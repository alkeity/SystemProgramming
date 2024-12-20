﻿using System;
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
		ListViewColumnSorter columnSorter;

		public MainForm()
		{
			InitializeComponent();
			columnSorter = new ListViewColumnSorter();
			listViewProcesses.ListViewItemSorter = columnSorter;
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
					ListViewItem item = new ListViewItem(new string[] { process.ProcessName, process.Id.ToString() });
					item.Name = process.Id.ToString();
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
			foreach (ColumnHeader ch in listViewProcesses.Columns)
			{
				ch.Width = -2;
			}
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

		private void contextMenuProcList_Opening(object sender, CancelEventArgs e)
		{
			openSourceToolStripMenuItem.Enabled = listViewProcesses.SelectedItems.Count > 0 ? true : false;
			endTaskToolStripMenuItem.Enabled = listViewProcesses.SelectedItems.Count > 0 ? true : false;
		}

		private void endTaskToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < listViewProcesses.SelectedItems.Count; i++)
			{
				Process process = Process.GetProcessById(Convert.ToInt32(listViewProcesses.SelectedItems[i].Name));
				process.Kill();
			}
		}

		private void openSourceToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (listViewProcesses.SelectedItems.Count > 0)
			{
				string procPath = Process.GetProcessById(Convert.ToInt32(listViewProcesses.SelectedItems[0].Name)).MainModule.FileName;
				Process.Start(new ProcessStartInfo("explorer.exe", $"/select, \"{procPath}\""));
			}
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

		private void listViewProcesses_ColumnClick(object sender, ColumnClickEventArgs e)
		{
			if (e.Column == columnSorter.SortColumn)
			{
				columnSorter.Order = columnSorter.Order == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
			}
			else
			{
				columnSorter.SortColumn = e.Column;
				columnSorter.Order = SortOrder.Ascending;
			}
			listViewProcesses.Sort();
		}
	}
}
