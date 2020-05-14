using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns30
{
	// Token: 0x020001F1 RID: 497
	internal class Class123 : IDisposable
	{
		// Token: 0x14000171 RID: 369
		// (add) Token: 0x0600167C RID: 5756 RVA: 0x00036510 File Offset: 0x00034710
		// (remove) Token: 0x0600167D RID: 5757 RVA: 0x00036548 File Offset: 0x00034748
		public event EventHandler OnDisposing
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

		// Token: 0x14000172 RID: 370
		// (add) Token: 0x0600167E RID: 5758 RVA: 0x00036580 File Offset: 0x00034780
		// (remove) Token: 0x0600167F RID: 5759 RVA: 0x000365B8 File Offset: 0x000347B8
		public event EventHandler OnDisposed
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

		// Token: 0x06001680 RID: 5760 RVA: 0x00006895 File Offset: 0x00004A95
		private void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001681 RID: 5761 RVA: 0x000068B0 File Offset: 0x00004AB0
		private void method_1()
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06001682 RID: 5762 RVA: 0x000068CB File Offset: 0x00004ACB
		// (set) Token: 0x06001683 RID: 5763 RVA: 0x000068D3 File Offset: 0x00004AD3
		public bool IsDisposed { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06001684 RID: 5764 RVA: 0x000068DC File Offset: 0x00004ADC
		// (set) Token: 0x06001685 RID: 5765 RVA: 0x000068E4 File Offset: 0x00004AE4
		public bool IsDisposing { [DebuggerStepThrough] get; [DebuggerStepThrough] private set; }

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06001686 RID: 5766 RVA: 0x000068ED File Offset: 0x00004AED
		public bool IsDisposingOrDisposed
		{
			get
			{
				return this.IsDisposed || this.IsDisposing;
			}
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x000365F0 File Offset: 0x000347F0
		~Class123()
		{
			this.method_2(false);
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x000068FF File Offset: 0x00004AFF
		public void Dispose()
		{
			this.method_2(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001689 RID: 5769 RVA: 0x00036620 File Offset: 0x00034820
		[DebuggerStepThrough]
		private void method_2(bool disposing)
		{
			if (!this.IsDisposed && !this.IsDisposing)
			{
				try
				{
					this.IsDisposing = true;
					this.method_0();
					this.vmethod_2(disposing);
					this.vmethod_1();
					if (disposing)
					{
						this.vmethod_0();
					}
				}
				finally
				{
					this.IsDisposing = false;
					this.IsDisposed = true;
				}
				this.method_1();
				return;
			}
		}

		// Token: 0x0600168A RID: 5770 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_0()
		{
		}

		// Token: 0x0600168B RID: 5771 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_1()
		{
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_2(bool disposing)
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0000690E File Offset: 0x00004B0E
		[DebuggerStepThrough]
		public override string ToString()
		{
			return base.GetType().FullName;
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x0000691B File Offset: 0x00004B1B
		[DebuggerStepThrough]
		protected void method_3()
		{
			if (this.IsDisposed)
			{
				throw new ObjectDisposedException(this.ToString());
			}
		}

		// Token: 0x040003A5 RID: 933
		private EventHandler eventHandler_0;

		// Token: 0x040003A6 RID: 934
		private EventHandler eventHandler_1;

		// Token: 0x040003A7 RID: 935
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040003A8 RID: 936
		[CompilerGenerated]
		private bool bool_1;
	}
}
