using System;
using System.Runtime.CompilerServices;
using ns28;

namespace ns27
{
	// Token: 0x02000493 RID: 1171
	internal struct Struct50
	{
		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06002B8B RID: 11147 RVA: 0x00014441 File Offset: 0x00012641
		// (set) Token: 0x06002B8C RID: 11148 RVA: 0x00014449 File Offset: 0x00012649
		public TimeSpan TotalRunTime { get; private set; }

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06002B8D RID: 11149 RVA: 0x00014452 File Offset: 0x00012652
		// (set) Token: 0x06002B8E RID: 11150 RVA: 0x0001445A File Offset: 0x0001265A
		public uint TotalFishCaught { get; private set; }

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06002B8F RID: 11151 RVA: 0x00014463 File Offset: 0x00012663
		// (set) Token: 0x06002B90 RID: 11152 RVA: 0x0001446B File Offset: 0x0001266B
		public uint TotalBootsCaught { get; private set; }

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06002B91 RID: 11153 RVA: 0x00014474 File Offset: 0x00012674
		// (set) Token: 0x06002B92 RID: 11154 RVA: 0x0001447C File Offset: 0x0001267C
		public uint TotalBucketsSold { get; private set; }

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06002B93 RID: 11155 RVA: 0x00014485 File Offset: 0x00012685
		// (set) Token: 0x06002B94 RID: 11156 RVA: 0x0001448D File Offset: 0x0001268D
		public uint TotalCasts { get; private set; }

		// Token: 0x06002B95 RID: 11157 RVA: 0x00014496 File Offset: 0x00012696
		public Struct50(TimeSpan totalRunTime, uint totalFishCaught, uint totalBootsCaught, uint totalBucketsSold, uint totalCasts)
		{
			this = default(Struct50);
			this.TotalRunTime = totalRunTime;
			this.TotalFishCaught = totalFishCaught;
			this.TotalBootsCaught = totalBootsCaught;
			this.TotalBucketsSold = totalBucketsSold;
			this.TotalCasts = totalCasts;
		}

		// Token: 0x06002B96 RID: 11158 RVA: 0x000A9B80 File Offset: 0x000A7D80
		public static Struct50 smethod_0(Struct50 left, Struct52 right)
		{
			return new Struct50(left.TotalRunTime + (right.EndTime - right.StartTime), left.TotalFishCaught + right.FishCaught, left.TotalBootsCaught + right.BootsCaught, left.TotalBucketsSold + right.BucketsSold, left.TotalCasts + right.Casts);
		}

		// Token: 0x04001700 RID: 5888
		public static readonly Struct50 struct50_0 = new Struct50(TimeSpan.Zero, 0U, 0U, 0U, 0U);

		// Token: 0x04001701 RID: 5889
		[CompilerGenerated]
		private TimeSpan timeSpan_0;

		// Token: 0x04001702 RID: 5890
		[CompilerGenerated]
		private uint uint_0;

		// Token: 0x04001703 RID: 5891
		[CompilerGenerated]
		private uint uint_1;

		// Token: 0x04001704 RID: 5892
		[CompilerGenerated]
		private uint uint_2;

		// Token: 0x04001705 RID: 5893
		[CompilerGenerated]
		private uint uint_3;
	}
}
