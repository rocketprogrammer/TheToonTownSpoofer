using System;
using System.Collections.Generic;

namespace ns17
{
	// Token: 0x02000271 RID: 625
	internal sealed class Class214<T> : IComparer<T> where T : IComparable
	{
		// Token: 0x06001A5F RID: 6751 RVA: 0x000095C5 File Offset: 0x000077C5
		public int Compare(T x, T y)
		{
			return -x.CompareTo(y);
		}
	}
}
