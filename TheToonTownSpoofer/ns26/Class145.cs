using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Timers;
using ns23;
using ns24;
using ns30;

namespace ns26
{
	// Token: 0x02000468 RID: 1128
	internal sealed class Class145 : Class123
	{
		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x060029DB RID: 10715 RVA: 0x000135B9 File Offset: 0x000117B9
		public string PANDA_DOWNLOAD_URL
		{
			get
			{
				return string.Format(Class145.string_1, this.int_2);
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x060029DC RID: 10716 RVA: 0x000135D0 File Offset: 0x000117D0
		public bool Running
		{
			get
			{
				return this.bool_2;
			}
		}

		// Token: 0x060029DD RID: 10717 RVA: 0x000135D8 File Offset: 0x000117D8
		public Class145(int port, Class96 patcher)
		{
			this.class96_0 = patcher;
			this.object_0 = new object();
			this.list_0 = new List<Class145.Class146>();
			this.int_2 = port;
		}

		// Token: 0x060029DE RID: 10718 RVA: 0x000A0700 File Offset: 0x0009E900
		protected override void vmethod_0()
		{
			lock (this.object_0)
			{
				this.method_6();
			}
			base.vmethod_0();
		}

		// Token: 0x060029DF RID: 10719 RVA: 0x000A0748 File Offset: 0x0009E948
		private void method_4(Class145.Class146 data)
		{
			try
			{
				lock (this.object_0)
				{
					if (this.list_0.Contains(data))
					{
						this.list_0.Remove(data);
					}
					if (this.list_0.Count == 0)
					{
						this.timer_0.Enabled = false;
					}
				}
			}
			catch (Exception ex)
			{
				ex.smethod_0();
			}
		}

		// Token: 0x060029E0 RID: 10720 RVA: 0x000A07D0 File Offset: 0x0009E9D0
		private void timer_0_Elapsed(object sender, ElapsedEventArgs e)
		{
			this.timer_0.Enabled = false;
			lock (this.object_0)
			{
				try
				{
					if (!this.bool_2)
					{
						return;
					}
					for (int i = this.list_0.Count - 1; i >= 0; i--)
					{
						if ((DateTime.Now - this.list_0[i].dateTime_0).TotalMilliseconds > (double)Class145.int_1)
						{
							this.method_12(this.list_0[i]);
						}
					}
				}
				catch (Exception ex)
				{
					ex.smethod_0();
				}
				if (this.list_0.Count == 0)
				{
					this.timer_0.Enabled = false;
				}
				else
				{
					this.timer_0.Enabled = true;
				}
			}
		}

		// Token: 0x060029E1 RID: 10721 RVA: 0x000A08B8 File Offset: 0x0009EAB8
		public void method_5()
		{
			WaitCallback waitCallback = null;
			if (!Class463.DesignMode)
			{
				if (waitCallback == null)
				{
					waitCallback = new WaitCallback(this.method_16);
				}
				ThreadPool.UnsafeQueueUserWorkItem(waitCallback, null);
			}
		}

		// Token: 0x060029E2 RID: 10722 RVA: 0x000A08E8 File Offset: 0x0009EAE8
		public void method_6()
		{
			if (!Class463.DesignMode)
			{
				lock (this.object_0)
				{
					if (this.bool_2)
					{
						this.bool_2 = false;
						this.tcpListener_0.Stop();
						this.timer_0.Enabled = false;
						this.method_11();
						this.timer_0.Dispose();
					}
				}
			}
		}

		// Token: 0x060029E3 RID: 10723 RVA: 0x000A0964 File Offset: 0x0009EB64
		private void method_7()
		{
			try
			{
				lock (this.object_0)
				{
					if (this.bool_2)
					{
						this.tcpListener_0.BeginAcceptSocket(new AsyncCallback(this.method_8), null);
					}
				}
			}
			catch (Exception ex)
			{
				ex.smethod_0();
			}
		}

		// Token: 0x060029E4 RID: 10724 RVA: 0x000A09D8 File Offset: 0x0009EBD8
		private void method_8(IAsyncResult ar)
		{
			Socket socket = null;
			try
			{
				socket = this.tcpListener_0.EndAcceptSocket(ar);
			}
			catch (ObjectDisposedException)
			{
				if (base.IsDisposed || base.IsDisposing || !this.bool_2)
				{
					return;
				}
			}
			Class145.Class146 @class = null;
			try
			{
				@class = new Class145.Class146(socket);
				lock (this.object_0)
				{
					this.list_0.Add(@class);
				}
				if (Class145.smethod_2(((IPEndPoint)socket.RemoteEndPoint).Address))
				{
					this.method_9(@class);
				}
				else
				{
					this.method_12(@class);
				}
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				if (@class != null)
				{
					this.method_12(@class);
				}
			}
			this.method_7();
			lock (this.object_0)
			{
				if (!this.timer_0.Enabled)
				{
					this.timer_0.Enabled = true;
				}
			}
		}

		// Token: 0x060029E5 RID: 10725 RVA: 0x000A0AFC File Offset: 0x0009ECFC
		private void method_9(Class145.Class146 data)
		{
			try
			{
				data.dateTime_0 = DateTime.Now;
				data.socket_0.BeginReceive(data.byte_0, 0, Class145.Class146.int_0, SocketFlags.None, new AsyncCallback(this.method_10), data);
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				this.method_12(data);
			}
		}

		// Token: 0x060029E6 RID: 10726 RVA: 0x000A0B5C File Offset: 0x0009ED5C
		private void method_10(IAsyncResult ar)
		{
			Class145.Class146 @class = ar.AsyncState as Class145.Class146;
			if (!@class.IsDisposed && !@class.IsDisposing)
			{
				lock (this.object_0)
				{
					try
					{
						int num = @class.socket_0.EndReceive(ar);
						if (@class.socket_0.Connected)
						{
							if (num > 0)
							{
								@class.stringBuilder_0.Append(Encoding.ASCII.GetString(@class.byte_0, 0, num));
								if (@class.stringBuilder_0.Length <= 8190)
								{
									string text = @class.stringBuilder_0.ToString();
									if (text.EndsWith("\r\n\r\n"))
									{
										string requestedFile;
										string s;
										if (Class145.smethod_1(text, out requestedFile) && this.method_15(@class, requestedFile, out s))
										{
											@class.byte_0 = Encoding.ASCII.GetBytes(s);
											this.method_13(@class);
										}
										else
										{
											this.method_12(@class);
										}
									}
									else
									{
										this.method_9(@class);
									}
								}
								else
								{
									this.method_12(@class);
								}
							}
							else
							{
								this.method_12(@class);
							}
						}
						else
						{
							this.method_4(@class);
							@class.Dispose();
						}
					}
					catch (Exception ex)
					{
						this.method_4(@class);
						@class.Dispose();
						ex.smethod_0();
					}
				}
				return;
			}
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x000A0CB4 File Offset: 0x0009EEB4
		private void method_11()
		{
			lock (this.object_0)
			{
				for (int i = this.list_0.Count - 1; i >= 0; i--)
				{
					this.method_12(this.list_0[i]);
				}
			}
		}

		// Token: 0x060029E8 RID: 10728 RVA: 0x000A0D18 File Offset: 0x0009EF18
		private void method_12(Class145.Class146 data)
		{
			this.method_4(data);
			try
			{
				if (data.socket_0.Connected)
				{
					data.socket_0.BeginDisconnect(false, new AsyncCallback(Class145.smethod_0), data);
				}
				else
				{
					data.Dispose();
				}
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				data.Dispose();
			}
		}

		// Token: 0x060029E9 RID: 10729 RVA: 0x000A0D7C File Offset: 0x0009EF7C
		private static void smethod_0(IAsyncResult ar)
		{
			try
			{
				Class145.Class146 @class = ar.AsyncState as Class145.Class146;
				@class.socket_0.EndDisconnect(ar);
				@class.Dispose();
			}
			catch (Exception ex)
			{
				ex.smethod_0();
			}
		}

		// Token: 0x060029EA RID: 10730 RVA: 0x000A0DC4 File Offset: 0x0009EFC4
		private void method_13(Class145.Class146 data)
		{
			lock (this.object_0)
			{
				int num = data.byte_0.Length - data.int_1;
				data.dateTime_0 = DateTime.Now;
				if (num > 0)
				{
					data.socket_0.BeginSend(data.byte_0, data.int_1, (num > Class145.Class146.int_0) ? Class145.Class146.int_0 : num, SocketFlags.None, new AsyncCallback(this.method_14), data);
				}
				else
				{
					this.method_12(data);
				}
			}
		}

		// Token: 0x060029EB RID: 10731 RVA: 0x000A0E5C File Offset: 0x0009F05C
		private void method_14(IAsyncResult result)
		{
			Class145.Class146 @class = result.AsyncState as Class145.Class146;
			lock (this.object_0)
			{
				@class.int_1 += @class.socket_0.EndSend(result);
			}
			this.method_13(@class);
		}

		// Token: 0x060029EC RID: 10732 RVA: 0x000A0EC4 File Offset: 0x0009F0C4
		private static bool smethod_1(string receivedData, out string requestedFile)
		{
			requestedFile = null;
			if (string.IsNullOrEmpty(receivedData))
			{
				return false;
			}
			string[] array = receivedData.Split(new char[]
			{
				'\r',
				'\n'
			}, StringSplitOptions.RemoveEmptyEntries);
			if (array.Length == 0)
			{
				return false;
			}
			int i = 0;
			while (i < array.Length)
			{
				string[] array2 = array[i].Split(new char[]
				{
					' '
				}, StringSplitOptions.RemoveEmptyEntries);
				if (i != 0)
				{
					i++;
				}
				else
				{
					string a;
					if ((a = array2[i]) == null || (!(a == "GET") && !(a == "HEAD")))
					{
						return false;
					}
					if (array2.Length != 3)
					{
						return false;
					}
					if (!string.IsNullOrEmpty(array2[1]) && !(array2[1] == "*") && !(array2[1] == "/"))
					{
						requestedFile = array2[1];
						return true;
					}
					return false;
				}
			}
			return false;
		}

		// Token: 0x060029ED RID: 10733 RVA: 0x000A0F8C File Offset: 0x0009F18C
		private bool method_15(Class145.Class146 data, string requestedFile, out string response)
		{
			response = null;
			Uri uri = new Uri(new Uri("http://" + ((IPEndPoint)data.socket_0.LocalEndPoint).Address.ToString()), requestedFile);
			string fileName = Path.GetFileName(uri.LocalPath);
			if (fileName != Class145.string_2)
			{
				return false;
			}
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("HTTP/1.1 200 OK\r\n");
			stringBuilder.Append(string.Format("Date: {0:r}\r\n", DateTime.UtcNow));
			stringBuilder.Append(string.Format("Last-Modified: {0:r}\r\n", DateTime.UtcNow));
			stringBuilder.Append("Apache/2.2.3 (Red Hat)\r\n");
			stringBuilder.Append("Connection: close\r\n");
			stringBuilder.Append("Content-Type: text/plain; charset=ISO-8859-1\r\n");
			string text = this.class96_0.method_10(this.PANDA_DOWNLOAD_URL);
			stringBuilder.Append(string.Format("Content-Length: {0}\r\n", text.Length));
			stringBuilder.Append("\r\n");
			stringBuilder.Append(text);
			response = stringBuilder.ToString();
			return true;
		}

		// Token: 0x060029EE RID: 10734 RVA: 0x000A10A0 File Offset: 0x0009F2A0
		private static bool smethod_2(IPAddress ipAddress)
		{
			foreach (IPAddress ipaddress in Dns.GetHostEntry(Class145.string_0).AddressList)
			{
				if (ipaddress.GetAddressBytes().smethod_9(ipAddress.GetAddressBytes()))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060029EF RID: 10735 RVA: 0x000A10EC File Offset: 0x0009F2EC
		[CompilerGenerated]
		private void method_16(object _)
		{
			lock (this.object_0)
			{
				try
				{
					if (!this.bool_2)
					{
						this.bool_2 = true;
						this.tcpListener_0 = new TcpListener(IPAddress.Any, this.int_2);
						this.tcpListener_0.Start();
						this.method_7();
						this.timer_0 = new System.Timers.Timer();
						this.timer_0.Elapsed += this.timer_0_Elapsed;
						this.timer_0.Interval = (double)Class145.int_0;
					}
				}
				catch (Exception ex)
				{
					this.bool_2 = false;
					ex.smethod_1(new object[]
					{
						"Could not start the patch server."
					});
				}
			}
		}

		// Token: 0x040015EE RID: 5614
		private static readonly string string_0 = "LOCALHOST";

		// Token: 0x040015EF RID: 5615
		private static readonly string string_1 = "http://localhost:{0}";

		// Token: 0x040015F0 RID: 5616
		private static readonly string string_2 = "patcher.ver";

		// Token: 0x040015F1 RID: 5617
		private static readonly int int_0 = 5000;

		// Token: 0x040015F2 RID: 5618
		private static readonly int int_1 = 5000;

		// Token: 0x040015F3 RID: 5619
		private TcpListener tcpListener_0;

		// Token: 0x040015F4 RID: 5620
		private int int_2;

		// Token: 0x040015F5 RID: 5621
		private bool bool_2;

		// Token: 0x040015F6 RID: 5622
		private List<Class145.Class146> list_0;

		// Token: 0x040015F7 RID: 5623
		private System.Timers.Timer timer_0;

		// Token: 0x040015F8 RID: 5624
		private readonly object object_0;

		// Token: 0x040015F9 RID: 5625
		private Class96 class96_0;

		// Token: 0x02000469 RID: 1129
		private sealed class Class146 : Class123
		{
			// Token: 0x060029F1 RID: 10737 RVA: 0x00013638 File Offset: 0x00011838
			public Class146(Socket clientSocket)
			{
				this.socket_0 = clientSocket;
			}

			// Token: 0x060029F2 RID: 10738 RVA: 0x0001366D File Offset: 0x0001186D
			protected override void vmethod_0()
			{
				if (this.socket_0 != null)
				{
					this.socket_0.Dispose();
				}
				base.vmethod_0();
			}

			// Token: 0x040015FA RID: 5626
			public static readonly int int_0 = 2048;

			// Token: 0x040015FB RID: 5627
			public Socket socket_0;

			// Token: 0x040015FC RID: 5628
			public byte[] byte_0 = new byte[Class145.Class146.int_0];

			// Token: 0x040015FD RID: 5629
			public DateTime dateTime_0 = DateTime.Now;

			// Token: 0x040015FE RID: 5630
			public StringBuilder stringBuilder_0 = new StringBuilder();

			// Token: 0x040015FF RID: 5631
			public int int_1;
		}
	}
}
