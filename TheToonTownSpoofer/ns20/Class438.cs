using System;
using System.Diagnostics;
using System.Drawing;
using ns23;
using ns31;

namespace ns20
{
	// Token: 0x0200042C RID: 1068
	internal static class Class438
	{
		// Token: 0x06002872 RID: 10354 RVA: 0x00098EE8 File Offset: 0x000970E8
		public static bool smethod_0(this Rectangle rec, Rectangle other)
		{
			return rec.Left <= other.Right && other.Left <= rec.Right && rec.Top <= other.Bottom && other.Top <= rec.Bottom;
		}

		// Token: 0x06002873 RID: 10355 RVA: 0x00098F3C File Offset: 0x0009713C
		public static Rectangle smethod_1(this Rectangle rec, Rectangle max_bounds)
		{
			rec = rec.smethod_24();
			max_bounds = max_bounds.smethod_24();
			if (rec.X < max_bounds.X)
			{
				int num = rec.Width - (max_bounds.X - rec.X);
				if (num < 0)
				{
					num = 0;
				}
				rec.Width = num;
				rec.X = max_bounds.X;
			}
			if (rec.Y < max_bounds.Y)
			{
				int num2 = rec.Height - (max_bounds.Y - rec.Y);
				if (num2 < 0)
				{
					num2 = 0;
				}
				rec.Height = num2;
				rec.Y = max_bounds.Y;
			}
			if (rec.X > max_bounds.Right)
			{
				rec.X = max_bounds.Right;
			}
			if (rec.Y > max_bounds.Bottom)
			{
				rec.Y = max_bounds.Bottom;
			}
			if (rec.Right > max_bounds.Right)
			{
				rec.Width = max_bounds.Right - rec.X;
			}
			if (rec.Bottom > max_bounds.Bottom)
			{
				rec.Height = max_bounds.Bottom - rec.Y;
			}
			return rec;
		}

		// Token: 0x06002874 RID: 10356 RVA: 0x00012634 File Offset: 0x00010834
		public static bool smethod_2(this Rectangle rec)
		{
			return rec.Size.smethod_1();
		}

		// Token: 0x06002875 RID: 10357 RVA: 0x00012642 File Offset: 0x00010842
		public static Rectangle smethod_3(this Rectangle rec, int width_offset, int height_offset)
		{
			return new Rectangle(rec.Location, new Size(rec.Width + width_offset, rec.Height + height_offset));
		}

		// Token: 0x06002876 RID: 10358 RVA: 0x00012667 File Offset: 0x00010867
		public static Rectangle smethod_4(this Rectangle rec, int xOffset, int yOffset)
		{
			return new Rectangle(rec.Location.smethod_3(xOffset, yOffset), rec.Size);
		}

		// Token: 0x06002877 RID: 10359 RVA: 0x00012683 File Offset: 0x00010883
		public static Rectangle smethod_5(this Rectangle rec, Size sz)
		{
			return rec.smethod_6(sz.Width, sz.Height);
		}

