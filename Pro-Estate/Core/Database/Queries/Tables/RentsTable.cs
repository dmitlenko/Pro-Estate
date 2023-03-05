using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Tables
{
	public class RentsTable : ATableQuery<Rent>
	{
		public override Bitmap Icon { get => Properties.Resources.building_key; }
		public override string Name { get => "Оренди"; }
		public override string Description { get => "Запит надає список всіх оренд в базі даних."; }

		public override Table<Rent> Table => Database.Rents;

		public override AccountLevel MinViewLevel => AccountLevel.Employee;
		public override AccountLevel MinEditLevel => AccountLevel.Employee;
		public override AccountLevel MinCreateLevel => AccountLevel.Employee;
		public override AccountLevel MinDeleteLevel => AccountLevel.Employee;

		private IQueryable<Rent> GetValues()
		{
			return from a in Database.Rents select a;
		}

		public override QueryResult<Rent> FetchResult()
		{
			var values = GetValues();
			return new QueryResult<Rent>(DatabaseHelper.LINQResultToDataTable(values), values, this);
		}
	}
}