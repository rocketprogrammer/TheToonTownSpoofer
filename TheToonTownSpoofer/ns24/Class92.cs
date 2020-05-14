using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns21;

namespace ns24
{
	// Token: 0x02000309 RID: 777
	internal abstract class Class92 : Class86
	{
		// Token: 0x06001E6F RID: 7791 RVA: 0x00005D8B File Offset: 0x00003F8B
		protected Class92(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x00005F55 File Offset: 0x00004155
		protected Class92()
		{
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x06001E71 RID: 7793 RVA: 0x0000BACD File Offset: 0x00009CCD
		// (set) Token: 0x06001E72 RID: 7794 RVA: 0x0000BAE5 File Offset: 0x00009CE5
		public bool Pick
		{
			get
			{
				return this.GardeningActions.HasFlag(Enum36.flag_2);
			}
			set
			{
				if (this.Pick != value)
				{
					if (value)
					{
						this.GardeningActions |= Enum36.flag_2;
						return;
					}
					this.GardeningActions &= ~Enum36.flag_2;
				}
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06001E73 RID: 7795 RVA: 0x0000BB16 File Offset: 0x00009D16
		// (set) Token: 0x06001E74 RID: 7796 RVA: 0x0000BB2E File Offset: 0x00009D2E
		public bool Plant
		{
			get
			{
				return this.GardeningActions.HasFlag(Enum36.flag_3);
			}
			set
			{
				if (this.Plant != value)
				{
					if (value)
					{
						this.GardeningActions |= Enum36.flag_3;
						return;
					}
					this.GardeningActions &= ~Enum36.flag_3;
				}
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06001E75 RID: 7797 RVA: 0x0000BB5F File Offset: 0x00009D5F
		// (set) Token: 0x06001E76 RID: 7798 RVA: 0x0000BB77 File Offset: 0x00009D77
		public bool Water
		{
			get
			{
				return this.GardeningActions.HasFlag(Enum36.flag_4);
			}
			set
			{
				if (this.Water != value)
				{
					if (value)
					{
						this.GardeningActions |= Enum36.flag_4;
						return;
					}
					this.GardeningActions &= ~Enum36.flag_4;
				}
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06001E77 RID: 7799 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		// (set) Token: 0x06001E78 RID: 7800 RVA: 0x0000BBC0 File Offset: 0x00009DC0
		public bool Enabled
		{
			get
			{
				return this.GardeningActions.HasFlag(Enum36.flag_1);
			}
			set
			{
				if (this.Enabled != value)
				{
					if (value)
					{
						this.GardeningActions |= Enum36.flag_1;
						return;
					}
					this.GardeningActions &= ~Enum36.flag_1;
				}
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06001E79 RID: 7801 RVA: 0x0000BBF1 File Offset: 0x00009DF1
		// (set) Token: 0x06001E7A RID: 7802 RVA: 0x0000BBF9 File Offset: 0x00009DF9
		public Enum36 GardeningActions { get; set; }

		// Token: 0x04000B98 RID: 2968
		[CompilerGenerated]
		private Enum36 enum36_0;
	}
}
