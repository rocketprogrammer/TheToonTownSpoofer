using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using ns22;
using ns26;
using ns27;
using ns29;
using ns30;

namespace ns28
{
	// Token: 0x020004B1 RID: 1201
	internal sealed class Class150 : Class123
	{
		// Token: 0x06002D14 RID: 11540 RVA: 0x000AD80C File Offset: 0x000ABA0C
		protected override void vmethod_0()
		{
			lock (this.object_0)
			{
				this.class125_0.Dispose();
				this.method_4();
			}
			base.vmethod_0();
		}

		// Token: 0x06002D15 RID: 11541 RVA: 0x000AD860 File Offset: 0x000ABA60
		public void method_4()
		{
			lock (this.object_0)
			{
				foreach (Class150 @class in this.dictionary_0.Values)
				{
					@class.Dispose();
				}
				this.dictionary_0.Clear();
			}
		}

		// Token: 0x17000B22 RID: 2850
		// (get) Token: 0x06002D16 RID: 11542 RVA: 0x000AD8EC File Offset: 0x000ABAEC
		public Bitmap GetBitmap
		{
			get
			{
				Bitmap result;
				lock (this.object_0)
				{
					Bitmap bitmap = null;
					try
					{
						bitmap = new Bitmap(this.class125_0.Size.Width, this.class125_0.Size.Height);
						this.class125_0.method_5();
						using (Graphics graphics = Graphics.FromImage(bitmap))
						{
							graphics.DrawImage(this.class125_0.BaseBitmap, new Rectangle(Point.Empty, this.class125_0.Size));
						}
						result = bitmap;
					}
					catch
					{
						if (bitmap != null)
						{
							bitmap.Dispose();
						}
						throw;
					}
					finally
					{
						this.class125_0.method_4();
					}
				}
				return result;
			}
		}

		// Token: 0x17000B23 RID: 2851
		// (get) Token: 0x06002D17 RID: 11543 RVA: 0x000AD9DC File Offset: 0x000ABBDC
		public unsafe Struct54[] GetPixels
		{
			get
			{
				Struct54[] array = new Struct54[this.size_0.Width * this.size_0.Height];
				lock (this.object_0)
				{
					Struct33* ptr = this.class125_0.pBase;
					Struct54[] array2;
					Struct54* ptr2;
					if ((array2 = array) != null && array2.Length != 0)
					{
						fixed (Struct54* ptr2 = &array2[0])
						{
						}
					}
					else
					{
						ptr2 = null;
					}
					Struct54* ptr3 = ptr2;
					for (int i = 0; i < this.size_0.Width * this.size_0.Height; i++)
					{
						*ptr3 = Struct54.smethod_2(*ptr);
						ptr++;
						ptr3++;
					}
					ptr2 = null;
				}
				return array;
			}
		}

		// Token: 0x06002D18 RID: 11544 RVA: 0x00015782 File Offset: 0x00013982
		private Class150()
		{
			this.dictionary_0 = new Dictionary<Size, Class150>();
		}

		// Token: 0x06002D19 RID: 11545 RVA: 0x000157A0 File Offset: 0x000139A0
		public Class150(Class125 bmp) : this()
		{
			this.size_0 = bmp.Size;
			this.class125_0 = bmp;
			this.class125_0.method_4();
		}

