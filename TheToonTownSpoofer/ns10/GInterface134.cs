using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns10
{
	// Token: 0x02000147 RID: 327
	[Guid("4E195DB1-9E29-47FC-9CE1-DE9937D32925")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface134
	{
		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001114 RID: 4372
		[DispId(1)]
		string TransportState { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001115 RID: 4373
		[DispId(2)]
		string TransportStatus { [DispId(2)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001116 RID: 4374
		[DispId(3)]
		string PlaybackStorageMedium { [DispId(3)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001117 RID: 4375
		[DispId(4)]
		string RecordStorageMedium { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001118 RID: 4376
		[DispId(5)]
		string PossiblePlaybackStorageMedia { [DispId(5)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001119 RID: 4377
		[DispId(6)]
		string PossibleRecordStorageMedia { [DispId(6)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600111A RID: 4378
		[DispId(7)]
		string CurrentPlayMode { [DispId(7)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x0600111B RID: 4379
		[DispId(8)]
		string TransportPlaySpeed { [DispId(8)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x0600111C RID: 4380
		[DispId(9)]
		string RecordMediumWriteStatus { [DispId(9)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x0600111D RID: 4381
		[DispId(10)]
		string CurrentRecordQualityMode { [DispId(10)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x0600111E RID: 4382
		[DispId(11)]
		string PossibleRecordQualityModes { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x0600111F RID: 4383
		[DispId(12)]
		uint NumberOfTracks { [DispId(12)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001120 RID: 4384
		[DispId(13)]
		uint CurrentTrack { [DispId(13)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001121 RID: 4385
		[DispId(14)]
		string CurrentTrackDuration { [DispId(14)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001122 RID: 4386
		[DispId(15)]
		string CurrentMediaDuration { [DispId(15)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001123 RID: 4387
		[DispId(16)]
		string CurrentTrackMetaData { [DispId(16)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001124 RID: 4388
		[DispId(17)]
		string CurrentTrackURI { [DispId(17)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001125 RID: 4389
		[DispId(18)]
		string AVTransportURI { [DispId(18)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001126 RID: 4390
		[DispId(19)]
		string AVTransportURIMetaData { [DispId(19)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001127 RID: 4391
		[DispId(20)]
		string NextAVTransportURI { [DispId(20)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001128 RID: 4392
		[DispId(21)]
		string NextAVTransportURIMetaData { [DispId(21)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001129 RID: 4393
		[DispId(22)]
		string RelativeTimePosition { [DispId(22)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600112A RID: 4394
		[DispId(23)]
		string AbsoluteTimePosition { [DispId(23)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600112B RID: 4395
		[DispId(24)]
		int RelativeCounterPosition { [DispId(24)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700067A RID: 1658
		// (get) Token: 0x0600112C RID: 4396
		[DispId(25)]
		int AbsoluteCounterPosition { [DispId(25)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x1700067B RID: 1659
		// (get) Token: 0x0600112D RID: 4397
		[DispId(26)]
		string CurrentTransportActions { [DispId(26)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700067C RID: 1660
		// (get) Token: 0x0600112E RID: 4398
		[DispId(27)]
		string LastChange { [DispId(27)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700067D RID: 1661
		// (get) Token: 0x0600112F RID: 4399
		[DispId(28)]
		string A_ARG_TYPE_SeekMode { [DispId(28)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700067E RID: 1662
		// (get) Token: 0x06001130 RID: 4400
		[DispId(29)]
		string A_ARG_TYPE_SeekTarget { [DispId(29)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700067F RID: 1663
		// (get) Token: 0x06001131 RID: 4401
		[DispId(30)]
		uint A_ARG_TYPE_InstanceID { [DispId(30)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000680 RID: 1664
		// (get) Token: 0x06001132 RID: 4402
		[DispId(45)]
		string CurrentProtocolInfo { [DispId(45)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06001133 RID: 4403
		[DispId(31)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.IUnknown)] [In] object punkRemoteEndpointInfo, [In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrCurrentURI, [MarshalAs(UnmanagedType.BStr)] [In] string bstrCurrentURIMetaData);

		// Token: 0x06001134 RID: 4404
		[DispId(33)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_1([In] uint ulInstanceID, out uint pulNumTracks, [MarshalAs(UnmanagedType.BStr)] out string pbstrMediaDuration, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentURI, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentURIMetaData, [MarshalAs(UnmanagedType.BStr)] out string pbstrNextURI, [MarshalAs(UnmanagedType.BStr)] out string pNextURIMetaData, [MarshalAs(UnmanagedType.BStr)] out string pbstrPlayMedium, [MarshalAs(UnmanagedType.BStr)] out string pbstrRecordMedium, [MarshalAs(UnmanagedType.BStr)] out string pbstrWriteStatus);

		// Token: 0x06001135 RID: 4405
		[DispId(34)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentTransportState, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentTransportStatus, [MarshalAs(UnmanagedType.BStr)] out string pbstrCurrentSpeed);

		// Token: 0x06001136 RID: 4406
		[DispId(35)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3([In] uint ulInstanceID, out uint pTrack, [MarshalAs(UnmanagedType.BStr)] out string pbstrTrackDuration, [MarshalAs(UnmanagedType.BStr)] out string pbstrTrackMetaData, [MarshalAs(UnmanagedType.BStr)] out string pbstrTrackURI, [MarshalAs(UnmanagedType.BStr)] out string pbstrRelTime, [MarshalAs(UnmanagedType.BStr)] out string pbstrAbsTime, out int plRelCount, out int plAbsCount);

		// Token: 0x06001137 RID: 4407
		[DispId(36)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] out string pbstrPlayMedia, [MarshalAs(UnmanagedType.BStr)] out string pbstrRecMedia, [MarshalAs(UnmanagedType.BStr)] out string pbstrRecQualityModes);

		// Token: 0x06001138 RID: 4408
		[DispId(37)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] out string pbstrPlayMode, [MarshalAs(UnmanagedType.BStr)] out string pbstrRecQualityMode);

		// Token: 0x06001139 RID: 4409
		[DispId(38)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6([In] uint ulInstanceID);

		// Token: 0x0600113A RID: 4410
		[DispId(39)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrSpeed);

		// Token: 0x0600113B RID: 4411
		[DispId(40)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8([In] uint ulInstanceID);

		// Token: 0x0600113C RID: 4412
		[DispId(41)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrUnit, [MarshalAs(UnmanagedType.BStr)] [In] string bstrTarget);

		// Token: 0x0600113D RID: 4413
		[DispId(42)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10([In] uint ulInstanceID);

		// Token: 0x0600113E RID: 4414
		[DispId(43)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11([In] uint ulInstanceID);

		// Token: 0x0600113F RID: 4415
		[DispId(44)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_12([In] uint ulInstanceID, [MarshalAs(UnmanagedType.BStr)] [In] [Out] ref string pbstrActions);
	}
}
