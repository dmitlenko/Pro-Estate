using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using Pro_Estate.Forms.DataEntry.Controls;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Crown;
using ReaLTaiizor.Forms;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Pro_Estate.Forms.DataEntry
{
	public partial class DataEntryForm<T> : CrownForm
		where T : class, IIdentifable
	{
		private EntryAction Action { get; set; }
		private T Value { get; set; }
		private ProEstateDatabase Database { get; set; }
		private UserControl EntryFields { get; set; }
		private IEntryData<T> EntryData => EntryFields as IEntryData<T>;
		private bool IsCreate => Action == EntryAction.Add;
		private bool IsSubmitted = false;

		public DataEntryForm(EntryAction action, T value, ProEstateDatabase database)
		{
			InitializeComponent();

			Action = action;
			Value = value;
			Database = database;
			Icon = Properties.Resources.table_add;

			switch (Value)
			{
				case Account item:
					EntryFields = new AccountEntry<Account>(Database);
					Text = "облікового запису";
					break;

				case Apartment item:
					EntryFields = new ApartmentEntry<Apartment>(Database, item);
					Text = "приміщення";
					break;

				case Customer item:
					EntryFields = new HumanEntry<Customer>(Database, item);
					Text = "клієнта";
					break;

				case Employee item:
					EntryFields = new HumanEntry<Employee>(Database, item);
					Text = "працівника";
					break;

				case Lessee item:
					EntryFields = new HumanEntry<Lessee>(Database, item);
					Text = "орендаря";
					break;

				case Requirement item:
					EntryFields = new RequirementEntry<Requirement>(Database, item);
					Text = "вимоги";
					break;

				case Rent item:
					EntryFields = new RentEntry<Rent>(Database, item);
					Text = "оренди";
					break;

				case Sell item:
					EntryFields = new SellEntry<Sell>(Database, item);
					Text = "продажу";
					break;

				default: break;
			}

			if (IsCreate)
			{
				Text = $"Створення {Text}";
				actionButton.Text = "Додати";
			}
			else
			{
				Text = $"Редагування {Text}";
				actionButton.Text = "Зберегти";
			}

			fieldsForm.Height = EntryFields.Height;
			fieldsForm.Width = EntryFields.Width;

			// Some magic numbers. I just calculated some paddings for the form
			Height = fieldsForm.Height + 88;
			Width = fieldsForm.Width + 32;

			fieldsForm.Controls.Add(EntryFields);
		}

		private void cancelButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void DataEntryForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (EntryData.CheckFields() && !IsSubmitted)
			{
				DialogResult result = CrownMessageBox.ShowWarning(@"Ви втратите всі незбережені зміни. Продовжити?", @"Закрити форму", DialogButton.YesNo);
				e.Cancel = result == DialogResult.No;
			}
		}

		private void actionButton_Click(object sender, EventArgs e)
		{
			if (!EntryData.CheckFields())
			{
				CrownMessageBox.ShowError("Введені невірні дані. Перевірте правильність введених даних.", "Помилка!");
				return;
			}

			if (IsCreate)
			{
				if (CrownMessageBox.ShowWarning(@"Ви дійсно хочете створити новий запис?", @"Створити новий запис", DialogButton.YesNo) == DialogResult.No)
					return;

				Database.GetTable<T>().InsertOnSubmit(EntryData.GetValue());
			}
			else
			{
				if (CrownMessageBox.ShowWarning(@"Ви дійсно хочете змінити цей запис?", @"Створити новий запис", DialogButton.YesNo) == DialogResult.No)
					return;

				T i1 = EntryData.GetValue();
				T i2 = Database.GetTable<T>().Single(et => et == Value);

				DatabaseHelper.CopyFields(i1, i2);

				Debug.Print(ToString());
			}

			Enabled = false;
			Database.SubmitChanges();
			Enabled = IsSubmitted = true;
			DialogResult = DialogResult.OK;
			Close();
		}
	}

	public enum EntryAction
	{
		Add,
		Edit
	}
}