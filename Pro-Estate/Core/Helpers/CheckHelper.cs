using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_Estate.Core.Helpers
{
	public class CheckHelper
	{
		public static bool IsValidEmail(string email)
		{
			var trimmedEmail = email.Trim();

			if (trimmedEmail.EndsWith("."))
			{
				return false; // suggested by @TK-421
			}
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == trimmedEmail;
			}
			catch
			{
				return false;
			}
		}

		public static bool IsAnyEmpty(params string[] strings)
		{
			return strings.Any(s => s.Length == 0 || string.IsNullOrWhiteSpace(s) || string.IsNullOrEmpty(s));
		}

		public static bool IsAnyEmpty(params TextBox[] boxes)
		{
			return IsAnyEmpty(boxes.Select(x => x.Text).ToArray());
		}
	}
}
