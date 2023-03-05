using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;

namespace Pro_Estate.Core.Database.Queries.Reports
{
	public class RequirementsReport : AReportQuery
	{
		public override Bitmap Icon { get => Properties.Resources.text_list_bullets; }
		public override string Name { get => "Вимоги від клієнтів"; }
		public override string Description { get => "Звіт про вимоги клієнтів надає статистику про вимоги від клієнтів"; }
		public override bool Editable { get => false; }

		private class ResultRow
		{
			public Customer Customer { get; set; }
			public double MinPrice { get; set; }
			public double MaxPrice { get; set; }
			public double Square { get; set; }
		}

		public override string GetHTML()
		{
			var results = Database.Requirements.Select(x => new ResultRow
			{
				Customer = x.Client,
				MinPrice = x.MinPrice,
				MaxPrice = x.MaxPrice,
				Square = x.Square,
			});

			var table = DatabaseHelper.LINQResultToDataTable(results);

			if (results.Count() == 0)
				return "";

			return Properties.Resources.pro_estate_report_head +
				string.Format(Properties.Resources.pro_estate_report_body,
						Name,
						Description,
						HTMLHelper.ColumnsToHeaders(table.Columns),
						HTMLHelper.RowsToHTML(table.Rows),
						HTMLHelper.SummaryTable(new KeyValuePair<string, object>[]
						{
							new KeyValuePair<string, object>( "Середня ціна за вимогами", results.Select(r => (r.MinPrice + r.MaxPrice) / 2).Average() ),
							new KeyValuePair<string, object>( "Середня площа за вимогами", results.Select(r => r.Square).Average()),
							new KeyValuePair<string, object>( "Найвища ціна за вимогами", results.Select(r => r.MaxPrice).Max()),
							new KeyValuePair<string, object>( "Найнижча ціна за вимогами", results.Select(r => r.MaxPrice).Min()),
							new KeyValuePair<string, object>( "Середня найвища ціна за вимогами", results.Select(r => r.MaxPrice).Average()),
							new KeyValuePair<string, object>( "Середня найнижча ціна за вимогами", results.Select(r => r.MinPrice).Average()),
						}));;
		}
	}
}