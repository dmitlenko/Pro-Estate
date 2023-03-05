using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Tables;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System.Linq;

namespace Pro_Estate.Forms
{
	public partial class AuthForm : CrownForm
	{
		private ProEstateDatabase Database;

		public Account Account { get; private set; }

		public AuthForm(ProEstateDatabase proEstateDatabase)
		{
			InitializeComponent();

			Database = proEstateDatabase;
		}

		private void crownButton1_Click(object sender, System.EventArgs e)
		{
			var passwordHash = Account.Hash(password.Text);
			Account = Database.Accounts.SingleOrDefault(a => a.UserName == username.Text && a.PasswordHash == passwordHash);

			if (Account == null || Account == default(Account))
			{
				CrownMessageBox.ShowError(@"Користувач не існує або дані введені неправильно.", @"Помилка!");
				return;
			}

			DialogResult = System.Windows.Forms.DialogResult.OK;
			Close();
		}

		private void crownButton2_Click(object sender, System.EventArgs e)
		{
			Close();
		}
	}
}