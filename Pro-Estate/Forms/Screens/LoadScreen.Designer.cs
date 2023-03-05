namespace Pro_Estate.Forms
{
	partial class LoadScreen
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
			this.statusText = new System.Windows.Forms.Label();
			this.version = new ReaLTaiizor.Controls.CrownLabel();
			this.SuspendLayout();
			// 
			// statusText
			// 
			this.statusText.AutoSize = true;
			this.statusText.BackColor = System.Drawing.Color.Transparent;
			this.statusText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.statusText.Location = new System.Drawing.Point(32, 232);
			this.statusText.Name = "statusText";
			this.statusText.Size = new System.Drawing.Size(35, 13);
			this.statusText.TabIndex = 0;
			this.statusText.Text = "label1";
			// 
			// version
			// 
			this.version.BackColor = System.Drawing.Color.Transparent;
			this.version.ForeColor = System.Drawing.Color.Black;
			this.version.Location = new System.Drawing.Point(232, 264);
			this.version.Name = "version";
			this.version.Size = new System.Drawing.Size(168, 16);
			this.version.TabIndex = 7;
			this.version.Text = "Pro-Estate v";
			this.version.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// LoadScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pro_Estate.Properties.Resources.pro_estate;
			this.ClientSize = new System.Drawing.Size(400, 280);
			this.Controls.Add(this.version);
			this.Controls.Add(this.statusText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoadScreen";
			this.ShowInTaskbar = false;
			this.Text = "SplashScreen";
			this.TopMost = true;
			this.Shown += new System.EventHandler(this.SplashForm_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label statusText;
		private ReaLTaiizor.Controls.CrownLabel version;
	}
}