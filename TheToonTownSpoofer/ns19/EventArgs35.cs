using System;
using System.Runtime.CompilerServices;

namespace ns19
{
	// Token: 0x020003F4 RID: 1012
	internal sealed class EventArgs35 : EventArgs
	{
		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060026BC RID: 9916 RVA: 0x0001145A File Offset: 0x0000F65A
		// (set) Token: 0x060026BD RID: 9917 RVA: 0x00011462 File Offset: 0x0000F662
		public int Group { get; private set; }

		// Token: 0x060026BE RID: 9918 RVA: 0x0001146B File Offset: 0x0000F66B
		public EventArgs35(int group)
		{
			this.Group = group;
		}

		// Token: 0x040012FA RID: 4858
		[CompilerGenerated]
		private int int_0;
	}
}
