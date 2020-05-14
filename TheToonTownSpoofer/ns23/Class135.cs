using System;
using System.Runtime.CompilerServices;
using ns16;
using ns25;
using ns30;

namespace ns23
{
	// Token: 0x02000391 RID: 913
	internal sealed class Class135 : Class123
	{
		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x060023AD RID: 9133 RVA: 0x0000F53F File Offset: 0x0000D73F
		// (set) Token: 0x060023AE RID: 9134 RVA: 0x0000F547 File Offset: 0x0000D747
		public Class102 ContentPackSettings { get; private set; }

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060023AF RID: 9135 RVA: 0x0000F550 File Offset: 0x0000D750
		// (set) Token: 0x060023B0 RID: 9136 RVA: 0x0000F558 File Offset: 0x0000D758
		public Class132 ContentPack { get; private set; }

		// Token: 0x060023B1 RID: 9137 RVA: 0x0000F561 File Offset: 0x0000D761
		public Class135(Class102 contentPackSettings, Class132 contentPack)
		{
			this.ContentPackSettings = contentPackSettings;
			this.ContentPack = contentPack;
		}

		// Token: 0x060023B2 RID: 9138 RVA: 0x0000F577 File Offset: 0x0000D777
		protected override void vmethod_0()
		{
			if (this.ContentPack != null)
			{
				this.ContentPack.Dispose();
			}
			base.vmethod_0();
		}

		// Token: 0x0400106F RID: 4207
		[CompilerGenerated]
		private Class102 class102_0;

		// Token: 0x04001070 RID: 4208
		[CompilerGenerated]
		private Class132 class132_0;
	}
}
