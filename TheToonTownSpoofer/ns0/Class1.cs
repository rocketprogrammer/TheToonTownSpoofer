using System;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;

namespace ns0
{
	// Token: 0x02000004 RID: 4
	internal sealed class Class1
	{
		// Token: 0x06000001 RID: 1 RVA: 0x000163B0 File Offset: 0x000145B0
		public static byte[] smethod_0(byte[] byte_0)
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			if (callingAssembly != Assembly.GetExecutingAssembly())
			{
				byte[] array = new byte[]
				{
					0,
					36,
					0,
					0,
					4,
					128,
					0,
					0,
					148,
					0,
					0,
					0,
					6,
					2,
					0,
					0,
					0,
					36,
					0,
					0,
					82,
					83,
					65,
					49,
					0,
					4,
					0,
					0,
					1,
					0,
					1,
					0,
					129,
					216,
					197,
					192,
					165,
					98,
					40,
					194,
					113,
					31,
					242,
					73,
					172,
					217,
					46,
					43,
					188,
					40,
					117,
					218,
					218,
					5,
					206,
					122,
					32,
					127,
					177,
					200,
					166,
					240,
					27,
					206,
					144,
					253,
					0,
					189,
					93,
					129,
					177,
					25,
					223,
					229,
					21,
					192,
					175,
					63,
					200,
					26,
					76,
					152,
					19,
					35,
					184,
					248,
					168,
					155,
					203,
					239,
					248,
					161,
					92,
					125,
					248,
					29,
					233,
					31,
					5,
					150,
					127,
					24,
					189,
					168,
					135,
					89,
					217,
					184,
					138,
					170,
					78,
					233,
					99,
					230,
					196,
					222,
					74,
					79,
					203,
					229,
					97,
					109,
					51,
					11,
					108,
					118,
					160,
					27,
					124,
					115,
					38,
					224,
					24,
					220,
					195,
					77,
					78,
					222,
					114,
					237,
					155,
					226,
					191,
					165,
					51,
					5,
					169,
					17,
					0,
					228,
					126,
					151,
					193,
					81,
					70,
					22,
					164,
					105,
					128,
					165
				};
				byte[] publicKey = callingAssembly.GetName().GetPublicKey();
				if (publicKey == null)
				{
					return null;
				}
				if (publicKey.Length != 160)
				{
					return null;
				}
				for (int i = 0; i < 160; i++)
				{
					if (publicKey[i] != array[i])
					{
						return null;
					}
				}
			}
			Class1.Stream0 stream = new Class1.Stream0(byte_0);
			byte[] array2 = new byte[0];
			int num = stream.method_1();
			if (num == 67324752)
			{
				short num2 = (short)stream.method_0();
				int num3 = stream.method_0();
				int num4 = stream.method_0();
				checked
				{
					if (num == 67324752 && num2 == 20 && num3 == 0)
					{
						if (num4 == 8)
						{
							stream.method_1();
							stream.method_1();
							stream.method_1();
							int num5 = stream.method_1();
							int num6 = stream.method_0();
							int num7 = stream.method_0();
							if (num6 > 0)
							{
								byte[] buffer = new byte[(uint)num6];
								stream.Read(buffer, 0, num6);
							}
							if (num7 > 0)
							{
								byte[] buffer2 = new byte[(uint)num7];
								stream.Read(buffer2, 0, num7);
							}
							byte[] array3 = new byte[(uint)(unchecked(stream.Length - stream.Position))];
							stream.Read(array3, 0, array3.Length);
							Class1.Class2 @class = new Class1.Class2(array3);
							array2 = new byte[(uint)num5];
							@class.method_2(array2, 0, array2.Length);
							goto IL_287;
						}
					}
					throw new FormatException("Wrong Header Signature");
				}
			}
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = stream.method_1();
				array2 = new byte[checked((uint)num9)];
				int num11;
				for (int j = 0; j < num9; j += num11)
				{
					int num10 = stream.method_1();
					num11 = stream.method_1();
					byte[] array4 = new byte[checked((uint)num10)];
					stream.Read(array4, 0, array4.Length);
					Class1.Class2 class2 = new Class1.Class2(array4);
					class2.method_2(array2, j, num11);
				}
			}
			if (num8 == 2)
			{
				DESCryptoServiceProvider descryptoServiceProvider = new DESCryptoServiceProvider();
				descryptoServiceProvider.Key = new byte[]
				{
					248,
					67,
					52,
					byte.MaxValue,
					86,
					31,
					177,
					110
				};
				descryptoServiceProvider.IV = new byte[]
				{
					248,
					27,
					11,
					69,
					66,
					182,
					32,
					56
				};
				ICryptoTransform cryptoTransform = descryptoServiceProvider.CreateDecryptor();
				byte[] byte_ = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				descryptoServiceProvider.Clear();
				array2 = Class1.smethod_0(byte_);
			}
			IL_287:
			stream.Close();
			return array2;
		}

		// Token: 0x02000005 RID: 5
		internal sealed class Class2
		{
			// Token: 0x06000002 RID: 2 RVA: 0x000032B4 File Offset: 0x000014B4
			public Class2(byte[] byte_0)
			{
				this.class3_0 = new Class1.Class3();
				this.class4_0 = new Class1.Class4();
				this.int_4 = 2;
				this.class3_0.method_7(byte_0, 0, byte_0.Length);
			}

			// Token: 0x06000003 RID: 3 RVA: 0x00016650 File Offset: 0x00014850
			private bool method_0()
			{
				int i = this.class4_0.method_4();
				while (i >= 258)
				{
					int num;
					switch (this.int_4)
					{
					case 7:
						while (((num = this.class5_0.method_1(this.class3_0)) & -256) == 0)
						{
							this.class4_0.method_0(num);
							if (--i < 258)
							{
								return true;
							}
						}
						if (num >= 257)
						{
							this.int_6 = Class1.Class2.int_0[num - 257];
							this.int_5 = Class1.Class2.int_1[num - 257];
							goto IL_9E;
						}
						if (num < 0)
						{
							return false;
						}
						this.class5_1 = null;
						this.class5_0 = null;
						this.int_4 = 2;
						return true;
					case 8:
						goto IL_9E;
					case 9:
						goto IL_EE;
					case 10:
						break;
					default:
						continue;
					}
					IL_121:
					if (this.int_5 > 0)
					{
						this.int_4 = 10;
						int num2 = this.class3_0.method_0(this.int_5);
						if (num2 < 0)
						{
							return false;
						}
						this.class3_0.method_1(this.int_5);
						this.int_7 += num2;
					}
					this.class4_0.method_2(this.int_6, this.int_7);
					i -= this.int_6;
					this.int_4 = 7;
					continue;
					IL_EE:
					num = this.class5_1.method_1(this.class3_0);
					if (num >= 0)
					{
						this.int_7 = Class1.Class2.int_2[num];
						this.int_5 = Class1.Class2.int_3[num];
						goto IL_121;
					}
					return false;
					IL_9E:
					if (this.int_5 > 0)
					{
						this.int_4 = 8;
						int num3 = this.class3_0.method_0(this.int_5);
						if (num3 < 0)
						{
							return false;
						}
						this.class3_0.method_1(this.int_5);
						this.int_6 += num3;
					}
					this.int_4 = 9;
					goto IL_EE;
				}
				return true;
			}

			// Token: 0x06000004 RID: 4 RVA: 0x0001681C File Offset: 0x00014A1C
			private bool method_1()
			{
				switch (this.int_4)
				{
				case 2:
				{
					if (this.bool_0)
					{
						this.int_4 = 12;
						return false;
					}
					int num = this.class3_0.method_0(3);
					if (num < 0)
					{
						return false;
					}
					this.class3_0.method_1(3);
					if ((num & 1) != 0)
					{
						this.bool_0 = true;
					}
					switch (num >> 1)
					{
					case 0:
						this.class3_0.method_4();
						this.int_4 = 3;
						break;
					case 1:
						this.class5_0 = Class1.Class5.class5_0;
						this.class5_1 = Class1.Class5.class5_1;
						this.int_4 = 7;
						break;
					case 2:
						this.class6_0 = new Class1.Class6();
						this.int_4 = 6;
						break;
					}
					return true;
				}
				case 3:
					if ((this.int_8 = this.class3_0.method_0(16)) < 0)
					{
						return false;
					}
					this.class3_0.method_1(16);
					this.int_4 = 4;
					break;
				case 4:
					break;
				case 5:
					goto IL_133;
				case 6:
					if (!this.class6_0.method_0(this.class3_0))
					{
						return false;
					}
					this.class5_0 = this.class6_0.method_1();
					this.class5_1 = this.class6_0.method_2();
					this.int_4 = 7;
					goto IL_1B7;
				case 7:
				case 8:
				case 9:
				case 10:
					goto IL_1B7;
				case 11:
					return false;
				case 12:
					return false;
				default:
					return false;
				}
				int num2 = this.class3_0.method_0(16);
				if (num2 < 0)
				{
					return false;
				}
				this.class3_0.method_1(16);
				this.int_4 = 5;
				IL_133:
				int num3 = this.class4_0.method_3(this.class3_0, this.int_8);
				this.int_8 -= num3;
				if (this.int_8 == 0)
				{
					this.int_4 = 2;
					return true;
				}
				return !this.class3_0.method_5();
				IL_1B7:
				return this.method_0();
			}

			// Token: 0x06000005 RID: 5 RVA: 0x000169EC File Offset: 0x00014BEC
			public int method_2(byte[] byte_0, int int_9, int int_10)
			{
				int num = 0;
				for (;;)
				{
					if (this.int_4 != 11)
					{
						int num2 = this.class4_0.method_6(byte_0, int_9, int_10);
						int_9 += num2;
						num += num2;
						int_10 -= num2;
						if (int_10 == 0)
						{
							return num;
						}
					}
					if (!this.method_1())
					{
						if (this.class4_0.method_5() <= 0)
						{
							break;
						}
						if (this.int_4 == 11)
						{
							break;
						}
					}
				}
				return num;
			}

			// Token: 0x04000002 RID: 2
			private static int[] int_0 = new int[]
			{
				3,
				4,
				5,
				6,
				7,
				8,
				9,
				10,
				11,
				13,
				15,
				17,
				19,
				23,
				27,
				31,
				35,
				43,
				51,
				59,
				67,
				83,
				99,
				115,
				131,
				163,
				195,
				227,
				258
			};

			// Token: 0x04000003 RID: 3
			private static int[] int_1 = new int[]
			{
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				0,
				1,
				1,
				1,
				1,
				2,
				2,
				2,
				2,
				3,
				3,
				3,
				3,
				4,
				4,
				4,
				4,
				5,
				5,
				5,
				5,
				0
			};

			// Token: 0x04000004 RID: 4
			private static int[] int_2 = new int[]
			{
				1,
				2,
				3,
				4,
				5,
				7,
				9,
				13,
				17,
				25,
				33,
				49,
				65,
				97,
				129,
				193,
				257,
				385,
				513,
				769,
				1025,
				1537,
				2049,
				3073,
				4097,
				6145,
				8193,
				12289,
				16385,
				24577
			};

			// Token: 0x04000005 RID: 5
			private static int[] int_3 = new int[]
			{
				0,
				0,
				0,
				0,
				1,
				1,
				2,
				2,
				3,
				3,
				4,
				4,
				5,
				5,
				6,
				6,
				7,
				7,
				8,
				8,
				9,
				9,
				10,
				10,
				11,
				11,
				12,
				12,
				13,
				13
			};

			// Token: 0x04000006 RID: 6
			private int int_4;

			// Token: 0x04000007 RID: 7
			private int int_5;

			// Token: 0x04000008 RID: 8
			private int int_6;

			// Token: 0x04000009 RID: 9
			private int int_7;

			// Token: 0x0400000A RID: 10
			private int int_8;

			// Token: 0x0400000B RID: 11
			private bool bool_0;

			// Token: 0x0400000C RID: 12
			private Class1.Class3 class3_0;

			// Token: 0x0400000D RID: 13
			private Class1.Class4 class4_0;

			// Token: 0x0400000E RID: 14
			private Class1.Class6 class6_0;

			// Token: 0x0400000F RID: 15
			private Class1.Class5 class5_0;

			// Token: 0x04000010 RID: 16
			private Class1.Class5 class5_1;
		}

		// Token: 0x02000006 RID: 6
		internal sealed class Class3
		{
			// Token: 0x06000007 RID: 7 RVA: 0x00016ABC File Offset: 0x00014CBC
			public int method_0(int int_3)
			{
				if (this.int_2 < int_3)
				{
					if (this.int_0 == this.int_1)
					{
						return -1;
					}
					this.uint_0 |= (uint)((uint)((int)(this.byte_0[this.int_0++] & byte.MaxValue) | (int)(this.byte_0[this.int_0++] & byte.MaxValue) << 8) << this.int_2);
					this.int_2 += 16;
				}
				return (int)((ulong)this.uint_0 & (ulong)((long)((1 << int_3) - 1)));
			}

			// Token: 0x06000008 RID: 8 RVA: 0x000032E9 File Offset: 0x000014E9
			public void method_1(int int_3)
			{
				this.uint_0 >>= int_3;
				this.int_2 -= int_3;
			}

			// Token: 0x06000009 RID: 9 RVA: 0x0000330A File Offset: 0x0000150A
			public int method_2()
			{
				return this.int_2;
			}

			// Token: 0x0600000A RID: 10 RVA: 0x00003312 File Offset: 0x00001512
			public int method_3()
			{
				return this.int_1 - this.int_0 + (this.int_2 >> 3);
			}

			// Token: 0x0600000B RID: 11 RVA: 0x0000332A File Offset: 0x0000152A
			public void method_4()
			{
				this.uint_0 >>= (this.int_2 & 7);
				this.int_2 &= -8;
			}

			// Token: 0x0600000C RID: 12 RVA: 0x00003353 File Offset: 0x00001553
			public bool method_5()
			{
				return this.int_0 == this.int_1;
			}

			// Token: 0x0600000D RID: 13 RVA: 0x00016B5C File Offset: 0x00014D5C
			public int method_6(byte[] byte_1, int int_3, int int_4)
			{
				int num = 0;
				while (this.int_2 > 0 && int_4 > 0)
				{
					byte_1[int_3++] = (byte)this.uint_0;
					this.uint_0 >>= 8;
					this.int_2 -= 8;
					int_4--;
					num++;
				}
				if (int_4 == 0)
				{
					return num;
				}
				int num2 = this.int_1 - this.int_0;
				if (int_4 > num2)
				{
					int_4 = num2;
				}
				Array.Copy(this.byte_0, this.int_0, byte_1, int_3, int_4);
				this.int_0 += int_4;
				if ((this.int_0 - this.int_1 & 1) != 0)
				{
					this.uint_0 = (uint)(this.byte_0[this.int_0++] & byte.MaxValue);
					this.int_2 = 8;
				}
				return num + int_4;
			}

			// Token: 0x0600000F RID: 15 RVA: 0x00016C2C File Offset: 0x00014E2C
			public void method_7(byte[] byte_1, int int_3, int int_4)
			{
				if (this.int_0 < this.int_1)
				{
					throw new InvalidOperationException();
				}
				int num = int_3 + int_4;
				if (0 <= int_3 && int_3 <= num && num <= byte_1.Length)
				{
					if ((int_4 & 1) != 0)
					{
						this.uint_0 |= (uint)((uint)(byte_1[int_3++] & byte.MaxValue) << this.int_2);
						this.int_2 += 8;
					}
					this.byte_0 = byte_1;
					this.int_0 = int_3;
					this.int_1 = num;
					return;
				}
				throw new ArgumentOutOfRangeException();
			}

			// Token: 0x04000011 RID: 17
			private byte[] byte_0;

			// Token: 0x04000012 RID: 18
			private int int_0 = 0;

			// Token: 0x04000013 RID: 19
			private int int_1 = 0;

			// Token: 0x04000014 RID: 20
			private uint uint_0 = 0U;

			// Token: 0x04000015 RID: 21
			private int int_2 = 0;
		}

		// Token: 0x02000007 RID: 7
		internal sealed class Class4
		{
			// Token: 0x06000010 RID: 16 RVA: 0x00016CB4 File Offset: 0x00014EB4
			public void method_0(int int_4)
			{
				if (this.int_3++ == Class1.Class4.int_0)
				{
					throw new InvalidOperationException();
				}
				this.byte_0[this.int_2++] = (byte)int_4;
				this.int_2 &= Class1.Class4.int_1;
			}

			// Token: 0x06000011 RID: 17 RVA: 0x00016D0C File Offset: 0x00014F0C
			private void method_1(int int_4, int int_5, int int_6)
			{
				while (int_5-- > 0)
				{
					this.byte_0[this.int_2++] = this.byte_0[int_4++];
					this.int_2 &= Class1.Class4.int_1;
					int_4 &= Class1.Class4.int_1;
				}
			}

			// Token: 0x06000012 RID: 18 RVA: 0x00016D68 File Offset: 0x00014F68
			public void method_2(int int_4, int int_5)
			{
				if ((this.int_3 += int_4) > Class1.Class4.int_0)
				{
					throw new InvalidOperationException();
				}
				int num = this.int_2 - int_5 & Class1.Class4.int_1;
				int num2 = Class1.Class4.int_0 - int_4;
				if (num > num2 || this.int_2 >= num2)
				{
					this.method_1(num, int_4, int_5);
					return;
				}
				if (int_4 <= int_5)
				{
					Array.Copy(this.byte_0, num, this.byte_0, this.int_2, int_4);
					this.int_2 += int_4;
					return;
				}
				while (int_4-- > 0)
				{
					this.byte_0[this.int_2++] = this.byte_0[num++];
				}
			}

			// Token: 0x06000013 RID: 19 RVA: 0x00016E1C File Offset: 0x0001501C
			public int method_3(Class1.Class3 class3_0, int int_4)
			{
				int_4 = Math.Min(Math.Min(int_4, Class1.Class4.int_0 - this.int_3), class3_0.method_3());
				int num = Class1.Class4.int_0 - this.int_2;
				int num2;
				if (int_4 > num)
				{
					num2 = class3_0.method_6(this.byte_0, this.int_2, num);
					if (num2 == num)
					{
						num2 += class3_0.method_6(this.byte_0, 0, int_4 - num);
					}
				}
				else
				{
					num2 = class3_0.method_6(this.byte_0, this.int_2, int_4);
				}
				this.int_2 = (this.int_2 + num2 & Class1.Class4.int_1);
				this.int_3 += num2;
				return num2;
			}

			// Token: 0x06000014 RID: 20 RVA: 0x00003387 File Offset: 0x00001587
			public int method_4()
			{
				return Class1.Class4.int_0 - this.int_3;
			}

			// Token: 0x06000015 RID: 21 RVA: 0x00003395 File Offset: 0x00001595
			public int method_5()
			{
				return this.int_3;
			}

			// Token: 0x06000016 RID: 22 RVA: 0x00016EC0 File Offset: 0x000150C0
			public int method_6(byte[] byte_1, int int_4, int int_5)
			{
				int num = this.int_2;
				if (int_5 > this.int_3)
				{
					int_5 = this.int_3;
				}
				else
				{
					num = (this.int_2 - this.int_3 + int_5 & Class1.Class4.int_1);
				}
				int num2 = int_5;
				int num3 = int_5 - num;
				if (num3 > 0)
				{
					Array.Copy(this.byte_0, Class1.Class4.int_0 - num3, byte_1, int_4, num3);
					int_4 += num3;
					int_5 = num;
				}
				Array.Copy(this.byte_0, num - int_5, byte_1, int_4, int_5);
				this.int_3 -= num2;
				if (this.int_3 < 0)
				{
					throw new InvalidOperationException();
				}
				return num2;
			}

			// Token: 0x04000016 RID: 22
			private static int int_0 = 32768;

			// Token: 0x04000017 RID: 23
			private static int int_1 = Class1.Class4.int_0 - 1;

			// Token: 0x04000018 RID: 24
			private byte[] byte_0 = new byte[checked((uint)Class1.Class4.int_0)];

			// Token: 0x04000019 RID: 25
			private int int_2 = 0;

			// Token: 0x0400001A RID: 26
			private int int_3 = 0;
		}

		// Token: 0x02000008 RID: 8
		internal sealed class Class5
		{
			// Token: 0x06000019 RID: 25 RVA: 0x00016F54 File Offset: 0x00015154
			static Class5()
			{
				byte[] array = new byte[288];
				int i = 0;
				while (i < 144)
				{
					array[i++] = 8;
				}
				while (i < 256)
				{
					array[i++] = 9;
				}
				while (i < 280)
				{
					array[i++] = 7;
				}
				while (i < 288)
				{
					array[i++] = 8;
				}
				Class1.Class5.class5_0 = new Class1.Class5(array);
				array = new byte[32];
				i = 0;
				while (i < 32)
				{
					array[i++] = 5;
				}
				Class1.Class5.class5_1 = new Class1.Class5(array);
			}

			// Token: 0x0600001A RID: 26 RVA: 0x000033DC File Offset: 0x000015DC
			public Class5(byte[] byte_0)
			{
				this.method_0(byte_0);
			}

			// Token: 0x0600001B RID: 27 RVA: 0x00016FF0 File Offset: 0x000151F0
			private void method_0(byte[] byte_0)
			{
				int[] array;
				int[] array2;
				checked
				{
					array = new int[(uint)(unchecked(Class1.Class5.int_0 + 1))];
					array2 = new int[(uint)(unchecked(Class1.Class5.int_0 + 1))];
				}
				foreach (int num in byte_0)
				{
					if (num > 0)
					{
						int[] array3;
						IntPtr intPtr;
						(array3 = array)[(int)(intPtr = (IntPtr)num)] = array3[(int)intPtr] + 1;
					}
				}
				int num2 = 0;
				int num3 = 512;
				for (int j = 1; j <= Class1.Class5.int_0; j++)
				{
					array2[j] = num2;
					num2 += array[j] << 16 - j;
					if (j >= 10)
					{
						int num4 = array2[j] & 130944;
						int num5 = num2 & 130944;
						num3 += num5 - num4 >> 16 - j;
					}
				}
				this.short_0 = new short[checked((uint)num3)];
				int num6 = 512;
				for (int k = Class1.Class5.int_0; k >= 10; k--)
				{
					int num7 = num2 & 130944;
					num2 -= array[k] << 16 - k;
					int num8 = num2 & 130944;
					for (int l = num8; l < num7; l += 128)
					{
						this.short_0[(int)Class1.Class7.smethod_0(l)] = (short)(-num6 << 4 | k);
						num6 += 1 << k - 9;
					}
				}
				for (int m = 0; m < byte_0.Length; m++)
				{
					int num9 = (int)byte_0[m];
					if (num9 != 0)
					{
						num2 = array2[num9];
						int num10 = (int)Class1.Class7.smethod_0(num2);
						if (num9 <= 9)
						{
							do
							{
								this.short_0[num10] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < 512);
						}
						else
						{
							int num11 = (int)this.short_0[num10 & 511];
							int num12 = 1 << (num11 & 15);
							num11 = -(num11 >> 4);
							do
							{
								this.short_0[num11 | num10 >> 9] = (short)(m << 4 | num9);
								num10 += 1 << num9;
							}
							while (num10 < num12);
						}
						array2[num9] = num2 + (1 << 16 - num9);
					}
				}
			}

			// Token: 0x0600001C RID: 28 RVA: 0x000171F0 File Offset: 0x000153F0
			public int method_1(Class1.Class3 class3_0)
			{
				int num;
				if ((num = class3_0.method_0(9)) >= 0)
				{
					int num2;
					if ((num2 = (int)this.short_0[num]) >= 0)
					{
						class3_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					int num3 = -(num2 >> 4);
					int int_ = num2 & 15;
					if ((num = class3_0.method_0(int_)) >= 0)
					{
						num2 = (int)this.short_0[num3 | num >> 9];
						class3_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					int num4 = class3_0.method_2();
					num = class3_0.method_0(num4);
					num2 = (int)this.short_0[num3 | num >> 9];
					if ((num2 & 15) <= num4)
					{
						class3_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
				else
				{
					int num5 = class3_0.method_2();
					num = class3_0.method_0(num5);
					int num2 = (int)this.short_0[num];
					if (num2 >= 0 && (num2 & 15) <= num5)
					{
						class3_0.method_1(num2 & 15);
						return num2 >> 4;
					}
					return -1;
				}
			}

			// Token: 0x0400001B RID: 27
			private static int int_0 = 15;

			// Token: 0x0400001C RID: 28
			private short[] short_0;

			// Token: 0x0400001D RID: 29
			public static Class1.Class5 class5_0;

			// Token: 0x0400001E RID: 30
			public static Class1.Class5 class5_1;
		}

		// Token: 0x02000009 RID: 9
		internal sealed class Class6
		{
			// Token: 0x0600001E RID: 30 RVA: 0x000172C8 File Offset: 0x000154C8
			public bool method_0(Class1.Class3 class3_0)
			{
				for (;;)
				{
					switch (this.int_2)
					{
					case 0:
						this.int_3 = class3_0.method_0(5);
						if (this.int_3 >= 0)
						{
							this.int_3 += 257;
							class3_0.method_1(5);
							this.int_2 = 1;
							goto IL_1DD;
						}
						return false;
					case 1:
						goto IL_1DD;
					case 2:
						goto IL_18F;
					case 3:
						goto IL_156;
					case 4:
						break;
					case 5:
						goto IL_2C;
					default:
						continue;
					}
					IL_E1:
					int num;
					while (((num = this.class5_0.method_1(class3_0)) & -16) == 0)
					{
						this.byte_1[this.int_8++] = (this.byte_2 = (byte)num);
						if (this.int_8 == this.int_6)
						{
							return true;
						}
					}
					if (num >= 0)
					{
						if (num >= 17)
						{
							this.byte_2 = 0;
						}
						this.int_7 = num - 16;
						this.int_2 = 5;
						goto IL_2C;
					}
					return false;
					IL_156:
					while (this.int_8 < this.int_5)
					{
						int num2 = class3_0.method_0(3);
						if (num2 < 0)
						{
							return false;
						}
						class3_0.method_1(3);
						this.byte_0[Class1.Class6.int_9[this.int_8]] = (byte)num2;
						this.int_8++;
					}
					this.class5_0 = new Class1.Class5(this.byte_0);
					this.byte_0 = null;
					this.int_8 = 0;
					this.int_2 = 4;
					goto IL_E1;
					IL_2C:
					int num3 = Class1.Class6.int_1[this.int_7];
					int num4 = class3_0.method_0(num3);
					if (num4 < 0)
					{
						return false;
					}
					class3_0.method_1(num3);
					num4 += Class1.Class6.int_0[this.int_7];
					while (num4-- > 0)
					{
						this.byte_1[this.int_8++] = this.byte_2;
					}
					if (this.int_8 == this.int_6)
					{
						break;
					}
					this.int_2 = 4;
					continue;
					IL_18F:
					this.int_5 = class3_0.method_0(4);
					if (this.int_5 >= 0)
					{
						this.int_5 += 4;
						class3_0.method_1(4);
						this.byte_0 = new byte[19];
						this.int_8 = 0;
						this.int_2 = 3;
						goto IL_156;
					}
					return false;
					IL_1DD:
					this.int_4 = class3_0.method_0(5);
					if (this.int_4 >= 0)
					{
						this.int_4++;
						class3_0.method_1(5);
						this.int_6 = this.int_3 + this.int_4;
						this.byte_1 = new byte[checked((uint)this.int_6)];
						this.int_2 = 2;
						goto IL_18F;
					}
					return false;
				}
				return true;
			}

			// Token: 0x0600001F RID: 31 RVA: 0x00017564 File Offset: 0x00015764
			public Class1.Class5 method_1()
			{
				byte[] destinationArray = new byte[checked((uint)this.int_3)];
				Array.Copy(this.byte_1, 0, destinationArray, 0, this.int_3);
				return new Class1.Class5(destinationArray);
			}

			// Token: 0x06000020 RID: 32 RVA: 0x00017598 File Offset: 0x00015798
			public Class1.Class5 method_2()
			{
				byte[] destinationArray = new byte[checked((uint)this.int_4)];
				Array.Copy(this.byte_1, this.int_3, destinationArray, 0, this.int_4);
				return new Class1.Class5(destinationArray);
			}

			// Token: 0x0400001F RID: 31
			private static readonly int[] int_0 = new int[]
			{
				3,
				3,
				11
			};

			// Token: 0x04000020 RID: 32
			private static readonly int[] int_1 = new int[]
			{
				2,
				3,
				7
			};

			// Token: 0x04000021 RID: 33
			private byte[] byte_0;

			// Token: 0x04000022 RID: 34
			private byte[] byte_1;

			// Token: 0x04000023 RID: 35
			private Class1.Class5 class5_0;

			// Token: 0x04000024 RID: 36
			private int int_2;

			// Token: 0x04000025 RID: 37
			private int int_3;

			// Token: 0x04000026 RID: 38
			private int int_4;

			// Token: 0x04000027 RID: 39
			private int int_5;

			// Token: 0x04000028 RID: 40
			private int int_6;

			// Token: 0x04000029 RID: 41
			private int int_7;

			// Token: 0x0400002A RID: 42
			private byte byte_2;

			// Token: 0x0400002B RID: 43
			private int int_8;

			// Token: 0x0400002C RID: 44
			private static readonly int[] int_9 = new int[]
			{
				16,
				17,
				18,
				0,
				8,
				7,
				9,
				6,
				10,
				5,
				11,
				4,
				12,
				3,
				13,
				2,
				14,
				1,
				15
			};
		}

		// Token: 0x0200000A RID: 10
		internal sealed class Class7
		{
			// Token: 0x06000022 RID: 34 RVA: 0x000033F3 File Offset: 0x000015F3
			public static short smethod_0(int int_9)
			{
				return (short)((int)Class1.Class7.byte_0[int_9 & 15] << 12 | (int)Class1.Class7.byte_0[int_9 >> 4 & 15] << 8 | (int)Class1.Class7.byte_0[int_9 >> 8 & 15] << 4 | (int)Class1.Class7.byte_0[int_9 >> 12]);
			}

			// Token: 0x06000023 RID: 35 RVA: 0x00017624 File Offset: 0x00015824
			static Class7()
			{
				int i;
				checked
				{
					Class1.Class7.short_0 = new short[(uint)Class1.Class7.int_1];
					Class1.Class7.byte_1 = new byte[(uint)Class1.Class7.int_1];
					i = 0;
				}
				while (i < 144)
				{
					Class1.Class7.short_0[i] = Class1.Class7.smethod_0(48 + i << 8);
					Class1.Class7.byte_1[i++] = 8;
				}
				while (i < 256)
				{
					Class1.Class7.short_0[i] = Class1.Class7.smethod_0(256 + i << 7);
					Class1.Class7.byte_1[i++] = 9;
				}
				while (i < 280)
				{
					Class1.Class7.short_0[i] = Class1.Class7.smethod_0(-256 + i << 9);
					Class1.Class7.byte_1[i++] = 7;
				}
				while (i < Class1.Class7.int_1)
				{
					Class1.Class7.short_0[i] = Class1.Class7.smethod_0(-88 + i << 8);
					Class1.Class7.byte_1[i++] = 8;
				}
				checked
				{
					Class1.Class7.short_1 = new short[(uint)Class1.Class7.int_2];
					Class1.Class7.byte_2 = new byte[(uint)Class1.Class7.int_2];
				}
				for (i = 0; i < Class1.Class7.int_2; i++)
				{
					Class1.Class7.short_1[i] = Class1.Class7.smethod_0(i << 11);
					Class1.Class7.byte_2[i] = 5;
				}
			}

			// Token: 0x0400002D RID: 45
			private static int int_0 = 16384;

			// Token: 0x0400002E RID: 46
			private static int int_1 = 286;

			// Token: 0x0400002F RID: 47
			private static int int_2 = 30;

			// Token: 0x04000030 RID: 48
			private static int int_3 = 19;

			// Token: 0x04000031 RID: 49
			private static int int_4 = 16;

			// Token: 0x04000032 RID: 50
			private static int int_5 = 17;

			// Token: 0x04000033 RID: 51
			private static int int_6 = 18;

			// Token: 0x04000034 RID: 52
			private static int int_7 = 256;

			// Token: 0x04000035 RID: 53
			private static int[] int_8 = new int[]
			{
				16,
				17,
				18,
				0,
				8,
				7,
				9,
				6,
				10,
				5,
				11,
				4,
				12,
				3,
				13,
				2,
				14,
				1,
				15
			};

			// Token: 0x04000036 RID: 54
			private static byte[] byte_0 = new byte[]
			{
				0,
				8,
				4,
				12,
				2,
				10,
				6,
				14,
				1,
				9,
				5,
				13,
				3,
				11,
				7,
				15
			};

			// Token: 0x04000037 RID: 55
			private static short[] short_0;

			// Token: 0x04000038 RID: 56
			private static byte[] byte_1;

			// Token: 0x04000039 RID: 57
			private static short[] short_1;

			// Token: 0x0400003A RID: 58
			private static byte[] byte_2;
		}

		// Token: 0x0200000B RID: 11
		internal sealed class Stream0 : MemoryStream
		{
			// Token: 0x06000024 RID: 36 RVA: 0x0000342C File Offset: 0x0000162C
			public int method_0()
			{
				return this.ReadByte() | this.ReadByte() << 8;
			}

			// Token: 0x06000025 RID: 37 RVA: 0x0000343D File Offset: 0x0000163D
			public int method_1()
			{
				return this.method_0() | this.method_0() << 16;
			}

			// Token: 0x06000026 RID: 38 RVA: 0x0000344F File Offset: 0x0000164F
			public Stream0(byte[] byte_0) : base(byte_0, false)
			{
			}
		}
	}
}
