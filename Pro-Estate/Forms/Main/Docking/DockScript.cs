using Pro_Estate.Core.Database.Base;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Docking.Crown;
using System;
using System.Windows.Forms;

namespace Pro_Estate.Forms.Main.Docking
{
	public partial class DockScript : CrownDocument
	{
		private ABaseScript Script { get; set; }

		public DockScript(ABaseScript baseScript)
		{
			InitializeComponent();


			Script = baseScript;
			DockText = baseScript.Name;
			Icon = baseScript.Icon;

			scriptName.Text = baseScript.Name;
			scriptDescription.Text = baseScript.Description;
			scriptIcon.Image = baseScript.Icon;

			AddControls();
			Script.PrepareControls(controlsPanel.Controls);
			Script.Prepare();
		}

		public void AddControls()
		{
			foreach (Control control in Script.Controls)
			{
				if (control.Tag is string)
					controlsPanel.Controls.Add(new CrownLabel { Text = $"{control.Tag as string}:", AutoSize = true });
				controlsPanel.Controls.Add(control);
			}
		}

		private void executeButton_Click(object sender, EventArgs e)
		{
			Script.Execute(this);
		}
	}
}