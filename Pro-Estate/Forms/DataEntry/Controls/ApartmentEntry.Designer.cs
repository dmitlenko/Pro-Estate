using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	partial class ApartmentEntry<T>
		where T : Apartment, new()
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
			this.crownLabel2 = new ReaLTaiizor.Controls.CrownLabel();
			this.price = new ReaLTaiizor.Controls.CrownNumeric();
			this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
			this.square = new ReaLTaiizor.Controls.CrownNumeric();
			this.isresidental = new ReaLTaiizor.Controls.CrownCheckBox();
			this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
			this.lessee = new ReaLTaiizor.Controls.CrownComboBox();
			this.dateAdded = new System.Windows.Forms.DateTimePicker();
			this.crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
			this.crownLabel6 = new ReaLTaiizor.Controls.CrownLabel();
			this.name = new ReaLTaiizor.Controls.CrownTextBox();
			this.country = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
			this.crownLabel7 = new ReaLTaiizor.Controls.CrownLabel();
			this.state = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel8 = new ReaLTaiizor.Controls.CrownLabel();
			this.city = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel9 = new ReaLTaiizor.Controls.CrownLabel();
			this.street = new ReaLTaiizor.Controls.CrownTextBox();
			this.house = new ReaLTaiizor.Controls.CrownTextBox();
			this.crownLabel10 = new ReaLTaiizor.Controls.CrownLabel();
			this.rentPrice = new ReaLTaiizor.Controls.CrownNumeric();
			this.crownLabel11 = new ReaLTaiizor.Controls.CrownLabel();
			((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rentPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// crownLabel2
			// 
			this.crownLabel2.AutoSize = true;
			this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel2.Location = new System.Drawing.Point(0, 40);
			this.crownLabel2.Name = "crownLabel2";
			this.crownLabel2.Size = new System.Drawing.Size(32, 13);
			this.crownLabel2.TabIndex = 2;
			this.crownLabel2.Text = "Ціна:";
			// 
			// price
			// 
			this.price.DecimalPlaces = 2;
			this.price.Location = new System.Drawing.Point(0, 56);
			this.price.Name = "price";
			this.price.Size = new System.Drawing.Size(144, 20);
			this.price.TabIndex = 2;
			// 
			// crownLabel1
			// 
			this.crownLabel1.AutoSize = true;
			this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel1.Location = new System.Drawing.Point(304, 40);
			this.crownLabel1.Name = "crownLabel1";
			this.crownLabel1.Size = new System.Drawing.Size(45, 13);
			this.crownLabel1.TabIndex = 5;
			this.crownLabel1.Text = "Площа:";
			// 
			// square
			// 
			this.square.DecimalPlaces = 2;
			this.square.Location = new System.Drawing.Point(304, 56);
			this.square.Name = "square";
			this.square.Size = new System.Drawing.Size(144, 20);
			this.square.TabIndex = 3;
			this.square.ThousandsSeparator = true;
			// 
			// isresidental
			// 
			this.isresidental.Location = new System.Drawing.Point(304, 16);
			this.isresidental.Name = "isresidental";
			this.isresidental.Size = new System.Drawing.Size(144, 20);
			this.isresidental.TabIndex = 4;
			this.isresidental.Text = "Житлове?";
			// 
			// crownLabel4
			// 
			this.crownLabel4.AutoSize = true;
			this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel4.Location = new System.Drawing.Point(0, 0);
			this.crownLabel4.Name = "crownLabel4";
			this.crownLabel4.Size = new System.Drawing.Size(54, 13);
			this.crownLabel4.TabIndex = 10;
			this.crownLabel4.Text = "Орендар:";
			// 
			// lessee
			// 
			this.lessee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.lessee.FormattingEnabled = true;
			this.lessee.Location = new System.Drawing.Point(0, 16);
			this.lessee.Name = "lessee";
			this.lessee.Size = new System.Drawing.Size(144, 21);
			this.lessee.TabIndex = 0;
			// 
			// dateAdded
			// 
			this.dateAdded.Location = new System.Drawing.Point(0, 96);
			this.dateAdded.Name = "dateAdded";
			this.dateAdded.Size = new System.Drawing.Size(144, 20);
			this.dateAdded.TabIndex = 5;
			// 
			// crownLabel5
			// 
			this.crownLabel5.AutoSize = true;
			this.crownLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel5.Location = new System.Drawing.Point(0, 80);
			this.crownLabel5.Name = "crownLabel5";
			this.crownLabel5.Size = new System.Drawing.Size(93, 13);
			this.crownLabel5.TabIndex = 13;
			this.crownLabel5.Text = "Дата додавання:";
			// 
			// crownLabel6
			// 
			this.crownLabel6.AutoSize = true;
			this.crownLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel6.Location = new System.Drawing.Point(152, 0);
			this.crownLabel6.Name = "crownLabel6";
			this.crownLabel6.Size = new System.Drawing.Size(42, 13);
			this.crownLabel6.TabIndex = 14;
			this.crownLabel6.Text = "Назва:";
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
			// country
			// 
			this.country.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.country.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.country.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.country.Location = new System.Drawing.Point(152, 96);
			this.country.Name = "country";
			this.country.Size = new System.Drawing.Size(144, 20);
			this.country.TabIndex = 6;
			// 
			// crownLabel3
			// 
			this.crownLabel3.AutoSize = true;
			this.crownLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel3.Location = new System.Drawing.Point(152, 80);
			this.crownLabel3.Name = "crownLabel3";
			this.crownLabel3.Size = new System.Drawing.Size(44, 13);
			this.crownLabel3.TabIndex = 16;
			this.crownLabel3.Text = "Країна:";
			// 
			// crownLabel7
			// 
			this.crownLabel7.AutoSize = true;
			this.crownLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel7.Location = new System.Drawing.Point(304, 80);
			this.crownLabel7.Name = "crownLabel7";
			this.crownLabel7.Size = new System.Drawing.Size(53, 13);
			this.crownLabel7.TabIndex = 16;
			this.crownLabel7.Text = "Область:";
			// 
			// state
			// 
			this.state.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.state.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.state.Location = new System.Drawing.Point(304, 96);
			this.state.Name = "state";
			this.state.Size = new System.Drawing.Size(144, 20);
			this.state.TabIndex = 7;
			// 
			// crownLabel8
			// 
			this.crownLabel8.AutoSize = true;
			this.crownLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel8.Location = new System.Drawing.Point(0, 120);
			this.crownLabel8.Name = "crownLabel8";
			this.crownLabel8.Size = new System.Drawing.Size(38, 13);
			this.crownLabel8.TabIndex = 16;
			this.crownLabel8.Text = "Місто:";
			// 
			// city
			// 
			this.city.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.city.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.city.Location = new System.Drawing.Point(0, 136);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(144, 20);
			this.city.TabIndex = 8;
			// 
			// crownLabel9
			// 
			this.crownLabel9.AutoSize = true;
			this.crownLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel9.Location = new System.Drawing.Point(152, 120);
			this.crownLabel9.Name = "crownLabel9";
			this.crownLabel9.Size = new System.Drawing.Size(46, 13);
			this.crownLabel9.TabIndex = 16;
			this.crownLabel9.Text = "Вулиця:";
			// 
			// street
			// 
			this.street.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.street.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.street.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.street.Location = new System.Drawing.Point(152, 136);
			this.street.Name = "street";
			this.street.Size = new System.Drawing.Size(144, 20);
			this.street.TabIndex = 9;
			// 
			// house
			// 
			this.house.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.house.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.house.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.house.Location = new System.Drawing.Point(304, 136);
			this.house.Name = "house";
			this.house.Size = new System.Drawing.Size(144, 20);
			this.house.TabIndex = 10;
			// 
			// crownLabel10
			// 
			this.crownLabel10.AutoSize = true;
			this.crownLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel10.Location = new System.Drawing.Point(304, 120);
			this.crownLabel10.Name = "crownLabel10";
			this.crownLabel10.Size = new System.Drawing.Size(52, 13);
			this.crownLabel10.TabIndex = 18;
			this.crownLabel10.Text = "Будинок:";
			// 
			// rentPrice
			// 
			this.rentPrice.DecimalPlaces = 2;
			this.rentPrice.Location = new System.Drawing.Point(152, 56);
			this.rentPrice.Name = "rentPrice";
			this.rentPrice.Size = new System.Drawing.Size(144, 20);
			this.rentPrice.TabIndex = 19;
			// 
			// crownLabel11
			// 
			this.crownLabel11.AutoSize = true;
			this.crownLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel11.Location = new System.Drawing.Point(152, 40);
			this.crownLabel11.Name = "crownLabel11";
			this.crownLabel11.Size = new System.Drawing.Size(71, 13);
			this.crownLabel11.TabIndex = 20;
			this.crownLabel11.Text = "Ціна оренди:";
			// 
			// ApartmentEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.rentPrice);
			this.Controls.Add(this.crownLabel11);
			this.Controls.Add(this.house);
			this.Controls.Add(this.crownLabel10);
			this.Controls.Add(this.street);
			this.Controls.Add(this.crownLabel9);
			this.Controls.Add(this.city);
			this.Controls.Add(this.crownLabel8);
			this.Controls.Add(this.state);
			this.Controls.Add(this.crownLabel7);
			this.Controls.Add(this.country);
			this.Controls.Add(this.crownLabel3);
			this.Controls.Add(this.name);
			this.Controls.Add(this.crownLabel6);
			this.Controls.Add(this.crownLabel5);
			this.Controls.Add(this.dateAdded);
			this.Controls.Add(this.lessee);
			this.Controls.Add(this.crownLabel4);
			this.Controls.Add(this.isresidental);
			this.Controls.Add(this.square);
			this.Controls.Add(this.crownLabel1);
			this.Controls.Add(this.price);
			this.Controls.Add(this.crownLabel2);
			this.Name = "ApartmentEntry";
			this.Size = new System.Drawing.Size(448, 160);
			((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rentPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ReaLTaiizor.Controls.CrownLabel crownLabel2;
		private ReaLTaiizor.Controls.CrownNumeric price;
		private ReaLTaiizor.Controls.CrownLabel crownLabel1;
		private ReaLTaiizor.Controls.CrownNumeric square;
		private ReaLTaiizor.Controls.CrownCheckBox isresidental;
		private ReaLTaiizor.Controls.CrownLabel crownLabel4;
		private ReaLTaiizor.Controls.CrownComboBox lessee;
		private System.Windows.Forms.DateTimePicker dateAdded;
		private ReaLTaiizor.Controls.CrownLabel crownLabel5;
		private ReaLTaiizor.Controls.CrownLabel crownLabel6;
		private ReaLTaiizor.Controls.CrownTextBox name;
		private ReaLTaiizor.Controls.CrownTextBox country;
		private ReaLTaiizor.Controls.CrownLabel crownLabel3;
		private ReaLTaiizor.Controls.CrownLabel crownLabel7;
		private ReaLTaiizor.Controls.CrownTextBox state;
		private ReaLTaiizor.Controls.CrownLabel crownLabel8;
		private ReaLTaiizor.Controls.CrownTextBox city;
		private ReaLTaiizor.Controls.CrownLabel crownLabel9;
		private ReaLTaiizor.Controls.CrownTextBox street;
		private ReaLTaiizor.Controls.CrownTextBox house;
		private ReaLTaiizor.Controls.CrownLabel crownLabel10;
		private ReaLTaiizor.Controls.CrownNumeric rentPrice;
		private ReaLTaiizor.Controls.CrownLabel crownLabel11;
	}
}
