using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			notifyIcon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			topmostToolStripMenuItem.Checked = Properties.Settings.Default.Topmost;
			this.TopMost = topmostToolStripMenuItem.Checked;
			hideWhenMinimizedToolStripMenuItem.Checked = Properties.Settings.Default.HideInTaskbar;
		}

		private void FillProcessList()
		{
			lwProcesses.Items.Clear();
			List<Process> allProcesses = Process.GetProcesses().Cast<Process>().ToList();
			//allProcesses.Sort( (x, y) => x.ProcessName.CompareTo(y.ProcessName) );
			foreach (Process process in allProcesses)
			{
				string[] processInfo = {
										process.ProcessName, process.Id.ToString(),
										process.Responding == true ? "Responding" : "Not responding"
				};
				lwProcesses.Items.Add(new ListViewItem(processInfo));
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			FillProcessList();
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

		}


		private void updateNowToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void btnEndTask_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < lwProcesses.SelectedItems.Count; i++)
			{
				Process process = Process.GetProcessById(Convert.ToInt32(lwProcesses.SelectedItems[i].SubItems[1].Text));
				process.Kill();
			}
			FillProcessList();
		}
	}
}
