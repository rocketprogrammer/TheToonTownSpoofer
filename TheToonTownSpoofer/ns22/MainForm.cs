using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns20;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns30;
using ns31;

namespace ns22
{
	// Token: 0x02000372 RID: 882
	internal sealed partial class MainForm : Form0
	{
		// Token: 0x140001A0 RID: 416
		// (add) Token: 0x0600227A RID: 8826 RVA: 0x00075120 File Offset: 0x00073320
		// (remove) Token: 0x0600227B RID: 8827 RVA: 0x00075158 File Offset: 0x00073358
		public event EventHandler MoveToNotificationArea
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

		// Token: 0x140001A1 RID: 417
		// (add) Token: 0x0600227C RID: 8828 RVA: 0x00075190 File Offset: 0x00073390
		// (remove) Token: 0x0600227D RID: 8829 RVA: 0x000751C8 File Offset: 0x000733C8
		public event EventHandler CheckForUpdatesLaunched
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

		// Token: 0x140001A2 RID: 418
		// (add) Token: 0x0600227E RID: 8830 RVA: 0x00075200 File Offset: 0x00073400
		// (remove) Token: 0x0600227F RID: 8831 RVA: 0x00075238 File Offset: 0x00073438
		public event EventHandler MyGalleryLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001A3 RID: 419
		// (add) Token: 0x06002280 RID: 8832 RVA: 0x00075270 File Offset: 0x00073470
		// (remove) Token: 0x06002281 RID: 8833 RVA: 0x000752A8 File Offset: 0x000734A8
		public event EventHandler ContentPacksLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001A4 RID: 420
		// (add) Token: 0x06002282 RID: 8834 RVA: 0x000752E0 File Offset: 0x000734E0
		// (remove) Token: 0x06002283 RID: 8835 RVA: 0x00075318 File Offset: 0x00073518
		public event EventHandler<EventArgs24> HotkeysLaunched
		{
			add
			{
				EventHandler<EventArgs24> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs24> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs24> value2 = (EventHandler<EventArgs24>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs24>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs24> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs24> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs24> value2 = (EventHandler<EventArgs24>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs24>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001A5 RID: 421
		// (add) Token: 0x06002284 RID: 8836 RVA: 0x00075350 File Offset: 0x00073550
		// (remove) Token: 0x06002285 RID: 8837 RVA: 0x00075388 File Offset: 0x00073588
		public event EventHandler GuideLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001A6 RID: 422
		// (add) Token: 0x06002286 RID: 8838 RVA: 0x000753C0 File Offset: 0x000735C0
		// (remove) Token: 0x06002287 RID: 8839 RVA: 0x000753F8 File Offset: 0x000735F8
		public event EventHandler ConnectLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_6;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_6;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001A7 RID: 423
		// (add) Token: 0x06002288 RID: 8840 RVA: 0x00075430 File Offset: 0x00073630
		// (remove) Token: 0x06002289 RID: 8841 RVA: 0x00075468 File Offset: 0x00073668
		public event EventHandler InvasionsLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_7;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_7;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001A8 RID: 424
		// (add) Token: 0x0600228A RID: 8842 RVA: 0x000754A0 File Offset: 0x000736A0
		// (remove) Token: 0x0600228B RID: 8843 RVA: 0x000754D8 File Offset: 0x000736D8
		public event EventHandler GagAMaticLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_8;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_8, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_8;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_8, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001A9 RID: 425
		// (add) Token: 0x0600228C RID: 8844 RVA: 0x00075510 File Offset: 0x00073710
		// (remove) Token: 0x0600228D RID: 8845 RVA: 0x00075548 File Offset: 0x00073748
		public event EventHandler JoeFishLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_9;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_9;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001AA RID: 426
		// (add) Token: 0x0600228E RID: 8846 RVA: 0x00075580 File Offset: 0x00073780
		// (remove) Token: 0x0600228F RID: 8847 RVA: 0x000755B8 File Offset: 0x000737B8
		public event EventHandler GardenerFloraLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_10;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_10;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001AB RID: 427
		// (add) Token: 0x06002290 RID: 8848 RVA: 0x000755F0 File Offset: 0x000737F0
		// (remove) Token: 0x06002291 RID: 8849 RVA: 0x00075628 File Offset: 0x00073828
		public event EventHandler RemoteControlLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_11;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_11, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_11;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_11, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001AC RID: 428
		// (add) Token: 0x06002292 RID: 8850 RVA: 0x00075660 File Offset: 0x00073860
		// (remove) Token: 0x06002293 RID: 8851 RVA: 0x00075698 File Offset: 0x00073898
		public event EventHandler RaceTrackLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_12;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_12, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_12;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_12, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001AD RID: 429
		// (add) Token: 0x06002294 RID: 8852 RVA: 0x000756D0 File Offset: 0x000738D0
		// (remove) Token: 0x06002295 RID: 8853 RVA: 0x00075708 File Offset: 0x00073908
		public event EventHandler OptionsLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_13;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_13, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_13;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_13, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001AE RID: 430
		// (add) Token: 0x06002296 RID: 8854 RVA: 0x00075740 File Offset: 0x00073940
		// (remove) Token: 0x06002297 RID: 8855 RVA: 0x00075778 File Offset: 0x00073978
		public event EventHandler AboutLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_14;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_14, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_14;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_14, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001AF RID: 431
		// (add) Token: 0x06002298 RID: 8856 RVA: 0x000757B0 File Offset: 0x000739B0
		// (remove) Token: 0x06002299 RID: 8857 RVA: 0x000757E8 File Offset: 0x000739E8
		public event EventHandler ReleaseNotesLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_15;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_15, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_15;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_15, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001B0 RID: 432
		// (add) Token: 0x0600229A RID: 8858 RVA: 0x00075820 File Offset: 0x00073A20
		// (remove) Token: 0x0600229B RID: 8859 RVA: 0x00075858 File Offset: 0x00073A58
		public event EventHandler ParTeePuttLaunched
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_16;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_16, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_16;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_16, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600229C RID: 8860 RVA: 0x00075890 File Offset: 0x00073A90
		public MainForm(Class520 mainSpawner)
		{
			this.class520_0 = mainSpawner;
			this.InitializeComponent();
			this.class112_0 = Class110.Instance.ApplicationSettings;
			this.font_0 = new Font("Century", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.rectangle_1 = new Rectangle(111, 111, 64, 64);
			this.rectangle_0 = new Rectangle(62, 62, 164, 48);
			base.SetStyle(ControlStyles.ResizeRedraw, true);
			this.class340_0 = new MainForm.Class340[6];
			this.class340_0[0] = new MainForm.Class340(Class480.VisualMode_03, Class480.VisualMode_Hover_03, new Rectangle(77, 201, 68, 43), new Rectangle(81, 206, 58, 35), new EventHandler(this.method_24));
			this.class340_0[1] = new MainForm.Class340(Class480.VisualMode_04, Class480.VisualMode_Hover_04, new Rectangle(145, 201, 67, 43), new Rectangle(147, 206, 58, 35), new EventHandler(this.method_26));
			this.class340_0[2] = new MainForm.Class340(Class480.VisualMode_07, Class480.VisualMode_Hover_07, new Rectangle(77, 252, 135, 32), new Rectangle(98, 254, 114, 26), new EventHandler(this.method_28));
			this.class340_0[3] = new MainForm.Class340(Class480.VisualMode_Close, Class480.VisualMode_Close_Hover, new Rectangle(228, 13, 23, 23), new Rectangle(228, 13, 23, 23), new EventHandler(this.method_21));
			this.class340_0[4] = new MainForm.Class340(Class480.VisualMode_Restore, Class480.VisualMode_Restore_Hover, new Rectangle(203, 13, 23, 23), new Rectangle(203, 13, 23, 23), new EventHandler(this.method_23));
			this.class340_0[5] = new MainForm.Class340(Class480.VisualMode_Minimize, Class480.VisualMode_Minimize_Hover, new Rectangle(178, 13, 23, 23), new Rectangle(178, 13, 23, 23), new EventHandler(this.method_22));
			this.class134_0 = new MainForm.Class134[16];
			this.class134_0[0] = new MainForm.Class134(Class480.Connect_LargeIcon, "&Connect", Keys.C, new EventHandler(this.method_4));
			this.class134_0[1] = new MainForm.Class134(Class480.Invasions_LargeIcon, "&Invasions", Keys.I, new EventHandler(this.method_5));
			this.class134_0[2] = new MainForm.Class134(Class480.GagAMatic_LargeIcon, "&Gag-A-Matic", Keys.G, new EventHandler(this.method_6));
			this.class134_0[3] = new MainForm.Class134(Class480.JoeFish_LargeIcon, "&Joe Fish", Keys.J, new EventHandler(this.method_7));
			this.class134_0[4] = new MainForm.Class134(Class480.GardenerFlora_LargeIcon, "Gardener &Flora", Keys.F, new EventHandler(this.method_8));
			this.class134_0[5] = new MainForm.Class134(Class480.RemoteController_LargeIcon, "&Remote Control", Keys.R, new EventHandler(this.method_9));
			this.class134_0[6] = new MainForm.Class134(Class480.RaceTrack_LargeIcon, "Race &Track", Keys.T, new EventHandler(this.method_10));
			this.class134_0[7] = new MainForm.Class134(Class480.ParTeePutt_LargeIcon, "ParTee P&utt", Keys.U, new EventHandler(this.method_11));
			this.class134_0[8] = new MainForm.Class134(Class480.MyGallery_LargeIcon, "&My Gallery", Keys.M, new EventHandler(this.method_15));
			this.class134_0[9] = new MainForm.Class134(Class480.ContentPacks_LargeIcon, "Content &Packs", Keys.P, new EventHandler(this.method_12));
			this.class134_1 = (this.class134_0[10] = new MainForm.Class134(Class480.Hotkeys_LargeIcon, this.method_1(), Keys.H, new EventHandler(this.method_19)));
			this.class134_0[11] = new MainForm.Class134(Class480.GenericSettings_LargeIcon, "&Options", Keys.O, new EventHandler(this.method_13));
			this.class134_0[12] = new MainForm.Class134(Class480.Guide_LargeIcon, "Guide (F1)", Keys.F1, new EventHandler(this.method_17));
			this.class134_0[13] = new MainForm.Class134(Class480.ReleaseNotes_LargeIcon, "Release &Notes", Keys.N, new EventHandler(this.method_16));
			this.class134_0[14] = new MainForm.Class134(Class480.Updating_LargeIcon, "Check for Updates", Keys.None, new EventHandler(this.method_18));
			this.class134_0[15] = new MainForm.Class134(Class480.About_LargeIcon, "&About", Keys.A, new EventHandler(this.method_14));
			using (StringFormat stringFormat = MainForm.smethod_2())
			{
				foreach (MainForm.Class134 img in this.class134_0)
				{
					this.method_2(img, stringFormat);
				}
			}
			base.CustomPainting = true;
			this.UseOpacity = true;
			base.AllowFormDrag = true;
			base.StartPosition = FormStartPosition.Manual;
			base.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - base.Width, Screen.PrimaryScreen.WorkingArea.Height - base.Height);
		}

		// Token: 0x0600229D RID: 8861 RVA: 0x0000E895 File Offset: 0x0000CA95
		private string method_1()
		{
			if (this.class112_0.HotkeysEnabled)
			{
				return "Disable &Hotkeys";
			}
			return "Enable &Hotkeys";
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00075DC4 File Offset: 0x00073FC4
		private void method_2(MainForm.Class134 img, StringFormat sf = null)
		{
			bool flag = sf == null;
			try
			{
				if (flag)
				{
					sf = MainForm.smethod_2();
				}
				if (img.image_1 != null)
				{
					img.image_1.Dispose();
				}
				img.image_1 = Class490.smethod_0(img.string_0, this.font_0, Color.FromArgb(7, 54, 109), Color.Honeydew, sf, this.rectangle_0.Size, 6);
			}
			finally
			{
				if (flag)
				{
					sf.Dispose();
				}
			}
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00075E48 File Offset: 0x00074048
		private static StringFormat smethod_2()
		{
			StringFormat stringFormat = null;
			StringFormat result;
			try
			{
				stringFormat = new StringFormat();
				stringFormat.Alignment = StringAlignment.Center;
				stringFormat.LineAlignment = StringAlignment.Center;
				stringFormat.Trimming = StringTrimming.Character;
				stringFormat.HotkeyPrefix = HotkeyPrefix.Show;
				result = stringFormat;
			}
			catch
			{
				if (stringFormat != null)
				{
					stringFormat.Dispose();
				}
				throw;
			}
			return result;
		}

		// Token: 0x060022A0 RID: 8864 RVA: 0x0000E8AF File Offset: 0x0000CAAF
		private void method_3()
		{
			base.Invalidate(this.rectangle_1);
			base.Invalidate(this.rectangle_0);
		}

		// Token: 0x060022A1 RID: 8865 RVA: 0x0000E8C9 File Offset: 0x0000CAC9
		private void method_4(object sender, EventArgs e)
		{
			if (this.eventHandler_6 != null)
			{
				this.eventHandler_6(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022A2 RID: 8866 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		private void method_5(object sender, EventArgs e)
		{
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022A3 RID: 8867 RVA: 0x0000E8FF File Offset: 0x0000CAFF
		private void method_6(object sender, EventArgs e)
		{
			if (this.eventHandler_8 != null)
			{
				this.eventHandler_8(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022A4 RID: 8868 RVA: 0x0000E91A File Offset: 0x0000CB1A
		private void method_7(object sender, EventArgs e)
		{
			if (this.eventHandler_9 != null)
			{
				this.eventHandler_9(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022A5 RID: 8869 RVA: 0x0000E935 File Offset: 0x0000CB35
		private void method_8(object sender, EventArgs e)
		{
			if (this.eventHandler_10 != null)
			{
				this.eventHandler_10(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0000E950 File Offset: 0x0000CB50
		private void method_9(object sender, EventArgs e)
		{
			if (this.eventHandler_11 != null)
			{
				this.eventHandler_11(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x0000E96B File Offset: 0x0000CB6B
		private void method_10(object sender, EventArgs e)
		{
			if (this.eventHandler_12 != null)
			{
				this.eventHandler_12(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x0000E986 File Offset: 0x0000CB86
		private void method_11(object sender, EventArgs e)
		{
			if (this.eventHandler_16 != null)
			{
				this.eventHandler_16(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x0000E9A1 File Offset: 0x0000CBA1
		private void method_12(object sender, EventArgs e)
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x0000E9BC File Offset: 0x0000CBBC
		private void method_13(object sender, EventArgs e)
		{
			if (this.eventHandler_13 != null)
			{
				this.eventHandler_13(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x0000E9D7 File Offset: 0x0000CBD7
		private void method_14(object sender, EventArgs e)
		{
			if (this.eventHandler_14 != null)
			{
				this.eventHandler_14(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x0000E9F2 File Offset: 0x0000CBF2
		private void method_15(object sender, EventArgs e)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x0000EA0D File Offset: 0x0000CC0D
		private void method_16(object sender, EventArgs e)
		{
			if (this.eventHandler_15 != null)
			{
				this.eventHandler_15(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x0000EA28 File Offset: 0x0000CC28
		private void method_17(object sender, EventArgs e)
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x0000EA43 File Offset: 0x0000CC43
		private void method_18(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00075E9C File Offset: 0x0007409C
		private void method_19(object sender, EventArgs e)
		{
			if (this.eventHandler_4 != null)
			{
				EventArgs24 eventArgs = new EventArgs24();
				this.eventHandler_4(this, eventArgs);
				if (eventArgs.HotkeysEnabledStateChangedResult)
				{
					this.class134_1.string_0 = this.method_1();
					this.method_2(this.class134_1, null);
					this.method_3();
				}
			}
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x0000EA5E File Offset: 0x0000CC5E
		public void method_20()
		{
			this.class134_1.string_0 = this.method_1();
			this.method_2(this.class134_1, null);
			if (this.class134_1 == this.class134_0[this.int_0])
			{
				this.method_3();
			}
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x0000EA99 File Offset: 0x0000CC99
		private void method_21(object sender, EventArgs e)
		{
			if (Class509.CanExitTheToonTownSpoofer)
			{
				base.Close();
			}
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00075EF0 File Offset: 0x000740F0
		private void method_22(object sender, EventArgs e)
		{
			bool flag = false;
			foreach (MainForm.Class340 @class in this.class340_0)
			{
				bool flag2 = false;
				if (@class.enum69_0.HasFlag(Enum69.const_2))
				{
					flag2 = true;
					@class.enum69_0 &= (Enum69)(-3);
				}
				if (@class.enum69_0.HasFlag(Enum69.const_1))
				{
					@class.enum69_0 &= (Enum69)(-2);
					flag2 = true;
					this.Cursor = Cursors.Default;
				}
				if (flag2)
				{
					base.Invalidate(@class.rectangle_1);
					flag = true;
				}
			}
			if (flag)
			{
				base.Update();
			}
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x0000EAA8 File Offset: 0x0000CCA8
		private void method_23(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x0000EAC3 File Offset: 0x0000CCC3
		private void method_24(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0000EACB File Offset: 0x0000CCCB
		private void method_25()
		{
			this.int_0--;
			if (this.int_0 < 0)
			{
				this.int_0 = this.class134_0.Length - 1;
			}
			this.method_3();
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x0000EAFA File Offset: 0x0000CCFA
		private void method_26(object sender, EventArgs e)
		{
			this.method_27();
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0000EB02 File Offset: 0x0000CD02
		private void method_27()
		{
			this.int_0++;
			if (this.int_0 >= this.class134_0.Length)
			{
				this.int_0 = 0;
			}
			this.method_3();
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x0000EB2F File Offset: 0x0000CD2F
		private void method_28(object sender, EventArgs e)
		{
			this.method_29();
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0000EB37 File Offset: 0x0000CD37
		private void method_29()
		{
			this.class134_0[this.int_0].method_4();
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x00075FA0 File Offset: 0x000741A0
		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Return)
			{
				switch (keyCode)
				{
				case Keys.Left:
					this.method_25();
					return;
				case Keys.Right:
					this.method_27();
					return;
				}
				for (int i = 0; i < this.class134_0.Length; i++)
				{
					MainForm.Class134 @class = this.class134_0[i];
					if (@class.keys_0 == e.KeyCode)
					{
						this.int_0 = i;
						this.method_3();
						@class.method_4();
						return;
					}
				}
				return;
			}
			this.method_29();
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00055BCC File Offset: 0x00053DCC
		private void MainForm_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			switch (e.KeyCode)
			{
			case Keys.Left:
			case Keys.Right:
				e.IsInputKey = true;
				break;
			case Keys.Up:
				break;
			default:
				return;
			}
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00076028 File Offset: 0x00074228
		protected override void OnMouseMove(MouseEventArgs e)
		{
			bool flag = false;
			foreach (MainForm.Class340 @class in this.class340_0)
			{
				if (@class.enum69_0.HasFlag(Enum69.const_2))
				{
					flag = true;
					IL_3C:
					if (!flag)
					{
						foreach (MainForm.Class340 class2 in this.class340_0)
						{
							if (class2.rectangle_0.Contains(e.Location))
							{
								if (!class2.enum69_0.HasFlag(Enum69.const_1))
								{
									class2.enum69_0 |= Enum69.const_1;
									base.Invalidate(class2.rectangle_1);
									this.Cursor = Cursors.Hand;
									flag = true;
								}
							}
							else if (class2.enum69_0.HasFlag(Enum69.const_1))
							{
								class2.enum69_0 &= (Enum69)(-2);
								base.Invalidate(class2.rectangle_1);
								if (!flag)
								{
									this.Cursor = Cursors.Default;
								}
							}
						}
					}
					base.OnMouseMove(e);
					return;
				}
			}
			goto IL_3C;
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x0007613C File Offset: 0x0007433C
		protected override void OnMouseDown(MouseEventArgs e)
		{
			bool flag = false;
			foreach (MainForm.Class340 @class in this.class340_0)
			{
				if (@class.enum69_0.HasFlag(Enum69.const_1))
				{
					flag = true;
					@class.enum69_0 |= Enum69.const_2;
					IL_45:
					if (!flag)
					{
						base.OnMouseDown(e);
					}
					return;
				}
			}
			goto IL_45;
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x00076198 File Offset: 0x00074398
		protected override void OnMouseUp(MouseEventArgs e)
		{
			bool flag = false;
			foreach (MainForm.Class340 @class in this.class340_0)
			{
				if (@class.enum69_0.HasFlag(Enum69.const_2))
				{
					flag = true;
					@class.enum69_0 &= (Enum69)(-3);
					if (@class.enum69_0.HasFlag(Enum69.const_1))
					{
						@class.method_0();
					}
					IL_64:
					if (!flag)
					{
						base.OnMouseUp(e);
					}
					return;
				}
			}
			goto IL_64;
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00076214 File Offset: 0x00074414
		protected override void vmethod_0(Graphics gr)
		{
			gr.SmoothingMode = SmoothingMode.HighQuality;
			gr.InterpolationMode = InterpolationMode.HighQualityBilinear;
			gr.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
			gr.DrawImage(Class480.VisualMode_01, new Rectangle(0, 0, 295, 201));
			gr.DrawImage(Class480.VisualMode_02, new Rectangle(0, 201, 77, 83));
			foreach (MainForm.Class340 @class in this.class340_0)
			{
				Enum69 enum69_ = @class.enum69_0;
				if (enum69_ == Enum69.const_1)
				{
					if (@class.image_1 != null)
					{
						gr.DrawImage(@class.image_1, @class.rectangle_1);
					}
				}
				else if (@class.image_0 != null)
				{
					gr.DrawImage(@class.image_0, @class.rectangle_1);
				}
			}
			gr.DrawImage(Class480.VisualMode_05, new Rectangle(212, 201, 83, 83));
			gr.DrawImage(Class480.VisualMode_06, new Rectangle(77, 244, 135, 8));
			gr.DrawImage(Class480.VisualMode_08, new Rectangle(0, 284, 295, 58));
			MainForm.Class134 class2 = this.class134_0[this.int_0];
			gr.DrawImage(class2.image_0, this.rectangle_1);
			gr.DrawImage(class2.image_1, new Rectangle(new Point(this.rectangle_0.smethod_10() - class2.image_1.Width / 2, this.rectangle_0.smethod_11() - class2.image_1.Height / 2), class2.image_1.Size));
			gr.DrawImage(Class480.VisualMode_Screen_Overlay, new Rectangle(58, 46, 173, 108));
			base.vmethod_0(gr);
		}

		// Token: 0x04000FD8 RID: 4056
		private EventHandler eventHandler_0;

		// Token: 0x04000FD9 RID: 4057
		private EventHandler eventHandler_1;

		// Token: 0x04000FDA RID: 4058
		private EventHandler eventHandler_2;

		// Token: 0x04000FDB RID: 4059
		private EventHandler eventHandler_3;

		// Token: 0x04000FDC RID: 4060
		private EventHandler<EventArgs24> eventHandler_4;

		// Token: 0x04000FDD RID: 4061
		private EventHandler eventHandler_5;

		// Token: 0x04000FDE RID: 4062
		private Class112 class112_0;

		// Token: 0x04000FDF RID: 4063
		private EventHandler eventHandler_6;

		// Token: 0x04000FE0 RID: 4064
		private EventHandler eventHandler_7;

		// Token: 0x04000FE1 RID: 4065
		private EventHandler eventHandler_8;

		// Token: 0x04000FE2 RID: 4066
		private EventHandler eventHandler_9;

		// Token: 0x04000FE3 RID: 4067
		private EventHandler eventHandler_10;

		// Token: 0x04000FE4 RID: 4068
		private EventHandler eventHandler_11;

		// Token: 0x04000FE5 RID: 4069
		private EventHandler eventHandler_12;

		// Token: 0x04000FE6 RID: 4070
		private EventHandler eventHandler_13;

		// Token: 0x04000FE7 RID: 4071
		private EventHandler eventHandler_14;

		// Token: 0x04000FE8 RID: 4072
		private EventHandler eventHandler_15;

		// Token: 0x04000FE9 RID: 4073
		private EventHandler eventHandler_16;

		// Token: 0x04000FEA RID: 4074
		private MainForm.Class340[] class340_0;

		// Token: 0x04000FEB RID: 4075
		private readonly Class520 class520_0;

		// Token: 0x04000FEE RID: 4078
		private readonly Rectangle rectangle_0;

		// Token: 0x04000FEF RID: 4079
		private readonly Rectangle rectangle_1;

		// Token: 0x04000FF0 RID: 4080
		private readonly MainForm.Class134 class134_1;

		// Token: 0x04000FF1 RID: 4081
		private int int_0;

		// Token: 0x02000373 RID: 883
		private sealed class Class134 : Class123
		{
			// Token: 0x140001B1 RID: 433
			// (add) Token: 0x060022C1 RID: 8897 RVA: 0x000763B8 File Offset: 0x000745B8
			// (remove) Token: 0x060022C2 RID: 8898 RVA: 0x000763F0 File Offset: 0x000745F0
			public event EventHandler LaunchClicked
			{
				add
				{
					EventHandler eventHandler = this.eventHandler_2;
					EventHandler eventHandler2;
					do
					{
						eventHandler2 = eventHandler;
						EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
						eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
					}
					while (eventHandler != eventHandler2);
				}
				remove
				{
					EventHandler eventHandler = this.eventHandler_2;
					EventHandler eventHandler2;
					do
					{
						eventHandler2 = eventHandler;
						EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
						eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
					}
					while (eventHandler != eventHandler2);
				}
			}

			// Token: 0x060022C3 RID: 8899 RVA: 0x0000EB4B File Offset: 0x0000CD4B
			public Class134(Image normalImage, string text, Keys hotkey, EventHandler launchClicked)
			{
				this.image_0 = normalImage;
				this.string_0 = text;
				this.keys_0 = hotkey;
				this.eventHandler_2 = launchClicked;
			}

			// Token: 0x060022C4 RID: 8900 RVA: 0x0000EB70 File Offset: 0x0000CD70
			protected override void vmethod_0()
			{
				if (this.image_1 != null)
				{
					this.image_1.Dispose();
				}
				base.vmethod_0();
			}

			// Token: 0x060022C5 RID: 8901 RVA: 0x0000EB8B File Offset: 0x0000CD8B
			public void method_4()
			{
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2(this, EventArgs.Empty);
				}
			}

			// Token: 0x04000FF2 RID: 4082
			public Image image_0;

			// Token: 0x04000FF3 RID: 4083
			private EventHandler eventHandler_2;

			// Token: 0x04000FF4 RID: 4084
			public string string_0;

			// Token: 0x04000FF5 RID: 4085
			public Image image_1;

			// Token: 0x04000FF6 RID: 4086
			public Keys keys_0;
		}

		// Token: 0x02000374 RID: 884
		private sealed class Class340
		{
			// Token: 0x140001B2 RID: 434
			// (add) Token: 0x060022C6 RID: 8902 RVA: 0x00076428 File Offset: 0x00074628
			// (remove) Token: 0x060022C7 RID: 8903 RVA: 0x00076460 File Offset: 0x00074660
			public event EventHandler ButtonClicked
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

			// Token: 0x060022C8 RID: 8904 RVA: 0x0000EBA6 File Offset: 0x0000CDA6
			public Class340(Image normalImage, Image hoverImage, Rectangle imageBounds, Rectangle mouseBounds, EventHandler clicked)
			{
				this.rectangle_0 = mouseBounds;
				this.rectangle_1 = imageBounds;
				this.image_1 = hoverImage;
				this.image_0 = normalImage;
				this.eventHandler_0 = clicked;
			}

			// Token: 0x060022C9 RID: 8905 RVA: 0x0000EBD3 File Offset: 0x0000CDD3
			public void method_0()
			{
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, EventArgs.Empty);
				}
			}

			// Token: 0x04000FF7 RID: 4087
			public Enum69 enum69_0;

			// Token: 0x04000FF8 RID: 4088
			public Rectangle rectangle_0;

			// Token: 0x04000FF9 RID: 4089
			public Image image_0;

			// Token: 0x04000FFA RID: 4090
			public Image image_1;

			// Token: 0x04000FFB RID: 4091
			public Rectangle rectangle_1;

			// Token: 0x04000FFC RID: 4092
			private EventHandler eventHandler_0;
		}
	}
}
