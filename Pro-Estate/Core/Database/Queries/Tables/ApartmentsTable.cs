using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Tables
{
	public class ApartmentsTable : ATableQuery<Apartment>
	{
		
		public override Bitmap Icon { get => Properties.Resources.building; }
		public override string Name { get => "Приміщення"; }
		public override string Description { get => "Запит надає список всіх приміщень в базі даних"; }

		public override Table<Apartment> Table => Database.Apartments;

		public override AccountLevel MinViewLevel => AccountLevel.Customer;
		public override AccountLevel MinEditLevel => AccountLevel.Employee;
		public override AccountLevel MinCreateLevel => AccountLevel.Lessor;

		private IQueryable<Apartment> GetValues()
		{
			return from a in Database.Apartments select a;
		}

		public override QueryResult<Apartment> FetchResult()
		{
			var values = GetValues();
			return new QueryResult<Apartment>(DatabaseHelper.LINQResultToDataTable(values), values, this);
		}
	}
}