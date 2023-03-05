namespace Pro_Estate.Forms.Wizards
{
	partial class DatabaseWizard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseWizard));
			this.pathTextBox = new ReaLTaiizor.Controls.CrownTextBox();
			this.openButton = new ReaLTaiizor.Controls.CrownButton();
			this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
			this.password1 = new ReaLTaiizor.Controls.CrownTextBox();
			this.password2 = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
			this.createButton = new ReaLTaiizor.Controls.CrownButton();
			this.closeButton = new ReaLTaiizor.Controls.CrownButton();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.passwordLengthLabel = new ReaLTaiizor.Controls.CrownLabel();
			this.SuspendLayout();
			// 
			// pathTextBox
			// 
			this.pathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.pathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.pathTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.pathTextBox.Location = new System.Drawing.Point(8, 8);
			this.pathTextBox.Name = "pathTextBox";
			this.pathTextBox.ReadOnly = true;
			this.pathTextBox.Size = new System.Drawing.Size(336, 24);
			this.pathTextBox.TabIndex = 0;
			// 
			// openButton
			// 
			this.openButton.Location = new System.Drawing.Point(352, 8);
			this.openButton.Name = "openButton";
			this.openButton.Padding = new System.Windows.Forms.Padding(5);
			this.openButton.Size = new System.Drawing.Size(144, 24);
			this.openButton.TabIndex = 1;
			this.openButton.Text = "Відкрити файл";
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// crownLabel1
			// 
			this.crownLabel1.AutoSize = true;
			this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel1.Location = new System.Drawing.Point(8, 40);
			this.crownLabel1.Name = "crownLabel1";
			this.crownLabel1.Size = new System.Drawing.Size(127, 13);
			this.crownLabel1.TabIndex = 2;
			this.crownLabel1.Text = "Пароль адміністратора:";
			// 
			// password1
			// 
			this.password1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.password1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.password1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.password1.Location = new System.Drawing.Point(8, 56);
			this.password1.Name = "password1";
			this.password1.Size = new System.Drawing.Size(240, 24);
			this.password1.TabIndex = 3;
			this.password1.TextChanged += new System.EventHandler(this.password1_TextChanged);
			// 
			// password2
			// 
			this.password2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.password2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.password2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.password2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.password2.Location = new System.Drawing.Point(256, 56);
			this.password2.Name = "password2";
			this.password2.Size = new System.Drawing.Size(240, 24);
			this.password2.TabIndex = 4;
			// 
			// crownLabel2
			// 
			this.crownLabel2.AutoSize = true;
			this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel2.Location = new System.Drawing.Point(256, 40);
			this.crownLabel2.Name = "crownLabel2";
			this.crownLabel2.Size = new System.Drawing.Size(103, 13);
			this.crownLabel2.TabIndex = 5;
			this.crownLabel2.Text = "Повторити пароль:";
			// 
			// createButton
			// 
			this.createButton.Enabled = false;
			this.createButton.Location = new System.Drawing.Point(352, 104);
			this.createButton.Name = "createButton";
			this.createButton.Padding = new System.Windows.Forms.Padding(5);
			this.createButton.Size = new System.Drawing.Size(144, 24);
			this.createButton.TabIndex = 6;
			this.createButton.Text = "Створити";
			this.createButton.Click += new System.EventHandler(this.createButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(8, 104);
			this.closeButton.Name = "closeButton";
			this.closeButton.Padding = new System.Windows.Forms.Padding(5);
			this.closeButton.Size = new System.Drawing.Size(144, 24);
			this.closeButton.TabIndex = 7;
			this.closeButton.Text = "Вийти";
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// saveFileDialog
			// 
			this.saveFileDialog.Filter = "Database files|*.mdf|All files|*.*";
			// 
			// passwordLengthLabel
			// 
			this.passwordLengthLabel.AutoSize = true;
			this.passwordLengthLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.passwordLengthLabel.Location = new System.Drawing.Point(8, 80);
			this.passwordLengthLabel.Name = "passwordLengthLabel";
			this.passwordLengthLabel.Size = new System.Drawing.Size(237, 13);
			this.passwordLengthLabel.TabIndex = 8;
			this.passwordLengthLabel.Text = "Пароль має бути більше 8 символі в довжині!";
			// 
			// DatabaseWizard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(504, 136);
			this.Controls.Add(this.passwordLengthLabel);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.createButton);
			this.Controls.Add(this.crownLabel2);
			this.Controls.Add(this.password2);
			this.Controls.Add(this.password1);
			this.Controls.Add(this.crownLabel1);
			this.Controls.Add(this.openButton);
			this.Controls.Add(this.pathTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DatabaseWizard";
			this.Text = "Створення нової бази даних";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ReaLTaiizor.Controls.CrownTextBox pathTextBox;
		private ReaLTaiizor.Controls.CrownButton openButton;
		private ReaLTaiizor.Controls.CrownLabel crownLabel1;
		private ReaLTaiizor.Controls.CrownTextBox password1;
		private ReaLTaiizor.Controls.CrownTextBox password2;
		private ReaLTaiizor.Controls.CrownLabel crownLabel2;
		private ReaLTaiizor.Controls.CrownButton createButton;
		private ReaLTaiizor.Controls.CrownButton closeButton;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private ReaLTaiizor.Controls.CrownLabel passwordLengthLabel;
	}
}