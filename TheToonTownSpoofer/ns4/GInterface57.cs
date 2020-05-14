using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x020000A6 RID: 166
	[Guid("EF870383-83AB-4EA9-BE48-56FA4251AF10")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface57
	{
		// Token: 0x1700024E RID: 590
		// (get) Token: 0x06000782 RID: 1922
		// (set) Token: 0x06000783 RID: 1923
		[DispId(8400)]
		string URL { [DispId(8400)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(8400)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000784 RID: 1924
		[DispId(8401)]
		int status { [DispId(8401)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000785 RID: 1925
		[DispId(8402)]
		int pendingDownloads { [DispId(8402)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000786 RID: 1926
		[DispId(8403)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string samiText);

		// Token: 0x06000787 RID: 1927
		[DispId(8404)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string lyrics);

		// Token: 0x06000788 RID: 1928
		[DispId(8405)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string pageName);

		// Token: 0x06000789 RID: 1929
		[DispId(8406)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x0600078A RID: 1930
		[DispId(8407)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x0600078B RID: 1931
		[DispId(8408)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();

		// Token: 0x0600078C RID: 1932
		[DispId(8409)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6();

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600078D RID: 1933
		[DispId(8410)]
		string baseURL { [DispId(8410)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600078E RID: 1934
		[DispId(8414)]
		string fullURL { [DispId(8414)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600078F RID: 1935
		[DispId(8411)]
		int secureLock { [DispId(8411)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000790 RID: 1936
		[DispId(8412)]
		bool busy { [DispId(8412)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000791 RID: 1937
		[DispId(8413)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7();
	}
}
