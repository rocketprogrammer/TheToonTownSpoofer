using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using ns14;
using ns15;
using ns16;
using ns18;
using ns19;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns30;
using ns31;
using TSN.Collections;

namespace ns20
{
	// Token: 0x0200042F RID: 1071
	internal sealed class Class142 : Class123
	{
		// Token: 0x060028A1 RID: 10401 RVA: 0x000995E0 File Offset: 0x000977E0
		private static void smethod_0()
		{
			Action<Class177> action = null;
			Func<Class177, bool> func = null;
			Class142.Class439 @class = new Class142.Class439();
			@class.hashSet_0 = new HashSet<Class177>();
			lock (((ICollection)Class142.list_0).SyncRoot)
			{
				lock (((ICollection)Class142.list_1).SyncRoot)
				{
					foreach (Class142 class2 in Class142.list_1)
					{
						lock (((ICollection)class2.list_2).SyncRoot)
						{
							List<Class177> list = class2.list_2;
							if (action == null)
							{
								action = new Action<Class177>(@class.method_0);
							}
							list.ForEach(action);
						}
					}
				}
				foreach (Class177 item in @class.hashSet_0)
				{
					if (!Class142.list_0.Contains(item))
					{
						Class142.list_0.Add(item);
					}
				}
				IEnumerable<Class177> source = Class142.list_0;
				if (func == null)
				{
					func = new Func<Class177, bool>(@class.method_1);
				}
				IEnumerable<Class177> col = source.Where(func).ToArray<Class177>();
				if (Class142.action_0 == null)
				{
					Class142.action_0 = new Action<Class177>(Class142.smethod_11);
				}
				col.smethod_7(Class142.action_0);
			}
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x000997D0 File Offset: 0x000979D0
		public static bool smethod_1(Enum101 type, string username)
		{
			lock (((ICollection)Class142.list_1).SyncRoot)
			{
				foreach (Class142 @class in Class142.list_1)
				{
					if (@class.ServerType == type && @class.Username == username)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00099868 File Offset: 0x00097A68
		public static bool smethod_2(IntPtr hWnd, out Class142 wnd)
		{
			lock (((ICollection)Class142.list_1).SyncRoot)
			{
				foreach (Class142 @class in Class142.list_1)
				{
					if (@class.ToonTownProcess.MainWindowHandle == hWnd)
					{
						wnd = @class;
						return true;
					}
				}
			}
			wnd = null;
			return false;
		}

		// Token: 0x060028A4 RID: 10404 RVA: 0x00099904 File Offset: 0x00097B04
		public static HashSet<string> smethod_3()
		{
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			lock (((ICollection)Class142.list_1).SyncRoot)
			{
				foreach (Class142 @class in Class142.list_1)
				{
					if (@class.LogMonitor != null)
					{
						string logFileName = @class.LogMonitor.LogFileName;
						if (!string.IsNullOrEmpty(logFileName) && !hashSet.Contains(logFileName))
						{
							hashSet.Add(logFileName);
						}
					}
				}
			}
			return hashSet;
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060028A5 RID: 10405 RVA: 0x000999BC File Offset: 0x00097BBC
		public static ReadOnlyCollection<Class177> AvailableDistricts
		{
			get
			{
				ReadOnlyCollection<Class177> result;
				lock (((ICollection)Class142.list_0).SyncRoot)
				{
					result = Class142.list_0.AsReadOnly();
				}
				return result;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060028A6 RID: 10406 RVA: 0x00099A08 File Offset: 0x00097C08
		public static ReadOnlyCollection<Class142> OpenToonTownWindows
		{
			get
			{
				ReadOnlyCollection<Class142> result;
				lock (((ICollection)Class142.list_1).SyncRoot)
				{
					result = Class142.list_1.AsReadOnly();
				}
				return result;
			}
		}

		// Token: 0x140001D1 RID: 465
		// (add) Token: 0x060028A7 RID: 10407 RVA: 0x00099A54 File Offset: 0x00097C54
		// (remove) Token: 0x060028A8 RID: 10408 RVA: 0x00099A88 File Offset: 0x00097C88
		public static event EventHandler<EventArgs31> WindowInvasionStateChanged
		{
			add
			{
				EventHandler<EventArgs31> eventHandler = Class142.eventHandler_2;
				EventHandler<EventArgs31> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs31> value2 = (EventHandler<EventArgs31>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs31>>(ref Class142.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs31> eventHandler = Class142.eventHandler_2;
				EventHandler<EventArgs31> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs31> value2 = (EventHandler<EventArgs31>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs31>>(ref Class142.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001D2 RID: 466
		// (add) Token: 0x060028A9 RID: 10409 RVA: 0x00099ABC File Offset: 0x00097CBC
		// (remove) Token: 0x060028AA RID: 10410 RVA: 0x00099AF0 File Offset: 0x00097CF0
		public static event EventHandler<EventArgs37> WindowDistrictChanged
		{
			add
			{
				EventHandler<EventArgs37> eventHandler = Class142.eventHandler_3;
				EventHandler<EventArgs37> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs37> value2 = (EventHandler<EventArgs37>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs37>>(ref Class142.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs37> eventHandler = Class142.eventHandler_3;
				EventHandler<EventArgs37> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs37> value2 = (EventHandler<EventArgs37>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs37>>(ref Class142.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001D3 RID: 467
		// (add) Token: 0x060028AB RID: 10411 RVA: 0x00099B24 File Offset: 0x00097D24
		// (remove) Token: 0x060028AC RID: 10412 RVA: 0x00099B58 File Offset: 0x00097D58
		public static event EventHandler<EventArgs29> InvasionNotDetected
		{
			add
			{
				EventHandler<EventArgs29> eventHandler = Class142.eventHandler_4;
				EventHandler<EventArgs29> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs29> value2 = (EventHandler<EventArgs29>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs29>>(ref Class142.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs29> eventHandler = Class142.eventHandler_4;
				EventHandler<EventArgs29> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs29> value2 = (EventHandler<EventArgs29>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs29>>(ref Class142.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001D4 RID: 468
		// (add) Token: 0x060028AD RID: 10413 RVA: 0x00099B8C File Offset: 0x00097D8C
		// (remove) Token: 0x060028AE RID: 10414 RVA: 0x00099BC0 File Offset: 0x00097DC0
		public static event EventHandler WindowClosed
		{
			add
			{
				EventHandler eventHandler = Class142.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class142.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = Class142.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref Class142.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x0001296E File Offset: 0x00010B6E
		private static void smethod_4(Class142 window)
		{
			if (Class142.eventHandler_5 != null)
			{
				Class142.eventHandler_5(window, EventArgs.Empty);
			}
		}

		// Token: 0x060028B0 RID: 10416 RVA: 0x00012987 File Offset: 0x00010B87
		private static void smethod_5(Class142 window, Class177 district)
		{
			if (Class142.eventHandler_4 != null)
			{
				Class142.eventHandler_4(window, new EventArgs29(district));
			}
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x000129A1 File Offset: 0x00010BA1
		private static void smethod_6(Class142 window, Struct26 state)
		{
			if (Class142.eventHandler_2 != null)
			{
				Class142.eventHandler_2(window, new EventArgs31(state));
			}
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x000129BB File Offset: 0x00010BBB
		private static void smethod_7(Class142 window, Class177 district)
		{
			if (Class142.eventHandler_3 != null)
			{
				Class142.eventHandler_3(window, new EventArgs37(district));
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060028B3 RID: 10419 RVA: 0x000129D5 File Offset: 0x00010BD5
		public bool IsLogging
		{
			get
			{
				return this.LogMonitor != null && this.LogMonitor.Running;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060028B4 RID: 10420 RVA: 0x000129EC File Offset: 0x00010BEC
		// (set) Token: 0x060028B5 RID: 10421 RVA: 0x000129F4 File Offset: 0x00010BF4
		public Class141 ToonTownProcess { get; private set; }

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060028B6 RID: 10422 RVA: 0x000129FD File Offset: 0x00010BFD
		// (set) Token: 0x060028B7 RID: 10423 RVA: 0x00012A05 File Offset: 0x00010C05
		public string Username { get; private set; }

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060028B8 RID: 10424 RVA: 0x00012A0E File Offset: 0x00010C0E
		// (set) Token: 0x060028B9 RID: 10425 RVA: 0x00012A16 File Offset: 0x00010C16
		public Class129 LogMonitor { get; private set; }

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060028BA RID: 10426 RVA: 0x00012A1F File Offset: 0x00010C1F
		// (set) Token: 0x060028BB RID: 10427 RVA: 0x00012A27 File Offset: 0x00010C27
		public Enum101 ServerType { get; private set; }

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060028BC RID: 10428 RVA: 0x00012A30 File Offset: 0x00010C30
		// (set) Token: 0x060028BD RID: 10429 RVA: 0x00012A38 File Offset: 0x00010C38
		public Class177 District { get; private set; }

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060028BE RID: 10430 RVA: 0x00012A41 File Offset: 0x00010C41
		// (set) Token: 0x060028BF RID: 10431 RVA: 0x00012A49 File Offset: 0x00010C49
		public Struct26? Invasion { get; private set; }

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x060028C0 RID: 10432 RVA: 0x00012A52 File Offset: 0x00010C52
		// (set) Token: 0x060028C1 RID: 10433 RVA: 0x00012A5A File Offset: 0x00010C5A
		public Enum57 Playground { get; private set; }

		// Token: 0x140001D5 RID: 469
		// (add) Token: 0x060028C2 RID: 10434 RVA: 0x00099BF4 File Offset: 0x00097DF4
		// (remove) Token: 0x060028C3 RID: 10435 RVA: 0x00099C2C File Offset: 0x00097E2C
		public event EventHandler<EventArgs31> InvasionStateChanged
		{
			add
			{
				EventHandler<EventArgs31> eventHandler = this.eventHandler_6;
				EventHandler<EventArgs31> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs31> value2 = (EventHandler<EventArgs31>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs31>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs31> eventHandler = this.eventHandler_6;
				EventHandler<EventArgs31> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs31> value2 = (EventHandler<EventArgs31>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs31>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001D6 RID: 470
		// (add) Token: 0x060028C4 RID: 10436 RVA: 0x00099C64 File Offset: 0x00097E64
		// (remove) Token: 0x060028C5 RID: 10437 RVA: 0x00099C9C File Offset: 0x00097E9C
		public event EventHandler<EventArgs37> DistrictChanged
		{
			add
			{
				EventHandler<EventArgs37> eventHandler = this.eventHandler_7;
				EventHandler<EventArgs37> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs37> value2 = (EventHandler<EventArgs37>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs37>>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs37> eventHandler = this.eventHandler_7;
				EventHandler<EventArgs37> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs37> value2 = (EventHandler<EventArgs37>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs37>>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x060028C6 RID: 10438 RVA: 0x00099CD4 File Offset: 0x00097ED4
		private List<Class309> SafeFileStates
		{
			get
			{
				List<Class309> result;
				lock (((ICollection)this.list_3).SyncRoot)
				{
					result = this.list_3;
				}
				return result;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x060028C7 RID: 10439 RVA: 0x00012A63 File Offset: 0x00010C63
		public ReadOnlyCollection<Class309> FileStates
		{
			get
			{
				return this.SafeFileStates.AsReadOnly();
			}
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00099D1C File Offset: 0x00097F1C
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public static Class142 smethod_8(Process p, Enum101 serverType, string username, bool isOpen = true)
		{
			Class142 result;
			try
			{
				p.EnableRaisingEvents = true;
				result = new Class142(p, serverType, username, isOpen);
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				result = null;
			}
			return result;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00099D58 File Offset: 0x00097F58
		public static Class142 smethod_9(IntPtr hWnd, Enum101 serverType, string username)
		{
			Class142 result;
			try
			{
				result = new Class142(hWnd, serverType, username);
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				result = null;
			}
			return result;
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00012A70 File Offset: 0x00010C70
		private Class142(Process p, Enum101 serverType, string username, bool isOpen = true) : this(serverType, username)
		{
			if (p == null)
			{
				throw new ArgumentNullException("p");
			}
			this.ToonTownProcess = new Class141(p, true, isOpen);
			this.ToonTownProcess.ProcessExited += this.method_7;
		}

		// Token: 0x060028CB RID: 10443 RVA: 0x00012AAE File Offset: 0x00010CAE
		private Class142(IntPtr hWnd, Enum101 serverType, string username) : this(serverType, username)
		{
			this.ToonTownProcess = new Class141();
			this.ToonTownProcess.ProcessExited += this.method_7;
			this.ToonTownProcess.MainWindowHandle = hWnd;
		}

		// Token: 0x060028CC RID: 10444 RVA: 0x00099D8C File Offset: 0x00097F8C
		private Class142(Enum101 serverType, string username)
		{
			this.list_3 = new List<Class309>();
			this.ServerType = serverType;
			this.Username = username;
			this.Playground = Enum57.const_0;
			lock (((ICollection)Class142.list_1).SyncRoot)
			{
				Class142.list_1.Add(this);
			}
		}

		// Token: 0x060028CD RID: 10445 RVA: 0x00012AE6 File Offset: 0x00010CE6
		public void method_4()
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_8));
		}

		// Token: 0x060028CE RID: 10446 RVA: 0x00099E08 File Offset: 0x00098008
		public bool method_5()
		{
			Class142.Class440 @class = new Class142.Class440();
			@class.class142_0 = this;
			@class.bool_0 = false;
			@class.bool_1 = false;
			EventHandler eventHandler = null;
			WaitCallback waitCallback = null;
			Class142.Class441 class2 = new Class142.Class441();
			class2.class440_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			try
			{
				try
				{
					Class141 toonTownProcess = this.ToonTownProcess;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler(class2.method_0);
					}
					toonTownProcess.ProcessExited += eventHandler;
					if (waitCallback == null)
					{
						waitCallback = new WaitCallback(class2.method_1);
					}
					ThreadPool.QueueUserWorkItem(waitCallback);
					class2.manualResetEventSlim_0.Wait();
				}
				finally
				{
					@class.bool_1 = true;
				}
			}
			finally
			{
				if (class2.manualResetEventSlim_0 != null)
				{
					((IDisposable)class2.manualResetEventSlim_0).Dispose();
				}
			}
			return @class.bool_0;
		}

		// Token: 0x060028CF RID: 10447 RVA: 0x00099ED0 File Offset: 0x000980D0
		private bool method_6(EventHandler endOfStream = null)
		{
			EventHandler<EventArgs0> eventHandler = null;
			EventHandler<EventArgs31> eventHandler2 = null;
			EventHandler<EventArgs37> eventHandler3 = null;
			EventHandler eventHandler4 = null;
			EventHandler<EventArgs1> eventHandler5 = null;
			EventHandler eventHandler6 = null;
			EventHandler<EventArgs30> eventHandler7 = null;
			string logFile;
			if (Class142.smethod_10(this.ToonTownProcess.Process, out logFile))
			{
				this.LogMonitor = new Class129(logFile);
				Class129 logMonitor = this.LogMonitor;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler<EventArgs0>(this.method_9);
				}
				logMonitor.FileStateRead += eventHandler;
				Class129 logMonitor2 = this.LogMonitor;
				if (eventHandler2 == null)
				{
					eventHandler2 = new EventHandler<EventArgs31>(this.method_10);
				}
				logMonitor2.InvasionStateChanged += eventHandler2;
				Class129 logMonitor3 = this.LogMonitor;
				if (eventHandler3 == null)
				{
					eventHandler3 = new EventHandler<EventArgs37>(this.method_11);
				}
				logMonitor3.DistrictChanged += eventHandler3;
				Class129 logMonitor4 = this.LogMonitor;
				if (eventHandler4 == null)
				{
					eventHandler4 = new EventHandler(this.method_12);
				}
				logMonitor4.LoggedOut += eventHandler4;
				Class129 logMonitor5 = this.LogMonitor;
				if (eventHandler5 == null)
				{
					eventHandler5 = new EventHandler<EventArgs1>(this.method_13);
				}
				logMonitor5.AvailableDistrictsChanged += eventHandler5;
				Class129 logMonitor6 = this.LogMonitor;
				if (eventHandler6 == null)
				{
					eventHandler6 = new EventHandler(this.method_14);
				}
				logMonitor6.NoInvasionDetected += eventHandler6;
				Class129 logMonitor7 = this.LogMonitor;
				if (eventHandler7 == null)
				{
					eventHandler7 = new EventHandler<EventArgs30>(this.method_15);
				}
				logMonitor7.PlaygroundChanged += eventHandler7;
				if (endOfStream != null)
				{
					this.LogMonitor.ReadingPaused += endOfStream;
				}
				this.LogMonitor.method_4();
				return true;
			}
			return false;
		}

		// Token: 0x060028D0 RID: 10448 RVA: 0x0009A000 File Offset: 0x00098200
		private static bool smethod_10(Process p, out string logFile)
		{
			Class335.smethod_2(Class142.string_7, true);
			List<FileSystemInfo> list = Class471.smethod_2(p.Id);
			if (list != null)
			{
				using (List<FileSystemInfo>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						FileSystemInfo fileSystemInfo = enumerator.Current;
						if (fileSystemInfo is FileInfo && string.Equals(fileSystemInfo.Extension, Class142.string_4, StringComparison.OrdinalIgnoreCase) && fileSystemInfo.Name.StartsWith("toontown", StringComparison.OrdinalIgnoreCase) && fileSystemInfo.Exists)
						{
							logFile = fileSystemInfo.FullName;
							Class335.smethod_3(Class142.string_6, new object[]
							{
								logFile
							});
							return true;
						}
					}
					goto IL_B4;
				}
				bool result;
				return result;
			}
			Class335.smethod_2(Class142.string_5, true);
			IL_B4:
			string text = null;
			if ((p.StartInfo == null || string.IsNullOrEmpty(text = p.StartInfo.WorkingDirectory)) && p.MainModule != null)
			{
				text = Path.GetDirectoryName(p.MainModule.FileName);
			}
			if (!string.IsNullOrEmpty(text) && Directory.Exists(text))
			{
				Class142.Class442 @class = new Class142.Class442();
				Class335.smethod_3(Class142.string_2, new object[]
				{
					text
				});
				@class.dateTime_0 = p.StartTime;
				@class.hashSet_0 = Class142.smethod_3();
				IEnumerable<string> source = Class234.smethod_1(text, Class142.string_3, Class142.string_4).Where(new Func<string, bool>(@class.method_0));
				if (Class142.func_0 == null)
				{
					Class142.func_0 = new Func<string, bool>(Class142.smethod_12);
				}
				string[] array = source.Where(Class142.func_0).Where(new Func<string, bool>(@class.method_1)).ToArray<string>();
				if (array.Length == 1)
				{
					logFile = array[0];
					Class335.smethod_3(Class142.string_1, new object[]
					{
						logFile
					});
					return true;
				}
			}
			Class335.smethod_2(Class142.string_0, true);
			logFile = null;
			return false;
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x0009A1EC File Offset: 0x000983EC
		private void method_7(object sender, EventArgs e)
		{
			if (this.LogMonitor != null)
			{
				this.LogMonitor.method_5();
				this.LogMonitor = null;
			}
			Class99 connectSettings = Class110.Instance.ConnectSettings;
			Class96 actualToonTownVersionData = connectSettings.ActualToonTownVersionData;
			Class96 actualTestToonTownVersionData = connectSettings.ActualTestToonTownVersionData;
			Class96 spoofedToonTownVersionData = connectSettings.SpoofedToonTownVersionData;
			bool spoofedToonTownEnabled = connectSettings.SpoofedToonTownEnabled;
			lock (((ICollection)actualToonTownVersionData.FILES).SyncRoot)
			{
				lock (((ICollection)actualTestToonTownVersionData.FILES).SyncRoot)
				{
					lock (((ICollection)spoofedToonTownVersionData.FILES).SyncRoot)
					{
						foreach (Class309 @class in this.FileStates)
						{
							if (!@class.UpToDate)
							{
								switch (this.ServerType)
								{
								case Enum101.const_1:
									if (actualToonTownVersionData.FILES.ContainsKey(@class.FileName))
									{
										actualToonTownVersionData.FILES[@class.FileName].ForceRecheck = true;
									}
									if (spoofedToonTownEnabled && spoofedToonTownVersionData.FILES.ContainsKey(@class.FileName))
									{
										spoofedToonTownVersionData.FILES[@class.FileName].ForceRecheck = true;
									}
									break;
								case Enum101.const_2:
									if (actualTestToonTownVersionData.FILES.ContainsKey(@class.FileName))
									{
										actualTestToonTownVersionData.FILES[@class.FileName].ForceRecheck = true;
									}
									break;
								}
							}
						}
					}
				}
			}
			base.Dispose();
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x0009A404 File Offset: 0x00098604
		protected override void vmethod_0()
		{
			lock (((ICollection)Class142.list_1).SyncRoot)
			{
				if (Class142.list_1.Contains(this))
				{
					Class142.list_1.Remove(this);
				}
			}
			lock (((ICollection)this.list_2).SyncRoot)
			{
				this.list_2.Clear();
			}
			lock (((ICollection)Class142.dictionary_1).SyncRoot)
			{
				if (Class142.dictionary_1.ContainsKey(this))
				{
					Class142.dictionary_1.Remove(this);
				}
			}
			this.District = null;
			Class142.smethod_0();
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, new EventArgs37(null));
			}
			Class142.smethod_4(this);
			Class142.smethod_7(this, null);
			this.ToonTownProcess.Dispose();
			base.vmethod_0();
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00012AFA File Offset: 0x00010CFA
		[CompilerGenerated]
		private static void smethod_11(Class177 d)
		{
			Class142.list_0.Remove(d);
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00012B08 File Offset: 0x00010D08
		[CompilerGenerated]
		private void method_8(object obj)
		{
			this.method_6(null);
		}

		// Token: 0x060028D5 RID: 10453 RVA: 0x00012B12 File Offset: 0x00010D12
		[CompilerGenerated]
		private void method_9(object sender, EventArgs0 e)
		{
			this.SafeFileStates.Add(e.FileState);
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x0009A524 File Offset: 0x00098724
		[CompilerGenerated]
		private void method_10(object sender, EventArgs31 e)
		{
			lock (((ICollection)Class142.dictionary_0).SyncRoot)
			{
				switch (e.InvasionState.enum97_0)
				{
				case Enum97.const_0:
				case Enum97.const_2:
					if (Class142.dictionary_0.ContainsKey(this))
					{
						Class142.dictionary_0[this] = e.InvasionState;
					}
					else
					{
						Class142.dictionary_0.Add(this, e.InvasionState);
					}
					this.Invasion = new Struct26?(e.InvasionState);
					break;
				case Enum97.const_1:
					if (Class142.dictionary_0.ContainsKey(this))
					{
						Class142.dictionary_0.Remove(this);
					}
					this.Invasion = null;
					break;
				}
			}
			if (this.eventHandler_6 != null)
			{
				this.eventHandler_6(this, e);
			}
			Class142.smethod_6(this, e.InvasionState);
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x0009A614 File Offset: 0x00098814
		[CompilerGenerated]
		private void method_11(object sender, EventArgs37 e)
		{
			this.District = e.District;
			this.Invasion = null;
			lock (((ICollection)Class142.dictionary_0).SyncRoot)
			{
				if (Class142.dictionary_0.ContainsKey(this))
				{
					Class142.dictionary_0.Remove(this);
				}
			}
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, e);
			}
			lock (((ICollection)Class142.dictionary_1).SyncRoot)
			{
				if (Class142.dictionary_1.ContainsKey(this))
				{
					Class142.dictionary_1[this] = e.District;
				}
				else
				{
					Class142.dictionary_1.Add(this, e.District);
				}
			}
			Class142.smethod_7(this, e.District);
		}

		// Token: 0x060028D8 RID: 10456 RVA: 0x0009A708 File Offset: 0x00098908
		[CompilerGenerated]
		private void method_12(object sender, EventArgs e)
		{
			this.District = null;
			this.Invasion = null;
			lock (((ICollection)Class142.dictionary_0).SyncRoot)
			{
				if (Class142.dictionary_0.ContainsKey(this))
				{
					Class142.dictionary_0.Remove(this);
				}
			}
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, null);
			}
			lock (((ICollection)Class142.dictionary_1).SyncRoot)
			{
				if (Class142.dictionary_1.ContainsKey(this))
				{
					Class142.dictionary_1[this] = null;
				}
				else
				{
					Class142.dictionary_1.Add(this, null);
				}
			}
			Class142.smethod_7(this, null);
		}

		// Token: 0x060028D9 RID: 10457 RVA: 0x0009A7E8 File Offset: 0x000989E8
		[CompilerGenerated]
		private void method_13(object sender, EventArgs1 e)
		{
			lock (((ICollection)this.list_2).SyncRoot)
			{
				this.list_2.Clear();
				foreach (uint shardID in e.Shards)
				{
					Class177 item = Class177.smethod_0(shardID);
					if (!this.list_2.Contains(item))
					{
						this.list_2.Add(item);
					}
				}
			}
			Class142.smethod_0();
		}

		// Token: 0x060028DA RID: 10458 RVA: 0x00012B25 File Offset: 0x00010D25
		[CompilerGenerated]
		private void method_14(object sender, EventArgs e)
		{
			Class142.smethod_5(this, this.District);
		}

		// Token: 0x060028DB RID: 10459 RVA: 0x00012B33 File Offset: 0x00010D33
		[CompilerGenerated]
		private void method_15(object sender, EventArgs30 e)
		{
			this.Playground = e.Playground;
		}

		// Token: 0x060028DC RID: 10460 RVA: 0x00012B41 File Offset: 0x00010D41
		[CompilerGenerated]
		private static bool smethod_12(string file)
		{
			return Class234.smethod_4(file);
		}

		// Token: 0x0400149C RID: 5276
		private static readonly string string_0 = "Failed to Locate Log File";

		// Token: 0x0400149D RID: 5277
		private static readonly string string_1 = "Log File Located with Fallback";

		// Token: 0x0400149E RID: 5278
		private static readonly string string_2 = "Using Fallback";

		// Token: 0x0400149F RID: 5279
		private static readonly string string_3 = "toontown-*.log";

		// Token: 0x040014A0 RID: 5280
		private static readonly string string_4 = ".log";

		// Token: 0x040014A1 RID: 5281
		private static readonly string string_5 = "Open Files Failed";

		// Token: 0x040014A2 RID: 5282
		private static readonly string string_6 = "Log File Located With Open Files";

		// Token: 0x040014A3 RID: 5283
		private static readonly string string_7 = "Attempting to Locate Log File...";

		// Token: 0x040014A4 RID: 5284
		private static readonly List<Class177> list_0 = new List<Class177>();

		// Token: 0x040014A5 RID: 5285
		private static readonly List<Class142> list_1 = new List<Class142>();

		// Token: 0x040014A6 RID: 5286
		private static Dictionary<Class142, Struct26> dictionary_0 = new Dictionary<Class142, Struct26>();

		// Token: 0x040014A7 RID: 5287
		private static Dictionary<Class142, Class177> dictionary_1 = new Dictionary<Class142, Class177>();

		// Token: 0x040014A8 RID: 5288
		public static readonly TSN.Collections.ReadOnlyDictionary<Class142, Class177> readOnlyDictionary_0 = new TSN.Collections.ReadOnlyDictionary<Class142, Class177>(Class142.dictionary_1);

		// Token: 0x040014A9 RID: 5289
		public static readonly TSN.Collections.ReadOnlyDictionary<Class142, Struct26> readOnlyDictionary_1 = new TSN.Collections.ReadOnlyDictionary<Class142, Struct26>(Class142.dictionary_0);

		// Token: 0x040014AA RID: 5290
		private static EventHandler<EventArgs31> eventHandler_2;

		// Token: 0x040014AB RID: 5291
		private static EventHandler<EventArgs37> eventHandler_3;

		// Token: 0x040014AC RID: 5292
		private static EventHandler<EventArgs29> eventHandler_4;

		// Token: 0x040014AD RID: 5293
		private static EventHandler eventHandler_5;

		// Token: 0x040014AE RID: 5294
		private readonly List<Class177> list_2 = new List<Class177>();

		// Token: 0x040014AF RID: 5295
		private EventHandler<EventArgs31> eventHandler_6;

		// Token: 0x040014B0 RID: 5296
		private EventHandler<EventArgs37> eventHandler_7;

		// Token: 0x040014B1 RID: 5297
		private readonly List<Class309> list_3;

		// Token: 0x040014B2 RID: 5298
		[CompilerGenerated]
		private Class141 class141_0;

		// Token: 0x040014B3 RID: 5299
		[CompilerGenerated]
		private string string_8;

		// Token: 0x040014B4 RID: 5300
		[CompilerGenerated]
		private Class129 class129_0;

		// Token: 0x040014B5 RID: 5301
		[CompilerGenerated]
		private Enum101 enum101_0;

		// Token: 0x040014B6 RID: 5302
		[CompilerGenerated]
		private Class177 class177_0;

		// Token: 0x040014B7 RID: 5303
		[CompilerGenerated]
		private Struct26? nullable_0;

		// Token: 0x040014B8 RID: 5304
		[CompilerGenerated]
		private Enum57 enum57_0;

		// Token: 0x040014B9 RID: 5305
		[CompilerGenerated]
		private static Action<Class177> action_0;

		// Token: 0x040014BA RID: 5306
		[CompilerGenerated]
		private static Func<string, bool> func_0;

		// Token: 0x02000430 RID: 1072
		[CompilerGenerated]
		private sealed class Class439
		{
			// Token: 0x060028DF RID: 10463 RVA: 0x00012B49 File Offset: 0x00010D49
			public void method_0(Class177 d)
			{
				if (!this.hashSet_0.Contains(d))
				{
					this.hashSet_0.Add(d);
				}
			}

			// Token: 0x060028E0 RID: 10464 RVA: 0x00012B66 File Offset: 0x00010D66
			public bool method_1(Class177 d)
			{
				return !this.hashSet_0.Contains(d);
			}

			// Token: 0x040014BB RID: 5307
			public HashSet<Class177> hashSet_0;
		}

		// Token: 0x02000431 RID: 1073
		[CompilerGenerated]
		private sealed class Class440
		{
			// Token: 0x040014BC RID: 5308
			public bool bool_0;

			// Token: 0x040014BD RID: 5309
			public bool bool_1;

			// Token: 0x040014BE RID: 5310
			public Class142 class142_0;
		}

		// Token: 0x02000432 RID: 1074
		[CompilerGenerated]
		private sealed class Class441
		{
			// Token: 0x060028E3 RID: 10467 RVA: 0x00012B77 File Offset: 0x00010D77
			public void method_0(object sender, EventArgs e)
			{
				if (!this.class440_0.bool_1)
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x060028E4 RID: 10468 RVA: 0x00012B91 File Offset: 0x00010D91
			public void method_1(object obj)
			{
				if (!this.class440_0.class142_0.method_6(new EventHandler(this.method_2)))
				{
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x060028E5 RID: 10469 RVA: 0x00012BBC File Offset: 0x00010DBC
			public void method_2(object sender, EventArgs e)
			{
				if (!this.class440_0.bool_1 && !this.class440_0.bool_0)
				{
					this.class440_0.bool_0 = true;
					this.manualResetEventSlim_0.Set();
				}
			}

			// Token: 0x040014BF RID: 5311
			public Class142.Class440 class440_0;

			// Token: 0x040014C0 RID: 5312
			public ManualResetEventSlim manualResetEventSlim_0;
		}

		// Token: 0x02000433 RID: 1075
		[CompilerGenerated]
		private sealed class Class442
		{
			// Token: 0x060028E7 RID: 10471 RVA: 0x00012BEF File Offset: 0x00010DEF
			public bool method_0(string file)
			{
				return !this.hashSet_0.Contains(file);
			}

			// Token: 0x060028E8 RID: 10472 RVA: 0x0009A93C File Offset: 0x00098B3C
			public bool method_1(string file)
			{
				FileInfo fileInfo = new FileInfo(file);
				TimeSpan timeSpan;
				if (this.dateTime_0 > fileInfo.CreationTime)
				{
					timeSpan = this.dateTime_0 - fileInfo.CreationTime;
				}
				else
				{
					timeSpan = fileInfo.CreationTime - this.dateTime_0;
				}
				return timeSpan.TotalSeconds < 10.0;
			}

			// Token: 0x040014C1 RID: 5313
			public DateTime dateTime_0;

			// Token: 0x040014C2 RID: 5314
			public HashSet<string> hashSet_0;
		}
	}
}
