using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Enum.Crown;
using ReaLTaiizor.Forms;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Estate.Forms.Wizards
{
	public partial class DatabaseWizard : CrownForm
	{
		public DatabaseWizard()
		{
			InitializeComponent();
		}

		private void createButton_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(password1.Text) && !string.IsNullOrEmpty(password2.Text)
				&& password1.Text == password2.Text && password1.Text.Length >= 8
				&& CrownMessageBox.ShowInformation("Ви дійсно хочете створити нову базу даних?", "Створеня бази даних", DialogButton.YesNo) == DialogResult.Yes)
			{
				string filename = pathTextBox.Text;

				Enabled = false;

				Task.Factory.StartNew(() =>
				{
					ProEstateDatabase db = new ProEstateDatabase(filename);

					if (db.DatabaseExists())
					{
						db.DeleteDatabase();
						db.SubmitChanges();
					}

					db.CreateDatabase();

					db.Accounts.InsertOnSubmit(Account.Generate("admin", password1.Text, AccountLevel.Admin));
					db.SubmitChanges();

					Properties.Settings.Default["ConnectionString"] = DatabaseHelper.ConstructConnectionString(filename);
					Properties.Settings.Default.Save();

					db.Dispose();
				}).ContinueWith(_ => Invoke(new Action(() =>
				{
					Enabled = true;

					CrownMessageBox.ShowInformation($@"Базу даних було успішно створено. Щоб авторизуватись як адміністратор використовуйте наступні дані:{Environment.NewLine}  ім'я користувача: admin{Environment.NewLine}  пароль:{password1.Text}", @"Успішно!"); ;

					DialogResult = DialogResult.OK;
					Close();
				})));
			}
			else
			{
				CrownMessageBox.ShowError(@"Паролі не співпадають або мають неправильний формат.", @"Помилка!");
			}
		}

		private void openButton_Click(object sender, System.EventArgs e)
		{
			if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				pathTextBox.Text = saveFileDialog.FileName;
				createButton.Enabled = true;
			}
		}

		private void password1_TextChanged(object sender, System.EventArgs e)
		{
			passwordLengthLabel.Visible = password1.Text.Length < 8;
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}