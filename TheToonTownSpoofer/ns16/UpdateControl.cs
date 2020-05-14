using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns18;
using ns19;
using ns20;
using ns22;
using ns23;
using ns24;
using ns26;
using ns28;
using ns30;

namespace ns16
{
	// Token: 0x020003C7 RID: 967
	internal sealed class UpdateControl : UserControl
	{
		// Token: 0x06002576 RID: 9590 RVA: 0x0001083A File Offset: 0x0000EA3A
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.class151_0 != null)
				{
					this.class151_0.Dispose();
				}
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x00083EC4 File Offset: 0x000820C4
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.MessageLink = new LinkLabel();
			this.MessageLabel = new Label();
			this.CancelStrip = new ContextMenuStrip(this.icontainer_0);
			this.StopCheckingMenuItem = new ToolStripMenuItem();
			this.UpdateFailedStrip = new ContextMenuStrip(this.icontainer_0);
			this.TryAgainNowMenuItem = new ToolStripMenuItem();
			this.TryAgainLaterMenuItem = new ToolStripMenuItem();
			this.UpdateFailedSep = new ToolStripSeparator();
			this.ViewErrorMenuItem = new ToolStripMenuItem();
			this.UpdateStrip = new ContextMenuStrip(this.icontainer_0);
			this.InstallMenuItem = new ToolStripMenuItem();
			this.ViewChangesMenuItem = new ToolStripMenuItem();
			this.UpdateStrip_1 = new ContextMenuStrip(this.icontainer_0);
			this.UpdatedHideMenuItem = new ToolStripMenuItem();
			this.UpdatedViewChangesMenuItem = new ToolStripMenuItem();
			this.UpToDateStrip = new ContextMenuStrip(this.icontainer_0);
			this.DismissMenuItem = new ToolStripMenuItem();
			this.Animator = new Control2();
			this.CancelStrip.SuspendLayout();
			this.UpdateFailedStrip.SuspendLayout();
			this.UpdateStrip.SuspendLayout();
			this.UpdateStrip_1.SuspendLayout();
			this.UpToDateStrip.SuspendLayout();
			base.SuspendLayout();
			this.MessageLink.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.MessageLink.AutoEllipsis = true;
			this.MessageLink.LinkColor = Color.FromArgb(0, 192, 192);
			this.MessageLink.Location = new Point(20, 0);
			this.MessageLink.Margin = new Padding(13, 0, 3, 0);
			this.MessageLink.Name = "MessageLink";
			this.MessageLink.Size = new Size(224, 16);
			this.MessageLink.TabIndex = 1;
			this.MessageLink.TextAlign = ContentAlignment.MiddleLeft;
			this.MessageLink.LinkClicked += this.MessageLink_LinkClicked;
			this.MessageLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.MessageLabel.AutoEllipsis = true;
			this.MessageLabel.Location = new Point(20, 0);
			this.MessageLabel.Name = "MessageLabel";
			this.MessageLabel.Size = new Size(224, 16);
			this.MessageLabel.TabIndex = 2;
			this.MessageLabel.TextAlign = ContentAlignment.MiddleLeft;
			this.CancelStrip.Items.AddRange(new ToolStripItem[]
			{
				this.StopCheckingMenuItem
			});
			this.CancelStrip.Name = "CancelStrip";
			this.CancelStrip.Size = new Size(257, 26);
			this.StopCheckingMenuItem.Name = "StopCheckingMenuItem";
			this.StopCheckingMenuItem.Size = new Size(256, 22);
			this.StopCheckingMenuItem.Text = "&Stop checking for updates for now";
			this.StopCheckingMenuItem.Click += this.StopCheckingMenuItem_Click;
			this.UpdateFailedStrip.Items.AddRange(new ToolStripItem[]
			{
				this.TryAgainNowMenuItem,
				this.TryAgainLaterMenuItem,
				this.UpdateFailedSep,
				this.ViewErrorMenuItem
			});
			this.UpdateFailedStrip.Name = "UpdateFailedStrip";
			this.UpdateFailedStrip.Size = new Size(165, 76);
			this.TryAgainNowMenuItem.Name = "TryAgainNowMenuItem";
			this.TryAgainNowMenuItem.Size = new Size(164, 22);
			this.TryAgainNowMenuItem.Text = "Try again &now";
			this.TryAgainNowMenuItem.Click += this.TryAgainNowMenuItem_Click;
			this.TryAgainLaterMenuItem.Name = "TryAgainLaterMenuItem";
			this.TryAgainLaterMenuItem.Size = new Size(164, 22);
			this.TryAgainLaterMenuItem.Text = "Try again &later";
			this.TryAgainLaterMenuItem.Click += this.TryAgainLaterMenuItem_Click;
			this.UpdateFailedSep.Name = "UpdateFailedSep";
			this.UpdateFailedSep.Size = new Size(161, 6);
			this.ViewErrorMenuItem.Name = "ViewErrorMenuItem";
			this.ViewErrorMenuItem.Size = new Size(164, 22);
			this.ViewErrorMenuItem.Text = "&View error details";
			this.ViewErrorMenuItem.Click += this.ViewErrorMenuItem_Click;
			this.UpdateStrip.Items.AddRange(new ToolStripItem[]
			{
				this.InstallMenuItem,
				this.ViewChangesMenuItem
			});
			this.UpdateStrip.Name = "UpdateStrip";
			this.UpdateStrip.Size = new Size(68, 48);
			this.InstallMenuItem.Name = "InstallMenuItem";
			this.InstallMenuItem.Size = new Size(67, 22);
			this.InstallMenuItem.Click += this.InstallMenuItem_Click;
			this.ViewChangesMenuItem.Name = "ViewChangesMenuItem";
			this.ViewChangesMenuItem.Size = new Size(67, 22);
			this.ViewChangesMenuItem.Click += this.UpdatedViewChangesMenuItem_Click;
			this.UpdateStrip_1.Items.AddRange(new ToolStripItem[]
			{
				this.UpdatedHideMenuItem,
				this.UpdatedViewChangesMenuItem
			});
			this.UpdateStrip_1.Name = "UpdateStrip";
			this.UpdateStrip_1.Size = new Size(100, 48);
			this.UpdatedHideMenuItem.Name = "UpdatedHideMenuItem";
			this.UpdatedHideMenuItem.Size = new Size(99, 22);
			this.UpdatedHideMenuItem.Text = "&Hide";
			this.UpdatedHideMenuItem.Click += this.UpdatedHideMenuItem_Click;
			this.UpdatedViewChangesMenuItem.Name = "UpdatedViewChangesMenuItem";
			this.UpdatedViewChangesMenuItem.Size = new Size(99, 22);
			this.UpdatedViewChangesMenuItem.Click += this.UpdatedViewChangesMenuItem_Click;
			this.UpToDateStrip.Items.AddRange(new ToolStripItem[]
			{
				this.DismissMenuItem
			});
			this.UpToDateStrip.Name = "UpToDateStrip";
			this.UpToDateStrip.Size = new Size(115, 26);
			this.DismissMenuItem.Name = "DismissMenuItem";
			this.DismissMenuItem.Size = new Size(114, 22);
			this.DismissMenuItem.Text = "Dismiss";
			this.DismissMenuItem.Click += this.DismissMenuItem_Click;
			this.Animator.AnimationInterval = 25;
			this.Animator.Columns = 10;
			this.Animator.Dock = DockStyle.Left;
			this.Animator.Location = new Point(0, 0);
			this.Animator.Name = "Animator";
			this.Animator.Rows = 5;
			this.Animator.Size = new Size(16, 16);
			this.Animator.StaticImage = false;
			this.Animator.TabIndex = 0;
			this.Animator.Text = "animationControl1";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.Animator);
			base.Controls.Add(this.MessageLink);
			base.Controls.Add(this.MessageLabel);
			base.Name = "UpdateControl";
			base.Size = new Size(244, 16);
			this.CancelStrip.ResumeLayout(false);
			this.UpdateFailedStrip.ResumeLayout(false);
			this.UpdateStrip.ResumeLayout(false);
			this.UpdateStrip_1.ResumeLayout(false);
			this.UpToDateStrip.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x140001BE RID: 446
		// (add) Token: 0x06002578 RID: 9592 RVA: 0x00084690 File Offset: 0x00082890
		// (remove) Token: 0x06002579 RID: 9593 RVA: 0x000846C8 File Offset: 0x000828C8
		[Category("Updater")]
		[Description("Event is raised before the update checking begins.")]
		public event EventHandler<EventArgs40> BeforeChecking
		{
			add
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001BF RID: 447
		// (add) Token: 0x0600257A RID: 9594 RVA: 0x00084700 File Offset: 0x00082900
		// (remove) Token: 0x0600257B RID: 9595 RVA: 0x00084738 File Offset: 0x00082938
		[Description("Event is raised before the downloading of the update begins.")]
		[Category("Updater")]
		public event EventHandler<EventArgs40> BeforeDownloading
		{
			add
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_1;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs40> eventHandler = this.eventHandler_1;
				EventHandler<EventArgs40> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs40> value2 = (EventHandler<EventArgs40>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs40>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001C0 RID: 448
		// (add) Token: 0x0600257C RID: 9596 RVA: 0x00084770 File Offset: 0x00082970
		// (remove) Token: 0x0600257D RID: 9597 RVA: 0x000847A8 File Offset: 0x000829A8
		[Category("Updater")]
		[Description("Event is raised when checking or updating is canceled.")]
		public event EventHandler Canceled
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

		// Token: 0x140001C1 RID: 449
		// (add) Token: 0x0600257E RID: 9598 RVA: 0x000847E0 File Offset: 0x000829E0
		// (remove) Token: 0x0600257F RID: 9599 RVA: 0x00084818 File Offset: 0x00082A18
		[Description("Event is raised when the checking for updates fails.")]
		[Category("Updater")]
		public event EventHandler<EventArgs26> CheckingFailed
		{
			add
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001C2 RID: 450
		// (add) Token: 0x06002580 RID: 9600 RVA: 0x00084850 File Offset: 0x00082A50
		// (remove) Token: 0x06002581 RID: 9601 RVA: 0x00084888 File Offset: 0x00082A88
		[Category("Updater")]
		[Description("Event is raised when an update can't be installed and the closing is aborted.")]
		public event EventHandler ClosingAborted
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_4;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_4;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001C3 RID: 451
		// (add) Token: 0x06002582 RID: 9602 RVA: 0x000848C0 File Offset: 0x00082AC0
		// (remove) Token: 0x06002583 RID: 9603 RVA: 0x000848F8 File Offset: 0x00082AF8
		[Category("Updater")]
		[Description("Event is raised when the update fails to download or extract.")]
		public event EventHandler<EventArgs26> DownloadingOrExtractingFailed
		{
			add
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_5;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs26> eventHandler = this.eventHandler_5;
				EventHandler<EventArgs26> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs26> value2 = (EventHandler<EventArgs26>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs26>>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001C4 RID: 452
		// (add) Token: 0x06002584 RID: 9604 RVA: 0x00084930 File Offset: 0x00082B30
		// (remove) Token: 0x06002585 RID: 9605 RVA: 0x00084968 File Offset: 0x00082B68
		[Category("Updater")]
		[Description("Event is raised when the update is ready to be installed.")]
		public event EventHandler ReadyToBeInstalled
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

		// Token: 0x140001C5 RID: 453
		// (add) Token: 0x06002586 RID: 9606 RVA: 0x000849A0 File Offset: 0x00082BA0
		// (remove) Token: 0x06002587 RID: 9607 RVA: 0x000849D8 File Offset: 0x00082BD8
		[Description("Event is raised when a new update is found.")]
		[Category("Updater")]
		public event EventHandler UpdateAvailable
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

		// Token: 0x140001C6 RID: 454
		// (add) Token: 0x06002588 RID: 9608 RVA: 0x00084A10 File Offset: 0x00082C10
		// (remove) Token: 0x06002589 RID: 9609 RVA: 0x00084A48 File Offset: 0x00082C48
		[Category("Updater")]
		[Description("Event is raised when an update fails to install.")]
		public event EventHandler<EventArgs26> UpdateFailed
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

		// Token: 0x140001C7 RID: 455
		// (add) Token: 0x0600258A RID: 9610 RVA: 0x00084A80 File Offset: 0x00082C80
		// (remove) Token: 0x0600258B RID: 9611 RVA: 0x00084AB8 File Offset: 0x00082CB8
		[Description("Event is raised when an update installs successfully and the dismiss item is clicked.")]
		[Category("Updater")]
		public event EventHandler<EventArgs7> UpdateSuccessful
		{
			add
			{
				EventHandler<EventArgs7> eventHandler = this.eventHandler_9;
				EventHandler<EventArgs7> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs7> value2 = (EventHandler<EventArgs7>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs7> eventHandler = this.eventHandler_9;
				EventHandler<EventArgs7> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs7> value2 = (EventHandler<EventArgs7>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001C8 RID: 456
		// (add) Token: 0x0600258C RID: 9612 RVA: 0x00084AF0 File Offset: 0x00082CF0
		// (remove) Token: 0x0600258D RID: 9613 RVA: 0x00084B28 File Offset: 0x00082D28
		public event EventHandler UpdateFailedTryLater
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

		// Token: 0x140001C9 RID: 457
		// (add) Token: 0x0600258E RID: 9614 RVA: 0x00084B60 File Offset: 0x00082D60
		// (remove) Token: 0x0600258F RID: 9615 RVA: 0x00084B98 File Offset: 0x00082D98
		public event EventHandler CloseApplicationNow
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

		// Token: 0x140001CA RID: 458
		// (add) Token: 0x06002590 RID: 9616 RVA: 0x00084BD0 File Offset: 0x00082DD0
		// (remove) Token: 0x06002591 RID: 9617 RVA: 0x00084C08 File Offset: 0x00082E08
		[Description("Event is raised when the latest version is already installed.")]
		[Category("Updater")]
		public event EventHandler<EventArgs7> UpToDate
		{
			add
			{
				EventHandler<EventArgs7> eventHandler = this.eventHandler_12;
				EventHandler<EventArgs7> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs7> value2 = (EventHandler<EventArgs7>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_12, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs7> eventHandler = this.eventHandler_12;
				EventHandler<EventArgs7> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs7> value2 = (EventHandler<EventArgs7>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs7>>(ref this.eventHandler_12, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001CB RID: 459
		// (add) Token: 0x06002592 RID: 9618 RVA: 0x00084C40 File Offset: 0x00082E40
		// (remove) Token: 0x06002593 RID: 9619 RVA: 0x00084C78 File Offset: 0x00082E78
		[Description("Event is raised when the updater should close.")]
		[Category("Updater")]
		public event EventHandler Dismiss
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

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06002594 RID: 9620 RVA: 0x0001086C File Offset: 0x0000EA6C
		public Enum111 UpdateStepOn
		{
			get
			{
				return this.class151_0.UpdateStepOn;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06002595 RID: 9621 RVA: 0x00010879 File Offset: 0x0000EA79
		// (set) Token: 0x06002596 RID: 9622 RVA: 0x00010886 File Offset: 0x0000EA86
		public Enum78 UpdateType
		{
			get
			{
				return this.class151_0.UpdateType;
			}
			set
			{
				this.class151_0.UpdateType = value;
			}
		}

		// Token: 0x06002597 RID: 9623 RVA: 0x00084CB0 File Offset: 0x00082EB0
		public UpdateControl()
		{
			this.InitializeComponent();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(UpdateControl));
			this.bitmap_0 = (Bitmap)componentResourceManager.GetObject("Updater_info");
			this.bitmap_1 = (Bitmap)componentResourceManager.GetObject("Updater_update_working");
			this.bitmap_2 = (Bitmap)componentResourceManager.GetObject("Updater_update_notify");
			this.bitmap_3 = (Bitmap)componentResourceManager.GetObject("Updater_tick");
			this.bitmap_4 = (Bitmap)componentResourceManager.GetObject("Updater_cross");
			this.string_1 = componentResourceManager.GetString("UpdaterExitedPrematurely_Title");
			this.string_2 = componentResourceManager.GetString("UpdaterExitedPrematurely");
			this.class151_0 = new Class151();
			this.class151_0.UpdaterExitedPrematurely_Title = this.string_1;
			this.class151_0.UpdaterExitedPrematurely = this.string_2;
			this.class151_0.UseCloseAppNow = true;
			this.class151_0.UpToDate += this.method_11;
			this.class151_0.UpdateSuccessful += this.method_12;
			this.class151_0.UpdateStepMismatch += this.method_13;
			this.class151_0.UpdateFailed += this.method_14;
			this.class151_0.UpdateAvailable += this.method_15;
			this.class151_0.ReadyToBeInstalled += this.method_16;
			this.class151_0.ProgressChanged += this.method_17;
			this.class151_0.ExtractingFailed += this.method_18;
			this.class151_0.BeforeChecking += this.method_10;
			this.class151_0.Canceled += this.method_7;
			this.class151_0.CloseAppNow += this.method_6;
			this.class151_0.ClosingAborted += this.method_5;
			this.class151_0.DownloadingFailed += this.method_4;
			this.class151_0.BeforeExtracting += this.method_3;
			this.class151_0.CheckingFailed += this.method_2;
			this.class151_0.BeforeDownloading += this.method_1;
			this.class151_0.Arguments = Class409.Current.OriginalString;
			this.class151_0.UpdateType = Enum78.const_3;
			this.method_20(this.bitmap_2, true);
		}

		// Token: 0x06002598 RID: 9624 RVA: 0x00010894 File Offset: 0x0000EA94
		private void method_0()
		{
			this.CancelStrip.Close();
			this.UpdateFailedStrip.Close();
			this.UpdateStrip.Close();
			this.UpdateStrip_1.Close();
			this.UpToDateStrip.Close();
		}

		// Token: 0x06002599 RID: 9625 RVA: 0x00084F40 File Offset: 0x00083140
		private void method_1(object sender, EventArgs40 e)
		{
			UpdateControl.Class386 @class = new UpdateControl.Class386();
			@class.eventArgs40_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600259A RID: 9626 RVA: 0x00084F74 File Offset: 0x00083174
		private void method_2(object sender, EventArgs26 e)
		{
			UpdateControl.Class387 @class = new UpdateControl.Class387();
			@class.eventArgs26_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600259B RID: 9627 RVA: 0x000108CD File Offset: 0x0000EACD
		private void method_3(object sender, EventArgs40 e)
		{
			this.smethod_4(new MethodInvoker(this.method_25));
		}

		// Token: 0x0600259C RID: 9628 RVA: 0x00084FA8 File Offset: 0x000831A8
		private void method_4(object sender, EventArgs26 e)
		{
			UpdateControl.Class388 @class = new UpdateControl.Class388();
			@class.eventArgs26_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600259D RID: 9629 RVA: 0x000108E1 File Offset: 0x0000EAE1
		private void method_5(object sender, EventArgs e)
		{
			this.smethod_4(new MethodInvoker(this.method_26));
		}

		// Token: 0x0600259E RID: 9630 RVA: 0x000108F5 File Offset: 0x0000EAF5
		private void method_6(object sender, EventArgs e)
		{
			this.smethod_4(new MethodInvoker(this.method_27));
		}

		// Token: 0x0600259F RID: 9631 RVA: 0x00084FDC File Offset: 0x000831DC
		private void method_7(object sender, EventArgs e)
		{
			UpdateControl.Class389 @class = new UpdateControl.Class389();
			@class.eventArgs_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025A0 RID: 9632 RVA: 0x00010909 File Offset: 0x0000EB09
		public void method_8()
		{
			this.class151_0.method_5();
		}

		// Token: 0x060025A1 RID: 9633 RVA: 0x00085010 File Offset: 0x00083210
		private void method_9(Enum111 uso)
		{
			switch (uso)
			{
			case Enum111.const_1:
				this.MessageLink.Text = (this.string_0 = "Checking for updates");
				this.MessageLink.Visible = true;
				this.MessageLabel.Visible = false;
				return;
			case Enum111.const_2:
				this.MessageLink.Text = "Update is ready to be downloaded.";
				this.MessageLink.Visible = true;
				this.MessageLabel.Visible = false;
				return;
			case Enum111.const_3:
				this.MessageLink.Text = (this.string_0 = "Downloading update");
				this.MessageLink.Visible = true;
				this.MessageLabel.Visible = false;
				return;
			case Enum111.const_4:
				this.MessageLink.Text = "Update is ready to be installed.";
				this.MessageLink.Visible = true;
				this.MessageLabel.Visible = false;
				return;
			case Enum111.const_5:
				this.MessageLink.Text = (this.string_0 = "Extracting update");
				this.MessageLink.Visible = true;
				this.MessageLabel.Visible = false;
				return;
			case Enum111.const_6:
				this.MessageLink.Text = "Update will be installed on next start.";
				this.MessageLink.Visible = true;
				this.MessageLabel.Visible = false;
				return;
			default:
				return;
			}
		}

		// Token: 0x060025A2 RID: 9634 RVA: 0x00085150 File Offset: 0x00083350
		private void method_10(object sender, EventArgs40 e)
		{
			UpdateControl.Class390 @class = new UpdateControl.Class390();
			@class.eventArgs40_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025A3 RID: 9635 RVA: 0x00085184 File Offset: 0x00083384
		private void method_11(object sender, EventArgs7 e)
		{
			UpdateControl.Class391 @class = new UpdateControl.Class391();
			@class.eventArgs7_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025A4 RID: 9636 RVA: 0x000851B8 File Offset: 0x000833B8
		private void method_12(object sender, EventArgs7 e)
		{
			UpdateControl.Class392 @class = new UpdateControl.Class392();
			@class.eventArgs7_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025A5 RID: 9637 RVA: 0x00010916 File Offset: 0x0000EB16
		private void method_13(object sender, EventArgs e)
		{
			this.smethod_4(new MethodInvoker(this.method_28));
		}

		// Token: 0x060025A6 RID: 9638 RVA: 0x000851EC File Offset: 0x000833EC
		private void method_14(object sender, EventArgs26 e)
		{
			UpdateControl.Class393 @class = new UpdateControl.Class393();
			@class.eventArgs26_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025A7 RID: 9639 RVA: 0x00085220 File Offset: 0x00083420
		private void method_15(object sender, EventArgs e)
		{
			UpdateControl.Class394 @class = new UpdateControl.Class394();
			@class.eventArgs_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025A8 RID: 9640 RVA: 0x00085254 File Offset: 0x00083454
		private void method_16(object sender, EventArgs e)
		{
			UpdateControl.Class395 @class = new UpdateControl.Class395();
			@class.eventArgs_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025A9 RID: 9641 RVA: 0x00085288 File Offset: 0x00083488
		private void method_17(object sender, EventArgs9 e)
		{
			UpdateControl.Class396 @class = new UpdateControl.Class396();
			@class.eventArgs9_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025AA RID: 9642 RVA: 0x000852BC File Offset: 0x000834BC
		private void method_18(object sender, EventArgs26 e)
		{
			UpdateControl.Class397 @class = new UpdateControl.Class397();
			@class.eventArgs26_0 = e;
			@class.updateControl_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060025AB RID: 9643 RVA: 0x000852F0 File Offset: 0x000834F0
		private void method_19(EventArgs26 e)
		{
			if (e.PrematureExit)
			{
				e = new EventArgs26(true, this.string_1, e.ErrorMessage ?? this.string_2);
			}
			this.eventArgs26_0 = e;
			this.enum86_0 = UpdateControl.Enum86.const_6;
			this.method_20(this.bitmap_4, true);
		}

		// Token: 0x060025AC RID: 9644 RVA: 0x0001092A File Offset: 0x0000EB2A
		private void method_20(Image img, bool staticImg)
		{
			this.Animator.method_1();
			this.Animator.StaticImage = staticImg;
			this.Animator.AnimationInterval = 25;
			this.Animator.BaseImage = img;
			this.Animator.method_0();
		}

		// Token: 0x060025AD RID: 9645 RVA: 0x00085340 File Offset: 0x00083540
		public void method_21()
		{
			if (!base.DesignMode)
			{
				this.class151_0.method_18();
				if (this.class151_0.ClosingForInstall)
				{
					this.method_20(this.bitmap_1, false);
					this.MessageLabel.Text = "Installing update...";
					this.MessageLink.Visible = false;
					this.MessageLabel.Visible = true;
					return;
				}
				this.method_22();
			}
		}

		// Token: 0x060025AE RID: 9646 RVA: 0x00010967 File Offset: 0x0000EB67
		public bool method_22()
		{
			return this.method_23(false);
		}

		// Token: 0x060025AF RID: 9647 RVA: 0x00010970 File Offset: 0x0000EB70
		public bool method_23(bool recheck)
		{
			if (this.class151_0.UpdateStepOn != Enum111.const_0)
			{
				if (!recheck || this.class151_0.UpdateStepOn != Enum111.const_2)
				{
					return false;
				}
			}
			return this.class151_0.method_7(recheck);
		}

		// Token: 0x060025B0 RID: 9648 RVA: 0x000853AC File Offset: 0x000835AC
		private void MessageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			switch (this.enum86_0)
			{
			case UpdateControl.Enum86.const_1:
			case UpdateControl.Enum86.const_3:
			case UpdateControl.Enum86.const_4:
				this.CancelStrip.Show(this.MessageLink, new Point(0, this.MessageLink.Height));
				return;
			case UpdateControl.Enum86.const_2:
			case UpdateControl.Enum86.const_5:
				this.UpdateStrip.Show(this.MessageLink, new Point(0, this.MessageLink.Height));
				return;
			case UpdateControl.Enum86.const_6:
				this.UpdateFailedStrip.Show(this.MessageLink, new Point(0, this.MessageLink.Height));
				return;
			case UpdateControl.Enum86.const_7:
				this.UpToDateStrip.Show(this.MessageLink, new Point(0, this.MessageLink.Height));
				return;
			case UpdateControl.Enum86.const_8:
				this.UpdateStrip_1.Show(this.MessageLink, new Point(0, this.MessageLink.Height));
				return;
			default:
				return;
			}
		}

		// Token: 0x060025B1 RID: 9649 RVA: 0x000109A0 File Offset: 0x0000EBA0
		public void method_24()
		{
			this.class151_0.method_4();
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x000109AD File Offset: 0x0000EBAD
		private void StopCheckingMenuItem_Click(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x000109B5 File Offset: 0x0000EBB5
		private void TryAgainNowMenuItem_Click(object sender, EventArgs e)
		{
			this.method_23(true);
		}

		// Token: 0x060025B4 RID: 9652 RVA: 0x000109BF File Offset: 0x0000EBBF
		private void TryAgainLaterMenuItem_Click(object sender, EventArgs e)
		{
			if (this.eventHandler_10 != null)
			{
				this.eventHandler_10(this, EventArgs.Empty);
			}
		}

		// Token: 0x060025B5 RID: 9653 RVA: 0x00085498 File Offset: 0x00083698
		private void ViewErrorMenuItem_Click(object sender, EventArgs e)
		{
			using (frmError frmError = new frmError(this.eventArgs26_0))
			{
				frmError.ShowDialog(base.ParentForm);
				if (frmError.TryAgainLater && this.eventHandler_10 != null)
				{
					this.eventHandler_10(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x060025B6 RID: 9654 RVA: 0x000854FC File Offset: 0x000836FC
		private void UpdatedViewChangesMenuItem_Click(object sender, EventArgs e)
		{
			using (frmChanges frmChanges = new frmChanges(this.class151_0.Version, this.class151_0.RawChanges, this.class151_0.AreChangesRTF, this.bool_0))
			{
				frmChanges.ShowDialog(base.ParentForm);
				if (frmChanges.UpdateNow)
				{
					this.method_24();
				}
			}
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x000109DA File Offset: 0x0000EBDA
		private void DismissMenuItem_Click(object sender, EventArgs e)
		{
			if (this.eventHandler_13 != null)
			{
				this.eventHandler_13(this, e);
			}
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x000109F1 File Offset: 0x0000EBF1
		private void InstallMenuItem_Click(object sender, EventArgs e)
		{
			this.method_24();
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x000109F9 File Offset: 0x0000EBF9
		private void UpdatedHideMenuItem_Click(object sender, EventArgs e)
		{
			if (this.eventHandler_9 != null)
			{
				this.eventHandler_9(this, this.eventArgs7_0);
			}
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00010A15 File Offset: 0x0000EC15
		[CompilerGenerated]
		private void method_25()
		{
			this.method_0();
			this.method_9(Enum111.const_5);
			this.StopCheckingMenuItem.Text = "Stop extracting update for now";
			this.enum86_0 = UpdateControl.Enum86.const_4;
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00085570 File Offset: 0x00083770
		[CompilerGenerated]
		private void method_26()
		{
			this.method_0();
			if (this.class151_0.ClosingForInstall)
			{
				base.ParentForm.ShowInTaskbar = true;
				base.ParentForm.WindowState = FormWindowState.Normal;
			}
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, EventArgs.Empty);
			}
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00010A3B File Offset: 0x0000EC3B
		[CompilerGenerated]
		private void method_27()
		{
			this.method_0();
			if (this.eventHandler_11 != null)
			{
				this.eventHandler_11(this, EventArgs.Empty);
			}
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x000855C4 File Offset: 0x000837C4
		[CompilerGenerated]
		private void method_28()
		{
			this.method_0();
			this.method_9(this.class151_0.UpdateStepOn);
			switch (this.class151_0.UpdateStepOn)
			{
			case Enum111.const_1:
			case Enum111.const_3:
			case Enum111.const_5:
				this.method_20(this.bitmap_1, false);
				break;
			case Enum111.const_2:
			case Enum111.const_4:
				break;
			default:
				return;
			}
		}

		// Token: 0x040011DE RID: 4574
		private IContainer icontainer_0;

		// Token: 0x040011DF RID: 4575
		private Control2 Animator;

		// Token: 0x040011E0 RID: 4576
		private LinkLabel MessageLink;

		// Token: 0x040011E1 RID: 4577
		private Label MessageLabel;

		// Token: 0x040011E2 RID: 4578
		private ContextMenuStrip CancelStrip;

		// Token: 0x040011E3 RID: 4579
		private ToolStripMenuItem StopCheckingMenuItem;

		// Token: 0x040011E4 RID: 4580
		private ContextMenuStrip UpdateFailedStrip;

		// Token: 0x040011E5 RID: 4581
		private ToolStripMenuItem TryAgainNowMenuItem;

		// Token: 0x040011E6 RID: 4582
		private ToolStripMenuItem TryAgainLaterMenuItem;

		// Token: 0x040011E7 RID: 4583
		private ToolStripSeparator UpdateFailedSep;

		// Token: 0x040011E8 RID: 4584
		private ToolStripMenuItem ViewErrorMenuItem;

		// Token: 0x040011E9 RID: 4585
		private ContextMenuStrip UpdateStrip;

		// Token: 0x040011EA RID: 4586
		private ToolStripMenuItem InstallMenuItem;

		// Token: 0x040011EB RID: 4587
		private ToolStripMenuItem ViewChangesMenuItem;

		// Token: 0x040011EC RID: 4588
		private ContextMenuStrip UpdateStrip_1;

		// Token: 0x040011ED RID: 4589
		private ToolStripMenuItem UpdatedHideMenuItem;

		// Token: 0x040011EE RID: 4590
		private ToolStripMenuItem UpdatedViewChangesMenuItem;

		// Token: 0x040011EF RID: 4591
		private ContextMenuStrip UpToDateStrip;

		// Token: 0x040011F0 RID: 4592
		private ToolStripMenuItem DismissMenuItem;

		// Token: 0x040011F1 RID: 4593
		private EventHandler<EventArgs40> eventHandler_0;

		// Token: 0x040011F2 RID: 4594
		private EventHandler<EventArgs40> eventHandler_1;

		// Token: 0x040011F3 RID: 4595
		private EventHandler eventHandler_2;

		// Token: 0x040011F4 RID: 4596
		private EventHandler<EventArgs26> eventHandler_3;

		// Token: 0x040011F5 RID: 4597
		private EventHandler eventHandler_4;

		// Token: 0x040011F6 RID: 4598
		private EventHandler<EventArgs26> eventHandler_5;

		// Token: 0x040011F7 RID: 4599
		private EventHandler eventHandler_6;

		// Token: 0x040011F8 RID: 4600
		private EventHandler eventHandler_7;

		// Token: 0x040011F9 RID: 4601
		private EventHandler<EventArgs26> eventHandler_8;

		// Token: 0x040011FA RID: 4602
		private EventHandler<EventArgs7> eventHandler_9;

		// Token: 0x040011FB RID: 4603
		private EventHandler eventHandler_10;

		// Token: 0x040011FC RID: 4604
		private EventHandler eventHandler_11;

		// Token: 0x040011FD RID: 4605
		private EventHandler<EventArgs7> eventHandler_12;

		// Token: 0x040011FE RID: 4606
		private EventHandler eventHandler_13;

		// Token: 0x040011FF RID: 4607
		private readonly Bitmap bitmap_0;

		// Token: 0x04001200 RID: 4608
		private readonly Bitmap bitmap_1;

		// Token: 0x04001201 RID: 4609
		private readonly Bitmap bitmap_2;

		// Token: 0x04001202 RID: 4610
		private readonly Bitmap bitmap_3;

		// Token: 0x04001203 RID: 4611
		private readonly Bitmap bitmap_4;

		// Token: 0x04001204 RID: 4612
		private Class151 class151_0;

		// Token: 0x04001205 RID: 4613
		private UpdateControl.Enum86 enum86_0;

		// Token: 0x04001206 RID: 4614
		private string string_0;

		// Token: 0x04001207 RID: 4615
		private bool bool_0;

		// Token: 0x04001208 RID: 4616
		private EventArgs26 eventArgs26_0;

		// Token: 0x04001209 RID: 4617
		private EventArgs7 eventArgs7_0;

		// Token: 0x0400120A RID: 4618
		private readonly string string_1;

		// Token: 0x0400120B RID: 4619
		private readonly string string_2;

		// Token: 0x020003C8 RID: 968
		private enum Enum86
		{
			// Token: 0x0400120D RID: 4621
			const_0,
			// Token: 0x0400120E RID: 4622
			const_1,
			// Token: 0x0400120F RID: 4623
			const_2,
			// Token: 0x04001210 RID: 4624
			const_3,
			// Token: 0x04001211 RID: 4625
			const_4,
			// Token: 0x04001212 RID: 4626
			const_5,
			// Token: 0x04001213 RID: 4627
			const_6,
			// Token: 0x04001214 RID: 4628
			const_7,
			// Token: 0x04001215 RID: 4629
			const_8
		}

		// Token: 0x020003C9 RID: 969
		[CompilerGenerated]
		private sealed class Class386
		{
			// Token: 0x060025BF RID: 9663 RVA: 0x00085620 File Offset: 0x00083820
			public void method_0()
			{
				this.updateControl_0.method_0();
				if (this.updateControl_0.eventHandler_1 != null)
				{
					this.updateControl_0.eventHandler_1(this.updateControl_0, this.eventArgs40_0);
				}
				if (this.eventArgs40_0.Cancel)
				{
					return;
				}
				this.updateControl_0.method_9(Enum111.const_3);
				this.updateControl_0.method_20(this.updateControl_0.bitmap_1, false);
				this.updateControl_0.StopCheckingMenuItem.Text = "Stop downloading update for now";
				this.updateControl_0.enum86_0 = UpdateControl.Enum86.const_3;
			}

			// Token: 0x04001216 RID: 4630
			public UpdateControl updateControl_0;

			// Token: 0x04001217 RID: 4631
			public EventArgs40 eventArgs40_0;
		}

		// Token: 0x020003CA RID: 970
		[CompilerGenerated]
		private sealed class Class387
		{
			// Token: 0x060025C1 RID: 9665 RVA: 0x000856B4 File Offset: 0x000838B4
			public void method_0()
			{
				this.updateControl_0.method_0();
				this.updateControl_0.method_19(this.eventArgs26_0);
				this.updateControl_0.MessageLink.Text = "Failed to check for updates.";
				this.updateControl_0.MessageLink.Visible = true;
				this.updateControl_0.MessageLabel.Visible = false;
				if (this.updateControl_0.eventHandler_3 != null)
				{
					this.updateControl_0.eventHandler_3(this.updateControl_0, this.eventArgs26_0);
				}
			}

			// Token: 0x04001218 RID: 4632
			public UpdateControl updateControl_0;

			// Token: 0x04001219 RID: 4633
			public EventArgs26 eventArgs26_0;
		}

		// Token: 0x020003CB RID: 971
		[CompilerGenerated]
		private sealed class Class388
		{
			// Token: 0x060025C3 RID: 9667 RVA: 0x00085740 File Offset: 0x00083940
			public void method_0()
			{
				this.updateControl_0.method_19(this.eventArgs26_0);
				this.updateControl_0.MessageLink.Text = "Failed to download the update.";
				this.updateControl_0.MessageLink.Visible = true;
				this.updateControl_0.MessageLabel.Visible = false;
				if (this.updateControl_0.eventHandler_5 != null)
				{
					this.updateControl_0.eventHandler_5(this.updateControl_0, this.eventArgs26_0);
				}
			}

			// Token: 0x0400121A RID: 4634
			public UpdateControl updateControl_0;

			// Token: 0x0400121B RID: 4635
			public EventArgs26 eventArgs26_0;
		}

		// Token: 0x020003CC RID: 972
		[CompilerGenerated]
		private sealed class Class389
		{
			// Token: 0x060025C5 RID: 9669 RVA: 0x000857C0 File Offset: 0x000839C0
			public void method_0()
			{
				this.updateControl_0.method_0();
				this.updateControl_0.Animator.method_1();
				if (this.updateControl_0.eventHandler_2 != null)
				{
					this.updateControl_0.eventHandler_2(this.updateControl_0, this.eventArgs_0);
				}
			}

			// Token: 0x0400121C RID: 4636
			public UpdateControl updateControl_0;

			// Token: 0x0400121D RID: 4637
			public EventArgs eventArgs_0;
		}

		// Token: 0x020003CD RID: 973
		[CompilerGenerated]
		private sealed class Class390
		{
			// Token: 0x060025C7 RID: 9671 RVA: 0x00085814 File Offset: 0x00083A14
			public void method_0()
			{
				this.updateControl_0.method_0();
				if (this.updateControl_0.eventHandler_0 != null)
				{
					this.updateControl_0.eventHandler_0(this.updateControl_0, this.eventArgs40_0);
				}
				if (this.eventArgs40_0.Cancel)
				{
					this.updateControl_0.method_8();
					return;
				}
				this.updateControl_0.method_9(Enum111.const_1);
				this.updateControl_0.enum86_0 = UpdateControl.Enum86.const_1;
				this.updateControl_0.method_20(this.updateControl_0.bitmap_1, false);
			}

			// Token: 0x0400121E RID: 4638
			public UpdateControl updateControl_0;

			// Token: 0x0400121F RID: 4639
			public EventArgs40 eventArgs40_0;
		}

		// Token: 0x020003CE RID: 974
		[CompilerGenerated]
		private sealed class Class391
		{
			// Token: 0x060025C9 RID: 9673 RVA: 0x000858A0 File Offset: 0x00083AA0
			public void method_0()
			{
				this.updateControl_0.method_0();
				this.updateControl_0.MessageLink.Text = "You already have the latest version";
				this.updateControl_0.MessageLink.Visible = true;
				this.updateControl_0.MessageLabel.Visible = false;
				this.updateControl_0.enum86_0 = UpdateControl.Enum86.const_7;
				this.updateControl_0.method_20(this.updateControl_0.bitmap_3, true);
				this.updateControl_0.eventArgs7_0 = this.eventArgs7_0;
				if (this.updateControl_0.eventHandler_12 != null)
				{
					this.updateControl_0.eventHandler_12(this.updateControl_0, this.eventArgs7_0);
				}
			}

			// Token: 0x04001220 RID: 4640
			public UpdateControl updateControl_0;

			// Token: 0x04001221 RID: 4641
			public EventArgs7 eventArgs7_0;
		}

		// Token: 0x020003CF RID: 975
		[CompilerGenerated]
		private sealed class Class392
		{
			// Token: 0x060025CB RID: 9675 RVA: 0x0008594C File Offset: 0x00083B4C
			public void method_0()
			{
				this.updateControl_0.method_0();
				this.updateControl_0.MessageLink.Visible = false;
				this.updateControl_0.MessageLabel.Text = string.Format("Successfully updated to {0}.", this.updateControl_0.class151_0.Version);
				this.updateControl_0.MessageLabel.Visible = true;
				this.updateControl_0.bool_0 = false;
				this.updateControl_0.UpdatedViewChangesMenuItem.Text = string.Format("View changes in version {0}", this.updateControl_0.class151_0.Version);
				this.updateControl_0.enum86_0 = UpdateControl.Enum86.const_8;
				this.updateControl_0.method_20(this.updateControl_0.bitmap_3, true);
				this.updateControl_0.eventArgs7_0 = this.eventArgs7_0;
				if (this.updateControl_0.eventHandler_9 != null)
				{
					this.updateControl_0.eventHandler_9(this.updateControl_0, this.eventArgs7_0);
				}
			}

			// Token: 0x04001222 RID: 4642
			public UpdateControl updateControl_0;

			// Token: 0x04001223 RID: 4643
			public EventArgs7 eventArgs7_0;
		}

		// Token: 0x020003D0 RID: 976
		[CompilerGenerated]
		private sealed class Class393
		{
			// Token: 0x060025CD RID: 9677 RVA: 0x00085A44 File Offset: 0x00083C44
			public void method_0()
			{
				this.updateControl_0.method_0();
				this.updateControl_0.eventArgs26_0 = this.eventArgs26_0;
				this.updateControl_0.MessageLink.Text = "Update failed to install.";
				this.updateControl_0.MessageLink.Visible = true;
				this.updateControl_0.MessageLabel.Visible = false;
				this.updateControl_0.enum86_0 = UpdateControl.Enum86.const_6;
				this.updateControl_0.method_20(this.updateControl_0.bitmap_4, true);
				if (this.updateControl_0.eventHandler_8 != null)
				{
					this.updateControl_0.eventHandler_8(this.updateControl_0, this.eventArgs26_0);
				}
			}

			// Token: 0x04001224 RID: 4644
			public UpdateControl updateControl_0;

			// Token: 0x04001225 RID: 4645
			public EventArgs26 eventArgs26_0;
		}

		// Token: 0x020003D1 RID: 977
		[CompilerGenerated]
		private sealed class Class394
		{
			// Token: 0x060025CF RID: 9679 RVA: 0x00085AF0 File Offset: 0x00083CF0
			public void method_0()
			{
				this.updateControl_0.method_0();
				this.updateControl_0.InstallMenuItem.Text = "&Download update now";
				this.updateControl_0.ViewChangesMenuItem.Text = string.Format("View changes in version {0}", this.updateControl_0.class151_0.Version);
				this.updateControl_0.enum86_0 = UpdateControl.Enum86.const_5;
				this.updateControl_0.bool_0 = true;
				this.updateControl_0.method_9(Enum111.const_2);
				this.updateControl_0.method_20(this.updateControl_0.bitmap_2, true);
				if (this.updateControl_0.eventHandler_7 != null)
				{
					this.updateControl_0.eventHandler_7(this.updateControl_0, this.eventArgs_0);
				}
			}

			// Token: 0x04001226 RID: 4646
			public UpdateControl updateControl_0;

			// Token: 0x04001227 RID: 4647
			public EventArgs eventArgs_0;
		}

		// Token: 0x020003D2 RID: 978
		[CompilerGenerated]
		private sealed class Class395
		{
			// Token: 0x060025D1 RID: 9681 RVA: 0x00085BAC File Offset: 0x00083DAC
			public void method_0()
			{
				this.updateControl_0.method_0();
				this.updateControl_0.InstallMenuItem.Text = "&Install update now";
				this.updateControl_0.ViewChangesMenuItem.Text = string.Format("View changes in version {0}", this.updateControl_0.class151_0.Version);
				this.updateControl_0.enum86_0 = UpdateControl.Enum86.const_5;
				this.updateControl_0.bool_0 = true;
				this.updateControl_0.method_9(this.updateControl_0.class151_0.UpdateStepOn);
				this.updateControl_0.method_20(this.updateControl_0.bitmap_0, true);
				if (this.updateControl_0.eventHandler_6 != null)
				{
					this.updateControl_0.eventHandler_6(this.updateControl_0, this.eventArgs_0);
				}
			}

			// Token: 0x04001228 RID: 4648
			public UpdateControl updateControl_0;

			// Token: 0x04001229 RID: 4649
			public EventArgs eventArgs_0;
		}

		// Token: 0x020003D3 RID: 979
		[CompilerGenerated]
		private sealed class Class396
		{
			// Token: 0x060025D3 RID: 9683 RVA: 0x00085C78 File Offset: 0x00083E78
			public void method_0()
			{
				if (this.eventArgs9_0.PercentComplete > 0)
				{
					this.updateControl_0.MessageLink.Text = string.Concat(new object[]
					{
						this.updateControl_0.string_0,
						", ",
						this.eventArgs9_0.PercentComplete,
						"%"
					});
				}
			}

			// Token: 0x0400122A RID: 4650
			public UpdateControl updateControl_0;

			// Token: 0x0400122B RID: 4651
			public EventArgs9 eventArgs9_0;
		}

		// Token: 0x020003D4 RID: 980
		[CompilerGenerated]
		private sealed class Class397
		{
			// Token: 0x060025D5 RID: 9685 RVA: 0x00085CE4 File Offset: 0x00083EE4
			public void method_0()
			{
				this.updateControl_0.method_0();
				this.updateControl_0.method_19(this.eventArgs26_0);
				this.updateControl_0.MessageLink.Text = "Failed to extract the update.";
				this.updateControl_0.MessageLink.Visible = true;
				this.updateControl_0.MessageLabel.Visible = false;
				if (this.updateControl_0.eventHandler_5 != null)
				{
					this.updateControl_0.eventHandler_5(this.updateControl_0, this.eventArgs26_0);
				}
			}

			// Token: 0x0400122C RID: 4652
			public UpdateControl updateControl_0;

			// Token: 0x0400122D RID: 4653
			public EventArgs26 eventArgs26_0;
		}
	}
}
