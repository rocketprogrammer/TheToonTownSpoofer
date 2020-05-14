using System;
using System.IO;
using System.IO.Compression;
using ns21;
using ns25;
using ns30;

namespace ns17
{
	// Token: 0x0200027F RID: 639
	internal static class Class219
	{
		// Token: 0x06001AC6 RID: 6854 RVA: 0x0004F6D8 File Offset: 0x0004D8D8
		public static void smethod_0(Stream inStream, Stream outStream, bool isStreamOwner)
		{
			if (inStream != null && outStream != null)
			{
				try
				{
					using (Stream1 stream = new Stream1(inStream))
					{
						stream.IsStreamOwner = isStreamOwner;
						stream.smethod_5(outStream, new byte[4096]);
					}
					return;
				}
				finally
				{
					if (isStreamOwner)
					{
						outStream.Close();
					}
				}
			}
			throw new Exception("Null Stream");
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x0004F74C File Offset: 0x0004D94C
		public static void smethod_1(Stream inStream, Stream outStream, bool isStreamOwner, int level)
		{
			if (inStream == null)
			{
				throw new ArgumentNullException("inStream");
			}
			if (outStream == null)
			{
				throw new ArgumentNullException("outStream");
			}
			try
			{
				using (Stream2 stream = new Stream2(outStream, level))
				{
					stream.IsStreamOwner = isStreamOwner;
					inStream.smethod_5(stream, new byte[4096]);
				}
			}
			finally
			{
				if (isStreamOwner)
				{
					inStream.Close();
				}
			}
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x0004F7CC File Offset: 0x0004D9CC
		public static byte[] smethod_2(Stream str)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Class219.smethod_6(memoryStream);
				using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress))
				{
					str.CopyTo(deflateStream);
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x0004F830 File Offset: 0x0004DA30
		public static byte[] smethod_3(byte[] data)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				Class219.smethod_6(memoryStream);
				using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Compress))
				{
					data.smethod_0(deflateStream);
					result = memoryStream.ToArray();
				}
			}
			return result;
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x0004F894 File Offset: 0x0004DA94
		public static byte[] smethod_4(byte[] data)
		{
			byte[] result;
			using (MemoryStream memoryStream = new MemoryStream(data))
			{
				Class219.smethod_7(memoryStream);
				using (DeflateStream deflateStream = new DeflateStream(memoryStream, CompressionMode.Decompress))
				{
					result = deflateStream.smethod_1();
				}
			}
			return result;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0004F8F0 File Offset: 0x0004DAF0
		public static void smethod_5(Stream source, Stream destination)
		{
			Class219.smethod_7(source);
			using (DeflateStream deflateStream = new DeflateStream(source, CompressionMode.Decompress))
			{
				deflateStream.smethod_5(destination, new byte[4096]);
			}
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00009A20 File Offset: 0x00007C20
		private static void smethod_6(Stream str)
		{
			str.WriteByte(120);
			str.WriteByte(1);
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x00009A31 File Offset: 0x00007C31
		private static void smethod_7(Stream str)
		{
			str.ReadByte();
			str.ReadByte();
		}
	}
}
