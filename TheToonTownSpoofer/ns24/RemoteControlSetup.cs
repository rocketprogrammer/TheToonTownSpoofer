using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Windows.Forms;
using ns16;
using ns20;
using ns21;
using ns22;
using ns25;
using ns26;
using ns29;
using ns31;

namespace ns24
{
	// Token: 0x02000326 RID: 806
	internal sealed partial class RemoteControlSetup : Form
	{
		// Token: 0x06001F43 RID: 8003 RVA: 0x00067078 File Offset: 0x00065278
		public RemoteControlSetup()
		{
			this.InitializeComponent();
			this.class97_0 = Class110.Instance.RemoteControllerSettings;
			this.UseOpacity.Checked = this.class97_0.UseOpacity;
			this.KeepOnTop.Checked = this.class97_0.TopMost;
			this.AnimateRemoteController.Checked = this.class97_0.AnimateController;
			this.class141_0 = new Class141();
			this.class141_1 = new Class141();
			Class141 @class = this.class141_0;
			EventHandler value = new EventHandler(this.method_4);
			@class.ProcessExited += value;
			Class141 class2 = this.class141_1;
			EventHandler value2 = new EventHandler(this.method_5);
			class2.ProcessExited += value2;
			this.method_0();
			switch (this.class97_0.KeyboardLayout)
			{
			default:
				this.QWERTYOpt.Checked = true;
				return;
			case Enum84.const_1:
				this.AZERTYOpt.Checked = true;
				return;
			case Enum84.const_2:
				this.QWERTZOpt.Checked = true;
				return;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x0000C4D9 File Offset: 0x0000A6D9
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x0000C4E6 File Offset: 0x0000A6E6
		public IntPtr FirstSelectedWindow
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return this.class141_0.MainWindowHandle;
			}
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				if (this.class141_0.MainWindowHandle != value)
				{
					this.class141_0.MainWindowHandle = value;
					this.FirstWindowSelector.SelectedWindow = value;
					this.method_0();
				}
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x0000C519 File Offset: 0x0000A719
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x0000C526 File Offset: 0x0000A726
		public IntPtr SecondSelectedWindow
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return this.class141_1.MainWindowHandle;
			}
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			set
			{
				if (this.class141_1.MainWindowHandle != value)
				{
					this.class141_1.MainWindowHandle = value;
					this.SecondWindowSelector.SelectedWindow = value;
					this.method_0();
				}
			}
		}

		// Token: 0x06001F48 RID: 8008 RVA: 0x0000C559 File Offset: 0x0000A759
		private void method_0()
		{
			this.smethod_6(new MethodInvoker(this.method_6));
		}

		// Token: 0x06001F49 RID: 8009 RVA: 0x0006717C File Offset: 0x0006537C
		private void method_1(object sender, EventArgs15 e)
		{
			if (e.Handle == IntPtr.Zero)
			{
				e.IsValid = false;
				return;
			}
			using (Process process = Class265.smethod_7(e.Handle))
			{
				e.IsValid = (process.ProcessName.ToLower() == "toontown");
			}
		}

		// Token: 0x06001F4A RID: 8010 RVA: 0x000050D4 File Offset: 0x000032D4
		private void OKBtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001F4B RID: 8011 RVA: 0x0000C56D File Offset: 0x0000A76D
		private void method_2(object sender, EventArgs14 e)
		{
			this.FirstSelectedWindow = e.Handle;
			this.method_0();
		}

		// Token: 0x06001F4C RID: 8012 RVA: 0x0000C581 File Offset: 0x0000A781
		private void method_3(object sender, EventArgs14 e)
		{
			this.SecondSelectedWindow = e.Handle;
			this.method_0();
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0000C595 File Offset: 0x0000A795
		private void KeepOnTop_CheckedChanged(object sender, EventArgs e)
		{
			this.class97_0.TopMost = this.KeepOnTop.Checked;
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x0000C5AD File Offset: 0x0000A7AD
		private void AnimateRemoteController_CheckedChanged(object sender, EventArgs e)
		{
			this.class97_0.AnimateController = this.AnimateRemoteController.Checked;
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x0000C5C5 File Offset: 0x0000A7C5
		private void UseOpacity_CheckedChanged(object sender, EventArgs e)
		{
			this.class97_0.UseOpacity = this.UseOpacity.Checked;
		}

		// Token: 0x06001F50 RID: 8016 RVA: 0x00008E0F File Offset: 0x0000700F
		private void RemoteControlSetup_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_11);
			e.Handled = true;
		}

		// Token: 0x06001F51 RID: 8017 RVA: 0x0000C5DD File Offset: 0x0000A7DD
		private void QWERTYOpt_CheckedChanged(object sender, EventArgs e)
		{
			if (this.QWERTYOpt.Checked)
			{
				this.class97_0.KeyboardLayout = Enum84.const_0;
			}
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0000C5F8 File Offset: 0x0000A7F8
		private void AZERTYOpt_CheckedChanged(object sender, EventArgs e)
		{
			if (this.AZERTYOpt.Checked)
			{
				this.class97_0.KeyboardLayout = Enum84.const_1;
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x0000C613 File Offset: 0x0000A813
		private void QWERTZOpt_CheckedChanged(object sender, EventArgs e)
		{
			if (this.QWERTZOpt.Checked)
			{
				this.class97_0.KeyboardLayout = Enum84.const_2;
			}
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x0000C663 File Offset: 0x0000A863
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x0000C663 File Offset: 0x0000A863
		[CompilerGenerated]
		private void method_5(object sender, EventArgs e)
		{
			this.method_0();
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00067FF4 File Offset: 0x000661F4
		[CompilerGenerated]
		private void method_6()
		{
			if (this.FirstWindowSelector.SelectedWindow == IntPtr.Zero && this.SecondWindowSelector.SelectedWindow == IntPtr.Zero)
			{
				this.StatusLed.BaseColor = Color.Red;
				this.StatusText.Text = "Please select your ToonTown windows.";
				return;
			}
			if (this.FirstWindowSelector.SelectedWindow == IntPtr.Zero || this.SecondWindowSelector.SelectedWindow == IntPtr.Zero)
			{
				this.StatusLed.BaseColor = Color.DarkOrange;
				this.StatusText.Text = "Please select both ToonTown windows.";
				return;
			}
			if (this.FirstWindowSelector.SelectedWindow == this.SecondWindowSelector.SelectedWindow)
			{
				this.StatusLed.BaseColor = Color.Red;
				this.StatusText.Text = "The same window is selected twice.";
				return;
			}
			this.StatusLed.BaseColor = Color.FromArgb(153, 255, 54);
			this.StatusText.Text = "Both windows selected, all setup!";
		}

		// Token: 0x04000C0E RID: 3086
		private Class97 class97_0;
	}
}
