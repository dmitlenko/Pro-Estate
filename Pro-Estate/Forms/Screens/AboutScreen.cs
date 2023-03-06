using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Estate.Forms.Screens
{
	public partial class AboutScreen : Form
	{
		public AboutScreen()
		{
			InitializeComponent();

			version.Text += Assembly.GetExecutingAssembly().GetName().Version.ToString();
			
		}

		private void crownButton1_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
