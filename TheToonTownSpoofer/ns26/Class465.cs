using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns17;
using ns19;
using ns23;
using ns25;
using ns28;
using ns30;
using ns31;

namespace ns26
{
	// Token: 0x0200045B RID: 1115
	internal static class Class465
	{
		// Token: 0x06002999 RID: 10649 RVA: 0x0009F87C File Offset: 0x0009DA7C
		public static Enum129 smethod_0(this MouseButtons button, bool buttonDown)
		{
			if (buttonDown)
			{
				if (button <= MouseButtons.Right)
				{
					if (button == MouseButtons.Left)
					{
						return Enum129.flag_1;
					}
					if (button == MouseButtons.Right)
					{
						return Enum129.flag_3;
					}
				}
				else
				{
					if (button == MouseButtons.Middle)
					{
						return Enum129.flag_5;
					}
					if (button == MouseButtons.XButton1)
					{
						return Enum129.flag_7;
					}
					if (button == MouseButtons.XButton2)
					{
						return Enum129.flag_7;
					}
				}
				throw new NotSupportedException(string.Format(Class217.cultureInfo_0, "'{0}' not supported for MouseDown.", new object[]
				{
					button
				}));
			}
			if (button <= MouseButtons.Right)
			{
				if (button == MouseButtons.Left)
				{
					return Enum129.flag_2;
				}
				if (button == MouseButtons.Right)
				{
					return Enum129.flag_4;
				}
			}
			else
			{
				if (button == MouseButtons.Middle)
				{
					return Enum129.flag_6;
				}
				if (button == MouseButtons.XButton1)
				{
					return Enum129.flag_8;
				}
				if (button == MouseButtons.XButton2)
				{
					return Enum129.flag_8;
				}
			}
			throw new NotSupportedException(string.Format(Class217.cultureInfo_0, "'{0}' not supported for MouseUp.", new object[]
			{
				button
			}));
		}

		// Token: 0x0600299A RID: 10650 RVA: 0x0009F968 File Offset: 0x0009DB68
		public static void smethod_1(MouseButtons button)
		{
			Class316 @class = new Class316();
			if (!Class365.smethod_0(@class.method_6(button)))
			{
				Enum129 dwFlags = button.smethod_0(true);
				Class265.mouse_event(dwFlags, 0U, 0U, 0U, IntPtr.Zero);
			}
		}

		// Token: 0x0600299B RID: 10651 RVA: 0x0009F9A0 File Offset: 0x0009DBA0
		public static void smethod_2(MouseButtons button)
		{
			Class316 @class = new Class316();
			if (!Class365.smethod_0(@class.method_7(button)))
			{
				Enum129 dwFlags = button.smethod_0(false);
				Class265.mouse_event(dwFlags, 0U, 0U, 0U, IntPtr.Zero);
			}
		}

