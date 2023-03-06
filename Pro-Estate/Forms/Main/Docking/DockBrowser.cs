using ReaLTaiizor.Docking.Crown;
using System;
using System.Drawing;

namespace Pro_Estate.Forms.Main.Docking
{
	public partial class DockBrowser : CrownDocument
	{
		public DockBrowser(string title, string html, Image icon = null, bool showSaveStrip = false, string url = null)
		{
			InitializeComponent();

			webBrowser.DocumentText = !string.IsNullOrEmpty(html) ? html : (Properties.Resources.pro_estate_report_head + Properties.Resources.pro_estate_body_empty);
			DockText = title;
			Icon = icon == null ? Properties.Resources.safari_browser : icon;
			if (url != null) webBrowser.Url = new Uri(url);

			toolStrip.Visible = showSaveStrip;
			webBrowser.IsWebBrowserContextMenuEnabled = false;
		}

		private void saveButton_Click(object sender, System.EventArgs e)
		{
			webBrowser.ShowSaveAsDialog();
		}

		private void printButton_Click(object sender, System.EventArgs e)
		{
			webBrowser.ShowPrintDialog();
		}
	}
}