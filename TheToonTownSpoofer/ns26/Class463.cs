using System;
using System.Diagnostics;

namespace ns26
{
	// Token: 0x02000453 RID: 1107
	internal static class Class463
	{
		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06002985 RID: 10629 RVA: 0x0009F554 File Offset: 0x0009D754
		public static bool DesignMode
		{
			get
			{
				bool result;
				using (Process currentProcess = Process.GetCurrentProcess())
				{
					result = (currentProcess.ProcessName.ToLower() == "devenv");
				}
				return result;
			}
		}
	}
}