		// Token: 0x0600299C RID: 10652 RVA: 0x0009F9D8 File Offset: 0x0009DBD8
		public static void smethod_3(Point p)
		{
			Cursor.Position = p;
			if (!Class265.SetCursorPos(p.X, p.Y))
			{
				new Win32Exception().smethod_0();
				Class316 @class = new Class316();
				Point p2 = Class410.smethod_13(p);
				if (!Class365.smethod_0(@class.method_5(p2)))
				{
					Class265.mouse_event(Enum129.flag_0 | Enum129.flag_11, (uint)p2.X, (uint)p2.Y, 0U, IntPtr.Zero);
				}
			}
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x0009FA44 File Offset: 0x0009DC44
		public static void smethod_4(IntPtr hWnd, Point p)
		{
			Rectangle rectangle = Class410.smethod_16(hWnd);
			if (p.X < 0)
			{
				p.X = 0;
			}
			if (p.Y < 0)
			{
				p.Y = 0;
			}
			if (p.X > rectangle.Width)
			{
				p.X = rectangle.Width;
			}
			if (p.Y > rectangle.Height)
			{
				p.Y = rectangle.Height;
			}
			p.X += rectangle.X;
			p.Y += rectangle.Y;
			Class465.smethod_3(p);
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x0009FAE8 File Offset: 0x0009DCE8
		public static void smethod_5(Rectangle window_bounds, Point p)
		{
			if (p.X < 0)
			{
				p.X = 0;
			}
			if (p.Y < 0)
			{
				p.Y = 0;
			}
			if (p.X > window_bounds.Width)
			{
				p.X = window_bounds.Width;
			}
			if (p.Y > window_bounds.Height)
			{
				p.Y = window_bounds.Height;
			}
			p.X += window_bounds.X;
			p.Y += window_bounds.Y;
			Class465.smethod_3(p);
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x00013310 File Offset: 0x00011510
		public static void smethod_6(MouseButtons button, TimeSpan delay, ManualResetEventSlim reset)
		{
			if (!reset.IsSet)
			{
				Class465.smethod_1(button);
			}
			if (!reset.IsSet && delay > TimeSpan.Zero)
			{
				reset.Wait(delay);
			}
			if (!reset.IsSet)
			{
				Class465.smethod_2(button);
			}
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0009FB88 File Offset: 0x0009DD88
		public static void smethod_7(MouseButtons button)
		{
			using (ManualResetEventSlim manualResetEventSlim = new ManualResetEventSlim(false))
			{
				Class465.smethod_6(button, TimeSpan.Zero, manualResetEventSlim);
			}
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x0001334B File Offset: 0x0001154B
		public static void smethod_8(MouseButtons button, int delay, ManualResetEventSlim reset)
		{
			Class465.smethod_6(button, new TimeSpan(0, 0, 0, 0, delay), reset);
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x0001335E File Offset: 0x0001155E
		public static void smethod_9(IntPtr hWnd, Keys Key)
		{
			Class465.smethod_13(hWnd, Key);
			Class465.smethod_14(hWnd, Key);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x0001336E File Offset: 0x0001156E
		public static void smethod_10(IntPtr hWnd, Keys Key, WaitHandle[] waitHandle, int delay)
		{
			Class465.smethod_13(hWnd, Key);
			if (delay > 0)
			{
				WaitHandle.WaitAny(waitHandle, delay);
			}
			Class465.smethod_14(hWnd, Key);
		}

		// Token: 0x060029A4 RID: 10660 RVA: 0x0001338A File Offset: 0x0001158A
		public static void smethod_11(IntPtr hWnd, Keys Key, ManualResetEventSlim reset, int delay)
		{
			if (!reset.IsSet)
			{
				Class465.smethod_13(hWnd, Key);
			}
			if (!reset.IsSet && delay > 0)
			{
				reset.Wait(delay);
			}
			if (!reset.IsSet)
			{
				Class465.smethod_14(hWnd, Key);
			}
		}

		// Token: 0x060029A5 RID: 10661 RVA: 0x000133BE File Offset: 0x000115BE
		public static void smethod_12(IntPtr hWnd, Keys Key, ManualResetEventSlim reset, TimeSpan delay)
		{
			if (!reset.IsSet)
			{
				Class465.smethod_13(hWnd, Key);
			}
			if (!reset.IsSet && delay > TimeSpan.Zero)
			{
				reset.Wait(delay);
			}
			if (!reset.IsSet)
			{
				Class465.smethod_14(hWnd, Key);
			}
		}

		// Token: 0x060029A6 RID: 10662 RVA: 0x000133FB File Offset: 0x000115FB
		public static void smethod_13(IntPtr hWnd, Keys Key)
		{
			Class265.PostMessage(hWnd, Enum16.const_88, (int)Key, 0);
		}

		// Token: 0x060029A7 RID: 10663 RVA: 0x0001340B File Offset: 0x0001160B
		public static void smethod_14(IntPtr hWnd, Keys Key)
		{
			Class265.PostMessage(hWnd, Enum16.const_89, (int)Key, 0);
		}
	}
}
