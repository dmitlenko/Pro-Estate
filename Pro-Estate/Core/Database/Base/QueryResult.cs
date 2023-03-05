using System.Collections.Generic;
using System.Data;

namespace Pro_Estate.Core.Database.Base
{
	public class QueryResult<T>
		where T : class
	{
		public DataTable DataTable { get; private set; }
		public IEnumerable<T> Values { get; private set; }
		public ATableQuery<T> Query { get; private set; }

		public QueryResult(DataTable dataTable, IEnumerable<T> values, ATableQuery<T> query)
		{
			DataTable = dataTable;
			Values = values;
			Query = query;
		}
	}
}