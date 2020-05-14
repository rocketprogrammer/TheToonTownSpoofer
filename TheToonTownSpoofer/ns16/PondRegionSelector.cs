using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns15;
using ns17;
using ns18;
using ns20;
using ns24;
using ns28;
using ns30;
using ns31;

namespace ns16
{
	// Token: 0x020003C4 RID: 964
	internal sealed partial class PondRegionSelector : Form
	{
		// Token: 0x06002529 RID: 9513 RVA: 0x00010506 File Offset: 0x0000E706
		public PondRegionSelector()
		{
			this.InitializeComponent();
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x0600252A RID: 9514 RVA: 0x00010514 File Offset: 0x0000E714
		// (set) Token: 0x0600252B RID: 9515 RVA: 0x00010521 File Offset: 0x0000E721
		[DefaultValue(typeof(Bitmap), null)]
		public Bitmap Image
		{
			get
			{
				return this.DrawingBoardRenderer.Image;
			}
			set
			{
				this.DrawingBoardRenderer.Image = value;
			}
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x0001052F File Offset: 0x0000E72F
		public Class95<T> method_0<T>() where T : Interface17
		{
			return this.DrawingBoardRenderer.method_0<T>();
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x0001053C File Offset: 0x0000E73C
		public void method_1<T>(Class95<T> value) where T : Interface17
		{
			this.DrawingBoardRenderer.method_1<T>(value);
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x0007FE84 File Offset: 0x0007E084
		private void NoTool_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NoTool.Checked)
			{
				this.DrawingBoardRenderer.DrawingTool = Enum125.const_0;
				return;
			}
			if (this.BrushTool.Checked)
			{
				this.DrawingBoardRenderer.DrawingTool = Enum125.const_1;
				return;
			}
			if (this.EraserTool.Checked)
			{
				this.DrawingBoardRenderer.DrawingTool = Enum125.const_2;
				return;
			}
			this.NoTool.Checked = true;
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x0007FEEC File Offset: 0x0007E0EC
		private void SmallSize_CheckedChanged(object sender, EventArgs e)
		{
			if (this.ExtraSmallSize.Checked)
			{
				this.DrawingBoardRenderer.DrawingToolSize = Enum61.const_0;
				return;
			}
			if (this.SmallSize.Checked)
			{
				this.DrawingBoardRenderer.DrawingToolSize = Enum61.const_1;
				return;
			}
			if (this.MediumSize.Checked)
			{
				this.DrawingBoardRenderer.DrawingToolSize = Enum61.const_2;
				return;
			}
			if (this.LargeSize.Checked)
			{
				this.DrawingBoardRenderer.DrawingToolSize = Enum61.const_3;
				return;
			}
			if (this.ExtraLargeSize.Checked)
			{
				this.DrawingBoardRenderer.DrawingToolSize = Enum61.const_4;
				return;
			}
			if (this.ExtraExtraLargeSize.Checked)
			{
				this.DrawingBoardRenderer.DrawingToolSize = Enum61.const_5;
				return;
			}
			this.MediumSize.Checked = true;
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x0001054A File Offset: 0x0000E74A
		private void ZoomIn_Click(object sender, EventArgs e)
		{
			this.DrawingBoardRenderer.method_2();
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00010557 File Offset: 0x0000E757
		private void ZoomOut_Click(object sender, EventArgs e)
		{
			this.DrawingBoardRenderer.method_3();
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x0000A641 File Offset: 0x00008841
		private void AcceptBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00006181 File Offset: 0x00004381
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x0007FFA4 File Offset: 0x0007E1A4
		private void PondRegionSelector_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK)
			{
				Bitmap overlay = this.DrawingBoardRenderer.Overlay;
				if (overlay == null)
				{
					DialogBox.smethod_3("Please make a valid selection by using the drawing tools.", "Nothing selected");
					return;
				}
				int num = Class125.smethod_4(overlay);
				if (num == 1)
				{
					DialogBox.smethod_3("Only a single pixel is selected. Unfortunately, Joe Fish needs at least 10,000 selected pixels to operate properly. Please try to use a larger brush.", "Too Small, Try Again.");
					e.Cancel = true;
					return;
				}
				if (num < 10000)
				{
					DialogBox.smethod_3("Please make a larger selection, this will ensure Joe Fish can operate properly.", "Selection Too Small");
					e.Cancel = true;
				}
			}
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00010564 File Offset: 0x0000E764
		private void PondRegionSelector_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_27);
			e.Handled = true;
		}
	}
}
