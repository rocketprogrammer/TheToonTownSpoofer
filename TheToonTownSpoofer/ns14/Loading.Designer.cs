namespace ns14
{
	// Token: 0x020001CE RID: 462
	internal sealed partial class Loading : global::ns14.Form0
	{
		// Token: 0x06001502 RID: 5378 RVA: 0x000057DF File Offset: 0x000039DF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0002A434 File Offset: 0x00028634
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns14.Loading));
			this.circleBar = new global::ns17.CircleProgressBar();
			this.LoadingLabel = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.circleBar.AnimationSpeed = 75;
			this.circleBar.Location = new global::System.Drawing.Point(175, 2);
			this.circleBar.Name = "circleBar";
			this.circleBar.On = true;
			this.circleBar.Size = new global::System.Drawing.Size(30, 30);
			this.circleBar.TabIndex = 0;
			this.LoadingLabel.AutoSize = true;
			this.LoadingLabel.Font = new global::System.Drawing.Font("Georgia", 9f);
			this.LoadingLabel.Location = new global::System.Drawing.Point(10, 11);
			this.LoadingLabel.Name = "LoadingLabel";
			this.LoadingLabel.Size = new global::System.Drawing.Size(133, 15);
			this.LoadingLabel.TabIndex = 1;
			this.LoadingLabel.Text = "Please wait, loading...";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(210, 35);
			base.Controls.Add(this.LoadingLabel);
			base.Controls.Add(this.circleBar);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Loading";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "One Moment...";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000292 RID: 658
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000293 RID: 659
		private global::ns17.CircleProgressBar circleBar;

		// Token: 0x04000294 RID: 660
		private global::System.Windows.Forms.Label LoadingLabel;
	}
}
