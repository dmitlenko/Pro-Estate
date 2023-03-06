using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Queries;
using Pro_Estate.Core.Database.Tables;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Docking.Crown;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Pro_Estate.Forms.Main.Docking
{
	public partial class DockActions : CrownToolWindow
	{
		private readonly ObservableList<CrownTreeNode> tablesNodes = new ObservableList<CrownTreeNode>();
		private readonly ObservableList<CrownTreeNode> reportNodes = new ObservableList<CrownTreeNode>();
		private readonly ObservableList<CrownTreeNode> scriptNodes = new ObservableList<CrownTreeNode>();
		private readonly ObservableList<CrownTreeNode> chartNodes = new ObservableList<CrownTreeNode>();

		private CrownDockPanel Panel { get; set; }

		private ProEstateDatabase Database { get; set; }
		private AccountLevel AccountLevel { get; set; }

		public DockActions(CrownDockPanel crownDockPanel, ProEstateDatabase database, AccountLevel accountLevel)
		{
			InitializeComponent();
			Panel = crownDockPanel;
			Database = database;
			AccountLevel = accountLevel;

			FillNodes(Queries.Tables(Database), tablesNodes);
			FillNodes(Queries.Reports(Database), reportNodes);
			FillNodes(Queries.Scripts(Database), scriptNodes);
			FillNodes(Queries.Charts(Database), chartNodes);

			AddNode("Таблиці", tablesNodes, Properties.Resources.table);
			AddNode("Звіти", reportNodes, Properties.Resources.report_green);
			AddNode("Запити", scriptNodes, Properties.Resources.query_design);
			AddNode("Діаграми", chartNodes, Properties.Resources.table_chart);

			foreach (var node in queriesTree.Nodes)
				node.Expanded = true;
		}

		private void FillNodes<T>(IEnumerable<T> items, ICollection<CrownTreeNode> nodes) where T : ABaseQuery
		{
			foreach (var item in items)
			{
				if (item.MinViewLevel <= AccountLevel)
					nodes.Add(new CrownTreeNode
					{
						Text = item.Name,
						Icon = item.Icon,
						Tag = item
					});
			}
		}

		private void AddNode(string name, ObservableList<CrownTreeNode> nodes, Bitmap icon)
		{
			if (nodes.Any())
				queriesTree.Nodes.Add(new CrownTreeNode
				{
					Text = name,
					Nodes = nodes,
					Icon = icon
				});
		}

		private void queriesTree_MouseUp(object sender, MouseEventArgs e)
		{
			if (queriesTree.SelectedNodes.Count > 0 && e.Button == MouseButtons.Left)
			{
				var item = queriesTree.SelectedNodes[0].Tag;
				CrownDocument crownDocument = null;

				switch (item)
				{
					case AReportQuery rq:
						crownDocument = new DockBrowser(rq.Name, rq.GetHTML(), rq.Icon, true);
						break;

					case ABaseScript bs:
						crownDocument = new DockScript((ABaseScript)Activator.CreateInstance(bs.GetType(), Database));
						break;

					case AChartQuery cq:
						crownDocument = new DockChart(cq);
						break;

					case ATableQuery<Account> table:
						crownDocument = new DockTable<Account>(table, AccountLevel);
						break;

					case ATableQuery<Apartment> table:
						crownDocument = new DockTable<Apartment>(table, AccountLevel);
						break;

					case ATableQuery<Customer> table:
						crownDocument = new DockTable<Customer>(table, AccountLevel);
						break;

					case ATableQuery<Employee> table:
						crownDocument = new DockTable<Employee>(table, AccountLevel);
						break;

					case ATableQuery<Lessor> table:
						crownDocument = new DockTable<Lessor>(table, AccountLevel);
						break;

					case ATableQuery<PassportData> table:
						crownDocument = new DockTable<PassportData>(table, AccountLevel);
						break;

					case ATableQuery<Rent> table:
						crownDocument = new DockTable<Rent>(table, AccountLevel);
						break;

					case ATableQuery<Requirement> table:
						crownDocument = new DockTable<Requirement>(table, AccountLevel);
						break;

					case ATableQuery<Sell> table:
						crownDocument = new DockTable<Sell>(table, AccountLevel);
						break;

					default: break;
				}

				if (crownDocument != null) Panel.AddContent(crownDocument);

				queriesTree.SelectedNodes.Clear();
			}
		}
	}
}