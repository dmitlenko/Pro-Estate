using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Pro_Estate.Core.Helpers
{
	public class HTMLHelper
	{
		public static string ArrayToColumns(string[] columns)
		{
			return string.Join("", columns.Select(n => $"<td>{n}</td>"));
		}

		public static string ArrayToHeaders(string[] columns)
		{
			return string.Join("", columns.Select(n => $"<th>{n}</th>"));
		}

		public static string ColumnsToHeaders(DataColumnCollection columns)
		{
			return ArrayToHeaders(columns.Cast<DataColumn>().Where(x => x.ColumnName != "__tag").Select(x => x.ColumnName).ToArray());
		}

		public static string RowsToHTML(DataRowCollection rows)
		{
			List<string> sRows = new List<string>();
			
			foreach (DataRow row in rows)
				sRows.Add(string.Join("", row.ItemArray.Where((v, i) => i != row.ItemArray.Length - 1).Select(x => $"<td>{x}</td>")));	

			return string.Join("", sRows.Select(n => $"<tr>{n}</tr>"));
		}

		public static string SummaryTable(KeyValuePair<string, object>[] columns)
		{
			return string.Format(@"<table class=""summary-table"">{0}</table>",string.Join("", columns.Select(v => $"<tr><td>{v.Key}:</td><td>{string.Format("{0:0.00}", v.Value)}</td></tr>")));
		}

		public static string ArrayToParagraphs(params string[] strings)
		{
			return string.Join("", strings.Select(s => $"<p>{s}</p>"));
		}
	}
}