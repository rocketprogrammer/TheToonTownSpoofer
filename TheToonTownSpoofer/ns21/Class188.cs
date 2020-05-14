using System;
using System.Drawing;

namespace ns21
{
	// Token: 0x02000246 RID: 582
	internal static class Class188
	{
		// Token: 0x060018F6 RID: 6390 RVA: 0x0004493C File Offset: 0x00042B3C
		public static Color smethod_0(Color baseColor, Color blendColor, int opacity)
		{
			return Color.FromArgb((int)((float)blendColor.R * ((float)opacity / 100f) + (float)baseColor.R * (1f - (float)opacity / 100f)), (int)((float)blendColor.G * ((float)opacity / 100f) + (float)baseColor.G * (1f - (float)opacity / 100f)), (int)((float)blendColor.B * ((float)opacity / 100f) + (float)baseColor.B * (1f - (float)opacity / 100f)));
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x000449CC File Offset: 0x00042BCC
		public static Color smethod_1(Color baseColor, Color blendColor, int opacity)
		{
			return Class188.smethod_0(baseColor, Color.FromArgb(Class188.smethod_3((int)baseColor.R, (int)blendColor.R), Class188.smethod_3((int)baseColor.G, (int)blendColor.G), Class188.smethod_3((int)baseColor.B, (int)blendColor.B)), opacity);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00044A20 File Offset: 0x00042C20
		public static Color smethod_2(Color baseColor, Color blendColor, int opacity)
		{
			return Class188.smethod_0(baseColor, Color.FromArgb(Class188.smethod_4((int)baseColor.R, (int)blendColor.R), Class188.smethod_4((int)baseColor.G, (int)blendColor.G), Class188.smethod_4((int)baseColor.B, (int)blendColor.B)), opacity);
		}

		// Token: 0x060018F9 RID: 6393 RVA: 0x00044A74 File Offset: 0x00042C74
		private static int smethod_3(int ibase, int blend)
		{
			float num = (float)ibase / 255f;
			float num2 = (float)blend / 255f;
			if ((double)num2 < 0.5)
			{
				return (int)(((double)(2f * num * num2) + Math.Pow((double)num, 2.0) * (double)(1f - 2f * num2)) * 255.0);
			}
			return (int)((Math.Sqrt((double)num) * (double)(2f * num2 - 1f) + (double)(2f * num * (1f - num2))) * 255.0);
		}

		// Token: 0x060018FA RID: 6394 RVA: 0x00044B08 File Offset: 0x00042D08
		private static int smethod_4(int ibase, int blend)
		{
			double num = (double)ibase / 255.0;
			double num2 = (double)blend / 255.0;
			if (num < 0.5)
			{
				return (int)(2.0 * num * num2 * 255.0);
			}
			return (int)((1.0 - 2.0 * (1.0 - num) * (1.0 - num2)) * 255.0);
		}
	}
}
