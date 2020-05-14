using System;
using System.Collections;
using System.Collections.Generic;
using TSN.Controls;

namespace ns19
{
	// Token: 0x02000400 RID: 1024
	internal sealed class Class414 : IComparer<ListViewItemState<string>>, IEqualityComparer<ListViewItemState<string>>, IComparer, IEqualityComparer
	{
		// Token: 0x06002709 RID: 9993 RVA: 0x00011787 File Offset: 0x0000F987
		private Class414(bool ignoreCase)
		{
			this.bool_0 = ignoreCase;
		}

		// Token: 0x0600270A RID: 9994 RVA: 0x0008C510 File Offset: 0x0008A710
		int IComparer.Compare(object x, object y)
		{
			if (object.ReferenceEquals(x, y))
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			ListViewItemState<string> listViewItemState = x as ListViewItemState<string>;
			ListViewItemState<string> listViewItemState2 = y as ListViewItemState<string>;
			if (listViewItemState == null)
			{
				throw new ArgumentException(Class414.string_2);
			}
			if (listViewItemState2 == null)
			{
				throw new ArgumentException(Class414.string_1);
			}
			if (this.bool_0)
			{
				return StringComparer.OrdinalIgnoreCase.Compare(listViewItemState.State, listViewItemState2.State);
			}
			return StringComparer.Ordinal.Compare(listViewItemState.State, listViewItemState2.State);
		}

		// Token: 0x0600270B RID: 9995 RVA: 0x0008C594 File Offset: 0x0008A794
		int IComparer<ListViewItemState<string>>.Compare(ListViewItemState<string> x, ListViewItemState<string> y)
		{
			if (object.ReferenceEquals(x, y))
			{
				return 0;
			}
			if (x == null)
			{
				return -1;
			}
			if (y == null)
			{
				return 1;
			}
			if (this.bool_0)
			{
				return StringComparer.OrdinalIgnoreCase.Compare(x.State, y.State);
			}
			return StringComparer.Ordinal.Compare(x.State, y.State);
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x0008C5EC File Offset: 0x0008A7EC
		bool IEqualityComparer<ListViewItemState<string>>.Equals(ListViewItemState<string> x, ListViewItemState<string> y)
		{
			if (object.ReferenceEquals(x, y))
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			if (this.bool_0)
			{
				return StringComparer.OrdinalIgnoreCase.Equals(x.State, y.State);
			}
			return StringComparer.Ordinal.Equals(x.State, y.State);
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x0008C644 File Offset: 0x0008A844
		bool IEqualityComparer.Equals(object x, object y)
		{
			if (object.ReferenceEquals(x, y))
			{
				return true;
			}
			if (x == null || y == null)
			{
				return false;
			}
			ListViewItemState<string> listViewItemState = x as ListViewItemState<string>;
			ListViewItemState<string> listViewItemState2 = y as ListViewItemState<string>;
			if (listViewItemState == null || listViewItemState2 == null)
			{
				return false;
			}
			if (this.bool_0)
			{
				return StringComparer.OrdinalIgnoreCase.Equals(listViewItemState.State, listViewItemState2.State);
			}
			return StringComparer.Ordinal.Equals(listViewItemState.State, listViewItemState2.State);
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00011796 File Offset: 0x0000F996
		int IEqualityComparer<ListViewItemState<string>>.GetHashCode(ListViewItemState<string> obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			if (this.bool_0)
			{
				return StringComparer.OrdinalIgnoreCase.GetHashCode(obj.State);
			}
			return StringComparer.Ordinal.GetHashCode(obj.State);
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x0008C6B0 File Offset: 0x0008A8B0
		int IEqualityComparer.GetHashCode(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException("obj");
			}
			ListViewItemState<string> listViewItemState = obj as ListViewItemState<string>;
			if (listViewItemState == null)
			{
				throw new ArgumentException(Class414.string_0);
			}
			if (this.bool_0)
			{
				return StringComparer.OrdinalIgnoreCase.GetHashCode(listViewItemState.State);
			}
			return StringComparer.Ordinal.GetHashCode(listViewItemState.State);
		}

		// Token: 0x04001334 RID: 4916
		private static readonly string string_0 = "obj is not a FileListViewItem";

		// Token: 0x04001335 RID: 4917
		private static readonly string string_1 = "y is not a FileListViewItem";

		// Token: 0x04001336 RID: 4918
		private static readonly string string_2 = "x is not a FileListViewItem";

		// Token: 0x04001337 RID: 4919
		public static readonly Class414 class414_0 = new Class414(true);

		// Token: 0x04001338 RID: 4920
		public static readonly Class414 class414_1 = new Class414(false);

		// Token: 0x04001339 RID: 4921
		private bool bool_0;
	}
}
