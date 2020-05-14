using System;
using System.Runtime.CompilerServices;
using ns25;

namespace ns15
{
	// Token: 0x0200022D RID: 557
	internal sealed class EventArgs12 : EventArgs
	{
		// Token: 0x17000737 RID: 1847
		// (get) Token: 0x06001810 RID: 6160 RVA: 0x00007B71 File Offset: 0x00005D71
		// (set) Token: 0x06001811 RID: 6161 RVA: 0x00007B79 File Offset: 0x00005D79
		public Class322 BeanCombination { get; private set; }

		// Token: 0x06001812 RID: 6162 RVA: 0x00007B82 File Offset: 0x00005D82
		public EventArgs12(Class322 beanCombination)
		{
			this.BeanCombination = beanCombination;
		}

		// Token: 0x04000609 RID: 1545
		[CompilerGenerated]
		private Class322 class322_0;
	}
}
