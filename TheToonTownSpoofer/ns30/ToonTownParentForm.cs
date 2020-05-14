using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns16;
using ns17;
using ns19;
using ns20;
using ns21;
using ns22;
using ns23;
using ns26;
using ns27;
using ns29;
using ns31;

namespace ns30
{
	// Token: 0x020001E3 RID: 483
	internal sealed partial class ToonTownParentForm : Form
	{
		// Token: 0x06001613 RID: 5651 RVA: 0x0003519C File Offset: 0x0003339C
		public static bool smethod_0(Class141 process)
		{
			Process[] array = Class156.smethod_3("toontown");
			bool result;
			try
			{
				if (array.Length != 1)
				{
					result = false;
				}
				else
				{
					int id = array[0].Id;
					IntPtr intPtr = array[0].smethod_0();
					if (!ToonTownParentForm.hashSet_0.Contains(id) && !(intPtr == IntPtr.Zero))
					{
						process.MainWindowHandle = intPtr;
						result = true;
					}
					else
					{
						result = false;
					}
				}
			}
			finally
			{
				array.smethod_1<Process>();
			}
			return result;
		}

		// Token: 0x06001614 RID: 5652 RVA: 0x000063C1 File Offset: 0x000045C1
		public static bool smethod_1(Class141 process, Form owner)
		{
			return ToonTownParentForm.smethod_0(process) || process.smethod_2(owner, null);
		}

