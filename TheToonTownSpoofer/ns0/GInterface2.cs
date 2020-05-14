using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000024 RID: 36
	[Guid("82A2986C-0293-4FD0-B279-B21B86C058BE")]
	[TypeLibType(256)]
	[InterfaceType(1)]
	[ComImport]
	public interface GInterface2
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x060000AC RID: 172
		// (set) Token: 0x060000AD RID: 173
		[DispId(1610678272)]
		string friendlyName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x060000AE RID: 174
		[DispId(1610678274)]
		string deviceName { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x060000AF RID: 175
		[DispId(1610678275)]
		string deviceId { [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060000B0 RID: 176
		[DispId(1610678276)]
		int partnershipIndex { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060000B1 RID: 177
		[DispId(1610678277)]
		bool connected { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000B2 RID: 178
		[DispId(1610678278)]
		Enum1 status { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000B3 RID: 179
		[DispId(1610678279)]
		Enum2 syncState { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000B4 RID: 180
		[DispId(1610678280)]
		int progress { [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060000B5 RID: 181
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x060000B6 RID: 182
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([In] bool vbShowUI);

		// Token: 0x060000B7 RID: 183
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();

		// Token: 0x060000B8 RID: 184
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x060000B9 RID: 185
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x060000BA RID: 186
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();

		// Token: 0x060000BB RID: 187
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_6([MarshalAs(UnmanagedType.Interface)] [In] GInterface2 pDevice);
	}
}
