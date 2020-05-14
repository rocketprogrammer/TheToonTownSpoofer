using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ns15;
using ns17;
using ns18;
using ns20;
using ns22;
using ns23;
using ns25;
using ns26;
using ns27;
using ns30;

namespace ns31
{
	// Token: 0x02000302 RID: 770
	internal sealed class Class292
	{
		// Token: 0x1400018E RID: 398
		// (add) Token: 0x06001E36 RID: 7734 RVA: 0x00061CEC File Offset: 0x0005FEEC
		// (remove) Token: 0x06001E37 RID: 7735 RVA: 0x00061D24 File Offset: 0x0005FF24
		public event EventHandler<EventArgs9> ProgressChanged
		{
			add
			{
				EventHandler<EventArgs9> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs9> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs9> value2 = (EventHandler<EventArgs9>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs9>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs9> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs9> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs9> value2 = (EventHandler<EventArgs9>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs9>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00061D5C File Offset: 0x0005FF5C
		private static void smethod_0(Class321 pd, BinaryWriter write_stream, uint length, uint copy_pos)
		{
			int value = (int)(copy_pos - pd.uint_5);
			write_stream.Write((ushort)length);
			if (length != 0U)
			{
				write_stream.Write(value);
				pd.uint_5 = copy_pos + length;
			}
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x0000B948 File Offset: 0x00009B48
		private static void smethod_1(BinaryWriter write_stream, uint length, byte[] buffer, uint buffer_pos)
		{
			write_stream.Write((ushort)length);
			if (length > 0U)
			{
				write_stream.Write(buffer, (int)buffer_pos, (int)length);
			}
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00061D90 File Offset: 0x0005FF90
		private static void smethod_2(Class321 pd, BinaryWriter write_stream, uint add_length, byte[] add_buffer, uint copy_length, uint copy_pos)
		{
			if (add_length == 0U && copy_length == 0U)
			{
				return;
			}
			uint num = 0U;
			while (add_length > 65535U)
			{
				Class292.smethod_1(write_stream, 65535U, add_buffer, num);
				num += 65535U;
				add_length -= 65535U;
				Class292.smethod_0(pd, write_stream, 0U, 0U);
			}
			Class292.smethod_1(write_stream, add_length, add_buffer, num);
			while (copy_length > 65535U)
			{
				Class292.smethod_0(pd, write_stream, 65535U, copy_pos);
				copy_pos += 65535U;
				copy_length -= 65535U;
				Class292.smethod_1(write_stream, 0U, null, 0U);
			}
			Class292.smethod_0(pd, write_stream, copy_length, copy_pos);
		}

		// Token: 0x06001E3B RID: 7739 RVA: 0x00061E24 File Offset: 0x00060024
		private static void smethod_3(Class321 pd, BinaryWriter write_stream)
		{
			IEnumerable<byte[]> queue_ = pd.queue_0;
			if (Class292.func_0 == null)
			{
				Class292.func_0 = new Func<byte[], int>(Class292.smethod_18);
			}
			uint num = (uint)queue_.Sum(Class292.func_0);
			byte[] array = new byte[num];
			int num2 = 0;
			while (pd.queue_0.Count > 0)
			{
				byte[] array2 = pd.queue_0.Dequeue();
				array2.CopyTo(array, num2);
				num2 += array2.Length;
			}
			Class292.smethod_2(pd, write_stream, num, array, pd.uint_3, pd.uint_4);
			pd.uint_3 = 0U;
		}

		// Token: 0x06001E3C RID: 7740 RVA: 0x00061EAC File Offset: 0x000600AC
		public static void smethod_4(Class321 pd, BinaryWriter write_stream, uint add_length, byte[] add_buffer, uint start_pos, uint copy_length, uint copy_pos)
		{
			if (add_length != 0U)
			{
				if (pd.uint_3 != 0U)
				{
					Class292.smethod_3(pd, write_stream);
				}
				byte[] array = new byte[add_length];
				Array.Copy(add_buffer, (long)((ulong)start_pos), array, 0L, (long)((ulong)add_length));
				pd.queue_0.Enqueue(array);
			}
			if (copy_length != 0U)
			{
				if (pd.uint_3 == 0U)
				{
					pd.uint_4 = copy_pos;
					pd.uint_3 = copy_length;
					return;
				}
				if (pd.uint_4 + pd.uint_3 == copy_pos)
				{
					pd.uint_3 += copy_length;
					return;
				}
				Class292.smethod_3(pd, write_stream);
				pd.uint_4 = copy_pos;
				pd.uint_3 = copy_length;
			}
		}

		// Token: 0x06001E3D RID: 7741 RVA: 0x00061F4C File Offset: 0x0006014C
		private static uint smethod_5(byte[] buf1, uint new_pos, byte[] buf2, uint copy_pos, uint max_length, uint min_length)
		{
			if (min_length > 2U)
			{
				if (min_length >= max_length)
				{
					return 0U;
				}
				if (buf1[(int)((UIntPtr)(min_length + new_pos))] != buf2[(int)((UIntPtr)(min_length + copy_pos))] || buf1[(int)((UIntPtr)(min_length - 1U + new_pos))] != buf2[(int)((UIntPtr)(min_length - 1U + copy_pos))] || buf1[(int)((UIntPtr)(min_length - 2U + new_pos))] != buf2[(int)((UIntPtr)(min_length - 2U + copy_pos))])
				{
					return 0U;
				}
			}
			uint num;
			for (num = 0U; num < max_length; num += 1U)
			{
				if (buf1[(int)((UIntPtr)new_pos)] != buf2[(int)((UIntPtr)copy_pos)])
				{
					break;
				}
				new_pos += 1U;
				copy_pos += 1U;
			}
			return num;
		}

		// Token: 0x06001E3E RID: 7742 RVA: 0x00061FC4 File Offset: 0x000601C4
		private static void smethod_6(uint new_pos, ref uint copy_pos, ref ushort copy_length, uint[] hash_table, uint[] link_table, byte[] buffer_orig, uint length_orig, byte[] buffer_new, uint length_new)
		{
			copy_length = 0;
			uint num = Class292.smethod_9(buffer_new, new_pos);
			if (4294967295U == hash_table[(int)((UIntPtr)num)])
			{
				return;
			}
			copy_pos = hash_table[(int)((UIntPtr)num)];
			copy_length = (ushort)Class292.smethod_5(buffer_new, new_pos, buffer_orig, copy_pos, Math.Min(Math.Min(length_new - new_pos, length_orig - copy_pos), 65535U), 0U);
			for (uint num2 = link_table[(int)((UIntPtr)copy_pos)]; num2 != 4294967295U; num2 = link_table[(int)((UIntPtr)num2)])
			{
				ushort num3 = (ushort)Class292.smethod_5(buffer_new, new_pos, buffer_orig, num2, Math.Min(Math.Min(length_new - new_pos, length_orig - num2), 65535U), (uint)copy_length);
				if (num3 > copy_length)
				{
					copy_pos = num2;
					copy_length = num3;
				}
			}
		}

		// Token: 0x06001E3F RID: 7743 RVA: 0x00062058 File Offset: 0x00060258
		private static void smethod_7(BinaryWriter write_stream, Stream stream_orig, Stream stream_new)
		{
			write_stream.Write(Class292.uint_0);
			write_stream.Write(Class292.ushort_0);
			write_stream.Write((uint)stream_orig.Length);
			write_stream.BaseStream.smethod_23(stream_orig.smethod_2());
			write_stream.Write((uint)stream_new.Length);
			write_stream.BaseStream.smethod_23(stream_new.smethod_2());
		}

		// Token: 0x06001E40 RID: 7744 RVA: 0x0000B95F File Offset: 0x00009B5F
		private static void smethod_8(Class321 pd, BinaryWriter write_stream)
		{
			Class292.smethod_3(pd, write_stream);
			Class292.smethod_1(write_stream, 0U, null, 0U);
			Class292.smethod_0(pd, write_stream, 0U, 0U);
		}

		// Token: 0x06001E41 RID: 7745 RVA: 0x000620B8 File Offset: 0x000602B8
		private static uint smethod_9(byte[] buffer, uint index)
		{
			uint num = 0U;
			for (int i = 0; i < 9; i++)
			{
				num ^= (uint)((uint)buffer[(int)(checked((IntPtr)(unchecked((long)i + (long)((ulong)index)))))] << i * 2 % 24);
			}
			num ^= num >> 24;
			return num & 16777215U;
		}

		// Token: 0x06001E42 RID: 7746 RVA: 0x000620F8 File Offset: 0x000602F8
		private static void smethod_10(byte[] buffer_orig, uint length_orig, uint[] hash_table, uint[] link_table)
		{
			int num = 0;
			while ((long)num < 16777216L)
			{
				hash_table[num] = uint.MaxValue;
				num++;
			}
			int num2 = 0;
			while ((long)num2 < (long)((ulong)length_orig))
			{
				link_table[num2] = uint.MaxValue;
				num2++;
			}
			if (length_orig < 9U)
			{
				return;
			}
			uint num3 = 0U;
			while ((ulong)num3 < (ulong)((long)(buffer_orig.Length - 9)))
			{
				uint num4 = Class292.smethod_9(buffer_orig, num3);
				link_table[(int)((UIntPtr)num3)] = hash_table[(int)((UIntPtr)num4)];
				hash_table[(int)((UIntPtr)num4)] = num3;
				num3 += 1U;
			}
		}

		// Token: 0x06001E43 RID: 7747 RVA: 0x00062160 File Offset: 0x00060360
		private static void smethod_11(Class321 pd, BinaryWriter write_stream, uint offset_orig, Stream stream_orig, Stream stream_new)
		{
			uint num = (uint)stream_orig.Length;
			uint num2 = (uint)stream_new.Length;
			stream_orig.Position = 0L;
			stream_new.Position = 0L;
			byte[] array = new byte[num];
			byte[] array2 = new byte[num2];
			stream_orig.smethod_6(array);
			stream_new.smethod_6(array2);
			uint[] link_table = new uint[num];
			if (pd.uint_6 == null)
			{
				pd.uint_6 = new uint[16777216];
			}
			Class292.smethod_10(array, num, pd.uint_6, link_table);
			uint num3 = 0U;
			uint num4 = 0U;
			if (num2 >= 9U)
			{
				while (num3 < num2 - 9U)
				{
					uint num5 = 0U;
					ushort num6 = 0;
					Class292.smethod_6(num3, ref num5, ref num6, pd.uint_6, link_table, array, num, array2, num2);
					if (num6 < 9)
					{
						num3 += 1U;
					}
					else
					{
						int add_length = (int)(num3 - num4);
						Class292.smethod_4(pd, write_stream, (uint)add_length, array2, num4, (uint)num6, num5 + offset_orig);
						num3 += (uint)num6;
						num4 = num3;
					}
				}
			}
			if (num4 != num2)
			{
				uint num7 = num2 - num4;
				Class292.smethod_4(pd, write_stream, num7, array2, num4, 0U, 0U);
				num4 += num7;
			}
		}

		// Token: 0x06001E44 RID: 7748 RVA: 0x00062274 File Offset: 0x00060474
		public static void smethod_12(Class321 pd, Enum81 type, BinaryWriter write_stream, uint offset_orig, uint offset_new, Stream stream_orig, Stream stream_new)
		{
			switch (type)
			{
			case Enum81.const_1:
				if (!Class136.smethod_3(stream_orig, stream_new))
				{
					type = Enum81.const_0;
				}
				break;
			case Enum81.const_2:
				if (!Class132.smethod_1(stream_orig, stream_new))
				{
					type = Enum81.const_0;
				}
				break;
			}
			switch (type)
			{
			case Enum81.const_1:
				Class136.smethod_0(pd, write_stream, offset_orig, offset_new, stream_orig, stream_new);
				return;
			case Enum81.const_2:
				Class132.smethod_2(pd, write_stream, offset_orig, offset_new, stream_orig, stream_new);
				return;
			default:
				Class292.smethod_11(pd, write_stream, offset_orig, stream_orig, stream_new);
				return;
			}
		}

		// Token: 0x06001E45 RID: 7749 RVA: 0x000622F0 File Offset: 0x000604F0
		public static void smethod_13(string originalFile, string newFile, string patchFile)
		{
			using (Stream stream = File.Open(originalFile, FileMode.Open, FileAccess.Read, FileShare.None))
			{
				using (Stream stream2 = File.Open(newFile, FileMode.Open, FileAccess.Read, FileShare.None))
				{
					using (Stream stream3 = File.Open(patchFile, FileMode.Create, FileAccess.Write, FileShare.None))
					{
						Class292.smethod_16(stream, stream2, stream3, Class292.smethod_14(originalFile, newFile));
					}
				}
			}
		}

		// Token: 0x06001E46 RID: 7750 RVA: 0x00062378 File Offset: 0x00060578
		private static Enum81 smethod_14(string file1, string file2)
		{
			Enum81 @enum = Class292.smethod_15(file1);
			Enum81 enum2 = Class292.smethod_15(file2);
			if (@enum != enum2)
			{
				return Enum81.const_0;
			}
			return @enum;
		}

		// Token: 0x06001E47 RID: 7751 RVA: 0x0006239C File Offset: 0x0006059C
		public static Enum81 smethod_15(string file)
		{
			string a;
			if ((a = Path.GetExtension(file).ToLower()) != null)
			{
				if (a == ".ttp")
				{
					return Enum81.const_2;
				}
				if (a == ".mf")
				{
					return Enum81.const_1;
				}
			}
			return Enum81.const_0;
		}

		// Token: 0x06001E48 RID: 7752 RVA: 0x000623E0 File Offset: 0x000605E0
		private static void smethod_16(Stream stream_orig, Stream stream_new, Stream stream_patch, Enum81 type)
		{
			using (Stream3 stream = new Stream3(stream_orig))
			{
				using (Stream3 stream2 = new Stream3(stream_new))
				{
					using (Stream3 stream3 = new Stream3(stream_patch))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(stream3))
						{
							Class292.smethod_7(binaryWriter, stream, stream2);
							Class321 @class = new Class321();
							Class292.smethod_12(@class, type, binaryWriter, 0U, 0U, stream, stream2);
							Class292.smethod_8(@class, binaryWriter);
							@class.queue_0 = null;
							@class.uint_6 = null;
						}
					}
				}
			}
		}

		// Token: 0x06001E49 RID: 7753 RVA: 0x000624A4 File Offset: 0x000606A4
		public void method_0(Stream stream_orig, Stream stream_patch, Stream stream_dest)
		{
			this.method_1(stream_orig, stream_patch, stream_dest, null, Struct43.struct43_0, null, Struct43.struct43_0, true, true);
		}

		// Token: 0x06001E4A RID: 7754 RVA: 0x000624D8 File Offset: 0x000606D8
		public void method_1(Stream stream_orig, Stream stream_patch, Stream stream_dest, uint? overrideExpectedStartingFileLength, Struct43 overrideExpectedStartingHash, uint? overrideExpectedResultingFileLength, Struct43 overrideExpectedResultingHash, bool validate_expected, bool validate_result)
		{
			using (Stream3 stream = new Stream3(stream_orig))
			{
				using (Stream3 stream2 = new Stream3(stream_patch))
				{
					using (Stream3 stream3 = new Stream3(stream_dest))
					{
						using (BinaryReader binaryReader = new BinaryReader(stream))
						{
							using (BinaryReader binaryReader2 = new BinaryReader(stream2))
							{
								using (BinaryWriter binaryWriter = new BinaryWriter(stream3))
								{
									binaryReader2.ReadUInt32();
									ushort num = binaryReader2.ReadUInt16();
									uint num2 = binaryReader2.ReadUInt32();
									Struct43 @struct = binaryReader2.BaseStream.smethod_22();
									uint num3 = binaryReader2.ReadUInt32();
									Struct43 struct2 = binaryReader2.BaseStream.smethod_22();
									uint num4 = 0U;
									if (validate_expected)
									{
										if (stream.Length != (long)((ulong)num2) && (overrideExpectedStartingFileLength == null || overrideExpectedStartingFileLength.Value != num2))
										{
											throw new InvalidDataException(string.Format("The starting file size: '{0}' does not match the expected file size: '{1}'.", stream.Length, num2));
										}
										Struct43 struct3 = stream_orig.smethod_2();
										if (Struct43.smethod_6(struct3, @struct) && (Struct43.smethod_5(overrideExpectedStartingHash, Struct43.struct43_0) || Struct43.smethod_6(overrideExpectedStartingHash, struct3)))
										{
											throw new InvalidDataException(string.Format("The actual starting hash: '{0}' does not match the expected hash: '{1}'.", struct3, @struct));
										}
									}
									byte[] buffer = new byte[4096];
									int num5 = 0;
									uint num7;
									uint num10;
									do
									{
										ushort num6 = (ushort)(num7 = (uint)binaryReader2.ReadUInt16());
										while (num6 > 0 && !binaryReader2.smethod_3())
										{
											int num8 = binaryReader2.Read(buffer, 0, (int)((num6 > 4096) ? 4096 : num6));
											binaryWriter.Write(buffer, 0, num8);
											num6 -= (ushort)num8;
											num4 += (uint)((ushort)num8);
											if (this.eventHandler_0 != null)
											{
												int num9 = EventArgs9.smethod_0((long)((ulong)num4), (long)((ulong)num3));
												if (num5 != num9)
												{
													num5 = num9;
													this.eventHandler_0(this, new EventArgs9((long)((ulong)num4), (long)((ulong)num3)));
												}
											}
										}
										num6 = (ushort)(num10 = (uint)binaryReader2.ReadUInt16());
										if (num6 > 0)
										{
											int num11 = binaryReader2.ReadInt32();
											if (num < 2)
											{
												binaryReader.BaseStream.Seek((long)num11, SeekOrigin.Begin);
											}
											else
											{
												binaryReader.BaseStream.Seek((long)num11, SeekOrigin.Current);
											}
											while (num6 > 0 && !binaryReader2.smethod_3())
											{
												int num8 = binaryReader.Read(buffer, 0, (int)((num6 > 4096) ? 4096 : num6));
												binaryWriter.Write(buffer, 0, num8);
												num6 -= (ushort)num8;
												num4 += (uint)((ushort)num8);
												if (this.eventHandler_0 != null)
												{
													int num9 = EventArgs9.smethod_0((long)((ulong)num4), (long)((ulong)num3));
													if (num5 != num9)
													{
														num5 = num9;
														this.eventHandler_0(this, new EventArgs9((long)((ulong)num4), (long)((ulong)num3)));
													}
												}
											}
										}
									}
									while (num10 != 0U || num7 != 0U);
									if (validate_result)
									{
										if (stream3.Length != (long)((ulong)num3))
										{
											if (overrideExpectedResultingFileLength != null)
											{
												uint? num12 = overrideExpectedResultingFileLength;
												long length = stream3.Length;
												if ((ulong)num12.GetValueOrDefault() == (ulong)length && num12 != null)
												{
													goto IL_2D7;
												}
											}
											throw new InvalidDataException(string.Format("The resulting file length: '{0}' does not match the expected data length: '{1}'.", stream3.Length, num3));
										}
										IL_2D7:
										Struct43 struct4 = stream3.smethod_2();
										if (Struct43.smethod_6(struct4, struct2) && (Struct43.smethod_5(overrideExpectedResultingHash, Struct43.struct43_0) || Struct43.smethod_6(overrideExpectedResultingHash, struct4)))
										{
											throw new InvalidDataException(string.Format("The resulting hash: '{0}' does not match the expected hash: '{1}'.", struct4, struct2));
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001E4B RID: 7755 RVA: 0x000628E8 File Offset: 0x00060AE8
		public static void smethod_17(Stream compressed_patch_stream, string destination_file, uint? overrideExpectedStartingFileLength, Struct43 overrideExpectedStartingHash, uint? overrideExpectedResultingFileLength, Struct43 overrideExpectedResultingHash, EventHandler<EventArgs9> progressChanged)
		{
			string text = destination_file + ".tmp";
			try
			{
				using (MemoryStream memoryStream = new MemoryStream())
				{
					Class219.smethod_0(compressed_patch_stream, memoryStream, false);
					memoryStream.Position = 0L;
					Class234.smethod_14(destination_file, text, true);
					using (Stream stream = File.Open(text, FileMode.Open, FileAccess.Read, FileShare.None))
					{
						using (Stream stream2 = File.Open(destination_file, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
						{
							Class292 @class = new Class292();
							if (progressChanged != null)
							{
								@class.ProgressChanged += progressChanged;
							}
							@class.method_1(stream, memoryStream, stream2, overrideExpectedStartingFileLength, overrideExpectedStartingHash, overrideExpectedResultingFileLength, overrideExpectedResultingHash, false, false);
						}
					}
				}
			}
			finally
			{
				if (File.Exists(text))
				{
					File.Delete(text);
				}
			}
		}

		// Token: 0x06001E4D RID: 7757 RVA: 0x0000B97A File Offset: 0x00009B7A
		[CompilerGenerated]
		private static int smethod_18(byte[] item)
		{
			return item.Length;
		}

		// Token: 0x04000B85 RID: 2949
		private static readonly ushort ushort_0 = 2;

		// Token: 0x04000B86 RID: 2950
		private static readonly uint uint_0 = 4276877996U;

		// Token: 0x04000B87 RID: 2951
		private EventHandler<EventArgs9> eventHandler_0;

		// Token: 0x04000B88 RID: 2952
		[CompilerGenerated]
		private static Func<byte[], int> func_0;
	}
}
