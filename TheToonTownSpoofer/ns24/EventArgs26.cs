using System;
using System.Runtime.CompilerServices;

namespace ns24
{
	// Token: 0x02000314 RID: 788
	internal sealed class EventArgs26 : EventArgs
	{
		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001EC1 RID: 7873 RVA: 0x0000BF12 File Offset: 0x0000A112
		// (set) Token: 0x06001EC2 RID: 7874 RVA: 0x0000BF1A File Offset: 0x0000A11A
		public string ErrorTitle { get; private set; }

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001EC3 RID: 7875 RVA: 0x0000BF23 File Offset: 0x0000A123
		// (set) Token: 0x06001EC4 RID: 7876 RVA: 0x0000BF2B File Offset: 0x0000A12B
		public string ErrorMessage { get; private set; }

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001EC5 RID: 7877 RVA: 0x0000BF34 File Offset: 0x0000A134
		// (set) Token: 0x06001EC6 RID: 7878 RVA: 0x0000BF3C File Offset: 0x0000A13C
		public bool PrematureExit { get; private set; }

		// Token: 0x06001EC7 RID: 7879 RVA: 0x0000BF45 File Offset: 0x0000A145
		public EventArgs26(string errorTitle, string errorMessage)
		{
			this.ErrorTitle = errorTitle;
			this.ErrorMessage = errorMessage;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0000BF5B File Offset: 0x0000A15B
		public EventArgs26(bool prematureExit, string errorTitle, string errorMessage) : this(errorTitle, errorMessage)
		{
			this.PrematureExit = prematureExit;
		}

		// Token: 0x04000BCC RID: 3020
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000BCD RID: 3021
		[CompilerGenerated]
		private string string_1;

		// Token: 0x04000BCE RID: 3022
		[CompilerGenerated]
		private bool bool_0;
	}
}
