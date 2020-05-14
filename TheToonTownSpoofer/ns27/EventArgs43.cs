using System;
using System.Runtime.CompilerServices;

namespace ns27
{
	// Token: 0x02000483 RID: 1155
	internal sealed class EventArgs43<T> : EventArgs
	{
		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002B01 RID: 11009 RVA: 0x0001417F File Offset: 0x0001237F
		// (set) Token: 0x06002B02 RID: 11010 RVA: 0x00014187 File Offset: 0x00012387
		public bool IsValid { get; set; }

		// Token: 0x06002B03 RID: 11011 RVA: 0x00014190 File Offset: 0x00012390
		public EventArgs43(T value) : this(value, true)
		{
		}

		// Token: 0x06002B04 RID: 11012 RVA: 0x0001419A File Offset: 0x0001239A
		public EventArgs43(T value, bool defaultIsValid)
		{
			this.gparam_0 = value;
			this.IsValid = defaultIsValid;
		}

		// Token: 0x040016D7 RID: 5847
		public readonly T gparam_0;

		// Token: 0x040016D8 RID: 5848
		[CompilerGenerated]
		private bool bool_0;
	}
}
