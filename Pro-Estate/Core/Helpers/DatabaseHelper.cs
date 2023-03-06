using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;

namespace Pro_Estate.Core.Helpers
{
	public class DatabaseHelper
	{
		public static DataTable LINQResultToDataTable<T>(IEnumerable<T> Linqlist)
		{
			DataTable dt = new DataTable();
			dt.TableName = typeof(T).Name;
			PropertyInfo[] columns = null;

			if (Linqlist == null) return dt;

			foreach (T Record in Linqlist)
			{
				if (columns == null)
				{
					columns = ((Type)Record.GetType()).GetProperties();
					foreach (PropertyInfo GetProperty in columns)
					{
						Type colType = GetProperty.PropertyType;

						if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition()
							   == typeof(Nullable<>)))
						{
							colType = colType.GetGenericArguments()[0];
						}

						dt.Columns.Add(new DataColumn(GetProperty.Name, colType));
					}

					dt.Columns.Add(new DataColumn("__tag", typeof(object)));
				}

				DataRow dr = dt.NewRow();

				foreach (PropertyInfo pinfo in columns)
				{
					dr[pinfo.Name] = pinfo.GetValue(Record, null) == null ? DBNull.Value : pinfo.GetValue
						   (Record, null);
				}
				dr["__tag"] = Record;

				dt.Rows.Add(dr);
			}
			return dt;
		}

		public static string ConstructConnectionString(string filename)
		{
			return new SqlConnectionStringBuilder
			{
				ConnectTimeout = 10,
				AttachDBFilename = filename,
				DataSource = "(LocalDB)\\MSSQLLocalDB",
				IntegratedSecurity = true
			}.ConnectionString;
		}

		public static void CopyFields<TSource>(TSource sourceObject, TSource targetObject)
		{
			var sourceFields = typeof(TSource).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			var targetFields = typeof(TSource).GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

			foreach (var sourceField in sourceFields)
			{
				var targetField = targetFields.FirstOrDefault(f => f.Name == sourceField.Name && f.FieldType == sourceField.FieldType);
				if (targetField != null)
				{
					var value = sourceField.GetValue(sourceObject);
					targetField.SetValue(targetObject, value);
				}
			}
		}

		public static Series ChartSeries(string name, string xValueMember, string yValueMember, SeriesChartType seriesChartType = SeriesChartType.Column)
		{
			return new Series
			{
				Name = name,
				LegendText = name,
				XValueMember = xValueMember,
				YValueMembers = yValueMember,
				ChartType = seriesChartType,
			};
		}
	}
}