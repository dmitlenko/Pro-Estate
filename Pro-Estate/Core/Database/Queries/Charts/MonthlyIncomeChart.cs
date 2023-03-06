using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
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
		private string[] xAxisData = { "Продажі", "Оренди" };
		private double[] yAxisData;
		public override string Name => "Статистика з заробітку";
		public override string Description => "Статистика заробітку за місяць";
		public override Bitmap Icon => Properties.Resources.chart_pie_title;
		public override AccountLevel MinViewLevel => AccountLevel.Customer;

		public override DataTable GetDataTable()
		{
			return new DataTable();
		}

		public override List<Series> GetSeries(Chart chart)
		{
			Series ser = new Series { ChartType = SeriesChartType.Pie };
			var minDate = DateTime.Today.AddMonths(-1);

			double sellValue = (from s in Database.Sells
								where s.Date > minDate
								select s.Price).Sum() * Constants.IncomePercent;

			double rentValue = (from s in Database.Rents
								where s.DateStart > minDate
								select s.Price).Sum() * Constants.IncomePercent;

			double sellPercent = sellValue / (sellValue + rentValue);
			double rentPercent = rentValue / (sellValue + rentValue);

			yAxisData = new double[] { sellPercent, rentPercent };

			ser.Points.DataBindXY(xAxisData, yAxisData);

			return new List<Series> { ser };
		}
	}
}