using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Processes2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Process[] allProcs = Process.GetProcesses();
			for (int i = 0; i < allProcs.Length; i++)
			{
				Console.WriteLine($"{allProcs[i].Id}\t{allProcs[i].ProcessName}");
			}
		}
	}
}
