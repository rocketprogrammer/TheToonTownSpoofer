using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns16;
using ns18;
using ns21;
using ns22;
using ns23;
using ns26;
using ns27;
using ns29;
using ns31;

namespace ns17
{
	// Token: 0x02000294 RID: 660
	internal sealed partial class UninstallationCleanUp : Form0
	{
		// Token: 0x06001B46 RID: 6982 RVA: 0x00009EDB File Offset: 0x000080DB
		public UninstallationCleanUp() : base(false)
		{
			this.InitializeComponent();
			base.FormClosing += this.UninstallationCleanUp_FormClosing;
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00053BB0 File Offset: 0x00051DB0
		private void method_1(string file)
		{
			UninstallationCleanUp.Class231 @class = new UninstallationCleanUp.Class231();
			@class.string_0 = file;
			@class.uninstallationCleanUp_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00009EFC File Offset: 0x000080FC
		private void UninstallationCleanUp_Shown(object sender, EventArgs e)
		{
			ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(this.method_8), null);
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00009F11 File Offset: 0x00008111
		protected override void vmethod_1(EventArgs19 e)
		{
			e.Cancel = true;
			e.CancelReason = UninstallationCleanUp.string_8;
			base.vmethod_1(e);
		}

		// Token: 0x06001B4A RID: 6986 RVA: 0x00053BE4 File Offset: 0x00051DE4
		private void UninstallationCleanUp_FormClosing(object sender, FormClosingEventArgs e)
		{
			CloseReason closeReason = e.CloseReason;
			if (closeReason != CloseReason.WindowsShutDown && !this.bool_5)
			{
				e.Cancel = true;
			}
		}

		// Token: 0x06001B4B RID: 6987 RVA: 0x00053C0C File Offset: 0x00051E0C
		public void method_2(List<Class524> failedToDelete, string parentDirectory, string childDirectory)
		{
			if (Class336.smethod_0(parentDirectory, childDirectory))
			{
				return;
			}
			KeyValuePair<string, DirectoryInfo>[] array = Class234.smethod_0(new DirectoryInfo(parentDirectory));
			KeyValuePair<string, DirectoryInfo>[] array2 = Class234.smethod_0(new DirectoryInfo(childDirectory));
			if (array.Length >= array2.Length)
			{
				return;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (!string.Equals(array[i].Key, array2[i].Key, StringComparison.OrdinalIgnoreCase))
				{
					return;
				}
			}
			for (int j = array2.Length - 1; j >= array.Length; j--)
			{
				if (!this.method_4(failedToDelete, array2[j].Value.FullName))
				{
					return;
				}
			}
		}

		// Token: 0x06001B4C RID: 6988 RVA: 0x00053CA0 File Offset: 0x00051EA0
		private void method_3(List<Class524> failedToDelete, string file)
		{
			try
			{
				if (File.Exists(file))
				{
					this.method_1(file);
					File.Delete(file);
				}
			}
			catch
			{
				failedToDelete.Add(new Class524(file));
			}
		}

		// Token: 0x06001B4D RID: 6989 RVA: 0x00009F2C File Offset: 0x0000812C
		private bool method_4(List<Class524> failedToDelete, string directory)
		{
			if (Directory.Exists(directory))
			{
				if (!Class234.smethod_2(directory))
				{
					return this.method_5(failedToDelete, directory);
				}
				failedToDelete.Add(new Class524(directory));
			}
			return false;
		}

		// Token: 0x06001B4E RID: 6990 RVA: 0x00053CE4 File Offset: 0x00051EE4
		private bool method_5(List<Class524> failedToDelete, string directory)
		{
			try
			{
				this.method_1(directory);
				Directory.Delete(directory);
				return true;
			}
			catch
			{
				failedToDelete.Add(new Class524(directory));
			}
			return false;
		}

		// Token: 0x06001B4F RID: 6991 RVA: 0x00053D24 File Offset: 0x00051F24
		private void method_6(List<Class524> failedToDelete, string directory)
		{
			if (Directory.Exists(directory))
			{
				string text = Path.Combine(directory, UninstallationCleanUp.string_7);
				if (File.Exists(text))
				{
					HashSet<string> hashSet = this.method_7(text);
					foreach (string path in hashSet)
					{
						this.method_3(failedToDelete, Path.Combine(directory, path));
					}
					this.method_3(failedToDelete, text);
				}
				this.method_4(failedToDelete, directory);
			}
		}

		// Token: 0x06001B50 RID: 6992 RVA: 0x00053DB0 File Offset: 0x00051FB0
		private HashSet<string> method_7(string cache_file)
		{
			HashSet<string> hashSet = new HashSet<string>(StringComparer.CurrentCultureIgnoreCase);
			try
			{
				string[] array;
				using (StreamReader streamReader = new StreamReader(cache_file, Encoding.ASCII))
				{
					array = streamReader.ReadToEnd().Split(new string[]
					{
						Environment.NewLine
					}, StringSplitOptions.RemoveEmptyEntries);
				}
				foreach (string value in array)
				{
					string text;
					if (value.smethod_16('\t', out text) && !string.IsNullOrEmpty(text) && !hashSet.Contains(text))
					{
						hashSet.Add(text);
					}
				}
			}
			catch
			{
			}
			return hashSet;
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00054068 File Offset: 0x00052268
		[CompilerGenerated]
		private void method_8(object _)
		{
			Class110 instance = Class110.Instance;
			Class114 createdFileArchive = instance.CreatedFileArchive;
			Class112 applicationSettings = instance.ApplicationSettings;
			List<Class524> list = new List<Class524>();
			List<string> list2 = new List<string>();
			List<string> list3 = new List<string>();
			list2.Add(UninstallationCleanUp.string_6);
			list2.Add(UninstallationCleanUp.string_5);
			list2.Add(UninstallationCleanUp.string_4);
			list2.Add(UninstallationCleanUp.string_3);
			list2.Add(UninstallationCleanUp.string_2);
			list3.Add(UninstallationCleanUp.string_1);
			list3.Add(UninstallationCleanUp.string_0);
			foreach (Class524 @class in createdFileArchive.Files)
			{
				this.method_3(list, @class.string_1);
			}
			foreach (Class524 class2 in createdFileArchive.Files)
			{
				this.method_2(list, Class291.string_4, Path.GetDirectoryName(class2.string_1));
				this.method_2(list, Class291.string_5, Path.GetDirectoryName(class2.string_1));
			}
			createdFileArchive.Files.Clear();
			foreach (Class524 class3 in instance.RaceTrackFileIndex.Files)
			{
				this.method_3(list, class3.string_1);
			}
			instance.RaceTrackFileIndex.Files.Clear();
			foreach (Class524 class4 in instance.JoeFishSettings.JoeFishCaptureSettings.Files)
			{
				this.method_3(list, class4.string_1);
			}
			instance.JoeFishSettings.JoeFishCaptureSettings.Files.Clear();
			foreach (Class524 class5 in instance.GardenerFloraSettings.GardenerFloraCaptureFiles.Files)
			{
				this.method_3(list, class5.string_1);
			}
			instance.GardenerFloraSettings.GardenerFloraCaptureFiles.Files.Clear();
			foreach (Class524 class6 in instance.GardenerFloraSettings.GardenerFloraFiles.Files)
			{
				this.method_3(list, class6.string_1);
			}
			instance.GardenerFloraSettings.GardenerFloraFiles.Files.Clear();
			foreach (Class102 class7 in instance.ConnectSettings.ContentPacks)
			{
				this.method_3(list, class7.FileName);
			}
			instance.ConnectSettings.ContentPacks.Clear();
			if (Class336.smethod_0(Class291.string_2, applicationSettings.ScreenshotSaveDirectory) && Directory.Exists(Class291.string_2))
			{
				MethodInvoker methodInvoker = null;
				UninstallationCleanUp.Class232 class8 = new UninstallationCleanUp.Class232();
				class8.uninstallationCleanUp_0 = this;
				class8.string_0 = Class234.smethod_1(Class291.string_2, UninstallationCleanUp.string_21, UninstallationCleanUp.string_22);
				if (class8.string_0.Length > 0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(class8.method_0);
					}
					this.smethod_6(methodInvoker);
				}
			}
			foreach (string path in list2)
			{
				this.method_3(list, Path.Combine(Class291.string_4, path));
				this.method_3(list, Path.Combine(Class291.string_5, path));
			}
			foreach (string path2 in list3)
			{
				this.method_4(list, Path.Combine(Class291.string_4, path2));
				this.method_4(list, Path.Combine(Class291.string_5, path2));
			}
			if (Directory.Exists(Class291.string_4))
			{
				string[] array = Class234.smethod_1(Class291.string_4, UninstallationCleanUp.string_19, UninstallationCleanUp.string_20);
				foreach (string file in array)
				{
					this.method_3(list, file);
				}
			}
			if (Directory.Exists(Class291.string_5))
			{
				string[] array3 = Class234.smethod_1(Class291.string_5, UninstallationCleanUp.string_19, UninstallationCleanUp.string_20);
				foreach (string file2 in array3)
				{
					this.method_3(list, file2);
				}
			}
			this.method_3(list, Class291.string_23);
			this.method_3(list, Class291.string_16);
			this.method_3(list, Class291.string_14);
			this.method_3(list, Class291.string_17);
			this.method_3(list, Class291.string_15);
			this.method_6(list, Path.Combine(Class291.string_4, UninstallationCleanUp.string_18));
			this.method_6(list, Path.Combine(Class291.string_5, UninstallationCleanUp.string_18));
			this.method_4(list, Class291.string_2);
			this.method_4(list, Class291.string_6);
			this.method_4(list, Class291.string_9);
			this.method_4(list, Class291.string_10);
			this.method_4(list, Class291.string_8);
			this.method_4(list, Class291.string_11);
			this.method_4(list, Class291.string_7);
			this.method_4(list, Class291.string_3);
			this.method_4(list, Class291.string_5);
			this.method_4(list, Class291.string_4);
			this.method_4(list, Class291.string_13);
			this.method_4(list, Class291.string_1);
			if (Directory.Exists(Class291.string_0) && !Class234.smethod_2(Class291.string_0))
			{
				this.method_5(list, Class291.string_0);
			}
			if (list.Count > 0)
			{
				string text = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + UninstallationCleanUp.string_17);
				bool flag;
				try
				{
					using (Stream stream = File.Open(text, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
					{
						using (StreamWriter streamWriter = new StreamWriter(stream, Encoding.Unicode))
						{
							streamWriter.WriteLine(UninstallationCleanUp.string_16);
							streamWriter.WriteLine(string.Empty);
							foreach (Class524 class9 in list)
							{
								streamWriter.WriteLine(class9.string_1);
							}
							streamWriter.WriteLine(string.Empty);
							streamWriter.WriteLine(UninstallationCleanUp.string_15);
							streamWriter.WriteLine(UninstallationCleanUp.string_14);
						}
					}
					flag = true;
				}
				catch
				{
					flag = false;
				}
				if (flag)
				{
					if (UninstallationCleanUp.func_0 == null)
					{
						UninstallationCleanUp.func_0 = new Func<bool>(UninstallationCleanUp.smethod_2);
					}
					if (!this.smethod_5(UninstallationCleanUp.func_0))
					{
						goto IL_768;
					}
					try
					{
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.FileName = text;
						processStartInfo.UseShellExecute = true;
						processStartInfo.ErrorDialog = true;
						using (Process process = new Process())
						{
							process.StartInfo = processStartInfo;
							process.Start();
						}
						goto IL_768;
					}
					catch
					{
						DialogBox.smethod_3(string.Format(UninstallationCleanUp.string_11, text), UninstallationCleanUp.string_12);
						goto IL_768;
					}
				}
				if (UninstallationCleanUp.methodInvoker_0 == null)
				{
					UninstallationCleanUp.methodInvoker_0 = new MethodInvoker(UninstallationCleanUp.smethod_3);
				}
				this.smethod_6(UninstallationCleanUp.methodInvoker_0);
			}
			IL_768:
			this.smethod_4(new MethodInvoker(this.method_9));
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x000548A8 File Offset: 0x00052AA8
		[CompilerGenerated]
		private static bool smethod_2()
		{
			DialogResult dialogResult = DialogBox.smethod_6(UninstallationCleanUp.string_13, UninstallationCleanUp.string_10, new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			});
			return dialogResult == DialogResult.Yes;
		}

		// Token: 0x06001B55 RID: 6997 RVA: 0x00009F75 File Offset: 0x00008175
		[CompilerGenerated]
		private static void smethod_3()
		{
			DialogBox.smethod_3(UninstallationCleanUp.string_9, UninstallationCleanUp.string_10);
		}

		// Token: 0x06001B56 RID: 6998 RVA: 0x00009F86 File Offset: 0x00008186
		[CompilerGenerated]
		private void method_9()
		{
			this.bool_5 = true;
			base.Close();
		}

		// Token: 0x040008DF RID: 2271
		private static readonly string string_0 = "whitelist";

		// Token: 0x040008E0 RID: 2272
		private static readonly string string_1 = "sign";

		// Token: 0x040008E1 RID: 2273
		private static readonly string string_2 = "whitelist\\twhitelist.dat";

		// Token: 0x040008E2 RID: 2274
		private static readonly string string_3 = "sign\\texture.jpg";

		// Token: 0x040008E3 RID: 2275
		private static readonly string string_4 = "useropt";

		// Token: 0x040008E4 RID: 2276
		private static readonly string string_5 = "readlog.txt";

		// Token: 0x040008E5 RID: 2277
		private static readonly string string_6 = "errorCode";

		// Token: 0x040008E6 RID: 2278
		private static readonly string string_7 = "cache_index.txt";

		// Token: 0x040008E7 RID: 2279
		private static readonly string string_8 = "One moment, uninstalling...";

		// Token: 0x040008E8 RID: 2280
		private static readonly string string_9 = "Some files or directories could not be deleted.";

		// Token: 0x040008E9 RID: 2281
		private static readonly string string_10 = "Files or Directories in Use";

		// Token: 0x040008EA RID: 2282
		private static readonly string string_11 = "The file: '{0}' could not be opened.";

		// Token: 0x040008EB RID: 2283
		private static readonly string string_12 = "Error Opening File";

		// Token: 0x040008EC RID: 2284
		private static readonly string string_13 = "Some files or directories could not be deleted. Would you like to view a list of them?";

		// Token: 0x040008ED RID: 2285
		private static readonly string string_14 = "~The Spoof Net";

		// Token: 0x040008EE RID: 2286
		private static readonly string string_15 = "We apologize for any inconvenience.";

		// Token: 0x040008EF RID: 2287
		private static readonly string string_16 = "The following files or directories could not be deleted:";

		// Token: 0x040008F0 RID: 2288
		private static readonly string string_17 = ".txt";

		// Token: 0x040008F1 RID: 2289
		private static readonly string string_18 = "news";

		// Token: 0x040008F2 RID: 2290
		private static readonly string string_19 = "toontown-*.log";

		// Token: 0x040008F3 RID: 2291
		private static readonly string string_20 = ".log";

		// Token: 0x040008F4 RID: 2292
		private static readonly string string_21 = "*.jpg";

		// Token: 0x040008F5 RID: 2293
		private static readonly string string_22 = ".jpg";

		// Token: 0x040008F6 RID: 2294
		private static readonly string string_23 = "Your screenshots are located in the directory: '{0}'. Would you like to open the directory in Explorer?";

		// Token: 0x040008F7 RID: 2295
		private static readonly string string_24 = "Open Screenshot Directory";

		// Token: 0x040008F8 RID: 2296
		private static readonly string string_25 = "You have {0} screenshots saved. Would you like to move them to a different folder?";

		// Token: 0x040008F9 RID: 2297
		private static readonly string string_26 = "Save Screenshots";

		// Token: 0x040008FA RID: 2298
		private bool bool_5;

		// Token: 0x040008FF RID: 2303
		[CompilerGenerated]
		private static Func<bool> func_0;

		// Token: 0x04000900 RID: 2304
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_0;

		// Token: 0x02000295 RID: 661
		[CompilerGenerated]
		private sealed class Class231
		{
			// Token: 0x06001B59 RID: 7001 RVA: 0x00009F95 File Offset: 0x00008195
			public void method_0()
			{
				this.uninstallationCleanUp_0.DeletingFileLabel.Text = this.string_0;
			}

			// Token: 0x04000901 RID: 2305
			public UninstallationCleanUp uninstallationCleanUp_0;

			// Token: 0x04000902 RID: 2306
			public string string_0;
		}

		// Token: 0x02000296 RID: 662
		[CompilerGenerated]
		private sealed class Class232
		{
			// Token: 0x06001B5B RID: 7003 RVA: 0x000549F8 File Offset: 0x00052BF8
			public void method_0()
			{
				DialogResult dialogResult = DialogBox.smethod_6(string.Format(UninstallationCleanUp.string_25, this.string_0.Length), UninstallationCleanUp.string_26, new Enum39[]
				{
					Enum39.const_5,
					Enum39.const_6
				});
				if (dialogResult == DialogResult.Yes && this.uninstallationCleanUp_0.folderBrowserDialog_0.ShowDialog() == DialogResult.OK)
				{
					Class356.smethod_0(this.string_0, this.uninstallationCleanUp_0.folderBrowserDialog_0.SelectedPath);
					return;
				}
				DialogResult dialogResult2 = DialogBox.smethod_6(string.Format(UninstallationCleanUp.string_23, Class291.string_2), UninstallationCleanUp.string_24, new Enum39[]
				{
					Enum39.const_5,
					Enum39.const_6
				});
				if (dialogResult2 != DialogResult.Yes)
				{
					return;
				}
				Class512.smethod_0(Class291.string_2);
			}

			// Token: 0x04000903 RID: 2307
			public string[] string_0;

			// Token: 0x04000904 RID: 2308
			public UninstallationCleanUp uninstallationCleanUp_0;
		}
	}
}
