using System;
using ns19;
using ns26;

namespace ns31
{
	// Token: 0x020002F9 RID: 761
	internal struct Struct26
	{
		// Token: 0x06001DEF RID: 7663 RVA: 0x0000B583 File Offset: 0x00009783
		public Struct26(Enum97 msgType, Class464 cog, uint cogsRemaining, bool skelecog)
		{
			this.enum97_0 = msgType;
			this.class464_0 = cog;
			this.uint_0 = cogsRemaining;
			this.bool_0 = skelecog;
			this.dateTime_0 = DateTime.Now;
		}

		// Token: 0x04000B3E RID: 2878
		public readonly Enum97 enum97_0;

		// Token: 0x04000B3F RID: 2879
		public readonly Class464 class464_0;

		// Token: 0x04000B40 RID: 2880
		public readonly uint uint_0;

		// Token: 0x04000B41 RID: 2881
		public readonly bool bool_0;

		// Token: 0x04000B42 RID: 2882
		public readonly DateTime dateTime_0;
	}
}
