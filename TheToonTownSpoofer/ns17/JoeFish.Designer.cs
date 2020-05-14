namespace ns17
{
	// Token: 0x0200028F RID: 655
	internal sealed partial class JoeFish : global::System.Windows.Forms.Form
	{
		// Token: 0x06001B21 RID: 6945 RVA: 0x000523E0 File Offset: 0x000505E0
		protected override void Dispose(bool disposing)
		{
			if (this.class141_0 != null)
			{
				this.class141_0.Dispose();
			}
			if (this.class98_0 != null)
			{
				this.class98_0.Dispose();
			}
			if (this.class103_0 != null)
			{
				this.class103_0.Dispose();
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B22 RID: 6946 RVA: 0x00052444 File Offset: 0x00050644
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns17.JoeFish));
			this.BeginFishing = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.JoeFishTitle = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.CloseButton = new global::System.Windows.Forms.Button();
			this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			this.JoeFishMenu = new global::System.Windows.Forms.MenuStrip();
			this.FileMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CloseMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CustomizeMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CapturesMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DefaultCapturesMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CustomCapturesMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.CreateCapturesMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.WayPointsMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.DefaultWayPointsMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.CustomWayPointsMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.CreateWayPointsMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.StopWhenNewSpeciesAreDetectedMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.UpdatePondCaptureMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.UpdatePondRegionMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.CustomizeSettings = new global::System.Windows.Forms.ToolStripMenuItem();
			this.StatisticsMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ShowStatisticsWhenCompletedMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.ViewStatisticsMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.WindowMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.SelectToonTownWindowMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.HelpMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.GuideMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.JoeFishMenu.SuspendLayout();
			base.SuspendLayout();
			this.BeginFishing.Location = new global::System.Drawing.Point(18, 119);
			this.BeginFishing.Name = "BeginFishing";
			this.BeginFishing.Size = new global::System.Drawing.Size(252, 33);
			this.BeginFishing.TabIndex = 0;
			this.BeginFishing.Text = "Begin Fishing";
			this.BeginFishing.UseVisualStyleBackColor = true;
			this.BeginFishing.Click += new global::System.EventHandler(this.BeginFishing_Click);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(275, 31);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(128, 128);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			this.JoeFishTitle.AutoSize = true;
			this.JoeFishTitle.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.JoeFishTitle.Location = new global::System.Drawing.Point(43, 40);
			this.JoeFishTitle.Name = "JoeFishTitle";
			this.JoeFishTitle.Size = new global::System.Drawing.Size(79, 26);
			this.JoeFishTitle.TabIndex = 10;
			this.JoeFishTitle.Text = "Joe Fish";
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.label1.Location = new global::System.Drawing.Point(121, 48);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(121, 15);
			this.label1.TabIndex = 10;
			this.label1.Text = "Automatic Fisherman";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.label2.Location = new global::System.Drawing.Point(17, 100);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(252, 15);
			this.label2.TabIndex = 10;
			this.label2.Text = "Please stand on a dock and click begin fishing.";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.label3.Location = new global::System.Drawing.Point(78, 66);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(122, 15);
			this.label3.TabIndex = 10;
			this.label3.Text = "Ready to fish for you. ";
			this.CloseButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Location = new global::System.Drawing.Point(439, 113);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new global::System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 11;
			this.CloseButton.TabStop = false;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new global::System.EventHandler(this.CloseButton_Click);
			this.openFileDialog_0.Filter = "Way Point Settings|*.wps";
			this.JoeFishMenu.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.FileMenuItem,
				this.CustomizeMenuItem,
				this.StatisticsMenuItem,
				this.WindowMenuItem,
				this.HelpMenuItem
			});
			this.JoeFishMenu.Location = new global::System.Drawing.Point(0, 0);
			this.JoeFishMenu.Name = "JoeFishMenu";
			this.JoeFishMenu.Size = new global::System.Drawing.Size(420, 24);
			this.JoeFishMenu.TabIndex = 12;
			this.JoeFishMenu.Text = "menuStrip1";
			this.FileMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CloseMenuItem
			});
			this.FileMenuItem.Name = "FileMenuItem";
			this.FileMenuItem.Size = new global::System.Drawing.Size(37, 20);
			this.FileMenuItem.Text = "&File";
			this.CloseMenuItem.Name = "CloseMenuItem";
			this.CloseMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131159;
			this.CloseMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.CloseMenuItem.Text = "&Close";
			this.CloseMenuItem.Click += new global::System.EventHandler(this.CloseMenuItem_Click);
			this.CustomizeMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.CapturesMenuItem,
				this.WayPointsMenuItem,
				this.toolStripSeparator1,
				this.StopWhenNewSpeciesAreDetectedMenuItem,
				this.toolStripSeparator2,
				this.UpdatePondCaptureMenuItem,
				this.UpdatePondRegionMenuItem,
				this.toolStripSeparator3,
				this.CustomizeSettings
			});
			this.CustomizeMenuItem.Name = "CustomizeMenuItem";
			this.CustomizeMenuItem.Size = new global::System.Drawing.Size(75, 20);
			this.CustomizeMenuItem.Text = "&Customize";
			this.CapturesMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.DefaultCapturesMenuItem,
				this.CustomCapturesMenuItem,
				this.toolStripSeparator4,
				this.CreateCapturesMenuItem
			});
			this.CapturesMenuItem.Name = "CapturesMenuItem";
			this.CapturesMenuItem.Size = new global::System.Drawing.Size(270, 22);
			this.CapturesMenuItem.Text = "&Captures";
			this.DefaultCapturesMenuItem.Checked = true;
			this.DefaultCapturesMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.DefaultCapturesMenuItem.Name = "DefaultCapturesMenuItem";
			this.DefaultCapturesMenuItem.Size = new global::System.Drawing.Size(116, 22);
			this.DefaultCapturesMenuItem.Text = "&Default";
			this.DefaultCapturesMenuItem.Click += new global::System.EventHandler(this.DefaultCapturesMenuItem_Click);
			this.CustomCapturesMenuItem.Name = "CustomCapturesMenuItem";
			this.CustomCapturesMenuItem.Size = new global::System.Drawing.Size(116, 22);
			this.CustomCapturesMenuItem.Text = "&Custom";
			this.CustomCapturesMenuItem.Click += new global::System.EventHandler(this.CustomCapturesMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(113, 6);
			this.CreateCapturesMenuItem.Name = "CreateCapturesMenuItem";
			this.CreateCapturesMenuItem.Size = new global::System.Drawing.Size(116, 22);
			this.CreateCapturesMenuItem.Text = "C&reate";
			this.CreateCapturesMenuItem.Click += new global::System.EventHandler(this.CreateCapturesMenuItem_Click);
			this.WayPointsMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.DefaultWayPointsMenuItem,
				this.CustomWayPointsMenuItem,
				this.toolStripSeparator5,
				this.CreateWayPointsMenuItem
			});
			this.WayPointsMenuItem.Name = "WayPointsMenuItem";
			this.WayPointsMenuItem.Size = new global::System.Drawing.Size(270, 22);
			this.WayPointsMenuItem.Text = "&Way Points";
			this.DefaultWayPointsMenuItem.Checked = true;
			this.DefaultWayPointsMenuItem.CheckState = global::System.Windows.Forms.CheckState.Checked;
			this.DefaultWayPointsMenuItem.Name = "DefaultWayPointsMenuItem";
			this.DefaultWayPointsMenuItem.Size = new global::System.Drawing.Size(116, 22);
			this.DefaultWayPointsMenuItem.Text = "&Default";
			this.DefaultWayPointsMenuItem.Click += new global::System.EventHandler(this.DefaultWayPointsMenuItem_Click);
			this.CustomWayPointsMenuItem.Name = "CustomWayPointsMenuItem";
			this.CustomWayPointsMenuItem.Size = new global::System.Drawing.Size(116, 22);
			this.CustomWayPointsMenuItem.Text = "&Custom";
			this.CustomWayPointsMenuItem.Click += new global::System.EventHandler(this.CustomWayPointsMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(113, 6);
			this.CreateWayPointsMenuItem.Name = "CreateWayPointsMenuItem";
			this.CreateWayPointsMenuItem.Size = new global::System.Drawing.Size(116, 22);
			this.CreateWayPointsMenuItem.Text = "C&reate";
			this.CreateWayPointsMenuItem.Click += new global::System.EventHandler(this.CreateWayPointsMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(267, 6);
			this.StopWhenNewSpeciesAreDetectedMenuItem.Name = "StopWhenNewSpeciesAreDetectedMenuItem";
			this.StopWhenNewSpeciesAreDetectedMenuItem.Size = new global::System.Drawing.Size(270, 22);
			this.StopWhenNewSpeciesAreDetectedMenuItem.Text = "Stop When &New Species are Detected";
			this.StopWhenNewSpeciesAreDetectedMenuItem.Click += new global::System.EventHandler(this.StopWhenNewSpeciesAreDetectedMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(267, 6);
			this.UpdatePondCaptureMenuItem.Name = "UpdatePondCaptureMenuItem";
			this.UpdatePondCaptureMenuItem.Size = new global::System.Drawing.Size(270, 22);
			this.UpdatePondCaptureMenuItem.Text = "Update Pond Capture";
			this.UpdatePondCaptureMenuItem.Click += new global::System.EventHandler(this.UpdatePondCaptureMenuItem_Click);
			this.UpdatePondRegionMenuItem.Name = "UpdatePondRegionMenuItem";
			this.UpdatePondRegionMenuItem.Size = new global::System.Drawing.Size(270, 22);
			this.UpdatePondRegionMenuItem.Text = "Update Pond Region";
			this.UpdatePondRegionMenuItem.Visible = false;
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(267, 6);
			this.CustomizeSettings.Name = "CustomizeSettings";
			this.CustomizeSettings.Size = new global::System.Drawing.Size(270, 22);
			this.CustomizeSettings.Text = "&Settings";
			this.CustomizeSettings.Click += new global::System.EventHandler(this.CustomizeSettings_Click);
			this.StatisticsMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.ShowStatisticsWhenCompletedMenuItem,
				this.ViewStatisticsMenuItem
			});
			this.StatisticsMenuItem.Name = "StatisticsMenuItem";
			this.StatisticsMenuItem.Size = new global::System.Drawing.Size(65, 20);
			this.StatisticsMenuItem.Text = "&Statistics";
			this.ShowStatisticsWhenCompletedMenuItem.Name = "ShowStatisticsWhenCompletedMenuItem";
			this.ShowStatisticsWhenCompletedMenuItem.Size = new global::System.Drawing.Size(248, 22);
			this.ShowStatisticsWhenCompletedMenuItem.Text = "&Show Statistics When Completed";
			this.ShowStatisticsWhenCompletedMenuItem.Click += new global::System.EventHandler(this.ShowStatisticsWhenCompletedMenuItem_Click);
			this.ViewStatisticsMenuItem.Name = "ViewStatisticsMenuItem";
			this.ViewStatisticsMenuItem.Size = new global::System.Drawing.Size(248, 22);
			this.ViewStatisticsMenuItem.Text = "&View";
			this.ViewStatisticsMenuItem.Click += new global::System.EventHandler(this.ViewStatisticsMenuItem_Click);
			this.WindowMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.SelectToonTownWindowMenuItem
			});
			this.WindowMenuItem.Name = "WindowMenuItem";
			this.WindowMenuItem.Size = new global::System.Drawing.Size(63, 20);
			this.WindowMenuItem.Text = "&Window";
			this.SelectToonTownWindowMenuItem.Name = "SelectToonTownWindowMenuItem";
			this.SelectToonTownWindowMenuItem.Size = new global::System.Drawing.Size(213, 22);
			this.SelectToonTownWindowMenuItem.Text = "&Select ToonTown Window";
			this.SelectToonTownWindowMenuItem.Click += new global::System.EventHandler(this.SelectToonTownWindowMenuItem_Click);
			this.HelpMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.GuideMenuItem
			});
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.Size = new global::System.Drawing.Size(44, 20);
			this.HelpMenuItem.Text = "&Help";
			this.GuideMenuItem.Name = "GuideMenuItem";
			this.GuideMenuItem.ShortcutKeys = global::System.Windows.Forms.Keys.F1;
			this.GuideMenuItem.Size = new global::System.Drawing.Size(124, 22);
			this.GuideMenuItem.Text = "&Guide";
			this.GuideMenuItem.Click += new global::System.EventHandler(this.GuideMenuItem_Click);
			base.AcceptButton = this.BeginFishing;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.CloseButton;
			base.ClientSize = new global::System.Drawing.Size(420, 165);
			base.Controls.Add(this.CloseButton);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.JoeFishTitle);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.BeginFishing);
			base.Controls.Add(this.JoeFishMenu);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.JoeFishMenu;
			base.MaximizeBox = false;
			base.Name = "JoeFish";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer Presents : Joe Fish";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.JoeFishMenu.ResumeLayout(false);
			this.JoeFishMenu.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040008A1 RID: 2209
		private global::ns25.Class98 class98_0;

		// Token: 0x040008A2 RID: 2210
		private global::ns16.Class141 class141_0;

		// Token: 0x040008A3 RID: 2211
		private global::ns19.Class103 class103_0;

		// Token: 0x040008A6 RID: 2214
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040008A7 RID: 2215
		private global::System.Windows.Forms.Button BeginFishing;

		// Token: 0x040008A8 RID: 2216
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040008A9 RID: 2217
		private global::System.Windows.Forms.Label JoeFishTitle;

		// Token: 0x040008AA RID: 2218
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040008AB RID: 2219
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040008AC RID: 2220
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040008AD RID: 2221
		private global::System.Windows.Forms.Button CloseButton;

		// Token: 0x040008AE RID: 2222
		private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

		// Token: 0x040008AF RID: 2223
		private global::System.Windows.Forms.MenuStrip JoeFishMenu;

		// Token: 0x040008B0 RID: 2224
		private global::System.Windows.Forms.ToolStripMenuItem FileMenuItem;

		// Token: 0x040008B1 RID: 2225
		private global::System.Windows.Forms.ToolStripMenuItem CloseMenuItem;

		// Token: 0x040008B2 RID: 2226
		private global::System.Windows.Forms.ToolStripMenuItem CustomizeMenuItem;

		// Token: 0x040008B3 RID: 2227
		private global::System.Windows.Forms.ToolStripMenuItem CapturesMenuItem;

		// Token: 0x040008B4 RID: 2228
		private global::System.Windows.Forms.ToolStripMenuItem DefaultCapturesMenuItem;

		// Token: 0x040008B5 RID: 2229
		private global::System.Windows.Forms.ToolStripMenuItem CustomCapturesMenuItem;

		// Token: 0x040008B6 RID: 2230
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x040008B7 RID: 2231
		private global::System.Windows.Forms.ToolStripMenuItem CreateCapturesMenuItem;

		// Token: 0x040008B8 RID: 2232
		private global::System.Windows.Forms.ToolStripMenuItem WayPointsMenuItem;

		// Token: 0x040008B9 RID: 2233
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040008BA RID: 2234
		private global::System.Windows.Forms.ToolStripMenuItem StopWhenNewSpeciesAreDetectedMenuItem;

		// Token: 0x040008BB RID: 2235
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x040008BC RID: 2236
		private global::System.Windows.Forms.ToolStripMenuItem UpdatePondCaptureMenuItem;

		// Token: 0x040008BD RID: 2237
		private global::System.Windows.Forms.ToolStripMenuItem UpdatePondRegionMenuItem;

		// Token: 0x040008BE RID: 2238
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x040008BF RID: 2239
		private global::System.Windows.Forms.ToolStripMenuItem CustomizeSettings;

		// Token: 0x040008C0 RID: 2240
		private global::System.Windows.Forms.ToolStripMenuItem DefaultWayPointsMenuItem;

		// Token: 0x040008C1 RID: 2241
		private global::System.Windows.Forms.ToolStripMenuItem CustomWayPointsMenuItem;

		// Token: 0x040008C2 RID: 2242
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x040008C3 RID: 2243
		private global::System.Windows.Forms.ToolStripMenuItem CreateWayPointsMenuItem;

		// Token: 0x040008C4 RID: 2244
		private global::System.Windows.Forms.ToolStripMenuItem StatisticsMenuItem;

		// Token: 0x040008C5 RID: 2245
		private global::System.Windows.Forms.ToolStripMenuItem ShowStatisticsWhenCompletedMenuItem;

		// Token: 0x040008C6 RID: 2246
		private global::System.Windows.Forms.ToolStripMenuItem ViewStatisticsMenuItem;

		// Token: 0x040008C7 RID: 2247
		private global::System.Windows.Forms.ToolStripMenuItem WindowMenuItem;

		// Token: 0x040008C8 RID: 2248
		private global::System.Windows.Forms.ToolStripMenuItem SelectToonTownWindowMenuItem;

		// Token: 0x040008C9 RID: 2249
		private global::System.Windows.Forms.ToolStripMenuItem HelpMenuItem;

		// Token: 0x040008CA RID: 2250
		private global::System.Windows.Forms.ToolStripMenuItem GuideMenuItem;
	}
}
