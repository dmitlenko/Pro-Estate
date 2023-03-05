using ReaLTaiizor.Controls;
using System.Windows.Forms;
using static System.Drawing.Color;

namespace Pro_Estate.Core.Helpers
{
	public static class ScriptHelper
	{
		public static int Width => 288;
		public static int Height => 20;

		public static CrownTextBox TextBox(string name, string title = "") => new CrownTextBox
		{
			Name = name,
			Width = Width,
			Height = Height,
			Tag = title,
		};

		public static CrownNumeric Numeric(string name, string title = "") => new CrownNumeric
		{
			Name = name,
			Width = Width,
			Height = Height,
			Minimum = 0,
			Maximum = int.MaxValue,
			Tag = title,
		};

		public static CrownCheckBox CheckBox(string name, string title = "") => new CrownCheckBox
		{
			Name = name,
			Width = Width,
			Height = Height,
			AutoSize = false,
			Text = title,
		};

		public static DateTimePicker DatePicker(string name, string title = "") => new DateTimePicker
		{
			Name = name,
			Width = Width,
			Height = Height,
			Tag = title,
		};

		public static CrownComboBox ComboBox(string name, string title = "") => new CrownComboBox
		{
			Name = name,
			Width = Width,
			Height = Height,
			Tag = title,
		};

		public static MaskedTextBox MaskedTextBox(string name, string title = "") => new MaskedTextBox
		{
			Name = name,
			Width = Width,
			Height = Height,
			BackColor = FromArgb(69, 73, 74),
			ForeColor = FromArgb(220, 220, 220),
			BorderStyle = BorderStyle.FixedSingle,
			Tag = title,
		};
	}
}