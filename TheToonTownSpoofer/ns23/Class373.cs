using System;
using System.Runtime.CompilerServices;
using ns31;

namespace ns23
{
	// Token: 0x020003A4 RID: 932
	internal static class Class373
	{
		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x0000F98F File Offset: 0x0000DB8F
		// (set) Token: 0x0600241F RID: 9247 RVA: 0x0000F996 File Offset: 0x0000DB96
		public static Interface18 Logger { get; set; }

		// Token: 0x06002420 RID: 9248 RVA: 0x0000F99E File Offset: 0x0000DB9E
		public static void smethod_0(this Exception ex)
		{
			ex.smethod_1(null);
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x0000F9A7 File Offset: 0x0000DBA7
		public static void smethod_1(this Exception ex, params object[] state)
		{
			if (Class373.Logger != null)
			{
				Class373.Logger.imethod_1(ex, state);
			}
		}

		// Token: 0x040010CA RID: 4298
		[CompilerGenerated]
		private static Interface18 interface18_0;
	}
}
