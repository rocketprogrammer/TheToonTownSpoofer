using System;
using System.Threading;
using ns31;
using TSN.Native;
using TSN.Native.Enums;

namespace ns23
{
	// Token: 0x020003A3 RID: 931
	internal static class Class372
	{
		// Token: 0x06002416 RID: 9238 RVA: 0x0007A63C File Offset: 0x0007883C
		public static string smethod_0(this NtStatus status)
		{
			string text = Class265.smethod_0(Class265.GetModuleHandle("ntdll.dll"), 11, Thread.CurrentThread.CurrentUICulture.LCID, (int)status);
			if (text != null && text.StartsWith("{"))
			{
				string[] array = text.Split(new char[]
				{
					'\n'
				});
				if (array.Length > 1)
				{
					text = array[1];
				}
			}
			return text;
		}

		// Token: 0x06002417 RID: 9239 RVA: 0x0000F91C File Offset: 0x0000DB1C
		public static bool smethod_1(this NtStatus status)
		{
			return status >= (NtStatus)3221225472U && status <= (NtStatus)4294967295U;
		}

		// Token: 0x06002418 RID: 9240 RVA: 0x0000F92F File Offset: 0x0000DB2F
		public static bool smethod_2(this NtStatus status)
		{
			return status >= NtStatus.Informational && status < (NtStatus)2147483648U;
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x0000F943 File Offset: 0x0000DB43
		public static bool smethod_3(this NtStatus status)
		{
			return status >= NtStatus.Success && status < NtStatus.Informational;
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x0000F953 File Offset: 0x0000DB53
		public static bool smethod_4(this NtStatus status)
		{
			return status >= (NtStatus)2147483648U && status < (NtStatus)3221225472U;
		}

		// Token: 0x0600241B RID: 9243 RVA: 0x0000F967 File Offset: 0x0000DB67
		public static void smethod_5(this NtStatus status)
		{
			throw new WindowsException(status);
		}

		// Token: 0x0600241C RID: 9244 RVA: 0x0000F96F File Offset: 0x0000DB6F
		public static void smethod_6(this NtStatus status)
		{
			if (status.smethod_1() || status.smethod_4())
			{
				status.smethod_5();
			}
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x0000F987 File Offset: 0x0000DB87
		public static Win32Error smethod_7(this NtStatus status)
		{
			return Class265.RtlNtStatusToDosError(status);
		}
	}
}
