namespace Pro_Estate.Forms.Main.Docking
{
	partial class DockActions
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.queriesTree = new ReaLTaiizor.Controls.CrownTreeView();
			this.SuspendLayout();
			// 
			// queriesTree
			// 
			this.queriesTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.queriesTree.Location = new System.Drawing.Point(0, 25);
			this.queriesTree.MaxDragChange = 20;
			this.queriesTree.Name = "queriesTree";
			this.queriesTree.ShowIcons = true;
			this.queriesTree.Size = new System.Drawing.Size(340, 361);
			this.queriesTree.TabIndex = 0;
			this.queriesTree.Text = "crownTreeView1";
			this.queriesTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.queriesTree_MouseUp);
			// 
			// DockTree
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.queriesTree);
			this.DefaultDockArea = ReaLTaiizor.Enum.Crown.DockArea.Left;
			this.DockText = "Готові запити";
			this.Icon = global::Pro_Estate.Properties.Resources.query_design;
			this.Name = "DockTree";
			this.Size = new System.Drawing.Size(340, 386);
			this.ResumeLayout(false);

		}

		#endregion

		private ReaLTaiizor.Controls.CrownTreeView queriesTree;
	}
}
