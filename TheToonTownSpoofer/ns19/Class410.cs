using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using ns16;
using ns17;
using ns18;
using ns21;
using ns22;
using ns23;
using ns24;
using ns25;
using ns27;
using ns30;
using ns31;

namespace ns19
{
	// Token: 0x020003F8 RID: 1016
	internal sealed class Class410
	{
		// Token: 0x060026DC RID: 9948 RVA: 0x00011541 File Offset: 0x0000F741
		public static void smethod_0(IntPtr hWnd, Point location, Size size, Bitmap bitmap)
		{
			Class410.smethod_1(hWnd, location, size, bitmap, byte.MaxValue);
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0008BB74 File Offset: 0x00089D74
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static void smethod_1(IntPtr hWnd, Point location, Size size, Bitmap bitmap, byte opacity)
		{
			if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
			{
				throw new ApplicationException("The bitmap must be 32ppp with alpha-channel.");
			}
			IntPtr dc = Class265.GetDC(IntPtr.Zero);
			IntPtr intPtr = Class265.CreateCompatibleDC(dc);
			IntPtr intPtr2 = IntPtr.Zero;
			IntPtr hObject = IntPtr.Zero;
			try
			{
				intPtr2 = bitmap.GetHbitmap(Color.FromArgb(0));
				hObject = Class265.SelectObject(intPtr, intPtr2);
				Point empty = Point.Empty;
				Struct29 @struct = new Struct29
				{
					byte_0 = Class410.byte_0,
					byte_1 = 0,
					byte_2 = opacity,
					byte_3 = Class410.byte_1
				};
				if (!Class265.UpdateLayeredWindow(hWnd, dc, ref location, ref size, intPtr, ref empty, 0, ref @struct, Class410.int_0))
				{
					throw new Win32Exception();
				}
			}
			finally
			{
				Class265.ReleaseDC(IntPtr.Zero, dc);
				if (intPtr2 != IntPtr.Zero)
				{
					Class265.SelectObject(intPtr, hObject);
					Class265.DeleteObject(intPtr2);
				}
				Class265.DeleteDC(intPtr);
			}
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0008BC68 File Offset: 0x00089E68
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static void smethod_2(IntPtr Handle, Bitmap bitmap, byte opacity, Point Location)
		{
			if (bitmap.PixelFormat != PixelFormat.Format32bppArgb)
			{
				throw new ApplicationException("The bitmap must be 32bpp.");
			}
			IntPtr dc = Class265.GetDC(IntPtr.Zero);
			IntPtr intPtr = Class265.CreateCompatibleDC(dc);
			IntPtr intPtr2 = IntPtr.Zero;
			IntPtr hObject = IntPtr.Zero;
			try
			{
				intPtr2 = bitmap.GetHbitmap(Color.FromArgb(0));
				hObject = Class265.SelectObject(intPtr, intPtr2);
				Size size = new Size(bitmap.Width, bitmap.Height);
				Point point = new Point(0, 0);
				Point point2 = Location;
				Struct29 @struct = default(Struct29);
				@struct.byte_0 = Class410.byte_0;
				@struct.byte_1 = 0;
				@struct.byte_2 = opacity;
				@struct.byte_3 = Class410.byte_1;
				Class265.UpdateLayeredWindow(Handle, dc, ref point2, ref size, intPtr, ref point, 0, ref @struct, Class410.int_0);
			}
			finally
			{
				Class265.ReleaseDC(IntPtr.Zero, dc);
				if (intPtr2 != IntPtr.Zero)
				{
					Class265.SelectObject(intPtr, hObject);
					Class265.DeleteObject(intPtr2);
				}
				Class265.DeleteDC(intPtr);
			}
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x00011551 File Offset: 0x0000F751
		public static void smethod_3(IntPtr hWnd)
		{
			Class265.SendMessage_2(hWnd, Enum16.const_9, true, 0);
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x0001155E File Offset: 0x0000F75E
		public static void smethod_4(IntPtr hWnd)
		{
			Class265.SendMessage_2(hWnd, Enum16.const_9, false, 0);
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x0001156B File Offset: 0x0000F76B
		public static void smethod_5(IntPtr hWnd)
		{
			if (!Class265.SendNotifyMessage(hWnd, Enum16.const_103, Enum71.const_7, 0))
			{
				throw new Win32Exception();
			}
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x00011586 File Offset: 0x0000F786
		public static void smethod_6(IntPtr hWnd)
		{
			if (!Class265.SendNotifyMessage(hWnd, Enum16.const_103, Enum71.const_8, 0))
			{
				throw new Win32Exception();
			}
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x000115A1 File Offset: 0x0000F7A1
		public static void smethod_7(IntPtr hWnd)
		{
			if (!Class265.SendNotifyMessage(hWnd, Enum16.const_103, Enum71.const_14, 0))
			{
				throw new Win32Exception();
			}
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000115BC File Offset: 0x0000F7BC
		public static void smethod_8(object wrapper, IntPtr hWnd)
		{
			Class265.SetWindowPos(hWnd, Class265.intptr_3, 0, 0, 0, 0, Enum31.flag_7 | Enum31.flag_12 | Enum31.flag_14);
			Class265.ShowWindowAsync(hWnd, Enum117.const_4);
			if (wrapper == null)
			{
				Class265.SetForegroundWindow_1(hWnd);
				return;
			}
			Class265.SetForegroundWindow(new HandleRef(wrapper, hWnd));
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x000115F1 File Offset: 0x0000F7F1
		public static void smethod_9(Control control)
		{
			Class265.SetWindowPos_1(new HandleRef(control, control.Handle), Class265.intptr_4, 0, 0, 0, 0, Enum31.flag_5 | Enum31.flag_7 | Enum31.flag_12);
		}

		// Token: 0x060026E6 RID: 9958 RVA: 0x00011610 File Offset: 0x0000F810
		public static void smethod_10(Control top, Control under)
		{
			Class265.SetWindowPos_2(new HandleRef(under, under.Handle), new HandleRef(top, top.Handle), 0, 0, 0, 0, Enum31.flag_5 | Enum31.flag_7 | Enum31.flag_12);
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00011636 File Offset: 0x0000F836
		public static void smethod_11(Control control, int time, Enum120 flags)
		{
			Class265.AnimateWindow(new HandleRef(control, control.Handle), time, flags);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x0008BD74 File Offset: 0x00089F74
		public static void smethod_12(List<KeyValuePair<IntPtr, Rectangle>> windows)
		{
			Class410.Class411 @class = new Class410.Class411();
			@class.list_0 = windows;
			if (@class.list_0 == null)
			{
				throw new ArgumentNullException("wnds");
			}
			@class.list_0.Clear();
			if (!Class265.EnumWindows(new Class265.Delegate174(@class.method_0), new IntPtr(0)))
			{
				throw new Win32Exception();
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0008BDCC File Offset: 0x00089FCC
		public static Point smethod_13(Point p)
		{
			return new Point((int)Math.Ceiling(p.X * 65535m / Screen.PrimaryScreen.Bounds.Width), (int)Math.Ceiling(p.Y * 65535m / Screen.PrimaryScreen.Bounds.Height));
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0008BE60 File Offset: 0x0008A060
		public static Rectangle smethod_14(IntPtr hWnd)
		{
			Struct24 @struct;
			if (!Class265.GetWindowRect(hWnd, out @struct))
			{
				throw new Win32Exception();
			}
			return @struct.method_0();
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x0008BE84 File Offset: 0x0008A084
		public static Rectangle smethod_15(IntPtr hWnd, IntPtr parenthWnd)
		{
			Struct24 @struct;
			if (!Class265.GetWindowRect(hWnd, out @struct))
			{
				throw new Win32Exception();
			}
			if (Class265.MapWindowPoints(Class265.GetDesktopWindow(), parenthWnd, ref @struct, 2U) == 0)
			{
				throw new Win32Exception();
			}
			return @struct.method_0();
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x0008BEC0 File Offset: 0x0008A0C0
		public static Rectangle smethod_16(IntPtr hWnd)
		{
			Struct24 @struct;
			if (!Class265.GetClientRect(hWnd, out @struct))
			{
				throw new Win32Exception();
			}
			Rectangle result = new Rectangle(0, 0, @struct.int_2 - @struct.int_0, @struct.int_3 - @struct.int_1);
			Point point = new Point(@struct.int_0, @struct.int_1);
			if (!Class265.ClientToScreen(hWnd, ref point))
			{
				throw new Win32Exception();
			}
			result.Location = new Point(point.X, point.Y);
			return result;
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0008BF4C File Offset: 0x0008A14C
		public static bool smethod_17(IntPtr hWnd, Size sz)
		{
			Size size = Class410.smethod_18(hWnd);
			if (size == sz)
			{
				return false;
			}
			Size size2 = Class410.smethod_14(hWnd).Size + (sz - size);
			return Class410.smethod_24(hWnd, size2, false);
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x0008BF90 File Offset: 0x0008A190
		public static Size smethod_18(IntPtr hWnd)
		{
			Struct24 @struct;
			if (!Class265.GetClientRect(hWnd, out @struct))
			{
				throw new Win32Exception();
			}
			return new Size(@struct.int_2 - @struct.int_0, @struct.int_3 - @struct.int_1);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x0008BFD0 File Offset: 0x0008A1D0
		public static Rectangle smethod_19(IntPtr hWnd)
		{
			Rectangle rectangle = Class410.smethod_14(hWnd);
			Rectangle rectangle2 = Class410.smethod_16(hWnd);
			return new Rectangle(rectangle2.X - rectangle.X, rectangle2.Y - rectangle.Y, rectangle2.Width, rectangle2.Height);
		}

		// Token: 0x060026F0 RID: 9968 RVA: 0x0008C01C File Offset: 0x0008A21C
		public static Rectangle smethod_20(IntPtr hWnd)
		{
			Struct24 @struct;
			if (!Class265.GetClientRect(hWnd, out @struct))
			{
				throw new Win32Exception();
			}
			return @struct.method_0();
		}

		// Token: 0x060026F1 RID: 9969 RVA: 0x0008C040 File Offset: 0x0008A240
		public static FormWindowState smethod_21(HandleRef hWnd)
		{
			Rectangle rectangle;
			return Class410.smethod_22(hWnd, out rectangle);
		}

		// Token: 0x060026F2 RID: 9970 RVA: 0x0008C058 File Offset: 0x0008A258
		public static FormWindowState smethod_22(HandleRef hWnd, out Rectangle normalRect)
		{
			Struct28 @struct = default(Struct28);
			@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Struct28));
			Class265.GetWindowPlacement(hWnd, ref @struct);
			normalRect = @struct.struct24_0.method_0();
			if (@struct.enum117_0 == Enum117.const_2)
			{
				return FormWindowState.Maximized;
			}
			if (@struct.enum117_0 != Enum117.const_8)
			{
				return FormWindowState.Normal;
			}
			if (@struct.enum62_0.HasFlag(Enum62.flag_1))
			{
				return (FormWindowState)3;
			}
			return FormWindowState.Minimized;
		}

		// Token: 0x060026F3 RID: 9971 RVA: 0x0008C0D4 File Offset: 0x0008A2D4
		public static void smethod_23(HandleRef hWnd, FormWindowState state, Rectangle? rect = null)
		{
			Rectangle left;
			FormWindowState formWindowState;
			if ((formWindowState = Class410.smethod_22(hWnd, out left)) != state || (rect != null && left != rect.Value))
			{
				Struct28 @struct = default(Struct28);
				@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Struct28));
				Class265.GetWindowPlacement(hWnd, ref @struct);
				if (rect != null && left != rect.Value)
				{
					@struct.struct24_0 = new Struct24(rect.Value);
				}
				if (formWindowState != state)
				{
					if (state.HasFlag(FormWindowState.Maximized))
					{
						if (state.HasFlag(FormWindowState.Minimized))
						{
							@struct.enum62_0 |= Enum62.flag_1;
							@struct.enum117_0 = Enum117.const_8;
						}
						else
						{
							@struct.enum117_0 = Enum117.const_2;
							@struct.enum62_0 &= ~Enum62.flag_1;
						}
					}
					else if (state.HasFlag(FormWindowState.Minimized))
					{
						@struct.enum117_0 = Enum117.const_8;
						@struct.enum62_0 &= ~Enum62.flag_1;
					}
					else
					{
						@struct.enum117_0 = Enum117.const_4;
						@struct.enum62_0 &= ~Enum62.flag_1;
					}
				}
				Class265.SetWindowPlacement(hWnd, ref @struct);
			}
		}

		// Token: 0x060026F4 RID: 9972 RVA: 0x0008C210 File Offset: 0x0008A410
		public static bool smethod_24(IntPtr hWnd, Size size, bool activate)
		{
			if (!(size == Class410.smethod_14(hWnd).Size))
			{
				Class265.SendMessage(hWnd, Enum16.const_154, IntPtr.Zero, IntPtr.Zero);
				if (activate)
				{
					if (!Class265.SetWindowPos(hWnd, Class265.intptr_3, 0, 0, size.Width, size.Height, Enum31.flag_7))
					{
						throw new Win32Exception();
					}
				}
				else if (!Class265.SetWindowPos(hWnd, Class265.intptr_3, 0, 0, size.Width, size.Height, Enum31.flag_5 | Enum31.flag_7))
				{
					throw new Win32Exception();
				}
				Class265.SendMessage(hWnd, Enum16.const_155, IntPtr.Zero, IntPtr.Zero);
				return true;
			}
			if (activate && !Class265.SetWindowPos(hWnd, Class265.intptr_3, 0, 0, 0, 0, Enum31.flag_7 | Enum31.flag_12))
			{
				throw new Win32Exception();
			}
			return false;
		}

		// Token: 0x060026F5 RID: 9973 RVA: 0x0001164C File Offset: 0x0000F84C
		public static Enum17 smethod_25(IntPtr hWnd)
		{
			return (Enum17)Class265.smethod_2(hWnd, Enum55.const_4);
		}

		// Token: 0x060026F6 RID: 9974 RVA: 0x00011657 File Offset: 0x0000F857
		public static void smethod_26(IntPtr hWnd, Enum17 style)
		{
			Class265.smethod_4(hWnd, Enum55.const_4, (int)style);
		}

		// Token: 0x060026F7 RID: 9975 RVA: 0x00011662 File Offset: 0x0000F862
		public static bool smethod_27(IntPtr hWnd)
		{
			return Class410.smethod_25(hWnd).HasFlag(Enum17.flag_23);
		}

		// Token: 0x060026F8 RID: 9976 RVA: 0x0008C2CC File Offset: 0x0008A4CC
		public static bool smethod_28(IntPtr hWnd, string data, IntPtr dwData, uint timeOut)
		{
			Struct20 @struct = default(Struct20);
			bool result;
			try
			{
				@struct.int_0 = (data.Length + 1) * 2;
				@struct.intptr_1 = Class265.LocalAlloc(Enum63.const_3, new IntPtr(@struct.int_0));
				Marshal.Copy(data.ToCharArray(), 0, @struct.intptr_1, data.Length);
				@struct.intptr_0 = dwData;
				IntPtr intPtr;
				result = (Class265.SendMessageTimeout(hWnd, Enum16.const_55, IntPtr.Zero, ref @struct, Enum88.flag_0, timeOut, out intPtr) != IntPtr.Zero);
			}
			finally
			{
				@struct.Dispose();
			}
			return result;
		}

		// Token: 0x0400131A RID: 4890
		private static readonly string string_0 = "Window handle: '{0}'";

		// Token: 0x0400131B RID: 4891
		private static readonly int int_0 = 2;

		// Token: 0x0400131C RID: 4892
		private static readonly byte byte_0 = 0;

		// Token: 0x0400131D RID: 4893
		private static readonly byte byte_1 = 1;

		// Token: 0x020003F9 RID: 1017
		[CompilerGenerated]
		private sealed class Class411
		{
			// Token: 0x060026FC RID: 9980 RVA: 0x0008C368 File Offset: 0x0008A568
			public bool method_0(IntPtr hWnd, IntPtr lParam)
			{
				if (Class265.IsWindowVisible(hWnd))
				{
					try
					{
						this.list_0.Add(new KeyValuePair<IntPtr, Rectangle>(hWnd, Class410.smethod_14(hWnd)));
					}
					catch (Win32Exception ex)
					{
						ex.smethod_1(new object[]
						{
							string.Format(Class217.cultureInfo_0, Class410.string_0, new object[]
							{
								hWnd.ToString()
							})
						});
					}
				}
				return true;
			}

			// Token: 0x0400131E RID: 4894
			public List<KeyValuePair<IntPtr, Rectangle>> list_0;
		}
	}
}
