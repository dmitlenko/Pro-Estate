using System;
using System.Windows.Forms;

namespace Pro_Estate.Forms
{
	public partial class ExceptionScreen : Form
	{
		public ExceptionScreen(string title, string stackTrace)
		{
			InitializeComponent();

			crownLabel1.Text += title;
			crownTextBox1.Text = stackTrace;
		}

		private void crownButton1_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.OK;
			Close();
		}

		private void crownButton2_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(crownTextBox1.Text);
		}
	}
}