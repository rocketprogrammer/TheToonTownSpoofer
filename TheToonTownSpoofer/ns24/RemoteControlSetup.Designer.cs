namespace ns24
{
	// Token: 0x02000326 RID: 806
	internal sealed partial class RemoteControlSetup : global::System.Windows.Forms.Form
	{
		// Token: 0x06001F54 RID: 8020 RVA: 0x0000C62E File Offset: 0x0000A82E
		protected override void Dispose(bool disposing)
		{
			this.class141_0.Dispose();
			this.class141_1.Dispose();
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x000671E8 File Offset: 0x000653E8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns24.RemoteControlSetup));
			this.OKBtn = new global::System.Windows.Forms.Button();
			this.SetupGroup = new global::ns24.Class310();
			this.QWERTZOpt = new global::System.Windows.Forms.RadioButton();
			this.AZERTYOpt = new global::System.Windows.Forms.RadioButton();
			this.QWERTYOpt = new global::System.Windows.Forms.RadioButton();
			this.UseOpacity = new global::System.Windows.Forms.CheckBox();
			this.AnimateRemoteController = new global::System.Windows.Forms.CheckBox();
			this.KeepOnTop = new global::System.Windows.Forms.CheckBox();
			this.StatusText = new global::System.Windows.Forms.Label();
			this.StatusLed = new global::ns29.Control12();
			this.lblContentPackTitle = new global::System.Windows.Forms.Label();
			this.FirstWindowSelector = new global::ns22.WindowSelector();
			this.SecondWindowSelector = new global::ns22.WindowSelector();
			this.KeyboardLayoutLabel = new global::System.Windows.Forms.Label();
			this.HowTo = new global::System.Windows.Forms.Label();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.SetupGroup.SuspendLayout();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.OKBtn.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.OKBtn.Location = new global::System.Drawing.Point(321, 378);
			this.OKBtn.Name = "OKBtn";
			this.OKBtn.Size = new global::System.Drawing.Size(75, 23);
			this.OKBtn.TabIndex = 2;
			this.OKBtn.Text = "&OK";
			this.OKBtn.UseVisualStyleBackColor = true;
			this.OKBtn.Click += new global::System.EventHandler(this.OKBtn_Click);
			this.SetupGroup.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.SetupGroup.Controls.Add(this.QWERTZOpt);
			this.SetupGroup.Controls.Add(this.AZERTYOpt);
			this.SetupGroup.Controls.Add(this.QWERTYOpt);
			this.SetupGroup.Controls.Add(this.UseOpacity);
			this.SetupGroup.Controls.Add(this.AnimateRemoteController);
			this.SetupGroup.Controls.Add(this.KeepOnTop);
			this.SetupGroup.Controls.Add(this.StatusText);
			this.SetupGroup.Controls.Add(this.StatusLed);
			this.SetupGroup.Controls.Add(this.lblContentPackTitle);
			this.SetupGroup.Controls.Add(this.FirstWindowSelector);
			this.SetupGroup.Controls.Add(this.SecondWindowSelector);
			this.SetupGroup.Controls.Add(this.KeyboardLayoutLabel);
			this.SetupGroup.Controls.Add(this.HowTo);
			this.SetupGroup.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.SetupGroup.HeaderHeight = 30;
			this.SetupGroup.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.SetupGroup.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.SetupGroup.Location = new global::System.Drawing.Point(4, 4);
			this.SetupGroup.Name = "SetupGroup";
			this.SetupGroup.Size = new global::System.Drawing.Size(395, 371);
			this.SetupGroup.TabIndex = 1;
			this.QWERTZOpt.AutoSize = true;
			this.QWERTZOpt.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.QWERTZOpt.ForeColor = global::System.Drawing.Color.DimGray;
			this.QWERTZOpt.Location = new global::System.Drawing.Point(192, 342);
			this.QWERTZOpt.Name = "QWERTZOpt";
			this.QWERTZOpt.Size = new global::System.Drawing.Size(73, 17);
			this.QWERTZOpt.TabIndex = 18;
			this.QWERTZOpt.TabStop = true;
			this.QWERTZOpt.Text = "QWERTZ";
			this.QWERTZOpt.UseVisualStyleBackColor = false;
			this.QWERTZOpt.CheckedChanged += new global::System.EventHandler(this.QWERTZOpt_CheckedChanged);
			this.AZERTYOpt.AutoSize = true;
			this.AZERTYOpt.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.AZERTYOpt.ForeColor = global::System.Drawing.Color.DimGray;
			this.AZERTYOpt.Location = new global::System.Drawing.Point(118, 342);
			this.AZERTYOpt.Name = "AZERTYOpt";
			this.AZERTYOpt.Size = new global::System.Drawing.Size(68, 17);
			this.AZERTYOpt.TabIndex = 18;
			this.AZERTYOpt.TabStop = true;
			this.AZERTYOpt.Text = "AZERTY";
			this.AZERTYOpt.UseVisualStyleBackColor = false;
			this.AZERTYOpt.CheckedChanged += new global::System.EventHandler(this.AZERTYOpt_CheckedChanged);
			this.QWERTYOpt.AutoSize = true;
			this.QWERTYOpt.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.QWERTYOpt.ForeColor = global::System.Drawing.Color.DimGray;
			this.QWERTYOpt.Location = new global::System.Drawing.Point(39, 342);
			this.QWERTYOpt.Name = "QWERTYOpt";
			this.QWERTYOpt.Size = new global::System.Drawing.Size(73, 17);
			this.QWERTYOpt.TabIndex = 18;
			this.QWERTYOpt.TabStop = true;
			this.QWERTYOpt.Text = "QWERTY";
			this.QWERTYOpt.UseVisualStyleBackColor = false;
			this.QWERTYOpt.CheckedChanged += new global::System.EventHandler(this.QWERTYOpt_CheckedChanged);
			this.UseOpacity.AutoSize = true;
			this.UseOpacity.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.UseOpacity.ForeColor = global::System.Drawing.Color.DimGray;
			this.UseOpacity.Location = new global::System.Drawing.Point(39, 289);
			this.UseOpacity.Name = "UseOpacity";
			this.UseOpacity.Size = new global::System.Drawing.Size(194, 17);
			this.UseOpacity.TabIndex = 17;
			this.UseOpacity.Text = "Use opacity for the Remote Control.";
			this.UseOpacity.UseVisualStyleBackColor = false;
			this.UseOpacity.CheckedChanged += new global::System.EventHandler(this.UseOpacity_CheckedChanged);
			this.AnimateRemoteController.AutoSize = true;
			this.AnimateRemoteController.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.AnimateRemoteController.ForeColor = global::System.Drawing.Color.DimGray;
			this.AnimateRemoteController.Location = new global::System.Drawing.Point(39, 243);
			this.AnimateRemoteController.Name = "AnimateRemoteController";
			this.AnimateRemoteController.Size = new global::System.Drawing.Size(292, 17);
			this.AnimateRemoteController.TabIndex = 17;
			this.AnimateRemoteController.Text = "Animate the Remote Control's buttons and control sticks.";
			this.AnimateRemoteController.UseVisualStyleBackColor = false;
			this.AnimateRemoteController.CheckedChanged += new global::System.EventHandler(this.AnimateRemoteController_CheckedChanged);
			this.KeepOnTop.AutoSize = true;
			this.KeepOnTop.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.KeepOnTop.ForeColor = global::System.Drawing.Color.DimGray;
			this.KeepOnTop.Location = new global::System.Drawing.Point(39, 266);
			this.KeepOnTop.Name = "KeepOnTop";
			this.KeepOnTop.Size = new global::System.Drawing.Size(261, 17);
			this.KeepOnTop.TabIndex = 17;
			this.KeepOnTop.Text = "Keep Remote Control on top of other applications.";
			this.KeepOnTop.UseVisualStyleBackColor = false;
			this.KeepOnTop.CheckedChanged += new global::System.EventHandler(this.KeepOnTop_CheckedChanged);
			this.StatusText.BackColor = global::System.Drawing.Color.Transparent;
			this.StatusText.ForeColor = global::System.Drawing.Color.DimGray;
			this.StatusText.Location = new global::System.Drawing.Point(45, 74);
			this.StatusText.Name = "StatusText";
			this.StatusText.Size = new global::System.Drawing.Size(338, 23);
			this.StatusText.TabIndex = 16;
			this.StatusText.TextAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.StatusLed.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.StatusLed.BaseColor = global::System.Drawing.Color.White;
			this.StatusLed.Location = new global::System.Drawing.Point(16, 74);
			this.StatusLed.Name = "StatusLed";
			this.StatusLed.On = true;
			this.StatusLed.Size = new global::System.Drawing.Size(23, 23);
			this.StatusLed.TabIndex = 15;
			this.StatusLed.Text = "led1";
			this.lblContentPackTitle.AutoSize = true;
			this.lblContentPackTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.lblContentPackTitle.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblContentPackTitle.ForeColor = global::System.Drawing.Color.Gray;
			this.lblContentPackTitle.Location = new global::System.Drawing.Point(10, 8);
			this.lblContentPackTitle.Name = "lblContentPackTitle";
			this.lblContentPackTitle.Size = new global::System.Drawing.Size(161, 19);
			this.lblContentPackTitle.TabIndex = 11;
			this.lblContentPackTitle.Text = "Remote Control Setup";
			this.FirstWindowSelector.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.FirstWindowSelector.ForeColor = global::System.Drawing.Color.DimGray;
			this.FirstWindowSelector.LabelMessage = "click and drag the target onto the first ToonTown window";
			this.FirstWindowSelector.Location = new global::System.Drawing.Point(12, 103);
			this.FirstWindowSelector.Name = "FirstWindowSelector";
			this.FirstWindowSelector.ResourceNumber = 102;
			this.FirstWindowSelector.Size = new global::System.Drawing.Size(373, 60);
			this.FirstWindowSelector.TabIndex = 0;
			this.FirstWindowSelector.SelectedHandleChanged += new global::System.EventHandler<global::ns21.EventArgs14>(this.method_2);
			this.FirstWindowSelector.SelectedHandleChanging += new global::System.EventHandler<global::ns20.EventArgs15>(this.method_1);
			this.SecondWindowSelector.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.SecondWindowSelector.ForeColor = global::System.Drawing.Color.DimGray;
			this.SecondWindowSelector.LabelMessage = "click and drag the target onto the second ToonTown window";
			this.SecondWindowSelector.Location = new global::System.Drawing.Point(12, 169);
			this.SecondWindowSelector.Name = "SecondWindowSelector";
			this.SecondWindowSelector.ResourceNumber = 102;
			this.SecondWindowSelector.Size = new global::System.Drawing.Size(373, 60);
			this.SecondWindowSelector.TabIndex = 0;
			this.SecondWindowSelector.SelectedHandleChanged += new global::System.EventHandler<global::ns21.EventArgs14>(this.method_3);
			this.SecondWindowSelector.SelectedHandleChanging += new global::System.EventHandler<global::ns20.EventArgs15>(this.method_1);
			this.KeyboardLayoutLabel.AutoSize = true;
			this.KeyboardLayoutLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.KeyboardLayoutLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.KeyboardLayoutLabel.Location = new global::System.Drawing.Point(36, 326);
			this.KeyboardLayoutLabel.Name = "KeyboardLayoutLabel";
			this.KeyboardLayoutLabel.Size = new global::System.Drawing.Size(87, 13);
			this.KeyboardLayoutLabel.TabIndex = 14;
			this.KeyboardLayoutLabel.Text = "Keyboard Layout";
			this.HowTo.BackColor = global::System.Drawing.Color.Transparent;
			this.HowTo.ForeColor = global::System.Drawing.Color.DimGray;
			this.HowTo.Location = new global::System.Drawing.Point(11, 38);
			this.HowTo.Name = "HowTo";
			this.HowTo.Size = new global::System.Drawing.Size(370, 37);
			this.HowTo.TabIndex = 14;
			this.HowTo.Text = "To setup the Remote Control, please identify both ToonTown windows by using the below controls.";
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(4, 389);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 37;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			this.panel1.Controls.Add(this.SetupGroup);
			this.panel1.Controls.Add(this.HowToOpenHelpLabel);
			this.panel1.Controls.Add(this.OKBtn);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Margin = new global::System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new global::System.Windows.Forms.Padding(4);
			this.panel1.Size = new global::System.Drawing.Size(403, 404);
			this.panel1.TabIndex = 38;
			base.AcceptButton = this.OKBtn;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.ClientSize = new global::System.Drawing.Size(403, 404);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "RemoteControlSetup";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remote Control Setup";
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.RemoteControlSetup_HelpRequested);
			this.SetupGroup.ResumeLayout(false);
			this.SetupGroup.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C0C RID: 3084
		private global::ns16.Class141 class141_0;

		// Token: 0x04000C0D RID: 3085
		private global::ns16.Class141 class141_1;

		// Token: 0x04000C0F RID: 3087
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000C10 RID: 3088
		private global::ns22.WindowSelector FirstWindowSelector;

		// Token: 0x04000C11 RID: 3089
		private global::ns22.WindowSelector SecondWindowSelector;

		// Token: 0x04000C12 RID: 3090
		private global::ns24.Class310 SetupGroup;

		// Token: 0x04000C13 RID: 3091
		private global::System.Windows.Forms.Label lblContentPackTitle;

		// Token: 0x04000C14 RID: 3092
		private global::System.Windows.Forms.Label HowTo;

		// Token: 0x04000C15 RID: 3093
		private global::System.Windows.Forms.Button OKBtn;

		// Token: 0x04000C16 RID: 3094
		private global::ns29.Control12 StatusLed;

		// Token: 0x04000C17 RID: 3095
		private global::System.Windows.Forms.Label StatusText;

		// Token: 0x04000C18 RID: 3096
		private global::System.Windows.Forms.CheckBox AnimateRemoteController;

		// Token: 0x04000C19 RID: 3097
		private global::System.Windows.Forms.CheckBox KeepOnTop;

		// Token: 0x04000C1A RID: 3098
		private global::System.Windows.Forms.CheckBox UseOpacity;

		// Token: 0x04000C1B RID: 3099
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;

		// Token: 0x04000C1C RID: 3100
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000C1D RID: 3101
		private global::System.Windows.Forms.RadioButton QWERTZOpt;

		// Token: 0x04000C1E RID: 3102
		private global::System.Windows.Forms.RadioButton AZERTYOpt;

		// Token: 0x04000C1F RID: 3103
		private global::System.Windows.Forms.RadioButton QWERTYOpt;

		// Token: 0x04000C20 RID: 3104
		private global::System.Windows.Forms.Label KeyboardLayoutLabel;
	}
}
