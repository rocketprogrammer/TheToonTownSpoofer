using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ns15;
using ns20;
using ns22;
using ns23;
using ns26;
using ns27;
using ns28;
using ns30;
using ns31;
using TheToonTownSpoofer.IO.Archive;
using TSN.IO;

namespace ns25
{
	// Token: 0x02000348 RID: 840
	internal sealed class Class132 : Class123
	{
		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x0600207F RID: 8319 RVA: 0x0000D334 File Offset: 0x0000B534
		// (set) Token: 0x06002080 RID: 8320 RVA: 0x0000D33C File Offset: 0x0000B53C
		public Enum82 Type { get; private set; }

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06002081 RID: 8321 RVA: 0x0000D345 File Offset: 0x0000B545
		// (set) Token: 0x06002082 RID: 8322 RVA: 0x0000D34D File Offset: 0x0000B54D
		public Guid ID { get; private set; }

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06002083 RID: 8323 RVA: 0x0000D356 File Offset: 0x0000B556
		// (set) Token: 0x06002084 RID: 8324 RVA: 0x0000D35E File Offset: 0x0000B55E
		public Struct43 DataHash { get; private set; }

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x06002085 RID: 8325 RVA: 0x0000D367 File Offset: 0x0000B567
		// (set) Token: 0x06002086 RID: 8326 RVA: 0x0000D36F File Offset: 0x0000B56F
		public Uri UpdateUri { get; set; }

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x06002087 RID: 8327 RVA: 0x0000D378 File Offset: 0x0000B578
		// (set) Token: 0x06002088 RID: 8328 RVA: 0x0000D380 File Offset: 0x0000B580
		public string Name { get; set; }

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06002089 RID: 8329 RVA: 0x0000D389 File Offset: 0x0000B589
		// (set) Token: 0x0600208A RID: 8330 RVA: 0x0000D391 File Offset: 0x0000B591
		public string Author { get; set; }

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x0600208B RID: 8331 RVA: 0x0000D39A File Offset: 0x0000B59A
		// (set) Token: 0x0600208C RID: 8332 RVA: 0x0000D3A2 File Offset: 0x0000B5A2
		public string Description { get; set; }

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x0600208D RID: 8333 RVA: 0x0000D3AB File Offset: 0x0000B5AB
		// (set) Token: 0x0600208E RID: 8334 RVA: 0x0000D3B3 File Offset: 0x0000B5B3
		public Version Version { get; set; }

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x0600208F RID: 8335 RVA: 0x0000D3BC File Offset: 0x0000B5BC
		// (set) Token: 0x06002090 RID: 8336 RVA: 0x0000D3C4 File Offset: 0x0000B5C4
		public string Password { get; set; }

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06002091 RID: 8337 RVA: 0x0000D3CD File Offset: 0x0000B5CD
		// (set) Token: 0x06002092 RID: 8338 RVA: 0x0000D3D5 File Offset: 0x0000B5D5
		public bool LoaderPack { get; set; }

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x06002093 RID: 8339 RVA: 0x0000D3DE File Offset: 0x0000B5DE
		// (set) Token: 0x06002094 RID: 8340 RVA: 0x0000D3E6 File Offset: 0x0000B5E6
		public Bitmap Icon { get; private set; }

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06002095 RID: 8341 RVA: 0x0000D3EF File Offset: 0x0000B5EF
		// (set) Token: 0x06002096 RID: 8342 RVA: 0x0000D3F7 File Offset: 0x0000B5F7
		public Version MinimumVersion { get; set; }

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002097 RID: 8343 RVA: 0x0000D400 File Offset: 0x0000B600
		// (set) Token: 0x06002098 RID: 8344 RVA: 0x0000D408 File Offset: 0x0000B608
		public Class136 Data { get; private set; }

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06002099 RID: 8345 RVA: 0x0000D411 File Offset: 0x0000B611
		// (set) Token: 0x0600209A RID: 8346 RVA: 0x0000D419 File Offset: 0x0000B619
		public Struct43 PasswordHash { get; set; }

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x0600209B RID: 8347 RVA: 0x0000D422 File Offset: 0x0000B622
		// (set) Token: 0x0600209C RID: 8348 RVA: 0x0000D42A File Offset: 0x0000B62A
		public Dictionary<string, Struct43> ItemIndex { get; private set; }

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x0600209D RID: 8349 RVA: 0x0000D433 File Offset: 0x0000B633
		// (set) Token: 0x0600209E RID: 8350 RVA: 0x0000D43B File Offset: 0x0000B63B
		public Uri ObsoleteDownloadURL { get; private set; }

