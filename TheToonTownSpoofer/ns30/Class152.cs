using System;
using System.IO;

namespace ns30
{
	// Token: 0x020001FD RID: 509
	internal static class Class152
	{
		// Token: 0x0600169A RID: 5786 RVA: 0x0003678C File Offset: 0x0003498C
		public static void smethod_0(this byte[] source, Stream destination)
		{
			int num;
			for (int i = 0; i < source.Length; i += num)
			{
				num = ((i + 4096 > source.Length) ? (source.Length - i) : 4096);
				destination.Write(source, i, num);
			}
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000367CC File Offset: 0x000349CC
		public static byte[] smethod_1(this Stream source)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				byte[] array = new byte[4096];
				int count;
				while ((count = source.Read(array, 0, array.Length)) != 0)
				{
					memoryStream.Write(array, 0, count);
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000069B9 File Offset: 0x00004BB9
		public static bool smethod_2(this Stream str)
		{
			return str.Position == str.Length;
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000069C9 File Offset: 0x00004BC9
		public static bool smethod_3(this BinaryReader reader)
		{
			return reader.BaseStream.smethod_2();
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x00036828 File Offset: 0x00034A28
		public static byte[] smethod_4(this Stream reader, int numberOfBytes)
		{
			byte[] array = new byte[numberOfBytes];
			reader.Read(array, 0, numberOfBytes);
			return array;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00036848 File Offset: 0x00034A48
		public static void smethod_5(this Stream source_stream, Stream destination_stream, byte[] buffer)
		{
			if (source_stream == null)
			{
				throw new ArgumentNullException("source_stream");
			}
			if (destination_stream == null)
			{
				throw new ArgumentNullException("destination_stream");
			}
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (buffer.Length < 128)
			{
				throw new ArgumentException("Buffer is too small", "buffer");
			}
			int count;
			while ((count = source_stream.Read(buffer, 0, buffer.Length)) != 0)
			{
				destination_stream.Write(buffer, 0, count);
			}
			destination_stream.Flush();
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000368B8 File Offset: 0x00034AB8
		public static void smethod_6(this Stream str, byte[] buffer)
		{
			int num = 0;
			int num2 = 4096;
			int num3;
			while ((num3 = str.Read(buffer, num, (num + num2 <= buffer.Length) ? num2 : (buffer.Length - num))) > 0)
			{
				num += num3;
			}
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x000368F0 File Offset: 0x00034AF0
		public static void smethod_7(this Stream str, Stream dest, long copyLength)
		{
			byte[] array = new byte[4096];
			while (copyLength > 0L)
			{
				int num = str.Read(array, 0, (int)((copyLength > (long)array.Length) ? ((long)array.Length) : copyLength));
				dest.Write(array, 0, num);
				copyLength -= (long)num;
			}
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x00036940 File Offset: 0x00034B40
		public static void smethod_8(this Stream str, byte[] buffer, long copyLength)
		{
			int num = 0;
			while (copyLength > 0L)
			{
				num += str.Read(buffer, num, (int)((copyLength > (long)buffer.Length) ? ((long)buffer.Length) : copyLength));
				copyLength -= (long)num;
			}
		}
	}
}
