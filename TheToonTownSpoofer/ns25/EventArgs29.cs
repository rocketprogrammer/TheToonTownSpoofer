using System;
using System.Runtime.CompilerServices;
using ns15;

namespace ns25
{
	// Token: 0x0200034A RID: 842
	internal sealed class EventArgs29 : EventArgs
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x060020B4 RID: 8372 RVA: 0x0000D495 File Offset: 0x0000B695
		// (set) Token: 0x060020B5 RID: 8373 RVA: 0x0000D49D File Offset: 0x0000B69D
		public Class177 District { get; private set; }

		// Token: 0x060020B6 RID: 8374 RVA: 0x0000D4A6 File Offset: 0x0000B6A6
		public EventArgs29(Class177 district)
		{
			this.District = district;
		}

		// Token: 0x04000D71 RID: 3441
		[CompilerGenerated]
		private Class177 class177_0;
	}
}
