using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ns31
{
	// Token: 0x020002E3 RID: 739
	internal static class Class268
	{
		// Token: 0x06001D64 RID: 7524 RVA: 0x0005E3B0 File Offset: 0x0005C5B0
		public static void smethod_0(this Graphics gr, Image image, Rectangle rect, float opacity)
		{
			ColorMatrix colorMatrix = new ColorMatrix();
			colorMatrix.Matrix33 = opacity;
			using (ImageAttributes imageAttributes = new ImageAttributes())
			{
				imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
				gr.DrawImage(image, rect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, imageAttributes);
			}
		}
	}
}
