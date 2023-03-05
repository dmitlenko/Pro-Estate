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
using static System.Windows.Forms.Control;

namespace Pro_Estate.Core.Database.Queries.Scripts
{
	public class LesseeReportScript : ABaseScript
	{
		private ControlCollection _collection = new ControlCollection(new Panel())
		{
			ScriptHelper.ComboBox("apartment","Приміщення"),
		};

		private CrownComboBox apartment;

		public LesseeReportScript(ProEstateDatabase database) : base(database) { }
		public override string Name => "Звіт за приміщенням";

		public override string Description => "Цей запит надає список всіх орендарів за наданим приміщенням.";

		public override Bitmap Icon => Properties.Resources.building_go;
		public override AccountLevel MinEditLevel => AccountLevel.Employee;
		public override ControlCollection Controls { get => _collection; set => _collection = value; }

		public override void Prepare()
		{
			apartment = (CrownComboBox)_collection["apartment"];

			apartment.Items.AddRange(Database.Apartments.ToArray());
		}

		private class ResultRow
		{
			public Customer Customer { get; set; }
			public double Price { get; set; }
			public string Name { get; set; }
			public DateTime DateStart { get; set; }
			public DateTime DateEnd { get; set; }
		}

		public override void Execute(params object[] list)
		{
			var dock = (list[0] as CrownDocument).DockPanel;
			var values = from a in Database.Rents
						 where a.Apartment == apartment.SelectedItem as Apartment
						 select new ResultRow
						 {
							 Customer = a.Client,
							 Price = a.Price,
							 Name = a.Apartment.Name,
							 DateStart = a.DateStart,
							 DateEnd = a.DateEnd,
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
							new KeyValuePair<string, object>($"Приміщення", apartment.SelectedItem),
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