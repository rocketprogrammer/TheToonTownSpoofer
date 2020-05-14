using System;
using System.Runtime.InteropServices;
using ns5;
using ns6;

namespace ns10
{
	// Token: 0x0200014E RID: 334
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class Class14 : GInterface79
	{
		// Token: 0x06001189 RID: 4489 RVA: 0x00003610 File Offset: 0x00001810
		public void onvideostart()
		{
			if (this.delegate67_0 != null)
			{
				this.delegate67_0();
				return;
			}
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x0000362C File Offset: 0x0000182C
		public void onvideoend()
		{
			if (this.delegate68_0 != null)
			{
				this.delegate68_0();
				return;
			}
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00003648 File Offset: 0x00001848
		internal Class14()
		{
			this.int_0 = 0;
			this.delegate67_0 = null;
			this.delegate68_0 = null;
		}

		// Token: 0x040000DA RID: 218
		public Delegate67 delegate67_0;

		// Token: 0x040000DB RID: 219
		public Delegate68 delegate68_0;

		// Token: 0x040000DC RID: 220
		public int int_0;
	}
}