		// Token: 0x06001615 RID: 5653 RVA: 0x00035214 File Offset: 0x00033414
		public static ToonTownParentForm smethod_2(Form parent)
		{
			ToonTownParentForm.Class115 @class = new ToonTownParentForm.Class115();
			@class.form_0 = parent;
			@class.class141_0 = new Class141();
			if (ToonTownParentForm.smethod_1(@class.class141_0, @class.form_0))
			{
				Func<bool> func = null;
				ToonTownParentForm.Class116 class2 = new ToonTownParentForm.Class116();
				class2.class115_0 = @class;
				class2.intptr_0 = @class.class141_0.MainWindowHandle;
				Enum79 @enum = (Enum79)Class265.smethod_2(class2.intptr_0, Enum55.const_3);
				if (@enum.HasFlag(Enum79.flag_19) && @enum.HasFlag(Enum79.flag_14) && @enum.HasFlag(Enum79.flag_9))
				{
					ToonTownParentForm.Class117 class3 = new ToonTownParentForm.Class117();
					class3.class116_0 = class2;
					class3.class115_0 = @class;
					class3.int_0 = @class.class141_0.Process.Id;
					ToonTownParentForm.hashSet_0.Add(class3.int_0);
					Rectangle bounds;
					FormWindowState formWindowState = Class410.smethod_22(new HandleRef(@class.form_0, class2.intptr_0), out bounds);
					@enum &= ~(Enum79.flag_9 | Enum79.flag_10);
					@enum &= ~Enum79.flag_14;
					@enum |= Enum79.flag_2;
					@enum &= ~Enum79.flag_1;
					@enum &= ~Enum79.flag_9;
					Class265.smethod_4(class2.intptr_0, Enum55.const_3, (int)@enum);
					IntPtr handle = Class265.smethod_3(new HandleRef(@class.form_0, class2.intptr_0), Enum104.const_5);
					Icon icon = Icon.FromHandle(handle);
					class3.toonTownParentForm_0 = new ToonTownParentForm();
					class3.toonTownParentForm_0.Icon = icon;
					ToonTownParentForm.Class117 class4 = class3;
					if (func == null)
					{
						func = new Func<bool>(class2.method_0);
					}
					class4.func_0 = func;
					class3.func_1 = new Func<bool>(class3.method_0);
					class3.action_0 = new Action(class3.method_1);
					class3.action_1 = new Action<Action>(class3.method_2);
					class3.action_2 = new Action(class3.method_3);
					class3.action_3 = new Action(class3.method_4);
					class3.action_4 = new Action(class3.method_5);
					class3.action_5 = new Action(class3.method_6);
					class3.action_6 = new Action(class3.method_7);
					class3.action_7 = new Action(class3.method_8);
					class3.action_8 = new Action<IntPtr?, Rectangle>(class3.method_9);
					class3.action_9 = new Action<IntPtr?, Rectangle>(class3.method_10);
					class3.toonTownParentForm_0.OnResizeStarted += class3.method_11;
					class3.toonTownParentForm_0.OnResizeEnded += class3.method_12;
					class3.toonTownParentForm_0.GotFocus += class3.method_13;
					class3.toonTownParentForm_0.WindowStateChanged += class3.method_14;
					@class.class141_0.ProcessExited += class3.method_15;
					if (formWindowState.HasFlag(FormWindowState.Maximized))
					{
						if (formWindowState.HasFlag(FormWindowState.Minimized))
						{
							Class410.smethod_23(new HandleRef(@class.form_0, class2.intptr_0), FormWindowState.Minimized, null);
						}
						else
						{
							Class410.smethod_23(new HandleRef(@class.form_0, class2.intptr_0), FormWindowState.Normal, null);
						}
					}
					class3.intptr_0 = Class265.SetParent(class2.intptr_0, class3.toonTownParentForm_0.Handle);
					class3.toonTownParentForm_0.StartPosition = FormStartPosition.Manual;
					class3.toonTownParentForm_0.Bounds = bounds;
					class3.action_9(new IntPtr?(class3.toonTownParentForm_0.Handle), class3.toonTownParentForm_0.ClientRectangle);
					Class410.smethod_23(new HandleRef(@class.form_0, class3.toonTownParentForm_0.Handle), formWindowState, null);
					class3.toonTownParentForm_0.FormClosing += class3.method_16;
					class3.toonTownParentForm_0.OnCloseClicked += class3.method_17;
					class3.toonTownParentForm_0.timer_0.Tick += class3.method_18;
					class3.toonTownParentForm_0.Shown += class3.method_19;
					class3.toonTownParentForm_0.Show();
					return class3.toonTownParentForm_0;
				}
				DialogBox.smethod_3("The ToonTown window appears to be full screen and cannot be used. Please change ToonTown to window mode and try again.", "Invalid ToonTown Window");
			}
			else
			{
				@class.class141_0.Dispose();
			}
			return null;
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000063D5 File Offset: 0x000045D5
		public ToonTownParentForm()
		{
			this.InitializeComponent();
			this.formWindowState_0 = FormWindowState.Normal;
		}

		// Token: 0x1400016D RID: 365
		// (add) Token: 0x06001617 RID: 5655 RVA: 0x000356B4 File Offset: 0x000338B4
		// (remove) Token: 0x06001618 RID: 5656 RVA: 0x000356EC File Offset: 0x000338EC
		public event EventHandler OnResizeStarted
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

		// Token: 0x1400016E RID: 366
		// (add) Token: 0x06001619 RID: 5657 RVA: 0x00035724 File Offset: 0x00033924
		// (remove) Token: 0x0600161A RID: 5658 RVA: 0x0003575C File Offset: 0x0003395C
		public event EventHandler OnResizeEnded
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400016F RID: 367
		// (add) Token: 0x0600161B RID: 5659 RVA: 0x00035794 File Offset: 0x00033994
		// (remove) Token: 0x0600161C RID: 5660 RVA: 0x000357CC File Offset: 0x000339CC
		public event EventHandler WindowStateChanged
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_2;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000170 RID: 368
		// (add) Token: 0x0600161D RID: 5661 RVA: 0x00035804 File Offset: 0x00033A04
		// (remove) Token: 0x0600161E RID: 5662 RVA: 0x0003583C File Offset: 0x00033A3C
		public event EventHandler OnCloseClicked
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_3;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000063EA File Offset: 0x000045EA
		protected override void OnSizeChanged(EventArgs e)
		{
			if (base.WindowState != this.formWindowState_0)
			{
				this.formWindowState_0 = base.WindowState;
				if (this.eventHandler_2 != null)
				{
					this.eventHandler_2(this, EventArgs.Empty);
				}
			}
			base.OnSizeChanged(e);
		}

		// Token: 0x06001620 RID: 5664 RVA: 0x00035874 File Offset: 0x00033A74
		protected override void WndProc(ref Message m)
		{
			Enum16 msg = (Enum16)m.Msg;
			if (msg <= Enum16.const_103)
			{
				switch (msg)
				{
				case Enum16.const_5:
				{
					uint num = (uint)((int)m.WParam);
					if (num == 0U)
					{
						this.OnLostFocus(EventArgs.Empty);
					}
					break;
				}
				case Enum16.const_6:
					break;
				case Enum16.const_7:
					if (this.bool_1)
					{
						return;
					}
					break;
				default:
					if (msg == Enum16.const_103)
					{
						Enum71 @enum = (Enum71)((int)m.WParam);
						if (@enum == Enum71.const_0 && this.eventHandler_3 != null)
						{
							this.eventHandler_3(this, EventArgs.Empty);
							return;
						}
					}
					break;
				}
			}
			else if (msg != Enum16.const_139)
			{
				if (msg == Enum16.const_155)
				{
					if (this.bool_0 && this.eventHandler_1 != null)
					{
						this.eventHandler_1(this, EventArgs.Empty);
					}
				}
			}
			else if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
				this.bool_0 = true;
			}
			base.WndProc(ref m);
		}

