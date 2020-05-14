using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using ns29;

namespace TSN.Collections
{
	// Token: 0x020004AB RID: 1195
	[DebuggerDisplay("Count = {Count}")]
	[ComVisible(false)]
	[DebuggerTypeProxy(typeof(Class519<, >))]
	[Serializable]
	public sealed class ReadOnlyDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable, ICollection
	{
		// Token: 0x06002C81 RID: 11393 RVA: 0x0001503D File Offset: 0x0001323D
		public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this.m_dicSource = dictionary;
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06002C82 RID: 11394 RVA: 0x0001505A File Offset: 0x0001325A
		public int Count
		{
			get
			{
				return this.m_dicSource.Count;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06002C83 RID: 11395 RVA: 0x00015067 File Offset: 0x00013267
		public ICollection<TKey> Keys
		{
			get
			{
				return this.m_dicSource.Keys;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06002C84 RID: 11396 RVA: 0x00015074 File Offset: 0x00013274
		public ICollection<TValue> Values
		{
			get
			{
				return this.m_dicSource.Values;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06002C85 RID: 11397 RVA: 0x00005B66 File Offset: 0x00003D66
		bool ICollection<KeyValuePair<!0, !1>>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06002C86 RID: 11398 RVA: 0x000067F0 File Offset: 0x000049F0
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06002C87 RID: 11399 RVA: 0x000AC3E4 File Offset: 0x000AA5E4
		object ICollection.SyncRoot
		{
			get
			{
				if (this.m_objSyncRoot == null)
				{
					ICollection collection = this.m_dicSource as ICollection;
					if (collection != null)
					{
						this.m_objSyncRoot = collection.SyncRoot;
					}
					else
					{
						Interlocked.CompareExchange(ref this.m_objSyncRoot, new object(), null);
					}
				}
				return this.m_objSyncRoot;
			}
		}

		// Token: 0x17000AFF RID: 2815
		public TValue this[TKey key]
		{
			get
			{
				return this.m_dicSource[key];
			}
			set
			{
				ReadOnlyDictionary<TKey, TValue>.smethod_0();
			}
		}

		// Token: 0x06002C8A RID: 11402 RVA: 0x0001508F File Offset: 0x0001328F
		void IDictionary<!0, !1>.Add(TKey key, TValue value)
		{
			ReadOnlyDictionary<TKey, TValue>.smethod_0();
		}

		// Token: 0x06002C8B RID: 11403 RVA: 0x00015096 File Offset: 0x00013296
		public bool ContainsKey(TKey key)
		{
			return this.m_dicSource.ContainsKey(key);
		}

		// Token: 0x06002C8C RID: 11404 RVA: 0x000150A4 File Offset: 0x000132A4
		bool IDictionary<!0, !1>.Remove(TKey key)
		{
			ReadOnlyDictionary<TKey, TValue>.smethod_0();
			return false;
		}

		// Token: 0x06002C8D RID: 11405 RVA: 0x000150AC File Offset: 0x000132AC
		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.m_dicSource.TryGetValue(key, out value);
		}

		// Token: 0x06002C8E RID: 11406 RVA: 0x0001508F File Offset: 0x0001328F
		void ICollection<KeyValuePair<!0, !1>>.Add(KeyValuePair<TKey, TValue> item)
		{
			ReadOnlyDictionary<TKey, TValue>.smethod_0();
		}

		// Token: 0x06002C8F RID: 11407 RVA: 0x0001508F File Offset: 0x0001328F
		void ICollection<KeyValuePair<!0, !1>>.Clear()
		{
			ReadOnlyDictionary<TKey, TValue>.smethod_0();
		}

		// Token: 0x06002C90 RID: 11408 RVA: 0x000AC430 File Offset: 0x000AA630
		bool ICollection<KeyValuePair<!0, !1>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			ICollection<KeyValuePair<TKey, TValue>> dicSource = this.m_dicSource;
			return dicSource.Contains(item);
		}

		// Token: 0x06002C91 RID: 11409 RVA: 0x000AC44C File Offset: 0x000AA64C
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			ICollection<KeyValuePair<TKey, TValue>> dicSource = this.m_dicSource;
			dicSource.CopyTo(array, arrayIndex);
		}

		// Token: 0x06002C92 RID: 11410 RVA: 0x000150A4 File Offset: 0x000132A4
		bool ICollection<KeyValuePair<!0, !1>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			ReadOnlyDictionary<TKey, TValue>.smethod_0();
			return false;
		}

		// Token: 0x06002C93 RID: 11411 RVA: 0x000AC468 File Offset: 0x000AA668
		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<!0, !1>>.GetEnumerator()
		{
			IEnumerable<KeyValuePair<TKey, TValue>> dicSource = this.m_dicSource;
			return dicSource.GetEnumerator();
		}

		// Token: 0x06002C94 RID: 11412 RVA: 0x000150BB File Offset: 0x000132BB
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.m_dicSource.GetEnumerator();
		}

		// Token: 0x06002C95 RID: 11413 RVA: 0x000AC484 File Offset: 0x000AA684
		void ICollection.CopyTo(Array array, int index)
		{
			ICollection collection = new List<KeyValuePair<TKey, TValue>>(this.m_dicSource);
			collection.CopyTo(array, index);
		}

		// Token: 0x06002C96 RID: 11414 RVA: 0x000150C8 File Offset: 0x000132C8
		private static void smethod_0()
		{
			throw new NotSupportedException("The Dictionary is read-only.");
		}

		// Token: 0x04001765 RID: 5989
		private readonly IDictionary<TKey, TValue> m_dicSource;

		// Token: 0x04001766 RID: 5990
		private object m_objSyncRoot;
	}
}
