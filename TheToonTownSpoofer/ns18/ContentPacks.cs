using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;
using ns19;
using ns20;
using ns21;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns31;

namespace ns18
{
	// Token: 0x020002B1 RID: 689
	internal sealed partial class ContentPacks : Form
	{
		// Token: 0x06001C0D RID: 7181 RVA: 0x0005A0DC File Offset: 0x000582DC
		public ContentPacks(List<string> contentPackPaths)
		{
			this.InitializeComponent();
			this.class99_0 = Class110.Instance.ConnectSettings;
			this.class114_0 = Class110.Instance.CreatedFileArchive;
			this.class112_0 = Class110.Instance.ApplicationSettings;
			if (this.SortByComboBox.SelectedIndex != 1)
			{
				this.SortByComboBox.SelectedIndex = 1;
			}
			else
			{
				this.method_0();
			}
			this.method_1();
			this.list_1 = contentPackPaths;
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x0000A694 File Offset: 0x00008894
		private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.method_0();
			this.method_4();
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x0005A154 File Offset: 0x00058354
		private void method_0()
		{
			switch (this.SortByComboBox.SelectedIndex)
			{
			default:
			{
				IEnumerable<Class102> contentPacks = this.class99_0.ContentPacks;
				if (ContentPacks.func_0 == null)
				{
					ContentPacks.func_0 = new Func<Class102, string>(ContentPacks.smethod_0);
				}
				this.list_0 = contentPacks.OrderBy(ContentPacks.func_0).ToList<Class102>();
				return;
			}
			case 1:
			{
				IEnumerable<Class102> contentPacks2 = this.class99_0.ContentPacks;
				if (ContentPacks.func_1 == null)
				{
					ContentPacks.func_1 = new Func<Class102, DateTime>(ContentPacks.smethod_1);
				}
				this.list_0 = contentPacks2.OrderBy(ContentPacks.func_1).ToList<Class102>();
				return;
			}
			}
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x0005A1EC File Offset: 0x000583EC
		private void EnableContentPacksLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			EventHandler eventHandler = null;
			ContentPacks.Class238 @class = new ContentPacks.Class238();
			@class.contentPacks_0 = this;
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
			Class110.smethod_1();
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x0005A268 File Offset: 0x00058468
		private void method_1()
		{
			if (this.class99_0.SpoofedToonTownEnabled)
			{
				this.ContentPackStatusLabel.Text = "Enabled";
				this.EnableContentPacksLink.Text = "Disable";
				this.AnimatedPointer.Enabled = false;
				return;
			}
			this.ContentPackStatusLabel.Text = "Disabled";
			this.EnableContentPacksLink.Text = "Enable";
			this.AnimatedPointer.Enabled = true;
		}

		// Token: 0x06001C12 RID: 7186 RVA: 0x0005A2DC File Offset: 0x000584DC
		private void method_2(Class135 contentPack)
		{
			this.ContentPackIconImage.Image = null;
			if (this.class135_0 != null && this.class135_0 != contentPack)
			{
				this.class135_0.Dispose();
				this.class135_0 = null;
			}
			if (contentPack == null)
			{
				this.AuthorLabel.Text = string.Empty;
				this.NameLabel.Text = string.Empty;
				this.VersionLabel.Text = string.Empty;
				this.DescriptionBox.Rtf = string.Empty;
				this.DateInstalledLabel.Text = string.Empty;
				this.CustomizeLink.Enabled = false;
				this.method_3(null);
			}
			else
			{
				this.ContentPackIconImage.Image = contentPack.ContentPack.Icon;
				this.AuthorLabel.Text = (string.IsNullOrEmpty(contentPack.ContentPack.Author) ? "Unknown" : contentPack.ContentPack.Author);
				this.NameLabel.Text = (string.IsNullOrEmpty(contentPack.ContentPack.Name) ? "Untitled" : contentPack.ContentPack.Name);
				switch (contentPack.ContentPack.Type)
				{
				case Enum82.const_0:
					this.VersionLabel.Text = "Unknown (Pre-V6)";
					break;
				case Enum82.const_1:
					this.VersionLabel.Text = (contentPack.ContentPack.Version.smethod_0() ? "Unknown" : contentPack.ContentPack.Version.ToString(4));
					break;
				}
				this.DescriptionBox.Rtf = (string.IsNullOrEmpty(contentPack.ContentPack.Description) ? string.Empty : contentPack.ContentPack.Description);
				switch (contentPack.ContentPackSettings.InstallState)
				{
				case Enum76.const_1:
				case Enum76.const_3:
					this.CustomizeLink.Enabled = !contentPack.ContentPackSettings.LoaderPack;
					break;
				default:
					this.CustomizeLink.Enabled = false;
					break;
				}
				this.DateInstalledLabel.Text = string.Format("{0:m}, {0:yyyy}", contentPack.ContentPackSettings.DateInstalled);
				this.method_3(contentPack);
			}
			this.class135_0 = contentPack;
			this.method_4();
		}

		// Token: 0x06001C13 RID: 7187 RVA: 0x0005A50C File Offset: 0x0005870C
		private void method_3(Class135 contentPack)
		{
			if (contentPack == null)
			{
				this.StatusLabel.Text = string.Empty;
				this.InstallCheckBox.Enabled = false;
				this.InstallCheckBox.Checked = false;
				this.AutoUpdateCheckBox.Enabled = false;
				this.AutoUpdateCheckBox.Checked = false;
				this.RemoveContentPackButton.Enabled = false;
				this.InstallCheckBox.Text = "[No Content Packs]";
				return;
			}
			this.RemoveContentPackButton.Enabled = true;
			this.InstallCheckBox.Enabled = this.class99_0.SpoofedToonTownEnabled;
			if (contentPack.ContentPackSettings.LoaderPack)
			{
				this.AutoUpdateCheckBox.Enabled = false;
				this.AutoUpdateCheckBox.Checked = true;
			}
			else
			{
				this.AutoUpdateCheckBox.Enabled = (contentPack.ContentPackSettings.UpdateUri != null);
				this.AutoUpdateCheckBox.Checked = contentPack.ContentPackSettings.AutoUpdate;
			}
			switch (contentPack.ContentPackSettings.InstallState)
			{
			case Enum76.const_0:
				this.InstallCheckBox.Text = "Check to install";
				this.InstallCheckBox.Checked = false;
				this.StatusLabel.Text = "Uninstalled";
				return;
			case Enum76.const_1:
				this.InstallCheckBox.Text = "Check to uninstall";
				this.InstallCheckBox.Checked = false;
				this.StatusLabel.Text = "Installed";
				return;
			case Enum76.const_2:
				this.InstallCheckBox.Text = "Log in to ToonTown to uninstall";
				this.InstallCheckBox.Checked = true;
				this.StatusLabel.Text = "Uninstall pending, please log in";
				return;
			case Enum76.const_3:
				this.InstallCheckBox.Text = "Log in to ToonTown to install";
				this.StatusLabel.Text = "Install pending, please log in";
				this.InstallCheckBox.Checked = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x06001C14 RID: 7188 RVA: 0x0005A6CC File Offset: 0x000588CC
		private void method_4()
		{
			if (this.class135_0 != null && this.list_0.Count != 0)
			{
				int num = this.list_0.IndexOf(this.class135_0.ContentPackSettings);
				this.ViewingNumberLabel.Text = string.Format("viewing {0}/{1}", num + 1, this.list_0.Count);
				this.MoveNextButton.Enabled = (num < this.list_0.Count - 1);
				this.MovePreviousButton.Enabled = (num > 0);
				return;
			}
			this.ViewingNumberLabel.Text = string.Format("viewing 0/{0}", this.list_0.Count);
			this.MoveNextButton.Enabled = false;
			this.MovePreviousButton.Enabled = false;
		}

		// Token: 0x06001C15 RID: 7189 RVA: 0x0005A79C File Offset: 0x0005899C
		public void method_5(List<string> contentPackPaths)
		{
			if (this.list_1 != null && this.list_1.Count > 0)
			{
				foreach (string path in contentPackPaths)
				{
					this.method_10(path);
				}
			}
		}

		// Token: 0x06001C16 RID: 7190 RVA: 0x0000A6A2 File Offset: 0x000088A2
		private void ContentPacks_Shown(object sender, EventArgs e)
		{
			this.method_6();
			if (this.class112_0.FirstTimeOpeningContentPacks)
			{
				this.class112_0.FirstTimeOpeningContentPacks = false;
				this.method_12();
			}
			this.method_5(this.list_1);
		}

		// Token: 0x06001C17 RID: 7191 RVA: 0x0005A804 File Offset: 0x00058A04
		private void method_6()
		{
			if (this.list_0.Count > 0)
			{
				EventHandler eventHandler = null;
				ContentPacks.Class240 @class = new ContentPacks.Class240();
				@class.contentPacks_0 = this;
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
			this.method_2(null);
		}

		// Token: 0x06001C18 RID: 7192 RVA: 0x0005A890 File Offset: 0x00058A90
		private void method_7()
		{
			MethodInvoker methodInvoker = null;
			ContentPacks.Class241 @class = new ContentPacks.Class241();
			@class.contentPacks_0 = this;
			Class132 class2 = null;
			@class.class102_0 = this.list_0[0];
			@class.class135_0 = null;
			try
			{
				class2 = new Class132(@class.class102_0.FileName, true, false);
				@class.class135_0 = new Class135(@class.class102_0, class2);
			}
			catch (Exception exception_)
			{
				ContentPacks.Class242 class3 = new ContentPacks.Class242();
				class3.class241_0 = @class;
				class3.exception_0 = exception_;
				if (class2 != null)
				{
					class2.Dispose();
				}
				class2 = null;
				if (@class.class135_0 != null)
				{
					@class.class135_0.Dispose();
				}
				@class.class135_0 = null;
				this.smethod_6(new MethodInvoker(class3.method_0));
			}
			finally
			{
				if (@class.class135_0 != null)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.smethod_6(methodInvoker);
				}
			}
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0005A988 File Offset: 0x00058B88
		private void method_8(Class102 settings)
		{
			ContentPacks.Class243 @class = new ContentPacks.Class243();
			@class.class102_0 = settings;
			@class.contentPacks_0 = this;
			EventHandler eventHandler = null;
			ContentPacks.Class244 class2 = new ContentPacks.Class244();
			class2.class243_0 = @class;
			class2.loading_0 = new Loading();
			try
			{
				Form loading_ = class2.loading_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class2.method_0);
				}
				loading_.Shown += eventHandler;
				class2.loading_0.ShowDialog();
			}
			finally
			{
				if (class2.loading_0 != null)
				{
					((IDisposable)class2.loading_0).Dispose();
				}
			}
		}

		// Token: 0x06001C1A RID: 7194 RVA: 0x0005AA14 File Offset: 0x00058C14
		private void method_9()
		{
			HashSet<string> filesUpdated;
			Class102.smethod_2(Class291.ToonTownOpenDataDirectory, out filesUpdated);
			Class110.Instance.ConnectSettings.SpoofedToonTownVersionData.method_8(null, filesUpdated, Class291.ToonTownOpenDataDirectory);
		}

		// Token: 0x06001C1B RID: 7195 RVA: 0x0000A6D5 File Offset: 0x000088D5
		private void OpenNewButton_Click(object sender, EventArgs e)
		{
			this.openFileDialog_0.FileName = string.Empty;
			if (this.openFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.method_10(this.openFileDialog_0.FileName);
			}
		}

		// Token: 0x06001C1C RID: 7196 RVA: 0x0005AA48 File Offset: 0x00058C48
		private void method_10(string path)
		{
			ContentPacks.Class247 @class = new ContentPacks.Class247();
			@class.string_0 = path;
			@class.contentPacks_0 = this;
			@class.bool_0 = false;
			EventHandler eventHandler = null;
			ContentPacks.Class248 class2 = new ContentPacks.Class248();
			class2.class247_0 = @class;
			class2.loading_0 = new Loading();
			try
			{
				Form loading_ = class2.loading_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class2.method_0);
				}
				loading_.Shown += eventHandler;
				class2.loading_0.ShowDialog();
			}
			finally
			{
				if (class2.loading_0 != null)
				{
					((IDisposable)class2.loading_0).Dispose();
				}
			}
			if (@class.bool_0)
			{
				DialogBox.smethod_3("You cannot install a loader pack content pack over an existing content pack with the same internal id.", "Invalid Install");
			}
			Class110.smethod_1();
		}

		// Token: 0x06001C1D RID: 7197 RVA: 0x0005AAF8 File Offset: 0x00058CF8
		private void InstallCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.class135_0 != null)
			{
				EventHandler eventHandler = null;
				ContentPacks.Class251 @class = new ContentPacks.Class251();
				@class.contentPacks_0 = this;
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
				this.method_2(this.class135_0);
				Class110.smethod_1();
			}
		}

