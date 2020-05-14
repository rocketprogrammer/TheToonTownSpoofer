using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;
using ns15;
using ns16;
using ns17;
using ns18;
using ns20;
using ns22;
using ns23;
using ns24;
using ns26;
using ns29;
using ns31;

namespace ns21
{
	// Token: 0x0200024D RID: 589
	internal sealed partial class Installing : Form0
	{
		// Token: 0x17000798 RID: 1944
		// (get) Token: 0x06001995 RID: 6549 RVA: 0x00008E1F File Offset: 0x0000701F
		// (set) Token: 0x06001996 RID: 6550 RVA: 0x00008E27 File Offset: 0x00007027
		public Enum101 ServerType { get; private set; }

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06001997 RID: 6551 RVA: 0x00008E30 File Offset: 0x00007030
		// (set) Token: 0x06001998 RID: 6552 RVA: 0x00008E38 File Offset: 0x00007038
		public Enum42 InstallerResult { get; private set; }

		// Token: 0x06001999 RID: 6553 RVA: 0x00046448 File Offset: 0x00044648
		public Installing(Class96 patchData, Enum101 type, string username, Dictionary<string, string> variables)
		{
			this.object_0 = new object();
			this.InstallerResult = Enum42.const_0;
			this.class96_0 = patchData;
			this.string_20 = username;
			this.dictionary_0 = variables;
			this.ServerType = type;
			this.InitializeComponent();
			base.FormClosing += this.Installing_FormClosing;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x000464A4 File Offset: 0x000446A4
		private void Installing_FormClosing(object sender, FormClosingEventArgs e)
		{
			CloseReason closeReason = e.CloseReason;
			if (closeReason != CloseReason.WindowsShutDown)
			{
				Enum42 installerResult = this.InstallerResult;
				if (installerResult != Enum42.const_0)
				{
					return;
				}
				e.Cancel = true;
				this.method_1();
			}
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x000464D8 File Offset: 0x000446D8
		private void method_1()
		{
			if (DialogResult.Yes == DialogBox.smethod_6(Installing.string_0, Installing.string_1, new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			}))
			{
				this.method_2(false);
			}
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00008E41 File Offset: 0x00007041
		protected override void vmethod_1(EventArgs19 e)
		{
			e.Cancel = true;
			e.CancelReason = Installing.string_14;
			this.method_2(true);
			base.vmethod_1(e);
		}

		// Token: 0x0600199D RID: 6557 RVA: 0x00008E63 File Offset: 0x00007063
		private void btnAbort_Click(object sender, EventArgs e)
		{
			this.method_1();
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x00008E6B File Offset: 0x0000706B
		private void method_2(bool internalCancel)
		{
			this.class137_0.method_4(internalCancel);
			this.btnAbort.Text = Installing.string_12;
			this.btnAbort.Enabled = false;
			base.EnableCloseButton = false;
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x00046510 File Offset: 0x00044710
		private void Installing_Load(object sender, EventArgs e)
		{
			this.class137_0 = new Class137(this.class96_0, this.ServerType, this.ServerType == Enum101.const_1 && Class110.Instance.ConnectSettings.SpoofedToonTownEnabled);
			this.class137_0.InstallerStateChanged += this.method_9;
			this.class137_0.VersionMismatch += this.method_7;
			this.class137_0.DownloadProgressChanged += this.method_6;
			this.class137_0.ResetCounters += this.method_3;
			this.class137_0.ProgressChanged += this.method_5;
			this.class137_0.method_5();
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00008E9C File Offset: 0x0000709C
		private void method_3(object sender, EventArgs e)
		{
			this.smethod_4(new MethodInvoker(this.method_10));
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x000465D0 File Offset: 0x000447D0
		private void method_4()
		{
			lock (this.object_0)
			{
				this.nullable_2 = null;
				this.nullable_1 = null;
				this.nullable_0 = null;
				this.nullable_3 = null;
				this.int_0 = -1;
				this.int_1 = -1;
				this.barProgress.Value = 0;
			}
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00046654 File Offset: 0x00044854
		private void timer_1_Tick(object sender, EventArgs e)
		{
			lock (this.object_0)
			{
				Enum74 @enum = this.enum74_0;
				if (@enum != Enum74.const_1)
				{
					if (@enum != Enum74.const_7)
					{
						this.timer_1.Enabled = false;
						goto IL_1A1;
					}
				}
				if (this.nullable_2 != null)
				{
					string text = null;
					string arg = string.Format(Class313.class196_0, "{0}", new object[]
					{
						this.nullable_2.Value
					});
					Enum74 enum2 = this.enum74_0;
					if (enum2 != Enum74.const_1)
					{
						if (enum2 == Enum74.const_7)
						{
							text = string.Format(Installing.string_17, arg);
						}
					}
					else
					{
						text = string.Format(Installing.string_19, arg);
					}
					if (this.nullable_3 != null && this.nullable_0 != null && this.nullable_1 != null && this.nullable_1.Value > this.nullable_0.Value)
					{
						double totalMilliseconds = (DateTime.Now - this.nullable_3.Value).TotalMilliseconds;
						long num = this.nullable_1.Value - this.nullable_0.Value;
						long num2 = (long)((double)num / totalMilliseconds * 1000.0);
						text += string.Format(Class313.class196_0, " @ {0}/s)", new object[]
						{
							num2
						});
					}
					else
					{
						text += ")";
					}
					this.lblStatus.Text = text;
				}
				this.nullable_3 = new DateTime?(DateTime.Now);
				this.nullable_0 = this.nullable_1;
				this.nullable_1 = null;
				IL_1A1:;
			}
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0004682C File Offset: 0x00044A2C
		private void method_5(object sender, EventArgs9 e)
		{
			MethodInvoker methodInvoker = null;
			Installing.Class189 @class = new Installing.Class189();
			@class.eventArgs9_0 = e;
			@class.installing_0 = this;
			lock (this.object_0)
			{
				if (this.int_1 != @class.eventArgs9_0.PercentComplete)
				{
					this.int_1 = @class.eventArgs9_0.PercentComplete;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.smethod_4(methodInvoker);
				}
			}
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x000468B8 File Offset: 0x00044AB8
		private void method_6(object sender, EventArgs10 e)
		{
			MethodInvoker methodInvoker = null;
			Installing.Class190 @class = new Installing.Class190();
			@class.eventArgs10_0 = e;
			@class.installing_0 = this;
			lock (this.object_0)
			{
				this.nullable_1 = new long?(@class.eventArgs10_0.TotalCompleted);
				this.nullable_2 = new long?(@class.eventArgs10_0.TotalRemaining);
				if (this.int_0 != @class.eventArgs10_0.PercentComplete)
				{
					this.int_0 = @class.eventArgs10_0.PercentComplete;
					if (methodInvoker == null)
					{
						methodInvoker = new MethodInvoker(@class.method_0);
					}
					this.smethod_4(methodInvoker);
				}
			}
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x00046970 File Offset: 0x00044B70
		private void method_7(object sender, EventArgs42 e)
		{
			Installing.Class191 @class = new Installing.Class191();
			@class.eventArgs42_0 = e;
			@class.installing_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x00008EB0 File Offset: 0x000070B0
		private void method_8(ProgressBarStyle style)
		{
			if (this.barProgress.Style != style)
			{
				this.barProgress.Style = style;
			}
		}

		// Token: 0x060019A7 RID: 6567 RVA: 0x000469A4 File Offset: 0x00044BA4
		private void method_9(object sender, EventArgs33 e)
		{
			Installing.Class192 @class = new Installing.Class192();
			@class.eventArgs33_0 = e;
			@class.installing_0 = this;
			this.smethod_4(new MethodInvoker(@class.method_0));
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x000469D8 File Offset: 0x00044BD8
		private void timer_0_Tick(object sender, EventArgs e)
		{
			try
			{
				Installing.Class193 @class = new Installing.Class193();
				@class.class141_0 = this.class142_0.ToonTownProcess;
				if (!this.class142_0.ToonTownProcess.ProcessOpen)
				{
					this.timer_0.Enabled = false;
					this.InstallerResult = Enum42.const_5;
					base.Close();
				}
				else
				{
					Class265.Delegate174 @delegate = null;
					Installing.Class194 class2 = new Installing.Class194();
					class2.class193_0 = @class;
					class2.bool_0 = (!string.IsNullOrEmpty(@class.class141_0.MainWindowTitle) || @class.class141_0.MainWindowHandle != IntPtr.Zero);
					if (!class2.bool_0)
					{
						using (Process processById = Process.GetProcessById(@class.class141_0.Process.Id))
						{
							class2.bool_0 = (!string.IsNullOrEmpty(processById.smethod_1()) || processById.smethod_0() != IntPtr.Zero);
						}
					}
					if (!class2.bool_0 && this.int_2 > 6)
					{
						try
						{
							if (@delegate == null)
							{
								@delegate = new Class265.Delegate174(class2.method_0);
							}
							Class265.EnumWindows(@delegate, IntPtr.Zero);
						}
						catch (Exception ex)
						{
							ex.smethod_0();
						}
					}
					if (class2.bool_0)
					{
						this.timer_0.Enabled = false;
						int num = (1 << Environment.ProcessorCount) - 1;
						try
						{
							@class.class141_0.Process.ProcessorAffinity = new IntPtr(num);
						}
						catch (Exception ex2)
						{
							ex2.smethod_1(new object[]
							{
								string.Format(Installing.string_13, num)
							});
						}
						if (this.class142_0 != null)
						{
							this.class142_0.method_4();
						}
						this.InstallerResult = Enum42.const_2;
						base.Close();
					}
				}
				this.int_2++;
			}
			catch (Exception ex3)
			{
				ex3.smethod_0();
				this.timer_0.Enabled = false;
				this.InstallerResult = Enum42.const_4;
				base.Close();
			}
		}

		// Token: 0x060019AB RID: 6571 RVA: 0x00008EFE File Offset: 0x000070FE
		[CompilerGenerated]
		private void method_10()
		{
			this.method_4();
		}

		// Token: 0x04000712 RID: 1810
		private static readonly string string_0 = "Are you sure you want to abort installation?";

		// Token: 0x04000713 RID: 1811
		private static readonly string string_1 = "Abort Installation";

		// Token: 0x04000714 RID: 1812
		private static readonly string string_2 = "The Content Pack '{0}' could not be fully updated as it requires at least version '{1}' of The ToonTown Spoofer.";

		// Token: 0x04000715 RID: 1813
		private static readonly string string_3 = "Please update The ToonTown Spoofer";

		// Token: 0x04000716 RID: 1814
		private static readonly string string_4 = "The Content Pack '{0}' could not be updated as it requires at least version '{1}' of The ToonTown Spoofer.";

		// Token: 0x04000717 RID: 1815
		private static readonly string string_5 = "Checking for Updates";

		// Token: 0x04000718 RID: 1816
		private static readonly string string_6 = "Extracting Files";

		// Token: 0x04000719 RID: 1817
		private static readonly string string_7 = "Installing Content Pack";

		// Token: 0x0400071A RID: 1818
		private static readonly string string_8 = "Launching ToonTown";

		// Token: 0x0400071B RID: 1819
		private static readonly string string_9 = "Patching Content Pack";

		// Token: 0x0400071C RID: 1820
		private static readonly string string_10 = "Validating Core Files";

		// Token: 0x0400071D RID: 1821
		private static readonly string string_11 = "Validating Data";

		// Token: 0x0400071E RID: 1822
		private static readonly string string_12 = "Aborting...";

		// Token: 0x0400071F RID: 1823
		private static readonly string string_13 = "Processor affinity: {0}";

		// Token: 0x04000720 RID: 1824
		private static readonly string string_14 = "Please wait, aborting installation...";

		// Token: 0x04000721 RID: 1825
		private static readonly string string_15 = "Checking for Content Pack Updates";

		// Token: 0x04000722 RID: 1826
		private static readonly string string_16 = "Downloading Content Pack";

		// Token: 0x04000723 RID: 1827
		private static readonly string string_17 = "Downloading Content Pack ({0}";

		// Token: 0x04000724 RID: 1828
		private static readonly string string_18 = "Downloading Updates";

		// Token: 0x04000725 RID: 1829
		private static readonly string string_19 = "Downloading Updates ({0}";

		// Token: 0x04000727 RID: 1831
		private Dictionary<string, string> dictionary_0;

		// Token: 0x04000728 RID: 1832
		private Enum74 enum74_0;

		// Token: 0x04000729 RID: 1833
		private string string_20;

		// Token: 0x0400072A RID: 1834
		private Class142 class142_0;

		// Token: 0x0400072B RID: 1835
		private Class96 class96_0;

		// Token: 0x0400072C RID: 1836
		private long? nullable_0;

		// Token: 0x0400072D RID: 1837
		private long? nullable_1;

		// Token: 0x0400072E RID: 1838
		private long? nullable_2;

		// Token: 0x0400072F RID: 1839
		private DateTime? nullable_3;

		// Token: 0x04000730 RID: 1840
		private int int_0;

		// Token: 0x04000731 RID: 1841
		private int int_1;

		// Token: 0x04000732 RID: 1842
		private readonly object object_0;

		// Token: 0x04000733 RID: 1843
		private int int_2;

		// Token: 0x0400073C RID: 1852
		[CompilerGenerated]
		private Enum101 enum101_0;

		// Token: 0x0400073D RID: 1853
		[CompilerGenerated]
		private Enum42 enum42_0;

		// Token: 0x0200024E RID: 590
		[CompilerGenerated]
		private sealed class Class189
		{
			// Token: 0x060019AE RID: 6574 RVA: 0x00008F06 File Offset: 0x00007106
			public void method_0()
			{
				this.installing_0.barProgress.Value = this.eventArgs9_0.PercentComplete;
			}

			// Token: 0x0400073E RID: 1854
			public Installing installing_0;

			// Token: 0x0400073F RID: 1855
			public EventArgs9 eventArgs9_0;
		}

		// Token: 0x0200024F RID: 591
		[CompilerGenerated]
		private sealed class Class190
		{
			// Token: 0x060019B0 RID: 6576 RVA: 0x00008F23 File Offset: 0x00007123
			public void method_0()
			{
				this.installing_0.barProgress.Value = this.eventArgs10_0.PercentComplete;
			}

			// Token: 0x04000740 RID: 1856
			public Installing installing_0;

			// Token: 0x04000741 RID: 1857
			public EventArgs10 eventArgs10_0;
		}

		// Token: 0x02000250 RID: 592
		[CompilerGenerated]
		private sealed class Class191
		{
			// Token: 0x060019B2 RID: 6578 RVA: 0x000471A0 File Offset: 0x000453A0
			public void method_0()
			{
				if (this.eventArgs42_0.IsPatch)
				{
					DialogBox.smethod_3(string.Format(Installing.string_2, this.eventArgs42_0.ContentPackData.Name, this.eventArgs42_0.MinimumVersion), Installing.string_3);
					return;
				}
				DialogBox.smethod_3(string.Format(Installing.string_4, this.eventArgs42_0.ContentPackData.Name, this.eventArgs42_0.MinimumVersion), Installing.string_3);
			}

			// Token: 0x04000742 RID: 1858
			public Installing installing_0;

			// Token: 0x04000743 RID: 1859
			public EventArgs42 eventArgs42_0;
		}

		// Token: 0x02000251 RID: 593
		[CompilerGenerated]
		private sealed class Class192
		{
			// Token: 0x060019B4 RID: 6580 RVA: 0x0004721C File Offset: 0x0004541C
			public void method_0()
			{
				this.installing_0.enum74_0 = this.eventArgs33_0.InstallerState;
				switch (this.eventArgs33_0.InstallerState)
				{
				case Enum74.const_0:
					this.installing_0.timer_1.Enabled = false;
					this.installing_0.method_8(ProgressBarStyle.Marquee);
					this.installing_0.lblStatus.Text = Installing.string_5;
					return;
				case Enum74.const_1:
					this.installing_0.method_4();
					this.installing_0.method_8(ProgressBarStyle.Continuous);
					this.installing_0.lblStatus.Text = Installing.string_18;
					this.installing_0.timer_1.Enabled = true;
					return;
				case Enum74.const_2:
					this.installing_0.timer_1.Enabled = false;
					this.installing_0.method_8(ProgressBarStyle.Marquee);
					this.installing_0.lblStatus.Text = Installing.string_6;
					return;
				case Enum74.const_3:
					this.installing_0.timer_1.Enabled = false;
					this.installing_0.method_8(ProgressBarStyle.Marquee);
					this.installing_0.lblStatus.Text = Installing.string_11;
					return;
				case Enum74.const_4:
					this.installing_0.timer_1.Enabled = false;
					this.installing_0.method_8(ProgressBarStyle.Marquee);
					this.installing_0.lblStatus.Text = Installing.string_10;
					return;
				case Enum74.const_5:
					this.installing_0.timer_1.Enabled = false;
					switch (this.eventArgs33_0.InstallFailureType)
					{
					case Enum66.const_0:
						this.installing_0.method_8(ProgressBarStyle.Continuous);
						this.installing_0.lblStatus.Text = Installing.string_8;
						this.installing_0.barProgress.Value = 100;
						this.installing_0.btnAbort.Enabled = false;
						if (Class80.smethod_0(this.installing_0.ServerType, this.installing_0.string_20, this.installing_0.dictionary_0, out this.installing_0.class142_0))
						{
							this.installing_0.timer_0.Enabled = true;
							return;
						}
						this.installing_0.InstallerResult = Enum42.const_4;
						this.installing_0.Close();
						return;
					case Enum66.const_1:
						this.installing_0.InstallerResult = Enum42.const_6;
						this.installing_0.Close();
						return;
					case Enum66.const_2:
						this.installing_0.InstallerResult = Enum42.const_1;
						this.installing_0.Close();
						return;
					case Enum66.const_3:
						this.installing_0.InstallerResult = Enum42.const_3;
						this.installing_0.Close();
						return;
					default:
						return;
					}
					break;
				case Enum74.const_6:
					this.installing_0.timer_1.Enabled = false;
					this.installing_0.method_8(ProgressBarStyle.Marquee);
					this.installing_0.lblStatus.Text = Installing.string_15;
					return;
				case Enum74.const_7:
					this.installing_0.method_4();
					this.installing_0.method_8(ProgressBarStyle.Continuous);
					this.installing_0.lblStatus.Text = Installing.string_16;
					this.installing_0.timer_1.Enabled = true;
					return;
				case Enum74.const_8:
					this.installing_0.timer_1.Enabled = false;
					this.installing_0.method_8(ProgressBarStyle.Continuous);
					this.installing_0.lblStatus.Text = Installing.string_9;
					return;
				case Enum74.const_9:
					this.installing_0.timer_1.Enabled = false;
					this.installing_0.method_8(ProgressBarStyle.Marquee);
					this.installing_0.lblStatus.Text = Installing.string_7;
					return;
				default:
					return;
				}
			}

			// Token: 0x04000744 RID: 1860
			public Installing installing_0;

			// Token: 0x04000745 RID: 1861
			public EventArgs33 eventArgs33_0;
		}

		// Token: 0x02000252 RID: 594
		[CompilerGenerated]
		private sealed class Class193
		{
			// Token: 0x04000746 RID: 1862
			public Class141 class141_0;
		}

		// Token: 0x02000253 RID: 595
		[CompilerGenerated]
		private sealed class Class194
		{
			// Token: 0x060019B7 RID: 6583 RVA: 0x00047578 File Offset: 0x00045778
			public bool method_0(IntPtr arg, IntPtr l)
			{
				int num;
				Class265.GetWindowThreadProcessId(arg, out num);
				if (num == this.class193_0.class141_0.Process.Id && Class265.IsWindowVisible(arg))
				{
					this.bool_0 = true;
					return false;
				}
				return true;
			}

			// Token: 0x04000747 RID: 1863
			public Installing.Class193 class193_0;

			// Token: 0x04000748 RID: 1864
			public bool bool_0;
		}
	}
}
