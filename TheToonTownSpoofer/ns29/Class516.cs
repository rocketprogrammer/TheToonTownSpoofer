using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns23;
using ns26;

namespace ns29
{
	// Token: 0x020004C8 RID: 1224
	internal static class Class516
	{
		// Token: 0x06002DD9 RID: 11737 RVA: 0x00016100 File Offset: 0x00014300
		static Class516()
		{
			Application.ApplicationExit += Class516.smethod_3;
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x000AFDA4 File Offset: 0x000ADFA4
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static void smethod_0(Class515 data)
		{
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = Class110.Instance.MakePackageSettings.Panda3dPath;
			processStartInfo.WorkingDirectory = Path.GetDirectoryName(Class110.Instance.MakePackageSettings.Panda3dPath);
			processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
			processStartInfo.UseShellExecute = true;
			processStartInfo.Arguments = string.Format("\"{0}\"", data.ModelPath);
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process process = null;
			try
			{
				process = new Process();
				process.StartInfo = processStartInfo;
				process.EnableRaisingEvents = true;
				process.Exited += Class516.smethod_1;
				lock (((ICollection)Class516.dictionary_0).SyncRoot)
				{
					Class516.dictionary_0.Add(process, data);
				}
				process.Start();
			}
			catch
			{
				if (process != null)
				{
					process.Dispose();
				}
				throw;
			}
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x000AFEA8 File Offset: 0x000AE0A8
		private static void smethod_1(object sender, EventArgs e)
		{
			lock (((ICollection)Class516.dictionary_0).SyncRoot)
			{
				Process process = sender as Process;
				Class516.smethod_2(process, Class516.dictionary_0[process]);
				Class516.dictionary_0.Remove(process);
				if (Class516.manualResetEventSlim_0 != null && Class516.dictionary_0.Count == 0)
				{
					Class516.manualResetEventSlim_0.Set();
				}
			}
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x000AFF28 File Offset: 0x000AE128
		private static void smethod_2(Process p, Class515 data)
		{
			p.Dispose();
			foreach (string fileName in data.ImagePaths)
			{
				Class369.smethod_3(fileName);
			}
			foreach (string directory in data.Directories)
			{
				Class369.smethod_0(directory);
			}
		}

		// Token: 0x06002DDD RID: 11741 RVA: 0x000AFFC8 File Offset: 0x000AE1C8
		private static void smethod_3(object sender, EventArgs e)
		{
			lock (((ICollection)Class516.dictionary_0).SyncRoot)
			{
				using (Class516.manualResetEventSlim_0 = new ManualResetEventSlim(false))
				{
					bool flag2 = Class516.dictionary_0.Count > 0;
					IEnumerable<Process> col = Class516.dictionary_0.Keys.ToArray<Process>();
					if (Class516.action_0 == null)
					{
						Class516.action_0 = new Action<Process>(Class516.smethod_4);
					}
					col.smethod_7(Class516.action_0);
					if (flag2)
					{
						Class516.manualResetEventSlim_0.Wait(10000);
					}
				}
			}
		}

		// Token: 0x06002DDE RID: 11742 RVA: 0x000B0080 File Offset: 0x000AE280
		[CompilerGenerated]
		private static void smethod_4(Process item)
		{
			try
			{
				item.CloseMainWindow();
				item.WaitForExit(5000);
			}
			catch (Exception ex)
			{
				ex.smethod_0();
			}
		}

		// Token: 0x04001816 RID: 6166
		private static ManualResetEventSlim manualResetEventSlim_0;

		// Token: 0x04001817 RID: 6167
		private static Dictionary<Process, Class515> dictionary_0 = new Dictionary<Process, Class515>();

		// Token: 0x04001818 RID: 6168
		[CompilerGenerated]
		private static Action<Process> action_0;
	}
}
