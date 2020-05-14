using System;
using System.Runtime.CompilerServices;

namespace ns31
{
	// Token: 0x020002DF RID: 735
	internal sealed class EventArgs25 : EventArgs
	{
		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06001D58 RID: 7512 RVA: 0x0000B014 File Offset: 0x00009214
		// (set) Token: 0x06001D59 RID: 7513 RVA: 0x0000B01C File Offset: 0x0000921C
		public string CompressedFilePath { get; private set; }

		// Token: 0x06001D5A RID: 7514 RVA: 0x0000B025 File Offset: 0x00009225
		public EventArgs25(string compressedFilePath)
		{
			this.CompressedFilePath = compressedFilePath;
		}

		// Token: 0x04000AC3 RID: 2755
		[CompilerGenerated]
		private string string_0;
	}
}
