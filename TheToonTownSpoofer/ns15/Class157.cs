using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace ns15
{
	// Token: 0x0200020A RID: 522
	internal static class Class157
	{
		// Token: 0x060016EA RID: 5866 RVA: 0x00037820 File Offset: 0x00035A20
		public static ImageCodecInfo smethod_0(string mimeType)
		{
			ImageCodecInfo[] imageEncoders = ImageCodecInfo.GetImageEncoders();
			for (int i = 0; i < imageEncoders.Length; i++)
			{
				if (imageEncoders[i].MimeType == mimeType)
				{
					return imageEncoders[i];
				}
			}
			return null;
		}

		// Token: 0x060016EB RID: 5867 RVA: 0x00006CC9 File Offset: 0x00004EC9
		public static ImageCodecInfo smethod_1()
		{
			return Class157.smethod_4(ImageCodecInfo.GetImageEncoders(), Class157.guid_1, Class157.string_2);
		}

		// Token: 0x060016EC RID: 5868 RVA: 0x00006CDF File Offset: 0x00004EDF
		public static ImageCodecInfo smethod_2()
		{
			return Class157.smethod_4(ImageCodecInfo.GetImageEncoders(), Class157.guid_0, Class157.string_1);
		}

		// Token: 0x060016ED RID: 5869 RVA: 0x00006CF5 File Offset: 0x00004EF5
		public static ImageCodecInfo smethod_3()
		{
			return Class157.smethod_4(ImageCodecInfo.GetImageDecoders(), Class157.guid_0, Class157.string_1);
		}

		// Token: 0x060016EE RID: 5870 RVA: 0x00037858 File Offset: 0x00035A58
		private static ImageCodecInfo smethod_4(ImageCodecInfo[] codecs, Guid image_guid, string mime_type)
		{
			int num = codecs.Length;
			for (int i = 0; i < num; i++)
			{
				if (codecs[i].Clsid == image_guid)
				{
					return codecs[i];
				}
			}
			for (int j = 0; j < num; j++)
			{
				if (codecs[j].MimeType == mime_type)
				{
					return codecs[j];
				}
			}
			throw new InvalidOperationException(Class157.string_0);
		}

		// Token: 0x060016EF RID: 5871 RVA: 0x00006D0B File Offset: 0x00004F0B
		public static void smethod_5(Bitmap image, Stream image_stream, int quality)
		{
			Class157.smethod_7(image, image_stream, quality, Class157.smethod_2());
		}

		// Token: 0x060016F0 RID: 5872 RVA: 0x00006D1A File Offset: 0x00004F1A
		public static void smethod_6(Bitmap image, Stream image_stream, int quality)
		{
			Class157.smethod_7(image, image_stream, quality, Class157.smethod_1());
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x000378B4 File Offset: 0x00035AB4
		private static void smethod_7(Bitmap image, Stream image_stream, int quality, ImageCodecInfo codec)
		{
			if (quality >= 0 && quality <= 100)
			{
				using (EncoderParameters encoderParameters = new EncoderParameters())
				{
					using (EncoderParameter encoderParameter = new EncoderParameter(Encoder.Quality, (long)quality))
					{
						encoderParameters.Param = new EncoderParameter[]
						{
							encoderParameter
						};
						image.Save(image_stream, codec, encoderParameters);
					}
					return;
				}
			}
			throw new ArgumentOutOfRangeException("quality", string.Format("Quality is out of range: '{0}'.", quality));
		}

		// Token: 0x060016F2 RID: 5874 RVA: 0x00037948 File Offset: 0x00035B48
		public static void smethod_8(Bitmap image, Stream image_stream, int quality, int width, int height)
		{
			using (Bitmap bitmap = new Bitmap(image, width, height))
			{
				Class157.smethod_5(bitmap, image_stream, quality);
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x00037984 File Offset: 0x00035B84
		public static void smethod_9(Bitmap image, Stream image_stream, int quality, int width, int height)
		{
			using (Bitmap bitmap = new Bitmap(image, width, height))
			{
				Class157.smethod_6(bitmap, image_stream, quality);
			}
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x000379C0 File Offset: 0x00035BC0
		public static void smethod_10(Bitmap image, Stream image_stream, Color backColor, int quality, int width, int height)
		{
			using (Bitmap bitmap = new Bitmap(width, height))
			{
				using (Graphics graphics = Graphics.FromImage(bitmap))
				{
					graphics.SmoothingMode = SmoothingMode.HighQuality;
					graphics.InterpolationMode = InterpolationMode.High;
					graphics.CompositingQuality = CompositingQuality.HighQuality;
					graphics.Clear(backColor);
					graphics.DrawImage(image, new Rectangle(Point.Empty, new Size(width, height)));
				}
				Class157.smethod_6(bitmap, image_stream, quality);
			}
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x00006D29 File Offset: 0x00004F29
		public static void smethod_11(Bitmap image, Stream image_stream, Color backColor, int quality)
		{
			Class157.smethod_10(image, image_stream, backColor, quality, image.Width, image.Height);
		}

		// Token: 0x040004FC RID: 1276
		private static readonly string string_0 = "The PNG image codec was not found.";

		// Token: 0x040004FD RID: 1277
		private static readonly Guid guid_0 = new Guid("{557cf406-1a04-11d3-9a73-0000f81ef32e}");

		// Token: 0x040004FE RID: 1278
		private static readonly string string_1 = "image/png";

		// Token: 0x040004FF RID: 1279
		private static readonly string string_2 = "image/jpeg";

		// Token: 0x04000500 RID: 1280
		private static readonly Guid guid_1 = new Guid("{557cf401-1a04-11d3-9a73-0000f81ef32e}");
	}
}
