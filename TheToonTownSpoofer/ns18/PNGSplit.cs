using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ns15;
using ns19;
using ns20;
using ns21;
using ns27;
using ns30;
using ns31;
using TSN.Drawing;

namespace ns18
{
	// Token: 0x020002B0 RID: 688
	internal sealed partial class PNGSplit : Form
	{
		// Token: 0x06001C01 RID: 7169 RVA: 0x00057DC4 File Offset: 0x00055FC4
		public PNGSplit(Stream stream)
		{
			this.stream_0 = stream;
			this.stream_0.Position = 0L;
			this.bitmap_0 = (Image.FromStream(this.stream_0) as Bitmap);
			if (!Class125.smethod_0(this.bitmap_0.PixelFormat))
			{
				throw new InvalidPixelFormatException(this.bitmap_0.PixelFormat);
			}
			this.stream_0.Position = 0L;
			if (stream == null)
			{
				throw new ArgumentNullException("stream");
			}
			this.InitializeComponent();
			this.method_1();
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x06001C02 RID: 7170 RVA: 0x0000A631 File Offset: 0x00008831
		public Stream RGBStream
		{
			get
			{
				return this.stream_1;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001C03 RID: 7171 RVA: 0x0000A639 File Offset: 0x00008839
		public Stream JPGStream
		{
			get
			{
				return this.stream_2;
			}
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x0000A641 File Offset: 0x00008841
		private void btnSave_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00006181 File Offset: 0x00004381
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06001C06 RID: 7174 RVA: 0x0000A64A File Offset: 0x0000884A
		private void method_0(object sender, EventArgs17 e)
		{
			this.method_1();
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00057E5C File Offset: 0x0005605C
		private void method_1()
		{
			if (this.stream_1 == null)
			{
				this.stream_1 = new MemoryStream();
			}
			this.stream_1.SetLength(0L);
			if (this.stream_2 == null)
			{
				this.stream_2 = new MemoryStream();
			}
			this.stream_2.SetLength(0L);
			if (this.bitmap_1 == null)
			{
				this.bitmap_1 = new Bitmap(this.bitmap_0.Width, this.bitmap_0.Height);
			}
			Class486.smethod_0(this.stream_0, this.stream_1, this.bitmap_1, new Color?(this.cSelector.SelectedColor), true, Enum14.const_3);
			this.stream_1.Position = 0L;
			this.bitmap_2 = Class486.smethod_2(this.stream_1);
			this.picSource.Image = this.bitmap_0;
			this.picImage.Image = this.bitmap_1;
			this.picRGB.Image = this.bitmap_2;
			Class157.smethod_6(this.bitmap_1, this.stream_2, 100);
			this.stream_0.Position = 0L;
			this.stream_2.Position = 0L;
			this.stream_1.Position = 0L;
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0000A652 File Offset: 0x00008852
		private void PNGSplit_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_22);
			e.Handled = true;
		}

		// Token: 0x040009A0 RID: 2464
		private Stream stream_0;
	}
}
