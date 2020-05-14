using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns17;
using ns22;
using ns23;
using ns25;
using ns26;
using ns29;
using TSN.Controls;

namespace ns18
{
	// Token: 0x020002AF RID: 687
	internal sealed partial class frmUnusedContentPackFiles : Form
	{
		// Token: 0x06001BFB RID: 7163 RVA: 0x00057C9C File Offset: 0x00055E9C
		public frmUnusedContentPackFiles(Dictionary<ListViewItemState<string>, Class338> data)
		{
			Action<ListViewItemState<string>> action = null;
			base..ctor();
			if (data == null)
			{
				throw new ArgumentNullException("data");
			}
			this.dictionary_0 = data;
			this.InitializeComponent();
			IEnumerable<ListViewItemState<string>> keys = this.dictionary_0.Keys;
			if (action == null)
			{
				action = new Action<ListViewItemState<string>>(this.method_0);
			}
			keys.smethod_7(action);
		}

		// Token: 0x06001BFC RID: 7164 RVA: 0x000050D4 File Offset: 0x000032D4
		private void btnOK_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001BFD RID: 7165 RVA: 0x00057CF0 File Offset: 0x00055EF0
		private void btnExport_Click(object sender, EventArgs e)
		{
			if (this.lbFiles.SelectedItems.Count > 0)
			{
				ListViewItemState<string> listViewItemState = this.lbFiles.SelectedItems[0] as ListViewItemState<string>;
				Enum68 @enum = Class136.smethod_4(listViewItemState.State);
				if (@enum == Enum68.const_0)
				{
					return;
				}
				this.saveFileDialog_0.FileName = Path.GetFileName(listViewItemState.State);
				this.saveFileDialog_0.Filter = @enum.smethod_0(false);
				if (this.saveFileDialog_0.ShowDialog() == DialogResult.OK)
				{
					Class338 mfd = this.dictionary_0[listViewItemState];
					mfd.smethod_0(this.saveFileDialog_0.FileName);
				}
			}
		}

		// Token: 0x06001BFE RID: 7166 RVA: 0x0000A5FD File Offset: 0x000087FD
		private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.btnExport.Enabled = (this.lbFiles.SelectedItems.Count > 0);
		}

		// Token: 0x06001BFF RID: 7167 RVA: 0x00057D8C File Offset: 0x00055F8C
		private void frmUnusedContentPackFiles_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = (DialogBox.smethod_6("After saving your Content Pack these files will be no longer available. Are you sure you would like to close this window?", "Close the Unused Content Pack Files window?", new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			}) != DialogResult.Yes);
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x0000A61D File Offset: 0x0000881D
		[CompilerGenerated]
		private void method_0(ListViewItemState<string> item)
		{
			this.lbFiles.Items.Add(item);
		}

		// Token: 0x0400099F RID: 2463
		private Dictionary<ListViewItemState<string>, Class338> dictionary_0;
	}
}
