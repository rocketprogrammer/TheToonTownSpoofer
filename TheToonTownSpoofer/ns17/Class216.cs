using System;

namespace ns17
{
	// Token: 0x02000276 RID: 630
	internal static class Class216
	{
		// Token: 0x06001AA0 RID: 6816 RVA: 0x000098EE File Offset: 0x00007AEE
		public unsafe static char* smethod_0(char* buf, char c, int length)
		{
			while (length-- > 0)
			{
				if (*buf == c)
				{
					return buf;
				}
				buf++;
			}
			return null;
		}

		// Token: 0x06001AA1 RID: 6817 RVA: 0x0000990D File Offset: 0x00007B0D
		public unsafe static int smethod_1(char* buf1, char* buf2, int length)
		{
			while (length-- > 0)
			{
				if (*buf1 != *buf2)
				{
					if (*buf1 <= *buf2)
					{
						return -1;
					}
					return 1;
				}
				else
				{
					buf1++;
					buf2++;
				}
			}
			return 0;
		}

		// Token: 0x06001AA2 RID: 6818 RVA: 0x0004E634 File Offset: 0x0004C834
		public unsafe static void smethod_2(char* dest, char* src, int length)
		{
			while (length >= 8)
			{
				*(int*)dest = *(int*)src;
				*(int*)(dest + 2) = *(int*)(src + 2);
				*(int*)(dest + 4) = *(int*)(src + 4);
				*(int*)(dest + 6) = *(int*)(src + 6);
				dest += 8;
				src += 8;
				length -= 8;
			}
			if ((length & 4) != 0)
			{
				*(int*)dest = *(int*)src;
				*(int*)(dest + 2) = *(int*)(src + 2);
				dest += 4;
				src += 4;
			}
			if ((length & 2) != 0)
			{
				*(int*)dest = *(int*)src;
				dest += 2;
				src += 2;
			}
			if ((length & 1) != 0)
			{
				*dest = *src;
			}
		}

		// Token: 0x06001AA3 RID: 6819 RVA: 0x0004E6BC File Offset: 0x0004C8BC
		public unsafe static void smethod_3(char* dest, char* src, int length)
		{
			if ((dest & 2) != 0)
			{
				*dest = *src;
				dest++;
				src++;
				length--;
			}
			while (length >= 8)
			{
				*(int*)dest = *(int*)src;
				*(int*)(dest + 2) = *(int*)(src + 2);
				*(int*)(dest + 4) = *(int*)(src + 4);
				*(int*)(dest + 6) = *(int*)(src + 6);
				dest += 8;
				src += 8;
				length -= 8;
			}
			if ((length & 4) != 0)
			{
				*(int*)dest = *(int*)src;
				*(int*)(dest + 2) = *(int*)(src + 2);
				dest += 4;
				src += 4;
			}
			if ((length & 2) != 0)
			{
				*(int*)dest = *(int*)src;
				dest += 2;
				src += 2;
			}
			if ((length & 1) != 0)
			{
				*dest = *src;
			}
		}
	}
}
