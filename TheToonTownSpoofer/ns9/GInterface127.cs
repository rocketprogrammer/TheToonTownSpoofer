using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns10;

namespace ns9
{
	// Token: 0x0200013E RID: 318
	[TypeLibType(4160)]
	[Guid("9FBB3336-6DA3-479D-B8FF-67D46E20A987")]
	[ComImport]
	public interface GInterface127 : GInterface128
	{
		// Token: 0x17000625 RID: 1573
		// (get) Token: 0x060010B7 RID: 4279
		[DispId(1251)]
		string sourceURL { [DispId(1251)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000626 RID: 1574
		// (get) Token: 0x060010B8 RID: 4280
		[DispId(1252)]
		int size { [DispId(1252)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000627 RID: 1575
		// (get) Token: 0x060010B9 RID: 4281
		[DispId(1253)]
		string type { [DispId(1253)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x060010BA RID: 4282
		[DispId(1254)]
		int progress { [DispId(1254)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x060010BB RID: 4283
		[DispId(1255)]
		Enum11 downloadState { [DispId(1255)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060010BC RID: 4284
		[DispId(1256)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x060010BD RID: 4285
		[DispId(1257)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4();

		// Token: 0x060010BE RID: 4286
		[DispId(1258)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5();

		// Token: 0x060010BF RID: 4287
		[DispId(1301)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);
	}
}
