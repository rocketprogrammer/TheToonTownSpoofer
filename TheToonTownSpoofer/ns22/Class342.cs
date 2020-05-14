using System;
using System.Collections;
using System.Collections.Generic;
using ns14;
using ns24;

namespace ns22
{
	// Token: 0x02000378 RID: 888
	internal sealed class Class342<TObjectType, TOwnerType> : IEnumerable<!0>, ICollection<!0>, IList<TObjectType>, IEnumerable, ICollection, IList where TObjectType : Interface21<TObjectType>, new() where TOwnerType : Interface12<TObjectType>
	{
		// Token: 0x060022DA RID: 8922 RVA: 0x0000ED41 File Offset: 0x0000CF41
		public Class342(TOwnerType owner)
		{
			if (owner == null)
			{
				throw new ArgumentNullException("owner");
			}
			this.gparam_0 = owner;
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x0000ED6E File Offset: 0x0000CF6E
		public int IndexOf(TObjectType item)
		{
			return this.list_0.IndexOf(item);
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x0000ED7C File Offset: 0x0000CF7C
		int IList.IndexOf(object value)
		{
			return this.IndexOf((TObjectType)((object)value));
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x0000ED8A File Offset: 0x0000CF8A
		public void Insert(int index, TObjectType item)
		{
			this.list_0.Insert(index, item);
			item.Owner = this.gparam_0;
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x0000EDB1 File Offset: 0x0000CFB1
		void IList.Insert(int index, object value)
		{
			this.Insert(index, (TObjectType)((object)value));
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0007652C File Offset: 0x0007472C
		public void RemoveAt(int index)
		{
			TObjectType tobjectType = this.list_0[index];
			this.list_0.RemoveAt(index);
			tobjectType.Owner = null;
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		void IList.RemoveAt(int index)
		{
			this.RemoveAt(index);
		}

		// Token: 0x17000905 RID: 2309
		public TObjectType this[int index]
		{
			get
			{
				return this.list_0[index];
			}
			set
			{
				TObjectType tobjectType = this.list_0[index];
				if (!tobjectType.Equals(value))
				{
					TObjectType obj = this.list_0[index];
					TOwnerType townerType = this.gparam_0;
					townerType.imethod_1(obj);
					this.list_0[index] = value;
					value.Owner = this.gparam_0;
					obj.Owner = null;
					TOwnerType townerType2 = this.gparam_0;
					townerType2.imethod_0(this.list_0[index]);
				}
			}
		}

		// Token: 0x17000906 RID: 2310
		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				this[index] = (TObjectType)((object)value);
			}
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00076604 File Offset: 0x00074804
		public void Add(TObjectType item)
		{
			this.list_0.Add(item);
			item.Owner = this.gparam_0;
			TOwnerType townerType = this.gparam_0;
			townerType.imethod_0(item);
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x0000EDF4 File Offset: 0x0000CFF4
		int IList.Add(object item)
		{
			this.Add((TObjectType)((object)item));
			return this.list_0.Count - 1;
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x0000EE0F File Offset: 0x0000D00F
		void ICollection<!0>.Add(TObjectType item)
		{
			this.Add(item);
		}

		// Token: 0x060022E8 RID: 8936 RVA: 0x0000EE18 File Offset: 0x0000D018
		void IList.Clear()
		{
			this.Clear();
		}

		// Token: 0x060022E9 RID: 8937 RVA: 0x0000EE18 File Offset: 0x0000D018
		void ICollection<!0>.Clear()
		{
			this.Clear();
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0007664C File Offset: 0x0007484C
		public void Clear()
		{
			TObjectType[] array = new TObjectType[this.list_0.Count];
			this.list_0.CopyTo(array);
			this.list_0.Clear();
			foreach (TObjectType obj in array)
			{
				obj.Owner = null;
				TOwnerType townerType = this.gparam_0;
				townerType.imethod_1(obj);
			}
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x000766C0 File Offset: 0x000748C0
		public bool Remove(TObjectType item)
		{
			if (this.list_0.Remove(item))
			{
				TOwnerType townerType = this.gparam_0;
				townerType.imethod_1(item);
				return true;
			}
			return false;
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0000EE20 File Offset: 0x0000D020
		bool ICollection<!0>.Remove(TObjectType item)
		{
			return this.Remove(item);
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x0000EE29 File Offset: 0x0000D029
		void IList.Remove(object value)
		{
			this.Remove((TObjectType)((object)value));
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x0000EE38 File Offset: 0x0000D038
		public bool Contains(TObjectType item)
		{
			return this.list_0.Contains(item);
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x0000EE46 File Offset: 0x0000D046
		bool ICollection<!0>.Contains(TObjectType item)
		{
			return this.Contains(item);
		}

		// Token: 0x060022F0 RID: 8944 RVA: 0x0000EE4F File Offset: 0x0000D04F
		bool IList.Contains(object value)
		{
			return this.Contains((TObjectType)((object)value));
		}

		// Token: 0x060022F1 RID: 8945 RVA: 0x0000EE5D File Offset: 0x0000D05D
		void ICollection<!0>.CopyTo(TObjectType[] array, int arrayIndex)
		{
			this.list_0.CopyTo(array, arrayIndex);
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x0000EE6C File Offset: 0x0000D06C
		void ICollection.CopyTo(Array array, int index)
		{
			this.list_0.ToArray().CopyTo(array, index);
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x0000EE80 File Offset: 0x0000D080
		int ICollection.Count
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0000EE88 File Offset: 0x0000D088
		public int Count
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x060022F5 RID: 8949 RVA: 0x0000EE80 File Offset: 0x0000D080
		int ICollection<!0>.Count
		{
			get
			{
				return this.Count;
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x060022F6 RID: 8950 RVA: 0x0000EE95 File Offset: 0x0000D095
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return this.IsReadOnly;
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x060022F7 RID: 8951 RVA: 0x000067F0 File Offset: 0x000049F0
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x060022F8 RID: 8952 RVA: 0x000067F0 File Offset: 0x000049F0
		bool IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x060022F9 RID: 8953 RVA: 0x000067F0 File Offset: 0x000049F0
		bool IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x0000EE9D File Offset: 0x0000D09D
		public IEnumerator<TObjectType> GetEnumerator()
		{
			return this.list_0.GetEnumerator();
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x0000EEAF File Offset: 0x0000D0AF
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060022FC RID: 8956 RVA: 0x0000EEAF File Offset: 0x0000D0AF
		IEnumerator<TObjectType> IEnumerable<!0>.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000067F0 File Offset: 0x000049F0
		bool ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x060022FE RID: 8958 RVA: 0x0000EEB7 File Offset: 0x0000D0B7
		object ICollection.SyncRoot
		{
			get
			{
				return ((ICollection)this.list_0).SyncRoot;
			}
		}

		// Token: 0x04001008 RID: 4104
		private List<TObjectType> list_0 = new List<TObjectType>();

		// Token: 0x04001009 RID: 4105
		private readonly TOwnerType gparam_0;
	}
}
