using System;

namespace ns27
{
	// Token: 0x02000479 RID: 1145
	internal static class Class478
	{
		// Token: 0x06002AB6 RID: 10934 RVA: 0x000A4E00 File Offset: 0x000A3000
		public unsafe static void smethod_0(byte[] src, out byte[] dst)
		{
			uint num = (uint)(src.Length + src.Length / 16 + 64 + 3);
			dst = new byte[num];
			uint num2;
			if ((long)src.Length <= 13L)
			{
				num2 = (uint)src.Length;
				num = 0U;
			}
			else
			{
				byte[] array = new byte[65539];
				byte[] array2;
				byte* ptr;
				if ((array2 = array) != null && array2.Length != 0)
				{
					fixed (byte* ptr = &array2[0])
					{
					}
				}
				else
				{
					ptr = null;
				}
				byte* ptr2;
				if (src != null && src.Length != 0)
				{
					fixed (byte* ptr2 = &src[0])
					{
					}
				}
				else
				{
					ptr2 = null;
				}
				byte[] array3;
				byte* ptr3;
				if ((array3 = dst) != null && array3.Length != 0)
				{
					fixed (byte* ptr3 = &array3[0])
					{
					}
				}
				else
				{
					ptr3 = null;
				}
				byte** ptr4 = (byte**)ptr;
				byte* ptr5 = ptr2 + src.Length;
				byte* ptr6 = ptr2 + src.Length - 8 - 5;
				byte* ptr7 = ptr2;
				byte* ptr8 = ptr2 + 4;
				byte* ptr9 = ptr3;
				bool flag = false;
				bool flag2 = false;
				for (;;)
				{
					uint num3 = 0U;
					uint num4 = Class478.smethod_2(ptr8);
					byte* ptr10 = ptr8 - (ptr8 - *(IntPtr*)(ptr4 + (ulong)num4 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*))) / 1;
					if (ptr10 >= ptr2 && (num3 = (uint)((long)(ptr8 - ptr10))) > 0U && num3 <= 49151U)
					{
						if (num3 > 2048U && ptr10[3] != ptr8[3])
						{
							num4 = Class478.smethod_3(num4);
							ptr10 = ptr8 - (ptr8 - *(IntPtr*)(ptr4 + (ulong)num4 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*))) / 1;
							if (ptr10 >= ptr2 && (num3 = (uint)((long)(ptr8 - ptr10))) > 0U && num3 <= 49151U)
							{
								if (num3 > 2048U && ptr10[3] != ptr8[3])
								{
									flag = true;
								}
							}
							else
							{
								flag = true;
							}
						}
					}
					else
					{
						flag = true;
					}
					if (!flag && *(ushort*)ptr10 == *(ushort*)ptr8 && ptr10[2] == ptr8[2])
					{
						flag2 = true;
					}
					flag = false;
					if (!flag2)
					{
						*(IntPtr*)(ptr4 + (ulong)num4 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*)) = ptr8;
						ptr8++;
						if (ptr8 >= ptr6)
						{
							break;
						}
					}
					else
					{
						flag2 = false;
						*(IntPtr*)(ptr4 + (ulong)num4 * (ulong)((long)sizeof(byte*)) / (ulong)sizeof(byte*)) = ptr8;
						if ((long)(ptr8 - ptr7) > 0L)
						{
							uint num5 = (uint)((long)(ptr8 - ptr7));
							if (num5 <= 3U)
							{
								byte* ptr11 = ptr9 + -2;
								*ptr11 |= (byte)num5;
							}
							else if (num5 <= 18U)
							{
								*(ptr9++) = (byte)(num5 - 3U);
							}
							else
							{
								uint num6 = num5 - 18U;
								*(ptr9++) = 0;
								while (num6 > 255U)
								{
									num6 -= 255U;
									*(ptr9++) = 0;
								}
								*(ptr9++) = (byte)num6;
							}
							do
							{
								*(ptr9++) = *(ptr7++);
							}
							while ((num5 -= 1U) > 0U);
						}
						ptr8 += 3;
						if (ptr10[3] != *(ptr8++) || ptr10[4] != *(ptr8++) || ptr10[5] != *(ptr8++) || ptr10[6] != *(ptr8++) || ptr10[7] != *(ptr8++))
						{
							goto IL_38F;
						}
						if (ptr10[8] != *(ptr8++))
						{
							goto IL_38F;
						}
						byte* ptr12 = ptr10 + 8 + 1;
						while (ptr8 < ptr5)
						{
							if (*ptr12 != *ptr8)
							{
								break;
							}
							ptr12++;
							ptr8++;
						}
						uint num7 = (uint)((long)(ptr8 - ptr7));
						if (num3 <= 16384U)
						{
							num3 -= 1U;
							if (num7 <= 33U)
							{
								*(ptr9++) = (byte)(32U | num7 - 2U);
							}
							else
							{
								num7 -= 33U;
								*(ptr9++) = 32;
								while (num7 > 255U)
								{
									num7 -= 255U;
									*(ptr9++) = 0;
								}
								*(ptr9++) = (byte)num7;
							}
						}
						else
						{
							num3 -= 16384U;
							if (num7 <= 9U)
							{
								*(ptr9++) = (byte)(16U | (num3 & 16384U) >> 11 | num7 - 2U);
							}
							else
							{
								num7 -= 9U;
								*(ptr9++) = (byte)(16U | (num3 & 16384U) >> 11);
								while (num7 > 255U)
								{
									num7 -= 255U;
									*(ptr9++) = 0;
								}
								*(ptr9++) = (byte)num7;
							}
						}
						*(ptr9++) = (byte)((num3 & 63U) << 2);
						*(ptr9++) = (byte)(num3 >> 6);
						IL_461:
						ptr7 = ptr8;
						if (ptr8 >= ptr6)
						{
							break;
						}
						continue;
						IL_38F:
						ptr8--;
						num7 = (uint)((long)(ptr8 - ptr7));
						if (num3 <= 2048U)
						{
							num3 -= 1U;
							*(ptr9++) = (byte)(num7 - 1U << 5 | (num3 & 7U) << 2);
							*(ptr9++) = (byte)(num3 >> 3);
							goto IL_461;
						}
						if (num3 <= 16384U)
						{
							num3 -= 1U;
							*(ptr9++) = (byte)(32U | num7 - 2U);
							*(ptr9++) = (byte)((num3 & 63U) << 2);
							*(ptr9++) = (byte)(num3 >> 6);
							goto IL_461;
						}
						num3 -= 16384U;
						*(ptr9++) = (byte)(16U | (num3 & 16384U) >> 11 | num7 - 2U);
						*(ptr9++) = (byte)((num3 & 63U) << 2);
						*(ptr9++) = (byte)(num3 >> 6);
						goto IL_461;
					}
				}
				num = (uint)((long)(ptr9 - ptr3));
				num2 = (uint)((long)(ptr5 - ptr7));
				ptr = null;
				ptr2 = null;
				ptr3 = null;
			}
			if (num2 > 0U)
			{
				uint num8 = (uint)(src.Length - (int)num2);
				if (num == 0U && num2 <= 238U)
				{
					dst[(int)((UIntPtr)(num++))] = (byte)(17U + num2);
				}
				else if (num2 <= 3U)
				{
					byte[] array4 = dst;
					UIntPtr uintPtr = (UIntPtr)(num - 2U);
					array4[(int)uintPtr] = (array4[(int)uintPtr] | (byte)num2);
				}
				else if (num2 <= 18U)
				{
					dst[(int)((UIntPtr)(num++))] = (byte)(num2 - 3U);
				}
				else
				{
					uint num9 = num2 - 18U;
					dst[(int)((UIntPtr)(num++))] = 0;
					while (num9 > 255U)
					{
						num9 -= 255U;
						dst[(int)((UIntPtr)(num++))] = 0;
					}
					dst[(int)((UIntPtr)(num++))] = (byte)num9;
				}
				do
				{
					dst[(int)((UIntPtr)(num++))] = src[(int)((UIntPtr)(num8++))];
				}
				while ((num2 -= 1U) > 0U);
			}
			dst[(int)((UIntPtr)(num++))] = 17;
			dst[(int)((UIntPtr)(num++))] = 0;
			dst[(int)((UIntPtr)(num++))] = 0;
			if ((long)dst.Length != (long)((ulong)num))
			{
				byte[] array5 = new byte[num];
				Buffer.BlockCopy(dst, 0, array5, 0, (int)num);
				dst = array5;
			}
		}

		// Token: 0x06002AB7 RID: 10935 RVA: 0x000A5478 File Offset: 0x000A3678
		public unsafe static void smethod_1(byte[] src, byte[] dst)
		{
			uint num = 0U;
			byte* ptr;
			if (src != null && src.Length != 0)
			{
				fixed (byte* ptr = &src[0])
				{
				}
			}
			else
			{
				ptr = null;
			}
			byte* ptr2;
			if (dst != null && dst.Length != 0)
			{
				fixed (byte* ptr2 = &dst[0])
				{
				}
			}
			else
			{
				ptr2 = null;
			}
			byte* ptr3 = null;
			byte* ptr4 = ptr + src.Length;
			byte* ptr5 = ptr2 + dst.Length;
			byte* ptr6 = ptr;
			byte* ptr7 = ptr2;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			bool flag6 = false;
			if (*ptr6 > 17)
			{
				num = (uint)(*(ptr6++) - 17);
				if (num < 4U)
				{
					flag2 = true;
				}
				else
				{
					if ((long)(ptr5 - ptr7) < (long)((ulong)num))
					{
						throw new OverflowException("Output Overrun");
					}
					if ((long)(ptr4 - ptr6) < (long)((ulong)(num + 1U)))
					{
						throw new OverflowException("Input Overrun");
					}
					do
					{
						*(ptr7++) = *(ptr6++);
					}
					while ((num -= 1U) > 0U);
					flag5 = true;
				}
			}
			while (!flag6 && ptr6 < ptr4)
			{
				if (!flag2 && !flag5)
				{
					num = (uint)(*(ptr6++));
					if (num >= 16U)
					{
						flag = true;
					}
					else
					{
						if (num == 0U)
						{
							if ((long)(ptr4 - ptr6) < 1L)
							{
								throw new OverflowException("Input Overrun");
							}
							while (*ptr6 == 0)
							{
								num += 255U;
								ptr6++;
								if ((long)(ptr4 - ptr6) < 1L)
								{
									throw new OverflowException("Input Overrun");
								}
							}
							num += (uint)(15 + *(ptr6++));
						}
						if ((long)(ptr5 - ptr7) < (long)((ulong)(num + 3U)))
						{
							throw new OverflowException("Output Overrun");
						}
						if ((long)(ptr4 - ptr6) < (long)((ulong)(num + 4U)))
						{
							throw new OverflowException("Input Overrun");
						}
						int i = 0;
						while (i < 4)
						{
							*ptr7 = *ptr6;
							i++;
							ptr7++;
							ptr6++;
						}
						if ((num -= 1U) > 0U)
						{
							if (num >= 4U)
							{
								do
								{
									int j = 0;
									while (j < 4)
									{
										*ptr7 = *ptr6;
										j++;
										ptr7++;
										ptr6++;
									}
									num -= 4U;
								}
								while (num >= 4U);
								if (num > 0U)
								{
									do
									{
										*(ptr7++) = *(ptr6++);
									}
									while ((num -= 1U) > 0U);
								}
							}
							else
							{
								do
								{
									*(ptr7++) = *(ptr6++);
								}
								while ((num -= 1U) > 0U);
							}
						}
					}
				}
				if (!flag && !flag2)
				{
					flag5 = false;
					num = (uint)(*(ptr6++));
					if (num < 16U)
					{
						ptr3 = ptr7 - 2049;
						ptr3 -= num >> 2;
						ptr3 -= *(ptr6++) << 2;
						if (ptr3 < ptr2 || ptr3 >= ptr7)
						{
							throw new OverflowException("Lookbehind Overrun");
						}
						if ((long)(ptr5 - ptr7) < 3L)
						{
							throw new OverflowException("Output Overrun");
						}
						*(ptr7++) = *(ptr3++);
						*(ptr7++) = *(ptr3++);
						*(ptr7++) = *(ptr3++);
						flag3 = true;
					}
				}
				flag = false;
				do
				{
					if (num >= 64U)
					{
						ptr3 = ptr7 - 1;
						ptr3 -= (num >> 2 & 7U);
						ptr3 -= *(ptr6++) << 3;
						num = (num >> 5) - 1U;
						if (ptr3 < ptr2 || ptr3 >= ptr7)
						{
							goto IL_663;
						}
						if ((long)(ptr5 - ptr7) < (long)((ulong)(num + 2U)))
						{
							goto IL_658;
						}
						flag4 = true;
					}
					else if (num >= 32U)
					{
						num &= 31U;
						if (num == 0U)
						{
							if ((long)(ptr4 - ptr6) < 1L)
							{
								goto Block_32;
							}
							while (*ptr6 == 0)
							{
								num += 255U;
								ptr6++;
								if ((long)(ptr4 - ptr6) < 1L)
								{
									goto IL_679;
								}
							}
							num += (uint)(31 + *(ptr6++));
						}
						ptr3 = ptr7 - 1;
						ptr3 -= *(ushort*)ptr6 >> 2;
						ptr6 += 2;
					}
					else if (num >= 16U)
					{
						ptr3 = ptr7;
						ptr3 -= (num & 8U) << 11;
						num &= 7U;
						if (num == 0U)
						{
							if ((long)(ptr4 - ptr6) < 1L)
							{
								goto Block_36;
							}
							while (*ptr6 == 0)
							{
								num += 255U;
								ptr6++;
								if ((long)(ptr4 - ptr6) < 1L)
								{
									goto IL_68F;
								}
							}
							num += (uint)(7 + *(ptr6++));
						}
						ptr3 -= *(ushort*)ptr6 >> 2;
						ptr6 += 2;
						if (ptr3 == ptr7)
						{
							flag6 = true;
						}
						else
						{
							ptr3 -= 16384;
						}
					}
					else
					{
						ptr3 = ptr7 - 1;
						ptr3 -= num >> 2;
						ptr3 -= *(ptr6++) << 2;
						if (ptr3 < ptr2 || ptr3 >= ptr7)
						{
							goto IL_6D1;
						}
						if ((long)(ptr5 - ptr7) < 2L)
						{
							goto IL_69A;
						}
						*(ptr7++) = *(ptr3++);
						*(ptr7++) = *(ptr3++);
						flag3 = true;
					}
					if (!flag6 && !flag3 && !flag4)
					{
						if (ptr3 < ptr2 || ptr3 >= ptr7)
						{
							goto IL_6B0;
						}
						if ((long)(ptr5 - ptr7) < (long)((ulong)(num + 2U)))
						{
							goto IL_6A5;
						}
					}
					if (!flag6 && num >= 6U && (long)(ptr7 - ptr3) >= 4L && !flag3 && !flag4)
					{
						int k = 0;
						while (k < 4)
						{
							*ptr7 = *ptr3;
							k++;
							ptr7++;
							ptr3++;
						}
						num -= 2U;
						do
						{
							int l = 0;
							while (l < 4)
							{
								*ptr7 = *ptr3;
								l++;
								ptr7++;
								ptr3++;
							}
							num -= 4U;
						}
						while (num >= 4U);
						if (num > 0U)
						{
							do
							{
								*(ptr7++) = *(ptr3++);
							}
							while ((num -= 1U) > 0U);
						}
					}
					else if (!flag6 && !flag3)
					{
						flag4 = false;
						*(ptr7++) = *(ptr3++);
						*(ptr7++) = *(ptr3++);
						do
						{
							*(ptr7++) = *(ptr3++);
						}
						while ((num -= 1U) > 0U);
					}
					if (!flag6 && !flag2)
					{
						flag3 = false;
						num = (uint)(ptr6[-2] & 3);
						if (num == 0U)
						{
							break;
						}
					}
					if (!flag6)
					{
						flag2 = false;
						if ((long)(ptr5 - ptr7) < (long)((ulong)num))
						{
							goto IL_6BB;
						}
						if ((long)(ptr4 - ptr6) < (long)((ulong)(num + 1U)))
						{
							goto IL_6C6;
						}
						*(ptr7++) = *(ptr6++);
						if (num > 1U)
						{
							*(ptr7++) = *(ptr6++);
							if (num > 2U)
							{
								*(ptr7++) = *(ptr6++);
							}
						}
						num = (uint)(*(ptr6++));
					}
					if (flag6)
					{
						break;
					}
				}
				while (ptr6 < ptr4);
				continue;
				Block_32:
				throw new OverflowException("Input Overrun");
				Block_36:
				throw new OverflowException("Input Overrun");
				IL_658:
				throw new OverflowException("Output Overrun");
				IL_663:
				throw new OverflowException("Lookbehind Overrun");
				IL_679:
				throw new OverflowException("Input Overrun");
				IL_68F:
				throw new OverflowException("Input Overrun");
				IL_69A:
				throw new OverflowException("Output Overrun");
				IL_6A5:
				throw new OverflowException("Output Overrun");
				IL_6B0:
				throw new OverflowException("Lookbehind Overrun");
				IL_6BB:
				throw new OverflowException("Output Overrun");
				IL_6C6:
				throw new OverflowException("Input Overrun");
				IL_6D1:
				throw new OverflowException("Lookbehind Overrun");
			}
			if (!flag6)
			{
				throw new OverflowException("EOF Marker Not Found");
			}
			if (ptr6 != ptr4)
			{
				throw new OverflowException("Input Overrun");
			}
			if (ptr6 < ptr4)
			{
				throw new OverflowException("Input Not Consumed");
			}
			ptr = null;
			ptr2 = null;
		}

		// Token: 0x06002AB8 RID: 10936 RVA: 0x00013E83 File Offset: 0x00012083
		private unsafe static uint smethod_2(byte* input)
		{
			return Class478.smethod_4(Class478.smethod_5(33U, Class478.smethod_7(input, 5, 5, 6)) >> 5, 0);
		}

		// Token: 0x06002AB9 RID: 10937 RVA: 0x00013E9D File Offset: 0x0001209D
		private static uint smethod_3(uint idx)
		{
			return (idx & 2047U) ^ 8223U;
		}

		// Token: 0x06002ABA RID: 10938 RVA: 0x00013EAC File Offset: 0x000120AC
		private static uint smethod_4(uint v, byte s)
		{
			return (v & 16383U >> (int)s) << (int)s;
		}

		// Token: 0x06002ABB RID: 10939 RVA: 0x00013EBF File Offset: 0x000120BF
		private static uint smethod_5(uint a, uint b)
		{
			return a * b;
		}

		// Token: 0x06002ABC RID: 10940 RVA: 0x00013EC4 File Offset: 0x000120C4
		private unsafe static uint smethod_6(byte* input, byte s1, byte s2)
		{
			return (uint)(((int)input[2] << (int)s2 ^ (int)input[1]) << (int)s1 ^ (int)(*input));
		}

		// Token: 0x06002ABD RID: 10941 RVA: 0x00013EDE File Offset: 0x000120DE
		private unsafe static uint smethod_7(byte* input, byte s1, byte s2, byte s3)
		{
			return Class478.smethod_6(input + 1, s2, s3) << (int)s1 ^ (uint)(*input);
		}

		// Token: 0x0400168D RID: 5773
		private const uint uint_0 = 8U;

		// Token: 0x0400168E RID: 5774
		private const uint uint_1 = 33U;

		// Token: 0x0400168F RID: 5775
		private const uint uint_2 = 9U;

		// Token: 0x04001690 RID: 5776
		private const byte byte_0 = 32;

		// Token: 0x04001691 RID: 5777
		private const byte byte_1 = 16;

		// Token: 0x04001692 RID: 5778
		private const uint uint_3 = 1024U;

		// Token: 0x04001693 RID: 5779
		private const uint uint_4 = 2048U;

		// Token: 0x04001694 RID: 5780
		private const uint uint_5 = 16384U;

		// Token: 0x04001695 RID: 5781
		private const uint uint_6 = 49151U;

		// Token: 0x04001696 RID: 5782
		private const byte byte_2 = 14;

		// Token: 0x04001697 RID: 5783
		private const uint uint_7 = 16383U;

		// Token: 0x04001698 RID: 5784
		private const uint uint_8 = 65539U;
	}
}
