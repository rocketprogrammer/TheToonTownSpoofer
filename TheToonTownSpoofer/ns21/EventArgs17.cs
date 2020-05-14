using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ns21
{
	// Token: 0x02000254 RID: 596
	internal sealed class EventArgs17 : EventArgs
	{
		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x060019B8 RID: 6584 RVA: 0x00008F40 File Offset: 0x00007140
		// (set) Token: 0x060019B9 RID: 6585 RVA: 0x00008F48 File Offset: 0x00007148
		public Color Color { get; private set; }

		// Token: 0x060019BA RID: 6586 RVA: 0x00008F51 File Offset: 0x00007151
		public EventArgs17(Color c)
		{
			this.Color = c;
		}

		// Token: 0x04000749 RID: 1865
		[CompilerGenerated]
		private Color color_0;
	}
}
