using System;
using System.Collections.Generic;
using System.IO;
using ns15;
using ns26;
using ns27;
using TSN.Collections;
using TSN.IO;

namespace ns19
{
	// Token: 0x020003F6 RID: 1014
	internal struct Struct40
	{
		// Token: 0x060026BF RID: 9919 RVA: 0x0008A8D8 File Offset: 0x00088AD8
		private static void smethod_0(Class177 district, Struct40 invasion, DateTime? endTime)
		{
			if (endTime != null)
			{
				List<uint> list;
				Dictionary<uint, uint> dictionary;
				Dictionary<uint, uint> dictionary2;
				Struct40.smethod_4(district, invasion.uint_0, invasion.class464_0, out list, out dictionary, out dictionary2);
				list.Add((uint)endTime.Value.ToUniversalTime().Subtract(invasion.dateTime_0).TotalSeconds);
				if (list.Count > Struct40.int_0)
				{
					list.RemoveAt(0);
				}
				if (dictionary.ContainsKey(invasion.uint_0))
				{
					dictionary[invasion.uint_0] = Struct40.smethod_5(district, invasion.uint_0, invasion.class464_0);
				}
				else
				{
					dictionary.Add(invasion.uint_0, Struct40.smethod_5(district, invasion.uint_0, invasion.class464_0));
				}
				if (dictionary2.ContainsKey(invasion.uint_0))
				{
					dictionary2[invasion.uint_0] = Struct40.smethod_6(district, invasion.uint_0);
				}
				else
				{
					dictionary2.Add(invasion.uint_0, Struct40.smethod_6(district, invasion.uint_0));
				}
			}
			Struct40.dictionary_3.Remove(district);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x0008A9F4 File Offset: 0x00088BF4
		public static void smethod_1(Class177 district, Class464 cog, uint cogsRemaining, bool skelecog, DateTime startTime, out uint? estimatedDuration, out DateTime actualStartTime)
		{
			lock (Struct40.object_0)
			{
				if (Struct40.dictionary_3.ContainsKey(district))
				{
					if (Struct40.dictionary_3[district].class464_0 == cog)
					{
						actualStartTime = Struct40.dictionary_3[district].dateTime_0;
						estimatedDuration = Struct40.dictionary_3[district].nullable_1;
						return;
					}
					Struct40.smethod_0(district, Struct40.dictionary_3[district], null);
				}
				Struct40 value = new Struct40(cog, cogsRemaining, skelecog, startTime.ToUniversalTime(), estimatedDuration = Struct40.smethod_7(district, cog, cogsRemaining));
				actualStartTime = value.dateTime_0;
				Struct40.dictionary_3.Add(district, value);
			}
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x0008AAD8 File Offset: 0x00088CD8
		public static void smethod_2(Class177 district)
		{
			lock (Struct40.object_0)
			{
				if (Struct40.dictionary_3.ContainsKey(district))
				{
					Struct40.smethod_0(district, Struct40.dictionary_3[district], null);
				}
			}
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x0008AB38 File Offset: 0x00088D38
		public static void smethod_3(Class177 district)
		{
			lock (Struct40.object_0)
			{
				if (Struct40.dictionary_3.ContainsKey(district))
				{
					Struct40.smethod_0(district, Struct40.dictionary_3[district], new DateTime?(DateTime.Now));
				}
			}
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x0008AB9C File Offset: 0x00088D9C
		private static void smethod_4(Class177 district, uint cogsRemaining, Class464 cog, out List<uint> timesCollection, out Dictionary<uint, uint> invasionTime, out Dictionary<uint, uint> invasionTimes)
		{
			Dictionary<Class464, Dictionary<uint, uint>> dictionary;
			if (Struct40.dictionary_0.ContainsKey(district))
			{
				dictionary = Struct40.dictionary_0[district];
			}
			else
			{
				Struct40.dictionary_0.Add(district, dictionary = new Dictionary<Class464, Dictionary<uint, uint>>());
			}
			if (dictionary.ContainsKey(cog))
			{
				invasionTime = dictionary[cog];
			}
			else
			{
				Dictionary<Class464, Dictionary<uint, uint>> dictionary2 = dictionary;
				Dictionary<uint, uint> value;
				invasionTime = (value = new Dictionary<uint, uint>());
				dictionary2.Add(cog, value);
			}
			if (Struct40.dictionary_1.ContainsKey(district))
			{
				invasionTimes = Struct40.dictionary_1[district];
			}
			else
			{
				Dictionary<Class177, Dictionary<uint, uint>> dictionary3 = Struct40.dictionary_1;
				Dictionary<uint, uint> value2;
				invasionTimes = (value2 = new Dictionary<uint, uint>());
				dictionary3.Add(district, value2);
			}
			Dictionary<Class464, Dictionary<uint, List<uint>>> dictionary4;
			if (Struct40.dictionary_2.ContainsKey(district))
			{
				dictionary4 = Struct40.dictionary_2[district];
			}
			else
			{
				Struct40.dictionary_2.Add(district, dictionary4 = new Dictionary<Class464, Dictionary<uint, List<uint>>>());
			}
			Dictionary<uint, List<uint>> dictionary5;
			if (dictionary4.ContainsKey(cog))
			{
				dictionary5 = dictionary4[cog];
			}
			else
			{
				dictionary4.Add(cog, dictionary5 = new Dictionary<uint, List<uint>>());
			}
			if (dictionary5.ContainsKey(cogsRemaining))
			{
				timesCollection = dictionary5[cogsRemaining];
				return;
			}
			Dictionary<uint, List<uint>> dictionary6 = dictionary5;
			List<uint> value3;
			timesCollection = (value3 = new List<uint>());
			dictionary6.Add(cogsRemaining, value3);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x0008ACA8 File Offset: 0x00088EA8
		private static uint smethod_5(Class177 district, uint cogsRemaining, Class464 cog)
		{
			uint num = 0U;
			List<uint> list = Struct40.dictionary_2[district][cog][cogsRemaining];
			foreach (uint num2 in list)
			{
				num += num2;
			}
			num /= (uint)list.Count;
			return num;
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x0008AD18 File Offset: 0x00088F18
		private static uint smethod_6(Class177 district, uint cogsRemaining)
		{
			uint num = 0U;
			uint num2 = 0U;
			foreach (Dictionary<uint, List<uint>> dictionary in Struct40.dictionary_2[district].Values)
			{
				if (dictionary.ContainsKey(cogsRemaining))
				{
					foreach (uint num3 in dictionary[cogsRemaining])
					{
						num += num3;
						num2 += 1U;
					}
				}
			}
			num /= num2;
			return num;
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x0008ADC8 File Offset: 0x00088FC8
		private static uint? smethod_7(Class177 district, Class464 cog, uint cogsRemaining)
		{
			uint? num;
			if (Struct40.dictionary_1.ContainsKey(district))
			{
				if (Struct40.dictionary_1[district].ContainsKey(cogsRemaining))
				{
					num = new uint?(Struct40.dictionary_1[district][cogsRemaining]);
					uint? num2 = Struct40.smethod_8(district, cog, cogsRemaining);
					if (num2 != null)
					{
						num -= num2.Value;
					}
				}
				else if (!Struct40.smethod_9(Struct40.dictionary_1[district], cogsRemaining, out num))
				{
					num = null;
				}
			}
			else
			{
				num = null;
			}
			return num;
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x0008AE80 File Offset: 0x00089080
		private static uint? smethod_8(Class177 district, Class464 cog, uint cogsRemaining)
		{
			if (!Struct40.dictionary_0.ContainsKey(district))
			{
				return null;
			}
			Dictionary<Class464, Dictionary<uint, uint>> dictionary = Struct40.dictionary_0[district];
			if (!dictionary.ContainsKey(cog))
			{
				return null;
			}
			Dictionary<uint, uint> dictionary2 = dictionary[cog];
			if (!dictionary2.ContainsKey(cogsRemaining))
			{
				return null;
			}
			uint num = dictionary2[cogsRemaining];
			if (!Struct40.dictionary_1.ContainsKey(district))
			{
				return null;
			}
			Dictionary<uint, uint> dictionary3 = Struct40.dictionary_1[district];
			if (!dictionary3.ContainsKey(cogsRemaining))
			{
				return null;
			}
			return new uint?(dictionary3[cogsRemaining] - num);
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x0008AF30 File Offset: 0x00089130
		private static bool smethod_9(Dictionary<uint, uint> dic, uint cogsRemaining, out uint? estimatedDuration)
		{
			estimatedDuration = null;
			uint num = uint.MaxValue;
			foreach (uint num2 in dic.Keys)
			{
				uint num3 = (uint)Math.Abs((int)(num2 - cogsRemaining));
				if (num > num3)
				{
					num = num3;
					estimatedDuration = new uint?(num2);
				}
			}
			if (estimatedDuration == null)
			{
				return false;
			}
			estimatedDuration = new uint?((uint)(cogsRemaining / estimatedDuration.Value * dic[estimatedDuration.Value]));
			return true;
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x0008AFD4 File Offset: 0x000891D4
		public static bool smethod_10(Class177 district, out Struct40? invasion)
		{
			bool result;
			lock (Struct40.object_0)
			{
				invasion = null;
				if (!Struct40.dictionary_3.ContainsKey(district))
				{
					result = false;
				}
				else
				{
					Struct40 @struct = Struct40.dictionary_3[district];
					if (@struct.nullable_0 != null && DateTime.Now.ToUniversalTime() < @struct.nullable_0.Value)
					{
						Struct40.smethod_0(district, @struct, null);
						result = false;
					}
					else
					{
						invasion = new Struct40?(@struct);
						result = true;
					}
				}
			}
			return result;
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x0001147A File Offset: 0x0000F67A
		private static void smethod_11()
		{
			Struct40.dictionary_0.Clear();
			Struct40.dictionary_1.Clear();
			Struct40.dictionary_2.Clear();
			Struct40.dictionary_3.Clear();
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x0008B08C File Offset: 0x0008928C
		public static void smethod_12(Stream stream)
		{
			lock (Struct40.object_0)
			{
				using (Stream3 stream2 = new Stream3(stream))
				{
					using (BinaryWriter binaryWriter = new BinaryWriter(stream2))
					{
						binaryWriter.Write(Struct40.byte_0);
						binaryWriter.Write(Struct40.dictionary_2.Count);
						using (Dictionary<Class177, Dictionary<Class464, Dictionary<uint, List<uint>>>>.Enumerator enumerator = Struct40.dictionary_2.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								BinaryWriter binaryWriter2 = binaryWriter;
								KeyValuePair<Class177, Dictionary<Class464, Dictionary<uint, List<uint>>>> keyValuePair = enumerator.Current;
								binaryWriter2.Write(keyValuePair.Key.uint_0);
								BinaryWriter binaryWriter3 = binaryWriter;
								KeyValuePair<Class177, Dictionary<Class464, Dictionary<uint, List<uint>>>> keyValuePair2 = enumerator.Current;
								binaryWriter3.Write(keyValuePair2.Value.Count);
								KeyValuePair<Class177, Dictionary<Class464, Dictionary<uint, List<uint>>>> keyValuePair3 = enumerator.Current;
								using (Dictionary<Class464, Dictionary<uint, List<uint>>>.Enumerator enumerator2 = keyValuePair3.Value.GetEnumerator())
								{
									while (enumerator2.MoveNext())
									{
										BinaryWriter binaryWriter4 = binaryWriter;
										KeyValuePair<Class464, Dictionary<uint, List<uint>>> keyValuePair4 = enumerator2.Current;
										binaryWriter4.Write(keyValuePair4.Key.string_1);
										BinaryWriter binaryWriter5 = binaryWriter;
										KeyValuePair<Class464, Dictionary<uint, List<uint>>> keyValuePair5 = enumerator2.Current;
										binaryWriter5.Write(keyValuePair5.Value.Count);
										KeyValuePair<Class464, Dictionary<uint, List<uint>>> keyValuePair6 = enumerator2.Current;
										using (Dictionary<uint, List<uint>>.Enumerator enumerator3 = keyValuePair6.Value.GetEnumerator())
										{
											while (enumerator3.MoveNext())
											{
												BinaryWriter binaryWriter6 = binaryWriter;
												KeyValuePair<uint, List<uint>> keyValuePair7 = enumerator3.Current;
												binaryWriter6.Write(keyValuePair7.Key);
												BinaryWriter binaryWriter7 = binaryWriter;
												KeyValuePair<uint, List<uint>> keyValuePair8 = enumerator3.Current;
												binaryWriter7.Write(keyValuePair8.Value.Count);
												KeyValuePair<uint, List<uint>> keyValuePair9 = enumerator3.Current;
												foreach (uint value in keyValuePair9.Value)
												{
													binaryWriter.Write(value);
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x0008B31C File Offset: 0x0008951C
		public static void smethod_13(Stream stream)
		{
			lock (Struct40.object_0)
			{
				Struct40.smethod_11();
				try
				{
					using (Stream3 stream2 = new Stream3(stream))
					{
						using (BinaryReader binaryReader = new BinaryReader(stream2))
						{
							byte[] array = binaryReader.ReadBytes(Struct40.byte_0.Length);
							if (!array.smethod_9(Struct40.byte_0))
							{
								throw new InvalidFileType(Struct40.byte_0, array);
							}
							int num = binaryReader.ReadInt32();
							for (int i = 0; i < num; i++)
							{
								Class177 @class = Class177.smethod_0(binaryReader.ReadUInt32());
								int num2 = binaryReader.ReadInt32();
								Dictionary<Class464, Dictionary<uint, uint>> dictionary;
								if (Struct40.dictionary_0.ContainsKey(@class))
								{
									dictionary = Struct40.dictionary_0[@class];
								}
								else
								{
									Struct40.dictionary_0.Add(@class, dictionary = new Dictionary<Class464, Dictionary<uint, uint>>());
								}
								Dictionary<Class464, Dictionary<uint, List<uint>>> dictionary2;
								if (Struct40.dictionary_2.ContainsKey(@class))
								{
									dictionary2 = Struct40.dictionary_2[@class];
								}
								else
								{
									Struct40.dictionary_2.Add(@class, dictionary2 = new Dictionary<Class464, Dictionary<uint, List<uint>>>());
								}
								Dictionary<uint, uint> dictionary3;
								if (Struct40.dictionary_1.ContainsKey(@class))
								{
									dictionary3 = Struct40.dictionary_1[@class];
								}
								else
								{
									Struct40.dictionary_1.Add(@class, dictionary3 = new Dictionary<uint, uint>());
								}
								for (int j = 0; j < num2; j++)
								{
									Class464 key = Class464.Cogs[binaryReader.ReadString()];
									int num3 = binaryReader.ReadInt32();
									Dictionary<uint, uint> dictionary4;
									if (dictionary.ContainsKey(key))
									{
										dictionary4 = dictionary[key];
									}
									else
									{
										dictionary.Add(key, dictionary4 = new Dictionary<uint, uint>());
									}
									Dictionary<uint, List<uint>> dictionary5;
									if (dictionary2.ContainsKey(key))
									{
										dictionary5 = dictionary2[key];
									}
									else
									{
										dictionary2.Add(key, dictionary5 = new Dictionary<uint, List<uint>>());
									}
									for (int k = 0; k < num3; k++)
									{
										uint key2 = binaryReader.ReadUInt32();
										int num4 = binaryReader.ReadInt32();
										List<uint> list;
										if (dictionary5.ContainsKey(key2))
										{
											list = dictionary5[key2];
										}
										else
										{
											dictionary5.Add(key2, list = new List<uint>());
										}
										uint num5 = 0U;
										for (int l = 0; l < num4; l++)
										{
											uint num6 = binaryReader.ReadUInt32();
											list.Add(num6);
											num5 += num6;
										}
										num5 /= (uint)num4;
										dictionary4.Add(key2, num5);
									}
									foreach (uint num7 in dictionary5.Keys)
									{
										if (dictionary3.ContainsKey(num7))
										{
											dictionary3[num7] = Struct40.smethod_6(@class, num7);
										}
										else
										{
											dictionary3.Add(num7, Struct40.smethod_6(@class, num7));
										}
									}
								}
							}
						}
					}
				}
				catch
				{
					Struct40.smethod_11();
					throw;
				}
			}
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0008B65C File Offset: 0x0008985C
		private Struct40(Class464 cog, uint cogsRemaining, bool skelecog, DateTime startTime, uint? estimatedDuration)
		{
			if (cog == null)
			{
				throw new ArgumentNullException("cog");
			}
			this.class464_0 = cog;
			this.uint_0 = cogsRemaining;
			this.bool_0 = skelecog;
			this.dateTime_0 = startTime;
			this.nullable_1 = estimatedDuration;
			if (estimatedDuration != null)
			{
				this.nullable_0 = new DateTime?(startTime + new TimeSpan(0, 0, (int)estimatedDuration.Value));
				return;
			}
			this.nullable_0 = null;
		}

		// Token: 0x04001300 RID: 4864
		private static readonly int int_0 = 10;

		// Token: 0x04001301 RID: 4865
		private static readonly Dictionary<Class177, Dictionary<Class464, Dictionary<uint, uint>>> dictionary_0 = new Dictionary<Class177, Dictionary<Class464, Dictionary<uint, uint>>>();

		// Token: 0x04001302 RID: 4866
		private static readonly Dictionary<Class177, Dictionary<uint, uint>> dictionary_1 = new Dictionary<Class177, Dictionary<uint, uint>>();

		// Token: 0x04001303 RID: 4867
		private static readonly Dictionary<Class177, Dictionary<Class464, Dictionary<uint, List<uint>>>> dictionary_2 = new Dictionary<Class177, Dictionary<Class464, Dictionary<uint, List<uint>>>>();

		// Token: 0x04001304 RID: 4868
		private static readonly Dictionary<Class177, Struct40> dictionary_3 = new Dictionary<Class177, Struct40>();

		// Token: 0x04001305 RID: 4869
		public static readonly ReadOnlyDictionary<Class177, Struct40> readOnlyDictionary_0 = new ReadOnlyDictionary<Class177, Struct40>(Struct40.dictionary_3);

		// Token: 0x04001306 RID: 4870
		public static readonly object object_0 = new object();

		// Token: 0x04001307 RID: 4871
		private static readonly byte[] byte_0 = new byte[]
		{
			73,
			78,
			86
		};

		// Token: 0x04001308 RID: 4872
		public readonly Class464 class464_0;

		// Token: 0x04001309 RID: 4873
		public readonly uint uint_0;

		// Token: 0x0400130A RID: 4874
		public readonly bool bool_0;

		// Token: 0x0400130B RID: 4875
		public readonly DateTime dateTime_0;

		// Token: 0x0400130C RID: 4876
		public readonly DateTime? nullable_0;

		// Token: 0x0400130D RID: 4877
		public readonly uint? nullable_1;
	}
}
