using System;
using System.IO;
using System.Runtime.CompilerServices;
using ns14;

namespace ns15
{
	// Token: 0x0200020D RID: 525
	internal sealed class Class89 : Class86
	{
		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001708 RID: 5896 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x0600170A RID: 5898 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x1700071B RID: 1819
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x00006E68 File Offset: 0x00005068
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					71,
					77,
					83
				};
			}
		}

		// Token: 0x1700071C RID: 1820
		// (get) Token: 0x0600170C RID: 5900 RVA: 0x00006E7B File Offset: 0x0000507B
		// (set) Token: 0x0600170D RID: 5901 RVA: 0x00006E83 File Offset: 0x00005083
		public bool TopMost { get; set; }

		// Token: 0x1700071D RID: 1821
		// (get) Token: 0x0600170E RID: 5902 RVA: 0x00006E8C File Offset: 0x0000508C
		// (set) Token: 0x0600170F RID: 5903 RVA: 0x00006E94 File Offset: 0x00005094
		public bool ShowToolTips { get; set; }

		// Token: 0x06001710 RID: 5904 RVA: 0x00006E9D File Offset: 0x0000509D
		public Class89()
		{
			this.TopMost = false;
			this.ShowToolTips = true;
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class89(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x00006EB3 File Offset: 0x000050B3
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.TopMost = reader.ReadBoolean();
			this.ShowToolTips = reader.ReadBoolean();
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00006ECD File Offset: 0x000050CD
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.Write(this.TopMost);
			writer.Write(this.ShowToolTips);
		}

		// Token: 0x04000507 RID: 1287
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x04000508 RID: 1288
		[CompilerGenerated]
		private bool bool_1;
	}
}
