namespace ns30
{
	// Token: 0x020001E1 RID: 481
	internal partial class WindowSelect : global::System.Windows.Forms.Form
	{
		// Token: 0x060015FE RID: 5630 RVA: 0x000062A3 File Offset: 0x000044A3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00034C4C File Offset: 0x00032E4C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns30.WindowSelect));
			this.Selector = new global::ns22.WindowSelector();
			this.OKButton = new global::System.Windows.Forms.Button();
			this.CancelBtn = new global::System.Windows.Forms.Button();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			base.SuspendLayout();
			this.Selector.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Selector.LabelMessage = "click and drag the target onto the window";
			this.Selector.Location = new global::System.Drawing.Point(6, 5);
			this.Selector.Name = "Selector";
			this.Selector.ResourceNumber = 102;
			this.Selector.Size = new global::System.Drawing.Size(329, 60);
			this.Selector.TabIndex = 0;
			this.OKButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.OKButton.Enabled = false;
			this.OKButton.Location = new global::System.Drawing.Point(260, 71);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 1;
			this.OKButton.Text = "&OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new global::System.EventHandler(this.OKButton_Click);
			this.CancelBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.CancelBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new global::System.Drawing.Point(179, 71);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new global::System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 2;
			this.CancelBtn.Text = "&Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new global::System.EventHandler(this.CancelBtn_Click);
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(2, 84);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 36;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			base.AcceptButton = this.OKButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.CancelBtn;
			base.ClientSize = new global::System.Drawing.Size(341, 98);
			base.Controls.Add(this.HowToOpenHelpLabel);
			base.Controls.Add(this.CancelBtn);
			base.Controls.Add(this.OKButton);
			base.Controls.Add(this.Selector);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "WindowSelect";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400035E RID: 862
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x0400035F RID: 863
		private global::ns22.WindowSelector Selector;

		// Token: 0x04000360 RID: 864
		private global::System.Windows.Forms.Button OKButton;

		// Token: 0x04000361 RID: 865
		private global::System.Windows.Forms.Button CancelBtn;

		// Token: 0x04000362 RID: 866
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;
	}
}
