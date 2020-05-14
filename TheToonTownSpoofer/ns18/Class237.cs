using System;
using System.Drawing;
using ns23;
using ns27;

namespace ns18
{
	// Token: 0x020002AB RID: 683
	internal static class Class237
	{
		// Token: 0x06001BF1 RID: 7153 RVA: 0x00057754 File Offset: 0x00055954
		public static float? smethod_0(PointF sphereCenter, float sphereRadius, PointF rayPosition, float rayAngle)
		{
			double num = Class477.smethod_11((double)rayAngle);
			PointF pointF = new PointF(-(float)Math.Sin(num), (float)Math.Cos(num));
			pointF.smethod_1();
			return Class237.smethod_1(sphereCenter, sphereRadius, rayPosition, pointF);
		}

		// Token: 0x06001BF2 RID: 7154 RVA: 0x00057790 File Offset: 0x00055990
		public static float? smethod_1(PointF sphereCenter, float sphereRadius, PointF rayPosition, PointF rayDirection)
		{
			float num = sphereCenter.X - rayPosition.X;
			float num2 = sphereCenter.Y - rayPosition.Y;
			float num3 = num * num + num2 * num2;
			float num4 = sphereRadius * sphereRadius;
			if (num3 <= num4)
			{
				return new float?(0f);
			}
			float num5 = num * rayDirection.X + num2 * rayDirection.Y;
			if (num5 < 0f)
			{
				return null;
			}
			float num6 = num3 - num5 * num5;
			if (num6 > num4)
			{
				return null;
			}
			float num7 = (float)Math.Sqrt((double)(num4 - num6));
			return new float?(num5 - num7);
		}
	}
}
