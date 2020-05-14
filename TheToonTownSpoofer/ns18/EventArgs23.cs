using System;
using System.Runtime.CompilerServices;

namespace ns18
{
	// Token: 0x020002AD RID: 685
	internal sealed class EventArgs23 : EventArgs
	{
		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x0000A5BE File Offset: 0x000087BE
		// (set) Token: 0x06001BF7 RID: 7159 RVA: 0x0000A5C6 File Offset: 0x000087C6
		public long PacketLength { get; private set; }

		// Token: 0x06001BF8 RID: 7160 RVA: 0x0000A5CF File Offset: 0x000087CF
		public EventArgs23(long packetLength)
		{
			this.PacketLength = packetLength;
		}

		// Token: 0x0400098F RID: 2447
		[CompilerGenerated]
		private long long_0;
	}
}
