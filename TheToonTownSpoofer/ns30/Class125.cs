using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Security.Permissions;
using ns17;
using ns22;
using ns26;

namespace ns30
{
	// Token: 0x020001FE RID: 510
	internal sealed class Class125 : Class123
	{
		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x060016A3 RID: 5795 RVA: 0x000069D6 File Offset: 0x00004BD6
		public unsafe Struct33* pBase
		{
			[DebuggerStepThrough]
			get
			{
				return this.pStruct33_0;
			}
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x060016A4 RID: 5796 RVA: 0x000069DE File Offset: 0x00004BDE
		public int Width
		{
			[DebuggerStepThrough]
			get
			{
				return this.rectangle_0.Width;
			}
		}

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x060016A5 RID: 5797 RVA: 0x000069EB File Offset: 0x00004BEB
		public int Height
		{
			[DebuggerStepThrough]
			get
			{
				return this.rectangle_0.Height;
			}
		}

		// Token: 0x17000705 RID: 1797
		// (get) Token: 0x060016A6 RID: 5798 RVA: 0x000069F8 File Offset: 0x00004BF8
		public Size Size
		{
			[DebuggerStepThrough]
			get
			{
				return this.rectangle_0.Size;
			}
		}

		// Token: 0x17000706 RID: 1798
		// (get) Token: 0x060016A7 RID: 5799 RVA: 0x00006A05 File Offset: 0x00004C05
		public Bitmap BaseBitmap
		{
			[DebuggerStepThrough]
			get
			{
				return this.bitmap_0;
			}
		}

		// Token: 0x17000707 RID: 1799
		// (get) Token: 0x060016A8 RID: 5800 RVA: 0x00006A0D File Offset: 0x00004C0D
		public bool IsLocked
		{
			[DebuggerStepThrough]
			get
			{
				return this.bool_2;
			}
		}

		// Token: 0x17000708 RID: 1800
		// (get) Token: 0x060016A9 RID: 5801 RVA: 0x00036980 File Offset: 0x00034B80
		public unsafe Struct33[,] Colors
		{
			get
			{
				Struct33[,] array = new Struct33[this.Size.Width, this.Size.Height];
				Struct33* ptr = this.pStruct33_0;
				for (int i = 0; i < this.Size.Height; i++)
				{
					for (int j = 0; j < this.Size.Width; j++)
					{
						array[j, i] = *ptr;
						ptr++;
					}
				}
				return array;
			}
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00036A0C File Offset: 0x00034C0C
		public Class125(Bitmap source, bool ownsBitmap)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			this.bool_3 = ownsBitmap;
			this.bitmap_0 = source;
			GraphicsUnit graphicsUnit = GraphicsUnit.Pixel;
			this.rectangle_0 = Rectangle.Truncate(this.bitmap_0.GetBounds(ref graphicsUnit));
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00006A15 File Offset: 0x00004C15
		public Class125(Bitmap source) : this(source, false)
		{
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00036A60 File Offset: 0x00034C60
		public Class125(Size size)
		{
			this.bool_3 = true;
			this.bitmap_0 = new Bitmap(size.Width, size.Height);
			this.rectangle_0 = new Rectangle(Point.Empty, size);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00036AAC File Offset: 0x00034CAC
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public unsafe void method_4()
		{
			if (this.bool_2)
			{
				return;
			}
			this.bool_2 = true;
			this.bitmapData_0 = this.bitmap_0.LockBits(this.rectangle_0, ImageLockMode.ReadWrite, PixelFormat.Format32bppArgb);
			this.pStruct33_0 = (Struct33*)this.bitmapData_0.Scan0.ToPointer();
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00006A1F File Offset: 0x00004C1F
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public void method_5()
		{
			if (!this.bool_2)
			{
				return;
			}
			this.bitmap_0.UnlockBits(this.bitmapData_0);
			this.bitmapData_0 = null;
			this.pStruct33_0 = null;
			this.bool_2 = false;
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00006A51 File Offset: 0x00004C51
		protected override void vmethod_0()
		{
			if (this.bool_2)
			{
				this.method_5();
			}
			if (this.bitmap_0 != null && this.bool_3)
			{
				this.bitmap_0.Dispose();
				this.bitmap_0 = null;
			}
			base.vmethod_0();
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00036B00 File Offset: 0x00034D00
		public static bool smethod_0(PixelFormat format)
		{
			if (format <= PixelFormat.Format32bppRgb)
			{
				if (format == PixelFormat.Format24bppRgb || format == PixelFormat.Format32bppRgb)
				{
					return true;
				}
			}
			else
			{
				if (format == PixelFormat.Format32bppPArgb)
				{
					return true;
				}
				if (format == PixelFormat.Format32bppArgb)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00036B40 File Offset: 0x00034D40
		public unsafe void method_6(Rectangle bounds, out Class125 result)
		{
			if (bounds.Width > 0 && bounds.Height > 0)
			{
				if (this.Width >= bounds.Right && this.Height >= bounds.Bottom)
				{
					result = new Class125(new Size(bounds.Width, bounds.Height));
					using (new Class125.Class153(this))
					{
						using (new Class125.Class153(result))
						{
							Struct33* ptr = result.pStruct33_0;
							for (int i = bounds.Top; i < bounds.Bottom; i++)
							{
								Struct33* ptr2 = this.pStruct33_0 + i * this.rectangle_0.Width + bounds.Left;
								for (int j = 0; j < bounds.Width; j++)
								{
									*ptr = *ptr2;
									ptr++;
									ptr2++;
								}
							}
						}
						return;
					}
				}
				throw new ArgumentOutOfRangeException("bounds", "width or height too large");
			}
			throw new ArgumentOutOfRangeException("bounds", "width or height too small");
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00036C90 File Offset: 0x00034E90
		public unsafe static void smethod_1(Bitmap original)
		{
			using (Class125 @class = new Class125(original))
			{
				using (new Class125.Class153(@class))
				{
					Struct33* ptr = @class.pStruct33_0;
					int num = original.Height * original.Width;
					for (int i = 0; i < num; i++)
					{
						byte b = (byte)((double)ptr->R * 0.3 + (double)ptr->G * 0.59 + (double)ptr->B * 0.11);
						*ptr = new Struct33(b, b, b, ptr->A);
						ptr++;
					}
				}
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00036D5C File Offset: 0x00034F5C
		public unsafe static Class125 smethod_2(Bitmap[] bitmaps)
		{
			if (bitmaps == null)
			{
				throw new ArgumentNullException("bitmaps");
			}
			if (bitmaps.Length != 0 && bitmaps.Length <= 255)
			{
				Size size = bitmaps[0].Size;
				for (int i = 1; i < bitmaps.Length; i++)
				{
					if (bitmaps[i].Size != size)
					{
						IL_28C:
						throw new ArgumentException("To mode bitmaps, all must have same size.");
					}
				}
				Class125 @class = null;
				try
				{
					@class = new Class125(size);
					using (Class125.Class155 class2 = new Class125.Class155(bitmaps))
					{
						using (new Class125.Class154(class2))
						{
							using (new Class125.Class153(@class))
							{
								int num = bitmaps.Length;
								int num2 = Class227.smethod_0(num);
								byte b = 0;
								Struct33* ptr = @class.pStruct33_0;
								Struct33** ptr2;
								Struct33** ptr3;
								int* ptr4;
								int* ptr5;
								Class125.Struct18* ptr6;
								int num3;
								checked
								{
									ptr2 = stackalloc Struct33*[unchecked((UIntPtr)num) * (UIntPtr)sizeof(Struct33*)];
									ptr3 = ptr2;
									ptr4 = stackalloc int[unchecked((UIntPtr)num2) * 4];
									ptr5 = ptr4;
									ptr6 = stackalloc Class125.Struct18[unchecked((UIntPtr)num2) * (UIntPtr)sizeof(Class125.Struct18)];
									num3 = 0;
								}
								int num4 = size.Height * size.Width;
								for (int j = 0; j < num2; j++)
								{
									*ptr5 = -1;
									ptr5++;
								}
								for (int k = 0; k < num; k++)
								{
									*(IntPtr*)ptr3 = class2.class125_0[k].pStruct33_0;
									ptr3 += sizeof(Struct33*) / sizeof(Struct33*);
								}
								byte b2 = 0;
								for (int l = 0; l < num4; l++)
								{
									ptr3 = ptr2;
									Class125.Struct18* ptr7;
									for (int m = 0; m < num; m++)
									{
										int num5 = ((IntPtr*)ptr3)->GetHashCode() & int.MaxValue;
										ptr5 = ptr4 + num5 % num2;
										if (!Class125.smethod_3(ref ptr5, ref ptr6, ref num5, ref b2, *(*(IntPtr*)ptr3)))
										{
											ptr7 = ptr6 + num3;
											ptr7->int_0 = num5;
											ptr7->int_1 = *ptr5;
											ptr7->struct33_0 = *(*(IntPtr*)ptr3);
											ref Class125.Struct18 ptr8 = ref *ptr7;
											byte byte_ = 1;
											b2 = 1;
											ptr8.byte_0 = byte_;
											*ptr5 = num3;
											num3++;
										}
										if (b < b2)
										{
											*ptr = *(*(IntPtr*)ptr3);
											b = b2;
										}
										*(IntPtr*)ptr3 += (IntPtr)sizeof(Struct33);
										ptr3 += sizeof(Struct33*) / sizeof(Struct33*);
									}
									ptr5 = ptr4;
									for (int n = 0; n < num2; n++)
									{
										*ptr5 = -1;
										ptr5++;
									}
									ptr7 = ptr6;
									for (int num6 = 0; num6 < num2; num6++)
									{
										*ptr7 = Class125.Struct18.struct18_0;
										ptr7++;
									}
									num3 = 0;
									b = 0;
									ptr++;
								}
							}
						}
					}
					return @class;
				}
				catch
				{
					if (@class != null)
					{
						@class.Dispose();
					}
					throw;
				}
				goto IL_28C;
			}
			throw new ArgumentException(string.Format("Invalid number of bitmaps: '{0}'.", bitmaps.Length));
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00037080 File Offset: 0x00035280
		private unsafe static bool smethod_3(ref int* buckets_ps, ref Class125.Struct18* entries, ref int hash, ref byte repeat_count, Struct33 color)
		{
			if (*buckets_ps > -1)
			{
				Class125.Struct18* ptr = entries / (IntPtr)sizeof(Class125.Struct18) + *buckets_ps * sizeof(Class125.Struct18);
				while (ptr->int_0 != hash || !Struct33.smethod_3(ptr->struct33_0, color))
				{
					if (ptr->int_1 == -1)
					{
						return false;
					}
					ptr = entries / (IntPtr)sizeof(Class125.Struct18) + ptr->int_1 * sizeof(Class125.Struct18);
				}
				Class125.Struct18* ptr2 = ptr;
				ptr2->byte_0 = ptr2->byte_0 + 1;
				repeat_count = ptr->byte_0;
				return true;
			}
			return false;
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x000370F8 File Offset: 0x000352F8
		public unsafe static int smethod_4(Bitmap bmp)
		{
			int num = 0;
			using (Class125 @class = new Class125(bmp))
			{
				using (new Class125.Class153(@class))
				{
					Struct33* ptr = @class.pBase;
					for (int i = 0; i < bmp.Size.Width * bmp.Size.Height; i++)
					{
						if (ptr->A > 0)
						{
							num++;
						}
						ptr++;
					}
				}
			}
			return num;
		}

		// Token: 0x040004DD RID: 1245
		private Bitmap bitmap_0;

		// Token: 0x040004DE RID: 1246
		private BitmapData bitmapData_0;

		// Token: 0x040004DF RID: 1247
		private unsafe Struct33* pStruct33_0 = null;

		// Token: 0x040004E0 RID: 1248
		private bool bool_2;

		// Token: 0x040004E1 RID: 1249
		private Rectangle rectangle_0;

		// Token: 0x040004E2 RID: 1250
		private bool bool_3;

		// Token: 0x020001FF RID: 511
		private struct Struct18
		{
			// Token: 0x060016B6 RID: 5814 RVA: 0x00006A89 File Offset: 0x00004C89
			public Struct18(int hashCode, int next, Struct33 color, byte count)
			{
				this.int_0 = hashCode;
				this.int_1 = next;
				this.struct33_0 = color;
				this.byte_0 = count;
			}

			// Token: 0x040004E3 RID: 1251
			public static readonly Class125.Struct18 struct18_0 = new Class125.Struct18(0, 0, Struct33.struct33_0, 0);

			// Token: 0x040004E4 RID: 1252
			public int int_0;

			// Token: 0x040004E5 RID: 1253
			public int int_1;

			// Token: 0x040004E6 RID: 1254
			public Struct33 struct33_0;

			// Token: 0x040004E7 RID: 1255
			public byte byte_0;
		}

		// Token: 0x02000200 RID: 512
		internal sealed class Class153 : IDisposable
		{
			// Token: 0x060016B8 RID: 5816 RVA: 0x00037198 File Offset: 0x00035398
			public Class153(Class125 owner)
			{
				this.class125_0 = owner;
				if (this.bool_0 = !this.class125_0.IsLocked)
				{
					this.class125_0.method_4();
				}
			}

			// Token: 0x060016B9 RID: 5817 RVA: 0x00006ABC File Offset: 0x00004CBC
			public void Dispose()
			{
				if (this.bool_0)
				{
					this.class125_0.method_5();
				}
			}

			// Token: 0x040004E8 RID: 1256
			private Class125 class125_0;

			// Token: 0x040004E9 RID: 1257
			private bool bool_0;
		}

		// Token: 0x02000201 RID: 513
		private sealed class Class154 : IDisposable
		{
			// Token: 0x060016BA RID: 5818 RVA: 0x000371D8 File Offset: 0x000353D8
			public Class154(Class125[] owners)
			{
				this.class125_0 = owners;
				this.bool_0 = new bool[this.class125_0.Length];
				for (int i = 0; i < this.class125_0.Length; i++)
				{
					if (this.bool_0[i] = !this.class125_0[i].IsLocked)
					{
						this.class125_0[i].method_4();
					}
				}
			}

			// Token: 0x060016BB RID: 5819 RVA: 0x00006AD1 File Offset: 0x00004CD1
			public Class154(Class125.Class155 utilities) : this(utilities.class125_0)
			{
			}

			// Token: 0x060016BC RID: 5820 RVA: 0x00037244 File Offset: 0x00035444
			public void Dispose()
			{
				for (int i = 0; i < this.class125_0.Length; i++)
				{
					if (this.bool_0[i])
					{
						this.class125_0[i].method_5();
					}
				}
			}

			// Token: 0x040004EA RID: 1258
			private Class125[] class125_0;

			// Token: 0x040004EB RID: 1259
			private bool[] bool_0;
		}

		// Token: 0x02000202 RID: 514
		private sealed class Class155 : IDisposable
		{
			// Token: 0x060016BD RID: 5821 RVA: 0x0003727C File Offset: 0x0003547C
			public Class155(Bitmap[] bitmaps)
			{
				this.class125_0 = new Class125[bitmaps.Length];
				for (int i = 0; i < bitmaps.Length; i++)
				{
					this.class125_0[i] = new Class125(bitmaps[i]);
				}
			}

			// Token: 0x060016BE RID: 5822 RVA: 0x00006ADF File Offset: 0x00004CDF
			public void Dispose()
			{
				this.class125_0.smethod_1<Class125>();
			}

			// Token: 0x040004EC RID: 1260
			public readonly Class125[] class125_0;
		}
	}
}
