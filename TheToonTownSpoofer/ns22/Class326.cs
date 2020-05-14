using System;
using System.Drawing;
using System.IO;
using ns20;
using ns23;
using ns24;
using ns26;
using ns27;
using ns28;
using ns29;
using ns30;

namespace ns22
{
	// Token: 0x02000353 RID: 851
	internal static class Class326
	{
		// Token: 0x06002148 RID: 8520 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		public static Struct50 smethod_0(this BinaryReader reader)
		{
			return new Struct50(reader.smethod_10(), reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32(), reader.ReadUInt32());
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0006FD78 File Offset: 0x0006DF78
		public static void smethod_1(this BinaryWriter writer, Struct50 stats)
		{
			writer.smethod_11(stats.TotalRunTime);
			writer.Write(stats.TotalFishCaught);
			writer.Write(stats.TotalBootsCaught);
			writer.Write(stats.TotalBucketsSold);
			writer.Write(stats.TotalCasts);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x0006FDC8 File Offset: 0x0006DFC8
		public static Class95<Struct54> smethod_2(this BinaryReader reader)
		{
			if (!reader.ReadBoolean())
			{
				return null;
			}
			byte[] array = reader.smethod_7();
			if (array == null)
			{
				return null;
			}
			Class95<Struct54> result;
			using (MemoryStream memoryStream = new MemoryStream(array))
			{
				result = new Class95<Struct54>(memoryStream);
			}
			return result;
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0006FE18 File Offset: 0x0006E018
		public static void smethod_3(this BinaryWriter writer, Class95<Struct54> jbmp)
		{
			if (jbmp == null)
			{
				writer.Write(false);
				return;
			}
			writer.Write(true);
			using (MemoryStream memoryStream = new MemoryStream())
			{
				jbmp.method_2(memoryStream);
				writer.smethod_6(memoryStream.ToArray());
			}
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x0006FE6C File Offset: 0x0006E06C
		public unsafe static Class150 smethod_4(this BinaryReader reader)
		{
			if (reader.ReadBoolean())
			{
				Size sz = new Size(reader.ReadInt32(), reader.ReadInt32());
				byte[] array = reader.smethod_7();
				if (array != null)
				{
					Struct54[] array2 = new Struct54[sz.Width * sz.Height];
					byte[] array3;
					byte* ptr;
					if ((array3 = array) != null && array3.Length != 0)
					{
						fixed (byte* ptr = &array3[0])
						{
						}
					}
					else
					{
						ptr = null;
					}
					Struct54[] array4;
					Struct54* ptr2;
					if ((array4 = array2) != null && array4.Length != 0)
					{
						fixed (Struct54* ptr2 = &array4[0])
						{
						}
					}
					else
					{
						ptr2 = null;
					}
					Struct54* ptr3 = ptr2;
					Struct54* ptr4 = (Struct54*)ptr;
					for (int i = 0; i < sz.Width * sz.Height; i++)
					{
						*ptr3 = *ptr4;
						ptr3++;
						ptr4++;
					}
					ptr2 = null;
					ptr = null;
					return new Class150(array2, sz);
				}
			}
			return null;
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x0006FF4C File Offset: 0x0006E14C
		public unsafe static void smethod_5(this BinaryWriter writer, Class150 pix)
		{
			if (pix == null)
			{
				writer.Write(false);
				return;
			}
			Size size_ = pix.size_0;
			writer.Write(true);
			writer.Write(size_.Width);
			writer.Write(size_.Height);
			byte[] array = new byte[size_.Width * size_.Height * 3];
			Struct54[] getPixels = pix.GetPixels;
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
			Struct54* ptr2 = (Struct54*)ptr;
			Struct54[] array3;
			Struct54* ptr3;
			if ((array3 = getPixels) != null && array3.Length != 0)
			{
				fixed (Struct54* ptr3 = &array3[0])
				{
				}
			}
			else
			{
				ptr3 = null;
			}
			Struct54* ptr4 = ptr3;
			for (int i = 0; i < size_.Width * size_.Height; i++)
			{
				*ptr2 = *ptr4;
				ptr4++;
				ptr2++;
			}
			ptr3 = null;
			ptr = null;
			writer.smethod_6(array);
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x0007003C File Offset: 0x0006E23C
		public static void smethod_6(this BinaryWriter writer, byte[] data)
		{
			byte[] array = null;
			if (data != null)
			{
				try
				{
					Class478.smethod_0(data, out array);
				}
				catch (Exception ex)
				{
					ex.smethod_0();
					array = null;
				}
			}
			if (array == null)
			{
				writer.Write(false);
				return;
			}
			writer.Write(true);
			writer.Write(data.Length);
			writer.Write(array.Length);
			writer.Write(array);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x000700A0 File Offset: 0x0006E2A0
		public static byte[] smethod_7(this BinaryReader reader)
		{
			if (!reader.ReadBoolean())
			{
				return null;
			}
			int num = reader.ReadInt32();
			int count = reader.ReadInt32();
			byte[] src = reader.ReadBytes(count);
			byte[] array = new byte[num];
			byte[] result;
			try
			{
				Class478.smethod_1(src, array);
				result = array;
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				result = null;
			}
			finally
			{
			}
			return result;
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x0000D9C5 File Offset: 0x0000BBC5
		public static void smethod_8(this BinaryWriter writer, Class96 parser)
		{
			if (parser == null)
			{
				writer.Write(false);
				return;
			}
			writer.Write(true);
			parser.method_3(writer);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		public static Class96 smethod_9(this BinaryReader reader)
		{
			if (reader.ReadBoolean())
			{
				return new Class96(reader);
			}
			return null;
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x0000D9F2 File Offset: 0x0000BBF2
		public static TimeSpan smethod_10(this BinaryReader reader)
		{
			return TimeSpan.FromTicks(reader.ReadInt64());
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x0000D9FF File Offset: 0x0000BBFF
		public static void smethod_11(this BinaryWriter writer, TimeSpan time)
		{
			writer.Write(time.Ticks);
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x0000DA0E File Offset: 0x0000BC0E
		public static PointF smethod_12(this BinaryReader reader)
		{
			return new PointF(reader.ReadSingle(), reader.ReadSingle());
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0000DA21 File Offset: 0x0000BC21
		public static void smethod_13(this BinaryWriter writer, PointF p)
		{
			writer.Write(p.X);
			writer.Write(p.Y);
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0000DA3D File Offset: 0x0000BC3D
		public static Size smethod_14(this BinaryReader reader)
		{
			return new Size(reader.ReadInt32(), reader.ReadInt32());
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x0000DA50 File Offset: 0x0000BC50
		public static void smethod_15(this BinaryWriter writer, Size sz)
		{
			writer.Write(sz.Width);
			writer.Write(sz.Height);
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		public static Struct54 smethod_16(this BinaryReader reader)
		{
			return new Struct54(reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x0000DA85 File Offset: 0x0000BC85
		public static void smethod_17(this BinaryWriter writer, Struct54 color)
		{
			writer.Write(color.R);
			writer.Write(color.G);
			writer.Write(color.B);
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x0000DAAE File Offset: 0x0000BCAE
		public static Struct33 smethod_18(this BinaryReader reader)
		{
			return new Struct33(reader.ReadByte(), reader.ReadByte(), reader.ReadByte(), reader.ReadByte());
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x0000DACD File Offset: 0x0000BCCD
		public static void smethod_19(this BinaryWriter writer, Struct33 color)
		{
			writer.Write(color.R);
			writer.Write(color.G);
			writer.Write(color.B);
			writer.Write(color.A);
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x0000DB03 File Offset: 0x0000BD03
		public static void smethod_20(this BinaryWriter writer, Struct46 fbr)
		{
			writer.Write(fbr.double_0);
			writer.Write(fbr.double_1);
			writer.Write(fbr.double_2);
			writer.Write(fbr.double_3);
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x0000DB39 File Offset: 0x0000BD39
		public static Struct46 smethod_21(this BinaryReader reader)
		{
			return new Struct46(reader.ReadDouble(), reader.ReadDouble(), reader.ReadDouble(), reader.ReadDouble());
		}

		// Token: 0x0600215E RID: 8542 RVA: 0x00070110 File Offset: 0x0006E310
		public static Struct43 smethod_22(this Stream stream)
		{
			byte[] array = new byte[16];
			stream.Read(array, 0, array.Length);
			return new Struct43(array);
		}

		// Token: 0x0600215F RID: 8543 RVA: 0x0000DB58 File Offset: 0x0000BD58
		public static void smethod_23(this Stream stream, Struct43 hashCode)
		{
			stream.Write(hashCode.method_0(), 0, 16);
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x0000DB6A File Offset: 0x0000BD6A
		public static Struct43 smethod_24(this BinaryReader reader)
		{
			return new Struct43(reader.ReadBytes(16));
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x0000DB79 File Offset: 0x0000BD79
		public static void smethod_25(this BinaryWriter writer, Struct43 hash)
		{
			writer.Write(hash.method_0());
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x0000DB88 File Offset: 0x0000BD88
		public static void smethod_26(this BinaryWriter writer, Version version)
		{
			writer.Write(version.Major);
			writer.Write(version.Minor);
			writer.Write(version.Build);
			writer.Write(version.Revision);
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x0000DBBA File Offset: 0x0000BDBA
		public static Version smethod_27(this BinaryReader reader)
		{
			return new Version(reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32(), reader.ReadInt32());
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x0000DBD9 File Offset: 0x0000BDD9
		public static void smethod_28(this BinaryWriter writer, Guid guid)
		{
			writer.Write(guid.ToByteArray());
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		public static Guid smethod_29(this BinaryReader reader)
		{
			return new Guid(reader.ReadBytes(16));
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x0000DBF7 File Offset: 0x0000BDF7
		public static DateTime smethod_30(this BinaryReader reader)
		{
			return DateTime.FromBinary(reader.ReadInt64());
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x0000DC04 File Offset: 0x0000BE04
		public static void smethod_31(this BinaryWriter writer, DateTime dateTime)
		{
			writer.Write(dateTime.ToBinary());
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00070138 File Offset: 0x0006E338
		public static Uri smethod_32(this BinaryReader reader)
		{
			if (!reader.ReadBoolean())
			{
				return null;
			}
			string text = reader.ReadString();
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			return new Uri(text);
		}

		// Token: 0x06002169 RID: 8553 RVA: 0x0000DC13 File Offset: 0x0000BE13
		public static void smethod_33(this BinaryWriter writer, Uri uri)
		{
			if (!(uri == null) && !string.IsNullOrEmpty(uri.OriginalString))
			{
				writer.Write(true);
				writer.Write(uri.OriginalString);
				return;
			}
			writer.Write(false);
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x00070168 File Offset: 0x0006E368
		public static int smethod_34(this Stream reader)
		{
			byte[] array = reader.smethod_4(4);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToInt32(array, 0);
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00070194 File Offset: 0x0006E394
		public static void smethod_35(this Stream writer, int value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			writer.Write(bytes, 0, bytes.Length);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x000701C0 File Offset: 0x0006E3C0
		public static short smethod_36(this Stream reader)
		{
			byte[] array = reader.smethod_4(2);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(array);
			}
			return BitConverter.ToInt16(array, 0);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x000701EC File Offset: 0x0006E3EC
		public static void smethod_37(this Stream writer, short value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse(bytes);
			}
			writer.Write(bytes, 0, bytes.Length);
		}
	}
}
