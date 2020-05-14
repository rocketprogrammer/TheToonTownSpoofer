using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ns14;
using ns15;
using ns16;
using ns17;
using ns18;
using ns19;
using ns20;
using ns21;
using ns23;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns31;

namespace ns22
{
	// Token: 0x0200035B RID: 859
	internal sealed class Class330 : ApplicationContext
	{
		// Token: 0x060021C2 RID: 8642 RVA: 0x000723CC File Offset: 0x000705CC
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
				if (this.mainForm_0 != null)
				{
					this.mainForm_0.Dispose();
				}
				if (this.control_0 != null)
				{
					this.control_0.Dispose();
				}
				ParTeePutt[] array = this.list_1.ToArray();
				foreach (ParTeePutt parTeePutt in array)
				{
					parTeePutt.Close();
				}
				if (this.contextMenuStrip_0 != null)
				{
					this.contextMenuStrip_0.Dispose();
				}
				if (this.notifyIcon_0 != null)
				{
					this.notifyIcon_0.Dispose();
				}
				if (this.toolStripMenuItem_0 != null)
				{
					this.toolStripMenuItem_0.Dispose();
				}
				if (this.toolStripMenuItem_1 != null)
				{
					this.toolStripMenuItem_1.Dispose();
				}
				if (this.toolStripMenuItem_2 != null)
				{
					this.toolStripMenuItem_2.Dispose();
				}
				if (this.toolStripMenuItem_3 != null)
				{
					this.toolStripMenuItem_3.Dispose();
				}
				if (this.toolStripMenuItem_4 != null)
				{
					this.toolStripMenuItem_4.Dispose();
				}
				if (this.toolStripSeparator_0 != null)
				{
					this.toolStripSeparator_0.Dispose();
				}
				if (this.toolStripMenuItem_5 != null)
				{
					this.toolStripMenuItem_5.Dispose();
				}
				if (this.toolStripMenuItem_6 != null)
				{
					this.toolStripMenuItem_6.Dispose();
				}
				if (this.toolStripMenuItem_7 != null)
				{
					this.toolStripMenuItem_7.Dispose();
				}
				if (this.toolStripMenuItem_8 != null)
				{
					this.toolStripMenuItem_8.Dispose();
				}
				if (this.toolStripMenuItem_9 != null)
				{
					this.toolStripMenuItem_9.Dispose();
				}
				if (this.toolStripMenuItem_10 != null)
				{
					this.toolStripMenuItem_10.Dispose();
				}
				if (this.toolStripMenuItem_11 != null)
				{
					this.toolStripMenuItem_11.Dispose();
				}
				if (this.toolStripSeparator_1 != null)
				{
					this.toolStripSeparator_1.Dispose();
				}
				if (this.toolStripMenuItem_12 != null)
				{
					this.toolStripMenuItem_12.Dispose();
				}
				if (this.toolStripMenuItem_13 != null)
				{
					this.toolStripMenuItem_13.Dispose();
				}
				if (this.toolStripMenuItem_14 != null)
				{
					this.toolStripMenuItem_14.Dispose();
				}
				if (this.toolStripMenuItem_15 != null)
				{
					this.toolStripMenuItem_15.Dispose();
				}
				if (this.toolStripSeparator_2 != null)
				{
					this.toolStripSeparator_2.Dispose();
				}
				if (this.toolStripMenuItem_16 != null)
				{
					this.toolStripMenuItem_16.Dispose();
				}
				if (this.toolStripSeparator_3 != null)
				{
					this.toolStripSeparator_3.Dispose();
				}
				if (this.toolStripMenuItem_17 != null)
				{
					this.toolStripMenuItem_17.Dispose();
				}
				if (this.class520_0 != null)
				{
					this.class520_0.Dispose();
				}
				if (Class330.class205_0 != null)
				{
					Class330.class205_0.Dispose();
				}
				if (this.class318_0 != null)
				{
					this.class318_0.Dispose();
				}
				if (this.fileSystemWatcher_1 != null)
				{
					this.fileSystemWatcher_1.Dispose();
				}
				if (this.fileSystemWatcher_0 != null)
				{
					this.fileSystemWatcher_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x0007266C File Offset: 0x0007086C
		private void method_0()
		{
			this.icontainer_0 = new Container();
			this.fileSystemWatcher_0 = new FileSystemWatcher();
			((ISupportInitialize)this.fileSystemWatcher_0).BeginInit();
			this.fileSystemWatcher_1 = new FileSystemWatcher();
			((ISupportInitialize)this.fileSystemWatcher_1).BeginInit();
			this.notifyIcon_0 = new NotifyIcon(this.icontainer_0);
			this.contextMenuStrip_0 = new ContextMenuStrip(this.icontainer_0);
			this.toolStripMenuItem_0 = new ToolStripMenuItem();
			this.toolStripMenuItem_1 = new ToolStripMenuItem();
			this.toolStripMenuItem_2 = new ToolStripMenuItem();
			this.toolStripMenuItem_3 = new ToolStripMenuItem();
			this.toolStripMenuItem_4 = new ToolStripMenuItem();
			this.toolStripSeparator_0 = new ToolStripSeparator();
			this.toolStripMenuItem_5 = new ToolStripMenuItem();
			this.toolStripMenuItem_6 = new ToolStripMenuItem();
			this.toolStripMenuItem_7 = new ToolStripMenuItem();
			this.toolStripMenuItem_8 = new ToolStripMenuItem();
			this.toolStripMenuItem_9 = new ToolStripMenuItem();
			this.toolStripMenuItem_10 = new ToolStripMenuItem();
			this.toolStripMenuItem_11 = new ToolStripMenuItem();
			this.toolStripSeparator_1 = new ToolStripSeparator();
			this.toolStripMenuItem_12 = new ToolStripMenuItem();
			this.toolStripMenuItem_15 = new ToolStripMenuItem();
			this.toolStripMenuItem_13 = new ToolStripMenuItem();
			this.toolStripMenuItem_14 = new ToolStripMenuItem();
			this.toolStripSeparator_2 = new ToolStripSeparator();
			this.toolStripMenuItem_16 = new ToolStripMenuItem();
			this.toolStripSeparator_3 = new ToolStripSeparator();
			this.toolStripMenuItem_17 = new ToolStripMenuItem();
			this.class520_0 = new Class520(this.icontainer_0);
			Class330.class205_0 = new Class205(this.icontainer_0);
			this.class318_0 = new Class318(this.icontainer_0);
			this.contextMenuStrip_0.SuspendLayout();
			this.notifyIcon_0.ContextMenuStrip = this.contextMenuStrip_0;
			this.notifyIcon_0.Text = "The ToonTown Spoofer";
			this.notifyIcon_0.Icon = Class283.Icon;
			this.notifyIcon_0.BalloonTipIcon = ToolTipIcon.Info;
			this.notifyIcon_0.BalloonTipTitle = "Task Mode";
			this.notifyIcon_0.BalloonTipText = "The ToonTown Spoofer has been placed in the Notification Area, right click the icon to access all the features. Select Switch to Visual Mode to restore the main window.";
			this.contextMenuStrip_0.ImageScalingSize = new Size(20, 20);
			this.contextMenuStrip_0.Items.AddRange(new ToolStripItem[]
			{
				this.toolStripMenuItem_0,
				this.toolStripMenuItem_1,
				this.toolStripMenuItem_3,
				this.toolStripMenuItem_4,
				this.toolStripMenuItem_2,
				this.toolStripSeparator_0,
				this.toolStripMenuItem_5,
				this.toolStripMenuItem_6,
				this.toolStripMenuItem_7,
				this.toolStripMenuItem_8,
				this.toolStripMenuItem_9,
				this.toolStripMenuItem_10,
				this.toolStripMenuItem_11,
				this.toolStripSeparator_1,
				this.toolStripMenuItem_12,
				this.toolStripMenuItem_15,
				this.toolStripMenuItem_13,
				this.toolStripMenuItem_14,
				this.toolStripSeparator_2,
				this.toolStripMenuItem_16,
				this.toolStripSeparator_3,
				this.toolStripMenuItem_17
			});
			this.contextMenuStrip_0.Name = "MainContextMenuStrip";
			this.contextMenuStrip_0.Size = new Size(196, 466);
			this.toolStripMenuItem_0.Image = Class491.AboutMenuItem_Image;
			this.toolStripMenuItem_0.Name = "AboutMenuItem";
			this.toolStripMenuItem_0.Size = new Size(195, 26);
			this.toolStripMenuItem_0.Text = "About";
			this.toolStripMenuItem_0.Click += this.toolStripMenuItem_0_Click;
			this.toolStripMenuItem_1.Image = Class491.UpdatingMenuItem_Image;
			this.toolStripMenuItem_1.Name = "CheckForUpdatesMenuItem";
			this.toolStripMenuItem_1.Size = new Size(195, 26);
			this.toolStripMenuItem_1.Text = "Check for Updates";
			this.toolStripMenuItem_1.Click += this.toolStripMenuItem_1_Click;
			this.toolStripMenuItem_2.Image = Class491.ReleaseNotesMenuItem_Image;
			this.toolStripMenuItem_2.Name = "ReleaseNotesMenuItem";
			this.toolStripMenuItem_2.Size = new Size(195, 26);
			this.toolStripMenuItem_2.Text = "Release Notes";
			this.toolStripMenuItem_2.Click += this.toolStripMenuItem_2_Click;
			this.toolStripMenuItem_3.Image = Class491.OptionsMenuItem_Image;
			this.toolStripMenuItem_3.Name = "OptionsMenuItem";
			this.toolStripMenuItem_3.Size = new Size(195, 26);
			this.toolStripMenuItem_3.Text = "Options";
			this.toolStripMenuItem_3.Click += this.toolStripMenuItem_3_Click;
			this.toolStripMenuItem_4.Image = Class491.GuideMenuItem_Image;
			this.toolStripMenuItem_4.Name = "GuideMenuItem";
			this.toolStripMenuItem_4.Size = new Size(195, 26);
			this.toolStripMenuItem_4.Text = "Guide";
			this.toolStripMenuItem_4.Click += this.toolStripMenuItem_4_Click;
			this.toolStripSeparator_0.Name = "toolStripSeparator1";
			this.toolStripSeparator_0.Size = new Size(192, 6);
			this.toolStripMenuItem_5.Image = Class491.InvasionsMenuItem_Image;
			this.toolStripMenuItem_5.Name = "InvasionsMenuItem";
			this.toolStripMenuItem_5.Size = new Size(195, 26);
			this.toolStripMenuItem_5.Text = "Invasions";
			this.toolStripMenuItem_5.Click += this.toolStripMenuItem_5_Click;
			this.toolStripMenuItem_6.Image = Class491.JoeFishMenuItem_Image;
			this.toolStripMenuItem_6.Name = "JoeFishMenuItem";
			this.toolStripMenuItem_6.Size = new Size(195, 26);
			this.toolStripMenuItem_6.Text = "Joe Fish";
			this.toolStripMenuItem_6.Click += this.toolStripMenuItem_6_Click;
			this.toolStripMenuItem_7.Image = Class491.GardenerFloraMenuItem_Image;
			this.toolStripMenuItem_7.Name = "GardenerFloraMenuItem";
			this.toolStripMenuItem_7.Size = new Size(195, 26);
			this.toolStripMenuItem_7.Text = "Gardener Flora";
			this.toolStripMenuItem_7.Click += this.toolStripMenuItem_7_Click;
			this.toolStripMenuItem_8.Image = Class491.GagAMaticMenuItem_Image;
			this.toolStripMenuItem_8.Name = "GagAMaticMenuItem";
			this.toolStripMenuItem_8.Size = new Size(195, 26);
			this.toolStripMenuItem_8.Text = "Gag-A-Matic";
			this.toolStripMenuItem_8.Click += this.toolStripMenuItem_8_Click;
			this.toolStripMenuItem_9.Image = Class491.ParTeePuttMenuItem_Image;
			this.toolStripMenuItem_9.Name = "ParTeePuttMenuItem";
			this.toolStripMenuItem_9.Size = new Size(195, 26);
			this.toolStripMenuItem_9.Text = "ParTee Putt";
			this.toolStripMenuItem_9.Click += this.toolStripMenuItem_9_Click;
			this.toolStripMenuItem_10.Image = Class491.RaceTrackMenuItem_Image;
			this.toolStripMenuItem_10.Name = "RaceTrackMenuItem";
			this.toolStripMenuItem_10.Size = new Size(195, 26);
			this.toolStripMenuItem_10.Text = "Race Track";
			this.toolStripMenuItem_10.Click += this.toolStripMenuItem_10_Click;
			this.toolStripMenuItem_11.Image = Class491.RemoteControlMenuItem_Image;
			this.toolStripMenuItem_11.Name = "RemoteControlMenuItem";
			this.toolStripMenuItem_11.Size = new Size(195, 26);
			this.toolStripMenuItem_11.Text = "Remote Control";
			this.toolStripMenuItem_11.Click += this.toolStripMenuItem_11_Click;
			this.toolStripSeparator_1.Name = "toolStripSeparator2";
			this.toolStripSeparator_1.Size = new Size(192, 6);
			this.toolStripMenuItem_12.Image = Class491.ContentPacksMenuItem_Image;
			this.toolStripMenuItem_12.Name = "ContentPacksMenuItem";
			this.toolStripMenuItem_12.Size = new Size(195, 26);
			this.toolStripMenuItem_12.Text = "Content Packs";
			this.toolStripMenuItem_12.Click += this.toolStripMenuItem_12_Click;
			this.toolStripMenuItem_15.Image = Class491.SwitchHotkeysMenuItem_Image;
			this.toolStripMenuItem_15.Name = "SwitchHotkeysMenuItem";
			this.toolStripMenuItem_15.Size = new Size(195, 26);
			this.toolStripMenuItem_15.Text = "Enable Hotkeys";
			this.toolStripMenuItem_15.Click += this.toolStripMenuItem_15_Click;
			this.toolStripMenuItem_13.Image = Class491.MyGalleryMenuItem_Image;
			this.toolStripMenuItem_13.Name = "MyGalleryMenuItem";
			this.toolStripMenuItem_13.Size = new Size(195, 26);
			this.toolStripMenuItem_13.Text = "My Gallery";
			this.toolStripMenuItem_13.Click += this.toolStripMenuItem_13_Click;
			this.toolStripMenuItem_14.Image = Class491.SwitchToVisualModeMenuItem_Image;
			this.toolStripMenuItem_14.Name = "SwitchToVisualModeMenuItem";
			this.toolStripMenuItem_14.Size = new Size(195, 26);
			this.toolStripMenuItem_14.Text = "Switch to Visual Mode";
			this.toolStripMenuItem_14.Click += this.toolStripMenuItem_14_Click;
			this.toolStripSeparator_2.Name = "toolStripSeparator3";
			this.toolStripSeparator_2.Size = new Size(192, 6);
			this.toolStripMenuItem_16.Image = Class491.ConnectMenuItem_Image;
			this.toolStripMenuItem_16.Name = "ConnectMenuItem";
			this.toolStripMenuItem_16.Size = new Size(195, 26);
			this.toolStripMenuItem_16.Text = "Connect";
			this.toolStripMenuItem_16.Click += this.toolStripMenuItem_16_Click;
			this.toolStripSeparator_3.Name = "toolStripSeparator4";
			this.toolStripSeparator_3.Size = new Size(192, 6);
			this.toolStripMenuItem_17.Image = Class491.ExitMenuItem_Image;
			this.toolStripMenuItem_17.Name = "ExitMenuItem";
			this.toolStripMenuItem_17.Size = new Size(195, 26);
			this.toolStripMenuItem_17.Text = "Exit";
			this.toolStripMenuItem_17.Click += this.toolStripMenuItem_17_Click;
			this.class318_0.HotkeyActivated += this.method_3;
			this.fileSystemWatcher_0.EnableRaisingEvents = false;
			this.fileSystemWatcher_0.Filter = "*.jpg";
			this.fileSystemWatcher_0.SynchronizingObject = null;
			this.fileSystemWatcher_0.Path = Class291.ToonTownOpenDataDirectory;
			((ISupportInitialize)this.fileSystemWatcher_0).EndInit();
			this.fileSystemWatcher_1.EnableRaisingEvents = false;
			this.fileSystemWatcher_1.Filter = "*.jpg";
			this.fileSystemWatcher_1.SynchronizingObject = null;
			this.fileSystemWatcher_1.Path = Class291.ToonTownTestDataDirectory;
			((ISupportInitialize)this.fileSystemWatcher_1).EndInit();
			this.contextMenuStrip_0.ResumeLayout(false);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00073168 File Offset: 0x00071368
		public Class330()
		{
			this.method_0();
			this.list_1 = new List<ParTeePutt>();
			this.list_0 = new List<Form>();
			this.control_0 = new Control();
			this.control_0.CreateControl();
			this.class112_0 = Class110.Instance.ApplicationSettings;
			this.class385_0 = new Class385(2);
			this.taskFactory_0 = new TaskFactory(this.class385_0);
			this.fileSystemWatcher_0.Created += this.fileSystemWatcher_1_Created;
			this.fileSystemWatcher_1.Created += this.fileSystemWatcher_1_Created;
			FileSystemWatcher fileSystemWatcher = this.fileSystemWatcher_0;
			this.fileSystemWatcher_1.EnableRaisingEvents = true;
			fileSystemWatcher.EnableRaisingEvents = true;
			this.class318_0.method_5(Keys.Oemplus, Keys.Control, false);
			this.class318_0.method_5(Keys.Oemplus, Keys.Shift | Keys.Control, false);
			if (this.class112_0.HotkeysEnabled)
			{
				Class330.class205_0.method_0();
			}
			this.toolStripMenuItem_15.Text = this.method_4();
			string text = Path.Combine(Class291.ToonTownOpenDataDirectory, Class330.string_0);
			if (Class369.smethod_3(text))
			{
				Class110.Instance.CreatedFileArchive.method_4(text);
			}
			text = Path.Combine(Class291.ToonTownOpenDataDirectory, Class330.string_1);
			if (Class369.smethod_3(text))
			{
				Class110.Instance.CreatedFileArchive.method_4(text);
			}
			if (this.class112_0.UseVisualMode)
			{
				this.method_16();
			}
			else
			{
				this.notifyIcon_0.Visible = true;
				this.method_14();
			}
			Class129.smethod_18(Class291.ToonTownOpenDataDirectory, 10);
			Class129.smethod_18(Class291.ToonTownTestDataDirectory, 10);
			this.method_2(Class409.Current, false);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x00073314 File Offset: 0x00071514
		private void fileSystemWatcher_1_Created(object sender, FileSystemEventArgs e)
		{
			Action action = null;
			Class330.Class331 @class = new Class330.Class331();
			@class.fileSystemEventArgs_0 = e;
			@class.class330_0 = this;
			WatcherChangeTypes changeType = @class.fileSystemEventArgs_0.ChangeType;
			if (changeType != WatcherChangeTypes.Created)
			{
				return;
			}
			TaskFactory taskFactory = this.taskFactory_0;
			if (action == null)
			{
				action = new Action(@class.method_0);
			}
			taskFactory.StartNew(action);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x00073368 File Offset: 0x00071568
		public void method_1(Class409 args)
		{
			Class330.Class332 @class = new Class330.Class332();
			@class.class409_0 = args;
			@class.class330_0 = this;
			this.control_0.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x000733A0 File Offset: 0x000715A0
		private void method_2(Class409 args, bool invoked)
		{
			List<string> list = new List<string>();
			foreach (string text in args.Values)
			{
				if (!string.IsNullOrEmpty(text) && Path.GetExtension(text) == ".ttp" && File.Exists(text))
				{
					list.Add(text);
				}
			}
			if (list.Count > 0)
			{
				this.method_21(list);
				return;
			}
			if (invoked)
			{
				if (this.class112_0.UseVisualMode)
				{
					this.mainForm_0.BringToFront();
					this.mainForm_0.Activate();
					return;
				}
				this.method_15();
			}
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x0000E1A7 File Offset: 0x0000C3A7
		private void method_3(object sender, EventArgs18 e)
		{
			this.control_0.smethod_4(new MethodInvoker(this.method_26));
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x0000E1C0 File Offset: 0x0000C3C0
		private string method_4()
		{
			if (this.class112_0.HotkeysEnabled)
			{
				return "Disable &Hotkeys";
			}
			return "Enable &Hotkeys";
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x0000E1DA File Offset: 0x0000C3DA
		private void toolStripMenuItem_16_Click(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x00073454 File Offset: 0x00071654
		private void method_5()
		{
			bool created;
			Form f = this.class520_0.method_3<Connect>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x00073480 File Offset: 0x00071680
		private void method_6(Form f, bool created)
		{
			FormClosedEventHandler formClosedEventHandler = null;
			Class330.Class333 @class = new Class330.Class333();
			@class.form_0 = f;
			@class.class330_0 = this;
			if (created)
			{
				Form form_ = @class.form_0;
				if (formClosedEventHandler == null)
				{
					formClosedEventHandler = new FormClosedEventHandler(@class.method_0);
				}
				form_.FormClosed += formClosedEventHandler;
				this.list_0.Add(@class.form_0);
			}
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x0000E1E2 File Offset: 0x0000C3E2
		private void toolStripMenuItem_5_Click(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x000734D4 File Offset: 0x000716D4
		private void method_7()
		{
			bool created;
			Form f = this.class520_0.method_3<Invasions>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x0000E1EA File Offset: 0x0000C3EA
		private void toolStripMenuItem_6_Click(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x00073500 File Offset: 0x00071700
		private void method_8()
		{
			bool created;
			Form f = this.class520_0.method_3<JoeFish>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x0000E1F2 File Offset: 0x0000C3F2
		private void toolStripMenuItem_7_Click(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0007352C File Offset: 0x0007172C
		private void method_9()
		{
			bool created;
			Form f = this.class520_0.method_3<GardenerFlora>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0000E1FA File Offset: 0x0000C3FA
		private void toolStripMenuItem_8_Click(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00073558 File Offset: 0x00071758
		private void method_10()
		{
			bool created;
			Form f = this.class520_0.method_3<GagAMatic>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x0000E202 File Offset: 0x0000C402
		private void toolStripMenuItem_9_Click(object sender, EventArgs e)
		{
			this.method_11();
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00073584 File Offset: 0x00071784
		private void method_11()
		{
			FormClosingEventHandler formClosingEventHandler = null;
			Class330.Class334 @class = new Class330.Class334();
			@class.class330_0 = this;
			if (this.list_1.Count > 0 && (@class.parTeePutt_0 = this.list_1.Last<ParTeePutt>()).Visible)
			{
				if (@class.parTeePutt_0.WindowState == FormWindowState.Minimized)
				{
					@class.parTeePutt_0.WindowState = FormWindowState.Normal;
				}
				@class.parTeePutt_0.BringToFront();
				@class.parTeePutt_0.Activate();
				return;
			}
			@class.parTeePutt_0 = new ParTeePutt();
			Form parTeePutt_ = @class.parTeePutt_0;
			if (formClosingEventHandler == null)
			{
				formClosingEventHandler = new FormClosingEventHandler(@class.method_0);
			}
			parTeePutt_.FormClosing += formClosingEventHandler;
			this.list_1.Add(@class.parTeePutt_0);
			this.method_6(@class.parTeePutt_0, true);
			@class.parTeePutt_0.Show();
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x0000E20A File Offset: 0x0000C40A
		private void toolStripMenuItem_10_Click(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x0007364C File Offset: 0x0007184C
		private void method_12()
		{
			bool created;
			Form f = this.class520_0.method_3<RaceTrack>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x0000E212 File Offset: 0x0000C412
		private void toolStripMenuItem_11_Click(object sender, EventArgs e)
		{
			this.method_13();
		}

		// Token: 0x060021DA RID: 8666 RVA: 0x00073678 File Offset: 0x00071878
		private void method_13()
		{
			bool created;
			Form f = this.class520_0.method_3<RemoteControl>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021DB RID: 8667 RVA: 0x0000E21A File Offset: 0x0000C41A
		private void toolStripMenuItem_14_Click(object sender, EventArgs e)
		{
			this.class112_0.UseVisualMode = true;
			this.method_16();
			this.notifyIcon_0.Visible = false;
		}

		// Token: 0x060021DC RID: 8668 RVA: 0x0000E23A File Offset: 0x0000C43A
		private void method_14()
		{
			if (this.class112_0.DisplayNotifyBalloon)
			{
				this.method_15();
				this.class112_0.DisplayNotifyBalloon = false;
			}
		}

		// Token: 0x060021DD RID: 8669 RVA: 0x0000E25B File Offset: 0x0000C45B
		private void method_15()
		{
			this.notifyIcon_0.ShowBalloonTip(10000);
		}

		// Token: 0x060021DE RID: 8670 RVA: 0x000736A4 File Offset: 0x000718A4
		private void method_16()
		{
			EventHandler eventHandler = null;
			FormClosedEventHandler formClosedEventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			EventHandler eventHandler4 = null;
			EventHandler<EventArgs24> eventHandler5 = null;
			EventHandler eventHandler6 = null;
			EventHandler eventHandler7 = null;
			EventHandler eventHandler8 = null;
			EventHandler eventHandler9 = null;
			EventHandler eventHandler10 = null;
			EventHandler eventHandler11 = null;
			EventHandler eventHandler12 = null;
			EventHandler eventHandler13 = null;
			EventHandler eventHandler14 = null;
			EventHandler eventHandler15 = null;
			EventHandler eventHandler16 = null;
			EventHandler eventHandler17 = null;
			if (this.mainForm_0 == null)
			{
				this.mainForm_0 = new MainForm(this.class520_0);
				this.mainForm_0.Icon = Class283.Icon;
				MainForm mainForm = this.mainForm_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_27);
				}
				mainForm.MoveToNotificationArea += eventHandler;
				Form form = this.mainForm_0;
				if (formClosedEventHandler == null)
				{
					formClosedEventHandler = new FormClosedEventHandler(this.method_28);
				}
				form.FormClosed += formClosedEventHandler;
				MainForm mainForm2 = this.mainForm_0;
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler(this.method_29);
				}
				mainForm2.CheckForUpdatesLaunched += eventHandler2;
				MainForm mainForm3 = this.mainForm_0;
				if (eventHandler3 == null)
				{
					eventHandler3 = new EventHandler(this.method_30);
				}
				mainForm3.MyGalleryLaunched += eventHandler3;
				MainForm mainForm4 = this.mainForm_0;
				if (eventHandler4 == null)
				{
					eventHandler4 = new EventHandler(this.method_31);
				}
				mainForm4.ContentPacksLaunched += eventHandler4;
				MainForm mainForm5 = this.mainForm_0;
				if (eventHandler5 == null)
				{
					eventHandler5 = new EventHandler<EventArgs24>(this.method_32);
				}
				mainForm5.HotkeysLaunched += eventHandler5;
				MainForm mainForm6 = this.mainForm_0;
				if (eventHandler6 == null)
				{
					eventHandler6 = new EventHandler(this.method_33);
				}
				mainForm6.GuideLaunched += eventHandler6;
				MainForm mainForm7 = this.mainForm_0;
				if (eventHandler7 == null)
				{
					eventHandler7 = new EventHandler(this.method_34);
				}
				mainForm7.ReleaseNotesLaunched += eventHandler7;
				MainForm mainForm8 = this.mainForm_0;
				if (eventHandler8 == null)
				{
					eventHandler8 = new EventHandler(this.method_35);
				}
				mainForm8.AboutLaunched += eventHandler8;
				MainForm mainForm9 = this.mainForm_0;
				if (eventHandler9 == null)
				{
					eventHandler9 = new EventHandler(this.method_36);
				}
				mainForm9.OptionsLaunched += eventHandler9;
				MainForm mainForm10 = this.mainForm_0;
				if (eventHandler10 == null)
				{
					eventHandler10 = new EventHandler(this.method_37);
				}
				mainForm10.RemoteControlLaunched += eventHandler10;
				MainForm mainForm11 = this.mainForm_0;
				if (eventHandler11 == null)
				{
					eventHandler11 = new EventHandler(this.method_38);
				}
				mainForm11.RaceTrackLaunched += eventHandler11;
				MainForm mainForm12 = this.mainForm_0;
				if (eventHandler12 == null)
				{
					eventHandler12 = new EventHandler(this.method_39);
				}
				mainForm12.GagAMaticLaunched += eventHandler12;
				MainForm mainForm13 = this.mainForm_0;
				if (eventHandler13 == null)
				{
					eventHandler13 = new EventHandler(this.method_40);
				}
				mainForm13.GardenerFloraLaunched += eventHandler13;
				MainForm mainForm14 = this.mainForm_0;
				if (eventHandler14 == null)
				{
					eventHandler14 = new EventHandler(this.method_41);
				}
				mainForm14.JoeFishLaunched += eventHandler14;
				MainForm mainForm15 = this.mainForm_0;
				if (eventHandler15 == null)
				{
					eventHandler15 = new EventHandler(this.method_42);
				}
				mainForm15.InvasionsLaunched += eventHandler15;
				MainForm mainForm16 = this.mainForm_0;
				if (eventHandler16 == null)
				{
					eventHandler16 = new EventHandler(this.method_43);
				}
				mainForm16.ConnectLaunched += eventHandler16;
				MainForm mainForm17 = this.mainForm_0;
				if (eventHandler17 == null)
				{
					eventHandler17 = new EventHandler(this.method_44);
				}
				mainForm17.ParTeePuttLaunched += eventHandler17;
				this.mainForm_0.Show();
				return;
			}
			if (this.mainForm_0.Visible)
			{
				this.mainForm_0.BringToFront();
				this.mainForm_0.Activate();
			}
		}

		// Token: 0x060021DF RID: 8671 RVA: 0x0000E26D File Offset: 0x0000C46D
		private void toolStripMenuItem_0_Click(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x060021E0 RID: 8672 RVA: 0x00073960 File Offset: 0x00071B60
		private void method_17()
		{
			bool created;
			Form f = this.class520_0.method_3<AboutForm>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021E1 RID: 8673 RVA: 0x0000E275 File Offset: 0x0000C475
		private void toolStripMenuItem_2_Click(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x060021E2 RID: 8674 RVA: 0x0007398C File Offset: 0x00071B8C
		private void method_18()
		{
			bool created;
			Form f = this.class520_0.method_3<ReleaseNotes>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021E3 RID: 8675 RVA: 0x0000E27D File Offset: 0x0000C47D
		private void toolStripMenuItem_3_Click(object sender, EventArgs e)
		{
			this.method_19();
		}

		// Token: 0x060021E4 RID: 8676 RVA: 0x000739B8 File Offset: 0x00071BB8
		private void method_19()
		{
			bool created;
			Form f = this.class520_0.method_3<Options>(out created, new object[0]);
			this.method_6(f, created);
		}

		// Token: 0x060021E5 RID: 8677 RVA: 0x0000E285 File Offset: 0x0000C485
		private void toolStripMenuItem_1_Click(object sender, EventArgs e)
		{
			this.method_20();
		}

		// Token: 0x060021E6 RID: 8678 RVA: 0x000739E4 File Offset: 0x00071BE4
		private void method_20()
		{
			if (Class509.CanOpenUpdater)
			{
				bool flag = false;
				Class176 instance = Class176.Instance;
				DateTime now = DateTime.Now;
				try
				{
					using (Updater updater = new Updater(false))
					{
						updater.ShowDialog();
						switch (updater.UpdateResult)
						{
						case Enum43.const_4:
						case Enum43.const_6:
							flag = true;
							break;
						case Enum43.const_5:
							instance.UpdateStepOn = Enum111.const_0;
							flag = true;
							this.method_24();
							break;
						}
					}
				}
				finally
				{
					if (flag)
					{
						instance.LastCheckedForUpdate = now;
						instance.method_0();
					}
				}
			}
		}

		// Token: 0x060021E7 RID: 8679 RVA: 0x0000E28D File Offset: 0x0000C48D
		private void toolStripMenuItem_12_Click(object sender, EventArgs e)
		{
			this.method_21(null);
		}

		// Token: 0x060021E8 RID: 8680 RVA: 0x00073A90 File Offset: 0x00071C90
		private void method_21(List<string> contentPackPaths = null)
		{
			if (Class509.CanOpenContentPacksOrOpenDialog)
			{
				if (!this.class112_0.AcceptedContentPackAgreement)
				{
					using (ContentPackAgreement contentPackAgreement = new ContentPackAgreement())
					{
						if (contentPackAgreement.ShowDialog() != DialogResult.OK)
						{
							return;
						}
					}
				}
				Class509.ContentPacksOpen = true;
				bool flag;
				ContentPacks contentPacks = this.class520_0.method_3<ContentPacks>(out flag, new object[]
				{
					contentPackPaths
				});
				if (flag)
				{
					Form form = contentPacks;
					if (Class330.formClosedEventHandler_0 == null)
					{
						Class330.formClosedEventHandler_0 = new FormClosedEventHandler(Class330.smethod_0);
					}
					form.FormClosed += Class330.formClosedEventHandler_0;
				}
				else if (contentPackPaths != null)
				{
					contentPacks.method_5(contentPackPaths);
				}
				this.method_6(contentPacks, flag);
			}
		}

		// Token: 0x060021E9 RID: 8681 RVA: 0x0000E296 File Offset: 0x0000C496
		private void toolStripMenuItem_13_Click(object sender, EventArgs e)
		{
			this.method_22();
		}

		// Token: 0x060021EA RID: 8682 RVA: 0x00073B3C File Offset: 0x00071D3C
		private void method_22()
		{
			Class509.MyGalleryOpen = true;
			bool flag;
			Form form = this.class520_0.method_3<MyGallery>(out flag, new object[0]);
			if (flag)
			{
				Form form2 = form;
				if (Class330.formClosedEventHandler_1 == null)
				{
					Class330.formClosedEventHandler_1 = new FormClosedEventHandler(Class330.smethod_1);
				}
				form2.FormClosed += Class330.formClosedEventHandler_1;
			}
			this.method_6(form, flag);
		}

		// Token: 0x060021EB RID: 8683 RVA: 0x0000E29E File Offset: 0x0000C49E
		private void toolStripMenuItem_4_Click(object sender, EventArgs e)
		{
			this.method_23();
		}

		// Token: 0x060021EC RID: 8684 RVA: 0x0000E2A6 File Offset: 0x0000C4A6
		private void method_23()
		{
			Class462.smethod_0(Enum51.const_0);
		}

		// Token: 0x060021ED RID: 8685 RVA: 0x0000E2AE File Offset: 0x0000C4AE
		private void toolStripMenuItem_17_Click(object sender, EventArgs e)
		{
			if (Class509.CanExitTheToonTownSpoofer)
			{
				this.method_24();
			}
		}

		// Token: 0x060021EE RID: 8686 RVA: 0x0000E2BD File Offset: 0x0000C4BD
		private void method_24()
		{
			base.ExitThread();
		}

		// Token: 0x060021EF RID: 8687 RVA: 0x0000E2C5 File Offset: 0x0000C4C5
		private void toolStripMenuItem_15_Click(object sender, EventArgs e)
		{
			this.method_25();
		}

		// Token: 0x060021F0 RID: 8688 RVA: 0x00073B94 File Offset: 0x00071D94
		private bool method_25()
		{
			if (this.class520_0.method_0<Options>())
			{
				DialogBox.smethod_3("Please close the Options window before enabling or disabling hotkeys.", "Options Window Open");
				return false;
			}
			if (this.class112_0.HotkeysEnabled = !this.class112_0.HotkeysEnabled)
			{
				Class330.class205_0.method_0();
			}
			else
			{
				Class330.class205_0.method_1();
			}
			this.toolStripMenuItem_15.Text = this.method_4();
			return true;
		}

		// Token: 0x060021F1 RID: 8689 RVA: 0x0000E2CE File Offset: 0x0000C4CE
		[CompilerGenerated]
		private void method_26()
		{
			this.method_25();
			if (this.mainForm_0 != null)
			{
				this.mainForm_0.method_20();
			}
		}

		// Token: 0x060021F2 RID: 8690 RVA: 0x0000E2EA File Offset: 0x0000C4EA
		[CompilerGenerated]
		private void method_27(object sender, EventArgs e)
		{
			this.class112_0.UseVisualMode = false;
			this.mainForm_0.Close();
			this.notifyIcon_0.Visible = true;
			this.method_14();
		}

		// Token: 0x060021F3 RID: 8691 RVA: 0x0000E315 File Offset: 0x0000C515
		[CompilerGenerated]
		private void method_28(object sender, FormClosedEventArgs e)
		{
			if (this.class112_0.UseVisualMode)
			{
				this.method_24();
			}
			this.mainForm_0.Dispose();
			this.mainForm_0 = null;
		}

		// Token: 0x060021F4 RID: 8692 RVA: 0x0000E285 File Offset: 0x0000C485
		[CompilerGenerated]
		private void method_29(object sender, EventArgs e)
		{
			this.method_20();
		}

		// Token: 0x060021F5 RID: 8693 RVA: 0x0000E296 File Offset: 0x0000C496
		[CompilerGenerated]
		private void method_30(object sender, EventArgs e)
		{
			this.method_22();
		}

		// Token: 0x060021F6 RID: 8694 RVA: 0x0000E28D File Offset: 0x0000C48D
		[CompilerGenerated]
		private void method_31(object sender, EventArgs e)
		{
			this.method_21(null);
		}

		// Token: 0x060021F7 RID: 8695 RVA: 0x0000E33C File Offset: 0x0000C53C
		[CompilerGenerated]
		private void method_32(object sender, EventArgs24 e)
		{
			if (this.method_25())
			{
				e.HotkeysEnabledStateChangedResult = true;
			}
		}

		// Token: 0x060021F8 RID: 8696 RVA: 0x0000E29E File Offset: 0x0000C49E
		[CompilerGenerated]
		private void method_33(object sender, EventArgs e)
		{
			this.method_23();
		}

		// Token: 0x060021F9 RID: 8697 RVA: 0x0000E275 File Offset: 0x0000C475
		[CompilerGenerated]
		private void method_34(object sender, EventArgs e)
		{
			this.method_18();
		}

		// Token: 0x060021FA RID: 8698 RVA: 0x0000E26D File Offset: 0x0000C46D
		[CompilerGenerated]
		private void method_35(object sender, EventArgs e)
		{
			this.method_17();
		}

		// Token: 0x060021FB RID: 8699 RVA: 0x0000E27D File Offset: 0x0000C47D
		[CompilerGenerated]
		private void method_36(object sender, EventArgs e)
		{
			this.method_19();
		}

		// Token: 0x060021FC RID: 8700 RVA: 0x0000E212 File Offset: 0x0000C412
		[CompilerGenerated]
		private void method_37(object sender, EventArgs e)
		{
			this.method_13();
		}

		// Token: 0x060021FD RID: 8701 RVA: 0x0000E20A File Offset: 0x0000C40A
		[CompilerGenerated]
		private void method_38(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x060021FE RID: 8702 RVA: 0x0000E1FA File Offset: 0x0000C3FA
		[CompilerGenerated]
		private void method_39(object sender, EventArgs e)
		{
			this.method_10();
		}

		// Token: 0x060021FF RID: 8703 RVA: 0x0000E1F2 File Offset: 0x0000C3F2
		[CompilerGenerated]
		private void method_40(object sender, EventArgs e)
		{
			this.method_9();
		}

		// Token: 0x06002200 RID: 8704 RVA: 0x0000E1EA File Offset: 0x0000C3EA
		[CompilerGenerated]
		private void method_41(object sender, EventArgs e)
		{
			this.method_8();
		}

		// Token: 0x06002201 RID: 8705 RVA: 0x0000E1E2 File Offset: 0x0000C3E2
		[CompilerGenerated]
		private void method_42(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x06002202 RID: 8706 RVA: 0x0000E1DA File Offset: 0x0000C3DA
		[CompilerGenerated]
		private void method_43(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x06002203 RID: 8707 RVA: 0x0000E202 File Offset: 0x0000C402
		[CompilerGenerated]
		private void method_44(object sender, EventArgs e)
		{
			this.method_11();
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x0000E34D File Offset: 0x0000C54D
		[CompilerGenerated]
		private static void smethod_0(object sender, FormClosedEventArgs e)
		{
			Class509.ContentPacksOpen = false;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x0000E355 File Offset: 0x0000C555
		[CompilerGenerated]
		private static void smethod_1(object sender, FormClosedEventArgs e)
		{
			Class509.MyGalleryOpen = false;
		}

		// Token: 0x04000DE5 RID: 3557
		private IContainer icontainer_0;

		// Token: 0x04000DE6 RID: 3558
		private NotifyIcon notifyIcon_0;

		// Token: 0x04000DE7 RID: 3559
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x04000DE8 RID: 3560
		private ToolStripMenuItem toolStripMenuItem_0;

		// Token: 0x04000DE9 RID: 3561
		private ToolStripMenuItem toolStripMenuItem_1;

		// Token: 0x04000DEA RID: 3562
		private ToolStripMenuItem toolStripMenuItem_2;

		// Token: 0x04000DEB RID: 3563
		private ToolStripMenuItem toolStripMenuItem_3;

		// Token: 0x04000DEC RID: 3564
		private ToolStripMenuItem toolStripMenuItem_4;

		// Token: 0x04000DED RID: 3565
		private ToolStripSeparator toolStripSeparator_0;

		// Token: 0x04000DEE RID: 3566
		private ToolStripMenuItem toolStripMenuItem_5;

		// Token: 0x04000DEF RID: 3567
		private ToolStripMenuItem toolStripMenuItem_6;

		// Token: 0x04000DF0 RID: 3568
		private ToolStripMenuItem toolStripMenuItem_7;

		// Token: 0x04000DF1 RID: 3569
		private ToolStripMenuItem toolStripMenuItem_8;

		// Token: 0x04000DF2 RID: 3570
		private ToolStripMenuItem toolStripMenuItem_9;

		// Token: 0x04000DF3 RID: 3571
		private ToolStripMenuItem toolStripMenuItem_10;

		// Token: 0x04000DF4 RID: 3572
		private ToolStripMenuItem toolStripMenuItem_11;

		// Token: 0x04000DF5 RID: 3573
		private ToolStripSeparator toolStripSeparator_1;

		// Token: 0x04000DF6 RID: 3574
		private ToolStripMenuItem toolStripMenuItem_12;

		// Token: 0x04000DF7 RID: 3575
		private ToolStripMenuItem toolStripMenuItem_13;

		// Token: 0x04000DF8 RID: 3576
		private ToolStripMenuItem toolStripMenuItem_14;

		// Token: 0x04000DF9 RID: 3577
		private ToolStripMenuItem toolStripMenuItem_15;

		// Token: 0x04000DFA RID: 3578
		private ToolStripSeparator toolStripSeparator_2;

		// Token: 0x04000DFB RID: 3579
		private ToolStripMenuItem toolStripMenuItem_16;

		// Token: 0x04000DFC RID: 3580
		private ToolStripSeparator toolStripSeparator_3;

		// Token: 0x04000DFD RID: 3581
		private ToolStripMenuItem toolStripMenuItem_17;

		// Token: 0x04000DFE RID: 3582
		private Class520 class520_0;

		// Token: 0x04000DFF RID: 3583
		private Class318 class318_0;

		// Token: 0x04000E00 RID: 3584
		private FileSystemWatcher fileSystemWatcher_0;

		// Token: 0x04000E01 RID: 3585
		private FileSystemWatcher fileSystemWatcher_1;

		// Token: 0x04000E02 RID: 3586
		public static Class205 class205_0;

		// Token: 0x04000E03 RID: 3587
		private static readonly string string_0 = "phase_1.mf.orig";

		// Token: 0x04000E04 RID: 3588
		private static readonly string string_1 = "phase_2.mf.orig";

		// Token: 0x04000E05 RID: 3589
		private MainForm mainForm_0;

		// Token: 0x04000E06 RID: 3590
		private Class112 class112_0;

		// Token: 0x04000E07 RID: 3591
		private Control control_0;

		// Token: 0x04000E08 RID: 3592
		private TaskFactory taskFactory_0;

		// Token: 0x04000E09 RID: 3593
		private Class385 class385_0;

		// Token: 0x04000E0A RID: 3594
		private readonly List<Form> list_0;

		// Token: 0x04000E0B RID: 3595
		private readonly List<ParTeePutt> list_1;

		// Token: 0x04000E0C RID: 3596
		[CompilerGenerated]
		private static FormClosedEventHandler formClosedEventHandler_0;

		// Token: 0x04000E0D RID: 3597
		[CompilerGenerated]
		private static FormClosedEventHandler formClosedEventHandler_1;

		// Token: 0x0200035C RID: 860
		[CompilerGenerated]
		private sealed class Class331
		{
			// Token: 0x06002208 RID: 8712 RVA: 0x00073C08 File Offset: 0x00071E08
			public void method_0()
			{
				DateTime now = DateTime.Now;
				try
				{
					if (File.Exists(this.fileSystemEventArgs_0.FullPath))
					{
						while ((DateTime.Now - now).TotalMilliseconds < 10000.0)
						{
							if (Class234.smethod_5(this.fileSystemEventArgs_0.FullPath))
							{
								string destFileName = Class266.smethod_0(this.class330_0.class112_0.ScreenshotSaveDirectory, Path.GetFileNameWithoutExtension(this.fileSystemEventArgs_0.FullPath) + "_{0}.jpg");
								File.Move(this.fileSystemEventArgs_0.FullPath, destFileName);
								break;
							}
							Thread.Sleep(100);
						}
					}
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						this.fileSystemEventArgs_0.FullPath
					});
				}
			}

			// Token: 0x04000E0E RID: 3598
			public Class330 class330_0;

			// Token: 0x04000E0F RID: 3599
			public FileSystemEventArgs fileSystemEventArgs_0;
		}

		// Token: 0x0200035D RID: 861
		[CompilerGenerated]
		private sealed class Class332
		{
			// Token: 0x0600220A RID: 8714 RVA: 0x0000E373 File Offset: 0x0000C573
			public void method_0()
			{
				this.class330_0.method_2(this.class409_0, true);
			}

			// Token: 0x04000E10 RID: 3600
			public Class330 class330_0;

			// Token: 0x04000E11 RID: 3601
			public Class409 class409_0;
		}

		// Token: 0x0200035E RID: 862
		[CompilerGenerated]
		private sealed class Class333
		{
			// Token: 0x0600220C RID: 8716 RVA: 0x00073CE0 File Offset: 0x00071EE0
			public void method_0(object sender, FormClosedEventArgs e)
			{
				this.class330_0.list_0.Remove(this.form_0);
				if (this.class330_0.mainForm_0 != null && this.class330_0.list_0.Count == 0)
				{
					this.class330_0.mainForm_0.WindowState = FormWindowState.Normal;
					this.class330_0.mainForm_0.BringToFront();
					this.class330_0.mainForm_0.Activate();
				}
			}

			// Token: 0x04000E12 RID: 3602
			public Class330 class330_0;

			// Token: 0x04000E13 RID: 3603
			public Form form_0;
		}

		// Token: 0x0200035F RID: 863
		[CompilerGenerated]
		private sealed class Class334
		{
			// Token: 0x0600220E RID: 8718 RVA: 0x0000E387 File Offset: 0x0000C587
			public void method_0(object sender, FormClosingEventArgs e)
			{
				this.class330_0.list_1.Remove(this.parTeePutt_0);
				this.parTeePutt_0.Dispose();
			}

			// Token: 0x04000E14 RID: 3604
			public ParTeePutt parTeePutt_0;

			// Token: 0x04000E15 RID: 3605
			public Class330 class330_0;
		}
	}
}
