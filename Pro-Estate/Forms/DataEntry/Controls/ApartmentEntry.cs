using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using ReaLTaiizor.Extension;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	public partial class ApartmentEntry<T> : UserControl, IEntryData<T>
		where T : Apartment, IIdentifable, new()
	{
		private ProEstateDatabase Database { get; set; }
		private T Value { get; set; }

		public ApartmentEntry(ProEstateDatabase database, T item)
		{
			InitializeComponent();

			Database = database;
			Value = item;

			PrepareFields();

			if (item != null)
			{
				lessee.SelectedItem = Value.Lessee;
				name.Text = Value.Name;
				price.Value = (decimal)Value.Price;
				rentPrice.Value = (decimal)Value.RentPrice;
				square.Value = (decimal)Value.Square;
				dateAdded.Value = Value.DateAdded;
				country.Text = Value.Country;
				state.Text = Value.State;
				city.Text = Value.City;
				street.Text = Value.Street;
				house.Text = Value.House;
				isresidental.Checked = Value.IsResidential;
			}
		}

		private void PrepareFields()
		{
			lessee.Items.AddRange(Database.Lessees.ToArray());
			price.Maximum = int.MaxValue;
			rentPrice.Maximum = int.MaxValue;
			square.Maximum = int.MaxValue;
			dateAdded.MaxDate = DateTime.Now;
		}

		public T GetValue()
		{
			Value.Lessee = lessee.SelectedItem as Lessee;
			Value.Name = name.Text;
			Value.Price = (double)price.Value;
			Value.Square = (double)square.Value;
			Value.RentPrice = (double)rentPrice.Value;
			Value.DateAdded = dateAdded.Value;
			Value.Country = country.Text;
			Value.State = state.Text;
			Value.City = city.Text;
			Value.Street = street.Text;
			Value.House = house.Text;
			Value.IsResidential = isresidental.Checked;

			return Value;
		}

		public bool CheckFields()
		{
			if (lessee.SelectedItem == null) return false;
			if (CheckHelper.IsAnyEmpty(name, country, state, city, street, house)) return false;

			return true;
		}
	}
}