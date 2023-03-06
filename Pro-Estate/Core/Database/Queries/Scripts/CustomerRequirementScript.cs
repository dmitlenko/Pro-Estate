using Pro_Estate.Core.Database.Base;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Docking.Crown;
using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using static System.Windows.Forms.Control;

namespace Pro_Estate.Core.Database.Queries.Scripts
{
	public class CustomerRequirementScript : ABaseScript
	{
		private ControlCollection _collection = new ControlCollection(new System.Windows.Forms.Panel())
		{
			ScriptHelper.ComboBox("client","Клієнт"),
			ScriptHelper.Numeric("minPrice","Мінімальна ціна"),
			ScriptHelper.Numeric("maxPrice","Максимальна ціна"),
			ScriptHelper.Numeric("square","Площа"),
			ScriptHelper.CheckBox("isResidential", "Житлове?")
		};

		private CrownComboBox client;
		private CrownNumeric minPrice, maxPrice, square;
		private CrownCheckBox isResidential;

		public CustomerRequirementScript(ProEstateDatabase database) : base(database)
		{
		}

		public override string Name => "Додавання вимог";
		public override string Description => "Цей запит надає можливісь створити нову вимогу до приміщень.";

		public override Bitmap Icon => Properties.Resources.to_do_list;
		public override AccountLevel MinViewLevel => AccountLevel.Customer;
		public override ControlCollection Controls { get => _collection; set => _collection = value; }

		public override void Prepare()
		{
			client = (CrownComboBox)_collection["client"];
			minPrice = (CrownNumeric)_collection["minPrice"];
			maxPrice = (CrownNumeric)_collection["maxPrice"];
			square = (CrownNumeric)_collection["square"];
			isResidential = (CrownCheckBox)_collection["isResidential"];

			client.Items.AddRange(Database.Customers.ToArray());
			minPrice.DecimalPlaces = maxPrice.DecimalPlaces = 2;
			minPrice.Maximum = int.MaxValue - 1;
			maxPrice.Minimum = minPrice.Value;
			maxPrice.Maximum = int.MaxValue;

			minPrice.ValueChanged += (s, e) =>
			{
				maxPrice.Minimum = minPrice.Value;
			};
		}

		private bool CheckFields()
		{
			if (client.SelectedItem == null)
				return false;

			return true;
		}

		public override void Execute(params object[] list)
		{
			var document = list.First() as CrownDocument;

			if (CheckFields())
			{
				document.Enabled = false;
				Database.Requirements.InsertOnSubmit(new Requirement
				{
					Client = client.SelectedItem as Customer,
					MinPrice = (double)minPrice.Value,
					MaxPrice = (double)maxPrice.Value,
					Square = (double)square.Value,
					DateAdded = DateTime.Now,
					IsResidential = isResidential.Checked
				});

				Database.SubmitChanges();
				CrownMessageBox.ShowInformation("Нова вимога додана до бази даних.", "Створення вимоги");
				document.Close();
			}
			else
				CrownMessageBox.ShowError("Введені невірні дані.", "Помилка!");
		}
	}
}