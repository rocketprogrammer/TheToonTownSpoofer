namespace ns15
{
	// Token: 0x02000219 RID: 537
	internal partial class RunBaseForm : global::ns14.Form0
	{
		// Token: 0x060017A2 RID: 6050 RVA: 0x0003E11C File Offset: 0x0003C31C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			if (this.manualResetEventSlim_0 != null)
			{
				this.manualResetEventSlim_0.Dispose();
			}
			if (this.class149_0 != null)
			{
				this.class149_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0003E16C File Offset: 0x0003C36C
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.class318_0 = new global::ns25.Class318(this.icontainer_0);
			this.StopButton = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.timer_0.Enabled = false;
			this.timer_0.Interval = 1000;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.class318_0.HotkeyActivated += new global::System.EventHandler<global::ns17.EventArgs18>(this.method_5);
			this.StopButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.StopButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.StopButton.Location = new global::System.Drawing.Point(203, 9);
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new global::System.Drawing.Size(75, 23);
			this.StopButton.TabIndex = 1;
			this.StopButton.Text = "Stop";
			this.StopButton.UseVisualStyleBackColor = true;
			this.StopButton.Click += new global::System.EventHandler(this.StopButton_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(286, 40);
			base.Controls.Add(this.StopButton);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "RunBaseForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Press Escape to Stop";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.RunBaseForm_Load);
			base.ResumeLayout(false);
		}

		// Token: 0x040005B5 RID: 1461
		protected global::ns28.Class149 class149_0;

		// Token: 0x040005B7 RID: 1463
		protected readonly global::System.Threading.ManualResetEventSlim manualResetEventSlim_0;

		// Token: 0x040005BB RID: 1467
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040005BC RID: 1468
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x040005BD RID: 1469
		private global::ns25.Class318 class318_0;

		// Token: 0x040005BE RID: 1470
		private global::System.Windows.Forms.Button StopButton;
	}
}
