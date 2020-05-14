using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x0200007F RID: 127
	[TypeLibType(4160)]
	[Guid("74C09E02-F828-11D2-A74B-00A0C905F36E")]
	[ComImport]
	public interface GInterface18
	{
		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000539 RID: 1337
		[DispId(62)]
		bool isAvailable { [DispId(62)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600053A RID: 1338
		[DispId(51)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_25();

		// Token: 0x0600053B RID: 1339
		[DispId(52)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_26();

		// Token: 0x0600053C RID: 1340
		[DispId(53)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_27();

		// Token: 0x0600053D RID: 1341
		[DispId(54)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_28();

		// Token: 0x0600053E RID: 1342
		[DispId(55)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_29();

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x0600053F RID: 1343
		// (set) Token: 0x06000540 RID: 1344
		[DispId(56)]
		double currentPosition { [DispId(56)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(56)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000541 RID: 1345
		[DispId(57)]
		string currentPositionString { [DispId(57)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000542 RID: 1346
		[DispId(58)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_30();

		// Token: 0x06000543 RID: 1347
		[DispId(59)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_31();

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000544 RID: 1348
		// (set) Token: 0x06000545 RID: 1349
		[DispId(60)]
		GInterface7 currentItem { [DispId(60)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(60)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000546 RID: 1350
		// (set) Token: 0x06000547 RID: 1351
		[DispId(61)]
		int currentMarker { [DispId(61)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(61)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x06000548 RID: 1352
		[DispId(63)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_32([MarshalAs(UnmanagedType.Interface)] [In] GInterface7 pIWMPMedia);
	}
}
