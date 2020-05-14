using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using ns18;
using ns22;
using ns28;
using ns30;

namespace ns16
{
	// Token: 0x020003B9 RID: 953
	internal sealed class Class384
	{
		// Token: 0x140001BC RID: 444
		// (add) Token: 0x060024DE RID: 9438 RVA: 0x0007E96C File Offset: 0x0007CB6C
		// (remove) Token: 0x060024DF RID: 9439 RVA: 0x0007E9A4 File Offset: 0x0007CBA4
		public event EventHandler<EventArgs23> PacketReceived
		{
			add
			{
				EventHandler<EventArgs23> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs23> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs23> value2 = (EventHandler<EventArgs23>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs23>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs23> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs23> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs23> value2 = (EventHandler<EventArgs23>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs23>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060024E0 RID: 9440 RVA: 0x00010102 File Offset: 0x0000E302
		private void method_0(EventArgs23 e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, e);
			}
		}

		// Token: 0x060024E1 RID: 9441 RVA: 0x00010119 File Offset: 0x0000E319
		public Class384(Class384.Class138 download, CancellationToken cancellationToken)
		{
			if (download == null)
			{
				throw new ArgumentNullException("download");
			}
			this.interface22_0 = download;
			this.cancellationToken_0 = cancellationToken;
		}

		// Token: 0x060024E2 RID: 9442 RVA: 0x0007E9DC File Offset: 0x0007CBDC
		public Class384.Enum83 method_1(out long size)
		{
			if (this.interface22_0.RemotePaths.Count == 0)
			{
				size = 0L;
				return Class384.Enum83.const_3;
			}
			this.method_2();
			this.class508_0.method_10(this.cancellationToken_0);
			if (this.class508_0.Initialized)
			{
				size = this.class508_0.TotalBytes;
				return Class384.Enum83.const_1;
			}
			if (this.class508_0.Canceled)
			{
				size = 0L;
				return Class384.Enum83.const_2;
			}
			return this.method_1(out size);
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0007EA64 File Offset: 0x0007CC64
		private void method_2()
		{
			switch (this.interface22_0.DownloadMethod)
			{
			case Enum75.const_0:
				this.class508_0 = new Class508(this.interface22_0.RemotePaths.Dequeue(), this.interface22_0.TargetFile, true);
				return;
			case Enum75.const_1:
				this.class508_0 = new Class508(this.interface22_0.RemotePaths.Dequeue(), this.interface22_0.TargetStream, true);
				return;
			default:
				return;
			}
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x0007EADC File Offset: 0x0007CCDC
		public Class384.Enum83 method_3()
		{
			this.class508_0.PacketReceived += this.method_4;
			this.class508_0.method_11(this.cancellationToken_0);
			if (this.class508_0.DownloadCompleted)
			{
				return Class384.Enum83.const_1;
			}
			if (this.class508_0.Canceled)
			{
				return Class384.Enum83.const_2;
			}
			if (this.interface22_0.RemotePaths.Count == 0)
			{
				return Class384.Enum83.const_3;
			}
			if (this.long_0 > 0L)
			{
				this.method_0(new EventArgs23(-this.long_0));
				this.long_0 = 0L;
			}
			this.method_2();
			return this.method_3();
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x0001013D File Offset: 0x0000E33D
		[CompilerGenerated]
		private void method_4(object sender, EventArgs23 e)
		{
			this.long_0 += e.PacketLength;
			this.method_0(e);
		}

		// Token: 0x0400113A RID: 4410
		private Class508 class508_0;

		// Token: 0x0400113B RID: 4411
		private EventHandler<EventArgs23> eventHandler_0;

		// Token: 0x0400113C RID: 4412
		private CancellationToken cancellationToken_0;

		// Token: 0x0400113D RID: 4413
		private long long_0;

		// Token: 0x0400113E RID: 4414
		private Class384.Interface22 interface22_0;

		// Token: 0x020003BA RID: 954
		private interface Interface22
		{
			// Token: 0x17000970 RID: 2416
			// (get) Token: 0x060024E6 RID: 9446
			Enum75 DownloadMethod { get; }

			// Token: 0x17000971 RID: 2417
			// (get) Token: 0x060024E7 RID: 9447
			// (set) Token: 0x060024E8 RID: 9448
			Queue<Uri> RemotePaths { get; set; }

			// Token: 0x17000972 RID: 2418
			// (get) Token: 0x060024E9 RID: 9449
			Stream TargetStream { get; }

			// Token: 0x17000973 RID: 2419
			// (get) Token: 0x060024EA RID: 9450
			string TargetFile { get; }
		}

		// Token: 0x020003BB RID: 955
		internal class Class138 : Class123, Class384.Interface22
		{
			// Token: 0x17000974 RID: 2420
			// (get) Token: 0x060024EB RID: 9451 RVA: 0x00010159 File Offset: 0x0000E359
			// (set) Token: 0x060024EC RID: 9452 RVA: 0x00010161 File Offset: 0x0000E361
			public Enum75 DownloadMethod { get; private set; }

			// Token: 0x17000975 RID: 2421
			// (get) Token: 0x060024ED RID: 9453 RVA: 0x0001016A File Offset: 0x0000E36A
			// (set) Token: 0x060024EE RID: 9454 RVA: 0x00010185 File Offset: 0x0000E385
			public string TargetFile
			{
				get
				{
					if (this.DownloadMethod != Enum75.const_0)
					{
						throw new InvalidOperationException("IDownloadData is in Stream mode.");
					}
					return this.string_0;
				}
				private set
				{
					this.string_0 = value;
				}
			}

			// Token: 0x17000976 RID: 2422
			// (get) Token: 0x060024EF RID: 9455 RVA: 0x0001018E File Offset: 0x0000E38E
			// (set) Token: 0x060024F0 RID: 9456 RVA: 0x000101AA File Offset: 0x0000E3AA
			public Stream TargetStream
			{
				get
				{
					if (this.DownloadMethod != Enum75.const_1)
					{
						throw new InvalidOperationException("IDownloadData is in File mode.");
					}
					return this.stream_0;
				}
				private set
				{
					this.stream_0 = value;
				}
			}

			// Token: 0x17000977 RID: 2423
			// (get) Token: 0x060024F1 RID: 9457 RVA: 0x000101B3 File Offset: 0x0000E3B3
			// (set) Token: 0x060024F2 RID: 9458 RVA: 0x000101BB File Offset: 0x0000E3BB
			Queue<Uri> Class384.Interface22.RemotePaths { get; set; }

			// Token: 0x060024F3 RID: 9459 RVA: 0x000101C4 File Offset: 0x0000E3C4
			private Class138(Queue<Uri> remotePaths)
			{
				this.interface22_0 = this;
				this.interface22_0.RemotePaths = remotePaths;
			}

			// Token: 0x060024F4 RID: 9460 RVA: 0x000101DF File Offset: 0x0000E3DF
			public Class138(Stream destinationStream, Queue<Uri> remotePaths) : this(remotePaths)
			{
				this.DownloadMethod = Enum75.const_1;
				this.TargetStream = destinationStream;
			}

			// Token: 0x060024F5 RID: 9461 RVA: 0x000101F6 File Offset: 0x0000E3F6
			public Class138(string destinationPath, Queue<Uri> remotePaths) : this(remotePaths)
			{
				this.DownloadMethod = Enum75.const_0;
				this.TargetFile = destinationPath;
			}

			// Token: 0x060024F6 RID: 9462 RVA: 0x0007EB88 File Offset: 0x0007CD88
			protected override void vmethod_0()
			{
				Enum75 downloadMethod = this.DownloadMethod;
				if (downloadMethod == Enum75.const_1)
				{
					this.TargetStream.Dispose();
				}
				base.vmethod_0();
			}

			// Token: 0x0400113F RID: 4415
			private Class384.Interface22 interface22_0;

			// Token: 0x04001140 RID: 4416
			private string string_0;

			// Token: 0x04001141 RID: 4417
			private Stream stream_0;

			// Token: 0x04001142 RID: 4418
			[CompilerGenerated]
			private Enum75 enum75_0;

			// Token: 0x04001143 RID: 4419
			[CompilerGenerated]
			private Queue<Uri> queue_0;
		}

		// Token: 0x020003BC RID: 956
		internal enum Enum83
		{
			// Token: 0x04001145 RID: 4421
			const_0,
			// Token: 0x04001146 RID: 4422
			const_1,
			// Token: 0x04001147 RID: 4423
			const_2,
			// Token: 0x04001148 RID: 4424
			const_3
		}
	}
}
