using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns16;

namespace ns25
{
	// Token: 0x02000350 RID: 848
	internal sealed class Class97 : Class86
	{
		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x0000D65C File Offset: 0x0000B85C
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x0000D664 File Offset: 0x0000B864
		public bool TopMost { get; set; }

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x0000D66D File Offset: 0x0000B86D
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x0000D675 File Offset: 0x0000B875
		public bool AnimateController { get; set; }

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x0000D67E File Offset: 0x0000B87E
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x0000D686 File Offset: 0x0000B886
		public bool UseOpacity { get; set; }

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x060020EA RID: 8426 RVA: 0x0000D68F File Offset: 0x0000B88F
		// (set) Token: 0x060020EB RID: 8427 RVA: 0x0000D697 File Offset: 0x0000B897
		public Enum84 KeyboardLayout { get; set; }

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x060020EC RID: 8428 RVA: 0x0000C06F File Offset: 0x0000A26F
		protected override int? Version
		{
			get
			{
				return new int?(2);
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x060020ED RID: 8429 RVA: 0x0000C077 File Offset: 0x0000A277
		protected override int MaximumVersion
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x060020EE RID: 8430 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x060020EF RID: 8431 RVA: 0x0000D6A0 File Offset: 0x0000B8A0
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					82,
					67,
					83
				};
			}
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x0000D6B3 File Offset: 0x0000B8B3
		public Class97()
		{
			this.TopMost = false;
			this.AnimateController = true;
			this.UseOpacity = true;
			this.KeyboardLayout = Enum84.const_0;
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class97(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x0000D6D7 File Offset: 0x0000B8D7
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.TopMost);
			writer.Write(this.AnimateController);
			writer.Write(this.UseOpacity);
			writer.Write((byte)this.KeyboardLayout);
		}

		// Token: 0x060020F3 RID: 8435 RVA: 0x0000D709 File Offset: 0x0000B909
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.TopMost = reader.ReadBoolean();
			this.AnimateController = reader.ReadBoolean();
			this.UseOpacity = reader.ReadBoolean();
			if (version > 1)
			{
				this.KeyboardLayout = (Enum84)reader.ReadByte();
				return;
			}
			this.KeyboardLayout = Enum84.const_0;
		}

		// Token: 0x04000D83 RID: 3459
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000D84 RID: 3460
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000D85 RID: 3461
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000D86 RID: 3462
		[CompilerGenerated]
		private Enum84 enum84_0;
	}
}
