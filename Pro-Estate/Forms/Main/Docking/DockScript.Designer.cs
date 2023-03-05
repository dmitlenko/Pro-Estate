namespace Pro_Estate.Forms.Main.Docking
{
	partial class DockScript
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.scriptName = new ReaLTaiizor.Controls.CrownLabel();
			this.executeButton = new ReaLTaiizor.Controls.CrownButton();
			this.scriptDescription = new ReaLTaiizor.Controls.CrownLabel();
			this.scriptIcon = new System.Windows.Forms.PictureBox();
			this.controlsPanel = new System.Windows.Forms.FlowLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.scriptIcon)).BeginInit();
			this.SuspendLayout();
			// 
			// scriptName
			// 
			this.scriptName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.scriptName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.scriptName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.scriptName.Location = new System.Drawing.Point(40, 8);
			this.scriptName.Name = "scriptName";
			this.scriptName.Size = new System.Drawing.Size(328, 32);
			this.scriptName.TabIndex = 0;
			this.scriptName.Text = "crownLabel1";
			// 
			// executeButton
			// 
			this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.executeButton.Location = new System.Drawing.Point(200, 248);
			this.executeButton.Name = "executeButton";
			this.executeButton.Padding = new System.Windows.Forms.Padding(5);
			this.executeButton.Size = new System.Drawing.Size(192, 23);
			this.executeButton.TabIndex = 1;
			this.executeButton.Text = "Виконати";
			this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
			// 
			// scriptDescription
			// 
			this.scriptDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.scriptDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.scriptDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.scriptDescription.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.scriptDescription.Location = new System.Drawing.Point(40, 40);
			this.scriptDescription.Name = "scriptDescription";
			this.scriptDescription.Size = new System.Drawing.Size(352, 96);
			this.scriptDescription.TabIndex = 2;
			this.scriptDescription.Text = "crownLabel1";
			// 
			// scriptIcon
			// 
			this.scriptIcon.Location = new System.Drawing.Point(8, 8);
			this.scriptIcon.Name = "scriptIcon";
			this.scriptIcon.Size = new System.Drawing.Size(32, 32);
			this.scriptIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.scriptIcon.TabIndex = 3;
			this.scriptIcon.TabStop = false;
			// 
			// controlsPanel
			// 
			this.controlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.controlsPanel.BackColor = System.Drawing.Color.Transparent;
			this.controlsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.controlsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.controlsPanel.Location = new System.Drawing.Point(8, 144);
			this.controlsPanel.Name = "controlsPanel";
			this.controlsPanel.Padding = new System.Windows.Forms.Padding(8);
			this.controlsPanel.Size = new System.Drawing.Size(384, 96);
			this.controlsPanel.TabIndex = 5;
			// 
			// DockScript
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.controlsPanel);
			this.Controls.Add(this.scriptIcon);
			this.Controls.Add(this.scriptDescription);
			this.Controls.Add(this.executeButton);
			this.Controls.Add(this.scriptName);
			this.Name = "DockScript";
			this.Size = new System.Drawing.Size(400, 280);
			((System.ComponentModel.ISupportInitialize)(this.scriptIcon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private ReaLTaiizor.Controls.CrownLabel scriptName;
		private ReaLTaiizor.Controls.CrownButton executeButton;
		private ReaLTaiizor.Controls.CrownLabel scriptDescription;
		private System.Windows.Forms.PictureBox scriptIcon;
		private System.Windows.Forms.FlowLayoutPanel controlsPanel;
	}
}
