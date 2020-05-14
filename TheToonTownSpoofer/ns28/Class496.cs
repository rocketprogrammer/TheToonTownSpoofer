using System;

namespace ns28
{
	// Token: 0x0200049E RID: 1182
	internal static class Class496
	{
		// Token: 0x06002BF8 RID: 11256 RVA: 0x000AAB54 File Offset: 0x000A8D54
		public static TResult smethod_0<T, TResult>(this T obj, Func<T, TResult> eval) where T : class where TResult : class
		{
			if (object.ReferenceEquals(obj, null))
			{
				return default(TResult);
			}
			return eval(obj);
		}

		// Token: 0x06002BF9 RID: 11257 RVA: 0x0001477B File Offset: 0x0001297B
		public static TResult smethod_1<T, TResult>(this T obj, Func<T, TResult> eval, TResult failureValue) where T : class
		{
			if (object.ReferenceEquals(obj, null))
			{
				return failureValue;
			}
			return eval(obj);
		}
	}
}
