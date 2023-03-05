using Pro_Estate.Forms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Pro_Estate
{
	internal static class Program
	{
		private static void CultureFix()
		{
			CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
			culture.DateTimeFormat.ShortDatePattern = "dd.MM.yyyy";
			culture.DateTimeFormat.LongTimePattern = "";
			Thread.CurrentThread.CurrentCulture = culture;
		}

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			CultureFix();
#if DEBUG
			Application.Run(new LoadScreen());
#else
			try
			{
				Application.Run(new LoadScreen());
			}
			catch (Exception ex)
			{
				using (ExceptionScreen form = new ExceptionScreen(ex.Message, $"{ex.Message}{Environment.NewLine}{ex.StackTrace}"))
				{
					form.FormClosed += (o, _) => Application.Exit();
					form.ShowDialog();
				}
			}
#endif
		}
	}
}