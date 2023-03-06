using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pro_Estate.Core.Database.Queries.Charts
{
	public class MonthlySellsChart : AChartQuery
	{
		public override string Name => "Статистика з продаж";
		public override string Description => "Статистика продаж за місяць";
		public override Bitmap Icon => Properties.Resources.chart_column_up;
		public override AccountLevel MinViewLevel => AccountLevel.Customer;

		public override DataTable GetDataTable()
		{
			var minDate = DateTime.Today.AddMonths(-1);
			var values = from s in Database.Sells
						 where s.Date > minDate
						 select s;
			return DatabaseHelper.LINQResultToDataTable(values);
		}

		public override List<Series> GetSeries(Chart chart)
		{
			return new List<Series>
			{
				DatabaseHelper.ChartSeries("Продаж", "Date", "Price")
			};
		}
	}
}
