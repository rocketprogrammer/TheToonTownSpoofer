using System;
using System.Runtime.CompilerServices;

namespace ns16
{
	// Token: 0x020003C2 RID: 962
	internal sealed class EventArgs32 : EventArgs
	{
		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x00010482 File Offset: 0x0000E682
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x0001048A File Offset: 0x0000E68A
		public bool Modified { get; private set; }

		// Token: 0x06002524 RID: 9508 RVA: 0x00010493 File Offset: 0x0000E693
		public EventArgs32(bool modified)
		{
			this.Modified = modified;
		}

		// Token: 0x04001164 RID: 4452
		[CompilerGenerated]
		private bool bool_0;
	}
}
