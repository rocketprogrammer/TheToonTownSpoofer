namespace ns30
{
	// Token: 0x020001DE RID: 478
	internal sealed partial class RegionSelector : global::System.Windows.Forms.Form
	{
		// Token: 0x060015ED RID: 5613 RVA: 0x00006193 File Offset: 0x00004393
		protected override void Dispose(bool disposing)
		{
			if (this.bitmap_0 != null)
			{
				this.bitmap_0.Dispose();
			}
			this.class141_0.Dispose();
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x00032DF4 File Offset: 0x00030FF4
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns30.RegionSelector));
			this.mnuCommands = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.cmnuAccept = new global::System.Windows.Forms.ToolStripMenuItem();
			this.cmnuCancel = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			this.RegionSelectorControl = new global::ns22.Control5();
			this.mnuCommands.SuspendLayout();
			base.SuspendLayout();
			this.mnuCommands.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.cmnuAccept,
				this.cmnuCancel
			});
			this.mnuCommands.Name = "mnuCommands";
			this.mnuCommands.Size = new global::System.Drawing.Size(112, 48);
			this.cmnuAccept.Name = "cmnuAccept";
			this.cmnuAccept.Size = new global::System.Drawing.Size(111, 22);
			this.cmnuAccept.Text = "&Accept";
			this.cmnuAccept.Click += new global::System.EventHandler(this.cmnuAccept_Click);
			this.cmnuCancel.Name = "cmnuCancel";
			this.cmnuCancel.Size = new global::System.Drawing.Size(111, 22);
			this.cmnuCancel.Text = "&Cancel";
			this.cmnuCancel.Click += new global::System.EventHandler(this.cmnuCancel_Click);
			this.toolTip_0.ToolTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.toolTip_0.ToolTipTitle = "Capture Screen";
			this.RegionSelectorControl.BackColor = global::System.Drawing.SystemColors.Control;
			this.RegionSelectorControl.ContextMenuStrip = this.mnuCommands;
			this.RegionSelectorControl.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.RegionSelectorControl.Font = new global::System.Drawing.Font("Georgia", 20.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.RegionSelectorControl.Location = new global::System.Drawing.Point(0, 0);
			this.RegionSelectorControl.Name = "RegionSelectorControl";
			this.RegionSelectorControl.Size = new global::System.Drawing.Size(852, 445);
			this.RegionSelectorControl.TabIndex = 0;
			this.RegionSelectorControl.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.RegionSelectorControl_KeyDown);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(852, 445);
			base.Controls.Add(this.RegionSelectorControl);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RegionSelector";
			this.Text = "The ToonTown Spoofer : Region Selector";
			base.Load += new global::System.EventHandler(this.RegionSelector_Load);
			this.mnuCommands.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000326 RID: 806
		private global::System.Drawing.Bitmap bitmap_0;

		// Token: 0x04000329 RID: 809
		private global::ns16.Class141 class141_0;

		// Token: 0x0400032A RID: 810
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400032B RID: 811
		private global::ns22.Control5 RegionSelectorControl;

		// Token: 0x0400032C RID: 812
		private global::System.Windows.Forms.ContextMenuStrip mnuCommands;

		// Token: 0x0400032D RID: 813
		private global::System.Windows.Forms.ToolStripMenuItem cmnuAccept;

		// Token: 0x0400032E RID: 814
		private global::System.Windows.Forms.ToolStripMenuItem cmnuCancel;

		// Token: 0x0400032F RID: 815
		private global::System.Windows.Forms.ToolTip toolTip_0;
	}
}
