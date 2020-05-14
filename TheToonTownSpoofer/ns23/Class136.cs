using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using ns20;
using ns21;
using ns22;
using ns25;
using ns26;
using ns27;
using ns30;
using ns31;
using TSN.Collections;
using TSN.IO;

namespace ns23
{
	// Token: 0x020003A7 RID: 935
	internal sealed class Class136 : Class123, IEnumerable<KeyValuePair<string, Class338>>, IEnumerable
	{
		// Token: 0x0600243E RID: 9278 RVA: 0x0007AC18 File Offset: 0x00078E18
		public static void smethod_0(Class321 pd, BinaryWriter write_stream, uint offset_orig, uint offset_new, Stream stream_orig, Stream stream_new)
		{
			using (Stream3 stream = new Stream3(stream_orig))
			{
				using (Stream3 stream2 = new Stream3(stream_new))
				{
					using (Class136 @class = new Class136(stream))
					{
						using (Class136 class2 = new Class136(stream2))
						{
							List<KeyValuePair<string, Class136.Class339>> list = new List<KeyValuePair<string, Class136.Class339>>();
							List<KeyValuePair<string, Class136.Class339>> list2 = null;
							long endPosition;
							class2.method_9(ref list, out endPosition);
							long endPosition2;
							@class.method_9(ref list2, out endPosition2);
							using (Stream3 stream3 = new Stream3(stream, 0L, endPosition2))
							{
								using (Stream3 stream4 = new Stream3(stream2, 0L, endPosition))
								{
									Class292.smethod_12(pd, Enum81.const_0, write_stream, offset_orig, offset_new, stream3, stream4);
								}
							}
							foreach (KeyValuePair<string, Class136.Class339> keyValuePair in list)
							{
								if (@class.method_6(keyValuePair.Key))
								{
									Class136.Class339 class3 = @class[keyValuePair.Key] as Class136.Class339;
									Class136.smethod_1(pd, write_stream, offset_orig, offset_new, keyValuePair.Key, stream, class3.uint_4, class3.uint_4 + class3.DataLength, stream2, keyValuePair.Value.uint_4, keyValuePair.Value.uint_4 + keyValuePair.Value.DataLength);
								}
								else
								{
									class2.method_15(keyValuePair.Value);
									Class292.smethod_4(pd, write_stream, keyValuePair.Value.DataLength, keyValuePair.Value.Data, 0U, 0U, 0U);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600243F RID: 9279 RVA: 0x0007AE64 File Offset: 0x00079064
		private static void smethod_1(Class321 pd, BinaryWriter write_stream, uint offset_orig, uint offset_new, string filename, Stream stream_orig, uint orig_start, uint orig_end, Stream stream_new, uint new_start, uint new_end)
		{
			uint num = new_end - new_start;
			uint num2 = orig_end - orig_start;
			using (Stream3 stream = new Stream3(stream_orig, (long)((ulong)orig_start), (long)((ulong)orig_end)))
			{
				using (Stream3 stream2 = new Stream3(stream_new, (long)((ulong)new_start), (long)((ulong)new_end)))
				{
					if (num == num2 && Struct43.smethod_5(stream.smethod_2(), stream2.smethod_2()))
					{
						Class292.smethod_4(pd, write_stream, 0U, null, 0U, num2, offset_orig + orig_start);
					}
					else
					{
						Class292.smethod_12(pd, Class292.smethod_15(filename), write_stream, offset_orig + orig_start, offset_new + new_start, stream, stream2);
					}
				}
			}
		}

		// Token: 0x06002440 RID: 9280 RVA: 0x0007AF10 File Offset: 0x00079110
		private static bool smethod_2(Stream file_stream, out byte[] header)
		{
			long position = file_stream.Position;
			header = new byte[Class136.byte_0.Length];
			file_stream.Read(header, 0, Class136.byte_0.Length);
			file_stream.Position = position;
			return header.smethod_9(Class136.byte_0);
		}

		// Token: 0x06002441 RID: 9281 RVA: 0x0007AF58 File Offset: 0x00079158
		public static bool smethod_3(Stream file_stream1, Stream file_stream2)
		{
			byte[] enumeration;
			byte[] enumeration2;
			return Class136.smethod_2(file_stream1, out enumeration) && Class136.smethod_2(file_stream2, out enumeration2) && enumeration.smethod_9(enumeration2);
		}

		// Token: 0x06002442 RID: 9282 RVA: 0x0007AF84 File Offset: 0x00079184
		public static Enum68 smethod_4(string file)
		{
			string a;
			if ((a = Path.GetExtension(file).ToLower()) != null)
			{
				if (a == ".jpg")
				{
					return Enum68.const_1;
				}
				if (a == ".rgb")
				{
					return Enum68.const_2;
				}
				if (a == ".wav")
				{
					return Enum68.const_3;
				}
				if (a == ".mp3")
				{
					return Enum68.const_4;
				}
				if (a == ".mid")
				{
					return Enum68.const_5;
				}
			}
			return Enum68.const_0;
		}

		// Token: 0x06002443 RID: 9283 RVA: 0x0007AFEC File Offset: 0x000791EC
		public static bool smethod_5(string file, out string multifile_name)
		{
			multifile_name = null;
			int num = 0;
			string text;
			if (!file.smethod_8('/', ref num, out text))
			{
				return false;
			}
			if (!Class136.smethod_7(text))
			{
				return false;
			}
			multifile_name = text;
			return true;
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x0007B01C File Offset: 0x0007921C
		public static bool smethod_6(string multifile_name)
		{
			int num = 0;
			string text;
			decimal d;
			return multifile_name.smethod_8('_', ref num, out text) && !(text.ToLower() != "phase") && multifile_name.smethod_11(".mf", ref num, out text) && decimal.TryParse(text, out d) && (d != 1m && d != 2m) && num == multifile_name.Length;
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x0007B098 File Offset: 0x00079298
		public static bool smethod_7(string multifile_name)
		{
			int num = 0;
			string text;
			decimal d;
			return multifile_name.smethod_8('_', ref num, out text) && !(text.ToLower() != "phase") && multifile_name.smethod_7(ref num, out text) && decimal.TryParse(text, out d) && d != 1m && d != 2m;
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x0007B104 File Offset: 0x00079304
		public static bool smethod_8(string file)
		{
			if (string.IsNullOrEmpty(file))
			{
				return false;
			}
			int num = 0;
			string text;
			if (!file.smethod_8('/', ref num, out text))
			{
				return false;
			}
			if (!Class136.smethod_7(text))
			{
				return false;
			}
			if (!file.smethod_8('/', ref num, out text))
			{
				return false;
			}
			string a;
			if ((a = text.ToLower()) != null)
			{
				if (a == "audio")
				{
					string a2;
					string a3;
					return file.smethod_8('/', ref num, out text) && ((a2 = text.ToLower()) != null && (a2 == "bgm" || a2 == "dial" || a2 == "sfx")) && file.smethod_14('.', ref num, out text) && ((a3 = text.ToLower()) != null && (a3 == "wav" || a3 == "mp3" || a3 == "mid"));
				}
				if (a == "maps")
				{
					string a4;
					return file.smethod_14('.', ref num, out text) && ((a4 = text.ToLower()) != null && (a4 == "jpg" || a4 == "rgb"));
				}
			}
			return false;
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x06002447 RID: 9287 RVA: 0x0000FB16 File Offset: 0x0000DD16
		public ReadOnlyDictionary<string, Class338> MultiFileData
		{
			get
			{
				if (this.readOnlyDictionary_0 == null)
				{
					this.readOnlyDictionary_0 = new ReadOnlyDictionary<string, Class338>(this.dictionary_0);
				}
				return this.readOnlyDictionary_0;
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x06002448 RID: 9288 RVA: 0x0000FB37 File Offset: 0x0000DD37
		// (set) Token: 0x06002449 RID: 9289 RVA: 0x0000FB3F File Offset: 0x0000DD3F
		public short MajorVersion
		{
			get
			{
				return this.short_0;
			}
			set
			{
				this.short_0 = value;
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x0600244A RID: 9290 RVA: 0x0000FB48 File Offset: 0x0000DD48
		// (set) Token: 0x0600244B RID: 9291 RVA: 0x0000FB50 File Offset: 0x0000DD50
		public short MinorVersion
		{
			get
			{
				return this.short_1;
			}
			set
			{
				this.short_1 = value;
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x0600244C RID: 9292 RVA: 0x0000FB59 File Offset: 0x0000DD59
		// (set) Token: 0x0600244D RID: 9293 RVA: 0x0000FB61 File Offset: 0x0000DD61
		public uint Scale
		{
			get
			{
				return this.uint_0;
			}
			set
			{
				this.uint_0 = value;
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x0600244E RID: 9294 RVA: 0x0007B23C File Offset: 0x0007943C
		// (set) Token: 0x0600244F RID: 9295 RVA: 0x0007B268 File Offset: 0x00079468
		public DateTime TimeStamp
		{
			get
			{
				return Class136.dateTime_0.AddSeconds(this.uint_1).ToLocalTime();
			}
			set
			{
				this.uint_1 = (uint)value.ToUniversalTime().Subtract(Class136.dateTime_0).TotalSeconds;
			}
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x0007B298 File Offset: 0x00079498
		protected override void vmethod_0()
		{
			if (this.stream_0 != null)
			{
				this.stream_0.Close();
				this.stream_0.Dispose();
			}
			if (this.binaryReader_0 != null)
			{
				this.binaryReader_0.Dispose();
			}
			if (this.binaryWriter_0 != null)
			{
				this.binaryWriter_0.Dispose();
			}
			base.vmethod_0();
		}

		// Token: 0x17000958 RID: 2392
		public Class338 this[string name]
		{
			get
			{
				return this.dictionary_0[name];
			}
		}

		// Token: 0x06002452 RID: 9298 RVA: 0x0007B2F0 File Offset: 0x000794F0
		public Class338 method_4(string name)
		{
			if (this.dictionary_0.ContainsKey(name))
			{
				throw new ArgumentException(string.Format("The specified key already exists: '{0}'.", name));
			}
			Class136.Class339 @class = new Class136.Class339();
			@class.LoadedFromStream = false;
			this.dictionary_0.Add(name, @class);
			return @class;
		}

		// Token: 0x06002453 RID: 9299 RVA: 0x0000FB78 File Offset: 0x0000DD78
		public void method_5(string name)
		{
			if (!this.dictionary_0.ContainsKey(name))
			{
				throw new ArgumentException(string.Format("The specified key does not exists: '{0}'.", name));
			}
			this.dictionary_0.Remove(name);
		}

		// Token: 0x06002454 RID: 9300 RVA: 0x0000FBA6 File Offset: 0x0000DDA6
		public bool method_6(string name)
		{
			return this.dictionary_0.ContainsKey(name);
		}

		// Token: 0x06002455 RID: 9301 RVA: 0x0007B338 File Offset: 0x00079538
		public IEnumerator<KeyValuePair<string, Class338>> GetEnumerator()
		{
			Class136.Class375 @class = new Class136.Class375(0);
			@class.class136_0 = this;
			return @class;
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x0000FBB4 File Offset: 0x0000DDB4
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		public Class136(Stream str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			this.stream_0 = str;
			this.dictionary_0 = new Dictionary<string, Class338>(StringComparer.OrdinalIgnoreCase);
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x0000FBE9 File Offset: 0x0000DDE9
		public Class136()
		{
			this.Scale = 1U;
			this.MajorVersion = 1;
			this.MinorVersion = 1;
			this.TimeStamp = DateTime.Now;
			this.dictionary_0 = new Dictionary<string, Class338>(StringComparer.OrdinalIgnoreCase);
			this.bool_2 = true;
		}

		// Token: 0x06002459 RID: 9305 RVA: 0x0000FC28 File Offset: 0x0000DE28
		private void method_7()
		{
			if (this.stream_0 == null)
			{
				throw new NullReferenceException("There is no stream to use.");
			}
		}

		// Token: 0x0600245A RID: 9306 RVA: 0x0007B354 File Offset: 0x00079554
		public Class337 method_8(string indexName)
		{
			if (this.method_6(indexName))
			{
				Class337 @class = new Class337();
				Class338 class2 = this[indexName];
				this.method_15(class2);
				@class.method_0(Encoding.ASCII.GetString(class2.Data));
				return @class;
			}
			return null;
		}

		// Token: 0x0600245B RID: 9307 RVA: 0x0007B398 File Offset: 0x00079598
		private void method_9(ref List<KeyValuePair<string, Class136.Class339>> sortedCollection, out long endOfIndex)
		{
			this.method_7();
			if (this.binaryReader_0 == null)
			{
				this.binaryReader_0 = new BinaryReader(this.stream_0);
			}
			Class136.smethod_9(this.stream_0, this.binaryReader_0, out this.short_0, out this.short_1, out this.uint_0, out this.uint_1, ref this.dictionary_0, ref sortedCollection);
			endOfIndex = this.stream_0.Position;
			this.bool_2 = true;
		}

		// Token: 0x0600245C RID: 9308 RVA: 0x0007B408 File Offset: 0x00079608
		public void method_10()
		{
			List<KeyValuePair<string, Class136.Class339>> list = null;
			long num;
			this.method_9(ref list, out num);
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x0007B424 File Offset: 0x00079624
		public void method_11()
		{
			this.method_7();
			if (!this.bool_2)
			{
				throw new InvalidOperationException("The index has not been loaded.");
			}
			if (this.binaryReader_0 == null)
			{
				this.binaryReader_0 = new BinaryReader(this.stream_0);
			}
			Class136.smethod_10(this.stream_0, this.binaryReader_0, this.dictionary_0);
		}

		// Token: 0x0600245E RID: 9310 RVA: 0x0000FC3D File Offset: 0x0000DE3D
		public void method_12()
		{
			this.method_10();
			this.method_11();
		}

		// Token: 0x0600245F RID: 9311 RVA: 0x0007B47C File Offset: 0x0007967C
		public void method_13(IEnumerable<string> names)
		{
			this.method_7();
			if (!this.bool_2)
			{
				throw new InvalidOperationException("The index has not been loaded.");
			}
			if (this.binaryReader_0 == null)
			{
				this.binaryReader_0 = new BinaryReader(this.stream_0);
			}
			Class136.smethod_12(this.stream_0, this.binaryReader_0, this.dictionary_0, names);
		}

		// Token: 0x06002460 RID: 9312 RVA: 0x0000FC4B File Offset: 0x0000DE4B
		public void method_14(IEnumerable<string> names)
		{
			this.method_10();
			this.method_13(names);
		}

		// Token: 0x06002461 RID: 9313 RVA: 0x0007B4D4 File Offset: 0x000796D4
		public void method_15(Class338 data)
		{
			this.method_7();
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (!this.bool_2)
			{
				throw new InvalidOperationException("The index has not been loaded.");
			}
			Class136.Class339 @class = data as Class136.Class339;
			if (@class == null)
			{
				throw new ArgumentException("data is not MultiFileDataDetails.");
			}
			if (!this.dictionary_0.ContainsValue(@class))
			{
				throw new ArgumentException("The data was not loaded from the MultiFile.");
			}
			Class136.smethod_11(this.stream_0, this.binaryReader_0, @class);
		}

		// Token: 0x06002462 RID: 9314 RVA: 0x0007B548 File Offset: 0x00079748
		public void method_16(IEnumerable<Class338> data)
		{
			this.method_7();
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			if (!this.bool_2)
			{
				throw new InvalidOperationException("The index has not been loaded.");
			}
			foreach (Class338 @class in data)
			{
				Class136.Class339 class2 = @class as Class136.Class339;
				if (class2 == null)
				{
					throw new ArgumentException("Item is not MultiFileDataDetails.");
				}
				if (!this.dictionary_0.ContainsValue(class2))
				{
					throw new ArgumentException("The item was not loaded from the MultiFile.");
				}
				Class136.smethod_11(this.stream_0, this.binaryReader_0, class2);
			}
		}

		// Token: 0x06002463 RID: 9315 RVA: 0x0007B5F4 File Offset: 0x000797F4
		public void method_17(Stream str, BinaryWriter writer)
		{
			if (!this.bool_2)
			{
				throw new InvalidOperationException("The index has not been loaded.");
			}
			if (writer.BaseStream != str)
			{
				throw new ArgumentException("The BinaryWriter has an incorrect base stream.");
			}
			IEnumerable<KeyValuePair<string, Class338>> source = this.dictionary_0;
			if (Class136.func_1 == null)
			{
				Class136.func_1 = new Func<KeyValuePair<string, Class338>, KeyValuePair<string, Class136.Class339>>(Class136.smethod_19);
			}
			List<KeyValuePair<string, Class136.Class339>> list = source.Select(Class136.func_1).ToList<KeyValuePair<string, Class136.Class339>>();
			List<KeyValuePair<string, Class136.Class339>> list2 = list;
			if (Class136.comparison_0 == null)
			{
				Class136.comparison_0 = new Comparison<KeyValuePair<string, Class136.Class339>>(Class136.smethod_20);
			}
			list2.Sort(Class136.comparison_0);
			Class136.smethod_13(str, writer, this.short_0, this.short_1, this.uint_0, this.uint_1, list);
		}

		// Token: 0x06002464 RID: 9316 RVA: 0x0007B69C File Offset: 0x0007989C
		public void method_18()
		{
			this.method_7();
			if (!this.bool_2)
			{
				throw new InvalidOperationException("The index has not been loaded.");
			}
			if (this.binaryWriter_0 == null)
			{
				this.binaryWriter_0 = new BinaryWriter(this.stream_0);
			}
			this.stream_0.Position = 0L;
			this.stream_0.SetLength(0L);
			this.method_17(this.stream_0, this.binaryWriter_0);
		}

		// Token: 0x06002465 RID: 9317 RVA: 0x0007B718 File Offset: 0x00079918
		private static void smethod_9(Stream str, BinaryReader reader, out short majorVersion, out short minorVersion, out uint scale, out uint timeStamp, ref Dictionary<string, Class338> data, ref List<KeyValuePair<string, Class136.Class339>> orderedData)
		{
			byte[] array = reader.ReadBytes(Class136.byte_0.Length);
			if (!array.smethod_9(Class136.byte_0))
			{
				throw new InvalidFileType(Class136.byte_0, array);
			}
			majorVersion = reader.ReadInt16();
			minorVersion = reader.ReadInt16();
			scale = reader.ReadUInt32();
			timeStamp = reader.ReadUInt32();
			if (scale == 0U)
			{
				scale = 1U;
			}
			for (;;)
			{
				uint num = reader.ReadUInt32() * scale;
				if (num == 0U)
				{
					break;
				}
				Class136.Class339 @class = new Class136.Class339();
				@class.LoadedFromStream = true;
				@class.uint_5 = num;
				@class.uint_4 = reader.ReadUInt32() * scale;
				@class.DataLength = reader.ReadUInt32();
				@class.Flags = reader.ReadUInt16();
				if (@class.Compressed)
				{
					@class.DecompressedLength = reader.ReadUInt32();
				}
				else
				{
					@class.DecompressedLength = @class.DataLength;
				}
				@class.TimeStamp = reader.ReadUInt32();
				ushort count = reader.ReadUInt16();
				byte[] data2 = reader.ReadBytes((int)count);
				string key = Class136.smethod_15(data2);
				data.Add(key, @class);
				if (orderedData != null)
				{
					orderedData.Add(new KeyValuePair<string, Class136.Class339>(key, @class));
				}
				str.Position = (long)((ulong)num);
			}
		}

		// Token: 0x06002466 RID: 9318 RVA: 0x0007B83C File Offset: 0x00079A3C
		private static void smethod_10(Stream str, BinaryReader reader, Dictionary<string, Class338> data)
		{
			Class338[] array = data.Values.ToArray<Class338>();
			for (int i = 0; i < array.Length; i++)
			{
				Class136.smethod_11(str, reader, array[i] as Class136.Class339);
			}
		}

		// Token: 0x06002467 RID: 9319 RVA: 0x0000FC5A File Offset: 0x0000DE5A
		private static void smethod_11(Stream str, BinaryReader reader, Class136.Class339 mfd)
		{
			str.Position = (long)((ulong)mfd.uint_4);
			if (mfd.DataLength > 0U)
			{
				mfd.Data = reader.ReadBytes((int)mfd.DataLength);
				return;
			}
			mfd.Data = new byte[0];
		}

		// Token: 0x06002468 RID: 9320 RVA: 0x0007B874 File Offset: 0x00079A74
		private static void smethod_12(Stream str, BinaryReader reader, Dictionary<string, Class338> data, IEnumerable<string> names)
		{
			using (IEnumerator<string> enumerator = names.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (data.ContainsKey(enumerator.Current))
					{
						Class136.smethod_11(str, reader, data[enumerator.Current] as Class136.Class339);
					}
				}
			}
		}

		// Token: 0x06002469 RID: 9321 RVA: 0x0007B8D8 File Offset: 0x00079AD8
		private static void smethod_13(Stream str, BinaryWriter writer, short majorVersion, short minorVersion, uint scale, uint timeStamp, List<KeyValuePair<string, Class136.Class339>> data)
		{
			foreach (KeyValuePair<string, Class136.Class339> keyValuePair in data)
			{
				if (!keyValuePair.Value.Populated)
				{
					throw new NotSupportedException(string.Format("Item: '{0}' is not populated.", keyValuePair.Key));
				}
			}
			writer.Write(Class136.byte_0);
			writer.Write(majorVersion);
			writer.Write(minorVersion);
			writer.Write(scale);
			writer.Write(timeStamp);
			Class136.smethod_16(str, scale);
			foreach (KeyValuePair<string, Class136.Class339> keyValuePair2 in data)
			{
				keyValuePair2.Value.uint_3 = (uint)str.Position;
				writer.Write(0);
				writer.Write(0);
				writer.Write(keyValuePair2.Value.DataLength);
				writer.Write(keyValuePair2.Value.Flags);
				if (keyValuePair2.Value.Compressed)
				{
					writer.Write(keyValuePair2.Value.DecompressedLength);
				}
				writer.Write(keyValuePair2.Value.TimeStamp);
				writer.Write((ushort)keyValuePair2.Key.Length);
				writer.Write(Class136.smethod_14(keyValuePair2.Key));
				Class136.smethod_16(str, scale);
			}
			int num = (int)str.Position;
			writer.Write(0);
			Class136.smethod_16(str, scale);
			for (int i = 0; i < data.Count; i++)
			{
				data[i].Value.uint_4 = (uint)str.Position / scale;
				writer.Write(data[i].Value.Data, 0, (int)data[i].Value.DataLength);
				Class136.smethod_16(str, scale);
			}
			long position = str.Position;
			for (int j = 0; j < data.Count; j++)
			{
				str.Position = (long)((ulong)(data[j].Value.uint_3 / scale));
				data[j].Value.uint_5 = (uint)((long)((j < data.Count - 1) ? data[j + 1].Value.uint_3 : ((uint)num)) / (long)((ulong)scale));
				writer.Write(data[j].Value.uint_5);
				writer.Write(data[j].Value.uint_4);
			}
			str.Position = position;
		}

		// Token: 0x0600246A RID: 9322 RVA: 0x0007BBB0 File Offset: 0x00079DB0
		private static byte[] smethod_14(string data)
		{
			byte[] array = new byte[data.Length];
			for (int i = 0; i < data.Length; i++)
			{
				array[i] = (byte)(data[i] ^ 'ÿ');
			}
			return array;
		}

		// Token: 0x0600246B RID: 9323 RVA: 0x0007BBEC File Offset: 0x00079DEC
		private static string smethod_15(byte[] data)
		{
			string text = string.Empty;
			for (int i = 0; i < data.Length; i++)
			{
				text += (char)(data[i] ^ byte.MaxValue);
			}
			return text;
		}

		// Token: 0x0600246C RID: 9324 RVA: 0x0007BC24 File Offset: 0x00079E24
		private static void smethod_16(Stream str, uint scale)
		{
			if (scale == 1U)
			{
				return;
			}
			uint num = Class136.smethod_17((uint)str.Position, scale);
			while (str.Position < (long)((ulong)num))
			{
				str.WriteByte(0);
			}
		}

		// Token: 0x0600246D RID: 9325 RVA: 0x0000FC91 File Offset: 0x0000DE91
		private static uint smethod_17(uint position, uint scale)
		{
			if (position % scale == 0U)
			{
				return position;
			}
			return position - position % scale + scale;
		}

		// Token: 0x0600246E RID: 9326 RVA: 0x0000FCA1 File Offset: 0x0000DEA1
		[CompilerGenerated]
		private static KeyValuePair<string, Class338> smethod_18(KeyValuePair<string, Class338> item)
		{
			return new KeyValuePair<string, Class338>(item.Key, item.Value);
		}

		// Token: 0x0600246F RID: 9327 RVA: 0x0000FCB6 File Offset: 0x0000DEB6
		[CompilerGenerated]
		private static KeyValuePair<string, Class136.Class339> smethod_19(KeyValuePair<string, Class338> item)
		{
			return new KeyValuePair<string, Class136.Class339>(item.Key, item.Value as Class136.Class339);
		}

		// Token: 0x06002470 RID: 9328 RVA: 0x0000FCD0 File Offset: 0x0000DED0
		[CompilerGenerated]
		private static int smethod_20(KeyValuePair<string, Class136.Class339> x, KeyValuePair<string, Class136.Class339> y)
		{
			return string.CompareOrdinal(x.Key, y.Key);
		}

		// Token: 0x040010D2 RID: 4306
		public static readonly DateTime dateTime_0 = new DateTime(1970, 1, 1, 0, 0, 0, 0);

		// Token: 0x040010D3 RID: 4307
		private static readonly byte[] byte_0 = new byte[]
		{
			112,
			109,
			102,
			0,
			10,
			13
		};

		// Token: 0x040010D4 RID: 4308
		private ReadOnlyDictionary<string, Class338> readOnlyDictionary_0;

		// Token: 0x040010D5 RID: 4309
		private Dictionary<string, Class338> dictionary_0;

		// Token: 0x040010D6 RID: 4310
		private short short_0;

		// Token: 0x040010D7 RID: 4311
		private short short_1;

		// Token: 0x040010D8 RID: 4312
		private uint uint_0;

		// Token: 0x040010D9 RID: 4313
		private uint uint_1;

		// Token: 0x040010DA RID: 4314
		private Stream stream_0;

		// Token: 0x040010DB RID: 4315
		private BinaryReader binaryReader_0;

		// Token: 0x040010DC RID: 4316
		private BinaryWriter binaryWriter_0;

		// Token: 0x040010DD RID: 4317
		private bool bool_2;

		// Token: 0x040010DE RID: 4318
		[CompilerGenerated]
		private static Func<KeyValuePair<string, Class338>, KeyValuePair<string, Class338>> func_0;

		// Token: 0x040010DF RID: 4319
		[CompilerGenerated]
		private static Func<KeyValuePair<string, Class338>, KeyValuePair<string, Class136.Class339>> func_1;

		// Token: 0x040010E0 RID: 4320
		[CompilerGenerated]
		private static Comparison<KeyValuePair<string, Class136.Class339>> comparison_0;

		// Token: 0x020003A8 RID: 936
		private sealed class Class339 : Class338
		{
			// Token: 0x17000959 RID: 2393
			// (get) Token: 0x06002472 RID: 9330 RVA: 0x0000FD12 File Offset: 0x0000DF12
			// (set) Token: 0x06002473 RID: 9331 RVA: 0x0000FD1A File Offset: 0x0000DF1A
			public bool LoadedFromStream
			{
				get
				{
					return this.bool_1;
				}
				set
				{
					this.bool_1 = value;
				}
			}

			// Token: 0x1700095A RID: 2394
			// (get) Token: 0x06002474 RID: 9332 RVA: 0x0000FD23 File Offset: 0x0000DF23
			// (set) Token: 0x06002475 RID: 9333 RVA: 0x0000FD2B File Offset: 0x0000DF2B
			public new uint TimeStamp
			{
				get
				{
					return this.uint_1;
				}
				set
				{
					this.uint_1 = value;
				}
			}

			// Token: 0x1700095B RID: 2395
			// (get) Token: 0x06002476 RID: 9334 RVA: 0x0000FD34 File Offset: 0x0000DF34
			// (set) Token: 0x06002477 RID: 9335 RVA: 0x0000FD3C File Offset: 0x0000DF3C
			public uint DecompressedLength
			{
				get
				{
					return this.uint_0;
				}
				set
				{
					this.uint_0 = value;
				}
			}

			// Token: 0x1700095C RID: 2396
			// (get) Token: 0x06002478 RID: 9336 RVA: 0x0000FD45 File Offset: 0x0000DF45
			// (set) Token: 0x06002479 RID: 9337 RVA: 0x0000FD4D File Offset: 0x0000DF4D
			public uint DataLength
			{
				get
				{
					return this.uint_2;
				}
				set
				{
					this.uint_2 = value;
				}
			}

			// Token: 0x1700095D RID: 2397
			// (get) Token: 0x0600247A RID: 9338 RVA: 0x0000FD56 File Offset: 0x0000DF56
			// (set) Token: 0x0600247B RID: 9339 RVA: 0x0000FD5E File Offset: 0x0000DF5E
			public new byte[] Data
			{
				get
				{
					return this.byte_0;
				}
				set
				{
					this.byte_0 = value;
					this.bool_0 = (this.byte_0 != null);
				}
			}

			// Token: 0x1700095E RID: 2398
			// (get) Token: 0x0600247C RID: 9340 RVA: 0x0000FD79 File Offset: 0x0000DF79
			// (set) Token: 0x0600247D RID: 9341 RVA: 0x0000FD81 File Offset: 0x0000DF81
			public ushort Flags
			{
				get
				{
					return this.ushort_0;
				}
				set
				{
					this.ushort_0 = value;
				}
			}

			// Token: 0x1700095F RID: 2399
			// (get) Token: 0x0600247E RID: 9342 RVA: 0x0000FD8A File Offset: 0x0000DF8A
			public new bool Compressed
			{
				get
				{
					return base.Compressed;
				}
			}

			// Token: 0x040010E1 RID: 4321
			public uint uint_3;

			// Token: 0x040010E2 RID: 4322
			public uint uint_4;

			// Token: 0x040010E3 RID: 4323
			public uint uint_5;
		}
	}
}
