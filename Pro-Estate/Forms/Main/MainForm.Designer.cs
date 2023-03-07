namespace Pro_Estate
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.stausStrip = new ReaLTaiizor.Controls.CrownStatusStrip();
			this.connectionStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.crownMenuStrip1 = new ReaLTaiizor.Controls.CrownMenuStrip();
			this.fileToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.вікноToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.queriesWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.accountWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.допомогаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showGreetingTab = new System.Windows.Forms.ToolStripMenuItem();
			this.instructionItem = new System.Windows.Forms.ToolStripMenuItem();
			this.проПрограмуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adminMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.adminDatabaseItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createNewDB = new System.Windows.Forms.ToolStripMenuItem();
			this.crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
			this.DockPanel = new ReaLTaiizor.Docking.Crown.CrownDockPanel();
			this.selectDBItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dbOpen = new System.Windows.Forms.OpenFileDialog();
			this.stausStrip.SuspendLayout();
			this.crownMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// stausStrip
			// 
			this.stausStrip.AutoSize = false;
			this.stausStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.stausStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.stausStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatus});
			this.stausStrip.Location = new System.Drawing.Point(0, 676);
			this.stausStrip.Name = "stausStrip";
			this.stausStrip.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
			this.stausStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.stausStrip.Size = new System.Drawing.Size(1153, 24);
			this.stausStrip.SizingGrip = false;
			this.stausStrip.TabIndex = 0;
			this.stausStrip.Text = "statusStrip";
			// 
			// connectionStatus
			// 
			this.connectionStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.connectionStatus.Margin = new System.Windows.Forms.Padding(0);
			this.connectionStatus.Name = "connectionStatus";
			this.connectionStatus.Size = new System.Drawing.Size(99, 16);
			this.connectionStatus.Text = "connectionStatus";
			// 
			// crownMenuStrip1
			// 
			this.crownMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.crownMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenu,
            this.вікноToolStripMenuItem,
            this.допомогаToolStripMenuItem,
            this.adminMenu});
			this.crownMenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.crownMenuStrip1.Name = "crownMenuStrip1";
			this.crownMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
			this.crownMenuStrip1.Size = new System.Drawing.Size(1153, 24);
			this.crownMenuStrip1.TabIndex = 2;
			this.crownMenuStrip1.Text = "crownMenuStrip1";
			// 
			// fileToolStripMenu
			// 
			this.fileToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.fileToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeMenuItem});
			this.fileToolStripMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.fileToolStripMenu.Name = "fileToolStripMenu";
			this.fileToolStripMenu.Size = new System.Drawing.Size(48, 20);
			this.fileToolStripMenu.Text = "Файл";
			// 
			// closeMenuItem
			// 
			this.closeMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.closeMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.closeMenuItem.Name = "closeMenuItem";
			this.closeMenuItem.Size = new System.Drawing.Size(178, 22);
			this.closeMenuItem.Text = "Завершити роботу";
			this.closeMenuItem.Click += new System.EventHandler(this.Close_Click);
			// 
			// вікноToolStripMenuItem
			// 
			this.вікноToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.вікноToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queriesWindow,
            this.accountWindow});
			this.вікноToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.вікноToolStripMenuItem.Name = "вікноToolStripMenuItem";
			this.вікноToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
			this.вікноToolStripMenuItem.Text = "Вікно";
			// 
			// queriesWindow
			// 
			this.queriesWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.queriesWindow.Checked = true;
			this.queriesWindow.CheckOnClick = true;
			this.queriesWindow.CheckState = System.Windows.Forms.CheckState.Checked;
			this.queriesWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.queriesWindow.Image = global::Pro_Estate.Properties.Resources.query_design;
			this.queriesWindow.Name = "queriesWindow";
			this.queriesWindow.Size = new System.Drawing.Size(167, 22);
			this.queriesWindow.Text = "Готові запити";
			this.queriesWindow.Click += new System.EventHandler(this.queriesWindow_Click);
			// 
			// accountWindow
			// 
			this.accountWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.accountWindow.Checked = true;
			this.accountWindow.CheckOnClick = true;
			this.accountWindow.CheckState = System.Windows.Forms.CheckState.Checked;
			this.accountWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.accountWindow.Image = global::Pro_Estate.Properties.Resources.user_green;
			this.accountWindow.Name = "accountWindow";
			this.accountWindow.Size = new System.Drawing.Size(167, 22);
			this.accountWindow.Text = "Обліковий запис";
			this.accountWindow.Click += new System.EventHandler(this.accountWindow_Click);
			// 
			// допомогаToolStripMenuItem
			// 
			this.допомогаToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.допомогаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGreetingTab,
            this.instructionItem,
            this.проПрограмуToolStripMenuItem});
			this.допомогаToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.допомогаToolStripMenuItem.Name = "допомогаToolStripMenuItem";
			this.допомогаToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.допомогаToolStripMenuItem.Text = "Допомога";
			// 
			// showGreetingTab
			// 
			this.showGreetingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.showGreetingTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.showGreetingTab.Name = "showGreetingTab";
			this.showGreetingTab.Size = new System.Drawing.Size(154, 22);
			this.showGreetingTab.Text = "Привітання";
			this.showGreetingTab.Click += new System.EventHandler(this.showGreetingTab_Click);
			// 
			// instructionItem
			// 
			this.instructionItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.instructionItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.instructionItem.Name = "instructionItem";
			this.instructionItem.Size = new System.Drawing.Size(154, 22);
			this.instructionItem.Text = "Інструкція";
			this.instructionItem.Click += new System.EventHandler(this.instructionItem_Click);
			// 
			// проПрограмуToolStripMenuItem
			// 
			this.проПрограмуToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.проПрограмуToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
			this.проПрограмуToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.проПрограмуToolStripMenuItem.Text = "Про програму";
			this.проПрограмуToolStripMenuItem.Click += new System.EventHandler(this.проПрограмуToolStripMenuItem_Click);
			// 
			// adminMenu
			// 
			this.adminMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.adminMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminDatabaseItem});
			this.adminMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.adminMenu.Name = "adminMenu";
			this.adminMenu.Size = new System.Drawing.Size(111, 20);
			this.adminMenu.Text = "Адміністрування";
			// 
			// adminDatabaseItem
			// 
			this.adminDatabaseItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.adminDatabaseItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewDB,
            this.selectDBItem});
			this.adminDatabaseItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.adminDatabaseItem.Name = "adminDatabaseItem";
			this.adminDatabaseItem.Size = new System.Drawing.Size(180, 22);
			this.adminDatabaseItem.Text = "База даних";
			// 
			// createNewDB
			// 
			this.createNewDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.createNewDB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.createNewDB.Name = "createNewDB";
			this.createNewDB.Size = new System.Drawing.Size(180, 22);
			this.createNewDB.Text = "Створити нову";
			this.createNewDB.Click += new System.EventHandler(this.createNewDB_Click);
			// 
			// crownContextMenuStrip1
			// 
			this.crownContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.crownContextMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.crownContextMenuStrip1.Name = "crownContextMenuStrip1";
			this.crownContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// DockPanel
			// 
			this.DockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.DockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DockPanel.Location = new System.Drawing.Point(0, 24);
			this.DockPanel.Name = "DockPanel";
			this.DockPanel.Size = new System.Drawing.Size(1153, 652);
			this.DockPanel.TabIndex = 5;
			this.DockPanel.ContentAdded += new System.EventHandler<ReaLTaiizor.Docking.Crown.DockContentEventArgs>(this.DockPanel_ContentAdded);
			this.DockPanel.ContentRemoved += new System.EventHandler<ReaLTaiizor.Docking.Crown.DockContentEventArgs>(this.DockPanel_ContentRemoved);
			// 
			// selectDBItem
			// 
			this.selectDBItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.selectDBItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.selectDBItem.Name = "selectDBItem";
			this.selectDBItem.Size = new System.Drawing.Size(180, 22);
			this.selectDBItem.Text = "Вибрати існуючу";
			this.selectDBItem.Click += new System.EventHandler(this.selectDBItem_Click);
			// 
			// dbOpen
			// 
			this.dbOpen.Filter = "Database files|*.mdf|All files|*.*";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1153, 700);
			this.Controls.Add(this.DockPanel);
			this.Controls.Add(this.stausStrip);
			this.Controls.Add(this.crownMenuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.crownMenuStrip1;
			this.Name = "MainForm";
			this.Text = "Pro-Estate";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.stausStrip.ResumeLayout(false);
			this.stausStrip.PerformLayout();
			this.crownMenuStrip1.ResumeLayout(false);
			this.crownMenuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ReaLTaiizor.Controls.CrownStatusStrip stausStrip;
		private ReaLTaiizor.Controls.CrownMenuStrip crownMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenu;
		private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
		private ReaLTaiizor.Docking.Crown.CrownDockPanel DockPanel;
		private System.Windows.Forms.ToolStripMenuItem closeMenuItem;
		private System.Windows.Forms.ToolStripStatusLabel connectionStatus;
		private System.Windows.Forms.ToolStripMenuItem допомогаToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createNewDB;
		private System.Windows.Forms.ToolStripMenuItem проПрограмуToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem вікноToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem queriesWindow;
		private System.Windows.Forms.ToolStripMenuItem showGreetingTab;
		private System.Windows.Forms.ToolStripMenuItem accountWindow;
		private System.Windows.Forms.ToolStripMenuItem adminMenu;
		private System.Windows.Forms.ToolStripMenuItem adminDatabaseItem;
		private System.Windows.Forms.ToolStripMenuItem instructionItem;
		private System.Windows.Forms.ToolStripMenuItem selectDBItem;
		private System.Windows.Forms.OpenFileDialog dbOpen;
	}
}

