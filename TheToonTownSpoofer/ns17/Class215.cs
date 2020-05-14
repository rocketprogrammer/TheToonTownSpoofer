using System;
using System.Runtime.InteropServices;
using ns25;

namespace ns17
{
	// Token: 0x02000272 RID: 626
	internal sealed class Class215<T> : IDisposable where T : class
	{
		// Token: 0x06001A61 RID: 6753 RVA: 0x000095D9 File Offset: 0x000077D9
		public Class215(T target)
		{
			this.class315_0 = new Class315(target, GCHandleType.Weak);
		}

		// Token: 0x170007A8 RID: 1960
		// (get) Token: 0x06001A62 RID: 6754 RVA: 0x0004E258 File Offset: 0x0004C458
		public T Target
		{
			get
			{
				return this.class315_0.Handle.Target as T;
			}
		}

		// Token: 0x170007A9 RID: 1961
		// (get) Token: 0x06001A63 RID: 6755 RVA: 0x0004E284 File Offset: 0x0004C484
		public bool IsAlive
		{
			get
			{
				return this.class315_0.Handle.Target != null;
			}
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000095F3 File Offset: 0x000077F3
		public void Dispose()
		{
			this.class315_0.Dispose();
		}

		// Token: 0x040007EF RID: 2031
		private Class315 class315_0;
	}
}
