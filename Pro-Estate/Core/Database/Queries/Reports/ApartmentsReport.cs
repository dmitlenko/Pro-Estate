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
	public class ApartmentsReport : AReportQuery
	{
		public override Bitmap Icon { get => Properties.Resources.building; }
		public override string Name { get => "Список приміщень"; }
		public override string Description { get => "Звіт про доступні приміщення для оренди та покупки."; }
		public override bool Editable { get => false; }

		public override AccountLevel MinViewLevel => AccountLevel.Customer;

		private class ResultRow
		{
			public Lessor Lessor { get; set; }
			public double BuyPrice { get; set; }
			public double RentPrice { get; set; }
			public double Square { get; set; }
			public string Address { get; set; }
			public string Type { get; set; }
		}

		public override string GetHTML()
		{
			var results = Database.Apartments.Select(x => new ResultRow
			{
				Lessor = x.Lessee,
				BuyPrice = x.Price,
				RentPrice = x.RentPrice,
				Square = x.Square,
				Address = $"{x.Country}, {x.State} обл., м. {x.City}, вул. {x.Street}, буд. {x.House}",
				Type = x.IsResidential ? "Residential" : "Non residential"
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
							new KeyValuePair<string, object>( "Середня ціна покупки", results.Select(r => r.BuyPrice).Average() ),
							new KeyValuePair<string, object>( "Середня ціна оренди", results.Select(r => r.RentPrice).Average() ),
							new KeyValuePair<string, object>( "Середня площа", results.Select(r => r.Square).Average()),
						}));;
		}
	}
}