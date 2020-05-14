using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns15;
using ns16;
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
using ns30;
using ns31;

namespace ns17
{
	// Token: 0x0200028F RID: 655
	internal sealed partial class JoeFish : Form
	{
		// Token: 0x06001B0A RID: 6922 RVA: 0x00051A80 File Offset: 0x0004FC80
		public JoeFish()
		{
			EventHandler eventHandler = null;
			FormClosingEventHandler formClosingEventHandler = null;
			this.bool_0 = true;
			base..ctor();
			this.InitializeComponent();
			this.class141_0 = new Class141();
			this.ShowStatisticsWhenCompletedMenuItem.Checked = Class110.Instance.JoeFishSettings.ShowStatisticsAfterRunning;
			this.StopWhenNewSpeciesAreDetectedMenuItem.Checked = Class110.Instance.JoeFishSettings.StopWhenNewSpecies;
			string customCaptureFile = Class110.Instance.JoeFishSettings.CustomCaptureFile;
			if (!string.IsNullOrEmpty(customCaptureFile) && File.Exists(customCaptureFile))
			{
				if (!this.method_3(customCaptureFile))
				{
					this.method_2(true);
				}
			}
			else
			{
				this.method_2(true);
			}
			string customWayPointSettings = Class110.Instance.JoeFishSettings.CustomWayPointSettings;
			if (!string.IsNullOrEmpty(customWayPointSettings) && File.Exists(customWayPointSettings))
			{
				if (!this.method_5(customWayPointSettings))
				{
					this.method_4(true);
				}
			}
			else
			{
				this.method_4(true);
			}
			if (eventHandler == null)
			{
				eventHandler = new EventHandler(this.method_6);
			}
			base.Shown += eventHandler;
			if (formClosingEventHandler == null)
			{
				formClosingEventHandler = new FormClosingEventHandler(this.method_7);
			}
			base.FormClosing += formClosingEventHandler;
		}

		// Token: 0x06001B0B RID: 6923 RVA: 0x000050D4 File Offset: 0x000032D4
		private void CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x000050D4 File Offset: 0x000032D4
		private void CloseMenuItem_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001B0D RID: 6925 RVA: 0x00009D13 File Offset: 0x00007F13
		private void SelectToonTownWindowMenuItem_Click(object sender, EventArgs e)
		{
			this.class141_0.smethod_2(this, null);
		}

		// Token: 0x06001B0E RID: 6926 RVA: 0x00051B84 File Offset: 0x0004FD84
		private bool method_0()
		{
			if (!this.class141_0.ProcessOpen && !this.class141_0.smethod_1(this))
			{
				return false;
			}
			if (this.class98_0 == null)
			{
				DialogBox.smethod_3(JoeFish.string_2, JoeFish.string_3);
				return false;
			}
			if (this.class101_0 == null)
			{
				DialogBox.smethod_3(JoeFish.string_0, JoeFish.string_1);
				return false;
			}
			return true;
		}

		// Token: 0x06001B0F RID: 6927 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		private void BeginFishing_Click(object sender, EventArgs e)
		{
			if (!this.method_0())
			{
				return;
			}
			Class106 joeFishSettings = Class110.Instance.JoeFishSettings;
			using (Class499 @class = new Class499(this))
			{
				using (JoeFishRunning joeFishRunning = new JoeFishRunning(this.class141_0.MainWindowHandle, Enum50.const_0, this.class98_0, this.class103_0, this.class101_0))
				{
					@class.method_0(joeFishRunning);
					if (joeFishRunning.ShowDialog() != DialogResult.Abort && joeFishSettings.ShowStatisticsAfterRunning)
					{
						base.BringToFront();
						base.Activate();
						Struct52 @struct = new Struct52(joeFishRunning.StartTime, joeFishRunning.EndTime, joeFishRunning.FishCaught, joeFishRunning.BootsCaught, joeFishRunning.BucketsSold, joeFishRunning.Casts);
						Class106 class2 = joeFishSettings;
						class2.JoeFishTotalRunStatistics = Struct50.smethod_0(class2.JoeFishTotalRunStatistics, @struct);
						using (JoeFishStatistics joeFishStatistics = new JoeFishStatistics())
						{
							joeFishStatistics.JoeFishRunStatistics = new Struct52?(@struct);
							joeFishStatistics.ShowDialog();
						}
					}
				}
			}
			this.class98_0.method_4();
		}

