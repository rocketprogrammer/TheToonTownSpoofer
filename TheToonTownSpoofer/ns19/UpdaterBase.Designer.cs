namespace ns19
{
	// Token: 0x020003F1 RID: 1009
	internal partial class UpdaterBase : global::ns14.Form0
	{
		// Token: 0x060026B0 RID: 9904 RVA: 0x000113BE File Offset: 0x0000F5BE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060026B1 RID: 9905 RVA: 0x00089570 File Offset: 0x00087770
		private void InitializeComponent()
		{
			this.UpdaterInstance = new global::ns16.UpdateControl();
			this.LogoPictureBox = new global::System.Windows.Forms.PictureBox();
			this.TitleLabel = new global::System.Windows.Forms.Label();
			this.AutomaticUpdaterLabel = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).BeginInit();
			base.SuspendLayout();
			this.UpdaterInstance.Location = new global::System.Drawing.Point(12, 58);
			this.UpdaterInstance.Name = "UpdaterInstance";
			this.UpdaterInstance.Size = new global::System.Drawing.Size(226, 16);
			this.UpdaterInstance.TabIndex = 0;
			this.UpdaterInstance.UpdateType = global::ns23.Enum78.const_3;
			this.UpdaterInstance.Canceled += new global::System.EventHandler(this.method_1);
			this.UpdaterInstance.CheckingFailed += new global::System.EventHandler<global::ns24.EventArgs26>(this.method_9);
			this.UpdaterInstance.ClosingAborted += new global::System.EventHandler(this.method_2);
			this.UpdaterInstance.DownloadingOrExtractingFailed += new global::System.EventHandler<global::ns24.EventArgs26>(this.method_8);
			this.UpdaterInstance.ReadyToBeInstalled += new global::System.EventHandler(this.method_11);
			this.UpdaterInstance.UpdateAvailable += new global::System.EventHandler(this.method_10);
			this.UpdaterInstance.UpdateFailed += new global::System.EventHandler<global::ns24.EventArgs26>(this.method_7);
			this.UpdaterInstance.UpdateSuccessful += new global::System.EventHandler<global::ns30.EventArgs7>(this.method_6);
			this.UpdaterInstance.UpdateFailedTryLater += new global::System.EventHandler(this.method_3);
			this.UpdaterInstance.CloseApplicationNow += new global::System.EventHandler(this.method_5);
			this.UpdaterInstance.UpToDate += new global::System.EventHandler<global::ns30.EventArgs7>(this.method_4);
			this.UpdaterInstance.Dismiss += new global::System.EventHandler(this.method_12);
			this.LogoPictureBox.Location = new global::System.Drawing.Point(248, 10);
			this.LogoPictureBox.Name = "LogoPictureBox";
			this.LogoPictureBox.Size = new global::System.Drawing.Size(64, 64);
			this.LogoPictureBox.TabIndex = 1;
			this.LogoPictureBox.TabStop = false;
			this.TitleLabel.Font = new global::System.Drawing.Font("Calibri", 15.75f);
			this.TitleLabel.Location = new global::System.Drawing.Point(3, 9);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new global::System.Drawing.Size(241, 26);
			this.TitleLabel.TabIndex = 2;
			this.TitleLabel.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.AutomaticUpdaterLabel.AutoSize = true;
			this.AutomaticUpdaterLabel.Location = new global::System.Drawing.Point(76, 40);
			this.AutomaticUpdaterLabel.Name = "AutomaticUpdaterLabel";
			this.AutomaticUpdaterLabel.Size = new global::System.Drawing.Size(95, 13);
			this.AutomaticUpdaterLabel.TabIndex = 3;
			this.AutomaticUpdaterLabel.Text = "Automatic Updater";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(324, 85);
			base.Controls.Add(this.AutomaticUpdaterLabel);
			base.Controls.Add(this.TitleLabel);
			base.Controls.Add(this.LogoPictureBox);
			base.Controls.Add(this.UpdaterInstance);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "UpdaterBase";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Checking for updates...";
			base.Shown += new global::System.EventHandler(this.UpdaterBase_Shown);
			((global::System.ComponentModel.ISupportInitialize)this.LogoPictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040012DF RID: 4831
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040012E0 RID: 4832
		private global::ns16.UpdateControl UpdaterInstance;

		// Token: 0x040012E1 RID: 4833
		private global::System.Windows.Forms.PictureBox LogoPictureBox;

		// Token: 0x040012E2 RID: 4834
		private global::System.Windows.Forms.Label TitleLabel;

		// Token: 0x040012E3 RID: 4835
		private global::System.Windows.Forms.Label AutomaticUpdaterLabel;
	}
}
