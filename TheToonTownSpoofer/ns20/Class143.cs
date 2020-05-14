using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using ns15;
using ns16;
using ns18;
using ns22;
using ns23;
using ns26;
using ns27;
using ns29;
using ns30;
using ns31;
using TSN.IO;

namespace ns20
{
	// Token: 0x02000437 RID: 1079
	internal sealed class Class143 : Class123
	{
		// Token: 0x060028EE RID: 10478 RVA: 0x0009A9DC File Offset: 0x00098BDC
		public static Class143 smethod_0()
		{
			Class143 @class = null;
			try
			{
				@class = new Class143();
				if (File.Exists(Class291.string_14))
				{
					@class.method_7();
				}
				else
				{
					@class.method_8();
				}
			}
			catch (Exception ex)
			{
				if (@class != null)
				{
					@class.Dispose();
				}
				@class = null;
				ex.smethod_0();
			}
			if (@class == null)
			{
				try
				{
					@class = new Class143();
					@class.method_8();
				}
				catch
				{
					if (@class != null)
					{
						@class.Dispose();
					}
					@class = null;
					throw;
				}
			}
			return @class;
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x060028EF RID: 10479 RVA: 0x00005B5E File Offset: 0x00003D5E
		private int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x060028F0 RID: 10480 RVA: 0x00005B66 File Offset: 0x00003D66
		private int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x060028F1 RID: 10481 RVA: 0x00005B66 File Offset: 0x00003D66
		private int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x060028F2 RID: 10482 RVA: 0x00012C44 File Offset: 0x00010E44
		// (set) Token: 0x060028F3 RID: 10483 RVA: 0x00012C4C File Offset: 0x00010E4C
		public Size ThumbnailSize { get; private set; }

		// Token: 0x060028F4 RID: 10484 RVA: 0x0009AA60 File Offset: 0x00098C60
		public List<Class140> method_4()
		{
			List<Class140> list = new List<Class140>();
			foreach (KeyValuePair<string, Class143.Class144> keyValuePair in this.dictionary_0)
			{
				list.Add(keyValuePair.Value.class140_0);
			}
			return list;
		}

		// Token: 0x060028F5 RID: 10485 RVA: 0x0009AAC8 File Offset: 0x00098CC8
		public Bitmap method_5(string filePath)
		{
			Class143.Class144 @class = this.method_6(filePath);
			if (@class == null)
			{
				return null;
			}
			if (@class.class140_0.bitmap_0 != null)
			{
				return @class.class140_0.bitmap_0;
			}
			@class.memoryStream_0 = new MemoryStream();
			@class.stream3_0.Position = 0L;
			@class.stream3_0.CopyTo(@class.memoryStream_0);
			@class.memoryStream_0.Seek(0L, SeekOrigin.Begin);
			return @class.class140_0.bitmap_0 = (Bitmap)Image.FromStream(@class.memoryStream_0);
		}

		// Token: 0x060028F6 RID: 10486 RVA: 0x0009AB60 File Offset: 0x00098D60
		private Class143.Class144 method_6(string filePath)
		{
			string fileName = Path.GetFileName(filePath);
			if (this.dictionary_0.ContainsKey(fileName))
			{
				long num;
				DateTime d;
				Class234.smethod_13(filePath, out num, out d);
				Class143.Class144 @class = this.dictionary_0[fileName];
				if (@class.long_0 == num && @class.class140_0.DateCreated == d)
				{
					return @class;
				}
				@class.Dispose();
				this.dictionary_0.Remove(fileName);
				this.int_0++;
			}
			Class143.Class144 class2 = null;
			Class143.Class144 result;
			try
			{
				class2 = new Class143.Class144();
				class2.struct43_0 = Class513.smethod_0(filePath);
				DateTime dateCreated;
				Class234.smethod_13(filePath, out class2.long_0, out dateCreated);
				class2.class140_0 = new Class140(fileName, filePath, dateCreated);
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(memoryStream))
					{
						using (Bitmap bitmap = (Bitmap)Image.FromFile(filePath))
						{
							binaryWriter.Write(fileName);
							binaryWriter.smethod_25(class2.struct43_0);
							binaryWriter.Write(class2.long_0);
							binaryWriter.Write(class2.class140_0.DateCreated.ToBinary());
							using (MemoryStream memoryStream2 = new MemoryStream())
							{
								Class157.smethod_9(bitmap, memoryStream2, 100, this.ThumbnailSize.Width, this.ThumbnailSize.Height);
								binaryWriter.Write(memoryStream2.Length);
								class2.long_1 = memoryStream2.Length;
								memoryStream2.Seek(0L, SeekOrigin.Begin);
								memoryStream2.CopyTo(memoryStream);
							}
							this.stream_0.Seek(0L, SeekOrigin.End);
							memoryStream.Seek(0L, SeekOrigin.Begin);
							memoryStream.CopyTo(this.stream_0);
						}
					}
				}
				this.stream_0.Seek(-class2.long_1, SeekOrigin.Current);
				class2.stream3_0 = new Stream3(this.stream_0, this.stream_0.Position, this.stream_0.Position + class2.long_1);
				this.dictionary_0.Add(fileName, class2);
				this.stream_0.Seek((long)(Class143.byte_0.Length + 4), SeekOrigin.Begin);
				using (Stream3 stream = new Stream3(this.stream_0))
				{
					using (BinaryWriter binaryWriter2 = new BinaryWriter(stream))
					{
						binaryWriter2.Write(this.dictionary_0.Count);
					}
				}
				result = class2;
			}
			catch (Exception ex)
			{
				if (class2 != null)
				{
					class2.Dispose();
				}
				ex.smethod_1(new object[]
				{
					filePath
				});
				result = null;
			}
			return result;
		}

