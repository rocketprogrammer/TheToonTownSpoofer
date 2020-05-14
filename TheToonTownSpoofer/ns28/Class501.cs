using System;

namespace ns28
{
	// Token: 0x020004A3 RID: 1187
	internal sealed class Class501
	{
		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06002C41 RID: 11329 RVA: 0x000AB220 File Offset: 0x000A9420
		public bool IsCancelling
		{
			get
			{
				bool result;
				lock (this.object_0)
				{
					result = this.bool_0;
				}
				return result;
			}
		}

		// Token: 0x06002C42 RID: 11330 RVA: 0x000AB264 File Offset: 0x000A9464
		public void method_0()
		{
			lock (this.object_0)
			{
				this.bool_0 = true;
			}
		}

		// Token: 0x0400173F RID: 5951
		private readonly object object_0 = new object();

		// Token: 0x04001740 RID: 5952
		private bool bool_0;
	}
}
