using System;
using System.Runtime.CompilerServices;
using ns15;

namespace ns19
{
	// Token: 0x02000403 RID: 1027
	internal sealed class EventArgs37 : EventArgs
	{
		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x00011825 File Offset: 0x0000FA25
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x0001182D File Offset: 0x0000FA2D
		public Class177 District { get; private set; }

		// Token: 0x06002716 RID: 10006 RVA: 0x00011836 File Offset: 0x0000FA36
		public EventArgs37(uint shardID) : this(Class177.smethod_0(shardID))
		{
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x00011844 File Offset: 0x0000FA44
		public EventArgs37(Class177 district)
		{
			this.District = district;
		}

		// Token: 0x0400133F RID: 4927
		[CompilerGenerated]
		private Class177 class177_0;
	}
}
