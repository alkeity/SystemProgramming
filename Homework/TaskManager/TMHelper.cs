using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace TaskManager
{
	static internal class TMHelper
	{
		static internal readonly int refreshRateNormal = 1000;
		static internal readonly int refreshRateSlow = 2000;
		static internal readonly int refreshRateFast = 500;
		static internal readonly int refreshRatePaused = 1;

		static internal string GetRefreshRateText(int interval)
		{
			string result = "Refresh rate: ";
			result += interval == refreshRateNormal ? "Normal" :
					  interval == refreshRateFast ? "Fast" :
					  interval == refreshRateSlow ? "Slow" :
					  "Paused";
			return result;
		}

		static internal string GetProcessOwner(Process process)
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

		[DllImport("advapi32.dll", SetLastError = true)]
		private static extern bool OpenProcessToken(IntPtr ProcessHandle, uint DesiredAccess, out IntPtr TokenHandle);
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CloseHandle(IntPtr hObject);
	}
}
