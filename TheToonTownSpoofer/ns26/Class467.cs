using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ns26
{
	// Token: 0x02000462 RID: 1122
	internal static class Class467
	{
		// Token: 0x060029BB RID: 10683 RVA: 0x0009FF60 File Offset: 0x0009E160
		public static void smethod_0<T>(this T[] values, int shift)
		{
			int num = values.Length;
			shift %= num;
			if (shift != 0)
			{
				T[] array = new T[num];
				if (shift < 0)
				{
					shift = -shift;
					shift = num - shift;
				}
				int num2 = num - shift;
				Array.Copy(values, 0, array, shift, num2);
				Array.Copy(values, num2, array, 0, shift);
				Array.Copy(array, values, num);
			}
		}

		// Token: 0x060029BC RID: 10684 RVA: 0x0009FFB0 File Offset: 0x0009E1B0
		public static void smethod_1<T>(this List<T> list, int shift)
		{
			int count = list.Count;
			shift %= count;
			if (shift != 0)
			{
				T[] array = list.ToArray();
				array.smethod_0(shift);
				list.Clear();
				list.AddRange(array);
			}
		}

		// Token: 0x060029BD RID: 10685 RVA: 0x0009FFEC File Offset: 0x0009E1EC
		[DebuggerStepThrough]
		public static bool smethod_2<TKey, TValue>(this Dictionary<TKey, TValue> dic, params TKey[] keys)
		{
			if (keys == null)
			{
				throw new ArgumentNullException("keys");
			}
			if (keys.Length == 0)
			{
				throw new ArgumentException("There are no elements in the keys collection.");
			}
			foreach (TKey key in keys)
			{
				if (!dic.ContainsKey(key))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060029BE RID: 10686 RVA: 0x000A0040 File Offset: 0x0009E240
		public static bool smethod_3<TKey, TValue>(this Dictionary<TKey, TValue> dic, params TValue[] values)
		{
			if (values == null)
			{
				throw new ArgumentNullException("values");
			}
			if (values.Length == 0)
			{
				throw new ArgumentException("There are no elements in the values collection.");
			}
			List<TValue> list = new List<TValue>(dic.Values);
			foreach (TValue item in values)
			{
				if (!list.Contains(item))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060029BF RID: 10687 RVA: 0x000A00A4 File Offset: 0x0009E2A4
		[DebuggerStepThrough]
		public static bool smethod_4<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, TValue value)
		{
			if (dic.ContainsKey(key))
			{
				TValue tvalue = dic[key];
				return tvalue.Equals(value);
			}
			return false;
		}

		// Token: 0x060029C0 RID: 10688 RVA: 0x000134FE File Offset: 0x000116FE
		[DebuggerStepThrough]
		public static bool smethod_5<TKey, TValue>(this Dictionary<TKey, TValue> dic, TKey key, Action<KeyValuePair<TKey, TValue>> del)
		{
			if (dic.ContainsKey(key))
			{
				del(new KeyValuePair<TKey, TValue>(key, dic[key]));
				return true;
			}
			return false;
		}

		// Token: 0x060029C1 RID: 10689 RVA: 0x000A00D8 File Offset: 0x0009E2D8
		[DebuggerStepThrough]
		public static T[] smethod_6<T>(this T[] arr, int startIndex)
		{
			T[] array = new T[arr.Length - startIndex];
			Array.Copy(arr, startIndex, array, 0, arr.Length - startIndex);
			return array;
		}

		// Token: 0x060029C2 RID: 10690 RVA: 0x000A0100 File Offset: 0x0009E300
		[DebuggerStepThrough]
		public static void smethod_7<T>(this IEnumerable<T> col, Action<T> del)
		{
			foreach (T obj in col)
			{
				del(obj);
			}
		}

		// Token: 0x060029C3 RID: 10691 RVA: 0x000A0148 File Offset: 0x0009E348
		[DebuggerStepThrough]
		public static void smethod_8<T, T2>(this Dictionary<T, T2> dic, IEnumerable<T> items)
		{
			Class467.Class468<T, T2> @class = new Class467.Class468<T, T2>();
			@class.dictionary_0 = dic;
			items.smethod_7(new Action<T>(@class.method_0));
		}

		// Token: 0x060029C4 RID: 10692 RVA: 0x000A0174 File Offset: 0x0009E374
		[DebuggerStepThrough]
		public static bool smethod_9<T>(this IEnumerable<T> enumeration1, IEnumerable<T> enumeration2)
		{
			using (IEnumerator<T> enumerator = enumeration1.GetEnumerator())
			{
				using (IEnumerator<T> enumerator2 = enumeration2.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						if (!enumerator.MoveNext())
						{
							return false;
						}
						T t = enumerator2.Current;
						if (!t.Equals(enumerator.Current))
						{
							return false;
						}
					}
					if (enumerator.MoveNext())
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x000A0210 File Offset: 0x0009E410
		[DebuggerStepThrough]
		public static bool smethod_10<T>(this IEnumerable<T> source, Func<T, bool> predicate)
		{
			using (IEnumerator<T> enumerator = source.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (predicate(enumerator.Current))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x02000463 RID: 1123
		[CompilerGenerated]
		private sealed class Class468<T, T2>
		{
			// Token: 0x060029C7 RID: 10695 RVA: 0x0001351F File Offset: 0x0001171F
			public void method_0(T item)
			{
				this.dictionary_0.Remove(item);
			}

			// Token: 0x040015E7 RID: 5607
			public Dictionary<T, T2> dictionary_0;
		}
	}
}
