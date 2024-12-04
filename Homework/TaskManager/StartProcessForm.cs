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
	public partial class StartProcessForm : Form
	{
		public StartProcessForm(bool topmost)
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			this.TopMost = topmost;
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (comboProcess.Text != "")
			{
				string[] userInput = comboProcess.Text.Split(' ');
				string programName = userInput[0];
				string args = "";
				for (int i = 1; i < userInput.Length; i++) { args += $"{userInput[i]} "; }

				process.StartInfo.FileName = programName;
				process.StartInfo.Arguments = args;
				try
				{
					process.Start();
					this.Close();
				}
				catch (Win32Exception ex) 
				{
					//MessageBox.Show(ex.Message);
				}
				catch (Exception ex) 
				{ 
					//MessageBox.Show(ex.Message); 
				}
			}
		}
	}
}
