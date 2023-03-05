using Pro_Estate.Core.Database.Base;
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Pro_Estate.Core.Database.Tables
{
	public enum ApartmentType
	{
		None,
		Residential,
		NonResidential
	}

	[Table(Name = "Apartment")]
	public class Apartment : IIdentifable
	{
		private EntityRef<Lessee> _lessee = new EntityRef<Lessee>();

		[Column(IsPrimaryKey = true, IsDbGenerated = true, CanBeNull = false)]
		public int Id { get; set; }

		[Column(DbType = "nvarchar(1000)", CanBeNull = false)]
		public string Name { get; set; }

		[Column(CanBeNull = false)]
		public double Square { get; set; }

		[Column(CanBeNull = false)]
		public double Price { get; set; }

		[Column(CanBeNull = false)]
		public double RentPrice { get; set; }

		[Column(CanBeNull = false)]
		public DateTime DateAdded { get; set; } = DateTime.Now;

		[Association(Name = "FK_Apartment_Lessee", IsForeignKey = true, ThisKey = "LesseeId", OtherKey = "Id", Storage = "_lessee")]
		public Lessee Lessee { get => _lessee.Entity; set => _lessee.Entity = value; }

		[Column(CanBeNull = false)]
		public bool IsResidential { get; set; }

		[Column(CanBeNull = false)]
		private int LesseeId { get; set; }

		[Column(DbType = "nvarchar(200)", CanBeNull = false)]
		public string Country { get; set; }

		[Column(DbType = "nvarchar(200)", CanBeNull = false)]
		public string State { get; set; }

		[Column(DbType = "nvarchar(200)", CanBeNull = false)]
		public string City { get; set; }

		[Column(DbType = "nvarchar(200)", CanBeNull = false)]
		public string Street { get; set; }

		[Column(DbType = "nvarchar(20)", CanBeNull = false)]
		public string House { get; set; }

		public override string ToString()
		{
			return $"{Name}: {Country}, {State} обл., м. {City}, вул. {Street}, буд. {House}";
		}
	}
}