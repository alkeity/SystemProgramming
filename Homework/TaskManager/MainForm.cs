using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class MainForm : Form
	{
		ListViewColumnSorter lvColumnSorter;
		HashSet<int> hiddenColumns;

		public MainForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			topmostToolStripMenuItem.Checked = Properties.Settings.Default.Topmost;
			this.TopMost = topmostToolStripMenuItem.Checked;
			hideWhenMinimizedToolStripMenuItem.Checked = Properties.Settings.Default.HideInTaskbar;

			hiddenColumns = new HashSet<int>();

			lvColumnSorter = new ListViewColumnSorter();
			lvProcesses.ListViewItemSorter = lvColumnSorter;
		}

		private void AddProcesses(Dictionary<int, Process> processes)
		{
			string path;
			foreach (Process process in processes.Values)
			{
				if (!lvProcesses.Items.ContainsKey(process.Id.ToString()))
				{
					try { path = process.MainModule.FileName; }
					catch (Win32Exception) { path = ""; }

					string[] processInfo = {
										process.ProcessName, process.Id.ToString(),
										process.Responding == true ? "Responding" : "Not responding",
										TMHelper.GetProcessOwner(process), "", "", path
											};
					ListViewItem item = new ListViewItem(processInfo) { Name = process.Id.ToString() };
					lvProcesses.Items.Add(item);
				}
			}
		}

		private	void RemoveProcesses(Dictionary<int, Process> processes)
		{
			foreach (ListViewItem item in lvProcesses.Items)
			{
				if (!processes.ContainsKey(Convert.ToInt32(item.Name))) { lvProcesses.Items.Remove(item); }
			}
		}

		private void FillProcessList()
		{
			Dictionary<int, Process> processes = Process.GetProcesses().ToDictionary(x => x.Id);
			AddProcesses(processes);
			labelProcessAmount.Text = processes.Count.ToString();
		}

		private void UpdateProcessList()
		{
			Dictionary<int, Process> processes = Process.GetProcesses().ToDictionary(x => x.Id);
			AddProcesses(processes);
			RemoveProcesses(processes);
			labelProcessAmount.Text = processes.Count.ToString();
		}

		private void SetColumnsAutosize()
		{
			foreach (ColumnHeader ch in lvProcesses.Columns)
			{
				if (!hiddenColumns.Contains(ch.Index)) ch.Width = -2;
			}
		}

		private void ChangeColumnVisibility(int index, bool visible)
		{
			if (visible)
			{
				hiddenColumns.Remove(index);
				lvProcesses.Columns[index].DisplayIndex = index;
			}
			else
			{
				hiddenColumns.Add(index);
				lvProcesses.Columns[index].DisplayIndex = 0;
				lvProcesses.Columns[index].Width = 0;
			}
			SetColumnsAutosize();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			fastToolStripMenuItem.Tag = TMHelper.refreshRateFast;
			normalToolStripMenuItem.Tag = TMHelper.refreshRateNormal;
			slowToolStripMenuItem.Tag = TMHelper.refreshRateSlow;
			pausedToolStripMenuItem.Tag = TMHelper.refreshRatePaused;

			timerUpdate.Interval = TMHelper.refreshRateNormal;
			toolStripRefresh.Text = TMHelper.GetRefreshRateText(timerUpdate.Interval);

			FillProcessList();
			SetColumnsAutosize();
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (hideWhenMinimizedToolStripMenuItem.Checked && this.WindowState == FormWindowState.Minimized) this.ShowInTaskbar = false;
			else this.ShowInTaskbar = true;
		}

		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			UpdateProcessList();
		}

		private void lwProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == lvColumnSorter.SortColumn)
			{
				lvColumnSorter.Order = lvColumnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
			}
			else
			{
				lvColumnSorter.SortColumn = e.Column;
				lvColumnSorter.Order = SortOrder.Ascending;
			}
			lvProcesses.Sort();
		}

		private void lvProcesses_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
		{
			if (hiddenColumns.Contains(e.ColumnIndex))
			{
				e.Cancel = true;
				e.NewWidth = 0;
			}
		}

		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			this.WindowState = FormWindowState.Normal;
			this.Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void topmostToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.TopMost = topmostToolStripMenuItem.Checked;
			Properties.Settings.Default.Topmost = topmostToolStripMenuItem.Checked;
			Properties.Settings.Default.Save();
		}

		private void hideWhenMinimizedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.HideInTaskbar = hideWhenMinimizedToolStripMenuItem.Checked;
			Properties.Settings.Default.Save();
		}

		private void startNewProcessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", null, null, null);
		}

		private void updateNowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			UpdateProcessList();
		}

		private void KillTasks(object sender, EventArgs e)
		{
			for (int i = 0; i < lvProcesses.SelectedItems.Count; i++)
			{
				Process process = Process.GetProcessById(Convert.ToInt32(lvProcesses.SelectedItems[i].SubItems[1].Text));
				process.Kill();
			}
			UpdateProcessList();
		}

		private void refreshRatesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToolStripMenuItem checkedItem = sender as ToolStripMenuItem;

			foreach (ToolStripMenuItem item in refreshRateToolStripMenuItem.DropDownItems) item.Checked = false;
			checkedItem.Checked = true;
			timerUpdate.Interval = Convert.ToInt32(checkedItem.Tag);
			timerUpdate.Enabled = timerUpdate.Interval > 1 ? true : false;
			toolStripRefresh.Text = TMHelper.GetRefreshRateText(timerUpdate.Interval);
		}

		private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string procPath = Process.GetProcessById(Convert.ToInt32(lvProcesses.SelectedItems[0].Name)).MainModule.FileName;
				Process.Start(new ProcessStartInfo("explorer.exe", $"/select, \"{procPath}\""));
			}
			catch (Win32Exception)
			{
				MessageBox.Show("Access denied.");
			}
		}

		private void ContextMenuColumnsItemClick(object sender, EventArgs e)
		{
			ToolStripMenuItem item = sender as ToolStripMenuItem;
			ChangeColumnVisibility(Convert.ToInt32(item.Tag), item.Checked);
		}


		[DllImport("shell32.dll", EntryPoint = "#61", CharSet = CharSet.Unicode)]
		public static extern int RunFileDlg(
			[In] IntPtr hwnd,
			[In] IntPtr icon,
			[In] string path,
			[In] string title,
			[In] string prompt,
			[In] string flags
			);
	}
}
