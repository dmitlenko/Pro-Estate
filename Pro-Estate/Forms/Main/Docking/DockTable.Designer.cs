namespace Pro_Estate.Forms.Main.Docking
{
	partial class DockTable<T>
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
			this.Table = new System.Windows.Forms.ListView();
			this.toolStrip = new ReaLTaiizor.Controls.CrownToolStrip();
			this.queryWizard = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.addNew = new System.Windows.Forms.ToolStripButton();
			this.editSelected = new System.Windows.Forms.ToolStripButton();
			this.deleteSelected = new System.Windows.Forms.ToolStripButton();
			this.refreshButton = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// Table
			// 
			this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Table.FullRowSelect = true;
			this.Table.HideSelection = false;
			this.Table.Location = new System.Drawing.Point(0, 28);
			this.Table.Name = "Table";
			this.Table.Size = new System.Drawing.Size(669, 385);
			this.Table.TabIndex = 1;
			this.Table.UseCompatibleStateImageBehavior = false;
			this.Table.View = System.Windows.Forms.View.Details;
			this.Table.SelectedIndexChanged += new System.EventHandler(this.Table_SelectedIndexChanged);
			// 
			// toolStrip
			// 
			this.toolStrip.AutoSize = false;
			this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryWizard,
            this.toolStripSeparator1,
            this.addNew,
            this.editSelected,
            this.deleteSelected,
            this.toolStripSeparator2,
            this.refreshButton});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
			this.toolStrip.Size = new System.Drawing.Size(669, 28);
			this.toolStrip.TabIndex = 5;
			this.toolStrip.Text = "crownToolStrip1";
			// 
			// queryWizard
			// 
			this.queryWizard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.queryWizard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.queryWizard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.queryWizard.Image = global::Pro_Estate.Properties.Resources.query_wizard;
			this.queryWizard.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.queryWizard.Name = "queryWizard";
			this.queryWizard.Size = new System.Drawing.Size(23, 25);
			this.queryWizard.Text = "Майстер запитів";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
			// 
			// addNew
			// 
			this.addNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.addNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.addNew.Image = global::Pro_Estate.Properties.Resources.new_data;
			this.addNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.addNew.Name = "addNew";
			this.addNew.Size = new System.Drawing.Size(97, 25);
			this.addNew.Text = "Новий запис";
			this.addNew.Click += new System.EventHandler(this.addNew_Click);
			// 
			// editSelected
			// 
			this.editSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.editSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.editSelected.Image = global::Pro_Estate.Properties.Resources.pencil;
			this.editSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.editSelected.Name = "editSelected";
			this.editSelected.Size = new System.Drawing.Size(87, 25);
			this.editSelected.Text = "Редагувати";
			this.editSelected.Click += new System.EventHandler(this.editSelected_Click);
			// 
			// removeSelected
			// 
			this.deleteSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.deleteSelected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.deleteSelected.Image = global::Pro_Estate.Properties.Resources.delete;
			this.deleteSelected.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.deleteSelected.Name = "removeSelected";
			this.deleteSelected.Size = new System.Drawing.Size(79, 25);
			this.deleteSelected.Text = "Видалити";
			this.deleteSelected.Click += new System.EventHandler(this.removeSelected_Click);
			// 
			// refreshButton
			// 
			this.refreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.refreshButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.refreshButton.Image = global::Pro_Estate.Properties.Resources.arrow_refresh;
			this.refreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.refreshButton.Name = "refreshButton";
			this.refreshButton.Size = new System.Drawing.Size(75, 25);
			this.refreshButton.Text = "Оновити";
			this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
			// 
			// DockTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Table);
			this.Controls.Add(this.toolStrip);
			this.Name = "DockTable";
			this.Size = new System.Drawing.Size(669, 413);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView Table;
		private ReaLTaiizor.Controls.CrownToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton queryWizard;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton addNew;
		private System.Windows.Forms.ToolStripButton editSelected;
		private System.Windows.Forms.ToolStripButton deleteSelected;
		private System.Windows.Forms.ToolStripButton refreshButton;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}
