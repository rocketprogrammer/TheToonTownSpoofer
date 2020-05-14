using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;
using ns17;
using ns26;
using ns27;
using ns28;
using ns29;
using ns30;
using ns31;

namespace ns20
{
	// Token: 0x0200044E RID: 1102
	internal static class Class460
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x0009E630 File Offset: 0x0009C830
		public static WindowSelect_1 smethod_0(EventHandler<EventArgs15> e = null)
		{
			EventHandler<EventArgs15> eventHandler = null;
			Class460.Class461 @class = new Class460.Class461();
			@class.eventHandler_0 = e;
			WindowSelect_1 windowSelect_ = null;
			WindowSelect_1 result;
			try
			{
				windowSelect_ = new WindowSelect_1();
				windowSelect_.LabelMessage = "click and drag the target onto the ToonTown window";
				windowSelect_.SelectedHandleChanging += Class460.smethod_1;
				if (@class.eventHandler_0 != null)
				{
					WindowSelect windowSelect = windowSelect_;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler<EventArgs15>(@class.method_0);
					}
					windowSelect.SelectedHandleChanging += eventHandler;
				}
				result = windowSelect_;
			}
			catch
			{
				if (windowSelect_ != null)
				{
					windowSelect_.Dispose();
				}
				throw;
			}
			return result;
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x0009E6B4 File Offset: 0x0009C8B4
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static void smethod_1(object sender, EventArgs15 e)
		{
			using (Process process = Class265.smethod_7(e.Handle))
			{
				try
				{
					if (process.ProcessName.ToLower() == Class502.string_9)
					{
						e.IsValid = true;
					}
				}
				catch (Exception)
				{
					e.IsValid = false;
				}
			}
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x0009E720 File Offset: 0x0009C920
		public static bool smethod_2(out Class524 selectedFile)
		{
			bool result;
			using (FileSelect fileSelect = new FileSelect())
			{
				fileSelect.InputLabelMessage = "Please enter a reference name for this capture file.";
				fileSelect.InputText = "The ToonTown Spoofer : Joe Fish Capture Setup File Name";
				fileSelect.FileInfo = Class110.Instance.JoeFishSettings.JoeFishCaptureSettings.Files.ToArray();
				fileSelect.Filter = "Joe Fish Capture Setup File|*.jfc";
				fileSelect.InstallFolder = Class291.JoeFishCaptureSettingsDirectory;
				fileSelect.FileExtension = ".jfc";
				FileSelectBase fileSelectBase = fileSelect;
				if (Class460.eventHandler_0 == null)
				{
					Class460.eventHandler_0 = new EventHandler<EventArgs43<string>>(Class460.smethod_6);
				}
				fileSelectBase.InputValidating += Class460.eventHandler_0;
				if (fileSelect.ShowDialog() == DialogResult.OK)
				{
					selectedFile = fileSelect.SelectedFileInfo;
				}
				else
				{
					selectedFile = null;
				}
				Class110.Instance.JoeFishSettings.JoeFishCaptureSettings.Files.Clear();
				Class110.Instance.JoeFishSettings.JoeFishCaptureSettings.Files.AddRange(fileSelect.FileInfo);
				Class110.smethod_1();
				result = Class524.smethod_1(selectedFile, null);
			}
			return result;
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x0009E828 File Offset: 0x0009CA28
		public static bool smethod_3(out Class524 selectedFile)
		{
			bool result;
			using (FileSelect fileSelect = new FileSelect())
			{
				fileSelect.InputLabelMessage = "Please enter a reference name for this capture file.";
				fileSelect.InputText = "The ToonTown Spoofer : Gardener Flora Capture Setup File Name";
				fileSelect.FileInfo = Class110.Instance.GardenerFloraSettings.GardenerFloraCaptureFiles.Files.ToArray();
				fileSelect.Filter = "Gardener Flora Capture Setup File|*.gfc";
				fileSelect.InstallFolder = Class291.GardenerFloraCaptureSettingsDirectory;
				fileSelect.FileExtension = ".gfc";
				FileSelectBase fileSelectBase = fileSelect;
				if (Class460.eventHandler_1 == null)
				{
					Class460.eventHandler_1 = new EventHandler<EventArgs43<string>>(Class460.smethod_7);
				}
				fileSelectBase.InputValidating += Class460.eventHandler_1;
				if (fileSelect.ShowDialog() == DialogResult.OK)
				{
					selectedFile = fileSelect.SelectedFileInfo;
				}
				else
				{
					selectedFile = null;
				}
				Class110.Instance.GardenerFloraSettings.GardenerFloraCaptureFiles.Files.Clear();
				Class110.Instance.GardenerFloraSettings.GardenerFloraCaptureFiles.Files.AddRange(fileSelect.FileInfo);
				Class110.smethod_1();
				result = Class524.smethod_1(selectedFile, null);
			}
			return result;
		}

		// Token: 0x0600296C RID: 10604 RVA: 0x0009E930 File Offset: 0x0009CB30
		public static bool smethod_4(out Class524 selectedFile)
		{
			bool result;
			using (FileSelect fileSelect = new FileSelect())
			{
				fileSelect.InputLabelMessage = "Please enter a reference name for this flora file.";
				fileSelect.InputText = "The ToonTown Spoofer : Gardener Flora File Name";
				fileSelect.FileInfo = Class110.Instance.GardenerFloraSettings.GardenerFloraFiles.Files.ToArray();
				fileSelect.Filter = "Gardener Flora File|*.flora";
				fileSelect.InstallFolder = Class291.GardenerFloraEstateSettings;
				fileSelect.FileExtension = ".flora";
				FileSelectBase fileSelectBase = fileSelect;
				if (Class460.eventHandler_2 == null)
				{
					Class460.eventHandler_2 = new EventHandler<EventArgs43<string>>(Class460.smethod_8);
				}
				fileSelectBase.InputValidating += Class460.eventHandler_2;
				if (fileSelect.ShowDialog() == DialogResult.OK)
				{
					selectedFile = fileSelect.SelectedFileInfo;
				}
				else
				{
					selectedFile = null;
				}
				Class110.Instance.GardenerFloraSettings.GardenerFloraFiles.Files.Clear();
				Class110.Instance.GardenerFloraSettings.GardenerFloraFiles.Files.AddRange(fileSelect.FileInfo);
				Class110.smethod_1();
				result = Class524.smethod_1(selectedFile, null);
			}
			return result;
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0009EA38 File Offset: 0x0009CC38
		public static bool smethod_5(out Class524 selectedFile)
		{
			bool result;
			using (FileSelect fileSelect = new FileSelect())
			{
				fileSelect.InputLabelMessage = "Please enter a reference name for this Race Track file.";
				fileSelect.InputText = "The ToonTown Spoofer : Race Track File Name";
				fileSelect.FileInfo = Class110.Instance.RaceTrackFileIndex.Files.ToArray();
				fileSelect.Filter = "Race Track File|*.race";
				fileSelect.InstallFolder = Class291.RaceTrackSettingsDirectory;
				fileSelect.FileExtension = ".race";
				FileSelectBase fileSelectBase = fileSelect;
				if (Class460.eventHandler_3 == null)
				{
					Class460.eventHandler_3 = new EventHandler<EventArgs43<string>>(Class460.smethod_9);
				}
				fileSelectBase.InputValidating += Class460.eventHandler_3;
				if (fileSelect.ShowDialog() == DialogResult.OK)
				{
					selectedFile = fileSelect.SelectedFileInfo;
				}
				else
				{
					selectedFile = null;
				}
				Class110.Instance.RaceTrackFileIndex.Files.Clear();
				Class110.Instance.RaceTrackFileIndex.Files.AddRange(fileSelect.FileInfo);
				Class110.smethod_1();
				result = Class524.smethod_1(selectedFile, null);
			}
			return result;
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x00013130 File Offset: 0x00011330
		[CompilerGenerated]
		private static void smethod_6(object sender, EventArgs43<string> e)
		{
			if (string.IsNullOrEmpty(e.gparam_0))
			{
				DialogBox.smethod_3("Please enter a name.", "Empty Name");
				e.IsValid = false;
				return;
			}
			e.IsValid = true;
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x00013130 File Offset: 0x00011330
		[CompilerGenerated]
		private static void smethod_7(object sender, EventArgs43<string> e)
		{
			if (string.IsNullOrEmpty(e.gparam_0))
			{
				DialogBox.smethod_3("Please enter a name.", "Empty Name");
				e.IsValid = false;
				return;
			}
			e.IsValid = true;
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x00013130 File Offset: 0x00011330
		[CompilerGenerated]
		private static void smethod_8(object sender, EventArgs43<string> e)
		{
			if (string.IsNullOrEmpty(e.gparam_0))
			{
				DialogBox.smethod_3("Please enter a name.", "Empty Name");
				e.IsValid = false;
				return;
			}
			e.IsValid = true;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x00013130 File Offset: 0x00011330
		[CompilerGenerated]
		private static void smethod_9(object sender, EventArgs43<string> e)
		{
			if (string.IsNullOrEmpty(e.gparam_0))
			{
				DialogBox.smethod_3("Please enter a name.", "Empty Name");
				e.IsValid = false;
				return;
			}
			e.IsValid = true;
		}

		// Token: 0x04001581 RID: 5505
		[CompilerGenerated]
		private static EventHandler<EventArgs43<string>> eventHandler_0;

		// Token: 0x04001582 RID: 5506
		[CompilerGenerated]
		private static EventHandler<EventArgs43<string>> eventHandler_1;

		// Token: 0x04001583 RID: 5507
		[CompilerGenerated]
		private static EventHandler<EventArgs43<string>> eventHandler_2;

		// Token: 0x04001584 RID: 5508
		[CompilerGenerated]
		private static EventHandler<EventArgs43<string>> eventHandler_3;

		// Token: 0x0200044F RID: 1103
		[CompilerGenerated]
		private sealed class Class461
		{
			// Token: 0x06002973 RID: 10611 RVA: 0x0001315D File Offset: 0x0001135D
			public void method_0(object sender, EventArgs15 e)
			{
				if (e.IsValid)
				{
					this.eventHandler_0(sender, e);
				}
			}

			// Token: 0x04001585 RID: 5509
			public EventHandler<EventArgs15> eventHandler_0;
		}
	}
}
