namespace ns17
{
	// Token: 0x0200027D RID: 637
	internal sealed partial class DialogBox : global::ns14.Form0
	{
		// Token: 0x06001ABA RID: 6842 RVA: 0x000099B6 File Offset: 0x00007BB6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001ABB RID: 6843 RVA: 0x0004F290 File Offset: 0x0004D490
		private void InitializeComponent()
		{
			this.MainPanel = new global::System.Windows.Forms.Panel();
			this.LayoutPanel = new global::System.Windows.Forms.FlowLayoutPanel();
			this.Message = new global::System.Windows.Forms.Label();
			this.IconImage = new global::ns18.Control2();
			this.MainPanel.SuspendLayout();
			base.SuspendLayout();
			this.MainPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.MainPanel.Controls.Add(this.LayoutPanel);
			this.MainPanel.Controls.Add(this.Message);
			this.MainPanel.Controls.Add(this.IconImage);
			this.MainPanel.Location = new global::System.Drawing.Point(12, 12);
			this.MainPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.Size = new global::System.Drawing.Size(134, 93);
			this.MainPanel.TabIndex = 0;
			this.LayoutPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.LayoutPanel.AutoSize = true;
			this.LayoutPanel.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.LayoutPanel.Location = new global::System.Drawing.Point(0, 93);
			this.LayoutPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.LayoutPanel.Name = "LayoutPanel";
			this.LayoutPanel.Size = new global::System.Drawing.Size(0, 0);
			this.LayoutPanel.TabIndex = 6;
			this.Message.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.Message.AutoEllipsis = true;
			this.Message.Location = new global::System.Drawing.Point(0, 0);
			this.Message.Margin = new global::System.Windows.Forms.Padding(0);
			this.Message.Name = "Message";
			this.Message.Size = new global::System.Drawing.Size(96, 64);
			this.Message.TabIndex = 5;
			this.Message.TextAlign = global::System.Drawing.ContentAlignment.MiddleCenter;
			this.IconImage.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.IconImage.Location = new global::System.Drawing.Point(102, 0);
			this.IconImage.Margin = new global::System.Windows.Forms.Padding(0);
			this.IconImage.Name = "IconImage";
			this.IconImage.Size = new global::System.Drawing.Size(32, 32);
			this.IconImage.TabIndex = 4;
			this.IconImage.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(158, 117);
			base.Controls.Add(this.MainPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "DialogBox";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "DialogBox";
			base.TopMost = true;
			this.MainPanel.ResumeLayout(false);
			this.MainPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400082F RID: 2095
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000830 RID: 2096
		private global::System.Windows.Forms.Panel MainPanel;

		// Token: 0x04000831 RID: 2097
		private global::System.Windows.Forms.FlowLayoutPanel LayoutPanel;

		// Token: 0x04000832 RID: 2098
		private global::System.Windows.Forms.Label Message;

		// Token: 0x04000833 RID: 2099
		private global::ns18.Control2 IconImage;
	}
}
