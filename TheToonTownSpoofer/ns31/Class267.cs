using System;
using System.Drawing;

namespace ns31
{
	// Token: 0x020002E2 RID: 738
	internal static class Class267
	{
		// Token: 0x06001D60 RID: 7520 RVA: 0x0000B034 File Offset: 0x00009234
		public static Size smethod_0(this Size sz, Size max)
		{
			if (sz.Width > max.Width)
			{
				sz.Width = max.Width;
			}
			if (sz.Height > max.Height)
			{
				sz.Height = max.Height;
			}
			return sz;
		}

		// Token: 0x06001D61 RID: 7521 RVA: 0x0000B073 File Offset: 0x00009273
		public static bool smethod_1(this Size sz)
		{
			return sz.Width != 0 && sz.Height != 0;
		}

		// Token: 0x06001D62 RID: 7522 RVA: 0x0005E344 File Offset: 0x0005C544
		public static Size smethod_2(this Size sz, int maxWidth, int maxHeight)
		{
			if (sz.Width > maxWidth)
			{
				sz.Height = (int)((float)maxWidth / (float)sz.Width * (float)sz.Height);
				sz.Width = maxWidth;
			}
			if (sz.Height > maxHeight)
			{
				sz.Width = (int)((float)maxHeight / (float)sz.Height * (float)sz.Width);
				sz.Height = maxHeight;
			}
			return sz;
		}

		// Token: 0x06001D63 RID: 7523 RVA: 0x0000B08D File Offset: 0x0000928D
		public static Size smethod_3(this Size sz, float scale)
		{
			return new Size((int)Math.Ceiling((double)((float)sz.Width * scale)), (int)Math.Ceiling((double)((float)sz.Height * scale)));
		}
	}
}
