using System;
using System.Globalization;
using System.IO;
using ns17;
using ns31;

namespace ns23
{
	// Token: 0x0200039E RID: 926
	internal sealed class Class368 : Class367
	{
		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060023F2 RID: 9202 RVA: 0x00079EC8 File Offset: 0x000780C8
		protected override string ProcessID
		{
			get
			{
				string result;
				try
				{
					result = base.ProcessID;
				}
				catch
				{
					result = Class265.GetCurrentProcessId().ToString(NumberFormatInfo.CurrentInfo);
				}
				return result;
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060023F3 RID: 9203 RVA: 0x00079F08 File Offset: 0x00078108
		protected override string ProcessName
		{
			get
			{
				string result;
				try
				{
					result = base.ProcessName;
				}
				catch
				{
					result = Class265.smethod_5();
				}
				return result;
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060023F4 RID: 9204 RVA: 0x00079F38 File Offset: 0x00078138
		protected string Win32ThreadID
		{
			get
			{
				return Class265.GetCurrentThreadId().ToString(NumberFormatInfo.CurrentInfo);
			}
		}

		// Token: 0x060023F5 RID: 9205 RVA: 0x00079F58 File Offset: 0x00078158
		private string method_8()
		{
			string result;
			try
			{
				result = this.Win32ThreadID;
			}
			catch (Exception ex)
			{
				result = base.method_6(ex);
			}
			return result;
		}

		// Token: 0x060023F6 RID: 9206 RVA: 0x0000F75B File Offset: 0x0000D95B
		public Class368(string logFile) : base(logFile)
		{
		}

		// Token: 0x060023F7 RID: 9207 RVA: 0x0000F764 File Offset: 0x0000D964
		public Class368(string directory, string logFile) : base(directory, logFile)
		{
		}

		// Token: 0x060023F8 RID: 9208 RVA: 0x00079F8C File Offset: 0x0007818C
		protected override void vmethod_0(StreamWriter writer, Exception ex, params object[] state)
		{
			writer.WriteLine(string.Format(Class217.cultureInfo_0, Class368.string_25, new object[]
			{
				this.method_8()
			}));
			base.vmethod_0(writer, ex, state);
		}

		// Token: 0x040010C6 RID: 4294
		private static readonly string string_25 = "Win32 Thread Id: {0}";
	}
}
