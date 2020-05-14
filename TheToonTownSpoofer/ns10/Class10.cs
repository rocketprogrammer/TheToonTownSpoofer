using System;
using System.Runtime.InteropServices;
using ns7;

namespace ns10
{
	// Token: 0x0200014A RID: 330
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	internal sealed class Class10 : GInterface103
	{
		// Token: 0x0600115A RID: 4442 RVA: 0x00003459 File Offset: 0x00001659
		public void onblur()
		{
			if (this.delegate69_0 != null)
			{
				this.delegate69_0();
				return;
			}
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00003475 File Offset: 0x00001675
		public void onfocus()
		{
			if (this.delegate70_0 != null)
			{
				this.delegate70_0();
				return;
			}
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00003491 File Offset: 0x00001691
		public void onclick()
		{
			if (this.delegate71_0 != null)
			{
				this.delegate71_0();
				return;
			}
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x000034AD File Offset: 0x000016AD
		public void ondblclick()
		{
			if (this.delegate72_0 != null)
			{
				this.delegate72_0();
				return;
			}
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x000034C9 File Offset: 0x000016C9
		public void onmousedown()
		{
			if (this.delegate73_0 != null)
			{
				this.delegate73_0();
				return;
			}
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x000034E5 File Offset: 0x000016E5
		public void onmouseup()
		{
			if (this.delegate74_0 != null)
			{
				this.delegate74_0();
				return;
			}
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x00003501 File Offset: 0x00001701
		public void onmousemove()
		{
			if (this.delegate75_0 != null)
			{
				this.delegate75_0();
				return;
			}
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x0000351D File Offset: 0x0000171D
		public void onmouseover()
		{
			if (this.delegate76_0 != null)
			{
				this.delegate76_0();
				return;
			}
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x00003539 File Offset: 0x00001739
		public void onmouseout()
		{
			if (this.delegate77_0 != null)
			{
				this.delegate77_0();
				return;
			}
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00003555 File Offset: 0x00001755
		public void onkeypress()
		{
			if (this.delegate78_0 != null)
			{
				this.delegate78_0();
				return;
			}
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00003571 File Offset: 0x00001771
		public void onkeydown()
		{
			if (this.delegate79_0 != null)
			{
				this.delegate79_0();
				return;
			}
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0000358D File Offset: 0x0000178D
		public void onkeyup()
		{
			if (this.delegate80_0 != null)
			{
				this.delegate80_0();
				return;
			}
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x000177E8 File Offset: 0x000159E8
		internal Class10()
		{
			this.int_0 = 0;
			this.delegate69_0 = null;
			this.delegate70_0 = null;
			this.delegate71_0 = null;
			this.delegate72_0 = null;
			this.delegate73_0 = null;
			this.delegate74_0 = null;
			this.delegate75_0 = null;
			this.delegate76_0 = null;
			this.delegate77_0 = null;
			this.delegate78_0 = null;
			this.delegate79_0 = null;
			this.delegate80_0 = null;
		}

		// Token: 0x040000C5 RID: 197
		public Delegate69 delegate69_0;

		// Token: 0x040000C6 RID: 198
		public Delegate70 delegate70_0;

		// Token: 0x040000C7 RID: 199
		public Delegate71 delegate71_0;

		// Token: 0x040000C8 RID: 200
		public Delegate72 delegate72_0;

		// Token: 0x040000C9 RID: 201
		public Delegate73 delegate73_0;

		// Token: 0x040000CA RID: 202
		public Delegate74 delegate74_0;

		// Token: 0x040000CB RID: 203
		public Delegate75 delegate75_0;

		// Token: 0x040000CC RID: 204
		public Delegate76 delegate76_0;

		// Token: 0x040000CD RID: 205
		public Delegate77 delegate77_0;

		// Token: 0x040000CE RID: 206
		public Delegate78 delegate78_0;

		// Token: 0x040000CF RID: 207
		public Delegate79 delegate79_0;

		// Token: 0x040000D0 RID: 208
		public Delegate80 delegate80_0;

		// Token: 0x040000D1 RID: 209
		public int int_0;
	}
}
