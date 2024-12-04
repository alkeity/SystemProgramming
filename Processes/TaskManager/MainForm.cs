using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TaskManager
{
	public partial class MainForm : Form
	{
		Dictionary<int, Process> allProcesses;

		public MainForm()
		{
			InitializeComponent();
			LoadProcesses();
		}

		private void LoadProcesses()
		{
			allProcesses = Process.GetProcesses().ToDictionary(x => x.Id);
			AddProcesses();
			toolStripProcessAmount.Text = allProcesses.Count.ToString();
		}

		private void AddProcesses()
		{
			foreach (Process process in allProcesses.Values)
			{
				if (!listViewProcesses.Items.ContainsKey(process.Id.ToString()))
				{
					ListViewItem item = new ListViewItem(new string[] { process.Id.ToString(), process.ProcessName });
					item.Name = item.Text = process.Id.ToString();
					listViewProcesses.Items.Add(item);
				}
			}
		}

		private void RemoveProcesses()
		{
			foreach (ListViewItem item in listViewProcesses.Items)
			{
				if (!allProcesses.ContainsKey(Convert.ToInt32(item.Name))) { listViewProcesses.Items.Remove(item); }
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}

		private void timer_Tick(object sender, EventArgs e)
		{
			LoadProcesses();
			RemoveProcesses();
			toolStripProcessAmount.Text = allProcesses.Count.ToString();
		}

		private void startNewProcessToolStripMenuItem_Click(object sender, EventArgs e)
		{
			RunFileDlg(this.Handle, IntPtr.Zero, "C:\\Windows\\System32\\", null, null, null);
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
