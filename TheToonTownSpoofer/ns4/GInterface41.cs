using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns3;

namespace ns4
{
	// Token: 0x02000096 RID: 150
	[TypeLibType(4160)]
	[Guid("350BA78B-6BC8-4113-A5F5-312056934EB6")]
	[ComImport]
	public interface GInterface41 : GInterface25
	{
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000680 RID: 1664
		// (set) Token: 0x06000681 RID: 1665
		[DispId(951)]
		string SAMIStyle { [DispId(951)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(951)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000682 RID: 1666
		// (set) Token: 0x06000683 RID: 1667
		[DispId(952)]
		string SAMILang { [DispId(952)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(952)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06000684 RID: 1668
		// (set) Token: 0x06000685 RID: 1669
		[DispId(953)]
		string SAMIFileName { [DispId(953)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(953)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06000686 RID: 1670
		// (set) Token: 0x06000687 RID: 1671
		[DispId(954)]
		string captioningId { [DispId(954)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(954)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000688 RID: 1672
		[DispId(955)]
		int SAMILangCount { [DispId(955)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000689 RID: 1673
		[DispId(956)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_40([In] int nIndex);

		// Token: 0x0600068A RID: 1674
		[DispId(957)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_41([In] int nIndex);

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x0600068B RID: 1675
		[DispId(958)]
		int SAMIStyleCount { [DispId(958)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600068C RID: 1676
		[DispId(959)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_42([In] int nIndex);
	}
}
