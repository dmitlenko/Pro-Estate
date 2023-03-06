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
			chart.Palette = ChartColorPalette.Excel;
			PrepareChartLook();
			chart.DataSource = Query.GetDataTable();
		}

		private void PrepareChartLook()
		{
			chart.Series.Clear();
			Query.GetSeries(chart).ForEach(x => chart.Series.Add(x));

			chart.Legends.Clear();
			chart.Legends.Add(new Legend
			{
				LegendStyle = LegendStyle.Table,
				Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom,
				Alignment = StringAlignment.Center,
				Title = Query.Description,
				BorderColor = Color.Black
			});
		}
	}
}