		// Token: 0x06002D1A RID: 11546 RVA: 0x000157C6 File Offset: 0x000139C6
		public Class150(Bitmap bmp, bool ownsBitmap) : this()
		{
			this.size_0 = bmp.Size;
			this.class125_0 = new Class125(bmp, ownsBitmap);
			this.class125_0.method_4();
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x000ADAC0 File Offset: 0x000ABCC0
		public unsafe Class150(Struct54[] pixels, Size sz) : this()
		{
			if (pixels == null)
			{
				throw new ArgumentNullException("pixels");
			}
			this.size_0 = sz;
			this.class125_0 = new Class125(sz);
			this.class125_0.method_4();
			Struct33* ptr = this.class125_0.pBase;
			Struct54* ptr2;
			if (pixels != null && pixels.Length != 0)
			{
				fixed (Struct54* ptr2 = &pixels[0])
				{
				}
			}
			else
			{
				ptr2 = null;
			}
			Struct54* ptr3 = ptr2;
			for (int i = 0; i < sz.Width * sz.Height; i++)
			{
				*ptr = Struct33.smethod_2(*ptr3);
				ptr++;
				ptr3++;
			}
			ptr2 = null;
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x000ADB68 File Offset: 0x000ABD68
		public unsafe static bool smethod_0(Class150 source, Struct46 sourceRatio, Class150 value, Struct46 valueRatio, int max_diff, out Point location)
		{
			int num = (int)((double)source.size_0.Width / sourceRatio.double_2);
			int num2 = (int)((double)source.size_0.Height / sourceRatio.double_3);
			int num3 = (int)((double)value.size_0.Width / valueRatio.double_2);
			int num4 = (int)((double)value.size_0.Height / valueRatio.double_3);
			int num5;
			if (num > num3)
			{
				num5 = num3;
			}
			else
			{
				num5 = num;
			}
			int num6;
			if (num2 > num4)
			{
				num6 = num4;
			}
			else
			{
				num6 = num2;
			}
			Size sz = new Size((int)Math.Round(sourceRatio.double_2 * (double)num5), (int)Math.Round(sourceRatio.double_3 * (double)num6));
			Size sz2 = new Size((int)Math.Round(valueRatio.double_2 * (double)num5), (int)Math.Round(valueRatio.double_3 * (double)num6));
			if (sz2.Width <= sz.Width && sz2.Height <= sz.Height)
			{
				Class150 @class = source.method_5(sz);
				Class150 class2 = value.method_5(sz2);
				lock (@class.object_0)
				{
					lock (class2.object_0)
					{
						Struct33* pBase = @class.class125_0.pBase;
						Struct33* pBase2 = class2.class125_0.pBase;
						decimal d = sz2.Width * sz2.Height * 3m;
						for (int i = 0; i < sz.Height - sz2.Height; i++)
						{
							for (int j = 0; j < sz.Width - sz2.Width; j++)
							{
								Struct33* ptr = pBase2;
								uint num7 = 0U;
								int num8 = j + sz2.Width;
								for (int k = i; k < i + sz2.Height; k++)
								{
									Struct33* ptr2 = pBase + k * sz.Width + j;
									for (int l = j; l < num8; l++)
									{
										num7 = num7 + Class477.smethod_8((int)ptr2->R, (int)ptr->R) + Class477.smethod_8((int)ptr2->G, (int)ptr->G) + Class477.smethod_8((int)ptr2->B, (int)ptr->B);
										ptr2++;
										ptr++;
									}
									if (num7 / d > max_diff)
									{
										break;
									}
								}
								if (num7 / d < max_diff)
								{
									location = new Point((int)Math.Round((double)j / (double)sz.Width * (double)source.size_0.Width), (int)Math.Round((double)i / (double)sz.Height * (double)source.size_0.Height));
									return true;
								}
							}
						}
					}
				}
				location = Point.Empty;
				return false;
			}
			location = Point.Empty;
			return false;
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x000ADEE8 File Offset: 0x000AC0E8
		public static bool smethod_1(Class150 left, Class150 right, int max_diff)
		{
			if (left.size_0 != right.size_0)
			{
				int width = Math.Min(left.size_0.Width, right.size_0.Width);
				int height = Math.Min(left.size_0.Width, right.size_0.Height);
				Size sz = new Size(width, height);
				left = left.method_5(sz);
				right = right.method_5(sz);
			}
			int num = 1;
			int num2 = Class150.smethod_2(left, right, 0, 0);
			if (num2 <= max_diff)
			{
				return true;
			}
			bool flag = left.size_0.Width > num;
			bool flag2 = left.size_0.Height > num;
			if (flag)
			{
				int num3;
				if ((num3 = Class150.smethod_2(left, right, -num, 0)) < num2)
				{
					num2 = num3;
				}
				if (num2 <= max_diff)
				{
					return true;
				}
				if ((num3 = Class150.smethod_2(left, right, num, 0)) < num2)
				{
					num2 = num3;
				}
				if (num2 <= max_diff)
				{
					return true;
				}
			}
			if (flag && flag2)
			{
				int num3;
				if ((num3 = Class150.smethod_2(left, right, -num, num)) < num2)
				{
					num2 = num3;
				}
				if (num2 <= max_diff)
				{
					return true;
				}
				if ((num3 = Class150.smethod_2(left, right, -num, -num)) < num2)
				{
					num2 = num3;
				}
				if (num2 <= max_diff)
				{
					return true;
				}
				if ((num3 = Class150.smethod_2(left, right, num, num)) < num2)
				{
					num2 = num3;
				}
				if (num2 <= max_diff)
				{
					return true;
				}
				if ((num3 = Class150.smethod_2(left, right, num, -num)) < num2)
				{
					num2 = num3;
				}
				if (num2 <= max_diff)
				{
					return true;
				}
			}
			if (flag2)
			{
				int num3;
				if ((num3 = Class150.smethod_2(left, right, 0, -num)) < num2)
				{
					num2 = num3;
				}
				if (num2 <= max_diff)
				{
					return true;
				}
				if ((num3 = Class150.smethod_2(left, right, 0, num)) < num2)
				{
					num2 = num3;
				}
				if (num2 <= max_diff)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002D1E RID: 11550 RVA: 0x000AE098 File Offset: 0x000AC298
		public unsafe static int smethod_2(Class150 left, Class150 right, int x_pixel_offset, int y_pixel_offset)
		{
			int result;
			lock (right.object_0)
			{
				lock (left.object_0)
				{
					uint num = 0U;
					Size size = left.size_0;
					Struct33* pBase = left.class125_0.pBase;
					Struct33* pBase2 = right.class125_0.pBase;
					int num2;
					int num3;
					if (x_pixel_offset > 0)
					{
						num2 = x_pixel_offset;
						num3 = 0;
					}
					else
					{
						x_pixel_offset = Math.Abs(x_pixel_offset);
						num3 = x_pixel_offset;
						num2 = 0;
					}
					int num4;
					int num5;
					if (y_pixel_offset > 0)
					{
						num4 = y_pixel_offset;
						num5 = 0;
					}
					else
					{
						y_pixel_offset = Math.Abs(y_pixel_offset);
						num5 = y_pixel_offset;
						num4 = 0;
					}
					int i = y_pixel_offset;
					while (i < size.Height)
					{
						Struct33* ptr = pBase + num4 * size.Width + num2;
						Struct33* ptr2 = pBase2 + num5 * size.Width + num3;
						for (int j = x_pixel_offset; j < size.Width; j++)
						{
							num = num + Class477.smethod_8((int)ptr->R, (int)ptr2->R) + Class477.smethod_8((int)ptr->G, (int)ptr2->G) + Class477.smethod_8((int)ptr->B, (int)ptr2->B);
							ptr++;
							ptr2++;
						}
						i++;
						num4++;
						num5++;
					}
					result = (int)(num / ((size.Width - x_pixel_offset) * (size.Height - y_pixel_offset) * 3m));
				}
			}
			return result;
		}

		// Token: 0x06002D1F RID: 11551 RVA: 0x000AE27C File Offset: 0x000AC47C
		private Class150 method_5(Size sz)
		{
			if (this.size_0 == sz)
			{
				return this;
			}
			if (this.dictionary_0.ContainsKey(sz))
			{
				return this.dictionary_0[sz];
			}
			Bitmap bitmap = null;
			Class150 result;
			lock (this.object_0)
			{
				try
				{
					bitmap = new Bitmap(sz.Width, sz.Height);
					this.class125_0.method_5();
					using (Graphics graphics = Graphics.FromImage(bitmap))
					{
						graphics.InterpolationMode = InterpolationMode.High;
						graphics.SmoothingMode = SmoothingMode.AntiAlias;
						graphics.DrawImage(this.class125_0.BaseBitmap, new Rectangle(Point.Empty, sz));
					}
					Class150 @class = null;
					try
					{
						@class = new Class150(bitmap, true);
						this.dictionary_0.Add(sz, @class);
						result = @class;
					}
					catch
					{
						if (@class != null)
						{
							@class.Dispose();
						}
						throw;
					}
				}
				catch
				{
					if (bitmap != null)
					{
						bitmap.Dispose();
					}
					throw;
				}
				finally
				{
					this.class125_0.method_4();
				}
			}
			return result;
		}

		// Token: 0x0400179A RID: 6042
		private Dictionary<Size, Class150> dictionary_0;

		// Token: 0x0400179B RID: 6043
		private readonly Class125 class125_0;

		// Token: 0x0400179C RID: 6044
		public readonly Size size_0;

		// Token: 0x0400179D RID: 6045
		private readonly object object_0 = new object();
	}
}
