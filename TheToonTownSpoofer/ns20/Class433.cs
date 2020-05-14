using System;
using System.Drawing;
using ns16;
using ns19;
using ns23;
using ns26;
using ns28;
using ns30;
using ns31;

namespace ns20
{
	// Token: 0x0200041F RID: 1055
	internal static class Class433
	{
		// Token: 0x0600280B RID: 10251 RVA: 0x00093E4C File Offset: 0x0009204C
		public static Enum107 smethod_0(Class141 toontownWindow, Class150 original_capture, Struct46 bounds, Class104 settings)
		{
			if (original_capture == null)
			{
				return Enum107.const_2;
			}
			if (bounds.IsSizeEmpty)
			{
				return Enum107.const_2;
			}
			IntPtr mainWindowHandle = toontownWindow.MainWindowHandle;
			if (!toontownWindow.ProcessOpen)
			{
				return Enum107.const_2;
			}
			if (original_capture != null && !Struct46.smethod_0(bounds, Struct46.struct46_0))
			{
				Rectangle rec = bounds.method_0(Class410.smethod_16(mainWindowHandle).Size);
				Enum107 result;
				using (Bitmap bitmap = Class364.smethod_3(mainWindowHandle, rec))
				{
					using (Class125 @class = new Class125(bitmap))
					{
						using (Class150 class2 = new Class150(@class))
						{
							if (Class150.smethod_1(class2, original_capture, settings.MaxColorRange))
							{
								result = Enum107.const_0;
							}
							else
							{
								result = Enum107.const_1;
							}
						}
					}
				}
				return result;
			}
			return Enum107.const_2;
		}

		// Token: 0x0600280C RID: 10252 RVA: 0x00093F24 File Offset: 0x00092124
		public static Enum107 smethod_1(Class141 toontownWindow, Class150 original_capture, Rectangle capture_bounds, Class104 settings)
		{
			if (original_capture == null)
			{
				return Enum107.const_2;
			}
			IntPtr mainWindowHandle = toontownWindow.MainWindowHandle;
			if (!toontownWindow.ProcessOpen)
			{
				return Enum107.const_2;
			}
			if (original_capture != null && capture_bounds.Size.smethod_1())
			{
				Enum107 result;
				using (Bitmap bitmap = Class364.smethod_3(mainWindowHandle, capture_bounds))
				{
					using (Class125 @class = new Class125(bitmap))
					{
						using (Class150 class2 = new Class150(@class))
						{
							if (Class150.smethod_1(class2, original_capture, settings.MaxColorRange))
							{
								result = Enum107.const_0;
							}
							else
							{
								result = Enum107.const_1;
							}
						}
					}
				}
				return result;
			}
			return Enum107.const_2;
		}
	}
}
