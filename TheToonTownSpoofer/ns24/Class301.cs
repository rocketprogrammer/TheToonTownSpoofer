using System;
using System.ComponentModel;
using System.Drawing;
using ns18;
using ns19;
using ns31;

namespace ns24
{
	// Token: 0x02000316 RID: 790
	internal static class Class301
	{
		// Token: 0x06001ECB RID: 7883 RVA: 0x00065248 File Offset: 0x00063448
		public static void smethod_0(IntPtr hWnd)
		{
			IntPtr windowDC = Class265.GetWindowDC(hWnd);
			using (Graphics graphics = Graphics.FromHdc(windowDC))
			{
				using (SolidBrush solidBrush = new SolidBrush(Color.FromArgb(100, Color.Red)))
				{
					graphics.FillRectangle(solidBrush, Class410.smethod_19(hWnd));
				}
			}
			if (Class265.ReleaseDC(hWnd, windowDC) == 0)
			{
				throw new Win32Exception();
			}
			Class410.smethod_4(hWnd);
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0000BF85 File Offset: 0x0000A185
		public static void smethod_1(IntPtr hWnd)
		{
			Class410.smethod_3(hWnd);
			Class265.RedrawWindow(hWnd, IntPtr.Zero, IntPtr.Zero, Enum45.flag_0 | Enum45.flag_2 | Enum45.flag_7 | Enum45.flag_8 | Enum45.flag_10);
			Class265.InvalidateRect(hWnd, IntPtr.Zero, true);
			Class265.UpdateWindow(hWnd);
		}
	}
}
