using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns9
{
	// Token: 0x02000132 RID: 306
	[Guid("6B550945-018F-11D3-B14A-00C04F79FAA6")]
	[TypeLibType(4160)]
	[ComConversionLoss]
	[ComImport]
	public interface GInterface115
	{
		// Token: 0x06001047 RID: 4167
		[DispId(8151)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] int lGraphState);

		// Token: 0x06001048 RID: 4168
		[DispId(8173)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] int lGraphState);

		// Token: 0x06001049 RID: 4169
		[DispId(8153)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] double dRate);

		// Token: 0x0600104A RID: 4170
		[DispId(8157)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [MarshalAs(UnmanagedType.BStr)] string bstrQueuedUrl, [ComAliasName("WMPLib.ULONG_PTR")] uint dwCurrentContext);

		// Token: 0x0600104B RID: 4171
		[DispId(8156)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph);

		// Token: 0x0600104C RID: 4172
		[DispId(8158)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [MarshalAs(UnmanagedType.BStr)] [In] string bstrCommand, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParam);

		// Token: 0x0600104D RID: 4173
		[DispId(8172)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [MarshalAs(UnmanagedType.BStr)] [In] string bstrCommand, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParam, [In] double dTime);

		// Token: 0x0600104E RID: 4174
		[DispId(8159)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] int lMarker);

		// Token: 0x0600104F RID: 4175
		[DispId(8160)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] int lErrMajor, [In] int lErrMinor, [In] int lCondition, [MarshalAs(UnmanagedType.BStr)] [In] string bstrInfo, [MarshalAs(UnmanagedType.IUnknown)] [In] object punkGraphData);

		// Token: 0x06001050 RID: 4176
		[DispId(8161)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [MarshalAs(UnmanagedType.BStr)] [In] string bstrRealm, [MarshalAs(UnmanagedType.BStr)] [In] string bstrSite, [In] [Out] IntPtr bstrUser, [In] [Out] IntPtr bstrPassword, [In] [Out] ref uint pdwFlags, out bool pfCancel);

		// Token: 0x06001051 RID: 4177
		[DispId(8178)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL, out bool pfCancel);

		// Token: 0x06001052 RID: 4178
		[DispId(8162)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL, [MarshalAs(UnmanagedType.BStr)] [In] string bstrContent, [In] ref byte pPostData, [In] uint dwPostDataSize, [In] int lResult);

		// Token: 0x06001053 RID: 4179
		[DispId(8163)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_12([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, out bool pfResult);

		// Token: 0x06001054 RID: 4180
		[DispId(8165)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_13([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph);

		// Token: 0x06001055 RID: 4181
		[DispId(8166)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_14([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph);

		// Token: 0x06001056 RID: 4182
		[DispId(8167)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_15([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] int lResult);

		// Token: 0x06001057 RID: 4183
		[DispId(8168)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_16([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] int fStarted, [In] int lResult);

		// Token: 0x06001058 RID: 4184
		[DispId(8169)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_17([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] bool fDelay);

		// Token: 0x06001059 RID: 4185
		[DispId(8170)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_18([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] int lEventCode, [In] int lParam1, [In] int lParam2);

		// Token: 0x0600105A RID: 4186
		[DispId(8171)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_19([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] uint dwAction);

		// Token: 0x0600105B RID: 4187
		[DispId(8174)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_20([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph);

		// Token: 0x0600105C RID: 4188
		[DispId(8177)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_21([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph);

		// Token: 0x0600105D RID: 4189
		[DispId(8179)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_22([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph);

		// Token: 0x0600105E RID: 4190
		[DispId(8180)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_23([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] uint dwBitrate);

		// Token: 0x0600105F RID: 4191
		[DispId(8181)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_24([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkFilterGraph, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkCardeaEncConfig, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint phrContinue, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint hEventToSet);

		// Token: 0x06001060 RID: 4192
		[DispId(8182)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_25([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkFilterGraph, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint phrContinue, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint hEventToSet);

		// Token: 0x06001061 RID: 4193
		[DispId(8186)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_26([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [In] int EventCode);

		// Token: 0x06001062 RID: 4194
		[DispId(8183)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_27([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, out bool pfResult);

		// Token: 0x06001063 RID: 4195
		[DispId(8184)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_28([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint phWnd, [ComAliasName("WMPLib.ULONG_PTR")] [In] uint hIndivEvent, out bool pfCancel, out bool pfResult);

		// Token: 0x06001064 RID: 4196
		[DispId(8185)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_29([ComAliasName("WMPLib.ULONG_PTR")] [In] uint punkGraph);
	}
}
