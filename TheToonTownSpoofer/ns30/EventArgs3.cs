using System;
using System.Runtime.CompilerServices;

namespace ns30
{
	// Token: 0x020001E9 RID: 489
	internal class EventArgs3<T> : EventArgs
	{
		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x06001640 RID: 5696 RVA: 0x0000661B File Offset: 0x0000481B
		// (set) Token: 0x06001641 RID: 5697 RVA: 0x00006623 File Offset: 0x00004823
		public T Item { get; private set; }

		// Token: 0x06001642 RID: 5698 RVA: 0x0000662C File Offset: 0x0000482C
		public EventArgs3(T item)
		{
			this.Item = item;
		}

		// Token: 0x04000390 RID: 912
		[CompilerGenerated]
		private T gparam_0;
	}
}
