namespace ns18
{
	// Token: 0x020002AF RID: 687
	internal sealed partial class frmUnusedContentPackFiles : global::System.Windows.Forms.Form
	{
		// Token: 0x06001BF9 RID: 7161 RVA: 0x0000A5DE File Offset: 0x000087DE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00057834 File Offset: 0x00055A34
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns18.frmUnusedContentPackFiles));
			this.btnOK = new global::System.Windows.Forms.Button();
			this.lbFiles = new global::System.Windows.Forms.ListView();
			this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
			this.lblUnusedContentPackFiles = new global::System.Windows.Forms.Label();
			this.btnExport = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.saveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
			base.SuspendLayout();
			this.btnOK.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOK.Location = new global::System.Drawing.Point(263, 344);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new global::System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new global::System.EventHandler(this.btnOK_Click);
			this.lbFiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lbFiles.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.lbFiles.HeaderStyle = global::System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lbFiles.HideSelection = false;
			this.lbFiles.Location = new global::System.Drawing.Point(12, 74);
			this.lbFiles.MultiSelect = false;
			this.lbFiles.Name = "lbFiles";
			this.lbFiles.Size = new global::System.Drawing.Size(326, 264);
			this.lbFiles.TabIndex = 0;
			this.lbFiles.UseCompatibleStateImageBehavior = false;
			this.lbFiles.View = global::System.Windows.Forms.View.Details;
			this.lbFiles.SelectedIndexChanged += new global::System.EventHandler(this.lbFiles_SelectedIndexChanged);
			this.columnHeader_0.Text = "";
			this.columnHeader_0.Width = 301;
			this.lblUnusedContentPackFiles.AutoSize = true;
			this.lblUnusedContentPackFiles.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblUnusedContentPackFiles.Location = new global::System.Drawing.Point(7, 7);
			this.lblUnusedContentPackFiles.Name = "lblUnusedContentPackFiles";
			this.lblUnusedContentPackFiles.Size = new global::System.Drawing.Size(237, 26);
			this.lblUnusedContentPackFiles.TabIndex = 14;
			this.lblUnusedContentPackFiles.Text = "Unused Content Pack Files";
			this.btnExport.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnExport.Enabled = false;
			this.btnExport.Location = new global::System.Drawing.Point(182, 344);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new global::System.Drawing.Size(75, 23);
			this.btnExport.TabIndex = 1;
			this.btnExport.Text = "Export";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new global::System.EventHandler(this.btnExport_Click);
			this.label1.Location = new global::System.Drawing.Point(9, 33);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(329, 38);
			this.label1.TabIndex = 17;
			this.label1.Text = "These files are no longer used in ToonTown and will not be saved, please use this opportunity to export your data.";
			this.saveFileDialog_0.Title = "Select a path to extract your file.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(350, 374);
			base.Controls.Add(this.lbFiles);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.btnExport);
			base.Controls.Add(this.lblUnusedContentPackFiles);
			base.Controls.Add(this.btnOK);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MaximumSize = new global::System.Drawing.Size(1200, 412);
			this.MinimumSize = new global::System.Drawing.Size(366, 412);
			base.Name = "frmUnusedContentPackFiles";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MakePackage : Unused Content Pack Files";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.frmUnusedContentPackFiles_FormClosing);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000997 RID: 2455
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000998 RID: 2456
		private global::System.Windows.Forms.Button btnOK;

		// Token: 0x04000999 RID: 2457
		private global::System.Windows.Forms.ListView lbFiles;

		// Token: 0x0400099A RID: 2458
		private global::System.Windows.Forms.ColumnHeader columnHeader_0;

		// Token: 0x0400099B RID: 2459
		private global::System.Windows.Forms.Label lblUnusedContentPackFiles;

		// Token: 0x0400099C RID: 2460
		private global::System.Windows.Forms.Button btnExport;

		// Token: 0x0400099D RID: 2461
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400099E RID: 2462
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog_0;
	}
}
