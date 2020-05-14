using System;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using ns15;
using ns18;
using ns19;
using ns21;
using ns22;
using ns23;
using ns29;
using ns30;

namespace ns28
{
	// Token: 0x020004AF RID: 1199
	internal sealed class Class508
	{
		// Token: 0x06002CD2 RID: 11474 RVA: 0x000ACC6C File Offset: 0x000AAE6C
		private Class508(Uri downloadFile, Enum75 method, bool allowResuming)
		{
			method.smethod_0();
			this.DownloadMethod = method;
			this.Target = downloadFile;
			this.AllowResuming = allowResuming;
			this.FailureDelay = 1000;
			this.DownloadAttempts = 3;
			this.RequiresInitialization = true;
		}

		// Token: 0x06002CD3 RID: 11475 RVA: 0x000ACCB8 File Offset: 0x000AAEB8
		public Class508(Uri downloadFile, Stream destinationStream, bool allowResuming) : this(downloadFile, Enum75.const_1, allowResuming)
		{
			if (downloadFile == null)
			{
				throw new ArgumentNullException("downloadFile");
			}
			if (destinationStream == null)
			{
				throw new ArgumentNullException("destinationStream");
			}
			if (!destinationStream.CanWrite)
			{
				throw new ArgumentException("Stream cannot be wrote to.");
			}
			this.stream_0 = destinationStream;
		}

