using System;
using ns31;

namespace ns26
{
	// Token: 0x0200045A RID: 1114
	internal struct Struct45 : IDisposable
	{
		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002994 RID: 10644 RVA: 0x000132CE File Offset: 0x000114CE
		internal IntPtr hObject
		{
			get
			{
				return this.intptr_0;
			}
		}

		// Token: 0x06002995 RID: 10645 RVA: 0x000132D6 File Offset: 0x000114D6
		internal Struct45(IntPtr hObject)
		{
			this.intptr_0 = hObject;
		}

		// Token: 0x06002996 RID: 10646 RVA: 0x000132DF File Offset: 0x000114DF
		public static Struct45 smethod_0(IntPtr hObject)
		{
			return new Struct45(hObject);
		}

		// Token: 0x06002997 RID: 10647 RVA: 0x000132E7 File Offset: 0x000114E7
		public static IntPtr smethod_1(Struct45 hObject)
		{
			return hObject.hObject;
		}

		// Token: 0x06002998 RID: 10648 RVA: 0x000132F0 File Offset: 0x000114F0
		public void Dispose()
		{
			if (this.intptr_0 != IntPtr.Zero)
			{
				Class265.DeleteObject(this.intptr_0);
			}
		}

		// Token: 0x040015CB RID: 5579
		private IntPtr intptr_0;
	}
}
