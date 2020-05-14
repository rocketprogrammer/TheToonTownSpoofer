using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ns5
{
	// Token: 0x020000AE RID: 174
	[Guid("98BB02D4-ED74-43CC-AD6A-45888F2E0DCC")]
	[TypeLibType(4160)]
	[ComImport]
	public interface GInterface65
	{
		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06000918 RID: 2328
		[DispId(3040)]
		string fullServiceName { [DispId(3040)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06000919 RID: 2329
		[DispId(3000)]
		string friendlyName { [DispId(3000)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x0600091A RID: 2330
		[DispId(3001)]
		string guideButtonText { [DispId(3001)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x0600091B RID: 2331
		[DispId(3002)]
		string guideButtonTip { [DispId(3002)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x0600091C RID: 2332
		[DispId(3003)]
		string guideMenuText { [DispId(3003)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x0600091D RID: 2333
		[DispId(3004)]
		string guideAccText { [DispId(3004)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x0600091E RID: 2334
		[DispId(3005)]
		string task1ButtonText { [DispId(3005)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600091F RID: 2335
		[DispId(3006)]
		string task1ButtonTip { [DispId(3006)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06000920 RID: 2336
		[DispId(3007)]
		string task1MenuText { [DispId(3007)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06000921 RID: 2337
		[DispId(3008)]
		string task1AccText { [DispId(3008)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06000922 RID: 2338
		[DispId(3017)]
		string guideUrl { [DispId(3017)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06000923 RID: 2339
		[DispId(3018)]
		string task1Url { [DispId(3018)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06000924 RID: 2340
		[DispId(3021)]
		string imageLargeUrl { [DispId(3021)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000925 RID: 2341
		[DispId(3022)]
		string imageSmallUrl { [DispId(3022)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000926 RID: 2342
		[DispId(3023)]
		string imageMenuUrl { [DispId(3023)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000927 RID: 2343
		[DispId(3024)]
		string infoCenterUrl { [DispId(3024)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000928 RID: 2344
		[DispId(3025)]
		string albumInfoUrl { [DispId(3025)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000929 RID: 2345
		[DispId(3026)]
		string buyCDUrl { [DispId(3026)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x0600092A RID: 2346
		[DispId(3027)]
		string htmlViewUrl { [DispId(3027)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x0600092B RID: 2347
		[DispId(3028)]
		string navigateUrl { [DispId(3028)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x0600092C RID: 2348
		[DispId(3029)]
		string cookieUrl { [DispId(3029)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x0600092D RID: 2349
		[DispId(3030)]
		string downloadStatusUrl { [DispId(3030)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x0600092E RID: 2350
		[DispId(3031)]
		string colorPlayer { [DispId(3031)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600092F RID: 2351
		[DispId(3032)]
		string colorPlayerText { [DispId(3032)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000930 RID: 2352
		[DispId(3035)]
		int navigateDispid { [DispId(3035)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000931 RID: 2353
		[DispId(3036)]
		string navigateParams { [DispId(3036)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000932 RID: 2354
		[DispId(3037)]
		string navigatePane { [DispId(3037)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x06000933 RID: 2355
		// (set) Token: 0x06000934 RID: 2356
		[DispId(3038)]
		string selectedPane { [DispId(3038)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; [DispId(3038)] [MethodImpl(MethodImplOptions.InternalCall)] [param: MarshalAs(UnmanagedType.BStr)] [param: In] set; }

		// Token: 0x06000935 RID: 2357
		[DispId(3041)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void imethod_0([MarshalAs(UnmanagedType.BStr)] [In] string bstrPane, [In] int lDispid, [MarshalAs(UnmanagedType.BStr)] [In] string bstrParams);

		// Token: 0x06000936 RID: 2358
		[DispId(3042)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.BStr)]
		string imethod_1([MarshalAs(UnmanagedType.IUnknown)] [In] object pObject, [MarshalAs(UnmanagedType.BStr)] [In] string bstrURL);

		// Token: 0x17000348 RID: 840
		// (set) Token: 0x06000937 RID: 2359
		[DispId(3039)]
		int selectedTask { [DispId(3039)] [MethodImpl(MethodImplOptions.InternalCall)] [param: In] set; }

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06000938 RID: 2360
		[DispId(3043)]
		bool contentPartnerSelected { [DispId(3043)] [MethodImpl(MethodImplOptions.InternalCall)] get; }
	}
}
