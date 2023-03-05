using System.Data.Linq;

namespace Pro_Estate.Core.Database.Base
{
	public abstract class ATableQuery<T> : ABaseQuery where T : class
	{
		public abstract Table<T> Table { get; }

		public abstract QueryResult<T> FetchResult();
	}
}