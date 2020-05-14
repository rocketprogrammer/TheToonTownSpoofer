using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns21;

namespace ns30
{
	// Token: 0x020001DD RID: 477
	internal sealed class ThumbnailContainer : UserControl
	{
		// Token: 0x170006D7 RID: 1751
		// (get) Token: 0x060015C1 RID: 5569 RVA: 0x00005F9E File Offset: 0x0000419E
		// (set) Token: 0x060015C2 RID: 5570 RVA: 0x00005FAB File Offset: 0x000041AB
		[DefaultValue(typeof(Bitmap), null)]
		public Bitmap Image
		{
			get
			{
				return this.ThumbButton.Image;
			}
			set
			{
				this.ThumbButton.Image = value;
			}
		}

		// Token: 0x170006D8 RID: 1752
		// (get) Token: 0x060015C3 RID: 5571 RVA: 0x00005FB9 File Offset: 0x000041B9
		// (set) Token: 0x060015C4 RID: 5572 RVA: 0x00005FC6 File Offset: 0x000041C6
		public string FileName
		{
			get
			{
				return this.ThumbLabel.Text;
			}
			set
			{
				this.ThumbLabel.Text = value;
			}
		}

		// Token: 0x14000169 RID: 361
		// (add) Token: 0x060015C5 RID: 5573 RVA: 0x00005FD4 File Offset: 0x000041D4
		// (remove) Token: 0x060015C6 RID: 5574 RVA: 0x00005FE2 File Offset: 0x000041E2
		public event EventHandler ShowScreenshot
		{
			add
			{
				this.ThumbButton.ShowScreenshot += value;
			}
			remove
			{
				this.ThumbButton.ShowScreenshot -= value;
			}
		}

		// Token: 0x1400016A RID: 362
		// (add) Token: 0x060015C7 RID: 5575 RVA: 0x00005FF0 File Offset: 0x000041F0
		// (remove) Token: 0x060015C8 RID: 5576 RVA: 0x00005FFE File Offset: 0x000041FE
		public event EventHandler ButtonSelected
		{
			add
			{
				this.ThumbButton.ButtonSelected += value;
			}
			remove
			{
				this.ThumbButton.ButtonSelected -= value;
			}
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060015C9 RID: 5577 RVA: 0x0000600C File Offset: 0x0000420C
		// (set) Token: 0x060015CA RID: 5578 RVA: 0x00006019 File Offset: 0x00004219
		public bool Selected
		{
			get
			{
				return this.ThumbButton.Selected;
			}
			set
			{
				this.ThumbButton.Selected = value;
			}
		}

		// Token: 0x060015CB RID: 5579 RVA: 0x00006027 File Offset: 0x00004227
		public ThumbnailContainer()
		{
			this.InitializeComponent();
		}

		// Token: 0x060015CC RID: 5580 RVA: 0x0003220C File Offset: 0x0003040C
		private void ThumbnailContainer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Tab)
			{
				return;
			}
			e.IsInputKey = true;
		}

		// Token: 0x060015CD RID: 5581 RVA: 0x00006035 File Offset: 0x00004235
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00032230 File Offset: 0x00030430
		private void InitializeComponent()
		{
			this.ThumbLabel = new Label();
			this.ThumbButton = new Control0();
			base.SuspendLayout();
			this.ThumbLabel.AutoEllipsis = true;
			this.ThumbLabel.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.ThumbLabel.Location = new Point(0, 134);
			this.ThumbLabel.Name = "ThumbLabel";
			this.ThumbLabel.Size = new Size(178, 12);
			this.ThumbLabel.TabIndex = 1;
			this.ThumbLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.ThumbButton.BackColor = SystemColors.Control;
			this.ThumbButton.Cursor = Cursors.Hand;
			this.ThumbButton.Location = new Point(0, 0);
			this.ThumbButton.Name = "ThumbButton";
			this.ThumbButton.Size = new Size(178, 134);
			this.ThumbButton.TabIndex = 0;
			this.ThumbButton.TabStop = false;
			this.ThumbButton.Text = "thumbnailButton1";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.ThumbLabel);
			base.Controls.Add(this.ThumbButton);
			base.Name = "ThumbnailContainer";
			base.Size = new Size(178, 146);
			base.PreviewKeyDown += this.ThumbnailContainer_PreviewKeyDown;
			base.ResumeLayout(false);
		}

		// Token: 0x0400031E RID: 798
		private IContainer icontainer_0;

		// Token: 0x0400031F RID: 799
		private Control0 ThumbButton;

		// Token: 0x04000320 RID: 800
		private Label ThumbLabel;
	}
}
