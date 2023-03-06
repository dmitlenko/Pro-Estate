using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pro_Estate.Core.Database.Base
{
	public abstract class AChartQuery: ABaseQuery
	{
		public abstract List<Series> GetSeries();
		public abstract DataTable GetDataTable();
	}
}