		// Token: 0x0600209F RID: 8351 RVA: 0x0000D444 File Offset: 0x0000B644
		internal void method_4(Guid id)
		{
			this.ID = id;
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x0006D9A4 File Offset: 0x0006BBA4
		public Class132()
		{
			this.ItemIndex = new Dictionary<string, Struct43>(StringComparer.OrdinalIgnoreCase);
			this.ID = Guid.NewGuid();
			this.Data = new Class136();
			this.UpdateUri = null;
			this.Name = string.Empty;
			this.Author = string.Empty;
			this.Description = string.Empty;
			this.Password = string.Empty;
			this.LoaderPack = false;
			this.MinimumVersion = Class500.Current.AssemblyVersion;
			this.PasswordHash = Struct43.struct43_0;
			this.Version = new Version(1, 0, 0, 0);
			this.DataHash = Struct43.struct43_0;
			this.Type = Enum82.const_1;
			this.ObsoleteDownloadURL = null;
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x0006DA5C File Offset: 0x0006BC5C
		public Class132(string filename, bool loadIcon, bool populateData)
		{
			this.ItemIndex = new Dictionary<string, Struct43>(StringComparer.OrdinalIgnoreCase);
			using (Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					byte[] array = binaryReader.ReadBytes(Class132.byte_0.Length);
					if (array.smethod_9(Class132.byte_0))
					{
						int num = binaryReader.ReadInt32();
						if (num < 2 || num > Class132.int_0)
						{
							throw new InvalidFileVersion<int>(2, Class132.int_0, num);
						}
						this.ObsoleteDownloadURL = null;
						this.Type = Enum82.const_1;
						this.method_6(stream, binaryReader, loadIcon, populateData);
					}
					else
					{
						if (!array.smethod_9(Class132.byte_1))
						{
							throw new InvalidFileType(Class132.byte_0, array);
						}
						this.Type = Enum82.const_0;
						this.Version = new Version(0, 0, 0, 0);
						this.method_7(stream, binaryReader, loadIcon, populateData);
					}
				}
			}
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x0006DB54 File Offset: 0x0006BD54
		public void method_5(Stream str)
		{
			if (this.Icon != null)
			{
				this.Icon.Dispose();
				this.Icon = null;
			}
			if (this.memoryStream_0 != null)
			{
				this.memoryStream_0.Dispose();
				this.memoryStream_0 = null;
			}
			if (str != null)
			{
				this.memoryStream_0 = new MemoryStream();
				str.CopyTo(this.memoryStream_0);
				this.memoryStream_0.Position = 0L;
				this.Icon = (Bitmap)Image.FromStream(this.memoryStream_0);
			}
		}

		// Token: 0x060020A3 RID: 8355 RVA: 0x0006DBDC File Offset: 0x0006BDDC
		protected override void vmethod_0()
		{
			if (this.Icon != null)
			{
				this.Icon.Dispose();
			}
			if (this.memoryStream_0 != null)
			{
				this.memoryStream_0.Dispose();
			}
			if (this.Data != null)
			{
				this.Data.Dispose();
			}
			this.ItemIndex.Clear();
			base.vmethod_0();
		}

		// Token: 0x060020A4 RID: 8356 RVA: 0x0006DC34 File Offset: 0x0006BE34
		public static bool smethod_0(Stream file_stream, out byte[] header, out int version)
		{
			long position = file_stream.Position;
			header = new byte[Class132.byte_0.Length];
			file_stream.Read(header, 0, Class132.byte_0.Length);
			byte[] array = new byte[4];
			file_stream.Read(array, 0, 4);
			version = BitConverter.ToInt32(array, 0);
			file_stream.Position = position;
			return header.smethod_9(Class132.byte_0) && version == Class132.int_0;
		}

		// Token: 0x060020A5 RID: 8357 RVA: 0x0006DCA4 File Offset: 0x0006BEA4
		public static bool smethod_1(Stream file_stream1, Stream file_stream2)
		{
			byte[] enumeration;
			int num;
			byte[] enumeration2;
			int num2;
			return Class132.smethod_0(file_stream1, out enumeration, out num) && Class132.smethod_0(file_stream2, out enumeration2, out num2) && enumeration.smethod_9(enumeration2) && num == num2;
		}

		// Token: 0x060020A6 RID: 8358 RVA: 0x0006DCD8 File Offset: 0x0006BED8
		public static void smethod_2(Class321 pd, BinaryWriter write_stream, uint offset_orig, uint offset_new, Stream stream_orig, Stream stream_new)
		{
			using (Stream3 stream = new Stream3(stream_orig))
			{
				using (Stream3 stream2 = new Stream3(stream_new))
				{
					uint num;
					uint num2;
					Class132.smethod_3(stream, out num, out num2);
					uint num3;
					uint num4;
					Class132.smethod_3(stream2, out num3, out num4);
					using (Stream3 stream3 = new Stream3(stream, 0L, (long)((ulong)num)))
					{
						using (Stream3 stream4 = new Stream3(stream2, 0L, (long)((ulong)num3)))
						{
							Class292.smethod_12(pd, Enum81.const_0, write_stream, offset_orig, offset_new, stream3, stream4);
						}
					}
					using (Stream3 stream5 = new Stream3(stream, (long)((ulong)num), (long)((ulong)(num + num2))))
					{
						using (Stream3 stream6 = new Stream3(stream2, (long)((ulong)num3), (long)((ulong)(num3 + num4))))
						{
							Class136.smethod_0(pd, write_stream, offset_orig + num, offset_new + num3, stream5, stream6);
						}
					}
				}
			}
		}

		// Token: 0x060020A7 RID: 8359 RVA: 0x0006DE08 File Offset: 0x0006C008
		private static void smethod_3(Stream stream, out uint index, out uint data_length)
		{
			using (Stream3 stream2 = new Stream3(stream))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream2))
				{
					binaryReader.ReadBytes(Class132.byte_0.Length);
					binaryReader.ReadInt32();
					binaryReader.smethod_29();
					Struct43 val = binaryReader.smethod_24();
					if (Struct43.smethod_5(val, Struct43.struct43_0))
					{
						throw new LoaderPackNotSupported();
					}
					if (binaryReader.ReadBoolean())
					{
						binaryReader.ReadString();
					}
					binaryReader.ReadString();
					binaryReader.ReadString();
					binaryReader.ReadString();
					binaryReader.smethod_27();
					binaryReader.smethod_27();
					binaryReader.smethod_24();
					int num = binaryReader.ReadInt32();
					stream.Position += (long)num;
					int num2 = binaryReader.ReadInt32();
					for (int i = 0; i < num2; i++)
					{
						binaryReader.ReadString();
						binaryReader.smethod_24();
					}
					data_length = (uint)binaryReader.ReadInt32();
					index = (uint)stream.Position;
				}
			}
		}

