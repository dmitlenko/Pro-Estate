using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Tables
{
	public class SellsTable : ATableQuery<Sell>
	{
		public override Bitmap Icon { get => Properties.Resources.domain_buying_selling; }
		public override string Name { get => "Продажі"; }
		public override string Description { get => "Запит надає список всіх продаж в базі даних."; }

		public override Table<Sell> Table => Database.Sells;
		public override AccountLevel MinViewLevel => AccountLevel.Employee;
		public override AccountLevel MinEditLevel => AccountLevel.Employee;
		public override AccountLevel MinCreateLevel => AccountLevel.Employee;
		public override AccountLevel MinDeleteLevel => AccountLevel.Employee;

		private IQueryable<Sell> GetValues()
		{
			return from a in Database.Sells select a;
		}

		public override QueryResult<Sell> FetchResult()
		{
			var values = GetValues();
			return new QueryResult<Sell>(DatabaseHelper.LINQResultToDataTable(values), values, this);
		}
	}
}