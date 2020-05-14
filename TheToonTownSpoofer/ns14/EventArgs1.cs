using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns14
{
	// Token: 0x020001C8 RID: 456
	internal sealed class EventArgs1 : EventArgs
	{
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x00004FF8 File Offset: 0x000031F8
		// (set) Token: 0x06001480 RID: 5248 RVA: 0x00005000 File Offset: 0x00003200
		public HashSet<uint> Shards { get; private set; }

		// Token: 0x06001481 RID: 5249 RVA: 0x00005009 File Offset: 0x00003209
		public EventArgs1(HashSet<uint> shards)
		{
			this.Shards = shards;
		}

		// Token: 0x0400021C RID: 540
		[CompilerGenerated]
		private HashSet<uint> hashSet_0;
	}
}
