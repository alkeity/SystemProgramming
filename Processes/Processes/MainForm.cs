using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Processes
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			string[] userInput = comboProgram.Text.Split(' ');
			string programName = userInput[0];
			string args = "";
			for (int i = 1; i < userInput.Length; i++) { args += userInput[i]; }

			process.StartInfo.FileName = programName;
			process.StartInfo.Arguments = args;

			try
			{
				process.Start();
				if (!comboProgram.Items.Contains(comboProgram.Text))
				{
					comboProgram.Items.Add(comboProgram.Text);
				}
			}
			catch (Win32Exception ex) { MessageBox.Show(ex.Message); }
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
