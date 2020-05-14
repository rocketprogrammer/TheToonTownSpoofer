using System;
using System.Diagnostics;

namespace ns24
{
	// Token: 0x0200031B RID: 795
	internal static class Class303
	{
		// Token: 0x06001ECF RID: 7887 RVA: 0x0000BFDB File Offset: 0x0000A1DB
		[DebuggerStepThrough]
		public static bool smethod_0(this Uri uri)
		{
			return uri.IsAbsoluteUri && (uri.Scheme == "http" || uri.Scheme == "https");
		}
	}
}
