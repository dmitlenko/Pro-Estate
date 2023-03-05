using Pro_Estate.Core.Database.Base;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Pro_Estate.Core.Database.Tables
{
	[Table(Name = "Customer")]
	public class Customer : IIdentifable, IHumanData
	{
		private EntityRef<PassportData> _passportData = new EntityRef<PassportData>();

		[Column(IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(DbType = "nvarchar(40)", CanBeNull = false)]
		public string Surname { get; set; }

		[Column(DbType = "nvarchar(40)", CanBeNull = false)]
		public string Name { get; set; }

		[Column(DbType = "nvarchar(40)", CanBeNull = false)]
		public string Patronymic { get; set; }

		[Column(DbType = "nvarchar(1024)", CanBeNull = false)]
		public string Email { get; set; }

		[Column(DbType = "nvarchar(13)", CanBeNull = false)]
		public string Phone { get; set; }

		[Association(Name = "FK_Customer_PassportData", IsForeignKey = true, ThisKey = "PassportDataId", OtherKey = "Id", Storage = "_passportData")]
		public PassportData PassportData { get => _passportData.Entity; set => _passportData.Entity = value; }

		[Column(CanBeNull = false)]
		private int PassportDataId { get; set; }

		public override string ToString()
		{
			return $"{Surname} {Name} {Patronymic}";
		}
	}
}