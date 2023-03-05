using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	partial class HumanEntry<T>
		where T : class, IHumanData, IIdentifable, new()
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
			this.surname = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
			this.name = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
			this.patronymic = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
			this.crownLabel6 = new ReaLTaiizor.Controls.CrownLabel();
			this.phone = new System.Windows.Forms.MaskedTextBox();
			this.crownLabel7 = new ReaLTaiizor.Controls.CrownLabel();
			this.email = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
			this.gender = new ReaLTaiizor.Controls.CrownComboBox();
			this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
			this.birthDate = new System.Windows.Forms.DateTimePicker();
			this.crownLabel8 = new ReaLTaiizor.Controls.CrownLabel();
			this.country = new ReaLTaiizor.Controls.CrownTextBox();
			this.state = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel9 = new ReaLTaiizor.Controls.CrownLabel();
			this.city = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel10 = new ReaLTaiizor.Controls.CrownLabel();
			this.street = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel11 = new ReaLTaiizor.Controls.CrownLabel();
			this.house = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel12 = new ReaLTaiizor.Controls.CrownLabel();
			this.SuspendLayout();
			// 
			// surname
			// 
			this.surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.surname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.surname.Location = new System.Drawing.Point(0, 16);
			this.surname.Name = "surname";
			this.surname.Size = new System.Drawing.Size(144, 20);
			this.surname.TabIndex = 0;
			// 
			// crownLabel2
			// 
			this.crownLabel2.AutoSize = true;
			this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel2.Location = new System.Drawing.Point(0, 0);
			this.crownLabel2.Name = "crownLabel2";
			this.crownLabel2.Size = new System.Drawing.Size(59, 13);
			this.crownLabel2.TabIndex = 2;
			this.crownLabel2.Text = "Прізвище:";
			// 
			// name
			// 
			this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.name.Location = new System.Drawing.Point(152, 16);
			this.name.Name = "name";
			this.name.Size = new System.Drawing.Size(144, 20);
			this.name.TabIndex = 1;
			// 
			// crownLabel1
			// 
			this.crownLabel1.AutoSize = true;
			this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel1.Location = new System.Drawing.Point(152, 0);
			this.crownLabel1.Name = "crownLabel1";
			this.crownLabel1.Size = new System.Drawing.Size(29, 13);
			this.crownLabel1.TabIndex = 11;
			this.crownLabel1.Text = "Ім\'я:";
			// 
			// patronymic
			// 
			this.patronymic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.patronymic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.patronymic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.patronymic.Location = new System.Drawing.Point(304, 16);
			this.patronymic.Name = "patronymic";
			this.patronymic.Size = new System.Drawing.Size(144, 20);
			this.patronymic.TabIndex = 2;
			// 
			// crownLabel5
			// 
			this.crownLabel5.AutoSize = true;
			this.crownLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel5.Location = new System.Drawing.Point(304, 0);
			this.crownLabel5.Name = "crownLabel5";
			this.crownLabel5.Size = new System.Drawing.Size(70, 13);
			this.crownLabel5.TabIndex = 13;
			this.crownLabel5.Text = "По батькові:";
			// 
			// crownLabel6
			// 
			this.crownLabel6.AutoSize = true;
			this.crownLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel6.Location = new System.Drawing.Point(0, 40);
			this.crownLabel6.Name = "crownLabel6";
			this.crownLabel6.Size = new System.Drawing.Size(55, 13);
			this.crownLabel6.TabIndex = 15;
			this.crownLabel6.Text = "Телефон:";
			// 
			// phone
			// 
			this.phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.phone.ForeColor = System.Drawing.Color.Gainsboro;
			this.phone.Location = new System.Drawing.Point(0, 56);
			this.phone.Mask = "+38 (999) 000-0000";
			this.phone.Name = "phone";
			this.phone.Size = new System.Drawing.Size(144, 20);
			this.phone.TabIndex = 3;
			this.phone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			// 
			// crownLabel7
			// 
			this.crownLabel7.AutoSize = true;
			this.crownLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel7.Location = new System.Drawing.Point(152, 40);
			this.crownLabel7.Name = "crownLabel7";
			this.crownLabel7.Size = new System.Drawing.Size(43, 13);
			this.crownLabel7.TabIndex = 11;
			this.crownLabel7.Text = "Пошта:";
			// 
			// email
			// 
			this.email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.email.Location = new System.Drawing.Point(152, 56);
			this.email.Name = "email";
			this.email.Size = new System.Drawing.Size(144, 20);
			this.email.TabIndex = 4;
			// 
			// crownLabel4
			// 
			this.crownLabel4.AutoSize = true;
			this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel4.Location = new System.Drawing.Point(0, 80);
			this.crownLabel4.Name = "crownLabel4";
			this.crownLabel4.Size = new System.Drawing.Size(39, 13);
			this.crownLabel4.TabIndex = 22;
			this.crownLabel4.Text = "Стать:";
			// 
			// gender
			// 
			this.gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.gender.FormattingEnabled = true;
			this.gender.Items.AddRange(new object[] {
            "Жіноча",
            "Чоловіча"});
			this.gender.Location = new System.Drawing.Point(0, 96);
			this.gender.Name = "gender";
			this.gender.Size = new System.Drawing.Size(144, 21);
			this.gender.TabIndex = 6;
			// 
			// crownLabel3
			// 
			this.crownLabel3.AutoSize = true;
			this.crownLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel3.Location = new System.Drawing.Point(304, 40);
			this.crownLabel3.Name = "crownLabel3";
			this.crownLabel3.Size = new System.Drawing.Size(101, 13);
			this.crownLabel3.TabIndex = 20;
			this.crownLabel3.Text = "Дата народження:";
			// 
			// birthDate
			// 
			this.birthDate.CalendarForeColor = System.Drawing.Color.Gainsboro;
			this.birthDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.birthDate.Location = new System.Drawing.Point(304, 56);
			this.birthDate.Name = "birthDate";
			this.birthDate.Size = new System.Drawing.Size(144, 20);
			this.birthDate.TabIndex = 5;
			// 
			// crownLabel8
			// 
			this.crownLabel8.AutoSize = true;
			this.crownLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel8.Location = new System.Drawing.Point(152, 80);
			this.crownLabel8.Name = "crownLabel8";
			this.crownLabel8.Size = new System.Drawing.Size(44, 13);
			this.crownLabel8.TabIndex = 11;
			this.crownLabel8.Text = "Країна:";
			// 
			// country
			// 
			this.country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.country.Location = new System.Drawing.Point(152, 96);
			this.country.Name = "country";
			this.country.Size = new System.Drawing.Size(144, 20);
			this.country.TabIndex = 7;
			// 
			// state
			// 
			this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.state.Location = new System.Drawing.Point(304, 96);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(144, 20);
			this.state.TabIndex = 8;
			// 
			// crownLabel9
			// 
			this.crownLabel9.AutoSize = true;
			this.crownLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel9.Location = new System.Drawing.Point(304, 80);
			this.crownLabel9.Name = "crownLabel9";
			this.crownLabel9.Size = new System.Drawing.Size(53, 13);
			this.crownLabel9.TabIndex = 23;
			this.crownLabel9.Text = "Область:";
			// 
			// city
			// 
			this.city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.city.Location = new System.Drawing.Point(0, 136);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(144, 20);
			this.city.TabIndex = 9;
			// 
			// crownLabel10
			// 
			this.crownLabel10.AutoSize = true;
			this.crownLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel10.Location = new System.Drawing.Point(0, 120);
			this.crownLabel10.Name = "crownLabel10";
			this.crownLabel10.Size = new System.Drawing.Size(38, 13);
			this.crownLabel10.TabIndex = 25;
			this.crownLabel10.Text = "Місто:";
			// 
			// street
			// 
			this.street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.street.Location = new System.Drawing.Point(152, 136);
			this.street.Name = "street";
			this.street.Size = new System.Drawing.Size(144, 20);
			this.street.TabIndex = 10;
			// 
			// crownLabel11
			// 
			this.crownLabel11.AutoSize = true;
			this.crownLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel11.Location = new System.Drawing.Point(152, 120);
			this.crownLabel11.Name = "crownLabel11";
			this.crownLabel11.Size = new System.Drawing.Size(46, 13);
			this.crownLabel11.TabIndex = 27;
			this.crownLabel11.Text = "Вулиця:";
			// 
			// house
			// 
			this.house.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.house.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.house.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.house.Location = new System.Drawing.Point(304, 136);
			this.house.Name = "house";
			this.house.Size = new System.Drawing.Size(144, 20);
			this.house.TabIndex = 11;
			// 
			// crownLabel12
			// 
			this.crownLabel12.AutoSize = true;
			this.crownLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel12.Location = new System.Drawing.Point(304, 120);
			this.crownLabel12.Name = "crownLabel12";
			this.crownLabel12.Size = new System.Drawing.Size(52, 13);
			this.crownLabel12.TabIndex = 29;
			this.crownLabel12.Text = "Будинок:";
			// 
			// HumanEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.house);
			this.Controls.Add(this.crownLabel12);
			this.Controls.Add(this.street);
			this.Controls.Add(this.crownLabel11);
			this.Controls.Add(this.city);
			this.Controls.Add(this.crownLabel10);
			this.Controls.Add(this.state);
			this.Controls.Add(this.crownLabel9);
			this.Controls.Add(this.crownLabel4);
			this.Controls.Add(this.gender);
			this.Controls.Add(this.crownLabel3);
			this.Controls.Add(this.birthDate);
			this.Controls.Add(this.phone);
			this.Controls.Add(this.crownLabel6);
			this.Controls.Add(this.patronymic);
			this.Controls.Add(this.crownLabel5);
			this.Controls.Add(this.country);
			this.Controls.Add(this.crownLabel8);
			this.Controls.Add(this.email);
			this.Controls.Add(this.crownLabel7);
			this.Controls.Add(this.name);
			this.Controls.Add(this.crownLabel1);
			this.Controls.Add(this.surname);
			this.Controls.Add(this.crownLabel2);
			this.Name = "HumanEntry";
			this.Size = new System.Drawing.Size(448, 160);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ReaLTaiizor.Controls.CrownTextBox surname;
		private ReaLTaiizor.Controls.CrownLabel crownLabel2;
		private ReaLTaiizor.Controls.CrownTextBox name;
		private ReaLTaiizor.Controls.CrownLabel crownLabel1;
		private ReaLTaiizor.Controls.CrownTextBox patronymic;
		private ReaLTaiizor.Controls.CrownLabel crownLabel5;
		private ReaLTaiizor.Controls.CrownLabel crownLabel6;
		private System.Windows.Forms.MaskedTextBox phone;
		private ReaLTaiizor.Controls.CrownLabel crownLabel7;
		private ReaLTaiizor.Controls.CrownTextBox email;
		private ReaLTaiizor.Controls.CrownLabel crownLabel4;
		private ReaLTaiizor.Controls.CrownComboBox gender;
		private ReaLTaiizor.Controls.CrownLabel crownLabel3;
		private System.Windows.Forms.DateTimePicker birthDate;
		private ReaLTaiizor.Controls.CrownLabel crownLabel8;
		private ReaLTaiizor.Controls.CrownTextBox country;
		private ReaLTaiizor.Controls.CrownTextBox state;
		private ReaLTaiizor.Controls.CrownLabel crownLabel9;
		private ReaLTaiizor.Controls.CrownTextBox city;
		private ReaLTaiizor.Controls.CrownLabel crownLabel10;
		private ReaLTaiizor.Controls.CrownTextBox street;
		private ReaLTaiizor.Controls.CrownLabel crownLabel11;
		private ReaLTaiizor.Controls.CrownTextBox house;
		private ReaLTaiizor.Controls.CrownLabel crownLabel12;
	}
}
