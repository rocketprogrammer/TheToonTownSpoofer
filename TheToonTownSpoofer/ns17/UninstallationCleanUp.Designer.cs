namespace ns17
{
	// Token: 0x02000294 RID: 660
	internal sealed partial class UninstallationCleanUp : global::ns14.Form0
	{
		// Token: 0x06001B51 RID: 6993 RVA: 0x00009F56 File Offset: 0x00008156
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00053E68 File Offset: 0x00052068
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns17.UninstallationCleanUp));
			this.DeletingFileLabel = new global::System.Windows.Forms.Label();
			this.CleaningUpLabel = new global::System.Windows.Forms.Label();
			this.folderBrowserDialog_0 = new global::System.Windows.Forms.FolderBrowserDialog();
			base.SuspendLayout();
			this.DeletingFileLabel.AutoEllipsis = true;
			this.DeletingFileLabel.Font = new global::System.Drawing.Font("Georgia", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.DeletingFileLabel.Location = new global::System.Drawing.Point(99, 9);
			this.DeletingFileLabel.Name = "DeletingFileLabel";
			this.DeletingFileLabel.Size = new global::System.Drawing.Size(266, 14);
			this.DeletingFileLabel.TabIndex = 2;
			this.CleaningUpLabel.AutoSize = true;
			this.CleaningUpLabel.Font = new global::System.Drawing.Font("Georgia", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.CleaningUpLabel.Location = new global::System.Drawing.Point(12, 9);
			this.CleaningUpLabel.Name = "CleaningUpLabel";
			this.CleaningUpLabel.Size = new global::System.Drawing.Size(81, 14);
			this.CleaningUpLabel.TabIndex = 1;
			this.CleaningUpLabel.Text = "Cleaning up:";
			this.folderBrowserDialog_0.Description = "Please choose a new directory for your screenshots.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(377, 33);
			base.Controls.Add(this.DeletingFileLabel);
			base.Controls.Add(this.CleaningUpLabel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UninstallationCleanUp";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer : Clean Up";
			base.Shown += new global::System.EventHandler(this.UninstallationCleanUp_Shown);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040008FB RID: 2299
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040008FC RID: 2300
		private global::System.Windows.Forms.Label DeletingFileLabel;

		// Token: 0x040008FD RID: 2301
		private global::System.Windows.Forms.Label CleaningUpLabel;

		// Token: 0x040008FE RID: 2302
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_0;
	}
}
