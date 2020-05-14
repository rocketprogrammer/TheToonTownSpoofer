using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using ns22;
using ns23;
using ns27;
using ns28;
using ns29;
using ns30;
using ns31;
using TSN.Native.Enums;

namespace ns26
{
	// Token: 0x0200046A RID: 1130
	[ComVisible(true)]
	[EventTrackingEnabled(true)]
	internal sealed class Class471 : ServicedComponent
	{
		// Token: 0x060029F4 RID: 10740 RVA: 0x000A11C4 File Offset: 0x0009F3C4
		private static Dictionary<string, string> smethod_0()
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			Dictionary<string, string> dictionary = new Dictionary<string, string>(logicalDrives.Length);
			StringBuilder stringBuilder = new StringBuilder(Class471.int_0);
			foreach (string text in logicalDrives)
			{
				string text2 = text.Substring(0, 2);
				Class265.QueryDosDevice(text2, stringBuilder, Class471.int_0);
				dictionary.Add(Class471.smethod_1(stringBuilder.ToString()), text2);
			}
			dictionary.Add(Class471.string_1.Substring(0, Class471.string_1.Length - 1), "\\");
			return dictionary;
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x000A1258 File Offset: 0x0009F458
		private static string smethod_1(string deviceName)
		{
			if (string.Compare(deviceName, 0, Class471.string_1, 0, Class471.string_1.Length, StringComparison.InvariantCulture) == 0)
			{
				string str = deviceName.Substring(deviceName.IndexOf('\\', Class471.string_1.Length) + 1);
				return Class471.string_1 + str;
			}
			return deviceName;
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x000A12A8 File Offset: 0x0009F4A8
		public static List<FileSystemInfo> smethod_2(int processID)
		{
			ThreadStart threadStart = null;
			Class471.Class473 @class = new Class471.Class473();
			@class.int_0 = processID;
			@class.list_0 = new List<FileSystemInfo>();
			List<FileSystemInfo> result;
			try
			{
				if (threadStart == null)
				{
					threadStart = new ThreadStart(@class.method_0);
				}
				Thread thread = new Thread(threadStart);
				thread.IsBackground = true;
				thread.Start();
				if (!thread.Join(5000))
				{
					thread.Abort();
				}
				result = @class.list_0.Distinct(new Class488()).ToList<FileSystemInfo>();
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					Class471.string_0 + @class.int_0.ToString()
				});
				result = null;
			}
			return result;
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x000A1360 File Offset: 0x0009F560
		public static IEnumerator<FileSystemInfo> smethod_3(uint processId)
		{
			Class471.Class474 @class = new Class471.Class474(0);
			@class.uint_0 = processId;
			return @class;
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x000A137C File Offset: 0x0009F57C
		private static bool smethod_4(IntPtr handle, uint processId, IntPtr currentProcess, bool remote, out string fileName)
		{
			Class494 @class = null;
			Class522 class2 = null;
			bool result;
			try
			{
				if (remote)
				{
					@class = Class265.OpenProcess(Enum72.flag_0, true, processId);
					if (Class265.DuplicateHandle(@class.DangerousGetHandle(), handle, currentProcess, out class2, 0, false, Enum130.flag_1))
					{
						handle = class2.DangerousGetHandle();
					}
				}
				result = Class471.smethod_5(handle, out fileName, 200);
			}
			finally
			{
				if (remote)
				{
					if (@class != null)
					{
						@class.Close();
						@class.Dispose();
					}
					if (class2 != null)
					{
						class2.Close();
						class2.Dispose();
					}
				}
			}
			return result;
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x000A13FC File Offset: 0x0009F5FC
		private static bool smethod_5(IntPtr handle, out string fileName, int wait)
		{
			Class471.Class472 @class = new Class471.Class472(handle);
			Thread thread = new Thread(new ThreadStart(@class.method_0));
			thread.IsBackground = true;
			thread.Start();
			if (thread.Join(wait))
			{
				fileName = @class.string_0;
				return @class.bool_0;
			}
			try
			{
				thread.Abort();
			}
			catch
			{
			}
			fileName = string.Empty;
			return false;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x000A146C File Offset: 0x0009F66C
		private static bool smethod_6(IntPtr handle, out string fileName)
		{
			IntPtr intPtr = IntPtr.Zero;
			RuntimeHelpers.PrepareConstrainedRegions();
			try
			{
				int num = 512;
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					intPtr = Marshal.AllocHGlobal(num);
				}
				NtStatus ntStatus = Class265.NtQueryObject(handle, Enum118.const_1, intPtr, num, out num);
				if (ntStatus == (NtStatus)2147483653U)
				{
					RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
					}
					finally
					{
						Marshal.FreeHGlobal(intPtr);
						intPtr = Marshal.AllocHGlobal(num);
					}
					ntStatus = Class265.NtQueryObject(handle, Enum118.const_1, intPtr, num, out num);
				}
				if (ntStatus == NtStatus.Success)
				{
					fileName = Marshal.PtrToStringUni((IntPtr)((int)intPtr + 8), (num - 9) / 2);
					return fileName.Length != 0;
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			fileName = string.Empty;
			return false;
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x000A1538 File Offset: 0x0009F738
		private static bool smethod_7(IntPtr handle, uint processId, byte objectType, IntPtr currentProcess, bool remote, out string token)
		{
			token = null;
			if (Class471.dictionary_1.ContainsKey(objectType))
			{
				token = Class471.dictionary_1[objectType];
				return true;
			}
			if (Class471.smethod_8(handle, processId, currentProcess, remote, out token))
			{
				Class471.dictionary_1.Add(objectType, token);
				return true;
			}
			return false;
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x000A1588 File Offset: 0x0009F788
		private static bool smethod_8(IntPtr handle, uint processId, IntPtr currentProcess, bool remote, out string token)
		{
			Class494 @class = null;
			Class522 class2 = null;
			bool result;
			try
			{
				if (remote)
				{
					@class = Class265.OpenProcess(Enum72.flag_0, true, processId);
					if (Class265.DuplicateHandle(@class.DangerousGetHandle(), handle, currentProcess, out class2, 0, false, Enum130.flag_1))
					{
						handle = class2.DangerousGetHandle();
					}
				}
				result = Class471.smethod_9(handle, out token);
			}
			finally
			{
				if (@class != null)
				{
					@class.Close();
				}
				if (class2 != null)
				{
					class2.Close();
				}
			}
			return result;
		}

		// Token: 0x060029FD RID: 10749 RVA: 0x000A15F4 File Offset: 0x0009F7F4
		private static bool smethod_9(IntPtr handle, out string token)
		{
			IntPtr intPtr = IntPtr.Zero;
			int num = 0;
			token = null;
			NtStatus ntStatus = Class265.NtQueryObject(handle, Enum118.const_2, IntPtr.Zero, 0, out num);
			if (ntStatus == (NtStatus)3221225480U)
			{
				return false;
			}
			RuntimeHelpers.PrepareConstrainedRegions();
			bool result;
			try
			{
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					intPtr = Marshal.AllocHGlobal(num);
				}
				ntStatus = Class265.NtQueryObject(handle, Enum118.const_2, intPtr, num, out num);
				if (!ntStatus.smethod_1() && !ntStatus.smethod_4())
				{
					token = ((Struct16)Marshal.PtrToStructure(intPtr, typeof(Struct16))).struct31_0.method_6();
					result = true;
				}
				else
				{
					result = false;
				}
			}
			finally
			{
				Marshal.FreeHGlobal(intPtr);
			}
			return result;
		}

		// Token: 0x060029FE RID: 10750 RVA: 0x000A16AC File Offset: 0x0009F8AC
		private static bool smethod_10(string devicePath, out string dosPath)
		{
			int i = devicePath.Length;
			while (i > 0)
			{
				if ((i = devicePath.LastIndexOf('\\', i - 1)) == -1)
				{
					break;
				}
				string str;
				if (Class471.dictionary_0.TryGetValue(devicePath.Substring(0, i), out str))
				{
					dosPath = str + devicePath.Substring(i);
					return dosPath.Length != 0;
				}
			}
			dosPath = string.Empty;
			return false;
		}

		// Token: 0x04001600 RID: 5632
		private static readonly string string_0 = "Process ID: ";

		// Token: 0x04001601 RID: 5633
		private static readonly string string_1 = "\\Device\\LanmanRedirector\\";

		// Token: 0x04001602 RID: 5634
		private static readonly int int_0 = 260;

		// Token: 0x04001603 RID: 5635
		private static Dictionary<string, string> dictionary_0;

		// Token: 0x04001604 RID: 5636
		private static Dictionary<byte, string> dictionary_1 = new Dictionary<byte, string>();

		// Token: 0x0200046B RID: 1131
		private sealed class Class472
		{
			// Token: 0x06002A01 RID: 10753 RVA: 0x000136C6 File Offset: 0x000118C6
			public Class472(IntPtr handle)
			{
				this.intptr_0 = handle;
			}

			// Token: 0x06002A02 RID: 10754 RVA: 0x000136D5 File Offset: 0x000118D5
			public void method_0()
			{
				this.bool_0 = Class471.smethod_6(this.intptr_0, out this.string_0);
			}

			// Token: 0x04001605 RID: 5637
			public readonly IntPtr intptr_0;

			// Token: 0x04001606 RID: 5638
			public string string_0;

			// Token: 0x04001607 RID: 5639
			public bool bool_0;
		}

		// Token: 0x0200046C RID: 1132
		[CompilerGenerated]
		private sealed class Class473
		{
			// Token: 0x06002A04 RID: 10756 RVA: 0x000A1718 File Offset: 0x0009F918
			public void method_0()
			{
				try
				{
					using (IEnumerator<FileSystemInfo> enumerator = Class471.smethod_3((uint)this.int_0))
					{
						while (enumerator.MoveNext())
						{
							FileSystemInfo item = enumerator.Current;
							this.list_0.Add(item);
						}
					}
				}
				catch (ThreadAbortException)
				{
				}
			}

			// Token: 0x04001608 RID: 5640
			public List<FileSystemInfo> list_0;

			// Token: 0x04001609 RID: 5641
			public int int_0;
		}
	}
}
