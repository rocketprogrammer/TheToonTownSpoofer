using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ns28
{
	// Token: 0x020004AC RID: 1196
	internal sealed class Class506<Key, Value> : IEnumerable<KeyValuePair<!0, !1>>, IDictionary<!0, !1>, ICollection<KeyValuePair<!0, !1>>, IEnumerable
	{
		// Token: 0x06002C97 RID: 11415 RVA: 0x000150D4 File Offset: 0x000132D4
		[DebuggerStepThrough]
		public Class506() : this(0)
		{
		}

		// Token: 0x06002C98 RID: 11416 RVA: 0x000150DD File Offset: 0x000132DD
		[DebuggerStepThrough]
		public Class506(IEqualityComparer<Key> comparer) : this(0, comparer)
		{
		}

		// Token: 0x06002C99 RID: 11417 RVA: 0x000AC4A8 File Offset: 0x000AA6A8
		[DebuggerStepThrough]
		private Class506(Class506<Key, Value> dictionary)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			this.bool_0 = true;
			this.list_0 = dictionary.list_0;
			this.dictionary_0 = dictionary.dictionary_0;
			this.iequalityComparer_0 = dictionary.iequalityComparer_0;
			this.int_0 = dictionary.int_0;
		}

		// Token: 0x06002C9A RID: 11418 RVA: 0x000150E7 File Offset: 0x000132E7
		[DebuggerStepThrough]
		public Class506(int capacity) : this(capacity, null)
		{
		}

		// Token: 0x06002C9B RID: 11419 RVA: 0x000150F1 File Offset: 0x000132F1
		[DebuggerStepThrough]
		public Class506(int capacity, IEqualityComparer<Key> comparer)
		{
			this.int_0 = capacity;
			this.iequalityComparer_0 = comparer;
		}

		// Token: 0x06002C9C RID: 11420 RVA: 0x00015107 File Offset: 0x00013307
		[DebuggerStepThrough]
		public void Add(Key key, Value value)
		{
			this.method_5();
			this.objectsTable.Add(key, value);
			this.objectsArray.Add(new KeyValuePair<Key, Value>(key, value));
		}

		// Token: 0x06002C9D RID: 11421 RVA: 0x0001512E File Offset: 0x0001332E
		[DebuggerStepThrough]
		public void Add(KeyValuePair<Key, Value> item)
		{
			this.method_5();
			this.objectsTable.Add(item.Key, item.Value);
			this.objectsArray.Add(item);
		}

		// Token: 0x06002C9E RID: 11422 RVA: 0x000AC500 File Offset: 0x000AA700
		[DebuggerStepThrough]
		public bool Contains(KeyValuePair<Key, Value> item)
		{
			if (this.objectsTable.ContainsKey(item.Key))
			{
				Value value = this.objectsTable[item.Key];
				if (value.Equals(item.Value))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002C9F RID: 11423 RVA: 0x0001515B File Offset: 0x0001335B
		[DebuggerStepThrough]
		public bool ContainsKey(Key key)
		{
			return this.objectsTable.ContainsKey(key);
		}

		// Token: 0x06002CA0 RID: 11424 RVA: 0x00015169 File Offset: 0x00013369
		[DebuggerStepThrough]
		public bool method_0(Value value)
		{
			return this.objectsTable.ContainsValue(value);
		}

		// Token: 0x06002CA1 RID: 11425 RVA: 0x000AC554 File Offset: 0x000AA754
		[DebuggerStepThrough]
		private int method_1(Value value)
		{
			for (int i = 0; i < this.objectsArray.Count; i++)
			{
				Value value2 = this.objectsArray[i].Value;
				if (value2.Equals(value))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06002CA2 RID: 11426 RVA: 0x000AC5A4 File Offset: 0x000AA7A4
		[DebuggerStepThrough]
		private int method_2(Key key)
		{
			for (int i = 0; i < this.objectsArray.Count; i++)
			{
				KeyValuePair<Key, Value> keyValuePair = this.objectsArray[i];
				if (this.iequalityComparer_0 != null)
				{
					if (this.iequalityComparer_0.Equals(keyValuePair.Key, key))
					{
						return i;
					}
				}
				else
				{
					Key key2 = keyValuePair.Key;
					if (key2.Equals(key))
					{
						return i;
					}
				}
			}
			return -1;
		}

		// Token: 0x06002CA3 RID: 11427 RVA: 0x00015177 File Offset: 0x00013377
		public int method_3(Key key)
		{
			return this.method_2(key);
		}

		// Token: 0x06002CA4 RID: 11428 RVA: 0x000AC618 File Offset: 0x000AA818
		[DebuggerStepThrough]
		public bool Remove(KeyValuePair<Key, Value> item)
		{
			this.method_5();
			if (this.ContainsKey(item.Key))
			{
				Value value = this.objectsTable[item.Key];
				if (value.Equals(item.Value))
				{
					this.Remove(item.Key);
					return true;
				}
			}
			return false;
		}

		// Token: 0x06002CA5 RID: 11429 RVA: 0x000AC67C File Offset: 0x000AA87C
		[DebuggerStepThrough]
		public bool Remove(Key key)
		{
			this.method_5();
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			int num = this.method_2(key);
			if (num >= 0)
			{
				this.objectsTable.Remove(key);
				this.objectsArray.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x06002CA6 RID: 11430 RVA: 0x000AC6CC File Offset: 0x000AA8CC
		[DebuggerStepThrough]
		public bool Remove(Value value)
		{
			this.method_5();
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			int num = this.method_1(value);
			if (num >= 0)
			{
				this.objectsTable.Remove(this.objectsArray[num].Key);
				this.objectsArray.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x06002CA7 RID: 11431 RVA: 0x000AC730 File Offset: 0x000AA930
		[DebuggerStepThrough]
		public void method_4(int index)
		{
			this.method_5();
			if (index >= this.Count || index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			KeyValuePair<Key, Value> keyValuePair = this.objectsArray[index];
			this.objectsArray.RemoveAt(index);
			this.objectsTable.Remove(keyValuePair.Key);
		}

		// Token: 0x06002CA8 RID: 11432 RVA: 0x000AC788 File Offset: 0x000AA988
		[DebuggerStepThrough]
		public IEnumerator<KeyValuePair<Key, Value>> GetEnumerator()
		{
			Class506<Key, Value>.Class507 @class = new Class506<Key, Value>.Class507(0);
			@class.class506_0 = this;
			return @class;
		}

		// Token: 0x06002CA9 RID: 11433 RVA: 0x00015180 File Offset: 0x00013380
		[DebuggerStepThrough]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06002CAA RID: 11434 RVA: 0x00015188 File Offset: 0x00013388
		public bool IsReadOnly
		{
			[DebuggerStepThrough]
			get
			{
				return this.bool_0;
			}
		}

		// Token: 0x06002CAB RID: 11435 RVA: 0x00015190 File Offset: 0x00013390
		[DebuggerStepThrough]
		private void method_5()
		{
			if (this.bool_0)
			{
				throw new NotSupportedException("Collection is readonly.");
			}
		}

		// Token: 0x17000B01 RID: 2817
		public KeyValuePair<Key, Value> this[int index]
		{
			[DebuggerStepThrough]
			get
			{
				return this.objectsArray[index];
			}
			[DebuggerStepThrough]
			set
			{
				this.method_5();
				if (index < 0 || index >= this.objectsArray.Count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				this.objectsTable.Remove(this.objectsArray[index].Key);
				this.objectsArray[index] = value;
				this.objectsTable.Add(value.Key, value.Value);
			}
		}

		// Token: 0x17000B02 RID: 2818
		public Value this[Key key]
		{
			[DebuggerStepThrough]
			get
			{
				return this.objectsTable[key];
			}
			[DebuggerStepThrough]
			set
			{
				this.method_5();
				if (this.objectsTable.ContainsKey(key))
				{
					this.objectsTable[key] = value;
					this.objectsArray[this.method_2(key)] = new KeyValuePair<Key, Value>(key, value);
					return;
				}
				this.Add(key, value);
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06002CB0 RID: 11440 RVA: 0x000151C1 File Offset: 0x000133C1
		private List<KeyValuePair<Key, Value>> objectsArray
		{
			[DebuggerStepThrough]
			get
			{
				if (this.list_0 == null)
				{
					this.list_0 = new List<KeyValuePair<Key, Value>>(this.int_0);
				}
				return this.list_0;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06002CB1 RID: 11441 RVA: 0x000151E2 File Offset: 0x000133E2
		private Dictionary<Key, Value> objectsTable
		{
			[DebuggerStepThrough]
			get
			{
				if (this.dictionary_0 == null)
				{
					this.dictionary_0 = new Dictionary<Key, Value>(this.int_0, this.iequalityComparer_0);
				}
				return this.dictionary_0;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06002CB2 RID: 11442 RVA: 0x00015209 File Offset: 0x00013409
		public ICollection<Key> Keys
		{
			[DebuggerStepThrough]
			get
			{
				IEnumerable<KeyValuePair<Key, Value>> objectsArray = this.objectsArray;
				if (Class506<Key, Value>.func_0 == null)
				{
					Class506<Key, Value>.func_0 = new Func<KeyValuePair<Key, Value>, Key>(Class506<Key, Value>.smethod_0);
				}
				return objectsArray.Select(Class506<Key, Value>.func_0).ToArray<Key>();
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06002CB3 RID: 11443 RVA: 0x00015238 File Offset: 0x00013438
		public ICollection<Value> Values
		{
			[DebuggerStepThrough]
			get
			{
				IEnumerable<KeyValuePair<Key, Value>> objectsArray = this.objectsArray;
				if (Class506<Key, Value>.func_1 == null)
				{
					Class506<Key, Value>.func_1 = new Func<KeyValuePair<Key, Value>, Value>(Class506<Key, Value>.smethod_1);
				}
				return objectsArray.Select(Class506<Key, Value>.func_1).ToArray<Value>();
			}
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x00015267 File Offset: 0x00013467
		[DebuggerStepThrough]
		public Class506<Key, Value> method_6()
		{
			return new Class506<Key, Value>(this);
		}

		// Token: 0x06002CB5 RID: 11445 RVA: 0x0001526F File Offset: 0x0001346F
		[DebuggerStepThrough]
		public void Clear()
		{
			this.method_5();
			this.objectsTable.Clear();
			this.objectsArray.Clear();
		}

		// Token: 0x06002CB6 RID: 11446 RVA: 0x0001528D File Offset: 0x0001348D
		[DebuggerStepThrough]
		public bool TryGetValue(Key key, out Value value)
		{
			return this.objectsTable.TryGetValue(key, out value);
		}

		// Token: 0x06002CB7 RID: 11447 RVA: 0x000AC86C File Offset: 0x000AAA6C
		[DebuggerStepThrough]
		public void method_7(int index, Key key, Value value)
		{
			this.method_5();
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			if (index > this.Count || index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			this.objectsArray.Insert(index, new KeyValuePair<Key, Value>(key, value));
			this.objectsTable.Add(key, value);
		}

		// Token: 0x06002CB8 RID: 11448 RVA: 0x000AC8CC File Offset: 0x000AAACC
		[DebuggerStepThrough]
		void ICollection<KeyValuePair<!0, !1>>.CopyTo(KeyValuePair<Key, Value>[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0 || arrayIndex > array.Length)
			{
				throw new IndexOutOfRangeException("The specified index is out of range.");
			}
			if (array.Length - arrayIndex < this.Count)
			{
				throw new ArgumentException("The specified array is too small for the contents of the collection.");
			}
			int count = this.Count;
			List<KeyValuePair<Key, Value>> list = this.list_0;
			for (int i = 0; i < count; i++)
			{
				array[arrayIndex++] = list[i];
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06002CB9 RID: 11449 RVA: 0x0001529C File Offset: 0x0001349C
		public int Count
		{
			[DebuggerStepThrough]
			get
			{
				return this.objectsArray.Count;
			}
		}

		// Token: 0x06002CBA RID: 11450 RVA: 0x000152A9 File Offset: 0x000134A9
		[CompilerGenerated]
		private static Key smethod_0(KeyValuePair<Key, Value> item)
		{
			return item.Key;
		}

		// Token: 0x06002CBB RID: 11451 RVA: 0x000152B2 File Offset: 0x000134B2
		[CompilerGenerated]
		private static Value smethod_1(KeyValuePair<Key, Value> item)
		{
			return item.Value;
		}

		// Token: 0x04001767 RID: 5991
		private IEqualityComparer<Key> iequalityComparer_0;

		// Token: 0x04001768 RID: 5992
		private int int_0;

		// Token: 0x04001769 RID: 5993
		private List<KeyValuePair<Key, Value>> list_0;

		// Token: 0x0400176A RID: 5994
		private Dictionary<Key, Value> dictionary_0;

		// Token: 0x0400176B RID: 5995
		private bool bool_0;

		// Token: 0x0400176C RID: 5996
		[CompilerGenerated]
		private static Func<KeyValuePair<Key, Value>, Key> func_0;

		// Token: 0x0400176D RID: 5997
		[CompilerGenerated]
		private static Func<KeyValuePair<Key, Value>, Value> func_1;
	}
}
