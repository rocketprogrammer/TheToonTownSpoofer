using System;
using System.Runtime.InteropServices;
using ns7;

namespace ns10
{
	// Token: 0x02000154 RID: 340
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	internal sealed class Class20 : GInterface106
	{
		// Token: 0x06001261 RID: 4705 RVA: 0x00003FA0 File Offset: 0x000021A0
		public void ondragbegin()
		{
			if (this.delegate81_0 != null)
			{
				this.delegate81_0();
				return;
			}
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00003FBC File Offset: 0x000021BC
		public void ondragend()
		{
			if (this.delegate82_0 != null)
			{
				this.delegate82_0();
				return;
			}
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x00003FD8 File Offset: 0x000021D8
		public void onpositionchange()
		{
			if (this.delegate83_0 != null)
			{
				this.delegate83_0();
				return;
			}
		}

		// Token: 0x06001264 RID: 4708 RVA: 0x00003FF4 File Offset: 0x000021F4
		internal Class20()
		{
			this.int_0 = 0;
			this.delegate81_0 = null;
			this.delegate82_0 = null;
			this.delegate83_0 = null;
		}

		// Token: 0x0400012A RID: 298
		public Delegate81 delegate81_0;

		// Token: 0x0400012B RID: 299
		public Delegate82 delegate82_0;

		// Token: 0x0400012C RID: 300
		public Delegate83 delegate83_0;

		// Token: 0x0400012D RID: 301
		public int int_0;
	}
}
