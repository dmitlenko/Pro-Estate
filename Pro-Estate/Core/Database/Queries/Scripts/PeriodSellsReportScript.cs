using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using Pro_Estate.Forms.Main.Docking;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Docking.Crown;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Pro_Estate.Core.Database.Queries.Scripts
{
	public class PeriodSellsReportScript : ABaseScript
	{
		private ControlCollection _collection = new ControlCollection(new System.Windows.Forms.Panel())
		{
			ScriptHelper.DatePicker("fromDate","Дата початку"),
			ScriptHelper.DatePicker("toDate","Дата кінця"),
		};

		private DateTimePicker fromDate, toDate;

		public PeriodSellsReportScript(ProEstateDatabase database) : base(database) { }

		public override string Name => "Продажі за період";
		public override string Description => "Цей запит надає список всіх продажів за певний період часу.";

		public override Bitmap Icon => Properties.Resources.time;
		public override AccountLevel MinViewLevel => AccountLevel.Employee;
		public override ControlCollection Controls { get => _collection; set => _collection = value; }

		public override void Prepare()
		{
			fromDate = (DateTimePicker)_collection["fromDate"];
			toDate = (DateTimePicker)_collection["toDate"];

			toDate.MinDate = fromDate.Value;

			fromDate.ValueChanged += (s, e) =>
			{
				toDate.MinDate = fromDate.Value;
			};
		}

		private class ResultRow
		{
			public Customer Customer { get; set; }
			public double Price { get; set; }
			public string Name { get; set; }
			public DateTime Date { get; set; }
		}

		public override void Execute(params object[] list)
		{
			var dock = (list[0] as CrownDocument).DockPanel;
			var values = from a in Database.Sells
						 where a.Date >= fromDate.Value && a.Date <= toDate.Value
						 select new ResultRow
						 {
							 Customer = a.Client,
							 Price = a.Price,
							 Name = a.Apartment.Name,
							 Date =  a.Date
						 };
			var table = DatabaseHelper.LINQResultToDataTable(values);

			if (values.Count() == 0)
			{
				CrownMessageBox.ShowInformation("Звіт не дав жодних резільтатів.", "Помилка");
				return;
			}

			var html = Properties.Resources.pro_estate_report_head +
				string.Format(Properties.Resources.pro_estate_report_body,
						Name,
						HTMLHelper.SummaryTable(new KeyValuePair<string, object>[]
						{
							new KeyValuePair<string, object>($"Початок відрізку", fromDate.Value.ToString("dd.MM.yyyy")),
							new KeyValuePair<string, object>($"Кінець відрізку", toDate.Value.ToString("dd.MM.yyyy")),
						}),
						HTMLHelper.ColumnsToHeaders(table.Columns),
						HTMLHelper.RowsToHTML(table.Rows),
						HTMLHelper.SummaryTable(new KeyValuePair<string, object>[]
						{
							new KeyValuePair<string, object>($"Всього зароблено ({Constants.IncomePercent * 100}%)", values.Select(x => x.Price * Constants.IncomePercent).Sum())
						}));
			dock.AddContent(new DockBrowser(Name + " (результат)", html, Icon, true));
		}
	}
}