using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns21;
using ns24;
using ns25;
using TSN.Collections;

namespace ns23
{
	// Token: 0x02000388 RID: 904
	internal sealed class Class93 : Class92
	{
		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x0600234A RID: 9034 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x0600234B RID: 9035 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x0600234C RID: 9036 RVA: 0x0000F0BD File Offset: 0x0000D2BD
		// (set) Token: 0x0600234D RID: 9037 RVA: 0x0000F0C5 File Offset: 0x0000D2C5
		public Class322 BeanCombination { get; set; }

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x0600234E RID: 9038 RVA: 0x0000F0CE File Offset: 0x0000D2CE
		// (set) Token: 0x0600234F RID: 9039 RVA: 0x0000F0D6 File Offset: 0x0000D2D6
		public int WaterCount { get; set; }

		// Token: 0x06002350 RID: 9040 RVA: 0x0000F0DF File Offset: 0x0000D2DF
		public Class93()
		{
			base.GardeningActions = (Enum36.flag_1 | Enum36.flag_2 | Enum36.flag_3 | Enum36.flag_4);
			this.WaterCount = 3;
		}

		// Token: 0x06002351 RID: 9041 RVA: 0x0000F0F6 File Offset: 0x0000D2F6
		public Class93(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002352 RID: 9042 RVA: 0x0007712C File Offset: 0x0007532C
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			base.GardeningActions = (Enum36)reader.ReadByte();
			int key = reader.ReadInt32();
			ReadOnlyDictionary<int, Class322> readOnlyDictionary_ = Class322.readOnlyDictionary_0;
			if (readOnlyDictionary_.ContainsKey(key))
			{
				this.BeanCombination = readOnlyDictionary_[key];
			}
			else
			{
				this.BeanCombination = null;
			}
			this.WaterCount = reader.ReadInt32();
			base.vmethod_2(reader, version);
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00077188 File Offset: 0x00075388
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write((byte)base.GardeningActions);
			if (this.BeanCombination == null)
			{
				writer.Write(0);
			}
			else
			{
				writer.Write(this.BeanCombination.NumericCombination);
			}
			writer.Write(this.WaterCount);
			base.vmethod_0(writer);
		}

		// Token: 0x0400103B RID: 4155
		[CompilerGenerated]
		private Class322 class322_0;

		// Token: 0x0400103C RID: 4156
		[CompilerGenerated]
		private int int_0;
	}
}
