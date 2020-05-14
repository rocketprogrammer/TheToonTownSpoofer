using System;
using System.Windows.Forms;
using ns31;

namespace ns24
{
	// Token: 0x02000307 RID: 775
	internal sealed class Class295 : ComboBox, Interface19
	{
		// Token: 0x06001E5A RID: 7770 RVA: 0x0000B9CB File Offset: 0x00009BCB
		public void imethod_0(int index)
		{
			base.RefreshItem(index);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0000B9D4 File Offset: 0x00009BD4
		public void imethod_1()
		{
			base.RefreshItems();
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x00062AF0 File Offset: 0x00060CF0
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
