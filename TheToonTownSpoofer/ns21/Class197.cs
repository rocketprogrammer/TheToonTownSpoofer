using System;
using System.Diagnostics;
using System.Windows.Forms;
using ns15;
using ns16;
using ns20;
using ns22;
using ns26;
using ns28;
using ns29;
using ns30;

namespace ns21
{
	// Token: 0x02000259 RID: 601
	internal static class Class197
	{
		// Token: 0x060019D0 RID: 6608 RVA: 0x0000903F File Offset: 0x0000723F
		public static bool smethod_0(this Class141 process)
		{
			return Class197.smethod_3(Class502.string_9, process);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0000904C File Offset: 0x0000724C
		public static bool smethod_1(this Class141 process, Form owner)
		{
			return process.smethod_0() || process.smethod_2(owner, null);
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x00047950 File Offset: 0x00045B50
		public static bool smethod_2(this Class141 process, Form owner, EventHandler<EventArgs15> e = null)
		{
			using (Class499 @class = new Class499(owner))
			{
				using (WindowSelect_1 windowSelect_ = Class460.smethod_0(e))
				{
					@class.method_0(windowSelect_);
					if (windowSelect_.ShowDialog() == DialogResult.OK)
					{
						Class335.smethod_3(Class197.string_1, new object[]
						{
							windowSelect_.SelectedHandle
						});
						process.MainWindowHandle = windowSelect_.SelectedHandle;
						Class335.smethod_3(Class197.string_0, new object[]
						{
							process.MainWindowHandle
						});
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x00047A08 File Offset: 0x00045C08
		public static bool smethod_3(string processName, Class141 process)
		{
			Process[] array = Class156.smethod_3(processName);
			bool result;
			try
			{
				if (array.Length != 1)
				{
					result = false;
				}
				else
				{
					IntPtr intPtr = array[0].smethod_0();
					Class335.smethod_3(Class197.string_2, new object[]
					{
						intPtr
					});
					process.MainWindowHandle = intPtr;
					Class335.smethod_3(Class197.string_3, new object[]
					{
						process.MainWindowHandle
					});
					result = true;
				}
			}
			finally
			{
				array.smethod_1<Process>();
			}
			return result;
		}

		// Token: 0x04000756 RID: 1878
		private static readonly string string_0 = "Window Selector Result Process Wrapper Result";

		// Token: 0x04000757 RID: 1879
		private static readonly string string_1 = "Window Selector Result";

		// Token: 0x04000758 RID: 1880
		private static readonly string string_2 = "Auto Select Single Window Result";

		// Token: 0x04000759 RID: 1881
		private static readonly string string_3 = "Auto Select Single Window Process Wrapper Result";
	}
}