		// Token: 0x04000369 RID: 873
		private static HashSet<int> hashSet_0 = new HashSet<int>();

		// Token: 0x0400036A RID: 874
		private EventHandler eventHandler_0;

		// Token: 0x0400036B RID: 875
		private EventHandler eventHandler_1;

		// Token: 0x0400036C RID: 876
		private EventHandler eventHandler_2;

		// Token: 0x0400036D RID: 877
		private EventHandler eventHandler_3;

		// Token: 0x0400036E RID: 878
		private FormWindowState formWindowState_0;

		// Token: 0x0400036F RID: 879
		private bool bool_0;

		// Token: 0x04000370 RID: 880
		private bool bool_1;

		// Token: 0x020001E4 RID: 484
		[CompilerGenerated]
		private sealed class Class115
		{
			// Token: 0x04000371 RID: 881
			public Class141 class141_0;

			// Token: 0x04000372 RID: 882
			public Form form_0;
		}

		// Token: 0x020001E5 RID: 485
		[CompilerGenerated]
		private sealed class Class116
		{
			// Token: 0x06001624 RID: 5668 RVA: 0x00006432 File Offset: 0x00004632
			public bool method_0()
			{
				return this.class115_0.class141_0.ProcessOpen && Class265.IsWindow(this.intptr_0);
			}

			// Token: 0x04000373 RID: 883
			public ToonTownParentForm.Class115 class115_0;

			// Token: 0x04000374 RID: 884
			public IntPtr intptr_0;
		}

		// Token: 0x020001E6 RID: 486
		[CompilerGenerated]
		private sealed class Class117
		{
			// Token: 0x06001626 RID: 5670 RVA: 0x00006453 File Offset: 0x00004653
			public bool method_0()
			{
				return this.func_0() && Class265.GetParent(this.class116_0.intptr_0) == this.toonTownParentForm_0.Handle;
			}

			// Token: 0x06001627 RID: 5671 RVA: 0x00035968 File Offset: 0x00033B68
			public void method_1()
			{
				if (this.class115_0.class141_0.ProcessOpen)
				{
					int processId = Class265.GetProcessId(this.class115_0.class141_0.Process.Handle);
					if (processId != 0 && this.int_0 == processId)
					{
						using (Process processById = Process.GetProcessById(processId))
						{
							Class410.smethod_8(this.toonTownParentForm_0, processById.MainWindowHandle);
						}
					}
				}
			}

			// Token: 0x06001628 RID: 5672 RVA: 0x000359E4 File Offset: 0x00033BE4
			public void method_2(Action del)
			{
				try
				{
					del();
				}
				catch (Win32Exception ex)
				{
					ex.smethod_0();
					if (!this.func_1())
					{
						this.toonTownParentForm_0.timer_0.Enabled = false;
						this.action_0();
						this.toonTownParentForm_0.Close();
					}
				}
			}

			// Token: 0x06001629 RID: 5673 RVA: 0x00035A48 File Offset: 0x00033C48
			public void method_3()
			{
				if (this.func_0())
				{
					Class410.smethod_23(new HandleRef(this.class115_0.form_0, this.class116_0.intptr_0), FormWindowState.Minimized, null);
				}
			}

