using System;
using System.Runtime.CompilerServices;
using ns30;

namespace ns27
{
	// Token: 0x02000496 RID: 1174
	internal sealed class EventArgs6<T> : EventArgs3<T>
	{
		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06002BB7 RID: 11191 RVA: 0x0001455D File Offset: 0x0001275D
		// (set) Token: 0x06002BB8 RID: 11192 RVA: 0x00014565 File Offset: 0x00012765
		public int RemovedIndex { get; private set; }

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06002BB9 RID: 11193 RVA: 0x0001456E File Offset: 0x0001276E
		// (set) Token: 0x06002BBA RID: 11194 RVA: 0x00014576 File Offset: 0x00012776
		public int GroupIndex { get; private set; }

		// Token: 0x06002BBB RID: 11195 RVA: 0x0001457F File Offset: 0x0001277F
		public EventArgs6(T item, int removedIndex, int groupIndex) : base(item)
		{
			this.RemovedIndex = removedIndex;
			this.GroupIndex = groupIndex;
		}

		// Token: 0x0400170B RID: 5899
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400170C RID: 5900
		[CompilerGenerated]
		private int int_1;
	}
}
