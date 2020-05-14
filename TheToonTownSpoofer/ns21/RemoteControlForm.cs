using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns15;
using ns16;
using ns20;
using ns26;
using ns31;

namespace ns21
{
	// Token: 0x02000248 RID: 584
	internal partial class RemoteControlForm : Form0
	{
		// Token: 0x14000179 RID: 377
		// (add) Token: 0x060018FB RID: 6395 RVA: 0x00044B8C File Offset: 0x00042D8C
		// (remove) Token: 0x060018FC RID: 6396 RVA: 0x00044BC4 File Offset: 0x00042DC4
		public event EventHandler SetupClicked
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400017A RID: 378
		// (add) Token: 0x060018FD RID: 6397 RVA: 0x00044BFC File Offset: 0x00042DFC
		// (remove) Token: 0x060018FE RID: 6398 RVA: 0x00044C34 File Offset: 0x00042E34
		public event EventHandler CloseClicked
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x00044C6C File Offset: 0x00042E6C
		public RemoteControlForm()
		{
			this.InitializeComponent();
			base.CustomPainting = true;
			this.class443_0 = new Class443<Image>(23);
			this.class443_1 = new Class443<Rectangle>(8);
			this.enum25_0 = Enum25.const_0;
			base.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
			this.class141_0 = new Class141();
			Class141 @class = this.class141_0;
			EventHandler value = new EventHandler(this.method_19);
			@class.ProcessExited += value;
			this.class141_1 = new Class141();
			Class141 class2 = this.class141_1;
			EventHandler value2 = new EventHandler(this.method_20);
			class2.ProcessExited += value2;
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06001902 RID: 6402 RVA: 0x000083AD File Offset: 0x000065AD
		// (set) Token: 0x06001903 RID: 6403 RVA: 0x000083BA File Offset: 0x000065BA
		public IntPtr FirstToonTownWindow
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return this.class141_0.MainWindowHandle;
			}
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				if (this.class141_0.MainWindowHandle != value)
				{
					this.method_14();
					this.class141_0.MainWindowHandle = value;
				}
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06001904 RID: 6404 RVA: 0x000083E1 File Offset: 0x000065E1
		// (set) Token: 0x06001905 RID: 6405 RVA: 0x000083EE File Offset: 0x000065EE
		public IntPtr SecondToonTownWindow
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return this.class141_1.MainWindowHandle;
			}
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				if (this.class141_1.MainWindowHandle != value)
				{
					this.method_15();
					this.class141_1.MainWindowHandle = value;
				}
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x06001906 RID: 6406 RVA: 0x00008415 File Offset: 0x00006615
		// (set) Token: 0x06001907 RID: 6407 RVA: 0x00008428 File Offset: 0x00006628
		[Description("The left controller image boundary.")]
		[Category("Bounds")]
		public Rectangle LeftControllerBounds
		{
			get
			{
				return this.class443_1[RemoteControlForm.Enum35.const_0];
			}
			set
			{
				this.class443_1[RemoteControlForm.Enum35.const_0] = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0000843C File Offset: 0x0000663C
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0000844F File Offset: 0x0000664F
		[Category("Bounds")]
		[Description("The right controller image boundary.")]
		public Rectangle RightControllerBounds
		{
			get
			{
				return this.class443_1[RemoteControlForm.Enum35.const_1];
			}
			set
			{
				this.class443_1[RemoteControlForm.Enum35.const_1] = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600190A RID: 6410 RVA: 0x00008463 File Offset: 0x00006663
		// (set) Token: 0x0600190B RID: 6411 RVA: 0x00008476 File Offset: 0x00006676
		[Category("Bounds")]
		[Description("The left blue image boundary.")]
		public Rectangle LeftBlueBounds
		{
			get
			{
				return this.class443_1[RemoteControlForm.Enum35.const_2];
			}
			set
			{
				this.class443_1[RemoteControlForm.Enum35.const_2] = value;
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x0600190C RID: 6412 RVA: 0x0000848A File Offset: 0x0000668A
		// (set) Token: 0x0600190D RID: 6413 RVA: 0x0000849D File Offset: 0x0000669D
		[Description("The top yellow image boundary.")]
		[Category("Bounds")]
		public Rectangle TopYellowBounds
		{
			get
			{
				return this.class443_1[RemoteControlForm.Enum35.const_3];
			}
			set
			{
				this.class443_1[RemoteControlForm.Enum35.const_3] = value;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x0600190E RID: 6414 RVA: 0x000084B1 File Offset: 0x000066B1
		// (set) Token: 0x0600190F RID: 6415 RVA: 0x000084C4 File Offset: 0x000066C4
		[Category("Bounds")]
		[Description("The bottom green image boundary.")]
		public Rectangle BottomGreenBounds
		{
			get
			{
				return this.class443_1[RemoteControlForm.Enum35.const_5];
			}
			set
			{
				this.class443_1[RemoteControlForm.Enum35.const_5] = value;
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x06001910 RID: 6416 RVA: 0x000084D8 File Offset: 0x000066D8
		// (set) Token: 0x06001911 RID: 6417 RVA: 0x000084EB File Offset: 0x000066EB
		[Description("The right red image boundary.")]
		[Category("Bounds")]
		public Rectangle RightRedBounds
		{
			get
			{
				return this.class443_1[RemoteControlForm.Enum35.const_4];
			}
			set
			{
				this.class443_1[RemoteControlForm.Enum35.const_4] = value;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x06001912 RID: 6418 RVA: 0x000084FF File Offset: 0x000066FF
		// (set) Token: 0x06001913 RID: 6419 RVA: 0x00008512 File Offset: 0x00006712
		[Category("Bounds")]
		[Description("The setup image boundary.")]
		public Rectangle SetupBounds
		{
			get
			{
				return this.class443_1[RemoteControlForm.Enum35.const_6];
			}
			set
			{
				if (this.class443_1[RemoteControlForm.Enum35.const_6] != value)
				{
					this.method_10();
					this.class443_1[RemoteControlForm.Enum35.const_6] = value;
					this.method_10();
				}
			}
		}

		// Token: 0x1700076B RID: 1899
		// (get) Token: 0x06001914 RID: 6420 RVA: 0x0000854B File Offset: 0x0000674B
		// (set) Token: 0x06001915 RID: 6421 RVA: 0x0000855E File Offset: 0x0000675E
		[Category("Bounds")]
		[Description("The close image boundary.")]
		public Rectangle CloseBounds
		{
			get
			{
				return this.class443_1[RemoteControlForm.Enum35.const_7];
			}
			set
			{
				if (this.class443_1[RemoteControlForm.Enum35.const_7] != value)
				{
					this.method_11();
					this.class443_1[RemoteControlForm.Enum35.const_7] = value;
					this.method_11();
				}
			}
		}

		// Token: 0x1700076C RID: 1900
		// (get) Token: 0x06001916 RID: 6422 RVA: 0x00008597 File Offset: 0x00006797
		// (set) Token: 0x06001917 RID: 6423 RVA: 0x000085AA File Offset: 0x000067AA
		[DefaultValue(typeof(Image), null)]
		[Category("Images")]
		[Description("The left controller image pointing left.")]
		public Image LeftController_LeftImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_4];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_4] = value;
			}
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001918 RID: 6424 RVA: 0x000085BE File Offset: 0x000067BE
		// (set) Token: 0x06001919 RID: 6425 RVA: 0x000085D1 File Offset: 0x000067D1
		[Category("Images")]
		[Description("The left controller image pointing up.")]
		[DefaultValue(typeof(Image), null)]
		public Image LeftController_TopImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_2];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_2] = value;
			}
		}

		// Token: 0x1700076E RID: 1902
		// (get) Token: 0x0600191A RID: 6426 RVA: 0x000085E5 File Offset: 0x000067E5
		// (set) Token: 0x0600191B RID: 6427 RVA: 0x000085F8 File Offset: 0x000067F8
		[Description("The left controller image pointing to the top left.")]
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		public Image LeftController_TopLeftImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_1];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_1] = value;
			}
		}

		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x0600191C RID: 6428 RVA: 0x0000860C File Offset: 0x0000680C
		// (set) Token: 0x0600191D RID: 6429 RVA: 0x0000861F File Offset: 0x0000681F
		[DefaultValue(typeof(Image), null)]
		[Description("The left controller image pointing to the top right.")]
		[Category("Images")]
		public Image LeftController_TopRightImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_3];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_3] = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x0600191E RID: 6430 RVA: 0x00008633 File Offset: 0x00006833
		// (set) Token: 0x0600191F RID: 6431 RVA: 0x00008646 File Offset: 0x00006846
		[Description("The left controller image pointing to the right.")]
		[DefaultValue(typeof(Image), null)]
		[Category("Images")]
		public Image LeftController_RightImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_5];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_5] = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x06001920 RID: 6432 RVA: 0x0000865A File Offset: 0x0000685A
		// (set) Token: 0x06001921 RID: 6433 RVA: 0x0000866D File Offset: 0x0000686D
		[Description("The left controller image pointing to the bottom left.")]
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		public Image LeftController_BottomLeftImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_6];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_6] = value;
			}
		}

		// Token: 0x17000772 RID: 1906
		// (get) Token: 0x06001922 RID: 6434 RVA: 0x00008681 File Offset: 0x00006881
		// (set) Token: 0x06001923 RID: 6435 RVA: 0x00008694 File Offset: 0x00006894
		[Description("The left controller image pointing to the bottom right.")]
		[DefaultValue(typeof(Image), null)]
		[Category("Images")]
		public Image LeftController_BottomRightImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_8];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_8] = value;
			}
		}

		// Token: 0x17000773 RID: 1907
		// (get) Token: 0x06001924 RID: 6436 RVA: 0x000086A8 File Offset: 0x000068A8
		// (set) Token: 0x06001925 RID: 6437 RVA: 0x000086BB File Offset: 0x000068BB
		[Description("The left controller image pointing to the bottom.")]
		[DefaultValue(typeof(Image), null)]
		[Category("Images")]
		public Image LeftController_BottomImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_7];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_7] = value;
			}
		}

		// Token: 0x17000774 RID: 1908
		// (get) Token: 0x06001926 RID: 6438 RVA: 0x000086CF File Offset: 0x000068CF
		// (set) Token: 0x06001927 RID: 6439 RVA: 0x000086E3 File Offset: 0x000068E3
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		[Description("The right controller image pointing left.")]
		public Image RightController_LeftImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_12];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_12] = value;
			}
		}

		// Token: 0x17000775 RID: 1909
		// (get) Token: 0x06001928 RID: 6440 RVA: 0x000086F8 File Offset: 0x000068F8
		// (set) Token: 0x06001929 RID: 6441 RVA: 0x0000870C File Offset: 0x0000690C
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		[Description("The right controller image pointing up.")]
		public Image RightController_TopImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_10];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_10] = value;
			}
		}

		// Token: 0x17000776 RID: 1910
		// (get) Token: 0x0600192A RID: 6442 RVA: 0x00008721 File Offset: 0x00006921
		// (set) Token: 0x0600192B RID: 6443 RVA: 0x00008735 File Offset: 0x00006935
		[DefaultValue(typeof(Image), null)]
		[Description("The right controller image pointing to the top left.")]
		[Category("Images")]
		public Image RightController_TopLeftImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_9];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_9] = value;
			}
		}

		// Token: 0x17000777 RID: 1911
		// (get) Token: 0x0600192C RID: 6444 RVA: 0x0000874A File Offset: 0x0000694A
		// (set) Token: 0x0600192D RID: 6445 RVA: 0x0000875E File Offset: 0x0000695E
		[Description("The right controller image pointing to the top right.")]
		[DefaultValue(typeof(Image), null)]
		[Category("Images")]
		public Image RightController_TopRightImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_11];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_11] = value;
			}
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x0600192E RID: 6446 RVA: 0x00008773 File Offset: 0x00006973
		// (set) Token: 0x0600192F RID: 6447 RVA: 0x00008787 File Offset: 0x00006987
		[Description("The right controller image pointing to the right.")]
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		public Image RightController_RightImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_13];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_13] = value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001930 RID: 6448 RVA: 0x0000879C File Offset: 0x0000699C
		// (set) Token: 0x06001931 RID: 6449 RVA: 0x000087B0 File Offset: 0x000069B0
		[DefaultValue(typeof(Image), null)]
		[Description("The right controller image pointing to the bottom left.")]
		[Category("Images")]
		public Image RightController_BottomLeftImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_14];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_14] = value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001932 RID: 6450 RVA: 0x000087C5 File Offset: 0x000069C5
		// (set) Token: 0x06001933 RID: 6451 RVA: 0x000087D9 File Offset: 0x000069D9
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		[Description("The right controller image pointing to the bottom right.")]
		public Image RightController_BottomRightImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_16];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_16] = value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x000087EE File Offset: 0x000069EE
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x00008802 File Offset: 0x00006A02
		[Description("The right controller image pointing to the bottom.")]
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		public Image RightController_BottomImage
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_15];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_15] = value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x00008817 File Offset: 0x00006A17
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0000882B File Offset: 0x00006A2B
		[Description("The top yellow down pressed.")]
		[DefaultValue(typeof(Image), null)]
		[Category("Images")]
		public Image TopYellow_Image
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_18];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_18] = value;
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x00008840 File Offset: 0x00006A40
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x00008854 File Offset: 0x00006A54
		[Category("Images")]
		[Description("The left blue down pressed.")]
		[DefaultValue(typeof(Image), null)]
		public Image LeftBlue_Image
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_17];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_17] = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x00008869 File Offset: 0x00006A69
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0000887D File Offset: 0x00006A7D
		[Category("Images")]
		[Description("The right red down pressed.")]
		[DefaultValue(typeof(Image), null)]
		public Image RightRed_Image
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_19];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_19] = value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x00008892 File Offset: 0x00006A92
		// (set) Token: 0x0600193D RID: 6461 RVA: 0x000088A6 File Offset: 0x00006AA6
		[Category("Images")]
		[Description("The bottom green down pressed.")]
		[DefaultValue(typeof(Image), null)]
		public Image BottomGreen_Image
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_20];
			}
			set
			{
				this.class443_0[RemoteControlForm.Enum34.const_20] = value;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600193E RID: 6462 RVA: 0x000088BB File Offset: 0x00006ABB
		// (set) Token: 0x0600193F RID: 6463 RVA: 0x000088CF File Offset: 0x00006ACF
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		[Description("The setup button.")]
		public Image Setup_Image
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_21];
			}
			set
			{
				if (this.class443_0[RemoteControlForm.Enum34.const_21] != value)
				{
					this.class443_0[RemoteControlForm.Enum34.const_21] = value;
					this.method_10();
				}
			}
		}

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001940 RID: 6464 RVA: 0x000088FF File Offset: 0x00006AFF
		// (set) Token: 0x06001941 RID: 6465 RVA: 0x00008913 File Offset: 0x00006B13
		[Description("The close button.")]
		[Category("Images")]
		[DefaultValue(typeof(Image), null)]
		public Image Close_Image
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_22];
			}
			set
			{
				if (this.class443_0[RemoteControlForm.Enum34.const_22] != value)
				{
					this.class443_0[RemoteControlForm.Enum34.const_22] = value;
					this.method_11();
				}
			}
		}

		// Token: 0x17000782 RID: 1922
		// (get) Token: 0x06001942 RID: 6466 RVA: 0x00008943 File Offset: 0x00006B43
		// (set) Token: 0x06001943 RID: 6467 RVA: 0x00008956 File Offset: 0x00006B56
		[Description("The background controller with opacity.")]
		[DefaultValue(typeof(Image), null)]
		[Category("Images")]
		public Image Background
		{
			get
			{
				return this.class443_0[RemoteControlForm.Enum34.const_0];
			}
			set
			{
				if (this.class443_0[RemoteControlForm.Enum34.const_0] != value)
				{
					this.class443_0[RemoteControlForm.Enum34.const_0] = value;
					if (value != null)
					{
						base.ClientSize = value.Size;
					}
					base.Invalidate();
				}
			}
		}

		// Token: 0x17000783 RID: 1923
		// (get) Token: 0x06001944 RID: 6468 RVA: 0x00008993 File Offset: 0x00006B93
		// (set) Token: 0x06001945 RID: 6469 RVA: 0x00044D80 File Offset: 0x00042F80
		private bool ADown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_7);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_7))
					{
						this.method_12(true, Keys.Left);
						if (this.bool_7)
						{
							this.method_4();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_7))
				{
					this.method_13(true, Keys.Left);
					if (this.bool_7)
					{
						this.method_4();
					}
				}
			}
		}

		// Token: 0x17000784 RID: 1924
		// (get) Token: 0x06001946 RID: 6470 RVA: 0x0000899D File Offset: 0x00006B9D
		// (set) Token: 0x06001947 RID: 6471 RVA: 0x00044DD4 File Offset: 0x00042FD4
		private bool SpaceDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_5);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_5))
					{
						this.method_12(true, Keys.ControlKey);
						this.method_12(false, Keys.ControlKey);
						if (this.bool_7)
						{
							this.method_9();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_5))
				{
					this.method_13(true, Keys.ControlKey);
					this.method_13(false, Keys.ControlKey);
					if (this.bool_7)
					{
						this.method_9();
					}
				}
			}
		}

		// Token: 0x17000785 RID: 1925
		// (get) Token: 0x06001948 RID: 6472 RVA: 0x000089A7 File Offset: 0x00006BA7
		// (set) Token: 0x06001949 RID: 6473 RVA: 0x00044E3C File Offset: 0x0004303C
		private bool ShiftDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_3);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_3))
					{
						this.method_12(true, Keys.ControlKey);
						if (this.bool_7)
						{
							this.method_9();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_3))
				{
					this.method_13(true, Keys.ControlKey);
					if (this.bool_7)
					{
						this.method_9();
					}
				}
			}
		}

		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x0600194A RID: 6474 RVA: 0x000089B0 File Offset: 0x00006BB0
		// (set) Token: 0x0600194B RID: 6475 RVA: 0x00044E90 File Offset: 0x00043090
		private bool ControlDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_4);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_4))
					{
						this.method_12(false, Keys.ControlKey);
						if (this.bool_7)
						{
							this.method_9();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_4))
				{
					this.method_13(false, Keys.ControlKey);
					if (this.bool_7)
					{
						this.method_9();
					}
				}
			}
		}

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600194C RID: 6476 RVA: 0x000089B9 File Offset: 0x00006BB9
		// (set) Token: 0x0600194D RID: 6477 RVA: 0x00044EE4 File Offset: 0x000430E4
		private bool DDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_9);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_9))
					{
						this.method_12(true, Keys.Right);
						if (this.bool_7)
						{
							this.method_4();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_9))
				{
					this.method_13(true, Keys.Right);
					if (this.bool_7)
					{
						this.method_4();
					}
				}
			}
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600194E RID: 6478 RVA: 0x000089C6 File Offset: 0x00006BC6
		// (set) Token: 0x0600194F RID: 6479 RVA: 0x00044F40 File Offset: 0x00043140
		private bool WDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_6);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_6))
					{
						this.method_12(true, Keys.Up);
						if (this.bool_7)
						{
							this.method_4();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_6))
				{
					this.method_13(true, Keys.Up);
					if (this.bool_7)
					{
						this.method_4();
					}
				}
			}
		}

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x06001950 RID: 6480 RVA: 0x000089D0 File Offset: 0x00006BD0
		// (set) Token: 0x06001951 RID: 6481 RVA: 0x00044F94 File Offset: 0x00043194
		private bool SDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_8);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_8))
					{
						this.method_12(true, Keys.Down);
						if (this.bool_7)
						{
							this.method_4();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_8))
				{
					this.method_13(true, Keys.Down);
					if (this.bool_7)
					{
						this.method_4();
					}
				}
			}
		}

		// Token: 0x1700078A RID: 1930
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x000089DD File Offset: 0x00006BDD
		// (set) Token: 0x06001953 RID: 6483 RVA: 0x00044FF0 File Offset: 0x000431F0
		private bool LeftDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_14);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_14))
					{
						this.method_12(false, Keys.Left);
						if (this.bool_7)
						{
							this.method_5();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_14))
				{
					this.method_13(false, Keys.Left);
					if (this.bool_7)
					{
						this.method_5();
					}
				}
			}
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x06001954 RID: 6484 RVA: 0x000089EA File Offset: 0x00006BEA
		// (set) Token: 0x06001955 RID: 6485 RVA: 0x0004504C File Offset: 0x0004324C
		private bool RightDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_16);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_16))
					{
						this.method_12(false, Keys.Right);
						if (this.bool_7)
						{
							this.method_5();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_16))
				{
					this.method_13(false, Keys.Right);
					if (this.bool_7)
					{
						this.method_5();
					}
				}
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06001956 RID: 6486 RVA: 0x000089F7 File Offset: 0x00006BF7
		// (set) Token: 0x06001957 RID: 6487 RVA: 0x000450A8 File Offset: 0x000432A8
		private bool UpDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_13);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_13))
					{
						this.method_12(false, Keys.Up);
						if (this.bool_7)
						{
							this.method_5();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_13))
				{
					this.method_13(false, Keys.Up);
					if (this.bool_7)
					{
						this.method_5();
					}
				}
			}
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06001958 RID: 6488 RVA: 0x00008A04 File Offset: 0x00006C04
		// (set) Token: 0x06001959 RID: 6489 RVA: 0x00045104 File Offset: 0x00043304
		private bool DownDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_15);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_15))
					{
						this.method_12(false, Keys.Down);
						if (this.bool_7)
						{
							this.method_5();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_15))
				{
					this.method_13(false, Keys.Down);
					if (this.bool_7)
					{
						this.method_5();
					}
				}
			}
		}

		// Token: 0x1700078E RID: 1934
		// (get) Token: 0x0600195A RID: 6490 RVA: 0x00008A11 File Offset: 0x00006C11
		// (set) Token: 0x0600195B RID: 6491 RVA: 0x00045160 File Offset: 0x00043360
		private bool XDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_11);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_11))
					{
						this.method_12(false, Keys.Escape);
						if (this.bool_7)
						{
							this.method_6();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_11))
				{
					this.method_13(false, Keys.Escape);
					if (this.bool_7)
					{
						this.method_6();
					}
				}
			}
		}

		// Token: 0x1700078F RID: 1935
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x00008A1E File Offset: 0x00006C1E
		// (set) Token: 0x0600195D RID: 6493 RVA: 0x000451BC File Offset: 0x000433BC
		private bool ZDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_10);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_10))
					{
						this.method_12(true, Keys.Escape);
						if (this.bool_7)
						{
							this.method_6();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_10))
				{
					this.method_13(true, Keys.Escape);
					if (this.bool_7)
					{
						this.method_6();
					}
				}
			}
		}

		// Token: 0x17000790 RID: 1936
		// (get) Token: 0x0600195E RID: 6494 RVA: 0x00008A2B File Offset: 0x00006C2B
		// (set) Token: 0x0600195F RID: 6495 RVA: 0x00045218 File Offset: 0x00043418
		private bool CDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_12);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_12))
					{
						this.method_12(true, Keys.Escape);
						this.method_12(false, Keys.Escape);
						if (this.bool_7)
						{
							this.method_6();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_12))
				{
					this.method_13(true, Keys.Escape);
					this.method_13(false, Keys.Escape);
					if (this.bool_7)
					{
						this.method_6();
					}
				}
			}
		}

		// Token: 0x17000791 RID: 1937
		// (get) Token: 0x06001960 RID: 6496 RVA: 0x00008A38 File Offset: 0x00006C38
		// (set) Token: 0x06001961 RID: 6497 RVA: 0x00045284 File Offset: 0x00043484
		private bool EVDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_1);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_1))
					{
						this.method_12(true, Keys.Delete);
						if (this.bool_7)
						{
							this.method_7();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_1))
				{
					this.method_13(true, Keys.Delete);
					if (this.bool_7)
					{
						this.method_7();
					}
				}
			}
		}

		// Token: 0x17000792 RID: 1938
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00008A41 File Offset: 0x00006C41
		// (set) Token: 0x06001963 RID: 6499 RVA: 0x000452D8 File Offset: 0x000434D8
		private bool NumPad0EndDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_2);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_2))
					{
						this.method_12(false, Keys.Delete);
						if (this.bool_7)
						{
							this.method_7();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_2))
				{
					this.method_13(false, Keys.Delete);
					if (this.bool_7)
					{
						this.method_7();
					}
				}
			}
		}

		// Token: 0x17000793 RID: 1939
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00008A4A File Offset: 0x00006C4A
		// (set) Token: 0x06001965 RID: 6501 RVA: 0x0004532C File Offset: 0x0004352C
		private bool QDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_17);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_17))
					{
						this.method_12(true, Keys.Home);
						if (this.bool_7)
						{
							this.method_8();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_17))
				{
					this.method_13(true, Keys.Home);
					if (this.bool_7)
					{
						this.method_8();
					}
				}
			}
		}

		// Token: 0x17000794 RID: 1940
		// (get) Token: 0x06001966 RID: 6502 RVA: 0x00008A57 File Offset: 0x00006C57
		// (set) Token: 0x06001967 RID: 6503 RVA: 0x00045388 File Offset: 0x00043588
		private bool ForwardSlashQuestionMarkDown
		{
			get
			{
				return this.method_1(RemoteControlForm.Enum33.flag_18);
			}
			set
			{
				if (value)
				{
					if (this.method_2(RemoteControlForm.Enum33.flag_18))
					{
						this.method_12(false, Keys.Home);
						if (this.bool_7)
						{
							this.method_8();
							return;
						}
					}
				}
				else if (this.method_3(RemoteControlForm.Enum33.flag_18))
				{
					this.method_13(false, Keys.Home);
					if (this.bool_7)
					{
						this.method_8();
					}
				}
			}
		}

		// Token: 0x17000795 RID: 1941
		// (get) Token: 0x06001968 RID: 6504 RVA: 0x00008A64 File Offset: 0x00006C64
		// (set) Token: 0x06001969 RID: 6505 RVA: 0x00008A6C File Offset: 0x00006C6C
		public bool AnimateController
		{
			get
			{
				return this.bool_7;
			}
			set
			{
				if (this.bool_7 != value)
				{
					this.bool_7 = value;
					if (!this.UseOpacity || base.DesignMode)
					{
						base.Invalidate();
						return;
					}
					base.method_0();
				}
			}
		}

		// Token: 0x17000796 RID: 1942
		// (get) Token: 0x0600196A RID: 6506 RVA: 0x00008A9D File Offset: 0x00006C9D
		// (set) Token: 0x0600196B RID: 6507 RVA: 0x00008AA5 File Offset: 0x00006CA5
		public override bool UseOpacity
		{
			get
			{
				return base.UseOpacity;
			}
			set
			{
				if (base.UseOpacity != value)
				{
					base.UseOpacity = value;
					if (base.UseOpacity)
					{
						base.FormBorderStyle = FormBorderStyle.None;
						return;
					}
					base.FormBorderStyle = FormBorderStyle.FixedSingle;
				}
			}
		}

		// Token: 0x17000797 RID: 1943
		// (get) Token: 0x0600196C RID: 6508 RVA: 0x00008ACE File Offset: 0x00006CCE
		// (set) Token: 0x0600196D RID: 6509 RVA: 0x00008AD6 File Offset: 0x00006CD6
		public Enum84 KeyboardLayout { get; set; }

		// Token: 0x0600196E RID: 6510 RVA: 0x00008ADF File Offset: 0x00006CDF
		private bool method_1(RemoteControlForm.Enum33 flag)
		{
			return this.enum33_0.HasFlag(flag);
		}

		// Token: 0x0600196F RID: 6511 RVA: 0x00008AF7 File Offset: 0x00006CF7
		private bool method_2(RemoteControlForm.Enum33 flag)
		{
			if (!this.method_1(flag))
			{
				this.enum33_0 |= flag;
				return true;
			}
			return false;
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00008B13 File Offset: 0x00006D13
		private bool method_3(RemoteControlForm.Enum33 flag)
		{
			if (this.method_1(flag))
			{
				this.enum33_0 &= ~flag;
				return true;
			}
			return false;
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00008B30 File Offset: 0x00006D30
		private void method_4()
		{
			if (this.UseOpacity && !base.DesignMode)
			{
				base.method_0();
			}
			else if (this.LeftControllerBounds.smethod_2())
			{
				base.Invalidate(this.LeftControllerBounds);
				return;
			}
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00008B64 File Offset: 0x00006D64
		private void method_5()
		{
			if (this.UseOpacity && !base.DesignMode)
			{
				base.method_0();
			}
			else if (this.RightControllerBounds.smethod_2())
			{
				base.Invalidate(this.RightControllerBounds);
				return;
			}
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00008B98 File Offset: 0x00006D98
		private void method_6()
		{
			if (this.UseOpacity && !base.DesignMode)
			{
				base.method_0();
			}
			else if (this.TopYellowBounds.smethod_2())
			{
				base.Invalidate(this.TopYellowBounds);
				return;
			}
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00008BCC File Offset: 0x00006DCC
		private void method_7()
		{
			if (this.UseOpacity && !base.DesignMode)
			{
				base.method_0();
			}
			else if (this.RightRedBounds.smethod_2())
			{
				base.Invalidate(this.RightRedBounds);
				return;
			}
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00008C00 File Offset: 0x00006E00
		private void method_8()
		{
			if (this.UseOpacity && !base.DesignMode)
			{
				base.method_0();
			}
			else if (this.BottomGreenBounds.smethod_2())
			{
				base.Invalidate(this.BottomGreenBounds);
				return;
			}
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x00008C34 File Offset: 0x00006E34
		private void method_9()
		{
			if (this.UseOpacity && !base.DesignMode)
			{
				base.method_0();
			}
			else if (this.LeftBlueBounds.smethod_2())
			{
				base.Invalidate(this.LeftBlueBounds);
				return;
			}
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00008C68 File Offset: 0x00006E68
		private void method_10()
		{
			if (this.UseOpacity && !base.DesignMode)
			{
				base.method_0();
			}
			else if (this.SetupBounds.smethod_2())
			{
				base.Invalidate(this.SetupBounds);
				return;
			}
		}

		// Token: 0x06001978 RID: 6520 RVA: 0x00008C9C File Offset: 0x00006E9C
		private void method_11()
		{
			if (this.UseOpacity && !base.DesignMode)
			{
				base.method_0();
			}
			else if (this.CloseBounds.smethod_2())
			{
				base.Invalidate(this.CloseBounds);
				return;
			}
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x000453E4 File Offset: 0x000435E4
		protected override void vmethod_0(Graphics gr)
		{
			if (this.Background != null)
			{
				gr.DrawImage(this.Background, base.ClientRectangle);
			}
			if (this.bool_7)
			{
				if (this.LeftControllerBounds.smethod_2())
				{
					if (this.ADown && this.WDown)
					{
						if (this.LeftController_TopLeftImage != null)
						{
							gr.DrawImage(this.LeftController_TopLeftImage, this.LeftControllerBounds);
						}
					}
					else if (this.DDown && this.WDown)
					{
						if (this.LeftController_TopRightImage != null)
						{
							gr.DrawImage(this.LeftController_TopRightImage, this.LeftControllerBounds);
						}
					}
					else if (this.ADown && this.SDown)
					{
						if (this.LeftController_BottomLeftImage != null)
						{
							gr.DrawImage(this.LeftController_BottomLeftImage, this.LeftControllerBounds);
						}
					}
					else if (this.DDown && this.SDown)
					{
						if (this.LeftController_BottomRightImage != null)
						{
							gr.DrawImage(this.LeftController_BottomRightImage, this.LeftControllerBounds);
						}
					}
					else if (this.ADown)
					{
						if (this.LeftController_LeftImage != null)
						{
							gr.DrawImage(this.LeftController_LeftImage, this.LeftControllerBounds);
						}
					}
					else if (this.DDown)
					{
						if (this.LeftController_RightImage != null)
						{
							gr.DrawImage(this.LeftController_RightImage, this.LeftControllerBounds);
						}
					}
					else if (this.WDown)
					{
						if (this.LeftController_TopImage != null)
						{
							gr.DrawImage(this.LeftController_TopImage, this.LeftControllerBounds);
						}
					}
					else if (this.SDown && this.LeftController_BottomImage != null)
					{
						gr.DrawImage(this.LeftController_BottomImage, this.LeftControllerBounds);
					}
				}
				if (this.RightControllerBounds.smethod_2())
				{
					if (this.LeftDown && this.UpDown)
					{
						if (this.RightController_TopLeftImage != null)
						{
							gr.DrawImage(this.RightController_TopLeftImage, this.RightControllerBounds);
						}
					}
					else if (this.RightDown && this.UpDown)
					{
						if (this.RightController_TopRightImage != null)
						{
							gr.DrawImage(this.RightController_TopRightImage, this.RightControllerBounds);
						}
					}
					else if (this.LeftDown && this.DownDown)
					{
						if (this.RightController_BottomLeftImage != null)
						{
							gr.DrawImage(this.RightController_BottomLeftImage, this.RightControllerBounds);
						}
					}
					else if (this.RightDown && this.DownDown)
					{
						if (this.RightController_BottomRightImage != null)
						{
							gr.DrawImage(this.RightController_BottomRightImage, this.RightControllerBounds);
						}
					}
					else if (this.LeftDown)
					{
						if (this.RightController_LeftImage != null)
						{
							gr.DrawImage(this.RightController_LeftImage, this.RightControllerBounds);
						}
					}
					else if (this.RightDown)
					{
						if (this.RightController_RightImage != null)
						{
							gr.DrawImage(this.RightController_RightImage, this.RightControllerBounds);
						}
					}
					else if (this.UpDown)
					{
						if (this.RightController_TopImage != null)
						{
							gr.DrawImage(this.RightController_TopImage, this.RightControllerBounds);
						}
					}
					else if (this.DownDown && this.RightController_BottomImage != null)
					{
						gr.DrawImage(this.RightController_BottomImage, this.RightControllerBounds);
					}
				}
				if (this.TopYellowBounds.smethod_2() && (this.ZDown || this.XDown || this.CDown) && this.TopYellow_Image != null)
				{
					gr.DrawImage(this.TopYellow_Image, this.TopYellowBounds);
				}
				if (this.LeftBlueBounds.smethod_2() && (this.ShiftDown || this.ControlDown || this.SpaceDown) && this.LeftBlue_Image != null)
				{
					gr.DrawImage(this.LeftBlue_Image, this.LeftBlueBounds);
				}
				if (this.RightRedBounds.smethod_2() && (this.EVDown || this.NumPad0EndDown) && this.RightRed_Image != null)
				{
					gr.DrawImage(this.RightRed_Image, this.RightRedBounds);
				}
				if (this.BottomGreenBounds.smethod_2() && (this.QDown || this.ForwardSlashQuestionMarkDown) && this.BottomGreen_Image != null)
				{
					gr.DrawImage(this.BottomGreen_Image, this.BottomGreenBounds);
				}
			}
			if (this.float_1 > 0f)
			{
				if (this.CloseBounds.smethod_2() && this.Close_Image != null)
				{
					gr.smethod_0(this.Close_Image, this.CloseBounds, this.float_1 + (this.bool_5 ? 0.5f : 0f));
				}
				if (this.SetupBounds.smethod_2() && this.Setup_Image != null)
				{
					gr.smethod_0(this.Setup_Image, this.SetupBounds, this.float_1 + (this.bool_6 ? 0.5f : 0f));
				}
			}
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00045864 File Offset: 0x00043A64
		private void method_12(bool leftController, Keys key)
		{
			IntPtr intPtr = leftController ? this.class141_0.MainWindowHandle : this.class141_1.MainWindowHandle;
			if (intPtr != IntPtr.Zero)
			{
				Class465.smethod_13(intPtr, key);
			}
		}

		// Token: 0x0600197B RID: 6523 RVA: 0x000458A4 File Offset: 0x00043AA4
		private void method_13(bool leftController, Keys key)
		{
			IntPtr intPtr = leftController ? this.class141_0.MainWindowHandle : this.class141_1.MainWindowHandle;
			if (intPtr != IntPtr.Zero)
			{
				Class465.smethod_14(intPtr, key);
			}
		}

		// Token: 0x0600197C RID: 6524 RVA: 0x00008CD0 File Offset: 0x00006ED0
		protected override void OnKeyDown(KeyEventArgs e)
		{
			this.method_18(true, e);
			base.OnKeyDown(e);
		}

		// Token: 0x0600197D RID: 6525 RVA: 0x00008CE1 File Offset: 0x00006EE1
		protected override void OnKeyUp(KeyEventArgs e)
		{
			this.method_18(false, e);
			base.OnKeyUp(e);
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00008CF2 File Offset: 0x00006EF2
		private void method_14()
		{
			this.ADown = false;
			this.WDown = false;
			this.DDown = false;
			this.SDown = false;
			this.ZDown = false;
			this.EVDown = false;
			this.ShiftDown = false;
			this.QDown = false;
			this.method_16();
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00008D32 File Offset: 0x00006F32
		private void method_15()
		{
			this.UpDown = false;
			this.LeftDown = false;
			this.RightDown = false;
			this.DownDown = false;
			this.XDown = false;
			this.ControlDown = false;
			this.NumPad0EndDown = false;
			this.ForwardSlashQuestionMarkDown = false;
			this.method_16();
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00008D72 File Offset: 0x00006F72
		private void method_16()
		{
			this.CDown = false;
			this.SpaceDown = false;
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x000458E4 File Offset: 0x00043AE4
		private Keys method_17(Keys key)
		{
			switch (this.KeyboardLayout)
			{
			default:
				return key;
			case Enum84.const_1:
				if (key <= Keys.Q)
				{
					if (key == Keys.A)
					{
						return Keys.Q;
					}
					if (key == Keys.M)
					{
						return Keys.OemSemicolon;
					}
					if (key == Keys.Q)
					{
						return Keys.A;
					}
				}
				else if (key <= Keys.Z)
				{
					if (key == Keys.W)
					{
						return Keys.Z;
					}
					if (key == Keys.Z)
					{
						return Keys.W;
					}
				}
				else
				{
					switch (key)
					{
					case Keys.OemSemicolon:
						return Keys.OemCloseBrackets;
					case Keys.Oemplus:
					case Keys.OemMinus:
						break;
					case Keys.Oemcomma:
						return Keys.M;
					case Keys.OemPeriod:
						return Keys.Oemcomma;
					case Keys.OemQuestion:
						return Keys.OemPeriod;
					case Keys.Oemtilde:
						return Keys.OemQuotes;
					default:
						switch (key)
						{
						case Keys.OemCloseBrackets:
							return Keys.OemOpenBrackets;
						case Keys.Oem8:
							return Keys.OemQuestion;
						}
						break;
					}
				}
				return key;
			case Enum84.const_2:
				switch (key)
				{
				case Keys.Y:
					return Keys.Z;
				case Keys.Z:
					return Keys.Y;
				default:
					switch (key)
					{
					case Keys.OemSemicolon:
						return Keys.OemOpenBrackets;
					case Keys.Oemplus:
						return Keys.OemCloseBrackets;
					case Keys.OemMinus:
						return Keys.OemQuestion;
					case Keys.Oemtilde:
						return Keys.OemSemicolon;
					}
					return key;
				}
				break;
			}
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00045A10 File Offset: 0x00043C10
		private void method_18(bool keyDown, KeyEventArgs e)
		{
			Keys keys = this.method_17(e.KeyCode);
			if (keys <= Keys.E)
			{
				switch (keys)
				{
				case Keys.ShiftKey:
					if (this.class141_0.ProcessOpen)
					{
						this.ShiftDown = keyDown;
						return;
					}
					return;
				case Keys.ControlKey:
					if (this.class141_1.ProcessOpen)
					{
						this.ControlDown = keyDown;
						return;
					}
					return;
				default:
					switch (keys)
					{
					case Keys.Space:
						if (this.class141_0.ProcessOpen || this.class141_1.ProcessOpen)
						{
							this.SpaceDown = keyDown;
							return;
						}
						return;
					case Keys.Prior:
					case Keys.Next:
					case Keys.Home:
						return;
					case Keys.End:
						break;
					case Keys.Left:
						if (this.class141_1.ProcessOpen)
						{
							this.LeftDown = keyDown;
							return;
						}
						return;
					case Keys.Up:
						if (this.class141_0.ProcessOpen)
						{
							this.UpDown = keyDown;
							return;
						}
						return;
					case Keys.Right:
						if (this.class141_1.ProcessOpen)
						{
							this.RightDown = keyDown;
							return;
						}
						return;
					case Keys.Down:
						if (this.class141_1.ProcessOpen)
						{
							this.DownDown = keyDown;
							return;
						}
						return;
					default:
						switch (keys)
						{
						case Keys.A:
							if (this.class141_0.ProcessOpen)
							{
								this.ADown = keyDown;
								return;
							}
							return;
						case Keys.B:
							return;
						case Keys.C:
							if (this.class141_0.ProcessOpen || this.class141_1.ProcessOpen)
							{
								this.CDown = keyDown;
								return;
							}
							return;
						case Keys.D:
							if (this.class141_0.ProcessOpen)
							{
								this.DDown = keyDown;
								return;
							}
							return;
						case Keys.E:
							goto IL_218;
						default:
							return;
						}
						break;
					}
					break;
				}
			}
			else
			{
				switch (keys)
				{
				case Keys.Q:
					if (this.class141_0.ProcessOpen)
					{
						this.QDown = keyDown;
						return;
					}
					return;
				case Keys.R:
				case Keys.T:
				case Keys.U:
				case Keys.Y:
					return;
				case Keys.S:
					if (this.class141_0.ProcessOpen)
					{
						this.SDown = keyDown;
						return;
					}
					return;
				case Keys.V:
					goto IL_218;
				case Keys.W:
					if (this.class141_0.ProcessOpen)
					{
						this.WDown = keyDown;
						return;
					}
					return;
				case Keys.X:
					if (this.class141_1.ProcessOpen)
					{
						this.XDown = keyDown;
						return;
					}
					return;
				case Keys.Z:
					if (this.class141_0.ProcessOpen)
					{
						this.ZDown = keyDown;
						return;
					}
					return;
				default:
					if (keys != Keys.NumPad0)
					{
						if (keys != Keys.OemQuestion)
						{
							return;
						}
						if (this.class141_1.ProcessOpen)
						{
							this.ForwardSlashQuestionMarkDown = keyDown;
							return;
						}
						return;
					}
					break;
				}
			}
			if (this.class141_1.ProcessOpen)
			{
				this.NumPad0EndDown = keyDown;
				return;
			}
			return;
			IL_218:
			if (this.class141_0.ProcessOpen)
			{
				this.EVDown = keyDown;
				return;
			}
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x00008D82 File Offset: 0x00006F82
		protected override void OnLostFocus(EventArgs e)
		{
			this.method_14();
			this.method_15();
			base.OnLostFocus(e);
		}

		// Token: 0x06001984 RID: 6532 RVA: 0x00045C8C File Offset: 0x00043E8C
		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (!base.DesignMode)
			{
				Screen screen = Screen.FromControl(this);
				base.Location = new Point(screen.WorkingArea.X + screen.WorkingArea.Width / 2 - base.Width / 2, screen.WorkingArea.Y + screen.WorkingArea.Height - base.Height);
			}
		}

		// Token: 0x06001985 RID: 6533 RVA: 0x00045D08 File Offset: 0x00043F08
		private void timer_0_Tick(object sender, EventArgs e)
		{
			switch (this.enum25_0)
			{
			case Enum25.const_1:
				this.float_1 += RemoteControlForm.float_0;
				if (this.float_1 >= 0.5f)
				{
					this.float_1 = 0.5f;
					this.enum25_0 = Enum25.const_3;
					this.timer_0.Enabled = false;
				}
				if (this.UseOpacity && !base.DesignMode)
				{
					base.method_0();
					return;
				}
				this.method_10();
				this.method_11();
				return;
			case Enum25.const_2:
				this.float_1 -= RemoteControlForm.float_0;
				if (this.float_1 <= 0f)
				{
					this.float_1 = 0f;
					this.enum25_0 = Enum25.const_0;
					this.timer_0.Enabled = false;
				}
				if (this.UseOpacity && !base.DesignMode)
				{
					base.method_0();
					return;
				}
				this.method_10();
				this.method_11();
				return;
			default:
				this.timer_0.Enabled = false;
				return;
			}
		}

		// Token: 0x06001986 RID: 6534 RVA: 0x00045DFC File Offset: 0x00043FFC
		protected override void OnMouseLeave(EventArgs e)
		{
			switch (this.enum25_0)
			{
			case Enum25.const_1:
			case Enum25.const_3:
				this.enum25_0 = Enum25.const_2;
				this.timer_0.Enabled = true;
				break;
			}
			base.OnMouseLeave(e);
		}

		// Token: 0x06001987 RID: 6535 RVA: 0x00045E40 File Offset: 0x00044040
		protected override void OnMouseEnter(EventArgs e)
		{
			switch (this.enum25_0)
			{
			case Enum25.const_0:
			case Enum25.const_2:
				this.enum25_0 = Enum25.const_1;
				this.timer_0.Enabled = true;
				break;
			}
			base.OnMouseEnter(e);
		}

		// Token: 0x06001988 RID: 6536 RVA: 0x00045E84 File Offset: 0x00044084
		protected override void OnMouseMove(MouseEventArgs e)
		{
			if (this.SetupBounds.Contains(e.Location))
			{
				if (!this.bool_6)
				{
					this.bool_6 = true;
					this.method_10();
					this.Cursor = Cursors.Hand;
					if (this.bool_5)
					{
						this.bool_5 = false;
						this.method_11();
					}
				}
			}
			else if (this.CloseBounds.Contains(e.Location))
			{
				if (!this.bool_5)
				{
					this.bool_5 = true;
					this.method_11();
					this.Cursor = Cursors.Hand;
					if (this.bool_6)
					{
						this.bool_6 = false;
						this.method_10();
					}
				}
			}
			else if (this.bool_5)
			{
				this.bool_5 = false;
				this.method_11();
				this.Cursor = Cursors.Default;
			}
			else if (this.bool_6)
			{
				this.bool_6 = false;
				this.method_10();
				this.Cursor = Cursors.Default;
			}
			base.OnMouseMove(e);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x00008D97 File Offset: 0x00006F97
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (!this.bool_6 && !this.bool_5)
			{
				base.OnMouseDown(e);
			}
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x00045F80 File Offset: 0x00044180
		protected override void OnMouseUp(MouseEventArgs e)
		{
			if (this.bool_6)
			{
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, EventArgs.Empty);
					return;
				}
			}
			else if (this.bool_5)
			{
				if (this.eventHandler_1 != null)
				{
					this.eventHandler_1(this, EventArgs.Empty);
					return;
				}
			}
			else
			{
				base.OnMouseUp(e);
			}
		}

		// Token: 0x0600198B RID: 6539 RVA: 0x00008DB0 File Offset: 0x00006FB0
		[CompilerGenerated]
		private void method_19(object sender, EventArgs e)
		{
			this.method_14();
		}

		// Token: 0x0600198C RID: 6540 RVA: 0x00008DB8 File Offset: 0x00006FB8
		[CompilerGenerated]
		private void method_20(object sender, EventArgs e)
		{
			this.method_15();
		}

		// Token: 0x040006CB RID: 1739
		private static readonly float float_0 = 0.04f;

		// Token: 0x040006CC RID: 1740
		private EventHandler eventHandler_0;

		// Token: 0x040006CD RID: 1741
		private EventHandler eventHandler_1;

		// Token: 0x040006CE RID: 1742
		private Class443<Image> class443_0;

		// Token: 0x040006D1 RID: 1745
		private Class443<Rectangle> class443_1;

		// Token: 0x040006D2 RID: 1746
		private Enum25 enum25_0;

		// Token: 0x040006D3 RID: 1747
		private float float_1;

		// Token: 0x040006D4 RID: 1748
		private bool bool_5;

		// Token: 0x040006D5 RID: 1749
		private bool bool_6;

		// Token: 0x040006D8 RID: 1752
		private RemoteControlForm.Enum33 enum33_0;

		// Token: 0x040006D9 RID: 1753
		private bool bool_7;

		// Token: 0x040006DA RID: 1754
		[CompilerGenerated]
		private Enum84 enum84_0;

		// Token: 0x02000249 RID: 585
		[Flags]
		private enum Enum33
		{
			// Token: 0x040006DC RID: 1756
			flag_0 = 0,
			// Token: 0x040006DD RID: 1757
			flag_1 = 1,
			// Token: 0x040006DE RID: 1758
			flag_2 = 2,
			// Token: 0x040006DF RID: 1759
			flag_3 = 4,
			// Token: 0x040006E0 RID: 1760
			flag_4 = 8,
			// Token: 0x040006E1 RID: 1761
			flag_5 = 16,
			// Token: 0x040006E2 RID: 1762
			flag_6 = 32,
			// Token: 0x040006E3 RID: 1763
			flag_7 = 64,
			// Token: 0x040006E4 RID: 1764
			flag_8 = 128,
			// Token: 0x040006E5 RID: 1765
			flag_9 = 256,
			// Token: 0x040006E6 RID: 1766
			flag_10 = 512,
			// Token: 0x040006E7 RID: 1767
			flag_11 = 1024,
			// Token: 0x040006E8 RID: 1768
			flag_12 = 2048,
			// Token: 0x040006E9 RID: 1769
			flag_13 = 4096,
			// Token: 0x040006EA RID: 1770
			flag_14 = 8192,
			// Token: 0x040006EB RID: 1771
			flag_15 = 16384,
			// Token: 0x040006EC RID: 1772
			flag_16 = 32768,
			// Token: 0x040006ED RID: 1773
			flag_17 = 65536,
			// Token: 0x040006EE RID: 1774
			flag_18 = 131072
		}

		// Token: 0x0200024A RID: 586
		private enum Enum34
		{
			// Token: 0x040006F0 RID: 1776
			const_0,
			// Token: 0x040006F1 RID: 1777
			const_1,
			// Token: 0x040006F2 RID: 1778
			const_2,
			// Token: 0x040006F3 RID: 1779
			const_3,
			// Token: 0x040006F4 RID: 1780
			const_4,
			// Token: 0x040006F5 RID: 1781
			const_5,
			// Token: 0x040006F6 RID: 1782
			const_6,
			// Token: 0x040006F7 RID: 1783
			const_7,
			// Token: 0x040006F8 RID: 1784
			const_8,
			// Token: 0x040006F9 RID: 1785
			const_9,
			// Token: 0x040006FA RID: 1786
			const_10,
			// Token: 0x040006FB RID: 1787
			const_11,
			// Token: 0x040006FC RID: 1788
			const_12,
			// Token: 0x040006FD RID: 1789
			const_13,
			// Token: 0x040006FE RID: 1790
			const_14,
			// Token: 0x040006FF RID: 1791
			const_15,
			// Token: 0x04000700 RID: 1792
			const_16,
			// Token: 0x04000701 RID: 1793
			const_17,
			// Token: 0x04000702 RID: 1794
			const_18,
			// Token: 0x04000703 RID: 1795
			const_19,
			// Token: 0x04000704 RID: 1796
			const_20,
			// Token: 0x04000705 RID: 1797
			const_21,
			// Token: 0x04000706 RID: 1798
			const_22
		}

		// Token: 0x0200024B RID: 587
		private enum Enum35
		{
			// Token: 0x04000708 RID: 1800
			const_0,
			// Token: 0x04000709 RID: 1801
			const_1,
			// Token: 0x0400070A RID: 1802
			const_2,
			// Token: 0x0400070B RID: 1803
			const_3,
			// Token: 0x0400070C RID: 1804
			const_4,
			// Token: 0x0400070D RID: 1805
			const_5,
			// Token: 0x0400070E RID: 1806
			const_6,
			// Token: 0x0400070F RID: 1807
			const_7
		}
	}
}
