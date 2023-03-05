namespace Pro_Estate.Forms
{
	partial class AuthForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
			this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
			this.username = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownButton1 = new ReaLTaiizor.Controls.CrownButton();
			this.password = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
			this.crownButton2 = new ReaLTaiizor.Controls.CrownButton();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// crownLabel1
			// 
			this.crownLabel1.AutoSize = true;
			this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel1.Location = new System.Drawing.Point(120, 32);
			this.crownLabel1.Name = "crownLabel1";
			this.crownLabel1.Size = new System.Drawing.Size(95, 13);
			this.crownLabel1.TabIndex = 0;
			this.crownLabel1.Text = "Ім\'я користувача:";
			this.crownLabel1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// username
			// 
			this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.username.Location = new System.Drawing.Point(120, 48);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(232, 24);
			this.username.TabIndex = 1;
			// 
			// crownButton1
			// 
			this.crownButton1.Location = new System.Drawing.Point(240, 144);
			this.crownButton1.Name = "crownButton1";
			this.crownButton1.Padding = new System.Windows.Forms.Padding(5);
			this.crownButton1.Size = new System.Drawing.Size(112, 23);
			this.crownButton1.TabIndex = 3;
			this.crownButton1.Text = "Авторизуватись";
			this.crownButton1.Click += new System.EventHandler(this.crownButton1_Click);
			// 
			// password
			// 
			this.password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.password.Location = new System.Drawing.Point(120, 96);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(232, 24);
			this.password.TabIndex = 2;
			// 
			// crownLabel2
			// 
			this.crownLabel2.AutoSize = true;
			this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel2.Location = new System.Drawing.Point(120, 80);
			this.crownLabel2.Name = "crownLabel2";
			this.crownLabel2.Size = new System.Drawing.Size(48, 13);
			this.crownLabel2.TabIndex = 4;
			this.crownLabel2.Text = "Пароль:";
			this.crownLabel2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// crownButton2
			// 
			this.crownButton2.Location = new System.Drawing.Point(120, 144);
			this.crownButton2.Name = "crownButton2";
			this.crownButton2.Padding = new System.Windows.Forms.Padding(5);
			this.crownButton2.Size = new System.Drawing.Size(112, 23);
			this.crownButton2.TabIndex = 4;
			this.crownButton2.Text = "Скасувати";
			this.crownButton2.Click += new System.EventHandler(this.crownButton2_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pro_Estate.Properties.Resources.pro_estate_building;
			this.pictureBox1.Location = new System.Drawing.Point(72, -56);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(400, 280);
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// AuthForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(472, 224);
			this.Controls.Add(this.crownButton2);
			this.Controls.Add(this.crownLabel2);
			this.Controls.Add(this.password);
			this.Controls.Add(this.crownButton1);
			this.Controls.Add(this.username);
			this.Controls.Add(this.crownLabel1);
			this.Controls.Add(this.pictureBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AuthForm";
			this.ShowInTaskbar = false;
			this.Text = "Авторизація";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ReaLTaiizor.Controls.CrownLabel crownLabel1;
		private ReaLTaiizor.Controls.CrownTextBox username;
		private ReaLTaiizor.Controls.CrownButton crownButton1;
		private ReaLTaiizor.Controls.CrownTextBox password;
		private ReaLTaiizor.Controls.CrownLabel crownLabel2;
		private ReaLTaiizor.Controls.CrownButton crownButton2;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}