			// Token: 0x0600162A RID: 5674 RVA: 0x00035A8C File Offset: 0x00033C8C
			public void method_4()
			{
				if (this.func_0())
				{
					Class410.smethod_23(new HandleRef(this.class115_0.form_0, this.class116_0.intptr_0), FormWindowState.Normal, null);
				}
			}

			// Token: 0x0600162B RID: 5675 RVA: 0x00006484 File Offset: 0x00004684
			public void method_5()
			{
				if (this.func_0())
				{
					Class265.ShowWindow(new HandleRef(this.class115_0.form_0, this.class116_0.intptr_0), Enum117.const_1);
				}
			}

			// Token: 0x0600162C RID: 5676 RVA: 0x000064B5 File Offset: 0x000046B5
			public void method_6()
			{
				if (this.func_0())
				{
					Class265.ShowWindow(new HandleRef(this.class115_0.form_0, this.class116_0.intptr_0), Enum117.const_5);
				}
			}

			// Token: 0x0600162D RID: 5677 RVA: 0x000064E6 File Offset: 0x000046E6
			public void method_7()
			{
				if (this.func_0())
				{
					Class265.SendMessage(this.class116_0.intptr_0, Enum16.const_154, IntPtr.Zero, IntPtr.Zero);
				}
			}

			// Token: 0x0600162E RID: 5678 RVA: 0x00006515 File Offset: 0x00004715
			public void method_8()
			{
				if (this.func_0())
				{
					Class265.SendMessage(this.class116_0.intptr_0, Enum16.const_155, IntPtr.Zero, IntPtr.Zero);
				}
			}

			// Token: 0x0600162F RID: 5679 RVA: 0x00035AD0 File Offset: 0x00033CD0
			public void method_9(IntPtr? parenthWnd, Rectangle targetRect)
			{
				ToonTownParentForm.Class117.Class118 @class = new ToonTownParentForm.Class117.Class118();
				@class.class117_0 = this;
				@class.class116_0 = this.class116_0;
				@class.class115_0 = this.class115_0;
				@class.nullable_0 = parenthWnd;
				@class.rectangle_0 = targetRect;
				this.action_1(new Action(@class.method_0));
			}

			// Token: 0x06001630 RID: 5680 RVA: 0x00035B28 File Offset: 0x00033D28
			public void method_10(IntPtr? parenthWnd, Rectangle targetRect)
			{
				ToonTownParentForm.Class117.Class119 @class = new ToonTownParentForm.Class117.Class119();
				@class.class117_0 = this;
				@class.class116_0 = this.class116_0;
				@class.class115_0 = this.class115_0;
				@class.nullable_0 = parenthWnd;
				@class.rectangle_0 = targetRect;
				this.action_1(new Action(@class.method_0));
			}

			// Token: 0x06001631 RID: 5681 RVA: 0x00006544 File Offset: 0x00004744
			public void method_11(object sender, EventArgs e)
			{
				this.toonTownParentForm_0.timer_0.Enabled = false;
				if (this.toonTownParentForm_0.WindowState != FormWindowState.Minimized)
				{
					this.action_4();
					this.action_6();
				}
			}

			// Token: 0x06001632 RID: 5682 RVA: 0x00035B80 File Offset: 0x00033D80
			public void method_12(object sender, EventArgs e)
			{
				if (this.toonTownParentForm_0.WindowState != FormWindowState.Minimized)
				{
					this.action_8(new IntPtr?(this.toonTownParentForm_0.Handle), this.toonTownParentForm_0.ClientRectangle);
					this.action_7();
					this.action_5();
				}
				this.toonTownParentForm_0.timer_0.Enabled = true;
			}

			// Token: 0x06001633 RID: 5683 RVA: 0x0000657B File Offset: 0x0000477B
			public void method_13(object sender, EventArgs e)
			{
				if (this.func_1())
				{
					this.toonTownParentForm_0.bool_1 = true;
					Class265.SendMessage_3(this.class115_0.class141_0.MainWindowHandle, Enum16.const_5, 1, 0);
				}
			}

