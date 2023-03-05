using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Tables
{
	public class RequirementsTable : ATableQuery<Requirement>
	{
		public override Bitmap Icon { get => Properties.Resources.text_list_bullets; }
		public override string Name { get => "Вимоги"; }
		public override string Description { get => "Запит надає список всіх вимог від клієнтів в базі даних."; }

		public override AccountLevel MinViewLevel => AccountLevel.Employee;
		public override AccountLevel MinEditLevel => AccountLevel.Employee;
		public override AccountLevel MinCreateLevel => AccountLevel.Employee;
		public override AccountLevel MinDeleteLevel => AccountLevel.Employee;
		public override Table<Requirement> Table => Database.Requirements;

		public IQueryable<Requirement> GetValues()
		{
			return from a in Database.Requirements select a;
		}

		public override QueryResult<Requirement> FetchResult()
		{
			var values = GetValues();
			return new QueryResult<Requirement>(DatabaseHelper.LINQResultToDataTable(values), values, this);
		}
	}
}