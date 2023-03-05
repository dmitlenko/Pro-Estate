using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Tables
{
	public class LessorsTable : ATableQuery<Lessee>
	{
		public override Bitmap Icon { get => Properties.Resources.user_suit; }
		public override string Name { get => "Орендодавці"; }
		public override string Description { get => "Запит надає список всіх орендодавців в базі даних."; }

		public override AccountLevel MinViewLevel => AccountLevel.Employee;
		public override AccountLevel MinEditLevel => AccountLevel.Admin;
		public override AccountLevel MinCreateLevel => AccountLevel.Admin;
		public override AccountLevel MinDeleteLevel => AccountLevel.Admin;

		public override Table<Lessee> Table => Database.Lessees;

		private IQueryable<Lessee> GetValues()
		{
			return from a in Database.Lessees select a;
		}

		public override QueryResult<Lessee> FetchResult()
		{
			var values = GetValues();
			return new QueryResult<Lessee>(DatabaseHelper.LINQResultToDataTable(values), values, this);
		}
	}
}