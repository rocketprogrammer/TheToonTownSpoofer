using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns18
{
	// Token: 0x020002C6 RID: 710
	internal sealed class Class256 : IComparer
	{
		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0000AA09 File Offset: 0x00008C09
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0000AA11 File Offset: 0x00008C11
		public int SortColumn { get; set; }

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0000AA1A File Offset: 0x00008C1A
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0000AA22 File Offset: 0x00008C22
		public SortOrder Order { get; set; }

		// Token: 0x06001C64 RID: 7268 RVA: 0x0000AA2B File Offset: 0x00008C2B
		public Class256()
		{
			this.SortColumn = 0;
			this.Order = SortOrder.None;
			this.caseInsensitiveComparer_0 = new CaseInsensitiveComparer();
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0005BB08 File Offset: 0x00059D08
		public int Compare(object x, object y)
		{
			ListViewItem listViewItem = y as ListViewItem;
			ListViewItem listViewItem2 = x as ListViewItem;
			int num = this.caseInsensitiveComparer_0.Compare(listViewItem2.SubItems[this.SortColumn].Text, listViewItem.SubItems[this.SortColumn].Text);
			if (this.Order == SortOrder.Ascending)
			{
				return num;
			}
			if (this.Order == SortOrder.Descending)
			{
				return -num;
			}
			return 0;
		}

		// Token: 0x04000A27 RID: 2599
		private CaseInsensitiveComparer caseInsensitiveComparer_0;

		// Token: 0x04000A28 RID: 2600
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000A29 RID: 2601
		[CompilerGenerated]
		private SortOrder sortOrder_0;
	}
}
