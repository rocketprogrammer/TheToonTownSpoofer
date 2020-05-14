using System;
using System.Diagnostics;
using System.Drawing;
using ns20;

namespace ns27
{
	// Token: 0x02000477 RID: 1143
	internal static class Class477
	{
		// Token: 0x06002AA6 RID: 10918 RVA: 0x000A4774 File Offset: 0x000A2974
		[DebuggerStepThrough]
		public static bool smethod_0(PointF center, float radius, PointF point)
		{
			return Math.Pow((double)(point.X - center.X), 2.0) + Math.Pow((double)(point.Y - center.Y), 2.0) < Math.Pow((double)radius, 2.0);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x000A47D0 File Offset: 0x000A29D0
		[DebuggerStepThrough]
		public static int smethod_1(PointF center, float radius, Class477.Struct48 line, out PointF intersection1, out PointF intersection2)
		{
			float num = line.pointF_1.X - line.pointF_0.X;
			float num2 = line.pointF_1.Y - line.pointF_0.Y;
			float num3 = num * num + num2 * num2;
			float num4 = 2f * (num * (line.pointF_0.X - center.X) + num2 * (line.pointF_0.Y - center.Y));
			float num5 = (line.pointF_0.X - center.X) * (line.pointF_0.X - center.X) + (line.pointF_0.Y - center.Y) * (line.pointF_0.Y - center.Y) - radius * radius;
			float num6 = num4 * num4 - 4f * num3 * num5;
			if ((double)num3 <= 1E-07 || num6 < 0f)
			{
				intersection1 = new PointF(float.NaN, float.NaN);
				intersection2 = new PointF(float.NaN, float.NaN);
				return 0;
			}
			float num7;
			if (num6 == 0f)
			{
				num7 = -num4 / (2f * num3);
				intersection1 = new PointF(line.pointF_0.X + num7 * num, line.pointF_0.Y + num7 * num2);
				intersection2 = new PointF(float.NaN, float.NaN);
				return 1;
			}
			num7 = (float)(((double)(-(double)num4) + Math.Sqrt((double)num6)) / (double)(2f * num3));
			intersection1 = new PointF(line.pointF_0.X + num7 * num, line.pointF_0.Y + num7 * num2);
			num7 = (float)(((double)(-(double)num4) - Math.Sqrt((double)num6)) / (double)(2f * num3));
			intersection2 = new PointF(line.pointF_0.X + num7 * num, line.pointF_0.Y + num7 * num2);
			return 2;
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x000A4A28 File Offset: 0x000A2C28
		public static float? smethod_2(PointF p, RectangleF rec)
		{
			PointF end = rec.smethod_7();
			Class477.Struct48 ab = new Class477.Struct48(p, end);
			PointF? pointF = null;
			if (p.Y <= rec.Top)
			{
				pointF = Class477.smethod_3(ab, rec);
				if (pointF == null)
				{
					if (p.X < rec.Left)
					{
						pointF = Class477.smethod_4(ab, rec);
					}
					else
					{
						pointF = Class477.smethod_5(ab, rec);
					}
				}
			}
			else if (p.Y >= rec.Bottom)
			{
				pointF = Class477.smethod_6(ab, rec);
				if (pointF == null)
				{
					if (p.X < rec.Left)
					{
						pointF = Class477.smethod_4(ab, rec);
					}
					else
					{
						pointF = Class477.smethod_5(ab, rec);
					}
				}
			}
			else if (p.X <= rec.Left)
			{
				pointF = Class477.smethod_4(ab, rec);
			}
			else
			{
				if (p.X < rec.Right)
				{
					return null;
				}
				pointF = Class477.smethod_5(ab, rec);
			}
			if (pointF == null)
			{
				return null;
			}
			return new float?(Class477.smethod_9(p, pointF.Value));
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x00013D95 File Offset: 0x00011F95
		[DebuggerStepThrough]
		private static PointF? smethod_3(Class477.Struct48 AB, RectangleF rec)
		{
			return Class477.smethod_7(AB, new Class477.Struct48(rec.smethod_16(), rec.smethod_15()));
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x00013DAE File Offset: 0x00011FAE
		[DebuggerStepThrough]
		private static PointF? smethod_4(Class477.Struct48 AB, RectangleF rec)
		{
			return Class477.smethod_7(AB, new Class477.Struct48(rec.smethod_16(), rec.smethod_12()));
		}

		// Token: 0x06002AAB RID: 10923 RVA: 0x00013DC7 File Offset: 0x00011FC7
		[DebuggerStepThrough]
		private static PointF? smethod_5(Class477.Struct48 AB, RectangleF rec)
		{
			return Class477.smethod_7(AB, new Class477.Struct48(rec.smethod_15(), rec.smethod_13()));
		}

		// Token: 0x06002AAC RID: 10924 RVA: 0x00013DE0 File Offset: 0x00011FE0
		[DebuggerStepThrough]
		private static PointF? smethod_6(Class477.Struct48 AB, RectangleF rec)
		{
			return Class477.smethod_7(AB, new Class477.Struct48(rec.smethod_12(), rec.smethod_13()));
		}

		// Token: 0x06002AAD RID: 10925 RVA: 0x000A4B40 File Offset: 0x000A2D40
		[DebuggerStepThrough]
		public static PointF? smethod_7(Class477.Struct48 AB, Class477.Struct48 CD)
		{
			double num = (double)(AB.pointF_0.Y - CD.pointF_0.Y);
			double num2 = (double)(CD.pointF_1.X - CD.pointF_0.X);
			double num3 = (double)(AB.pointF_0.X - CD.pointF_0.X);
			double num4 = (double)(CD.pointF_1.Y - CD.pointF_0.Y);
			double num5 = (double)(AB.pointF_1.X - AB.pointF_0.X);
			double num6 = (double)(AB.pointF_1.Y - AB.pointF_0.Y);
			double num7 = num5 * num4 - num6 * num2;
			double num8 = num * num2 - num3 * num4;
			if (num7 == 0.0)
			{
				if (num8 != 0.0)
				{
					return null;
				}
				if (AB.pointF_0.X >= CD.pointF_0.X && AB.pointF_0.X <= CD.pointF_1.X)
				{
					return new PointF?(AB.pointF_0);
				}
				if (CD.pointF_0.X >= AB.pointF_0.X && CD.pointF_0.X <= AB.pointF_1.X)
				{
					return new PointF?(CD.pointF_0);
				}
				return null;
			}
			else
			{
				double num9 = num8 / num7;
				if (num9 < 0.0 || num9 > 1.0)
				{
					return null;
				}
				double num10 = (num * num5 - num3 * num6) / num7;
				if (num10 >= 0.0 && num10 <= 1.0)
				{
					return new PointF?(new PointF((float)((double)AB.pointF_0.X + num9 * num5), (float)((double)AB.pointF_0.Y + num9 * num6)));
				}
				return null;
			}
		}

		// Token: 0x06002AAE RID: 10926 RVA: 0x00013DF9 File Offset: 0x00011FF9
		[DebuggerStepThrough]
		public static uint smethod_8(int left, int right)
		{
			return (uint)Math.Abs(left - right);
		}

		// Token: 0x06002AAF RID: 10927 RVA: 0x000A4DA8 File Offset: 0x000A2FA8
		[DebuggerStepThrough]
		public static float smethod_9(PointF p1, PointF p2)
		{
			return (float)Math.Abs(Math.Sqrt(Math.Pow((double)(p2.X - p1.X), 2.0) + Math.Pow((double)(p2.Y - p1.Y), 2.0)));
		}

		// Token: 0x06002AB0 RID: 10928 RVA: 0x00013E03 File Offset: 0x00012003
		[DebuggerStepThrough]
		public static double smethod_10(double sideA, double sideB, double angleB)
		{
			return Class477.smethod_12(Math.Asin(sideA * Math.Sin(Class477.smethod_11(angleB)) / sideB));
		}

		// Token: 0x06002AB1 RID: 10929 RVA: 0x00013E1E File Offset: 0x0001201E
		[DebuggerStepThrough]
		public static double smethod_11(double degrees)
		{
			return degrees * Class477.double_0;
		}

		// Token: 0x06002AB2 RID: 10930 RVA: 0x00013E27 File Offset: 0x00012027
		[DebuggerStepThrough]
		public static double smethod_12(double radians)
		{
			return radians * Class477.double_1;
		}

		// Token: 0x06002AB3 RID: 10931 RVA: 0x00013E30 File Offset: 0x00012030
		[DebuggerStepThrough]
		public static float smethod_13(Point p1, Point p2)
		{
			return ((float)p1.Y - (float)p2.Y) / ((float)p1.X - (float)p2.X);
		}

		// Token: 0x04001689 RID: 5769
		public static readonly double double_0 = 0.017453292519943295;

		// Token: 0x0400168A RID: 5770
		public static readonly double double_1 = 57.29577951308232;

		// Token: 0x02000478 RID: 1144
		internal struct Struct48
		{
			// Token: 0x06002AB5 RID: 10933 RVA: 0x00013E73 File Offset: 0x00012073
			[DebuggerStepThrough]
			public Struct48(PointF start, PointF end)
			{
				this.pointF_0 = start;
				this.pointF_1 = end;
			}

			// Token: 0x0400168B RID: 5771
			public readonly PointF pointF_0;

			// Token: 0x0400168C RID: 5772
			public readonly PointF pointF_1;
		}
	}
}
