using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns3
{
	// Token: 0x02000083 RID: 131
	[TypeLibType(4160)]
	[Guid("EC21B779-EDEF-462D-BBA4-AD9DDE2B29A7")]
	[ComImport]
	public interface GInterface22
	{
		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000569 RID: 1385
		[DispId(801)]
		int bandWidth { [DispId(801)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600056A RID: 1386
		[DispId(802)]
		int recoveredPackets { [DispId(802)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600056B RID: 1387
		[DispId(803)]
		string sourceProtocol { [DispId(803)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600056C RID: 1388
		[DispId(804)]
		int receivedPackets { [DispId(804)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600056D RID: 1389
		[DispId(805)]
		int lostPackets { [DispId(805)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600056E RID: 1390
		[DispId(806)]
		int receptionQuality { [DispId(806)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600056F RID: 1391
		[DispId(807)]
		int bufferingCount { [DispId(807)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000570 RID: 1392
		[DispId(808)]
		int bufferingProgress { [DispId(808)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000571 RID: 1393
		// (set) Token: 0x06000572 RID: 1394
		[DispId(809)]
		int bufferingTime { [DispId(809)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(809)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000573 RID: 1395
		[DispId(810)]
		int frameRate { [DispId(810)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000574 RID: 1396
		[DispId(811)]
		int maxBitRate { [DispId(811)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000575 RID: 1397
		[DispId(812)]
		int bitRate { [DispId(812)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000576 RID: 1398
		[DispId(813)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol);

		// Token: 0x06000577 RID: 1399
		[DispId(814)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol, [In] int lProxySetting);

		// Token: 0x06000578 RID: 1400
		[DispId(815)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol);

		// Token: 0x06000579 RID: 1401
		[DispId(816)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol, [MarshalAs(UnmanagedType.BStr)] [In] string bstrProxyName);

		// Token: 0x0600057A RID: 1402
		[DispId(817)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		int imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol);

		// Token: 0x0600057B RID: 1403
		[DispId(818)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol, [In] int lProxyPort);

		// Token: 0x0600057C RID: 1404
		[DispId(819)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_6([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol);

		// Token: 0x0600057D RID: 1405
		[DispId(820)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol, [MarshalAs(UnmanagedType.BStr)] [In] string pbstrExceptionList);

		// Token: 0x0600057E RID: 1406
		[DispId(821)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		bool imethod_8([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol);

		// Token: 0x0600057F RID: 1407
		[DispId(822)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9([MarshalAs(UnmanagedType.BStr)] [In] string bstrProtocol, [In] bool fBypassForLocal);

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000580 RID: 1408
		// (set) Token: 0x06000581 RID: 1409
		[DispId(823)]
		int maxBandwidth { [DispId(823)] [MethodImpl(MethodImplOptions.InternalCall)] get; [DispId(823)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000582 RID: 1410
		[DispId(824)]
		int downloadProgress { [DispId(824)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000583 RID: 1411
		[DispId(825)]
		int encodedFrameRate { [DispId(825)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000584 RID: 1412
		[DispId(826)]
		int framesSkipped { [DispId(826)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
