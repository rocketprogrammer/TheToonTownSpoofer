using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns22;
using ns26;
using ns28;

namespace ns25
{
	// Token: 0x02000351 RID: 849
	internal sealed class Class98 : Class86, IDisposable
	{
		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x060020F4 RID: 8436 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x060020F5 RID: 8437 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x060020F6 RID: 8438 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060020F7 RID: 8439 RVA: 0x0000D747 File Offset: 0x0000B947
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					74,
					67,
					70,
					83
				};
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060020F8 RID: 8440 RVA: 0x0000D75A File Offset: 0x0000B95A
		// (set) Token: 0x060020F9 RID: 8441 RVA: 0x0000D762 File Offset: 0x0000B962
		public Struct46 CastBounds { get; set; }

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060020FA RID: 8442 RVA: 0x0000D76B File Offset: 0x0000B96B
		// (set) Token: 0x060020FB RID: 8443 RVA: 0x0000D773 File Offset: 0x0000B973
		public Class150 CastCapture { get; set; }

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060020FC RID: 8444 RVA: 0x0000D77C File Offset: 0x0000B97C
		// (set) Token: 0x060020FD RID: 8445 RVA: 0x0000D784 File Offset: 0x0000B984
		public Struct46 ExitFishingBounds { get; set; }

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060020FE RID: 8446 RVA: 0x0000D78D File Offset: 0x0000B98D
		// (set) Token: 0x060020FF RID: 8447 RVA: 0x0000D795 File Offset: 0x0000B995
		public Class150 ExitFishingCapture { get; set; }

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x06002100 RID: 8448 RVA: 0x0000D79E File Offset: 0x0000B99E
		// (set) Token: 0x06002101 RID: 8449 RVA: 0x0000D7A6 File Offset: 0x0000B9A6
		public Struct46 FishCaughtDuringBingoBounds { get; set; }

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002102 RID: 8450 RVA: 0x0000D7AF File Offset: 0x0000B9AF
		// (set) Token: 0x06002103 RID: 8451 RVA: 0x0000D7B7 File Offset: 0x0000B9B7
		public Class150 FishCaughtDuringBingoCapture { get; set; }

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002104 RID: 8452 RVA: 0x0000D7C0 File Offset: 0x0000B9C0
		// (set) Token: 0x06002105 RID: 8453 RVA: 0x0000D7C8 File Offset: 0x0000B9C8
		public Struct46 FishCaughtBounds { get; set; }

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002106 RID: 8454 RVA: 0x0000D7D1 File Offset: 0x0000B9D1
		// (set) Token: 0x06002107 RID: 8455 RVA: 0x0000D7D9 File Offset: 0x0000B9D9
		public Class150 FishCaughtCapture { get; set; }

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002108 RID: 8456 RVA: 0x0000D7E2 File Offset: 0x0000B9E2
		// (set) Token: 0x06002109 RID: 8457 RVA: 0x0000D7EA File Offset: 0x0000B9EA
		public Struct46 BootCaughtBounds { get; set; }

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x0600210A RID: 8458 RVA: 0x0000D7F3 File Offset: 0x0000B9F3
		// (set) Token: 0x0600210B RID: 8459 RVA: 0x0000D7FB File Offset: 0x0000B9FB
		public Class150 BootCaughtCapture { get; set; }

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x0600210C RID: 8460 RVA: 0x0000D804 File Offset: 0x0000BA04
		// (set) Token: 0x0600210D RID: 8461 RVA: 0x0000D80C File Offset: 0x0000BA0C
		public Struct46 BucketFullBounds { get; set; }

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x0600210E RID: 8462 RVA: 0x0000D815 File Offset: 0x0000BA15
		// (set) Token: 0x0600210F RID: 8463 RVA: 0x0000D81D File Offset: 0x0000BA1D
		public Class150 BucketFullCapture { get; set; }

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x06002110 RID: 8464 RVA: 0x0000D826 File Offset: 0x0000BA26
		// (set) Token: 0x06002111 RID: 8465 RVA: 0x0000D82E File Offset: 0x0000BA2E
		public Struct46 SellFishBounds { get; set; }

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x06002112 RID: 8466 RVA: 0x0000D837 File Offset: 0x0000BA37
		// (set) Token: 0x06002113 RID: 8467 RVA: 0x0000D83F File Offset: 0x0000BA3F
		public Class150 SellFishCapture { get; set; }

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x06002114 RID: 8468 RVA: 0x0000D848 File Offset: 0x0000BA48
		// (set) Token: 0x06002115 RID: 8469 RVA: 0x0000D850 File Offset: 0x0000BA50
		public Struct46 NoBeansBounds { get; set; }

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002116 RID: 8470 RVA: 0x0000D859 File Offset: 0x0000BA59
		// (set) Token: 0x06002117 RID: 8471 RVA: 0x0000D861 File Offset: 0x0000BA61
		public Class150 NoBeansCapture { get; set; }

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002118 RID: 8472 RVA: 0x0000D86A File Offset: 0x0000BA6A
		// (set) Token: 0x06002119 RID: 8473 RVA: 0x0000D872 File Offset: 0x0000BA72
		public Struct46 EstateSellFishBounds { get; set; }

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x0600211A RID: 8474 RVA: 0x0000D87B File Offset: 0x0000BA7B
		// (set) Token: 0x0600211B RID: 8475 RVA: 0x0000D883 File Offset: 0x0000BA83
		public Class150 EstateSellFishCapture { get; set; }

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x0600211C RID: 8476 RVA: 0x0000D88C File Offset: 0x0000BA8C
		// (set) Token: 0x0600211D RID: 8477 RVA: 0x0000D894 File Offset: 0x0000BA94
		public Struct46 NewSpeciesBounds { get; set; }

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x0600211E RID: 8478 RVA: 0x0000D89D File Offset: 0x0000BA9D
		// (set) Token: 0x0600211F RID: 8479 RVA: 0x0000D8A5 File Offset: 0x0000BAA5
		public Class150 NewSpeciesCapture { get; set; }

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x06002120 RID: 8480 RVA: 0x0000D8AE File Offset: 0x0000BAAE
		// (set) Token: 0x06002121 RID: 8481 RVA: 0x0000D8B6 File Offset: 0x0000BAB6
		public Struct46 NewSpeciesDuringBingoBounds { get; set; }

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x06002122 RID: 8482 RVA: 0x0000D8BF File Offset: 0x0000BABF
		// (set) Token: 0x06002123 RID: 8483 RVA: 0x0000D8C7 File Offset: 0x0000BAC7
		public Class150 NewSpeciesDuringBingoCapture { get; set; }