			// Token: 0x06001634 RID: 5684 RVA: 0x00035BE8 File Offset: 0x00033DE8
			public void method_14(object sender, EventArgs e)
			{
				Console.WriteLine("form WindowStateChanged");
				switch (this.toonTownParentForm_0.WindowState)
				{
				case FormWindowState.Normal:
				case FormWindowState.Maximized:
					this.action_4();
					this.action_3();
					this.action_6();
					this.action_8(new IntPtr?(this.toonTownParentForm_0.Handle), this.toonTownParentForm_0.ClientRectangle);
					this.action_7();
					this.action_5();
					return;
				case FormWindowState.Minimized:
					this.action_4();
					this.action_2();
					this.action_5();
					return;
				default:
					return;
				}
			}

			// Token: 0x06001635 RID: 5685 RVA: 0x000065AF File Offset: 0x000047AF
			public void method_15(object sender, EventArgs e)
			{
				this.toonTownParentForm_0.smethod_4(new MethodInvoker(this.method_20));
			}

			// Token: 0x06001636 RID: 5686 RVA: 0x00035CA0 File Offset: 0x00033EA0
			public void method_16(object sender, FormClosingEventArgs e)
			{
				this.toonTownParentForm_0.timer_0.Enabled = false;
				if (this.func_1())
				{
					this.action_4();
					Class265.SetParent(this.class116_0.intptr_0, this.intptr_0);
					Enum79 @enum = (Enum79)Class265.smethod_2(this.class116_0.intptr_0, Enum55.const_3);
					@enum &= ~Enum79.flag_2;
					@enum |= (Enum79)2147483648U;
					@enum |= Enum79.flag_19;
					@enum |= Enum79.flag_14;
					@enum |= Enum79.flag_9;
					Class265.smethod_4(this.class116_0.intptr_0, Enum55.const_3, (int)@enum);
					Rectangle rectangle;
					FormWindowState formWindowState = Class410.smethod_22(new HandleRef(this.toonTownParentForm_0, this.toonTownParentForm_0.Handle), out rectangle);
					if (formWindowState.HasFlag(FormWindowState.Minimized))
					{
						Class410.smethod_23(new HandleRef(this.toonTownParentForm_0, this.class116_0.intptr_0), formWindowState, new Rectangle?(rectangle));
					}
					else
					{
						this.action_6();
						this.action_8(null, rectangle);
						this.action_7();
						Class410.smethod_23(new HandleRef(this.toonTownParentForm_0, this.class116_0.intptr_0), formWindowState, null);
					}
					this.action_5();
				}
				this.class115_0.class141_0.Dispose();
				this.toonTownParentForm_0.Dispose();
				this.class115_0.form_0.Close();
				ToonTownParentForm.hashSet_0.Remove(this.int_0);
			}

			// Token: 0x06001637 RID: 5687 RVA: 0x000065C8 File Offset: 0x000047C8
			public void method_17(object sender, EventArgs e)
			{
				this.toonTownParentForm_0.Close();
			}

			// Token: 0x06001638 RID: 5688 RVA: 0x000065D5 File Offset: 0x000047D5
			public void method_18(object sender, EventArgs e)
			{
				this.action_1(new Action(this.method_21));
			}

			// Token: 0x06001639 RID: 5689 RVA: 0x000065EE File Offset: 0x000047EE
			public void method_19(object sender, EventArgs e)
			{
				this.toonTownParentForm_0.timer_0.Enabled = true;
			}

			// Token: 0x0600163A RID: 5690 RVA: 0x00006601 File Offset: 0x00004801
			public void method_20()
			{
				if (!this.toonTownParentForm_0.IsDisposed)
				{
					this.toonTownParentForm_0.Close();
				}
			}

			// Token: 0x0600163B RID: 5691 RVA: 0x00035E2C File Offset: 0x0003402C
			public void method_21()
			{
				if (this.func_1())
				{
					if (this.toonTownParentForm_0.WindowState != FormWindowState.Minimized)
					{
						Rectangle left = Class410.smethod_15(this.class116_0.intptr_0, this.toonTownParentForm_0.Handle);
						if (left != this.toonTownParentForm_0.ClientRectangle)
						{
							this.action_9(new IntPtr?(this.toonTownParentForm_0.Handle), this.toonTownParentForm_0.ClientRectangle);
							return;
						}
					}
				}
				else
				{
					this.action_0();
					this.toonTownParentForm_0.Close();
				}
			}

			// Token: 0x04000375 RID: 885
			public ToonTownParentForm.Class116 class116_0;

