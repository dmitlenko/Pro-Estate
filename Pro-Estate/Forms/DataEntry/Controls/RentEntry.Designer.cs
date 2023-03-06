using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	partial class RentEntry<T>
		where T : Rent, new()
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
			this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
			this.apartment = new ReaLTaiizor.Controls.CrownComboBox();
			this.startDate = new System.Windows.Forms.DateTimePicker();
			this.crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
			this.client = new ReaLTaiizor.Controls.CrownComboBox();
			this.crownLabel6 = new ReaLTaiizor.Controls.CrownLabel();
			this.crownLabel7 = new ReaLTaiizor.Controls.CrownLabel();
			this.endDate = new System.Windows.Forms.DateTimePicker();
			this.employee = new ReaLTaiizor.Controls.CrownComboBox();
			this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
			((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
			this.SuspendLayout();
			// 
			// crownLabel2
			// 
			this.crownLabel2.AutoSize = true;
			this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel2.Location = new System.Drawing.Point(304, 80);
			this.crownLabel2.Name = "crownLabel2";
			this.crownLabel2.Size = new System.Drawing.Size(32, 13);
			this.crownLabel2.TabIndex = 2;
			this.crownLabel2.Text = "Ціна:";
			// 
			// price
			// 
			this.price.DecimalPlaces = 2;
			this.price.Enabled = false;
			this.price.Location = new System.Drawing.Point(304, 96);
			this.price.Name = "price";
			this.price.ReadOnly = true;
			this.price.Size = new System.Drawing.Size(144, 20);
			this.price.TabIndex = 2;
			// 
			// crownLabel4
			// 
			this.crownLabel4.AutoSize = true;
			this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel4.Location = new System.Drawing.Point(0, 0);
			this.crownLabel4.Name = "crownLabel4";
			this.crownLabel4.Size = new System.Drawing.Size(73, 13);
			this.crownLabel4.TabIndex = 10;
			this.crownLabel4.Text = "Приміщення:";
			// 
			// apartment
			// 
			this.apartment.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.apartment.FormattingEnabled = true;
			this.apartment.Location = new System.Drawing.Point(0, 16);
			this.apartment.Name = "apartment";
			this.apartment.Size = new System.Drawing.Size(448, 21);
			this.apartment.TabIndex = 0;
			this.apartment.SelectedIndexChanged += new System.EventHandler(this.apartment_SelectedIndexChanged);
			// 
			// startDate
			// 
			this.startDate.Location = new System.Drawing.Point(0, 96);
			this.startDate.Name = "startDate";
			this.startDate.Size = new System.Drawing.Size(144, 20);
			this.startDate.TabIndex = 5;
			this.startDate.ValueChanged += new System.EventHandler(this.startDate_ValueChanged);
			// 
			// crownLabel5
			// 
			this.crownLabel5.AutoSize = true;
			this.crownLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel5.Location = new System.Drawing.Point(0, 80);
			this.crownLabel5.Name = "crownLabel5";
			this.crownLabel5.Size = new System.Drawing.Size(78, 13);
			this.crownLabel5.TabIndex = 13;
			this.crownLabel5.Text = "Дата початку:";
			// 
			// client
			// 
			this.client.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.client.FormattingEnabled = true;
			this.client.Location = new System.Drawing.Point(0, 56);
			this.client.Name = "client";
			this.client.Size = new System.Drawing.Size(296, 21);
			this.client.TabIndex = 19;
			// 
			// crownLabel6
			// 
			this.crownLabel6.AutoSize = true;
			this.crownLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel6.Location = new System.Drawing.Point(0, 40);
			this.crownLabel6.Name = "crownLabel6";
			this.crownLabel6.Size = new System.Drawing.Size(42, 13);
			this.crownLabel6.TabIndex = 20;
			this.crownLabel6.Text = "Клієнт:";
			// 
			// crownLabel7
			// 
			this.crownLabel7.AutoSize = true;
			this.crownLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel7.Location = new System.Drawing.Point(152, 80);
			this.crownLabel7.Name = "crownLabel7";
			this.crownLabel7.Size = new System.Drawing.Size(65, 13);
			this.crownLabel7.TabIndex = 22;
			this.crownLabel7.Text = "Дата кінця:";
			// 
			// endDate
			// 
			this.endDate.Location = new System.Drawing.Point(152, 96);
			this.endDate.Name = "endDate";
			this.endDate.Size = new System.Drawing.Size(144, 20);
			this.endDate.TabIndex = 21;
			this.endDate.ValueChanged += new System.EventHandler(this.endDate_ValueChanged);
			// 
			// employee
			// 
			this.employee.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.employee.FormattingEnabled = true;
			this.employee.Location = new System.Drawing.Point(304, 56);
			this.employee.Name = "employee";
			this.employee.Size = new System.Drawing.Size(144, 21);
			this.employee.TabIndex = 23;
			// 
			// crownLabel1
			// 
			this.crownLabel1.AutoSize = true;
			this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel1.Location = new System.Drawing.Point(304, 40);
			this.crownLabel1.Name = "crownLabel1";
			this.crownLabel1.Size = new System.Drawing.Size(62, 13);
			this.crownLabel1.TabIndex = 24;
			this.crownLabel1.Text = "Працівник:";
			// 
			// RentEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.crownLabel1);
			this.Controls.Add(this.employee);
			this.Controls.Add(this.crownLabel7);
			this.Controls.Add(this.endDate);
			this.Controls.Add(this.client);
			this.Controls.Add(this.crownLabel6);
			this.Controls.Add(this.crownLabel5);
			this.Controls.Add(this.startDate);
			this.Controls.Add(this.apartment);
			this.Controls.Add(this.crownLabel4);
			this.Controls.Add(this.price);
			this.Controls.Add(this.crownLabel2);
			this.Name = "RentEntry";
			this.Size = new System.Drawing.Size(448, 120);
			((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ReaLTaiizor.Controls.CrownLabel crownLabel2;
		private ReaLTaiizor.Controls.CrownNumeric price;
		private ReaLTaiizor.Controls.CrownLabel crownLabel4;
		private ReaLTaiizor.Controls.CrownComboBox apartment;
		private System.Windows.Forms.DateTimePicker startDate;
		private ReaLTaiizor.Controls.CrownLabel crownLabel5;
		private ReaLTaiizor.Controls.CrownComboBox client;
		private ReaLTaiizor.Controls.CrownLabel crownLabel6;
		private ReaLTaiizor.Controls.CrownLabel crownLabel7;
		private System.Windows.Forms.DateTimePicker endDate;
		private ReaLTaiizor.Controls.CrownComboBox employee;
		private ReaLTaiizor.Controls.CrownLabel crownLabel1;
	}
}
