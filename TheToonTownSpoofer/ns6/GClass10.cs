using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000DB RID: 219
	[Guid("6342FCED-25EA-4033-BDDB-D049A14382D3")]
	[ClassInterface(0)]
	[DefaultMember("value")]
	[ComImport]
	public sealed class GClass10 : GInterface92, GInterface93
	{
		// Token: 0x06000BE8 RID: 3048
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern GClass10();

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000BE9 RID: 3049
		// (set) Token: 0x06000BEA RID: 3050
		[DispId(0)]
		[IndexerName("value")]
		public extern string value { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000BEB RID: 3051
		// (set) Token: 0x06000BEC RID: 3052
		[DispId(6000)]
		public extern bool border { [DispId(6000)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6000)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000BED RID: 3053
		// (set) Token: 0x06000BEE RID: 3054
		[DispId(6001)]
		public extern string justification { [DispId(6001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000BEF RID: 3055
		// (set) Token: 0x06000BF0 RID: 3056
		[DispId(6002)]
		public extern string editStyle { [DispId(6002)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6002)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06000BF1 RID: 3057
		// (set) Token: 0x06000BF2 RID: 3058
		[DispId(6003)]
		public extern bool wordWrap { [DispId(6003)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06000BF3 RID: 3059
		// (set) Token: 0x06000BF4 RID: 3060
		[DispId(6004)]
		public extern bool readOnly { [DispId(6004)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6004)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06000BF5 RID: 3061
		// (set) Token: 0x06000BF6 RID: 3062
		[DispId(6005)]
		public extern string foregroundColor { [DispId(6005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06000BF7 RID: 3063
		// (set) Token: 0x06000BF8 RID: 3064
		[DispId(6006)]
		public extern string backgroundColor { [DispId(6006)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6006)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06000BF9 RID: 3065
		// (set) Token: 0x06000BFA RID: 3066
		[DispId(6007)]
		public extern int fontSize { [DispId(6007)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06000BFB RID: 3067
		// (set) Token: 0x06000BFC RID: 3068
		[DispId(6008)]
		public extern string fontStyle { [DispId(6008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6008)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06000BFD RID: 3069
		// (set) Token: 0x06000BFE RID: 3070
		[DispId(6009)]
		public extern string fontFace { [DispId(6009)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6009)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06000BFF RID: 3071
		// (set) Token: 0x06000C00 RID: 3072
		[DispId(6010)]
		public extern int textLimit { [DispId(6010)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6010)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000C01 RID: 3073
		[DispId(6011)]
		public extern int lineCount { [DispId(6011)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000C02 RID: 3074
		[DispId(6012)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		public extern string imethod_0([In] int nIndex);

		// Token: 0x06000C03 RID: 3075
		[DispId(6013)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_1();

		// Token: 0x06000C04 RID: 3076
		[DispId(6014)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_2();

		// Token: 0x06000C05 RID: 3077
		[DispId(6015)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_3([In] int nStart, [In] int nEnd);

		// Token: 0x06000C06 RID: 3078
		[DispId(6016)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern void imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000C07 RID: 3079
		[DispId(6017)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_5([In] int nIndex);

		// Token: 0x06000C08 RID: 3080
		[DispId(6018)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern int imethod_6([In] int nPosition);
	}
}
