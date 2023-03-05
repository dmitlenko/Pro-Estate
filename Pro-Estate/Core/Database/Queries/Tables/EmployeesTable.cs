using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Tables
{
	public class EmployeesTable : ATableQuery<Employee>
	{
		
		public override Bitmap Icon { get => Properties.Resources.user_orange; }
		public override string Name { get => "Працівники"; }
		public override string Description { get => "Запит надає список всіх працівників в базі даних."; }

		public override AccountLevel MinViewLevel => AccountLevel.Employee;
		public override AccountLevel MinEditLevel => AccountLevel.Admin;
		public override AccountLevel MinCreateLevel => AccountLevel.Admin;
		public override AccountLevel MinDeleteLevel => AccountLevel.Admin;

		private IQueryable<Employee> GetValues()
		{
			return from a in Database.Employees select a;
		}

		public override QueryResult<Employee> FetchResult()
		{
			var values = GetValues();
			return new QueryResult<Employee>(DatabaseHelper.LINQResultToDataTable(values), values, this);
		}

		public override Table<Employee> Table => Database.Employees;
	}
}