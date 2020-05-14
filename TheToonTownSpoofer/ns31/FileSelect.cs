using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns24;

namespace ns31
{
	// Token: 0x020002CE RID: 718
	internal sealed partial class FileSelect : FileSelectBase
	{
		// Token: 0x06001CA3 RID: 7331 RVA: 0x0000AD98 File Offset: 0x00008F98
		public FileSelect()
		{
			this.InitializeComponent_1();
			base.method_0<StringInputForm>();
		}

		// Token: 0x06001CA5 RID: 7333 RVA: 0x0005C558 File Offset: 0x0005A758
		private void InitializeComponent_1()
		{
			new ComponentResourceManager(typeof(FileSelect));
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(456, 223);
			base.Name = "FileSelect";
			this.Text = "The ToonTown Spoofer : Open File";
			base.ResumeLayout(false);
		}
	}
}
