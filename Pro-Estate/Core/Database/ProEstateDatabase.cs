using Pro_Estate.Core.Database.Tables;
using System.Data.Linq;

namespace Pro_Estate.Core.Database
{
	public class ProEstateDatabase : DataContext
	{
		public Table<Apartment> Apartments;
		public Table<Customer> Customers;
		public Table<Lessee> Lessees;
		public Table<Rent> Rents;
		public Table<Sell> Sells;
		public Table<Requirement> Requirements;
		public Table<PassportData> PassportData;
		public Table<Account> Accounts;
		public Table<Employee> Employees;

		public ProEstateDatabase(string connectionString) : base(connectionString)
		{
		}
	}
}