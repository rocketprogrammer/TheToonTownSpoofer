using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns20;
using ns21;
using ns22;
using ns23;

namespace ns30
{
	// Token: 0x020001E1 RID: 481
	internal partial class WindowSelect : Form
	{
		// Token: 0x06001600 RID: 5632 RVA: 0x00034F88 File Offset: 0x00033188
		public WindowSelect()
		{
			this.InitializeComponent();
			Class335.smethod_2(WindowSelect.string_0, true);
			this.Selector.BeginSelecting += this.method_1;
			this.Selector.EndSelecting += this.method_2;
			this.Selector.SelectedHandleChanged += this.method_0;
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x000062C2 File Offset: 0x000044C2
		public IntPtr SelectedHandle
		{
			get
			{
				return this.Selector.SelectedWindow;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x000062CF File Offset: 0x000044CF
		// (set) Token: 0x06001603 RID: 5635 RVA: 0x000062DC File Offset: 0x000044DC
		public string LabelMessage
		{
			get
			{
				return this.Selector.LabelMessage;
			}
			set
			{
				this.Selector.LabelMessage = value;
			}
		}

		// Token: 0x1400016C RID: 364
		// (add) Token: 0x06001604 RID: 5636 RVA: 0x000062EA File Offset: 0x000044EA
		// (remove) Token: 0x06001605 RID: 5637 RVA: 0x000062F8 File Offset: 0x000044F8
		public event EventHandler<EventArgs15> SelectedHandleChanging
		{
			add
			{
				this.Selector.SelectedHandleChanging += value;
			}
			remove
			{
				this.Selector.SelectedHandleChanging -= value;
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00006306 File Offset: 0x00004506
		private void method_0(object sender, EventArgs14 e)
		{
			this.OKButton.Enabled = (e.Handle != IntPtr.Zero);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00006323 File Offset: 0x00004523
		private void method_1(object sender, EventArgs e)
		{
			this.method_3(0.8);
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00006334 File Offset: 0x00004534
		private void method_2(object sender, EventArgs e)
		{
			this.method_3(1.0);
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00034FF4 File Offset: 0x000331F4
		private void method_3(double value)
		{
			try
			{
				base.Opacity = value;
			}
			catch (Exception ex)
			{
				ex.smethod_0();
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00035024 File Offset: 0x00033224
		private void OKButton_Click(object sender, EventArgs e)
		{
			Class335.smethod_3(WindowSelect.string_2, new object[]
			{
				this.SelectedHandle
			});
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00035058 File Offset: 0x00033258
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			Class335.smethod_3(WindowSelect.string_1, new object[]
			{
				this.SelectedHandle
			});
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x04000363 RID: 867
		private static readonly string string_0 = "Window Selector Initializing";

		// Token: 0x04000364 RID: 868
		private static readonly string string_1 = "Window Selection Canceled";

		// Token: 0x04000365 RID: 869
		private static readonly string string_2 = "Window Selected";
	}
}
