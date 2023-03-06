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
	public class MonthlyRentChart : AChartQuery
	{
		public override string Name => "Статистика з оренд";
		public override string Description => "Статистика оренд за місяць";
		public override Bitmap Icon => Properties.Resources.chart_column_up;
		public override AccountLevel MinViewLevel => AccountLevel.Customer;
		private IEnumerable<Rent> values;

		public override DataTable GetDataTable()
		{
			return DatabaseHelper.LINQResultToDataTable(values);
		}

		public override List<Series> GetSeries(Chart chart)
		{
			var minDate = DateTime.Today.AddMonths(-1);
			values = from s in Database.Rents
					 where s.DateStart > minDate
					 select s;

			chart.ChartAreas[0].AxisX.Minimum = values.Select(x => x.DateStart).Min().ToOADate();
			chart.ChartAreas[0].AxisX.Maximum = values.Select(x => x.DateStart).Max().ToOADate();

			return new List<Series>
			{
				DatabaseHelper.ChartSeries("Оренда", "DateStart", "Price")
			};
		}
	}
}