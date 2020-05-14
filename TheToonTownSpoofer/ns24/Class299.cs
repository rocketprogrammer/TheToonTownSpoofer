using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using ns18;
using ns19;
using ns27;
using ns30;

namespace ns24
{
	// Token: 0x02000312 RID: 786
	internal sealed class Class299<T>
	{
		// Token: 0x14000190 RID: 400
		// (add) Token: 0x06001EAD RID: 7853 RVA: 0x00064E04 File Offset: 0x00063004
		// (remove) Token: 0x06001EAE RID: 7854 RVA: 0x00064E3C File Offset: 0x0006303C
		public event EventHandler<EventArgs5<T>> ItemAdded
		{
			add
			{
				EventHandler<EventArgs5<T>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs5<T>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs5<T>> value2 = (EventHandler<EventArgs5<T>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5<T>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs5<T>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs5<T>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs5<T>> value2 = (EventHandler<EventArgs5<T>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs5<T>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000191 RID: 401
		// (add) Token: 0x06001EAF RID: 7855 RVA: 0x00064E74 File Offset: 0x00063074
		// (remove) Token: 0x06001EB0 RID: 7856 RVA: 0x00064EAC File Offset: 0x000630AC
		public event EventHandler<EventArgs6<T>> ItemRemoved
		{
			add
			{
				EventHandler<EventArgs6<T>> eventHandler = this.eventHandler_1;
				EventHandler<EventArgs6<T>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs6<T>> value2 = (EventHandler<EventArgs6<T>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs6<T>>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs6<T>> eventHandler = this.eventHandler_1;
				EventHandler<EventArgs6<T>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs6<T>> value2 = (EventHandler<EventArgs6<T>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs6<T>>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000192 RID: 402
		// (add) Token: 0x06001EB1 RID: 7857 RVA: 0x00064EE4 File Offset: 0x000630E4
		// (remove) Token: 0x06001EB2 RID: 7858 RVA: 0x00064F1C File Offset: 0x0006311C
		public event EventHandler<EventArgs35> GroupCreated
		{
			add
			{
				EventHandler<EventArgs35> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs35> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs35> value2 = (EventHandler<EventArgs35>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs35>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs35> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs35> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs35> value2 = (EventHandler<EventArgs35>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs35>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000193 RID: 403
		// (add) Token: 0x06001EB3 RID: 7859 RVA: 0x00064F54 File Offset: 0x00063154
		// (remove) Token: 0x06001EB4 RID: 7860 RVA: 0x00064F8C File Offset: 0x0006318C
		public event EventHandler<EventArgs35> GroupDestroyed
		{
			add
			{
				EventHandler<EventArgs35> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs35> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs35> value2 = (EventHandler<EventArgs35>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs35>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs35> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs35> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs35> value2 = (EventHandler<EventArgs35>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs35>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000194 RID: 404
		// (add) Token: 0x06001EB5 RID: 7861 RVA: 0x00064FC4 File Offset: 0x000631C4
		// (remove) Token: 0x06001EB6 RID: 7862 RVA: 0x00064FFC File Offset: 0x000631FC
		public event EventHandler<EventArgs4<T>> ItemMoved
		{
			add
			{
				EventHandler<EventArgs4<T>> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs4<T>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs4<T>> value2 = (EventHandler<EventArgs4<T>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs4<T>>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs4<T>> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs4<T>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs4<T>> value2 = (EventHandler<EventArgs4<T>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs4<T>>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06001EB7 RID: 7863 RVA: 0x0000BE68 File Offset: 0x0000A068
		public Class299(int maxItemsPerGroup)
		{
			this.list_1 = new List<Class299<T>.Class300>();
			this.list_0 = new List<T>();
			this.dictionary_0 = new Dictionary<T, Class299<T>.Class300>();
			this.int_0 = maxItemsPerGroup;
		}

		// Token: 0x06001EB8 RID: 7864 RVA: 0x00065034 File Offset: 0x00063234
		public void method_0(T item)
		{
			Class299<T>.Class300 @class = null;
			bool flag = false;
			if (this.list_1.Count > 0)
			{
				@class = this.list_1.Last<Class299<T>.Class300>();
				if (@class.list_0.Count == this.int_0)
				{
					@class = null;
				}
			}
			if (@class == null)
			{
				@class = new Class299<T>.Class300();
				this.list_1.Add(@class);
				flag = true;
			}
			int group = this.list_1.Count - 1;
			@class.list_0.Add(item);
			this.dictionary_0.Add(item, @class);
			this.list_0.Add(item);
			if (flag && this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, new EventArgs35(group));
			}
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs5<T>(item, group));
			}
		}

		// Token: 0x06001EB9 RID: 7865 RVA: 0x000650F8 File Offset: 0x000632F8
		public void method_1(T item)
		{
			Class299<T>.Class300 @class = this.dictionary_0[item];
			int removedIndex = this.list_0.IndexOf(item);
			this.dictionary_0.Remove(item);
			this.list_0.Remove(item);
			@class.list_0.Remove(item);
			int num = this.list_1.IndexOf(@class);
			int num2 = num;
			for (int i = num + 1; i < this.list_1.Count; i++)
			{
				Class299<T>.Class300 class2 = this.list_1[i];
				Class299<T>.Class300 class3 = this.list_1[num2];
				T t = class2.list_0[0];
				class2.list_0.RemoveAt(0);
				class3.list_0.Add(t);
				this.dictionary_0[t] = class3;
				if (this.eventHandler_4 != null)
				{
					this.eventHandler_4(this, new EventArgs4<T>(t, i, num2));
				}
				num2++;
			}
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, new EventArgs6<T>(item, removedIndex, num));
			}
			@class = this.list_1.Last<Class299<T>.Class300>();
			if (@class.list_0.Count == 0)
			{
				this.list_1.Remove(@class);
				if (this.eventHandler_3 != null)
				{
					this.eventHandler_3(this, new EventArgs35(num));
				}
			}
		}

		// Token: 0x17000820 RID: 2080
		public IEnumerable<T> this[int group]
		{
			get
			{
				return this.list_1[group].list_0.AsEnumerable<T>();
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06001EBB RID: 7867 RVA: 0x0000BEB0 File Offset: 0x0000A0B0
		public int Groups
		{
			get
			{
				return this.list_1.Count;
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001EBC RID: 7868 RVA: 0x0000BEBD File Offset: 0x0000A0BD
		public int Elements
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x06001EBD RID: 7869 RVA: 0x0000BECA File Offset: 0x0000A0CA
		public int method_2(T item)
		{
			return this.list_1.IndexOf(this.dictionary_0[item]);
		}

		// Token: 0x06001EBE RID: 7870 RVA: 0x0000BEE3 File Offset: 0x0000A0E3
		public int method_3(T item)
		{
			return this.list_0.IndexOf(item);
		}

		// Token: 0x06001EBF RID: 7871 RVA: 0x0000BEF1 File Offset: 0x0000A0F1
		public T method_4(int index)
		{
			return this.list_0[index];
		}

		// Token: 0x04000BC2 RID: 3010
		private EventHandler<EventArgs5<T>> eventHandler_0;

		// Token: 0x04000BC3 RID: 3011
		private EventHandler<EventArgs6<T>> eventHandler_1;

		// Token: 0x04000BC4 RID: 3012
		private EventHandler<EventArgs35> eventHandler_2;

		// Token: 0x04000BC5 RID: 3013
		private EventHandler<EventArgs35> eventHandler_3;

		// Token: 0x04000BC6 RID: 3014
		private EventHandler<EventArgs4<T>> eventHandler_4;

		// Token: 0x04000BC7 RID: 3015
		private readonly Dictionary<T, Class299<T>.Class300> dictionary_0;

		// Token: 0x04000BC8 RID: 3016
		private readonly List<T> list_0;

		// Token: 0x04000BC9 RID: 3017
		private readonly List<Class299<T>.Class300> list_1;

		// Token: 0x04000BCA RID: 3018
		private readonly int int_0;

		// Token: 0x02000313 RID: 787
		private sealed class Class300
		{
			// Token: 0x06001EC0 RID: 7872 RVA: 0x0000BEFF File Offset: 0x0000A0FF
			public Class300()
			{
				this.list_0 = new List<T>();
			}

			// Token: 0x04000BCB RID: 3019
			public readonly List<T> list_0;
		}
	}
}
