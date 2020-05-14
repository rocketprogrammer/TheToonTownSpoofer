using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ns16
{
	// Token: 0x020003EA RID: 1002
	internal sealed class EventArgs34 : EventArgs
	{
		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600264D RID: 9805 RVA: 0x00010F88 File Offset: 0x0000F188
		// (set) Token: 0x0600264E RID: 9806 RVA: 0x00010F90 File Offset: 0x0000F190
		public Graphics Graphics { get; private set; }

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x0600264F RID: 9807 RVA: 0x00010F99 File Offset: 0x0000F199
		// (set) Token: 0x06002650 RID: 9808 RVA: 0x00010FA1 File Offset: 0x0000F1A1
		public Rectangle Bounds { get; private set; }

		// Token: 0x06002651 RID: 9809 RVA: 0x00010FAA File Offset: 0x0000F1AA
		public EventArgs34(Graphics gr, Rectangle bounds)
		{
			this.Graphics = gr;
			this.Bounds = bounds;
		}

		// Token: 0x040012BA RID: 4794
		[CompilerGenerated]
		private Graphics graphics_0;

		// Token: 0x040012BB RID: 4795
		[CompilerGenerated]
		private Rectangle rectangle_0;
	}
}
