using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x0200002A RID: 42
	[InterfaceType(1)]
	[TypeLibType(256)]
	[Guid("BD94DBEB-417F-4928-AA06-087D56ED9B59")]
	[ComImport]
	public interface GInterface5
	{
		// Token: 0x060000FE RID: 254
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrItem);

		// Token: 0x060000FF RID: 255
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrItem);

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000100 RID: 256
		// (set) Token: 0x06000101 RID: 257
		[DispId(1610678274)]
		string label { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000102 RID: 258
		// (set) Token: 0x06000103 RID: 259
		[DispId(1610678276)]
		Enum4 burnFormat { [MethodImpl(MethodImplOptions.InternalCall)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000104 RID: 260
		// (set) Token: 0x06000105 RID: 261
		[DispId(1610678278)]
		GInterface6 burnPlaylist { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x06000106 RID: 262
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000107 RID: 263
		[DispId(1610678281)]
		Enum5 burnState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000108 RID: 264
		[DispId(1610678282)]
		int burnProgress { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000109 RID: 265
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x0600010A RID: 266
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x0600010B RID: 267
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();
	}
}
