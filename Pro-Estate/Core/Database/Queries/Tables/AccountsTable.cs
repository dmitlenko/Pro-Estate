using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Tables
{
	public class AccountsTable : ATableQuery<Account>
	{
		
		public override Bitmap Icon { get => Properties.Resources.user_green; }
		public override string Name { get => "Облікові записи"; }
		public override string Description { get => "Запит надає список всіх облікових записів в базі даних."; }

		private IQueryable<Account> GetValues()
		{
			return from a in Database.Accounts select a;
		}

		public override QueryResult<Account> FetchResult()
		{
			var values = GetValues();
			return new QueryResult<Account>(DatabaseHelper.LINQResultToDataTable(values), values, this);
		}

		public override AccountLevel MinViewLevel { get => AccountLevel.Admin; }

		public override bool Editable => false;

		public override Table<Account> Table => Database.Accounts;
	}
}