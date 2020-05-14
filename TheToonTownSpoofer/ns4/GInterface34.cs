using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns3;

namespace ns4
{
	// Token: 0x0200008F RID: 143
	[Guid("6F030D25-0890-480F-9775-1F7E40AB5B8E")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface34 : GInterface18
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x0600060C RID: 1548
		[DispId(62)]
		bool isAvailable { [DispId(62)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600060D RID: 1549
		[DispId(51)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x0600060E RID: 1550
		[DispId(52)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();

		// Token: 0x0600060F RID: 1551
		[DispId(53)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x06000610 RID: 1552
		[DispId(54)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x06000611 RID: 1553
		[DispId(55)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000612 RID: 1554
		// (set) Token: 0x06000613 RID: 1555
		[DispId(56)]
		double currentPosition { [DispId(56)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(56)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000614 RID: 1556
		[DispId(57)]
		string currentPositionString { [DispId(57)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000615 RID: 1557
		[DispId(58)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();

		// Token: 0x06000616 RID: 1558
		[DispId(59)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6();

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000617 RID: 1559
		// (set) Token: 0x06000618 RID: 1560
		[DispId(60)]
		GInterface7 currentItem { [DispId(60)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(60)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000619 RID: 1561
		// (set) Token: 0x0600061A RID: 1562
		[DispId(61)]
		int currentMarker { [DispId(61)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(61)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x0600061B RID: 1563
		[DispId(63)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);

		// Token: 0x0600061C RID: 1564
		[DispId(64)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_33([In] int lStep);
	}
}
