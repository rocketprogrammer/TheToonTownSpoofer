using System;
using System.IO;
using System.Management;
using ns17;
using ns23;
using ns29;

namespace ns25
{
	// Token: 0x0200033D RID: 829
	internal static class Class317
	{
		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06002011 RID: 8209 RVA: 0x0006A64C File Offset: 0x0006884C
		private static string MotherBoardSerial
		{
			get
			{
				if (string.IsNullOrEmpty(Class317.string_12))
				{
					try
					{
						using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(Class317.string_3))
						{
							ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
							using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = managementObjectCollection.GetEnumerator())
							{
								if (enumerator.MoveNext())
								{
									ManagementBaseObject managementBaseObject = enumerator.Current;
									Class317.string_12 = managementBaseObject[Class317.string_4].ToString();
								}
							}
						}
					}
					catch (Exception ex)
					{
						ex.smethod_0();
					}
					if (string.IsNullOrEmpty(Class317.string_12))
					{
						Class317.string_12 = Class317.string_2;
					}
				}
				return Class317.string_12;
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06002012 RID: 8210 RVA: 0x0006A710 File Offset: 0x00068910
		private static string SystemDriveSerial
		{
			get
			{
				if (string.IsNullOrEmpty(Class317.string_13))
				{
					try
					{
						string text = Environment.ExpandEnvironmentVariables(Class317.string_11);
						if (string.IsNullOrEmpty(text))
						{
							string[] logicalDrives = Directory.GetLogicalDrives();
							int num = 0;
							if (0 < logicalDrives.Length)
							{
								string text2 = logicalDrives[num];
								text = text2;
							}
						}
						if (string.IsNullOrEmpty(text))
						{
							text = Class317.string_7;
						}
						else if (text.Length > 1)
						{
							text = text.Substring(0, 1);
						}
						using (ManagementObject managementObject = new ManagementObject(string.Format(Class217.cultureInfo_0, Class317.string_6, new object[]
						{
							text
						})))
						{
							managementObject.Get();
							Class317.string_13 = managementObject[Class317.string_5].ToString();
						}
					}
					catch (Exception ex)
					{
						ex.smethod_0();
					}
					if (string.IsNullOrEmpty(Class317.string_13))
					{
						Class317.string_13 = Class317.string_1;
					}
				}
				return Class317.string_13;
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x06002013 RID: 8211 RVA: 0x0006A808 File Offset: 0x00068A08
		private static string CPUSerial
		{
			get
			{
				if (string.IsNullOrEmpty(Class317.string_14))
				{
					try
					{
						using (ManagementClass managementClass = new ManagementClass(Class317.string_8))
						{
							ManagementObjectCollection instances = managementClass.GetInstances();
							using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = instances.GetEnumerator())
							{
								if (enumerator.MoveNext())
								{
									ManagementObject managementObject = (ManagementObject)enumerator.Current;
									Class317.string_14 = managementObject.Properties[Class317.string_9].Value.ToString();
								}
							}
						}
					}
					catch (Exception ex)
					{
						ex.smethod_0();
					}
					if (string.IsNullOrEmpty(Class317.string_14))
					{
						Class317.string_14 = Class317.string_0;
					}
				}
				return Class317.string_14;
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x06002014 RID: 8212 RVA: 0x0006A8DC File Offset: 0x00068ADC
		private static string UniqueSerial
		{
			get
			{
				if (string.IsNullOrEmpty(Class317.string_15))
				{
					Class317.string_15 = string.Format(Class217.cultureInfo_0, Class317.string_10, new object[]
					{
						Class317.MotherBoardSerial,
						Class317.CPUSerial,
						Class317.SystemDriveSerial
					});
				}
				return Class317.string_15;
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x06002015 RID: 8213 RVA: 0x0000CF91 File Offset: 0x0000B191
		internal static string HashedUniqueSerial
		{
			get
			{
				if (string.IsNullOrEmpty(Class317.string_16))
				{
					Class317.string_16 = Class513.smethod_1(Class317.UniqueSerial);
				}
				return Class317.string_16;
			}
		}

		// Token: 0x04000CE6 RID: 3302
		private static readonly string string_0 = "##############";

		// Token: 0x04000CE7 RID: 3303
		private static readonly string string_1 = "***********";

		// Token: 0x04000CE8 RID: 3304
		private static readonly string string_2 = "^^^^^^^^^^^^^^^";

		// Token: 0x04000CE9 RID: 3305
		private static readonly string string_3 = "SELECT * FROM Win32_baseboard";

		// Token: 0x04000CEA RID: 3306
		private static readonly string string_4 = "SerialNumber";

		// Token: 0x04000CEB RID: 3307
		private static readonly string string_5 = "VolumeSerialNumber";

		// Token: 0x04000CEC RID: 3308
		private static readonly string string_6 = "win32_logicaldisk.deviceid=\"{0}:\"";

		// Token: 0x04000CED RID: 3309
		private static readonly string string_7 = "C";

		// Token: 0x04000CEE RID: 3310
		private static readonly string string_8 = "win32_processor";

		// Token: 0x04000CEF RID: 3311
		private static readonly string string_9 = "processorID";

		// Token: 0x04000CF0 RID: 3312
		private static readonly string string_10 = "{0}-{1}-{2}";

		// Token: 0x04000CF1 RID: 3313
		private static readonly string string_11 = "%SystemDrive%";

		// Token: 0x04000CF2 RID: 3314
		private static string string_12;

		// Token: 0x04000CF3 RID: 3315
		private static string string_13;

		// Token: 0x04000CF4 RID: 3316
		private static string string_14;

		// Token: 0x04000CF5 RID: 3317
		private static string string_15;

		// Token: 0x04000CF6 RID: 3318
		private static string string_16;
	}
}
