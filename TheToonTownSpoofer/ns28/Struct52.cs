using System;
using System.Runtime.CompilerServices;

namespace ns28
{
	// Token: 0x020004B3 RID: 1203
	internal struct Struct52
	{
		// Token: 0x17000B24 RID: 2852
		// (get) Token: 0x06002D20 RID: 11552 RVA: 0x000157F2 File Offset: 0x000139F2
		// (set) Token: 0x06002D21 RID: 11553 RVA: 0x000157FA File Offset: 0x000139FA
		public DateTime StartTime { get; private set; }

		// Token: 0x17000B25 RID: 2853
		// (get) Token: 0x06002D22 RID: 11554 RVA: 0x00015803 File Offset: 0x00013A03
		// (set) Token: 0x06002D23 RID: 11555 RVA: 0x0001580B File Offset: 0x00013A0B
		public DateTime EndTime { get; private set; }

		// Token: 0x17000B26 RID: 2854
		// (get) Token: 0x06002D24 RID: 11556 RVA: 0x00015814 File Offset: 0x00013A14
		// (set) Token: 0x06002D25 RID: 11557 RVA: 0x0001581C File Offset: 0x00013A1C
		public uint FishCaught { get; private set; }

		// Token: 0x17000B27 RID: 2855
		// (get) Token: 0x06002D26 RID: 11558 RVA: 0x00015825 File Offset: 0x00013A25
		// (set) Token: 0x06002D27 RID: 11559 RVA: 0x0001582D File Offset: 0x00013A2D
		public uint BootsCaught { get; private set; }

		// Token: 0x17000B28 RID: 2856
		// (get) Token: 0x06002D28 RID: 11560 RVA: 0x00015836 File Offset: 0x00013A36
		// (set) Token: 0x06002D29 RID: 11561 RVA: 0x0001583E File Offset: 0x00013A3E
		public uint BucketsSold { get; private set; }

		// Token: 0x17000B29 RID: 2857
		// (get) Token: 0x06002D2A RID: 11562 RVA: 0x00015847 File Offset: 0x00013A47
		// (set) Token: 0x06002D2B RID: 11563 RVA: 0x0001584F File Offset: 0x00013A4F
		public uint Casts { get; private set; }

		// Token: 0x06002D2C RID: 11564 RVA: 0x00015858 File Offset: 0x00013A58
		public Struct52(DateTime startTime, DateTime endTime, uint fishCaught, uint bootsCaught, uint bucketsSold, uint casts)
		{
			this = default(Struct52);
			this.StartTime = startTime;
			this.EndTime = endTime;
			this.FishCaught = fishCaught;
			this.BootsCaught = bootsCaught;
			this.BucketsSold = bucketsSold;
			this.Casts = casts;
		}

		// Token: 0x040017A2 RID: 6050
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x040017A3 RID: 6051
		[CompilerGenerated]
		private DateTime dateTime_1;

		// Token: 0x040017A4 RID: 6052
		[CompilerGenerated]
		private uint uint_0;

		// Token: 0x040017A5 RID: 6053
		[CompilerGenerated]
		private uint uint_1;

		// Token: 0x040017A6 RID: 6054
		[CompilerGenerated]
		private uint uint_2;

		// Token: 0x040017A7 RID: 6055
		[CompilerGenerated]
		private uint uint_3;
	}
}
