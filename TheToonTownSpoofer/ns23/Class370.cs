using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ns20;

namespace ns23
{
	// Token: 0x020003A1 RID: 929
	internal static class Class370
	{
		// Token: 0x06002409 RID: 9225 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
		public static Point smethod_0(this Point sz, Point max)
		{
			if (sz.X > max.X)
			{
				sz.X = max.X;
			}
			if (sz.Y > max.Y)
			{
				sz.Y = max.Y;
			}
			return sz;
		}

		// Token: 0x0600240A RID: 9226 RVA: 0x0007A254 File Offset: 0x00078454
		public static PointF smethod_1(this PointF value)
		{
			float num = value.X * value.X + value.Y * value.Y;
			float num2 = 1f / (float)Math.Sqrt((double)num);
			value.X *= num2;
			value.Y *= num2;
			return value;
		}

		// Token: 0x0600240B RID: 9227 RVA: 0x0007A2B0 File Offset: 0x000784B0
		public static Point smethod_2(this Point p, Rectangle bounds)
		{
			bounds = bounds.smethod_24();
			if (p.X < bounds.Left)
			{
				p.X = bounds.Left;
			}
			if (p.Y < bounds.Top)
			{
				p.Y = bounds.Top;
			}
			if (p.X > bounds.Right)
			{
				p.X = bounds.Right;
			}
			if (p.Y > bounds.Bottom)
			{
				p.Y = bounds.Bottom;
			}
			return p;
		}

		// Token: 0x0600240C RID: 9228 RVA: 0x0000F82F File Offset: 0x0000DA2F
		public static Point smethod_3(this Point p, int x, int y)
		{
			return new Point(p.X + x, p.Y + y);
		}

		// Token: 0x0600240D RID: 9229 RVA: 0x0000F848 File Offset: 0x0000DA48
		public static Rectangle smethod_4(this Point p, int width, int height)
		{
			return new Rectangle(p.X - width / 2, p.Y - height / 2, width, height);
		}

		// Token: 0x0600240E RID: 9230 RVA: 0x0000F867 File Offset: 0x0000DA67
		public static Rectangle smethod_5(this Point p, Size sz)
		{
			return new Rectangle(p.X - sz.Width / 2, p.Y - sz.Height / 2, sz.Width, sz.Height);
		}

		// Token: 0x0600240F RID: 9231 RVA: 0x0007A340 File Offset: 0x00078540
		public static Point smethod_6(this Point p)
		{
			if (SystemInformation.VirtualScreen.X < 0)
			{
				p.X += SystemInformation.VirtualScreen.X;
			}
			if (SystemInformation.VirtualScreen.Y < 0)
			{
				p.Y += SystemInformation.VirtualScreen.Y;
			}
			return p;
		}

		// Token: 0x06002410 RID: 9232 RVA: 0x0007A3A4 File Offset: 0x000785A4
		public static Point smethod_7(this Point p)
		{
			if (SystemInformation.VirtualScreen.X < 0)
			{
				p.X -= SystemInformation.VirtualScreen.X;
			}
			if (SystemInformation.VirtualScreen.Y < 0)
			{
				p.Y -= SystemInformation.VirtualScreen.Y;
			}
			return p;
		}

		// Token: 0x06002411 RID: 9233 RVA: 0x0000F89E File Offset: 0x0000DA9E
		public static Rectangle smethod_8(this Rectangle rec)
		{
			return new Rectangle(rec.Location.smethod_6(), rec.Size);
		}

		// Token: 0x06002412 RID: 9234 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		public static Rectangle smethod_9(this Rectangle rec)
		{
			return new Rectangle(rec.Location.smethod_7(), rec.Size);
		}

		// Token: 0x06002413 RID: 9235 RVA: 0x0000F8D2 File Offset: 0x0000DAD2
		[DebuggerStepThrough]
		public static Point smethod_10(this Point p, Point p2)
		{
			return new Point(p.X + p2.X, p.Y + p2.Y);
		}

		// Token: 0x06002414 RID: 9236 RVA: 0x0000F8F7 File Offset: 0x0000DAF7
		[DebuggerStepThrough]
		public static Point smethod_11(this Point p, Point p2)
		{
			return new Point(p.X - p2.X, p.Y - p2.Y);
		}
	}
}
