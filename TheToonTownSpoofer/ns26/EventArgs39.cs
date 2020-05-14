using System;
using System.Runtime.CompilerServices;

namespace ns26
{
	// Token: 0x02000456 RID: 1110
	internal sealed class EventArgs39 : EventArgs
	{
		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06002989 RID: 10633 RVA: 0x00013265 File Offset: 0x00011465
		// (set) Token: 0x0600298A RID: 10634 RVA: 0x0001326D File Offset: 0x0001146D
		public byte[] Message { get; private set; }

		// Token: 0x0600298B RID: 10635 RVA: 0x00013276 File Offset: 0x00011476
		public EventArgs39(byte[] message)
		{
			this.Message = message;
		}

		// Token: 0x040015A1 RID: 5537
		[CompilerGenerated]
		private byte[] byte_0;
	}
}