		// Token: 0x060020A8 RID: 8360 RVA: 0x0006DF14 File Offset: 0x0006C114
		private void method_6(Stream file_stream, BinaryReader reader, bool loadIcon, bool populateData)
		{
			this.ID = reader.smethod_29();
			this.DataHash = reader.smethod_24();
			this.LoaderPack = Struct43.smethod_5(this.DataHash, Struct43.struct43_0);
			this.UpdateUri = reader.smethod_32();
			this.Name = reader.ReadString();
			this.Author = reader.ReadString();
			this.Description = reader.ReadString();
			this.Version = reader.smethod_27();
			this.MinimumVersion = reader.smethod_27();
			this.PasswordHash = reader.smethod_24();
			int num = reader.ReadInt32();
			if (num > 0)
			{
				if (loadIcon)
				{
					using (Stream3 stream = new Stream3(file_stream, file_stream.Position, (long)num + file_stream.Position))
					{
						this.memoryStream_0 = new MemoryStream();
						stream.CopyTo(this.memoryStream_0);
						this.Icon = (Bitmap)Image.FromStream(this.memoryStream_0);
						goto IL_EE;
					}
				}
				file_stream.Position += (long)num;
			}
			IL_EE:
			if (this.LoaderPack)
			{
				if (populateData)
				{
					this.Data = new Class136();
					return;
				}
			}
			else
			{
				int num2 = reader.ReadInt32();
				for (int i = 0; i < num2; i++)
				{
					this.ItemIndex.Add(reader.ReadString(), reader.smethod_24());
				}
				int num3 = reader.ReadInt32();
				if (populateData)
				{
					using (Stream3 stream2 = new Stream3(file_stream, file_stream.Position, (long)num3 + file_stream.Position))
					{
						this.Data = new Class136(stream2);
						this.Data.method_12();
						return;
					}
				}
				file_stream.Position += (long)num3;
			}
		}

