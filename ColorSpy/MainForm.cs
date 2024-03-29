﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorSpy
{
	public partial class MainForm : Form
	{
		#region P/Invoke
		[DllImport ( "user32", SetLastError = true )]
		static extern IntPtr GetDC ( IntPtr hWnd );
		[DllImport ( "user32", SetLastError = true )]
		static extern int ReleaseDC ( IntPtr hWnd, IntPtr hDC );
		[DllImport ( "user32" )]
		static extern IntPtr GetDesktopWindow ();
		[DllImport ( "user32" )]
		static extern bool GetCursorPos ( out Point lpPoint );
		[DllImport ( "gdi32" )]
		static extern int GetPixel ( IntPtr hdc, int nXPos, int nYPos );
		#endregion

		private Color GetColorFromCursor ()
		{
			IntPtr hDC = GetDC ( IntPtr.Zero );
			if ( hDC == IntPtr.Zero )
				throw new Exception ();

			if ( !GetCursorPos ( out Point p ) )
				throw new Exception ();

			int c = GetPixel ( hDC, p.X, p.Y );
			if ( c == -1 )
				throw new Exception ();

			return Color.FromArgb ( ( c ) & 0xff, ( c >> 8 ) & 0xff, ( c >> 16 ) & 0xff );
		}

		private void GetYUVFromColor ( Color color, out int y, out int u, out int v )
		{
			int add128shift8 ( int v ) { return ( v + 128 ) >> 8; }
			byte saturate8(int v ) { return ( byte ) Math.Max ( Math.Min ( v, 255 ), 0 ); }
			byte rgb2y ( int r, int g, int b ) { return saturate8 ( add128shift8 ( ( 66 * r ) + ( 129 * g ) + ( 25 * b ) ) + 16 ); }
			byte rgb2u ( int r, int g, int b ) { return saturate8 ( add128shift8 ( ( -38 * r ) - ( 74 * g ) + ( 112 * b ) ) + 128 ); }
			byte rgb2v ( int r, int g, int b ) { return saturate8 ( add128shift8 ( ( 112 * r ) - ( 94 * g ) - ( 18 * b ) ) + 128 ); }

			y = rgb2y ( color.R, color.G, color.B );
			u = rgb2u ( color.R, color.G, color.B );
			v = rgb2v ( color.R, color.G, color.B );
		}

		private void GetHSVFromColor ( Color color, out int h, out int s, out int v )
		{
			byte r = color.R, g = color.G, b = color.B;

			byte rgbMin = r < g ? ( r < b ? r : b ) : ( g < b ? g : b ),
				rgbMax = r > g ? ( r > b ? r : b ) : ( g > b ? g : b );

			v = rgbMax;
			if ( v == 0 )
			{
				h = 0;
				s = 0;
				return;
			}

			s = 255 * ( rgbMax - rgbMin ) / v;
			if ( s == 0 )
			{
				h = 0;
				return;
			}

			if ( rgbMax == r ) h = 0 + 43 * ( g - b ) / ( rgbMax - rgbMin );
			else if ( rgbMax == g ) h = 85 + 43 * ( b - r ) / ( rgbMax - rgbMin );
			else h = 171 + 43 * ( r - g ) / ( rgbMax - rgbMin );
		}

		public MainForm ()
		{
			InitializeComponent ();
		}

		private async void MainForm_Shown ( object sender, EventArgs e )
		{
			await Task.Run ( () =>
			{
				while ( this.IsHandleCreated )
				{
					var color = GetColorFromCursor ();
					GetYUVFromColor ( color, out int y, out int u, out int v );
					GetHSVFromColor ( color, out int h, out int s, out int v2 );

					try
					{
						BeginInvoke ( new Action ( () =>
						{
							textBoxR.Text = color.R.ToString ();
							textBoxG.Text = color.G.ToString ();
							textBoxB.Text = color.B.ToString ();

							textBoxY.Text = y.ToString ();
							textBoxU.Text = u.ToString ();
							textBoxV.Text = v.ToString ();

							textBoxH.Text = h.ToString ();
							textBoxS.Text = s.ToString ();
							textBoxV2.Text = v2.ToString ();

							pictureBoxColor.BackColor = color;
						} ) ).AsyncWaitHandle.WaitOne ();
					}
					catch { }

					Thread.Sleep ( 0 );
				}
			} );
		}
	}
}
