using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns9;

namespace ns10
{
	// Token: 0x02000142 RID: 322
	[Guid("A915CEA2-72DF-41E1-A576-EF0BAE5E5169")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface130 : GInterface124
	{
		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x060010D4 RID: 4308
		[DispId(10005)]
		string version { [DispId(10005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x060010D5 RID: 4309
		[DispId(10012)]
		string appColorLight { [DispId(10012)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700063A RID: 1594
		// (set) Token: 0x060010D6 RID: 4310
		[DispId(10018)]
		object OnColorChange { [DispId(10018)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x060010D7 RID: 4311
		[DispId(10013)]
		string appColorMedium { [DispId(10013)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x060010D8 RID: 4312
		[DispId(10014)]
		string appColorDark { [DispId(10014)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x060010D9 RID: 4313
		[DispId(10015)]
		string appColorButtonHighlight { [DispId(10015)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x060010DA RID: 4314
		[DispId(10016)]
		string appColorButtonShadow { [DispId(10016)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x060010DB RID: 4315
		[DispId(10017)]
		string appColorButtonHoverFace { [DispId(10017)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060010DC RID: 4316
		[DispId(10026)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_2([MarshalAs(UnmanagedType.BStr)] [In] string bstrKeyName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrTaskPane, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParams);

		// Token: 0x17000640 RID: 1600
		// (get) Token: 0x060010DE RID: 4318
		// (set) Token: 0x060010DD RID: 4317
		[DispId(10027)]
		string SelectedTaskPane { [DispId(10027)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(10027)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x17000641 RID: 1601
		// (get) Token: 0x060010DF RID: 4319
		[DispId(10009)]
		GInterface125 DownloadManager { [DispId(10009)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.Interface)] get; }

		// Token: 0x17000642 RID: 1602
		// (set) Token: 0x060010E0 RID: 4320
		[DispId(10028)]
		object OnLoginChange { [DispId(10028)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x060010E1 RID: 4321
		[DispId(10029)]
		bool userLoggedIn { [DispId(10029)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x060010E2 RID: 4322
		[DispId(10030)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_3();

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x060010E3 RID: 4323
		[DispId(10031)]
		string accountType { [DispId(10031)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000645 RID: 1605
		// (set) Token: 0x060010E4 RID: 4324
		[DispId(10032)]
		object OnViewChange { [DispId(10032)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x060010E5 RID: 4325
		[DispId(10033)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_4([MarshalAs(UnmanagedType.BStr)] [In] string bstrLibraryLocationType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLibraryLocationID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFilter, [MarshalAs(UnmanagedType.BStr)] [In] string bstrViewParams);

		// Token: 0x060010E6 RID: 4326
		[DispId(10034)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_5([MarshalAs(UnmanagedType.BStr)] [In] string bstrLibraryLocationType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLibraryLocationID, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParams, [MarshalAs(UnmanagedType.BStr)] [In] string bstrFriendlyName, [MarshalAs(UnmanagedType.BStr)] [In] string bstrListType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrViewMode);

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x060010E7 RID: 4327
		[DispId(10035)]
		string libraryLocationType { [DispId(10035)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x060010E8 RID: 4328
		[DispId(10036)]
		string libraryLocationID { [DispId(10036)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x060010E9 RID: 4329
		[DispId(10037)]
		string selectedItemType { [DispId(10037)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x060010EA RID: 4330
		[DispId(10038)]
		string selectedItemID { [DispId(10038)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x060010EB RID: 4331
		[DispId(10039)]
		string filter { [DispId(10039)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x060010EC RID: 4332
		[DispId(10040)]
		string task { [DispId(10040)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x060010ED RID: 4333
		[DispId(10041)]
		string viewParameters { [DispId(10041)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060010EE RID: 4334
		[DispId(10042)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_6();

		// Token: 0x060010EF RID: 4335
		[DispId(10043)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_7([In] int lPopupIndex, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParameters);

		// Token: 0x060010F0 RID: 4336
		[DispId(10044)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_8([MarshalAs(UnmanagedType.BStr)] [In] string bstrViewType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrViewIDs);

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x060010F1 RID: 4337
		[DispId(10045)]
		string basketTitle { [DispId(10045)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x060010F2 RID: 4338
		[DispId(10046)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_9([MarshalAs(UnmanagedType.BStr)] [In] string bstrLibraryLocationType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrLibraryLocationIDs);

		// Token: 0x060010F3 RID: 4339
		[DispId(10047)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_10([MarshalAs(UnmanagedType.BStr)] [In] string bstrViewType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrViewIDs);

		// Token: 0x060010F4 RID: 4340
		[DispId(10048)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_11([MarshalAs(UnmanagedType.BStr)] [In] string bstrViewType, [MarshalAs(UnmanagedType.BStr)] [In] string bstrViewIDs);

		// Token: 0x060010F5 RID: 4341
		[DispId(10049)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_12([MarshalAs(UnmanagedType.BStr)] [In] string bstrFriendlyListType, [In] bool fDynamic);

		// Token: 0x060010F6 RID: 4342
		[DispId(10050)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_13([In] int lAuthenticationIndex);

		// Token: 0x060010F7 RID: 4343
		[DispId(10051)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_14([MarshalAs(UnmanagedType.BStr)] [In] string bstrMsg, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParam);

		// Token: 0x1700064E RID: 1614
		// (set) Token: 0x060010F8 RID: 4344
		[DispId(10052)]
		object OnSendMessageComplete { [DispId(10052)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x1700064F RID: 1615
		// (set) Token: 0x060010F9 RID: 4345
		[DispId(10053)]
		bool ignoreIEHistory { [DispId(10053)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x060010FA RID: 4346
		[DispId(10054)]
		bool pluginRunning { [DispId(10054)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x060010FB RID: 4347
		[DispId(10055)]
		bool templateBeingDisplayedInLocalLibrary { [DispId(10055)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000652 RID: 1618
		// (set) Token: 0x060010FC RID: 4348
		[DispId(10056)]
		object OnChangeViewError { [DispId(10056)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }

		// Token: 0x17000653 RID: 1619
		// (set) Token: 0x060010FD RID: 4349
		[DispId(10057)]
		object OnChangeViewOnlineListError { [DispId(10057)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.IDispatch)] [param: In] set; }
	}
}
