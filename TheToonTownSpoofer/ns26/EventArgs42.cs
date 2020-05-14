using System;
using System.Runtime.CompilerServices;
using ns16;

namespace ns26
{
	// Token: 0x02000467 RID: 1127
	internal sealed class EventArgs42 : EventArgs
	{
		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x060029D4 RID: 10708 RVA: 0x00013569 File Offset: 0x00011769
		// (set) Token: 0x060029D5 RID: 10709 RVA: 0x00013571 File Offset: 0x00011771
		public Version MinimumVersion { get; private set; }

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060029D6 RID: 10710 RVA: 0x0001357A File Offset: 0x0001177A
		// (set) Token: 0x060029D7 RID: 10711 RVA: 0x00013582 File Offset: 0x00011782
		public Class102 ContentPackData { get; private set; }

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060029D8 RID: 10712 RVA: 0x0001358B File Offset: 0x0001178B
		// (set) Token: 0x060029D9 RID: 10713 RVA: 0x00013593 File Offset: 0x00011793
		public bool IsPatch { get; private set; }

		// Token: 0x060029DA RID: 10714 RVA: 0x0001359C File Offset: 0x0001179C
		public EventArgs42(Class102 contentPackData, Version minimumVersion, bool isPatch)
		{
			this.ContentPackData = contentPackData;
			this.MinimumVersion = minimumVersion;
			this.IsPatch = isPatch;
		}

		// Token: 0x040015EB RID: 5611
		[CompilerGenerated]
		private Version version_0;

		// Token: 0x040015EC RID: 5612
		[CompilerGenerated]
		private Class102 class102_0;

		// Token: 0x040015ED RID: 5613
		[CompilerGenerated]
		private bool bool_0;
	}
}
