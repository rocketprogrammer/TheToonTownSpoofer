using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000089 RID: 137
	[Guid("8DA61686-4668-4A5C-AE5D-803193293DBE")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface28
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x0600059C RID: 1436
		[DispId(1001)]
		bool isAvailable { [DispId(1001)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600059D RID: 1437
		[DispId(1002)]
		string domain { [DispId(1002)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600059E RID: 1438
		[DispId(1003)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_36();

		// Token: 0x0600059F RID: 1439
		[DispId(1004)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_37();

		// Token: 0x060005A0 RID: 1440
		[DispId(1005)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_38();

		// Token: 0x060005A1 RID: 1441
		[DispId(1006)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_39();
	}
}