		// Token: 0x06002124 RID: 8484 RVA: 0x00005F55 File Offset: 0x00004155
		public Class98()
		{
		}

		// Token: 0x06002125 RID: 8485 RVA: 0x00005F5D File Offset: 0x0000415D
		public Class98(string filePath) : base(filePath)
		{
		}

		// Token: 0x06002126 RID: 8486 RVA: 0x0006F6A0 File Offset: 0x0006D8A0
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.CastBounds = reader.smethod_21();
			this.CastCapture = reader.smethod_4();
			this.ExitFishingBounds = reader.smethod_21();
			this.ExitFishingCapture = reader.smethod_4();
			this.FishCaughtBounds = reader.smethod_21();
			this.FishCaughtCapture = reader.smethod_4();
			this.FishCaughtDuringBingoBounds = reader.smethod_21();
			this.FishCaughtDuringBingoCapture = reader.smethod_4();
			this.BootCaughtBounds = reader.smethod_21();
			this.BootCaughtCapture = reader.smethod_4();
			this.BucketFullBounds = reader.smethod_21();
			this.BucketFullCapture = reader.smethod_4();
			this.SellFishBounds = reader.smethod_21();
			this.SellFishCapture = reader.smethod_4();
			this.NoBeansBounds = reader.smethod_21();
			this.NoBeansCapture = reader.smethod_4();
			this.EstateSellFishBounds = reader.smethod_21();
			this.EstateSellFishCapture = reader.smethod_4();
			this.NewSpeciesBounds = reader.smethod_21();
			this.NewSpeciesCapture = reader.smethod_4();
			this.NewSpeciesDuringBingoBounds = reader.smethod_21();
			this.NewSpeciesDuringBingoCapture = reader.smethod_4();
		}

		// Token: 0x06002127 RID: 8487 RVA: 0x0006F7B8 File Offset: 0x0006D9B8
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.smethod_20(this.CastBounds);
			writer.smethod_5(this.CastCapture);
			writer.smethod_20(this.ExitFishingBounds);
			writer.smethod_5(this.ExitFishingCapture);
			writer.smethod_20(this.FishCaughtBounds);
			writer.smethod_5(this.FishCaughtCapture);
			writer.smethod_20(this.FishCaughtDuringBingoBounds);
			writer.smethod_5(this.FishCaughtDuringBingoCapture);
			writer.smethod_20(this.BootCaughtBounds);
			writer.smethod_5(this.BootCaughtCapture);
			writer.smethod_20(this.BucketFullBounds);
			writer.smethod_5(this.BucketFullCapture);
			writer.smethod_20(this.SellFishBounds);
			writer.smethod_5(this.SellFishCapture);
			writer.smethod_20(this.NoBeansBounds);
			writer.smethod_5(this.NoBeansCapture);
			writer.smethod_20(this.EstateSellFishBounds);
			writer.smethod_5(this.EstateSellFishCapture);
			writer.smethod_20(this.NewSpeciesBounds);
			writer.smethod_5(this.NewSpeciesCapture);
			writer.smethod_20(this.NewSpeciesDuringBingoBounds);
			writer.smethod_5(this.NewSpeciesDuringBingoCapture);
		}

		// Token: 0x06002128 RID: 8488 RVA: 0x0006F8D0 File Offset: 0x0006DAD0
		public void method_4()
		{
			if (this.BootCaughtCapture != null)
			{
				this.BootCaughtCapture.method_4();
			}
			if (this.BucketFullCapture != null)
			{
				this.BucketFullCapture.method_4();
			}
			if (this.CastCapture != null)
			{
				this.CastCapture.method_4();
			}
			if (this.EstateSellFishCapture != null)
			{
				this.EstateSellFishCapture.method_4();
			}
			if (this.ExitFishingCapture != null)
			{
				this.ExitFishingCapture.method_4();
			}
			if (this.FishCaughtCapture != null)
			{
				this.FishCaughtCapture.method_4();
			}
			if (this.FishCaughtDuringBingoCapture != null)
			{
				this.FishCaughtDuringBingoCapture.method_4();
			}
			if (this.NewSpeciesCapture != null)
			{
				this.NewSpeciesCapture.method_4();
			}
			if (this.NewSpeciesDuringBingoCapture != null)
			{
				this.NewSpeciesDuringBingoCapture.method_4();
			}
			if (this.NoBeansCapture != null)
			{
				this.NoBeansCapture.method_4();
			}
			if (this.SellFishCapture != null)
			{
				this.SellFishCapture.method_4();
			}
		}

		// Token: 0x06002129 RID: 8489 RVA: 0x0006F9B0 File Offset: 0x0006DBB0
		public void Dispose()
		{
			if (this.BootCaughtCapture != null)
			{
				this.BootCaughtCapture.Dispose();
			}
			if (this.BucketFullCapture != null)
			{
				this.BucketFullCapture.Dispose();
			}
			if (this.CastCapture != null)
			{
				this.CastCapture.Dispose();
			}
			if (this.EstateSellFishCapture != null)
			{
				this.EstateSellFishCapture.Dispose();
			}
			if (this.ExitFishingCapture != null)
			{
				this.ExitFishingCapture.Dispose();
			}
			if (this.FishCaughtCapture != null)
			{
				this.FishCaughtCapture.Dispose();
			}
			if (this.FishCaughtDuringBingoCapture != null)
			{
				this.FishCaughtDuringBingoCapture.Dispose();
			}
			if (this.NewSpeciesCapture != null)
			{
				this.NewSpeciesCapture.Dispose();
			}
			if (this.NewSpeciesDuringBingoCapture != null)
			{
				this.NewSpeciesDuringBingoCapture.Dispose();
			}
			if (this.NoBeansCapture != null)
			{
				this.NoBeansCapture.Dispose();
			}
			if (this.SellFishCapture != null)
			{
				this.SellFishCapture.Dispose();
			}
		}

		// Token: 0x04000D87 RID: 3463
		[CompilerGenerated]
		private Struct46 struct46_0;

		// Token: 0x04000D88 RID: 3464
		[CompilerGenerated]
		private Class150 class150_0;

		// Token: 0x04000D89 RID: 3465
		[CompilerGenerated]
		private Struct46 struct46_1;

		// Token: 0x04000D8A RID: 3466
		[CompilerGenerated]
		private Class150 class150_1;

		// Token: 0x04000D8B RID: 3467
		[CompilerGenerated]
		private Struct46 struct46_2;

		// Token: 0x04000D8C RID: 3468
		[CompilerGenerated]
		private Class150 class150_2;

		// Token: 0x04000D8D RID: 3469
		[CompilerGenerated]
		private Struct46 struct46_3;

		// Token: 0x04000D8E RID: 3470
		[CompilerGenerated]
		private Class150 class150_3;

		// Token: 0x04000D8F RID: 3471
		[CompilerGenerated]
		private Struct46 struct46_4;

		// Token: 0x04000D90 RID: 3472
		[CompilerGenerated]
		private Class150 class150_4;

		// Token: 0x04000D91 RID: 3473
		[CompilerGenerated]
		private Struct46 struct46_5;

		// Token: 0x04000D92 RID: 3474
		[CompilerGenerated]
		private Class150 class150_5;

		// Token: 0x04000D93 RID: 3475
		[CompilerGenerated]
		private Struct46 struct46_6;

		// Token: 0x04000D94 RID: 3476
		[CompilerGenerated]
		private Class150 class150_6;

		// Token: 0x04000D95 RID: 3477
		[CompilerGenerated]
		private Struct46 struct46_7;

		// Token: 0x04000D96 RID: 3478
		[CompilerGenerated]
		private Class150 class150_7;

		// Token: 0x04000D97 RID: 3479
		[CompilerGenerated]
		private Struct46 struct46_8;

		// Token: 0x04000D98 RID: 3480
		[CompilerGenerated]
		private Class150 class150_8;

		// Token: 0x04000D99 RID: 3481
		[CompilerGenerated]
		private Struct46 struct46_9;

		// Token: 0x04000D9A RID: 3482
		[CompilerGenerated]
		private Class150 class150_9;

		// Token: 0x04000D9B RID: 3483
		[CompilerGenerated]
		private Struct46 struct46_10;

		// Token: 0x04000D9C RID: 3484
		[CompilerGenerated]
		private Class150 class150_10;
	}
}
