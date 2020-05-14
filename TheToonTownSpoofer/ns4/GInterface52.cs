using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns1;

namespace ns4
{
	// Token: 0x020000A1 RID: 161
	[InterfaceType(1)]
	[TypeLibType(256)]
	[Guid("788C8743-E57F-439D-A468-5BC77F2E59C6")]
	[ComImport]
	public interface GInterface52
	{
		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x060006BC RID: 1724
		[DispId(1610678272)]
		int count { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060006BD RID: 1725
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([In] int lIndex);

		// Token: 0x060006BE RID: 1726
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrFolder);

		// Token: 0x060006BF RID: 1727
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([In] int lIndex);

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x060006C0 RID: 1728
		[DispId(1610678276)]
		Enum7 scanState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x060006C1 RID: 1729
		[DispId(1610678277)]
		string currentFolder { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x060006C2 RID: 1730
		[DispId(1610678278)]
		int scannedFilesCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x060006C3 RID: 1731
		[DispId(1610678279)]
		int addedFilesCount { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060006C4 RID: 1732
		[DispId(1610678280)]
		int updateProgress { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060006C5 RID: 1733
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x060006C6 RID: 1734
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();
	}
}
