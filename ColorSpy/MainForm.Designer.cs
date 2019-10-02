namespace ColorSpy
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose ();
			}
			base.Dispose ( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxR = new System.Windows.Forms.TextBox();
			this.textBoxG = new System.Windows.Forms.TextBox();
			this.textBoxB = new System.Windows.Forms.TextBox();
			this.textBoxY = new System.Windows.Forms.TextBox();
			this.textBoxU = new System.Windows.Forms.TextBox();
			this.textBoxV = new System.Windows.Forms.TextBox();
			this.pictureBoxColor = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "R:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(17, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(18, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "G:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(17, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 15);
			this.label3.TabIndex = 0;
			this.label3.Text = "B:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(137, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(18, 15);
			this.label4.TabIndex = 0;
			this.label4.Text = "V:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(137, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(18, 15);
			this.label5.TabIndex = 0;
			this.label5.Text = "U:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(137, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(17, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "Y:";
			// 
			// textBoxR
			// 
			this.textBoxR.Location = new System.Drawing.Point(40, 13);
			this.textBoxR.Name = "textBoxR";
			this.textBoxR.ReadOnly = true;
			this.textBoxR.Size = new System.Drawing.Size(76, 23);
			this.textBoxR.TabIndex = 1;
			// 
			// textBoxG
			// 
			this.textBoxG.Location = new System.Drawing.Point(40, 44);
			this.textBoxG.Name = "textBoxG";
			this.textBoxG.ReadOnly = true;
			this.textBoxG.Size = new System.Drawing.Size(76, 23);
			this.textBoxG.TabIndex = 1;
			// 
			// textBoxB
			// 
			this.textBoxB.Location = new System.Drawing.Point(40, 75);
			this.textBoxB.Name = "textBoxB";
			this.textBoxB.ReadOnly = true;
			this.textBoxB.Size = new System.Drawing.Size(76, 23);
			this.textBoxB.TabIndex = 1;
			// 
			// textBoxY
			// 
			this.textBoxY.Location = new System.Drawing.Point(160, 13);
			this.textBoxY.Name = "textBoxY";
			this.textBoxY.ReadOnly = true;
			this.textBoxY.Size = new System.Drawing.Size(76, 23);
			this.textBoxY.TabIndex = 1;
			// 
			// textBoxU
			// 
			this.textBoxU.Location = new System.Drawing.Point(160, 44);
			this.textBoxU.Name = "textBoxU";
			this.textBoxU.ReadOnly = true;
			this.textBoxU.Size = new System.Drawing.Size(76, 23);
			this.textBoxU.TabIndex = 1;
			// 
			// textBoxV
			// 
			this.textBoxV.Location = new System.Drawing.Point(160, 75);
			this.textBoxV.Name = "textBoxV";
			this.textBoxV.ReadOnly = true;
			this.textBoxV.Size = new System.Drawing.Size(76, 23);
			this.textBoxV.TabIndex = 1;
			// 
			// pictureBoxColor
			// 
			this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxColor.Location = new System.Drawing.Point(16, 107);
			this.pictureBoxColor.Name = "pictureBoxColor";
			this.pictureBoxColor.Size = new System.Drawing.Size(220, 19);
			this.pictureBoxColor.TabIndex = 2;
			this.pictureBoxColor.TabStop = false;
			// 
			// MainForm
			// 
			this.ClientSize = new System.Drawing.Size(257, 140);
			this.Controls.Add(this.pictureBoxColor);
			this.Controls.Add(this.textBoxR);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBoxG);
			this.Controls.Add(this.textBoxB);
			this.Controls.Add(this.textBoxY);
			this.Controls.Add(this.textBoxU);
			this.Controls.Add(this.textBoxV);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.Text = "Color Spy";
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBoxR;
		private System.Windows.Forms.TextBox textBoxG;
		private System.Windows.Forms.TextBox textBoxB;
		private System.Windows.Forms.TextBox textBoxY;
		private System.Windows.Forms.TextBox textBoxU;
		private System.Windows.Forms.TextBox textBoxV;
		private System.Windows.Forms.PictureBox pictureBoxColor;
	}
}

