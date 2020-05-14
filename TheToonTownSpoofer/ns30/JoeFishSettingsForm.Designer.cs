namespace ns30
{
	// Token: 0x020001DF RID: 479
	internal sealed partial class JoeFishSettingsForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060015F0 RID: 5616 RVA: 0x00006204 File Offset: 0x00004404
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060015F1 RID: 5617 RVA: 0x000330C8 File Offset: 0x000312C8
		private void InitializeComponent()
		{
			this.CancelBtn = new global::System.Windows.Forms.Button();
			this.SaveBtn = new global::System.Windows.Forms.Button();
			this.ResetBtn = new global::System.Windows.Forms.Button();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.SettingsGroup = new global::ns24.Class310();
			this.AdvancedSettingsTitleLabe = new global::System.Windows.Forms.Label();
			this.SettingsLabel = new global::System.Windows.Forms.Label();
			this.MaxColorRangeTextBox = new global::ns21.Class181();
			this.ButtonClickDelayTextBox = new global::ns21.Class181();
			this.TargetRangeTextBox = new global::ns23.Class182();
			this.CastDragDelayTextBox = new global::ns21.Class181();
			this.label5 = new global::System.Windows.Forms.Label();
			this.AfterCastDelayTextBox = new global::ns21.Class181();
			this.label8 = new global::System.Windows.Forms.Label();
			this.AfterMoveBeforeClickDelayTextBox = new global::ns21.Class181();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			this.ControlPanel = new global::System.Windows.Forms.Panel();
			this.SettingsPanel = new global::System.Windows.Forms.Panel();
			this.RequireStableFishTargetCheckBox = new global::System.Windows.Forms.CheckBox();
			this.RequireStableFishTargetLabel = new global::System.Windows.Forms.Label();
			this.SettingsGroup.SuspendLayout();
			this.ControlPanel.SuspendLayout();
			this.SettingsPanel.SuspendLayout();
			base.SuspendLayout();
			this.CancelBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.CancelBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new global::System.Drawing.Point(349, 4);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new global::System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new global::System.EventHandler(this.CancelBtn_Click);
			this.SaveBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.SaveBtn.Location = new global::System.Drawing.Point(268, 4);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new global::System.Drawing.Size(75, 23);
			this.SaveBtn.TabIndex = 0;
			this.SaveBtn.Text = "Save";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new global::System.EventHandler(this.SaveBtn_Click);
			this.ResetBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.ResetBtn.Location = new global::System.Drawing.Point(187, 4);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.Size = new global::System.Drawing.Size(75, 23);
			this.ResetBtn.TabIndex = 2;
			this.ResetBtn.Text = "Reset";
			this.ResetBtn.UseVisualStyleBackColor = true;
			this.ResetBtn.Click += new global::System.EventHandler(this.ResetBtn_Click);
			this.HowToOpenHelpLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(2, 16);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 37;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			this.SettingsGroup.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.SettingsGroup.Controls.Add(this.RequireStableFishTargetCheckBox);
			this.SettingsGroup.Controls.Add(this.AdvancedSettingsTitleLabe);
			this.SettingsGroup.Controls.Add(this.SettingsLabel);
			this.SettingsGroup.Controls.Add(this.MaxColorRangeTextBox);
			this.SettingsGroup.Controls.Add(this.ButtonClickDelayTextBox);
			this.SettingsGroup.Controls.Add(this.TargetRangeTextBox);
			this.SettingsGroup.Controls.Add(this.CastDragDelayTextBox);
			this.SettingsGroup.Controls.Add(this.label5);
			this.SettingsGroup.Controls.Add(this.AfterCastDelayTextBox);
			this.SettingsGroup.Controls.Add(this.label8);
			this.SettingsGroup.Controls.Add(this.AfterMoveBeforeClickDelayTextBox);
			this.SettingsGroup.Controls.Add(this.label6);
			this.SettingsGroup.Controls.Add(this.label1);
			this.SettingsGroup.Controls.Add(this.RequireStableFishTargetLabel);
			this.SettingsGroup.Controls.Add(this.label7);
			this.SettingsGroup.Controls.Add(this.label2);
			this.SettingsGroup.Controls.Add(this.label4);
			this.SettingsGroup.Controls.Add(this.label3);
			this.SettingsGroup.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.SettingsGroup.HeaderHeight = 30;
			this.SettingsGroup.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.SettingsGroup.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.SettingsGroup.Location = new global::System.Drawing.Point(4, 4);
			this.SettingsGroup.Name = "SettingsGroup";
			this.SettingsGroup.Size = new global::System.Drawing.Size(426, 274);
			this.SettingsGroup.TabIndex = 15;
			this.AdvancedSettingsTitleLabe.AutoSize = true;
			this.AdvancedSettingsTitleLabe.BackColor = global::System.Drawing.Color.Transparent;
			this.AdvancedSettingsTitleLabe.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.AdvancedSettingsTitleLabe.ForeColor = global::System.Drawing.Color.DarkGray;
			this.AdvancedSettingsTitleLabe.Location = new global::System.Drawing.Point(75, 9);
			this.AdvancedSettingsTitleLabe.Name = "AdvancedSettingsTitleLabe";
			this.AdvancedSettingsTitleLabe.Size = new global::System.Drawing.Size(226, 19);
			this.AdvancedSettingsTitleLabe.TabIndex = 15;
			this.AdvancedSettingsTitleLabe.Text = "Set up advanced Joe Fish settings";
			this.SettingsLabel.AutoSize = true;
			this.SettingsLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.SettingsLabel.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
			this.SettingsLabel.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 95);
			this.SettingsLabel.Location = new global::System.Drawing.Point(7, 9);
			this.SettingsLabel.Name = "SettingsLabel";
			this.SettingsLabel.Size = new global::System.Drawing.Size(66, 19);
			this.SettingsLabel.TabIndex = 4;
			this.SettingsLabel.Text = "Settings:";
			this.MaxColorRangeTextBox.IfZeroDisplayEmpty = false;
			this.MaxColorRangeTextBox.Location = new global::System.Drawing.Point(340, 144);
			this.MaxColorRangeTextBox.MaximumValue = 255;
			this.MaxColorRangeTextBox.MaxLength = 3;
			this.MaxColorRangeTextBox.MinimumValue = 0;
			this.MaxColorRangeTextBox.Name = "MaxColorRangeTextBox";
			this.MaxColorRangeTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.MaxColorRangeTextBox.TabIndex = 4;
			this.MaxColorRangeTextBox.Value = 0;
			this.ButtonClickDelayTextBox.IfZeroDisplayEmpty = false;
			this.ButtonClickDelayTextBox.Location = new global::System.Drawing.Point(340, 92);
			this.ButtonClickDelayTextBox.MaximumValue = 1000;
			this.ButtonClickDelayTextBox.MaxLength = 4;
			this.ButtonClickDelayTextBox.MinimumValue = 0;
			this.ButtonClickDelayTextBox.Name = "ButtonClickDelayTextBox";
			this.ButtonClickDelayTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.ButtonClickDelayTextBox.TabIndex = 2;
			this.ButtonClickDelayTextBox.Value = 0;
			this.TargetRangeTextBox.Location = new global::System.Drawing.Point(340, 170);
			this.TargetRangeTextBox.MaximumValue = 1.5f;
			this.TargetRangeTextBox.MaxLength = 10;
			this.TargetRangeTextBox.MinimumValue = 0.01f;
			this.TargetRangeTextBox.Name = "TargetRangeTextBox";
			this.TargetRangeTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.TargetRangeTextBox.TabIndex = 5;
			this.TargetRangeTextBox.Text = "0.01";
			this.TargetRangeTextBox.Value = 0.01f;
			this.CastDragDelayTextBox.IfZeroDisplayEmpty = false;
			this.CastDragDelayTextBox.Location = new global::System.Drawing.Point(340, 40);
			this.CastDragDelayTextBox.MaximumValue = 1000;
			this.CastDragDelayTextBox.MaxLength = 4;
			this.CastDragDelayTextBox.MinimumValue = 0;
			this.CastDragDelayTextBox.Name = "CastDragDelayTextBox";
			this.CastDragDelayTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.CastDragDelayTextBox.TabIndex = 0;
			this.CastDragDelayTextBox.Value = 0;
			this.label5.AutoSize = true;
			this.label5.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label5.ForeColor = global::System.Drawing.Color.DimGray;
			this.label5.Location = new global::System.Drawing.Point(17, 69);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(220, 13);
			this.label5.TabIndex = 14;
			this.label5.Text = "Duration to delay after casting: (1000-20000¹)";
			this.AfterCastDelayTextBox.IfZeroDisplayEmpty = false;
			this.AfterCastDelayTextBox.Location = new global::System.Drawing.Point(340, 66);
			this.AfterCastDelayTextBox.MaximumValue = 20000;
			this.AfterCastDelayTextBox.MaxLength = 5;
			this.AfterCastDelayTextBox.MinimumValue = 1000;
			this.AfterCastDelayTextBox.Name = "AfterCastDelayTextBox";
			this.AfterCastDelayTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.AfterCastDelayTextBox.TabIndex = 1;
			this.AfterCastDelayTextBox.Text = "1000";
			this.AfterCastDelayTextBox.Value = 1000;
			this.label8.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label8.ForeColor = global::System.Drawing.Color.DimGray;
			this.label8.Location = new global::System.Drawing.Point(43, 252);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(114, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "²Floating point number.";
			this.AfterMoveBeforeClickDelayTextBox.IfZeroDisplayEmpty = false;
			this.AfterMoveBeforeClickDelayTextBox.Location = new global::System.Drawing.Point(340, 118);
			this.AfterMoveBeforeClickDelayTextBox.MaximumValue = 1000;
			this.AfterMoveBeforeClickDelayTextBox.MaxLength = 4;
			this.AfterMoveBeforeClickDelayTextBox.MinimumValue = 0;
			this.AfterMoveBeforeClickDelayTextBox.Name = "AfterMoveBeforeClickDelayTextBox";
			this.AfterMoveBeforeClickDelayTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.AfterMoveBeforeClickDelayTextBox.TabIndex = 3;
			this.AfterMoveBeforeClickDelayTextBox.Value = 0;
			this.label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label6.ForeColor = global::System.Drawing.Color.DimGray;
			this.label6.Location = new global::System.Drawing.Point(41, 230);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(209, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "¹Duration in milliseconds, 1000 = 1 second.";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label1.ForeColor = global::System.Drawing.Color.DimGray;
			this.label1.Location = new global::System.Drawing.Point(17, 147);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(186, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Image recognition color range: (0-255)";
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label7.ForeColor = global::System.Drawing.Color.DimGray;
			this.label7.Location = new global::System.Drawing.Point(17, 173);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(168, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Target movement range: (.01-1.5²)";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label2.ForeColor = global::System.Drawing.Color.DimGray;
			this.label2.Location = new global::System.Drawing.Point(17, 95);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(248, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Duration to hold the mouse while clicking: (0-1000¹)";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label4.ForeColor = global::System.Drawing.Color.DimGray;
			this.label4.Location = new global::System.Drawing.Point(17, 121);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(320, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Duration to delay after moving the mouse before clicking: (0-1000¹)";
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label3.ForeColor = global::System.Drawing.Color.DimGray;
			this.label3.Location = new global::System.Drawing.Point(17, 43);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(199, 13);
			this.label3.TabIndex = 14;
			this.label3.Text = "Duration to delay while casting: (0-1000¹)";
			this.ControlPanel.Controls.Add(this.CancelBtn);
			this.ControlPanel.Controls.Add(this.HowToOpenHelpLabel);
			this.ControlPanel.Controls.Add(this.SaveBtn);
			this.ControlPanel.Controls.Add(this.ResetBtn);
			this.ControlPanel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.ControlPanel.Location = new global::System.Drawing.Point(0, 282);
			this.ControlPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.ControlPanel.Name = "ControlPanel";
			this.ControlPanel.Size = new global::System.Drawing.Size(434, 31);
			this.ControlPanel.TabIndex = 38;
			this.SettingsPanel.Controls.Add(this.SettingsGroup);
			this.SettingsPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.SettingsPanel.Location = new global::System.Drawing.Point(0, 0);
			this.SettingsPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.SettingsPanel.Name = "SettingsPanel";
			this.SettingsPanel.Padding = new global::System.Windows.Forms.Padding(4);
			this.SettingsPanel.Size = new global::System.Drawing.Size(434, 282);
			this.SettingsPanel.TabIndex = 39;
			this.RequireStableFishTargetCheckBox.AutoSize = true;
			this.RequireStableFishTargetCheckBox.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.RequireStableFishTargetCheckBox.CheckAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.RequireStableFishTargetCheckBox.ForeColor = global::System.Drawing.Color.DimGray;
			this.RequireStableFishTargetCheckBox.Location = new global::System.Drawing.Point(340, 199);
			this.RequireStableFishTargetCheckBox.Name = "RequireStableFishTargetCheckBox";
			this.RequireStableFishTargetCheckBox.Size = new global::System.Drawing.Size(15, 14);
			this.RequireStableFishTargetCheckBox.TabIndex = 16;
			this.RequireStableFishTargetCheckBox.UseVisualStyleBackColor = false;
			this.RequireStableFishTargetLabel.AutoSize = true;
			this.RequireStableFishTargetLabel.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.RequireStableFishTargetLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.RequireStableFishTargetLabel.Location = new global::System.Drawing.Point(17, 199);
			this.RequireStableFishTargetLabel.Name = "RequireStableFishTargetLabel";
			this.RequireStableFishTargetLabel.Size = new global::System.Drawing.Size(127, 13);
			this.RequireStableFishTargetLabel.TabIndex = 14;
			this.RequireStableFishTargetLabel.Text = "Require stable fish target:";
			base.AcceptButton = this.SaveBtn;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.CancelButton = this.CancelBtn;
			base.ClientSize = new global::System.Drawing.Size(434, 313);
			base.Controls.Add(this.SettingsPanel);
			base.Controls.Add(this.ControlPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "JoeFishSettingsForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Joe Fish : Settings";
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.JoeFishSettingsForm_HelpRequested);
			this.SettingsGroup.ResumeLayout(false);
			this.SettingsGroup.PerformLayout();
			this.ControlPanel.ResumeLayout(false);
			this.ControlPanel.PerformLayout();
			this.SettingsPanel.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000337 RID: 823
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000338 RID: 824
		private global::ns21.Class181 MaxColorRangeTextBox;

		// Token: 0x04000339 RID: 825
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400033A RID: 826
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400033B RID: 827
		private global::ns21.Class181 ButtonClickDelayTextBox;

		// Token: 0x0400033C RID: 828
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400033D RID: 829
		private global::ns21.Class181 CastDragDelayTextBox;

		// Token: 0x0400033E RID: 830
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400033F RID: 831
		private global::ns21.Class181 AfterMoveBeforeClickDelayTextBox;

		// Token: 0x04000340 RID: 832
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000341 RID: 833
		private global::ns21.Class181 AfterCastDelayTextBox;

		// Token: 0x04000342 RID: 834
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000343 RID: 835
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000344 RID: 836
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000345 RID: 837
		private global::ns23.Class182 TargetRangeTextBox;

		// Token: 0x04000346 RID: 838
		private global::System.Windows.Forms.Button CancelBtn;

		// Token: 0x04000347 RID: 839
		private global::System.Windows.Forms.Button SaveBtn;

		// Token: 0x04000348 RID: 840
		private global::System.Windows.Forms.Button ResetBtn;

		// Token: 0x04000349 RID: 841
		private global::ns24.Class310 SettingsGroup;

		// Token: 0x0400034A RID: 842
		private global::System.Windows.Forms.Label SettingsLabel;

		// Token: 0x0400034B RID: 843
		private global::System.Windows.Forms.Label AdvancedSettingsTitleLabe;

		// Token: 0x0400034C RID: 844
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;

		// Token: 0x0400034D RID: 845
		private global::System.Windows.Forms.Panel ControlPanel;

		// Token: 0x0400034E RID: 846
		private global::System.Windows.Forms.Panel SettingsPanel;

		// Token: 0x0400034F RID: 847
		private global::System.Windows.Forms.CheckBox RequireStableFishTargetCheckBox;

		// Token: 0x04000350 RID: 848
		private global::System.Windows.Forms.Label RequireStableFishTargetLabel;
	}
}
