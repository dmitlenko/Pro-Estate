using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pro_Estate.Core.Database.Queries.Charts
{
	public class MonthlyIncomeChart : AChartQuery
	{
		public override string Name => "Статистика з заробітку";
		public override string Description => "Статистика заробітку за місяць";
		public override Bitmap Icon => Properties.Resources.chart_column_up;
		public override AccountLevel MinViewLevel => AccountLevel.Customer;

		private class ResultRow
		{
			public DateTime Date { get; set; }
			public double Price { get; set; }
		}

		public override DataTable GetDataTable()
		{
			var minDate = DateTime.Today.AddMonths(-1);
			var values = from s in Database.Sells
						 where s.Date > minDate
						 select new ResultRow { Date = s.Date, Price = s.Price };
			values.Concat(from s in Database.Rents
						  where s.DateStart > minDate
						  select new ResultRow { Date = s.DateStart, Price = s.Price });
			return DatabaseHelper.LINQResultToDataTable(values);
		}

		public override List<Series> GetSeries()
		{
			return new List<Series>
			{
				DatabaseHelper.ChartSeries("Оренда", "Date", "Price")
			};
		}
	}
}