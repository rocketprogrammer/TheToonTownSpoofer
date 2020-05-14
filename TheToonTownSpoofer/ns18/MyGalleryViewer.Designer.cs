namespace ns18
{
	// Token: 0x02000299 RID: 665
	internal sealed partial class MyGalleryViewer : global::ns18.Form1
	{
		// Token: 0x06001B93 RID: 7059 RVA: 0x0000A1AD File Offset: 0x000083AD
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x0005615C File Offset: 0x0005435C
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns18.MyGalleryViewer));
			this.ImageToolStrip = new global::System.Windows.Forms.ToolStrip();
			this.PreviousImageButton = new global::System.Windows.Forms.ToolStripButton();
			this.NextImageButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.CopyImageButton = new global::System.Windows.Forms.ToolStripButton();
			this.DeleteImageButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.SizeModeDropDownMenu = new global::System.Windows.Forms.ToolStripDropDownButton();
			this.StretchMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MaintainAspectRatioMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.MaintainAspectRatioAndStretchMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.FullScreenButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.StopButton = new global::System.Windows.Forms.ToolStripButton();
			this.PlayButton = new global::System.Windows.Forms.ToolStripButton();
			this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
			this.saveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
			this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.RendererControl = new global::ns22.ImageRenderer();
			this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
			this.ImageToolStrip.SuspendLayout();
			base.SuspendLayout();
			this.ImageToolStrip.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.ImageToolStrip.AutoSize = false;
			this.ImageToolStrip.Dock = global::System.Windows.Forms.DockStyle.None;
			this.ImageToolStrip.GripStyle = global::System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ImageToolStrip.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.PreviousImageButton,
				this.NextImageButton,
				this.toolStripSeparator1,
				this.CopyImageButton,
				this.DeleteImageButton,
				this.toolStripSeparator2,
				this.SizeModeDropDownMenu,
				this.FullScreenButton,
				this.toolStripSeparator4,
				this.StopButton,
				this.PlayButton
			});
			this.ImageToolStrip.Location = new global::System.Drawing.Point(0, 0);
			this.ImageToolStrip.Name = "ImageToolStrip";
			this.ImageToolStrip.Size = new global::System.Drawing.Size(567, 25);
			this.ImageToolStrip.TabIndex = 1;
			this.ImageToolStrip.MouseEnter += new global::System.EventHandler(this.RendererControl_MouseEnter);
			this.ImageToolStrip.MouseLeave += new global::System.EventHandler(this.RendererControl_MouseLeave);
			this.PreviousImageButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PreviousImageButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PreviousImageButton.Image");
			this.PreviousImageButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.PreviousImageButton.Name = "PreviousImageButton";
			this.PreviousImageButton.Size = new global::System.Drawing.Size(23, 22);
			this.PreviousImageButton.ToolTipText = "Previous (Left)";
			this.PreviousImageButton.Click += new global::System.EventHandler(this.PreviousImageButton_Click);
			this.NextImageButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NextImageButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NextImageButton.Image");
			this.NextImageButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.NextImageButton.Name = "NextImageButton";
			this.NextImageButton.Size = new global::System.Drawing.Size(23, 22);
			this.NextImageButton.ToolTipText = "Next (Right)";
			this.NextImageButton.Click += new global::System.EventHandler(this.NextImageButton_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(6, 25);
			this.CopyImageButton.Enabled = false;
			this.CopyImageButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("CopyImageButton.Image");
			this.CopyImageButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.CopyImageButton.Name = "CopyImageButton";
			this.CopyImageButton.Size = new global::System.Drawing.Size(55, 22);
			this.CopyImageButton.Text = "Copy";
			this.CopyImageButton.ToolTipText = "Copy the image to another location.";
			this.CopyImageButton.Click += new global::System.EventHandler(this.CopyImageButton_Click);
			this.DeleteImageButton.Enabled = false;
			this.DeleteImageButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("DeleteImageButton.Image");
			this.DeleteImageButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.DeleteImageButton.Name = "DeleteImageButton";
			this.DeleteImageButton.Size = new global::System.Drawing.Size(60, 22);
			this.DeleteImageButton.Text = "Delete";
			this.DeleteImageButton.ToolTipText = "Delete the image.";
			this.DeleteImageButton.Click += new global::System.EventHandler(this.DeleteImageButton_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(6, 25);
			this.SizeModeDropDownMenu.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.StretchMenuItem,
				this.MaintainAspectRatioMenuItem,
				this.MaintainAspectRatioAndStretchMenuItem
			});
			this.SizeModeDropDownMenu.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SizeModeDropDownMenu.Image");
			this.SizeModeDropDownMenu.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.SizeModeDropDownMenu.Name = "SizeModeDropDownMenu";
			this.SizeModeDropDownMenu.Size = new global::System.Drawing.Size(90, 22);
			this.SizeModeDropDownMenu.Text = "Size Mode";
			this.StretchMenuItem.Name = "StretchMenuItem";
			this.StretchMenuItem.Size = new global::System.Drawing.Size(253, 22);
			this.StretchMenuItem.Text = "Stretch";
			this.StretchMenuItem.Click += new global::System.EventHandler(this.StretchMenuItem_Click);
			this.MaintainAspectRatioMenuItem.Name = "MaintainAspectRatioMenuItem";
			this.MaintainAspectRatioMenuItem.Size = new global::System.Drawing.Size(253, 22);
			this.MaintainAspectRatioMenuItem.Text = "Maintain Aspect Ratio";
			this.MaintainAspectRatioMenuItem.Click += new global::System.EventHandler(this.MaintainAspectRatioMenuItem_Click);
			this.MaintainAspectRatioAndStretchMenuItem.Name = "MaintainAspectRatioAndStretchMenuItem";
			this.MaintainAspectRatioAndStretchMenuItem.Size = new global::System.Drawing.Size(253, 22);
			this.MaintainAspectRatioAndStretchMenuItem.Text = "Maintain Aspect Ratio and Stretch";
			this.MaintainAspectRatioAndStretchMenuItem.Click += new global::System.EventHandler(this.MaintainAspectRatioAndStretchMenuItem_Click);
			this.FullScreenButton.CheckOnClick = true;
			this.FullScreenButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("FullScreenButton.Image");
			this.FullScreenButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.FullScreenButton.Name = "FullScreenButton";
			this.FullScreenButton.Size = new global::System.Drawing.Size(84, 22);
			this.FullScreenButton.Text = "Full Screen";
			this.FullScreenButton.ToolTipText = "Full Screen (F12)";
			this.FullScreenButton.Click += new global::System.EventHandler(this.FullScreenButton_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(6, 25);
			this.StopButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.StopButton.Enabled = false;
			this.StopButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("StopButton.Image");
			this.StopButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.StopButton.Name = "StopButton";
			this.StopButton.Size = new global::System.Drawing.Size(23, 22);
			this.StopButton.Text = "Stop";
			this.StopButton.ToolTipText = "Stop Slideshow";
			this.StopButton.Click += new global::System.EventHandler(this.StopButton_Click);
			this.PlayButton.DisplayStyle = global::System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.PlayButton.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("PlayButton.Image");
			this.PlayButton.ImageTransparentColor = global::System.Drawing.Color.Magenta;
			this.PlayButton.Name = "PlayButton";
			this.PlayButton.Size = new global::System.Drawing.Size(23, 22);
			this.PlayButton.Text = "Start";
			this.PlayButton.ToolTipText = "Start Slideshow";
			this.PlayButton.Click += new global::System.EventHandler(this.PlayButton_Click);
			this.saveFileDialog_0.Filter = "ToonTown Screenshots|*.jpg";
			this.timer_0.Interval = 5000;
			this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
			this.RendererControl.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.RendererControl.BackColor = global::System.Drawing.Color.Black;
			this.RendererControl.Location = new global::System.Drawing.Point(0, 25);
			this.RendererControl.Name = "RendererControl";
			this.RendererControl.Size = new global::System.Drawing.Size(567, 318);
			this.RendererControl.TabIndex = 0;
			this.RendererControl.ImageLoaded += new global::System.EventHandler(this.method_2);
			this.RendererControl.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.MyGalleryViewer_KeyDown);
			this.RendererControl.MouseDoubleClick += new global::System.Windows.Forms.MouseEventHandler(this.RendererControl_MouseDoubleClick);
			this.RendererControl.MouseEnter += new global::System.EventHandler(this.RendererControl_MouseEnter);
			this.RendererControl.MouseLeave += new global::System.EventHandler(this.RendererControl_MouseLeave);
			this.RendererControl.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.RendererControl_MouseMove);
			this.RendererControl.PreviewKeyDown += new global::System.Windows.Forms.PreviewKeyDownEventHandler(this.MyGalleryViewer_PreviewKeyDown);
			this.timer_1.Interval = 4000;
			this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.Black;
			base.ClientSize = new global::System.Drawing.Size(567, 343);
			base.Controls.Add(this.RendererControl);
			base.Controls.Add(this.ImageToolStrip);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Name = "MyGalleryViewer";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.Manual;
			base.Deactivate += new global::System.EventHandler(this.MyGalleryViewer_Deactivate);
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.MyGalleryViewer_HelpRequested);
			base.KeyDown += new global::System.Windows.Forms.KeyEventHandler(this.MyGalleryViewer_KeyDown);
			base.PreviewKeyDown += new global::System.Windows.Forms.PreviewKeyDownEventHandler(this.MyGalleryViewer_PreviewKeyDown);
			base.Resize += new global::System.EventHandler(this.MyGalleryViewer_Resize);
			this.ImageToolStrip.ResumeLayout(false);
			this.ImageToolStrip.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000928 RID: 2344
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000929 RID: 2345
		private global::ns22.ImageRenderer RendererControl;

		// Token: 0x0400092A RID: 2346
		private global::System.Windows.Forms.ToolStrip ImageToolStrip;

		// Token: 0x0400092B RID: 2347
		private global::System.Windows.Forms.ToolStripButton PreviousImageButton;

		// Token: 0x0400092C RID: 2348
		private global::System.Windows.Forms.ToolStripButton NextImageButton;

		// Token: 0x0400092D RID: 2349
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x0400092E RID: 2350
		private global::System.Windows.Forms.ToolStripButton CopyImageButton;

		// Token: 0x0400092F RID: 2351
		private global::System.Windows.Forms.ToolStripButton DeleteImageButton;

		// Token: 0x04000930 RID: 2352
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000931 RID: 2353
		private global::System.Windows.Forms.ToolTip toolTip_0;

		// Token: 0x04000932 RID: 2354
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog_0;

		// Token: 0x04000933 RID: 2355
		private global::System.Windows.Forms.ToolStripDropDownButton SizeModeDropDownMenu;

		// Token: 0x04000934 RID: 2356
		private global::System.Windows.Forms.ToolStripMenuItem StretchMenuItem;

		// Token: 0x04000935 RID: 2357
		private global::System.Windows.Forms.ToolStripMenuItem MaintainAspectRatioMenuItem;

		// Token: 0x04000936 RID: 2358
		private global::System.Windows.Forms.ToolStripMenuItem MaintainAspectRatioAndStretchMenuItem;

		// Token: 0x04000937 RID: 2359
		private global::System.Windows.Forms.ToolStripButton FullScreenButton;

		// Token: 0x04000938 RID: 2360
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x04000939 RID: 2361
		private global::System.Windows.Forms.ToolStripButton StopButton;

		// Token: 0x0400093A RID: 2362
		private global::System.Windows.Forms.ToolStripButton PlayButton;

		// Token: 0x0400093B RID: 2363
		private global::System.Windows.Forms.Timer timer_0;

		// Token: 0x0400093C RID: 2364
		private global::System.Windows.Forms.Timer timer_1;
	}
}
