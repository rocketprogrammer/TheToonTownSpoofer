using System;
using System.Collections.Generic;

namespace ns20
{
	// Token: 0x02000434 RID: 1076
	internal sealed class Class443<TValue>
	{
		// Token: 0x060028E9 RID: 10473 RVA: 0x0009A99C File Offset: 0x00098B9C
		public Class443(int size)
		{
			this.list_0 = new List<TValue>(size);
			for (int i = 0; i < size; i++)
			{
				this.list_0.Add(default(TValue));
			}
		}

		// Token: 0x17000A08 RID: 2568
		public TValue this[int index]
		{
			get
			{
				return this.list_0[index];
			}
			set
			{
				this.list_0[index] = value;
			}
		}

		// Token: 0x17000A09 RID: 2569
		public TValue this[Enum enu]
		{
			get
			{
				return this.list_0[Convert.ToInt32(enu)];
			}
			set
			{
				this.list_0[Convert.ToInt32(enu)] = value;
			}
		}

		// Token: 0x040014C3 RID: 5315
		private List<TValue> list_0;
	}
}
