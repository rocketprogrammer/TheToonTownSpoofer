using System;
using System.IO;
using System.Text;
using ns17;
using ns23;
using ns30;
using ns31;

namespace ns22
{
	// Token: 0x02000367 RID: 871
	internal static class Class335
	{
		// Token: 0x06002227 RID: 8743 RVA: 0x0007424C File Offset: 0x0007244C
		static Class335()
		{
			Class335.string_11 = null;
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x06002228 RID: 8744 RVA: 0x000742D4 File Offset: 0x000724D4
		private static string DateTimeStamp
		{
			get
			{
				return DateTime.Now.ToString(Class335.string_7);
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x06002229 RID: 8745 RVA: 0x0000E4A2 File Offset: 0x0000C6A2
		public static string LogFile
		{
			get
			{
				return Class335.string_11;
			}
		}

		// Token: 0x0600222A RID: 8746 RVA: 0x000742F4 File Offset: 0x000724F4
		public static void smethod_0(string logDirectory)
		{
			if (!Class335.bool_0)
			{
				if (string.IsNullOrEmpty(logDirectory))
				{
					throw new NullReferenceException(Class335.string_6);
				}
				if (!Directory.Exists(logDirectory))
				{
					throw new DirectoryNotFoundException(Class335.string_5);
				}
				Class335.string_11 = Class266.smethod_1(logDirectory, Class335.DateTimeStamp + Class335.string_4, Class335.string_0);
				Class335.class133_0 = new Class335.Class133(Class335.string_11);
				Class335.bool_0 = true;
			}
		}

		// Token: 0x0600222B RID: 8747 RVA: 0x0000E4A9 File Offset: 0x0000C6A9
		public static void smethod_1()
		{
			if (Class335.bool_0)
			{
				Class335.class133_0.Dispose();
				Class335.bool_0 = false;
			}
		}

		// Token: 0x0600222C RID: 8748 RVA: 0x0000E4C2 File Offset: 0x0000C6C2
		public static void smethod_2(string message, bool appendDate = true)
		{
			Class335.smethod_4(message, appendDate, null);
		}

		// Token: 0x0600222D RID: 8749 RVA: 0x0000E4CC File Offset: 0x0000C6CC
		public static void smethod_3(string message, params object[] parameters)
		{
			Class335.smethod_4(message, true, parameters);
		}

		// Token: 0x0600222E RID: 8750 RVA: 0x00074364 File Offset: 0x00072564
		public static void smethod_4(string message, bool appendDate = true, params object[] parameters)
		{
			if (Class335.bool_0)
			{
				if (parameters != null && parameters.Length != 0)
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.Append(message);
					stringBuilder.Append(Class335.string_8);
					for (int i = 0; i < parameters.Length; i++)
					{
						if (i > 0)
						{
							stringBuilder.Append(Class335.string_10);
						}
						object obj = parameters[i];
						Array array = obj as Array;
						if (array != null)
						{
							stringBuilder.Append(Class335.string_1);
							for (int j = 0; j < array.Length; j++)
							{
								if (j > 0)
								{
									stringBuilder.Append(Class335.string_10);
								}
								stringBuilder.Append(array.GetValue(j).ToString());
							}
							stringBuilder.Append(Class335.string_2);
						}
						else
						{
							stringBuilder.Append(obj.ToString());
						}
					}
					stringBuilder.Append(Class335.string_9);
					message = stringBuilder.ToString();
					stringBuilder.Clear();
				}
				Class335.class133_0.method_4(message, appendDate);
			}
		}

		// Token: 0x04000F92 RID: 3986
		private static readonly string string_0 = "_{0}";

		// Token: 0x04000F93 RID: 3987
		private static readonly string string_1 = "{";

		// Token: 0x04000F94 RID: 3988
		private static readonly string string_2 = "}";

		// Token: 0x04000F95 RID: 3989
		private static readonly string string_3 = "{0}: {1}";

		// Token: 0x04000F96 RID: 3990
		private static readonly string string_4 = "{0}.log";

		// Token: 0x04000F97 RID: 3991
		private static readonly string string_5 = "The specified log directory does not exist.";

		// Token: 0x04000F98 RID: 3992
		private static readonly string string_6 = "Log directory cannot be null.";

		// Token: 0x04000F99 RID: 3993
		private static readonly string string_7 = "dd-MM-yyyy HH.mm.ss";

		// Token: 0x04000F9A RID: 3994
		private static readonly string string_8 = ": {";

		// Token: 0x04000F9B RID: 3995
		private static readonly string string_9 = Class335.string_2;

		// Token: 0x04000F9C RID: 3996
		private static readonly string string_10 = ", ";

		// Token: 0x04000F9D RID: 3997
		private static string string_11;

		// Token: 0x04000F9E RID: 3998
		private static bool bool_0 = false;

		// Token: 0x04000F9F RID: 3999
		private static Class335.Class133 class133_0;

		// Token: 0x02000368 RID: 872
		private sealed class Class133 : Class123
		{
			// Token: 0x0600222F RID: 8751 RVA: 0x00074460 File Offset: 0x00072660
			public Class133(string logFile)
			{
				this.object_0 = new object();
				try
				{
					this.stream_0 = File.Open(logFile, FileMode.Append, FileAccess.Write, FileShare.Read);
					this.streamWriter_0 = new StreamWriter(this.stream_0, Class217.encoding_2);
				}
				catch (Exception ex)
				{
					if (this.stream_0 != null)
					{
						this.stream_0.Dispose();
					}
					this.stream_0 = null;
					if (this.streamWriter_0 != null)
					{
						this.streamWriter_0.Dispose();
					}
					this.streamWriter_0 = null;
					ex.smethod_1(new object[]
					{
						logFile
					});
				}
			}

			// Token: 0x06002230 RID: 8752 RVA: 0x00074500 File Offset: 0x00072700
			public void method_4(string message, bool appendDate)
			{
				lock (this.object_0)
				{
					if (this.streamWriter_0 != null)
					{
						try
						{
							if (appendDate)
							{
								this.streamWriter_0.WriteLine(string.Format(Class335.string_3, Class335.DateTimeStamp, message));
							}
							else
							{
								this.streamWriter_0.WriteLine(message);
							}
							this.streamWriter_0.Flush();
						}
						catch (Exception ex)
						{
							ex.smethod_1(new object[]
							{
								message
							});
						}
					}
				}
			}

			// Token: 0x06002231 RID: 8753 RVA: 0x0000E4D6 File Offset: 0x0000C6D6
			protected override void vmethod_0()
			{
				if (this.streamWriter_0 != null)
				{
					this.streamWriter_0.Dispose();
				}
				if (this.stream_0 != null)
				{
					this.stream_0.Dispose();
				}
				base.vmethod_0();
			}

			// Token: 0x04000FA0 RID: 4000
			private readonly Stream stream_0;

			// Token: 0x04000FA1 RID: 4001
			private readonly StreamWriter streamWriter_0;

			// Token: 0x04000FA2 RID: 4002
			private readonly object object_0;
		}
	}
}
