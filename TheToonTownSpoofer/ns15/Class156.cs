using System;
using System.Collections;
using System.Diagnostics;
using System.Security.Permissions;

namespace ns15
{
	// Token: 0x02000203 RID: 515
	internal static class Class156
	{
		// Token: 0x060016BF RID: 5823 RVA: 0x000372BC File Offset: 0x000354BC
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static string smethod_0()
		{
			string fileName;
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				fileName = currentProcess.MainModule.FileName;
			}
			return fileName;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000372F8 File Offset: 0x000354F8
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static int smethod_1()
		{
			int id;
			using (Process currentProcess = Process.GetCurrentProcess())
			{
				id = currentProcess.Id;
			}
			return id;
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00037330 File Offset: 0x00035530
		public static int smethod_2(string processName)
		{
			foreach (Process process in Class156.smethod_3(processName))
			{
				process.Dispose();
			}
			Process[] array;
			return array.Length;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x00037360 File Offset: 0x00035560
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static Process[] smethod_3(string processName)
		{
			if (processName == null)
			{
				processName = string.Empty;
			}
			ArrayList arrayList = new ArrayList();
			foreach (Process process in Process.GetProcesses())
			{
				if (string.Equals(processName, process.ProcessName, StringComparison.OrdinalIgnoreCase))
				{
					arrayList.Add(process);
				}
				else
				{
					process.Dispose();
				}
			}
			Process[] array = new Process[arrayList.Count];
			arrayList.CopyTo(array, 0);
			return array;
		}
	}
}
