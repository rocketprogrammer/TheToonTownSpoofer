using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using ns18;
using ns22;

namespace ns29
{
	// Token: 0x020004BF RID: 1215
	internal struct Struct54 : Interface17
	{
		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002D97 RID: 11671 RVA: 0x00015D5F File Offset: 0x00013F5F
		// (set) Token: 0x06002D98 RID: 11672 RVA: 0x00015D67 File Offset: 0x00013F67
		public byte B { get; set; }

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00015D70 File Offset: 0x00013F70
		// (set) Token: 0x06002D9A RID: 11674 RVA: 0x00015D78 File Offset: 0x00013F78
		public byte G { get; set; }

		// Token: 0x17000B45 RID: 2885
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x00015D81 File Offset: 0x00013F81
		// (set) Token: 0x06002D9C RID: 11676 RVA: 0x00015D89 File Offset: 0x00013F89
		public byte R { get; set; }

		// Token: 0x06002D9D RID: 11677 RVA: 0x00015D92 File Offset: 0x00013F92
		public Struct54(byte r, byte g, byte b)
		{
			this = default(Struct54);
			this.R = r;
			this.G = g;
			this.B = b;
		}

		// Token: 0x06002D9E RID: 11678 RVA: 0x00015DB0 File Offset: 0x00013FB0
		public static Color smethod_0(Struct54 c)
		{
			return Color.FromArgb(255, (int)c.R, (int)c.G, (int)c.B);
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00015DD1 File Offset: 0x00013FD1
		public static Struct54 smethod_1(Color c)
		{
			return new Struct54(c.R, c.G, c.B);
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00015DED File Offset: 0x00013FED
		public static Struct54 smethod_2(Struct33 c)
		{
			return new Struct54(c.R, c.G, c.B);
		}

		// Token: 0x040017FF RID: 6143
		[CompilerGenerated]
		private byte byte_0;

		// Token: 0x04001800 RID: 6144
		[CompilerGenerated]
		private byte byte_1;

		// Token: 0x04001801 RID: 6145
		[CompilerGenerated]
		private byte byte_2;
	}
}
