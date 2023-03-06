using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	public partial class RentEntry<T> : UserControl, IEntryData<T>
		where T : Rent, new()
	{
		private ProEstateDatabase Database { get; set; }
		private T Value { get; set; }

		public RentEntry(ProEstateDatabase database, T item)
		{
			InitializeComponent();

			Database = database;
			Value = item;

			PrepareFields();

			if (Database.Rents.Any(x => x == item))
			{
				client.SelectedItem = Value.Client;
				apartment.SelectedItem = Value.Apartment;
				employee.SelectedItem = Value.Employee;
				price.Value = (decimal)Value.Price;
				startDate.Value = Value.DateStart;
				endDate.MinDate = Value.DateStart.AddMonths(1).AddHours(-1);
				endDate.Value = Value.DateEnd;
			}

			PrepareDates();
		}

		private void PrepareDates()
		{
			
		}

		private void PrepareFields()
		{
			apartment.Items.AddRange(Database.Apartments.ToArray());
			client.Items.AddRange(Database.Customers.ToArray());
			employee.Items.AddRange(Database.Employees.ToArray());
			price.Maximum = int.MaxValue;
			endDate.MinDate = startDate.Value.AddMonths(1);
		}

		private void CalculatePrice()
		{
			int months = (endDate.Value.Month - startDate.Value.Month) + 12 * (endDate.Value.Year - startDate.Value.Year);

			if (apartment.SelectedItem != null)
				price.Value = (decimal)(months * (apartment.SelectedItem as Apartment).RentPrice);
		}

		public T GetValue()
		{
			Value.Client = client.SelectedItem as Customer;
			Value.Apartment = apartment.SelectedItem as Apartment;
			Value.Employee = employee.SelectedItem as Employee;
			Value.Price = (double)price.Value;
			Value.DateStart = startDate.Value;
			Value.DateEnd = endDate.Value;

			return Value;
		}

		public bool CheckFields()
		{
			if (apartment.SelectedItem == null) return false;
			if (client.SelectedItem == null) return false;
			if (employee.SelectedItem == null) return false;
			if (!Database.Rents.Any(x => x == Value))
				if (Database.Rents.Any(x => x.Apartment == apartment.SelectedItem && x.Client == client.SelectedItem && x.DateEnd >= DateTime.Now)) return false;

			return true;
		}

		private void startDate_ValueChanged(object sender, EventArgs e)
		{
			endDate.MinDate = startDate.Value.AddMonths(1);
			CalculatePrice();
		}

		private void apartment_SelectedIndexChanged(object sender, EventArgs e)
		{
			CalculatePrice();
		}

		private void endDate_ValueChanged(object sender, EventArgs e)
		{
			CalculatePrice();
		}
	}
}