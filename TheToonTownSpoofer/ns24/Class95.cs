using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns18;
using ns20;
using ns22;
using ns29;
using ns30;

namespace ns24
{
	// Token: 0x0200030A RID: 778
	internal sealed class Class95<ColorType> : Class86 where ColorType : Interface17
	{
		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06001E7B RID: 7803 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x06001E7C RID: 7804 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x06001E7D RID: 7805 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001E7E RID: 7806 RVA: 0x0000BC02 File Offset: 0x00009E02
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					74,
					66,
					83
				};
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001E7F RID: 7807 RVA: 0x0000BC15 File Offset: 0x00009E15
		public Size OriginalSize
		{
			get
			{
				return this.size_0;
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001E80 RID: 7808 RVA: 0x0000BC1D File Offset: 0x00009E1D
		public Rectangle Bounds
		{
			get
			{
				return this.rectangle_0;
			}
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x00062B20 File Offset: 0x00060D20
		public Class95(Class125 alpha_bitmap, Class125 color_bitmap)
		{
			this.size_0 = alpha_bitmap.Size;
			using (new Class125.Class153(alpha_bitmap))
			{
				using (new Class125.Class153(color_bitmap))
				{
					this.method_6(alpha_bitmap, color_bitmap);
				}
			}
			this.method_4();
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0000BC25 File Offset: 0x00009E25
		public Class95(Stream stream) : base(stream)
		{
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0000BC5D File Offset: 0x00009E5D
		public Class95(string fileName) : base(fileName)
		{
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x00062BC0 File Offset: 0x00060DC0
		private void method_4()
		{
			Class95<ColorType>.Class296 @class = new Class95<ColorType>.Class296();
			@class.class95_0 = this;
			this.int_1 = new int[this.rectangle_0.Height][];
			int maxStackSize = 1048576 + this.rectangle_0.Height * this.rectangle_0.Width;
			@class.exception_0 = null;
			Thread thread = new Thread(new ThreadStart(@class.method_0), maxStackSize);
			thread.IsBackground = true;
			thread.Start();
			thread.Join();
			if (@class.exception_0 != null)
			{
				throw @class.exception_0;
			}
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x00062C4C File Offset: 0x00060E4C
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.int_0 = 0;
			this.size_0 = reader.smethod_14();
			if (reader.ReadBoolean())
			{
				short left = reader.ReadInt16();
				short num = reader.ReadInt16();
				short right = reader.ReadInt16();
				short num2 = reader.ReadInt16();
				short num3 = num2 - num;
				this.rectangle_0 = Rectangle.FromLTRB((int)left, (int)num, (int)right, (int)num2);
				this.array_0 = Array.CreateInstance(typeof(Array[]), new int[]
				{
					(int)num3
				}, new int[]
				{
					(int)num
				});
				for (short num4 = num; num4 < num2; num4 += 1)
				{
					short num5 = reader.ReadInt16();
					List<Array> list = new List<Array>();
					for (short num6 = 0; num6 < num5; num6 += 1)
					{
						short num7 = reader.ReadInt16();
						short num8 = reader.ReadInt16();
						short num9 = num7 + num8 - 1;
						Array array = Array.CreateInstance(this.type_0, new int[]
						{
							(int)num8
						}, new int[]
						{
							(int)num7
						});
						if (this.bool_0)
						{
							for (short num10 = num7; num10 <= num9; num10 += 1)
							{
								array.SetValue(reader.smethod_18(), (int)num10);
							}
						}
						else
						{
							for (short num11 = num7; num11 <= num9; num11 += 1)
							{
								array.SetValue(reader.smethod_16(), (int)num11);
							}
						}
						this.int_0 += array.Length;
						list.Add(array);
					}
					this.array_0.SetValue(list.ToArray(), (int)num4);
				}
				this.method_4();
			}
			else
			{
				this.array_0 = null;
			}
			base.vmethod_2(reader, version);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x00062E04 File Offset: 0x00061004
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.smethod_15(this.size_0);
			if (this.array_0 == null)
			{
				writer.Write(false);
			}
			else
			{
				writer.Write(true);
				writer.Write((short)this.rectangle_0.Left);
				writer.Write((short)this.rectangle_0.Top);
				writer.Write((short)this.rectangle_0.Right);
				writer.Write((short)this.rectangle_0.Bottom);
				foreach (Array[] array in this.array_0)
				{
					writer.Write((short)array.Length);
					Array[] array2 = array;
					int i = 0;
					while (i < array2.Length)
					{
						Array array3 = array2[i];
						writer.Write((short)array3.GetLowerBound(0));
						writer.Write((short)array3.Length);
						if (this.bool_0)
						{
							using (IEnumerator enumerator2 = array3.GetEnumerator())
							{
								while (enumerator2.MoveNext())
								{
									object obj = enumerator2.Current;
									Struct33 color = (Struct33)obj;
									writer.smethod_19(color);
								}
								goto IL_155;
							}
							goto IL_116;
						}
						goto IL_116;
						IL_155:
						i++;
						continue;
						IL_116:
						foreach (object obj2 in array3)
						{
							Struct54 color2 = (Struct54)obj2;
							writer.smethod_17(color2);
						}
						goto IL_155;
					}
				}
			}
			base.vmethod_0(writer);
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x00062FB8 File Offset: 0x000611B8
		public unsafe Bitmap method_5(Color? replaceColor = null)
		{
			Bitmap bitmap = null;
			Bitmap result;
			try
			{
				bitmap = new Bitmap(this.size_0.Width, this.size_0.Height);
				if (this.array_0 != null)
				{
					using (Class125 @class = new Class125(bitmap))
					{
						using (new Class125.Class153(@class))
						{
							for (int i = this.rectangle_0.Top; i < this.rectangle_0.Bottom; i++)
							{
								Array[] array = (Array[])this.array_0.GetValue(i);
								short num = 0;
								while ((int)num < array.Length)
								{
									Array array2 = (Array)array.GetValue((int)num);
									int lowerBound = array2.GetLowerBound(0);
									int num2 = lowerBound + array2.Length - 1;
									Struct33* ptr = @class.pBase + i * this.size_0.Width + lowerBound + this.rectangle_0.Left;
									if (replaceColor != null)
									{
										Struct33 @struct = Struct33.smethod_1(replaceColor.Value);
										for (int j = lowerBound; j <= num2; j++)
										{
											*ptr = @struct;
											ptr++;
										}
									}
									else if (this.bool_0)
									{
										for (int k = lowerBound; k <= num2; k++)
										{
											*ptr = (Struct33)array2.GetValue(k);
											ptr++;
										}
									}
									else
									{
										for (int l = lowerBound; l <= num2; l++)
										{
											*ptr = Struct33.smethod_2((Struct54)array2.GetValue(l));
											ptr++;
										}
									}
									num += 1;
								}
							}
						}
					}
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
			return result;
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x000631E0 File Offset: 0x000613E0
		private void method_6(Class125 alpha_bitmap, Class125 color_bitmap = null)
		{
			Struct33[,] colors = alpha_bitmap.Colors;
			Struct33[,] color_data = (color_bitmap == null) ? colors : color_bitmap.Colors;
			this.int_0 = 0;
			short left;
			short num;
			short num2;
			short num3;
			if (Class95<ColorType>.smethod_2(colors, this.size_0, FlowDirection.LeftToRight, out left) && Class95<ColorType>.smethod_2(colors, this.size_0, FlowDirection.TopDown, out num) && Class95<ColorType>.smethod_2(colors, this.size_0, FlowDirection.RightToLeft, out num2) && Class95<ColorType>.smethod_2(colors, this.size_0, FlowDirection.BottomUp, out num3))
			{
				this.rectangle_0 = Rectangle.FromLTRB((int)left, (int)num, (int)(num2 + 1), (int)(num3 + 1));
				this.array_0 = Array.CreateInstance(typeof(Array[]), new int[]
				{
					this.rectangle_0.Height
				}, new int[]
				{
					this.rectangle_0.Top
				});
				short num4 = num;
				while ((int)num4 < this.rectangle_0.Bottom)
				{
					this.array_0.SetValue(this.method_7(colors, color_data, left, num2, num4), (int)num4);
					num4 += 1;
				}
				return;
			}
			this.array_0 = null;
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x000632F4 File Offset: 0x000614F4
		private Array[] method_7(Struct33[,] pixels, Struct33[,] color_data, short left, short right, short y)
		{
			List<Array> list = new List<Array>();
			short num = left;
			while (num <= right && Class95<ColorType>.smethod_0(pixels, ref num, right, (int)y))
			{
				int i = (int)num;
				num += 1;
				Class95<ColorType>.smethod_1(pixels, ref num, right, y);
				int num2 = (int)num;
				num += 1;
				if (i > num2)
				{
					break;
				}
				int num3 = num2 - i + 1;
				int num4 = i - (int)left;
				Array array = Array.CreateInstance(this.type_0, new int[]
				{
					num3
				}, new int[]
				{
					num4
				});
				if (this.bool_0)
				{
					while (i <= num2)
					{
						array.SetValue(color_data[i, (int)y], num4);
						i++;
						num4++;
					}
				}
				else
				{
					while (i <= num2)
					{
						array.SetValue(Struct54.smethod_2(color_data[i, (int)y]), num4);
						i++;
						num4++;
					}
				}
				this.int_0 += array.Length;
				list.Add(array);
			}
			return list.ToArray();
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0000BC95 File Offset: 0x00009E95
		private static bool smethod_0(Struct33[,] pixels, ref short left, short right, int y)
		{
			while (left <= right)
			{
				if (pixels[(int)left, y].A != 0)
				{
					return true;
				}
				left += 1;
			}
			return false;
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0000BCB9 File Offset: 0x00009EB9
		private static void smethod_1(Struct33[,] pixels, ref short left, short right, short y)
		{
			while (left <= right && pixels[(int)left, (int)y].A != 0)
			{
				left += 1;
			}
			left -= 1;
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x00063408 File Offset: 0x00061608
		private static bool smethod_2(Struct33[,] pixels, Size sz, FlowDirection direction, out short result)
		{
			switch (direction)
			{
			case FlowDirection.LeftToRight:
			{
				short num = 0;
				while ((int)num < sz.Width)
				{
					short num2 = 0;
					while ((int)num2 < sz.Height)
					{
						if (pixels[(int)num, (int)num2].A > 0)
						{
							result = num;
							return true;
						}
						num2 += 1;
					}
					num += 1;
				}
				break;
			}
			case FlowDirection.TopDown:
			{
				short num3 = 0;
				while ((int)num3 < sz.Height)
				{
					short num4 = 0;
					while ((int)num4 < sz.Width)
					{
						if (pixels[(int)num4, (int)num3].A > 0)
						{
							result = num3;
							return true;
						}
						num4 += 1;
					}
					num3 += 1;
				}
				break;
			}
			case FlowDirection.RightToLeft:
				for (short num5 = (short)(sz.Width - 1); num5 >= 0; num5 -= 1)
				{
					short num6 = 0;
					while ((int)num6 < sz.Height)
					{
						if (pixels[(int)num5, (int)num6].A > 0)
						{
							result = num5;
							return true;
						}
						num6 += 1;
					}
				}
				break;
			case FlowDirection.BottomUp:
				for (short num7 = (short)(sz.Height - 1); num7 >= 0; num7 -= 1)
				{
					short num8 = 0;
					while ((int)num8 < sz.Width)
					{
						if (pixels[(int)num8, (int)num7].A > 0)
						{
							result = num7;
							return true;
						}
						num8 += 1;
					}
				}
				break;
			}
			result = 0;
			return false;
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0006354C File Offset: 0x0006174C
		public Rectangle[] method_8(Bitmap bmp, Size minimum_size, Size maximum_size, CancellationToken token)
		{
			Class95<ColorType>.Class297 @class = new Class95<ColorType>.Class297();
			@class.bitmap_0 = bmp;
			@class.size_0 = minimum_size;
			@class.size_1 = maximum_size;
			@class.cancellationToken_0 = token;
			@class.class95_0 = this;
			@class.cancellationToken_0.ThrowIfCancellationRequested();
			@class.list_0 = new List<Rectangle>();
			int maxStackSize = 1048576 + this.rectangle_0.Height * this.rectangle_0.Width * 2;
			@class.exception_0 = null;
			Thread thread = new Thread(new ThreadStart(@class.method_0), maxStackSize);
			thread.IsBackground = true;
			thread.Start();
			thread.Join();
			if (@class.exception_0 != null)
			{
				throw @class.exception_0;
			}
			@class.cancellationToken_0.ThrowIfCancellationRequested();
			return @class.list_0.ToArray();
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x0006360C File Offset: 0x0006180C
		private unsafe Struct24 method_9(bool* start_pixel, int x_start, int y_start)
		{
			Struct24 result = new Struct24(x_start, y_start, x_start, y_start);
			Class95<ColorType>.Enum60 @enum = Class95<ColorType>.Enum60.const_0;
			Class95<ColorType>.Enum60 enum2 = Class95<ColorType>.Enum60.const_0;
			int num = x_start;
			int num2 = y_start;
			bool* ptr = start_pixel;
			Struct24* ptr2 = &result;
			for (;;)
			{
				IL_279:
				if (num2 > 0 && *(ptr - this.rectangle_0.Width))
				{
					num2--;
					ptr -= this.rectangle_0.Width;
					enum2 = Class95<ColorType>.Enum60.const_3;
					if (ptr2->int_1 > num2)
					{
						ptr2->int_1 = num2;
					}
				}
				else if (num + 1 < this.rectangle_0.Width && ptr[1])
				{
					num++;
					ptr++;
					if (ptr2->int_2 < num)
					{
						ptr2->int_2 = num;
					}
				}
				else
				{
					enum2 = Class95<ColorType>.Enum60.const_2;
				}
				while (@enum != enum2 || start_pixel != ptr)
				{
					switch (enum2)
					{
					case Class95<ColorType>.Enum60.const_0:
						goto IL_279;
					case Class95<ColorType>.Enum60.const_1:
						if (num2 + 1 < this.rectangle_0.Height && ptr[this.rectangle_0.Width])
						{
							num2++;
							ptr += this.rectangle_0.Width;
							enum2 = Class95<ColorType>.Enum60.const_2;
							if (ptr2->int_3 < num2)
							{
								ptr2->int_3 = num2;
							}
						}
						else if (num > 0 && *(ptr - 1))
						{
							num--;
							ptr--;
							if (ptr2->int_0 > num)
							{
								ptr2->int_0 = num;
							}
						}
						else
						{
							enum2 = Class95<ColorType>.Enum60.const_3;
						}
						break;
					case Class95<ColorType>.Enum60.const_2:
						if (num + 1 < this.rectangle_0.Width && ptr[1])
						{
							num++;
							ptr++;
							enum2 = Class95<ColorType>.Enum60.const_0;
							if (ptr2->int_2 < num)
							{
								ptr2->int_2 = num;
							}
						}
						else if (num2 + 1 < this.rectangle_0.Height && ptr[this.rectangle_0.Width])
						{
							num2++;
							ptr += this.rectangle_0.Width;
							if (ptr2->int_3 < num2)
							{
								ptr2->int_3 = num2;
							}
						}
						else
						{
							enum2 = Class95<ColorType>.Enum60.const_1;
						}
						break;
					case Class95<ColorType>.Enum60.const_3:
						if (num > 0 && *(ptr - 1))
						{
							num--;
							ptr--;
							enum2 = Class95<ColorType>.Enum60.const_1;
							if (ptr2->int_0 > num)
							{
								ptr2->int_0 = num;
							}
						}
						else if (num2 > 0 && *(ptr - this.rectangle_0.Width))
						{
							num2--;
							ptr -= this.rectangle_0.Width;
							if (ptr2->int_1 > num2)
							{
								ptr2->int_1 = num2;
							}
						}
						else
						{
							enum2 = Class95<ColorType>.Enum60.const_0;
						}
						break;
					}
				}
				break;
			}
			return result;
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x000638A0 File Offset: 0x00061AA0
		public unsafe bool method_10(Bitmap bmp, float minimum_percent)
		{
			int num = this.int_0 - (int)Math.Ceiling((double)(minimum_percent * (float)this.int_0));
			Size size = bmp.Size;
			bool result;
			using (Class125 @class = new Class125(bmp))
			{
				using (new Class125.Class153(@class))
				{
					int num2 = 0;
					Array[][] array = new Array[this.array_0.Length][];
					this.array_0.CopyTo(array, 0);
					int i = 0;
					int num3 = this.rectangle_0.Y;
					while (i < this.rectangle_0.Height)
					{
						Array[] array2 = array[i];
						Array[] array3 = array2;
						int j = 0;
						while (j < array3.Length)
						{
							Array array4 = array3[j];
							int k = array4.GetLowerBound(0) + this.rectangle_0.Left;
							int length = array4.GetLength(0);
							int num4 = k + length;
							Struct33* ptr = @class.pBase + k + num3 * size.Width;
							if (this.bool_0)
							{
								Struct33[] array5 = new Struct33[length];
								array4.CopyTo(array5, 0);
								try
								{
									Struct33[] array6;
									Struct33* ptr2;
									if ((array6 = array5) != null && array6.Length != 0)
									{
										fixed (Struct33* ptr2 = &array6[0])
										{
										}
									}
									else
									{
										ptr2 = null;
									}
									Struct33* ptr3 = ptr2;
									while (k < num4)
									{
										if (ptr->R != ptr3->R || ptr->G != ptr3->G || ptr->B != ptr3->B || ptr->A != ptr3->A)
										{
											num2++;
										}
										ptr3++;
										ptr++;
										k++;
									}
									goto IL_23F;
								}
								finally
								{
									Struct33* ptr2 = null;
								}
								goto IL_193;
							}
							goto IL_193;
							IL_23F:
							j++;
							continue;
							IL_193:
							Struct54[] array7 = new Struct54[length];
							array4.CopyTo(array7, 0);
							try
							{
								Struct54[] array8;
								Struct54* ptr4;
								if ((array8 = array7) != null && array8.Length != 0)
								{
									fixed (Struct54* ptr4 = &array8[0])
									{
									}
								}
								else
								{
									ptr4 = null;
								}
								Struct54* ptr5 = ptr4;
								while (k < num4)
								{
									if (ptr->R != ptr5->R || ptr->G != ptr5->G || ptr->B != ptr5->B)
									{
										num2++;
									}
									ptr5++;
									ptr++;
									k++;
								}
								goto IL_23F;
							}
							finally
							{
								Struct54* ptr4 = null;
							}
							break;
						}
						if (num2 > num)
						{
							break;
						}
						i++;
						num3++;
					}
					result = (num2 <= num);
				}
			}
			return result;
		}

		// Token: 0x04000B99 RID: 2969
		private static readonly string string_0 = "Valid Target Bounds Found";

		// Token: 0x04000B9A RID: 2970
		private static readonly string string_1 = "Target Candidate Found";

		// Token: 0x04000B9B RID: 2971
		private readonly Type type_0 = typeof(ColorType);

		// Token: 0x04000B9C RID: 2972
		private readonly bool bool_0 = typeof(ColorType) == typeof(Struct33);

		// Token: 0x04000B9D RID: 2973
		private Size size_0;

		// Token: 0x04000B9E RID: 2974
		private Array array_0;

		// Token: 0x04000B9F RID: 2975
		private Rectangle rectangle_0;

		// Token: 0x04000BA0 RID: 2976
		private int int_0;

		// Token: 0x04000BA1 RID: 2977
		private int[][] int_1;

		// Token: 0x0200030B RID: 779
		private enum Enum60
		{
			// Token: 0x04000BA3 RID: 2979
			const_0,
			// Token: 0x04000BA4 RID: 2980
			const_1,
			// Token: 0x04000BA5 RID: 2981
			const_2,
			// Token: 0x04000BA6 RID: 2982
			const_3
		}

		// Token: 0x0200030C RID: 780
		[CompilerGenerated]
		private sealed class Class296
		{
			// Token: 0x06001E92 RID: 7826 RVA: 0x00063B80 File Offset: 0x00061D80
			public unsafe void method_0()
			{
				try
				{
					bool* ptr = stackalloc bool[(UIntPtr)(this.class95_0.rectangle_0.Height * this.class95_0.rectangle_0.Width)];
					Array[][] array = new Array[this.class95_0.array_0.Length][];
					this.class95_0.array_0.CopyTo(array, 0);
					for (int i = 0; i < this.class95_0.rectangle_0.Height; i++)
					{
						Array[] array2 = array[i];
						foreach (Array array4 in array2)
						{
							int k = array4.GetLowerBound(0);
							int length = array4.GetLength(0);
							int num = k + length - 1;
							bool* ptr2 = ptr + k + (IntPtr)this.class95_0.rectangle_0.Width * (IntPtr)i;
							while (k <= num)
							{
								*ptr2 = true;
								ptr2++;
								k++;
							}
						}
					}
					List<int> list = new List<int>();
					for (int l = 0; l < this.class95_0.rectangle_0.Height; l++)
					{
						list.Clear();
						int num2 = this.class95_0.rectangle_0.Width * l;
						bool* ptr3 = ptr + num2;
						for (int m = 0; m < this.class95_0.rectangle_0.Width; m++)
						{
							if (*ptr3 && (l == 0 || l == this.class95_0.rectangle_0.Height - 1 || m == 0 || m == this.class95_0.rectangle_0.Width - 1 || !ptr[m - 1 + num2] || !ptr[m + 1 + num2] || !ptr[m + num2 - this.class95_0.rectangle_0.Width] || !ptr[m + num2 + this.class95_0.rectangle_0.Width]))
							{
								list.Add(m);
							}
							ptr3++;
						}
						this.class95_0.int_1[l] = list.ToArray();
					}
				}
				catch (Exception ex)
				{
					this.exception_0 = ex;
				}
			}

			// Token: 0x04000BA7 RID: 2983
			public Exception exception_0;

			// Token: 0x04000BA8 RID: 2984
			public Class95<ColorType> class95_0;
		}

		// Token: 0x0200030D RID: 781
		[CompilerGenerated]
		private sealed class Class297
		{
			// Token: 0x06001E94 RID: 7828 RVA: 0x00063DB8 File Offset: 0x00061FB8
			public unsafe void method_0()
			{
				try
				{
					Struct24 @struct = new Struct24(int.MaxValue, int.MaxValue, int.MinValue, int.MinValue);
					Struct24 struct2 = new Struct24(int.MaxValue, int.MaxValue, int.MinValue, int.MinValue);
					bool* ptr = stackalloc bool[(UIntPtr)(this.class95_0.rectangle_0.Height * this.class95_0.rectangle_0.Width)];
					bool* ptr2 = stackalloc bool[(UIntPtr)(this.class95_0.rectangle_0.Height * this.class95_0.rectangle_0.Width)];
					Struct24* ptr3 = &@struct;
					Struct24* ptr4 = &struct2;
					using (Class125 @class = new Class125(this.bitmap_0))
					{
						using (new Class125.Class153(@class))
						{
							Array[][] array = new Array[this.class95_0.array_0.Length][];
							this.class95_0.array_0.CopyTo(array, 0);
							for (int i = 0; i < this.class95_0.rectangle_0.Height; i++)
							{
								Array[] array2 = array[i];
								Array[] array3 = array2;
								int j = 0;
								while (j < array3.Length)
								{
									Array array4 = array3[j];
									int k = array4.GetLowerBound(0);
									int length = array4.GetLength(0);
									int num = k + length - 1;
									bool flag = false;
									if (this.class95_0.bool_0)
									{
										Struct33[] array5 = new Struct33[length];
										array4.CopyTo(array5, 0);
										try
										{
											Struct33[] array6;
											Struct33* ptr5;
											if ((array6 = array5) != null && array6.Length != 0)
											{
												fixed (Struct33* ptr5 = &array6[0])
												{
												}
											}
											else
											{
												ptr5 = null;
											}
											Struct33* ptr6 = ptr5;
											Struct33* ptr7 = @class.pBase + @class.Width * i + k;
											bool* ptr8 = ptr + k + (IntPtr)this.class95_0.rectangle_0.Width * (IntPtr)i;
											while (k <= num)
											{
												if (ptr7->A != ptr6->A || ptr7->R != ptr6->R || ptr7->G != ptr6->G || ptr7->B != ptr6->B)
												{
													*ptr8 = true;
													flag = true;
													if (ptr3->int_0 > k)
													{
														ptr3->int_0 = k;
													}
													if (ptr3->int_2 < k)
													{
														ptr3->int_2 = k;
													}
												}
												ptr7++;
												ptr6++;
												ptr8++;
												k++;
											}
											goto IL_3B8;
										}
										finally
										{
											Struct33* ptr5 = null;
										}
										goto IL_25F;
									}
									goto IL_25F;
									IL_395:
									j++;
									continue;
									IL_36D:
									if (ptr3->int_1 > i)
									{
										ptr3->int_1 = i;
									}
									if (ptr3->int_3 < i)
									{
										ptr3->int_3 = i;
										goto IL_395;
									}
									goto IL_395;
									IL_25F:
									Struct54[] array7 = new Struct54[length];
									array4.CopyTo(array7, 0);
									try
									{
										Struct54[] array8;
										Struct54* ptr9;
										if ((array8 = array7) != null && array8.Length != 0)
										{
											fixed (Struct54* ptr9 = &array8[0])
											{
											}
										}
										else
										{
											ptr9 = null;
										}
										Struct54* ptr10 = ptr9;
										Struct33* ptr11 = @class.pBase + @class.Width * i + k;
										bool* ptr12 = ptr + k + (IntPtr)this.class95_0.rectangle_0.Width * (IntPtr)i;
										while (k <= num)
										{
											if (ptr11->R != ptr10->R || ptr11->G != ptr10->G || ptr11->B != ptr10->B)
											{
												*ptr12 = true;
												flag = true;
												if (ptr3->int_0 > k)
												{
													ptr3->int_0 = k;
												}
												if (ptr3->int_2 < k)
												{
													ptr3->int_2 = k;
												}
											}
											ptr11++;
											ptr10++;
											ptr12++;
											k++;
										}
										goto IL_3B8;
									}
									finally
									{
										Struct54* ptr9 = null;
									}
									goto IL_36D;
									IL_3B8:
									if (flag)
									{
										goto IL_36D;
									}
									goto IL_395;
								}
								if (this.cancellationToken_0.IsCancellationRequested)
								{
									return;
								}
							}
						}
					}
					for (int l = ptr3->int_1; l < ptr3->int_3; l++)
					{
						bool flag2 = false;
						bool* ptr13 = ptr + ptr3->int_0 + (IntPtr)l * (IntPtr)this.class95_0.rectangle_0.Width;
						bool* ptr14 = ptr2 + ptr3->int_0 + (IntPtr)l * (IntPtr)this.class95_0.rectangle_0.Width;
						for (int m = ptr3->int_0; m < ptr3->int_2; m++)
						{
							if (*ptr13 && (m + 1 == this.class95_0.rectangle_0.Width || ptr13[1]) && (m == 0 || *(ptr13 - 1)) && (l + 1 == this.class95_0.rectangle_0.Height || ptr13[this.class95_0.rectangle_0.Width]) && (l == 0 || *(ptr13 - this.class95_0.rectangle_0.Width)))
							{
								*ptr14 = true;
								flag2 = true;
								if (ptr4->int_0 > m)
								{
									ptr4->int_0 = m;
								}
								if (ptr4->int_2 < m)
								{
									ptr4->int_2 = m;
								}
							}
							ptr13++;
							ptr14++;
						}
						if (flag2)
						{
							if (ptr4->int_1 > l)
							{
								ptr4->int_1 = l;
							}
							if (ptr4->int_3 < l)
							{
								ptr4->int_3 = l;
							}
						}
						if (this.cancellationToken_0.IsCancellationRequested)
						{
							return;
						}
					}
					for (int n = ptr4->int_1; n < ptr4->int_3; n++)
					{
						bool* ptr15 = ptr2 + ptr4->int_0 + (IntPtr)n * (IntPtr)this.class95_0.rectangle_0.Width;
						for (int num2 = ptr4->int_0; num2 < ptr4->int_2; num2++)
						{
							if (*ptr15)
							{
								Struct24 struct3 = this.class95_0.method_9(ptr15, num2, n);
								struct3.int_2++;
								struct3.int_3++;
								Rectangle rectangle = struct3.method_0();
								Size size = rectangle.Size;
								Class335.smethod_3(Class95<ColorType>.string_1, new object[]
								{
									rectangle
								});
								if (size.Width > this.size_0.Width && size.Height > this.size_0.Height && size.Width < this.size_1.Width && size.Height < this.size_1.Height)
								{
									bool flag3 = true;
									for (int num3 = rectangle.Y; num3 < rectangle.Bottom; num3++)
									{
										int[] array9 = this.class95_0.int_1[num3];
										if (array9.Length > 0)
										{
											foreach (int num5 in array9)
											{
												if (num5 >= rectangle.Left && num5 <= rectangle.Right)
												{
													flag3 = false;
													break;
												}
											}
										}
										else
										{
											flag3 = false;
										}
										if (!flag3)
										{
											break;
										}
										if (this.cancellationToken_0.IsCancellationRequested)
										{
											return;
										}
									}
									if (flag3)
									{
										Rectangle rectangle2 = rectangle.smethod_4(this.class95_0.rectangle_0.X, this.class95_0.rectangle_0.Y);
										Class335.smethod_3(Class95<ColorType>.string_0, new object[]
										{
											rectangle2
										});
										this.list_0.Add(rectangle2);
									}
								}
								for (int num6 = struct3.int_1; num6 < struct3.int_3; num6++)
								{
									bool* ptr16 = ptr2 + struct3.int_0 + (IntPtr)num6 * (IntPtr)this.class95_0.rectangle_0.Width;
									for (int num7 = struct3.int_0; num7 < struct3.int_2; num7++)
									{
										*ptr16 = false;
										ptr16++;
									}
								}
							}
							ptr15++;
						}
						if (this.cancellationToken_0.IsCancellationRequested)
						{
							break;
						}
					}
				}
				catch (Exception ex)
				{
					this.exception_0 = ex;
				}
			}

			// Token: 0x04000BA9 RID: 2985
			public List<Rectangle> list_0;

			// Token: 0x04000BAA RID: 2986
			public Exception exception_0;

			// Token: 0x04000BAB RID: 2987
			public Class95<ColorType> class95_0;

			// Token: 0x04000BAC RID: 2988
			public Bitmap bitmap_0;

			// Token: 0x04000BAD RID: 2989
			public Size size_0;

			// Token: 0x04000BAE RID: 2990
			public Size size_1;

			// Token: 0x04000BAF RID: 2991
			public CancellationToken cancellationToken_0;
		}
	}
}
