using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	partial class RequirementEntry<T>
		where T : Requirement, new()
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
			this.square = new ReaLTaiizor.Controls.CrownNumeric();
			this.crownLabel1 = new ReaLTaiizor.Controls.CrownLabel();
			this.minPrice = new ReaLTaiizor.Controls.CrownNumeric();
			this.maxPrice = new ReaLTaiizor.Controls.CrownNumeric();
			this.crownLabel3 = new ReaLTaiizor.Controls.CrownLabel();
			this.isresidental = new ReaLTaiizor.Controls.CrownCheckBox();
			this.crownLabel4 = new ReaLTaiizor.Controls.CrownLabel();
			this.client = new ReaLTaiizor.Controls.CrownComboBox();
			this.dateAdded = new System.Windows.Forms.DateTimePicker();
			this.crownLabel5 = new ReaLTaiizor.Controls.CrownLabel();
			((System.ComponentModel.ISupportInitialize)(this.square)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.minPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.maxPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// crownLabel2
			// 
			this.crownLabel2.AutoSize = true;
			this.crownLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel2.Location = new System.Drawing.Point(0, 40);
			this.crownLabel2.Name = "crownLabel2";
			this.crownLabel2.Size = new System.Drawing.Size(45, 13);
			this.crownLabel2.TabIndex = 2;
			this.crownLabel2.Text = "Площа:";
			// 
			// square
			// 
			this.square.DecimalPlaces = 2;
			this.square.Location = new System.Drawing.Point(0, 56);
			this.square.Name = "square";
			this.square.Size = new System.Drawing.Size(144, 20);
			this.square.TabIndex = 1;
			// 
			// crownLabel1
			// 
			this.crownLabel1.AutoSize = true;
			this.crownLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel1.Location = new System.Drawing.Point(152, 40);
			this.crownLabel1.Name = "crownLabel1";
			this.crownLabel1.Size = new System.Drawing.Size(90, 13);
			this.crownLabel1.TabIndex = 5;
			this.crownLabel1.Text = "Мінімальна ціна:";
			// 
			// minPrice
			// 
			this.minPrice.DecimalPlaces = 2;
			this.minPrice.Location = new System.Drawing.Point(152, 56);
			this.minPrice.Name = "minPrice";
			this.minPrice.Size = new System.Drawing.Size(144, 20);
			this.minPrice.TabIndex = 2;
			this.minPrice.ThousandsSeparator = true;
			this.minPrice.ValueChanged += new System.EventHandler(this.minPrice_ValueChanged);
			// 
			// maxPrice
			// 
			this.maxPrice.DecimalPlaces = 2;
			this.maxPrice.Location = new System.Drawing.Point(304, 56);
			this.maxPrice.Name = "maxPrice";
			this.maxPrice.Size = new System.Drawing.Size(144, 20);
			this.maxPrice.TabIndex = 3;
			this.maxPrice.ThousandsSeparator = true;
			// 
			// crownLabel3
			// 
			this.crownLabel3.AutoSize = true;
			this.crownLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel3.Location = new System.Drawing.Point(304, 40);
			this.crownLabel3.Name = "crownLabel3";
			this.crownLabel3.Size = new System.Drawing.Size(104, 13);
			this.crownLabel3.TabIndex = 8;
			this.crownLabel3.Text = "Максимальна ціна:";
			// 
			// isresidental
			// 
			this.isresidental.AutoSize = true;
			this.isresidental.Location = new System.Drawing.Point(0, 96);
			this.isresidental.Name = "isresidental";
			this.isresidental.Size = new System.Drawing.Size(78, 17);
			this.isresidental.TabIndex = 4;
			this.isresidental.Text = "Житлове?";
			// 
			// crownLabel4
			// 
			this.crownLabel4.AutoSize = true;
			this.crownLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel4.Location = new System.Drawing.Point(0, 0);
			this.crownLabel4.Name = "crownLabel4";
			this.crownLabel4.Size = new System.Drawing.Size(42, 13);
			this.crownLabel4.TabIndex = 10;
			this.crownLabel4.Text = "Клієнт:";
			// 
			// client
			// 
			this.client.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.client.FormattingEnabled = true;
			this.client.Location = new System.Drawing.Point(0, 16);
			this.client.Name = "client";
			this.client.Size = new System.Drawing.Size(448, 21);
			this.client.TabIndex = 0;
			// 
			// dateAdded
			// 
			this.dateAdded.Location = new System.Drawing.Point(152, 96);
			this.dateAdded.Name = "dateAdded";
			this.dateAdded.Size = new System.Drawing.Size(144, 20);
			this.dateAdded.TabIndex = 5;
			// 
			// crownLabel5
			// 
			this.crownLabel5.AutoSize = true;
			this.crownLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownLabel5.Location = new System.Drawing.Point(152, 80);
			this.crownLabel5.Name = "crownLabel5";
			this.crownLabel5.Size = new System.Drawing.Size(93, 13);
			this.crownLabel5.TabIndex = 13;
			this.crownLabel5.Text = "Дата додавання:";
			// 
			// RequirementEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.Controls.Add(this.crownLabel5);
			this.Controls.Add(this.dateAdded);
			this.Controls.Add(this.client);
			this.Controls.Add(this.crownLabel4);
			this.Controls.Add(this.isresidental);
			this.Controls.Add(this.crownLabel3);
			this.Controls.Add(this.maxPrice);
			this.Controls.Add(this.minPrice);
			this.Controls.Add(this.crownLabel1);
			this.Controls.Add(this.square);
			this.Controls.Add(this.crownLabel2);
			this.Name = "RequirementEntry";
			this.Size = new System.Drawing.Size(448, 120);
			((System.ComponentModel.ISupportInitialize)(this.square)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.minPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.maxPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private ReaLTaiizor.Controls.CrownLabel crownLabel2;
		private ReaLTaiizor.Controls.CrownNumeric square;
		private ReaLTaiizor.Controls.CrownLabel crownLabel1;
		private ReaLTaiizor.Controls.CrownNumeric minPrice;
		private ReaLTaiizor.Controls.CrownNumeric maxPrice;
		private ReaLTaiizor.Controls.CrownLabel crownLabel3;
		private ReaLTaiizor.Controls.CrownCheckBox isresidental;
		private ReaLTaiizor.Controls.CrownLabel crownLabel4;
		private ReaLTaiizor.Controls.CrownComboBox client;
		private System.Windows.Forms.DateTimePicker dateAdded;
		private ReaLTaiizor.Controls.CrownLabel crownLabel5;
	}
}
