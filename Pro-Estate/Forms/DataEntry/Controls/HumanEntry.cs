using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System;
using System.Windows.Forms;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	public partial class HumanEntry<T> : UserControl, IEntryData<T>
		where T : class, IHumanData, IIdentifable, new()
	{
		private ProEstateDatabase Database { get; set; }
		private T Value { get; set; }

		public HumanEntry(ProEstateDatabase database, T item)
		{
			InitializeComponent();

			Database = database;
			Value = item;

			if (item != null)
			{
				PassportData passportData = Value.PassportData;
				surname.Text = Value.Surname;
				name.Text = Value.Name;
				patronymic.Text = Value.Patronymic;
				phone.Text = Value.Phone;
				email.Text = Value.Email;

				if (passportData != null)
				{
					gender.SelectedItem = passportData.Gender;
					birthDate.Value = passportData.BirthDate;
					country.Text = passportData.Country;
					state.Text = passportData.State;
					city.Text = passportData.City;
					street.Text = passportData.Street;
					house.Text = passportData.House;
				} else
				{
					Value.PassportData = new PassportData();
				}
			}
		}

		public T GetValue()
		{
			Value.Surname = surname.Text;
			Value.Name = name.Text;
			Value.Patronymic = patronymic.Text;
			Value.Phone = phone.Text;
			Value.Email = email.Text;
			Value.PassportData.Gender = gender.SelectedItem.ToString();
			Value.PassportData.BirthDate = birthDate.Value;
			Value.PassportData.Country = country.Text;
			Value.PassportData.State = state.Text;
			Value.PassportData.City = city.Text;
			Value.PassportData.Street = street.Text;
			Value.PassportData.House = house.Text;

			return Value;
		}

		public bool CheckFields()
		{
			if (CheckHelper.IsAnyEmpty(surname, name, patronymic, country, state, city, street, house)) return false;
			if (!CheckHelper.IsValidEmail(email.Text)) return false;
			if (!phone.MaskFull) return false;
			if (gender.SelectedIndex < 0) return false;
			if (birthDate.Value == DateTime.Now) return false;

			return true;
		}
	}
}