		// Token: 0x06002878 RID: 10360 RVA: 0x00012699 File Offset: 0x00010899
		public static Rectangle smethod_6(this Rectangle rec, int width_offset, int height_offset)
		{
			return new Rectangle(rec.X - width_offset / 2, rec.Y - height_offset / 2, rec.Width + width_offset, rec.Height + height_offset);
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x000126C8 File Offset: 0x000108C8
		[DebuggerStepThrough]
		public static PointF smethod_7(this RectangleF rec)
		{
			return new PointF(rec.X + rec.Width / 2f, rec.Y + rec.Height / 2f);
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x000126F9 File Offset: 0x000108F9
		[DebuggerStepThrough]
		public static float smethod_8(this RectangleF rec)
		{
			return rec.X + rec.Width / 2f;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00012710 File Offset: 0x00010910
		[DebuggerStepThrough]
		public static Point smethod_9(this Rectangle rec)
		{
			return new Point(rec.X + rec.Width / 2, rec.Y + rec.Height / 2);
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00012739 File Offset: 0x00010939
		public static int smethod_10(this Rectangle rec)
		{
			return rec.X + rec.Width / 2;
		}

		// Token: 0x0600287D RID: 10365 RVA: 0x0001274C File Offset: 0x0001094C
		public static int smethod_11(this Rectangle rec)
		{
			return rec.Y + rec.Height / 2;
		}

		// Token: 0x0600287E RID: 10366 RVA: 0x0001275F File Offset: 0x0001095F
		[DebuggerStepThrough]
		public static PointF smethod_12(this RectangleF rec)
		{
			return new PointF(rec.X, rec.Y + rec.Height);
		}

		// Token: 0x0600287F RID: 10367 RVA: 0x0001277C File Offset: 0x0001097C
		[DebuggerStepThrough]
		public static PointF smethod_13(this RectangleF rec)
		{
			return new PointF(rec.Right, rec.Bottom);
		}

		// Token: 0x06002880 RID: 10368 RVA: 0x00012791 File Offset: 0x00010991
		[DebuggerStepThrough]
		public static PointF smethod_14(this RectangleF rec)
		{
			return new PointF(rec.X + rec.Width / 2f, rec.Y + rec.Height);
		}

		// Token: 0x06002881 RID: 10369 RVA: 0x000127BC File Offset: 0x000109BC
		[DebuggerStepThrough]
		public static PointF smethod_15(this RectangleF rec)
		{
			return new PointF(rec.Right, rec.Top);
		}

		// Token: 0x06002882 RID: 10370 RVA: 0x000127D1 File Offset: 0x000109D1
		[DebuggerStepThrough]
		public static PointF smethod_16(this RectangleF rec)
		{
			return new PointF(rec.Left, rec.Top);
		}

		// Token: 0x06002883 RID: 10371 RVA: 0x000127E6 File Offset: 0x000109E6
		[DebuggerStepThrough]
		public static Point smethod_17(this Rectangle rec)
		{
			return new Point(rec.X, rec.Y + rec.Height);
		}

		// Token: 0x06002884 RID: 10372 RVA: 0x00012803 File Offset: 0x00010A03
		[DebuggerStepThrough]
		public static Point smethod_18(this Rectangle rec)
		{
			return new Point(rec.Right, rec.Bottom);
		}

		// Token: 0x06002885 RID: 10373 RVA: 0x00012818 File Offset: 0x00010A18
		[DebuggerStepThrough]
		public static Point smethod_19(this Rectangle rec)
		{
			return new Point(rec.X + rec.Width / 2, rec.Y + rec.Height);
		}

		// Token: 0x06002886 RID: 10374 RVA: 0x0001283F File Offset: 0x00010A3F
		[DebuggerStepThrough]
		public static Point smethod_20(this Rectangle rec)
		{
			return new Point(rec.Right, rec.Top);
		}

		// Token: 0x06002887 RID: 10375 RVA: 0x00012854 File Offset: 0x00010A54
		[DebuggerStepThrough]
		public static Point smethod_21(this Rectangle rec)
		{
			return new Point(rec.Left, rec.Top);
		}

		// Token: 0x06002888 RID: 10376 RVA: 0x0009906C File Offset: 0x0009726C
		public static Rectangle smethod_22(this Size sz, Rectangle bounds)
		{
			if (sz.Width > bounds.Width)
			{
				float num = (float)bounds.Width / (float)sz.Width;
				sz = new Size(bounds.Width, (int)((float)sz.Height * num));
			}
			if (sz.Height > bounds.Height)
			{
				float num2 = (float)bounds.Height / (float)sz.Height;
				sz = new Size((int)((float)sz.Width * num2), bounds.Height);
			}
			return new Rectangle(Point.Empty, sz)
			{
				X = bounds.X + (bounds.Width / 2 - sz.Width / 2),
				Y = bounds.Y + (bounds.Height / 2 - sz.Height / 2)
			};
		}

		// Token: 0x06002889 RID: 10377 RVA: 0x00099144 File Offset: 0x00097344
		[DebuggerStepThrough]
		public static bool smethod_23(this Rectangle rec, Point p)
		{
			return rec.X <= p.X && rec.X + rec.Width >= p.X && rec.Y <= p.Y && rec.Y + rec.Height >= p.Y;
		}

		// Token: 0x0600288A RID: 10378 RVA: 0x000991A8 File Offset: 0x000973A8
		[DebuggerStepThrough]
		public static Rectangle smethod_24(this Rectangle rec)
		{
			Rectangle result = rec;
			if (result.Width < 0)
			{
				result.X += result.Width;
				result.Width *= -1;
			}
			if (result.Height < 0)
			{
				result.Y += result.Height;
				result.Height *= -1;
			}
			return result;
		}
	}
}
