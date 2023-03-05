using Pro_Estate.Core.Database.Tables;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	partial class AccountEntry<T>
		where T : Account
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
			this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
			this.username = new ReaLTaiizor.Controls.CrownTextBox();
			this.password1 = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
			this.password2 = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
			this.level = new ReaLTaiizor.Controls.CrownComboBox();
			this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
			this.SuspendLayout();
			// 
			// crownLabel1
			// 
			this.crownLabel1.AutoSize = true;
			this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel1.Location = new System.Drawing.Point(0, 0);
			this.crownLabel1.Name = "crownLabel1";
			this.crownLabel1.Size = new System.Drawing.Size(95, 13);
			this.crownLabel1.TabIndex = 0;
			this.crownLabel1.Text = "Ім\'я користувача:";
			// 
			// username
			// 
			this.username.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.username.Location = new System.Drawing.Point(0, 16);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(296, 20);
			this.username.TabIndex = 1;
			// 
			// password1
			// 
			this.password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.password1.Location = new System.Drawing.Point(0, 56);
			this.password1.Name = "password1";
			this.password1.Size = new System.Drawing.Size(296, 20);
			this.password1.TabIndex = 3;
			// 
			// crownLabel2
			// 
			this.crownLabel2.AutoSize = true;
			this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel2.Location = new System.Drawing.Point(0, 40);
			this.crownLabel2.Name = "crownLabel2";
			this.crownLabel2.Size = new System.Drawing.Size(48, 13);
			this.crownLabel2.TabIndex = 2;
			this.crownLabel2.Text = "Пароль:";
			// 
			// password2
			// 
			this.password2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.password2.Location = new System.Drawing.Point(0, 96);
			this.password2.Name = "password2";
			this.password2.Size = new System.Drawing.Size(296, 20);
			this.password2.TabIndex = 5;
			// 
			// crownLabel3
			// 
			this.crownLabel3.AutoSize = true;
			this.crownLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel3.Location = new System.Drawing.Point(0, 80);
			this.crownLabel3.Name = "crownLabel3";
			this.crownLabel3.Size = new System.Drawing.Size(103, 13);
			this.crownLabel3.TabIndex = 4;
			this.crownLabel3.Text = "Повторити пароль:";
			// 
			// level
			// 
			this.level.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.level.FormattingEnabled = true;
			this.level.Location = new System.Drawing.Point(0, 136);
			this.level.Name = "level";
			this.level.Size = new System.Drawing.Size(296, 21);
			this.level.TabIndex = 7;
			// 
			// crownLabel4
			// 
			this.crownLabel4.AutoSize = true;
			this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel4.Location = new System.Drawing.Point(0, 120);
			this.crownLabel4.Name = "crownLabel4";
			this.crownLabel4.Size = new System.Drawing.Size(43, 13);
			this.crownLabel4.TabIndex = 8;
			this.crownLabel4.Text = "Рівень:";
			// 
			// AccountEntryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.crownLabel4);
			this.Controls.Add(this.level);
			this.Controls.Add(this.password2);
			this.Controls.Add(this.crownLabel3);
			this.Controls.Add(this.password1);
			this.Controls.Add(this.crownLabel2);
			this.Controls.Add(this.username);
			this.Controls.Add(this.crownLabel1);
			this.Name = "AccountEntryForm";
			this.Size = new System.Drawing.Size(296, 160);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ReaLTaiizor.Controls.CrownLabel crownLabel1;
		private ReaLTaiizor.Controls.CrownTextBox username;
		private ReaLTaiizor.Controls.CrownTextBox password1;
		private ReaLTaiizor.Controls.CrownLabel crownLabel2;
		private ReaLTaiizor.Controls.CrownTextBox password2;
		private ReaLTaiizor.Controls.CrownLabel crownLabel3;
		private ReaLTaiizor.Controls.CrownComboBox level;
		private ReaLTaiizor.Controls.CrownLabel crownLabel4;
	}
}
