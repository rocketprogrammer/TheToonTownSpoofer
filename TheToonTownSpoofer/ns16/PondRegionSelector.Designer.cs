namespace ns16
{
	// Token: 0x020003C4 RID: 964
	internal sealed partial class PondRegionSelector : global::System.Windows.Forms.Form
	{
		// Token: 0x06002527 RID: 9511 RVA: 0x000104E7 File Offset: 0x0000E6E7
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x0007F130 File Offset: 0x0007D330
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns16.PondRegionSelector));
			this.ExtraSmallSize = new global::System.Windows.Forms.RadioButton();
			this.BrushSizePanel = new global::System.Windows.Forms.Panel();
			this.ExtraExtraLargeSize = new global::System.Windows.Forms.RadioButton();
			this.ExtraLargeSize = new global::System.Windows.Forms.RadioButton();
			this.LargeSize = new global::System.Windows.Forms.RadioButton();
			this.MediumSize = new global::System.Windows.Forms.RadioButton();
			this.SmallSize = new global::System.Windows.Forms.RadioButton();
			this.ToolPanel = new global::System.Windows.Forms.Panel();
			this.EraserTool = new global::System.Windows.Forms.RadioButton();
			this.BrushTool = new global::System.Windows.Forms.RadioButton();
			this.NoTool = new global::System.Windows.Forms.RadioButton();
			this.AcceptBtn = new global::System.Windows.Forms.Button();
			this.CancelBtn = new global::System.Windows.Forms.Button();
			this.TitleText = new global::System.Windows.Forms.Label();
			this.HelpContent = new global::System.Windows.Forms.Label();
			this.ZoomPanel = new global::System.Windows.Forms.Panel();
			this.ZoomOut = new global::System.Windows.Forms.Button();
			this.ZoomIn = new global::System.Windows.Forms.Button();
			this.DrawingBoardRenderer = new global::ns15.DrawingBoardContainer();
			this.BrushSizePanel.SuspendLayout();
			this.ToolPanel.SuspendLayout();
			this.ZoomPanel.SuspendLayout();
			base.SuspendLayout();
			this.ExtraSmallSize.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.ExtraSmallSize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ExtraSmallSize.Image");
			this.ExtraSmallSize.Location = new global::System.Drawing.Point(2, 2);
			this.ExtraSmallSize.Name = "ExtraSmallSize";
			this.ExtraSmallSize.Size = new global::System.Drawing.Size(48, 48);
			this.ExtraSmallSize.TabIndex = 3;
			this.ExtraSmallSize.UseVisualStyleBackColor = true;
			this.ExtraSmallSize.CheckedChanged += new global::System.EventHandler(this.SmallSize_CheckedChanged);
			this.BrushSizePanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.BrushSizePanel.Controls.Add(this.ExtraExtraLargeSize);
			this.BrushSizePanel.Controls.Add(this.ExtraLargeSize);
			this.BrushSizePanel.Controls.Add(this.LargeSize);
			this.BrushSizePanel.Controls.Add(this.MediumSize);
			this.BrushSizePanel.Controls.Add(this.SmallSize);
			this.BrushSizePanel.Controls.Add(this.ExtraSmallSize);
			this.BrushSizePanel.Location = new global::System.Drawing.Point(675, 36);
			this.BrushSizePanel.Name = "BrushSizePanel";
			this.BrushSizePanel.Size = new global::System.Drawing.Size(52, 322);
			this.BrushSizePanel.TabIndex = 4;
			this.ExtraExtraLargeSize.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.ExtraExtraLargeSize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ExtraExtraLargeSize.Image");
			this.ExtraExtraLargeSize.Location = new global::System.Drawing.Point(2, 272);
			this.ExtraExtraLargeSize.Name = "ExtraExtraLargeSize";
			this.ExtraExtraLargeSize.Size = new global::System.Drawing.Size(48, 48);
			this.ExtraExtraLargeSize.TabIndex = 3;
			this.ExtraExtraLargeSize.UseVisualStyleBackColor = true;
			this.ExtraExtraLargeSize.CheckedChanged += new global::System.EventHandler(this.SmallSize_CheckedChanged);
			this.ExtraLargeSize.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.ExtraLargeSize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ExtraLargeSize.Image");
			this.ExtraLargeSize.Location = new global::System.Drawing.Point(2, 218);
			this.ExtraLargeSize.Name = "ExtraLargeSize";
			this.ExtraLargeSize.Size = new global::System.Drawing.Size(48, 48);
			this.ExtraLargeSize.TabIndex = 3;
			this.ExtraLargeSize.UseVisualStyleBackColor = true;
			this.ExtraLargeSize.CheckedChanged += new global::System.EventHandler(this.SmallSize_CheckedChanged);
			this.LargeSize.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.LargeSize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("LargeSize.Image");
			this.LargeSize.Location = new global::System.Drawing.Point(2, 164);
			this.LargeSize.Name = "LargeSize";
			this.LargeSize.Size = new global::System.Drawing.Size(48, 48);
			this.LargeSize.TabIndex = 3;
			this.LargeSize.UseVisualStyleBackColor = true;
			this.LargeSize.CheckedChanged += new global::System.EventHandler(this.SmallSize_CheckedChanged);
			this.MediumSize.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.MediumSize.Checked = true;
			this.MediumSize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("MediumSize.Image");
			this.MediumSize.Location = new global::System.Drawing.Point(2, 110);
			this.MediumSize.Name = "MediumSize";
			this.MediumSize.Size = new global::System.Drawing.Size(48, 48);
			this.MediumSize.TabIndex = 3;
			this.MediumSize.TabStop = true;
			this.MediumSize.UseVisualStyleBackColor = true;
			this.MediumSize.CheckedChanged += new global::System.EventHandler(this.SmallSize_CheckedChanged);
			this.SmallSize.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.SmallSize.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("SmallSize.Image");
			this.SmallSize.Location = new global::System.Drawing.Point(2, 56);
			this.SmallSize.Name = "SmallSize";
			this.SmallSize.Size = new global::System.Drawing.Size(48, 48);
			this.SmallSize.TabIndex = 3;
			this.SmallSize.UseVisualStyleBackColor = true;
			this.SmallSize.CheckedChanged += new global::System.EventHandler(this.SmallSize_CheckedChanged);
			this.ToolPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.ToolPanel.Controls.Add(this.EraserTool);
			this.ToolPanel.Controls.Add(this.BrushTool);
			this.ToolPanel.Controls.Add(this.NoTool);
			this.ToolPanel.Location = new global::System.Drawing.Point(617, 36);
			this.ToolPanel.Name = "ToolPanel";
			this.ToolPanel.Size = new global::System.Drawing.Size(52, 160);
			this.ToolPanel.TabIndex = 4;
			this.EraserTool.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.EraserTool.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("EraserTool.Image");
			this.EraserTool.Location = new global::System.Drawing.Point(2, 110);
			this.EraserTool.Name = "EraserTool";
			this.EraserTool.Size = new global::System.Drawing.Size(48, 48);
			this.EraserTool.TabIndex = 3;
			this.EraserTool.UseVisualStyleBackColor = true;
			this.EraserTool.CheckedChanged += new global::System.EventHandler(this.NoTool_CheckedChanged);
			this.BrushTool.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.BrushTool.Checked = true;
			this.BrushTool.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("BrushTool.Image");
			this.BrushTool.Location = new global::System.Drawing.Point(2, 56);
			this.BrushTool.Name = "BrushTool";
			this.BrushTool.Size = new global::System.Drawing.Size(48, 48);
			this.BrushTool.TabIndex = 3;
			this.BrushTool.TabStop = true;
			this.BrushTool.UseVisualStyleBackColor = true;
			this.BrushTool.CheckedChanged += new global::System.EventHandler(this.NoTool_CheckedChanged);
			this.NoTool.Appearance = global::System.Windows.Forms.Appearance.Button;
			this.NoTool.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("NoTool.Image");
			this.NoTool.Location = new global::System.Drawing.Point(2, 2);
			this.NoTool.Name = "NoTool";
			this.NoTool.Size = new global::System.Drawing.Size(48, 48);
			this.NoTool.TabIndex = 3;
			this.NoTool.UseVisualStyleBackColor = true;
			this.NoTool.CheckedChanged += new global::System.EventHandler(this.NoTool_CheckedChanged);
			this.AcceptBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.AcceptBtn.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.AcceptBtn.Location = new global::System.Drawing.Point(621, 382);
			this.AcceptBtn.Name = "AcceptBtn";
			this.AcceptBtn.Size = new global::System.Drawing.Size(106, 40);
			this.AcceptBtn.TabIndex = 5;
			this.AcceptBtn.Text = "Accept";
			this.AcceptBtn.UseVisualStyleBackColor = true;
			this.AcceptBtn.Click += new global::System.EventHandler(this.AcceptBtn_Click);
			this.CancelBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.CancelBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new global::System.Drawing.Point(621, 428);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new global::System.Drawing.Size(106, 23);
			this.CancelBtn.TabIndex = 6;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new global::System.EventHandler(this.CancelBtn_Click);
			this.TitleText.AutoSize = true;
			this.TitleText.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.TitleText.Location = new global::System.Drawing.Point(12, 9);
			this.TitleText.Name = "TitleText";
			this.TitleText.Size = new global::System.Drawing.Size(205, 26);
			this.TitleText.TabIndex = 10;
			this.TitleText.Text = "Joe Fish : Pond Painter";
			this.HelpContent.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.HelpContent.Location = new global::System.Drawing.Point(14, 384);
			this.HelpContent.Name = "HelpContent";
			this.HelpContent.Size = new global::System.Drawing.Size(597, 69);
			this.HelpContent.TabIndex = 11;
			this.HelpContent.Text = componentResourceManager.GetString("HelpContent.Text");
			this.ZoomPanel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.ZoomPanel.Controls.Add(this.ZoomOut);
			this.ZoomPanel.Controls.Add(this.ZoomIn);
			this.ZoomPanel.Location = new global::System.Drawing.Point(617, 252);
			this.ZoomPanel.Name = "ZoomPanel";
			this.ZoomPanel.Size = new global::System.Drawing.Size(52, 106);
			this.ZoomPanel.TabIndex = 12;
			this.ZoomOut.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ZoomOut.Image");
			this.ZoomOut.Location = new global::System.Drawing.Point(2, 56);
			this.ZoomOut.Name = "ZoomOut";
			this.ZoomOut.Size = new global::System.Drawing.Size(48, 48);
			this.ZoomOut.TabIndex = 0;
			this.ZoomOut.UseVisualStyleBackColor = true;
			this.ZoomOut.Click += new global::System.EventHandler(this.ZoomOut_Click);
			this.ZoomIn.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ZoomIn.Image");
			this.ZoomIn.Location = new global::System.Drawing.Point(2, 2);
			this.ZoomIn.Name = "ZoomIn";
			this.ZoomIn.Size = new global::System.Drawing.Size(48, 48);
			this.ZoomIn.TabIndex = 0;
			this.ZoomIn.UseVisualStyleBackColor = true;
			this.ZoomIn.Click += new global::System.EventHandler(this.ZoomIn_Click);
			this.DrawingBoardRenderer.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.DrawingBoardRenderer.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.DrawingBoardRenderer.DrawingTool = global::ns28.Enum125.const_1;
			this.DrawingBoardRenderer.DrawingToolSize = global::ns24.Enum61.const_2;
			this.DrawingBoardRenderer.Location = new global::System.Drawing.Point(8, 38);
			this.DrawingBoardRenderer.Name = "DrawingBoardRenderer";
			this.DrawingBoardRenderer.Size = new global::System.Drawing.Size(603, 341);
			this.DrawingBoardRenderer.TabIndex = 0;
			base.AcceptButton = this.AcceptBtn;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.CancelBtn;
			base.ClientSize = new global::System.Drawing.Size(734, 462);
			base.Controls.Add(this.ZoomPanel);
			base.Controls.Add(this.HelpContent);
			base.Controls.Add(this.TitleText);
			base.Controls.Add(this.CancelBtn);
			base.Controls.Add(this.AcceptBtn);
			base.Controls.Add(this.ToolPanel);
			base.Controls.Add(this.BrushSizePanel);
			base.Controls.Add(this.DrawingBoardRenderer);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			this.MinimumSize = new global::System.Drawing.Size(750, 500);
			base.Name = "PondRegionSelector";
			this.Text = "Joe Fish : Pond Painter";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.PondRegionSelector_FormClosing);
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.PondRegionSelector_HelpRequested);
			this.BrushSizePanel.ResumeLayout(false);
			this.ToolPanel.ResumeLayout(false);
			this.ZoomPanel.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001166 RID: 4454
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04001167 RID: 4455
		private global::ns15.DrawingBoardContainer DrawingBoardRenderer;

		// Token: 0x04001168 RID: 4456
		private global::System.Windows.Forms.RadioButton ExtraSmallSize;

		// Token: 0x04001169 RID: 4457
		private global::System.Windows.Forms.Panel BrushSizePanel;

		// Token: 0x0400116A RID: 4458
		private global::System.Windows.Forms.RadioButton ExtraExtraLargeSize;

		// Token: 0x0400116B RID: 4459
		private global::System.Windows.Forms.RadioButton ExtraLargeSize;

		// Token: 0x0400116C RID: 4460
		private global::System.Windows.Forms.RadioButton LargeSize;

		// Token: 0x0400116D RID: 4461
		private global::System.Windows.Forms.RadioButton MediumSize;

		// Token: 0x0400116E RID: 4462
		private global::System.Windows.Forms.RadioButton SmallSize;

		// Token: 0x0400116F RID: 4463
		private global::System.Windows.Forms.Panel ToolPanel;

		// Token: 0x04001170 RID: 4464
		private global::System.Windows.Forms.RadioButton EraserTool;

		// Token: 0x04001171 RID: 4465
		private global::System.Windows.Forms.RadioButton BrushTool;

		// Token: 0x04001172 RID: 4466
		private global::System.Windows.Forms.RadioButton NoTool;

		// Token: 0x04001173 RID: 4467
		private global::System.Windows.Forms.Button AcceptBtn;

		// Token: 0x04001174 RID: 4468
		private global::System.Windows.Forms.Button CancelBtn;

		// Token: 0x04001175 RID: 4469
		private global::System.Windows.Forms.Label TitleText;

		// Token: 0x04001176 RID: 4470
		private global::System.Windows.Forms.Label HelpContent;

		// Token: 0x04001177 RID: 4471
		private global::System.Windows.Forms.Panel ZoomPanel;

		// Token: 0x04001178 RID: 4472
		private global::System.Windows.Forms.Button ZoomOut;

		// Token: 0x04001179 RID: 4473
		private global::System.Windows.Forms.Button ZoomIn;
	}
}
