using System;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using ns15;
using ns17;
using ns28;
using ns31;

namespace ns23
{
	// Token: 0x0200039D RID: 925
	internal class Class367 : Interface18
	{
		// Token: 0x140001B4 RID: 436
		// (add) Token: 0x060023DC RID: 9180 RVA: 0x00079574 File Offset: 0x00077774
		// (remove) Token: 0x060023DD RID: 9181 RVA: 0x000795AC File Offset: 0x000777AC
		public event EventHandler<EventArgs25> LogFileCompressed
		{
			add
			{
				EventHandler<EventArgs25> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs25> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs25> value2 = (EventHandler<EventArgs25>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs25>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs25> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs25> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs25> value2 = (EventHandler<EventArgs25>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs25>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060023DE RID: 9182 RVA: 0x0000F71C File Offset: 0x0000D91C
		protected virtual string ProcessName
		{
			get
			{
				return Class156.smethod_0();
			}
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x000795E4 File Offset: 0x000777E4
		private string method_0()
		{
			string result;
			try
			{
				result = this.ProcessName;
			}
			catch (Exception ex)
			{
				result = this.method_6(ex);
			}
			return result;
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060023E0 RID: 9184 RVA: 0x0000F723 File Offset: 0x0000D923
		protected virtual string ThreadName
		{
			get
			{
				return Thread.CurrentThread.Name;
			}
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x00079618 File Offset: 0x00077818
		private string method_1()
		{
			string result;
			try
			{
				result = this.ThreadName;
			}
			catch (Exception ex)
			{
				result = this.method_6(ex);
			}
			return result;
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060023E2 RID: 9186 RVA: 0x0000F72F File Offset: 0x0000D92F
		protected virtual string MachineName
		{
			get
			{
				return Environment.MachineName;
			}
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0007964C File Offset: 0x0007784C
		private string method_2()
		{
			string result;
			try
			{
				result = this.MachineName;
			}
			catch (Exception ex)
			{
				result = this.method_6(ex);
			}
			return result;
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060023E4 RID: 9188 RVA: 0x0000F736 File Offset: 0x0000D936
		protected virtual string AppDomain
		{
			get
			{
				return System.AppDomain.CurrentDomain.FriendlyName;
			}
		}

		// Token: 0x060023E5 RID: 9189 RVA: 0x00079680 File Offset: 0x00077880
		private string method_3()
		{
			string result;
			try
			{
				result = this.AppDomain;
			}
			catch (Exception ex)
			{
				result = this.method_6(ex);
			}
			return result;
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000796B4 File Offset: 0x000778B4
		protected virtual string ProcessID
		{
			get
			{
				return Class156.smethod_1().ToString(NumberFormatInfo.CurrentInfo);
			}
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x000796D4 File Offset: 0x000778D4
		private string method_4()
		{
			string result;
			try
			{
				result = this.ProcessID;
			}
			catch (Exception ex)
			{
				result = this.method_6(ex);
			}
			return result;
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060023E8 RID: 9192 RVA: 0x00079708 File Offset: 0x00077908
		protected virtual string ManagedThreadID
		{
			get
			{
				return Thread.CurrentThread.ManagedThreadId.ToString(NumberFormatInfo.CurrentInfo);
			}
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0007972C File Offset: 0x0007792C
		private string method_5()
		{
			string result;
			try
			{
				result = this.ManagedThreadID;
			}
			catch (Exception ex)
			{
				result = this.method_6(ex);
			}
			return result;
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00079760 File Offset: 0x00077960
		protected string method_6(Exception ex)
		{
			return string.Format(Class217.cultureInfo_0, Class367.string_20, new object[]
			{
				ex.Message
			});
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00079790 File Offset: 0x00077990
		public Class367(string logFile)
		{
			this.string_24 = Path.GetDirectoryName(logFile);
			this.string_23 = Path.GetFileName(logFile);
			this.string_22 = Path.GetFileNameWithoutExtension(this.string_23) + "_{0}" + Path.GetExtension(this.string_23) + ".gz";
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x0000F742 File Offset: 0x0000D942
		public Class367(string directory, string logFile) : this(Path.Combine(directory, logFile))
		{
		}

		// Token: 0x060023ED RID: 9197 RVA: 0x0000F751 File Offset: 0x0000D951
		public void imethod_0(Exception ex)
		{
			this.imethod_1(ex, null);
		}

		// Token: 0x060023EE RID: 9198 RVA: 0x000797E8 File Offset: 0x000779E8
		public void imethod_1(Exception ex, params object[] state)
		{
			using (Mutex mutex = new Mutex(false, string.Format(Class217.cultureInfo_0, "{0}-LOGMUTEX", new object[]
			{
				Class500.Current.Guid
			})))
			{
				if (mutex.WaitOne(1000, true))
				{
					try
					{
						string text = Path.Combine(this.string_24, this.string_23);
						this.method_7(text);
						using (Stream stream = File.Open(text, FileMode.Append, FileAccess.Write, FileShare.None))
						{
							using (StreamWriter streamWriter = new StreamWriter(stream, Class217.encoding_1))
							{
								streamWriter.WriteLine(Class367.string_0);
								DateTime now = DateTime.Now;
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_4, new object[]
								{
									now.ToShortDateString(),
									now.ToShortTimeString()
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_5, new object[]
								{
									ex.GetType().FullName
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_6, new object[]
								{
									ex.Message
								}));
								WebException ex2 = ex as WebException;
								if (ex2 != null)
								{
									streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_18, new object[]
									{
										ex2.Status
									}));
									HttpWebResponse httpWebResponse = ex2.Response as HttpWebResponse;
									if (httpWebResponse != null)
									{
										streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_19, new object[]
										{
											httpWebResponse.StatusCode
										}));
									}
								}
								if (ex.StackTrace != null)
								{
									streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_7, new object[]
									{
										ex.StackTrace
									}));
								}
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_1, new object[]
								{
									Class500.Current.FileVersion
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_2, new object[]
								{
									Environment.OSVersion.ToString()
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_3, new object[]
								{
									Environment.Version
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_8, new object[]
								{
									this.method_2()
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_9, new object[]
								{
									this.method_3()
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_11, new object[]
								{
									this.method_0()
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_10, new object[]
								{
									this.method_4()
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_12, new object[]
								{
									this.method_5()
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_13, new object[]
								{
									this.method_1()
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_14, new object[]
								{
									Thread.CurrentThread.IsThreadPoolThread
								}));
								int num;
								int num2;
								ThreadPool.GetAvailableThreads(out num, out num2);
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_15, new object[]
								{
									num
								}));
								streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_16, new object[]
								{
									num2
								}));
								if (state != null)
								{
									for (int i = 0; i < state.Length; i++)
									{
										streamWriter.WriteLine(string.Format(Class217.cultureInfo_0, Class367.string_17, new object[]
										{
											i,
											state[i].ToString()
										}));
									}
								}
								this.vmethod_0(streamWriter, ex, state);
								streamWriter.WriteLine(Class367.string_21);
							}
						}
					}
					catch
					{
					}
					finally
					{
						mutex.ReleaseMutex();
					}
				}
			}
		}

		// Token: 0x060023EF RID: 9199 RVA: 0x00079CC4 File Offset: 0x00077EC4
		private void method_7(string logFilePath)
		{
			if (!File.Exists(logFilePath))
			{
				return;
			}
			try
			{
				FileInfo fileInfo = new FileInfo(logFilePath);
				if (fileInfo.Length >= (long)Class367.int_0)
				{
					string text = Class266.smethod_0(this.string_24, this.string_22);
					bool flag = false;
					try
					{
						using (FileStream fileStream = fileInfo.OpenRead())
						{
							using (FileStream fileStream2 = File.Open(text, FileMode.Create, FileAccess.Write, FileShare.None))
							{
								using (GZipStream gzipStream = new GZipStream(fileStream2, CompressionMode.Compress))
								{
									fileStream.CopyTo(gzipStream);
								}
							}
						}
						flag = true;
					}
					catch
					{
						flag = false;
						if (File.Exists(text))
						{
							File.Delete(text);
						}
					}
					if (flag)
					{
						if (this.eventHandler_0 != null)
						{
							this.eventHandler_0(this, new EventArgs25(text));
						}
						File.Delete(logFilePath);
					}
				}
			}
			catch
			{
			}
		}

		// Token: 0x060023F0 RID: 9200 RVA: 0x00005104 File Offset: 0x00003304
		protected virtual void vmethod_0(StreamWriter writer, Exception ex, params object[] state)
		{
		}

		// Token: 0x040010AB RID: 4267
		private static readonly int int_0 = 1048576;

		// Token: 0x040010AC RID: 4268
		private static readonly string string_0 = "--------------------header--------------------";

		// Token: 0x040010AD RID: 4269
		private static readonly string string_1 = "Assembly File Version: {0}";

		// Token: 0x040010AE RID: 4270
		private static readonly string string_2 = "OS Version: {0}";

		// Token: 0x040010AF RID: 4271
		private static readonly string string_3 = "CLR: {0}";

		// Token: 0x040010B0 RID: 4272
		private static readonly string string_4 = "Timestamp: {0} {1}";

		// Token: 0x040010B1 RID: 4273
		private static readonly string string_5 = "Type: {0}";

		// Token: 0x040010B2 RID: 4274
		private static readonly string string_6 = "Message: {0}";

		// Token: 0x040010B3 RID: 4275
		private static readonly string string_7 = "Stack: {0}";

		// Token: 0x040010B4 RID: 4276
		private static readonly string string_8 = "Machine: {0}";

		// Token: 0x040010B5 RID: 4277
		private static readonly string string_9 = "Application Domain: {0}";

		// Token: 0x040010B6 RID: 4278
		private static readonly string string_10 = "Process Id: {0}";

		// Token: 0x040010B7 RID: 4279
		private static readonly string string_11 = "Process Name: {0}";

		// Token: 0x040010B8 RID: 4280
		private static readonly string string_12 = "Managed Thread Id: {0}";

		// Token: 0x040010B9 RID: 4281
		private static readonly string string_13 = "Thread Name: {0}";

		// Token: 0x040010BA RID: 4282
		private static readonly string string_14 = "Is on thread pool: {0}";

		// Token: 0x040010BB RID: 4283
		private static readonly string string_15 = "Available worker threads: {0}";

		// Token: 0x040010BC RID: 4284
		private static readonly string string_16 = "Available IO worker threads: {0}";

		// Token: 0x040010BD RID: 4285
		private static readonly string string_17 = "Extended Properties[{0}]: {1}";

		// Token: 0x040010BE RID: 4286
		private static readonly string string_18 = "Web exception status: '{0}'.";

		// Token: 0x040010BF RID: 4287
		private static readonly string string_19 = "Web response status code: '{0}'.";

		// Token: 0x040010C0 RID: 4288
		private static readonly string string_20 = "Unable to read intrinsic property. Error message: {0";

		// Token: 0x040010C1 RID: 4289
		private static readonly string string_21 = "--------------------footer--------------------";

		// Token: 0x040010C2 RID: 4290
		private readonly string string_22;

		// Token: 0x040010C3 RID: 4291
		private readonly string string_23;

		// Token: 0x040010C4 RID: 4292
		private readonly string string_24;

		// Token: 0x040010C5 RID: 4293
		private EventHandler<EventArgs25> eventHandler_0;
	}
}
