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
	public class CustomerReportScript : ABaseScript
	{
		private ControlCollection _collection = new ControlCollection(new Panel())
		{
			ScriptHelper.ComboBox("client","Клієнт"),
			ScriptHelper.ComboBox("lessee","Орендар"),
			ScriptHelper.ComboBox("employee","Працівник"),
		};

		private CrownComboBox client, lessee, employee;

		public CustomerReportScript(ProEstateDatabase database) : base(database) { }

		public override string Name => "Звіт за клієнтом";

		public override string Description => "Цей запит надає список всіх покупок і аренд за вибраним клієнтом, " +
			"орендатором або працівником. Можна вибирати одночасно.";

		public override Bitmap Icon => Properties.Resources.client_account_template;
		public override AccountLevel MinViewLevel => AccountLevel.Employee;
		public override ControlCollection Controls { get => _collection; set => _collection = value; }

		public override void Prepare()
		{
			client = (CrownComboBox)_collection["client"];
			lessee = (CrownComboBox)_collection["lessee"];
			employee = (CrownComboBox)_collection["employee"];

			client.Items.AddRange(Database.Customers.ToArray());
			lessee.Items.AddRange(Database.Lessees.ToArray());
			employee.Items.AddRange(Database.Employees.ToArray());
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
						 where (client.SelectedItem == null ? true : a.Client == client.SelectedItem) &&
						 (lessee.SelectedItem == null ? true : a.Apartment.Lessee == lessee.SelectedItem) &&
						 (employee.SelectedItem == null ? true : a.Employee == employee.SelectedItem)
						 select new ResultRow
						 {
							 Customer = a.Client,
							 Price = a.Price,
							 Name = a.Apartment.Name,
							 Date = a.Date,
						 };
			values = values.Concat(from a in Database.Rents
								   where (client.SelectedItem == null ? true : a.Client == client.SelectedItem) &&
								   (lessee.SelectedItem == null ? true : a.Apartment.Lessee == lessee.SelectedItem) &&
								   (employee.SelectedItem == null ? true : a.Employee == employee.SelectedItem)
								   select new ResultRow
								   {
									   Customer = a.Client,
									   Price = a.Price,
									   Name = a.Apartment.Name,
									   Date = a.DateStart,
								   });
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
							new KeyValuePair<string, object>($"Клієнт", client.SelectedItem),
							new KeyValuePair<string, object>($"Орендар", lessee.SelectedItem),
							new KeyValuePair<string, object>($"Працівник", employee.SelectedItem),
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