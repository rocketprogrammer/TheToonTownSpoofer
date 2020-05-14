using System;
using System.Runtime.CompilerServices;

namespace ns30
{
	// Token: 0x020001EB RID: 491
	internal sealed class EventArgs7 : EventArgs
	{
		// Token: 0x170006EA RID: 1770
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00006674 File Offset: 0x00004874
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x0000667C File Offset: 0x0000487C
		public string Version { get; private set; }

		// Token: 0x0600164A RID: 5706 RVA: 0x00006685 File Offset: 0x00004885
		public EventArgs7(string version)
		{
			this.Version = version;
		}

		// Token: 0x04000393 RID: 915
		[CompilerGenerated]
		private string string_0;
	}
}
