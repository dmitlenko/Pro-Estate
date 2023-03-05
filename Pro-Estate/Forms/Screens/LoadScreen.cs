using Pro_Estate.Core.Database;
using Pro_Estate.Forms.Wizards;
using ReaLTaiizor.Forms;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace Pro_Estate.Forms
{
	public partial class LoadScreen : CrownForm
	{
		public ProEstateDatabase Database;
		public MainForm MainForm;
		public AuthForm AuthForm;
		public DatabaseWizard DatabaseWizard;

		public LoadScreen()
		{
			InitializeComponent();

			version.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
		}

		private string SplashText
		{
			set
			{
				statusText.Text = value;
				Application.DoEvents();
			}
		}

		private void SplashForm_Shown(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(Properties.Settings.Default.ConnectionString))
			{
				using (DatabaseWizard = new DatabaseWizard())
				{
					SplashText = "Створення бази даних...";

					DatabaseWizard.Load += (o, args) => Hide();
					DatabaseWizard.FormClosed += (o, args) => Show();

					if (DatabaseWizard.ShowDialog() != DialogResult.OK)
						Environment.Exit(1);
				}
			}

			SplashText = "Підключення бази даних...";
			Database = new ProEstateDatabase(Properties.Settings.Default.ConnectionString);
			if (Database.DatabaseExists()) Database.Connection.Open();

			SplashText = "Завантаження інтерфейсу...";
			MainForm = new MainForm(Database);

			SplashText = "Авторизація...";
			using (AuthForm = new AuthForm(Database))
			{
				AuthForm.Shown += (o, args) => Hide();

				if (AuthForm.ShowDialog() == DialogResult.OK)
				{
					MainForm.Account = AuthForm.Account;
					MainForm.InvokeLoad();
					MainForm.ShowDialog();
					Close();
				}
				else
				{
					Application.Exit();
				}
			}
		}
	}
}