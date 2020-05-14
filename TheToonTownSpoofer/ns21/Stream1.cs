using System;
using System.IO;
using ns25;
using ns26;
using TheToonTownSpoofer.IO.Compression.BZip2;

namespace ns21
{
	// Token: 0x02000244 RID: 580
	internal sealed class Stream1 : Stream
	{
		// Token: 0x060018C9 RID: 6345 RVA: 0x00043550 File Offset: 0x00041750
		public Stream1(Stream stream)
		{
			for (int i = 0; i < Class320.int_6; i++)
			{
				this.int_15[i] = new int[Class320.int_2];
				this.int_16[i] = new int[Class320.int_2];
				this.int_17[i] = new int[Class320.int_2];
			}
			this.method_5(stream);
			this.method_1();
			this.method_2();
			this.method_13();
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060018CA RID: 6346 RVA: 0x00008243 File Offset: 0x00006443
		// (set) Token: 0x060018CB RID: 6347 RVA: 0x0000824B File Offset: 0x0000644B
		public bool IsStreamOwner
		{
			get
			{
				return this.bool_3;
			}
			set
			{
				this.bool_3 = value;
			}
		}

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x060018CC RID: 6348 RVA: 0x00008254 File Offset: 0x00006454
		public override bool CanRead
		{
			get
			{
				return this.stream_0.CanRead;
			}
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060018CD RID: 6349 RVA: 0x00008261 File Offset: 0x00006461
		public override bool CanSeek
		{
			get
			{
				return this.stream_0.CanSeek;
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x060018CE RID: 6350 RVA: 0x000067F0 File Offset: 0x000049F0
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x060018CF RID: 6351 RVA: 0x0000826E File Offset: 0x0000646E
		public override long Length
		{
			get
			{
				return this.stream_0.Length;
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x060018D0 RID: 6352 RVA: 0x0000827B File Offset: 0x0000647B
		// (set) Token: 0x060018D1 RID: 6353 RVA: 0x00008288 File Offset: 0x00006488
		public override long Position
		{
			get
			{
				return this.stream_0.Position;
			}
			set
			{
				throw new NotSupportedException("BZip2InputStream position cannot be set");
			}
		}

		// Token: 0x060018D2 RID: 6354 RVA: 0x00008294 File Offset: 0x00006494
		public override void Flush()
		{
			if (this.stream_0 != null)
			{
				this.stream_0.Flush();
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x000082A9 File Offset: 0x000064A9
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("BZip2InputStream Seek not supported");
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x000082B5 File Offset: 0x000064B5
		public override void SetLength(long value)
		{
			throw new NotSupportedException("BZip2InputStream SetLength not supported");
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x000082C1 File Offset: 0x000064C1
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException("BZip2InputStream Write not supported");
		}

		// Token: 0x060018D6 RID: 6358 RVA: 0x000082CD File Offset: 0x000064CD
		public override void WriteByte(byte value)
		{
			throw new NotSupportedException("BZip2InputStream WriteByte not supported");
		}

		// Token: 0x060018D7 RID: 6359 RVA: 0x00043684 File Offset: 0x00041884
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			for (int i = 0; i < count; i++)
			{
				int num = this.ReadByte();
				if (num == -1)
				{
					return i;
				}
				buffer[offset + i] = (byte)num;
			}
			return count;
		}

		// Token: 0x060018D8 RID: 6360 RVA: 0x000082D9 File Offset: 0x000064D9
		public override void Close()
		{
			if (this.IsStreamOwner && this.stream_0 != null)
			{
				this.stream_0.Close();
			}
		}

		// Token: 0x060018D9 RID: 6361 RVA: 0x000436C4 File Offset: 0x000418C4
		public override int ReadByte()
		{
			if (this.bool_2)
			{
				return -1;
			}
			int result = this.int_19;
			switch (this.int_20)
			{
			case 3:
				this.method_16();
				break;
			case 4:
				this.method_17();
				break;
			case 6:
				this.method_18();
				break;
			case 7:
				this.method_19();
				break;
			}
			return result;
		}

		// Token: 0x060018DA RID: 6362 RVA: 0x00043730 File Offset: 0x00041930
		private void method_0()
		{
			this.int_12 = 0;
			for (int i = 0; i < 256; i++)
			{
				if (this.bool_1[i])
				{
					this.byte_0[this.int_12] = (byte)i;
					this.byte_1[i] = (byte)this.int_12;
					this.int_12++;
				}
			}
		}

		// Token: 0x060018DB RID: 6363 RVA: 0x0004378C File Offset: 0x0004198C
		private void method_1()
		{
			char c = this.method_8();
			char c2 = this.method_8();
			char c3 = this.method_8();
			char c4 = this.method_8();
			if (c == 'B' && c2 == 'Z' && c3 == 'h' && c4 >= '1' && c4 <= '9')
			{
				this.method_20((int)(c4 - '0'));
				this.uint_0 = 0U;
				return;
			}
			this.bool_2 = true;
		}

		// Token: 0x060018DC RID: 6364 RVA: 0x000437E8 File Offset: 0x000419E8
		private void method_2()
		{
			char c = this.method_8();
			char c2 = this.method_8();
			char c3 = this.method_8();
			char c4 = this.method_8();
			char c5 = this.method_8();
			char c6 = this.method_8();
			if (c == '\u0017' && c2 == 'r' && c3 == 'E' && c4 == '8' && c5 == 'P' && c6 == '\u0090')
			{
				this.method_4();
				return;
			}
			if (c == '1' && c2 == 'A' && c3 == 'Y' && c4 == '&' && c5 == 'S')
			{
				if (c6 == 'Y')
				{
					this.int_21 = this.method_10();
					this.bool_0 = (this.method_7(1) == 1);
					this.method_12();
					this.interface23_0.imethod_0();
					this.int_20 = 1;
					return;
				}
			}
			Stream1.smethod_2();
			this.bool_2 = true;
		}

		// Token: 0x060018DD RID: 6365 RVA: 0x000438B0 File Offset: 0x00041AB0
		private void method_3()
		{
			this.int_23 = (int)this.interface23_0.Value;
			if (this.int_21 != this.int_23)
			{
				Stream1.smethod_3();
			}
			this.uint_0 = ((this.uint_0 << 1 & uint.MaxValue) | this.uint_0 >> 31);
			this.uint_0 ^= (uint)this.int_23;
		}

		// Token: 0x060018DE RID: 6366 RVA: 0x000082F6 File Offset: 0x000064F6
		private void method_4()
		{
			this.int_22 = this.method_10();
			if (this.int_22 != (int)this.uint_0)
			{
				Stream1.smethod_3();
			}
			this.bool_2 = true;
		}

		// Token: 0x060018DF RID: 6367 RVA: 0x0000831E File Offset: 0x0000651E
		private void method_5(Stream stream)
		{
			this.stream_0 = stream;
			this.int_11 = 0;
			this.int_10 = 0;
		}

		// Token: 0x060018E0 RID: 6368 RVA: 0x00043910 File Offset: 0x00041B10
		private void method_6()
		{
			int num = 0;
			try
			{
				num = this.stream_0.ReadByte();
			}
			catch (Exception)
			{
				Stream1.smethod_0();
			}
			if (num == -1)
			{
				Stream1.smethod_0();
			}
			this.int_10 = (this.int_10 << 8 | (num & 255));
			this.int_11 += 8;
		}

		// Token: 0x060018E1 RID: 6369 RVA: 0x00043974 File Offset: 0x00041B74
		private int method_7(int n)
		{
			while (this.int_11 < n)
			{
				this.method_6();
			}
			int result = this.int_10 >> this.int_11 - n & (1 << n) - 1;
			this.int_11 -= n;
			return result;
		}

		// Token: 0x060018E2 RID: 6370 RVA: 0x00008335 File Offset: 0x00006535
		private char method_8()
		{
			return (char)this.method_7(8);
		}

		// Token: 0x060018E3 RID: 6371 RVA: 0x0000833F File Offset: 0x0000653F
		private int method_9(int numBits)
		{
			return this.method_7(numBits);
		}

		// Token: 0x060018E4 RID: 6372 RVA: 0x000439C0 File Offset: 0x00041BC0
		private int method_10()
		{
			int num = this.method_7(8);
			num = (num << 8 | this.method_7(8));
			num = (num << 8 | this.method_7(8));
			return num << 8 | this.method_7(8);
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x000439FC File Offset: 0x00041BFC
		private void method_11()
		{
			char[][] array = new char[Class320.int_6][];
			for (int i = 0; i < Class320.int_6; i++)
			{
				array[i] = new char[Class320.int_2];
			}
			bool[] array2 = new bool[16];
			for (int j = 0; j < 16; j++)
			{
				array2[j] = (this.method_7(1) == 1);
			}
			for (int k = 0; k < 16; k++)
			{
				if (array2[k])
				{
					for (int l = 0; l < 16; l++)
					{
						this.bool_1[k * 16 + l] = (this.method_7(1) == 1);
					}
				}
				else
				{
					for (int m = 0; m < 16; m++)
					{
						this.bool_1[k * 16 + m] = false;
					}
				}
			}
			this.method_0();
			int num = this.int_12 + 2;
			int num2 = this.method_7(3);
			int num3 = this.method_7(15);
			for (int n = 0; n < num3; n++)
			{
				int num4 = 0;
				while (this.method_7(1) == 1)
				{
					num4++;
				}
				this.byte_3[n] = (byte)num4;
			}
			byte[] array3 = new byte[Class320.int_6];
			for (int num5 = 0; num5 < num2; num5++)
			{
				array3[num5] = (byte)num5;
			}
			for (int num6 = 0; num6 < num3; num6++)
			{
				int num7 = (int)this.byte_3[num6];
				byte b = array3[num7];
				while (num7 > 0)
				{
					array3[num7] = array3[num7 - 1];
					num7--;
				}
				array3[0] = b;
				this.byte_2[num6] = b;
			}
			for (int num8 = 0; num8 < num2; num8++)
			{
				int num9 = this.method_7(5);
				for (int num10 = 0; num10 < num; num10++)
				{
					while (this.method_7(1) == 1)
					{
						if (this.method_7(1) == 0)
						{
							num9++;
						}
						else
						{
							num9--;
						}
					}
					array[num8][num10] = (char)num9;
				}
			}
			for (int num11 = 0; num11 < num2; num11++)
			{
				int num12 = 32;
				int num13 = 0;
				for (int num14 = 0; num14 < num; num14++)
				{
					num13 = Math.Max(num13, (int)array[num11][num14]);
					num12 = Math.Min(num12, (int)array[num11][num14]);
				}
				Stream1.smethod_4(this.int_15[num11], this.int_16[num11], this.int_17[num11], array[num11], num12, num13, num);
				this.int_18[num11] = num12;
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00043C54 File Offset: 0x00041E54
		private void method_12()
		{
			byte[] array = new byte[256];
			int num = Class320.int_1 * this.int_9;
			this.int_8 = this.method_9(24);
			this.method_11();
			int num2 = this.int_12 + 1;
			int num3 = -1;
			int num4 = 0;
			for (int i = 0; i <= 255; i++)
			{
				this.int_14[i] = 0;
			}
			for (int j = 0; j <= 255; j++)
			{
				array[j] = (byte)j;
			}
			this.int_7 = -1;
			if (num4 == 0)
			{
				num3++;
				num4 = Class320.int_7;
			}
			num4--;
			int num5 = (int)this.byte_2[num3];
			int num6 = this.int_18[num5];
			int k;
			int num7;
			for (k = this.method_7(num6); k > this.int_15[num5][num6]; k = (k << 1 | num7))
			{
				if (num6 > 20)
				{
					throw new BZip2Exception("Bzip data error");
				}
				num6++;
				while (this.int_11 < 1)
				{
					this.method_6();
				}
				num7 = (this.int_10 >> this.int_11 - 1 & 1);
				this.int_11--;
			}
			if (k - this.int_16[num5][num6] >= 0 && k - this.int_16[num5][num6] < Class320.int_2)
			{
				int num8 = this.int_17[num5][k - this.int_16[num5][num6]];
				while (num8 != num2)
				{
					if (num8 != Class320.int_4)
					{
						if (num8 != Class320.int_5)
						{
							this.int_7++;
							if (this.int_7 >= num)
							{
								Stream1.smethod_1();
							}
							byte b = array[num8 - 1];
							this.int_14[(int)this.byte_0[(int)b]]++;
							this.byte_4[this.int_7] = this.byte_0[(int)b];
							for (int l = num8 - 1; l > 0; l--)
							{
								array[l] = array[l - 1];
							}
							array[0] = b;
							if (num4 == 0)
							{
								num3++;
								num4 = Class320.int_7;
							}
							num4--;
							num5 = (int)this.byte_2[num3];
							num6 = this.int_18[num5];
							for (k = this.method_7(num6); k > this.int_15[num5][num6]; k = (k << 1 | num7))
							{
								num6++;
								while (this.int_11 < 1)
								{
									this.method_6();
								}
								num7 = (this.int_10 >> this.int_11 - 1 & 1);
								this.int_11--;
							}
							num8 = this.int_17[num5][k - this.int_16[num5][num6]];
							continue;
						}
					}
					int m = -1;
					int num9 = 1;
					do
					{
						if (num8 == Class320.int_4)
						{
							m += num9;
						}
						else if (num8 == Class320.int_5)
						{
							m += 2 * num9;
						}
						num9 <<= 1;
						if (num4 == 0)
						{
							num3++;
							num4 = Class320.int_7;
						}
						num4--;
						num5 = (int)this.byte_2[num3];
						num6 = this.int_18[num5];
						for (k = this.method_7(num6); k > this.int_15[num5][num6]; k = (k << 1 | num7))
						{
							num6++;
							while (this.int_11 < 1)
							{
								this.method_6();
							}
							num7 = (this.int_10 >> this.int_11 - 1 & 1);
							this.int_11--;
						}
						num8 = this.int_17[num5][k - this.int_16[num5][num6]];
					}
					while (num8 == Class320.int_4 || num8 == Class320.int_5);
					m++;
					byte b2 = this.byte_0[(int)array[0]];
					this.int_14[(int)b2] += m;
					while (m > 0)
					{
						this.int_7++;
						this.byte_4[this.int_7] = b2;
						m--;
					}
					if (this.int_7 >= num)
					{
						Stream1.smethod_1();
					}
				}
				return;
			}
			throw new BZip2Exception("Bzip data error");
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x00044078 File Offset: 0x00042278
		private void method_13()
		{
			int[] array = new int[257];
			array[0] = 0;
			Array.Copy(this.int_14, 0, array, 1, 256);
			for (int i = 1; i <= 256; i++)
			{
				array[i] += array[i - 1];
			}
			for (int j = 0; j <= this.int_7; j++)
			{
				byte b = this.byte_4[j];
				this.int_13[array[(int)b]] = j;
				array[(int)b]++;
			}
			this.int_27 = this.int_13[this.int_8];
			this.int_24 = 0;
			this.int_30 = 0;
			this.int_26 = 256;
			if (this.bool_0)
			{
				this.int_28 = 0;
				this.int_29 = 0;
				this.method_14();
				return;
			}
			this.method_15();
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x0004415C File Offset: 0x0004235C
		private void method_14()
		{
			if (this.int_30 <= this.int_7)
			{
				this.int_25 = this.int_26;
				this.int_26 = (int)this.byte_4[this.int_27];
				this.int_27 = this.int_13[this.int_27];
				if (this.int_28 == 0)
				{
					this.int_28 = Class320.int_0[this.int_29];
					this.int_29++;
					if (this.int_29 == 512)
					{
						this.int_29 = 0;
					}
				}
				this.int_28--;
				this.int_26 ^= ((this.int_28 == 1) ? 1 : 0);
				this.int_30++;
				this.int_19 = this.int_26;
				this.int_20 = 3;
				this.interface23_0.imethod_1(this.int_26);
				return;
			}
			this.method_3();
			this.method_2();
			this.method_13();
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00044258 File Offset: 0x00042458
		private void method_15()
		{
			if (this.int_30 <= this.int_7)
			{
				this.int_25 = this.int_26;
				this.int_26 = (int)this.byte_4[this.int_27];
				this.int_27 = this.int_13[this.int_27];
				this.int_30++;
				this.int_19 = this.int_26;
				this.int_20 = 6;
				this.interface23_0.imethod_1(this.int_26);
				return;
			}
			this.method_3();
			this.method_2();
			this.method_13();
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x000442EC File Offset: 0x000424EC
		private void method_16()
		{
			if (this.int_26 != this.int_25)
			{
				this.int_20 = 2;
				this.int_24 = 1;
				this.method_14();
				return;
			}
			this.int_24++;
			if (this.int_24 >= 4)
			{
				this.byte_5 = this.byte_4[this.int_27];
				this.int_27 = this.int_13[this.int_27];
				if (this.int_28 == 0)
				{
					this.int_28 = Class320.int_0[this.int_29];
					this.int_29++;
					if (this.int_29 == 512)
					{
						this.int_29 = 0;
					}
				}
				this.int_28--;
				this.byte_5 ^= ((this.int_28 == 1) ? 1 : 0);
				this.int_31 = 0;
				this.int_20 = 4;
				this.method_17();
				return;
			}
			this.int_20 = 2;
			this.method_14();
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x000443E4 File Offset: 0x000425E4
		private void method_17()
		{
			if (this.int_31 < (int)this.byte_5)
			{
				this.int_19 = this.int_26;
				this.interface23_0.imethod_1(this.int_26);
				this.int_31++;
				return;
			}
			this.int_20 = 2;
			this.int_30++;
			this.int_24 = 0;
			this.method_14();
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00044450 File Offset: 0x00042650
		private void method_18()
		{
			if (this.int_26 != this.int_25)
			{
				this.int_20 = 5;
				this.int_24 = 1;
				this.method_15();
				return;
			}
			this.int_24++;
			if (this.int_24 >= 4)
			{
				this.byte_5 = this.byte_4[this.int_27];
				this.int_27 = this.int_13[this.int_27];
				this.int_20 = 7;
				this.int_31 = 0;
				this.method_19();
				return;
			}
			this.int_20 = 5;
			this.method_15();
		}

		// Token: 0x060018ED RID: 6381 RVA: 0x000444E0 File Offset: 0x000426E0
		private void method_19()
		{
			if (this.int_31 < (int)this.byte_5)
			{
				this.int_19 = this.int_26;
				this.interface23_0.imethod_1(this.int_26);
				this.int_31++;
				return;
			}
			this.int_20 = 5;
			this.int_30++;
			this.int_24 = 0;
			this.method_15();
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x0004454C File Offset: 0x0004274C
		private void method_20(int newSize100k)
		{
			if (0 > newSize100k || newSize100k > 9 || 0 > this.int_9 || this.int_9 > 9)
			{
				throw new BZip2Exception("Invalid block size");
			}
			this.int_9 = newSize100k;
			if (newSize100k == 0)
			{
				return;
			}
			int num = Class320.int_1 * newSize100k;
			this.byte_4 = new byte[num];
			this.int_13 = new int[num];
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00008348 File Offset: 0x00006548
		private static void smethod_0()
		{
			throw new EndOfStreamException("BZip2 input stream end of compressed stream");
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x00008354 File Offset: 0x00006554
		private static void smethod_1()
		{
			throw new BZip2Exception("BZip2 input stream block overrun");
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x00008360 File Offset: 0x00006560
		private static void smethod_2()
		{
			throw new BZip2Exception("BZip2 input stream bad block header");
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0000836C File Offset: 0x0000656C
		private static void smethod_3()
		{
			throw new BZip2Exception("BZip2 input stream crc error");
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x000445AC File Offset: 0x000427AC
		private static void smethod_4(int[] limit, int[] baseArray, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
			int num = 0;
			for (int i = minLen; i <= maxLen; i++)
			{
				for (int j = 0; j < alphaSize; j++)
				{
					if ((int)length[j] == i)
					{
						perm[num] = j;
						num++;
					}
				}
			}
			for (int k = 0; k < Class320.int_3; k++)
			{
				baseArray[k] = 0;
			}
			for (int l = 0; l < alphaSize; l++)
			{
				baseArray[(int)(length[l] + '\u0001')]++;
			}
			for (int m = 1; m < Class320.int_3; m++)
			{
				baseArray[m] += baseArray[m - 1];
			}
			for (int n = 0; n < Class320.int_3; n++)
			{
				limit[n] = 0;
			}
			int num2 = 0;
			for (int num3 = minLen; num3 <= maxLen; num3++)
			{
				num2 += baseArray[num3 + 1] - baseArray[num3];
				limit[num3] = num2 - 1;
				num2 <<= 1;
			}
			for (int num4 = minLen + 1; num4 <= maxLen; num4++)
			{
				baseArray[num4] = (limit[num4 - 1] + 1 << 1) - baseArray[num4];
			}
		}

		// Token: 0x04000696 RID: 1686
		private const int int_0 = 1;

		// Token: 0x04000697 RID: 1687
		private const int int_1 = 2;

		// Token: 0x04000698 RID: 1688
		private const int int_2 = 3;

		// Token: 0x04000699 RID: 1689
		private const int int_3 = 4;

		// Token: 0x0400069A RID: 1690
		private const int int_4 = 5;

		// Token: 0x0400069B RID: 1691
		private const int int_5 = 6;

		// Token: 0x0400069C RID: 1692
		private const int int_6 = 7;

		// Token: 0x0400069D RID: 1693
		private int int_7;

		// Token: 0x0400069E RID: 1694
		private int int_8;

		// Token: 0x0400069F RID: 1695
		private int int_9;

		// Token: 0x040006A0 RID: 1696
		private bool bool_0;

		// Token: 0x040006A1 RID: 1697
		private int int_10;

		// Token: 0x040006A2 RID: 1698
		private int int_11;

		// Token: 0x040006A3 RID: 1699
		private Interface23 interface23_0 = new Class475();

		// Token: 0x040006A4 RID: 1700
		private bool[] bool_1 = new bool[256];

		// Token: 0x040006A5 RID: 1701
		private int int_12;

		// Token: 0x040006A6 RID: 1702
		private byte[] byte_0 = new byte[256];

		// Token: 0x040006A7 RID: 1703
		private byte[] byte_1 = new byte[256];

		// Token: 0x040006A8 RID: 1704
		private byte[] byte_2 = new byte[Class320.int_9];

		// Token: 0x040006A9 RID: 1705
		private byte[] byte_3 = new byte[Class320.int_9];

		// Token: 0x040006AA RID: 1706
		private int[] int_13;

		// Token: 0x040006AB RID: 1707
		private byte[] byte_4;

		// Token: 0x040006AC RID: 1708
		private int[] int_14 = new int[256];

		// Token: 0x040006AD RID: 1709
		private int[][] int_15 = new int[Class320.int_6][];

		// Token: 0x040006AE RID: 1710
		private int[][] int_16 = new int[Class320.int_6][];

		// Token: 0x040006AF RID: 1711
		private int[][] int_17 = new int[Class320.int_6][];

		// Token: 0x040006B0 RID: 1712
		private int[] int_18 = new int[Class320.int_6];

		// Token: 0x040006B1 RID: 1713
		private Stream stream_0;

		// Token: 0x040006B2 RID: 1714
		private bool bool_2;

		// Token: 0x040006B3 RID: 1715
		private int int_19 = -1;

		// Token: 0x040006B4 RID: 1716
		private int int_20 = 1;

		// Token: 0x040006B5 RID: 1717
		private int int_21;

		// Token: 0x040006B6 RID: 1718
		private int int_22;

		// Token: 0x040006B7 RID: 1719
		private int int_23;

		// Token: 0x040006B8 RID: 1720
		private uint uint_0;

		// Token: 0x040006B9 RID: 1721
		private int int_24;

		// Token: 0x040006BA RID: 1722
		private int int_25;

		// Token: 0x040006BB RID: 1723
		private int int_26;

		// Token: 0x040006BC RID: 1724
		private int int_27;

		// Token: 0x040006BD RID: 1725
		private int int_28;

		// Token: 0x040006BE RID: 1726
		private int int_29;

		// Token: 0x040006BF RID: 1727
		private int int_30;

		// Token: 0x040006C0 RID: 1728
		private int int_31;

		// Token: 0x040006C1 RID: 1729
		private byte byte_5;

		// Token: 0x040006C2 RID: 1730
		private bool bool_3 = true;
	}
}
