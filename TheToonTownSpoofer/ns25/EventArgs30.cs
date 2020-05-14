using System;
using System.Runtime.CompilerServices;
using ns31;

namespace ns25
{
	// Token: 0x0200034C RID: 844
	internal sealed class EventArgs30 : EventArgs
	{
		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x060020CA RID: 8394 RVA: 0x0000D5B9 File Offset: 0x0000B7B9
		// (set) Token: 0x060020CB RID: 8395 RVA: 0x0000D5C1 File Offset: 0x0000B7C1
		public Enum57 Playground { get; private set; }

		// Token: 0x060020CC RID: 8396 RVA: 0x0000D5CA File Offset: 0x0000B7CA
		public EventArgs30(Enum57 playground)
		{
			this.Playground = playground;
		}

		// Token: 0x04000D7E RID: 3454
		[CompilerGenerated]
		private Enum57 enum57_0;
	}
}
