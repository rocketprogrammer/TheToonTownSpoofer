using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading;
using ns23;
using ns29;
using ns30;
using ns31;

namespace ns16
{
	// Token: 0x020003DE RID: 990
	internal sealed class Class141 : Class123
	{
		// Token: 0x140001CC RID: 460
		// (add) Token: 0x060025E2 RID: 9698 RVA: 0x00085FD4 File Offset: 0x000841D4
		// (remove) Token: 0x060025E3 RID: 9699 RVA: 0x0008600C File Offset: 0x0008420C
		public event EventHandler ProcessExited
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

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x060025E4 RID: 9700 RVA: 0x00010B01 File Offset: 0x0000ED01
		// (set) Token: 0x060025E5 RID: 9701 RVA: 0x00010B09 File Offset: 0x0000ED09
		public Process Process
		{
			get
			{
				return this.process_0;
			}
			set
			{
				if (this.process_0 != value)
				{
					this.method_4(value, true);
					this.bool_2 = false;
				}
			}
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00086044 File Offset: 0x00084244
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private void method_4(Process p, bool isOpen = true)
		{
			EventHandler eventHandler = null;
			if (this.bool_2 && this.process_0 != null)
			{
				this.process_0.Dispose();
			}
			if (p != null)
			{
				p.EnableRaisingEvents = true;
				if (eventHandler == null)
				{
					eventHandler = new EventHandler(this.method_6);
				}
				p.Exited += eventHandler;
				if (isOpen && p.HasExited)
				{
					this.Process = null;
					this.method_5();
				}
			}
			this.process_0 = p;
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x060025E7 RID: 9703 RVA: 0x00010B23 File Offset: 0x0000ED23
		// (set) Token: 0x060025E8 RID: 9704 RVA: 0x000860B0 File Offset: 0x000842B0
		internal IntPtr MainWindowHandle
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				if (this.process_0 == null)
				{
					return IntPtr.Zero;
				}
				this.process_0.Refresh();
				return this.process_0.smethod_0();
			}
			set
			{
				if (this.MainWindowHandle != value)
				{
					if (value == IntPtr.Zero)
					{
						this.Process = null;
						return;
					}
					try
					{
						this.method_4(Class265.smethod_7(value), true);
						this.bool_2 = true;
					}
					catch (Exception ex)
					{
						ex.smethod_0();
						this.Process = null;
					}
				}
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x060025E9 RID: 9705 RVA: 0x00010B49 File Offset: 0x0000ED49
		public string MainWindowTitle
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				if (this.process_0 == null)
				{
					return string.Empty;
				}
				this.process_0.Refresh();
				return this.process_0.smethod_1();
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x060025EA RID: 9706 RVA: 0x00010B6F File Offset: 0x0000ED6F
		public bool ProcessOpen
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return this.process_0 != null && !this.process_0.HasExited;
			}
		}

		// Token: 0x060025EB RID: 9707 RVA: 0x00010B89 File Offset: 0x0000ED89
		public Class141(Process p, bool ownsProcess, bool isOpen = true)
		{
			this.method_4(p, isOpen);
			this.bool_2 = ownsProcess;
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x00010BA0 File Offset: 0x0000EDA0
		public Class141()
		{
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00010BA8 File Offset: 0x0000EDA8
		internal Class141(IntPtr hWnd)
		{
			this.MainWindowHandle = hWnd;
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00010BB7 File Offset: 0x0000EDB7
		private void method_5()
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, EventArgs.Empty);
			}
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00010BD2 File Offset: 0x0000EDD2
		protected override void vmethod_0()
		{
			if (this.bool_2 && this.process_0 != null)
			{
				this.process_0.Dispose();
			}
			base.vmethod_0();
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x00010BF5 File Offset: 0x0000EDF5
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			if (this.process_0 == (Process)sender)
			{
				this.Process = null;
				this.method_5();
			}
		}

		// Token: 0x04001284 RID: 4740
		private EventHandler eventHandler_2;

		// Token: 0x04001285 RID: 4741
		private Process process_0;

		// Token: 0x04001286 RID: 4742
		private bool bool_2;
	}
}
