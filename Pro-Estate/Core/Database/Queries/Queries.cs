using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Queries.Charts;
using Pro_Estate.Core.Database.Queries.Reports;
using Pro_Estate.Core.Database.Queries.Scripts;
using Pro_Estate.Core.Database.Queries.Tables;
using System.Collections.Generic;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries
{
	public class Queries
	{
		public static List<ABaseQuery> Reports(ProEstateDatabase database)
		{
			return new List<ABaseQuery>(new ABaseQuery[]
			{
				new MonthlySellsReport { Database = database },
				new MonthlyIncomeReport { Database = database },
				new RequirementsReport { Database = database },
				new IncomeReport { Database = database },
				new ApartmentsReport { Database = database },
			}.OrderBy(x => x.Name));
		}

		public static List<ABaseQuery> Tables(ProEstateDatabase database)
		{
			return new List<ABaseQuery>(new ABaseQuery[]
			{
				new AccountsTable { Database = database },
				new EmployeesTable { Database = database },
				new ApartmentsTable { Database = database },
				new CustomersTable { Database = database },
				new LessorsTable { Database = database },
				new RentsTable { Database = database },
				new RequirementsTable { Database = database },
				new SellsTable { Database = database }
			}.OrderBy(x => x.Name));
		}

		public static List<ABaseScript> Scripts(ProEstateDatabase database)
		{
			return new List<ABaseScript>(new ABaseScript[]
			{
				new CustomerReportScript (database),
				new LesseeReportScript (database),
				new PeriodSellsReportScript (database),
				new CustomerRequirementScript (database),
				new CustomerRegisterScript (database),
				new LessorRegisterScript (database),
			}.OrderBy(x => x.Name));
		}

		public static List<AChartQuery> Charts(ProEstateDatabase database)
		{
			return new List<AChartQuery>(new AChartQuery[]
			{
				new MonthlySellsChart {Database = database},
				new MonthlyRentChart {Database = database},
			}.OrderBy(x => x.Name));
		}
	}
}