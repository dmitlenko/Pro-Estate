namespace Pro_Estate.Forms.Main.Docking
{
	partial class DockAccount
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
			this.profilePicture = new System.Windows.Forms.PictureBox();
			this.userName = new ReaLTaiizor.Controls.CrownLabel();
			this.role = new ReaLTaiizor.Controls.CrownLabel();
			((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
			this.SuspendLayout();
			// 
			// profilePicture
			// 
			this.profilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.profilePicture.Location = new System.Drawing.Point(8, 32);
			this.profilePicture.Name = "profilePicture";
			this.profilePicture.Size = new System.Drawing.Size(56, 56);
			this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.profilePicture.TabIndex = 0;
			this.profilePicture.TabStop = false;
			// 
			// userName
			// 
			this.userName.AutoSize = true;
			this.userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.userName.Location = new System.Drawing.Point(72, 32);
			this.userName.Name = "userName";
			this.userName.Size = new System.Drawing.Size(92, 18);
			this.userName.TabIndex = 1;
			this.userName.Text = "crownLabel1";
			// 
			// role
			// 
			this.role.AutoSize = true;
			this.role.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.role.Location = new System.Drawing.Point(72, 56);
			this.role.Name = "role";
			this.role.Size = new System.Drawing.Size(68, 13);
			this.role.TabIndex = 3;
			this.role.Text = "crownLabel1";
			// 
			// DockAccount
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.role);
			this.Controls.Add(this.userName);
			this.Controls.Add(this.profilePicture);
			this.DefaultDockArea = ReaLTaiizor.Enum.Crown.DockArea.Left;
			this.DockText = "Обліковий запис";
			this.Icon = global::Pro_Estate.Properties.Resources.user_green;
			this.Name = "DockAccount";
			this.Size = new System.Drawing.Size(264, 241);
			((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox profilePicture;
		private ReaLTaiizor.Controls.CrownLabel userName;
		private ReaLTaiizor.Controls.CrownLabel role;
	}
}
