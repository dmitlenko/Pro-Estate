using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Reports
{
	public class MonthlySellsReport : AReportQuery
	{
		public override Bitmap Icon { get => Properties.Resources.domain_buying_selling; }
		public override string Name { get => "Продажі за останнцій місяць"; }
		public override string Description { get => "Звіт надає про всі продажі які були зроблені за останній місяць."; }
		public override bool Editable { get => false; }

		private class ResultRow
		{
			public Customer Customer { get; set; }
			public double Price { get; set; }
			public string Name { get; set; }
			public DateTime Date { get; set; }
		}

		public override string GetHTML()
		{
			var minDate = DateTime.Now.AddMonths(-1);
			var values = from a in Database.Sells
						 where a.Date > minDate
						 select new ResultRow
						 {
							 Customer = a.Client,
							 Price = a.Price,
							 Name = a.Apartment.Name,
							 Date = a.Date,
						 };
			var table = DatabaseHelper.LINQResultToDataTable(values);

			if (values.Count() == 0)
				return "";

			return Properties.Resources.pro_estate_report_head +
				string.Format(Properties.Resources.pro_estate_report_body,
						Name,
						Description,
						HTMLHelper.ColumnsToHeaders(table.Columns),
						HTMLHelper.RowsToHTML(table.Rows), 
						HTMLHelper.SummaryTable(new KeyValuePair<string, object>[]
						{
							new KeyValuePair<string, object>($"Всього зароблено ({Constants.IncomePercent * 100}%)", values.Select(x => x.Price * Constants.IncomePercent).Sum())
						}));
		}
	}
}