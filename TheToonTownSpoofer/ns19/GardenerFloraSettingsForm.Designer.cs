namespace ns19
{
	// Token: 0x020003F3 RID: 1011
	internal sealed partial class GardenerFloraSettingsForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060026BA RID: 9914 RVA: 0x0001143B File Offset: 0x0000F63B
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00089AB0 File Offset: 0x00087CB0
		private void InitializeComponent()
		{
			this.ResetBtn = new global::System.Windows.Forms.Button();
			this.SaveBtn = new global::System.Windows.Forms.Button();
			this.CancelBtn = new global::System.Windows.Forms.Button();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.smoothGroup1 = new global::ns24.Class310();
			this.AdvancedSettingsTitleLabe = new global::System.Windows.Forms.Label();
			this.SettingsLabel = new global::System.Windows.Forms.Label();
			this.MaxColorRangeTextBox = new global::ns21.Class181();
			this.ButtonClickDelayTextBox = new global::ns21.Class181();
			this.TargetRangeTextBox = new global::ns23.Class182();
			this.label8 = new global::System.Windows.Forms.Label();
			this.AfterMoveBeforeClickDelayTextBox = new global::ns21.Class181();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.SettingsPanel = new global::System.Windows.Forms.Panel();
			this.ControlPanel = new global::System.Windows.Forms.Panel();
			this.smoothGroup1.SuspendLayout();
			this.SettingsPanel.SuspendLayout();
			this.ControlPanel.SuspendLayout();
			base.SuspendLayout();
			this.ResetBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.ResetBtn.Location = new global::System.Drawing.Point(177, 4);
			this.ResetBtn.Name = "ResetBtn";
			this.ResetBtn.Size = new global::System.Drawing.Size(75, 23);
			this.ResetBtn.TabIndex = 2;
			this.ResetBtn.Text = "Reset";
			this.ResetBtn.UseVisualStyleBackColor = true;
			this.ResetBtn.Click += new global::System.EventHandler(this.ResetBtn_Click);
			this.SaveBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.SaveBtn.Location = new global::System.Drawing.Point(258, 4);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new global::System.Drawing.Size(75, 23);
			this.SaveBtn.TabIndex = 0;
			this.SaveBtn.Text = "Save";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new global::System.EventHandler(this.SaveBtn_Click);
			this.CancelBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.CancelBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new global::System.Drawing.Point(339, 4);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new global::System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 1;
			this.CancelBtn.Text = "Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new global::System.EventHandler(this.CancelBtn_Click);
			this.HowToOpenHelpLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(2, 16);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 36;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			this.smoothGroup1.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.smoothGroup1.Controls.Add(this.AdvancedSettingsTitleLabe);
			this.smoothGroup1.Controls.Add(this.SettingsLabel);
			this.smoothGroup1.Controls.Add(this.MaxColorRangeTextBox);
			this.smoothGroup1.Controls.Add(this.ButtonClickDelayTextBox);
			this.smoothGroup1.Controls.Add(this.TargetRangeTextBox);
			this.smoothGroup1.Controls.Add(this.label8);
			this.smoothGroup1.Controls.Add(this.AfterMoveBeforeClickDelayTextBox);
			this.smoothGroup1.Controls.Add(this.label6);
			this.smoothGroup1.Controls.Add(this.label1);
			this.smoothGroup1.Controls.Add(this.label7);
			this.smoothGroup1.Controls.Add(this.label2);
			this.smoothGroup1.Controls.Add(this.label4);
			this.smoothGroup1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.smoothGroup1.HeaderHeight = 30;
			this.smoothGroup1.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.smoothGroup1.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.smoothGroup1.Location = new global::System.Drawing.Point(4, 4);
			this.smoothGroup1.Name = "smoothGroup1";
			this.smoothGroup1.Size = new global::System.Drawing.Size(416, 199);
			this.smoothGroup1.TabIndex = 19;
			this.AdvancedSettingsTitleLabe.AutoSize = true;
			this.AdvancedSettingsTitleLabe.BackColor = global::System.Drawing.Color.Transparent;
			this.AdvancedSettingsTitleLabe.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.AdvancedSettingsTitleLabe.ForeColor = global::System.Drawing.Color.DarkGray;
			this.AdvancedSettingsTitleLabe.Location = new global::System.Drawing.Point(75, 9);
			this.AdvancedSettingsTitleLabe.Name = "AdvancedSettingsTitleLabe";
			this.AdvancedSettingsTitleLabe.Size = new global::System.Drawing.Size(271, 19);
			this.AdvancedSettingsTitleLabe.TabIndex = 15;
			this.AdvancedSettingsTitleLabe.Text = "Set up advanced Gardener Flora settings";
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
			this.MaxColorRangeTextBox.Location = new global::System.Drawing.Point(340, 92);
			this.MaxColorRangeTextBox.MaximumValue = 255;
			this.MaxColorRangeTextBox.MaxLength = 3;
			this.MaxColorRangeTextBox.MinimumValue = 0;
			this.MaxColorRangeTextBox.Name = "MaxColorRangeTextBox";
			this.MaxColorRangeTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.MaxColorRangeTextBox.TabIndex = 2;
			this.MaxColorRangeTextBox.Value = 0;
			this.ButtonClickDelayTextBox.IfZeroDisplayEmpty = false;
			this.ButtonClickDelayTextBox.Location = new global::System.Drawing.Point(340, 40);
			this.ButtonClickDelayTextBox.MaximumValue = 1000;
			this.ButtonClickDelayTextBox.MaxLength = 4;
			this.ButtonClickDelayTextBox.MinimumValue = 0;
			this.ButtonClickDelayTextBox.Name = "ButtonClickDelayTextBox";
			this.ButtonClickDelayTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.ButtonClickDelayTextBox.TabIndex = 0;
			this.ButtonClickDelayTextBox.Value = 0;
			this.TargetRangeTextBox.Location = new global::System.Drawing.Point(340, 118);
			this.TargetRangeTextBox.MaximumValue = 1.5f;
			this.TargetRangeTextBox.MaxLength = 10;
			this.TargetRangeTextBox.MinimumValue = 0.01f;
			this.TargetRangeTextBox.Name = "TargetRangeTextBox";
			this.TargetRangeTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.TargetRangeTextBox.TabIndex = 3;
			this.TargetRangeTextBox.Text = "0.01";
			this.TargetRangeTextBox.Value = 0.01f;
			this.label8.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label8.AutoSize = true;
			this.label8.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label8.ForeColor = global::System.Drawing.Color.DimGray;
			this.label8.Location = new global::System.Drawing.Point(37, 173);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(114, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "²Floating point number.";
			this.AfterMoveBeforeClickDelayTextBox.IfZeroDisplayEmpty = false;
			this.AfterMoveBeforeClickDelayTextBox.Location = new global::System.Drawing.Point(340, 66);
			this.AfterMoveBeforeClickDelayTextBox.MaximumValue = 1000;
			this.AfterMoveBeforeClickDelayTextBox.MaxLength = 4;
			this.AfterMoveBeforeClickDelayTextBox.MinimumValue = 0;
			this.AfterMoveBeforeClickDelayTextBox.Name = "AfterMoveBeforeClickDelayTextBox";
			this.AfterMoveBeforeClickDelayTextBox.Size = new global::System.Drawing.Size(56, 20);
			this.AfterMoveBeforeClickDelayTextBox.TabIndex = 1;
			this.AfterMoveBeforeClickDelayTextBox.Value = 0;
			this.label6.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.label6.AutoSize = true;
			this.label6.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label6.ForeColor = global::System.Drawing.Color.DimGray;
			this.label6.Location = new global::System.Drawing.Point(35, 151);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(209, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "¹Duration in milliseconds, 1000 = 1 second.";
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label1.ForeColor = global::System.Drawing.Color.DimGray;
			this.label1.Location = new global::System.Drawing.Point(17, 95);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(186, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "Image recognition color range: (0-255)";
			this.label7.AutoSize = true;
			this.label7.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label7.ForeColor = global::System.Drawing.Color.DimGray;
			this.label7.Location = new global::System.Drawing.Point(17, 121);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(168, 13);
			this.label7.TabIndex = 14;
			this.label7.Text = "Target movement range: (.01-1.5²)";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label2.ForeColor = global::System.Drawing.Color.DimGray;
			this.label2.Location = new global::System.Drawing.Point(17, 43);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(248, 13);
			this.label2.TabIndex = 14;
			this.label2.Text = "Duration to hold the mouse while clicking: (0-1000¹)";
			this.label4.AutoSize = true;
			this.label4.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.label4.ForeColor = global::System.Drawing.Color.DimGray;
			this.label4.Location = new global::System.Drawing.Point(17, 69);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(320, 13);
			this.label4.TabIndex = 14;
			this.label4.Text = "Duration to delay after moving the mouse before clicking: (0-1000¹)";
			this.SettingsPanel.Controls.Add(this.smoothGroup1);
			this.SettingsPanel.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.SettingsPanel.Location = new global::System.Drawing.Point(0, 0);
			this.SettingsPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.SettingsPanel.Name = "SettingsPanel";
			this.SettingsPanel.Padding = new global::System.Windows.Forms.Padding(4);
			this.SettingsPanel.Size = new global::System.Drawing.Size(424, 207);
			this.SettingsPanel.TabIndex = 37;
			this.ControlPanel.Controls.Add(this.HowToOpenHelpLabel);
			this.ControlPanel.Controls.Add(this.ResetBtn);
			this.ControlPanel.Controls.Add(this.CancelBtn);
			this.ControlPanel.Controls.Add(this.SaveBtn);
			this.ControlPanel.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.ControlPanel.Location = new global::System.Drawing.Point(0, 207);
			this.ControlPanel.Margin = new global::System.Windows.Forms.Padding(0);
			this.ControlPanel.Name = "ControlPanel";
			this.ControlPanel.Size = new global::System.Drawing.Size(424, 31);
			this.ControlPanel.TabIndex = 38;
			base.AcceptButton = this.SaveBtn;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.CancelButton = this.CancelBtn;
			base.ClientSize = new global::System.Drawing.Size(424, 238);
			base.Controls.Add(this.SettingsPanel);
			base.Controls.Add(this.ControlPanel);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "GardenerFloraSettingsForm";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Gardener Flora : Settings";
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.GardenerFloraSettingsForm_HelpRequested);
			this.smoothGroup1.ResumeLayout(false);
			this.smoothGroup1.PerformLayout();
			this.SettingsPanel.ResumeLayout(false);
			this.ControlPanel.ResumeLayout(false);
			this.ControlPanel.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040012E6 RID: 4838
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040012E7 RID: 4839
		private global::ns24.Class310 smoothGroup1;

		// Token: 0x040012E8 RID: 4840
		private global::System.Windows.Forms.Label AdvancedSettingsTitleLabe;

		// Token: 0x040012E9 RID: 4841
		private global::System.Windows.Forms.Label SettingsLabel;

		// Token: 0x040012EA RID: 4842
		private global::ns21.Class181 MaxColorRangeTextBox;

		// Token: 0x040012EB RID: 4843
		private global::ns21.Class181 ButtonClickDelayTextBox;

		// Token: 0x040012EC RID: 4844
		private global::ns23.Class182 TargetRangeTextBox;

		// Token: 0x040012ED RID: 4845
		private global::System.Windows.Forms.Label label8;

		// Token: 0x040012EE RID: 4846
		private global::ns21.Class181 AfterMoveBeforeClickDelayTextBox;

		// Token: 0x040012EF RID: 4847
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040012F0 RID: 4848
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040012F1 RID: 4849
		private global::System.Windows.Forms.Label label7;

		// Token: 0x040012F2 RID: 4850
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040012F3 RID: 4851
		private global::System.Windows.Forms.Label label4;

		// Token: 0x040012F4 RID: 4852
		private global::System.Windows.Forms.Button ResetBtn;

		// Token: 0x040012F5 RID: 4853
		private global::System.Windows.Forms.Button SaveBtn;

		// Token: 0x040012F6 RID: 4854
		private global::System.Windows.Forms.Button CancelBtn;

		// Token: 0x040012F7 RID: 4855
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;

		// Token: 0x040012F8 RID: 4856
		private global::System.Windows.Forms.Panel SettingsPanel;

		// Token: 0x040012F9 RID: 4857
		private global::System.Windows.Forms.Panel ControlPanel;
	}
}
