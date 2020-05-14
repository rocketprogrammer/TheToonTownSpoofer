using System;
using System.Drawing.Imaging;

namespace ns24
{
	// Token: 0x0200031C RID: 796
	internal static class Class304
	{
		// Token: 0x06001ED0 RID: 7888 RVA: 0x000652CC File Offset: 0x000634CC
		public static string smethod_0(this PixelFormat format)
		{
			if (format <= PixelFormat.Format8bppIndexed)
			{
				if (format <= PixelFormat.Format32bppRgb)
				{
					switch (format)
					{
					case PixelFormat.Format16bppRgb555:
					case PixelFormat.Format16bppRgb565:
						break;
					default:
						if (format == PixelFormat.Format24bppRgb)
						{
							return "24 bits per pixel";
						}
						if (format != PixelFormat.Format32bppRgb)
						{
							goto IL_D7;
						}
						return "32 bits per pixel with empty alpha information";
					}
				}
				else
				{
					if (format == PixelFormat.Format1bppIndexed)
					{
						return "1 bit per pixel";
					}
					if (format == PixelFormat.Format4bppIndexed)
					{
						return "4 bits per pixel";
					}
					if (format != PixelFormat.Format8bppIndexed)
					{
						goto IL_D7;
					}
					return "8 bits per pixel";
				}
			}
			else if (format <= PixelFormat.Format16bppGrayScale)
			{
				if (format != PixelFormat.Format16bppArgb1555)
				{
					if (format == PixelFormat.Format32bppPArgb)
					{
						return "32 bits per pixel with premultiplied red, green and blue components according to the alpha component";
					}
					if (format != PixelFormat.Format16bppGrayScale)
					{
						goto IL_D7;
					}
				}
			}
			else if (format <= PixelFormat.Format64bppPArgb)
			{
				if (format == PixelFormat.Format48bppRgb)
				{
					return "48 bits per pixel";
				}
				if (format != PixelFormat.Format64bppPArgb)
				{
					goto IL_D7;
				}
				return "64 bits per pixel with premultiplied red, green and blue components according to the alpha component";
			}
			else
			{
				if (format == PixelFormat.Format32bppArgb)
				{
					return "32 bits per pixel";
				}
				if (format != PixelFormat.Format64bppArgb)
				{
					goto IL_D7;
				}
				return "64 bits per pixel";
			}
			return "16 bits per pixel";
			IL_D7:
			return "unknown";
		}
	}
}
