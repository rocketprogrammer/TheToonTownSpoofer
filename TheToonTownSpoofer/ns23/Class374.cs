using System;
using System.Collections.Generic;
using System.Threading;

namespace ns23
{
	// Token: 0x020003A6 RID: 934
	internal sealed class Class374
	{
		// Token: 0x140001B5 RID: 437
		// (add) Token: 0x06002432 RID: 9266 RVA: 0x0007A970 File Offset: 0x00078B70
		// (remove) Token: 0x06002433 RID: 9267 RVA: 0x0007A9A8 File Offset: 0x00078BA8
		public event EventHandler Started
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

		// Token: 0x140001B6 RID: 438
		// (add) Token: 0x06002434 RID: 9268 RVA: 0x0007A9E0 File Offset: 0x00078BE0
		// (remove) Token: 0x06002435 RID: 9269 RVA: 0x0007AA18 File Offset: 0x00078C18
		public event EventHandler Stopped
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

		// Token: 0x06002436 RID: 9270 RVA: 0x0000FAA5 File Offset: 0x0000DCA5
		private void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002437 RID: 9271 RVA: 0x0000FAC0 File Offset: 0x0000DCC0
		private void method_1()
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002438 RID: 9272 RVA: 0x0000FADB File Offset: 0x0000DCDB
		public Class374()
		{
			this.object_0 = new object();
			this.list_0 = new List<KeyValuePair<Action<object>, object>>();
			this.bool_0 = false;
		}

		// Token: 0x06002439 RID: 9273 RVA: 0x0000FB02 File Offset: 0x0000DD02
		public void method_2(Action<object> action)
		{
			this.method_3(action, null);
		}

		// Token: 0x0600243A RID: 9274 RVA: 0x0007AA50 File Offset: 0x00078C50
		public void method_3(Action<object> action, object state)
		{
			lock (this.object_0)
			{
				this.list_0.Add(new KeyValuePair<Action<object>, object>(action, state));
				if (this.bool_0)
				{
					return;
				}
				this.bool_0 = true;
			}
			this.method_0();
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_6));
		}

		// Token: 0x0600243B RID: 9275 RVA: 0x0000FB0C File Offset: 0x0000DD0C
		public void method_4(Action<object> action)
		{
			this.method_5(action, null);
		}

		// Token: 0x0600243C RID: 9276 RVA: 0x0007AACC File Offset: 0x00078CCC
		public void method_5(Action<object> action, object state)
		{
			lock (this.object_0)
			{
				this.list_0.Insert(0, new KeyValuePair<Action<object>, object>(action, state));
				if (this.bool_0)
				{
					return;
				}
				this.bool_0 = true;
			}
			this.method_0();
			ThreadPool.QueueUserWorkItem(new WaitCallback(this.method_6));
		}

		// Token: 0x0600243D RID: 9277 RVA: 0x0007AB48 File Offset: 0x00078D48
		private void method_6(object state)
		{
			bool flag3;
			try
			{
				KeyValuePair<Action<object>, object> keyValuePair;
				lock (this.object_0)
				{
					keyValuePair = this.list_0[0];
					this.list_0.RemoveAt(0);
				}
				keyValuePair.Key(keyValuePair.Value);
			}
			finally
			{
				lock (this.object_0)
				{
					if (this.list_0.Count == 0)
					{
						this.bool_0 = false;
						this.method_1();
						flag3 = false;
					}
					else
					{
						flag3 = true;
					}
				}
			}
			if (flag3)
			{
				this.method_6(state);
			}
		}

		// Token: 0x040010CD RID: 4301
		private List<KeyValuePair<Action<object>, object>> list_0;

		// Token: 0x040010CE RID: 4302
		private volatile bool bool_0;

		// Token: 0x040010CF RID: 4303
		private readonly object object_0;

		// Token: 0x040010D0 RID: 4304
		private EventHandler eventHandler_0;

		// Token: 0x040010D1 RID: 4305
		private EventHandler eventHandler_1;
	}
}
