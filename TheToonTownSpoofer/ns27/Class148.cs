using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Win32.SafeHandles;
using ns16;
using ns20;
using ns23;
using ns24;
using ns26;
using ns28;
using ns30;
using ns31;

namespace ns27
{
	// Token: 0x02000497 RID: 1175
	internal sealed class Class148 : Class123
	{
		// Token: 0x140001DC RID: 476
		// (add) Token: 0x06002BBC RID: 11196 RVA: 0x000AA24C File Offset: 0x000A844C
		// (remove) Token: 0x06002BBD RID: 11197 RVA: 0x000AA284 File Offset: 0x000A8484
		public event EventHandler<EventArgs39> MessageReceived
		{
			add
			{
				EventHandler<EventArgs39> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs39> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs39> value2 = (EventHandler<EventArgs39>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs39>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs39> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs39> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs39> value2 = (EventHandler<EventArgs39>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs39>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001DD RID: 477
		// (add) Token: 0x06002BBE RID: 11198 RVA: 0x000AA2BC File Offset: 0x000A84BC
		// (remove) Token: 0x06002BBF RID: 11199 RVA: 0x000AA2F4 File Offset: 0x000A84F4
		public event EventHandler ServerDisconnected
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

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06002BC0 RID: 11200 RVA: 0x00014596 File Offset: 0x00012796
		// (set) Token: 0x06002BC1 RID: 11201 RVA: 0x0001459E File Offset: 0x0001279E
		public bool Connected { get; private set; }

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06002BC2 RID: 11202 RVA: 0x000145A7 File Offset: 0x000127A7
		// (set) Token: 0x06002BC3 RID: 11203 RVA: 0x000145AF File Offset: 0x000127AF
		public string PipeName { get; private set; }

		// Token: 0x06002BC4 RID: 11204 RVA: 0x000AA32C File Offset: 0x000A852C
		public void method_4(string pipename)
		{
			if (this.Connected)
			{
				throw new Exception("Already connected to pipe server.");
			}
			this.PipeName = pipename;
			this.safeFileHandle_0 = Class265.CreateFile(this.PipeName, (Enum64)3221225472U, Enum89.const_0, IntPtr.Zero, Enum105.const_2, Enum122.const_13, IntPtr.Zero);
			if (this.safeFileHandle_0.IsInvalid)
			{
				try
				{
					throw new Win32Exception();
				}
				catch (Exception ex)
				{
					ex.smethod_0();
				}
				this.safeFileHandle_0.Dispose();
				this.safeFileHandle_0 = null;
				this.PipeName = null;
				return;
			}
			this.fileStream_0 = new FileStream(this.safeFileHandle_0, FileAccess.ReadWrite, Class148.int_0, true);
			this.Connected = true;
			this.task_0 = new Task(new Action(this.method_6));
			this.task_0.Start();
		}

		// Token: 0x06002BC5 RID: 11205 RVA: 0x000AA404 File Offset: 0x000A8604
		public void method_5()
		{
			if (!this.Connected)
			{
				return;
			}
			this.Connected = false;
			this.PipeName = null;
			if (this.fileStream_0 != null)
			{
				this.fileStream_0.Close();
				this.fileStream_0.Dispose();
				this.fileStream_0 = null;
			}
			if (this.safeFileHandle_0 != null)
			{
				this.safeFileHandle_0.Close();
				this.safeFileHandle_0.Dispose();
				this.safeFileHandle_0 = null;
			}
			if (this.task_0 != null)
			{
				this.task_0.Wait();
				this.task_0.Dispose();
				this.task_0 = null;
			}
		}

		// Token: 0x06002BC6 RID: 11206 RVA: 0x000145B8 File Offset: 0x000127B8
		protected override void vmethod_0()
		{
			this.method_5();
			base.vmethod_0();
		}

		// Token: 0x06002BC7 RID: 11207 RVA: 0x000AA498 File Offset: 0x000A8698
		private void method_6()
		{
			WaitCallback waitCallback = null;
			byte[] array = new byte[Class148.int_0];
			using (MemoryStream memoryStream = new MemoryStream())
			{
				for (;;)
				{
					memoryStream.SetLength(0L);
					int num = 0;
					try
					{
						if (this.fileStream_0.Read(array, 0, 4) == 0)
						{
							break;
						}
						int num2 = BitConverter.ToInt32(array, 0);
						do
						{
							int num3 = this.fileStream_0.Read(array, 0, Math.Min(num2 - num, Class148.int_0));
							memoryStream.Write(array, 0, num3);
							num += num3;
						}
						while (num < num2);
					}
					catch
					{
						break;
					}
					if (num == 0)
					{
						break;
					}
					if (this.eventHandler_2 != null)
					{
						this.eventHandler_2(this, new EventArgs39(memoryStream.ToArray()));
					}
				}
			}
			if (this.Connected)
			{
				if (waitCallback == null)
				{
					waitCallback = new WaitCallback(this.method_8);
				}
				ThreadPool.UnsafeQueueUserWorkItem(waitCallback, null);
			}
		}

		// Token: 0x06002BC8 RID: 11208 RVA: 0x000AA58C File Offset: 0x000A878C
		public bool method_7(byte[] message)
		{
			bool result;
			try
			{
				this.fileStream_0.Write(BitConverter.GetBytes(message.Length), 0, 4);
				this.fileStream_0.Write(message, 0, message.Length);
				this.fileStream_0.Flush();
				result = true;
			}
			catch
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06002BCA RID: 11210 RVA: 0x000145C6 File Offset: 0x000127C6
		[CompilerGenerated]
		private void method_8(object _)
		{
			this.method_5();
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x0400170D RID: 5901
		private static readonly int int_0 = 4096;

		// Token: 0x0400170E RID: 5902
		private EventHandler<EventArgs39> eventHandler_2;

		// Token: 0x0400170F RID: 5903
		private EventHandler eventHandler_3;

		// Token: 0x04001710 RID: 5904
		private FileStream fileStream_0;

		// Token: 0x04001711 RID: 5905
		private SafeFileHandle safeFileHandle_0;

		// Token: 0x04001712 RID: 5906
		private Task task_0;

		// Token: 0x04001713 RID: 5907
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04001714 RID: 5908
		[CompilerGenerated]
		private string string_0;
	}
}
