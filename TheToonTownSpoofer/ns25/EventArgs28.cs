using System;
using System.Runtime.CompilerServices;
using ns15;
using ns16;

namespace ns25
{
	// Token: 0x02000336 RID: 822
	internal sealed class EventArgs28 : EventArgs
	{
		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06001FF8 RID: 8184 RVA: 0x0000CE7C File Offset: 0x0000B07C
		// (set) Token: 0x06001FF9 RID: 8185 RVA: 0x0000CE84 File Offset: 0x0000B084
		public Enum28 Response { get; private set; }

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x06001FFA RID: 8186 RVA: 0x0000CE8D File Offset: 0x0000B08D
		// (set) Token: 0x06001FFB RID: 8187 RVA: 0x0000CE95 File Offset: 0x0000B095
		public Enum87 PreviousStep { get; private set; }

		// Token: 0x06001FFC RID: 8188 RVA: 0x0000CE9E File Offset: 0x0000B09E
		public EventArgs28(Enum28 response, Enum87 previousStep)
		{
			this.Response = response;
			this.PreviousStep = previousStep;
		}

		// Token: 0x04000C73 RID: 3187
		[CompilerGenerated]
		private Enum28 enum28_0;

		// Token: 0x04000C74 RID: 3188
		[CompilerGenerated]
		private Enum87 enum87_0;
	}
}
