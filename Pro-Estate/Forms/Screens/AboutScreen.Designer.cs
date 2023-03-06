namespace Pro_Estate.Forms.Screens
{
	partial class AboutScreen
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
			this.version = new ReaLTaiizor.Controls.CrownLabel();
			this.statusText = new System.Windows.Forms.Label();
			this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
			this.SuspendLayout();
			// 
			// version
			// 
			this.version.BackColor = System.Drawing.Color.Transparent;
			this.version.ForeColor = System.Drawing.Color.Black;
			this.version.Location = new System.Drawing.Point(232, 264);
			this.version.Name = "version";
			this.version.Size = new System.Drawing.Size(168, 16);
			this.version.TabIndex = 8;
			this.version.Text = "Pro-Estate v";
			this.version.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// statusText
			// 
			this.statusText.AutoSize = true;
			this.statusText.BackColor = System.Drawing.Color.Transparent;
			this.statusText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.statusText.Location = new System.Drawing.Point(32, 176);
			this.statusText.Name = "statusText";
			this.statusText.Size = new System.Drawing.Size(175, 65);
			this.statusText.TabIndex = 9;
			this.statusText.Text = "Програма була створена \r\nстудентом ФКЗЕ ім. Є.О. Патона\r\nМітленком Денисом\r\n\r\ndmi" +
    "tlenko (c) 2023";
			// 
			// crownButton1
			// 
			this.crownButton1.Location = new System.Drawing.Point(32, 248);
			this.crownButton1.Name = "crownButton1";
			this.crownButton1.Padding = new System.Windows.Forms.Padding(5);
			this.crownButton1.Size = new System.Drawing.Size(176, 23);
			this.crownButton1.TabIndex = 10;
			this.crownButton1.Text = "OK";
			this.crownButton1.Click += new System.EventHandler(this.crownButton1_Click);
			// 
			// AboutScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pro_Estate.Properties.Resources.pro_estate;
			this.ClientSize = new System.Drawing.Size(400, 280);
			this.Controls.Add(this.crownButton1);
			this.Controls.Add(this.statusText);
			this.Controls.Add(this.version);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AboutScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AboutScreen";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ReaLTaiizor.Controls.CrownLabel version;
		private System.Windows.Forms.Label statusText;
		private ReaLTaiizor.Controls.CrownButton crownButton1;
	}
}