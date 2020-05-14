using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ns21
{
	// Token: 0x02000242 RID: 578
	internal sealed class EventArgs16 : EventArgs
	{
		// Token: 0x17000755 RID: 1877
		// (get) Token: 0x060018B2 RID: 6322 RVA: 0x0000817F File Offset: 0x0000637F
		// (set) Token: 0x060018B3 RID: 6323 RVA: 0x00008187 File Offset: 0x00006387
		public Dictionary<string, string> Result { get; private set; }

		// Token: 0x17000756 RID: 1878
		// (get) Token: 0x060018B4 RID: 6324 RVA: 0x00008190 File Offset: 0x00006390
		// (set) Token: 0x060018B5 RID: 6325 RVA: 0x00008198 File Offset: 0x00006398
		public bool NewFormat { get; private set; }

		// Token: 0x060018B6 RID: 6326 RVA: 0x000081A1 File Offset: 0x000063A1
		public EventArgs16(bool newFormat, Dictionary<string, string> result)
		{
			this.NewFormat = newFormat;
			this.Result = result;
		}

		// Token: 0x0400068F RID: 1679
		[CompilerGenerated]
		private Dictionary<string, string> dictionary_0;

		// Token: 0x04000690 RID: 1680
		[CompilerGenerated]
		private bool bool_0;
	}
}
