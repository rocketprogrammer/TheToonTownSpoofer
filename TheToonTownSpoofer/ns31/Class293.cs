using System;
using System.Windows.Forms;

namespace ns31
{
	// Token: 0x02000305 RID: 773
	internal sealed class Class293 : ListBox, Interface19
	{
		// Token: 0x06001E55 RID: 7765 RVA: 0x0000B9B2 File Offset: 0x00009BB2
		public void imethod_0(int index)
		{
			base.RefreshItem(index);
		}

		// Token: 0x06001E56 RID: 7766 RVA: 0x0000B9BB File Offset: 0x00009BBB
		public void imethod_1()
		{
			base.RefreshItems();
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x000629CC File Offset: 0x00060BCC
		public void imethod_2(object obj)
		{
			int num = base.Items.IndexOf(obj);
			if (num == -1)
			{
				throw new ArgumentException("The specified object does not exist in this instance.");
			}
			base.RefreshItem(num);
		}
	}
}
