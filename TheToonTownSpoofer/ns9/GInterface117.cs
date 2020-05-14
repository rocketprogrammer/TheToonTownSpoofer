using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x02000134 RID: 308
	[TypeLibType(4160)]
	[Guid("40C6BDE7-9C90-49D4-AD20-BEF81A6C5F22")]
	[ComImport]
	public interface GInterface117
	{
		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06001067 RID: 4199
		// (set) Token: 0x06001068 RID: 4200
		[DispId(1)]
		string title { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }
	}
}
