using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns10
{
	// Token: 0x02000148 RID: 328
	[Guid("FB61CD38-8DE7-4479-8B76-A8D097C20C70")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface135
	{
		// Token: 0x17000681 RID: 1665
		// (get) Token: 0x06001140 RID: 4416
		[DispId(1)]
		string SourceProtocolInfo { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x06001141 RID: 4417
		[DispId(2)]
		string SinkProtocolInfo { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001142 RID: 4418
		[DispId(3)]
		string CurrentConnectionIDs { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000684 RID: 1668
		// (get) Token: 0x06001143 RID: 4419
		[DispId(4)]
		string A_ARG_TYPE_ConnectionStatus { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000685 RID: 1669
		// (get) Token: 0x06001144 RID: 4420
		[DispId(5)]
		string A_ARG_TYPE_ConnectionManager { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000686 RID: 1670
		// (get) Token: 0x06001145 RID: 4421
		[DispId(6)]
		string A_ARG_TYPE_Direction { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001146 RID: 4422
		[DispId(7)]
		string A_ARG_TYPE_ProtocolInfo { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001147 RID: 4423
		[DispId(8)]
		int A_ARG_TYPE_ConnectionID { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001148 RID: 4424
		[DispId(9)]
		int A_ARG_TYPE_AVTransportID { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001149 RID: 4425
		[DispId(10)]
		int A_ARG_TYPE_RcsID { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600114A RID: 4426
		[DispId(11)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrSource, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrSink);

		// Token: 0x0600114B RID: 4427
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrConnectionIDs);

		// Token: 0x0600114C RID: 4428
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([In] int lConnectionID, [In] [Out] ref int plResID, [In] [Out] ref int plAVTransportID, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrProtocolInfo, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrPeerConnectionManager, [In] [Out] ref int plPeerConnectionID, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrDirection, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrStatus);
	}
}
