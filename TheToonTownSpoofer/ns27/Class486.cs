using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using ns22;
using ns30;

namespace ns27
{
	// Token: 0x0200048D RID: 1165
	internal static class Class486
	{
		// Token: 0x06002B58 RID: 11096 RVA: 0x000A8164 File Offset: 0x000A6364
		public static void smethod_0(Stream data_stream, Stream destination_stream, Bitmap destination_bitmap, Color? backGroundColor, bool convert_to_grayscale, Enum14 format)
		{
			using (Bitmap bitmap = (Bitmap)Image.FromStream(data_stream))
			{
				if (destination_bitmap != null && backGroundColor != null)
				{
					if (destination_bitmap.Width == bitmap.Width)
					{
						if (destination_bitmap.Height == bitmap.Height)
						{
							using (Graphics graphics = Graphics.FromImage(destination_bitmap))
							{
								using (SolidBrush solidBrush = new SolidBrush(backGroundColor.Value))
								{
									graphics.SmoothingMode = SmoothingMode.HighQuality;
									graphics.InterpolationMode = InterpolationMode.High;
									graphics.CompositingQuality = CompositingQuality.HighQuality;
									graphics.FillRectangle(solidBrush, 0, 0, destination_bitmap.Width, destination_bitmap.Height);
									graphics.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);
								}
								goto IL_B2;
							}
						}
					}
					throw new ArgumentException("Destination dimensions do not match source image dimensions.");
				}
				IL_B2:
				if (convert_to_grayscale)
				{
					Class125.smethod_1(bitmap);
				}
				using (Stream3 stream = new Stream3(destination_stream))
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(stream))
					{
						stream.smethod_37(Class486.short_0);
						stream.WriteByte(1);
						stream.WriteByte(1);
						short num;
						short value;
						switch (format)
						{
						case Enum14.const_0:
							num = 4;
							value = 3;
							break;
						case Enum14.const_1:
							num = 3;
							value = 3;
							break;
						case Enum14.const_2:
							num = 2;
							value = 3;
							break;
						case Enum14.const_3:
							num = 1;
							value = 2;
							break;
						default:
							throw new NotSupportedException(string.Format("The specified format: '{0}' is not supported.", format));
						}
						stream.smethod_37(value);
						stream.smethod_37((short)bitmap.Width);
						stream.smethod_37((short)bitmap.Height);
						stream.smethod_37(num);
						stream.smethod_35(0);
						stream.smethod_35(255);
						binaryWriter.Write(new byte[4]);
						binaryWriter.Write(new byte[80]);
						stream.smethod_35(0);
						binaryWriter.Write(new byte[404]);
						for (int i = 0; i < (int)num; i++)
						{
							for (int j = 0; j < bitmap.Height; j++)
							{
								stream.smethod_35(0);
							}
							for (int k = 0; k < bitmap.Height; k++)
							{
								stream.smethod_35(0);
							}
						}
						Class486.Class487[] array = new Class486.Class487[bitmap.Height];
						if (destination_bitmap == null)
						{
							array = new Class486.Class487[bitmap.Height * (int)num];
							Struct33[,] array2 = new Struct33[bitmap.Width, bitmap.Height];
							Class486.smethod_4(bitmap, array2);
							switch (format)
							{
							case Enum14.const_0:
							case Enum14.const_1:
								for (int l = (int)(num - 1); l >= 0; l--)
								{
									int num2 = ((int)(num - 1) - l) * bitmap.Height;
									for (int m = 0; m < bitmap.Height; m++)
									{
										Class486.Class487 @class = array[num2 + m] = new Class486.Class487();
										@class.byte_0 = new byte[bitmap.Width];
										for (int n = 0; n < bitmap.Width; n++)
										{
											switch (l)
											{
											case 0:
												@class.byte_0[n] = array2[n, m].R;
												break;
											case 1:
												@class.byte_0[n] = array2[n, m].G;
												break;
											case 2:
												@class.byte_0[n] = array2[n, m].B;
												break;
											case 3:
												@class.byte_0[n] = array2[n, m].A;
												break;
											}
										}
									}
								}
								break;
							case Enum14.const_2:
								for (int num3 = (int)(num - 1); num3 >= 0; num3--)
								{
									int num4 = ((int)(num - 1) - num3) * bitmap.Height;
									for (int num5 = 0; num5 < bitmap.Height; num5++)
									{
										Class486.Class487 class2 = array[num4 + num5] = new Class486.Class487();
										class2.byte_0 = new byte[bitmap.Width];
										for (int num6 = 0; num6 < bitmap.Width; num6++)
										{
											switch (num3)
											{
											case 0:
												class2.byte_0[num6] = array2[num6, num5].R;
												break;
											case 1:
												class2.byte_0[num6] = array2[num6, num5].A;
												break;
											}
										}
									}
								}
								break;
							case Enum14.const_3:
								for (int num7 = 0; num7 < bitmap.Height; num7++)
								{
									array[num7] = new Class486.Class487();
									array[num7].byte_0 = new byte[bitmap.Width];
									for (int num8 = 0; num8 < bitmap.Width; num8++)
									{
										array[num7].byte_0[num8] = array2[num8, num7].R;
									}
								}
								break;
							default:
								throw new NotSupportedException("Format not supported: " + format);
							}
						}
						else
						{
							array = new Class486.Class487[bitmap.Height];
							Color[,] array3 = new Color[bitmap.Width, bitmap.Height];
							Class486.smethod_5(bitmap, array3);
							for (int num9 = 0; num9 < bitmap.Height; num9++)
							{
								array[num9] = new Class486.Class487();
								array[num9].byte_0 = new byte[bitmap.Width];
								for (int num10 = 0; num10 < bitmap.Width; num10++)
								{
									array[num9].byte_0[num10] = array3[num10, num9].A;
								}
							}
						}
						foreach (Class486.Class487 tbl in array)
						{
							Class486.smethod_7(stream, tbl);
						}
						Array.Reverse(array);
						binaryWriter.Seek(512, SeekOrigin.Begin);
						foreach (Class486.Class487 class3 in array)
						{
							stream.smethod_35(class3.int_0);
						}
						foreach (Class486.Class487 class4 in array)
						{
							stream.smethod_35(class4.int_1);
						}
					}
				}
			}
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x000A87E0 File Offset: 0x000A69E0
		public static Enum14 smethod_1(Stream data_stream)
		{
			Enum14 result;
			using (Stream3 stream = new Stream3(data_stream))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					stream.smethod_36();
					binaryReader.ReadByte();
					binaryReader.ReadByte();
					short num = stream.smethod_36();
					stream.smethod_36();
					stream.smethod_36();
					short num2 = stream.smethod_36();
					switch (num)
					{
					case 1:
					case 2:
						result = Enum14.const_3;
						break;
					case 3:
						switch (num2)
						{
						case 2:
							result = Enum14.const_2;
							break;
						case 3:
							result = Enum14.const_1;
							break;
						case 4:
							result = Enum14.const_0;
							break;
						default:
							throw new NotSupportedException(string.Format("ZSIZE: '{0}' is not supported.", num2));
						}
						break;
					default:
						throw new NotSupportedException(string.Format("DIMENSION: '{0}' is not supported.", num));
					}
				}
			}
			return result;
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x000A88D0 File Offset: 0x000A6AD0
		public static Bitmap smethod_2(Stream data_stream)
		{
			Bitmap result;
			using (Stream3 stream = new Stream3(data_stream))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					stream.smethod_36();
					byte b = binaryReader.ReadByte();
					binaryReader.ReadByte();
					short num = stream.smethod_36();
					short num2 = stream.smethod_36();
					short num3 = stream.smethod_36();
					short num4 = stream.smethod_36();
					stream.smethod_34();
					stream.smethod_34();
					stream.smethod_34();
					binaryReader.ReadBytes(80);
					stream.smethod_34();
					binaryReader.ReadBytes(404);
					int num5 = (int)(num3 * num4);
					Class486.Class487[] array = new Class486.Class487[num5];
					int num6 = 0;
					if (b == 1)
					{
						for (int i = 0; i < num5; i++)
						{
							array[i] = new Class486.Class487();
							array[i].int_0 = stream.smethod_34();
						}
						for (int j = 0; j < num5; j++)
						{
							array[j].int_1 = stream.smethod_34();
						}
						for (int k = 0; k < num5; k++)
						{
							array[k].byte_0 = new byte[(int)num2];
						}
						Array.Reverse(array);
						if (num == 1)
						{
							Class486.smethod_6(stream, array[0]);
						}
						else
						{
							if (num != 2)
							{
								if (num != 3)
								{
									throw new InvalidDataException("Invalid SGI image format.");
								}
							}
							foreach (Class486.Class487 tbl in array)
							{
								Class486.smethod_6(stream, tbl);
								num6++;
							}
						}
					}
					Struct33[,] array3 = new Struct33[(int)num2, (int)num3];
					int num7 = 0;
					num6 = 0;
					bool flag;
					if (num == 3)
					{
						switch (num4)
						{
						case 2:
							flag = true;
							for (int m = 0; m < (int)num4; m++)
							{
								int num8 = (int)num3 * m;
								num7 = 0;
								num6 = 0;
								for (int n = num8; n < num8 + (int)num3; n++)
								{
									Class486.Class487 @class = array[n];
									foreach (byte b2 in @class.byte_0)
									{
										switch (m)
										{
										case 0:
											array3[num7, num6].A = b2;
											break;
										case 1:
											array3[num7, num6].R = b2;
											array3[num7, num6].G = b2;
											array3[num7, num6].B = b2;
											break;
										}
										num7++;
									}
									num7 = 0;
									num6++;
								}
							}
							break;
						case 3:
						case 4:
							flag = (num4 == 4);
							for (int num10 = (int)(num4 - 1); num10 >= 0; num10--)
							{
								int num11 = (int)num3 * ((int)num4 - num10 - 1);
								num7 = 0;
								num6 = 0;
								for (int num12 = num11; num12 < num11 + (int)num3; num12++)
								{
									Class486.Class487 class2 = array[num12];
									foreach (byte b3 in class2.byte_0)
									{
										switch (num10)
										{
										case 0:
											array3[num7, num6].R = b3;
											break;
										case 1:
											array3[num7, num6].G = b3;
											break;
										case 2:
											array3[num7, num6].B = b3;
											break;
										case 3:
											array3[num7, num6].A = b3;
											break;
										}
										num7++;
									}
									num7 = 0;
									num6++;
								}
							}
							break;
						default:
							throw new NotSupportedException(string.Format("ZSIZE: '{0}' is not supported.", num4));
						}
					}
					else
					{
						flag = true;
						foreach (Class486.Class487 class3 in array)
						{
							foreach (byte b4 in class3.byte_0)
							{
								array3[num7, num6].R = b4;
								array3[num7, num6].G = b4;
								array3[num7, num6].B = b4;
								array3[num7, num6].A = b4;
								num7++;
							}
							num7 = 0;
							num6++;
						}
					}
					Bitmap bitmap = null;
					try
					{
						if (flag)
						{
							bitmap = new Bitmap((int)num2, (int)num3, PixelFormat.Format32bppArgb);
						}
						else
						{
							bitmap = new Bitmap((int)num2, (int)num3, PixelFormat.Format32bppRgb);
						}
						Class486.smethod_3(bitmap, array3);
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
				}
			}
			return result;
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x000A8DA4 File Offset: 0x000A6FA4
		private unsafe static void smethod_3(Bitmap bmp, Struct33[,] data)
		{
			using (Class125 @class = new Class125(bmp))
			{
				using (new Class125.Class153(@class))
				{
					try
					{
						Struct33* ptr;
						if (data != null && data.Length != 0)
						{
							fixed (Struct33* ptr = &data[0, 0])
							{
							}
						}
						else
						{
							ptr = null;
						}
						Struct33* ptr2 = ptr;
						Struct33* ptr3 = @class.pBase;
						for (int i = 0; i < bmp.Width * bmp.Height; i++)
						{
							*ptr3 = *ptr2;
							ptr3++;
							ptr2++;
						}
					}
					finally
					{
						Struct33* ptr = null;
					}
				}
			}
		}

		// Token: 0x06002B5C RID: 11100 RVA: 0x000A8E6C File Offset: 0x000A706C
		private unsafe static void smethod_4(Bitmap original, Struct33[,] data)
		{
			int width = original.Width;
			int height = original.Height;
			using (Class125 @class = new Class125(original))
			{
				using (new Class125.Class153(@class))
				{
					Struct33* ptr = @class.pBase;
					for (int i = 0; i < height; i++)
					{
						for (int j = 0; j < width; j++)
						{
							data[j, i] = *ptr;
							ptr++;
						}
					}
				}
			}
		}

		// Token: 0x06002B5D RID: 11101 RVA: 0x000A8F14 File Offset: 0x000A7114
		private unsafe static void smethod_5(Bitmap original, Color[,] data)
		{
			int width = original.Width;
			int height = original.Height;
			using (Class125 @class = new Class125(original))
			{
				using (new Class125.Class153(@class))
				{
					Struct33* ptr = @class.pBase;
					for (int i = 0; i < height; i++)
					{
						for (int j = 0; j < width; j++)
						{
							data[j, i] = Struct33.smethod_0(*ptr);
							ptr++;
						}
					}
				}
			}
		}

		// Token: 0x06002B5E RID: 11102 RVA: 0x000A8FC0 File Offset: 0x000A71C0
		private static void smethod_6(Stream reader, Class486.Class487 tbl)
		{
			reader.Position = (long)tbl.int_0;
			int num = 0;
			for (;;)
			{
				int num2 = reader.ReadByte();
				int i = num2 & 127;
				if (i == 0)
				{
					break;
				}
				if ((num2 & 128) > 0)
				{
					while (i > 0)
					{
						byte b = (byte)reader.ReadByte();
						tbl.byte_0[num] = b;
						i--;
						num++;
					}
				}
				else
				{
					byte b = (byte)reader.ReadByte();
					while (i > 0)
					{
						tbl.byte_0[num] = b;
						i--;
						num++;
					}
				}
			}
		}

		// Token: 0x06002B5F RID: 11103 RVA: 0x000A9040 File Offset: 0x000A7240
		private static void smethod_7(Stream writer, Class486.Class487 tbl)
		{
			tbl.int_0 = (int)writer.Position;
			int num = 0;
			while (num != tbl.byte_0.Length)
			{
				byte b = tbl.byte_0[num];
				int num2 = 1;
				int num3 = num + 1;
				while (num3 - num < 127 && num3 < tbl.byte_0.Length && tbl.byte_0[num3] == b)
				{
					num2++;
					num3++;
				}
				int num4 = 1;
				num3 = num + 1;
				while (num3 - num < 127 && num3 + 1 < tbl.byte_0.Length && tbl.byte_0[num3] != tbl.byte_0[num3 + 1])
				{
					num4++;
					num3 += 2;
				}
				if (num4 > 1)
				{
					writer.WriteByte((byte)(128 + num4));
					tbl.int_1++;
					for (int i = num; i < num + num4; i++)
					{
						writer.WriteByte(tbl.byte_0[i]);
						tbl.int_1++;
					}
					num += num4;
				}
				else
				{
					writer.WriteByte((byte)num2);
					tbl.int_1++;
					writer.WriteByte(b);
					tbl.int_1++;
					num += num2;
				}
			}
			writer.WriteByte(0);
			tbl.int_1++;
		}

		// Token: 0x040016F4 RID: 5876
		public static readonly short short_0 = 474;

		// Token: 0x0200048E RID: 1166
		private sealed class Class487
		{
			// Token: 0x040016F5 RID: 5877
			public int int_0;

			// Token: 0x040016F6 RID: 5878
			public int int_1;

			// Token: 0x040016F7 RID: 5879
			public byte[] byte_0;
		}
	}
}