		// Token: 0x06002CD4 RID: 11476 RVA: 0x0001534B File Offset: 0x0001354B
		public Class508(Uri downloadFile, string destinationFileName, bool allowResuming) : this(downloadFile, Enum75.const_0, allowResuming)
		{
			if (string.IsNullOrEmpty(destinationFileName))
			{
				throw new ArgumentNullException("destinationFileName");
			}
			this.string_6 = destinationFileName;
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06002CD5 RID: 11477 RVA: 0x00015370 File Offset: 0x00013570
		// (set) Token: 0x06002CD6 RID: 11478 RVA: 0x00015378 File Offset: 0x00013578
		public int DownloadAttempts { get; private set; }

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x00015381 File Offset: 0x00013581
		// (set) Token: 0x06002CD8 RID: 11480 RVA: 0x00015389 File Offset: 0x00013589
		public int MaxDownloadAttempts { get; set; }

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06002CD9 RID: 11481 RVA: 0x00015392 File Offset: 0x00013592
		// (set) Token: 0x06002CDA RID: 11482 RVA: 0x0001539A File Offset: 0x0001359A
		public bool RequiresInitialization { get; set; }

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06002CDB RID: 11483 RVA: 0x000153A3 File Offset: 0x000135A3
		// (set) Token: 0x06002CDC RID: 11484 RVA: 0x000153BC File Offset: 0x000135BC
		public bool Initialized
		{
			get
			{
				return this.enum123_0.HasFlag(Class508.Enum123.flag_6);
			}
			set
			{
				if (this.Initialized != value)
				{
					switch (value)
					{
					case false:
						this.enum123_0 &= ~Class508.Enum123.flag_6;
						break;
					case true:
						this.enum123_0 |= Class508.Enum123.flag_6;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06002CDD RID: 11485 RVA: 0x000153F7 File Offset: 0x000135F7
		// (set) Token: 0x06002CDE RID: 11486 RVA: 0x00015410 File Offset: 0x00013610
		public bool Initializing
		{
			get
			{
				return this.enum123_0.HasFlag(Class508.Enum123.flag_5);
			}
			set
			{
				if (this.Initializing != value)
				{
					switch (value)
					{
					case false:
						this.enum123_0 &= ~Class508.Enum123.flag_5;
						break;
					case true:
						this.enum123_0 |= Class508.Enum123.flag_5;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06002CDF RID: 11487 RVA: 0x0001544B File Offset: 0x0001364B
		// (set) Token: 0x06002CE0 RID: 11488 RVA: 0x00015463 File Offset: 0x00013663
		public bool DownloadFailed
		{
			get
			{
				return this.enum123_0.HasFlag(Class508.Enum123.flag_3);
			}
			set
			{
				if (this.DownloadFailed != value)
				{
					switch (value)
					{
					case false:
						this.enum123_0 &= ~Class508.Enum123.flag_3;
						break;
					case true:
						this.enum123_0 |= Class508.Enum123.flag_3;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06002CE1 RID: 11489 RVA: 0x0001549D File Offset: 0x0001369D
		// (set) Token: 0x06002CE2 RID: 11490 RVA: 0x000154B5 File Offset: 0x000136B5
		public bool Canceled
		{
			get
			{
				return this.enum123_0.HasFlag(Class508.Enum123.flag_4);
			}
			set
			{
				if (this.Canceled != value)
				{
					switch (value)
					{
					case false:
						this.enum123_0 &= ~Class508.Enum123.flag_4;
						break;
					case true:
						this.enum123_0 |= Class508.Enum123.flag_4;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06002CE3 RID: 11491 RVA: 0x000154EF File Offset: 0x000136EF
		// (set) Token: 0x06002CE4 RID: 11492 RVA: 0x00015507 File Offset: 0x00013707
		public bool DownloadStarted
		{
			get
			{
				return this.enum123_0.HasFlag(Class508.Enum123.flag_1);
			}
			set
			{
				if (this.DownloadStarted != value)
				{
					switch (value)
					{
					case false:
						this.enum123_0 &= ~Class508.Enum123.flag_1;
						break;
					case true:
						this.enum123_0 |= Class508.Enum123.flag_1;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06002CE5 RID: 11493 RVA: 0x00015541 File Offset: 0x00013741
		// (set) Token: 0x06002CE6 RID: 11494 RVA: 0x00015559 File Offset: 0x00013759
		public bool DownloadCompleted
		{
			get
			{
				return this.enum123_0.HasFlag(Class508.Enum123.flag_2);
			}
			set
			{
				if (this.DownloadCompleted != value)
				{
					switch (value)
					{
					case false:
						this.enum123_0 &= ~Class508.Enum123.flag_2;
						break;
					case true:
						this.enum123_0 |= Class508.Enum123.flag_2;
						return;
					default:
						return;
					}
				}
			}
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06002CE7 RID: 11495 RVA: 0x00015593 File Offset: 0x00013793
		public string TargetFile
		{
			get
			{
				if (this.DownloadMethod != Enum75.const_0)
				{
					throw new InvalidOperationException(Class508.string_4);
				}
				return this.string_6;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06002CE8 RID: 11496 RVA: 0x000155AE File Offset: 0x000137AE
		public Stream TargetStream
		{
			get
			{
				if (this.DownloadMethod != Enum75.const_1)
				{
					throw new InvalidOperationException(Class508.string_5);
				}
				return this.stream_0;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06002CE9 RID: 11497 RVA: 0x000155CA File Offset: 0x000137CA
		// (set) Token: 0x06002CEA RID: 11498 RVA: 0x000155D2 File Offset: 0x000137D2
		public Enum75 DownloadMethod { get; private set; }

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06002CEB RID: 11499 RVA: 0x000155DB File Offset: 0x000137DB
		// (set) Token: 0x06002CEC RID: 11500 RVA: 0x000155E3 File Offset: 0x000137E3
		public Uri Target { get; private set; }

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x06002CED RID: 11501 RVA: 0x000155EC File Offset: 0x000137EC
		// (set) Token: 0x06002CEE RID: 11502 RVA: 0x000155F4 File Offset: 0x000137F4
		public int FailureDelay { get; set; }

		// Token: 0x17000B1F RID: 2847
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x000155FD File Offset: 0x000137FD
		// (set) Token: 0x06002CF0 RID: 11504 RVA: 0x00015605 File Offset: 0x00013805
		public bool AllowResuming { get; private set; }

		// Token: 0x17000B20 RID: 2848
		// (get) Token: 0x06002CF1 RID: 11505 RVA: 0x0001560E File Offset: 0x0001380E
		// (set) Token: 0x06002CF2 RID: 11506 RVA: 0x00015616 File Offset: 0x00013816
		public long TotalBytes { get; private set; }

		// Token: 0x17000B21 RID: 2849
		// (get) Token: 0x06002CF3 RID: 11507 RVA: 0x0001561F File Offset: 0x0001381F
		// (set) Token: 0x06002CF4 RID: 11508 RVA: 0x00015627 File Offset: 0x00013827
		public long BytesDownloaded { get; private set; }

		// Token: 0x140001E0 RID: 480
		// (add) Token: 0x06002CF5 RID: 11509 RVA: 0x000ACD0C File Offset: 0x000AAF0C
		// (remove) Token: 0x06002CF6 RID: 11510 RVA: 0x000ACD44 File Offset: 0x000AAF44
		public event EventHandler<EventArgs10> ProgressChanged
		{
			add
			{
				EventHandler<EventArgs10> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs10> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs10> value2 = (EventHandler<EventArgs10>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs10>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs10> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs10> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs10> value2 = (EventHandler<EventArgs10>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs10>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001E1 RID: 481
		// (add) Token: 0x06002CF7 RID: 11511 RVA: 0x000ACD7C File Offset: 0x000AAF7C
		// (remove) Token: 0x06002CF8 RID: 11512 RVA: 0x000ACDB4 File Offset: 0x000AAFB4
		public event EventHandler<EventArgs23> PacketReceived
		{
			add
			{
				EventHandler<EventArgs23> eventHandler = this.eventHandler_1;
				EventHandler<EventArgs23> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs23> value2 = (EventHandler<EventArgs23>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs23>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs23> eventHandler = this.eventHandler_1;
				EventHandler<EventArgs23> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs23> value2 = (EventHandler<EventArgs23>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs23>>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001E2 RID: 482
		// (add) Token: 0x06002CF9 RID: 11513 RVA: 0x000ACDEC File Offset: 0x000AAFEC
		// (remove) Token: 0x06002CFA RID: 11514 RVA: 0x000ACE24 File Offset: 0x000AB024
		public event EventHandler<EventArgs36> DownloadError
		{
			add
			{
				EventHandler<EventArgs36> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs36> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs36> value2 = (EventHandler<EventArgs36>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs36>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs36> eventHandler = this.eventHandler_2;
				EventHandler<EventArgs36> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs36> value2 = (EventHandler<EventArgs36>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs36>>(ref this.eventHandler_2, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001E3 RID: 483
		// (add) Token: 0x06002CFB RID: 11515 RVA: 0x000ACE5C File Offset: 0x000AB05C
		// (remove) Token: 0x06002CFC RID: 11516 RVA: 0x000ACE94 File Offset: 0x000AB094
		public event EventHandler DownloadComplete
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

		// Token: 0x140001E4 RID: 484
		// (add) Token: 0x06002CFD RID: 11517 RVA: 0x000ACECC File Offset: 0x000AB0CC
		// (remove) Token: 0x06002CFE RID: 11518 RVA: 0x000ACF04 File Offset: 0x000AB104
		public event EventHandler<EventArgs2> DownloadSizeAcquired
		{
			add
			{
				EventHandler<EventArgs2> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs2> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs2> value2 = (EventHandler<EventArgs2>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs2>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs2> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs2> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs2> value2 = (EventHandler<EventArgs2>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs2>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001E5 RID: 485
		// (add) Token: 0x06002CFF RID: 11519 RVA: 0x000ACF3C File Offset: 0x000AB13C
		// (remove) Token: 0x06002D00 RID: 11520 RVA: 0x000ACF74 File Offset: 0x000AB174
		public event EventHandler DownloadInitialized
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_5;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001E6 RID: 486
		// (add) Token: 0x06002D01 RID: 11521 RVA: 0x000ACFAC File Offset: 0x000AB1AC
		// (remove) Token: 0x06002D02 RID: 11522 RVA: 0x000ACFE4 File Offset: 0x000AB1E4
		public event EventHandler<EventArgs36> DownloadInitializationFailed
		{
			add
			{
				EventHandler<EventArgs36> eventHandler = this.eventHandler_6;
				EventHandler<EventArgs36> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs36> value2 = (EventHandler<EventArgs36>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs36>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs36> eventHandler = this.eventHandler_6;
				EventHandler<EventArgs36> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs36> value2 = (EventHandler<EventArgs36>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs36>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001E7 RID: 487
		// (add) Token: 0x06002D03 RID: 11523 RVA: 0x000AD01C File Offset: 0x000AB21C
		// (remove) Token: 0x06002D04 RID: 11524 RVA: 0x000AD054 File Offset: 0x000AB254
		public event EventHandler DownloadCanceled
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_7;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_7;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001E8 RID: 488
		// (add) Token: 0x06002D05 RID: 11525 RVA: 0x000AD08C File Offset: 0x000AB28C
		// (remove) Token: 0x06002D06 RID: 11526 RVA: 0x000AD0C4 File Offset: 0x000AB2C4
		public event EventHandler DownloadInititializationCanceled
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_8;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_8, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_8;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_8, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06002D07 RID: 11527 RVA: 0x00015630 File Offset: 0x00013830
		private void method_0()
		{
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002D08 RID: 11528 RVA: 0x0001564B File Offset: 0x0001384B
		private void method_1()
		{
			if (this.eventHandler_8 != null)
			{
				this.eventHandler_8(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002D09 RID: 11529 RVA: 0x00015666 File Offset: 0x00013866
		private void method_2()
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002D0A RID: 11530 RVA: 0x00015681 File Offset: 0x00013881
		private void method_3(Exception ex)
		{
			if (this.eventHandler_6 != null)
			{
				this.eventHandler_6(this, new EventArgs36(ex));
			}
		}

		// Token: 0x06002D0B RID: 11531 RVA: 0x0001569D File Offset: 0x0001389D
		private void method_4()
		{
			if (this.BytesDownloaded > 0L && this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs10(this.BytesDownloaded, this.TotalBytes));
			}
		}

		// Token: 0x06002D0C RID: 11532 RVA: 0x000156D5 File Offset: 0x000138D5
		private void method_5(long packetLength)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, new EventArgs23(packetLength));
			}
		}

		// Token: 0x06002D0D RID: 11533 RVA: 0x000156F1 File Offset: 0x000138F1
		private void method_6(long downloadSize)
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, new EventArgs2(downloadSize));
			}
		}

		// Token: 0x06002D0E RID: 11534 RVA: 0x0001570D File Offset: 0x0001390D
		private void method_7(Exception ex)
		{
			if (this.eventHandler_2 != null)
			{
				this.eventHandler_2(this, new EventArgs36(ex));
			}
		}

		// Token: 0x06002D0F RID: 11535 RVA: 0x00015729 File Offset: 0x00013929
		private void method_8()
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002D10 RID: 11536 RVA: 0x000AD0FC File Offset: 0x000AB2FC
		private void method_9()
		{
			switch (this.DownloadMethod)
			{
			case Enum75.const_0:
				if (File.Exists(this.string_6))
				{
					File.Delete(this.string_6);
				}
				break;
			case Enum75.const_1:
				this.stream_0.Seek(0L, SeekOrigin.Begin);
				this.stream_0.SetLength(0L);
				break;
			}
			this.BytesDownloaded = 0L;
		}

		// Token: 0x06002D11 RID: 11537 RVA: 0x000AD174 File Offset: 0x000AB374
		public void method_10(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException(Class508.string_0);
			}
			if (!(obj is CancellationToken))
			{
				throw new ArgumentException(Class508.string_1, Class508.string_0);
			}
			CancellationToken cancellationToken = (CancellationToken)obj;
			if (this.Initializing)
			{
				throw new NotSupportedException(Class508.string_3);
			}
			try
			{
				try
				{
					this.Initializing = true;
					HttpWebRequest httpWebRequest = null;
					try
					{
						cancellationToken.ThrowIfCancellationRequested();
						this.Initialized = false;
						httpWebRequest = this.Target.smethod_1();
						using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
						{
							if (this.TotalBytes == 0L)
							{
								try
								{
									this.TotalBytes = httpWebResponse.ContentLength;
								}
								catch (NotSupportedException)
								{
									this.TotalBytes = -1L;
								}
							}
							if (this.AllowResuming)
							{
								if (this.DownloadMethod == Enum75.const_1)
								{
									this.BytesDownloaded = this.stream_0.Length;
								}
								else
								{
									FileInfo fileInfo = new FileInfo(this.string_6);
									if (fileInfo.Exists)
									{
										this.BytesDownloaded = fileInfo.Length;
									}
									else
									{
										this.BytesDownloaded = 0L;
									}
								}
								if (this.BytesDownloaded > 0L)
								{
									if (this.TotalBytes > 0L && this.TotalBytes >= this.BytesDownloaded)
									{
										if (this.DownloadMethod == Enum75.const_0)
										{
											DateTime t = httpWebResponse.LastModified.ToUniversalTime();
											DateTime lastWriteTimeUtc = File.GetLastWriteTimeUtc(this.string_6);
											if (t > lastWriteTimeUtc)
											{
												this.method_9();
											}
										}
									}
									else
									{
										this.method_9();
									}
									httpWebRequest.Abort();
									httpWebResponse.Close();
									if (this.BytesDownloaded == this.TotalBytes)
									{
										this.DownloadCompleted = true;
										return;
									}
								}
							}
							else
							{
								this.method_9();
								this.BytesDownloaded = 0L;
							}
						}
					}
					finally
					{
						if (httpWebRequest != null)
						{
							httpWebRequest.Abort();
						}
					}
				}
				finally
				{
					this.Initializing = false;
				}
				this.Initialized = true;
				this.method_6(this.TotalBytes);
				this.method_2();
			}
			catch (OperationCanceledException)
			{
				this.Canceled = true;
				this.method_1();
			}
			catch (Exception ex)
			{
				this.DownloadFailed = true;
				this.method_3(ex);
			}
		}

		// Token: 0x06002D12 RID: 11538 RVA: 0x000AD418 File Offset: 0x000AB618
		public void method_11(object obj)
		{
			if (obj == null)
			{
				throw new ArgumentNullException(Class508.string_0);
			}
			if (!(obj is CancellationToken))
			{
				throw new ArgumentException(Class508.string_1, Class508.string_0);
			}
			CancellationToken cancellationToken = (CancellationToken)obj;
			if (this.DownloadStarted)
			{
				throw new NotSupportedException(Class508.string_2);
			}
			try
			{
				try
				{
					this.DownloadStarted = true;
					this.DownloadAttempts = 0;
					for (;;)
					{
						this.DownloadAttempts++;
						try
						{
							cancellationToken.ThrowIfCancellationRequested();
							if (!this.Initialized && (this.RequiresInitialization || this.AllowResuming))
							{
								this.method_10(cancellationToken);
							}
							cancellationToken.ThrowIfCancellationRequested();
							if (this.DownloadCompleted)
							{
								this.method_5(this.BytesDownloaded);
								this.method_4();
								return;
							}
							HttpWebRequest httpWebRequest = this.Target.smethod_1();
							if (this.AllowResuming && this.BytesDownloaded > 0L)
							{
								httpWebRequest.AddRange(this.BytesDownloaded);
							}
							else
							{
								this.method_9();
								this.BytesDownloaded = 0L;
							}
							using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
							{
								try
								{
									if (this.AllowResuming && this.BytesDownloaded > 0L && httpWebResponse.StatusCode != HttpStatusCode.PartialContent)
									{
										this.method_9();
									}
									if (this.BytesDownloaded > 0L)
									{
										this.method_5(this.BytesDownloaded);
										this.method_4();
									}
									using (Stream responseStream = httpWebResponse.GetResponseStream())
									{
										byte[] array = new byte[4096];
										int num;
										if (this.DownloadMethod == Enum75.const_1)
										{
											this.stream_0.Seek(0L, SeekOrigin.End);
											while ((num = responseStream.Read(array, 0, array.Length)) > 0)
											{
												this.stream_0.Write(array, 0, num);
												this.BytesDownloaded += (long)num;
												this.method_5((long)num);
												this.method_4();
												cancellationToken.ThrowIfCancellationRequested();
											}
										}
										else
										{
											using (Stream stream = File.Open(this.string_6, FileMode.Append, FileAccess.Write, FileShare.None))
											{
												while ((num = responseStream.Read(array, 0, array.Length)) > 0)
												{
													stream.Write(array, 0, num);
													this.BytesDownloaded += (long)num;
													this.method_5((long)num);
													this.method_4();
													cancellationToken.ThrowIfCancellationRequested();
												}
											}
										}
										if (num == 0)
										{
											this.DownloadCompleted = true;
										}
									}
								}
								finally
								{
									httpWebRequest.Abort();
									httpWebResponse.Close();
								}
							}
							break;
						}
						catch (OperationCanceledException)
						{
							throw;
						}
						catch (Exception ex)
						{
							ex.smethod_1(new object[]
							{
								"File: " + this.Target.OriginalString
							});
							if (this.DownloadAttempts >= this.MaxDownloadAttempts)
							{
								throw;
							}
							if (this.FailureDelay > 0 && this.FailureDelay != -1)
							{
								Thread.Sleep(this.FailureDelay);
							}
						}
					}
				}
				finally
				{
					this.DownloadStarted = false;
				}
				this.method_8();
			}
			catch (OperationCanceledException)
			{
				this.Canceled = true;
				this.method_0();
			}
			catch (Exception ex2)
			{
				this.DownloadFailed = true;
				this.method_7(ex2);
			}
		}

		// Token: 0x04001777 RID: 6007
		private static readonly string string_0 = "obj";

		// Token: 0x04001778 RID: 6008
		private static readonly string string_1 = "Must be a valid CancellationToken.";

		// Token: 0x04001779 RID: 6009
		private static readonly string string_2 = "Download has already started.";

		// Token: 0x0400177A RID: 6010
		private static readonly string string_3 = "Download is already being initialized.";

		// Token: 0x0400177B RID: 6011
		private static readonly string string_4 = "IDownloadData is in Stream mode.";

		// Token: 0x0400177C RID: 6012
		private static readonly string string_5 = "IDownloadData is in File mode.";

		// Token: 0x0400177D RID: 6013
		private Class508.Enum123 enum123_0;

		// Token: 0x0400177E RID: 6014
		private string string_6;

		// Token: 0x0400177F RID: 6015
		private Stream stream_0;

		// Token: 0x04001780 RID: 6016
		private EventHandler<EventArgs10> eventHandler_0;

		// Token: 0x04001781 RID: 6017
		private EventHandler<EventArgs23> eventHandler_1;

		// Token: 0x04001782 RID: 6018
		private EventHandler<EventArgs36> eventHandler_2;

		// Token: 0x04001783 RID: 6019
		private EventHandler eventHandler_3;

		// Token: 0x04001784 RID: 6020
		private EventHandler<EventArgs2> eventHandler_4;

		// Token: 0x04001785 RID: 6021
		private EventHandler eventHandler_5;

		// Token: 0x04001786 RID: 6022
		private EventHandler<EventArgs36> eventHandler_6;

		// Token: 0x04001787 RID: 6023
		private EventHandler eventHandler_7;

		// Token: 0x04001788 RID: 6024
		private EventHandler eventHandler_8;

		// Token: 0x04001789 RID: 6025
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400178A RID: 6026
		[CompilerGenerated]
		private int int_1;

		// Token: 0x0400178B RID: 6027
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400178C RID: 6028
		[CompilerGenerated]
		private Enum75 enum75_0;

		// Token: 0x0400178D RID: 6029
		[CompilerGenerated]
		private Uri uri_0;

		// Token: 0x0400178E RID: 6030
		[CompilerGenerated]
		private int int_2;

		// Token: 0x0400178F RID: 6031
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04001790 RID: 6032
		[CompilerGenerated]
		private long long_0;

		// Token: 0x04001791 RID: 6033
		[CompilerGenerated]
		private long long_1;

		// Token: 0x020004B0 RID: 1200
		[Flags]
		private enum Enum123
		{
			// Token: 0x04001793 RID: 6035
			flag_0 = 0,
			// Token: 0x04001794 RID: 6036
			flag_1 = 1,
			// Token: 0x04001795 RID: 6037
			flag_2 = 2,
			// Token: 0x04001796 RID: 6038
			flag_3 = 4,
			// Token: 0x04001797 RID: 6039
			flag_4 = 8,
			// Token: 0x04001798 RID: 6040
			flag_5 = 16,
			// Token: 0x04001799 RID: 6041
			flag_6 = 32
		}
	}
}
