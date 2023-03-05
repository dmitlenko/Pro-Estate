using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	public partial class SellEntry<T> : UserControl, IEntryData<T>
		where T : Sell, IIdentifable, new()
	{
		private ProEstateDatabase Database { get; set; }
		private T Value { get; set; }

		public SellEntry(ProEstateDatabase database, T item)
		{
			InitializeComponent();

			Database = database;
			Value = item;

			PrepareFields();

			if (item != null)
			{
				client.SelectedItem = Value.Client;
				apartment.SelectedItem = Value.Apartment;
				employee.SelectedItem = Value.Employee;
				price.Value = (decimal)Value.Price;
				startDate.Value = Value.Date;
			}
		}

		private void PrepareFields()
		{
			apartment.Items.AddRange(Database.Apartments.ToArray());
			client.Items.AddRange(Database.Customers.ToArray());
			employee.Items.AddRange(Database.Employees.ToArray());
			price.Maximum = int.MaxValue;
		}

		private void CalculatePrice()
		{
			if (apartment.SelectedItem != null)
				price.Value = (decimal)(apartment.SelectedItem as Apartment).Price;
		}

		public T GetValue()
		{
			Value.Client = client.SelectedItem as Customer;
			Value.Apartment = apartment.SelectedItem as Apartment;
			Value.Employee = employee.SelectedItem as Employee;
			Value.Price = (double)price.Value;
			Value.Date = startDate.Value;

			return Value;
		}

		public bool CheckFields()
		{
			if (apartment.SelectedItem == null) return false;
			if (client.SelectedItem == null) return false;
			if (employee.SelectedItem == null) return false;
			if (Database.Sells.Any(x => x.Apartment == apartment.SelectedItem && x.Client == client.SelectedItem)) return false;

			return true;
		}

		private void apartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalculatePrice();
		}
	}
}