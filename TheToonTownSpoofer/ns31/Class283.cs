using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns17;
using ns18;
using ns19;
using ns20;
using ns22;
using ns23;
using ns26;
using ns27;
using ns28;
using ns29;

namespace ns31
{
	// Token: 0x020002F6 RID: 758
	internal static class Class283
	{
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0000B4A8 File Offset: 0x000096A8
		public static Icon Icon
		{
			get
			{
				return Class283.icon_0;
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x00060620 File Offset: 0x0005E820
		[STAThread]
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.ControlAppDomain)]
		private static void Main()
		{
			Class283.Class284 @class = new Class283.Class284();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			@class.mutex_0 = null;
			@class.memoryMappedFile_0 = null;
			@class.mutex_1 = null;
			Thread.CurrentThread.CurrentCulture = (Thread.CurrentThread.CurrentUICulture = Class217.cultureInfo_0);
			Class368 class2 = new Class368(Class291.string_17);
			Class373.Logger = class2;
			Class367 class3 = class2;
			if (Class283.eventHandler_0 == null)
			{
				Class283.eventHandler_0 = new EventHandler<EventArgs25>(Class283.smethod_1);
			}
			class3.LogFileCompressed += Class283.eventHandler_0;
			@class.bool_0 = false;
			@class.action_0 = new Action(@class.method_0);
			@class.bool_1 = false;
			@class.action_1 = new Action(@class.method_1);
			@class.action_2 = new Action(@class.method_2);
			@class.action_3 = new Action<Exception, string>(@class.method_3);
			UnhandledExceptionEventHandler value = new UnhandledExceptionEventHandler(@class.method_4);
			AppDomain.CurrentDomain.UnhandledException += value;
			ThreadExceptionEventHandler value2 = new ThreadExceptionEventHandler(@class.method_5);
			Application.ThreadException += value2;
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			Enum29 @enum = Environment.OSVersion.smethod_0();
			if (@enum > Enum29.const_0 && @enum < Enum29.const_10)
			{
				DialogBox.smethod_3(Class283.string_2, Class283.string_3);
				Application.Exit();
				return;
			}
			try
			{
				try
				{
					@class.mutex_1 = new Mutex(false, Class283.string_16);
					if (!(@class.bool_0 = @class.mutex_1.WaitOne()))
					{
						Environment.ExitCode = 1;
						Application.Exit();
					}
					else if (Class265.smethod_1(Class283.string_15))
					{
						Class283.smethod_0();
						Environment.ExitCode = 1;
						Application.Exit();
					}
					else if (Class409.Current.Flags.Contains(Class283.string_17))
					{
						Environment.ExitCode = 0;
						Application.Exit();
					}
					else if (Class409.Current.Flags.Contains(Class283.string_18))
					{
						if (DialogBox.smethod_6(Class283.string_6, Class283.string_7, new Enum39[]
						{
							Enum39.const_5,
							Enum39.const_6
						}) == DialogResult.Yes)
						{
							using (UninstallationCleanUp uninstallationCleanUp = new UninstallationCleanUp())
							{
								Application.Run(uninstallationCleanUp);
							}
						}
						Application.Exit();
					}
					else
					{
						try
						{
							@class.mutex_0 = new Mutex(false, Class283.string_15);
						}
						catch (Exception ex)
						{
							@class.action_1();
							ex.smethod_0();
							DialogBox.smethod_4(Class283.string_8, Class283.string_9);
							Application.Exit();
							return;
						}
						if (!(@class.bool_1 = @class.mutex_0.WaitOne(TimeSpan.Zero, false)))
						{
							Class283.smethod_0();
							Environment.ExitCode = 1;
							Application.Exit();
						}
						else
						{
							try
							{
								@class.memoryMappedFile_0 = MemoryMappedFile.CreateNew(Class283.string_13, 4L, MemoryMappedFileAccess.ReadWrite);
							}
							catch (IOException ex2)
							{
								ex2.smethod_0();
								@class.action_2();
								if (Marshal.GetHRForException(ex2) == (int)Class265.uint_0)
								{
									Class283.smethod_0();
									Environment.ExitCode = 1;
									Application.Exit();
									return;
								}
							}
							using (Class283.icon_0 = Icon.ExtractAssociatedIcon(Application.ExecutablePath))
							{
								Class176 instance = Class176.Instance;
								DateTime now = DateTime.Now;
								if (instance.UpdateStepOn == Enum111.const_6 || (Class110.Instance.ApplicationSettings.UpdateType != Enum78.const_3 && (now - instance.LastCheckedForUpdate).TotalDays >= 14.0))
								{
									bool flag = false;
									try
									{
										using (Updater updater = new Updater(true))
										{
											Application.Run(updater);
											switch (updater.UpdateResult)
											{
											case Enum43.const_4:
											case Enum43.const_6:
												flag = true;
												break;
											case Enum43.const_5:
												instance.UpdateStepOn = Enum111.const_0;
												flag = true;
												Application.Exit();
												return;
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
								try
								{
									using (Class435 class4 = new Class435())
									{
										EventHandler<EventArgs11> eventHandler = null;
										Class283.Class285 class5 = new Class283.Class285();
										class5.class284_0 = @class;
										class5.class330_0 = new Class330();
										try
										{
											Class435 class6 = class4;
											if (eventHandler == null)
											{
												eventHandler = new EventHandler<EventArgs11>(class5.method_0);
											}
											class6.DataReceived += eventHandler;
											if (@class.memoryMappedFile_0 != null)
											{
												using (MemoryMappedViewStream memoryMappedViewStream = @class.memoryMappedFile_0.CreateViewStream(0L, (long)Class283.int_0, MemoryMappedFileAccess.ReadWrite))
												{
													using (BinaryWriter binaryWriter = new BinaryWriter(memoryMappedViewStream, Class217.encoding_0))
													{
														binaryWriter.Write(Process.GetCurrentProcess().Id);
														binaryWriter.Write(class4.Handle.ToInt64());
													}
												}
											}
											@class.action_0();
											bool flag2 = Class409.Current.Flags.Contains("DEBUG");
											try
											{
												if (flag2)
												{
													Class335.smethod_0(Class291.DebugLogDirectory);
													Class110.Instance.CreatedFileArchive.method_4(Class335.LogFile);
													Class335.smethod_2(Class283.string_5, false);
													Class335.smethod_2(Class283.string_4, false);
												}
												Application.Run(class5.class330_0);
											}
											finally
											{
												if (flag2)
												{
													Class335.smethod_2(Class283.string_5, false);
													Class335.smethod_1();
												}
											}
										}
										finally
										{
											if (class5.class330_0 != null)
											{
												((IDisposable)class5.class330_0).Dispose();
											}
										}
									}
								}
								finally
								{
									Class110.smethod_1();
								}
							}
						}
					}
				}
				finally
				{
					@class.action_0();
				}
			}
			finally
			{
				@class.action_1();
				@class.action_2();
				Application.ThreadException -= value2;
			}
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x00060CF0 File Offset: 0x0005EEF0
		private static void smethod_0()
		{
			using (MemoryMappedFile memoryMappedFile = MemoryMappedFile.OpenExisting(Class283.string_13, MemoryMappedFileRights.Read))
			{
				using (MemoryMappedViewStream memoryMappedViewStream = memoryMappedFile.CreateViewStream(0L, (long)Class283.int_0, MemoryMappedFileAccess.Read))
				{
					using (BinaryReader binaryReader = new BinaryReader(memoryMappedViewStream))
					{
						int processId = binaryReader.ReadInt32();
						long value = binaryReader.ReadInt64();
						using (Process currentProcess = Process.GetCurrentProcess())
						{
							using (Process processById = Process.GetProcessById(processId))
							{
								if (!processById.Responding || !Class410.smethod_28(new IntPtr(value), Environment.CommandLine, new IntPtr(currentProcess.Id), 5000U))
								{
									DialogBox.smethod_3(Class283.string_11, Class283.string_12);
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0000B4AF File Offset: 0x000096AF
		[CompilerGenerated]
		private static void smethod_1(object sender, EventArgs25 e)
		{
			Class110.Instance.CreatedFileArchive.method_4(e.CompressedFilePath);
		}

		// Token: 0x04000B1D RID: 2845
		private static readonly string string_0 = "Unfortunately, The ToonTown Spoofer has encountered an error and is forced to close unexpectedly. The 'trace.log' file located here: {0} may contain information that could help debug this issue. Would you like The ToonTown Spoofer to open this directory before it crashes?";

		// Token: 0x04000B1E RID: 2846
		private static readonly string string_1 = "Crash Detected";

		// Token: 0x04000B1F RID: 2847
		private static readonly string string_2 = "You're running a really old version of Windows which is not supported by The ToonTown Spoofer. Please accept our apologies for the inconvenience!";

		// Token: 0x04000B20 RID: 2848
		private static readonly string string_3 = "Operating System Not Supported";

		// Token: 0x04000B21 RID: 2849
		private static readonly string string_4 = "-----------------------The ToonTown Spoofer Log-----------------------";

		// Token: 0x04000B22 RID: 2850
		private static readonly string string_5 = "----------------------------------------------------------------------";

		// Token: 0x04000B23 RID: 2851
		private static readonly string string_6 = "Would you like to delete all saved files and settings, excluding screenshots?";

		// Token: 0x04000B24 RID: 2852
		private static readonly string string_7 = "Delete Files";

		// Token: 0x04000B25 RID: 2853
		private static readonly string string_8 = "The ToonTown Spoofer failed to run, please check the log for more information.";

		// Token: 0x04000B26 RID: 2854
		private static readonly string string_9 = "Initialization Failure";

		// Token: 0x04000B27 RID: 2855
		private static readonly string string_10 = "Error parsing received data: {0}";

		// Token: 0x04000B28 RID: 2856
		private static readonly string string_11 = "The ToonTown Spoofer appears to be open but not responding. Please try to end any instance of TheToonTownSpoofer.exe from Task Manager and try again, or restart your computer.";

		// Token: 0x04000B29 RID: 2857
		private static readonly string string_12 = "Process Not Responding";

		// Token: 0x04000B2A RID: 2858
		private static readonly string string_13 = "THETOONTOWNSPOOFERMMF";

		// Token: 0x04000B2B RID: 2859
		private static readonly string string_14 = "{0}-TheToonTownSpooferMutex";

		// Token: 0x04000B2C RID: 2860
		private static readonly string string_15 = string.Format(Class217.cultureInfo_0, Class283.string_14, new object[]
		{
			Class500.Current.Guid
		});

		// Token: 0x04000B2D RID: 2861
		private static readonly string string_16 = Class283.string_15 + "-INIT";

		// Token: 0x04000B2E RID: 2862
		private static readonly string string_17 = "HASMUTEX";

		// Token: 0x04000B2F RID: 2863
		private static readonly string string_18 = "DEACTIVATE";

		// Token: 0x04000B30 RID: 2864
		private static readonly int int_0 = 12;

		// Token: 0x04000B31 RID: 2865
		public static Icon icon_0;

		// Token: 0x04000B32 RID: 2866
		[CompilerGenerated]
		private static EventHandler<EventArgs25> eventHandler_0;

		// Token: 0x020002F7 RID: 759
		[CompilerGenerated]
		private sealed class Class284
		{
			// Token: 0x06001DE7 RID: 7655 RVA: 0x0000B4C6 File Offset: 0x000096C6
			public void method_0()
			{
				if (this.mutex_1 != null)
				{
					if (this.bool_0)
					{
						this.mutex_1.ReleaseMutex();
					}
					this.mutex_1.Dispose();
					this.mutex_1 = null;
				}
				this.bool_0 = false;
			}

			// Token: 0x06001DE8 RID: 7656 RVA: 0x0000B4FC File Offset: 0x000096FC
			public void method_1()
			{
				if (this.mutex_0 != null)
				{
					if (this.bool_1)
					{
						this.mutex_0.ReleaseMutex();
					}
					this.mutex_0.Dispose();
					this.mutex_0 = null;
				}
				this.bool_1 = false;
			}

			// Token: 0x06001DE9 RID: 7657 RVA: 0x0000B532 File Offset: 0x00009732
			public void method_2()
			{
				if (this.memoryMappedFile_0 != null)
				{
					this.memoryMappedFile_0.Dispose();
					this.memoryMappedFile_0 = null;
				}
			}

			// Token: 0x06001DEA RID: 7658 RVA: 0x00060F00 File Offset: 0x0005F100
			public void method_3(Exception ex, string msg)
			{
				ex.smethod_1(new object[]
				{
					msg
				});
				if (DialogResult.Yes == DialogBox.smethod_5(string.Format(Class283.string_0, Class291.CommonApplicationDataDirectory), Class283.string_1, new Enum39[]
				{
					Enum39.const_5,
					Enum39.const_2
				}))
				{
					Class512.smethod_1(Class291.string_17);
				}
				this.action_0();
				this.action_1();
				this.action_2();
				Environment.Exit(0);
			}

			// Token: 0x06001DEB RID: 7659 RVA: 0x0000B54E File Offset: 0x0000974E
			public void method_4(object sender, UnhandledExceptionEventArgs e)
			{
				this.action_3((Exception)e.ExceptionObject, "Unhandled Exception");
			}

			// Token: 0x06001DEC RID: 7660 RVA: 0x0000B56B File Offset: 0x0000976B
			public void method_5(object sender, ThreadExceptionEventArgs e)
			{
				this.action_3(e.Exception, "Thread Exception");
			}

			// Token: 0x04000B33 RID: 2867
			public Mutex mutex_0;

			// Token: 0x04000B34 RID: 2868
			public MemoryMappedFile memoryMappedFile_0;

			// Token: 0x04000B35 RID: 2869
			public Mutex mutex_1;

			// Token: 0x04000B36 RID: 2870
			public bool bool_0;

			// Token: 0x04000B37 RID: 2871
			public Action action_0;

			// Token: 0x04000B38 RID: 2872
			public bool bool_1;

			// Token: 0x04000B39 RID: 2873
			public Action action_1;

			// Token: 0x04000B3A RID: 2874
			public Action action_2;

			// Token: 0x04000B3B RID: 2875
			public Action<Exception, string> action_3;
		}

		// Token: 0x020002F8 RID: 760
		[CompilerGenerated]
		private sealed class Class285
		{
			// Token: 0x06001DEE RID: 7662 RVA: 0x00060F7C File Offset: 0x0005F17C
			public void method_0(object sender, EventArgs11 e)
			{
				Class409 args = null;
				bool flag = false;
				try
				{
					args = new Class409(e.DataReceived);
					flag = true;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						string.Format(Class283.string_10, e.DataReceived)
					});
				}
				if (flag)
				{
					this.class330_0.method_1(args);
				}
			}

			// Token: 0x04000B3C RID: 2876
			public Class283.Class284 class284_0;

			// Token: 0x04000B3D RID: 2877
			public Class330 class330_0;
		}
	}
}
