using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns22;
using ns26;
using ns28;

namespace ns14
{
	// Token: 0x020001DA RID: 474
	internal sealed class Class88 : Class86, IDisposable
	{
		// Token: 0x170006B8 RID: 1720
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06001580 RID: 5504 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001581 RID: 5505 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06001582 RID: 5506 RVA: 0x00005D94 File Offset: 0x00003F94
		protected override byte[] Header
		{
			get
			{
				return Class88.byte_0;
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06001583 RID: 5507 RVA: 0x00005D9B File Offset: 0x00003F9B
		// (set) Token: 0x06001584 RID: 5508 RVA: 0x00005DA3 File Offset: 0x00003FA3
		public Struct46 PlantFlowerBounds { get; set; }

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06001585 RID: 5509 RVA: 0x00005DAC File Offset: 0x00003FAC
		// (set) Token: 0x06001586 RID: 5510 RVA: 0x00005DB4 File Offset: 0x00003FB4
		public Class150 PlantFlowerCapture { get; set; }

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06001587 RID: 5511 RVA: 0x00005DBD File Offset: 0x00003FBD
		// (set) Token: 0x06001588 RID: 5512 RVA: 0x00005DC5 File Offset: 0x00003FC5
		public Struct46 WaterPlantBounds { get; set; }

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x00005DCE File Offset: 0x00003FCE
		// (set) Token: 0x0600158A RID: 5514 RVA: 0x00005DD6 File Offset: 0x00003FD6
		public Class150 WaterPlantCapture { get; set; }

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x0600158B RID: 5515 RVA: 0x00005DDF File Offset: 0x00003FDF
		// (set) Token: 0x0600158C RID: 5516 RVA: 0x00005DE7 File Offset: 0x00003FE7
		public Struct46 PickFlowerBounds { get; set; }

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x00005DF0 File Offset: 0x00003FF0
		// (set) Token: 0x0600158E RID: 5518 RVA: 0x00005DF8 File Offset: 0x00003FF8
		public Class150 PickFlowerCapture { get; set; }

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x00005E01 File Offset: 0x00004001
		// (set) Token: 0x06001590 RID: 5520 RVA: 0x00005E09 File Offset: 0x00004009
		public Struct46 FinalPlantBounds { get; set; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x00005E12 File Offset: 0x00004012
		// (set) Token: 0x06001592 RID: 5522 RVA: 0x00005E1A File Offset: 0x0000401A
		public Class150 FinalPlantCapture { get; set; }

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x06001593 RID: 5523 RVA: 0x00005E23 File Offset: 0x00004023
		// (set) Token: 0x06001594 RID: 5524 RVA: 0x00005E2B File Offset: 0x0000402B
		public Struct46 PlantFailedBounds { get; set; }

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x00005E34 File Offset: 0x00004034
		// (set) Token: 0x06001596 RID: 5526 RVA: 0x00005E3C File Offset: 0x0000403C
		public Class150 PlantFailedCapture { get; set; }

		// Token: 0x170006C6 RID: 1734
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00005E45 File Offset: 0x00004045
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x00005E4D File Offset: 0x0000404D
		public Struct46 PlantSuccessBounds { get; set; }

		// Token: 0x170006C7 RID: 1735
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00005E56 File Offset: 0x00004056
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x00005E5E File Offset: 0x0000405E
		public Class150 PlantSuccessCapture { get; set; }

		// Token: 0x170006C8 RID: 1736
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00005E67 File Offset: 0x00004067
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x00005E6F File Offset: 0x0000406F
		public Struct46 NoWaterBounds { get; set; }

		// Token: 0x170006C9 RID: 1737
		// (get) Token: 0x0600159D RID: 5533 RVA: 0x00005E78 File Offset: 0x00004078
		// (set) Token: 0x0600159E RID: 5534 RVA: 0x00005E80 File Offset: 0x00004080
		public Class150 NoWaterCapture { get; set; }

		// Token: 0x170006CA RID: 1738
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x00005E89 File Offset: 0x00004089
		// (set) Token: 0x060015A0 RID: 5536 RVA: 0x00005E91 File Offset: 0x00004091
		public Struct46 BasketFullBounds { get; set; }

		// Token: 0x170006CB RID: 1739
		// (get) Token: 0x060015A1 RID: 5537 RVA: 0x00005E9A File Offset: 0x0000409A
		// (set) Token: 0x060015A2 RID: 5538 RVA: 0x00005EA2 File Offset: 0x000040A2
		public Class150 BasketFullCapture { get; set; }

		// Token: 0x170006CC RID: 1740
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00005EAB File Offset: 0x000040AB
		// (set) Token: 0x060015A4 RID: 5540 RVA: 0x00005EB3 File Offset: 0x000040B3
		public Struct46 SellFlowersBounds { get; set; }

		// Token: 0x170006CD RID: 1741
		// (get) Token: 0x060015A5 RID: 5541 RVA: 0x00005EBC File Offset: 0x000040BC
		// (set) Token: 0x060015A6 RID: 5542 RVA: 0x00005EC4 File Offset: 0x000040C4
		public Class150 SellFlowersCapture { get; set; }

		// Token: 0x170006CE RID: 1742
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x00005ECD File Offset: 0x000040CD
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x00005ED5 File Offset: 0x000040D5
		public Struct46 DisabledBeanSlotBounds { get; set; }

		// Token: 0x170006CF RID: 1743
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x00005EDE File Offset: 0x000040DE
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x00005EE6 File Offset: 0x000040E6
		public Class150 DisabledBeanSlotCapture { get; set; }

		// Token: 0x170006D0 RID: 1744
		// (get) Token: 0x060015AB RID: 5547 RVA: 0x00005EEF File Offset: 0x000040EF
		// (set) Token: 0x060015AC RID: 5548 RVA: 0x00005EF7 File Offset: 0x000040F7
		public Struct46 FinalPickBounds { get; set; }

		// Token: 0x170006D1 RID: 1745
		// (get) Token: 0x060015AD RID: 5549 RVA: 0x00005F00 File Offset: 0x00004100
		// (set) Token: 0x060015AE RID: 5550 RVA: 0x00005F08 File Offset: 0x00004108
		public Class150 FinalPickCapture { get; set; }

		// Token: 0x170006D2 RID: 1746
		// (get) Token: 0x060015AF RID: 5551 RVA: 0x00005F11 File Offset: 0x00004111
		// (set) Token: 0x060015B0 RID: 5552 RVA: 0x00005F19 File Offset: 0x00004119
		public Struct46 CancelPlantBounds { get; set; }

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x060015B1 RID: 5553 RVA: 0x00005F22 File Offset: 0x00004122
		// (set) Token: 0x060015B2 RID: 5554 RVA: 0x00005F2A File Offset: 0x0000412A
		public Class150 CancelPlantCapture { get; set; }

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x060015B3 RID: 5555 RVA: 0x00005F33 File Offset: 0x00004133
		// (set) Token: 0x060015B4 RID: 5556 RVA: 0x00005F3B File Offset: 0x0000413B
		public Struct46 NoRemoveBounds { get; set; }

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x060015B5 RID: 5557 RVA: 0x00005F44 File Offset: 0x00004144
		// (set) Token: 0x060015B6 RID: 5558 RVA: 0x00005F4C File Offset: 0x0000414C
		public Class150 NoRemoveCapture { get; set; }

		// Token: 0x060015B7 RID: 5559 RVA: 0x00005F55 File Offset: 0x00004155
		public Class88()
		{
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x00005F5D File Offset: 0x0000415D
		public Class88(string filePath) : base(filePath)
		{
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x00031D74 File Offset: 0x0002FF74
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.PlantFlowerBounds = reader.smethod_21();
			this.PlantFlowerCapture = reader.smethod_4();
			this.WaterPlantBounds = reader.smethod_21();
			this.WaterPlantCapture = reader.smethod_4();
			this.PickFlowerBounds = reader.smethod_21();
			this.PickFlowerCapture = reader.smethod_4();
			this.FinalPlantBounds = reader.smethod_21();
			this.FinalPlantCapture = reader.smethod_4();
			this.PlantFailedBounds = reader.smethod_21();
			this.PlantFailedCapture = reader.smethod_4();
			this.PlantSuccessBounds = reader.smethod_21();
			this.PlantSuccessCapture = reader.smethod_4();
			this.NoWaterBounds = reader.smethod_21();
			this.NoWaterCapture = reader.smethod_4();
			this.BasketFullBounds = reader.smethod_21();
			this.BasketFullCapture = reader.smethod_4();
			this.SellFlowersBounds = reader.smethod_21();
			this.SellFlowersCapture = reader.smethod_4();
			this.DisabledBeanSlotBounds = reader.smethod_21();
			this.DisabledBeanSlotCapture = reader.smethod_4();
			this.FinalPickBounds = reader.smethod_21();
			this.FinalPickCapture = reader.smethod_4();
			this.CancelPlantBounds = reader.smethod_21();
			this.CancelPlantCapture = reader.smethod_4();
			this.NoRemoveBounds = reader.smethod_21();
			this.NoRemoveCapture = reader.smethod_4();
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00031EBC File Offset: 0x000300BC
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.smethod_20(this.PlantFlowerBounds);
			writer.smethod_5(this.PlantFlowerCapture);
			writer.smethod_20(this.WaterPlantBounds);
			writer.smethod_5(this.WaterPlantCapture);
			writer.smethod_20(this.PickFlowerBounds);
			writer.smethod_5(this.PickFlowerCapture);
			writer.smethod_20(this.FinalPlantBounds);
			writer.smethod_5(this.FinalPlantCapture);
			writer.smethod_20(this.PlantFailedBounds);
			writer.smethod_5(this.PlantFailedCapture);
			writer.smethod_20(this.PlantSuccessBounds);
			writer.smethod_5(this.PlantSuccessCapture);
			writer.smethod_20(this.NoWaterBounds);
			writer.smethod_5(this.NoWaterCapture);
			writer.smethod_20(this.BasketFullBounds);
			writer.smethod_5(this.BasketFullCapture);
			writer.smethod_20(this.SellFlowersBounds);
			writer.smethod_5(this.SellFlowersCapture);
			writer.smethod_20(this.DisabledBeanSlotBounds);
			writer.smethod_5(this.DisabledBeanSlotCapture);
			writer.smethod_20(this.FinalPickBounds);
			writer.smethod_5(this.FinalPickCapture);
			writer.smethod_20(this.CancelPlantBounds);
			writer.smethod_5(this.CancelPlantCapture);
			writer.smethod_20(this.NoRemoveBounds);
			writer.smethod_5(this.NoRemoveCapture);
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x00032004 File Offset: 0x00030204
		public void method_4()
		{
			if (this.PlantFlowerCapture != null)
			{
				this.PlantFlowerCapture.method_4();
			}
			if (this.WaterPlantCapture != null)
			{
				this.WaterPlantCapture.method_4();
			}
			if (this.PickFlowerCapture != null)
			{
				this.PickFlowerCapture.method_4();
			}
			if (this.FinalPlantCapture != null)
			{
				this.FinalPlantCapture.method_4();
			}
			if (this.PlantFailedCapture != null)
			{
				this.PlantFailedCapture.method_4();
			}
			if (this.PlantSuccessCapture != null)
			{
				this.PlantSuccessCapture.method_4();
			}
			if (this.NoWaterCapture != null)
			{
				this.NoWaterCapture.method_4();
			}
			if (this.BasketFullCapture != null)
			{
				this.BasketFullCapture.method_4();
			}
			if (this.SellFlowersCapture != null)
			{
				this.SellFlowersCapture.method_4();
			}
			if (this.DisabledBeanSlotCapture != null)
			{
				this.DisabledBeanSlotCapture.method_4();
			}
			if (this.FinalPickCapture != null)
			{
				this.FinalPickCapture.method_4();
			}
			if (this.CancelPlantCapture != null)
			{
				this.CancelPlantCapture.method_4();
			}
			if (this.NoRemoveCapture != null)
			{
				this.NoRemoveCapture.method_4();
			}
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00032108 File Offset: 0x00030308
		public void Dispose()
		{
			if (this.PlantFlowerCapture != null)
			{
				this.PlantFlowerCapture.Dispose();
			}
			if (this.WaterPlantCapture != null)
			{
				this.WaterPlantCapture.Dispose();
			}
			if (this.PickFlowerCapture != null)
			{
				this.PickFlowerCapture.Dispose();
			}
			if (this.FinalPlantCapture != null)
			{
				this.FinalPlantCapture.Dispose();
			}
			if (this.PlantFailedCapture != null)
			{
				this.PlantFailedCapture.Dispose();
			}
			if (this.PlantSuccessCapture != null)
			{
				this.PlantSuccessCapture.Dispose();
			}
			if (this.NoWaterCapture != null)
			{
				this.NoWaterCapture.Dispose();
			}
			if (this.BasketFullCapture != null)
			{
				this.BasketFullCapture.Dispose();
			}
			if (this.SellFlowersCapture != null)
			{
				this.SellFlowersCapture.Dispose();
			}
			if (this.DisabledBeanSlotCapture != null)
			{
				this.DisabledBeanSlotCapture.Dispose();
			}
			if (this.FinalPickCapture != null)
			{
				this.FinalPickCapture.Dispose();
			}
			if (this.CancelPlantCapture != null)
			{
				this.CancelPlantCapture.Dispose();
			}
			if (this.NoRemoveCapture != null)
			{
				this.NoRemoveCapture.Dispose();
			}
		}

		// Token: 0x040002FD RID: 765
		public static readonly byte[] byte_0 = new byte[]
		{
			71,
			70,
			67,
			83
		};

		// Token: 0x040002FE RID: 766
		[CompilerGenerated]
		private Struct46 struct46_0;

		// Token: 0x040002FF RID: 767
		[CompilerGenerated]
		private Class150 class150_0;

		// Token: 0x04000300 RID: 768
		[CompilerGenerated]
		private Struct46 struct46_1;

		// Token: 0x04000301 RID: 769
		[CompilerGenerated]
		private Class150 class150_1;

		// Token: 0x04000302 RID: 770
		[CompilerGenerated]
		private Struct46 struct46_2;

		// Token: 0x04000303 RID: 771
		[CompilerGenerated]
		private Class150 class150_2;

		// Token: 0x04000304 RID: 772
		[CompilerGenerated]
		private Struct46 struct46_3;

		// Token: 0x04000305 RID: 773
		[CompilerGenerated]
		private Class150 class150_3;

		// Token: 0x04000306 RID: 774
		[CompilerGenerated]
		private Struct46 struct46_4;

		// Token: 0x04000307 RID: 775
		[CompilerGenerated]
		private Class150 class150_4;

		// Token: 0x04000308 RID: 776
		[CompilerGenerated]
		private Struct46 struct46_5;

		// Token: 0x04000309 RID: 777
		[CompilerGenerated]
		private Class150 class150_5;

		// Token: 0x0400030A RID: 778
		[CompilerGenerated]
		private Struct46 struct46_6;

		// Token: 0x0400030B RID: 779
		[CompilerGenerated]
		private Class150 class150_6;

		// Token: 0x0400030C RID: 780
		[CompilerGenerated]
		private Struct46 struct46_7;

		// Token: 0x0400030D RID: 781
		[CompilerGenerated]
		private Class150 class150_7;

		// Token: 0x0400030E RID: 782
		[CompilerGenerated]
		private Struct46 struct46_8;

		// Token: 0x0400030F RID: 783
		[CompilerGenerated]
		private Class150 class150_8;

		// Token: 0x04000310 RID: 784
		[CompilerGenerated]
		private Struct46 struct46_9;

		// Token: 0x04000311 RID: 785
		[CompilerGenerated]
		private Class150 class150_9;

		// Token: 0x04000312 RID: 786
		[CompilerGenerated]
		private Struct46 struct46_10;

		// Token: 0x04000313 RID: 787
		[CompilerGenerated]
		private Class150 class150_10;

		// Token: 0x04000314 RID: 788
		[CompilerGenerated]
		private Struct46 struct46_11;

		// Token: 0x04000315 RID: 789
		[CompilerGenerated]
		private Class150 class150_11;

		// Token: 0x04000316 RID: 790
		[CompilerGenerated]
		private Struct46 struct46_12;

		// Token: 0x04000317 RID: 791
		[CompilerGenerated]
		private Class150 class150_12;
	}
}
