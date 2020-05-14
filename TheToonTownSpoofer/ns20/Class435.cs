using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns21;

namespace ns20
{
	// Token: 0x02000421 RID: 1057
	internal sealed class Class435 : NativeWindow, IDisposable
	{
		// Token: 0x140001CE RID: 462
		// (add) Token: 0x0600280F RID: 10255 RVA: 0x0009426C File Offset: 0x0009246C
		// (remove) Token: 0x06002810 RID: 10256 RVA: 0x000942A4 File Offset: 0x000924A4
		public event EventHandler<EventArgs11> DataReceived
		{
			add
			{
				EventHandler<EventArgs11> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs11> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs11> value2 = (EventHandler<EventArgs11>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs11>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs11> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs11> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs11> value2 = (EventHandler<EventArgs11>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs11>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00012203 File Offset: 0x00010403
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public Class435()
		{
			this.CreateHandle(new CreateParams());
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x000942DC File Offset: 0x000924DC
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			WaitCallback waitCallback = null;
			Class435.Class436 @class = new Class435.Class436();
			@class.class435_0 = this;
			int msg = m.Msg;
			if (msg == 74)
			{
				@class.string_0 = Marshal.PtrToStringUni(((Struct20)Marshal.PtrToStructure(m.LParam, typeof(Struct20))).intptr_1);
				if (this.eventHandler_0 != null)
				{
					base.WndProc(ref m);
					if (waitCallback == null)
					{
						waitCallback = new WaitCallback(@class.method_0);
					}
					ThreadPool.UnsafeQueueUserWorkItem(waitCallback, null);
					return;
				}
			}
			base.WndProc(ref m);
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00094360 File Offset: 0x00092560
		~Class435()
		{
			this.method_0(false);
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00012216 File Offset: 0x00010416
		public void Dispose()
		{
			this.method_0(true);
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0001221F File Offset: 0x0001041F
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private void method_0(bool disposing)
		{
			if (disposing && base.Handle != IntPtr.Zero)
			{
				this.DestroyHandle();
			}
		}

		// Token: 0x04001421 RID: 5153
		private EventHandler<EventArgs11> eventHandler_0;

		// Token: 0x02000422 RID: 1058
		[CompilerGenerated]
		private sealed class Class436
		{
			// Token: 0x06002817 RID: 10263 RVA: 0x0001223C File Offset: 0x0001043C
			public void method_0(object _)
			{
				this.class435_0.eventHandler_0(this.class435_0, new EventArgs11(this.string_0));
			}

			// Token: 0x04001422 RID: 5154
			public string string_0;

			// Token: 0x04001423 RID: 5155
			public Class435 class435_0;
		}
	}
}
