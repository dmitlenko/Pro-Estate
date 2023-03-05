using Pro_Estate.Core.Database.Tables;
using System.Drawing;

namespace Pro_Estate.Core.Database.Base
{
	public abstract class ABaseQuery
	{
		

		public ProEstateDatabase Database { get; set; }
		public abstract string Description { get; }
		public abstract Bitmap Icon { get; }
		public abstract string Name { get; }

		public virtual bool Editable { get => true; }
		public virtual bool Createable { get => true; }
		public virtual bool Deleteble { get => true; }

		public virtual AccountLevel MinViewLevel { get => AccountLevel.Customer; }
		public virtual AccountLevel MinEditLevel { get => AccountLevel.Employee; }
		public virtual AccountLevel MinCreateLevel { get => AccountLevel.Employee; }
		public virtual AccountLevel MinDeleteLevel { get => AccountLevel.Employee; }
	}
}