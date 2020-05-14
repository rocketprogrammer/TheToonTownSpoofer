using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns23;
using ns26;
using ns27;
using ns30;

namespace ns15
{
	// Token: 0x02000230 RID: 560
	internal class Class175
	{
		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600183C RID: 6204 RVA: 0x00007CB2 File Offset: 0x00005EB2
		// (set) Token: 0x0600183D RID: 6205 RVA: 0x00007CBA File Offset: 0x00005EBA
		public DateTime LastCheckedForUpdate { get; set; }

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x0600183E RID: 6206 RVA: 0x00007CC3 File Offset: 0x00005EC3
		// (set) Token: 0x0600183F RID: 6207 RVA: 0x00007CCB File Offset: 0x00005ECB
		public Enum111 UpdateStepOn { get; set; }

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00007CD4 File Offset: 0x00005ED4
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x00007CDC File Offset: 0x00005EDC
		public string UpdateVersion { get; set; }

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00007CE5 File Offset: 0x00005EE5
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x00007CED File Offset: 0x00005EED
		public string ChangesInLatestVersion { get; set; }

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x00007CF6 File Offset: 0x00005EF6
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x00007CFE File Offset: 0x00005EFE
		public bool ChangesIsRTF { get; set; }

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x00007D07 File Offset: 0x00005F07
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x00007D0F File Offset: 0x00005F0F
		public string ErrorTitle { get; private set; }

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00007D18 File Offset: 0x00005F18
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x00007D20 File Offset: 0x00005F20
		public string ErrorMessage { get; private set; }

		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x00007D29 File Offset: 0x00005F29
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x00007D31 File Offset: 0x00005F31
		public Enum15 AutoUpdaterStatus { get; private set; }

		// Token: 0x0600184C RID: 6220 RVA: 0x000419FC File Offset: 0x0003FBFC
		protected Class175(string autoUpdateID, string autoUpdateFilePath)
		{
			this.string_0 = autoUpdateID;
			this.string_1 = autoUpdateFilePath;
			this.AutoUpdaterStatus = Enum15.const_0;
			bool flag = false;
			try
			{
				if (File.Exists(autoUpdateFilePath))
				{
					this.method_1();
				}
				else
				{
					flag = true;
				}
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				flag = true;
			}
			if (flag)
			{
				this.LastCheckedForUpdate = DateTime.MinValue;
				this.UpdateStepOn = Enum111.const_0;
			}
		}

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x0600184D RID: 6221 RVA: 0x00007D3A File Offset: 0x00005F3A
		public string AutoUpdateID
		{
			get
			{
				if (string.IsNullOrEmpty(this.string_0))
				{
					return Path.GetFileName(Application.ExecutablePath);
				}
				return this.string_0;
			}
		}

		// Token: 0x0600184E RID: 6222 RVA: 0x00041A6C File Offset: 0x0003FC6C
		public void method_0()
		{
			lock (Class175.object_0)
			{
				using (FileStream fileStream = new FileStream(this.string_1, FileMode.Create, FileAccess.Write))
				{
					Class120.smethod_8(fileStream, "AUIF");
					Class120.smethod_4(fileStream, 1, this.LastCheckedForUpdate);
					Class120.smethod_0(fileStream, 2, (int)this.UpdateStepOn);
					if (!string.IsNullOrEmpty(this.UpdateVersion))
					{
						Class120.smethod_5(fileStream, 4, this.UpdateVersion);
					}
					if (!string.IsNullOrEmpty(this.ChangesInLatestVersion))
					{
						Class120.smethod_5(fileStream, 5, this.ChangesInLatestVersion);
						Class120.smethod_1(fileStream, 6, this.ChangesIsRTF);
					}
					fileStream.WriteByte(byte.MaxValue);
				}
			}
		}

		// Token: 0x0600184F RID: 6223 RVA: 0x00041B3C File Offset: 0x0003FD3C
		private void method_1()
		{
			lock (Class175.object_0)
			{
				using (FileStream fileStream = new FileStream(this.string_1, FileMode.Open, FileAccess.Read))
				{
					if (!Class493.smethod_8(fileStream, "AUIF"))
					{
						throw new Exception("Auto update state file ID is wrong.");
					}
					byte b = (byte)fileStream.ReadByte();
					while (!Class493.smethod_9(fileStream, b, 255))
					{
						switch (b)
						{
						case 1:
							this.LastCheckedForUpdate = Class493.smethod_0(fileStream);
							break;
						case 2:
							this.UpdateStepOn = (Enum111)Class493.smethod_4(fileStream);
							break;
						case 3:
							this.AutoUpdaterStatus = (Enum15)Class493.smethod_4(fileStream);
							break;
						case 4:
							this.UpdateVersion = Class493.smethod_1(fileStream);
							break;
						case 5:
							this.ChangesInLatestVersion = Class493.smethod_1(fileStream);
							break;
						case 6:
							this.ChangesIsRTF = Class493.smethod_5(fileStream);
							break;
						case 7:
							this.ErrorTitle = Class493.smethod_1(fileStream);
							break;
						case 8:
							this.ErrorMessage = Class493.smethod_1(fileStream);
							break;
						default:
							Class493.smethod_10(fileStream, b);
							break;
						}
						b = (byte)fileStream.ReadByte();
					}
				}
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00007D5A File Offset: 0x00005F5A
		public void method_2()
		{
			this.AutoUpdaterStatus = Enum15.const_0;
			this.UpdateVersion = null;
			this.ChangesInLatestVersion = null;
			this.ChangesIsRTF = false;
			this.ErrorTitle = null;
			this.ErrorMessage = null;
		}

		// Token: 0x04000623 RID: 1571
		private readonly string string_0;

		// Token: 0x04000624 RID: 1572
		private readonly string string_1;

		// Token: 0x04000625 RID: 1573
		private static readonly object object_0 = new object();

		// Token: 0x04000626 RID: 1574
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x04000627 RID: 1575
		[CompilerGenerated]
		private Enum111 enum111_0;

		// Token: 0x04000628 RID: 1576
		[CompilerGenerated]
		private string string_2;

		// Token: 0x04000629 RID: 1577
		[CompilerGenerated]
		private string string_3;

		// Token: 0x0400062A RID: 1578
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400062B RID: 1579
		[CompilerGenerated]
		private string string_4;

		// Token: 0x0400062C RID: 1580
		[CompilerGenerated]
		private string string_5;

		// Token: 0x0400062D RID: 1581
		[CompilerGenerated]
		private Enum15 enum15_0;
	}
}
