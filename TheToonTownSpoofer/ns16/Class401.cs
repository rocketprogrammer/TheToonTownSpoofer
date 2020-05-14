using System;
using System.Diagnostics;

namespace ns16
{
	// Token: 0x020003DD RID: 989
	internal static class Class401
	{
		// Token: 0x060025E1 RID: 9697 RVA: 0x00010ADA File Offset: 0x0000ECDA
		[DebuggerStepThrough]
		public static bool smethod_0(this char c)
		{
			return (c >= 'a' && c <= 'f') || (c >= '0' && c <= '9') || (c >= 'A' && c <= 'F');
		}
	}
}
