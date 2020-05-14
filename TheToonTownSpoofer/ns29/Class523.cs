using System;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using ns26;

namespace ns29
{
	// Token: 0x020004D3 RID: 1235
	internal sealed class Class523 : NativeWindow, IDisposable
	{
		// Token: 0x140001FA RID: 506
		// (add) Token: 0x06002E0D RID: 11789 RVA: 0x000B093C File Offset: 0x000AEB3C
		// (remove) Token: 0x06002E0E RID: 11790 RVA: 0x000B0974 File Offset: 0x000AEB74
		public event EventHandler<EventArgs41> HotkeyPressed
		{
			add
			{
				EventHandler<EventArgs41> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs41> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs41> value2 = (EventHandler<EventArgs41>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs41>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs41> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs41> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs41> value2 = (EventHandler<EventArgs41>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs41>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06002E0F RID: 11791 RVA: 0x00012203 File Offset: 0x00010403
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		public Class523()
		{
			this.CreateHandle(new CreateParams());
		}

		// Token: 0x06002E10 RID: 11792 RVA: 0x000B09AC File Offset: 0x000AEBAC
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			if (msg == 786 && this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs41(m.WParam.ToInt32()));
			}
			base.WndProc(ref m);
		}

		// Token: 0x06002E11 RID: 11793 RVA: 0x000B09F8 File Offset: 0x000AEBF8
		~Class523()
		{
			this.method_0(false);
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x000162FE File Offset: 0x000144FE
		public void Dispose()
		{
			this.method_0(true);
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x0001221F File Offset: 0x0001041F
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private void method_0(bool disposing)
		{
			if (disposing && base.Handle != IntPtr.Zero)
			{
				this.DestroyHandle();
			}
		}

		// Token: 0x04001830 RID: 6192
		private EventHandler<EventArgs41> eventHandler_0;
	}
}
