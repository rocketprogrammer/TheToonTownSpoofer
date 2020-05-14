using System;
using System.Windows.Forms;

namespace ns16
{
	// Token: 0x020003C3 RID: 963
	internal struct Struct38 : IDisposable
	{
		// Token: 0x06002525 RID: 9509 RVA: 0x000104A2 File Offset: 0x0000E6A2
		public Struct38(Form owner)
		{
			owner.Hide();
			this.form_0 = owner;
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x000104B1 File Offset: 0x0000E6B1
		public void Dispose()
		{
			if (this.form_0 != null && !this.form_0.IsDisposed && !this.form_0.Disposing)
			{
				this.form_0.Show();
				this.form_0 = null;
			}
		}

		// Token: 0x04001165 RID: 4453
		private Form form_0;
	}
}
