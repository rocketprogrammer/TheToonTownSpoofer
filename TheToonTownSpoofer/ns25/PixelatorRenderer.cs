using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns28;

namespace ns25
{
	// Token: 0x02000332 RID: 818
	[ToolboxItem(false)]
	internal sealed class PixelatorRenderer : UserControl
	{
		// Token: 0x06001FDF RID: 8159 RVA: 0x0000CD4B File Offset: 0x0000AF4B
		protected override void Dispose(bool disposing)
		{
			if (this.bitmap_0 != null)
			{
				this.bitmap_0.Dispose();
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001FE0 RID: 8160 RVA: 0x0006969C File Offset: 0x0006789C
		private void InitializeComponent()
		{
			this.PixelatorPreview = new PictureBox();
			((ISupportInitialize)this.PixelatorPreview).BeginInit();
			base.SuspendLayout();
			this.PixelatorPreview.Location = new Point(2, 2);
			this.PixelatorPreview.Name = "PixelatorPreview";
			this.PixelatorPreview.Size = new Size(100, 100);
			this.PixelatorPreview.SizeMode = PictureBoxSizeMode.StretchImage;
			this.PixelatorPreview.TabIndex = 1;
			this.PixelatorPreview.TabStop = false;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.PixelatorPreview);
			base.Name = "PixelatorRenderer";
			base.Size = new Size(104, 104);
			((ISupportInitialize)this.PixelatorPreview).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x06001FE1 RID: 8161 RVA: 0x00069778 File Offset: 0x00067978
		public PixelatorRenderer(Class150 pix)
		{
			this.InitializeComponent();
			this.PixelatorPreview.Image = (this.bitmap_0 = pix.GetBitmap);
		}

		// Token: 0x04000C5B RID: 3163
		private IContainer icontainer_0;

		// Token: 0x04000C5C RID: 3164
		private PictureBox PixelatorPreview;

		// Token: 0x04000C5D RID: 3165
		private Bitmap bitmap_0;
	}
}
