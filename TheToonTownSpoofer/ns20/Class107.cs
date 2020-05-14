using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;

namespace ns20
{
	// Token: 0x0200041D RID: 1053
	internal sealed class Class107 : Class86
	{
		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x060027DA RID: 10202 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x060027DC RID: 10204 RVA: 0x00012083 File Offset: 0x00010283
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					82,
					65,
					67,
					69
				};
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x00012096 File Offset: 0x00010296
		// (set) Token: 0x060027DE RID: 10206 RVA: 0x0001209E File Offset: 0x0001029E
		public ushort UrbanTrackQualifies { get; set; }

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x060027DF RID: 10207 RVA: 0x000120A7 File Offset: 0x000102A7
		// (set) Token: 0x060027E0 RID: 10208 RVA: 0x000120AF File Offset: 0x000102AF
		public ushort UrbanTrackWins { get; set; }

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x060027E1 RID: 10209 RVA: 0x000120B8 File Offset: 0x000102B8
		// (set) Token: 0x060027E2 RID: 10210 RVA: 0x000120C0 File Offset: 0x000102C0
		public ushort RuralTrackQualifies { get; set; }

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x060027E3 RID: 10211 RVA: 0x000120C9 File Offset: 0x000102C9
		// (set) Token: 0x060027E4 RID: 10212 RVA: 0x000120D1 File Offset: 0x000102D1
		public ushort RuralTrackWins { get; set; }

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x060027E5 RID: 10213 RVA: 0x000120DA File Offset: 0x000102DA
		// (set) Token: 0x060027E6 RID: 10214 RVA: 0x000120E2 File Offset: 0x000102E2
		public ushort SpeedwayTrackQualifies { get; set; }

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x060027E7 RID: 10215 RVA: 0x000120EB File Offset: 0x000102EB
		// (set) Token: 0x060027E8 RID: 10216 RVA: 0x000120F3 File Offset: 0x000102F3
		public ushort SpeedwayTrackWins { get; set; }

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x000120FC File Offset: 0x000102FC
		// (set) Token: 0x060027EA RID: 10218 RVA: 0x00012104 File Offset: 0x00010304
		public ushort TournamentQualifies { get; set; }

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x0001210D File Offset: 0x0001030D
		// (set) Token: 0x060027EC RID: 10220 RVA: 0x00012115 File Offset: 0x00010315
		public ushort TournamentWins { get; set; }

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x0001211E File Offset: 0x0001031E
		// (set) Token: 0x060027EE RID: 10222 RVA: 0x00012126 File Offset: 0x00010326
		public ushort TournamentSwept { get; set; }

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x060027EF RID: 10223 RVA: 0x0001212F File Offset: 0x0001032F
		// (set) Token: 0x060027F0 RID: 10224 RVA: 0x00012137 File Offset: 0x00010337
		public bool AutoUpdate { get; set; }

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x060027F1 RID: 10225 RVA: 0x00012140 File Offset: 0x00010340
		// (set) Token: 0x060027F2 RID: 10226 RVA: 0x00012148 File Offset: 0x00010348
		public bool TopMost { get; set; }

		// Token: 0x060027F3 RID: 10227 RVA: 0x00012151 File Offset: 0x00010351
		public Class107()
		{
			this.AutoUpdate = true;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x00005F5D File Offset: 0x0000415D
		public Class107(string fileName) : base(fileName)
		{
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x00093C4C File Offset: 0x00091E4C
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.SpeedwayTrackQualifies = reader.ReadUInt16();
			this.SpeedwayTrackWins = reader.ReadUInt16();
			this.UrbanTrackQualifies = reader.ReadUInt16();
			this.UrbanTrackWins = reader.ReadUInt16();
			this.RuralTrackQualifies = reader.ReadUInt16();
			this.RuralTrackWins = reader.ReadUInt16();
			this.TournamentQualifies = reader.ReadUInt16();
			this.TournamentWins = reader.ReadUInt16();
			this.TournamentSwept = reader.ReadUInt16();
			this.AutoUpdate = reader.ReadBoolean();
			this.TopMost = reader.ReadBoolean();
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x00093CE0 File Offset: 0x00091EE0
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.SpeedwayTrackQualifies);
			writer.Write(this.SpeedwayTrackWins);
			writer.Write(this.UrbanTrackQualifies);
			writer.Write(this.UrbanTrackWins);
			writer.Write(this.RuralTrackQualifies);
			writer.Write(this.RuralTrackWins);
			writer.Write(this.TournamentQualifies);
			writer.Write(this.TournamentWins);
			writer.Write(this.TournamentSwept);
			writer.Write(this.AutoUpdate);
			writer.Write(this.TopMost);
		}

		// Token: 0x04001405 RID: 5125
		[CompilerGenerated]
		private ushort ushort_0;

		// Token: 0x04001406 RID: 5126
		[CompilerGenerated]
		private ushort ushort_1;

		// Token: 0x04001407 RID: 5127
		[CompilerGenerated]
		private ushort ushort_2;

		// Token: 0x04001408 RID: 5128
		[CompilerGenerated]
		private ushort ushort_3;

		// Token: 0x04001409 RID: 5129
		[CompilerGenerated]
		private ushort ushort_4;

		// Token: 0x0400140A RID: 5130
		[CompilerGenerated]
		private ushort ushort_5;

		// Token: 0x0400140B RID: 5131
		[CompilerGenerated]
		private ushort ushort_6;

		// Token: 0x0400140C RID: 5132
		[CompilerGenerated]
		private ushort ushort_7;

		// Token: 0x0400140D RID: 5133
		[CompilerGenerated]
		private ushort ushort_8;

		// Token: 0x0400140E RID: 5134
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400140F RID: 5135
		[CompilerGenerated]
		private bool bool_1;
	}
}
