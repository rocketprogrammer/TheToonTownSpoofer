namespace ns17
{
	// Token: 0x02000269 RID: 617
	internal sealed partial class MyGallery : global::System.Windows.Forms.Form
	{
		// Token: 0x06001A48 RID: 6728 RVA: 0x0004DAA8 File Offset: 0x0004BCA8
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.class143_0 != null)
				{
					this.class143_0.Dispose();
				}
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
				if (this.fileSystemWatcher_0 != null)
				{
					this.fileSystemWatcher_0.Dispose();
				}
				if (this.control_0 != null)
				{
					this.control_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001A49 RID: 6729 RVA: 0x0004DB0C File Offset: 0x0004BD0C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns17.MyGallery));
			this.fileSystemWatcher_0 = new global::System.IO.FileSystemWatcher();
			this.StatusBar = new global::System.Windows.Forms.StatusStrip();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.ScreenshotsLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.Thumbnails = new global::ns24.ThumbnailStrip();
			((global::System.ComponentModel.ISupportInitialize)this.fileSystemWatcher_0).BeginInit();
			this.StatusBar.SuspendLayout();
			base.SuspendLayout();
			this.fileSystemWatcher_0.EnableRaisingEvents = true;
			this.fileSystemWatcher_0.Filter = "*.jpg";
			this.fileSystemWatcher_0.SynchronizingObject = this;
			this.fileSystemWatcher_0.Created += new global::System.IO.FileSystemEventHandler(this.fileSystemWatcher_0_Created);
			this.fileSystemWatcher_0.Deleted += new global::System.IO.FileSystemEventHandler(this.fileSystemWatcher_0_Deleted);
			this.StatusBar.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.HowToOpenHelpLabel,
				this.ScreenshotsLabel
			});
			this.StatusBar.Location = new global::System.Drawing.Point(0, 186);
			this.StatusBar.Name = "StatusBar";
			this.StatusBar.Size = new global::System.Drawing.Size(606, 22);
			this.StatusBar.TabIndex = 2;
			this.StatusBar.Text = "statusStrip1";
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(132, 17);
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			this.ScreenshotsLabel.Name = "ScreenshotsLabel";
			this.ScreenshotsLabel.Size = new global::System.Drawing.Size(0, 17);
			this.Thumbnails.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.Thumbnails.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.Thumbnails.Location = new global::System.Drawing.Point(0, 0);
			this.Thumbnails.Name = "Thumbnails";
			this.Thumbnails.Size = new global::System.Drawing.Size(606, 186);
			this.Thumbnails.TabIndex = 1;
			this.Thumbnails.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(606, 208);
			base.Controls.Add(this.Thumbnails);
			base.Controls.Add(this.StatusBar);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(2800, 246);
			this.MinimumSize = new global::System.Drawing.Size(240, 246);
			base.Name = "MyGallery";
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "My Gallery";
			base.Load += new global::System.EventHandler(this.MyGallery_Load);
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.MyGallery_HelpRequested);
			((global::System.ComponentModel.ISupportInitialize)this.fileSystemWatcher_0).EndInit();
			this.StatusBar.ResumeLayout(false);
			this.StatusBar.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040007D5 RID: 2005
		private readonly global::System.Windows.Forms.Control control_0;

		// Token: 0x040007D8 RID: 2008
		private global::ns20.Class143 class143_0;

		// Token: 0x040007D9 RID: 2009
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040007DA RID: 2010
		private global::System.IO.FileSystemWatcher fileSystemWatcher_0;

		// Token: 0x040007DB RID: 2011
		private global::ns24.ThumbnailStrip Thumbnails;

		// Token: 0x040007DC RID: 2012
		private global::System.Windows.Forms.StatusStrip StatusBar;

		// Token: 0x040007DD RID: 2013
		private global::System.Windows.Forms.ToolStripStatusLabel ScreenshotsLabel;

		// Token: 0x040007DE RID: 2014
		private global::System.Windows.Forms.ToolStripStatusLabel HowToOpenHelpLabel;
	}
}
