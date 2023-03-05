using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Tables
{
	public class CustomersTable : ATableQuery<Customer>
	{
		
		public override Bitmap Icon { get => Properties.Resources.users_5; }
		public override string Name { get => "Клієнти"; }
		public override string Description { get => "Запит надає список всіх клієнтів в базі даних."; }

		public override Table<Customer> Table => Database.Customers;

		public override AccountLevel MinViewLevel => AccountLevel.Employee;
		public override AccountLevel MinEditLevel => AccountLevel.Employee;
		public override AccountLevel MinCreateLevel => AccountLevel.Employee;
		public override AccountLevel MinDeleteLevel => AccountLevel.Employee;

		public override QueryResult<Customer> FetchResult()
		{
			var values = GetValues();
			return new QueryResult<Customer>(DatabaseHelper.LINQResultToDataTable(values), values, this);
		}

		private IQueryable<Customer> GetValues()
		{
			return from a in Database.Customers select a;
		}
	}
}