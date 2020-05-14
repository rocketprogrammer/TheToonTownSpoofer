using System;
using System.Runtime.CompilerServices;

namespace ns30
{
	// Token: 0x020001EA RID: 490
	internal sealed class EventArgs4<T> : EventArgs3<T>
	{
		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x06001643 RID: 5699 RVA: 0x0000663B File Offset: 0x0000483B
		// (set) Token: 0x06001644 RID: 5700 RVA: 0x00006643 File Offset: 0x00004843
		public int PreviousGroup { get; private set; }

		// Token: 0x170006E9 RID: 1769
		// (get) Token: 0x06001645 RID: 5701 RVA: 0x0000664C File Offset: 0x0000484C
		// (set) Token: 0x06001646 RID: 5702 RVA: 0x00006654 File Offset: 0x00004854
		public int NewGroup { get; private set; }

		// Token: 0x06001647 RID: 5703 RVA: 0x0000665D File Offset: 0x0000485D
		public EventArgs4(T item, int previousGroup, int newGroup) : base(item)
		{
			this.PreviousGroup = previousGroup;
			this.NewGroup = newGroup;
		}

		// Token: 0x04000391 RID: 913
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000392 RID: 914
		[CompilerGenerated]
		private int int_1;
	}
}