		// Token: 0x06001B10 RID: 6928 RVA: 0x00051D08 File Offset: 0x0004FF08
		private bool method_1(Class98 settings)
		{
			return settings.BootCaughtCapture != null && settings.BucketFullCapture != null && settings.CastCapture != null && settings.EstateSellFishCapture != null && settings.ExitFishingCapture != null && settings.FishCaughtCapture != null && settings.FishCaughtDuringBingoCapture != null && settings.NewSpeciesCapture != null && settings.NewSpeciesDuringBingoCapture != null && settings.NoBeansCapture != null && settings.SellFishCapture != null;
		}

		// Token: 0x06001B11 RID: 6929 RVA: 0x00051D74 File Offset: 0x0004FF74
		private void CustomCapturesMenuItem_Click(object sender, EventArgs e)
		{
			Class524 @class;
			if (Class460.smethod_2(out @class))
			{
				if (this.method_3(@class.string_1))
				{
					Class110.Instance.JoeFishSettings.CustomCaptureFile = @class.string_1;
				}
				else
				{
					this.method_2(false);
				}
				Class110.smethod_1();
			}
		}

		// Token: 0x06001B12 RID: 6930 RVA: 0x00009D23 File Offset: 0x00007F23
		private void DefaultCapturesMenuItem_Click(object sender, EventArgs e)
		{
			this.method_2(true);
			Class110.smethod_1();
		}

		// Token: 0x06001B13 RID: 6931 RVA: 0x00051DBC File Offset: 0x0004FFBC
		private void method_2(bool displayErrorIfFailure)
		{
			Class110.Instance.JoeFishSettings.CustomCaptureFile = null;
			if (File.Exists(Class291.string_20))
			{
				bool flag = false;
				Class98 @class = null;
				try
				{
					@class = new Class98(Class291.string_20);
					flag = true;
				}
				catch (Exception ex)
				{
					if (@class != null)
					{
						@class.Dispose();
					}
					@class = null;
					if (displayErrorIfFailure)
					{
						ex.smethod_1(new object[]
						{
							Class291.string_20
						});
					}
				}
				if (flag && this.method_1(@class))
				{
					if (this.class98_0 != null)
					{
						this.class98_0.Dispose();
					}
					this.class98_0 = @class;
					this.DefaultCapturesMenuItem.Checked = true;
					this.CustomCapturesMenuItem.Checked = false;
					return;
				}
				if (@class != null)
				{
					@class.Dispose();
				}
				@class = null;
				if (displayErrorIfFailure)
				{
					DialogBox.smethod_3(JoeFish.string_13, JoeFish.string_9);
					return;
				}
			}
			else
			{
				if (this.class98_0 != null)
				{
					this.class98_0.Dispose();
				}
				this.class98_0 = null;
				if (displayErrorIfFailure)
				{
					DialogBox.smethod_3(JoeFish.string_11, JoeFish.string_12);
				}
				this.DefaultCapturesMenuItem.Checked = false;
				this.CustomCapturesMenuItem.Checked = false;
			}
		}

		// Token: 0x06001B14 RID: 6932 RVA: 0x00051ED4 File Offset: 0x000500D4
		private bool method_3(string filePath)
		{
			Class98 @class = null;
			bool flag = false;
			try
			{
				@class = new Class98(filePath);
				flag = true;
			}
			catch (Exception ex)
			{
				if (@class != null)
				{
					@class.Dispose();
				}
				@class = null;
				ex.smethod_1(new object[]
				{
					string.Format(JoeFish.string_10, filePath)
				});
				DialogBox.smethod_7(ex, filePath);
			}
			if (flag && this.method_1(@class))
			{
				if (this.class98_0 != null)
				{
					this.class98_0.Dispose();
				}
				this.class98_0 = @class;
				this.CustomCapturesMenuItem.Checked = true;
				this.DefaultCapturesMenuItem.Checked = false;
				return true;
			}
			if (@class != null)
			{
				@class.Dispose();
			}
			@class = null;
			this.DefaultCapturesMenuItem.Checked = false;
			this.CustomCapturesMenuItem.Checked = false;
			DialogBox.smethod_3(JoeFish.string_8, JoeFish.string_9);
			return false;
		}