		// Token: 0x060020A9 RID: 8361 RVA: 0x0006E0CC File Offset: 0x0006C2CC
		private void method_7(Stream file_stream, BinaryReader reader, bool loadIcon, bool populateData)
		{
			Encoding encoding = Encoding.GetEncoding(1252);
			int num = reader.ReadInt32();
			if (num != 1)
			{
				throw new InvalidFileVersion<int>(1, 1, num);
			}
			decimal num2 = reader.ReadDecimal();
			decimal d = reader.ReadDecimal();
			int num3 = (int)Math.Floor(num2);
			this.MinimumVersion = new Version(num3, (int)((num2 - num3) * 100m), (int)(d * 100m), 0);
			this.Name = Class132.smethod_4(reader, encoding);
			this.Description = Class132.smethod_4(reader, encoding);
			this.Author = Class132.smethod_4(reader, encoding);
			this.PasswordHash = new Struct43(Class132.smethod_4(reader, encoding));
			if (Struct43.smethod_5(this.PasswordHash, Class132.struct43_0))
			{
				this.PasswordHash = Struct43.struct43_0;
			}
			Class132.smethod_4(reader, encoding);
			string text = Class132.smethod_4(reader, encoding);
			if (!string.IsNullOrEmpty(text))
			{
				this.ObsoleteDownloadURL = new Uri(text);
			}
			string text2 = Class132.smethod_4(reader, encoding);
			if (!string.IsNullOrEmpty(text2))
			{
				this.UpdateUri = new Uri(text2);
			}
			this.ID = new Guid(Class132.smethod_4(reader, encoding));
			this.DataHash = new Struct43(Class132.smethod_4(reader, encoding));
			int num4 = reader.ReadInt32();
			if (num4 > 0)
			{
				if (loadIcon)
				{
					using (Stream3 stream = new Stream3(file_stream, file_stream.Position, file_stream.Position + (long)num4))
					{
						this.memoryStream_0 = new MemoryStream();
						stream.CopyTo(this.memoryStream_0);
						this.Icon = (Bitmap)Image.FromStream(this.memoryStream_0);
						goto IL_1AC;
					}
				}
				file_stream.Position += (long)num4;
			}
			IL_1AC:
			this.LoaderPack = reader.ReadBoolean();
			if (this.LoaderPack)
			{
				this.DataHash = Struct43.struct43_0;
			}
			if (this.LoaderPack)
			{
				if (populateData)
				{
					this.Data = new Class136();
					return;
				}
			}
			else
			{
				int num5 = reader.ReadInt32();
				for (int i = 0; i < num5; i++)
				{
					this.ItemIndex.Add(Class132.smethod_4(reader, encoding), new Struct43(Class132.smethod_4(reader, encoding)));
				}
				int num6 = reader.ReadInt32();
				if (populateData)
				{
					using (Stream3 stream2 = new Stream3(file_stream, file_stream.Position, file_stream.Position + (long)num6))
					{
						this.Data = new Class136(stream2);
						this.Data.method_12();
						return;
					}
				}
				file_stream.Position += (long)num6;
			}
		}

