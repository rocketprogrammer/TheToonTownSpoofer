using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns4
{
	// Token: 0x02000092 RID: 146
	[Guid("5C29BBE0-F87D-4C45-AA28-A70F0230FFA9")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface37
	{
		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000645 RID: 1605
		[DispId(1051)]
		string mimeType { [DispId(1051)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000646 RID: 1606
		[DispId(1052)]
		string pictureType { [DispId(1052)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000647 RID: 1607
		[DispId(1053)]
		string Description { [DispId(1053)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000648 RID: 1608
		[DispId(1054)]
		string URL { [DispId(1054)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
