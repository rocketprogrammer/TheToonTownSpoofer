using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;
using ns19;
using ns20;
using ns22;
using ns23;
using ns25;
using ns26;
using ns28;
using ns30;
using ns31;

namespace ns15
{
	// Token: 0x02000219 RID: 537
	internal partial class RunBaseForm : Form0
	{
		// Token: 0x14000174 RID: 372
		// (add) Token: 0x06001783 RID: 6019 RVA: 0x0003DB14 File Offset: 0x0003BD14
		// (remove) Token: 0x06001784 RID: 6020 RVA: 0x0003DB4C File Offset: 0x0003BD4C
		public event EventHandler OnStartRunning
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1700072A RID: 1834
		// (get) Token: 0x06001785 RID: 6021 RVA: 0x000073CD File Offset: 0x000055CD
		protected bool CanContinue
		{
			get
			{
				return !this.manualResetEventSlim_0.IsSet && this.class142_0.ToonTownProcess.ProcessOpen;
			}
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x000073EE File Offset: 0x000055EE
		private RunBaseForm()
		{
			this.InitializeComponent();
			base.FormClosing += this.RunBaseForm_FormClosing;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x0003DB84 File Offset: 0x0003BD84
		public RunBaseForm(IntPtr hWnd) : this()
		{
			Class335.smethod_3(RunBaseForm.string_0, new object[]
			{
				hWnd
			});
			this.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			this.intptr_0 = hWnd;
			this.class318_0.method_5(Keys.Escape, Keys.None, false);
			Size size = new Size(1024, 768);
			this.struct42_0 = Struct42.smethod_2(new Point(50, 720), new Point(size.Width, size.Height));
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0003DC10 File Offset: 0x0003BE10
		protected void method_1(DialogResult result = DialogResult.None)
		{
			RunBaseForm.Class160 @class = new RunBaseForm.Class160();
			@class.dialogResult_0 = result;
			@class.runBaseForm_0 = this;
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0003DC44 File Offset: 0x0003BE44
		protected void method_2(MethodInvoker del)
		{
			RunBaseForm.Class161 @class = new RunBaseForm.Class161();
			@class.methodInvoker_0 = del;
			@class.runBaseForm_0 = this;
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0003DC78 File Offset: 0x0003BE78
		protected T method_3<T>(Func<T> del)
		{
			RunBaseForm.Class162<T> @class = new RunBaseForm.Class162<T>();
			@class.func_0 = del;
			@class.runBaseForm_0 = this;
			return this.smethod_5(new Func<T>(@class.method_0));
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x0000740E File Offset: 0x0000560E
		protected bool method_4(int milliseconds)
		{
			this.manualResetEventSlim_0.Wait(milliseconds);
			return !this.manualResetEventSlim_0.IsSet;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x0000742B File Offset: 0x0000562B
		private void StopButton_Click(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0000742B File Offset: 0x0000562B
		private void method_5(object sender, EventArgs18 e)
		{
			this.method_6();
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x00007433 File Offset: 0x00005633
		protected override void vmethod_1(EventArgs19 e)
		{
			e.Cancel = true;
			e.CancelReason = RunBaseForm.string_5;
			this.method_6();
			base.vmethod_1(e);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0003DCAC File Offset: 0x0003BEAC
		private void RunBaseForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			CloseReason closeReason = e.CloseReason;
			if (closeReason != CloseReason.WindowsShutDown && !this.bool_5)
			{
				e.Cancel = true;
				this.method_6();
			}
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00007454 File Offset: 0x00005654
		private void method_6()
		{
			this.smethod_4(new MethodInvoker(this.method_22));
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00007468 File Offset: 0x00005668
		protected void method_7()
		{
			Class410.smethod_8(this, this.intptr_0);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0003DCDC File Offset: 0x0003BEDC
		private void RunBaseForm_Load(object sender, EventArgs e)
		{
			if (!base.DesignMode)
			{
				if (!Class142.smethod_2(this.intptr_0, out this.class142_0))
				{
					this.class142_0 = Class142.smethod_9(this.intptr_0, Enum101.const_0, null);
					if (!this.class142_0.method_5())
					{
						base.Hide();
						DialogBox.smethod_4(RunBaseForm.string_1, RunBaseForm.string_2);
						this.bool_5 = true;
						base.DialogResult = DialogResult.Abort;
						base.Close();
						return;
					}
				}
				if (this.class142_0.Playground == Enum57.const_0)
				{
					base.Hide();
					DialogBox.smethod_3(RunBaseForm.string_3, RunBaseForm.string_4);
					this.bool_5 = true;
					base.DialogResult = DialogResult.Abort;
					base.Close();
					return;
				}
				this.class149_0 = new Class149(this.class142_0);
				this.method_8();
				this.timer_0.Enabled = true;
				if (this.eventHandler_0 != null)
				{
					this.eventHandler_0(this, EventArgs.Empty);
				}
			}
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x00007476 File Offset: 0x00005676
		private void timer_0_Tick(object sender, EventArgs e)
		{
			if (!base.DesignMode)
			{
				this.method_8();
			}
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x0003DDC4 File Offset: 0x0003BFC4
		private void method_8()
		{
			if (this.class142_0.ToonTownProcess.ProcessOpen)
			{
				Point point;
				try
				{
					Rectangle rec = Class410.smethod_16(this.intptr_0);
					point = new Point(rec.smethod_10() - base.Width / 2, rec.Bottom - base.Height);
				}
				catch (Win32Exception)
				{
					return;
				}
				if (base.Location != point)
				{
					base.Location = point;
				}
			}
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00007486 File Offset: 0x00005686
		protected void method_9()
		{
			if (!this.method_4(250))
			{
				return;
			}
			this.method_10(this.struct42_0);
			this.method_4(250);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0003DE3C File Offset: 0x0003C03C
		protected void method_10(Struct42 pnt)
		{
			Rectangle window_bounds = Class410.smethod_16(this.intptr_0);
			this.method_13(window_bounds, pnt.method_0(new Point(window_bounds.Width, window_bounds.Height)));
		}

		// Token: 0x06001797 RID: 6039 RVA: 0x000074AE File Offset: 0x000056AE
		protected void method_11(Struct46 bounds)
		{
			this.method_12(Class410.smethod_16(this.intptr_0), bounds);
		}

		// Token: 0x06001798 RID: 6040 RVA: 0x000074C2 File Offset: 0x000056C2
		protected void method_12(Rectangle window_bounds, Struct46 bounds)
		{
			this.method_13(window_bounds, bounds.method_0(window_bounds.Size).smethod_9());
		}

		// Token: 0x06001799 RID: 6041 RVA: 0x000074DE File Offset: 0x000056DE
		protected void method_13(Rectangle window_bounds, Point p)
		{
			Class465.smethod_5(window_bounds, p);
		}

		// Token: 0x0600179A RID: 6042 RVA: 0x000074E7 File Offset: 0x000056E7
		protected void method_14(Point p)
		{
			this.method_13(Class410.smethod_16(this.intptr_0), p);
		}

		// Token: 0x0600179B RID: 6043 RVA: 0x000074FB File Offset: 0x000056FB
		protected void method_15(Rectangle window_bounds, Rectangle bounds)
		{
			this.method_13(window_bounds, bounds.smethod_9());
		}

		// Token: 0x0600179C RID: 6044 RVA: 0x0000750A File Offset: 0x0000570A
		protected void method_16(Point p, Class104 settings)
		{
			this.method_7();
			this.method_14(p);
			this.manualResetEventSlim_0.Wait(settings.AfterMoveBeforeClickDelay);
			this.method_18(settings);
		}

		// Token: 0x0600179D RID: 6045 RVA: 0x00007532 File Offset: 0x00005732
		protected void method_17(Struct46 bounds, Class104 settings)
		{
			this.method_7();
			this.method_11(bounds);
			this.manualResetEventSlim_0.Wait(settings.AfterMoveBeforeClickDelay);
			this.method_18(settings);
		}

		// Token: 0x0600179E RID: 6046 RVA: 0x0000755A File Offset: 0x0000575A
		protected void method_18(Class104 settings)
		{
			Class465.smethod_8(MouseButtons.Left, settings.ButtonClickDelay, this.manualResetEventSlim_0);
		}

		// Token: 0x0600179F RID: 6047 RVA: 0x0003DE78 File Offset: 0x0003C078
		protected Enum107 method_19(int interval, int timeout, Class150 original_capture, Struct46 bounds, Class104 settings)
		{
			RunBaseForm.Class163 @class = new RunBaseForm.Class163();
			@class.int_0 = timeout;
			Action action = null;
			RunBaseForm.Class164 class2 = new RunBaseForm.Class164();
			class2.class163_0 = @class;
			class2.manualResetEventSlim_0 = new ManualResetEventSlim(false);
			Enum107 result;
			try
			{
				if (action == null)
				{
					action = new Action(class2.method_0);
				}
				using (Task task = new Task(action))
				{
					try
					{
						task.Start();
						result = this.method_20(interval, original_capture, bounds, settings, class2.manualResetEventSlim_0);
					}
					finally
					{
						class2.manualResetEventSlim_0.Set();
						task.Wait();
					}
				}
			}
			finally
			{
				if (class2.manualResetEventSlim_0 != null)
				{
					((IDisposable)class2.manualResetEventSlim_0).Dispose();
				}
			}
			return result;
		}

		// Token: 0x060017A0 RID: 6048 RVA: 0x0003DF3C File Offset: 0x0003C13C
		protected Enum107 method_20(int interval, Class150 original_capture, Struct46 bounds, Class104 settings, ManualResetEventSlim waitHandle = null)
		{
			while (!this.manualResetEventSlim_0.IsSet && (waitHandle == null || !waitHandle.IsSet))
			{
				this.method_7();
				switch (Class433.smethod_0(this.class142_0.ToonTownProcess, original_capture, bounds, settings))
				{
				case Enum107.const_0:
					return Enum107.const_0;
				case Enum107.const_1:
					if (waitHandle == null)
					{
						this.manualResetEventSlim_0.Wait(interval);
					}
					else
					{
						WaitHandle.WaitAny(new WaitHandle[]
						{
							this.manualResetEventSlim_0.WaitHandle,
							waitHandle.WaitHandle
						}, interval);
					}
					break;
				case Enum107.const_2:
					return Enum107.const_2;
				}
			}
			return Enum107.const_1;
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0003DFE0 File Offset: 0x0003C1E0
		protected unsafe bool method_21(ManualResetEventSlim waitHandle = null)
		{
			int num = 0;
			do
			{
				Size size = new Size(20, 20);
				using (Bitmap bitmap = Class364.smethod_3(this.intptr_0, new Rectangle(Point.Empty, size)))
				{
					using (Class125 @class = new Class125(bitmap, false))
					{
						using (new Class125.Class153(@class))
						{
							Struct33* ptr = @class.pBase;
							Struct33 right = new Struct33(0, 0, 0, byte.MaxValue);
							for (int i = 0; i < base.Size.Height; i++)
							{
								for (int j = 0; j < base.Size.Width; j++)
								{
									if (Struct33.smethod_4(*ptr, right))
									{
										return true;
									}
									ptr++;
								}
							}
						}
					}
				}
				if (waitHandle != null)
				{
					waitHandle.Wait(100);
				}
				else
				{
					Thread.Sleep(100);
				}
				num++;
			}
			while (num < 100 && (waitHandle == null || !waitHandle.IsSet));
			return false;
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x00007572 File Offset: 0x00005772
		[CompilerGenerated]
		private void method_22()
		{
			this.manualResetEventSlim_0.Set();
			this.class318_0.method_11(Keys.Escape, Keys.None);
			base.EnableCloseButton = false;
		}

		// Token: 0x040005AE RID: 1454
		private static readonly string string_0 = "Run Base Initializing";

		// Token: 0x040005AF RID: 1455
		private static readonly string string_1 = "The ToonTown Spoofer was unable to access ToonTown's coordinate system. Try running The ToonTown Spoofer with administrative privileges.";

		// Token: 0x040005B0 RID: 1456
		private static readonly string string_2 = "Error Accessing Coordinates";

		// Token: 0x040005B1 RID: 1457
		private static readonly string string_3 = "Your toon does not appear to be in a valid playground.";

		// Token: 0x040005B2 RID: 1458
		private static readonly string string_4 = "Invalid Playground";

		// Token: 0x040005B3 RID: 1459
		private static readonly string string_5 = "One moment, shutting down...";

		// Token: 0x040005B4 RID: 1460
		protected Class142 class142_0;

		// Token: 0x040005B6 RID: 1462
		protected readonly IntPtr intptr_0;

		// Token: 0x040005B8 RID: 1464
		private EventHandler eventHandler_0;

		// Token: 0x040005B9 RID: 1465
		protected readonly Struct42 struct42_0;

		// Token: 0x040005BA RID: 1466
		private bool bool_5;

		// Token: 0x0200021A RID: 538
		[CompilerGenerated]
		private sealed class Class160
		{
			// Token: 0x060017A7 RID: 6055 RVA: 0x000075D3 File Offset: 0x000057D3
			public void method_0()
			{
				if (this.dialogResult_0 != DialogResult.None)
				{
					this.runBaseForm_0.DialogResult = this.dialogResult_0;
				}
				this.runBaseForm_0.bool_5 = true;
				this.runBaseForm_0.Close();
			}

			// Token: 0x040005BF RID: 1471
			public RunBaseForm runBaseForm_0;

			// Token: 0x040005C0 RID: 1472
			public DialogResult dialogResult_0;
		}

		// Token: 0x0200021B RID: 539
		[CompilerGenerated]
		private sealed class Class161
		{
			// Token: 0x060017A9 RID: 6057 RVA: 0x0003E328 File Offset: 0x0003C528
			public void method_0()
			{
				using (new Struct38(this.runBaseForm_0))
				{
					this.methodInvoker_0();
				}
			}

			// Token: 0x040005C1 RID: 1473
			public RunBaseForm runBaseForm_0;

			// Token: 0x040005C2 RID: 1474
			public MethodInvoker methodInvoker_0;
		}

		// Token: 0x0200021C RID: 540
		[CompilerGenerated]
		private sealed class Class162<T>
		{
			// Token: 0x060017AB RID: 6059 RVA: 0x0003E370 File Offset: 0x0003C570
			public T method_0()
			{
				T result;
				using (new Struct38(this.runBaseForm_0))
				{
					result = this.func_0();
				}
				return result;
			}

			// Token: 0x040005C3 RID: 1475
			public RunBaseForm runBaseForm_0;

			// Token: 0x040005C4 RID: 1476
			public Func<T> func_0;
		}

		// Token: 0x0200021D RID: 541
		[CompilerGenerated]
		private sealed class Class163
		{
			// Token: 0x040005C5 RID: 1477
			public int int_0;
		}

		// Token: 0x0200021E RID: 542
		[CompilerGenerated]
		private sealed class Class164
		{
			// Token: 0x060017AE RID: 6062 RVA: 0x00007605 File Offset: 0x00005805
			public void method_0()
			{
				this.manualResetEventSlim_0.Wait(this.class163_0.int_0);
				this.manualResetEventSlim_0.Set();
			}

			// Token: 0x040005C6 RID: 1478
			public RunBaseForm.Class163 class163_0;

			// Token: 0x040005C7 RID: 1479
			public ManualResetEventSlim manualResetEventSlim_0;
		}
	}
}
