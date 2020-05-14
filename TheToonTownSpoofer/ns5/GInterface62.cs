using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000AB RID: 171
	[TypeLibType(4160)]
	[Guid("6FCAE13D-E492-4584-9C21-D2C052A2A33A")]
	[ComImport]
	public interface GInterface62
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000879 RID: 2169
		[DispId(2500)]
		string title { [DispId(2500)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x0600087A RID: 2170
		[DispId(2501)]
		float version { [DispId(2501)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x0600087B RID: 2171
		[DispId(2502)]
		string authorVersion { [DispId(2502)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x0600087C RID: 2172
		[DispId(2503)]
		string author { [DispId(2503)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600087D RID: 2173
		[DispId(2504)]
		string copyright { [DispId(2504)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600087E RID: 2174
		// (set) Token: 0x0600087F RID: 2175
		[DispId(2505)]
		string currentViewID { [DispId(2505)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(2505)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000880 RID: 2176
		[DispId(2506)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x06000881 RID: 2177
		[DispId(2507)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string stringVal);

		// Token: 0x06000882 RID: 2178
		[DispId(2508)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string viewID);

		// Token: 0x06000883 RID: 2179
		[DispId(2515)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object imethod_3([MarshalAs(UnmanagedType.BStr)] [In] string viewID, [In] int x, [In] int y);

		// Token: 0x06000884 RID: 2180
		[DispId(2509)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string viewID);

		// Token: 0x06000885 RID: 2181
		[DispId(2510)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string dialogType, [MarshalAs(UnmanagedType.BStr)] [In] string parameters);

		// Token: 0x06000886 RID: 2182
		[DispId(2511)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrString);

		// Token: 0x06000887 RID: 2183
		[DispId(2512)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_7([MarshalAs(UnmanagedType.BStr)] [In] string bstrName);

		// Token: 0x06000888 RID: 2184
		[DispId(2513)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrValue);

		// Token: 0x06000889 RID: 2185
		[DispId(2514)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9([MarshalAs(UnmanagedType.BStr)] string bstrFilename);

		// Token: 0x0600088A RID: 2186
		[DispId(2516)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object imethod_10([MarshalAs(UnmanagedType.BStr)] [In] string viewID, [In] int nIndex, [In] int x, [In] int y, [In] int nWidth, [In] int nHeight, [MarshalAs(UnmanagedType.BStr)] [In] string bstrHorizontalAlignment, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVerticalAlignment);

		// Token: 0x0600088B RID: 2187
		[DispId(2518)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11([MarshalAs(UnmanagedType.BStr)] [In] string viewID, [In] int nIndex, [In] int x, [In] int y, [In] int nWidth, [In] int nHeight, [MarshalAs(UnmanagedType.BStr)] [In] string bstrHorizontalAlignment, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVerticalAlignment);
	}
}
