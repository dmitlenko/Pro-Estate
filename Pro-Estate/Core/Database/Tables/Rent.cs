using Pro_Estate.Core.Database.Base;
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Pro_Estate.Core.Database.Tables
{
	[Table(Name = "Rent")]
	public class Rent : IIdentifable
	{
		private EntityRef<Apartment> _apartment = new EntityRef<Apartment>();
		private EntityRef<Customer> _client = new EntityRef<Customer>();
		private EntityRef<Employee> _employee = new EntityRef<Employee>();

		[Column(IsDbGenerated = true, IsPrimaryKey = true)]
		public int Id { get; set; }

		[Association(Name = "FK_Rent_Client", IsForeignKey = true, ThisKey = "ClientId", OtherKey = "Id", Storage = "_client")]
		public Customer Client { get => _client.Entity; set => _client.Entity = value; }

		[Column(CanBeNull = false)]
		public DateTime DateStart { get; set; } = DateTime.Now;

		[Column(CanBeNull = false)]
		public DateTime DateEnd { get; set; } = DateTime.Now;

		[Column(CanBeNull = false)]
		public double Price { get; set; }

		[Association(Name = "FK_Rent_Apartment", IsForeignKey = true, ThisKey = "ApartmentId", OtherKey = "Id", Storage = "_apartment")]
		public Apartment Apartment { get => _apartment.Entity; set => _apartment.Entity = value; }

		[Association(Name = "FK_rent_Employee", IsForeignKey = true, ThisKey = "EmployeeId", OtherKey = "Id", Storage = "_employee")]
		public Employee Employee { get => _employee.Entity; set => _employee.Entity = value; }

		[Column(CanBeNull = false)]
		private int EmployeeId { get; set; }

		[Column(CanBeNull = false)]
		private int ApartmentId { get; set; }

		[Column(CanBeNull = false)]
		private int ClientId { get; set; }
	}
}