using Pro_Estate.Core.Database.Tables;
using ReaLTaiizor.Docking.Crown;

namespace Pro_Estate.Forms.Main.Docking
{
	public partial class DockAccount : CrownToolWindow
	{
		private Account account;

		public DockAccount(Account account)
		{
			InitializeComponent();

			this.account = account;

			userName.Text = "@" + account.UserName;
			role.Text = "Роль: " + account.Level.ToString();

			LoadImage();
		}

		private void LoadImage()
		{
			switch (account.Level)
			{
				case AccountLevel.None:
					profilePicture.Image = null;
					break;

				case AccountLevel.Customer:
					profilePicture.Image = Properties.Resources.img_customer;
					break;

				case AccountLevel.Employee:
					profilePicture.Image = Properties.Resources.img_employee;
					break;

				case AccountLevel.Lessee:
					profilePicture.Image = Properties.Resources.img_lessee;
					break;

				case AccountLevel.Admin:
					profilePicture.Image = Properties.Resources.img_admin;
					break;
			}
		}

		private void crownButton2_Click(object sender, System.EventArgs e)
		{
		}
	}
}