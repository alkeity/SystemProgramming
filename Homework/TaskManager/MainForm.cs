using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
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
										GetProcessOwner(process), path
											};
					ListViewItem item = new ListViewItem(processInfo);
					item.Name = process.Id.ToString();
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

		private void SetRefreshRateText()
		{
			toolStripRefresh.Text = timerUpdate.Interval == 1000 ? "Normal" :
									timerUpdate.Interval == 500 ? "Fast" :
									timerUpdate.Interval == 2000 ? "Slow" :
									"Paused";
		}

		private void SetColumnsAutosize()
		{
			foreach (ColumnHeader ch in lvProcesses.Columns)
			{
				ch.Width = -2;
			}
		}

		private string GetProcessOwner(Process process)
		{
			string username;
			IntPtr processHandle = IntPtr.Zero;
			try
			{
				OpenProcessToken(process.Handle, 8, out processHandle);
				using (WindowsIdentity wi = new WindowsIdentity(processHandle))
				{
					username = wi.Name.Contains(@"\") ? wi.Name.Substring(wi.Name.IndexOf(@"\") + 1) : wi.Name;
				}
			}
			catch (Win32Exception) { username = ""; }
			finally
			{
				if (processHandle != IntPtr.Zero) CloseHandle(processHandle);
			}
			return username;
		}

		private void ChangeColumnVisibility(int index, bool visible)
		{
			if (visible)
			{
				lvProcesses.Columns[index].DisplayIndex = index;
				lvProcesses.Columns[index].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
				hiddenColumns.Remove(index);
			}
			else
			{
				lvProcesses.Columns[index].DisplayIndex = 0;
				lvProcesses.Columns[index].Width = 0;
				hiddenColumns.Add(index);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			FillProcessList();
			SetRefreshRateText();
			SetColumnsAutosize();
		}

		private void MainForm_Resize(object sender, EventArgs e)
		{
			if (hideWhenMinimizedToolStripMenuItem.Checked && this.WindowState == FormWindowState.Minimized)
			{
				this.ShowInTaskbar = false;
			}
			else this.ShowInTaskbar = true;
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
			topmostToolStripMenuItem.Checked = !topmostToolStripMenuItem.Checked;
			this.TopMost = topmostToolStripMenuItem.Checked;
			Properties.Settings.Default.Topmost = topmostToolStripMenuItem.Checked;
			Properties.Settings.Default.Save();
		}

		private void hideWhenMinimizedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			hideWhenMinimizedToolStripMenuItem.Checked = !hideWhenMinimizedToolStripMenuItem.Checked;
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

		private void btnEndTask_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < lvProcesses.SelectedItems.Count; i++)
			{
				Process process = Process.GetProcessById(Convert.ToInt32(lvProcesses.SelectedItems[i].SubItems[1].Text));
				process.Kill();
			}
			FillProcessList();
		}

		private void normalToolStripMenuItem_Click(object sender, EventArgs e)
		{
			normalToolStripMenuItem.Checked = true;
			highToolStripMenuItem.Checked = lowToolStripMenuItem.Checked = pausedToolStripMenuItem.Checked = false;
			timerUpdate.Enabled = true;
			timerUpdate.Interval = 1000;
			SetRefreshRateText();
		}

		private void highToolStripMenuItem_Click(object sender, EventArgs e)
		{
			highToolStripMenuItem.Checked = true;
			normalToolStripMenuItem.Checked = lowToolStripMenuItem.Checked = pausedToolStripMenuItem.Checked = false;
			timerUpdate.Enabled = true;
			timerUpdate.Interval = 500;
			SetRefreshRateText();
		}

		private void lowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lowToolStripMenuItem.Checked = true;
			normalToolStripMenuItem.Checked = highToolStripMenuItem.Checked = pausedToolStripMenuItem.Checked = false;
			timerUpdate.Enabled = true;
			timerUpdate.Interval = 2000;
			SetRefreshRateText();
		}

		private void pausedToolStripMenuItem_Click(object sender, EventArgs e)
		{
			pausedToolStripMenuItem.Checked = true;
			normalToolStripMenuItem.Checked = lowToolStripMenuItem.Checked = highToolStripMenuItem.Checked = false;
			timerUpdate.Enabled = false;
			SetRefreshRateText();
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

		private void endTaskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < lvProcesses.SelectedItems.Count; i++)
			{
				Process process = Process.GetProcessById(Convert.ToInt32(lvProcesses.SelectedItems[i].Name));
				process.Kill();
			}
		}

		private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (lvProcesses.SelectedItems.Count > 0)
			{
				string procPath = Process.GetProcessById(Convert.ToInt32(lvProcesses.SelectedItems[0].Name)).MainModule.FileName;
				Process.Start(new ProcessStartInfo("explorer.exe", $"/select, \"{procPath}\""));
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

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr hObject);
	}
}
