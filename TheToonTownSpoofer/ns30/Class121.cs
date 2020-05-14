using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using ns17;

namespace ns30
{
	// Token: 0x020001EF RID: 495
	internal sealed class Class121<T> : IEnumerable<T>, ICollection<T>, Interface13<T>, IDisposable, IEnumerable where T : class
	{
		// Token: 0x0600165C RID: 5724 RVA: 0x00006713 File Offset: 0x00004913
		public Class121()
		{
			this.list_0 = new List<Class215<T>>();
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00036224 File Offset: 0x00034424
		public IEnumerable<T> LiveList
		{
			get
			{
				List<T> list = new List<T>(this.list_0.Count);
				list.AddRange(this.UnsafeLiveList);
				return list;
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x0600165E RID: 5726 RVA: 0x00006726 File Offset: 0x00004926
		public IEnumerable<T> CompleteList
		{
			get
			{
				IEnumerable<Class215<T>> source = this.list_0;
				if (Class121<T>.func_0 == null)
				{
					Class121<T>.func_0 = new Func<Class215<T>, T>(Class121<T>.smethod_0);
				}
				return source.Select(Class121<T>.func_0);
			}
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600165F RID: 5727 RVA: 0x00006750 File Offset: 0x00004950
		public IEnumerable<T> LiveListWithoutPurge
		{
			get
			{
				IEnumerable<T> completeList = this.CompleteList;
				if (Class121<T>.func_1 == null)
				{
					Class121<T>.func_1 = new Func<T, bool>(Class121<T>.smethod_1);
				}
				return completeList.Where(Class121<T>.func_1);
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x0000677A File Offset: 0x0000497A
		public int CompleteCount
		{
			get
			{
				return this.list_0.Count;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x00006787 File Offset: 0x00004987
		public int DeadCount
		{
			get
			{
				IEnumerable<T> completeList = this.CompleteList;
				if (Class121<T>.func_2 == null)
				{
					Class121<T>.func_2 = new Func<T, bool>(Class121<T>.smethod_2);
				}
				return completeList.Count(Class121<T>.func_2);
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x000067B1 File Offset: 0x000049B1
		public int LiveCount
		{
			get
			{
				return this.UnsafeLiveList.Count<T>();
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x06001663 RID: 5731 RVA: 0x000067BE File Offset: 0x000049BE
		public int LiveCountWithoutPurge
		{
			get
			{
				IEnumerable<T> completeList = this.CompleteList;
				if (Class121<T>.func_3 == null)
				{
					Class121<T>.func_3 = new Func<T, bool>(Class121<T>.smethod_3);
				}
				return completeList.Count(Class121<T>.func_3);
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x06001664 RID: 5732 RVA: 0x000067E8 File Offset: 0x000049E8
		int ICollection<!0>.Count
		{
			get
			{
				return this.LiveCount;
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001665 RID: 5733 RVA: 0x000067F0 File Offset: 0x000049F0
		bool ICollection<!0>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06001666 RID: 5734 RVA: 0x00036250 File Offset: 0x00034450
		private IEnumerable<T> UnsafeLiveList
		{
			get
			{
				Class121<T>.Class122 @class = new Class121<T>.Class122(-2);
				@class.class121_0 = this;
				return @class;
			}
		}

		// Token: 0x06001667 RID: 5735 RVA: 0x000067F3 File Offset: 0x000049F3
		public void Add(T item)
		{
			this.list_0.Add(new Class215<T>(item));
		}

		// Token: 0x06001668 RID: 5736 RVA: 0x00036270 File Offset: 0x00034470
		public bool Remove(T item)
		{
			for (int num = 0; num != this.list_0.Count; num++)
			{
				Class215<T> @class = this.list_0[num];
				T target = @class.Target;
				if (target == item)
				{
					this.list_0.RemoveAt(num);
					@class.Dispose();
					return true;
				}
			}
			return false;
		}

		// Token: 0x06001669 RID: 5737 RVA: 0x000362CC File Offset: 0x000344CC
		public void imethod_0()
		{
			IEnumerator<T> enumerator = this.UnsafeLiveList.GetEnumerator();
			while (enumerator.MoveNext())
			{
			}
		}

		// Token: 0x0600166A RID: 5738 RVA: 0x00006806 File Offset: 0x00004A06
		public void Dispose()
		{
			this.Clear();
		}

		// Token: 0x0600166B RID: 5739 RVA: 0x000362F0 File Offset: 0x000344F0
		public void Clear()
		{
			foreach (Class215<T> @class in this.list_0)
			{
				@class.Dispose();
			}
			this.list_0.Clear();
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0000680E File Offset: 0x00004A0E
		bool ICollection<!0>.Contains(T item)
		{
			return this.LiveListWithoutPurge.Contains(item);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x00036350 File Offset: 0x00034550
		void ICollection<!0>.CopyTo(T[] array, int arrayIndex)
		{
			List<T> list = new List<T>(this.list_0.Count);
			list.AddRange(this.UnsafeLiveList);
			list.CopyTo(array, arrayIndex);
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0000681C File Offset: 0x00004A1C
		IEnumerator<T> IEnumerable<!0>.GetEnumerator()
		{
			return this.LiveList.GetEnumerator();
		}

		// Token: 0x0600166F RID: 5743 RVA: 0x00006829 File Offset: 0x00004A29
		IEnumerator IEnumerable.GetEnumerator()
		{
			return ((IEnumerable<!0>)this).GetEnumerator();
		}

		// Token: 0x06001670 RID: 5744 RVA: 0x00006831 File Offset: 0x00004A31
		[CompilerGenerated]
		private static T smethod_0(Class215<T> x)
		{
			return x.Target;
		}

		// Token: 0x06001671 RID: 5745 RVA: 0x00006839 File Offset: 0x00004A39
		[CompilerGenerated]
		private static bool smethod_1(T x)
		{
			return x != null;
		}

		// Token: 0x06001672 RID: 5746 RVA: 0x00006847 File Offset: 0x00004A47
		[CompilerGenerated]
		private static bool smethod_2(T x)
		{
			return x == null;
		}

		// Token: 0x06001673 RID: 5747 RVA: 0x00006839 File Offset: 0x00004A39
		[CompilerGenerated]
		private static bool smethod_3(T x)
		{
			return x != null;
		}

		// Token: 0x04000398 RID: 920
		private List<Class215<T>> list_0;

		// Token: 0x04000399 RID: 921
		[CompilerGenerated]
		private static Func<Class215<T>, T> func_0;

		// Token: 0x0400039A RID: 922
		[CompilerGenerated]
		private static Func<T, bool> func_1;

		// Token: 0x0400039B RID: 923
		[CompilerGenerated]
		private static Func<T, bool> func_2;

		// Token: 0x0400039C RID: 924
		[CompilerGenerated]
		private static Func<T, bool> func_3;
	}
}
