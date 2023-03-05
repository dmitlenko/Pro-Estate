namespace Pro_Estate.Forms
{
	partial class ExceptionScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
			this.crownButton2 = new ReaLTaiizor.Controls.CrownButton();
			this.crownTextBox1 = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
			this.SuspendLayout();
			// 
			// crownButton1
			// 
			this.crownButton1.Location = new System.Drawing.Point(408, 320);
			this.crownButton1.Name = "crownButton1";
			this.crownButton1.Padding = new System.Windows.Forms.Padding(5);
			this.crownButton1.Size = new System.Drawing.Size(176, 23);
			this.crownButton1.TabIndex = 0;
			this.crownButton1.Text = "OK";
			this.crownButton1.Click += new System.EventHandler(this.crownButton1_Click);
			// 
			// crownButton2
			// 
			this.crownButton2.Location = new System.Drawing.Point(296, 320);
			this.crownButton2.Name = "crownButton2";
			this.crownButton2.Padding = new System.Windows.Forms.Padding(5);
			this.crownButton2.Size = new System.Drawing.Size(104, 23);
			this.crownButton2.TabIndex = 1;
			this.crownButton2.Text = "Copy";
			this.crownButton2.Click += new System.EventHandler(this.crownButton2_Click);
			// 
			// crownTextBox1
			// 
			this.crownTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.crownTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.crownTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownTextBox1.Location = new System.Drawing.Point(8, 32);
			this.crownTextBox1.Multiline = true;
			this.crownTextBox1.Name = "crownTextBox1";
			this.crownTextBox1.Size = new System.Drawing.Size(576, 280);
			this.crownTextBox1.TabIndex = 2;
			// 
			// crownLabel1
			// 
			this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel1.Location = new System.Drawing.Point(8, 8);
			this.crownLabel1.Name = "crownLabel1";
			this.crownLabel1.Size = new System.Drawing.Size(576, 16);
			this.crownLabel1.TabIndex = 3;
			this.crownLabel1.Text = "An unexpected error happened:";
			// 
			// ExceptionScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(592, 352);
			this.Controls.Add(this.crownLabel1);
			this.Controls.Add(this.crownTextBox1);
			this.Controls.Add(this.crownButton2);
			this.Controls.Add(this.crownButton1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ExceptionScreen";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ExceptionScreen";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ReaLTaiizor.Controls.CrownButton crownButton1;
		private ReaLTaiizor.Controls.CrownButton crownButton2;
		private ReaLTaiizor.Controls.CrownTextBox crownTextBox1;
		private ReaLTaiizor.Controls.CrownLabel crownLabel1;
	}
}