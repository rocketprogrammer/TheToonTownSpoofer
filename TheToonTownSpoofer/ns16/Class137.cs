using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ns15;
using ns17;
using ns18;
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
using ns30;
using ns31;

namespace ns16
{
	// Token: 0x020003AF RID: 943
	internal sealed class Class137 : Class123
	{
		// Token: 0x140001B7 RID: 439
		// (add) Token: 0x060024A4 RID: 9380 RVA: 0x0007C8FC File Offset: 0x0007AAFC
		// (remove) Token: 0x060024A5 RID: 9381 RVA: 0x0007C934 File Offset: 0x0007AB34
		public event EventHandler<EventArgs42> VersionMismatch
		{
			add
			{
				EventHandler<EventArgs42> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs42> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs42> value2 = (EventHandler<EventArgs42>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs42>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs42> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs42> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs42> value2 = (EventHandler<EventArgs42>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs42>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001B8 RID: 440
		// (add) Token: 0x060024A6 RID: 9382 RVA: 0x0007C96C File Offset: 0x0007AB6C
		// (remove) Token: 0x060024A7 RID: 9383 RVA: 0x0007C9A4 File Offset: 0x0007ABA4
		public event EventHandler<EventArgs10> DownloadProgressChanged
		{
			add
			{
				EventHandler<EventArgs10> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs10> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs10> value2 = (EventHandler<EventArgs10>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs10>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs10> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs10> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs10> value2 = (EventHandler<EventArgs10>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs10>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001B9 RID: 441
		// (add) Token: 0x060024A8 RID: 9384 RVA: 0x0007C9DC File Offset: 0x0007ABDC
		// (remove) Token: 0x060024A9 RID: 9385 RVA: 0x0007CA14 File Offset: 0x0007AC14
		public event EventHandler<EventArgs9> ProgressChanged
		{
			add
			{
				EventHandler<EventArgs9> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs9> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs9> value2 = (EventHandler<EventArgs9>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs9>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs9> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs9> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs9> value2 = (EventHandler<EventArgs9>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs9>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001BA RID: 442
		// (add) Token: 0x060024AA RID: 9386 RVA: 0x0007CA4C File Offset: 0x0007AC4C
		// (remove) Token: 0x060024AB RID: 9387 RVA: 0x0007CA84 File Offset: 0x0007AC84
		public event EventHandler<EventArgs33> InstallerStateChanged
		{
			add
			{
				EventHandler<EventArgs33> eventHandler = this.eventHandler_5;
				EventHandler<EventArgs33> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs33> value2 = (EventHandler<EventArgs33>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs33>>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs33> eventHandler = this.eventHandler_5;
				EventHandler<EventArgs33> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs33> value2 = (EventHandler<EventArgs33>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs33>>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001BB RID: 443
		// (add) Token: 0x060024AC RID: 9388 RVA: 0x0007CABC File Offset: 0x0007ACBC
		// (remove) Token: 0x060024AD RID: 9389 RVA: 0x0007CAF4 File Offset: 0x0007ACF4
		public event EventHandler ResetCounters
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

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060024AE RID: 9390 RVA: 0x0000FF26 File Offset: 0x0000E126
		private bool Canceling
		{
			get
			{
				return this.cancellationTokenSource_0.IsCancellationRequested;
			}
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0000FF33 File Offset: 0x0000E133
		public void method_4(bool internalCancel)
		{
			if (!this.Canceling)
			{
				this.bool_3 = internalCancel;
				this.cancellationTokenSource_0.Cancel();
			}
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0000FF4F File Offset: 0x0000E14F
		protected override void vmethod_0()
		{
			this.method_4(true);
			this.task_0.Wait();
			this.task_0.Dispose();
			this.cancellationTokenSource_0.Dispose();
			base.vmethod_0();
		}

		// Token: 0x060024B1 RID: 9393 RVA: 0x0007CB2C File Offset: 0x0007AD2C
		public Class137(Class96 liveToonTown, Enum101 server, bool usingVirtualServer)
		{
			Action action = null;
			base..ctor();
			this.hashSet_0 = new HashSet<string>();
			this.cancellationTokenSource_0 = new CancellationTokenSource();
			this.class96_0 = liveToonTown;
			switch (server)
			{
			case Enum101.const_1:
				this.string_1 = Class291.ToonTownOpenDataDirectory;
				this.class96_1 = Class110.Instance.ConnectSettings.ActualToonTownVersionData;
				break;
			case Enum101.const_2:
				this.string_1 = Class291.ToonTownTestDataDirectory;
				this.class96_1 = Class110.Instance.ConnectSettings.ActualTestToonTownVersionData;
				break;
			}
			this.class96_1.Properties = this.class96_0.Properties.imethod_0();
			this.bool_2 = usingVirtualServer;
			if (action == null)
			{
				action = new Action(this.method_7);
			}
			this.task_0 = new Task(action);
		}

		// Token: 0x060024B2 RID: 9394 RVA: 0x0000FF7F File Offset: 0x0000E17F
		public void method_5()
		{
			this.task_0.Start();
		}

		// Token: 0x060024B3 RID: 9395 RVA: 0x0007CBF4 File Offset: 0x0007ADF4
		private void method_6()
		{
			Action action = null;
			Action action2 = null;
			Class137.Class376 @class = new Class137.Class376();
			@class.class137_0 = this;
			@class.enum74_0 = Enum74.const_0;
			@class.action_0 = new Action<Enum74, Enum66>(@class.method_0);
			try
			{
				Func<KeyValuePair<string, Class186>, bool> func = null;
				Func<Class102, Class402, int, bool> func2 = null;
				Class137.Class377 class2 = new Class137.Class377();
				class2.class376_0 = @class;
				bool flag = Class156.smethod_2(Class137.string_0) > 0;
				bool flag2;
				class2.dictionary_0 = this.class96_1.method_9(this.class96_0, this.string_1, this.bool_2, !flag, this.hashSet_0, out flag2);
				bool flag3 = class2.dictionary_0.Count == 0;
				class2.class114_0 = Class110.Instance.CreatedFileArchive;
				class2.class96_0 = Class110.Instance.ConnectSettings.SpoofedToonTownVersionData;
				if (this.bool_2)
				{
					lock (((ICollection)this.class96_1.FILES).SyncRoot)
					{
						List<KeyValuePair<string, Class186>> list;
						lock (((ICollection)class2.class96_0.FILES).SyncRoot)
						{
							IEnumerable<KeyValuePair<string, Class186>> files = class2.class96_0.FILES;
							if (func == null)
							{
								func = new Func<KeyValuePair<string, Class186>, bool>(class2.method_0);
							}
							list = files.Where(func).ToList<KeyValuePair<string, Class186>>();
						}
						if (flag)
						{
							if (list.Count > 0)
							{
								flag2 = false;
							}
						}
						else
						{
							foreach (KeyValuePair<string, Class186> keyValuePair in list)
							{
								string text = Path.Combine(this.string_1, keyValuePair.Key);
								string text2 = Path.Combine(this.string_1, keyValuePair.Key + ".orig");
								if (File.Exists(text2))
								{
									File.Copy(text2, text, true);
									class2.class96_0.method_6(keyValuePair.Key, this.class96_1.FILES[keyValuePair.Key], null, null);
									Class110.Instance.CreatedFileArchive.method_4(text);
									string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(keyValuePair.Key);
									if (!this.hashSet_0.Contains(fileNameWithoutExtension))
									{
										this.hashSet_0.Add(fileNameWithoutExtension);
									}
								}
							}
						}
					}
				}
				Class137.Class377 class3 = class2;
				if (action == null)
				{
					action = new Action(this.method_8);
				}
				class3.action_0 = action;
				if (this.Canceling)
				{
					@class.action_0(Enum74.const_5, Enum66.const_3);
					return;
				}
				if (!flag2)
				{
					@class.action_0(Enum74.const_5, Enum66.const_1);
					return;
				}
				if (this.hashSet_0.Count == 0 && flag3 && flag)
				{
					@class.action_0(Enum74.const_5, Enum66.const_0);
					return;
				}
				if (flag)
				{
					@class.action_0(Enum74.const_5, Enum66.const_1);
					return;
				}
				if (!flag3)
				{
					EventHandler<EventArgs23> eventHandler = null;
					Class137.Class378 class4 = new Class137.Class378();
					class4.class377_0 = class2;
					class4.class376_0 = @class;
					List<Class137.Class139> list2 = new List<Class137.Class139>();
					int num = Class110.Instance.ConnectSettings.MaximumSimultaneousDownloads;
					num = Math.Min(3, Math.Max(1, num));
					TaskFactory taskFactory = new TaskFactory(new Class385(num));
					foreach (Class307 class5 in class2.dictionary_0.Values)
					{
						if (class5.FileDetails.Patches.Count > 0)
						{
							Class137.Class139 class6 = null;
							for (int i = 0; i < class5.FileDetails.Patches.Count; i++)
							{
								Class282 class7 = class5.FileDetails.Patches[i];
								Queue<Uri> queue = new Queue<Uri>();
								foreach (Uri baseUri in this.class96_0.DownloadUrls)
								{
									queue.Enqueue(new Uri(baseUri, string.Format("{0}.v{1}.pch.bz2", class5.PhaseName, class7.Version)));
								}
								if (queue.Count > 0)
								{
									Class137.Class139 class8 = new Class137.Class139(class5, class7, i == 0, new MemoryStream(), queue);
									list2.Add(class8);
									if (class6 != null)
									{
										class6.NextPatchDownloadData = class8;
									}
									class6 = class8;
								}
							}
						}
						else
						{
							Queue<Uri> queue = new Queue<Uri>();
							foreach (Uri baseUri2 in this.class96_0.DownloadUrls)
							{
								queue.Enqueue(new Uri(baseUri2, string.Format("{0}.v{1}.bz2", class5.PhaseName, class5.FileDetails.Version)));
							}
							if (queue.Count > 0)
							{
								Class137.Class139 class8 = new Class137.Class139(class5, new MemoryStream(), queue);
								list2.Add(class8);
							}
						}
					}
					class4.long_0 = 0L;
					class4.long_1 = 0L;
					Task[] array = new Task[list2.Count];
					for (int j = 0; j < list2.Count; j++)
					{
						Class137.Class379 class9 = new Class137.Class379();
						class9.class378_0 = class4;
						class9.class377_0 = class2;
						class9.class376_0 = @class;
						class9.class139_0 = list2[j];
						array[j] = taskFactory.StartNew(new Action(class9.method_0));
					}
					Task.WaitAll(array);
					array.smethod_1<Task>();
					if (action2 == null)
					{
						action2 = new Action(@class.method_1);
					}
					Action action3 = action2;
					if (this.Canceling)
					{
						list2.smethod_1<Class137.Class139>();
						action3();
						return;
					}
					@class.action_0(Enum74.const_1, Enum66.const_0);
					class4.list_0 = new List<Class307>();
					class4.list_1 = new List<Task>();
					class4.taskFactory_0 = new TaskFactory(new Class385(2));
					class2.action_0();
					Task[] array2 = new Task[list2.Count];
					for (int k = 0; k < list2.Count; k++)
					{
						Action action4 = null;
						Class137.Class380 class10 = new Class137.Class380();
						class10.class378_0 = class4;
						class10.class377_0 = class2;
						class10.class376_0 = @class;
						class10.class139_0 = list2[k];
						Class384 downloader = class10.class139_0.Downloader;
						if (eventHandler == null)
						{
							eventHandler = new EventHandler<EventArgs23>(class4.method_0);
						}
						downloader.PacketReceived += eventHandler;
						lock (class10.class139_0)
						{
							Task[] array3 = array2;
							int num2 = k;
							Class137.Class139 class139_2 = class10.class139_0;
							TaskFactory taskFactory2 = taskFactory;
							if (action4 == null)
							{
								action4 = new Action(class10.method_0);
							}
							array3[num2] = (class139_2.DownloadTask = taskFactory2.StartNew(action4));
						}
					}
					Task.WaitAll(array2);
					@class.action_0(Enum74.const_2, Enum66.const_0);
					bool flag7 = false;
					Monitor.Enter(class4.list_1, ref flag7);
					try
					{
						while (class4.list_1.Count > 0)
						{
							Task[] array4 = class4.list_1.ToArray();
							class4.list_1.Clear();
							if (flag7)
							{
								Monitor.Exit(class4.list_1);
								flag7 = false;
							}
							Task.WaitAll(array4);
							array4.smethod_1<Task>();
							Monitor.Enter(class4.list_1, ref flag7);
						}
					}
					catch (Exception ex)
					{
						Console.Write(ex.Message);
					}
					finally
					{
						if (flag7)
						{
							Monitor.Exit(class4.list_1);
						}
					}
					foreach (Class307 class11 in class4.list_0)
					{
						File.Copy(class11.FilePath, class11.AltFilePath, true);
						class2.class114_0.method_4(class11.AltFilePath);
					}
					if (this.Canceling)
					{
						list2.smethod_1<Class137.Class139>();
						action3();
						return;
					}
				}
				@class.action_0(Enum74.const_4, Enum66.const_0);
				class2.action_0();
				if (!Class481.smethod_0(this.eventHandler_4, this.string_1))
				{
					@class.action_0(Enum74.const_5, Enum66.const_2);
					return;
				}
				if (this.bool_2)
				{
					Class102.smethod_1(this.hashSet_0);
					if (!this.Canceling)
					{
						@class.action_0(Enum74.const_6, Enum66.const_0);
						using (List<Class102>.Enumerator enumerator5 = Class110.Instance.ConnectSettings.ContentPacks.GetEnumerator())
						{
							Func<Class402, bool> func3 = null;
							Class137.Class383 class12 = new Class137.Class383();
							class12.class377_0 = class2;
							class12.class376_0 = @class;
							while (enumerator5.MoveNext())
							{
								Class102 class102_ = enumerator5.Current;
								class12.class102_0 = class102_;
								if (this.Canceling)
								{
									break;
								}
								switch (class12.class102_0.InstallState)
								{
								case Enum76.const_1:
									if (!class12.class102_0.AutoUpdate)
									{
										continue;
									}
									break;
								case Enum76.const_2:
									continue;
								case Enum76.const_3:
									break;
								default:
									continue;
								}
								if (class12.class102_0.AutoUpdate || class12.class102_0.LoaderPack)
								{
									byte[] bytes;
									using (MemoryStream memoryStream = new MemoryStream())
									{
										string text3 = class12.class102_0.UpdateUri.OriginalString;
										if (text3.Contains('?'))
										{
											text3 += '&';
										}
										else
										{
											text3 += '?';
										}
										Version fileVersion = Class500.Current.FileVersion;
										if (class12.class102_0.VersionType == Enum82.const_0)
										{
											text3 += string.Format("v={0}.{1}.{2}", fileVersion.Major, fileVersion.Minor, fileVersion.Build);
										}
										else
										{
											text3 += string.Format("v={0}.{1}.{2}.{3}", new object[]
											{
												fileVersion.Major,
												fileVersion.Minor,
												fileVersion.Build,
												fileVersion.Revision
											});
										}
										Class508 class13 = new Class508(new Uri(text3), memoryStream, false);
										using (Task task = new Task(new Action<object>(class13.method_11), this.cancellationTokenSource_0.Token))
										{
											task.RunSynchronously();
										}
										if (!class13.DownloadCompleted)
										{
											continue;
										}
										bytes = memoryStream.ToArray();
									}
									string @string = Encoding.ASCII.GetString(bytes);
									bool flag8 = false;
									if (func3 == null)
									{
										func3 = new Func<Class402, bool>(class12.method_0);
									}
									Func<Class402, bool> func4 = func3;
									switch (class12.class102_0.VersionType)
									{
									case Enum82.const_0:
									{
										Class402 class14;
										if (Class402.smethod_0(@string, class12.class102_0.LoaderPack, out class14) && (class12.class102_0.LoaderPack || Struct43.smethod_6(class14.Hash, class12.class102_0.DataHash)))
										{
											flag8 = func4(class14);
										}
										break;
									}
									case Enum82.const_1:
									{
										if (func2 == null)
										{
											func2 = new Func<Class102, Class402, int, bool>(class2.method_1);
										}
										Func<Class102, Class402, int, bool> func5 = func2;
										Class402 class14;
										if (Class402.smethod_1(@string, class12.class102_0.LoaderPack, out class14))
										{
											if (class12.class102_0.LoaderPack)
											{
												flag8 = func4(class14);
											}
											else if (Struct43.smethod_6(class14.Hash, class12.class102_0.DataHash) && Struct43.smethod_6(class14.Hash, Struct43.struct43_0))
											{
												int arg;
												if (class14.Patches != null && class14.method_0(class12.class102_0.DataHash, class12.class102_0.ContentPackVersion, out arg))
												{
													flag8 = func5(class12.class102_0, class14, arg);
												}
												else
												{
													flag8 = func4(class14);
												}
											}
										}
										break;
									}
									}
									if (flag8)
									{
										class12.class102_0.method_5();
									}
								}
							}
						}
						@class.action_0(Enum74.const_9, Enum66.const_0);
						HashSet<string> filesUpdated;
						Class102.smethod_2(this.string_1, out filesUpdated);
						@class.action_0(Enum74.const_3, Enum66.const_0);
						class2.class96_0.Properties = this.class96_0.Properties.imethod_0();
						class2.class96_0.method_8(this.class96_0, filesUpdated, this.string_1);
					}
				}
			}
			catch (Exception ex2)
			{
				ex2.smethod_0();
				@class.action_0(Enum74.const_5, Enum66.const_2);
				return;
			}
			finally
			{
				Class110.smethod_1();
				GC.Collect();
			}
			if (this.Canceling)
			{
				@class.action_0(Enum74.const_5, Enum66.const_3);
				return;
			}
			@class.action_0(Enum74.const_5, Enum66.const_0);
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0000FF8C File Offset: 0x0000E18C
		[CompilerGenerated]
		private void method_7()
		{
			this.method_6();
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0000FF94 File Offset: 0x0000E194
		[CompilerGenerated]
		private void method_8()
		{
			if (this.eventHandler_6 != null)
			{
				this.eventHandler_6(this, EventArgs.Empty);
			}
		}

		// Token: 0x04001100 RID: 4352
		private static readonly string string_0 = "toontown";

		// Token: 0x04001101 RID: 4353
		private EventHandler<EventArgs42> eventHandler_2;

		// Token: 0x04001102 RID: 4354
		private EventHandler<EventArgs10> eventHandler_3;

		// Token: 0x04001103 RID: 4355
		private EventHandler<EventArgs9> eventHandler_4;

		// Token: 0x04001104 RID: 4356
		private EventHandler<EventArgs33> eventHandler_5;

		// Token: 0x04001105 RID: 4357
		private EventHandler eventHandler_6;

		// Token: 0x04001106 RID: 4358
		private readonly Class96 class96_0;

		// Token: 0x04001107 RID: 4359
		private readonly string string_1;

		// Token: 0x04001108 RID: 4360
		private readonly Class96 class96_1;

		// Token: 0x04001109 RID: 4361
		private readonly Task task_0;

		// Token: 0x0400110A RID: 4362
		private readonly bool bool_2;

		// Token: 0x0400110B RID: 4363
		private readonly HashSet<string> hashSet_0;

		// Token: 0x0400110C RID: 4364
		private readonly CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x0400110D RID: 4365
		private bool bool_3;

		// Token: 0x020003B0 RID: 944
		private sealed class Class139 : Class384.Class138
		{
			// Token: 0x17000969 RID: 2409
			// (get) Token: 0x060024B7 RID: 9399 RVA: 0x0000FFBB File Offset: 0x0000E1BB
			// (set) Token: 0x060024B8 RID: 9400 RVA: 0x0000FFC3 File Offset: 0x0000E1C3
			public Class307 FileUpdateDetails { get; private set; }

			// Token: 0x1700096A RID: 2410
			// (get) Token: 0x060024B9 RID: 9401 RVA: 0x0000FFCC File Offset: 0x0000E1CC
			// (set) Token: 0x060024BA RID: 9402 RVA: 0x0000FFD4 File Offset: 0x0000E1D4
			public Class282 PatchDetails { get; private set; }

			// Token: 0x1700096B RID: 2411
			// (get) Token: 0x060024BB RID: 9403 RVA: 0x0000FFDD File Offset: 0x0000E1DD
			// (set) Token: 0x060024BC RID: 9404 RVA: 0x0000FFE5 File Offset: 0x0000E1E5
			public Task DownloadTask { get; set; }

			// Token: 0x1700096C RID: 2412
			// (get) Token: 0x060024BD RID: 9405 RVA: 0x0000FFEE File Offset: 0x0000E1EE
			// (set) Token: 0x060024BE RID: 9406 RVA: 0x0000FFF6 File Offset: 0x0000E1F6
			public Class137.Class139 NextPatchDownloadData { get; set; }

			// Token: 0x1700096D RID: 2413
			// (get) Token: 0x060024BF RID: 9407 RVA: 0x0000FFFF File Offset: 0x0000E1FF
			// (set) Token: 0x060024C0 RID: 9408 RVA: 0x00010007 File Offset: 0x0000E207
			public Class384 Downloader { get; set; }

			// Token: 0x1700096E RID: 2414
			// (get) Token: 0x060024C1 RID: 9409 RVA: 0x00010010 File Offset: 0x0000E210
			// (set) Token: 0x060024C2 RID: 9410 RVA: 0x00010018 File Offset: 0x0000E218
			public Class384.Enum83 DownloadState { get; set; }

			// Token: 0x1700096F RID: 2415
			// (get) Token: 0x060024C3 RID: 9411 RVA: 0x00010021 File Offset: 0x0000E221
			// (set) Token: 0x060024C4 RID: 9412 RVA: 0x00010029 File Offset: 0x0000E229
			public bool IsFirstPatch { get; private set; }

			// Token: 0x060024C5 RID: 9413 RVA: 0x00010032 File Offset: 0x0000E232
			public Class139(Class307 fileUpdateDetails, Class282 patchDetails, bool isFirstPatch, Stream destinationStream, Queue<Uri> remotePaths) : base(destinationStream, remotePaths)
			{
				this.DownloadState = Class384.Enum83.const_0;
				this.FileUpdateDetails = fileUpdateDetails;
				this.PatchDetails = patchDetails;
				this.IsFirstPatch = isFirstPatch;
			}

			// Token: 0x060024C6 RID: 9414 RVA: 0x0001005A File Offset: 0x0000E25A
			public Class139(Class307 fileUpdateDetails, Stream destinationStream, Queue<Uri> remotePaths) : this(fileUpdateDetails, null, false, destinationStream, remotePaths)
			{
			}

			// Token: 0x0400110E RID: 4366
			[CompilerGenerated]
			private Class307 class307_0;

			// Token: 0x0400110F RID: 4367
			[CompilerGenerated]
			private Class282 class282_0;

			// Token: 0x04001110 RID: 4368
			[CompilerGenerated]
			private Task task_0;

			// Token: 0x04001111 RID: 4369
			[CompilerGenerated]
			private Class137.Class139 class139_0;

			// Token: 0x04001112 RID: 4370
			[CompilerGenerated]
			private Class384 class384_0;

			// Token: 0x04001113 RID: 4371
			[CompilerGenerated]
			private Class384.Enum83 enum83_0;

			// Token: 0x04001114 RID: 4372
			[CompilerGenerated]
			private bool bool_2;
		}

		// Token: 0x020003B1 RID: 945
		[CompilerGenerated]
		private sealed class Class376
		{
			// Token: 0x060024C8 RID: 9416 RVA: 0x00010067 File Offset: 0x0000E267
			public void method_0(Enum74 newInstallerState, Enum66 installFailureType)
			{
				if (this.enum74_0 != newInstallerState)
				{
					this.enum74_0 = newInstallerState;
					if (this.class137_0.eventHandler_5 != null)
					{
						this.class137_0.eventHandler_5(this.class137_0, new EventArgs33(newInstallerState, installFailureType));
					}
				}
			}

			// Token: 0x060024C9 RID: 9417 RVA: 0x000100A3 File Offset: 0x0000E2A3
			public void method_1()
			{
				if (this.class137_0.bool_3)
				{
					this.action_0(Enum74.const_5, Enum66.const_2);
					return;
				}
				this.action_0(Enum74.const_5, Enum66.const_3);
			}

			// Token: 0x04001115 RID: 4373
			public Enum74 enum74_0;

			// Token: 0x04001116 RID: 4374
			public Action<Enum74, Enum66> action_0;

			// Token: 0x04001117 RID: 4375
			public Class137 class137_0;
		}

		// Token: 0x020003B2 RID: 946
		[CompilerGenerated]
		private sealed class Class377
		{
			// Token: 0x060024CB RID: 9419 RVA: 0x0007DA2C File Offset: 0x0007BC2C
			public bool method_0(KeyValuePair<string, Class186> f)
			{
				return f.Value.ForceRecheck && !this.dictionary_0.ContainsKey(f.Key) && this.class376_0.class137_0.class96_1.FILES.ContainsKey(f.Key);
			}

			// Token: 0x060024CC RID: 9420 RVA: 0x0007DA80 File Offset: 0x0007BC80
			public bool method_1(Class102 _contentPack, Class402 _updateData, int _startPatchIndex)
			{
				EventHandler<EventArgs10> eventHandler = null;
				EventHandler<EventArgs9> eventHandler2 = null;
				this.class376_0.action_0(Enum74.const_7, Enum66.const_0);
				HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				bool result;
				try
				{
					int i = _startPatchIndex;
					while (i < _updateData.Patches.Count)
					{
						KeyValuePair<Struct43, Class319> keyValuePair = _updateData.Patches[i];
						if (keyValuePair.Value.MinimumVersion <= Class500.Current.FileVersion)
						{
							string text = Path.Combine(Class291.ContentPackDataDirectory, keyValuePair.Key.ToString() + ".tmp");
							bool downloadCompleted;
							using (Stream stream = File.Open(text, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
							{
								Class508 @class = new Class508(keyValuePair.Value.DownloadUri, stream, true);
								using (Task task = new Task(new Action<object>(@class.method_11), this.class376_0.class137_0.cancellationTokenSource_0.Token))
								{
									Class508 class2 = @class;
									if (eventHandler == null)
									{
										eventHandler = new EventHandler<EventArgs10>(this.method_2);
									}
									class2.ProgressChanged += eventHandler;
									this.action_0();
									task.RunSynchronously();
								}
								downloadCompleted = @class.DownloadCompleted;
							}
							if (downloadCompleted)
							{
								hashSet.Add(text);
								i++;
								continue;
							}
							if (File.Exists(text))
							{
								File.Delete(text);
							}
						}
						else if (this.class376_0.class137_0.eventHandler_2 != null)
						{
							this.class376_0.class137_0.eventHandler_2(this.class376_0.class137_0, new EventArgs42(_contentPack, keyValuePair.Value.MinimumVersion, true));
						}
						IL_19B:
						this.class376_0.action_0(Enum74.const_8, Enum66.const_0);
						string path = _contentPack.FileName;
						string text2 = null;
						this.action_0();
						foreach (string path2 in hashSet)
						{
							string text3 = Path.ChangeExtension(path2, ".ttp");
							Class292 class3 = new Class292();
							Class292 class4 = class3;
							if (eventHandler2 == null)
							{
								eventHandler2 = new EventHandler<EventArgs9>(this.method_3);
							}
							class4.ProgressChanged += eventHandler2;
							try
							{
								using (Stream stream2 = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None))
								{
									using (Stream stream3 = File.Open(path2, FileMode.Open, FileAccess.Read, FileShare.None))
									{
										using (Stream stream4 = File.Open(text3, FileMode.Create, FileAccess.ReadWrite, FileShare.None))
										{
											class3.method_0(stream2, stream3, stream4);
										}
									}
								}
							}
							catch (Exception ex)
							{
								ex.smethod_1(new object[]
								{
									"failure to patch"
								});
								break;
							}
							path = text3;
							text2 = text3;
						}
						if (!string.IsNullOrEmpty(text2) && File.Exists(text2))
						{
							Class234.smethod_14(text2, _contentPack.FileName, true);
							return true;
						}
						return false;
					}
					goto IL_19B;
				}
				catch (Exception ex2)
				{
					ex2.smethod_0();
					result = false;
				}
				finally
				{
					foreach (string path3 in hashSet)
					{
						if (File.Exists(path3))
						{
							File.Delete(path3);
						}
					}
				}
				return result;
			}

			// Token: 0x060024CD RID: 9421 RVA: 0x0007DEA4 File Offset: 0x0007C0A4
			public void method_2(object sender, EventArgs10 e)
			{
				if (this.class376_0.enum74_0 == Enum74.const_7 && this.class376_0.class137_0.eventHandler_3 != null)
				{
					this.class376_0.class137_0.eventHandler_3(this.class376_0.class137_0, e);
				}
			}

			// Token: 0x060024CE RID: 9422 RVA: 0x0007DEF4 File Offset: 0x0007C0F4
			public void method_3(object sender, EventArgs9 e)
			{
				if (this.class376_0.enum74_0 == Enum74.const_8 && this.class376_0.class137_0.eventHandler_4 != null)
				{
					this.class376_0.class137_0.eventHandler_4(this.class376_0.class137_0, e);
				}
			}

			// Token: 0x04001118 RID: 4376
			public Class137.Class376 class376_0;

			// Token: 0x04001119 RID: 4377
			public Dictionary<string, Class307> dictionary_0;

			// Token: 0x0400111A RID: 4378
			public Class114 class114_0;

			// Token: 0x0400111B RID: 4379
			public Class96 class96_0;

			// Token: 0x0400111C RID: 4380
			public Action action_0;
		}

		// Token: 0x020003B3 RID: 947
		[CompilerGenerated]
		private sealed class Class378
		{
			// Token: 0x060024D0 RID: 9424 RVA: 0x0007DF44 File Offset: 0x0007C144
			public void method_0(object sender, EventArgs23 e)
			{
				if (this.class376_0.enum74_0 == Enum74.const_1)
				{
					this.long_1 += e.PacketLength;
					if (this.class376_0.class137_0.eventHandler_3 != null)
					{
						this.class376_0.class137_0.eventHandler_3(this.class376_0.class137_0, new EventArgs10(this.long_1, this.long_0));
					}
				}
			}

			// Token: 0x0400111D RID: 4381
			public Class137.Class377 class377_0;

			// Token: 0x0400111E RID: 4382
			public Class137.Class376 class376_0;

			// Token: 0x0400111F RID: 4383
			public long long_0;

			// Token: 0x04001120 RID: 4384
			public long long_1;

			// Token: 0x04001121 RID: 4385
			public List<Class307> list_0;

			// Token: 0x04001122 RID: 4386
			public List<Task> list_1;

			// Token: 0x04001123 RID: 4387
			public TaskFactory taskFactory_0;
		}

		// Token: 0x020003B4 RID: 948
		[CompilerGenerated]
		private sealed class Class379
		{
			// Token: 0x060024D2 RID: 9426 RVA: 0x0007DFB8 File Offset: 0x0007C1B8
			public void method_0()
			{
				this.class139_0.Downloader = new Class384(this.class139_0, this.class376_0.class137_0.cancellationTokenSource_0.Token);
				long num;
				switch (this.class139_0.Downloader.method_1(out num))
				{
				case Class384.Enum83.const_1:
					this.class378_0.long_0 += num;
					return;
				case Class384.Enum83.const_2:
					break;
				case Class384.Enum83.const_3:
					this.class376_0.class137_0.method_4(true);
					break;
				default:
					return;
				}
			}

			// Token: 0x04001124 RID: 4388
			public Class137.Class378 class378_0;

			// Token: 0x04001125 RID: 4389
			public Class137.Class377 class377_0;

			// Token: 0x04001126 RID: 4390
			public Class137.Class376 class376_0;

			// Token: 0x04001127 RID: 4391
			public Class137.Class139 class139_0;
		}

		// Token: 0x020003B5 RID: 949
		[CompilerGenerated]
		private sealed class Class380
		{
			// Token: 0x060024D4 RID: 9428 RVA: 0x0007E040 File Offset: 0x0007C240
			public void method_0()
			{
				Action action = null;
				this.class139_0.DownloadState = this.class139_0.Downloader.method_3();
				if (this.class139_0.PatchDetails == null)
				{
					TaskFactory taskFactory_ = this.class378_0.taskFactory_0;
					if (action == null)
					{
						action = new Action(this.method_1);
					}
					Task item = taskFactory_.StartNew(action);
					lock (this.class378_0.list_1)
					{
						this.class378_0.list_1.Add(item);
						return;
					}
				}
				if (this.class139_0.IsFirstPatch)
				{
					Class137.Class380.Class381 @class = new Class137.Class380.Class381();
					@class.class380_0 = this;
					@class.class378_0 = this.class378_0;
					@class.class377_0 = this.class377_0;
					@class.class376_0 = this.class376_0;
					@class.action_0 = null;
					@class.action_0 = new Action<Class137.Class139>(@class.method_0);
					Task item2 = this.class378_0.taskFactory_0.StartNew(new Action(@class.method_1));
					lock (this.class378_0.list_1)
					{
						this.class378_0.list_1.Add(item2);
					}
				}
			}

			// Token: 0x060024D5 RID: 9429 RVA: 0x0007E1A8 File Offset: 0x0007C3A8
			public void method_1()
			{
				switch (this.class139_0.DownloadState)
				{
				case Class384.Enum83.const_1:
					try
					{
						Class307 fileUpdateDetails = this.class139_0.FileUpdateDetails;
						using (Stream stream = File.Open(fileUpdateDetails.FilePath, FileMode.Create, FileAccess.Write, FileShare.None))
						{
							this.class139_0.TargetStream.Position = 0L;
							Class219.smethod_0(this.class139_0.TargetStream, stream, false);
						}
						this.class377_0.class114_0.method_4(fileUpdateDetails.FilePath);
						if (this.class376_0.class137_0.bool_2 && fileUpdateDetails.Virtualized)
						{
							File.Copy(fileUpdateDetails.FilePath, fileUpdateDetails.AltFilePath, true);
							this.class377_0.class114_0.method_4(fileUpdateDetails.AltFilePath);
						}
						Struct43? hashOverride = new Struct43?(Class513.smethod_0(fileUpdateDetails.FilePath));
						long? sizeOverride = new long?(Class234.smethod_11(fileUpdateDetails.FilePath));
						this.class376_0.class137_0.class96_1.method_6(fileUpdateDetails.PhaseName, fileUpdateDetails.FileDetails, hashOverride, sizeOverride);
						if (this.class376_0.class137_0.bool_2)
						{
							this.class377_0.class96_0.method_6(fileUpdateDetails.PhaseName, fileUpdateDetails.FileDetails, hashOverride, sizeOverride);
						}
						goto IL_177;
					}
					catch (Exception ex)
					{
						ex.smethod_0();
						this.class376_0.class137_0.method_4(true);
						goto IL_177;
					}
					break;
				case Class384.Enum83.const_2:
					goto IL_177;
				case Class384.Enum83.const_3:
					break;
				default:
					goto IL_177;
				}
				this.class376_0.class137_0.method_4(true);
				IL_177:
				lock (this.class139_0)
				{
					this.class139_0.Dispose();
					this.class139_0.DownloadTask.Dispose();
				}
			}

			// Token: 0x04001128 RID: 4392
			public Class137.Class378 class378_0;

			// Token: 0x04001129 RID: 4393
			public Class137.Class377 class377_0;

			// Token: 0x0400112A RID: 4394
			public Class137.Class376 class376_0;

			// Token: 0x0400112B RID: 4395
			public Class137.Class139 class139_0;

			// Token: 0x020003B6 RID: 950
			private sealed class Class381
			{
				// Token: 0x060024D7 RID: 9431 RVA: 0x0007E3B4 File Offset: 0x0007C5B4
				public void method_0(Class137.Class139 patch_download)
				{
					Action<Task> action = null;
					Class137.Class380.Class381.Class382 @class = new Class137.Class380.Class381.Class382();
					@class.class381_0 = this;
					@class.class380_0 = this.class380_0;
					@class.class378_0 = this.class378_0;
					@class.class377_0 = this.class377_0;
					@class.class376_0 = this.class376_0;
					@class.class139_0 = patch_download;
					switch (@class.class139_0.DownloadState)
					{
					case Class384.Enum83.const_1:
						try
						{
							Class307 fileUpdateDetails = @class.class139_0.FileUpdateDetails;
							Class282 patchDetails = @class.class139_0.PatchDetails;
							@class.class139_0.TargetStream.Position = 0L;
							Class292.smethod_17(@class.class139_0.TargetStream, fileUpdateDetails.FilePath, new uint?(patchDetails.ExpectedFileSize), patchDetails.ExpectedHash, new uint?(patchDetails.ResultingFileSize), patchDetails.ResultingHash, null);
							Struct43? hashOverride = null;
							long? sizeOverride = null;
							if (@class.class139_0.NextPatchDownloadData == null)
							{
								if (this.class376_0.class137_0.bool_2 && fileUpdateDetails.Virtualized)
								{
									File.Copy(fileUpdateDetails.FilePath, fileUpdateDetails.AltFilePath, true);
									this.class377_0.class114_0.method_4(fileUpdateDetails.AltFilePath);
									lock (this.class378_0.list_0)
									{
										if (this.class378_0.list_0.Contains(fileUpdateDetails))
										{
											this.class378_0.list_0.Remove(fileUpdateDetails);
										}
									}
								}
								hashOverride = new Struct43?(Class513.smethod_0(fileUpdateDetails.FilePath));
								sizeOverride = new long?(Class234.smethod_11(fileUpdateDetails.FilePath));
							}
							else if (this.class376_0.class137_0.bool_2 && fileUpdateDetails.Virtualized)
							{
								lock (this.class378_0.list_0)
								{
									if (!this.class378_0.list_0.Contains(fileUpdateDetails))
									{
										this.class378_0.list_0.Add(fileUpdateDetails);
									}
								}
							}
							this.class376_0.class137_0.class96_1.method_5(fileUpdateDetails.PhaseName, @class.class139_0.PatchDetails, hashOverride, sizeOverride);
							if (this.class376_0.class137_0.bool_2)
							{
								this.class377_0.class96_0.method_5(fileUpdateDetails.PhaseName, @class.class139_0.PatchDetails, hashOverride, sizeOverride);
							}
							if (@class.class139_0.NextPatchDownloadData != null)
							{
								TaskFactory taskFactory_ = this.class378_0.taskFactory_0;
								Task[] tasks = new Task[]
								{
									@class.class139_0.NextPatchDownloadData.DownloadTask
								};
								if (action == null)
								{
									action = new Action<Task>(@class.method_0);
								}
								Task item = taskFactory_.ContinueWhenAny(tasks, action);
								lock (this.class378_0.list_1)
								{
									this.class378_0.list_1.Add(item);
								}
							}
							goto IL_336;
						}
						catch (Exception ex)
						{
							ex.smethod_0();
							this.class376_0.class137_0.method_4(true);
							goto IL_336;
						}
						break;
					case Class384.Enum83.const_2:
						goto IL_336;
					case Class384.Enum83.const_3:
						break;
					default:
						goto IL_336;
					}
					this.class376_0.class137_0.method_4(true);
					IL_336:
					lock (@class.class139_0)
					{
						@class.class139_0.Dispose();
						@class.class139_0.DownloadTask.Dispose();
					}
				}

				// Token: 0x060024D8 RID: 9432 RVA: 0x000100CD File Offset: 0x0000E2CD
				public void method_1()
				{
					this.action_0(this.class380_0.class139_0);
				}

				// Token: 0x0400112C RID: 4396
				public Class137.Class380 class380_0;

				// Token: 0x0400112D RID: 4397
				public Class137.Class378 class378_0;

				// Token: 0x0400112E RID: 4398
				public Class137.Class377 class377_0;

				// Token: 0x0400112F RID: 4399
				public Class137.Class376 class376_0;

				// Token: 0x04001130 RID: 4400
				public Action<Class137.Class139> action_0;

				// Token: 0x020003B7 RID: 951
				private sealed class Class382
				{
					// Token: 0x060024DA RID: 9434 RVA: 0x000100E5 File Offset: 0x0000E2E5
					public void method_0(Task _)
					{
						this.class381_0.action_0(this.class139_0.NextPatchDownloadData);
					}

					// Token: 0x04001131 RID: 4401
					public Class137.Class380.Class381 class381_0;

					// Token: 0x04001132 RID: 4402
					public Class137.Class380 class380_0;

					// Token: 0x04001133 RID: 4403
					public Class137.Class378 class378_0;

					// Token: 0x04001134 RID: 4404
					public Class137.Class377 class377_0;

					// Token: 0x04001135 RID: 4405
					public Class137.Class376 class376_0;

					// Token: 0x04001136 RID: 4406
					public Class137.Class139 class139_0;
				}
			}
		}

		// Token: 0x020003B8 RID: 952
		[CompilerGenerated]
		private sealed class Class383
		{
			// Token: 0x060024DC RID: 9436 RVA: 0x0007E7B4 File Offset: 0x0007C9B4
			public bool method_0(Class402 _updateData)
			{
				EventHandler<EventArgs10> eventHandler = null;
				this.class376_0.action_0(Enum74.const_7, Enum66.const_0);
				if (_updateData.MinimumVersion > Class500.Current.FileVersion)
				{
					if (this.class376_0.class137_0.eventHandler_2 != null)
					{
						this.class376_0.class137_0.eventHandler_2(this.class376_0.class137_0, new EventArgs42(this.class102_0, _updateData.MinimumVersion, false));
					}
					return false;
				}
				string text = this.class102_0.FileName + ".tmp";
				bool downloadCompleted;
				using (Stream stream = File.Open(text, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None))
				{
					Class508 @class = new Class508(_updateData.DownloadUri, stream, true);
					using (Task task = new Task(new Action<object>(@class.method_11), this.class376_0.class137_0.cancellationTokenSource_0.Token))
					{
						Class508 class2 = @class;
						if (eventHandler == null)
						{
							eventHandler = new EventHandler<EventArgs10>(this.method_1);
						}
						class2.ProgressChanged += eventHandler;
						this.class377_0.action_0();
						task.RunSynchronously();
					}
					downloadCompleted = @class.DownloadCompleted;
				}
				if (downloadCompleted)
				{
					Class234.smethod_14(text, this.class102_0.FileName, true);
				}
				else
				{
					File.Delete(text);
				}
				return downloadCompleted;
			}

			// Token: 0x060024DD RID: 9437 RVA: 0x0007E91C File Offset: 0x0007CB1C
			public void method_1(object sender, EventArgs10 e)
			{
				if (this.class376_0.enum74_0 == Enum74.const_7 && this.class376_0.class137_0.eventHandler_3 != null)
				{
					this.class376_0.class137_0.eventHandler_3(this.class376_0.class137_0, e);
				}
			}

			// Token: 0x04001137 RID: 4407
			public Class137.Class377 class377_0;

			// Token: 0x04001138 RID: 4408
			public Class137.Class376 class376_0;

			// Token: 0x04001139 RID: 4409
			public Class102 class102_0;
		}
	}
}
