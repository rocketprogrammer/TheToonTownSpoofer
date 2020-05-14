using System;
using System.Diagnostics;
using System.Security.Permissions;

namespace ns29
{
	// Token: 0x020004D8 RID: 1240
	internal static class Class525
	{
		// Token: 0x06002E29 RID: 11817 RVA: 0x000B0BF0 File Offset: 0x000AEDF0
		[DebuggerStepThrough]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static IntPtr smethod_0(this Process p)
		{
			IntPtr result;
			try
			{
				result = p.MainWindowHandle;
			}
			catch
			{
				result = IntPtr.Zero;
			}
			return result;
		}

		// Token: 0x06002E2A RID: 11818 RVA: 0x000B0C20 File Offset: 0x000AEE20
		[DebuggerStepThrough]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static string smethod_1(this Process p)
		{
			string result;
			try
			{
				result = p.MainWindowTitle;
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}

		// Token: 0x06002E2B RID: 11819 RVA: 0x000B0C50 File Offset: 0x000AEE50
		[DebuggerStepThrough]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static string smethod_2(this Process p)
		{
			string result;
			try
			{
				result = p.ProcessName;
			}
			catch
			{
				result = string.Empty;
			}
			return result;
		}
	}
}
