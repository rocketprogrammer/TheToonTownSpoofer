using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns19;
using ns22;
using ns27;
using ns29;

namespace ns26
{
	// Token: 0x02000475 RID: 1141
	internal sealed class Class106 : Class104
	{
		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06002A8B RID: 10891 RVA: 0x00013CB8 File Offset: 0x00011EB8
		protected override int? Version
		{
			get
			{
				return new int?(4);
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x00013CC0 File Offset: 0x00011EC0
		protected override int MaximumVersion
		{
			get
			{
				return 4;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06002A8D RID: 10893 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06002A8E RID: 10894 RVA: 0x00013CC3 File Offset: 0x00011EC3
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					74,
					70,
					83
				};
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06002A8F RID: 10895 RVA: 0x00013CD6 File Offset: 0x00011ED6
		// (set) Token: 0x06002A90 RID: 10896 RVA: 0x00013CDE File Offset: 0x00011EDE
		public Class114 JoeFishCaptureSettings { get; private set; }

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06002A91 RID: 10897 RVA: 0x00013CE7 File Offset: 0x00011EE7
		// (set) Token: 0x06002A92 RID: 10898 RVA: 0x00013CEF File Offset: 0x00011EEF
		public string CustomCaptureFile { get; set; }

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06002A93 RID: 10899 RVA: 0x00013CF8 File Offset: 0x00011EF8
		// (set) Token: 0x06002A94 RID: 10900 RVA: 0x00013D00 File Offset: 0x00011F00
		public string CustomWayPointSettings { get; set; }

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06002A95 RID: 10901 RVA: 0x00013D09 File Offset: 0x00011F09
		// (set) Token: 0x06002A96 RID: 10902 RVA: 0x00013D11 File Offset: 0x00011F11
		public bool StopWhenNewSpecies { get; set; }

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06002A97 RID: 10903 RVA: 0x00013D1A File Offset: 0x00011F1A
		// (set) Token: 0x06002A98 RID: 10904 RVA: 0x00013D22 File Offset: 0x00011F22
		public int CastDragDelay { get; set; }

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x00013D2B File Offset: 0x00011F2B
		// (set) Token: 0x06002A9A RID: 10906 RVA: 0x00013D33 File Offset: 0x00011F33
		public int AfterCastDelay { get; set; }

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06002A9B RID: 10907 RVA: 0x00013D3C File Offset: 0x00011F3C
		// (set) Token: 0x06002A9C RID: 10908 RVA: 0x00013D44 File Offset: 0x00011F44
		public Struct50 JoeFishTotalRunStatistics { get; set; }

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x00013D4D File Offset: 0x00011F4D
		// (set) Token: 0x06002A9E RID: 10910 RVA: 0x00013D55 File Offset: 0x00011F55
		public bool ShowStatisticsAfterRunning { get; set; }

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06002A9F RID: 10911 RVA: 0x00013D5E File Offset: 0x00011F5E
		// (set) Token: 0x06002AA0 RID: 10912 RVA: 0x00013D66 File Offset: 0x00011F66
		public bool RequireStableTarget { get; set; }

		// Token: 0x06002AA1 RID: 10913 RVA: 0x000A4598 File Offset: 0x000A2798
		public Class106()
		{
			this.JoeFishTotalRunStatistics = Struct50.struct50_0;
			this.JoeFishCaptureSettings = new Class114();
			this.CustomWayPointSettings = null;
			this.CustomCaptureFile = null;
			this.CastDragDelay = Class106.int_6;
			this.AfterCastDelay = Class106.int_7;
			this.ShowStatisticsAfterRunning = true;
			this.StopWhenNewSpecies = Class106.bool_0;
			base.MaxColorRange = Class106.int_5;
			this.RequireStableTarget = Class106.bool_1;
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0001126E File Offset: 0x0000F46E
		public Class106(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x000A4610 File Offset: 0x000A2810
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.JoeFishCaptureSettings = new Class114(reader);
			if (reader.ReadBoolean())
			{
				this.CustomCaptureFile = reader.ReadString();
			}
			if (reader.ReadBoolean())
			{
				this.CustomWayPointSettings = reader.ReadString();
			}
			this.StopWhenNewSpecies = reader.ReadBoolean();
			this.CastDragDelay = reader.ReadInt32();
			this.AfterCastDelay = reader.ReadInt32();
			this.ShowStatisticsAfterRunning = reader.ReadBoolean();
			this.JoeFishTotalRunStatistics = reader.smethod_0();
			if (version == 2)
			{
				reader.ReadSingle();
				reader.ReadSingle();
			}
			if (version > 3)
			{
				this.RequireStableTarget = reader.ReadBoolean();
			}
			else
			{
				this.RequireStableTarget = Class106.bool_1;
			}
			base.vmethod_2(reader, version);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x000A46C4 File Offset: 0x000A28C4
		protected override void vmethod_0(BinaryWriter writer)
		{
			this.JoeFishCaptureSettings.method_3(writer);
			if (this.CustomCaptureFile == null)
			{
				writer.Write(false);
			}
			else
			{
				writer.Write(true);
				writer.Write(this.CustomCaptureFile);
			}
			if (this.CustomWayPointSettings == null)
			{
				writer.Write(false);
			}
			else
			{
				writer.Write(true);
				writer.Write(this.CustomWayPointSettings);
			}
			writer.Write(this.StopWhenNewSpecies);
			writer.Write(this.CastDragDelay);
			writer.Write(this.AfterCastDelay);
			writer.Write(this.ShowStatisticsAfterRunning);
			writer.smethod_1(this.JoeFishTotalRunStatistics);
			writer.Write(this.RequireStableTarget);
			base.vmethod_0(writer);
		}

		// Token: 0x04001676 RID: 5750
		public static readonly int int_5 = 20;

		// Token: 0x04001677 RID: 5751
		public static readonly int int_6 = 100;

		// Token: 0x04001678 RID: 5752
		public static readonly int int_7 = 5000;

		// Token: 0x04001679 RID: 5753
		public static readonly bool bool_0 = true;

		// Token: 0x0400167A RID: 5754
		public static readonly bool bool_1 = true;

		// Token: 0x0400167B RID: 5755
		[CompilerGenerated]
		private Class114 class114_0;

		// Token: 0x0400167C RID: 5756
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400167D RID: 5757
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400167E RID: 5758
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x0400167F RID: 5759
		[CompilerGenerated]
		private int int_8;

		// Token: 0x04001680 RID: 5760
		[CompilerGenerated]
		private int int_9;

		// Token: 0x04001681 RID: 5761
		[CompilerGenerated]
		private Struct50 struct50_0;

		// Token: 0x04001682 RID: 5762
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x04001683 RID: 5763
		[CompilerGenerated]
		private bool bool_4;
	}
}
