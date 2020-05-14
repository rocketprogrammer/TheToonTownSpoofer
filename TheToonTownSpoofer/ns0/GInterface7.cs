using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x0200002D RID: 45
	[TypeLibType(4160)]
	[Guid("94D55E95-3FAC-11D3-B155-00C04F79FAA6")]
	[ComImport]
	public interface GInterface7
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600011A RID: 282
		[DispId(763)]
		bool isIdentical { [DispId(763)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600011B RID: 283
		[DispId(751)]
		string sourceURL { [DispId(751)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600011C RID: 284
		// (set) Token: 0x0600011D RID: 285
		[DispId(764)]
		string name { [DispId(764)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(764)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600011E RID: 286
		[DispId(752)]
		int imageSourceWidth { [DispId(752)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600011F RID: 287
		[DispId(753)]
		int imageSourceHeight { [DispId(753)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000120 RID: 288
		[DispId(754)]
		int markerCount { [DispId(754)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000121 RID: 289
		[DispId(755)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		double imethod_7([In] int MarkerNum);

		// Token: 0x06000122 RID: 290
		[DispId(756)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_8([In] int MarkerNum);

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000123 RID: 291
		[DispId(757)]
		double duration { [DispId(757)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000124 RID: 292
		[DispId(758)]
		string durationString { [DispId(758)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000125 RID: 293
		[DispId(759)]
		int attributeCount { [DispId(759)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000126 RID: 294
		[DispId(760)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_9([In] int lIndex);

		// Token: 0x06000127 RID: 295
		[DispId(761)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000128 RID: 296
		[DispId(762)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrVal);

		// Token: 0x06000129 RID: 297
		[DispId(765)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_10([In] int lAtom);

		// Token: 0x0600012A RID: 298
		[DispId(766)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_11([MarshalAs(UnmanagedType.Interface)] [In] GInterface6 pPlaylist);

		// Token: 0x0600012B RID: 299
		[DispId(767)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_12([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);
	}
}
