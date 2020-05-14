using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns10;

namespace ns9
{
	// Token: 0x0200013F RID: 319
	[TypeLibType(4160)]
	[Guid("C9470E8E-3F6B-46A9-A0A9-452815C34297")]
	[ComImport]
	public interface GInterface128
	{
		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x060010C0 RID: 4288
		[DispId(1251)]
		string sourceURL { [DispId(1251)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x060010C1 RID: 4289
		[DispId(1252)]
		int size { [DispId(1252)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x060010C2 RID: 4290
		[DispId(1253)]
		string type { [DispId(1253)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700062D RID: 1581
		// (get) Token: 0x060010C3 RID: 4291
		[DispId(1254)]
		int progress { [DispId(1254)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700062E RID: 1582
		// (get) Token: 0x060010C4 RID: 4292
		[DispId(1255)]
		Enum11 downloadState { [DispId(1255)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060010C5 RID: 4293
		[DispId(1256)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0();

		// Token: 0x060010C6 RID: 4294
		[DispId(1257)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1();

		// Token: 0x060010C7 RID: 4295
		[DispId(1258)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2();
	}
}
