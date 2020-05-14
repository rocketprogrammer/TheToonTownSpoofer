using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;
using ns15;

namespace ns27
{
	// Token: 0x0200047A RID: 1146
	internal sealed class Class111 : Class86
	{
		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06002ABE RID: 10942 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06002ABF RID: 10943 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06002AC0 RID: 10944 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06002AC1 RID: 10945 RVA: 0x00013EF3 File Offset: 0x000120F3
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					77,
					71,
					83
				};
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06002AC2 RID: 10946 RVA: 0x00013F06 File Offset: 0x00012106
		// (set) Token: 0x06002AC3 RID: 10947 RVA: 0x00013F0E File Offset: 0x0001210E
		public Enum24 ScreenshotScaling { get; set; }

		// Token: 0x06002AC4 RID: 10948 RVA: 0x00013F17 File Offset: 0x00012117
		public Class111()
		{
			this.ScreenshotScaling = Enum24.const_2;
		}

		// Token: 0x06002AC5 RID: 10949 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class111(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06002AC6 RID: 10950 RVA: 0x00013F26 File Offset: 0x00012126
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.ScreenshotScaling = (Enum24)reader.ReadByte();
		}

		// Token: 0x06002AC7 RID: 10951 RVA: 0x00013F34 File Offset: 0x00012134
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write((byte)this.ScreenshotScaling);
		}

		// Token: 0x04001699 RID: 5785
		[CompilerGenerated]
		private Enum24 enum24_0;
	}
}
