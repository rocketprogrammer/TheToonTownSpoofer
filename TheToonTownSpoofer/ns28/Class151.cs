using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns16;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns30;
using TSN.wyUpdate.Controls;

namespace ns28
{
	// Token: 0x020004B7 RID: 1207
	internal sealed class Class151 : Class123
	{
		// Token: 0x140001EA RID: 490
		// (add) Token: 0x06002D40 RID: 11584 RVA: 0x000AE4E8 File Offset: 0x000AC6E8
		// (remove) Token: 0x06002D41 RID: 11585 RVA: 0x000AE520 File Offset: 0x000AC720
		public event EventHandler<EventArgs40> BeforeChecking
		{
			add
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001EB RID: 491
		// (add) Token: 0x06002D42 RID: 11586 RVA: 0x000AE558 File Offset: 0x000AC758
		// (remove) Token: 0x06002D43 RID: 11587 RVA: 0x000AE590 File Offset: 0x000AC790
		public event EventHandler<EventArgs40> BeforeDownloading
		{
			add
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001EC RID: 492
		// (add) Token: 0x06002D44 RID: 11588 RVA: 0x000AE5C8 File Offset: 0x000AC7C8
		// (remove) Token: 0x06002D45 RID: 11589 RVA: 0x000AE600 File Offset: 0x000AC800
		public event EventHandler<EventArgs40> BeforeExtracting
		{
			add
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001ED RID: 493
		// (add) Token: 0x06002D46 RID: 11590 RVA: 0x000AE638 File Offset: 0x000AC838
		// (remove) Token: 0x06002D47 RID: 11591 RVA: 0x000AE670 File Offset: 0x000AC870
		public event EventHandler Canceled
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

		// Token: 0x140001EE RID: 494
		// (add) Token: 0x06002D48 RID: 11592 RVA: 0x000AE6A8 File Offset: 0x000AC8A8
		// (remove) Token: 0x06002D49 RID: 11593 RVA: 0x000AE6E0 File Offset: 0x000AC8E0
		public event EventHandler<EventArgs26> CheckingFailed
		{
			add
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_6;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_6;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001EF RID: 495
		// (add) Token: 0x06002D4A RID: 11594 RVA: 0x000AE718 File Offset: 0x000AC918
		// (remove) Token: 0x06002D4B RID: 11595 RVA: 0x000AE750 File Offset: 0x000AC950
		public event EventHandler ClosingAborted
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

		// Token: 0x140001F0 RID: 496
		// (add) Token: 0x06002D4C RID: 11596 RVA: 0x000AE788 File Offset: 0x000AC988
		// (remove) Token: 0x06002D4D RID: 11597 RVA: 0x000AE7C0 File Offset: 0x000AC9C0
		public event EventHandler<EventArgs26> DownloadingFailed
		{
			add
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_8;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_8, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_8;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_8, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001F1 RID: 497
		// (add) Token: 0x06002D4E RID: 11598 RVA: 0x000AE7F8 File Offset: 0x000AC9F8
		// (remove) Token: 0x06002D4F RID: 11599 RVA: 0x000AE830 File Offset: 0x000ACA30
		public event EventHandler<EventArgs26> ExtractingFailed
		{
			add
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_9;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_9;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001F2 RID: 498
		// (add) Token: 0x06002D50 RID: 11600 RVA: 0x000AE868 File Offset: 0x000ACA68
		// (remove) Token: 0x06002D51 RID: 11601 RVA: 0x000AE8A0 File Offset: 0x000ACAA0
		public event EventHandler<EventArgs9> ProgressChanged
		{
			add
			{
				EventHandler<EventArgs9> eventHandler = this.eventHandler_10;
				EventHandler<EventArgs9> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs9> value2 = (EventHandler<EventArgs9>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs9>>(ref this.eventHandler_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs9> eventHandler = this.eventHandler_10;
				EventHandler<EventArgs9> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs9> value2 = (EventHandler<EventArgs9>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs9>>(ref this.eventHandler_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001F3 RID: 499
		// (add) Token: 0x06002D52 RID: 11602 RVA: 0x000AE8D8 File Offset: 0x000ACAD8
		// (remove) Token: 0x06002D53 RID: 11603 RVA: 0x000AE910 File Offset: 0x000ACB10
		public event EventHandler ReadyToBeInstalled
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

		// Token: 0x140001F4 RID: 500
		// (add) Token: 0x06002D54 RID: 11604 RVA: 0x000AE948 File Offset: 0x000ACB48
		// (remove) Token: 0x06002D55 RID: 11605 RVA: 0x000AE980 File Offset: 0x000ACB80
		public event EventHandler UpdateAvailable
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

		// Token: 0x140001F5 RID: 501
		// (add) Token: 0x06002D56 RID: 11606 RVA: 0x000AE9B8 File Offset: 0x000ACBB8
		// (remove) Token: 0x06002D57 RID: 11607 RVA: 0x000AE9F0 File Offset: 0x000ACBF0
		public event EventHandler<EventArgs26> UpdateFailed
		{
			add
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_13;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_13, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_13;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_13, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001F6 RID: 502
		// (add) Token: 0x06002D58 RID: 11608 RVA: 0x000AEA28 File Offset: 0x000ACC28
		// (remove) Token: 0x06002D59 RID: 11609 RVA: 0x000AEA60 File Offset: 0x000ACC60
		public event EventHandler<EventArgs7> UpdateSuccessful
		{
			add
			{
				EventHandler<EventArgs7> eventHandler = this.eventHandler_14;
				EventHandler<EventArgs7> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs7> value2 = (EventHandler<EventArgs7>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_14, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs7> eventHandler = this.eventHandler_14;
				EventHandler<EventArgs7> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs7> value2 = (EventHandler<EventArgs7>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_14, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001F7 RID: 503
		// (add) Token: 0x06002D5A RID: 11610 RVA: 0x000AEA98 File Offset: 0x000ACC98
		// (remove) Token: 0x06002D5B RID: 11611 RVA: 0x000AEAD0 File Offset: 0x000ACCD0
		public event EventHandler<EventArgs7> UpToDate
		{
			add
			{
				EventHandler<EventArgs7> eventHandler = this.eventHandler_15;
				EventHandler<EventArgs7> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs7> value2 = (EventHandler<EventArgs7>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_15, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs7> eventHandler = this.eventHandler_15;
				EventHandler<EventArgs7> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs7> value2 = (EventHandler<EventArgs7>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_15, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001F8 RID: 504
		// (add) Token: 0x06002D5C RID: 11612 RVA: 0x000AEB08 File Offset: 0x000ACD08
		// (remove) Token: 0x06002D5D RID: 11613 RVA: 0x000AEB40 File Offset: 0x000ACD40
		public event EventHandler UpdateStepMismatch
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

		// Token: 0x17000B35 RID: 2869
		// (get) Token: 0x06002D5E RID: 11614 RVA: 0x00015A49 File Offset: 0x00013C49
		// (set) Token: 0x06002D5F RID: 11615 RVA: 0x00015A56 File Offset: 0x00013C56
		public string UpdaterExitedPrematurely_Title
		{
			get
			{
				return this.class126_0.UpdaterExitedPrematurely_Title;
			}
			set
			{
				this.class126_0.UpdaterExitedPrematurely_Title = value;
			}
		}

		// Token: 0x17000B36 RID: 2870
		// (get) Token: 0x06002D60 RID: 11616 RVA: 0x00015A64 File Offset: 0x00013C64
		// (set) Token: 0x06002D61 RID: 11617 RVA: 0x00015A71 File Offset: 0x00013C71
		public string UpdaterExitedPrematurely
		{
			get
			{
				return this.class126_0.UpdaterExitedPrematurely;
			}
			set
			{
				this.class126_0.UpdaterExitedPrematurely = value;
			}
		}

		// Token: 0x17000B37 RID: 2871
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x00015A7F File Offset: 0x00013C7F
		// (set) Token: 0x06002D63 RID: 11619 RVA: 0x00015A87 File Offset: 0x00013C87
		public string Arguments { get; set; }

		// Token: 0x17000B38 RID: 2872
		// (get) Token: 0x06002D64 RID: 11620 RVA: 0x000AEB78 File Offset: 0x000ACD78
		public string Changes
		{
			get
			{
				if (!this.bool_2)
				{
					return this.string_6;
				}
				string text;
				using (RichTextBox richTextBox = new RichTextBox())
				{
					richTextBox.Rtf = this.string_6;
					text = richTextBox.Text;
				}
				return text;
			}
		}

		// Token: 0x17000B39 RID: 2873
		// (get) Token: 0x06002D65 RID: 11621 RVA: 0x00015A90 File Offset: 0x00013C90
		public string RawChanges
		{
			get
			{
				return this.string_6;
			}
		}

		// Token: 0x17000B3A RID: 2874
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x00015A98 File Offset: 0x00013C98
		public bool AreChangesRTF
		{
			get
			{
				return this.bool_2;
			}
		}

		// Token: 0x17000B3B RID: 2875
		// (get) Token: 0x06002D67 RID: 11623 RVA: 0x00015AA0 File Offset: 0x00013CA0
		// (set) Token: 0x06002D68 RID: 11624 RVA: 0x00015AA8 File Offset: 0x00013CA8
		public bool ClosingForInstall { get; private set; }

		// Token: 0x17000B3C RID: 2876
		// (get) Token: 0x06002D69 RID: 11625 RVA: 0x00015AB1 File Offset: 0x00013CB1
		public DateTime LastCheckDate
		{
			get
			{
				return this.class176_0.LastCheckedForUpdate;
			}
		}

		// Token: 0x17000B3D RID: 2877
		// (get) Token: 0x06002D6A RID: 11626 RVA: 0x00015ABE File Offset: 0x00013CBE
		// (set) Token: 0x06002D6B RID: 11627 RVA: 0x00015AC6 File Offset: 0x00013CC6
		public Enum111 UpdateStepOn
		{
			get
			{
				return this.enum111_0;
			}
			private set
			{
				this.enum111_0 = value;
				if (value != Enum111.const_1 && value != Enum111.const_3 && value != Enum111.const_5)
				{
					if (value == Enum111.const_0)
					{
						this.class176_0.method_2();
					}
					this.class176_0.UpdateStepOn = value;
					this.class176_0.method_0();
				}
			}
		}

		// Token: 0x17000B3E RID: 2878
		// (get) Token: 0x06002D6C RID: 11628 RVA: 0x00015B00 File Offset: 0x00013D00
		// (set) Token: 0x06002D6D RID: 11629 RVA: 0x00015B08 File Offset: 0x00013D08
		public Enum78 UpdateType
		{
			get
			{
				return this.enum78_1;
			}
			set
			{
				this.enum78_1 = value;
				this.enum78_0 = value;
			}
		}

		// Token: 0x17000B3F RID: 2879
		// (get) Token: 0x06002D6E RID: 11630 RVA: 0x00015B18 File Offset: 0x00013D18
		public string Version
		{
			get
			{
				return this.string_5;
			}
		}

		// Token: 0x17000B40 RID: 2880
		// (get) Token: 0x06002D6F RID: 11631 RVA: 0x00015B20 File Offset: 0x00013D20
		// (set) Token: 0x06002D70 RID: 11632 RVA: 0x00015B2D File Offset: 0x00013D2D
		public string wyUpdateLocation
		{
			get
			{
				return this.class126_0.wyUpdateLocation;
			}
			set
			{
				this.class126_0.wyUpdateLocation = value;
			}
		}

		// Token: 0x17000B41 RID: 2881
		// (get) Token: 0x06002D71 RID: 11633 RVA: 0x00015B3B File Offset: 0x00013D3B
		// (set) Token: 0x06002D72 RID: 11634 RVA: 0x00015B43 File Offset: 0x00013D43
		public string ServiceName { get; set; }

		// Token: 0x140001F9 RID: 505
		// (add) Token: 0x06002D73 RID: 11635 RVA: 0x000AEBCC File Offset: 0x000ACDCC
		// (remove) Token: 0x06002D74 RID: 11636 RVA: 0x000AEC04 File Offset: 0x000ACE04
		public event EventHandler CloseAppNow
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_17;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_17, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_17;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_17, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002D75 RID: 11637 RVA: 0x00015B4C File Offset: 0x00013D4C
		// (set) Token: 0x06002D76 RID: 11638 RVA: 0x00015B54 File Offset: 0x00013D54
		public bool UseCloseAppNow { get; set; }

		// Token: 0x06002D77 RID: 11639 RVA: 0x000AEC3C File Offset: 0x000ACE3C
		public Class151()
		{
			this.class176_0 = Class176.Instance;
			Class126 @class = this.class126_0;
			EventHandler<EventArgs38> value = new EventHandler<EventArgs38>(this.method_20);
			@class.ProgressChanged += value;
			Class126 class2 = this.class126_0;
			EventHandler<EventArgs38> value2 = new EventHandler<EventArgs38>(this.method_21);
			class2.PipeServerDisconnected += value2;
			Class126 class3 = this.class126_0;
			EventHandler<EventArgs28> value3 = new EventHandler<EventArgs28>(this.method_22);
			class3.UpdateStepMismatch += value3;
			Class126 class4 = this.class126_0;
			EventHandler value4 = new EventHandler(this.method_23);
			class4.Canceled += value4;
		}

		// Token: 0x06002D78 RID: 11640 RVA: 0x00015B5D File Offset: 0x00013D5D
		protected override void vmethod_0()
		{
			if (this.class126_0 != null)
			{
				this.class126_0.Dispose();
			}
			base.vmethod_0();
		}

		// Token: 0x06002D79 RID: 11641 RVA: 0x000AECD4 File Offset: 0x000ACED4
		public void method_4()
		{
			if (this.class176_0 == null)
			{
				throw new FailedToInitializeException();
			}
			if (this.UpdateStepOn == Enum111.const_0)
			{
				throw new Exception(Class151.string_3);
			}
			if (this.UpdateStepOn == Enum111.const_1)
			{
				throw new Exception(Class151.string_2);
			}
			if (this.UpdateStepOn == Enum111.const_3)
			{
				throw new Exception(Class151.string_1);
			}
			if (this.UpdateStepOn == Enum111.const_5)
			{
				throw new Exception(Class151.string_0);
			}
			this.enum78_0 = Enum78.const_0;
			if (this.UpdateStepOn == Enum111.const_2)
			{
				this.method_10();
				return;
			}
			if (this.UpdateStepOn == Enum111.const_4)
			{
				this.method_11();
				return;
			}
			this.method_9();
		}

		// Token: 0x06002D7A RID: 11642 RVA: 0x00015B78 File Offset: 0x00013D78
		public void method_5()
		{
			if (this.class176_0 == null)
			{
				throw new FailedToInitializeException();
			}
			this.class126_0.method_17();
			this.method_6();
		}

		// Token: 0x06002D7B RID: 11643 RVA: 0x00015B99 File Offset: 0x00013D99
		private void method_6()
		{
			if (this.UpdateStepOn == Enum111.const_1)
			{
				this.UpdateStepOn = Enum111.const_0;
				return;
			}
			this.UpdateStepOn = Enum111.const_2;
		}

		// Token: 0x06002D7C RID: 11644 RVA: 0x000AED6C File Offset: 0x000ACF6C
		public bool method_7(bool recheck)
		{
			if (this.class176_0 == null)
			{
				throw new FailedToInitializeException();
			}
			if (this.UpdateStepOn != Enum111.const_0)
			{
				if (!recheck || this.UpdateStepOn != Enum111.const_2)
				{
					return false;
				}
			}
			EventArgs40 eventArgs = new EventArgs40();
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, eventArgs);
			}
			if (eventArgs.Cancel)
			{
				this.class126_0.method_17();
				return false;
			}
			this.UpdateStepOn = Enum111.const_1;
			if (recheck)
			{
				this.class126_0.method_11();
			}
			else
			{
				this.class126_0.method_12();
			}
			return true;
		}

		// Token: 0x06002D7D RID: 11645 RVA: 0x00015BB3 File Offset: 0x00013DB3
		public bool method_8()
		{
			return this.method_7(false);
		}

		// Token: 0x06002D7E RID: 11646 RVA: 0x00015BBC File Offset: 0x00013DBC
		private void method_9()
		{
			this.class126_0.method_15(this.ServiceName ?? Application.ExecutablePath, this.class176_0.AutoUpdateID, this.Arguments, this.ServiceName != null);
		}

		// Token: 0x06002D7F RID: 11647 RVA: 0x000AEDF4 File Offset: 0x000ACFF4
		private void method_10()
		{
			EventArgs40 eventArgs = new EventArgs40();
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, eventArgs);
			}
			if (eventArgs.Cancel)
			{
				this.class126_0.method_17();
				return;
			}
			this.UpdateStepOn = Enum111.const_3;
			this.class126_0.method_13();
		}

		// Token: 0x06002D80 RID: 11648 RVA: 0x000AEE44 File Offset: 0x000AD044
		private void method_11()
		{
			EventArgs40 eventArgs = new EventArgs40();
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, eventArgs);
			}
			if (eventArgs.Cancel)
			{
				this.class126_0.method_17();
				return;
			}
			this.UpdateStepOn = Enum111.const_5;
			this.class126_0.method_14();
		}

		// Token: 0x06002D81 RID: 11649 RVA: 0x000AEE94 File Offset: 0x000AD094
		private void method_12(Enum87 updateStepOn)
		{
			switch (updateStepOn)
			{
			case Enum87.const_0:
				if (string.IsNullOrEmpty(this.string_5))
				{
					this.method_16();
					return;
				}
				if (this.enum78_0 != Enum78.const_1 && this.enum78_0 != Enum78.const_0)
				{
					this.method_13();
					return;
				}
				this.UpdateStepOn = Enum111.const_2;
				this.method_10();
				return;
			case Enum87.const_2:
				if (this.enum78_0 == Enum78.const_0)
				{
					this.method_11();
					return;
				}
				this.method_14();
				return;
			case Enum87.const_3:
				this.method_15();
				return;
			default:
				return;
			}
		}

		// Token: 0x06002D82 RID: 11650 RVA: 0x00015BF5 File Offset: 0x00013DF5
		private void method_13()
		{
			this.UpdateStepOn = Enum111.const_2;
			if (this.eventHandler_12 != null)
			{
				this.eventHandler_12(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002D83 RID: 11651 RVA: 0x00015C17 File Offset: 0x00013E17
		private void method_14()
		{
			this.UpdateStepOn = Enum111.const_4;
			if (this.eventHandler_11 != null)
			{
				this.eventHandler_11(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002D84 RID: 11652 RVA: 0x00015C39 File Offset: 0x00013E39
		private void method_15()
		{
			this.UpdateStepOn = Enum111.const_6;
			if (this.eventHandler_11 != null)
			{
				this.eventHandler_11(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002D85 RID: 11653 RVA: 0x00015C5B File Offset: 0x00013E5B
		private void method_16()
		{
			this.UpdateStepOn = Enum111.const_0;
			if (this.eventHandler_15 != null)
			{
				this.eventHandler_15(this, new EventArgs7(this.string_5));
			}
		}

		// Token: 0x06002D86 RID: 11654 RVA: 0x000AEF0C File Offset: 0x000AD10C
		private void method_17(Enum111 us, EventArgs26 args)
		{
			this.method_6();
			switch (us)
			{
			case Enum111.const_1:
				if (this.eventHandler_6 != null)
				{
					this.eventHandler_6(this, args);
					return;
				}
				break;
			case Enum111.const_2:
			case Enum111.const_4:
				break;
			case Enum111.const_3:
				if (this.eventHandler_8 != null)
				{
					this.eventHandler_8(this, args);
					return;
				}
				break;
			case Enum111.const_5:
				if (this.eventHandler_9 != null)
				{
					this.eventHandler_9(this, args);
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06002D87 RID: 11655 RVA: 0x000AEF80 File Offset: 0x000AD180
		private static Enum111 smethod_0(Enum87 us)
		{
			switch (us)
			{
			case Enum87.const_0:
				return Enum111.const_1;
			case Enum87.const_2:
				return Enum111.const_3;
			case Enum87.const_3:
				return Enum111.const_5;
			default:
				throw new Exception(Class151.string_4);
			}
		}

		// Token: 0x06002D88 RID: 11656 RVA: 0x00015C83 File Offset: 0x00013E83
		public void method_18()
		{
			if (this.class176_0.UpdateStepOn == Enum111.const_6)
			{
				this.ClosingForInstall = true;
				this.method_9();
			}
		}

		// Token: 0x06002D89 RID: 11657 RVA: 0x000AEFB4 File Offset: 0x000AD1B4
		public void method_19()
		{
			if (this.class176_0 == null)
			{
				throw new FailedToInitializeException();
			}
			if (this.ClosingForInstall)
			{
				return;
			}
			this.enum111_0 = this.class176_0.UpdateStepOn;
			if (this.UpdateStepOn != Enum111.const_0)
			{
				this.string_5 = this.class176_0.UpdateVersion;
				this.string_6 = this.class176_0.ChangesInLatestVersion;
				this.bool_2 = this.class176_0.ChangesIsRTF;
				switch (this.UpdateStepOn)
				{
				case Enum111.const_2:
					if (this.enum78_0 != Enum78.const_1 && this.enum78_0 != Enum78.const_0)
					{
						this.method_13();
						return;
					}
					this.method_10();
					return;
				case Enum111.const_3:
				case Enum111.const_5:
					break;
				case Enum111.const_4:
					if (this.enum78_0 == Enum78.const_0)
					{
						this.method_11();
						return;
					}
					this.method_14();
					return;
				case Enum111.const_6:
					this.method_15();
					return;
				default:
					return;
				}
			}
			else
			{
				switch (this.class176_0.AutoUpdaterStatus)
				{
				case Enum15.const_1:
					this.string_5 = this.class176_0.UpdateVersion;
					this.string_6 = this.class176_0.ChangesInLatestVersion;
					this.bool_2 = this.class176_0.ChangesIsRTF;
					if (this.eventHandler_14 != null)
					{
						this.eventHandler_14(this, new EventArgs7(this.string_5));
					}
					break;
				case Enum15.const_2:
					if (this.eventHandler_13 != null)
					{
						this.eventHandler_13(this, new EventArgs26(this.class176_0.ErrorTitle, this.class176_0.ErrorMessage));
					}
					break;
				}
				this.class176_0.method_2();
				this.class176_0.method_0();
			}
		}

		// Token: 0x06002D8A RID: 11658 RVA: 0x000AF144 File Offset: 0x000AD344
		[CompilerGenerated]
		private void method_20(object sender, EventArgs38 e)
		{
			Class492 updateHelperData = e.UpdateHelperData;
			switch (updateHelperData.ResponseType)
			{
			case Enum28.const_0:
				this.method_17(Class151.smethod_0(updateHelperData.UpdateStep), new EventArgs26(updateHelperData.ExtraData[0], updateHelperData.ExtraData[1]));
				return;
			case Enum28.const_1:
				break;
			case Enum28.const_2:
				switch (updateHelperData.UpdateStep)
				{
				case Enum87.const_0:
					this.class176_0.LastCheckedForUpdate = DateTime.Now;
					if (updateHelperData.ExtraData.Count != 0)
					{
						this.string_5 = updateHelperData.ExtraData[0];
						if (updateHelperData.ExtraData.Count > 1)
						{
							this.string_6 = updateHelperData.ExtraData[1];
							this.bool_2 = updateHelperData.ExtraDataIsRTF[1];
						}
						this.class176_0.UpdateVersion = this.string_5;
						this.class176_0.ChangesInLatestVersion = this.string_6;
						this.class176_0.ChangesIsRTF = this.bool_2;
					}
					else
					{
						this.string_5 = null;
						this.string_6 = null;
						this.bool_2 = false;
						this.class176_0.method_2();
					}
					break;
				case Enum87.const_2:
					this.UpdateStepOn = Enum111.const_4;
					break;
				case Enum87.const_4:
					if (this.UseCloseAppNow)
					{
						this.class126_0.method_16();
						if (this.eventHandler_17 != null)
						{
							this.eventHandler_17(this, EventArgs.Empty);
							return;
						}
					}
					else
					{
						this.class126_0.method_16();
						Environment.Exit(0);
					}
					return;
				}
				this.method_12(updateHelperData.UpdateStep);
				return;
			case Enum28.const_3:
				if (this.eventHandler_10 != null)
				{
					this.eventHandler_10(this, new EventArgs9((long)updateHelperData.Progress, 100L));
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06002D8B RID: 11659 RVA: 0x000AF300 File Offset: 0x000AD500
		[CompilerGenerated]
		private void method_21(object sender, EventArgs38 e)
		{
			if (this.UpdateStepOn == Enum111.const_1 || this.UpdateStepOn == Enum111.const_3 || this.UpdateStepOn == Enum111.const_5)
			{
				this.method_17(this.UpdateStepOn, new EventArgs26(true, e.UpdateHelperData.ExtraData[0], e.UpdateHelperData.ExtraData[1]));
			}
		}

		// Token: 0x06002D8C RID: 11660 RVA: 0x000AF35C File Offset: 0x000AD55C
		[CompilerGenerated]
		private void method_22(object sender, EventArgs28 e)
		{
			if (e.PreviousStep == Enum87.const_4 && this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, EventArgs.Empty);
			}
			if (e.Response == Enum28.const_3)
			{
				switch (this.class126_0.UpdateStep)
				{
				case Enum87.const_0:
					this.UpdateStepOn = Enum111.const_1;
					break;
				case Enum87.const_2:
					this.UpdateStepOn = Enum111.const_3;
					break;
				case Enum87.const_3:
					this.UpdateStepOn = Enum111.const_5;
					break;
				}
			}
			if (this.eventHandler_16 != null)
			{
				this.eventHandler_16(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00015CA0 File Offset: 0x00013EA0
		[CompilerGenerated]
		private void method_23(object sender, EventArgs e)
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, e);
			}
		}

		// Token: 0x040017B4 RID: 6068
		private static readonly string string_0 = "The update must finish extracting before you can install it.";

		// Token: 0x040017B5 RID: 6069
		private static readonly string string_1 = "The update must be downloaded before you can install it.";

		// Token: 0x040017B6 RID: 6070
		private static readonly string string_2 = "The automatic updater must finish checking for updates before they can be installed.";

		// Token: 0x040017B7 RID: 6071
		private static readonly string string_3 = "There must be an update available before you can install it.";

		// Token: 0x040017B8 RID: 6072
		private static readonly string string_4 = "UpdateStep not supported";

		// Token: 0x040017B9 RID: 6073
		private Class176 class176_0;

		// Token: 0x040017BA RID: 6074
		private readonly Class126 class126_0 = new Class126();

		// Token: 0x040017BB RID: 6075
		private Enum111 enum111_0;

		// Token: 0x040017BC RID: 6076
		private Enum78 enum78_0;

		// Token: 0x040017BD RID: 6077
		private Enum78 enum78_1;

		// Token: 0x040017BE RID: 6078
		private string string_5;

		// Token: 0x040017BF RID: 6079
		private string string_6;

		// Token: 0x040017C0 RID: 6080
		private bool bool_2;

		// Token: 0x040017C1 RID: 6081
		private EventHandler<EventArgs40> eventHandler_2;

		// Token: 0x040017C2 RID: 6082
		private EventHandler<EventArgs40> eventHandler_3;

		// Token: 0x040017C3 RID: 6083
		private EventHandler<EventArgs40> eventHandler_4;

		// Token: 0x040017C4 RID: 6084
		private EventHandler eventHandler_5;

		// Token: 0x040017C5 RID: 6085
		private EventHandler<EventArgs26> eventHandler_6;

		// Token: 0x040017C6 RID: 6086
		private EventHandler eventHandler_7;

		// Token: 0x040017C7 RID: 6087
		private EventHandler<EventArgs26> eventHandler_8;

		// Token: 0x040017C8 RID: 6088
		private EventHandler<EventArgs26> eventHandler_9;

		// Token: 0x040017C9 RID: 6089
		private EventHandler<EventArgs9> eventHandler_10;

		// Token: 0x040017CA RID: 6090
		private EventHandler eventHandler_11;

		// Token: 0x040017CB RID: 6091
		private EventHandler eventHandler_12;

		// Token: 0x040017CC RID: 6092
		private EventHandler<EventArgs26> eventHandler_13;

		// Token: 0x040017CD RID: 6093
		private EventHandler<EventArgs7> eventHandler_14;

		// Token: 0x040017CE RID: 6094
		private EventHandler<EventArgs7> eventHandler_15;

		// Token: 0x040017CF RID: 6095
		private EventHandler eventHandler_16;

		// Token: 0x040017D0 RID: 6096
		private EventHandler eventHandler_17;

		// Token: 0x040017D1 RID: 6097
		[CompilerGenerated]
		private string string_7;

		// Token: 0x040017D2 RID: 6098
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040017D3 RID: 6099
		[CompilerGenerated]
		private string string_8;

		// Token: 0x040017D4 RID: 6100
		[CompilerGenerated]
		private bool bool_4;
	}
}
