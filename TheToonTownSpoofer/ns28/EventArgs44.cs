using System;
using System.Collections;
using System.Collections.Generic;
using ns15;

namespace ns28
{
	// Token: 0x020004A4 RID: 1188
	internal sealed class EventArgs44 : EventArgs
	{
		// Token: 0x06002C44 RID: 11332 RVA: 0x000AB2A8 File Offset: 0x000A94A8
		public EventArgs44(List<Class177> districts)
		{
			lock (((ICollection)districts).SyncRoot)
			{
				this.list_0 = new List<Class177>(districts);
			}
		}

		// Token: 0x04001741 RID: 5953
		public readonly List<Class177> list_0;
	}
}
