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
using ns16;
using ns18;
using ns20;
using ns23;
using ns24;
using ns26;
using ns27;
using ns31;

namespace ns17
{
	// Token: 0x02000269 RID: 617
	internal sealed partial class MyGallery : Form
	{
		// Token: 0x06001A40 RID: 6720 RVA: 0x0004D6DC File Offset: 0x0004B8DC
		public MyGallery()
		{
			KeyEventHandler keyEventHandler = null;
			EventHandler eventHandler = null;
			base..ctor();
			this.object_0 = new object();
			this.InitializeComponent();
			this.control_0 = new Control();
			Control control = this.control_0;
			EventHandler value = new EventHandler(this.method_3);
			control.LostFocus += value;
			Control control2 = this.control_0;
			if (MyGallery.previewKeyDownEventHandler_0 == null)
			{
				MyGallery.previewKeyDownEventHandler_0 = new PreviewKeyDownEventHandler(MyGallery.smethod_0);
			}
			control2.PreviewKeyDown += MyGallery.previewKeyDownEventHandler_0;
			Control control3 = this.control_0;
			if (keyEventHandler == null)
			{
				keyEventHandler = new KeyEventHandler(this.method_4);
			}
			control3.KeyDown += keyEventHandler;
			base.Controls.Add(this.control_0);
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(this.method_5);
			}
			base.Activated += eventHandler;
			this.control_0.Focus();
			this.class111_0 = Class110.Instance.MyGallerySettings;
			Rectangle workingArea = Screen.GetWorkingArea(Cursor.Position);
			base.Width = (int)((float)workingArea.Width * 0.9f);
			base.Location = new Point(workingArea.Width / 2 - base.Width / 2 + workingArea.X, (int)((double)workingArea.Height * 0.98) - base.Height + workingArea.Y);
			this.class385_0 = new Class385(1);
			this.taskFactory_0 = new TaskFactory(this.class385_0);
		}

		// Token: 0x06001A41 RID: 6721 RVA: 0x0004D838 File Offset: 0x0004BA38
		private void method_0()
		{
			this.ScreenshotsLabel.Text = string.Format("My Gallery has {0} screenshots available to view.", this.int_0);
			if (this.int_0 == 0)
			{
				ToolStripStatusLabel screenshotsLabel = this.ScreenshotsLabel;
				screenshotsLabel.Text += " Please take some screenshots in ToonTown and check back!";
			}
		}