		// Token: 0x06001B15 RID: 6933 RVA: 0x00051FA4 File Offset: 0x000501A4
		private void method_4(bool displayErrorIfFailure)
		{
			Class110.Instance.JoeFishSettings.CustomWayPointSettings = null;
			if (!File.Exists(Class291.string_22))
			{
				this.class101_0 = null;
				this.DefaultWayPointsMenuItem.Checked = false;
				this.CustomWayPointsMenuItem.Checked = false;
				if (displayErrorIfFailure)
				{
					DialogBox.smethod_3(JoeFish.string_6, JoeFish.string_7);
				}
				return;
			}
			bool flag;
			try
			{
				this.class101_0 = new Class101(Class291.string_22);
				flag = true;
			}
			catch (Exception ex)
			{
				this.class101_0 = null;
				if (displayErrorIfFailure)
				{
					DialogBox.smethod_7(ex, Class291.string_22);
				}
				flag = false;
			}
			if (flag)
			{
				this.DefaultWayPointsMenuItem.Checked = true;
				this.CustomWayPointsMenuItem.Checked = false;
				return;
			}
			this.DefaultWayPointsMenuItem.Checked = false;
			this.CustomWayPointsMenuItem.Checked = false;
		}

		// Token: 0x06001B16 RID: 6934 RVA: 0x00052074 File Offset: 0x00050274
		private bool method_5(string filePath)
		{
			bool flag;
			try
			{
				this.class101_0 = new Class101(filePath);
				flag = true;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, filePath);
				flag = false;
			}
			if (flag)
			{
				this.DefaultWayPointsMenuItem.Checked = false;
				this.CustomWayPointsMenuItem.Checked = true;
			}
			else
			{
				this.DefaultWayPointsMenuItem.Checked = false;
				this.CustomWayPointsMenuItem.Checked = false;
			}
			return flag;
		}

		// Token: 0x06001B17 RID: 6935 RVA: 0x00009D32 File Offset: 0x00007F32
		private void DefaultWayPointsMenuItem_Click(object sender, EventArgs e)
		{
			this.method_4(true);
			Class110.smethod_1();
		}