		// Token: 0x06001C1E RID: 7198 RVA: 0x0005AB88 File Offset: 0x00058D88
		private void RemoveContentPackButton_Click(object sender, EventArgs e)
		{
			if (this.class135_0 != null && DialogBox.smethod_6(string.Format("Are you sure you want to remove '{0}'?", string.IsNullOrEmpty(this.class135_0.ContentPackSettings.Name) ? "Unknown" : this.class135_0.ContentPackSettings.Name), "Remove Content Pack", new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			}) == DialogResult.Yes)
			{
				this.method_11(this.class135_0.ContentPackSettings);
			}
		}

		// Token: 0x06001C1F RID: 7199 RVA: 0x0005AC04 File Offset: 0x00058E04
		private void method_11(Class102 settings)
		{
			ContentPacks.Class252 @class = new ContentPacks.Class252();
			@class.class102_0 = settings;
			@class.contentPacks_0 = this;
			EventHandler eventHandler = null;
			ContentPacks.Class253 class2 = new ContentPacks.Class253();
			class2.class252_0 = @class;
			class2.loading_0 = new Loading();
			try
			{
				Form loading_ = class2.loading_0;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(class2.method_0);
				}
				loading_.Shown += eventHandler;
				class2.loading_0.ShowDialog();
			}
			finally
			{
				if (class2.loading_0 != null)
				{
					((IDisposable)class2.loading_0).Dispose();
				}
			}
			Class110.smethod_1();
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000050D4 File Offset: 0x000032D4
		private void CloseButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x0000A706 File Offset: 0x00008906
		private void MovePreviousButton_Click(object sender, EventArgs e)
		{
			this.method_8(this.list_0[this.list_0.IndexOf(this.class135_0.ContentPackSettings) - 1]);
		}

		// Token: 0x06001C22 RID: 7202 RVA: 0x0000A731 File Offset: 0x00008931
		private void MoveNextButton_Click(object sender, EventArgs e)
		{
			this.method_8(this.list_0[this.list_0.IndexOf(this.class135_0.ContentPackSettings) + 1]);
		}

		// Token: 0x06001C23 RID: 7203 RVA: 0x0005AC94 File Offset: 0x00058E94
		private void CreateYourOwnButton_Click(object sender, EventArgs e)
		{
			if (Class509.CanOpenMakePackageOrDialog)
			{
				ContentPacks.Class254 @class = new ContentPacks.Class254();
				Class509.MakePackageOpen = true;
				@class.class499_0 = new Class499(this);
				@class.makePackage_0 = new MakePackage();
				@class.class499_0.method_2(@class.makePackage_0, true);
				@class.makePackage_0.FormClosed += @class.method_0;
				@class.makePackage_0.Show();
			}
		}

		// Token: 0x06001C24 RID: 7204 RVA: 0x0000A75C File Offset: 0x0000895C
		private void AddNightLifeButton_Click(object sender, EventArgs e)
		{
			this.method_12();
		}

		// Token: 0x06001C25 RID: 7205 RVA: 0x0005AD00 File Offset: 0x00058F00
		private void method_12()
		{
			if (File.Exists(Class291.string_26))
			{
				this.method_10(Class291.string_26);
				return;
			}
			if (File.Exists(Class291.string_25))
			{
				try
				{
					Guid id;
					using (Class132 @class = new Class132(Class291.string_25, false, false))
					{
						id = @class.ID;
					}
					Class102 class2 = Class102.smethod_0(id);
					if (class2 == null)
					{
						this.method_10(Class291.string_25);
					}
					else
					{
						DialogBox.smethod_3("The NightLife content pack has already been installed.", "NightLife Already Installed");
						this.method_8(class2);
					}
					return;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						Class291.string_25
					});
					DialogBox.smethod_7(ex, Class291.string_25);
					return;
				}
			}
			DialogBox.smethod_4("The NightLight installer content pack is missing. Please reinstall The ToonTown Spoofer.", "NightLife Installer Missing");
		}

		// Token: 0x06001C26 RID: 7206 RVA: 0x0000A764 File Offset: 0x00008964
		private void AutoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.class135_0 != null)
			{
				this.class135_0.ContentPackSettings.AutoUpdate = this.AutoUpdateCheckBox.Checked;
				Class110.smethod_1();
			}
		}

		// Token: 0x06001C27 RID: 7207 RVA: 0x0005ADD4 File Offset: 0x00058FD4
		private void CustomizeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			using (Class499 @class = new Class499(this))
			{
				using (CustomizeContentPack customizeContentPack = new CustomizeContentPack(this.class135_0.ContentPackSettings))
				{
					@class.method_0(customizeContentPack);
					if (customizeContentPack.ShowDialog() == DialogResult.OK)
					{
						EventHandler eventHandler = null;
						ContentPacks.Class255 class2 = new ContentPacks.Class255();
						class2.contentPacks_0 = this;
						class2.loading_0 = new Loading();
						try
						{
							Form loading_ = class2.loading_0;
							if (eventHandler == null)
							{
								eventHandler = new EventHandler(class2.method_0);
							}
							loading_.Shown += eventHandler;
							class2.loading_0.ShowDialog();
						}
						finally
						{
							if (class2.loading_0 != null)
							{
								((IDisposable)class2.loading_0).Dispose();
							}
						}
					}
				}
			}
			Class110.smethod_1();
		}

		// Token: 0x06001C28 RID: 7208 RVA: 0x0000A78F File Offset: 0x0000898F
		private void ContentPacks_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_3);
			e.Handled = true;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x0000A79E File Offset: 0x0000899E
		[CompilerGenerated]
		private static string smethod_0(Class102 item)
		{
			return item.Name;
		}

		// Token: 0x06001C2A RID: 7210 RVA: 0x0000A7A6 File Offset: 0x000089A6
		[CompilerGenerated]
		private static DateTime smethod_1(Class102 item)
		{
			return item.DateInstalled;
		}

		// Token: 0x040009D6 RID: 2518
		private List<Class102> list_0;

		// Token: 0x040009D7 RID: 2519
		private Class99 class99_0;

		// Token: 0x040009D8 RID: 2520
		private List<string> list_1;

		// Token: 0x040009D9 RID: 2521
		private Class114 class114_0;

		// Token: 0x040009DA RID: 2522
		private Class112 class112_0;

		// Token: 0x040009DB RID: 2523
		[CompilerGenerated]
		private static Func<Class102, string> func_0;

		// Token: 0x040009DC RID: 2524
		[CompilerGenerated]
		private static Func<Class102, DateTime> func_1;

		// Token: 0x020002B2 RID: 690
		[CompilerGenerated]
		private sealed class Class238
		{
			// Token: 0x06001C2C RID: 7212 RVA: 0x0000A7AE File Offset: 0x000089AE
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_1));
			}

			// Token: 0x06001C2D RID: 7213 RVA: 0x0005AEA8 File Offset: 0x000590A8
			public void method_1(object state)
			{
				MethodInvoker methodInvoker = null;
				try
				{
					this.contentPacks_0.class99_0.SpoofedToonTownEnabled = !this.contentPacks_0.class99_0.SpoofedToonTownEnabled;
					if (this.contentPacks_0.class99_0.SpoofedToonTownEnabled)
					{
						this.contentPacks_0.class99_0.PatchServer.method_5();
					}
					else
					{
						this.contentPacks_0.class99_0.PatchServer.method_6();
					}
					if (this.contentPacks_0.class99_0.SpoofedToonTownEnabled)
					{
						foreach (KeyValuePair<string, Class186> keyValuePair in this.contentPacks_0.class99_0.ActualToonTownVersionData.FILES)
						{
							if (Class136.smethod_6(keyValuePair.Key))
							{
								string text = Path.Combine(Class291.ToonTownOpenDataDirectory, keyValuePair.Key);
								if (File.Exists(text))
								{
									string text2 = Path.Combine(Class291.ToonTownOpenDataDirectory, keyValuePair.Key + ".orig");
									File.Copy(text, text2, true);
									this.contentPacks_0.class114_0.method_4(text2);
								}
							}
						}
						this.contentPacks_0.class99_0.SpoofedToonTownVersionData.method_4(this.contentPacks_0.class99_0.ActualToonTownVersionData);
					}
					else
					{
						foreach (KeyValuePair<string, Class186> keyValuePair2 in this.contentPacks_0.class99_0.SpoofedToonTownVersionData.FILES)
						{
							string text3 = Path.Combine(Class291.ToonTownOpenDataDirectory, keyValuePair2.Key);
							string text4 = Path.Combine(Class291.ToonTownOpenDataDirectory, keyValuePair2.Key + ".orig");
							if (File.Exists(text4))
							{
								Class234.smethod_14(text4, text3, true);
								Class110.Instance.CreatedFileArchive.method_5(text4);
								Class110.Instance.CreatedFileArchive.method_4(text3);
							}
						}
						using (List<Class102>.Enumerator enumerator3 = this.contentPacks_0.class99_0.ContentPacks.GetEnumerator())
						{
							Action<string> action = null;
							ContentPacks.Class238.Class239 @class = new ContentPacks.Class238.Class239();
							@class.class238_0 = this;
							while (enumerator3.MoveNext())
							{
								Class102 class102_ = enumerator3.Current;
								@class.class102_0 = class102_;
								IEnumerable<string> keys = @class.class102_0.dictionary_0.Keys;
								if (action == null)
								{
									action = new Action<string>(@class.method_0);
								}
								keys.smethod_7(action);
								switch (@class.class102_0.InstallState)
								{
								case Enum76.const_1:
									@class.class102_0.InstallState = Enum76.const_3;
									break;
								case Enum76.const_2:
									@class.class102_0.InstallState = Enum76.const_0;
									break;
								}
							}
						}
					}
				}
				finally
				{
					Control sender = this.contentPacks_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_2);
					}
					sender.smethod_4(methodInvoker);
				}
			}

			// Token: 0x06001C2E RID: 7214 RVA: 0x0000A7C2 File Offset: 0x000089C2
			public void method_2()
			{
				this.contentPacks_0.method_3(this.contentPacks_0.class135_0);
				this.contentPacks_0.method_1();
				this.loading_0.method_1();
			}

			// Token: 0x040009DD RID: 2525
			public Loading loading_0;

			// Token: 0x040009DE RID: 2526
			public ContentPacks contentPacks_0;

			// Token: 0x020002B3 RID: 691
			private sealed class Class239
			{
				// Token: 0x06001C30 RID: 7216 RVA: 0x0005B1DC File Offset: 0x000593DC
				public void method_0(string item)
				{
					switch (this.class102_0.dictionary_0[item].enum76_0)
					{
					case Enum76.const_1:
						this.class102_0.dictionary_0[item].enum76_0 = Enum76.const_3;
						return;
					case Enum76.const_2:
						this.class102_0.dictionary_0[item].enum76_0 = Enum76.const_0;
						return;
					default:
						return;
					}
				}

				// Token: 0x040009DF RID: 2527
				public ContentPacks.Class238 class238_0;

				// Token: 0x040009E0 RID: 2528
				public Class102 class102_0;
			}
		}

		// Token: 0x020002B4 RID: 692
		[CompilerGenerated]
		private sealed class Class240
		{
			// Token: 0x06001C32 RID: 7218 RVA: 0x0000A7F0 File Offset: 0x000089F0
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001C33 RID: 7219 RVA: 0x0005B240 File Offset: 0x00059440
			public void method_1(object _)
			{
				MethodInvoker methodInvoker = null;
				try
				{
					this.contentPacks_0.method_7();
				}
				finally
				{
					Control sender = this.contentPacks_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_2);
					}
					sender.smethod_4(methodInvoker);
				}
			}

			// Token: 0x06001C34 RID: 7220 RVA: 0x0000A805 File Offset: 0x00008A05
			public void method_2()
			{
				this.loading_0.method_1();
			}

			// Token: 0x040009E1 RID: 2529
			public Loading loading_0;

			// Token: 0x040009E2 RID: 2530
			public ContentPacks contentPacks_0;
		}

		// Token: 0x020002B5 RID: 693
		[CompilerGenerated]
		private sealed class Class241
		{
			// Token: 0x06001C36 RID: 7222 RVA: 0x0000A812 File Offset: 0x00008A12
			public void method_0()
			{
				this.contentPacks_0.method_2(this.class135_0);
			}

			// Token: 0x040009E3 RID: 2531
			public Class102 class102_0;

			// Token: 0x040009E4 RID: 2532
			public Class135 class135_0;

			// Token: 0x040009E5 RID: 2533
			public ContentPacks contentPacks_0;
		}

		// Token: 0x020002B6 RID: 694
		[CompilerGenerated]
		private sealed class Class242
		{
			// Token: 0x06001C38 RID: 7224 RVA: 0x0000A825 File Offset: 0x00008A25
			public void method_0()
			{
				DialogBox.smethod_7(this.exception_0, this.class241_0.class102_0.FileName);
				this.class241_0.contentPacks_0.method_11(this.class241_0.class102_0);
			}

			// Token: 0x040009E6 RID: 2534
			public ContentPacks.Class241 class241_0;

			// Token: 0x040009E7 RID: 2535
			public Exception exception_0;
		}

		// Token: 0x020002B7 RID: 695
		[CompilerGenerated]
		private sealed class Class243
		{
			// Token: 0x040009E8 RID: 2536
			public ContentPacks contentPacks_0;

			// Token: 0x040009E9 RID: 2537
			public Class102 class102_0;
		}

		// Token: 0x020002B8 RID: 696
		[CompilerGenerated]
		private sealed class Class244
		{
			// Token: 0x06001C3B RID: 7227 RVA: 0x0000A85D File Offset: 0x00008A5D
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001C3C RID: 7228 RVA: 0x0005B28C File Offset: 0x0005948C
			public void method_1(object _)
			{
				MethodInvoker methodInvoker = null;
				ContentPacks.Class244.Class245 @class = new ContentPacks.Class244.Class245();
				@class.class244_0 = this;
				@class.class243_0 = this.class243_0;
				@class.class132_0 = null;
				@class.class135_0 = null;
				try
				{
					@class.class132_0 = new Class132(this.class243_0.class102_0.FileName, true, false);
					@class.class135_0 = new Class135(this.class243_0.class102_0, @class.class132_0);
				}
				catch (Exception exception_)
				{
					ContentPacks.Class244.Class246 class2 = new ContentPacks.Class244.Class246();
					class2.class245_0 = @class;
					class2.class244_0 = this;
					class2.class243_0 = this.class243_0;
					class2.exception_0 = exception_;
					if (@class.class132_0 != null)
					{
						@class.class132_0.Dispose();
					}
					@class.class132_0 = null;
					if (@class.class135_0 != null)
					{
						@class.class135_0.Dispose();
					}
					@class.class135_0 = null;
					this.class243_0.contentPacks_0.smethod_6(new MethodInvoker(class2.method_0));
				}
				finally
				{
					Control contentPacks_ = this.class243_0.contentPacks_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					contentPacks_.smethod_4(methodInvoker);
				}
			}

			// Token: 0x040009EA RID: 2538
			public ContentPacks.Class243 class243_0;

			// Token: 0x040009EB RID: 2539
			public Loading loading_0;

			// Token: 0x020002B9 RID: 697
			private sealed class Class245
			{
				// Token: 0x06001C3E RID: 7230 RVA: 0x0000A872 File Offset: 0x00008A72
				public void method_0()
				{
					if (this.class132_0 != null)
					{
						this.class243_0.contentPacks_0.method_2(this.class135_0);
					}
					this.class244_0.loading_0.method_1();
				}

				// Token: 0x040009EC RID: 2540
				public ContentPacks.Class244 class244_0;

				// Token: 0x040009ED RID: 2541
				public ContentPacks.Class243 class243_0;

				// Token: 0x040009EE RID: 2542
				public Class132 class132_0;

				// Token: 0x040009EF RID: 2543
				public Class135 class135_0;
			}

			// Token: 0x020002BA RID: 698
			private sealed class Class246
			{
				// Token: 0x06001C40 RID: 7232 RVA: 0x0000A8A2 File Offset: 0x00008AA2
				public void method_0()
				{
					DialogBox.smethod_7(this.exception_0, this.class243_0.class102_0.FileName);
					this.class243_0.contentPacks_0.method_11(this.class243_0.class102_0);
				}

				// Token: 0x040009F0 RID: 2544
				public ContentPacks.Class244.Class245 class245_0;

				// Token: 0x040009F1 RID: 2545
				public ContentPacks.Class244 class244_0;

				// Token: 0x040009F2 RID: 2546
				public ContentPacks.Class243 class243_0;

				// Token: 0x040009F3 RID: 2547
				public Exception exception_0;
			}
		}

		// Token: 0x020002BB RID: 699
		[CompilerGenerated]
		private sealed class Class247
		{
			// Token: 0x040009F4 RID: 2548
			public bool bool_0;

			// Token: 0x040009F5 RID: 2549
			public ContentPacks contentPacks_0;

			// Token: 0x040009F6 RID: 2550
			public string string_0;
		}

		// Token: 0x020002BC RID: 700
		[CompilerGenerated]
		private sealed class Class248
		{
			// Token: 0x06001C43 RID: 7235 RVA: 0x0000A8DA File Offset: 0x00008ADA
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001C44 RID: 7236 RVA: 0x0005B3B8 File Offset: 0x000595B8
			public void method_1(object _)
			{
				MethodInvoker methodInvoker = null;
				ContentPacks.Class248.Class249 @class = new ContentPacks.Class248.Class249();
				@class.class248_0 = this;
				@class.class247_0 = this.class247_0;
				Class132 class2 = null;
				Class102 class3 = null;
				@class.class135_0 = null;
				try
				{
					Guid id;
					Struct43 dataHash;
					Enum82 type;
					bool loaderPack;
					using (Class132 class4 = new Class132(this.class247_0.string_0, false, false))
					{
						class3 = Class102.smethod_0(class4.ID);
						id = class4.ID;
						dataHash = class4.DataHash;
						type = class4.Type;
						loaderPack = class4.LoaderPack;
					}
					if (class3 == null || !loaderPack)
					{
						string text = Path.Combine(Class291.ContentPackDataDirectory, id.ToString() + ".ttp");
						File.Copy(this.class247_0.string_0, text, true);
						class2 = new Class132(text, true, false);
						this.class247_0.string_0 = text;
					}
					if (class3 == null)
					{
						Struct43 contentPackHash;
						switch (type)
						{
						case Enum82.const_0:
							contentPackHash = dataHash;
							goto IL_118;
						}
						using (Stream stream = File.Open(this.class247_0.string_0, FileMode.Open, FileAccess.Read, FileShare.None))
						{
							contentPackHash = stream.smethod_2();
						}
						IL_118:
						class3 = new Class102(class2, contentPackHash, this.class247_0.string_0);
						@class.class135_0 = new Class135(class3, class2);
					}
					else if (loaderPack)
					{
						this.class247_0.bool_0 = true;
					}
					else
					{
						class3.method_5();
						this.class247_0.contentPacks_0.method_9();
						@class.class135_0 = new Class135(class3, class2);
					}
				}
				catch (Exception exception_)
				{
					ContentPacks.Class248.Class250 class5 = new ContentPacks.Class248.Class250();
					class5.class249_0 = @class;
					class5.class248_0 = this;
					class5.class247_0 = this.class247_0;
					class5.exception_0 = exception_;
					if (class2 != null)
					{
						class2.Dispose();
					}
					class2 = null;
					class3 = null;
					if (@class.class135_0 != null)
					{
						@class.class135_0.Dispose();
					}
					@class.class135_0 = null;
					class5.exception_0.smethod_1(new object[]
					{
						this.class247_0.string_0
					});
					this.class247_0.contentPacks_0.smethod_6(new MethodInvoker(class5.method_0));
				}
				finally
				{
					Control contentPacks_ = this.class247_0.contentPacks_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					contentPacks_.smethod_4(methodInvoker);
				}
			}

			// Token: 0x040009F7 RID: 2551
			public ContentPacks.Class247 class247_0;

			// Token: 0x040009F8 RID: 2552
			public Loading loading_0;

			// Token: 0x020002BD RID: 701
			private sealed class Class249
			{
				// Token: 0x06001C46 RID: 7238 RVA: 0x0005B668 File Offset: 0x00059868
				public void method_0()
				{
					if (this.class135_0 != null)
					{
						if (!this.class247_0.contentPacks_0.class99_0.ContentPacks.Contains(this.class135_0.ContentPackSettings))
						{
							this.class247_0.contentPacks_0.class99_0.ContentPacks.Add(this.class135_0.ContentPackSettings);
						}
						this.class247_0.contentPacks_0.method_0();
						this.class247_0.contentPacks_0.method_2(this.class135_0);
					}
					this.class248_0.loading_0.method_1();
				}

				// Token: 0x040009F9 RID: 2553
				public ContentPacks.Class248 class248_0;

				// Token: 0x040009FA RID: 2554
				public ContentPacks.Class247 class247_0;

				// Token: 0x040009FB RID: 2555
				public Class135 class135_0;
			}

			// Token: 0x020002BE RID: 702
			private sealed class Class250
			{
				// Token: 0x06001C48 RID: 7240 RVA: 0x0000A8EF File Offset: 0x00008AEF
				public void method_0()
				{
					DialogBox.smethod_7(this.exception_0, this.class247_0.string_0);
				}

				// Token: 0x040009FC RID: 2556
				public ContentPacks.Class248.Class249 class249_0;

				// Token: 0x040009FD RID: 2557
				public ContentPacks.Class248 class248_0;

				// Token: 0x040009FE RID: 2558
				public ContentPacks.Class247 class247_0;

				// Token: 0x040009FF RID: 2559
				public Exception exception_0;
			}
		}

		// Token: 0x020002BF RID: 703
		[CompilerGenerated]
		private sealed class Class251
		{
			// Token: 0x06001C4A RID: 7242 RVA: 0x0000A907 File Offset: 0x00008B07
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001C4B RID: 7243 RVA: 0x0005B700 File Offset: 0x00059900
			public void method_1(object _)
			{
				MethodInvoker methodInvoker = null;
				try
				{
					switch (this.contentPacks_0.class135_0.ContentPackSettings.InstallState)
					{
					case Enum76.const_0:
						if (this.contentPacks_0.InstallCheckBox.Checked)
						{
							this.contentPacks_0.class135_0.ContentPackSettings.InstallState = Enum76.const_3;
						}
						break;
					case Enum76.const_1:
						if (this.contentPacks_0.InstallCheckBox.Checked)
						{
							this.contentPacks_0.class135_0.ContentPackSettings.InstallState = Enum76.const_2;
						}
						break;
					case Enum76.const_2:
						if (!this.contentPacks_0.InstallCheckBox.Checked)
						{
							this.contentPacks_0.class135_0.ContentPackSettings.InstallState = Enum76.const_1;
						}
						break;
					case Enum76.const_3:
						if (!this.contentPacks_0.InstallCheckBox.Checked)
						{
							this.contentPacks_0.class135_0.ContentPackSettings.InstallState = Enum76.const_2;
						}
						break;
					}
					this.contentPacks_0.method_9();
				}
				finally
				{
					Control sender = this.contentPacks_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_2);
					}
					sender.smethod_4(methodInvoker);
				}
			}

			// Token: 0x06001C4C RID: 7244 RVA: 0x0000A91C File Offset: 0x00008B1C
			public void method_2()
			{
				this.loading_0.method_1();
			}

			// Token: 0x04000A00 RID: 2560
			public Loading loading_0;

			// Token: 0x04000A01 RID: 2561
			public ContentPacks contentPacks_0;
		}

		// Token: 0x020002C0 RID: 704
		[CompilerGenerated]
		private sealed class Class252
		{
			// Token: 0x04000A02 RID: 2562
			public ContentPacks contentPacks_0;

			// Token: 0x04000A03 RID: 2563
			public Class102 class102_0;
		}

		// Token: 0x020002C1 RID: 705
		[CompilerGenerated]
		private sealed class Class253
		{
			// Token: 0x06001C4F RID: 7247 RVA: 0x0000A929 File Offset: 0x00008B29
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001C50 RID: 7248 RVA: 0x0005B824 File Offset: 0x00059A24
			public void method_1(object state)
			{
				MethodInvoker methodInvoker = null;
				MethodInvoker methodInvoker2 = null;
				try
				{
					if (this.class252_0.contentPacks_0.class99_0.SpoofedToonTownEnabled)
					{
						switch (this.class252_0.class102_0.InstallState)
						{
						case Enum76.const_1:
						case Enum76.const_2:
							this.class252_0.class102_0.InstallState = Enum76.const_2;
							this.class252_0.contentPacks_0.method_9();
							break;
						}
					}
					if (File.Exists(this.class252_0.class102_0.FileName))
					{
						File.Delete(this.class252_0.class102_0.FileName);
					}
					this.class252_0.contentPacks_0.list_0.Remove(this.class252_0.class102_0);
					this.class252_0.contentPacks_0.class99_0.ContentPacks.Remove(this.class252_0.class102_0);
				}
				finally
				{
					if (this.class252_0.contentPacks_0.list_0.Count > 0)
					{
						this.class252_0.contentPacks_0.method_7();
						Control contentPacks_ = this.class252_0.contentPacks_0;
						if (methodInvoker == null)
						{
							methodInvoker = new MethodInvoker(this.method_2);
						}
						contentPacks_.smethod_4(methodInvoker);
					}
					else
					{
						Control contentPacks_2 = this.class252_0.contentPacks_0;
						if (methodInvoker2 == null)
						{
							methodInvoker2 = new MethodInvoker(this.method_3);
						}
						contentPacks_2.smethod_4(methodInvoker2);
					}
				}
			}

			// Token: 0x06001C51 RID: 7249 RVA: 0x0000A93E File Offset: 0x00008B3E
			public void method_2()
			{
				this.loading_0.method_1();
			}

			// Token: 0x06001C52 RID: 7250 RVA: 0x0000A94B File Offset: 0x00008B4B
			public void method_3()
			{
				this.class252_0.contentPacks_0.method_2(null);
				this.loading_0.method_1();
			}

			// Token: 0x04000A04 RID: 2564
			public ContentPacks.Class252 class252_0;

			// Token: 0x04000A05 RID: 2565
			public Loading loading_0;
		}

		// Token: 0x020002C2 RID: 706
		[CompilerGenerated]
		private sealed class Class254
		{
			// Token: 0x06001C54 RID: 7252 RVA: 0x0000A969 File Offset: 0x00008B69
			public void method_0(object sender, FormClosedEventArgs e)
			{
				Class509.MakePackageOpen = false;
				this.class499_0.Dispose();
				this.makePackage_0.Dispose();
			}

			// Token: 0x04000A06 RID: 2566
			public Class499 class499_0;

			// Token: 0x04000A07 RID: 2567
			public MakePackage makePackage_0;
		}

		// Token: 0x020002C3 RID: 707
		[CompilerGenerated]
		private sealed class Class255
		{
			// Token: 0x06001C56 RID: 7254 RVA: 0x0000A987 File Offset: 0x00008B87
			public void method_0(object sender, EventArgs e)
			{
				ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_1), null);
			}

			// Token: 0x06001C57 RID: 7255 RVA: 0x0005B984 File Offset: 0x00059B84
			public void method_1(object _)
			{
				MethodInvoker methodInvoker = null;
				try
				{
					this.contentPacks_0.method_9();
				}
				finally
				{
					Control sender = this.contentPacks_0;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_2);
					}
					sender.smethod_4(methodInvoker);
				}
			}

			// Token: 0x06001C58 RID: 7256 RVA: 0x0000A99C File Offset: 0x00008B9C
			public void method_2()
			{
				this.loading_0.method_1();
			}

			// Token: 0x04000A08 RID: 2568
			public Loading loading_0;

			// Token: 0x04000A09 RID: 2569
			public ContentPacks contentPacks_0;
		}
	}
}
