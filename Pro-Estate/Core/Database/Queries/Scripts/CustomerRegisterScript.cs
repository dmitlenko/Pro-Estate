using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Docking.Crown;
using ReaLTaiizor.Enum.Crown;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Pro_Estate.Core.Database.Queries.Scripts
{
	public class CustomerRegisterScript : ABaseScript
	{
		private ControlCollection _collection = new ControlCollection(new System.Windows.Forms.Panel())
		{
			ScriptHelper.TextBox("surname","Прізвище"),
			ScriptHelper.TextBox("name","Ім'я"),
			ScriptHelper.TextBox("patronymic","По батькові"),
			ScriptHelper.MaskedTextBox("phone", "Телефон"),
			ScriptHelper.TextBox("email","Пошта"),
			ScriptHelper.ComboBox("gender","Стать"),
			ScriptHelper.DatePicker("birthDate","Дата народження"),
			ScriptHelper.TextBox("country","Країна"),
			ScriptHelper.TextBox("state","Область"),
			ScriptHelper.TextBox("city","Місто"),
			ScriptHelper.TextBox("street","Вулиця"),
			ScriptHelper.TextBox("house","Будинок"),
		};

		private CrownTextBox surname, name, patronymic, email, country, state, city, street, house;
		private CrownComboBox gender;
		private MaskedTextBox phone;
		private DateTimePicker birthDate;

		public CustomerRegisterScript(ProEstateDatabase database) : base(database)
		{
		}

		public override string Name => "Реєстрація клієнта";

		public override string Description => "Цей запит надає змогу створити новий обліковий запис клієнта.";

		public override Bitmap Icon => Properties.Resources.user_add;
		public override AccountLevel MinViewLevel => AccountLevel.Customer;
		public override ControlCollection Controls { get => _collection; set => _collection = value; }

		public override void Prepare()
		{
			surname = (CrownTextBox)_collection["surname"];
			name = (CrownTextBox)_collection["name"];
			patronymic = (CrownTextBox)_collection["patronymic"];
			email = (CrownTextBox)_collection["email"];
			phone = (MaskedTextBox)_collection["phone"];

			country = (CrownTextBox)_collection["country"];
			state = (CrownTextBox)_collection["state"];
			city = (CrownTextBox)_collection["city"];
			street = (CrownTextBox)_collection["street"];
			house = (CrownTextBox)_collection["house"];

			gender = (CrownComboBox)_collection["gender"];
			birthDate = (DateTimePicker)_collection["birthDate"];

			gender.Items.AddRange(new string[] { "Жіноча", "Чоловіча" });
			phone.Mask = "+38 (000) 000-00-00";
			phone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
			birthDate.MaxDate = DateTime.Today;
		}

		private bool CheckFields()
		{
			if (CheckHelper.IsAnyEmpty(surname, name, patronymic, country, state, city, street, house)) return false;
			if (!CheckHelper.IsValidEmail(email.Text)) return false;
			if (gender.SelectedItem == null) return false;
			if (!phone.MaskFull) return false;

			return true;
		}

		public override void Execute(params object[] list)
		{
			var document = list.First() as CrownDocument;

			if (CheckFields())
			{
				if (CrownMessageBox.ShowInformation("Перед створенням нового запису перевірте правильність введених даних. Ви дійсно хочете створити новий запис?", "Створення клієнта", DialogButton.YesNo) == DialogResult.No)
					return;

				document.Enabled = false;
				Database.Customers.InsertOnSubmit(new Customer
				{
					Surname = surname.Text,
					Name = name.Text,
					Patronymic = patronymic.Text,
					Email = email.Text,
					Phone = phone.Text,
					PassportData = new PassportData
					{
						BirthDate = birthDate.Value,
						Gender = gender.SelectedItem as string,
						Country = country.Text,
						State = state.Text,
						City = city.Text,
						Street = street.Text,
						House = house.Text,
					}
				});

				Database.SubmitChanges();
				CrownMessageBox.ShowInformation("Запис було успішно створено.", "Створення клієнта");
				document.Close();
			}
			else
				CrownMessageBox.ShowError("Введені невірні дані.", "Помилка!");
		}
	}
}