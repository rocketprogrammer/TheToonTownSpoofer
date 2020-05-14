using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns21;
using ns24;

namespace ns20
{
	// Token: 0x02000451 RID: 1105
	internal sealed partial class ReleaseNotes : Form
	{
		// Token: 0x06002980 RID: 10624 RVA: 0x00013203 File Offset: 0x00011403
		public ReleaseNotes()
		{
			this.InitializeComponent();
		}

		// Token: 0x06002981 RID: 10625 RVA: 0x0009F430 File Offset: 0x0009D630
		private void ReleaseNotes_Load(object sender, EventArgs e)
		{
			Class305 @class = new Class305();
			this.ReleaseNotesRTF.Rtf = Class434.smethod_0(@class.sortedList_0);
		}

		// Token: 0x06002982 RID: 10626 RVA: 0x000050D4 File Offset: 0x000032D4
		private void OKButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
