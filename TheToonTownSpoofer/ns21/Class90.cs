using System;
using System.Collections.Generic;
using System.IO;
using ns14;
using ns16;
using ns26;
using ns29;
using TSN.Collections;

namespace ns21
{
	// Token: 0x02000258 RID: 600
	internal sealed class Class90 : Class86
	{
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060019C5 RID: 6597 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060019C6 RID: 6598 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x060019C7 RID: 6599 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x060019C8 RID: 6600 RVA: 0x00009006 File Offset: 0x00007206
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					71,
					70,
					87,
					80,
					83
				};
			}
		}

		// Token: 0x1700079F RID: 1951
		public Class101 this[Enum85 house]
		{
			get
			{
				house.smethod_0();
				return this.dictionary_0[house];
			}
		}

		// Token: 0x170007A0 RID: 1952
		// (get) Token: 0x060019CA RID: 6602 RVA: 0x00047754 File Offset: 0x00045954
		public bool HasCategories
		{
			get
			{
				return this.dictionary_0.smethod_2(new Enum85[]
				{
					Enum85.const_3,
					Enum85.const_1,
					Enum85.const_4,
					Enum85.const_2,
					Enum85.const_0,
					Enum85.const_5,
					Enum85.const_6
				});
			}
		}

		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x060019CB RID: 6603 RVA: 0x00009032 File Offset: 0x00007232
		public ReadOnlyDictionary<Enum85, Class101> WayPoints
		{
			get
			{
				return new ReadOnlyDictionary<Enum85, Class101>(this.dictionary_0);
			}
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x00047790 File Offset: 0x00045990
		public Class90()
		{
			this.dictionary_0 = new Dictionary<Enum85, Class101>();
			this.dictionary_0.Add(Enum85.const_3, new Class101());
			this.dictionary_0.Add(Enum85.const_1, new Class101());
			this.dictionary_0.Add(Enum85.const_4, new Class101());
			this.dictionary_0.Add(Enum85.const_2, new Class101());
			this.dictionary_0.Add(Enum85.const_0, new Class101());
			this.dictionary_0.Add(Enum85.const_5, new Class101());
			this.dictionary_0.Add(Enum85.const_6, new Class101());
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x00005F5D File Offset: 0x0000415D
		public Class90(string filePath) : base(filePath)
		{
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x00047828 File Offset: 0x00045A28
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.dictionary_0 = new Dictionary<Enum85, Class101>();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Enum85 @enum = (Enum85)reader.ReadByte();
				@enum.smethod_0();
				Class101 value = new Class101(reader);
				if (!this.dictionary_0.ContainsKey(@enum))
				{
					this.dictionary_0.Add(@enum, value);
				}
			}
			if (!this.dictionary_0.smethod_2(new Enum85[]
			{
				Enum85.const_3,
				Enum85.const_1,
				Enum85.const_4,
				Enum85.const_2,
				Enum85.const_0,
				Enum85.const_5,
				Enum85.const_6
			}))
			{
				throw new InvalidDataException("Some of the way point types for Gardener Flora are missing.");
			}
			base.vmethod_2(reader, version);
		}

		// Token: 0x060019CF RID: 6607 RVA: 0x000478D4 File Offset: 0x00045AD4
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.dictionary_0.Count);
			foreach (KeyValuePair<Enum85, Class101> keyValuePair in this.dictionary_0)
			{
				writer.Write((byte)keyValuePair.Key);
				keyValuePair.Value.method_3(writer);
			}
		}

		// Token: 0x04000755 RID: 1877
		private Dictionary<Enum85, Class101> dictionary_0;
	}
}
