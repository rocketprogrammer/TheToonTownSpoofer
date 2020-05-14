using System;
using System.Runtime.CompilerServices;
using ns27;

namespace ns26
{
	// Token: 0x02000455 RID: 1109
	internal sealed class EventArgs38 : EventArgs
	{
		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06002986 RID: 10630 RVA: 0x00013245 File Offset: 0x00011445
		// (set) Token: 0x06002987 RID: 10631 RVA: 0x0001324D File Offset: 0x0001144D
		public Class492 UpdateHelperData { get; private set; }

		// Token: 0x06002988 RID: 10632 RVA: 0x00013256 File Offset: 0x00011456
		public EventArgs38(Class492 updateHelperData)
		{
			this.UpdateHelperData = updateHelperData;
		}

		// Token: 0x040015A0 RID: 5536
		[CompilerGenerated]
		private Class492 class492_0;
	}
}
