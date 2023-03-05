using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	public partial class AccountEntry<T> : UserControl, IEntryData<T>
		where T : Account
	{
		private ProEstateDatabase Database { get; set; }

		public AccountEntry(ProEstateDatabase database)
		{
			InitializeComponent();
			Database = database;
			level.Items.AddRange(Enum.GetNames(typeof(AccountLevel)));
		}

		public T GetValue()
		{
			return (T)Account.Generate(username.Text, password1.Text, (AccountLevel)level.SelectedIndex);
		}

		public bool CheckFields()
		{
			if (string.IsNullOrWhiteSpace(username.Text) || !Regex.IsMatch(username.Text, "^[a-zA-Z0-9]*$"))
				return false;

			if (Database.Accounts.Any(x => x.UserName == username.Text))
				return false;

			if (password1.Text != password2.Text)
				return false;

			if (string.IsNullOrWhiteSpace(password1.Text) || password1.Text.Length < 8 || password1.Text.Contains(' '))
				return false;

			if (level.SelectedIndex < 0)
				return false;

			return true;
		}
	}
}