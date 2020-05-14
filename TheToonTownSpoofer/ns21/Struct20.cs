using System;
using ns31;

namespace ns21
{
	// Token: 0x02000236 RID: 566
	internal struct Struct20 : IDisposable
	{
		// Token: 0x06001858 RID: 6232 RVA: 0x00007DBC File Offset: 0x00005FBC
		public void Dispose()
		{
			if (this.intptr_1 != IntPtr.Zero)
			{
				Class265.LocalFree(this.intptr_1);
				this.intptr_1 = IntPtr.Zero;
			}
		}

		// Token: 0x04000660 RID: 1632
		internal IntPtr intptr_0;

		// Token: 0x04000661 RID: 1633
		public int int_0;

		// Token: 0x04000662 RID: 1634
		internal IntPtr intptr_1;
	}
}
