using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Forms.DataEntry;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Docking.Crown;
using ReaLTaiizor.Enum.Crown;
using System.Data;
using System.Windows.Forms;

namespace Pro_Estate.Forms.Main.Docking
{
	public partial class DockTable<T> : CrownDocument
		where T : class, new()
	{
		private QueryResult<T> Result { get; set; }
		private ATableQuery<T> Query { get; set; }
		private ProEstateDatabase Database { get; set; }
		private AccountLevel AccountLevel { get; set; }

		public DockTable(ATableQuery<T> query, AccountLevel accountLevel)
		{
			InitializeComponent();

			Query = query;
			Database = query.Database;
			Icon = query.Icon;
			DockText = query.Name;
			AccountLevel = accountLevel;

			BuildToolStrip();

			LoadData();
		}

		private void RefreshTable()
		{
			Database.Refresh(System.Data.Linq.RefreshMode.OverwriteCurrentValues, Query.Table);
			LoadData();
		}

		private void BuildToolStrip()
		{
			toolStrip.Visible = !(Query is AReportQuery);

			addNew.Enabled = Query.Createable && Query.MinCreateLevel <= AccountLevel;
			editSelected.Enabled = Query.Editable && Query.MinEditLevel <= AccountLevel ? Table.SelectedItems.Count > 0 : false;
			deleteSelected.Enabled = Query.Deleteble && Query.MinDeleteLevel <= AccountLevel ? Table.SelectedItems.Count > 0 : false;
		}

		private void LoadData()
		{
			Result = Query.FetchResult();
			Table.Clear();

			foreach (var col in Result.DataTable.Columns)
				if (col.ToString() != "__tag")
					Table.Columns.Add(new ColumnHeader
					{
						Text = col.ToString(),
						Name = col.ToString(),
					});

			foreach (DataRow row in Result.DataTable.Rows)
			{
				var item = new ListViewItem(row.ItemArray[0].ToString());

				for (int i = 1; i < row.ItemArray.Length - 1; i++)
					item.SubItems.Add(row.ItemArray[i].ToString());

				item.Tag = row["__tag"] as T;
				Table.Items.Add(item);
			}

			BuildToolStrip();
			Table.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
			Table.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
		}

		public override void Close()
		{
			if (toolStrip.Enabled)
			{
				DialogResult result = CrownMessageBox.ShowWarning(@"Ви втратите всі незбережені зміни. Продовжити?", @"Закрити документ", DialogButton.YesNo);
				if (result == DialogResult.No)
					return;
			}

			base.Close();
		}

		private void addNew_Click(object sender, System.EventArgs e)
		{
			if (new DataEntryForm<T>(EntryAction.Add, new T(), Database).ShowDialog() == DialogResult.OK)
				RefreshTable();
		}

		private void editSelected_Click(object sender, System.EventArgs e)
		{
			if (new DataEntryForm<T>(EntryAction.Edit, Table.SelectedItems[0].Tag as T, Database).ShowDialog() == DialogResult.OK)
				RefreshTable();
		}

		private void removeSelected_Click(object sender, System.EventArgs e)
		{
			DialogResult result = CrownMessageBox.ShowWarning(@"Ви дійсно хочете видалити виділений рядок?", @"Видалення рядка", DialogButton.YesNo);
			if (result == DialogResult.No || Table.SelectedItems.Count <= 0)
				return;

			Query.Table.DeleteOnSubmit(Table.SelectedItems[0].Tag as T);
			Database.SubmitChanges();

			RefreshTable();
		}

		private void Table_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			if (Table.SelectedItems.Count > 0)
				BuildToolStrip();
		}

		private void refreshButton_Click(object sender, System.EventArgs e)
		{
			RefreshTable();
		}
	}
}