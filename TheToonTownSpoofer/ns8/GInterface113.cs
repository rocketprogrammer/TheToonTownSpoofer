using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;

namespace ns8
{
	// Token: 0x0200010A RID: 266
	[InterfaceType(2)]
	[Guid("D84CCA96-CCE2-11D2-9ECC-0000F8085981")]
	[TypeLibType(4112)]
	[ComImport]
	public interface GInterface113
	{
		// Token: 0x06000E0D RID: 3597
		[DispId(5001)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenStateChange([In] int NewState);

		// Token: 0x06000E0E RID: 3598
		[DispId(5101)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlayStateChange([In] int NewState);

		// Token: 0x06000E0F RID: 3599
		[DispId(5102)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void AudioLanguageChange([In] int LangID);

		// Token: 0x06000E10 RID: 3600
		[DispId(5002)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StatusChange();

		// Token: 0x06000E11 RID: 3601
		[DispId(5301)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ScriptCommand([MarshalAs(UnmanagedType.BStr)] [In] string scType, [MarshalAs(UnmanagedType.BStr)] [In] string Param);

		// Token: 0x06000E12 RID: 3602
		[DispId(5403)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void NewStream();

		// Token: 0x06000E13 RID: 3603
		[DispId(5401)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Disconnect([In] int Result);

		// Token: 0x06000E14 RID: 3604
		[DispId(5402)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Buffering([In] bool Start);

		// Token: 0x06000E15 RID: 3605
		[DispId(5501)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Error();

		// Token: 0x06000E16 RID: 3606
		[DispId(5601)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void Warning([In] int WarningType, [In] int Param, [MarshalAs(UnmanagedType.BStr)] [In] string Description);

		// Token: 0x06000E17 RID: 3607
		[DispId(5201)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void EndOfStream([In] int Result);

		// Token: 0x06000E18 RID: 3608
		[DispId(5202)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PositionChange([In] double oldPosition, [In] double newPosition);

		// Token: 0x06000E19 RID: 3609
		[DispId(5203)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MarkerHit([In] int MarkerNum);

		// Token: 0x06000E1A RID: 3610
		[DispId(5204)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DurationUnitChange([In] int NewDurationUnit);

		// Token: 0x06000E1B RID: 3611
		[DispId(5701)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CdromMediaChange([In] int CdromNum);

		// Token: 0x06000E1C RID: 3612
		[DispId(5801)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Playlist, [In] Enum0 change);

		// Token: 0x06000E1D RID: 3613
		[DispId(5804)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistChange([In] Enum0 change);

		// Token: 0x06000E1E RID: 3614
		[DispId(5805)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentPlaylistItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000E1F RID: 3615
		[DispId(5802)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaChange([MarshalAs(UnmanagedType.IDispatch)] [In] object Item);

		// Token: 0x06000E20 RID: 3616
		[DispId(5803)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentMediaItemAvailable([MarshalAs(UnmanagedType.BStr)] [In] string bstrItemName);

		// Token: 0x06000E21 RID: 3617
		[DispId(5806)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void CurrentItemChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x06000E22 RID: 3618
		[DispId(5807)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionChange();

		// Token: 0x06000E23 RID: 3619
		[DispId(5808)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000E24 RID: 3620
		[DispId(5809)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribVal);

		// Token: 0x06000E25 RID: 3621
		[DispId(5820)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionAttributeStringChanged([MarshalAs(UnmanagedType.BStr)] [In] string bstrAttribName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrOldAttribVal, [MarshalAs(UnmanagedType.BStr)] [In] string bstrNewAttribVal);

		// Token: 0x06000E26 RID: 3622
		[DispId(5810)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionChange();

		// Token: 0x06000E27 RID: 3623
		[DispId(5811)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistAdded([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000E28 RID: 3624
		[DispId(5812)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistRemoved([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName);

		// Token: 0x06000E29 RID: 3625
		[DispId(5818)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void PlaylistCollectionPlaylistSetAsDeleted([MarshalAs(UnmanagedType.BStr)] [In] string bstrPlaylistName, [In] bool varfIsDeleted);

		// Token: 0x06000E2A RID: 3626
		[DispId(5819)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void ModeChange([MarshalAs(UnmanagedType.BStr)] [In] string ModeName, [In] bool NewValue);

		// Token: 0x06000E2B RID: 3627
		[DispId(5821)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaError([MarshalAs(UnmanagedType.IDispatch)] [In] object pMediaObject);

		// Token: 0x06000E2C RID: 3628
		[DispId(5823)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void OpenPlaylistSwitch([MarshalAs(UnmanagedType.IDispatch)] [In] object pItem);

		// Token: 0x06000E2D RID: 3629
		[DispId(5822)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void DomainChange([MarshalAs(UnmanagedType.BStr)] [In] string strDomain);

		// Token: 0x06000E2E RID: 3630
		[DispId(5824)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void StringCollectionChange([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispStringCollection, [In] Enum8 change, [In] int lCollectionIndex);

		// Token: 0x06000E2F RID: 3631
		[DispId(5825)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionMediaAdded([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);

		// Token: 0x06000E30 RID: 3632
		[DispId(5826)]
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		void MediaCollectionMediaRemoved([MarshalAs(UnmanagedType.IDispatch)] [In] object pdispMedia);
	}
}
