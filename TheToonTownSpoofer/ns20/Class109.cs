using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns21;

namespace ns20
{
	// Token: 0x0200043A RID: 1082
	internal sealed class Class109 : Class86
	{
		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06002900 RID: 10496 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06002901 RID: 10497 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06002902 RID: 10498 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06002903 RID: 10499 RVA: 0x00012CAA File Offset: 0x00010EAA
		// (set) Token: 0x06002904 RID: 10500 RVA: 0x00012CB2 File Offset: 0x00010EB2
		public Enum36 GardeningActions { get; set; }

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06002905 RID: 10501 RVA: 0x00012CBB File Offset: 0x00010EBB
		// (set) Token: 0x06002906 RID: 10502 RVA: 0x00012CC3 File Offset: 0x00010EC3
		public int WaterCount { get; set; }

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06002907 RID: 10503 RVA: 0x00012CCC File Offset: 0x00010ECC
		// (set) Token: 0x06002908 RID: 10504 RVA: 0x00012CE4 File Offset: 0x00010EE4
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
					switch (value)
					{
					case false:
						this.GardeningActions &= ~Enum36.flag_4;
						break;
					case true:
						this.GardeningActions |= Enum36.flag_4;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06002909 RID: 10505 RVA: 0x00012D23 File Offset: 0x00010F23
		// (set) Token: 0x0600290A RID: 10506 RVA: 0x00012D3B File Offset: 0x00010F3B
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
					switch (value)
					{
					case false:
						this.GardeningActions &= ~Enum36.flag_1;
						break;
					case true:
						this.GardeningActions |= Enum36.flag_1;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x0600290B RID: 10507 RVA: 0x00012D7A File Offset: 0x00010F7A
		public Class109()
		{
			this.GardeningActions = (Enum36.flag_1 | Enum36.flag_4);
			this.WaterCount = 3;
		}

		// Token: 0x0600290C RID: 10508 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class109(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x0600290D RID: 10509 RVA: 0x00012D91 File Offset: 0x00010F91
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.GardeningActions = (Enum36)reader.ReadByte();
			this.WaterCount = reader.ReadInt32();
			base.vmethod_2(reader, version);
		}

		// Token: 0x0600290E RID: 10510 RVA: 0x00012DB3 File Offset: 0x00010FB3
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write((byte)this.GardeningActions);
			writer.Write(this.WaterCount);
			base.vmethod_0(writer);
		}

		// Token: 0x040014DD RID: 5341
		[CompilerGenerated]
		private Enum36 enum36_0;

		// Token: 0x040014DE RID: 5342
		[CompilerGenerated]
		private int int_0;
	}
}
