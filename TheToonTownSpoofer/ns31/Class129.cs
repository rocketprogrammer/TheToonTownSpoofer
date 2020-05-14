using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using ns14;
using ns16;
using ns18;
using ns19;
using ns21;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns29;
using ns30;

namespace ns31
{
	// Token: 0x020002F5 RID: 757
	internal sealed class Class129 : Class123
	{
		// Token: 0x14000182 RID: 386
		// (add) Token: 0x06001DA1 RID: 7585 RVA: 0x0005F1D8 File Offset: 0x0005D3D8
		// (remove) Token: 0x06001DA2 RID: 7586 RVA: 0x0005F210 File Offset: 0x0005D410
		public event EventHandler ReadingPaused
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

		// Token: 0x14000183 RID: 387
		// (add) Token: 0x06001DA3 RID: 7587 RVA: 0x0005F248 File Offset: 0x0005D448
		// (remove) Token: 0x06001DA4 RID: 7588 RVA: 0x0005F280 File Offset: 0x0005D480
		public event EventHandler<EventArgs0> FileStateRead
		{
			add
			{
				EventHandler<EventArgs0> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs0> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs0> value2 = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs0>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs0> eventHandler = this.eventHandler_3;
				EventHandler<EventArgs0> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs0> value2 = (EventHandler<EventArgs0>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs0>>(ref this.eventHandler_3, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000184 RID: 388
		// (add) Token: 0x06001DA5 RID: 7589 RVA: 0x0005F2B8 File Offset: 0x0005D4B8
		// (remove) Token: 0x06001DA6 RID: 7590 RVA: 0x0005F2F0 File Offset: 0x0005D4F0
		public event EventHandler<EventArgs31> InvasionStateChanged
		{
			add
			{
				EventHandler<EventArgs31> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs31> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs31> value2 = (EventHandler<EventArgs31>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs31>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs31> eventHandler = this.eventHandler_4;
				EventHandler<EventArgs31> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs31> value2 = (EventHandler<EventArgs31>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs31>>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000185 RID: 389
		// (add) Token: 0x06001DA7 RID: 7591 RVA: 0x0005F328 File Offset: 0x0005D528
		// (remove) Token: 0x06001DA8 RID: 7592 RVA: 0x0005F360 File Offset: 0x0005D560
		public event EventHandler<EventArgs22> CoordinatesChanged
		{
			add
			{
				EventHandler<EventArgs22> eventHandler = this.eventHandler_5;
				EventHandler<EventArgs22> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs22> value2 = (EventHandler<EventArgs22>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs22>>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs22> eventHandler = this.eventHandler_5;
				EventHandler<EventArgs22> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs22> value2 = (EventHandler<EventArgs22>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs22>>(ref this.eventHandler_5, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000186 RID: 390
		// (add) Token: 0x06001DA9 RID: 7593 RVA: 0x0005F398 File Offset: 0x0005D598
		// (remove) Token: 0x06001DAA RID: 7594 RVA: 0x0005F3D0 File Offset: 0x0005D5D0
		public event EventHandler<EventArgs37> DistrictChanged
		{
			add
			{
				EventHandler<EventArgs37> eventHandler = this.eventHandler_6;
				EventHandler<EventArgs37> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs37> value2 = (EventHandler<EventArgs37>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs37>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs37> eventHandler = this.eventHandler_6;
				EventHandler<EventArgs37> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs37> value2 = (EventHandler<EventArgs37>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs37>>(ref this.eventHandler_6, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000187 RID: 391
		// (add) Token: 0x06001DAB RID: 7595 RVA: 0x0005F408 File Offset: 0x0005D608
		// (remove) Token: 0x06001DAC RID: 7596 RVA: 0x0005F440 File Offset: 0x0005D640
		public event EventHandler<EventArgs1> AvailableDistrictsChanged
		{
			add
			{
				EventHandler<EventArgs1> eventHandler = this.eventHandler_7;
				EventHandler<EventArgs1> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs1> value2 = (EventHandler<EventArgs1>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs1>>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs1> eventHandler = this.eventHandler_7;
				EventHandler<EventArgs1> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs1> value2 = (EventHandler<EventArgs1>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs1>>(ref this.eventHandler_7, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x14000188 RID: 392
		// (add) Token: 0x06001DAD RID: 7597 RVA: 0x0005F478 File Offset: 0x0005D678
		// (remove) Token: 0x06001DAE RID: 7598 RVA: 0x0005F4B0 File Offset: 0x0005D6B0
		public event EventHandler NoInvasionDetected
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

		// Token: 0x14000189 RID: 393
		// (add) Token: 0x06001DAF RID: 7599 RVA: 0x0005F4E8 File Offset: 0x0005D6E8
		// (remove) Token: 0x06001DB0 RID: 7600 RVA: 0x0005F520 File Offset: 0x0005D720
		public event EventHandler<EventArgs30> PlaygroundChanged
		{
			add
			{
				EventHandler<EventArgs30> eventHandler = this.eventHandler_9;
				EventHandler<EventArgs30> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs30> value2 = (EventHandler<EventArgs30>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs30>>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs30> eventHandler = this.eventHandler_9;
				EventHandler<EventArgs30> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs30> value2 = (EventHandler<EventArgs30>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs30>>(ref this.eventHandler_9, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x1400018A RID: 394
		// (add) Token: 0x06001DB1 RID: 7601 RVA: 0x0005F558 File Offset: 0x0005D758
		// (remove) Token: 0x06001DB2 RID: 7602 RVA: 0x0005F590 File Offset: 0x0005D790
		public event EventHandler LoggedOut
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_10;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_10;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_10, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0000B2A4 File Offset: 0x000094A4
		public string LogFileName
		{
			get
			{
				return this.string_0;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001DB4 RID: 7604 RVA: 0x0005F5C8 File Offset: 0x0005D7C8
		public bool Running
		{
			get
			{
				bool result;
				lock (this.object_0)
				{
					result = this.bool_2;
				}
				return result;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0005F60C File Offset: 0x0005D80C
		private bool HasData
		{
			get
			{
				bool result;
				lock (this.object_0)
				{
					result = (this.stream_0.Length != this.stream_0.Position);
				}
				return result;
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06001DB6 RID: 7606 RVA: 0x0000B2AC File Offset: 0x000094AC
		// (set) Token: 0x06001DB7 RID: 7607 RVA: 0x0005F664 File Offset: 0x0005D864
		public Enum92 LogMonitoringPrecision
		{
			get
			{
				return this.enum92_0;
			}
			set
			{
				this.enum92_0 = value;
				switch (this.enum92_0)
				{
				case Enum92.const_0:
					this.int_1 = 1000;
					return;
				case Enum92.const_2:
					this.int_1 = 10;
					return;
				}
				this.int_1 = 500;
			}
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
		private Class129()
		{
			this.LogMonitoringPrecision = Enum92.const_1;
			this.stringBuilder_0 = new StringBuilder();
			this.byte_0 = new byte[Class129.int_0];
			this.object_0 = new object();
			this.manualResetEventSlim_0 = new ManualResetEventSlim(false);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x0000B2B4 File Offset: 0x000094B4
		public Class129(Stream str) : this()
		{
			this.stream_0 = str;
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x0000B2C3 File Offset: 0x000094C3
		public Class129(string logFile) : this()
		{
			this.string_0 = logFile;
			this.stream_0 = new FileStream(this.string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x0000B2E6 File Offset: 0x000094E6
		protected override void vmethod_0()
		{
			this.method_5();
			this.manualResetEventSlim_0.Dispose();
			this.stringBuilder_0.Clear();
			base.vmethod_0();
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x0005F70C File Offset: 0x0005D90C
		public void method_4()
		{
			lock (this.object_0)
			{
				if (!this.bool_2)
				{
					this.bool_2 = true;
					this.manualResetEventSlim_0.Reset();
					this.stream_0.BeginRead(this.byte_0, 0, Class129.int_0, new AsyncCallback(this.method_7), null);
				}
			}
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x0005F788 File Offset: 0x0005D988
		public void method_5()
		{
			bool flag = false;
			try
			{
				Monitor.Enter(this.object_0, ref flag);
				if (this.bool_2)
				{
					using (this.manualResetEventSlim_1 = new ManualResetEventSlim(false))
					{
						this.bool_2 = false;
						this.manualResetEventSlim_0.Set();
						if (flag)
						{
							flag = false;
							Monitor.Exit(this.object_0);
						}
						this.manualResetEventSlim_1.Wait();
						this.stream_0.Dispose();
					}
				}
			}
			finally
			{
				if (flag)
				{
					Monitor.Exit(this.object_0);
				}
				if (!base.IsDisposing)
				{
					base.Dispose();
				}
			}
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x0000B30B File Offset: 0x0000950B
		private void method_6()
		{
			while (this.bool_2 && !this.HasData)
			{
				this.manualResetEventSlim_0.Wait(this.int_1);
			}
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x0005F840 File Offset: 0x0005DA40
		private void method_7(IAsyncResult asyncResult)
		{
			try
			{
				int num;
				lock (this.object_0)
				{
					num = this.stream_0.EndRead(asyncResult);
				}
				int i = 0;
				while (i < num)
				{
					char c = (char)this.byte_0[i];
					if (c == '\n')
					{
						goto IL_61;
					}
					if (c == '\r')
					{
						goto IL_61;
					}
					this.stringBuilder_0.Append((char)this.byte_0[i]);
					IL_B9:
					i++;
					continue;
					IL_61:
					if (this.stringBuilder_0.Length > 0)
					{
						lock (this.object_0)
						{
							if (!this.bool_2)
							{
								return;
							}
							this.method_19(this.stringBuilder_0.ToString());
						}
						this.stringBuilder_0.Clear();
						goto IL_B9;
					}
					goto IL_B9;
				}
				if (!this.HasData)
				{
					if (this.eventHandler_2 != null)
					{
						this.eventHandler_2(this, EventArgs.Empty);
					}
					this.method_6();
				}
			}
			finally
			{
				lock (this.object_0)
				{
					if (this.manualResetEventSlim_1 == null)
					{
						if (this.bool_2)
						{
							this.stream_0.BeginRead(this.byte_0, 0, Class129.int_0, new AsyncCallback(this.method_7), null);
						}
					}
					else
					{
						this.manualResetEventSlim_1.Set();
					}
				}
			}
		}

		// Token: 0x06001DC0 RID: 7616 RVA: 0x0000B332 File Offset: 0x00009532
		private void method_8()
		{
			if (this.eventHandler_8 != null)
			{
				this.eventHandler_8(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001DC1 RID: 7617 RVA: 0x0000B34D File Offset: 0x0000954D
		private void method_9(Class309 state)
		{
			if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, new EventArgs0(state));
			}
		}

		// Token: 0x06001DC2 RID: 7618 RVA: 0x0000B369 File Offset: 0x00009569
		private void method_10(Struct26 state)
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, new EventArgs31(state));
			}
		}

		// Token: 0x06001DC3 RID: 7619 RVA: 0x0000B385 File Offset: 0x00009585
		private void method_11(Struct56 coords)
		{
			if (this.eventHandler_5 != null)
			{
				this.eventHandler_5(this, new EventArgs22(coords));
			}
		}

		// Token: 0x06001DC4 RID: 7620 RVA: 0x0000B3A1 File Offset: 0x000095A1
		private void method_12(uint shardID)
		{
			if (this.eventHandler_6 != null)
			{
				this.eventHandler_6(this, new EventArgs37(shardID));
			}
		}

		// Token: 0x06001DC5 RID: 7621 RVA: 0x0000B3BD File Offset: 0x000095BD
		private void method_13()
		{
			if (this.eventHandler_10 != null)
			{
				this.eventHandler_10(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001DC6 RID: 7622 RVA: 0x0000B3D8 File Offset: 0x000095D8
		private void method_14(HashSet<uint> shards)
		{
			if (this.eventHandler_7 != null)
			{
				this.eventHandler_7(this, new EventArgs1(shards));
			}
		}

		// Token: 0x06001DC7 RID: 7623 RVA: 0x0005F9D4 File Offset: 0x0005DBD4
		private void method_15(string filePath, string fileName)
		{
			string key;
			switch (key = fileName.ToLower())
			{
			case "estate_1.dna":
				this.method_17(Enum57.const_1);
				return;
			case "toontown_central_sz.dna":
				this.method_17(Enum57.const_2);
				return;
			case "toontown_central_2300.dna":
				this.method_17(Enum57.const_4);
				return;
			case "toontown_central_2200.dna":
				this.method_17(Enum57.const_3);
				return;
			case "toontown_central_2100.dna":
				this.method_17(Enum57.const_5);
				return;
			case "goofy_speedway_sz.dna":
				this.method_17(Enum57.const_6);
				return;
			case "outdoor_zone_sz.dna":
				this.method_17(Enum57.const_7);
				return;
			case "golf_zone_sz.dna":
				this.method_17(Enum57.const_8);
				return;
			case "daisys_garden_sz.dna":
				this.method_17(Enum57.const_9);
				return;
			case "daisys_garden_5200.dna":
				this.method_17(Enum57.const_11);
				return;
			case "daisys_garden_5100.dna":
				this.method_17(Enum57.const_10);
				return;
			case "daisys_garden_5300.dna":
				this.method_17(Enum57.const_12);
				return;
			case "donalds_dock_sz.dna":
				this.method_17(Enum57.const_13);
				return;
			case "donalds_dock_1300.dna":
				this.method_17(Enum57.const_15);
				return;
			case "donalds_dock_1200.dna":
				this.method_17(Enum57.const_16);
				return;
			case "donalds_dock_1100.dna":
				this.method_17(Enum57.const_14);
				return;
			case "minnies_melody_land_sz.dna":
				this.method_17(Enum57.const_17);
				return;
			case "minnies_melody_land_4300.dna":
				this.method_17(Enum57.const_20);
				return;
			case "minnies_melody_land_4200.dna":
				this.method_17(Enum57.const_19);
				return;
			case "minnies_melody_land_4100.dna":
				this.method_17(Enum57.const_18);
				return;
			case "the_burrrgh_sz.dna":
				this.method_17(Enum57.const_21);
				return;
			case "the_burrrgh_3300.dna":
				this.method_17(Enum57.const_22);
				return;
			case "the_burrrgh_3100.dna":
				this.method_17(Enum57.const_24);
				return;
			case "the_burrrgh_3200.dna":
				this.method_17(Enum57.const_23);
				return;
			case "donalds_dreamland_sz.dna":
				this.method_17(Enum57.const_25);
				return;
			case "donalds_dreamland_9100.dna":
				this.method_17(Enum57.const_26);
				return;
			case "donalds_dreamland_9200.dna":
				this.method_17(Enum57.const_27);
				return;
			case "cog_hq_cashbot_sz.dna":
				this.method_17(Enum57.const_29);
				return;
			case "cog_hq_sellbot_sz.dna":
				this.method_17(Enum57.const_30);
				return;
			case "cog_hq_lawbot_sz.dna":
				this.method_17(Enum57.const_31);
				return;
			case "party_sz.dna":
				this.method_17(Enum57.const_32);
				break;

				return;
			}
		}

		// Token: 0x06001DC8 RID: 7624 RVA: 0x0005FD38 File Offset: 0x0005DF38
		private void method_16(string id)
		{
			if (id != null)
			{
				if (!(id == "10000"))
				{
					return;
				}
				this.method_17(Enum57.const_28);
			}
		}

		// Token: 0x06001DC9 RID: 7625 RVA: 0x0000B3F4 File Offset: 0x000095F4
		private void method_17(Enum57 playground)
		{
			if (this.eventHandler_9 != null)
			{
				this.eventHandler_9(this, new EventArgs30(playground));
			}
		}

		// Token: 0x06001DCA RID: 7626 RVA: 0x0000B410 File Offset: 0x00009610
		private void method_18()
		{
			this.method_17(Enum57.const_0);
		}

		// Token: 0x06001DCB RID: 7627 RVA: 0x0005FD60 File Offset: 0x0005DF60
		public bool method_19(string line)
		{
			if (string.IsNullOrEmpty(line))
			{
				return false;
			}
			char c = line[0];
			DateTime dateTime;
			string line2;
			if (c != ':')
			{
				Struct56? @struct;
				if (c != 'C')
				{
					if (c == '{')
					{
						HashSet<uint> shards;
						if (Class129.smethod_4(line, out shards))
						{
							this.method_14(shards);
							return true;
						}
					}
				}
				else if (line.StartsWith("Current position") && Class129.smethod_17(line, out @struct))
				{
					this.method_11(@struct.Value);
					return true;
				}
			}
			else if (Class129.smethod_16(line, out dateTime, out line2))
			{
				Struct26? struct2;
				if (Class129.smethod_15(line2, out struct2))
				{
					this.bool_3 = false;
					this.method_10(struct2.Value);
					return true;
				}
				string line3;
				if (Class129.smethod_6(line2, out line3))
				{
					uint shardID;
					if (Class129.smethod_8(line3, out shardID))
					{
						this.bool_3 = true;
						this.method_12(shardID);
						return true;
					}
					if (Class129.smethod_7(line3))
					{
						this.bool_3 = false;
						this.method_13();
						return true;
					}
				}
				else
				{
					if (this.bool_3 && Class129.smethod_3(line2))
					{
						this.bool_3 = false;
						this.method_8();
						return true;
					}
					string line4;
					string text;
					if (Class129.smethod_14(line2, out line4))
					{
						string fileName;
						if (Class129.smethod_13(line4, out fileName))
						{
							this.class309_0 = new Class309(fileName);
							return true;
						}
						if (this.class309_0 != null)
						{
							bool flag;
							if (Class129.smethod_12(line4, out flag))
							{
								this.class309_0.FileExists = flag;
								if (!flag)
								{
									this.method_9(this.class309_0);
								}
								return true;
							}
							string clientMd;
							string expectedMd;
							if (Class129.smethod_10(line4, out clientMd, out expectedMd))
							{
								this.class309_0.ClientMd5 = clientMd;
								this.class309_0.ExpectedMd5 = expectedMd;
								return true;
							}
							int clientSize;
							int expectedSize;
							if (Class129.smethod_9(line4, out clientSize, out expectedSize))
							{
								this.class309_0.ClientSize = clientSize;
								this.class309_0.ExpectedSize = expectedSize;
								return true;
							}
							bool upToDate;
							if (Class129.smethod_11(line4, out upToDate))
							{
								this.class309_0.UpToDate = upToDate;
								this.method_9(this.class309_0);
								this.class309_0 = null;
								return true;
							}
						}
					}
					else if (Class129.smethod_2(line2, out text))
					{
						int num = 0;
						string fileName2;
						if (text.smethod_15('/', ref num) && text.smethod_7(ref num, out fileName2))
						{
							this.method_15(text, fileName2);
							return true;
						}
					}
					else
					{
						string id;
						if (Class129.smethod_1(line2, out id))
						{
							this.method_16(id);
							return true;
						}
						if (Class129.smethod_0(line2))
						{
							this.method_18();
							return true;
						}
					}
				}
			}
			return false;
		}

		// Token: 0x06001DCC RID: 7628 RVA: 0x0000B419 File Offset: 0x00009619
		private static bool smethod_0(string line)
		{
			return line.smethod_12("StateData: AvatarChooser.enter");
		}

		// Token: 0x06001DCD RID: 7629 RVA: 0x0005FF98 File Offset: 0x0005E198
		private static bool smethod_1(string line, out string id)
		{
			int num = 0;
			id = null;
			return line.smethod_10("BossbotCogHQLoader: loadPlaceGeom: ", ref num) && line.smethod_7(ref num, out id);
		}

		// Token: 0x06001DCE RID: 7630 RVA: 0x0005FFC4 File Offset: 0x0005E1C4
		private static bool smethod_2(string line, out string filePath)
		{
			int num = 0;
			filePath = null;
			return line.smethod_10(":dna: Reading ", ref num) && line.smethod_7(ref num, out filePath);
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0000B426 File Offset: 0x00009626
		private static bool smethod_3(string line)
		{
			return line.smethod_12("DistributedToon: calling LocalAvatar.startchat");
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0005FFF0 File Offset: 0x0005E1F0
		private static bool smethod_4(string line, out HashSet<uint> shards)
		{
			shards = null;
			int num = 0;
			if (!line.smethod_9('{', ref num))
			{
				return false;
			}
			shards = new HashSet<uint>();
			uint item;
			while (Class129.smethod_5(line, ref num, out item))
			{
				if (!shards.Contains(item))
				{
					shards.Add(item);
				}
				if (!line.smethod_10(", ", ref num))
				{
					break;
				}
			}
			return true;
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00060048 File Offset: 0x0005E248
		private static bool smethod_5(string line, ref int startIndex, out uint shard)
		{
			shard = 0U;
			string s;
			return line.smethod_8(':', ref startIndex, out s) && uint.TryParse(s, out shard) && line.smethod_10(" <toontown.distributed.ToontownDistrict.ToontownDistrict instance at ", ref startIndex) && line.smethod_9('>', ref startIndex);
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00060090 File Offset: 0x0005E290
		private static bool smethod_6(string line, out string data)
		{
			data = null;
			int num = 0;
			if (!line.smethod_10("OTPClientRepository: ", ref num))
			{
				return false;
			}
			string text;
			if (!line.smethod_7(ref num, out text))
			{
				return false;
			}
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			data = text;
			return true;
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0000B433 File Offset: 0x00009633
		private static bool smethod_7(string line)
		{
			return line.smethod_12("Exiting shard");
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x000600D0 File Offset: 0x0005E2D0
		private static bool smethod_8(string line, out uint shardID)
		{
			shardID = 0U;
			int num = 0;
			string s;
			return line.smethod_10("Entering shard ", ref num) && line.smethod_7(ref num, out s) && uint.TryParse(s, out shardID);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00060108 File Offset: 0x0005E308
		private static bool smethod_9(string line, out int clientSize, out int expectedSize)
		{
			clientSize = 0;
			expectedSize = 0;
			int num = 0;
			if (!line.smethod_10("clientSize: ", ref num))
			{
				return false;
			}
			string text;
			if (!line.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			int num2;
			if (!int.TryParse(text.Trim(), out num2))
			{
				return false;
			}
			if (!line.smethod_10("expectedSize: ", ref num))
			{
				return false;
			}
			if (!line.smethod_7(ref num, out text))
			{
				return false;
			}
			int num3;
			if (!int.TryParse(text.Trim(), out num3))
			{
				return false;
			}
			clientSize = num2;
			expectedSize = num3;
			return true;
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00060188 File Offset: 0x0005E388
		private static bool smethod_10(string line, out string clientMd5, out string expectedMd5)
		{
			clientMd5 = null;
			expectedMd5 = null;
			int num = 0;
			if (!line.smethod_10("clientMd5: ", ref num))
			{
				return false;
			}
			string text;
			if (!line.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			if (!line.smethod_10("expectedMd5: ", ref num))
			{
				return false;
			}
			string text2;
			if (!line.smethod_7(ref num, out text2))
			{
				return false;
			}
			text = text.Trim().ToLower();
			text2 = text2.Trim().ToLower();
			if (text.Length != 32)
			{
				return false;
			}
			if (text2.Length != 32)
			{
				return false;
			}
			clientMd5 = text;
			expectedMd5 = text2;
			return true;
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x0000B445 File Offset: 0x00009645
		private static bool smethod_11(string line, out bool upToDate)
		{
			upToDate = false;
			if (line.smethod_12("file is up to date"))
			{
				upToDate = true;
				return true;
			}
			if (line.smethod_12("file is not valid"))
			{
				upToDate = false;
				return true;
			}
			return false;
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x0000B46F File Offset: 0x0000966F
		private static bool smethod_12(string line, out bool exists)
		{
			exists = false;
			if (line.smethod_12("file exists"))
			{
				exists = true;
				return true;
			}
			if (line.smethod_12("file does not exist"))
			{
				exists = false;
				return true;
			}
			return false;
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00060214 File Offset: 0x0005E414
		private static bool smethod_13(string line, out string phaseName)
		{
			phaseName = null;
			int num = 0;
			if (!line.smethod_10("working on: ", ref num))
			{
				return false;
			}
			line.smethod_10("./", ref num);
			string text;
			if (!line.smethod_7(ref num, out text))
			{
				return false;
			}
			text = text.ToLower();
			if (text.IndexOf(".mf") == -1)
			{
				return false;
			}
			phaseName = text;
			return true;
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00060270 File Offset: 0x0005E470
		private static bool smethod_14(string line, out string data)
		{
			data = null;
			int num = 0;
			if (!line.smethod_10("Launcher: ", ref num))
			{
				return false;
			}
			string text;
			if (!line.smethod_7(ref num, out text))
			{
				return false;
			}
			data = text;
			return true;
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x000602A8 File Offset: 0x0005E4A8
		private static bool smethod_15(string line, out Struct26? state)
		{
			state = null;
			int num = 0;
			if (!line.smethod_10("msgType: ", ref num))
			{
				return false;
			}
			string text;
			if (!line.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			byte msgType;
			if (!byte.TryParse(text, out msgType))
			{
				return false;
			}
			if (!line.smethod_10("cogType: ", ref num))
			{
				return false;
			}
			if (!line.smethod_8(',', ref num, out text))
			{
				return false;
			}
			string key = text;
			if (!line.smethod_10("numRemaining: ", ref num))
			{
				return false;
			}
			if (!line.smethod_8(',', ref num, out text))
			{
				return false;
			}
			uint cogsRemaining;
			if (!uint.TryParse(text, out cogsRemaining))
			{
				return false;
			}
			if (!line.smethod_10("skeleton: ", ref num))
			{
				return false;
			}
			if (!line.smethod_7(ref num, out text))
			{
				return false;
			}
			int num2;
			if (!int.TryParse(text, out num2))
			{
				return false;
			}
			Class464 cog;
			if (Class464.Cogs.ContainsKey(key))
			{
				cog = Class464.Cogs[key];
			}
			else
			{
				cog = Class464.class464_0;
			}
			state = new Struct26?(new Struct26((Enum97)msgType, cog, cogsRemaining, num2 != 0));
			return true;
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x000603A8 File Offset: 0x0005E5A8
		private static bool smethod_16(string line, out DateTime dateTime, out string data)
		{
			dateTime = default(DateTime);
			data = null;
			int num = 1;
			string s = null;
			if (!line.smethod_8('-', ref num, out s))
			{
				return false;
			}
			byte month;
			if (!byte.TryParse(s, out month))
			{
				return false;
			}
			if (!line.smethod_8('-', ref num, out s))
			{
				return false;
			}
			byte day;
			if (!byte.TryParse(s, out day))
			{
				return false;
			}
			if (!line.smethod_8(' ', ref num, out s))
			{
				return false;
			}
			short year;
			if (!short.TryParse(s, out year))
			{
				return false;
			}
			if (!line.smethod_8(':', ref num, out s))
			{
				return false;
			}
			byte hour;
			if (!byte.TryParse(s, out hour))
			{
				return false;
			}
			if (!line.smethod_8(':', ref num, out s))
			{
				return false;
			}
			byte minute;
			if (!byte.TryParse(s, out minute))
			{
				return false;
			}
			if (!line.smethod_8(' ', ref num, out s))
			{
				return false;
			}
			byte second;
			if (!byte.TryParse(s, out second))
			{
				return false;
			}
			dateTime = new DateTime((int)year, (int)month, (int)day, (int)hour, (int)minute, (int)second);
			if (num >= line.Length)
			{
				data = null;
			}
			else
			{
				data = line.Substring(num);
			}
			return true;
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00060498 File Offset: 0x0005E698
		private static bool smethod_17(string line, out Struct56? coords)
		{
			coords = null;
			int num = 0;
			if (!line.smethod_9('=', ref num))
			{
				return false;
			}
			if (!line.smethod_9('(', ref num))
			{
				return false;
			}
			string text;
			if (!line.smethod_8(')', ref num, out text))
			{
				return false;
			}
			string[] array = text.Split(new char[]
			{
				',',
				' '
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length != 3)
			{
				return false;
			}
			float x;
			if (!float.TryParse(array[0], out x))
			{
				return false;
			}
			float y;
			if (!float.TryParse(array[1], out y))
			{
				return false;
			}
			float z;
			if (!float.TryParse(array[2], out z))
			{
				return false;
			}
			if (!line.smethod_10(": ", ref num))
			{
				return false;
			}
			if (!line.smethod_8(',', ref num, out text))
			{
				return false;
			}
			float num2;
			if (!float.TryParse(text, out num2))
			{
				return false;
			}
			num2 %= 360f;
			if (num2 < 0f)
			{
				num2 += 360f;
			}
			coords = new Struct56?(new Struct56(x, y, z, num2));
			return true;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0006058C File Offset: 0x0005E78C
		public static void smethod_18(string directory, int maxLogFiles)
		{
			IEnumerable<string> source = Class234.smethod_1(directory, "toontown-*.log", ".log");
			if (Class129.func_0 == null)
			{
				Class129.func_0 = new Func<string, string>(Class129.smethod_19);
			}
			string[] array = source.OrderByDescending(Class129.func_0).Skip(maxLogFiles).ToArray<string>();
			foreach (string text in array)
			{
				try
				{
					File.Delete(text);
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						text
					});
				}
			}
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0000B499 File Offset: 0x00009699
		[CompilerGenerated]
		private static string smethod_19(string file)
		{
			return file;
		}

		// Token: 0x04000B06 RID: 2822
		private static readonly int int_0 = 1024;

		// Token: 0x04000B07 RID: 2823
		private Enum92 enum92_0;

		// Token: 0x04000B08 RID: 2824
		private bool bool_2;

		// Token: 0x04000B09 RID: 2825
		private Stream stream_0;

		// Token: 0x04000B0A RID: 2826
		private Class309 class309_0;

		// Token: 0x04000B0B RID: 2827
		private int int_1 = 500;

		// Token: 0x04000B0C RID: 2828
		private readonly string string_0;

		// Token: 0x04000B0D RID: 2829
		private readonly object object_0;

		// Token: 0x04000B0E RID: 2830
		private readonly byte[] byte_0;

		// Token: 0x04000B0F RID: 2831
		private readonly StringBuilder stringBuilder_0;

		// Token: 0x04000B10 RID: 2832
		private readonly ManualResetEventSlim manualResetEventSlim_0;

		// Token: 0x04000B11 RID: 2833
		private ManualResetEventSlim manualResetEventSlim_1;

		// Token: 0x04000B12 RID: 2834
		private bool bool_3;

		// Token: 0x04000B13 RID: 2835
		private EventHandler eventHandler_2;

		// Token: 0x04000B14 RID: 2836
		private EventHandler<EventArgs0> eventHandler_3;

		// Token: 0x04000B15 RID: 2837
		private EventHandler<EventArgs31> eventHandler_4;

		// Token: 0x04000B16 RID: 2838
		private EventHandler<EventArgs22> eventHandler_5;

		// Token: 0x04000B17 RID: 2839
		private EventHandler<EventArgs37> eventHandler_6;

		// Token: 0x04000B18 RID: 2840
		private EventHandler<EventArgs1> eventHandler_7;

		// Token: 0x04000B19 RID: 2841
		private EventHandler eventHandler_8;

		// Token: 0x04000B1A RID: 2842
		private EventHandler<EventArgs30> eventHandler_9;

		// Token: 0x04000B1B RID: 2843
		private EventHandler eventHandler_10;

		// Token: 0x04000B1C RID: 2844
		[CompilerGenerated]
		private static Func<string, string> func_0;
	}
}
