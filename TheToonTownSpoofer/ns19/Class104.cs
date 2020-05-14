using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;

namespace ns19
{
	// Token: 0x020003EF RID: 1007
	internal abstract class Class104 : Class86
	{
		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06002677 RID: 9847 RVA: 0x00011141 File Offset: 0x0000F341
		// (set) Token: 0x06002678 RID: 9848 RVA: 0x00011149 File Offset: 0x0000F349
		public int MaxColorRange { get; set; }

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06002679 RID: 9849 RVA: 0x00011152 File Offset: 0x0000F352
		// (set) Token: 0x0600267A RID: 9850 RVA: 0x0001115A File Offset: 0x0000F35A
		public int AfterMoveBeforeClickDelay { get; set; }

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x0600267B RID: 9851 RVA: 0x00011163 File Offset: 0x0000F363
		// (set) Token: 0x0600267C RID: 9852 RVA: 0x0001116B File Offset: 0x0000F36B
		public int ButtonClickDelay { get; set; }

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600267D RID: 9853 RVA: 0x00011174 File Offset: 0x0000F374
		// (set) Token: 0x0600267E RID: 9854 RVA: 0x0001117C File Offset: 0x0000F37C
		public float TargetRange { get; set; }

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x0600267F RID: 9855 RVA: 0x00011185 File Offset: 0x0000F385
		// (set) Token: 0x06002680 RID: 9856 RVA: 0x0001118D File Offset: 0x0000F38D
		public float IntermediateTargetRange { get; set; }

		// Token: 0x06002681 RID: 9857 RVA: 0x00011196 File Offset: 0x0000F396
		protected Class104()
		{
			this.AfterMoveBeforeClickDelay = Class104.int_1;
			this.ButtonClickDelay = Class104.int_0;
			this.TargetRange = Class104.float_0;
			this.IntermediateTargetRange = Class104.float_1;
		}

		// Token: 0x06002682 RID: 9858 RVA: 0x00005D8B File Offset: 0x00003F8B
		protected Class104(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002683 RID: 9859 RVA: 0x000891F8 File Offset: 0x000873F8
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.MaxColorRange = reader.ReadInt32();
			this.AfterMoveBeforeClickDelay = reader.ReadInt32();
			this.ButtonClickDelay = reader.ReadInt32();
			this.TargetRange = reader.ReadSingle();
			this.IntermediateTargetRange = reader.ReadSingle();
			base.vmethod_2(reader, version);
		}

		// Token: 0x06002684 RID: 9860 RVA: 0x0008924C File Offset: 0x0008744C
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.MaxColorRange);
			writer.Write(this.AfterMoveBeforeClickDelay);
			writer.Write(this.ButtonClickDelay);
			writer.Write(this.TargetRange);
			writer.Write(this.IntermediateTargetRange);
			base.vmethod_0(writer);
		}

		// Token: 0x040012CF RID: 4815
		public static readonly int int_0 = 50;

		// Token: 0x040012D0 RID: 4816
		public static readonly int int_1 = 50;

		// Token: 0x040012D1 RID: 4817
		public static readonly float float_0 = 0.5f;

		// Token: 0x040012D2 RID: 4818
		public static readonly float float_1 = 1f;

		// Token: 0x040012D3 RID: 4819
		[CompilerGenerated]
		private int int_2;

		// Token: 0x040012D4 RID: 4820
		[CompilerGenerated]
		private int int_3;

		// Token: 0x040012D5 RID: 4821
		[CompilerGenerated]
		private int int_4;

		// Token: 0x040012D6 RID: 4822
		[CompilerGenerated]
		private float float_2;

		// Token: 0x040012D7 RID: 4823
		[CompilerGenerated]
		private float float_3;
	}
}
