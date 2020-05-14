using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns17;
using ns19;
using ns26;
using ns31;

namespace ns23
{
	// Token: 0x02000398 RID: 920
	internal static class Class364
	{
		// Token: 0x060023CA RID: 9162 RVA: 0x00079070 File Offset: 0x00077270
		public static Bitmap smethod_0()
		{
			IntPtr desktopWindow = Class265.GetDesktopWindow();
			Rectangle virtualScreen = SystemInformation.VirtualScreen;
			return Class364.smethod_4(desktopWindow, virtualScreen);
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00079090 File Offset: 0x00077290
		public static Bitmap smethod_1(Rectangle rec)
		{
			IntPtr desktopWindow = Class265.GetDesktopWindow();
			return Class364.smethod_4(desktopWindow, rec);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x000790AC File Offset: 0x000772AC
		public static Bitmap smethod_2(IntPtr hWnd)
		{
			Rectangle rec = Class410.smethod_16(hWnd);
			return Class364.smethod_4(Class265.GetDesktopWindow(), rec);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x000790CC File Offset: 0x000772CC
		public static Bitmap smethod_3(IntPtr hWnd, Rectangle rec)
		{
			Rectangle rectangle = Class410.smethod_16(hWnd);
			if (rec.Size.Height + rec.Y > rectangle.Size.Height || rec.Size.Width + rec.X > rectangle.Size.Width)
			{
				throw new ArgumentException(string.Format(Class364.string_1, rec.Size, rec.Location, rectangle.Size));
			}
			rec.X += rectangle.X;
			rec.Y += rectangle.Y;
			return Class364.smethod_4(Class265.GetDesktopWindow(), rec);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0007919C File Offset: 0x0007739C
		private static Bitmap smethod_4(IntPtr handle, Rectangle rec)
		{
			IntPtr intPtr = IntPtr.Zero;
			IntPtr intPtr2 = IntPtr.Zero;
			try
			{
				intPtr = Class265.GetWindowDC(handle);
				if (intPtr == IntPtr.Zero)
				{
					throw new Win32Exception();
				}
				intPtr2 = Class265.CreateCompatibleDC(intPtr);
				if (intPtr2 == IntPtr.Zero)
				{
					throw new Win32Exception();
				}
				IntPtr intPtr3 = Class265.CreateCompatibleBitmap(intPtr, rec.Width, rec.Height);
				if (intPtr3 == IntPtr.Zero)
				{
					throw new Win32Exception();
				}
				using (Struct45 hObject = Struct45.smethod_0(intPtr3))
				{
					IntPtr intPtr4 = Class265.SelectObject(intPtr2, Struct45.smethod_1(hObject));
					if (!(intPtr4 == IntPtr.Zero))
					{
						if (intPtr4.ToInt32() != Class364.int_0)
						{
							if (!Class265.BitBlt(intPtr2, 0, 0, rec.Width, rec.Height, intPtr, rec.X, rec.Y, Enum37.const_0))
							{
								throw new Win32Exception();
							}
							IntPtr value = Class265.SelectObject(intPtr2, intPtr4);
							if (value == IntPtr.Zero || value.ToInt32() == Class364.int_0)
							{
								throw new InvalidOperationException(string.Format(Class217.cultureInfo_0, Class364.string_0, new object[]
								{
									value.ToString()
								}));
							}
							return Image.FromHbitmap(Struct45.smethod_1(hObject));
						}
					}
					throw new InvalidOperationException(string.Format(Class217.cultureInfo_0, Class364.string_0, new object[]
					{
						intPtr4.ToString()
					}));
				}
			}
			finally
			{
				if (intPtr2 != IntPtr.Zero && !Class265.DeleteDC(intPtr2))
				{
					throw new Win32Exception();
				}
				if (intPtr != IntPtr.Zero && Class265.ReleaseDC(handle, intPtr) == 0)
				{
					throw new Win32Exception();
				}
			}
			Bitmap result;
			return result;
		}

		// Token: 0x04001084 RID: 4228
		private static readonly int int_0 = 65535;

		// Token: 0x04001085 RID: 4229
		private static readonly string string_0 = "SelectObject function failed with exception '{0}'";

		// Token: 0x04001086 RID: 4230
		private static readonly string string_1 = "The requested capture size: '{0}' at location: '{1}' does not fit in the actual window's size: '{2}'.";
	}
}
