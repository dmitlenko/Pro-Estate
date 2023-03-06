using Pro_Estate.Core.Database.Base;
using System;
using System.Data.Linq.Mapping;

namespace Pro_Estate.Core.Database.Tables
{
	[Table(Name = "PassportData")]
	public class PassportData
	{
		[Column(IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }

		[Column(DbType = "nvarchar(120)", CanBeNull = false)]
		public string Gender { get; set; }

		[Column(CanBeNull = false)]
		public DateTime BirthDate { get; set; } = DateTime.Now;

		[Column(DbType = "nvarchar(120)", CanBeNull = false)]
		public string Country { get; set; }

		[Column(DbType = "nvarchar(120)", CanBeNull = false)]
		public string State { get; set; }

		[Column(DbType = "nvarchar(120)", CanBeNull = false)]
		public string City { get; set; }

		[Column(DbType = "nvarchar(120)", CanBeNull = false)]
		public string Street { get; set; }

		[Column(DbType = "nvarchar(20)", CanBeNull = false)]
		public string House { get; set; }

		public override string ToString()
		{
			return $"{Gender}, {BirthDate.ToString("dd.MM.yyyy")}, {Country}, {State}, {City}, {Street}, {House}";
		}
	}
}