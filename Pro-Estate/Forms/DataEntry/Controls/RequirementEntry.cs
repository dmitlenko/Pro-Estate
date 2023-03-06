using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pro_Estate.Forms.DataEntry.Controls
{
	public partial class RequirementEntry<T> : UserControl, IEntryData<T>
		where T : Requirement, new()
	{
		private ProEstateDatabase Database { get; set; }
		private T Value { get; set; }

		public RequirementEntry(ProEstateDatabase database, T item)
		{
			InitializeComponent();

			Database = database;
			Value = item;

			PrepareFields();

			if (item != null)
			{
				client.SelectedItem = Value.Client;
				square.Value = (decimal)Value.Square;
				minPrice.Value = (decimal)Value.MinPrice;
				maxPrice.Value = (decimal)Value.MaxPrice;
				isresidental.Checked = Value.IsResidential;
				dateAdded.Value = Value.DateAdded;
			}
		}

		private void PrepareFields()
		{
			client.Items.AddRange(Database.Customers.ToArray());
			square.Maximum = int.MaxValue;
			minPrice.Minimum = 0;
			minPrice.Maximum = int.MaxValue - 1;
			maxPrice.Maximum = int.MaxValue;
			dateAdded.MaxDate = DateTime.Now;
		}

		public T GetValue()
		{
			Value.Client = client.SelectedItem as Customer;
			Value.Square = (double)square.Value;
			Value.MinPrice = (double)minPrice.Value;
			Value.MaxPrice = (double)maxPrice.Value;
			Value.IsResidential = isresidental.Checked;
			Value.DateAdded = dateAdded.Value;

			return Value;
		}

		public bool CheckFields()
		{
			if (client.SelectedItem == null) return false;

			return true;
		}

		private void minPrice_ValueChanged(object sender, System.EventArgs e)
		{
			maxPrice.Value = minPrice.Value;
			maxPrice.Minimum = minPrice.Value;
		}
	}
}