			// Token: 0x04000376 RID: 886
			public ToonTownParentForm.Class115 class115_0;

			// Token: 0x04000377 RID: 887
			public int int_0;

			// Token: 0x04000378 RID: 888
			public ToonTownParentForm toonTownParentForm_0;

			// Token: 0x04000379 RID: 889
			public Func<bool> func_0;

			// Token: 0x0400037A RID: 890
			public Func<bool> func_1;

			// Token: 0x0400037B RID: 891
			public Action action_0;

			// Token: 0x0400037C RID: 892
			public Action<Action> action_1;

			// Token: 0x0400037D RID: 893
			public Action action_2;

			// Token: 0x0400037E RID: 894
			public Action action_3;

			// Token: 0x0400037F RID: 895
			public Action action_4;

			// Token: 0x04000380 RID: 896
			public Action action_5;

			// Token: 0x04000381 RID: 897
			public Action action_6;

			// Token: 0x04000382 RID: 898
			public Action action_7;

			// Token: 0x04000383 RID: 899
			public Action<IntPtr?, Rectangle> action_8;

			// Token: 0x04000384 RID: 900
			public Action<IntPtr?, Rectangle> action_9;

			// Token: 0x04000385 RID: 901
			public IntPtr intptr_0;

			// Token: 0x020001E7 RID: 487
			private sealed class Class118
			{
				// Token: 0x0600163D RID: 5693 RVA: 0x00035EC0 File Offset: 0x000340C0
				public void method_0()
				{
					Rectangle rectangle;
					if (this.nullable_0 != null && this.class117_0.func_1())
					{
						rectangle = Class410.smethod_15(this.class116_0.intptr_0, this.nullable_0.Value);
					}
					else
					{
						if (!this.class117_0.func_0())
						{
							return;
						}
						rectangle = Class410.smethod_14(this.class116_0.intptr_0);
					}
					bool flag = rectangle.Size != this.rectangle_0.Size;
					bool flag2 = rectangle.Location != this.rectangle_0.Location;
					if (flag)
					{
						if (flag2)
						{
							if (!Class265.SetWindowPos(this.class116_0.intptr_0, Class265.intptr_3, this.rectangle_0.X, this.rectangle_0.Y, this.rectangle_0.Width, this.rectangle_0.Height, (Enum31)0U))
							{
								throw new Win32Exception();
							}
						}
						else if (!Class265.SetWindowPos(this.class116_0.intptr_0, Class265.intptr_3, 0, 0, this.rectangle_0.Width, this.rectangle_0.Height, Enum31.flag_7))
						{
							throw new Win32Exception();
						}
					}
					else if (flag2 && !Class265.SetWindowPos(this.class116_0.intptr_0, Class265.intptr_3, this.rectangle_0.X, this.rectangle_0.Y, 0, 0, Enum31.flag_12))
					{
						throw new Win32Exception();
					}
				}

				// Token: 0x04000386 RID: 902
				public ToonTownParentForm.Class117 class117_0;

				// Token: 0x04000387 RID: 903
				public ToonTownParentForm.Class116 class116_0;

				// Token: 0x04000388 RID: 904
				public ToonTownParentForm.Class115 class115_0;

				// Token: 0x04000389 RID: 905
				public IntPtr? nullable_0;

				// Token: 0x0400038A RID: 906
				public Rectangle rectangle_0;
			}

			// Token: 0x020001E8 RID: 488
			private sealed class Class119
			{
				// Token: 0x0600163F RID: 5695 RVA: 0x00036020 File Offset: 0x00034220
				public void method_0()
				{
					this.class117_0.action_4();
					this.class117_0.action_6();
					this.class117_0.action_8(this.nullable_0, this.rectangle_0);
					this.class117_0.action_7();
					this.class117_0.action_5();
				}

				// Token: 0x0400038B RID: 907
				public ToonTownParentForm.Class117 class117_0;

				// Token: 0x0400038C RID: 908
				public ToonTownParentForm.Class116 class116_0;

				// Token: 0x0400038D RID: 909
				public ToonTownParentForm.Class115 class115_0;

				// Token: 0x0400038E RID: 910
				public IntPtr? nullable_0;

				// Token: 0x0400038F RID: 911
				public Rectangle rectangle_0;
			}
		}
	}
}
