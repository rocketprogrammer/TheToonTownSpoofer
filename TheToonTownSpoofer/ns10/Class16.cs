using System;
using System.Runtime.InteropServices;
using ns5;

namespace ns10
{
	// Token: 0x02000150 RID: 336
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class Class16 : GInterface76
	{
		// Token: 0x06001193 RID: 4499 RVA: 0x00003689 File Offset: 0x00001889
		public void ondragbegin()
		{
			if (this.delegate64_0 != null)
			{
				this.delegate64_0();
				return;
			}
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x000036A5 File Offset: 0x000018A5
		public void ondragend()
		{
			if (this.delegate65_0 != null)
			{
				this.delegate65_0();
				return;
			}
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x000036C1 File Offset: 0x000018C1
		public void onpositionchange()
		{
			if (this.delegate66_0 != null)
			{
				this.delegate66_0();
				return;
			}
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x000036DD File Offset: 0x000018DD
		internal Class16()
		{
			this.int_0 = 0;
			this.delegate64_0 = null;
			this.delegate65_0 = null;
			this.delegate66_0 = null;
		}

		// Token: 0x040000E0 RID: 224
		public Delegate64 delegate64_0;

		// Token: 0x040000E1 RID: 225
		public Delegate65 delegate65_0;

		// Token: 0x040000E2 RID: 226
		public Delegate66 delegate66_0;

		// Token: 0x040000E3 RID: 227
		public int int_0;
	}
}
