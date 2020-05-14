using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns16;
using ns25;
using ns26;
using TSN.Collections;

namespace ns28
{
	// Token: 0x020004AE RID: 1198
	internal sealed class Class113 : Class86
	{
		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06002CC3 RID: 11459 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06002CC4 RID: 11460 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06002CC5 RID: 11461 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06002CC6 RID: 11462 RVA: 0x000152F9 File Offset: 0x000134F9
		protected override byte[] Header
		{
			get
			{
				return Class113.byte_0;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06002CC7 RID: 11463 RVA: 0x00015300 File Offset: 0x00013500
		// (set) Token: 0x06002CC8 RID: 11464 RVA: 0x00015308 File Offset: 0x00013508
		public Dictionary<Enum13, Class94> EstatePlantSettings { get; private set; }

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06002CC9 RID: 11465 RVA: 0x00015311 File Offset: 0x00013511
		// (set) Token: 0x06002CCA RID: 11466 RVA: 0x00015319 File Offset: 0x00013519
		public List<Class322> BeanCombinations { get; private set; }

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06002CCB RID: 11467 RVA: 0x00015322 File Offset: 0x00013522
		// (set) Token: 0x06002CCC RID: 11468 RVA: 0x0001532A File Offset: 0x0001352A
		public Enum115 PlantMethod { get; set; }

		// Token: 0x06002CCD RID: 11469 RVA: 0x000ACA34 File Offset: 0x000AAC34
		public Class113()
		{
			this.EstatePlantSettings = new Dictionary<Enum13, Class94>();
			this.EstatePlantSettings.Add(Enum13.const_3, new Class94(Enum13.const_3));
			this.EstatePlantSettings.Add(Enum13.const_1, new Class94(Enum13.const_1));
			this.EstatePlantSettings.Add(Enum13.const_4, new Class94(Enum13.const_4));
			this.EstatePlantSettings.Add(Enum13.const_2, new Class94(Enum13.const_2));
			this.EstatePlantSettings.Add(Enum13.const_0, new Class94(Enum13.const_0));
			this.EstatePlantSettings.Add(Enum13.const_5, new Class94(Enum13.const_5));
			this.BeanCombinations = new List<Class322>();
			this.PlantMethod = Enum115.const_0;
		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x00005F5D File Offset: 0x0000415D
		public Class113(string fileName) : base(fileName)
		{
		}

		// Token: 0x06002CCF RID: 11471 RVA: 0x000ACAD0 File Offset: 0x000AACD0
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.EstatePlantSettings = new Dictionary<Enum13, Class94>();
			this.BeanCombinations = new List<Class322>();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Enum13 key = (Enum13)reader.ReadByte();
				Class94 value = new Class94(reader);
				if (!this.EstatePlantSettings.ContainsKey(key))
				{
					this.EstatePlantSettings.Add(key, value);
				}
			}
			this.PlantMethod = (Enum115)reader.ReadByte();
			num = reader.ReadInt32();
			ReadOnlyDictionary<int, Class322> readOnlyDictionary_ = Class322.readOnlyDictionary_0;
			for (int j = 0; j < num; j++)
			{
				int key2 = reader.ReadInt32();
				if (readOnlyDictionary_.ContainsKey(key2))
				{
					this.BeanCombinations.Add(readOnlyDictionary_[key2]);
				}
			}
			base.vmethod_2(reader, version);
		}

		// Token: 0x06002CD0 RID: 11472 RVA: 0x000ACB88 File Offset: 0x000AAD88
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.EstatePlantSettings.Count);
			foreach (KeyValuePair<Enum13, Class94> keyValuePair in this.EstatePlantSettings)
			{
				writer.Write((byte)keyValuePair.Key);
				keyValuePair.Value.method_3(writer);
			}
			writer.Write((byte)this.PlantMethod);
			writer.Write(this.BeanCombinations.Count);
			foreach (Class322 @class in this.BeanCombinations)
			{
				writer.Write(@class.NumericCombination);
			}
			base.vmethod_0(writer);
		}

		// Token: 0x04001773 RID: 6003
		public static readonly byte[] byte_0 = new byte[]
		{
			71,
			70,
			69,
			83
		};

		// Token: 0x04001774 RID: 6004
		[CompilerGenerated]
		private Dictionary<Enum13, Class94> dictionary_0;

		// Token: 0x04001775 RID: 6005
		[CompilerGenerated]
		private List<Class322> list_0;

		// Token: 0x04001776 RID: 6006
		[CompilerGenerated]
		private Enum115 enum115_0;
	}
}