		// Token: 0x060028F7 RID: 10487 RVA: 0x00012C55 File Offset: 0x00010E55
		private Class143()
		{
			this.class112_0 = Class110.Instance.ApplicationSettings;
			this.ThumbnailSize = new Size(170, 128);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x0009AECC File Offset: 0x000990CC
		public void method_7()
		{
			foreach (KeyValuePair<string, Class143.Class144> keyValuePair in this.dictionary_0)
			{
				keyValuePair.Value.Dispose();
			}
			this.dictionary_0.Clear();
			this.stream_0 = File.Open(Class291.string_14, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			using (Stream3 stream = new Stream3(this.stream_0))
			{
				using (BinaryReader binaryReader = new BinaryReader(stream))
				{
					byte[] array = Class143.byte_0;
					byte[] array2 = binaryReader.ReadBytes(array.Length);
					if (!array2.smethod_9(array))
					{
						throw new InvalidFileType(array, array2);
					}
					int num = binaryReader.ReadInt32();
					if (num < this.MinimumVersion || num > this.MaximumVersion)
					{
						throw new InvalidFileVersion<int>(this.MinimumVersion, this.MaximumVersion, num);
					}
					this.method_9(this.stream_0, binaryReader, num);
				}
			}
			foreach (string filePath in Class234.smethod_1(this.class112_0.ScreenshotSaveDirectory, "*.jpg", ".jpg"))
			{
				this.method_6(filePath);
			}
			if (this.int_0 > 10)
			{
				this.method_8();
			}
		}

		// Token: 0x060028F9 RID: 10489 RVA: 0x0009B03C File Offset: 0x0009923C
		public void method_8()
		{
			string text = Path.Combine(Class291.CommonApplicationDataDirectory, Guid.NewGuid().ToString() + ".tmp");
			using (Stream stream = File.Open(text, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
			{
				using (BinaryWriter binaryWriter = new BinaryWriter(stream))
				{
					byte[] array = Class143.byte_0;
					if (array != null)
					{
						binaryWriter.Write(array);
					}
					binaryWriter.Write(this.Version.Value);
					this.method_10(stream, binaryWriter);
				}
			}
			if (this.stream_0 != null)
			{
				this.stream_0.Close();
				this.stream_0.Dispose();
			}
			Class234.smethod_14(text, Class291.string_14, true);
			this.int_0 = 0;
			this.method_7();
		}

		// Token: 0x060028FA RID: 10490 RVA: 0x0009B11C File Offset: 0x0009931C
		private void method_9(Stream stream, BinaryReader reader, int version)
		{
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Class143.Class144 @class = null;
				try
				{
					@class = new Class143.Class144();
					string text = reader.ReadString();
					@class.struct43_0 = reader.smethod_24();
					@class.long_0 = reader.ReadInt64();
					string text2 = Path.Combine(this.class112_0.ScreenshotSaveDirectory, text);
					@class.class140_0 = new Class140(text, text2, DateTime.FromBinary(reader.ReadInt64()));
					@class.long_1 = reader.ReadInt64();
					if (File.Exists(text2))
					{
						@class.stream3_0 = new Stream3(stream, stream.Position, stream.Position + @class.long_1);
						if (this.dictionary_0.ContainsKey(text))
						{
							Class143.Class144 class2 = this.dictionary_0[text];
							class2.Dispose();
							this.dictionary_0.Remove(text);
						}
						this.dictionary_0.Add(text, @class);
					}
					else
					{
						this.int_0++;
						@class.Dispose();
					}
				}
				catch
				{
					if (@class != null)
					{
						@class.Dispose();
					}
					throw;
				}
				stream.Position += @class.long_1;
			}
		}

		// Token: 0x060028FB RID: 10491 RVA: 0x0009B250 File Offset: 0x00099450
		private void method_10(Stream stream, BinaryWriter writer)
		{
			writer.Write(this.dictionary_0.Count);
			foreach (KeyValuePair<string, Class143.Class144> keyValuePair in this.dictionary_0)
			{
				Class143.Class144 value = keyValuePair.Value;
				writer.Write(keyValuePair.Key);
				writer.smethod_25(value.struct43_0);
				writer.Write(value.long_0);
				writer.smethod_31(value.class140_0.DateCreated);
				writer.Write(value.long_1);
				value.stream3_0.Position = 0L;
				value.stream3_0.CopyTo(stream);
			}
		}

		// Token: 0x060028FC RID: 10492 RVA: 0x0009B318 File Offset: 0x00099518
		protected override void vmethod_0()
		{
			foreach (KeyValuePair<string, Class143.Class144> keyValuePair in this.dictionary_0)
			{
				keyValuePair.Value.Dispose();
			}
			this.dictionary_0.Clear();
			if (this.stream_0 != null)
			{
				this.stream_0.Close();
				this.stream_0.Dispose();
				this.stream_0 = null;
			}
			base.vmethod_0();
		}

		// Token: 0x040014CB RID: 5323
		private static readonly byte[] byte_0 = new byte[]
		{
			77,
			71,
			84,
			67,
			83
		};

		// Token: 0x040014CC RID: 5324
		private Dictionary<string, Class143.Class144> dictionary_0 = new Dictionary<string, Class143.Class144>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x040014CD RID: 5325
		private Stream stream_0;

		// Token: 0x040014CE RID: 5326
		private int int_0;

		// Token: 0x040014CF RID: 5327
		private Class112 class112_0;

		// Token: 0x040014D0 RID: 5328
		[CompilerGenerated]
		private Size size_0;

		// Token: 0x02000438 RID: 1080
		private sealed class Class144 : Class123
		{
			// Token: 0x060028FE RID: 10494 RVA: 0x0009B3A8 File Offset: 0x000995A8
			protected override void vmethod_0()
			{
				if (this.stream3_0 != null)
				{
					this.stream3_0.Dispose();
				}
				this.stream3_0 = null;
				if (this.memoryStream_0 != null)
				{
					this.memoryStream_0.Dispose();
				}
				this.memoryStream_0 = null;
				if (this.class140_0 != null)
				{
					this.class140_0.Dispose();
				}
				this.class140_0 = null;
				base.vmethod_0();
			}

			// Token: 0x040014D1 RID: 5329
			public Class140 class140_0;

			// Token: 0x040014D2 RID: 5330
			public Struct43 struct43_0;

			// Token: 0x040014D3 RID: 5331
			public long long_0;

			// Token: 0x040014D4 RID: 5332
			public long long_1;

			// Token: 0x040014D5 RID: 5333
			public Stream3 stream3_0;

			// Token: 0x040014D6 RID: 5334
			public MemoryStream memoryStream_0;
		}
	}
}
