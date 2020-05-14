using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns23;
using ns30;

namespace ns31
{
	// Token: 0x020002FA RID: 762
	internal sealed class Class130 : Class123
	{
		// Token: 0x1400018B RID: 395
		// (add) Token: 0x06001DF0 RID: 7664 RVA: 0x00060FE0 File Offset: 0x0005F1E0
		// (remove) Token: 0x06001DF1 RID: 7665 RVA: 0x00061018 File Offset: 0x0005F218
		public event EventHandler ClientConnected
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

		// Token: 0x1400018C RID: 396
		// (add) Token: 0x06001DF2 RID: 7666 RVA: 0x00061050 File Offset: 0x0005F250
		// (remove) Token: 0x06001DF3 RID: 7667 RVA: 0x00061088 File Offset: 0x0005F288
		public event EventHandler ClientDisconnected
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

		// Token: 0x1400018D RID: 397
		// (add) Token: 0x06001DF4 RID: 7668 RVA: 0x000610C0 File Offset: 0x0005F2C0
		// (remove) Token: 0x06001DF5 RID: 7669 RVA: 0x000610F8 File Offset: 0x0005F2F8
		public event EventHandler ClientError
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_4;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_4;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_4, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x0000B5AD File Offset: 0x000097AD
		// (set) Token: 0x06001DF7 RID: 7671 RVA: 0x0000B5C5 File Offset: 0x000097C5
		public bool Connecting
		{
			get
			{
				return this.enum59_0.HasFlag(Class130.Enum59.flag_1);
			}
			private set
			{
				this.method_4(Class130.Enum59.flag_1, value);
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0000B5CF File Offset: 0x000097CF
		public bool Connected
		{
			get
			{
				return this.socket_0.Connected;
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x0000B5DC File Offset: 0x000097DC
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0000B5F4 File Offset: 0x000097F4
		public bool Disconnecting
		{
			get
			{
				return this.enum59_0.HasFlag(Class130.Enum59.flag_2);
			}
			private set
			{
				this.method_4(Class130.Enum59.flag_2, value);
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x0000B5FE File Offset: 0x000097FE
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0000B616 File Offset: 0x00009816
		public bool WaitingForData
		{
			get
			{
				return this.enum59_0.HasFlag(Class130.Enum59.flag_3);
			}
			private set
			{
				this.method_4(Class130.Enum59.flag_3, value);
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0000B620 File Offset: 0x00009820
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0000B639 File Offset: 0x00009839
		public bool SendingData
		{
			get
			{
				return this.enum59_0.HasFlag(Class130.Enum59.flag_4);
			}
			private set
			{
				this.method_4(Class130.Enum59.flag_4, value);
			}
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0000B644 File Offset: 0x00009844
		private void method_4(Class130.Enum59 state, bool value)
		{
			if (value)
			{
				this.enum59_0 |= state;
				return;
			}
			this.enum59_0 &= ~state;
		}

		// Token: 0x06001E00 RID: 7680 RVA: 0x00061130 File Offset: 0x0005F330
		private Class130()
		{
			this.queue_0 = new Queue<byte[]>();
			this.enum59_0 = Class130.Enum59.flag_0;
		}

		// Token: 0x06001E01 RID: 7681 RVA: 0x0000B667 File Offset: 0x00009867
		protected Class130(int port) : this()
		{
			this.ipendPoint_0 = new IPEndPoint(Class130.ipaddress_0, port);
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0000B680 File Offset: 0x00009880
		protected override void vmethod_0()
		{
			if (this.socket_0 != null)
			{
				this.socket_0.Dispose();
			}
			base.vmethod_0();
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0000B69B File Offset: 0x0000989B
		private void method_5()
		{
			if (this.eventHandler_4 != null)
			{
				this.eventHandler_4(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x00061194 File Offset: 0x0005F394
		protected void method_6(MethodInvoker del)
		{
			try
			{
				del();
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				this.method_5();
			}
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x000611C8 File Offset: 0x0005F3C8
		protected void method_7(MethodInvoker del, MethodInvoker errorDel)
		{
			try
			{
				del();
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				errorDel();
				this.method_5();
			}
		}

		// Token: 0x06001E06 RID: 7686 RVA: 0x00061204 File Offset: 0x0005F404
		public void method_8()
		{
			MethodInvoker methodInvoker = null;
			MethodInvoker methodInvoker2 = null;
			base.method_3();
			lock (this.object_0)
			{
				if (this.enum59_0 == Class130.Enum59.flag_0)
				{
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(this.method_21);
					}
					MethodInvoker del = methodInvoker;
					if (methodInvoker2 == null)
					{
						methodInvoker2 = new MethodInvoker(this.method_22);
					}
					this.method_7(del, methodInvoker2);
				}
			}
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0006127C File Offset: 0x0005F47C
		private void method_9(IAsyncResult asyncResult)
		{
			Class130.Class286 @class = new Class130.Class286();
			@class.iasyncResult_0 = asyncResult;
			@class.class130_0 = this;
			this.method_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x000612B0 File Offset: 0x0005F4B0
		protected void method_10(byte[] data)
		{
			MethodInvoker methodInvoker = null;
			Class130.Class287 @class = new Class130.Class287();
			@class.byte_0 = data;
			@class.class130_0 = this;
			base.method_3();
			lock (this.object_0)
			{
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(@class.method_0);
				}
				this.method_6(methodInvoker);
			}
		}

		// Token: 0x06001E09 RID: 7689 RVA: 0x00061320 File Offset: 0x0005F520
		private void method_11()
		{
			if (this.SendingData)
			{
				return;
			}
			if (this.byte_0 == null || this.byte_0.Length - this.int_2 == 0)
			{
				if (this.queue_0.Count == 0)
				{
					this.byte_0 = null;
					this.int_2 = 0;
					this.int_3 = 0;
					return;
				}
				this.byte_0 = this.queue_0.Dequeue();
				this.int_2 = 0;
			}
			this.SendingData = true;
			this.int_3 = this.byte_0.Length - this.int_2;
			this.int_3 = ((this.int_3 < Class130.int_0) ? this.int_3 : Class130.int_0);
			this.method_6(new MethodInvoker(this.method_23));
		}

		// Token: 0x06001E0A RID: 7690 RVA: 0x000613D8 File Offset: 0x0005F5D8
		private void method_12(IAsyncResult asyncResult)
		{
			Class130.Class288 @class = new Class130.Class288();
			@class.iasyncResult_0 = asyncResult;
			@class.class130_0 = this;
			@class.int_0 = 0;
			this.method_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x00061414 File Offset: 0x0005F614
		public void method_13()
		{
			MethodInvoker methodInvoker = null;
			MethodInvoker methodInvoker2 = null;
			base.method_3();
			lock (this.object_0)
			{
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(this.method_24);
				}
				MethodInvoker del = methodInvoker;
				if (methodInvoker2 == null)
				{
					methodInvoker2 = new MethodInvoker(this.method_25);
				}
				this.method_7(del, methodInvoker2);
			}
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x00061480 File Offset: 0x0005F680
		private void method_14(IAsyncResult asyncResult)
		{
			Class130.Class289 @class = new Class130.Class289();
			@class.iasyncResult_0 = asyncResult;
			@class.class130_0 = this;
			this.method_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0000B6B6 File Offset: 0x000098B6
		private void method_15()
		{
			this.method_6(new MethodInvoker(this.method_26));
		}

		// Token: 0x06001E0E RID: 7694 RVA: 0x000614B4 File Offset: 0x0005F6B4
		private void method_16(IAsyncResult asyncResult)
		{
			Class130.Class290 @class = new Class130.Class290();
			@class.iasyncResult_0 = asyncResult;
			@class.class130_0 = this;
			this.method_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06001E0F RID: 7695 RVA: 0x000614E8 File Offset: 0x0005F6E8
		private void method_17(out int? length)
		{
			byte[] array = null;
			try
			{
				this.method_18(4, out array);
				if (array != null)
				{
					length = new int?(BitConverter.ToInt32(array, 0));
				}
				else
				{
					length = null;
				}
			}
			finally
			{
				array = null;
			}
		}

		// Token: 0x06001E10 RID: 7696 RVA: 0x00061534 File Offset: 0x0005F734
		private void method_18(int iPacketLength, out byte[] data)
		{
			data = null;
			int num = 0;
			for (int i = this.int_5; i < this.list_0.Count; i++)
			{
				if (i == this.int_5)
				{
					num += this.list_0[i].Length - this.int_6;
				}
				else
				{
					num += this.list_0[i].Length;
				}
			}
			if (num < iPacketLength)
			{
				return;
			}
			data = new byte[iPacketLength];
			num = iPacketLength;
			do
			{
				int num2 = this.list_0[this.int_5].Length - this.int_6;
				if (num2 >= num)
				{
					Array.Copy(this.list_0[this.int_5], this.int_6, data, iPacketLength - num, num);
					this.int_6 += num;
					num = 0;
				}
				else
				{
					Array.Copy(this.list_0[this.int_5], this.int_6, data, iPacketLength - num, num2);
					this.int_6 += num2;
					num -= num2;
				}
				if (this.int_6 == this.list_0[this.int_5].Length)
				{
					this.int_5++;
					this.int_6 = 0;
				}
			}
			while (num != 0);
		}

		// Token: 0x06001E11 RID: 7697 RVA: 0x0006166C File Offset: 0x0005F86C
		private void method_19()
		{
			byte[] array = new byte[this.int_4];
			Array.Copy(this.byte_1, array, this.int_4);
			this.list_0.Add(array);
			byte[] array2 = null;
			try
			{
				do
				{
					if (this.nullable_0 == null)
					{
						this.method_17(out this.nullable_0);
					}
					if (this.nullable_0 == null)
					{
						break;
					}
					this.method_18(this.nullable_0.Value, out array2);
					if (array2 != null)
					{
						this.queue_1.Enqueue(array2);
						this.nullable_0 = null;
					}
				}
				while (array2 != null);
			}
			finally
			{
				array2 = null;
			}
			for (int i = 0; i < this.int_5; i++)
			{
				this.list_0.RemoveAt(0);
				this.int_5--;
			}
			this.method_20();
		}

		// Token: 0x06001E12 RID: 7698 RVA: 0x00061748 File Offset: 0x0005F948
		private void method_20()
		{
			try
			{
				for (int i = 0; i < this.queue_1.Count; i++)
				{
					byte[] data = this.queue_1.Dequeue();
					this.vmethod_4(data);
				}
			}
			finally
			{
			}
		}

		// Token: 0x06001E13 RID: 7699 RVA: 0x00005104 File Offset: 0x00003304
		protected void vmethod_3()
		{
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x00005104 File Offset: 0x00003304
		protected void vmethod_4(byte[] data)
		{
		}

		// Token: 0x06001E15 RID: 7701 RVA: 0x00005104 File Offset: 0x00003304
		protected void vmethod_5()
		{
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0000B6CA File Offset: 0x000098CA
		[CompilerGenerated]
		private void method_21()
		{
			this.Connecting = true;
			this.socket_0 = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			this.socket_0.BeginConnect(this.ipendPoint_0, new AsyncCallback(this.method_9), null);
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0000B700 File Offset: 0x00009900
		[CompilerGenerated]
		private void method_22()
		{
			this.Connecting = false;
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x00061798 File Offset: 0x0005F998
		[CompilerGenerated]
		private void method_23()
		{
			if (this.socket_0.Connected)
			{
				this.socket_0.BeginSend(this.byte_0, this.int_2, this.int_3, SocketFlags.None, new AsyncCallback(this.method_12), null);
				return;
			}
			this.method_5();
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x000617E8 File Offset: 0x0005F9E8
		[CompilerGenerated]
		private void method_24()
		{
			if (this.socket_0.Connected)
			{
				if (!this.Disconnecting)
				{
					this.Disconnecting = true;
					this.socket_0.BeginDisconnect(false, new AsyncCallback(this.method_14), null);
					return;
				}
			}
			else if (this.eventHandler_3 != null)
			{
				this.eventHandler_3(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001E1A RID: 7706 RVA: 0x0000B709 File Offset: 0x00009909
		[CompilerGenerated]
		private void method_25()
		{
			this.Disconnecting = false;
		}

		// Token: 0x06001E1B RID: 7707 RVA: 0x00061848 File Offset: 0x0005FA48
		[CompilerGenerated]
		private void method_26()
		{
			if (!this.WaitingForData)
			{
				if (this.socket_0.Connected)
				{
					this.WaitingForData = true;
					this.socket_0.BeginReceive(this.byte_1, 0, Class130.int_1, SocketFlags.None, new AsyncCallback(this.method_16), null);
					return;
				}
				this.method_5();
			}
		}

		// Token: 0x04000B43 RID: 2883
		private static readonly IPAddress ipaddress_0 = new IPAddress(2747615841L);

		// Token: 0x04000B44 RID: 2884
		private static readonly int int_0 = 1024;

		// Token: 0x04000B45 RID: 2885
		private static readonly int int_1 = 1024;

		// Token: 0x04000B46 RID: 2886
		private Socket socket_0;

		// Token: 0x04000B47 RID: 2887
		private IPEndPoint ipendPoint_0;

		// Token: 0x04000B48 RID: 2888
		private EventHandler eventHandler_2;

		// Token: 0x04000B49 RID: 2889
		private EventHandler eventHandler_3;

		// Token: 0x04000B4A RID: 2890
		private EventHandler eventHandler_4;

		// Token: 0x04000B4B RID: 2891
		private Queue<byte[]> queue_0;

		// Token: 0x04000B4C RID: 2892
		private byte[] byte_0;

		// Token: 0x04000B4D RID: 2893
		private int int_2;

		// Token: 0x04000B4E RID: 2894
		private int int_3;

		// Token: 0x04000B4F RID: 2895
		private List<byte[]> list_0 = new List<byte[]>();

		// Token: 0x04000B50 RID: 2896
		private Queue<byte[]> queue_1 = new Queue<byte[]>();

		// Token: 0x04000B51 RID: 2897
		private byte[] byte_1 = new byte[Class130.int_1];

		// Token: 0x04000B52 RID: 2898
		private int int_4;

		// Token: 0x04000B53 RID: 2899
		private int int_5;

		// Token: 0x04000B54 RID: 2900
		private int int_6;

		// Token: 0x04000B55 RID: 2901
		private int? nullable_0 = null;

		// Token: 0x04000B56 RID: 2902
		private Class130.Enum59 enum59_0;

		// Token: 0x04000B57 RID: 2903
		private readonly object object_0 = new object();

		// Token: 0x020002FB RID: 763
		[Flags]
		private enum Enum59
		{
			// Token: 0x04000B59 RID: 2905
			flag_0 = 0,
			// Token: 0x04000B5A RID: 2906
			flag_1 = 1,
			// Token: 0x04000B5B RID: 2907
			flag_2 = 4,
			// Token: 0x04000B5C RID: 2908
			flag_3 = 8,
			// Token: 0x04000B5D RID: 2909
			flag_4 = 16
		}

		// Token: 0x020002FC RID: 764
		[CompilerGenerated]
		private sealed class Class286
		{
			// Token: 0x06001E1E RID: 7710 RVA: 0x000618A0 File Offset: 0x0005FAA0
			public void method_0()
			{
				this.class130_0.Connecting = false;
				this.class130_0.socket_0.EndConnect(this.iasyncResult_0);
				if (this.class130_0.socket_0.Connected)
				{
					this.class130_0.method_15();
					if (this.class130_0.eventHandler_2 != null)
					{
						this.class130_0.eventHandler_2(this.class130_0, EventArgs.Empty);
					}
					this.class130_0.vmethod_3();
					return;
				}
				this.class130_0.method_5();
			}

			// Token: 0x04000B5E RID: 2910
			public Class130 class130_0;

			// Token: 0x04000B5F RID: 2911
			public IAsyncResult iasyncResult_0;
		}

		// Token: 0x020002FD RID: 765
		[CompilerGenerated]
		private sealed class Class287
		{
			// Token: 0x06001E20 RID: 7712 RVA: 0x0000B73B File Offset: 0x0000993B
			public void method_0()
			{
				this.class130_0.queue_0.Enqueue(this.byte_0);
				this.class130_0.method_11();
			}

			// Token: 0x04000B60 RID: 2912
			public Class130 class130_0;

			// Token: 0x04000B61 RID: 2913
			public byte[] byte_0;
		}

		// Token: 0x020002FE RID: 766
		[CompilerGenerated]
		private sealed class Class288
		{
			// Token: 0x06001E22 RID: 7714 RVA: 0x0006192C File Offset: 0x0005FB2C
			public void method_0()
			{
				this.int_0 = this.class130_0.socket_0.EndSend(this.iasyncResult_0, out this.socketError_0);
				this.class130_0.SendingData = false;
				if (this.int_0 > 0)
				{
					if (this.int_0 < this.class130_0.int_3)
					{
						this.class130_0.int_3 = this.int_0;
					}
					this.class130_0.int_2 += this.class130_0.int_3;
					this.class130_0.method_11();
					return;
				}
				if (this.class130_0.socket_0.Connected)
				{
					this.class130_0.method_5();
				}
			}

			// Token: 0x04000B62 RID: 2914
			public SocketError socketError_0;

			// Token: 0x04000B63 RID: 2915
			public int int_0;

			// Token: 0x04000B64 RID: 2916
			public Class130 class130_0;

			// Token: 0x04000B65 RID: 2917
			public IAsyncResult iasyncResult_0;
		}

		// Token: 0x020002FF RID: 767
		[CompilerGenerated]
		private sealed class Class289
		{
			// Token: 0x06001E24 RID: 7716 RVA: 0x000619DC File Offset: 0x0005FBDC
			public void method_0()
			{
				this.class130_0.socket_0.EndDisconnect(this.iasyncResult_0);
				this.class130_0.Disconnecting = false;
				if (this.class130_0.eventHandler_3 != null)
				{
					this.class130_0.eventHandler_3(this.class130_0, EventArgs.Empty);
				}
				this.class130_0.vmethod_5();
			}

			// Token: 0x04000B66 RID: 2918
			public Class130 class130_0;

			// Token: 0x04000B67 RID: 2919
			public IAsyncResult iasyncResult_0;
		}

		// Token: 0x02000300 RID: 768
		[CompilerGenerated]
		private sealed class Class290
		{
			// Token: 0x06001E26 RID: 7718 RVA: 0x00061A40 File Offset: 0x0005FC40
			public void method_0()
			{
				SocketError socketError;
				this.class130_0.int_4 = this.class130_0.socket_0.EndReceive(this.iasyncResult_0, out socketError);
				this.class130_0.WaitingForData = false;
				if (this.class130_0.int_4 > 0)
				{
					this.class130_0.method_19();
					this.class130_0.method_15();
					return;
				}
				if (this.class130_0.socket_0.Connected)
				{
					this.class130_0.method_13();
				}
			}

			// Token: 0x04000B68 RID: 2920
			public Class130 class130_0;

			// Token: 0x04000B69 RID: 2921
			public IAsyncResult iasyncResult_0;
		}
	}
}
