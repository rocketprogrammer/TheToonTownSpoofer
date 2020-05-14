using System;
using System.Runtime.CompilerServices;
using ns21;

namespace ns25
{
	// Token: 0x02000333 RID: 819
	internal sealed class EventArgs27 : EventArgs
	{
		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06001FE2 RID: 8162 RVA: 0x0000CD7D File Offset: 0x0000AF7D
		// (set) Token: 0x06001FE3 RID: 8163 RVA: 0x0000CD85 File Offset: 0x0000AF85
		public Enum36 FloraActions { get; private set; }

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0000CD8E File Offset: 0x0000AF8E
		public EventArgs27(Enum36 floraActions)
		{
			this.FloraActions = floraActions;
		}

		// Token: 0x04000C5E RID: 3166
		[CompilerGenerated]
		private Enum36 enum36_0;
	}
}
