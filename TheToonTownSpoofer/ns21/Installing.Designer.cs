namespace ns21
{
	// Token: 0x0200024D RID: 589
	internal sealed partial class Installing : global::ns14.Form0
	{
		// Token: 0x060019A9 RID: 6569 RVA: 0x00008ECC File Offset: 0x000070CC
		protected override void Dispose(bool disposing)
		{
			if (this.class137_0 != null)
			{
				this.class137_0.Dispose();
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x00046C20 File Offset: 0x00044E20
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns21.Installing));
			this.barProgress = new global::System.Windows.Forms.ProgressBar();
			this.btnAbort = new global::System.Windows.Forms.Button();
			this.lblStatus = new global::System.Windows.Forms.Label();
			this.grpUpdating = new global::ns24.Class310();
			this.label3 = new global::System.Windows.Forms.Label();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.grpUpdating.SuspendLayout();
			base.SuspendLayout();
			this.barProgress.Location = new global::System.Drawing.Point(15, 60);
			this.barProgress.Name = "barProgress";
			this.barProgress.Size = new global::System.Drawing.Size(260, 23);
			this.barProgress.TabIndex = 0;
			this.btnAbort.Location = new global::System.Drawing.Point(281, 60);
			this.btnAbort.Name = "btnAbort";
			this.btnAbort.Size = new global::System.Drawing.Size(75, 23);
			this.btnAbort.TabIndex = 1;
			this.btnAbort.Text = "&Abort";
			this.btnAbort.UseVisualStyleBackColor = true;
			this.btnAbort.Click += new global::System.EventHandler(this.btnAbort_Click);
			this.lblStatus.AutoSize = true;
			this.lblStatus.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.lblStatus.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.lblStatus.ForeColor = global::System.Drawing.Color.DimGray;
			this.lblStatus.Location = new global::System.Drawing.Point(12, 44);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new global::System.Drawing.Size(114, 13);
			this.lblStatus.TabIndex = 2;
			this.lblStatus.Text = "Updating ToonTown...";
			this.grpUpdating.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.grpUpdating.Controls.Add(this.label3);
			this.grpUpdating.Controls.Add(this.barProgress);
			this.grpUpdating.Controls.Add(this.lblStatus);
			this.grpUpdating.Controls.Add(this.btnAbort);
			this.grpUpdating.HeaderHeight = 30;
			this.grpUpdating.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.grpUpdating.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.grpUpdating.Location = new global::System.Drawing.Point(4, 4);
			this.grpUpdating.Name = "grpUpdating";
			this.grpUpdating.Size = new global::System.Drawing.Size(364, 92);
			this.grpUpdating.TabIndex = 3;
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.DimGray;
			this.label3.Location = new global::System.Drawing.Point(10, 8);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(146, 19);
			this.label3.TabIndex = 3;
			this.label3.Text = "Installing ToonTown";
			this.timer_0.Interval = 500;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.timer_1.Interval = 1000;
			this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.ClientSize = new global::System.Drawing.Size(372, 100);
			base.Controls.Add(this.grpUpdating);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Installing";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ToonTown : Installing";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.Installing_Load);
			this.grpUpdating.ResumeLayout(false);
			this.grpUpdating.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000726 RID: 1830
		private global::ns16.Class137 class137_0;

		// Token: 0x04000734 RID: 1844
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000735 RID: 1845
		private global::System.Windows.Forms.ProgressBar barProgress;

		// Token: 0x04000736 RID: 1846
		private global::System.Windows.Forms.Button btnAbort;

		// Token: 0x04000737 RID: 1847
		private global::System.Windows.Forms.Label lblStatus;

		// Token: 0x04000738 RID: 1848
		private global::ns24.Class310 grpUpdating;

		// Token: 0x04000739 RID: 1849
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400073A RID: 1850
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x0400073B RID: 1851
		private global::System.Windows.Forms.Timer timer_1;
	}
}
