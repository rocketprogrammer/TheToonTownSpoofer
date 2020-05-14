using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ns16;
using ns19;
using ns23;
using ns25;
using ns26;
using ns27;
using ns30;
using ns31;

namespace ns15
{
	// Token: 0x0200022E RID: 558
	internal sealed class Class126 : Class123
	{
		// Token: 0x14000175 RID: 373
		// (add) Token: 0x06001813 RID: 6163 RVA: 0x00040F1C File Offset: 0x0003F11C
		// (remove) Token: 0x06001814 RID: 6164 RVA: 0x00040F54 File Offset: 0x0003F154
		public event EventHandler<EventArgs28> UpdateStepMismatch
		{
			add
			{
				EventHandler<EventArgs28> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs28> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs28> value2 = (EventHandler<EventArgs28>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs28>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs28> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs28> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs28> value2 = (EventHandler<EventArgs28>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs28>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000176 RID: 374
		// (add) Token: 0x06001815 RID: 6165 RVA: 0x00040F8C File Offset: 0x0003F18C
		// (remove) Token: 0x06001816 RID: 6166 RVA: 0x00040FC4 File Offset: 0x0003F1C4
		public event EventHandler<EventArgs38> ProgressChanged
		{
			add
			{
				EventHandler<EventArgs38> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs38> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs38> value2 = (EventHandler<EventArgs38>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs38>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs38> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs38> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs38> value2 = (EventHandler<EventArgs38>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs38>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000177 RID: 375
		// (add) Token: 0x06001817 RID: 6167 RVA: 0x00040FFC File Offset: 0x0003F1FC
		// (remove) Token: 0x06001818 RID: 6168 RVA: 0x00041034 File Offset: 0x0003F234
		public event EventHandler<EventArgs38> PipeServerDisconnected
		{
			add
			{
				EventHandler<EventArgs38> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs38> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs38> value2 = (EventHandler<EventArgs38>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs38>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs38> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs38> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs38> value2 = (EventHandler<EventArgs38>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs38>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000178 RID: 376
		// (add) Token: 0x06001819 RID: 6169 RVA: 0x0004106C File Offset: 0x0003F26C
		// (remove) Token: 0x0600181A RID: 6170 RVA: 0x000410A4 File Offset: 0x0003F2A4
		public event EventHandler Canceled
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000738 RID: 1848
		// (get) Token: 0x0600181B RID: 6171 RVA: 0x00007B91 File Offset: 0x00005D91
		// (set) Token: 0x0600181C RID: 6172 RVA: 0x00007B99 File Offset: 0x00005D99
		public Enum87 UpdateStep { get; private set; }

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600181D RID: 6173 RVA: 0x00007BA2 File Offset: 0x00005DA2
		// (set) Token: 0x0600181E RID: 6174 RVA: 0x00007BAA File Offset: 0x00005DAA
		public string UpdaterExitedPrematurely_Title { get; set; }

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600181F RID: 6175 RVA: 0x00007BB3 File Offset: 0x00005DB3
		// (set) Token: 0x06001820 RID: 6176 RVA: 0x00007BBB File Offset: 0x00005DBB
		public string UpdaterExitedPrematurely { get; set; }

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06001821 RID: 6177 RVA: 0x00007BC4 File Offset: 0x00005DC4
		// (set) Token: 0x06001822 RID: 6178 RVA: 0x00007BCC File Offset: 0x00005DCC
		public string ExtraArguments { get; set; }

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06001823 RID: 6179 RVA: 0x00007BD5 File Offset: 0x00005DD5
		// (set) Token: 0x06001824 RID: 6180 RVA: 0x000410DC File Offset: 0x0003F2DC
		public string wyUpdateLocation
		{
			get
			{
				return this.string_7;
			}
			set
			{
				this.string_7 = value;
				try
				{
					this.string_6 = Path.GetFullPath(Path.IsPathRooted(value) ? value : Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), value));
				}
				catch
				{
				}
			}
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0004112C File Offset: 0x0003F32C
		public Class126()
		{
			this.UpdateStep = Enum87.const_0;
			try
			{
				this.string_6 = Path.GetFullPath(Path.IsPathRooted(this.string_7) ? this.string_7 : Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), this.string_7));
			}
			catch
			{
			}
			this.method_4();
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x000411B8 File Offset: 0x0003F3B8
		protected override void vmethod_0()
		{
			Task task = this.task_0;
			if (task != null)
			{
				try
				{
					task.Wait();
				}
				catch (AggregateException)
				{
				}
				catch (ObjectDisposedException)
				{
				}
			}
			if (this.class148_0 != null)
			{
				this.class148_0.Dispose();
				this.class148_0 = null;
			}
			if (this.process_0 != null)
			{
				this.process_0.Dispose();
				this.process_0 = null;
			}
			base.vmethod_0();
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00041234 File Offset: 0x0003F434
		private void method_4()
		{
			if (this.class148_0 != null)
			{
				this.class148_0.MessageReceived -= this.method_6;
				this.class148_0.ServerDisconnected -= this.method_5;
				this.class148_0.Dispose();
				this.class148_0 = null;
			}
			this.class148_0 = new Class148();
			this.class148_0.MessageReceived += this.method_6;
			this.class148_0.ServerDisconnected += this.method_5;
		}

		// Token: 0x06001828 RID: 6184 RVA: 0x000412C4 File Offset: 0x0003F4C4
		private void method_5(object sender, EventArgs e)
		{
			if (this.process_0 != null)
			{
				this.process_0.Dispose();
				this.process_0 = null;
			}
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, new EventArgs38(new Class492(Enum28.const_0, this.UpdateStep, this.UpdaterExitedPrematurely_Title, this.UpdaterExitedPrematurely)));
			}
		}

		// Token: 0x06001829 RID: 6185 RVA: 0x0004131C File Offset: 0x0003F51C
		private void method_6(object sender, EventArgs39 e)
		{
			Class492 @class = Class492.smethod_0(e.Message);
			switch (@class.Action)
			{
			case Enum93.const_1:
				this.process_0 = Process.GetProcessById(@class.ProcessID);
				return;
			case Enum93.const_3:
				this.class148_0.method_5();
				this.method_4();
				this.process_0 = Process.GetProcessById(@class.ProcessID);
				this.method_7(@class.ExtraData[0]);
				if (!this.class148_0.Connected && this.eventHandler_4 != null)
				{
					this.eventHandler_4(this, new EventArgs38(new Class492(Enum28.const_0, this.UpdateStep, this.UpdaterExitedPrematurely_Title, "Failed to connect to the new version of wyUpdate.exe")));
				}
				this.method_18(new Class492(this.UpdateStep));
				return;
			}
			if (@class.UpdateStep != this.UpdateStep)
			{
				Enum87 updateStep = this.UpdateStep;
				this.UpdateStep = @class.UpdateStep;
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2(this, new EventArgs28(@class.ResponseType, updateStep));
				}
			}
			if (@class.Action == Enum93.const_0 && @class.UpdateStep == Enum87.const_4)
			{
				this.int_2 = @class.ProcessID;
			}
			if (@class.ResponseType != Enum28.const_1 && this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, new EventArgs38(@class));
			}
		}

		// Token: 0x0600182A RID: 6186 RVA: 0x00041468 File Offset: 0x0003F668
		private void method_7(string pipename)
		{
			int num = 0;
			while (!this.class148_0.Connected && num < 120)
			{
				this.class148_0.method_4(pipename);
				if (!this.class148_0.Connected)
				{
					if (this.process_0 == null || this.process_0.HasExited)
					{
						this.process_0 = null;
						break;
					}
					Thread.Sleep(250);
				}
				num++;
			}
			if (!this.class148_0.Connected && this.process_0 != null)
			{
				try
				{
					this.process_0.Kill();
				}
				catch
				{
				}
				this.process_0 = null;
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x0004150C File Offset: 0x0003F70C
		public static string smethod_0(string filename)
		{
			string text = filename.Replace("\\", "").ToLower();
			int length = text.Length;
			return "\\\\.\\pipe\\" + text.Substring(Math.Max(0, length - 246), Math.Min(246, length));
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00041560 File Offset: 0x0003F760
		private bool method_8(byte[] message)
		{
			int num = 0;
			bool flag;
			while ((flag = !this.class148_0.method_7(message)) && num < Class126.int_0 && this.class148_0.Connected)
			{
				Thread.Sleep(Class126.int_1);
				num++;
			}
			return !this.class148_0.Connected || !flag;
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x000415BC File Offset: 0x0003F7BC
		private bool method_9()
		{
			if (string.IsNullOrEmpty(this.string_6))
			{
				throw new Exception(Class126.string_5);
			}
			string pipename = Class126.smethod_0(this.string_6);
			if (!this.class148_0.Connected)
			{
				this.class148_0.method_4(pipename);
			}
			if (this.class148_0.Connected)
			{
				if (!this.method_8(new Class492(Enum93.const_1).method_0()))
				{
					throw new Exception(Class126.string_3);
				}
				return true;
			}
			else
			{
				if (!File.Exists(this.string_6))
				{
					throw new FileNotFoundException(Class126.string_2, this.string_6);
				}
				this.process_0 = new Process();
				this.process_0.StartInfo = new ProcessStartInfo(this.string_6, Class126.string_4);
				this.process_0.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				if (!string.IsNullOrEmpty(this.ExtraArguments))
				{
					ProcessStartInfo startInfo = this.process_0.StartInfo;
					startInfo.Arguments = startInfo.Arguments + " " + this.ExtraArguments;
				}
				this.process_0.Start();
				this.process_0.WaitForInputIdle(5000);
				this.method_7(pipename);
				return this.class148_0.Connected;
			}
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00007BDD File Offset: 0x00005DDD
		private void method_10()
		{
			this.task_0 = new Task(new Action(this.method_19));
			this.task_0.Start();
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00007C01 File Offset: 0x00005E01
		public void method_11()
		{
			this.method_18(new Class492(Enum87.const_1));
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00007C0F File Offset: 0x00005E0F
		public void method_12()
		{
			this.method_18(new Class492(Enum87.const_0));
		}

		// Token: 0x06001831 RID: 6193 RVA: 0x00007C1D File Offset: 0x00005E1D
		public void method_13()
		{
			this.method_18(new Class492(Enum87.const_2));
		}

		// Token: 0x06001832 RID: 6194 RVA: 0x00007C2B File Offset: 0x00005E2B
		public void method_14()
		{
			this.method_18(new Class492(Enum87.const_3));
		}

		// Token: 0x06001833 RID: 6195 RVA: 0x000416EC File Offset: 0x0003F8EC
		public void method_15(string fileToExecute, string autoUpdateID, string argumentsForFiles, bool isAService)
		{
			Class492 @class = new Class492(Enum87.const_4);
			@class.ExtraData.Add(fileToExecute);
			@class.ExtraDataIsRTF.Add(isAService);
			if (!string.IsNullOrEmpty(autoUpdateID))
			{
				@class.ExtraData.Add(autoUpdateID);
				@class.ExtraDataIsRTF.Add(false);
				if (!string.IsNullOrEmpty(argumentsForFiles))
				{
					@class.ExtraData.Add(argumentsForFiles);
					@class.ExtraDataIsRTF.Add(false);
				}
			}
			this.method_18(@class);
		}

		// Token: 0x06001834 RID: 6196 RVA: 0x00007C39 File Offset: 0x00005E39
		public void method_16()
		{
			Class265.ShowWindow(new HandleRef(this, new IntPtr(this.int_2)), Enum117.const_4);
			Class265.SetForegroundWindow_1(new IntPtr(this.int_2));
			this.method_18(new Class492(Enum87.const_5));
		}

		// Token: 0x06001835 RID: 6197 RVA: 0x00007C71 File Offset: 0x00005E71
		public void method_17()
		{
			this.method_18(new Class492(Enum93.const_2));
		}

		// Token: 0x06001836 RID: 6198 RVA: 0x00041760 File Offset: 0x0003F960
		private void method_18(Class492 uhd)
		{
			bool flag = false;
			Monitor.Enter(this.object_0, ref flag);
			this.stack_0.Push(uhd);
			if (this.task_0 == null)
			{
				this.UpdateStep = ((uhd.UpdateStep == Enum87.const_1) ? Enum87.const_0 : uhd.UpdateStep);
				this.method_10();
			}
			if (flag)
			{
				Monitor.Exit(this.object_0);
				flag = false;
			}
		}

		// Token: 0x06001837 RID: 6199 RVA: 0x000417C0 File Offset: 0x0003F9C0
		[CompilerGenerated]
		private void method_19()
		{
			WaitCallback waitCallback = null;
			bool flag = false;
			Monitor.Enter(this.object_0, ref flag);
			try
			{
				Class126.Class174 @class = new Class126.Class174();
				try
				{
					while (this.stack_0.Count > 0)
					{
						try
						{
							Class492 class2 = this.stack_0.Pop();
							if (flag)
							{
								Monitor.Exit(this.object_0);
								flag = false;
							}
							this.UpdateStep = class2.UpdateStep;
							if (this.process_0 == null && !this.method_9())
							{
								throw new Exception(Class126.string_1);
							}
							if (!this.method_8(class2.method_0()))
							{
								throw new Exception(Class126.string_0);
							}
							if (class2.Action == Enum93.const_2)
							{
								if (waitCallback == null)
								{
									waitCallback = new WaitCallback(this.method_20);
								}
								ThreadPool.UnsafeQueueUserWorkItem(waitCallback, null);
								break;
							}
						}
						finally
						{
							Monitor.Enter(this.object_0, ref flag);
						}
					}
				}
				catch (Exception ex)
				{
					ex.smethod_0();
					try
					{
						if (this.process_0 != null && !this.process_0.HasExited)
						{
							this.process_0.Kill();
						}
					}
					catch
					{
					}
					this.process_0 = null;
					this.stack_0.Clear();
					if (this.eventHandler_4 != null)
					{
						this.eventHandler_4(this, new EventArgs38(new Class492(Enum28.const_0, this.UpdateStep, this.UpdaterExitedPrematurely_Title, ex.Message)));
					}
				}
				@class.task_0 = Interlocked.Exchange<Task>(ref this.task_0, null);
				ThreadPool.UnsafeQueueUserWorkItem(new WaitCallback(@class.method_0), null);
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this.object_0);
					flag = false;
				}
			}
		}

		// Token: 0x06001838 RID: 6200 RVA: 0x00007C7F File Offset: 0x00005E7F
		[CompilerGenerated]
		private void method_20(object _)
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, EventArgs.Empty);
			}
		}

		// Token: 0x0400060A RID: 1546
		private static readonly string string_0 = "Failed to send message to pipe server";

		// Token: 0x0400060B RID: 1547
		private static readonly string string_1 = "Updater failed to start.";

		// Token: 0x0400060C RID: 1548
		private static readonly string string_2 = "The updater executable was not found.";

		// Token: 0x0400060D RID: 1549
		private static readonly string string_3 = "Failed to get the updater process ID.";

		// Token: 0x0400060E RID: 1550
		private static readonly string string_4 = "/autoupdate";

		// Token: 0x0400060F RID: 1551
		private static readonly int int_0 = 20;

		// Token: 0x04000610 RID: 1552
		private static readonly int int_1 = 250;

		// Token: 0x04000611 RID: 1553
		private static readonly string string_5 = "The updater executable path supplied is not valid. Make sure the updater exists on disk.";

		// Token: 0x04000612 RID: 1554
		private Task task_0;

		// Token: 0x04000613 RID: 1555
		private string string_6;

		// Token: 0x04000614 RID: 1556
		private string string_7 = "Update.exe";

		// Token: 0x04000615 RID: 1557
		private int int_2;

		// Token: 0x04000616 RID: 1558
		private Class148 class148_0;

		// Token: 0x04000617 RID: 1559
		private Process process_0;

		// Token: 0x04000618 RID: 1560
		private readonly object object_0 = new object();

		// Token: 0x04000619 RID: 1561
		private readonly Stack<Class492> stack_0 = new Stack<Class492>(2);

		// Token: 0x0400061A RID: 1562
		private EventHandler<EventArgs28> eventHandler_2;

		// Token: 0x0400061B RID: 1563
		private EventHandler<EventArgs38> eventHandler_3;

		// Token: 0x0400061C RID: 1564
		private EventHandler<EventArgs38> eventHandler_4;

		// Token: 0x0400061D RID: 1565
		private EventHandler eventHandler_5;

		// Token: 0x0400061E RID: 1566
		[CompilerGenerated]
		private Enum87 enum87_0;

		// Token: 0x0400061F RID: 1567
		[CompilerGenerated]
		private string string_8;

		// Token: 0x04000620 RID: 1568
		[CompilerGenerated]
		private string string_9;

		// Token: 0x04000621 RID: 1569
		[CompilerGenerated]
		private string string_10;

		// Token: 0x0200022F RID: 559
		[CompilerGenerated]
		private sealed class Class174
		{
			// Token: 0x0600183B RID: 6203 RVA: 0x00007C9A File Offset: 0x00005E9A
			public void method_0(object _)
			{
				this.task_0.Wait();
				this.task_0.Dispose();
			}

			// Token: 0x04000622 RID: 1570
			public Task task_0;
		}
	}
}
