using System;
using System.Diagnostics;
using System.Security.Permissions;
using ns17;
using ns23;

namespace ns29
{
	// Token: 0x020004C1 RID: 1217
	internal static class Class512
	{
		// Token: 0x06002DA6 RID: 11686 RVA: 0x000AF5CC File Offset: 0x000AD7CC
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static void smethod_0(string directory)
		{
			if (string.IsNullOrEmpty(directory))
			{
				return;
			}
			try
			{
				using (Process.Start(new ProcessStartInfo("explorer.exe")
				{
					Arguments = string.Format(Class217.cultureInfo_0, "/root,\"{0}\"", new object[]
					{
						directory
					})
				}))
				{
				}
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format(Class217.cultureInfo_0, "Directory: '{0}'", new object[]
					{
						directory
					})
				});
				DialogBox.smethod_4("There has been an error opening Explorer, check the log for more details.", "Error Opening Explorer");
			}
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x000AF684 File Offset: 0x000AD884
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static void smethod_1(string sFilePath)
		{
			if (string.IsNullOrEmpty(sFilePath))
			{
				return;
			}
			try
			{
				using (Process.Start(new ProcessStartInfo("explorer.exe")
				{
					Arguments = string.Format(Class217.cultureInfo_0, "/select,\"{0}\"", new object[]
					{
						sFilePath
					})
				}))
				{
				}
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format(Class217.cultureInfo_0, "File: '{0}'", new object[]
					{
						sFilePath
					})
				});
				DialogBox.smethod_4("There has been an error opening Explorer, check the log for more details.", "Error Opening Explorer");
			}
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x000AF73C File Offset: 0x000AD93C
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static void smethod_2(string url)
		{
			try
			{
				using (Process.Start(url))
				{
				}
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format(Class217.cultureInfo_0, "URL: '{0}'", new object[]
					{
						url
					})
				});
				try
				{
					Process.Start("iexplore.exe", url);
				}
				catch (Exception ex2)
				{
					ex2.smethod_1(new object[]
					{
						string.Format(Class217.cultureInfo_0, "URL: '{0}'", new object[]
						{
							url
						})
					});
					DialogBox.smethod_4(string.Format("There was an error browsing to: '{0}'.", url), "Error Opening Browser");
				}
			}
		}
	}
}
