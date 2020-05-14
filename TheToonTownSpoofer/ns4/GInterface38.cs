using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x02000093 RID: 147
	[TypeLibType(4160)]
	[Guid("769A72DB-13D2-45E2-9C48-53CA9D5B7450")]
	[ComImport]
	public interface GInterface38
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000649 RID: 1609
		[DispId(1056)]
		string Description { [DispId(1056)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x0600064A RID: 1610
		[DispId(1055)]
		string text { [DispId(1055)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
