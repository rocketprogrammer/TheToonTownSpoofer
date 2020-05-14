using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ns14;
using ns19;
using ns20;
using ns21;
using ns23;
using ns24;
using ns29;

namespace ns16
{
	// Token: 0x020003C1 RID: 961
	internal sealed class Class94 : Class92
	{
		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002507 RID: 9479 RVA: 0x0000C06F File Offset: 0x0000A26F
		protected override int? Version
		{
			get
			{
				return new int?(2);
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002508 RID: 9480 RVA: 0x0000C077 File Offset: 0x0000A277
		protected override int MaximumVersion
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06002509 RID: 9481 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x0600250A RID: 9482 RVA: 0x000102E2 File Offset: 0x0000E4E2
		// (set) Token: 0x0600250B RID: 9483 RVA: 0x000102EA File Offset: 0x0000E4EA
		public Enum13 HouseColor { get; set; }

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x000102F3 File Offset: 0x0000E4F3
		// (set) Token: 0x0600250D RID: 9485 RVA: 0x0001030B File Offset: 0x0000E50B
		public bool Customized
		{
			get
			{
				return this.State.HasFlag(Enum131.flag_1);
			}
			set
			{
				if (this.Customized != value)
				{
					if (value)
					{
						this.State |= Enum131.flag_1;
						return;
					}
					this.State &= ~Enum131.flag_1;
				}
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x0001033C File Offset: 0x0000E53C
		// (set) Token: 0x0600250F RID: 9487 RVA: 0x00010354 File Offset: 0x0000E554
		public bool GardenFlowers
		{
			get
			{
				return this.State.HasFlag(Enum131.flag_3);
			}
			set
			{
				if (this.GardenFlowers != value)
				{
					if (value)
					{
						this.State |= Enum131.flag_3;
						return;
					}
					this.State &= ~Enum131.flag_3;
				}
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x00010385 File Offset: 0x0000E585
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x0001039D File Offset: 0x0000E59D
		public bool GardenTrees
		{
			get
			{
				return this.State.HasFlag(Enum131.flag_2);
			}
			set
			{
				if (this.GardenTrees != value)
				{
					if (value)
					{
						this.State |= Enum131.flag_2;
						return;
					}
					this.State &= ~Enum131.flag_2;
				}
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x000103CE File Offset: 0x0000E5CE
		public KeyValuePair<Enum99, Class93>[] OrderedFlowers
		{
			get
			{
				IEnumerable<KeyValuePair<Enum99, Class93>> flowers = this.Flowers;
				if (Class94.func_0 == null)
				{
					Class94.func_0 = new Func<KeyValuePair<Enum99, Class93>, Enum99>(Class94.smethod_0);
				}
				return flowers.OrderBy(Class94.func_0).ToArray<KeyValuePair<Enum99, Class93>>();
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x000103FD File Offset: 0x0000E5FD
		public KeyValuePair<Enum99, Class109>[] OrderedTrees
		{
			get
			{
				IEnumerable<KeyValuePair<Enum99, Class109>> trees = this.Trees;
				if (Class94.func_1 == null)
				{
					Class94.func_1 = new Func<KeyValuePair<Enum99, Class109>, Enum99>(Class94.smethod_1);
				}
				return trees.OrderBy(Class94.func_1).ToArray<KeyValuePair<Enum99, Class109>>();
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x0001042C File Offset: 0x0000E62C
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x00010434 File Offset: 0x0000E634
		public Dictionary<Enum99, Class93> Flowers { get; private set; }

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x0001043D File Offset: 0x0000E63D
		// (set) Token: 0x06002517 RID: 9495 RVA: 0x00010445 File Offset: 0x0000E645
		public Dictionary<Enum99, Class109> Trees { get; private set; }

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06002518 RID: 9496 RVA: 0x0001044E File Offset: 0x0000E64E
		// (set) Token: 0x06002519 RID: 9497 RVA: 0x00010456 File Offset: 0x0000E656
		public Enum131 State { get; private set; }

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x0600251A RID: 9498 RVA: 0x0001045F File Offset: 0x0000E65F
		// (set) Token: 0x0600251B RID: 9499 RVA: 0x00010467 File Offset: 0x0000E667
		public ushort WaterCount { get; set; }

		// Token: 0x0600251C RID: 9500 RVA: 0x0007ED54 File Offset: 0x0007CF54
		public Class94(Enum13 estateHome)
		{
			this.Flowers = new Dictionary<Enum99, Class93>();
			this.Trees = new Dictionary<Enum99, Class109>();
			this.HouseColor = estateHome;
			this.GardenFlowers = true;
			this.GardenTrees = true;
			base.Pick = true;
			base.Plant = true;
			base.Water = true;
			base.Enabled = false;
			this.Customized = false;
			this.WaterCount = 3;
			this.Flowers.Add(Enum99.flag_5, new Class93());
			this.Flowers.Add(Enum99.flag_6, new Class93());
			this.Flowers.Add(Enum99.flag_7, new Class93());
			this.Flowers.Add(Enum99.flag_8, new Class93());
			this.Flowers.Add(Enum99.flag_9, new Class93());
			this.Flowers.Add(Enum99.flag_10, new Class93());
			this.Flowers.Add(Enum99.flag_11, new Class93());
			this.Flowers.Add(Enum99.flag_12, new Class93());
			this.Flowers.Add(Enum99.flag_13, new Class93());
			this.Flowers.Add(Enum99.flag_14, new Class93());
			this.Trees.Add(Enum99.flag_15, new Class109());
			this.Trees.Add(Enum99.flag_16, new Class109());
			this.Trees.Add(Enum99.flag_17, new Class109());
			this.Trees.Add(Enum99.flag_18, new Class109());
			this.Trees.Add(Enum99.flag_19, new Class109());
			this.Trees.Add(Enum99.flag_20, new Class109());
			this.Trees.Add(Enum99.flag_21, new Class109());
			this.Trees.Add(Enum99.flag_22, new Class109());
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x0000F0F6 File Offset: 0x0000D2F6
		public Class94(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x0007EF2C File Offset: 0x0007D12C
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.Flowers = new Dictionary<Enum99, Class93>();
			this.Trees = new Dictionary<Enum99, Class109>();
			this.HouseColor = (Enum13)reader.ReadByte();
			this.State = (Enum131)reader.ReadByte();
			base.GardeningActions = (Enum36)reader.ReadByte();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				Enum99 key = (Enum99)reader.ReadUInt16();
				Class93 value = new Class93(reader);
				if (!this.Flowers.ContainsKey(key))
				{
					this.Flowers.Add(key, value);
				}
			}
			num = reader.ReadInt32();
			for (int j = 0; j < num; j++)
			{
				Enum99 key2 = (Enum99)reader.ReadUInt16();
				Class109 value2 = new Class109(reader);
				if (!this.Trees.ContainsKey(key2))
				{
					this.Trees.Add(key2, value2);
				}
			}
			if (version > 1)
			{
				this.WaterCount = reader.ReadUInt16();
			}
			else
			{
				this.WaterCount = 3;
			}
			base.vmethod_2(reader, version);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x0007F018 File Offset: 0x0007D218
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write((byte)this.HouseColor);
			writer.Write((byte)this.State);
			writer.Write((byte)base.GardeningActions);
			writer.Write(this.Flowers.Count);
			foreach (KeyValuePair<Enum99, Class93> keyValuePair in this.Flowers)
			{
				writer.Write((ushort)keyValuePair.Key);
				keyValuePair.Value.method_3(writer);
			}
			writer.Write(this.Trees.Count);
			foreach (KeyValuePair<Enum99, Class109> keyValuePair2 in this.Trees)
			{
				writer.Write((ushort)keyValuePair2.Key);
				keyValuePair2.Value.method_3(writer);
			}
			writer.Write(this.WaterCount);
			base.vmethod_0(writer);
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x00010470 File Offset: 0x0000E670
		[CompilerGenerated]
		private static Enum99 smethod_0(KeyValuePair<Enum99, Class93> f)
		{
			return f.Key;
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x00010479 File Offset: 0x0000E679
		[CompilerGenerated]
		private static Enum99 smethod_1(KeyValuePair<Enum99, Class109> t)
		{
			return t.Key;
		}

		// Token: 0x0400115D RID: 4445
		[CompilerGenerated]
		private Enum13 enum13_0;

		// Token: 0x0400115E RID: 4446
		[CompilerGenerated]
		private Dictionary<Enum99, Class93> dictionary_0;

		// Token: 0x0400115F RID: 4447
		[CompilerGenerated]
		private Dictionary<Enum99, Class109> dictionary_1;

		// Token: 0x04001160 RID: 4448
		[CompilerGenerated]
		private Enum131 enum131_0;

		// Token: 0x04001161 RID: 4449
		[CompilerGenerated]
		private ushort ushort_0;

		// Token: 0x04001162 RID: 4450
		[CompilerGenerated]
		private static Func<KeyValuePair<Enum99, Class93>, Enum99> func_0;

		// Token: 0x04001163 RID: 4451
		[CompilerGenerated]
		private static Func<KeyValuePair<Enum99, Class109>, Enum99> func_1;
	}
}
