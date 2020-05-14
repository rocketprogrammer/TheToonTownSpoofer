using System;
using System.Runtime.CompilerServices;
using ns22;
using ns24;

namespace ns16
{
	// Token: 0x020003E2 RID: 994
	internal sealed class EventArgs33 : EventArgs
	{
		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06002609 RID: 9737 RVA: 0x00010D87 File Offset: 0x0000EF87
		// (set) Token: 0x0600260A RID: 9738 RVA: 0x00010D8F File Offset: 0x0000EF8F
		public Enum74 InstallerState { get; private set; }

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x0600260B RID: 9739 RVA: 0x00010D98 File Offset: 0x0000EF98
		// (set) Token: 0x0600260C RID: 9740 RVA: 0x00010DA0 File Offset: 0x0000EFA0
		public Enum66 InstallFailureType { get; private set; }

		// Token: 0x0600260D RID: 9741 RVA: 0x00010DA9 File Offset: 0x0000EFA9
		public EventArgs33(Enum74 installerState)
		{
			this.InstallerState = installerState;
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00010DB8 File Offset: 0x0000EFB8
		public EventArgs33(Enum74 installerState, Enum66 installFailureType) : this(installerState)
		{
			this.InstallFailureType = installFailureType;
		}

		// Token: 0x0400129A RID: 4762
		[CompilerGenerated]
		private Enum74 enum74_0;

		// Token: 0x0400129B RID: 4763
		[CompilerGenerated]
		private Enum66 enum66_0;
	}
}
