using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;

namespace ns3
{
	// Token: 0x02000079 RID: 121
	[Guid("6C497D62-8919-413C-82DB-E935FB3EC584")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface14 : GInterface15
	{
		// Token: 0x060004CF RID: 1231
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_56();

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060004D0 RID: 1232
		// (set) Token: 0x060004D1 RID: 1233
		[DispId(1)]
		string URL { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060004D2 RID: 1234
		[DispId(2)]
		Enum9 openState { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060004D3 RID: 1235
		[DispId(10)]
		Enum10 playState { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060004D4 RID: 1236
		[DispId(4)]
		GInterface18 controls { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060004D5 RID: 1237
		[DispId(5)]
		GInterface19 settings { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060004D6 RID: 1238
		// (set) Token: 0x060004D7 RID: 1239
		[DispId(6)]
		GInterface7 currentMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060004D8 RID: 1240
		[DispId(8)]
		GInterface9 mediaCollection { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060004D9 RID: 1241
		[DispId(9)]
		GInterface20 playlistCollection { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060004DA RID: 1242
		[DispId(11)]
		string versionInfo { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060004DB RID: 1243
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_57([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060004DC RID: 1244
		[DispId(7)]
		GInterface22 network { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060004DD RID: 1245
		// (set) Token: 0x060004DE RID: 1246
		[DispId(13)]
		GInterface6 currentPlaylist { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.Interface)] [param: In] set; }

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060004DF RID: 1247
		[DispId(14)]
		GInterface23 cdromCollection { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060004E0 RID: 1248
		[DispId(15)]
		GInterface25 closedCaption { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060004E1 RID: 1249
		[DispId(16)]
		bool isOnline { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060004E2 RID: 1250
		[DispId(17)]
		GInterface26 Error { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060004E3 RID: 1251
		[DispId(18)]
		string status { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060004E4 RID: 1252
		[DispId(40)]
		GInterface28 dvd { [DispId(40)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060004E5 RID: 1253
		[DispId(41)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface6 imethod_60([MarshalAs(UnmanagedType.BStr)] [In] string bstrName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x060004E6 RID: 1254
		[DispId(42)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		GInterface7 imethod_61([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004E7 RID: 1255
		// (set) Token: 0x060004E8 RID: 1256
		[DispId(19)]
		bool enabled { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004E9 RID: 1257
		// (set) Token: 0x060004EA RID: 1258
		[DispId(21)]
		bool fullScreen { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004EB RID: 1259
		// (set) Token: 0x060004EC RID: 1260
		[DispId(22)]
		bool enableContextMenu { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] set; }

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004EE RID: 1262
		// (set) Token: 0x060004ED RID: 1261
		[DispId(23)]
		string uiMode { [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004EF RID: 1263
		// (set) Token: 0x060004F0 RID: 1264
		[DispId(24)]
		bool stretchToFit { [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004F1 RID: 1265
		// (set) Token: 0x060004F2 RID: 1266
		[DispId(25)]
		bool windowlessVideo { [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004F3 RID: 1267
		[DispId(26)]
		bool isRemote { [DispId(26)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004F4 RID: 1268
		[DispId(27)]
		GInterface29 playerApplication { [DispId(27)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x060004F5 RID: 1269
		[DispId(28)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_62([MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);
	}
}
