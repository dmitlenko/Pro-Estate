using Pro_Estate.Core.Database.Base;
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Pro_Estate.Core.Database.Tables
{
	[Table(Name = "Requirements")]
	public class Requirement
	{
		private EntityRef<Customer> _client = new EntityRef<Customer>();


		[Column(IsDbGenerated = true, IsPrimaryKey = true)]
		public int Id { get; set; }

		[Association(Name = "FK_Requirements_Client", IsForeignKey = true, ThisKey = "ClientId", OtherKey = "Id", Storage = "_client")]
		public Customer Client { get => _client.Entity; set => _client.Entity = value; }

		[Column(CanBeNull = false)]
		public double Square { get; set; }

		[Column(CanBeNull = false)]
		public double MinPrice { get; set; }

		[Column(CanBeNull = false)]
		public double MaxPrice { get; set; }

		[Column(CanBeNull = false)]
		public DateTime DateAdded { get; set; } = DateTime.Now;

		[Column(CanBeNull = false)]
		private int ClientId { get; set; }

		[Column(CanBeNull = false)]
		public bool IsResidential { get; set; }
	}
}