using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ns15;
using ns19;
using ns20;
using ns21;
using ns24;
using ns26;
using ns28;
using ns29;
using ns30;

namespace ns27
{
	// Token: 0x02000488 RID: 1160
	internal sealed class Class147 : Class123
	{
		// Token: 0x140001DA RID: 474
		// (add) Token: 0x06002B3B RID: 11067 RVA: 0x000A7B14 File Offset: 0x000A5D14
		// (remove) Token: 0x06002B3C RID: 11068 RVA: 0x000A7B4C File Offset: 0x000A5D4C
		public event EventHandler<EventArgs16> AuthenticationComplete
		{
			add
			{
				EventHandler<EventArgs16> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs16> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs16> value2 = (EventHandler<EventArgs16>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs16>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs16> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs16> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs16> value2 = (EventHandler<EventArgs16>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs16>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001DB RID: 475
		// (add) Token: 0x06002B3D RID: 11069 RVA: 0x000A7B84 File Offset: 0x000A5D84
		// (remove) Token: 0x06002B3E RID: 11070 RVA: 0x000A7BBC File Offset: 0x000A5DBC
		public event EventHandler<EventArgs8> AuthenticationFailed
		{
			add
			{
				EventHandler<EventArgs8> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs8> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs8> value2 = (EventHandler<EventArgs8>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs8>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs8> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs8> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs8> value2 = (EventHandler<EventArgs8>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs8>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x00014218 File Offset: 0x00012418
		public Class96 PatchData
		{
			get
			{
				return this.class96_0;
			}
		}

		// Token: 0x06002B40 RID: 11072 RVA: 0x000A7BF4 File Offset: 0x000A5DF4
		public Class147(Enum101 type, string username, string password)
		{
			type.smethod_0();
			if (string.IsNullOrEmpty(username))
			{
				throw new ArgumentNullException("username");
			}
			if (string.IsNullOrEmpty(password))
			{
				throw new ArgumentNullException("password");
			}
			this.memoryStream_0 = new MemoryStream();
			this.enum101_0 = type;
			this.string_0 = username;
			this.string_1 = password;
			this.cancellationTokenSource_0 = new CancellationTokenSource();
		}

		// Token: 0x06002B41 RID: 11073 RVA: 0x00014220 File Offset: 0x00012420
		private void method_4(bool newFormat, Dictionary<string, string> result)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, new EventArgs16(newFormat, result));
			}
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x0001423D File Offset: 0x0001243D
		private void method_5(Exception ex)
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, new EventArgs8(ex));
			}
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x00014259 File Offset: 0x00012459
		protected override void vmethod_0()
		{
			this.cancellationTokenSource_0.Cancel();
			this.method_6();
			this.cancellationTokenSource_0.Dispose();
			this.memoryStream_0.Dispose();
			base.vmethod_0();
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000A7C64 File Offset: 0x000A5E64
		private void method_6()
		{
			try
			{
				if (this.task_0 != null)
				{
					this.task_0.Wait();
				}
			}
			catch (AggregateException)
			{
			}
			finally
			{
				if (this.task_0 != null)
				{
					this.task_0.Dispose();
					this.task_0 = null;
				}
			}
		}

		// Token: 0x06002B45 RID: 11077 RVA: 0x00014288 File Offset: 0x00012488
		public void method_7()
		{
			this.method_8();
		}

		// Token: 0x06002B46 RID: 11078 RVA: 0x000A7CC4 File Offset: 0x000A5EC4
		private void method_8()
		{
			switch (this.enum101_0)
			{
			case Enum101.const_1:
				this.class508_0 = new Class508(new Uri(Class502.string_0), this.memoryStream_0, false);
				break;
			case Enum101.const_2:
				this.class508_0 = new Class508(new Uri(Class502.string_1), this.memoryStream_0, false);
				break;
			}
			this.class508_0.RequiresInitialization = false;
			this.class508_0.DownloadComplete += this.method_11;
			this.method_10();
		}

		// Token: 0x06002B47 RID: 11079 RVA: 0x000A7D50 File Offset: 0x000A5F50
		private void method_9()
		{
			this.method_6();
			this.memoryStream_0.SetLength(0L);
			if (string.IsNullOrEmpty(this.class96_0.Properties.WEB_PAGE_LOGIN_RPC))
			{
				switch (this.enum101_0)
				{
				case Enum101.const_1:
					this.class508_0 = new Class508(new Uri(string.Format(Class502.string_2, this.string_0, this.string_1)), this.memoryStream_0, false);
					break;
				case Enum101.const_2:
					this.class508_0 = new Class508(new Uri(string.Format(Class502.string_3, this.string_0, this.string_1)), this.memoryStream_0, false);
					break;
				}
			}
			else
			{
				this.class508_0 = new Class508(new Uri(string.Format(this.class96_0.Properties.WEB_PAGE_LOGIN_RPC + "?n={0}&p={1}", this.string_0, this.string_1)), this.memoryStream_0, false);
			}
			this.class508_0.RequiresInitialization = false;
			this.class508_0.DownloadComplete += this.method_13;
			this.method_10();
		}

		// Token: 0x06002B48 RID: 11080 RVA: 0x000A7E74 File Offset: 0x000A6074
		private void method_10()
		{
			this.class508_0.DownloadError += this.method_16;
			this.task_0 = new Task(new Action<object>(this.class508_0.method_11), this.cancellationTokenSource_0.Token);
			this.task_0.Start();
		}

		// Token: 0x06002B49 RID: 11081 RVA: 0x000A7ED0 File Offset: 0x000A60D0
		private static Dictionary<string, string> smethod_0(string response, out bool newFormat)
		{
			newFormat = false;
			if (string.IsNullOrEmpty(response))
			{
				return null;
			}
			bool flag;
			response = response.smethod_2("ACCOUNT SERVER RESPONSE", out flag);
			newFormat = !flag;
			Dictionary<string, string> dictionary = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			string[] array = response.smethod_3(StringSplitOptions.RemoveEmptyEntries, new char[]
			{
				'\n'
			});
			for (int i = 0; i < array.Length; i++)
			{
				string key;
				string value;
				if (array[i].smethod_1('=', out key, out value))
				{
					dictionary.Add(key, value);
				}
			}
			return dictionary;
		}

		// Token: 0x06002B4A RID: 11082 RVA: 0x000A7F4C File Offset: 0x000A614C
		[CompilerGenerated]
		private void method_11(object sender, EventArgs e)
		{
			WaitCallback waitCallback = null;
			try
			{
				this.class96_0 = new Class96();
				this.memoryStream_0.Seek(0L, SeekOrigin.Begin);
				using (Stream3 stream = new Stream3(this.memoryStream_0))
				{
					using (StreamReader streamReader = new StreamReader(stream))
					{
						this.class96_0.method_11(streamReader.ReadToEnd());
					}
				}
				if (waitCallback == null)
				{
					waitCallback = new WaitCallback(this.method_12);
				}
				ThreadPool.UnsafeQueueUserWorkItem(waitCallback, null);
			}
			catch (Exception exception_)
			{
				Class147.Class482 @class = new Class147.Class482();
				@class.exception_0 = exception_;
				@class.class147_0 = this;
				ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0), null);
			}
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00014290 File Offset: 0x00012490
		[CompilerGenerated]
		private void method_12(object _)
		{
			this.method_9();
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x000A8028 File Offset: 0x000A6228
		[CompilerGenerated]
		private void method_13(object sender, EventArgs e)
		{
			WaitCallback waitCallback = null;
			WaitCallback waitCallback2 = null;
			try
			{
				WaitCallback waitCallback3 = null;
				Class147.Class483 @class = new Class147.Class483();
				@class.class147_0 = this;
				@class.dictionary_0 = Class147.smethod_0(Encoding.ASCII.GetString(this.memoryStream_0.ToArray()), out @class.bool_0);
				if (@class.dictionary_0 == null)
				{
					if (waitCallback == null)
					{
						waitCallback = new WaitCallback(this.method_14);
					}
					ThreadPool.QueueUserWorkItem(waitCallback, null);
				}
				else if (@class.bool_0 && @class.dictionary_0.smethod_4("LOGIN_ACTION", "QUEUE"))
				{
					Thread.Sleep(1000);
					if (waitCallback2 == null)
					{
						waitCallback2 = new WaitCallback(this.method_15);
					}
					ThreadPool.UnsafeQueueUserWorkItem(waitCallback2, null);
				}
				else
				{
					if (waitCallback3 == null)
					{
						waitCallback3 = new WaitCallback(@class.method_0);
					}
					ThreadPool.QueueUserWorkItem(waitCallback3, null);
				}
			}
			catch (Exception exception_)
			{
				Class147.Class484 class2 = new Class147.Class484();
				class2.exception_0 = exception_;
				class2.class147_0 = this;
				ThreadPool.QueueUserWorkItem(new WaitCallback(class2.method_0), null);
			}
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00014298 File Offset: 0x00012498
		[CompilerGenerated]
		private void method_14(object _)
		{
			this.method_5(new NullReferenceException("The server did not reply with data."));
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x00014290 File Offset: 0x00012490
		[CompilerGenerated]
		private void method_15(object _)
		{
			this.method_9();
		}

		// Token: 0x06002B4F RID: 11087 RVA: 0x000A8130 File Offset: 0x000A6330
		[CompilerGenerated]
		private void method_16(object sender, EventArgs36 e)
		{
			Class147.Class485 @class = new Class147.Class485();
			@class.eventArgs36_0 = e;
			@class.class147_0 = this;
			ThreadPool.QueueUserWorkItem(new WaitCallback(@class.method_0), null);
		}

		// Token: 0x040016E1 RID: 5857
		private Class508 class508_0;

		// Token: 0x040016E2 RID: 5858
		private MemoryStream memoryStream_0;

		// Token: 0x040016E3 RID: 5859
		private Enum101 enum101_0;

		// Token: 0x040016E4 RID: 5860
		private string string_0;

		// Token: 0x040016E5 RID: 5861
		private string string_1;

		// Token: 0x040016E6 RID: 5862
		private Class96 class96_0;

		// Token: 0x040016E7 RID: 5863
		private CancellationTokenSource cancellationTokenSource_0;

		// Token: 0x040016E8 RID: 5864
		private Task task_0;

		// Token: 0x040016E9 RID: 5865
		private EventHandler<EventArgs16> eventHandler_2;

		// Token: 0x040016EA RID: 5866
		private EventHandler<EventArgs8> eventHandler_3;

		// Token: 0x02000489 RID: 1161
		[CompilerGenerated]
		private sealed class Class482
		{
			// Token: 0x06002B51 RID: 11089 RVA: 0x000142AA File Offset: 0x000124AA
			public void method_0(object _)
			{
				this.class147_0.method_5(this.exception_0);
			}

			// Token: 0x040016EB RID: 5867
			public Exception exception_0;

			// Token: 0x040016EC RID: 5868
			public Class147 class147_0;
		}

		// Token: 0x0200048A RID: 1162
		[CompilerGenerated]
		private sealed class Class483
		{
			// Token: 0x06002B53 RID: 11091 RVA: 0x000142BD File Offset: 0x000124BD
			public void method_0(object _)
			{
				this.class147_0.method_4(this.bool_0, this.dictionary_0);
			}

			// Token: 0x040016ED RID: 5869
			public bool bool_0;

			// Token: 0x040016EE RID: 5870
			public Dictionary<string, string> dictionary_0;

			// Token: 0x040016EF RID: 5871
			public Class147 class147_0;
		}

		// Token: 0x0200048B RID: 1163
		[CompilerGenerated]
		private sealed class Class484
		{
			// Token: 0x06002B55 RID: 11093 RVA: 0x000142D6 File Offset: 0x000124D6
			public void method_0(object _)
			{
				this.class147_0.method_5(this.exception_0);
			}

			// Token: 0x040016F0 RID: 5872
			public Exception exception_0;

			// Token: 0x040016F1 RID: 5873
			public Class147 class147_0;
		}

		// Token: 0x0200048C RID: 1164
		[CompilerGenerated]
		private sealed class Class485
		{
			// Token: 0x06002B57 RID: 11095 RVA: 0x000142E9 File Offset: 0x000124E9
			public void method_0(object _)
			{
				this.class147_0.method_5(this.eventArgs36_0.Exception);
			}

			// Token: 0x040016F2 RID: 5874
			public EventArgs36 eventArgs36_0;

			// Token: 0x040016F3 RID: 5875
			public Class147 class147_0;
		}
	}
}
