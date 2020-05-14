using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ns15;
using ns17;

namespace ns25
{
	// Token: 0x02000334 RID: 820
	internal sealed partial class JoeFishNewSpeciesCaught : Form
	{
		// Token: 0x06001FE7 RID: 8167 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		public JoeFishNewSpeciesCaught()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06001FE8 RID: 8168 RVA: 0x0000CDCA File Offset: 0x0000AFCA
		// (set) Token: 0x06001FE9 RID: 8169 RVA: 0x0000CDD2 File Offset: 0x0000AFD2
		public Bitmap Screenshot
		{
			get
			{
				return this.bitmap_0;
			}
			set
			{
				this.bitmap_0 = value;
				this.ScreenshotPic.Image = this.bitmap_0;
			}
		}

		// Token: 0x06001FEA RID: 8170 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		private void StopFlashingBtn_Click(object sender, EventArgs e)
		{
			this.NewSpeciesFlasher.EnableFlashing = false;
			this.StopFlashingBtn.Enabled = false;
		}

		// Token: 0x06001FEB RID: 8171 RVA: 0x000050D4 File Offset: 0x000032D4
		private void CloseBtn_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001FEC RID: 8172 RVA: 0x00069EE8 File Offset: 0x000680E8
		private void SaveScreenshotBtn_Click(object sender, EventArgs e)
		{
			if (this.bitmap_0 == null)
			{
				DialogBox.smethod_3("There appears to have been an error and a screenshot was not taken.", "Error Accessing Screenshot");
				return;
			}
			if (this.saveFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				try
				{
					switch (this.saveFileDialog_0.FilterIndex)
					{
					case 1:
						using (Stream stream = File.Open(this.saveFileDialog_0.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
						{
							Class157.smethod_6(this.bitmap_0, stream, 100);
							goto IL_A3;
						}
						break;
					case 2:
						break;
					default:
						goto IL_A3;
					}
					using (Stream stream2 = File.Open(this.saveFileDialog_0.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
					{
						Class157.smethod_5(this.bitmap_0, stream2, 100);
					}
					IL_A3:;
				}
				catch (Exception ex)
				{
					DialogBox.smethod_7(ex, this.saveFileDialog_0.FileName);
				}
			}
		}

		// Token: 0x04000C6B RID: 3179
		private Bitmap bitmap_0;
	}
}
