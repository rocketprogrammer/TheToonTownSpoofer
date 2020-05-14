using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;
using ns18;
using ns23;
using ns24;
using ns26;
using ns30;

namespace ns19
{
	// Token: 0x020003F1 RID: 1009
	internal partial class UpdaterBase : Form0
	{
		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002697 RID: 9879 RVA: 0x00011287 File Offset: 0x0000F487
		// (set) Token: 0x06002698 RID: 9880 RVA: 0x0001128F File Offset: 0x0000F48F
		public Enum43 UpdateResult { get; private set; }

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002699 RID: 9881 RVA: 0x00011298 File Offset: 0x0000F498
		// (set) Token: 0x0600269A RID: 9882 RVA: 0x000112A5 File Offset: 0x0000F4A5
		public Enum78 UpdateType
		{
			get
			{
				return this.UpdaterInstance.UpdateType;
			}
			set
			{
				this.UpdaterInstance.UpdateType = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x0600269B RID: 9883 RVA: 0x000112B3 File Offset: 0x0000F4B3
		// (set) Token: 0x0600269C RID: 9884 RVA: 0x000112C0 File Offset: 0x0000F4C0
		[DefaultValue(typeof(Image), null)]
		public Image Logo
		{
			get
			{
				return this.LogoPictureBox.Image;
			}
			set
			{
				this.LogoPictureBox.Image = value;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x0600269D RID: 9885 RVA: 0x000112CE File Offset: 0x0000F4CE
		// (set) Token: 0x0600269E RID: 9886 RVA: 0x000112DB File Offset: 0x0000F4DB
		public string Title
		{
			get
			{
				return this.TitleLabel.Text;
			}
			set
			{
				this.TitleLabel.Text = value;
			}
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x000112E9 File Offset: 0x0000F4E9
		private UpdaterBase()
		{
			this.InitializeComponent();
			this.UpdateResult = Enum43.const_0;
			base.FormClosing += this.UpdaterBase_FormClosing;
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00011310 File Offset: 0x0000F510
		public UpdaterBase(bool autoCloseOnUpToDate) : this()
		{
			this.bool_5 = autoCloseOnUpToDate;
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x000894B0 File Offset: 0x000876B0
		private void UpdaterBase_FormClosing(object sender, FormClosingEventArgs e)
		{
			CloseReason closeReason = e.CloseReason;
			if (closeReason != CloseReason.WindowsShutDown)
			{
				switch (this.UpdaterInstance.UpdateStepOn)
				{
				case Enum111.const_1:
				case Enum111.const_3:
				case Enum111.const_5:
					e.Cancel = true;
					base.EnableCloseButton = false;
					this.UpdaterInstance.method_8();
					break;
				case Enum111.const_2:
				case Enum111.const_4:
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x0008950C File Offset: 0x0008770C
		protected override void vmethod_1(EventArgs19 e)
		{
			switch (this.UpdaterInstance.UpdateStepOn)
			{
			case Enum111.const_1:
			case Enum111.const_3:
			case Enum111.const_5:
				e.Cancel = true;
				e.CancelReason = "One moment, canceling update...";
				base.EnableCloseButton = false;
				this.UpdaterInstance.method_8();
				break;
			}
			base.vmethod_1(e);
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x0001131F File Offset: 0x0000F51F
		private void UpdaterBase_Shown(object sender, EventArgs e)
		{
			this.UpdaterInstance.method_21();
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x0001132C File Offset: 0x0000F52C
		private void method_1(object sender, EventArgs e)
		{
			this.UpdateResult = Enum43.const_1;
			base.Close();
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x0001133B File Offset: 0x0000F53B
		private void method_2(object sender, EventArgs e)
		{
			this.UpdateResult = Enum43.const_2;
			base.Close();
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x0001134A File Offset: 0x0000F54A
		private void method_3(object sender, EventArgs e)
		{
			this.UpdateResult = Enum43.const_3;
			base.Close();
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00011359 File Offset: 0x0000F559
		private void method_4(object sender, EventArgs7 e)
		{
			this.UpdateResult = Enum43.const_4;
			if (this.bool_5)
			{
				base.Close();
			}
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x00011370 File Offset: 0x0000F570
		private void method_5(object sender, EventArgs e)
		{
			this.UpdateResult = Enum43.const_5;
			base.Close();
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x0001137F File Offset: 0x0000F57F
		private void method_6(object sender, EventArgs7 e)
		{
			this.UpdateResult = Enum43.const_6;
			base.Close();
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x0001138E File Offset: 0x0000F58E
		private void method_7(object sender, EventArgs26 e)
		{
			this.UpdateResult = Enum43.const_7;
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x00011397 File Offset: 0x0000F597
		private void method_8(object sender, EventArgs26 e)
		{
			this.UpdateResult = Enum43.const_8;
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x000113A0 File Offset: 0x0000F5A0
		private void method_9(object sender, EventArgs26 e)
		{
			this.UpdateResult = Enum43.const_9;
		}

		// Token: 0x060026AD RID: 9901 RVA: 0x000113AA File Offset: 0x0000F5AA
		private void method_10(object sender, EventArgs e)
		{
			this.UpdateResult = Enum43.const_10;
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x000113B4 File Offset: 0x0000F5B4
		private void method_11(object sender, EventArgs e)
		{
			this.UpdateResult = Enum43.const_11;
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000050D4 File Offset: 0x000032D4
		private void method_12(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x040012DE RID: 4830
		private bool bool_5;

		// Token: 0x040012E4 RID: 4836
		[CompilerGenerated]
		private Enum43 enum43_0;
	}
}
