using System;
using System.IO;
using System.Text;

namespace ns30
{
	// Token: 0x020001ED RID: 493
	internal static class Class120
	{
		// Token: 0x0600164B RID: 5707 RVA: 0x00006694 File Offset: 0x00004894
		public static void smethod_0(Stream fs, byte flag, int num)
		{
			fs.WriteByte(flag);
			fs.Write(BitConverter.GetBytes(4), 0, 4);
			fs.Write(BitConverter.GetBytes(num), 0, 4);
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x000066B9 File Offset: 0x000048B9
		public static void smethod_1(Stream fs, byte flag, bool val)
		{
			Class120.smethod_0(fs, flag, val ? 1 : 0);
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x000066C9 File Offset: 0x000048C9
		public static void smethod_2(Stream fs, byte flag, long val)
		{
			fs.WriteByte(flag);
			fs.Write(BitConverter.GetBytes(8), 0, 4);
			fs.Write(BitConverter.GetBytes(val), 0, 8);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x000066EE File Offset: 0x000048EE
		public static void smethod_3(Stream fs, byte flag, short val)
		{
			fs.WriteByte(flag);
			fs.Write(BitConverter.GetBytes(2), 0, 4);
			fs.Write(BitConverter.GetBytes(val), 0, 2);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x0003608C File Offset: 0x0003428C
		public static void smethod_4(Stream fs, byte flag, DateTime dt)
		{
			fs.WriteByte(flag);
			fs.Write(BitConverter.GetBytes(24), 0, 4);
			fs.Write(BitConverter.GetBytes(dt.Year), 0, 4);
			fs.Write(BitConverter.GetBytes(dt.Month), 0, 4);
			fs.Write(BitConverter.GetBytes(dt.Day), 0, 4);
			fs.Write(BitConverter.GetBytes(dt.Hour), 0, 4);
			fs.Write(BitConverter.GetBytes(dt.Minute), 0, 4);
			fs.Write(BitConverter.GetBytes(dt.Second), 0, 4);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00036128 File Offset: 0x00034328
		public static void smethod_5(Stream fs, byte flag, string text)
		{
			if (text == null)
			{
				text = string.Empty;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			fs.WriteByte(flag);
			fs.Write(BitConverter.GetBytes(bytes.Length), 0, 4);
			fs.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00036170 File Offset: 0x00034370
		public static void smethod_6(Stream fs, byte flag, string text)
		{
			if (text == null)
			{
				text = string.Empty;
			}
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			byte[] bytes2 = BitConverter.GetBytes(bytes.Length);
			fs.WriteByte(flag);
			fs.Write(BitConverter.GetBytes(bytes.Length + 4), 0, 4);
			fs.Write(bytes2, 0, 4);
			fs.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000361CC File Offset: 0x000343CC
		public static void smethod_7(Stream fs, byte flag, byte[] arr)
		{
			byte[] bytes = BitConverter.GetBytes(arr.Length);
			fs.WriteByte(flag);
			fs.Write(bytes, 0, 4);
			fs.Write(arr, 0, arr.Length);
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00036200 File Offset: 0x00034400
		public static void smethod_8(Stream fs, string Header)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(Header);
			fs.Write(bytes, 0, bytes.Length);
		}
	}
}
