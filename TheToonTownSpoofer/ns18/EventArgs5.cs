using System;
using System.Runtime.CompilerServices;
using ns30;

namespace ns18
{
	// Token: 0x0200029C RID: 668
	internal sealed class EventArgs5<T> : EventArgs3<T>
	{
		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001B96 RID: 7062 RVA: 0x0000A1DF File Offset: 0x000083DF
		// (set) Token: 0x06001B97 RID: 7063 RVA: 0x0000A1E7 File Offset: 0x000083E7
		public int Group { get; private set; }

		// Token: 0x06001B98 RID: 7064 RVA: 0x0000A1F0 File Offset: 0x000083F0
		public EventArgs5(T item, int group) : base(item)
		{
			this.Group = group;
		}

		// Token: 0x0400094B RID: 2379
		[CompilerGenerated]
		private int int_0;
	}
}
