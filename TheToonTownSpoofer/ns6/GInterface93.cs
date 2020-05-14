using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns6
{
	// Token: 0x020000DD RID: 221
	[DefaultMember("value")]
	[Guid("70E1217C-C617-4CFD-BD8A-69CA2043E70B")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface93
	{
		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000C09 RID: 3081
		// (set) Token: 0x06000C0A RID: 3082
		[DispId(0)]
		[IndexerName("value")]
		string value { [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(0)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06000C0B RID: 3083
		// (set) Token: 0x06000C0C RID: 3084
		[DispId(6000)]
		bool border { [DispId(6000)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6000)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06000C0D RID: 3085
		// (set) Token: 0x06000C0E RID: 3086
		[DispId(6001)]
		string justification { [DispId(6001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6001)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06000C0F RID: 3087
		// (set) Token: 0x06000C10 RID: 3088
		[DispId(6002)]
		string editStyle { [DispId(6002)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6002)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06000C11 RID: 3089
		// (set) Token: 0x06000C12 RID: 3090
		[DispId(6003)]
		bool wordWrap { [DispId(6003)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6003)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06000C13 RID: 3091
		// (set) Token: 0x06000C14 RID: 3092
		[DispId(6004)]
		bool readOnly { [DispId(6004)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6004)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06000C15 RID: 3093
		// (set) Token: 0x06000C16 RID: 3094
		[DispId(6005)]
		string foregroundColor { [DispId(6005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6005)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06000C17 RID: 3095
		// (set) Token: 0x06000C18 RID: 3096
		[DispId(6006)]
		string backgroundColor { [DispId(6006)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6006)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06000C19 RID: 3097
		// (set) Token: 0x06000C1A RID: 3098
		[DispId(6007)]
		int fontSize { [DispId(6007)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6007)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06000C1B RID: 3099
		// (set) Token: 0x06000C1C RID: 3100
		[DispId(6008)]
		string fontStyle { [DispId(6008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6008)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06000C1D RID: 3101
		// (set) Token: 0x06000C1E RID: 3102
		[DispId(6009)]
		string fontFace { [DispId(6009)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(6009)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06000C1F RID: 3103
		// (set) Token: 0x06000C20 RID: 3104
		[DispId(6010)]
		int textLimit { [DispId(6010)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(6010)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06000C21 RID: 3105
		[DispId(6011)]
		int lineCount { [DispId(6011)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000C22 RID: 3106
		[DispId(6012)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_0([In] int nIndex);

		// Token: 0x06000C23 RID: 3107
		[DispId(6013)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_1();

		// Token: 0x06000C24 RID: 3108
		[DispId(6014)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_2();

		// Token: 0x06000C25 RID: 3109
		[DispId(6015)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([In] int nStart, [In] int nEnd);

		// Token: 0x06000C26 RID: 3110
		[DispId(6016)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string newVal);

		// Token: 0x06000C27 RID: 3111
		[DispId(6017)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_5([In] int nIndex);

		// Token: 0x06000C28 RID: 3112
		[DispId(6018)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_6([In] int nPosition);
	}
}
