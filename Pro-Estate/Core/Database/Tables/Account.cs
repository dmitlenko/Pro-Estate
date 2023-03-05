using Pro_Estate.Core.Database.Base;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Pro_Estate.Core.Database.Tables
{
	[Table(Name = "Account")]
	public class Account: IIdentifable
	{
		[Column(IsDbGenerated = true, IsPrimaryKey = true, CanBeNull = false)]
		public int Id { get; set; }

		[Column(DbType = "nvarchar(64)", CanBeNull = false)]
		public string PasswordHash { get; set; }

		[Column(DbType = "nvarchar(40)", CanBeNull = false)]
		public string UserName { get; set; }

		[Column(CanBeNull = false)]
		private int AccessLevel { get; set; }

		public static Account Generate(string username, string password, AccountLevel level)
		{
			return new Account
			{
				AccessLevel = (int)level,
				UserName = username,
				PasswordHash = Hash(password)
			};
		}

		public static string Hash(string password)
		{
			using (SHA256 sha = SHA256.Create())
			{
				return string.Concat(sha
					.ComputeHash(Encoding.UTF8.GetBytes(password))
					.Select(item => item.ToString("x2")));
			}
		}

		public AccountLevel Level
		{
			get
			{
				switch (AccessLevel)
				{
					case 0:
						return AccountLevel.None;

					case 1:
						return AccountLevel.Customer;

					case 2:
						return AccountLevel.Lessor;

					case 3:
						return AccountLevel.Employee;

					case 4:
						return AccountLevel.Admin;

					default:
						return AccountLevel.None;
				}
			}
		}
	}

	public enum AccountLevel
	{
		None = 0,
		Customer = 1,
		Lessor = 2,
		Employee = 3,
		Admin = 4
	}
}