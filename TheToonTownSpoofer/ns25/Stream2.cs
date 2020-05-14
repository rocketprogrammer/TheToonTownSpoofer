using System;
using System.IO;
using ns26;
using TheToonTownSpoofer.IO.Compression.BZip2;

namespace ns25
{
	// Token: 0x02000341 RID: 833
	internal sealed class Stream2 : Stream
	{
		// Token: 0x0600203E RID: 8254 RVA: 0x0000D168 File Offset: 0x0000B368
		public Stream2(Stream stream) : this(stream, 9)
		{
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x0006AFF4 File Offset: 0x000691F4
		public Stream2(Stream stream, int blockSize)
		{
			this.method_6(stream);
			this.int_20 = 50;
			if (blockSize > 9)
			{
				blockSize = 9;
			}
			if (blockSize < 1)
			{
				blockSize = 1;
			}
			this.int_10 = blockSize;
			this.method_21();
			this.method_2();
			this.method_3();
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0006B0D0 File Offset: 0x000692D0
		~Stream2()
		{
			this.Dispose(false);
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002041 RID: 8257 RVA: 0x0000D173 File Offset: 0x0000B373
		// (set) Token: 0x06002042 RID: 8258 RVA: 0x0000D17B File Offset: 0x0000B37B
		public bool IsStreamOwner
		{
			get
			{
				return this.bool_0;
			}
			set
			{
				this.bool_0 = value;
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06002043 RID: 8259 RVA: 0x000067F0 File Offset: 0x000049F0
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06002044 RID: 8260 RVA: 0x000067F0 File Offset: 0x000049F0
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06002045 RID: 8261 RVA: 0x0000D184 File Offset: 0x0000B384
		public override bool CanWrite
		{
			get
			{
				return this.stream_0.CanWrite;
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06002046 RID: 8262 RVA: 0x0000D191 File Offset: 0x0000B391
		public override long Length
		{
			get
			{
				return this.stream_0.Length;
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06002047 RID: 8263 RVA: 0x0000D19E File Offset: 0x0000B39E
		// (set) Token: 0x06002048 RID: 8264 RVA: 0x0000D1AB File Offset: 0x0000B3AB
		public override long Position
		{
			get
			{
				return this.stream_0.Position;
			}
			set
			{
				throw new NotSupportedException("BZip2OutputStream position cannot be set");
			}
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x0000D1B7 File Offset: 0x0000B3B7
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw new NotSupportedException("BZip2OutputStream Seek not supported");
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x0000D1C3 File Offset: 0x0000B3C3
		public override void SetLength(long value)
		{
			throw new NotSupportedException("BZip2OutputStream SetLength not supported");
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x0000D1CF File Offset: 0x0000B3CF
		public override int ReadByte()
		{
			throw new NotSupportedException("BZip2OutputStream ReadByte not supported");
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x0000D1DB File Offset: 0x0000B3DB
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new NotSupportedException("BZip2OutputStream Read not supported");
		}

		// Token: 0x0600204D RID: 8269 RVA: 0x0006B100 File Offset: 0x00069300
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new ArgumentOutOfRangeException("offset");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (buffer.Length - offset < count)
			{
				throw new ArgumentException("Offset/count out of range");
			}
			for (int i = 0; i < count; i++)
			{
				this.WriteByte(buffer[offset + i]);
			}
		}

		// Token: 0x0600204E RID: 8270 RVA: 0x0006B164 File Offset: 0x00069364
		public override void WriteByte(byte value)
		{
			int num = (256 + (int)value) % 256;
			if (this.int_24 != -1)
			{
				if (this.int_24 != num)
				{
					this.method_1();
					this.int_25 = 1;
					this.int_24 = num;
					return;
				}
				this.int_25++;
				if (this.int_25 > 254)
				{
					this.method_1();
					this.int_24 = -1;
					this.int_25 = 0;
					return;
				}
			}
			else
			{
				this.int_24 = num;
				this.int_25++;
			}
		}

		// Token: 0x0600204F RID: 8271 RVA: 0x0000D1E7 File Offset: 0x0000B3E7
		public override void Close()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06002050 RID: 8272 RVA: 0x0006B1EC File Offset: 0x000693EC
		private void method_0()
		{
			this.int_14 = 0;
			for (int i = 0; i < 256; i++)
			{
				if (this.bool_2[i])
				{
					this.char_0[this.int_14] = (char)i;
					this.char_1[i] = (char)this.int_14;
					this.int_14++;
				}
			}
		}

		// Token: 0x06002051 RID: 8273 RVA: 0x0006B248 File Offset: 0x00069448
		private void method_1()
		{
			if (this.int_8 >= this.int_26)
			{
				this.method_4();
				this.method_3();
				this.method_1();
				return;
			}
			this.bool_2[this.int_24] = true;
			for (int i = 0; i < this.int_25; i++)
			{
				this.interface23_0.imethod_1(this.int_24);
			}
			switch (this.int_25)
			{
			case 1:
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				return;
			case 2:
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				return;
			case 3:
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				return;
			default:
				this.bool_2[this.int_25 - 4] = true;
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)this.int_24;
				this.int_8++;
				this.byte_0[this.int_8 + 1] = (byte)(this.int_25 - 4);
				return;
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x06002052 RID: 8274 RVA: 0x0000D1F6 File Offset: 0x0000B3F6
		public int BytesWritten
		{
			get
			{
				return this.int_11;
			}
		}

		// Token: 0x06002053 RID: 8275 RVA: 0x0006B468 File Offset: 0x00069668
		protected override void Dispose(bool disposing)
		{
			try
			{
				base.Dispose(disposing);
				if (!this.bool_4)
				{
					this.bool_4 = true;
					if (this.int_25 > 0)
					{
						this.method_1();
					}
					this.int_24 = -1;
					this.method_4();
					this.method_5();
					this.Flush();
				}
			}
			finally
			{
				if (disposing && this.IsStreamOwner)
				{
					this.stream_0.Close();
				}
			}
		}

		// Token: 0x06002054 RID: 8276 RVA: 0x0000D1FE File Offset: 0x0000B3FE
		public override void Flush()
		{
			this.stream_0.Flush();
		}

		// Token: 0x06002055 RID: 8277 RVA: 0x0000D20B File Offset: 0x0000B40B
		private void method_2()
		{
			this.int_11 = 0;
			this.int_23 = 0;
			this.method_9(66);
			this.method_9(90);
			this.method_9(104);
			this.method_9(48 + this.int_10);
			this.uint_1 = 0U;
		}

		// Token: 0x06002056 RID: 8278 RVA: 0x0006B4DC File Offset: 0x000696DC
		private void method_3()
		{
			this.interface23_0.imethod_0();
			this.int_8 = -1;
			for (int i = 0; i < 256; i++)
			{
				this.bool_2[i] = false;
			}
			this.int_26 = Class320.int_1 * this.int_10 - 20;
		}

		// Token: 0x06002057 RID: 8279 RVA: 0x0006B52C File Offset: 0x0006972C
		private void method_4()
		{
			if (this.int_8 < 0)
			{
				return;
			}
			this.uint_0 = (uint)this.interface23_0.Value;
			this.uint_1 = (this.uint_1 << 1 | this.uint_1 >> 31);
			this.uint_1 ^= this.uint_0;
			this.method_19();
			this.method_9(49);
			this.method_9(65);
			this.method_9(89);
			this.method_9(38);
			this.method_9(83);
			this.method_9(89);
			this.method_10((int)this.uint_0);
			if (this.bool_1)
			{
				this.method_8(1, 1);
				this.int_23++;
			}
			else
			{
				this.method_8(1, 0);
			}
			this.method_13();
		}

		// Token: 0x06002058 RID: 8280 RVA: 0x0006B5F0 File Offset: 0x000697F0
		private void method_5()
		{
			this.method_9(23);
			this.method_9(114);
			this.method_9(69);
			this.method_9(56);
			this.method_9(80);
			this.method_9(144);
			this.method_10((int)this.uint_1);
			this.method_7();
		}

		// Token: 0x06002059 RID: 8281 RVA: 0x0000D249 File Offset: 0x0000B449
		private void method_6(Stream stream)
		{
			this.stream_0 = stream;
			this.int_13 = 0;
			this.int_12 = 0;
			this.int_11 = 0;
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x0006B644 File Offset: 0x00069844
		private void method_7()
		{
			while (this.int_13 > 0)
			{
				int num = this.int_12 >> 24;
				this.stream_0.WriteByte((byte)num);
				this.int_12 <<= 8;
				this.int_13 -= 8;
				this.int_11++;
			}
		}

		// Token: 0x0600205B RID: 8283 RVA: 0x0006B6A0 File Offset: 0x000698A0
		private void method_8(int n, int v)
		{
			while (this.int_13 >= 8)
			{
				int num = this.int_12 >> 24;
				this.stream_0.WriteByte((byte)num);
				this.int_12 <<= 8;
				this.int_13 -= 8;
				this.int_11++;
			}
			this.int_12 |= v << 32 - this.int_13 - n;
			this.int_13 += n;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x0000D267 File Offset: 0x0000B467
		private void method_9(int c)
		{
			this.method_8(8, c);
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x0006B728 File Offset: 0x00069928
		private void method_10(int u)
		{
			this.method_8(8, u >> 24 & 255);
			this.method_8(8, u >> 16 & 255);
			this.method_8(8, u >> 8 & 255);
			this.method_8(8, u & 255);
		}

		// Token: 0x0600205E RID: 8286 RVA: 0x0000D271 File Offset: 0x0000B471
		private void method_11(int numBits, int c)
		{
			this.method_8(numBits, c);
		}

		// Token: 0x0600205F RID: 8287 RVA: 0x0006B778 File Offset: 0x00069978
		private void method_12()
		{
			char[][] array = new char[Class320.int_6][];
			for (int i = 0; i < Class320.int_6; i++)
			{
				array[i] = new char[Class320.int_2];
			}
			int num = 0;
			int num2 = this.int_14 + 2;
			for (int j = 0; j < Class320.int_6; j++)
			{
				for (int k = 0; k < num2; k++)
				{
					array[j][k] = '\u000f';
				}
			}
			if (this.int_18 <= 0)
			{
				Stream2.smethod_0();
			}
			int num3;
			if (this.int_18 < 200)
			{
				num3 = 2;
			}
			else if (this.int_18 < 600)
			{
				num3 = 3;
			}
			else if (this.int_18 < 1200)
			{
				num3 = 4;
			}
			else if (this.int_18 < 2400)
			{
				num3 = 5;
			}
			else
			{
				num3 = 6;
			}
			int l = num3;
			int num4 = this.int_18;
			int m = 0;
			while (l > 0)
			{
				int num5 = num4 / l;
				int num6 = 0;
				int num7 = m - 1;
				while (num6 < num5 && num7 < num2 - 1)
				{
					num7++;
					num6 += this.int_19[num7];
				}
				if (num7 > m && l != num3 && l != 1 && (num3 - l) % 2 == 1)
				{
					num6 -= this.int_19[num7];
					num7--;
				}
				for (int n = 0; n < num2; n++)
				{
					if (n >= m && n <= num7)
					{
						array[l - 1][n] = '\0';
					}
					else
					{
						array[l - 1][n] = '\u000f';
					}
				}
				l--;
				m = num7 + 1;
				num4 -= num6;
			}
			int[][] array2 = new int[Class320.int_6][];
			for (int num8 = 0; num8 < Class320.int_6; num8++)
			{
				array2[num8] = new int[Class320.int_2];
			}
			int[] array3 = new int[Class320.int_6];
			short[] array4 = new short[Class320.int_6];
			for (int num9 = 0; num9 < Class320.int_8; num9++)
			{
				for (int num10 = 0; num10 < num3; num10++)
				{
					array3[num10] = 0;
				}
				for (int num11 = 0; num11 < num3; num11++)
				{
					for (int num12 = 0; num12 < num2; num12++)
					{
						array2[num11][num12] = 0;
					}
				}
				num = 0;
				int num13 = 0;
				int num7;
				for (m = 0; m < this.int_18; m = num7 + 1)
				{
					num7 = m + Class320.int_7 - 1;
					if (num7 >= this.int_18)
					{
						num7 = this.int_18 - 1;
					}
					for (int num14 = 0; num14 < num3; num14++)
					{
						array4[num14] = 0;
					}
					if (num3 == 6)
					{
						short num15 = 0;
						short num16 = 0;
						short num17 = 0;
						short num18 = 0;
						short num19 = 0;
						short num20 = 0;
						short num21 = num15;
						for (int num22 = m; num22 <= num7; num22++)
						{
							short num23 = this.short_0[num22];
							num21 += (short)array[0][(int)num23];
							num20 += (short)array[1][(int)num23];
							num19 += (short)array[2][(int)num23];
							num18 += (short)array[3][(int)num23];
							num17 += (short)array[4][(int)num23];
							num16 += (short)array[5][(int)num23];
						}
						array4[0] = num21;
						array4[1] = num20;
						array4[2] = num19;
						array4[3] = num18;
						array4[4] = num17;
						array4[5] = num16;
					}
					else
					{
						for (int num24 = m; num24 <= num7; num24++)
						{
							short num25 = this.short_0[num24];
							for (int num26 = 0; num26 < num3; num26++)
							{
								short[] array5 = array4;
								int num27 = num26;
								array5[num27] += (short)array[num26][(int)num25];
							}
						}
					}
					int num28 = 999999999;
					int num29 = -1;
					for (int num30 = 0; num30 < num3; num30++)
					{
						if ((int)array4[num30] < num28)
						{
							num28 = (int)array4[num30];
							num29 = num30;
						}
					}
					num13 += num28;
					array3[num29]++;
					this.char_2[num] = (char)num29;
					num++;
					for (int num31 = m; num31 <= num7; num31++)
					{
						array2[num29][(int)this.short_0[num31]]++;
					}
				}
				for (int num32 = 0; num32 < num3; num32++)
				{
					Stream2.smethod_1(array[num32], array2[num32], num2, 20);
				}
			}
			if (num3 >= 8)
			{
				Stream2.smethod_0();
			}
			if (num >= 32768 || num > 2 + 900000 / Class320.int_7)
			{
				Stream2.smethod_0();
			}
			char[] array6 = new char[Class320.int_6];
			for (int num33 = 0; num33 < num3; num33++)
			{
				array6[num33] = (char)num33;
			}
			for (int num34 = 0; num34 < num; num34++)
			{
				char c = this.char_2[num34];
				int num35 = 0;
				char c2 = array6[0];
				while (c != c2)
				{
					num35++;
					char c3 = c2;
					c2 = array6[num35];
					array6[num35] = c3;
				}
				array6[0] = c2;
				this.char_3[num34] = (char)num35;
			}
			int[][] array7 = new int[Class320.int_6][];
			for (int num36 = 0; num36 < Class320.int_6; num36++)
			{
				array7[num36] = new int[Class320.int_2];
			}
			for (int num37 = 0; num37 < num3; num37++)
			{
				int num38 = 32;
				int num39 = 0;
				for (int num40 = 0; num40 < num2; num40++)
				{
					if ((int)array[num37][num40] > num39)
					{
						num39 = (int)array[num37][num40];
					}
					if ((int)array[num37][num40] < num38)
					{
						num38 = (int)array[num37][num40];
					}
				}
				if (num39 > 20)
				{
					Stream2.smethod_0();
				}
				if (num38 < 1)
				{
					Stream2.smethod_0();
				}
				Stream2.smethod_2(array7[num37], array[num37], num38, num39, num2);
			}
			bool[] array8 = new bool[16];
			for (int num41 = 0; num41 < 16; num41++)
			{
				array8[num41] = false;
				for (int num42 = 0; num42 < 16; num42++)
				{
					if (this.bool_2[num41 * 16 + num42])
					{
						array8[num41] = true;
					}
				}
			}
			for (int num43 = 0; num43 < 16; num43++)
			{
				if (array8[num43])
				{
					this.method_8(1, 1);
				}
				else
				{
					this.method_8(1, 0);
				}
			}
			for (int num44 = 0; num44 < 16; num44++)
			{
				if (array8[num44])
				{
					for (int num45 = 0; num45 < 16; num45++)
					{
						if (this.bool_2[num44 * 16 + num45])
						{
							this.method_8(1, 1);
						}
						else
						{
							this.method_8(1, 0);
						}
					}
				}
			}
			this.method_8(3, num3);
			this.method_8(15, num);
			for (int num46 = 0; num46 < num; num46++)
			{
				for (int num47 = 0; num47 < (int)this.char_3[num46]; num47++)
				{
					this.method_8(1, 1);
				}
				this.method_8(1, 0);
			}
			for (int num48 = 0; num48 < num3; num48++)
			{
				int num49 = (int)array[num48][0];
				this.method_8(5, num49);
				for (int num50 = 0; num50 < num2; num50++)
				{
					while (num49 < (int)array[num48][num50])
					{
						this.method_8(2, 2);
						num49++;
					}
					while (num49 > (int)array[num48][num50])
					{
						this.method_8(2, 3);
						num49--;
					}
					this.method_8(1, 0);
				}
			}
			int num51 = 0;
			m = 0;
			while (m < this.int_18)
			{
				int num7 = m + Class320.int_7 - 1;
				if (num7 >= this.int_18)
				{
					num7 = this.int_18 - 1;
				}
				for (int num52 = m; num52 <= num7; num52++)
				{
					this.method_8((int)array[(int)this.char_2[num51]][(int)this.short_0[num52]], array7[(int)this.char_2[num51]][(int)this.short_0[num52]]);
				}
				m = num7 + 1;
				num51++;
			}
			if (num51 != num)
			{
				Stream2.smethod_0();
			}
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x0000D27B File Offset: 0x0000B47B
		private void method_13()
		{
			this.method_11(24, this.int_9);
			this.method_22();
			this.method_12();
		}

		// Token: 0x06002061 RID: 8289 RVA: 0x0006BEE0 File Offset: 0x0006A0E0
		private void method_14(int lo, int hi, int d)
		{
			int num = hi - lo + 1;
			if (num < 2)
			{
				return;
			}
			int i = 0;
			while (this.int_7[i] < num)
			{
				i++;
			}
			for (i--; i >= 0; i--)
			{
				int num2 = this.int_7[i];
				int j = lo + num2;
				while (j <= hi)
				{
					int num3 = this.int_16[j];
					int num4 = j;
					while (this.method_20(this.int_16[num4 - num2] + d, num3 + d))
					{
						this.int_16[num4] = this.int_16[num4 - num2];
						num4 -= num2;
						if (num4 <= lo + num2 - 1)
						{
							break;
						}
					}
					this.int_16[num4] = num3;
					j++;
					if (j > hi)
					{
						break;
					}
					num3 = this.int_16[j];
					num4 = j;
					while (this.method_20(this.int_16[num4 - num2] + d, num3 + d))
					{
						this.int_16[num4] = this.int_16[num4 - num2];
						num4 -= num2;
						if (num4 <= lo + num2 - 1)
						{
							break;
						}
					}
					this.int_16[num4] = num3;
					j++;
					if (j > hi)
					{
						break;
					}
					num3 = this.int_16[j];
					num4 = j;
					while (this.method_20(this.int_16[num4 - num2] + d, num3 + d))
					{
						this.int_16[num4] = this.int_16[num4 - num2];
						num4 -= num2;
						if (num4 <= lo + num2 - 1)
						{
							break;
						}
					}
					this.int_16[num4] = num3;
					j++;
					if (this.int_21 > this.int_22 && this.bool_3)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x0006C05C File Offset: 0x0006A25C
		private void method_15(int p1, int p2, int n)
		{
			while (n > 0)
			{
				int num = this.int_16[p1];
				this.int_16[p1] = this.int_16[p2];
				this.int_16[p2] = num;
				p1++;
				p2++;
				n--;
			}
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x0006C0A4 File Offset: 0x0006A2A4
		private void method_16(int loSt, int hiSt, int dSt)
		{
			Stream2.Struct30[] array = new Stream2.Struct30[1000];
			array[0].int_0 = loSt;
			array[0].int_1 = hiSt;
			array[0].int_2 = dSt;
			int i = 1;
			while (i > 0)
			{
				if (i >= 1000)
				{
					Stream2.smethod_0();
				}
				i--;
				int num = array[i].int_0;
				int num2 = array[i].int_1;
				int num3 = array[i].int_2;
				if (num2 - num >= 20 && num3 <= 10)
				{
					int num4 = (int)Stream2.smethod_3(this.byte_0[this.int_16[num] + num3 + 1], this.byte_0[this.int_16[num2] + num3 + 1], this.byte_0[this.int_16[num + num2 >> 1] + num3 + 1]);
					int j;
					int num5 = j = num;
					int num7;
					int num6 = num7 = num2;
					for (;;)
					{
						if (j <= num7)
						{
							int num8 = (int)this.byte_0[this.int_16[j] + num3 + 1] - num4;
							if (num8 == 0)
							{
								int num9 = this.int_16[j];
								this.int_16[j] = this.int_16[num5];
								this.int_16[num5] = num9;
								num5++;
								j++;
								continue;
							}
							if (num8 <= 0)
							{
								j++;
								continue;
							}
						}
						while (j <= num7)
						{
							int num8 = (int)this.byte_0[this.int_16[num7] + num3 + 1] - num4;
							if (num8 == 0)
							{
								int num10 = this.int_16[num7];
								this.int_16[num7] = this.int_16[num6];
								this.int_16[num6] = num10;
								num6--;
								num7--;
							}
							else
							{
								if (num8 < 0)
								{
									break;
								}
								num7--;
							}
						}
						if (j > num7)
						{
							break;
						}
						int num11 = this.int_16[j];
						this.int_16[j] = this.int_16[num7];
						this.int_16[num7] = num11;
						j++;
						num7--;
					}
					if (num6 < num5)
					{
						array[i].int_0 = num;
						array[i].int_1 = num2;
						array[i].int_2 = num3 + 1;
						i++;
					}
					else
					{
						int num8 = (num5 - num < j - num5) ? (num5 - num) : (j - num5);
						this.method_15(num, j - num8, num8);
						int num12 = (num2 - num6 < num6 - num7) ? (num2 - num6) : (num6 - num7);
						this.method_15(j, num2 - num12 + 1, num12);
						num8 = num + j - num5 - 1;
						num12 = num2 - (num6 - num7) + 1;
						array[i].int_0 = num;
						array[i].int_1 = num8;
						array[i].int_2 = num3;
						i++;
						array[i].int_0 = num8 + 1;
						array[i].int_1 = num12 - 1;
						array[i].int_2 = num3 + 1;
						i++;
						array[i].int_0 = num12;
						array[i].int_1 = num2;
						array[i].int_2 = num3;
						i++;
					}
				}
				else
				{
					this.method_14(num, num2, num3);
					if (this.int_21 > this.int_22 && this.bool_3)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06002064 RID: 8292 RVA: 0x0006C404 File Offset: 0x0006A604
		private void method_17()
		{
			int[] array = new int[256];
			int[] array2 = new int[256];
			bool[] array3 = new bool[256];
			for (int i = 0; i < Class320.int_10; i++)
			{
				this.byte_0[this.int_8 + i + 2] = this.byte_0[i % (this.int_8 + 1) + 1];
			}
			for (int i = 0; i <= this.int_8 + Class320.int_10; i++)
			{
				this.int_15[i] = 0;
			}
			this.byte_0[0] = this.byte_0[this.int_8 + 1];
			if (this.int_8 < 4000)
			{
				for (int i = 0; i <= this.int_8; i++)
				{
					this.int_16[i] = i;
				}
				this.bool_3 = false;
				this.int_22 = 0;
				this.int_21 = 0;
				this.method_14(0, this.int_8, 0);
				return;
			}
			int num = 0;
			for (int i = 0; i <= 255; i++)
			{
				array3[i] = false;
			}
			for (int i = 0; i <= 65536; i++)
			{
				this.int_17[i] = 0;
			}
			int num2 = (int)this.byte_0[0];
			for (int i = 0; i <= this.int_8; i++)
			{
				int num3 = (int)this.byte_0[i + 1];
				this.int_17[(num2 << 8) + num3]++;
				num2 = num3;
			}
			for (int i = 1; i <= 65536; i++)
			{
				this.int_17[i] += this.int_17[i - 1];
			}
			num2 = (int)this.byte_0[1];
			int j;
			for (int i = 0; i < this.int_8; i++)
			{
				int num3 = (int)this.byte_0[i + 2];
				j = (num2 << 8) + num3;
				num2 = num3;
				this.int_17[j]--;
				this.int_16[this.int_17[j]] = i;
			}
			j = ((int)this.byte_0[this.int_8 + 1] << 8) + (int)this.byte_0[1];
			this.int_17[j]--;
			this.int_16[this.int_17[j]] = this.int_8;
			for (int i = 0; i <= 255; i++)
			{
				array[i] = i;
			}
			int num4 = 1;
			do
			{
				num4 = 3 * num4 + 1;
			}
			while (num4 <= 256);
			do
			{
				num4 /= 3;
				for (int i = num4; i <= 255; i++)
				{
					int num5 = array[i];
					j = i;
					while (this.int_17[array[j - num4] + 1 << 8] - this.int_17[array[j - num4] << 8] > this.int_17[num5 + 1 << 8] - this.int_17[num5 << 8])
					{
						array[j] = array[j - num4];
						j -= num4;
						if (j <= num4 - 1)
						{
							break;
						}
					}
					array[j] = num5;
				}
			}
			while (num4 != 1);
			for (int i = 0; i <= 255; i++)
			{
				int num6 = array[i];
				for (j = 0; j <= 255; j++)
				{
					int num7 = (num6 << 8) + j;
					if ((this.int_17[num7] & 2097152) != 2097152)
					{
						int num8 = this.int_17[num7] & -2097153;
						int num9 = (this.int_17[num7 + 1] & -2097153) - 1;
						if (num9 > num8)
						{
							this.method_16(num8, num9, 2);
							num += num9 - num8 + 1;
							if (this.int_21 > this.int_22 && this.bool_3)
							{
								return;
							}
						}
						this.int_17[num7] |= 2097152;
					}
				}
				array3[num6] = true;
				if (i < 255)
				{
					int num10 = this.int_17[num6 << 8] & -2097153;
					int num11 = (this.int_17[num6 + 1 << 8] & -2097153) - num10;
					int num12 = 0;
					while (num11 >> num12 > 65534)
					{
						num12++;
					}
					for (j = 0; j < num11; j++)
					{
						int num13 = this.int_16[num10 + j];
						int num14 = j >> num12;
						this.int_15[num13] = num14;
						if (num13 < Class320.int_10)
						{
							this.int_15[num13 + this.int_8 + 1] = num14;
						}
					}
					if (num11 - 1 >> num12 > 65535)
					{
						Stream2.smethod_0();
					}
				}
				for (j = 0; j <= 255; j++)
				{
					array2[j] = (this.int_17[(j << 8) + num6] & -2097153);
				}
				for (j = (this.int_17[num6 << 8] & -2097153); j < (this.int_17[num6 + 1 << 8] & -2097153); j++)
				{
					num2 = (int)this.byte_0[this.int_16[j]];
					if (!array3[num2])
					{
						this.int_16[array2[num2]] = ((this.int_16[j] == 0) ? this.int_8 : (this.int_16[j] - 1));
						array2[num2]++;
					}
				}
				for (j = 0; j <= 255; j++)
				{
					this.int_17[(j << 8) + num6] |= 2097152;
				}
			}
		}

		// Token: 0x06002065 RID: 8293 RVA: 0x0006C968 File Offset: 0x0006AB68
		private void method_18()
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < 256; i++)
			{
				this.bool_2[i] = false;
			}
			for (int i = 0; i <= this.int_8; i++)
			{
				if (num == 0)
				{
					num = Class320.int_0[num2];
					num2++;
					if (num2 == 512)
					{
						num2 = 0;
					}
				}
				num--;
				byte[] array = this.byte_0;
				int num3 = i + 1;
				array[num3] ^= ((num == 1) ? 1 : 0);
				byte[] array2 = this.byte_0;
				int num4 = i + 1;
				array2[num4] &= byte.MaxValue;
				this.bool_2[(int)this.byte_0[i + 1]] = true;
			}
		}

		// Token: 0x06002066 RID: 8294 RVA: 0x0006CA18 File Offset: 0x0006AC18
		private void method_19()
		{
			this.int_22 = this.int_20 * this.int_8;
			this.int_21 = 0;
			this.bool_1 = false;
			this.bool_3 = true;
			this.method_17();
			if (this.int_21 > this.int_22 && this.bool_3)
			{
				this.method_18();
				this.int_21 = 0;
				this.int_22 = 0;
				this.bool_1 = true;
				this.bool_3 = false;
				this.method_17();
			}
			this.int_9 = -1;
			for (int i = 0; i <= this.int_8; i++)
			{
				if (this.int_16[i] == 0)
				{
					this.int_9 = i;
					IL_97:
					if (this.int_9 == -1)
					{
						Stream2.smethod_0();
					}
					return;
				}
			}
			goto IL_97;
		}

		// Token: 0x06002067 RID: 8295 RVA: 0x0006CACC File Offset: 0x0006ACCC
		private bool method_20(int i1, int i2)
		{
			byte b = this.byte_0[i1 + 1];
			byte b2 = this.byte_0[i2 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			i1++;
			i2++;
			b = this.byte_0[i1 + 1];
			b2 = this.byte_0[i2 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			i1++;
			i2++;
			b = this.byte_0[i1 + 1];
			b2 = this.byte_0[i2 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			i1++;
			i2++;
			b = this.byte_0[i1 + 1];
			b2 = this.byte_0[i2 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			i1++;
			i2++;
			b = this.byte_0[i1 + 1];
			b2 = this.byte_0[i2 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			i1++;
			i2++;
			b = this.byte_0[i1 + 1];
			b2 = this.byte_0[i2 + 1];
			if (b != b2)
			{
				return b > b2;
			}
			i1++;
			i2++;
			int num = this.int_8 + 1;
			int num2;
			int num3;
			for (;;)
			{
				b = this.byte_0[i1 + 1];
				b2 = this.byte_0[i2 + 1];
				if (b != b2)
				{
					goto Block_16;
				}
				num2 = this.int_15[i1];
				num3 = this.int_15[i2];
				if (num2 != num3)
				{
					break;
				}
				i1++;
				i2++;
				b = this.byte_0[i1 + 1];
				b2 = this.byte_0[i2 + 1];
				if (b != b2)
				{
					goto Block_8;
				}
				num2 = this.int_15[i1];
				num3 = this.int_15[i2];
				if (num2 != num3)
				{
					goto Block_9;
				}
				i1++;
				i2++;
				b = this.byte_0[i1 + 1];
				b2 = this.byte_0[i2 + 1];
				if (b != b2)
				{
					goto Block_10;
				}
				num2 = this.int_15[i1];
				num3 = this.int_15[i2];
				if (num2 != num3)
				{
					goto Block_11;
				}
				i1++;
				i2++;
				b = this.byte_0[i1 + 1];
				b2 = this.byte_0[i2 + 1];
				if (b != b2)
				{
					goto Block_12;
				}
				num2 = this.int_15[i1];
				num3 = this.int_15[i2];
				if (num2 != num3)
				{
					goto Block_13;
				}
				i1++;
				i2++;
				if (i1 > this.int_8)
				{
					i1 -= this.int_8;
					i1--;
				}
				if (i2 > this.int_8)
				{
					i2 -= this.int_8;
					i2--;
				}
				num -= 4;
				this.int_21++;
				if (num < 0)
				{
					return false;
				}
			}
			return num2 > num3;
			Block_8:
			return b > b2;
			Block_9:
			return num2 > num3;
			Block_10:
			return b > b2;
			Block_11:
			return num2 > num3;
			Block_12:
			return b > b2;
			Block_13:
			return num2 > num3;
			Block_16:
			return b > b2;
		}

		// Token: 0x06002068 RID: 8296 RVA: 0x0006CD68 File Offset: 0x0006AF68
		private void method_21()
		{
			int num = Class320.int_1 * this.int_10;
			this.byte_0 = new byte[num + 1 + Class320.int_10];
			this.int_15 = new int[num + Class320.int_10];
			this.int_16 = new int[num];
			this.int_17 = new int[65537];
			if (this.byte_0 == null || this.int_15 == null || this.int_16 == null)
			{
			}
			this.short_0 = new short[2 * num];
		}

		// Token: 0x06002069 RID: 8297 RVA: 0x0006CDEC File Offset: 0x0006AFEC
		private void method_22()
		{
			char[] array = new char[256];
			this.method_0();
			int num = this.int_14 + 1;
			for (int i = 0; i <= num; i++)
			{
				this.int_19[i] = 0;
			}
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < this.int_14; i++)
			{
				array[i] = (char)i;
			}
			for (int i = 0; i <= this.int_8; i++)
			{
				char c = this.char_1[(int)this.byte_0[this.int_16[i]]];
				int num4 = 0;
				char c2 = array[0];
				while (c != c2)
				{
					num4++;
					char c3 = c2;
					c2 = array[num4];
					array[num4] = c3;
				}
				array[0] = c2;
				if (num4 == 0)
				{
					num3++;
				}
				else
				{
					if (num3 > 0)
					{
						num3--;
						for (;;)
						{
							switch (num3 % 2)
							{
							case 0:
								this.short_0[num2] = (short)Class320.int_4;
								num2++;
								this.int_19[Class320.int_4]++;
								break;
							case 1:
								this.short_0[num2] = (short)Class320.int_5;
								num2++;
								this.int_19[Class320.int_5]++;
								break;
							}
							if (num3 < 2)
							{
								break;
							}
							num3 = (num3 - 2) / 2;
						}
						num3 = 0;
					}
					this.short_0[num2] = (short)(num4 + 1);
					num2++;
					this.int_19[num4 + 1]++;
				}
			}
			if (num3 > 0)
			{
				num3--;
				for (;;)
				{
					switch (num3 % 2)
					{
					case 0:
						this.short_0[num2] = (short)Class320.int_4;
						num2++;
						this.int_19[Class320.int_4]++;
						break;
					case 1:
						this.short_0[num2] = (short)Class320.int_5;
						num2++;
						this.int_19[Class320.int_5]++;
						break;
					}
					if (num3 < 2)
					{
						break;
					}
					num3 = (num3 - 2) / 2;
				}
			}
			this.short_0[num2] = (short)num;
			num2++;
			this.int_19[num]++;
			this.int_18 = num2;
		}

		// Token: 0x0600206A RID: 8298 RVA: 0x0000D297 File Offset: 0x0000B497
		private static void smethod_0()
		{
			throw new BZip2Exception("BZip2 output stream panic");
		}

		// Token: 0x0600206B RID: 8299 RVA: 0x0006D044 File Offset: 0x0006B244
		private static void smethod_1(char[] len, int[] freq, int alphaSize, int maxLen)
		{
			int[] array = new int[Class320.int_2 + 2];
			int[] array2 = new int[Class320.int_2 * 2];
			int[] array3 = new int[Class320.int_2 * 2];
			for (int i = 0; i < alphaSize; i++)
			{
				array2[i + 1] = ((freq[i] == 0) ? 1 : freq[i]) << 8;
			}
			for (;;)
			{
				int num = alphaSize;
				int j = 0;
				array[0] = 0;
				array2[0] = 0;
				array3[0] = -2;
				for (int k = 1; k <= alphaSize; k++)
				{
					array3[k] = -1;
					j++;
					array[j] = k;
					int num2 = j;
					int num3 = array[num2];
					while (array2[num3] < array2[array[num2 >> 1]])
					{
						array[num2] = array[num2 >> 1];
						num2 >>= 1;
					}
					array[num2] = num3;
				}
				if (j >= Class320.int_2 + 2)
				{
					Stream2.smethod_0();
				}
				while (j > 1)
				{
					int num4 = array[1];
					array[1] = array[j];
					j--;
					int num5 = 1;
					int num6 = array[1];
					for (;;)
					{
						int num7 = num5 << 1;
						if (num7 > j)
						{
							break;
						}
						if (num7 < j && array2[array[num7 + 1]] < array2[array[num7]])
						{
							num7++;
						}
						if (array2[num6] < array2[array[num7]])
						{
							break;
						}
						array[num5] = array[num7];
						num5 = num7;
					}
					array[num5] = num6;
					int num8 = array[1];
					array[1] = array[j];
					j--;
					num5 = 1;
					num6 = array[1];
					for (;;)
					{
						int num7 = num5 << 1;
						if (num7 > j)
						{
							break;
						}
						if (num7 < j && array2[array[num7 + 1]] < array2[array[num7]])
						{
							num7++;
						}
						if (array2[num6] < array2[array[num7]])
						{
							break;
						}
						array[num5] = array[num7];
						num5 = num7;
					}
					array[num5] = num6;
					num++;
					array3[num4] = (array3[num8] = num);
					array2[num] = ((int)(((long)array2[num4] & 4294967040L) + ((long)array2[num8] & 4294967040L)) | 1 + (((array2[num4] & 255) > (array2[num8] & 255)) ? (array2[num4] & 255) : (array2[num8] & 255)));
					array3[num] = -1;
					j++;
					array[j] = num;
					num5 = j;
					num6 = array[num5];
					while (array2[num6] < array2[array[num5 >> 1]])
					{
						array[num5] = array[num5 >> 1];
						num5 >>= 1;
					}
					array[num5] = num6;
				}
				if (num >= Class320.int_2 * 2)
				{
					Stream2.smethod_0();
				}
				bool flag = false;
				for (int l = 1; l <= alphaSize; l++)
				{
					int num9 = 0;
					int num10 = l;
					while (array3[num10] >= 0)
					{
						num10 = array3[num10];
						num9++;
					}
					len[l - 1] = (char)num9;
					if (num9 > maxLen)
					{
						flag = true;
					}
				}
				if (!flag)
				{
					break;
				}
				for (int m = 1; m < alphaSize; m++)
				{
					int num9 = array2[m] >> 8;
					num9 = 1 + num9 / 2;
					array2[m] = num9 << 8;
				}
			}
		}

		// Token: 0x0600206C RID: 8300 RVA: 0x0006D334 File Offset: 0x0006B534
		private static void smethod_2(int[] code, char[] length, int minLen, int maxLen, int alphaSize)
		{
			int num = 0;
			for (int i = minLen; i <= maxLen; i++)
			{
				for (int j = 0; j < alphaSize; j++)
				{
					if ((int)length[j] == i)
					{
						code[j] = num;
						num++;
					}
				}
				num <<= 1;
			}
		}

		// Token: 0x0600206D RID: 8301 RVA: 0x0006D370 File Offset: 0x0006B570
		private static byte smethod_3(byte a, byte b, byte c)
		{
			if (a > b)
			{
				byte b2 = a;
				a = b;
				b = b2;
			}
			if (b > c)
			{
				byte b2 = b;
				b = c;
				c = b2;
			}
			if (a > b)
			{
				b = a;
			}
			return b;
		}

		// Token: 0x04000D04 RID: 3332
		private const int int_0 = 2097152;

		// Token: 0x04000D05 RID: 3333
		private const int int_1 = -2097153;

		// Token: 0x04000D06 RID: 3334
		private const int int_2 = 15;

		// Token: 0x04000D07 RID: 3335
		private const int int_3 = 0;

		// Token: 0x04000D08 RID: 3336
		private const int int_4 = 20;

		// Token: 0x04000D09 RID: 3337
		private const int int_5 = 10;

		// Token: 0x04000D0A RID: 3338
		private const int int_6 = 1000;

		// Token: 0x04000D0B RID: 3339
		private readonly int[] int_7 = new int[]
		{
			1,
			4,
			13,
			40,
			121,
			364,
			1093,
			3280,
			9841,
			29524,
			88573,
			265720,
			797161,
			2391484
		};

		// Token: 0x04000D0C RID: 3340
		private bool bool_0 = true;

		// Token: 0x04000D0D RID: 3341
		private int int_8;

		// Token: 0x04000D0E RID: 3342
		private int int_9;

		// Token: 0x04000D0F RID: 3343
		private int int_10;

		// Token: 0x04000D10 RID: 3344
		private bool bool_1;

		// Token: 0x04000D11 RID: 3345
		private int int_11;

		// Token: 0x04000D12 RID: 3346
		private int int_12;

		// Token: 0x04000D13 RID: 3347
		private int int_13;

		// Token: 0x04000D14 RID: 3348
		private Interface23 interface23_0 = new Class475();

		// Token: 0x04000D15 RID: 3349
		private bool[] bool_2 = new bool[256];

		// Token: 0x04000D16 RID: 3350
		private int int_14;

		// Token: 0x04000D17 RID: 3351
		private char[] char_0 = new char[256];

		// Token: 0x04000D18 RID: 3352
		private char[] char_1 = new char[256];

		// Token: 0x04000D19 RID: 3353
		private char[] char_2 = new char[Class320.int_9];

		// Token: 0x04000D1A RID: 3354
		private char[] char_3 = new char[Class320.int_9];

		// Token: 0x04000D1B RID: 3355
		private byte[] byte_0;

		// Token: 0x04000D1C RID: 3356
		private int[] int_15;

		// Token: 0x04000D1D RID: 3357
		private int[] int_16;

		// Token: 0x04000D1E RID: 3358
		private short[] short_0;

		// Token: 0x04000D1F RID: 3359
		private int[] int_17;

		// Token: 0x04000D20 RID: 3360
		private int int_18;

		// Token: 0x04000D21 RID: 3361
		private int[] int_19 = new int[Class320.int_2];

		// Token: 0x04000D22 RID: 3362
		private int int_20;

		// Token: 0x04000D23 RID: 3363
		private int int_21;

		// Token: 0x04000D24 RID: 3364
		private int int_22;

		// Token: 0x04000D25 RID: 3365
		private bool bool_3;

		// Token: 0x04000D26 RID: 3366
		private int int_23;

		// Token: 0x04000D27 RID: 3367
		private int int_24 = -1;

		// Token: 0x04000D28 RID: 3368
		private int int_25;

		// Token: 0x04000D29 RID: 3369
		private uint uint_0;

		// Token: 0x04000D2A RID: 3370
		private uint uint_1;

		// Token: 0x04000D2B RID: 3371
		private int int_26;

		// Token: 0x04000D2C RID: 3372
		private Stream stream_0;

		// Token: 0x04000D2D RID: 3373
		private bool bool_4;

		// Token: 0x02000342 RID: 834
		private struct Struct30
		{
			// Token: 0x04000D2E RID: 3374
			public int int_0;

			// Token: 0x04000D2F RID: 3375
			public int int_1;

			// Token: 0x04000D30 RID: 3376
			public int int_2;
		}
	}
}
