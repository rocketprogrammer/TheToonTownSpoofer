using System;
using System.Runtime.CompilerServices;
using ns24;

namespace ns14
{
	// Token: 0x020001C7 RID: 455
	internal sealed class EventArgs0 : EventArgs
	{
		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x00004FD8 File Offset: 0x000031D8
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x00004FE0 File Offset: 0x000031E0
		public Class309 FileState { get; private set; }

		// Token: 0x0600147E RID: 5246 RVA: 0x00004FE9 File Offset: 0x000031E9
		public EventArgs0(Class309 filestate)
		{
			this.FileState = filestate;
		}

		// Token: 0x0400021B RID: 539
		[CompilerGenerated]
		private Class309 class309_0;
	}
}
