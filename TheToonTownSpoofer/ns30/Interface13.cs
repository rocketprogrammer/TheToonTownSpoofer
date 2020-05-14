using System;
using System.Collections;
using System.Collections.Generic;

namespace ns30
{
	// Token: 0x020001EE RID: 494
	internal interface Interface13<T> : IEnumerable<T>, ICollection<T>, IDisposable, IEnumerable where T : class
	{
		// Token: 0x170006EB RID: 1771
		// (get) Token: 0x06001654 RID: 5716
		IEnumerable<T> LiveList { get; }

		// Token: 0x170006EC RID: 1772
		// (get) Token: 0x06001655 RID: 5717
		IEnumerable<T> CompleteList { get; }

		// Token: 0x170006ED RID: 1773
		// (get) Token: 0x06001656 RID: 5718
		IEnumerable<T> LiveListWithoutPurge { get; }

		// Token: 0x170006EE RID: 1774
		// (get) Token: 0x06001657 RID: 5719
		int CompleteCount { get; }

		// Token: 0x170006EF RID: 1775
		// (get) Token: 0x06001658 RID: 5720
		int DeadCount { get; }

		// Token: 0x170006F0 RID: 1776
		// (get) Token: 0x06001659 RID: 5721
		int LiveCount { get; }

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600165A RID: 5722
		int LiveCountWithoutPurge { get; }

		// Token: 0x0600165B RID: 5723
		void imethod_0();
	}
}