		// Token: 0x06001A42 RID: 6722 RVA: 0x0004D888 File Offset: 0x0004BA88
		private void MyGallery_Load(object sender, EventArgs e)
		{
			EventHandler eventHandler = null;
			MyGallery.Class208 @class = new MyGallery.Class208();
			@class.myGallery_0 = this;
			@class.loading_0 = new Loading();
			try
			{
				Form loading_ = @class.loading_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(@class.method_0);
				}
				loading_.Shown += eventHandler;
				@class.loading_0.StartPosition = FormStartPosition.CenterScreen;
				@class.loading_0.ShowDialog();
			}
			finally
			{
				if (@class.loading_0 != null)
				{
					((IDisposable)@class.loading_0).Dispose();
				}
			}
			this.fileSystemWatcher_0.Path = Class110.Instance.ApplicationSettings.ScreenshotSaveDirectory;
			base.FormClosing += this.MyGallery_FormClosing;
			this.fileSystemWatcher_0.EnableRaisingEvents = true;
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0004D944 File Offset: 0x0004BB44
		private void method_1(Class140 data)
		{
			MyGallery.Class210 @class = new MyGallery.Class210();
			@class.class140_0 = data;
			@class.myGallery_0 = this;
			lock (this.object_0)
			{
				this.int_1++;
			}
			this.taskFactory_0.StartNew(new Action(@class.method_0));
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0004D9B8 File Offset: 0x0004BBB8
		private void method_2(string filePath, DateTime dateCreated, DateTime timeStamp)
		{
			MyGallery.Class211 @class = new MyGallery.Class211();
			@class.string_0 = filePath;
			@class.dateTime_0 = dateCreated;
			@class.dateTime_1 = timeStamp;
			@class.myGallery_0 = this;
			lock (this.object_0)
			{
				this.int_1++;
			}
			this.taskFactory_0.StartNew(new Action(@class.method_0));
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0004DA3C File Offset: 0x0004BC3C
		private void fileSystemWatcher_0_Created(object sender, FileSystemEventArgs e)
		{
			WatcherChangeTypes changeType = e.ChangeType;
			if (changeType != WatcherChangeTypes.Created)
			{
				return;
			}
			this.method_2(e.FullPath, Class234.smethod_12(e.FullPath), DateTime.Now);
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0004DA74 File Offset: 0x0004BC74
		private void fileSystemWatcher_0_Deleted(object sender, FileSystemEventArgs e)
		{
			MyGallery.Class213 @class = new MyGallery.Class213();
			@class.fileSystemEventArgs_0 = e;
			@class.myGallery_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0000953A File Offset: 0x0000773A
		private void MyGallery_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_8);
			e.Handled = true;
		}

		// Token: 0x06001A4A RID: 6730 RVA: 0x0000954A File Offset: 0x0000774A
		[CompilerGenerated]
		private void method_3(object sender, EventArgs e)
		{
			if (this.Focused)
			{
				this.control_0.Focus();
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0004DE2C File Offset: 0x0004C02C
		[CompilerGenerated]
		private static void smethod_0(object sender, PreviewKeyDownEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Tab)
			{
				switch (keyCode)
				{
				case Keys.Left:
				case Keys.Right:
					break;
				case Keys.Up:
					return;
				default:
					return;
				}
			}
			e.IsInputKey = true;
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0004DE64 File Offset: 0x0004C064
		[CompilerGenerated]
		private void method_4(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
			case Keys.Left:
				this.Thumbnails.method_10();
				return;
			case Keys.Up:
				break;
			case Keys.Right:
				this.Thumbnails.method_9();
				break;
			default:
				return;
			}
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00009560 File Offset: 0x00007760
		[CompilerGenerated]
		private void method_5(object sender, EventArgs e)
		{
			this.control_0.Focus();
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0000956E File Offset: 0x0000776E
		[CompilerGenerated]
		private void MyGallery_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.fileSystemWatcher_0.EnableRaisingEvents = false;
		}

		// Token: 0x040007D1 RID: 2001
		private readonly Class111 class111_0;

		// Token: 0x040007D2 RID: 2002
		private readonly Class385 class385_0;

		// Token: 0x040007D3 RID: 2003
		private readonly TaskFactory taskFactory_0;

		// Token: 0x040007D4 RID: 2004
		private readonly object object_0;

		// Token: 0x040007D6 RID: 2006
		private int int_0;

		// Token: 0x040007D7 RID: 2007
		private int int_1;

		// Token: 0x040007DF RID: 2015
		[CompilerGenerated]
		private static PreviewKeyDownEventHandler previewKeyDownEventHandler_0;

		// Token: 0x0200026A RID: 618
		[CompilerGenerated]
		private sealed class Class208
		{
			// Token: 0x06001A50 RID: 6736 RVA: 0x0000957C File Offset: 0x0000777C
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001A51 RID: 6737 RVA: 0x0004DEA8 File Offset: 0x0004C0A8
			public void method_1(object _)
			{
				MyGallery.Class208.Class209 @class = new MyGallery.Class208.Class209();
				@class.class208_0 = this;
				this.myGallery_0.class143_0 = Class143.smethod_0();
				@class.list_0 = this.myGallery_0.class143_0.method_4();
				foreach (Class140 data in @class.list_0)
				{
					this.myGallery_0.method_1(data);
				}
				this.myGallery_0.taskFactory_0.StartNew(new Action(@class.method_0));
			}

			// Token: 0x040007E0 RID: 2016
			public Loading loading_0;

			// Token: 0x040007E1 RID: 2017
			public MyGallery myGallery_0;

			// Token: 0x0200026B RID: 619
			private sealed class Class209
			{
				// Token: 0x06001A53 RID: 6739 RVA: 0x00009591 File Offset: 0x00007791
				public void method_0()
				{
					this.class208_0.myGallery_0.smethod_4(new MethodInvoker(this.method_1));
				}

				// Token: 0x06001A54 RID: 6740 RVA: 0x0004DF54 File Offset: 0x0004C154
				public void method_1()
				{
					IEnumerable<Class140> source = this.list_0;
					if (MyGallery.Class208.Class209.func_0 == null)
					{
						MyGallery.Class208.Class209.func_0 = new Func<Class140, bool>(MyGallery.Class208.Class209.smethod_0);
					}
					List<Class140> list = source.Where(MyGallery.Class208.Class209.func_0).ToList<Class140>();
					this.class208_0.myGallery_0.Thumbnails.method_5(list);
					this.class208_0.myGallery_0.int_0 = list.Count;
					this.class208_0.myGallery_0.method_0();
					this.class208_0.loading_0.method_1();
				}

				// Token: 0x06001A55 RID: 6741 RVA: 0x000095AF File Offset: 0x000077AF
				private static bool smethod_0(Class140 item)
				{
					return item.bitmap_0 != null;
				}

				// Token: 0x040007E2 RID: 2018
				public MyGallery.Class208 class208_0;

				// Token: 0x040007E3 RID: 2019
				public List<Class140> list_0;

				// Token: 0x040007E4 RID: 2020
				private static Func<Class140, bool> func_0;
			}
		}

		// Token: 0x0200026C RID: 620
		[CompilerGenerated]
		private sealed class Class210
		{
			// Token: 0x06001A57 RID: 6743 RVA: 0x0004DFDC File Offset: 0x0004C1DC
			public void method_0()
			{
				this.class140_0.bitmap_0 = this.myGallery_0.class143_0.method_5(this.class140_0.FilePath);
				lock (this.myGallery_0.object_0)
				{
					this.myGallery_0.int_1--;
				}
			}

			// Token: 0x040007E5 RID: 2021
			public MyGallery myGallery_0;

			// Token: 0x040007E6 RID: 2022
			public Class140 class140_0;
		}

		// Token: 0x0200026D RID: 621
		[CompilerGenerated]
		private sealed class Class211
		{
			// Token: 0x06001A59 RID: 6745 RVA: 0x0004E054 File Offset: 0x0004C254
			public void method_0()
			{
				if (File.Exists(this.string_0))
				{
					while ((DateTime.Now - this.dateTime_1).TotalMilliseconds < 10000.0)
					{
						try
						{
							if (Class234.smethod_5(this.string_0))
							{
								MethodInvoker methodInvoker = null;
								MyGallery.Class211.Class212 @class = new MyGallery.Class211.Class212();
								@class.class211_0 = this;
								@class.class140_0 = new Class140(Path.GetFileName(this.string_0), this.string_0, this.dateTime_0);
								@class.class140_0.bitmap_0 = this.myGallery_0.class143_0.method_5(@class.class140_0.FilePath);
								if (@class.class140_0.bitmap_0 != null)
								{
									Control sender = this.myGallery_0;
									if (methodInvoker == null)
									{
										methodInvoker = new MethodInvoker(@class.method_0);
									}
									sender.smethod_6(methodInvoker);
								}
								else
								{
									@class.class140_0.Dispose();
								}
								break;
							}
							Thread.Sleep(100);
						}
						catch (FileNotFoundException ex)
						{
							ex.smethod_1(new object[]
							{
								this.string_0
							});
						}
					}
				}
				lock (this.myGallery_0.object_0)
				{
					this.myGallery_0.int_1--;
				}
			}

			// Token: 0x040007E7 RID: 2023
			public MyGallery myGallery_0;

			// Token: 0x040007E8 RID: 2024
			public string string_0;

			// Token: 0x040007E9 RID: 2025
			public DateTime dateTime_0;

			// Token: 0x040007EA RID: 2026
			public DateTime dateTime_1;

			// Token: 0x0200026E RID: 622
			private sealed class Class212
			{
				// Token: 0x06001A5B RID: 6747 RVA: 0x0004E1B8 File Offset: 0x0004C3B8
				public void method_0()
				{
					this.class211_0.myGallery_0.Thumbnails.method_6(this.class140_0);
					this.class211_0.myGallery_0.int_0++;
					this.class211_0.myGallery_0.method_0();
				}

				// Token: 0x040007EB RID: 2027
				public MyGallery.Class211 class211_0;

				// Token: 0x040007EC RID: 2028
				public Class140 class140_0;
			}
		}

		// Token: 0x0200026F RID: 623
		[CompilerGenerated]
		private sealed class Class213
		{
			// Token: 0x06001A5D RID: 6749 RVA: 0x0004E208 File Offset: 0x0004C408
			public void method_0()
			{
				if (this.myGallery_0.Thumbnails.method_7(Path.GetFileName(this.fileSystemEventArgs_0.FullPath)))
				{
					this.myGallery_0.int_0--;
					this.myGallery_0.method_0();
				}
			}

			// Token: 0x040007ED RID: 2029
			public MyGallery myGallery_0;

			// Token: 0x040007EE RID: 2030
			public FileSystemEventArgs fileSystemEventArgs_0;
		}
	}
}
