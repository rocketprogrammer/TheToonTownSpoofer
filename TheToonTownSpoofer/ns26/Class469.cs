using System;
using System.Collections.Generic;

namespace ns26
{
	// Token: 0x02000464 RID: 1124
	internal static class Class469
	{
		// Token: 0x060029C8 RID: 10696 RVA: 0x0001352E File Offset: 0x0001172E
		public static void smethod_0<T>(this T[] source, T[] destination, ref int startIndex)
		{
			Array.Copy(source, 0, destination, startIndex, source.Length);
			startIndex += source.Length;
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x000A0260 File Offset: 0x0009E460
		public static void smethod_1<T>(this IEnumerable<T> array) where T : IDisposable
		{
			foreach (T t in array)
			{
				if (t != null)
				{
					t.Dispose();
				}
			}
		}
	}
}
