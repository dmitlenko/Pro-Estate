using Pro_Estate.Core.Database;
using Pro_Estate.Core.Database.Tables;
using Pro_Estate.Core.Helpers;
using Pro_Estate.Forms.Main.Docking;
using Pro_Estate.Forms.Screens;
using Pro_Estate.Forms.Wizards;
using ReaLTaiizor.Docking.Crown;
using ReaLTaiizor.Forms;
using ReaLTaiizor.Native;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Pro_Estate
{
	public partial class MainForm : CrownForm
	{
		private DockAccount _dockAccount;
		private DockActions _dockActions;
		private DockBrowser _greetingTab;
		private DockBrowser _tutorialTab;
		private WindowStateInfo _windowStateInfo;

		private List<CrownDockContent> _toolWindows = new List<CrownDockContent>();

		public MainForm(ProEstateDatabase database)
		{
			InitializeComponent();
			LoadWindowState();
			Database = database;

			Application.AddMessageFilter(new ControlScrollFilter());
			Application.AddMessageFilter(DockPanel.DockContentDragFilter);
			Application.AddMessageFilter(DockPanel.DockResizeFilter);
		}

		public Account Account { get; set; }
		private ProEstateDatabase Database { get; set; }

		private bool IsDBConnected { get => Database.Connection.State == System.Data.ConnectionState.Open; }

		public void InvokeLoad() => MainForm_Load(this, EventArgs.Empty);

		private void accountWindow_Click(object sender, EventArgs e)
		{
			ToggleToolWindow(_dockAccount);
		}

		private void BuildWindowMenu()
		{
			connectionStatus.Text = IsDBConnected ? "Підключено" : "Відключено";

			queriesWindow.Checked = DockPanel.Contains(_dockActions);
			accountWindow.Checked = DockPanel.Contains(_dockAccount);

			DockPanel.Enabled = IsDBConnected;
		}

		private void Close_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void createNewDB_Click(object sender, EventArgs e)
		{
			new DatabaseWizard().ShowDialog();

			BuildWindowMenu();
		}

		private void DockPanel_ContentAdded(object sender, DockContentEventArgs e)
		{
			if (_toolWindows.Contains(e.Content))
				BuildWindowMenu();
		}

		private void DockPanel_ContentRemoved(object sender, DockContentEventArgs e)
		{
			if (_toolWindows.Contains(e.Content))
				BuildWindowMenu();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			adminMenu.Visible = Account.Level == AccountLevel.Admin;

			_dockActions = new DockActions(DockPanel, Database, Account.Level);
			_dockAccount = new DockAccount(Account);
			_greetingTab = new DockBrowser("Ласкаво просимо", Properties.Resources.pro_estate_greeting);
			_tutorialTab = new DockBrowser("Інструкція користувача", null, Properties.Resources.installer_box, false, $"file:///{Application.StartupPath}/Resources/tutorial.mht");

			_toolWindows.Add(_dockActions);
			_toolWindows.Add(_greetingTab);
			_toolWindows.Add(_dockAccount);

			DockPanel.AddContent(_dockActions);
			DockPanel.AddContent(_greetingTab);
		}

		private void queriesWindow_Click(object sender, EventArgs e)
		{
			ToggleToolWindow(_dockActions);
		}

		private void showGreetingTab_Click(object sender, EventArgs e)
		{
			if (!DockPanel.Contains(_greetingTab))
				DockPanel.AddContent(_greetingTab);
		}

		private void ToggleToolWindow(CrownToolWindow toolWindow)
		{
			if (toolWindow.DockPanel == null)
				DockPanel.AddContent(toolWindow);
			else
				DockPanel.RemoveContent(toolWindow);
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveWindowState();
		}

		private void SaveWindowState()
		{
			_windowStateInfo = new WindowStateInfo
			{
				WindowLocation = Location,
				WindowSize = Size,
				WindowState = WindowState
			};

			using (var fileStream = new FileStream("WindowState.bin", FileMode.Create))
			{
				var binaryFormatter = new BinaryFormatter();
				binaryFormatter.Serialize(fileStream, _windowStateInfo);
			}
		}

		private void LoadWindowState()
		{
			var windowStateFilePath = "WindowState.bin";
			if (File.Exists(windowStateFilePath))
			{
				using (var fileStream = new FileStream(windowStateFilePath, FileMode.Open))
				{
					var binaryFormatter = new BinaryFormatter();
					_windowStateInfo = (WindowStateInfo)binaryFormatter.Deserialize(fileStream);

					Location = _windowStateInfo.WindowLocation;
					Size = _windowStateInfo.WindowSize;
					WindowState = _windowStateInfo.WindowState;
				}
			}
		}

		private void проПрограмуToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new AboutScreen().ShowDialog();
		}

		private void instructionItem_Click(object sender, EventArgs e)
		{
			DockPanel.AddContent(_tutorialTab);
		}

		private void selectDBItem_Click(object sender, EventArgs e)
		{
			if (dbOpen.ShowDialog() == DialogResult.OK && File.Exists(dbOpen.FileName))
			{
				Database.Connection.Close();
				Properties.Settings.Default["ConnectionString"] = DatabaseHelper.ConstructConnectionString(dbOpen.FileName);
				Properties.Settings.Default.Save();

				Database.Connection.ConnectionString = Properties.Settings.Default.ConnectionString;
				Database.Connection.Open();

				BuildWindowMenu();
			}
		}
	}

	[Serializable]
	public class WindowStateInfo
	{
		public Point WindowLocation { get; set; }
		public Size WindowSize { get; set; }
		public FormWindowState WindowState { get; set; }
	}
}