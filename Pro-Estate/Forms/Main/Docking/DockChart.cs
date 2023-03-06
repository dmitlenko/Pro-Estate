using Pro_Estate.Core.Database.Base;
using ReaLTaiizor.Docking.Crown;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pro_Estate.Forms.Main.Docking
{
	public partial class DockChart : CrownDocument
	{
		private AChartQuery Query { get; set; }
		public DockChart(AChartQuery query)
		{
			InitializeComponent();

			Query = query;

			DockText = Query.Name;
			Icon = Query.Icon;

			chart.Titles.Add(Query.Name);
			chart.Titles.Add(Query.Description);
			chart.Palette = ChartColorPalette.Excel;
			chart.Series.Clear();
			Query.GetSeries().ForEach(x => chart.Series.Add(x));
			chart.DataSource = Query.GetDataTable();
		}
	}
}
