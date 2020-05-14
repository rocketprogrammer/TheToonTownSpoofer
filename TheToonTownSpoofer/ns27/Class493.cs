using System;
using System.IO;
using System.Text;

namespace ns27
{
	// Token: 0x02000499 RID: 1177
	internal static class Class493
	{
		// Token: 0x06002BE0 RID: 11232 RVA: 0x000AA848 File Offset: 0x000A8A48
		public static DateTime smethod_0(Stream fs)
		{
			fs.Position += 4L;
			byte[] array = new byte[4];
			Class493.smethod_11(fs, array);
			int year = BitConverter.ToInt32(array, 0);
			Class493.smethod_11(fs, array);
			int month = BitConverter.ToInt32(array, 0);
			Class493.smethod_11(fs, array);
			int day = BitConverter.ToInt32(array, 0);
			Class493.smethod_11(fs, array);
			int hour = BitConverter.ToInt32(array, 0);
			Class493.smethod_11(fs, array);
			int minute = BitConverter.ToInt32(array, 0);
			Class493.smethod_11(fs, array);
			int second = BitConverter.ToInt32(array, 0);
			return new DateTime(year, month, day, hour, minute, second);
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000AA8E0 File Offset: 0x000A8AE0
		public static string smethod_1(Stream fs)
		{
			byte[] array = new byte[4];
			Class493.smethod_11(fs, array);
			byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
			Class493.smethod_11(fs, array2);
			return Encoding.UTF8.GetString(array2);
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000AA91C File Offset: 0x000A8B1C
		public static string smethod_2(Stream fs)
		{
			int num = Class493.smethod_4(fs);
			byte[] array = new byte[num];
			Class493.smethod_11(fs, array);
			return Encoding.UTF8.GetString(array);
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000AA94C File Offset: 0x000A8B4C
		public static byte[] smethod_3(Stream fs)
		{
			byte[] array = new byte[4];
			Class493.smethod_11(fs, array);
			byte[] array2 = new byte[BitConverter.ToInt32(array, 0)];
			Class493.smethod_11(fs, array2);
			return array2;
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000AA97C File Offset: 0x000A8B7C
		public static int smethod_4(Stream fs)
		{
			byte[] array = new byte[4];
			fs.Position += 4L;
			Class493.smethod_11(fs, array);
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000146BB File Offset: 0x000128BB
		public static bool smethod_5(Stream fs)
		{
			return Class493.smethod_4(fs) == 1;
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
		public static long smethod_6(Stream fs)
		{
			byte[] array = new byte[8];
			fs.Position += 4L;
			Class493.smethod_11(fs, array);
			return BitConverter.ToInt64(array, 0);
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000AA9EC File Offset: 0x000A8BEC
		public static short smethod_7(Stream fs)
		{
			byte[] array = new byte[2];
			fs.Position += 4L;
			Class493.smethod_11(fs, array);
			return BitConverter.ToInt16(array, 0);
		}

		// Token: 0x06002BE8 RID: 11240 RVA: 0x000AAA24 File Offset: 0x000A8C24
		public static bool smethod_8(Stream fs, string HeaderShouldBe)
		{
			byte[] array = new byte[HeaderShouldBe.Length];
			fs.Read(array, 0, array.Length);
			string @string = Encoding.UTF8.GetString(array);
			return @string == HeaderShouldBe;
		}

		// Token: 0x06002BE9 RID: 11241 RVA: 0x000146C6 File Offset: 0x000128C6
		public static bool smethod_9(Stream fs, byte endByte, byte readValue)
		{
			if (endByte == readValue)
			{
				return true;
			}
			if (fs.Length == fs.Position)
			{
				throw new Exception("Premature end of file.");
			}
			return false;
		}

		// Token: 0x06002BEA RID: 11242 RVA: 0x000AAA5C File Offset: 0x000A8C5C
		public static void smethod_10(Stream fs, byte flag)
		{
			if (flag < 128 || flag > 159)
			{
				byte[] array = new byte[4];
				fs.Read(array, 0, 4);
				fs.Position += (long)BitConverter.ToInt32(array, 0);
			}
		}

		// Token: 0x06002BEB RID: 11243 RVA: 0x000AAAA0 File Offset: 0x000A8CA0
		public static void smethod_11(Stream stream, byte[] data)
		{
			int num = 0;
			int i = data.Length;
			while (i > 0)
			{
				int num2 = stream.Read(data, num, i);
				if (num2 <= 0)
				{
					throw new EndOfStreamException(string.Format("End of stream reached with {0} bytes left to read", i));
				}
				i -= num2;
				num += num2;
			}
		}
	}
}
