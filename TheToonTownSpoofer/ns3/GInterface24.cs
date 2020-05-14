using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x02000085 RID: 133
	[TypeLibType(4160)]
	[Guid("CFAB6E98-8730-11D3-B388-00C04F68574B")]
	[ComImport]
	public interface GInterface24
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000588 RID: 1416
		[DispId(251)]
		string driveSpecifier { [DispId(251)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000589 RID: 1417
		[DispId(252)]
		GInterface6 Playlist { [DispId(252)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x0600058A RID: 1418
		[DispId(253)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_43();
	}
}
