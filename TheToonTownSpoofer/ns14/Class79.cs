using System;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns10;
using ns11;
using ns12;
using ns13;

namespace ns14
{
	// Token: 0x020001C5 RID: 453
	[ClassInterface(ClassInterfaceType.None)]
	internal sealed class Class79 : GInterface12
	{
		// Token: 0x06001434 RID: 5172 RVA: 0x00004F84 File Offset: 0x00003184
		public Class79(Class24 class24_1)
		{
			this.class24_0 = class24_1;
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x00024B30 File Offset: 0x00022D30
		public void CdromBurnError(GInterface5 pCdromBurn, int hrError)
		{
			Class25 class25_ = new Class25(pCdromBurn, hrError);
			this.class24_0.method_1(this.class24_0, class25_);
		}

		// Token: 0x06001436 RID: 5174 RVA: 0x00024B58 File Offset: 0x00022D58
		public void LibraryConnect(GInterface8 pLibrary)
		{
			Class26 class26_ = new Class26(pLibrary);
			this.class24_0.method_2(this.class24_0, class26_);
		}

		// Token: 0x06001437 RID: 5175 RVA: 0x00024B80 File Offset: 0x00022D80
		public void LibraryDisconnect(GInterface8 pLibrary)
		{
			Class27 class27_ = new Class27(pLibrary);
			this.class24_0.method_3(this.class24_0, class27_);
		}

		// Token: 0x06001438 RID: 5176 RVA: 0x00024BA8 File Offset: 0x00022DA8
		public void FolderScanStateChange(Enum7 wmpfss)
		{
			Class28 class28_ = new Class28(wmpfss);
			this.class24_0.method_4(this.class24_0, class28_);
		}

		// Token: 0x06001439 RID: 5177 RVA: 0x00024BD0 File Offset: 0x00022DD0
		public void StringCollectionChange(object pdispStringCollection, Enum8 change, int lCollectionIndex)
		{
			Class29 class29_ = new Class29(pdispStringCollection, change, lCollectionIndex);
			this.class24_0.method_5(this.class24_0, class29_);
		}

		// Token: 0x0600143A RID: 5178 RVA: 0x00024BF8 File Offset: 0x00022DF8
		public void MediaCollectionMediaAdded(object pdispMedia)
		{
			Class30 class30_ = new Class30(pdispMedia);
			this.class24_0.method_6(this.class24_0, class30_);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x00024C20 File Offset: 0x00022E20
		public void MediaCollectionMediaRemoved(object pdispMedia)
		{
			Class31 class31_ = new Class31(pdispMedia);
			this.class24_0.method_7(this.class24_0, class31_);
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x00024C48 File Offset: 0x00022E48
		public void PlaylistCollectionPlaylistSetAsDeleted(string bstrPlaylistName, bool varfIsDeleted)
		{
			Class32 class32_ = new Class32(bstrPlaylistName, varfIsDeleted);
			this.class24_0.method_8(this.class24_0, class32_);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x00024C70 File Offset: 0x00022E70
		public void ModeChange(string ModeName, bool NewValue)
		{
			Class33 class33_ = new Class33(ModeName, NewValue);
			this.class24_0.method_9(this.class24_0, class33_);
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x00024C98 File Offset: 0x00022E98
		public void MediaError(object pMediaObject)
		{
			Class34 class34_ = new Class34(pMediaObject);
			this.class24_0.method_10(this.class24_0, class34_);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x00024CC0 File Offset: 0x00022EC0
		public void OpenPlaylistSwitch(object pItem)
		{
			Class35 class35_ = new Class35(pItem);
			this.class24_0.method_11(this.class24_0, class35_);
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x00024CE8 File Offset: 0x00022EE8
		public void DomainChange(string strDomain)
		{
			Class36 class36_ = new Class36(strDomain);
			this.class24_0.method_12(this.class24_0, class36_);
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x00024D10 File Offset: 0x00022F10
		public void SwitchedToPlayerApplication()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_13(this.class24_0, e);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x00024D38 File Offset: 0x00022F38
		public void SwitchedToControl()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_14(this.class24_0, e);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x00024D60 File Offset: 0x00022F60
		public void PlayerDockedStateChange()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_15(this.class24_0, e);
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x00024D88 File Offset: 0x00022F88
		public void PlayerReconnect()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_16(this.class24_0, e);
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00024DB0 File Offset: 0x00022FB0
		public void Click(short nButton, short nShiftState, int fX, int fY)
		{
			Class37 class37_ = new Class37(nButton, nShiftState, fX, fY);
			this.class24_0.method_17(this.class24_0, class37_);
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x00024DDC File Offset: 0x00022FDC
		public void DoubleClick(short nButton, short nShiftState, int fX, int fY)
		{
			Class38 class38_ = new Class38(nButton, nShiftState, fX, fY);
			this.class24_0.method_18(this.class24_0, class38_);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x00024E08 File Offset: 0x00023008
		public void KeyDown(short nKeyCode, short nShiftState)
		{
			Class39 class39_ = new Class39(nKeyCode, nShiftState);
			this.class24_0.method_19(this.class24_0, class39_);
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x00024E30 File Offset: 0x00023030
		public void KeyPress(short nKeyAscii)
		{
			Class40 class40_ = new Class40(nKeyAscii);
			this.class24_0.method_20(this.class24_0, class40_);
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x00024E58 File Offset: 0x00023058
		public void KeyUp(short nKeyCode, short nShiftState)
		{
			Class41 class41_ = new Class41(nKeyCode, nShiftState);
			this.class24_0.method_21(this.class24_0, class41_);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x00024E80 File Offset: 0x00023080
		public void MouseDown(short nButton, short nShiftState, int fX, int fY)
		{
			Class42 class42_ = new Class42(nButton, nShiftState, fX, fY);
			this.class24_0.method_22(this.class24_0, class42_);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x00024EAC File Offset: 0x000230AC
		public void MouseMove(short nButton, short nShiftState, int fX, int fY)
		{
			Class43 class43_ = new Class43(nButton, nShiftState, fX, fY);
			this.class24_0.method_23(this.class24_0, class43_);
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x00024ED8 File Offset: 0x000230D8
		public void MouseUp(short nButton, short nShiftState, int fX, int fY)
		{
			Class44 class44_ = new Class44(nButton, nShiftState, fX, fY);
			this.class24_0.method_24(this.class24_0, class44_);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x00024F04 File Offset: 0x00023104
		public void DeviceConnect(GInterface2 pDevice)
		{
			Class45 class45_ = new Class45(pDevice);
			this.class24_0.method_25(this.class24_0, class45_);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00024F2C File Offset: 0x0002312C
		public void DeviceDisconnect(GInterface2 pDevice)
		{
			Class46 class46_ = new Class46(pDevice);
			this.class24_0.method_26(this.class24_0, class46_);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00024F54 File Offset: 0x00023154
		public void DeviceStatusChange(GInterface2 pDevice, Enum1 NewStatus)
		{
			Class47 class47_ = new Class47(pDevice, NewStatus);
			this.class24_0.method_27(this.class24_0, class47_);
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x00024F7C File Offset: 0x0002317C
		public void DeviceSyncStateChange(GInterface2 pDevice, Enum2 NewState)
		{
			Class48 class48_ = new Class48(pDevice, NewState);
			this.class24_0.method_28(this.class24_0, class48_);
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00024FA4 File Offset: 0x000231A4
		public void DeviceSyncError(GInterface2 pDevice, object pMedia)
		{
			Class49 class49_ = new Class49(pDevice, pMedia);
			this.class24_0.method_29(this.class24_0, class49_);
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00024FCC File Offset: 0x000231CC
		public void CreatePartnershipComplete(GInterface2 pDevice, int hrResult)
		{
			Class50 class50_ = new Class50(pDevice, hrResult);
			this.class24_0.method_30(this.class24_0, class50_);
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00024FF4 File Offset: 0x000231F4
		public void DeviceEstimation(GInterface2 pDevice, int hrResult, long qwEstimatedUsedSpace, long qwEstimatedSpace)
		{
			Class51 class51_ = new Class51(pDevice, hrResult, qwEstimatedUsedSpace, qwEstimatedSpace);
			this.class24_0.method_31(this.class24_0, class51_);
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00025020 File Offset: 0x00023220
		public void CdromRipStateChange(GInterface4 pCdromRip, Enum3 wmprs)
		{
			Class52 class52_ = new Class52(pCdromRip, wmprs);
			this.class24_0.method_32(this.class24_0, class52_);
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00025048 File Offset: 0x00023248
		public void CdromRipMediaError(GInterface4 pCdromRip, object pMedia)
		{
			Class53 class53_ = new Class53(pCdromRip, pMedia);
			this.class24_0.method_33(this.class24_0, class53_);
		}

		// Token: 0x06001456 RID: 5206 RVA: 0x00025070 File Offset: 0x00023270
		public void CdromBurnStateChange(GInterface5 pCdromBurn, Enum5 wmpbs)
		{
			Class54 class54_ = new Class54(pCdromBurn, wmpbs);
			this.class24_0.method_34(this.class24_0, class54_);
		}

		// Token: 0x06001457 RID: 5207 RVA: 0x00025098 File Offset: 0x00023298
		public void CdromBurnMediaError(GInterface5 pCdromBurn, object pMedia)
		{
			Class55 class55_ = new Class55(pCdromBurn, pMedia);
			this.class24_0.method_35(this.class24_0, class55_);
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x000250C0 File Offset: 0x000232C0
		public void OpenStateChange(int NewState)
		{
			Class56 class56_ = new Class56(NewState);
			this.class24_0.method_36(this.class24_0, class56_);
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x000250E8 File Offset: 0x000232E8
		public void PlayStateChange(int NewState)
		{
			Class57 class57_ = new Class57(NewState);
			this.class24_0.method_37(this.class24_0, class57_);
		}

		// Token: 0x0600145A RID: 5210 RVA: 0x00025110 File Offset: 0x00023310
		public void AudioLanguageChange(int LangID)
		{
			Class58 class58_ = new Class58(LangID);
			this.class24_0.method_38(this.class24_0, class58_);
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00025138 File Offset: 0x00023338
		public void StatusChange()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_39(this.class24_0, e);
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00025160 File Offset: 0x00023360
		public void ScriptCommand(string scType, string Param)
		{
			Class59 class59_ = new Class59(scType, Param);
			this.class24_0.method_40(this.class24_0, class59_);
		}

		// Token: 0x0600145D RID: 5213 RVA: 0x00025188 File Offset: 0x00023388
		public void NewStream()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_41(this.class24_0, e);
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x000251B0 File Offset: 0x000233B0
		public void Disconnect(int Result)
		{
			Class60 class60_ = new Class60(Result);
			this.class24_0.method_42(this.class24_0, class60_);
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x000251D8 File Offset: 0x000233D8
		public void Buffering(bool Start)
		{
			Class61 class61_ = new Class61(Start);
			this.class24_0.method_43(this.class24_0, class61_);
		}

		// Token: 0x06001460 RID: 5216 RVA: 0x00025200 File Offset: 0x00023400
		public void Error()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_44(this.class24_0, e);
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x00025228 File Offset: 0x00023428
		public void Warning(int WarningType, int Param, string Description)
		{
			Class62 class62_ = new Class62(WarningType, Param, Description);
			this.class24_0.method_45(this.class24_0, class62_);
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x00025250 File Offset: 0x00023450
		public void EndOfStream(int Result)
		{
			Class63 class63_ = new Class63(Result);
			this.class24_0.method_46(this.class24_0, class63_);
		}

		// Token: 0x06001463 RID: 5219 RVA: 0x00025278 File Offset: 0x00023478
		public void PositionChange(double oldPosition, double newPosition)
		{
			Class64 class64_ = new Class64(oldPosition, newPosition);
			this.class24_0.method_47(this.class24_0, class64_);
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000252A0 File Offset: 0x000234A0
		public void MarkerHit(int MarkerNum)
		{
			Class65 class65_ = new Class65(MarkerNum);
			this.class24_0.method_48(this.class24_0, class65_);
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x000252C8 File Offset: 0x000234C8
		public void DurationUnitChange(int NewDurationUnit)
		{
			Class66 class66_ = new Class66(NewDurationUnit);
			this.class24_0.method_49(this.class24_0, class66_);
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x000252F0 File Offset: 0x000234F0
		public void CdromMediaChange(int CdromNum)
		{
			Class67 class67_ = new Class67(CdromNum);
			this.class24_0.method_50(this.class24_0, class67_);
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00025318 File Offset: 0x00023518
		public void PlaylistChange(object Playlist, Enum0 change)
		{
			Class68 class68_ = new Class68(Playlist, change);
			this.class24_0.method_51(this.class24_0, class68_);
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00025340 File Offset: 0x00023540
		public void CurrentPlaylistChange(Enum0 change)
		{
			Class69 class69_ = new Class69(change);
			this.class24_0.method_52(this.class24_0, class69_);
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00025368 File Offset: 0x00023568
		public void CurrentPlaylistItemAvailable(string bstrItemName)
		{
			Class70 class70_ = new Class70(bstrItemName);
			this.class24_0.method_53(this.class24_0, class70_);
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x00025390 File Offset: 0x00023590
		public void MediaChange(object Item)
		{
			Class71 class71_ = new Class71(Item);
			this.class24_0.method_54(this.class24_0, class71_);
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000253B8 File Offset: 0x000235B8
		public void CurrentMediaItemAvailable(string bstrItemName)
		{
			Class72 class72_ = new Class72(bstrItemName);
			this.class24_0.method_55(this.class24_0, class72_);
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000253E0 File Offset: 0x000235E0
		public void CurrentItemChange(object pdispMedia)
		{
			Class73 class73_ = new Class73(pdispMedia);
			this.class24_0.method_56(this.class24_0, class73_);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00025408 File Offset: 0x00023608
		public void MediaCollectionChange()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_57(this.class24_0, e);
		}

		// Token: 0x0600146E RID: 5230 RVA: 0x00025430 File Offset: 0x00023630
		public void MediaCollectionAttributeStringAdded(string bstrAttribName, string bstrAttribVal)
		{
			Class74 class74_ = new Class74(bstrAttribName, bstrAttribVal);
			this.class24_0.method_58(this.class24_0, class74_);
		}

		// Token: 0x0600146F RID: 5231 RVA: 0x00025458 File Offset: 0x00023658
		public void MediaCollectionAttributeStringRemoved(string bstrAttribName, string bstrAttribVal)
		{
			Class75 class75_ = new Class75(bstrAttribName, bstrAttribVal);
			this.class24_0.method_59(this.class24_0, class75_);
		}

		// Token: 0x06001470 RID: 5232 RVA: 0x00025480 File Offset: 0x00023680
		public void MediaCollectionAttributeStringChanged(string bstrAttribName, string bstrOldAttribVal, string bstrNewAttribVal)
		{
			Class76 class76_ = new Class76(bstrAttribName, bstrOldAttribVal, bstrNewAttribVal);
			this.class24_0.method_60(this.class24_0, class76_);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x000254A8 File Offset: 0x000236A8
		public void PlaylistCollectionChange()
		{
			EventArgs e = new EventArgs();
			this.class24_0.method_61(this.class24_0, e);
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x000254D0 File Offset: 0x000236D0
		public void PlaylistCollectionPlaylistAdded(string bstrPlaylistName)
		{
			Class77 class77_ = new Class77(bstrPlaylistName);
			this.class24_0.method_62(this.class24_0, class77_);
		}

		// Token: 0x06001473 RID: 5235 RVA: 0x000254F8 File Offset: 0x000236F8
		public void PlaylistCollectionPlaylistRemoved(string bstrPlaylistName)
		{
			Class78 class78_ = new Class78(bstrPlaylistName);
			this.class24_0.method_63(this.class24_0, class78_);
		}

		// Token: 0x040001FB RID: 507
		private Class24 class24_0;
	}
}