		// Token: 0x060020AA RID: 8362 RVA: 0x0006E36C File Offset: 0x0006C56C
		private static string smethod_4(BinaryReader reader, Encoding enc)
		{
			int num = reader.ReadInt32();
			if (num > 0)
			{
				return enc.GetString(reader.ReadBytes(num));
			}
			return string.Empty;
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x0006E398 File Offset: 0x0006C598
		public void method_8(string filename, Struct43? passwordHash = null)
		{
			using (Stream stream = File.Open(filename, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(stream))
				{
					binaryWriter.Write(Class132.byte_0);
					binaryWriter.Write(Class132.int_0);
					binaryWriter.smethod_28(this.ID);
					long position = stream.Position;
					binaryWriter.smethod_25(Struct43.struct43_0);
					binaryWriter.smethod_33(this.UpdateUri);
					binaryWriter.Write(this.Name);
					binaryWriter.Write(this.Author);
					binaryWriter.Write(this.Description);
					binaryWriter.smethod_26(this.Version);
					binaryWriter.smethod_26(this.MinimumVersion);
					if (passwordHash != null)
					{
						binaryWriter.smethod_25(passwordHash.Value);
					}
					else if (string.IsNullOrEmpty(this.Password))
					{
						binaryWriter.smethod_25(Struct43.struct43_0);
					}
					else
					{
						binaryWriter.smethod_25(Encoding.Unicode.GetBytes(this.Password).smethod_0());
					}
					long position2 = stream.Position;
					binaryWriter.Write(0);
					if (this.Icon != null)
					{
						Class157.smethod_11(this.Icon, stream, Color.Black, 100);
						long position3 = stream.Position;
						stream.Position = position2;
						binaryWriter.Write((int)(position3 - position2 - 4L));
						stream.Position = position3;
					}
					if (!this.LoaderPack)
					{
						binaryWriter.Write(this.Data.MultiFileData.Count);
						foreach (KeyValuePair<string, Class338> keyValuePair in ((IEnumerable<KeyValuePair<string, Class338>>)this.Data.MultiFileData))
						{
							binaryWriter.Write(keyValuePair.Key);
							binaryWriter.smethod_25(keyValuePair.Value.Data.smethod_0());
						}
						position2 = stream.Position;
						binaryWriter.Write(0);
						using (Stream3 stream2 = new Stream3(stream, stream.Position))
						{
							using (BinaryWriter binaryWriter2 = new BinaryWriter(stream2))
							{
								this.Data.method_17(stream2, binaryWriter2);
								this.DataHash = stream2.smethod_2();
							}
						}
						long position3 = stream.Position;
						stream.Position = position2;
						binaryWriter.Write((int)(position3 - position2 - 4L));
						stream.Position = position3;
						position3 = stream.Position;
						stream.Position = position;
						binaryWriter.smethod_25(this.DataHash);
						stream.Position = position3;
					}
				}
			}
		}

		// Token: 0x04000D58 RID: 3416
		private static readonly int int_0 = 2;

		// Token: 0x04000D59 RID: 3417
		private static byte[] byte_0 = new byte[]
		{
			67,
			80,
			67
		};

		// Token: 0x04000D5A RID: 3418
		public static byte[] byte_1 = new byte[]
		{
			84,
			84,
			80
		};

		// Token: 0x04000D5B RID: 3419
		private static Struct43 struct43_0 = new Struct43("c21f969b5f03d33d43e04f8f136e7682");

		// Token: 0x04000D5C RID: 3420
		private MemoryStream memoryStream_0;

		// Token: 0x04000D5D RID: 3421
		[CompilerGenerated]
		private Enum82 enum82_0;

		// Token: 0x04000D5E RID: 3422
		[CompilerGenerated]
		private Guid guid_0;

		// Token: 0x04000D5F RID: 3423
		[CompilerGenerated]
		private Struct43 struct43_1;

		// Token: 0x04000D60 RID: 3424
		[CompilerGenerated]
		private Uri uri_0;

		// Token: 0x04000D61 RID: 3425
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000D62 RID: 3426
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000D63 RID: 3427
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000D64 RID: 3428
		[CompilerGenerated]
		private Version version_0;

		// Token: 0x04000D65 RID: 3429
		[CompilerGenerated]
		private string string_3;

		// Token: 0x04000D66 RID: 3430
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000D67 RID: 3431
		[CompilerGenerated]
		private Bitmap bitmap_0;

		// Token: 0x04000D68 RID: 3432
		[CompilerGenerated]
		private Version version_1;

		// Token: 0x04000D69 RID: 3433
		[CompilerGenerated]
		private Class136 class136_0;

		// Token: 0x04000D6A RID: 3434
		[CompilerGenerated]
		private Struct43 struct43_2;

		// Token: 0x04000D6B RID: 3435
		[CompilerGenerated]
		private Dictionary<string, Struct43> dictionary_0;

		// Token: 0x04000D6C RID: 3436
		[CompilerGenerated]
		private Uri uri_1;
	}
}
