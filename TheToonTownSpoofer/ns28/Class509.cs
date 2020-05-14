using System;
using System.Threading;
using ns15;
using ns17;

namespace ns28
{
	// Token: 0x020004B5 RID: 1205
	internal static class Class509
	{
		// Token: 0x140001E9 RID: 489
		// (add) Token: 0x06002D2D RID: 11565 RVA: 0x000AE3B4 File Offset: 0x000AC5B4
		// (remove) Token: 0x06002D2E RID: 11566 RVA: 0x000AE3E8 File Offset: 0x000AC5E8
		public static event EventHandler InstallingOrLoggingInCompleted
		{
			add
			{
				EventHandler eventHandler = Class509.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class509.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = Class509.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class509.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x000AE41C File Offset: 0x000AC61C
		private static bool smethod_0(Class509.Enum126 comp, bool value)
		{
			if (value)
			{
				if (!Class509.enum126_0.HasFlag(comp))
				{
					Class509.enum126_0 |= comp;
					return true;
				}
			}
			else if (Class509.enum126_0.HasFlag(comp))
			{
				Class509.enum126_0 &= ~comp;
				return true;
			}
			return false;
		}

		// Token: 0x17000B2A RID: 2858
		// (get) Token: 0x06002D30 RID: 11568 RVA: 0x0001588E File Offset: 0x00013A8E
		// (set) Token: 0x06002D31 RID: 11569 RVA: 0x000158A5 File Offset: 0x00013AA5
		public static bool MyGalleryOpen
		{
			get
			{
				return Class509.enum126_0.HasFlag(Class509.Enum126.flag_4);
			}
			set
			{
				Class509.smethod_0(Class509.Enum126.flag_4, value);
			}
		}

		// Token: 0x17000B2B RID: 2859
		// (get) Token: 0x06002D32 RID: 11570 RVA: 0x000158AF File Offset: 0x00013AAF
		// (set) Token: 0x06002D33 RID: 11571 RVA: 0x000158C6 File Offset: 0x00013AC6
		public static bool ContentPacksOpen
		{
			get
			{
				return Class509.enum126_0.HasFlag(Class509.Enum126.flag_1);
			}
			set
			{
				Class509.smethod_0(Class509.Enum126.flag_1, value);
			}
		}

		// Token: 0x17000B2C RID: 2860
		// (get) Token: 0x06002D34 RID: 11572 RVA: 0x000158D0 File Offset: 0x00013AD0
		// (set) Token: 0x06002D35 RID: 11573 RVA: 0x000158E7 File Offset: 0x00013AE7
		public static bool MakePackageOpen
		{
			get
			{
				return Class509.enum126_0.HasFlag(Class509.Enum126.flag_2);
			}
			set
			{
				Class509.smethod_0(Class509.Enum126.flag_2, value);
			}
		}

		// Token: 0x17000B2D RID: 2861
		// (get) Token: 0x06002D36 RID: 11574 RVA: 0x000158F1 File Offset: 0x00013AF1
		// (set) Token: 0x06002D37 RID: 11575 RVA: 0x00015908 File Offset: 0x00013B08
		public static bool InstallingOrLoggingIn
		{
			get
			{
				return Class509.enum126_0.HasFlag(Class509.Enum126.flag_3);
			}
			set
			{
				if (Class509.smethod_0(Class509.Enum126.flag_3, value) && !value && Class509.eventHandler_0 != null)
				{
					Class509.eventHandler_0(null, EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000B2E RID: 2862
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x0001592D File Offset: 0x00013B2D
		public static bool CanOpenContentPacksOrOpenDialog
		{
			get
			{
				if (Class509.InstallingOrLoggingIn)
				{
					DialogBox.smethod_3("Please wait until you are not logging into, or playing ToonTown before opening the Content Packs window.", "Try again later.");
					return false;
				}
				if (Class156.smethod_2("toontown") > 0)
				{
					DialogBox.smethod_3("Please close ToonTown before changing Content Packs.", "Close ToonTown first.");
					return false;
				}
				return true;
			}
		}

		// Token: 0x17000B2F RID: 2863
		// (get) Token: 0x06002D39 RID: 11577 RVA: 0x00015966 File Offset: 0x00013B66
		public static bool CanExitTheToonTownSpoofer
		{
			get
			{
				if (Class509.InstallingOrLoggingIn)
				{
					DialogBox.smethod_3("Please wait until installation has completed or abort installation before exiting The ToonTown Spoofer.", "Install In Progress");
					return false;
				}
				return true;
			}
		}

		// Token: 0x17000B30 RID: 2864
		// (get) Token: 0x06002D3A RID: 11578 RVA: 0x00015981 File Offset: 0x00013B81
		public static bool CanOpenMakePackageOrDialog
		{
			get
			{
				if (Class509.InstallingOrLoggingIn)
				{
					DialogBox.smethod_3("Please wait until you are not logging into, or playing ToonTown before opening the MakePackage window.", "Try again later.");
					return false;
				}
				if (Class156.smethod_2("toontown") > 0)
				{
					DialogBox.smethod_3("Please close ToonTown before opening MakePackage.", "Close ToonTown first.");
					return false;
				}
				return true;
			}
		}

		// Token: 0x17000B31 RID: 2865
		// (get) Token: 0x06002D3B RID: 11579 RVA: 0x000159BA File Offset: 0x00013BBA
		public static bool CanLoginToToonTownOrDialog
		{
			get
			{
				if (Class509.MakePackageOpen)
				{
					DialogBox.smethod_3("Please close MakePackage and the Content Pack window before logging into ToonTown.", "Close MakePackage first.");
					return false;
				}
				if (Class509.ContentPacksOpen)
				{
					DialogBox.smethod_3("Please close the Content Packs window before logging into ToonTown.", "Close Content Packs first.");
					return false;
				}
				return true;
			}
		}

		// Token: 0x17000B32 RID: 2866
		// (get) Token: 0x06002D3C RID: 11580 RVA: 0x000159ED File Offset: 0x00013BED
		public static bool CanChangeScreenshotDirectory
		{
			get
			{
				if (Class509.MyGalleryOpen)
				{
					DialogBox.smethod_3("Please close My Gallery before attempting to change the screenshot directory.", "Close My Gallery first.");
					return false;
				}
				return true;
			}
		}

		// Token: 0x17000B33 RID: 2867
		// (get) Token: 0x06002D3D RID: 11581 RVA: 0x000AE478 File Offset: 0x000AC678
		public static bool CanOpenUpdater
		{
			get
			{
				if (Class509.InstallingOrLoggingIn)
				{
					DialogBox.smethod_3("Please wait until installation has completed or abort installation before attempting to update The ToonTown Spoofer.", "Install In Progress");
					return false;
				}
				if (Class509.MyGalleryOpen)
				{
					DialogBox.smethod_3("Please close My Gallery before attempting to update The ToonTown Spoofer.", "Close My Gallery first.");
					return false;
				}
				if (Class509.MakePackageOpen)
				{
					DialogBox.smethod_3("Please close MakePackage and the Content Pack window before attempting to update The ToonTown Spoofer.", "Close MakePackage first.");
					return false;
				}
				if (Class509.ContentPacksOpen)
				{
					DialogBox.smethod_3("Please close the Content Packs window before attempting to update The ToonTown Spoofer.", "Close Content Packs first.");
					return false;
				}
				return true;
			}
		}

		// Token: 0x17000B34 RID: 2868
		// (get) Token: 0x06002D3E RID: 11582 RVA: 0x00015A08 File Offset: 0x00013C08
		public static bool CanChangeVirtualServerPort
		{
			get
			{
				if (Class509.InstallingOrLoggingIn)
				{
					DialogBox.smethod_3("Please wait until installation has completed or abort installation before attempting to change the port used for Content Packs.", "Install In Progress");
					return false;
				}
				if (Class156.smethod_2("toontown") > 0)
				{
					DialogBox.smethod_3("Please close ToonTown before attempting to change the port used for Content Packs.", "Close ToonTown first.");
					return false;
				}
				return true;
			}
		}

		// Token: 0x040017AC RID: 6060
		private static EventHandler eventHandler_0;

		// Token: 0x040017AD RID: 6061
		private static Class509.Enum126 enum126_0 = Class509.Enum126.flag_0;

		// Token: 0x020004B6 RID: 1206
		[Flags]
		private enum Enum126
		{
			// Token: 0x040017AF RID: 6063
			flag_0 = 0,
			// Token: 0x040017B0 RID: 6064
			flag_1 = 1,
			// Token: 0x040017B1 RID: 6065
			flag_2 = 2,
			// Token: 0x040017B2 RID: 6066
			flag_3 = 4,
			// Token: 0x040017B3 RID: 6067
			flag_4 = 8
		}
	}
}
