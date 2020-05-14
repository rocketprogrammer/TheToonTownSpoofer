using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ns19;
using TSN.Controls;

namespace ns18
{
	// Token: 0x020002AA RID: 682
	internal sealed class Class236 : IComparer<ListViewItemState<string>>, IComparer
	{
		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001BE8 RID: 7144 RVA: 0x0000A568 File Offset: 0x00008768
		internal static Class236 Default
		{
			get
			{
				return Class236.lazy_0.Value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001BE9 RID: 7145 RVA: 0x0000A574 File Offset: 0x00008774
		internal static Class236 DefaultZeroesFirst
		{
			get
			{
				return Class236.lazy_1.Value;
			}
		}

		// Token: 0x06001BEA RID: 7146 RVA: 0x000033EB File Offset: 0x000015EB
		private Class236()
		{
		}

		// Token: 0x06001BEB RID: 7147 RVA: 0x0000A580 File Offset: 0x00008780
		private Class236(bool zeroesFirst)
		{
			this.bool_0 = zeroesFirst;
		}

		// Token: 0x06001BEC RID: 7148 RVA: 0x0005762C File Offset: 0x0005582C
		int IComparer.Compare(object x, object y)
		{
			if (x == null && y == null)
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
			if (listViewItemState == null || listViewItemState2 == null)
			{
				return Comparer.Default.Compare(x, y);
			}
			if (this.bool_0)
			{
				return Class408.DefaultZeroesFirst.Compare(listViewItemState.State, listViewItemState2.State);
			}
			return Class408.Default.Compare(listViewItemState.State, listViewItemState2.State);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x000576A4 File Offset: 0x000558A4
		public int Compare(ListViewItemState<string> x, ListViewItemState<string> y)
		{
			if (x == null && y == null)
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
				return Class408.DefaultZeroesFirst.Compare(x.State, y.State);
			}
			return Class408.Default.Compare(x.State, y.State);
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x000576F8 File Offset: 0x000558F8
		// Note: this type is marked as 'beforefieldinit'.
		static Class236()
		{
			if (Class236.func_0 == null)
			{
				Class236.func_0 = new Func<Class236>(Class236.smethod_0);
			}
			Class236.lazy_0 = new Lazy<Class236>(Class236.func_0);
			if (Class236.func_1 == null)
			{
				Class236.func_1 = new Func<Class236>(Class236.smethod_1);
			}
			Class236.lazy_1 = new Lazy<Class236>(Class236.func_1);
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x0000A58F File Offset: 0x0000878F
		[CompilerGenerated]
		private static Class236 smethod_0()
		{
			return new Class236();
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x0000A596 File Offset: 0x00008796
		[CompilerGenerated]
		private static Class236 smethod_1()
		{
			return new Class236(true);
		}

		// Token: 0x04000989 RID: 2441
		private static readonly Lazy<Class236> lazy_0;

		// Token: 0x0400098A RID: 2442
		private static readonly Lazy<Class236> lazy_1;

		// Token: 0x0400098B RID: 2443
		private bool bool_0;

		// Token: 0x0400098C RID: 2444
		[CompilerGenerated]
		private static Func<Class236> func_0;

		// Token: 0x0400098D RID: 2445
		[CompilerGenerated]
		private static Func<Class236> func_1;
	}
}
