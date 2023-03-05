using static System.Windows.Forms.Control;

namespace Pro_Estate.Core.Database.Base
{
	public abstract class ABaseScript : ABaseQuery
	{
		public ABaseScript(ProEstateDatabase database)
		{
			Database = database;
		}

		public abstract ControlCollection Controls { get; set; }

		public virtual void PrepareControls(ControlCollection controls) => Controls = controls;

		public virtual void Prepare()
		{ }

		public abstract void Execute(params object[] list);
	}
}