		// Token: 0x06001B18 RID: 6936 RVA: 0x000520E4 File Offset: 0x000502E4
		private void CustomWayPointsMenuItem_Click(object sender, EventArgs e)
		{
			if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				Class110.Instance.JoeFishSettings.CustomWayPointSettings = string.Empty;
				if (this.method_5(this.openFileDialog_0.FileName))
				{
					Class110.Instance.JoeFishSettings.CustomWayPointSettings = this.openFileDialog_0.FileName;
				}
				else
				{
					this.method_4(false);
				}
				Class110.smethod_1();
			}
		}

		// Token: 0x06001B19 RID: 6937 RVA: 0x00052150 File Offset: 0x00050350
		private void CreateWayPointsMenuItem_Click(object sender, EventArgs e)
		{
			using (Class499 @class = new Class499(this))
			{
				using (WayPointEditor wayPointEditor = new WayPointEditor(true))
				{
					@class.method_0(wayPointEditor);
					wayPointEditor.ShowDialog();
				}
			}
		}

		// Token: 0x06001B1A RID: 6938 RVA: 0x000521B0 File Offset: 0x000503B0
		private void ViewStatisticsMenuItem_Click(object sender, EventArgs e)
		{
			using (JoeFishStatistics joeFishStatistics = new JoeFishStatistics())
			{
				joeFishStatistics.ShowDialog();
			}
		}

		// Token: 0x06001B1B RID: 6939 RVA: 0x000521E8 File Offset: 0x000503E8
		private void ShowStatisticsWhenCompletedMenuItem_Click(object sender, EventArgs e)
		{
			Class110.Instance.JoeFishSettings.ShowStatisticsAfterRunning = !Class110.Instance.JoeFishSettings.ShowStatisticsAfterRunning;
			this.ShowStatisticsWhenCompletedMenuItem.Checked = Class110.Instance.JoeFishSettings.ShowStatisticsAfterRunning;
			Class110.smethod_1();
		}

		// Token: 0x06001B1C RID: 6940 RVA: 0x00052238 File Offset: 0x00050438
		private void UpdatePondCaptureMenuItem_Click(object sender, EventArgs e)
		{
			if (!this.method_0())
			{
				return;
			}
			if (this.bool_0)
			{
				this.bool_0 = false;
				if (DialogResult.Cancel == DialogBox.smethod_6(JoeFish.string_4, JoeFish.string_5, new Enum39[]
				{
					Enum39.const_0,
					Enum39.const_1
				}))
				{
					return;
				}
			}
			using (Class499 @class = new Class499(this))
			{
				using (JoeFishRunning joeFishRunning = new JoeFishRunning(this.class141_0.MainWindowHandle, Enum50.const_1, this.class98_0, this.class103_0, this.class101_0))
				{
					@class.method_0(joeFishRunning);
					joeFishRunning.ShowDialog();
				}
			}
			this.class98_0.method_4();
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x000522F4 File Offset: 0x000504F4
		private void CreateCapturesMenuItem_Click(object sender, EventArgs e)
		{
			using (Class499 @class = new Class499(this))
			{
				using (JoeFishCaptureSetup joeFishCaptureSetup = new JoeFishCaptureSetup())
				{
					@class.method_0(joeFishCaptureSetup);
					joeFishCaptureSetup.ShowDialog();
				}
			}
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00052350 File Offset: 0x00050550
		private void CustomizeSettings_Click(object sender, EventArgs e)
		{
			using (JoeFishSettingsForm joeFishSettingsForm = new JoeFishSettingsForm())
			{
				if (joeFishSettingsForm.ShowDialog() == DialogResult.OK)
				{
					Class110.smethod_1();
				}
			}
		}

		// Token: 0x06001B1F RID: 6943 RVA: 0x00052390 File Offset: 0x00050590
		private void StopWhenNewSpeciesAreDetectedMenuItem_Click(object sender, EventArgs e)
		{
			Class110.Instance.JoeFishSettings.StopWhenNewSpecies = !Class110.Instance.JoeFishSettings.StopWhenNewSpecies;
			this.StopWhenNewSpeciesAreDetectedMenuItem.Checked = Class110.Instance.JoeFishSettings.StopWhenNewSpecies;
			Class110.smethod_1();
		}

		// Token: 0x06001B20 RID: 6944 RVA: 0x00009D41 File Offset: 0x00007F41
		private void GuideMenuItem_Click(object sender, EventArgs e)
		{
			Class462.smethod_0(Enum51.const_7);
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x000533F4 File Offset: 0x000515F4
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			if (File.Exists(Class291.string_23))
			{
				EventHandler eventHandler = null;
				JoeFish.Class228 @class = new JoeFish.Class228();
				@class.joeFish_0 = this;
				@class.loading_0 = new Loading();
				try
				{
					Form loading_ = @class.loading_0;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(@class.method_0);
					}
					loading_.Shown += eventHandler;
					@class.loading_0.ShowDialog();
					return;
				}
				finally
				{
					if (@class.loading_0 != null)
					{
						((IDisposable)@class.loading_0).Dispose();
					}
				}
			}
			this.class103_0 = new Class103();
		}

		// Token: 0x06001B24 RID: 6948 RVA: 0x00053480 File Offset: 0x00051680
		[CompilerGenerated]
		private void method_7(object sender, FormClosingEventArgs e)
		{
			if (this.class103_0 != null)
			{
				EventHandler eventHandler = null;
				JoeFish.Class229 @class = new JoeFish.Class229();
				@class.joeFish_0 = this;
				@class.loading_0 = new Loading();
				try
				{
					Form loading_ = @class.loading_0;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(@class.method_0);
					}
					loading_.Shown += eventHandler;
					@class.loading_0.ShowDialog();
				}
				finally
				{
					if (@class.loading_0 != null)
					{
						((IDisposable)@class.loading_0).Dispose();
					}
				}
			}
		}

		// Token: 0x04000891 RID: 2193
		private static readonly string string_0 = "Joe Fish cannot run without a way point settings file.";

		// Token: 0x04000892 RID: 2194
		private static readonly string string_1 = "No Way Point Settings File Loaded";

		// Token: 0x04000893 RID: 2195
		private static readonly string string_2 = "There is no Joe Fish Capture Setup file loaded. Please load a file or reinstall The ToonTown Spoofer to restore the default file.";

		// Token: 0x04000894 RID: 2196
		private static readonly string string_3 = "No Capture File Loaded";

		// Token: 0x04000895 RID: 2197
		private static readonly string string_4 = "This recaptures and updates the underlying pond graphic used for fish detection and involves Joe Fish analyzing the pond's graphics for a few moments.";

		// Token: 0x04000896 RID: 2198
		private static readonly string string_5 = "Update Pond Capture";

		// Token: 0x04000897 RID: 2199
		private static readonly string string_6 = "The default Joe Fish way point settings file appears to be missing. Joe Fish cannot run without a way point settings file. Reinstalling should fix this issue or you can create your own.";

		// Token: 0x04000898 RID: 2200
		private static readonly string string_7 = "Way Point Settings File Missing";

		// Token: 0x04000899 RID: 2201
		private static readonly string string_8 = "This Joe Fish Capture Setup file is incomplete and cannot be used. Please setup all the captures before attempting to use with Joe Fish.";

		// Token: 0x0400089A RID: 2202
		private static readonly string string_9 = "Incomplete Capture File";

		// Token: 0x0400089B RID: 2203
		private static readonly string string_10 = "Joe Fish Capture Setup filename: '{0}'.";

		// Token: 0x0400089C RID: 2204
		private static readonly string string_11 = "The default Joe Fish Capture Setup file appears to be missing. Reinstalling may fix this issue or you can customize captures by creating your own file.";

		// Token: 0x0400089D RID: 2205
		private static readonly string string_12 = "Missing Settings";

		// Token: 0x0400089E RID: 2206
		private static readonly string string_13 = "The default Joe Fish Capture Setup file appears to be incomplete, altered or invalid, reinstalling may fix this issue.";

		// Token: 0x0400089F RID: 2207
		private static readonly string string_14 = "The Joe Fish dock settings file appears to be corrupt and can not be loaded; Joe Fish will save a new file when it closes.";

		// Token: 0x040008A0 RID: 2208
		private static readonly string string_15 = "Error Loading Joe Fish Dock Settings";

		// Token: 0x040008A4 RID: 2212
		private Class101 class101_0;

		// Token: 0x040008A5 RID: 2213
		private bool bool_0;

		// Token: 0x02000290 RID: 656
		[CompilerGenerated]
		private sealed class Class228
		{
			// Token: 0x06001B27 RID: 6951 RVA: 0x00009D49 File Offset: 0x00007F49
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001B28 RID: 6952 RVA: 0x000535B0 File Offset: 0x000517B0
			public void method_1(object _)
			{
				try
				{
					this.joeFish_0.class103_0 = new Class103(Class291.string_23);
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						Class291.string_23
					});
					Control sender = this.joeFish_0;
					if (JoeFish.Class228.methodInvoker_0 == null)
					{
						JoeFish.Class228.methodInvoker_0 = new MethodInvoker(JoeFish.Class228.smethod_0);
					}
					sender.smethod_6(JoeFish.Class228.methodInvoker_0);
					this.joeFish_0.class103_0 = new Class103();
				}
				this.joeFish_0.smethod_4(new MethodInvoker(this.method_2));
			}

			// Token: 0x06001B29 RID: 6953 RVA: 0x00009D5E File Offset: 0x00007F5E
			private static void smethod_0()
			{
				DialogBox.smethod_4(JoeFish.string_14, JoeFish.string_15);
			}

			// Token: 0x06001B2A RID: 6954 RVA: 0x00009D6F File Offset: 0x00007F6F
			public void method_2()
			{
				this.loading_0.method_1();
			}

			// Token: 0x040008CB RID: 2251
			public Loading loading_0;

			// Token: 0x040008CC RID: 2252
			public JoeFish joeFish_0;

			// Token: 0x040008CD RID: 2253
			private static MethodInvoker methodInvoker_0;
		}

		// Token: 0x02000291 RID: 657
		[CompilerGenerated]
		private sealed class Class229
		{
			// Token: 0x06001B2C RID: 6956 RVA: 0x00009D7C File Offset: 0x00007F7C
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001B2D RID: 6957 RVA: 0x0005364C File Offset: 0x0005184C
			public void method_1(object _)
			{
				try
				{
					this.joeFish_0.class103_0.method_1(Class291.string_23);
				}
				catch (Exception exception_)
				{
					JoeFish.Class229.Class230 @class = new JoeFish.Class229.Class230();
					@class.class229_0 = this;
					@class.exception_0 = exception_;
					@class.exception_0.smethod_1(new object[]
					{
						Class291.string_23
					});
					this.joeFish_0.smethod_6(new MethodInvoker(@class.method_0));
				}
				this.joeFish_0.smethod_4(new MethodInvoker(this.method_2));
			}

			// Token: 0x06001B2E RID: 6958 RVA: 0x00009D91 File Offset: 0x00007F91
			public void method_2()
			{
				this.loading_0.method_1();
			}

			// Token: 0x040008CE RID: 2254
			public Loading loading_0;

			// Token: 0x040008CF RID: 2255
			public JoeFish joeFish_0;

			// Token: 0x02000292 RID: 658
			private sealed class Class230
			{
				// Token: 0x06001B30 RID: 6960 RVA: 0x00009D9E File Offset: 0x00007F9E
				public void method_0()
				{
					DialogBox.smethod_7(this.exception_0, Class291.string_23);
				}

				// Token: 0x040008D0 RID: 2256
				public JoeFish.Class229 class229_0;

				// Token: 0x040008D1 RID: 2257
				public Exception exception_0;
			}
		}
	}
}
