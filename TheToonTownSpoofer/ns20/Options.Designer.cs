namespace ns20
{
	// Token: 0x02000425 RID: 1061
	internal sealed partial class Options : global::System.Windows.Forms.Form
	{
		// Token: 0x0600285F RID: 10335 RVA: 0x00012519 File Offset: 0x00010719
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002860 RID: 10336 RVA: 0x000961C4 File Offset: 0x000943C4
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns20.Options));
			this.HotkeyOptions = new global::System.Windows.Forms.GroupBox();
			this.HotkeyActionsPanel = new global::System.Windows.Forms.Panel();
			this.HotkeyDescription = new global::System.Windows.Forms.TextBox();
			this.ReleaseKeyDelayLabel = new global::System.Windows.Forms.Label();
			this.RepeatKeyPressRateLabel = new global::System.Windows.Forms.Label();
			this.MoveMouseRateLabel = new global::System.Windows.Forms.Label();
			this.StopOtherHotkeysCheckBox = new global::System.Windows.Forms.CheckBox();
			this.TabToonTownWindowsRadioButton = new global::System.Windows.Forms.RadioButton();
			this.PerformEventRadioButton = new global::System.Windows.Forms.RadioButton();
			this.KeyToPressLabel = new global::System.Windows.Forms.Label();
			this.MoveMouseCheckBox = new global::System.Windows.Forms.CheckBox();
			this.ReleaseKeyCheckBox = new global::System.Windows.Forms.CheckBox();
			this.RepeatKeyPressCheckBox = new global::System.Windows.Forms.CheckBox();
			this.ResetHotkeys = new global::System.Windows.Forms.Button();
			this.RemoveHotkey = new global::System.Windows.Forms.Button();
			this.lblProperties = new global::System.Windows.Forms.Label();
			this.CancelHotkeyButton = new global::System.Windows.Forms.Button();
			this.AcceptHotkeyButton = new global::System.Windows.Forms.Button();
			this.OptionsStatus = new global::System.Windows.Forms.StatusStrip();
			this.StatusLabel = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.OKButton = new global::System.Windows.Forms.Button();
			this.OptionsContainer = new global::System.Windows.Forms.TabControl();
			this.ApplicationSettingsTab = new global::System.Windows.Forms.TabPage();
			this.DownloadingSettings = new global::System.Windows.Forms.GroupBox();
			this.ConcurrentDownloadsLabel = new global::System.Windows.Forms.Label();
			this.OptionsLogo = new global::System.Windows.Forms.PictureBox();
			this.ScreenshotSettingsGroup = new global::System.Windows.Forms.GroupBox();
			this.ViewScreenshotDirectory = new global::System.Windows.Forms.Button();
			this.BrowseForScreenshotDirectory = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.ScreenshotDirectoryBox = new global::System.Windows.Forms.TextBox();
			this.ContentSettingsGroup = new global::System.Windows.Forms.GroupBox();
			this.LocalPortLabel = new global::System.Windows.Forms.Label();
			this.AutomaticUpdatingGroup = new global::System.Windows.Forms.GroupBox();
			this.DoNothingCheckBox = new global::System.Windows.Forms.RadioButton();
			this.NotifyAvailableCheckBox = new global::System.Windows.Forms.RadioButton();
			this.NotifyWhenDownloadedCheckBox = new global::System.Windows.Forms.RadioButton();
			this.AutomaticallyInstallCheckBox = new global::System.Windows.Forms.RadioButton();
			this.HotkeySetupTab = new global::System.Windows.Forms.TabPage();
			this.folderBrowserDialog_0 = new global::System.Windows.Forms.FolderBrowserDialog();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.DataDirectoryTextBox = new global::System.Windows.Forms.TextBox();
			this.ViewDataDirectoryBtn = new global::System.Windows.Forms.Button();
			this.ConcurrentDownloadsTextBox = new global::ns21.Class181();
			this.LocalPortBox = new global::ns21.Class181();
			this.KeyToPressBox = new global::ns18.Class257();
			this.KeyPressRepeatRateBox = new global::ns21.Class181();
			this.KeyReleaseDelayBox = new global::ns21.Class181();
			this.MoveMouseRateBox = new global::ns21.Class181();
			this.HotkeyListBox = new global::ns31.Class293();
			this.HotkeyBox = new global::ns18.Class257();
			this.class343_0 = new global::ns22.Class343(this.icontainer_0);
			this.HotkeyOptions.SuspendLayout();
			this.HotkeyActionsPanel.SuspendLayout();
			this.OptionsStatus.SuspendLayout();
			this.OptionsContainer.SuspendLayout();
			this.ApplicationSettingsTab.SuspendLayout();
			this.DownloadingSettings.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.OptionsLogo).BeginInit();
			this.ScreenshotSettingsGroup.SuspendLayout();
			this.ContentSettingsGroup.SuspendLayout();
			this.AutomaticUpdatingGroup.SuspendLayout();
			this.HotkeySetupTab.SuspendLayout();
			base.SuspendLayout();
			this.HotkeyOptions.Controls.Add(this.HotkeyActionsPanel);
			this.HotkeyOptions.Controls.Add(this.ResetHotkeys);
			this.HotkeyOptions.Controls.Add(this.RemoveHotkey);
			this.HotkeyOptions.Controls.Add(this.lblProperties);
			this.HotkeyOptions.Controls.Add(this.CancelHotkeyButton);
			this.HotkeyOptions.Controls.Add(this.AcceptHotkeyButton);
			this.HotkeyOptions.Controls.Add(this.HotkeyListBox);
			this.HotkeyOptions.Controls.Add(this.HotkeyBox);
			this.HotkeyOptions.Location = new global::System.Drawing.Point(6, 7);
			this.HotkeyOptions.Name = "HotkeyOptions";
			this.HotkeyOptions.Size = new global::System.Drawing.Size(487, 294);
			this.HotkeyOptions.TabIndex = 1;
			this.HotkeyOptions.TabStop = false;
			this.HotkeyOptions.Text = "Hotkey Setup";
			this.HotkeyActionsPanel.Controls.Add(this.HotkeyDescription);
			this.HotkeyActionsPanel.Controls.Add(this.ReleaseKeyDelayLabel);
			this.HotkeyActionsPanel.Controls.Add(this.KeyToPressBox);
			this.HotkeyActionsPanel.Controls.Add(this.RepeatKeyPressRateLabel);
			this.HotkeyActionsPanel.Controls.Add(this.KeyPressRepeatRateBox);
			this.HotkeyActionsPanel.Controls.Add(this.MoveMouseRateLabel);
			this.HotkeyActionsPanel.Controls.Add(this.KeyReleaseDelayBox);
			this.HotkeyActionsPanel.Controls.Add(this.MoveMouseRateBox);
			this.HotkeyActionsPanel.Controls.Add(this.StopOtherHotkeysCheckBox);
			this.HotkeyActionsPanel.Controls.Add(this.TabToonTownWindowsRadioButton);
			this.HotkeyActionsPanel.Controls.Add(this.PerformEventRadioButton);
			this.HotkeyActionsPanel.Controls.Add(this.KeyToPressLabel);
			this.HotkeyActionsPanel.Controls.Add(this.MoveMouseCheckBox);
			this.HotkeyActionsPanel.Controls.Add(this.ReleaseKeyCheckBox);
			this.HotkeyActionsPanel.Controls.Add(this.RepeatKeyPressCheckBox);
			this.HotkeyActionsPanel.Location = new global::System.Drawing.Point(190, 44);
			this.HotkeyActionsPanel.Name = "HotkeyActionsPanel";
			this.HotkeyActionsPanel.Size = new global::System.Drawing.Size(288, 241);
			this.HotkeyActionsPanel.TabIndex = 14;
			this.HotkeyDescription.Enabled = false;
			this.HotkeyDescription.Location = new global::System.Drawing.Point(2, 2);
			this.HotkeyDescription.MaxLength = 999;
			this.HotkeyDescription.Multiline = true;
			this.HotkeyDescription.Name = "HotkeyDescription";
			this.HotkeyDescription.Size = new global::System.Drawing.Size(284, 42);
			this.HotkeyDescription.TabIndex = 11;
			this.HotkeyDescription.TextChanged += new global::System.EventHandler(this.HotkeyDescription_TextChanged);
			this.HotkeyDescription.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.HotkeyDescription.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.ReleaseKeyDelayLabel.AutoSize = true;
			this.ReleaseKeyDelayLabel.Enabled = false;
			this.ReleaseKeyDelayLabel.Location = new global::System.Drawing.Point(115, 152);
			this.ReleaseKeyDelayLabel.Name = "ReleaseKeyDelayLabel";
			this.ReleaseKeyDelayLabel.Size = new global::System.Drawing.Size(37, 13);
			this.ReleaseKeyDelayLabel.TabIndex = 13;
			this.ReleaseKeyDelayLabel.Text = "Delay:";
			this.RepeatKeyPressRateLabel.AutoSize = true;
			this.RepeatKeyPressRateLabel.Enabled = false;
			this.RepeatKeyPressRateLabel.Location = new global::System.Drawing.Point(139, 129);
			this.RepeatKeyPressRateLabel.Name = "RepeatKeyPressRateLabel";
			this.RepeatKeyPressRateLabel.Size = new global::System.Drawing.Size(33, 13);
			this.RepeatKeyPressRateLabel.TabIndex = 13;
			this.RepeatKeyPressRateLabel.Text = "Rate:";
			this.MoveMouseRateLabel.AutoSize = true;
			this.MoveMouseRateLabel.Enabled = false;
			this.MoveMouseRateLabel.Location = new global::System.Drawing.Point(117, 175);
			this.MoveMouseRateLabel.Name = "MoveMouseRateLabel";
			this.MoveMouseRateLabel.Size = new global::System.Drawing.Size(33, 13);
			this.MoveMouseRateLabel.TabIndex = 13;
			this.MoveMouseRateLabel.Text = "Rate:";
			this.StopOtherHotkeysCheckBox.AutoSize = true;
			this.StopOtherHotkeysCheckBox.Enabled = false;
			this.StopOtherHotkeysCheckBox.Location = new global::System.Drawing.Point(31, 197);
			this.StopOtherHotkeysCheckBox.Name = "StopOtherHotkeysCheckBox";
			this.StopOtherHotkeysCheckBox.Size = new global::System.Drawing.Size(254, 17);
			this.StopOtherHotkeysCheckBox.TabIndex = 9;
			this.StopOtherHotkeysCheckBox.Text = "Stop other active hotkeys for the active window.";
			this.StopOtherHotkeysCheckBox.UseVisualStyleBackColor = true;
			this.StopOtherHotkeysCheckBox.CheckedChanged += new global::System.EventHandler(this.StopOtherHotkeysCheckBox_CheckedChanged);
			this.StopOtherHotkeysCheckBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.StopOtherHotkeysCheckBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.TabToonTownWindowsRadioButton.AutoSize = true;
			this.TabToonTownWindowsRadioButton.Enabled = false;
			this.TabToonTownWindowsRadioButton.Location = new global::System.Drawing.Point(2, 50);
			this.TabToonTownWindowsRadioButton.Name = "TabToonTownWindowsRadioButton";
			this.TabToonTownWindowsRadioButton.Size = new global::System.Drawing.Size(181, 17);
			this.TabToonTownWindowsRadioButton.TabIndex = 0;
			this.TabToonTownWindowsRadioButton.TabStop = true;
			this.TabToonTownWindowsRadioButton.Text = "Tabs to next ToonTown window.";
			this.TabToonTownWindowsRadioButton.UseVisualStyleBackColor = true;
			this.TabToonTownWindowsRadioButton.CheckedChanged += new global::System.EventHandler(this.TabToonTownWindowsRadioButton_CheckedChanged);
			this.TabToonTownWindowsRadioButton.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.TabToonTownWindowsRadioButton.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.PerformEventRadioButton.AutoSize = true;
			this.PerformEventRadioButton.Enabled = false;
			this.PerformEventRadioButton.Location = new global::System.Drawing.Point(2, 73);
			this.PerformEventRadioButton.Name = "PerformEventRadioButton";
			this.PerformEventRadioButton.Size = new global::System.Drawing.Size(197, 17);
			this.PerformEventRadioButton.TabIndex = 1;
			this.PerformEventRadioButton.TabStop = true;
			this.PerformEventRadioButton.Text = "Performs a mouse and/or key event.";
			this.PerformEventRadioButton.UseVisualStyleBackColor = true;
			this.PerformEventRadioButton.CheckedChanged += new global::System.EventHandler(this.PerformEventRadioButton_CheckedChanged);
			this.PerformEventRadioButton.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.PerformEventRadioButton.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.KeyToPressLabel.AutoSize = true;
			this.KeyToPressLabel.Enabled = false;
			this.KeyToPressLabel.Location = new global::System.Drawing.Point(28, 105);
			this.KeyToPressLabel.Name = "KeyToPressLabel";
			this.KeyToPressLabel.Size = new global::System.Drawing.Size(68, 13);
			this.KeyToPressLabel.TabIndex = 7;
			this.KeyToPressLabel.Text = "Key to press:";
			this.MoveMouseCheckBox.AutoSize = true;
			this.MoveMouseCheckBox.Enabled = false;
			this.MoveMouseCheckBox.Location = new global::System.Drawing.Point(31, 174);
			this.MoveMouseCheckBox.Name = "MoveMouseCheckBox";
			this.MoveMouseCheckBox.Size = new global::System.Drawing.Size(90, 17);
			this.MoveMouseCheckBox.TabIndex = 7;
			this.MoveMouseCheckBox.Text = "Move mouse.";
			this.MoveMouseCheckBox.UseVisualStyleBackColor = true;
			this.MoveMouseCheckBox.CheckedChanged += new global::System.EventHandler(this.MoveMouseCheckBox_CheckedChanged);
			this.MoveMouseCheckBox.EnabledChanged += new global::System.EventHandler(this.MoveMouseCheckBox_EnabledChanged);
			this.MoveMouseCheckBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.MoveMouseCheckBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.ReleaseKeyCheckBox.AutoSize = true;
			this.ReleaseKeyCheckBox.Enabled = false;
			this.ReleaseKeyCheckBox.Location = new global::System.Drawing.Point(31, 151);
			this.ReleaseKeyCheckBox.Name = "ReleaseKeyCheckBox";
			this.ReleaseKeyCheckBox.Size = new global::System.Drawing.Size(88, 17);
			this.ReleaseKeyCheckBox.TabIndex = 5;
			this.ReleaseKeyCheckBox.Text = "Release key.";
			this.ReleaseKeyCheckBox.UseVisualStyleBackColor = true;
			this.ReleaseKeyCheckBox.CheckedChanged += new global::System.EventHandler(this.ReleaseKeyCheckBox_CheckedChanged);
			this.ReleaseKeyCheckBox.EnabledChanged += new global::System.EventHandler(this.ReleaseKeyCheckBox_EnabledChanged);
			this.ReleaseKeyCheckBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.ReleaseKeyCheckBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.RepeatKeyPressCheckBox.AutoSize = true;
			this.RepeatKeyPressCheckBox.Enabled = false;
			this.RepeatKeyPressCheckBox.Location = new global::System.Drawing.Point(31, 128);
			this.RepeatKeyPressCheckBox.Name = "RepeatKeyPressCheckBox";
			this.RepeatKeyPressCheckBox.Size = new global::System.Drawing.Size(112, 17);
			this.RepeatKeyPressCheckBox.TabIndex = 3;
			this.RepeatKeyPressCheckBox.Text = "Repeat key press.";
			this.RepeatKeyPressCheckBox.UseVisualStyleBackColor = true;
			this.RepeatKeyPressCheckBox.CheckedChanged += new global::System.EventHandler(this.RepeatKeyPressCheckBox_CheckedChanged);
			this.RepeatKeyPressCheckBox.EnabledChanged += new global::System.EventHandler(this.RepeatKeyPressCheckBox_EnabledChanged);
			this.RepeatKeyPressCheckBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.RepeatKeyPressCheckBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.ResetHotkeys.Location = new global::System.Drawing.Point(82, 264);
			this.ResetHotkeys.Name = "ResetHotkeys";
			this.ResetHotkeys.Size = new global::System.Drawing.Size(104, 23);
			this.ResetHotkeys.TabIndex = 5;
			this.ResetHotkeys.Text = "Reset Hotkeys";
			this.ResetHotkeys.UseVisualStyleBackColor = true;
			this.ResetHotkeys.Click += new global::System.EventHandler(this.ResetHotkeys_Click);
			this.ResetHotkeys.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.ResetHotkeys.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.RemoveHotkey.Location = new global::System.Drawing.Point(9, 264);
			this.RemoveHotkey.Name = "RemoveHotkey";
			this.RemoveHotkey.Size = new global::System.Drawing.Size(67, 23);
			this.RemoveHotkey.TabIndex = 4;
			this.RemoveHotkey.Text = "Remove";
			this.RemoveHotkey.UseVisualStyleBackColor = true;
			this.RemoveHotkey.Click += new global::System.EventHandler(this.RemoveHotkey_Click);
			this.RemoveHotkey.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.RemoveHotkey.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.lblProperties.AutoSize = true;
			this.lblProperties.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblProperties.Location = new global::System.Drawing.Point(282, 20);
			this.lblProperties.Name = "lblProperties";
			this.lblProperties.Size = new global::System.Drawing.Size(105, 19);
			this.lblProperties.TabIndex = 10;
			this.lblProperties.Text = "Hotkey Actions";
			this.CancelHotkeyButton.Enabled = false;
			this.CancelHotkeyButton.Location = new global::System.Drawing.Point(160, 16);
			this.CancelHotkeyButton.Name = "CancelHotkeyButton";
			this.CancelHotkeyButton.Size = new global::System.Drawing.Size(26, 26);
			this.CancelHotkeyButton.TabIndex = 2;
			this.CancelHotkeyButton.UseVisualStyleBackColor = true;
			this.CancelHotkeyButton.Click += new global::System.EventHandler(this.CancelHotkeyButton_Click);
			this.CancelHotkeyButton.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.CancelHotkeyButton.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.AcceptHotkeyButton.Enabled = false;
			this.AcceptHotkeyButton.Location = new global::System.Drawing.Point(131, 16);
			this.AcceptHotkeyButton.Name = "AcceptHotkeyButton";
			this.AcceptHotkeyButton.Size = new global::System.Drawing.Size(26, 26);
			this.AcceptHotkeyButton.TabIndex = 1;
			this.AcceptHotkeyButton.UseVisualStyleBackColor = true;
			this.AcceptHotkeyButton.Click += new global::System.EventHandler(this.AcceptHotkeyButton_Click);
			this.AcceptHotkeyButton.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.AcceptHotkeyButton.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.OptionsStatus.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.StatusLabel
			});
			this.OptionsStatus.Location = new global::System.Drawing.Point(0, 379);
			this.OptionsStatus.Name = "OptionsStatus";
			this.OptionsStatus.Size = new global::System.Drawing.Size(524, 22);
			this.OptionsStatus.SizingGrip = false;
			this.OptionsStatus.TabIndex = 2;
			this.OptionsStatus.Text = "statusStrip1";
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new global::System.Drawing.Size(0, 17);
			this.OKButton.Location = new global::System.Drawing.Point(437, 349);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 3;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new global::System.EventHandler(this.OKButton_Click);
			this.OKButton.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.OKButton.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.OptionsContainer.Controls.Add(this.ApplicationSettingsTab);
			this.OptionsContainer.Controls.Add(this.HotkeySetupTab);
			this.OptionsContainer.Location = new global::System.Drawing.Point(9, 12);
			this.OptionsContainer.Name = "OptionsContainer";
			this.OptionsContainer.SelectedIndex = 0;
			this.OptionsContainer.Size = new global::System.Drawing.Size(507, 331);
			this.OptionsContainer.TabIndex = 4;
			this.ApplicationSettingsTab.BackColor = global::System.Drawing.Color.White;
			this.ApplicationSettingsTab.Controls.Add(this.DownloadingSettings);
			this.ApplicationSettingsTab.Controls.Add(this.OptionsLogo);
			this.ApplicationSettingsTab.Controls.Add(this.ScreenshotSettingsGroup);
			this.ApplicationSettingsTab.Controls.Add(this.ContentSettingsGroup);
			this.ApplicationSettingsTab.Controls.Add(this.AutomaticUpdatingGroup);
			this.ApplicationSettingsTab.Location = new global::System.Drawing.Point(4, 22);
			this.ApplicationSettingsTab.Name = "ApplicationSettingsTab";
			this.ApplicationSettingsTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.ApplicationSettingsTab.Size = new global::System.Drawing.Size(499, 305);
			this.ApplicationSettingsTab.TabIndex = 0;
			this.ApplicationSettingsTab.Text = "Application Settings";
			this.DownloadingSettings.Controls.Add(this.ConcurrentDownloadsLabel);
			this.DownloadingSettings.Controls.Add(this.ConcurrentDownloadsTextBox);
			this.DownloadingSettings.Location = new global::System.Drawing.Point(305, 201);
			this.DownloadingSettings.Name = "DownloadingSettings";
			this.DownloadingSettings.Size = new global::System.Drawing.Size(137, 70);
			this.DownloadingSettings.TabIndex = 6;
			this.DownloadingSettings.TabStop = false;
			this.DownloadingSettings.Text = "Downloading";
			this.ConcurrentDownloadsLabel.AutoSize = true;
			this.ConcurrentDownloadsLabel.Location = new global::System.Drawing.Point(11, 20);
			this.ConcurrentDownloadsLabel.Name = "ConcurrentDownloadsLabel";
			this.ConcurrentDownloadsLabel.Size = new global::System.Drawing.Size(115, 13);
			this.ConcurrentDownloadsLabel.TabIndex = 2;
			this.ConcurrentDownloadsLabel.Text = "Concurrent Downloads";
			this.OptionsLogo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("OptionsLogo.Image");
			this.OptionsLogo.Location = new global::System.Drawing.Point(445, 3);
			this.OptionsLogo.Name = "OptionsLogo";
			this.OptionsLogo.Size = new global::System.Drawing.Size(48, 48);
			this.OptionsLogo.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.OptionsLogo.TabIndex = 5;
			this.OptionsLogo.TabStop = false;
			this.OptionsLogo.Click += new global::System.EventHandler(this.OptionsLogo_Click);
			this.OptionsLogo.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.OptionsLogo.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.ScreenshotSettingsGroup.Controls.Add(this.label2);
			this.ScreenshotSettingsGroup.Controls.Add(this.ViewDataDirectoryBtn);
			this.ScreenshotSettingsGroup.Controls.Add(this.ViewScreenshotDirectory);
			this.ScreenshotSettingsGroup.Controls.Add(this.BrowseForScreenshotDirectory);
			this.ScreenshotSettingsGroup.Controls.Add(this.label1);
			this.ScreenshotSettingsGroup.Controls.Add(this.DataDirectoryTextBox);
			this.ScreenshotSettingsGroup.Controls.Add(this.ScreenshotDirectoryBox);
			this.ScreenshotSettingsGroup.Location = new global::System.Drawing.Point(56, 31);
			this.ScreenshotSettingsGroup.Name = "ScreenshotSettingsGroup";
			this.ScreenshotSettingsGroup.Size = new global::System.Drawing.Size(266, 114);
			this.ScreenshotSettingsGroup.TabIndex = 4;
			this.ScreenshotSettingsGroup.TabStop = false;
			this.ScreenshotSettingsGroup.Text = "Directories";
			this.ViewScreenshotDirectory.Location = new global::System.Drawing.Point(192, 36);
			this.ViewScreenshotDirectory.Name = "ViewScreenshotDirectory";
			this.ViewScreenshotDirectory.Size = new global::System.Drawing.Size(63, 23);
			this.ViewScreenshotDirectory.TabIndex = 3;
			this.ViewScreenshotDirectory.Text = "View Files";
			this.ViewScreenshotDirectory.UseVisualStyleBackColor = true;
			this.ViewScreenshotDirectory.Click += new global::System.EventHandler(this.ViewScreenshotDirectory_Click);
			this.ViewScreenshotDirectory.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.ViewScreenshotDirectory.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.BrowseForScreenshotDirectory.Location = new global::System.Drawing.Point(164, 36);
			this.BrowseForScreenshotDirectory.Name = "BrowseForScreenshotDirectory";
			this.BrowseForScreenshotDirectory.Size = new global::System.Drawing.Size(25, 23);
			this.BrowseForScreenshotDirectory.TabIndex = 3;
			this.BrowseForScreenshotDirectory.Text = "...";
			this.BrowseForScreenshotDirectory.UseVisualStyleBackColor = true;
			this.BrowseForScreenshotDirectory.Click += new global::System.EventHandler(this.BrowseForScreenshotDirectory_Click);
			this.BrowseForScreenshotDirectory.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.BrowseForScreenshotDirectory.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(11, 20);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(137, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Screenshot Save Directory:";
			this.ScreenshotDirectoryBox.Location = new global::System.Drawing.Point(14, 37);
			this.ScreenshotDirectoryBox.Name = "ScreenshotDirectoryBox";
			this.ScreenshotDirectoryBox.ReadOnly = true;
			this.ScreenshotDirectoryBox.Size = new global::System.Drawing.Size(147, 20);
			this.ScreenshotDirectoryBox.TabIndex = 0;
			this.ScreenshotDirectoryBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.ScreenshotDirectoryBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.ContentSettingsGroup.Controls.Add(this.LocalPortLabel);
			this.ContentSettingsGroup.Controls.Add(this.LocalPortBox);
			this.ContentSettingsGroup.Location = new global::System.Drawing.Point(339, 120);
			this.ContentSettingsGroup.Name = "ContentSettingsGroup";
			this.ContentSettingsGroup.Size = new global::System.Drawing.Size(103, 70);
			this.ContentSettingsGroup.TabIndex = 3;
			this.ContentSettingsGroup.TabStop = false;
			this.ContentSettingsGroup.Text = "Content";
			this.LocalPortLabel.AutoSize = true;
			this.LocalPortLabel.Location = new global::System.Drawing.Point(11, 20);
			this.LocalPortLabel.Name = "LocalPortLabel";
			this.LocalPortLabel.Size = new global::System.Drawing.Size(58, 13);
			this.LocalPortLabel.TabIndex = 2;
			this.LocalPortLabel.Text = "Local Port:";
			this.AutomaticUpdatingGroup.Controls.Add(this.DoNothingCheckBox);
			this.AutomaticUpdatingGroup.Controls.Add(this.NotifyAvailableCheckBox);
			this.AutomaticUpdatingGroup.Controls.Add(this.NotifyWhenDownloadedCheckBox);
			this.AutomaticUpdatingGroup.Controls.Add(this.AutomaticallyInstallCheckBox);
			this.AutomaticUpdatingGroup.Location = new global::System.Drawing.Point(56, 154);
			this.AutomaticUpdatingGroup.Name = "AutomaticUpdatingGroup";
			this.AutomaticUpdatingGroup.Size = new global::System.Drawing.Size(219, 117);
			this.AutomaticUpdatingGroup.TabIndex = 0;
			this.AutomaticUpdatingGroup.TabStop = false;
			this.AutomaticUpdatingGroup.Text = "Automatic Updating";
			this.DoNothingCheckBox.AutoSize = true;
			this.DoNothingCheckBox.Location = new global::System.Drawing.Point(6, 88);
			this.DoNothingCheckBox.Name = "DoNothingCheckBox";
			this.DoNothingCheckBox.Size = new global::System.Drawing.Size(183, 17);
			this.DoNothingCheckBox.TabIndex = 0;
			this.DoNothingCheckBox.TabStop = true;
			this.DoNothingCheckBox.Text = "Do nothing, manual updates only.";
			this.DoNothingCheckBox.UseVisualStyleBackColor = true;
			this.DoNothingCheckBox.CheckedChanged += new global::System.EventHandler(this.DoNothingCheckBox_CheckedChanged);
			this.DoNothingCheckBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.DoNothingCheckBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.NotifyAvailableCheckBox.AutoSize = true;
			this.NotifyAvailableCheckBox.Location = new global::System.Drawing.Point(6, 65);
			this.NotifyAvailableCheckBox.Name = "NotifyAvailableCheckBox";
			this.NotifyAvailableCheckBox.Size = new global::System.Drawing.Size(201, 17);
			this.NotifyAvailableCheckBox.TabIndex = 0;
			this.NotifyAvailableCheckBox.TabStop = true;
			this.NotifyAvailableCheckBox.Text = "Notify when downloads are available.";
			this.NotifyAvailableCheckBox.UseVisualStyleBackColor = true;
			this.NotifyAvailableCheckBox.CheckedChanged += new global::System.EventHandler(this.NotifyAvailableCheckBox_CheckedChanged);
			this.NotifyAvailableCheckBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.NotifyAvailableCheckBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.NotifyWhenDownloadedCheckBox.AutoSize = true;
			this.NotifyWhenDownloadedCheckBox.Location = new global::System.Drawing.Point(6, 42);
			this.NotifyWhenDownloadedCheckBox.Name = "NotifyWhenDownloadedCheckBox";
			this.NotifyWhenDownloadedCheckBox.Size = new global::System.Drawing.Size(204, 17);
			this.NotifyWhenDownloadedCheckBox.TabIndex = 0;
			this.NotifyWhenDownloadedCheckBox.TabStop = true;
			this.NotifyWhenDownloadedCheckBox.Text = "Notify when updates are downloaded.";
			this.NotifyWhenDownloadedCheckBox.UseVisualStyleBackColor = true;
			this.NotifyWhenDownloadedCheckBox.CheckedChanged += new global::System.EventHandler(this.NotifyWhenDownloadedCheckBox_CheckedChanged);
			this.NotifyWhenDownloadedCheckBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.NotifyWhenDownloadedCheckBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.AutomaticallyInstallCheckBox.AutoSize = true;
			this.AutomaticallyInstallCheckBox.Location = new global::System.Drawing.Point(6, 19);
			this.AutomaticallyInstallCheckBox.Name = "AutomaticallyInstallCheckBox";
			this.AutomaticallyInstallCheckBox.Size = new global::System.Drawing.Size(160, 17);
			this.AutomaticallyInstallCheckBox.TabIndex = 0;
			this.AutomaticallyInstallCheckBox.TabStop = true;
			this.AutomaticallyInstallCheckBox.Text = "Automatically install updates.";
			this.AutomaticallyInstallCheckBox.UseVisualStyleBackColor = true;
			this.AutomaticallyInstallCheckBox.CheckedChanged += new global::System.EventHandler(this.AutomaticallyInstallCheckBox_CheckedChanged);
			this.AutomaticallyInstallCheckBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.AutomaticallyInstallCheckBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.HotkeySetupTab.BackColor = global::System.Drawing.Color.White;
			this.HotkeySetupTab.Controls.Add(this.HotkeyOptions);
			this.HotkeySetupTab.Location = new global::System.Drawing.Point(4, 22);
			this.HotkeySetupTab.Name = "HotkeySetupTab";
			this.HotkeySetupTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.HotkeySetupTab.Size = new global::System.Drawing.Size(499, 305);
			this.HotkeySetupTab.TabIndex = 1;
			this.HotkeySetupTab.Text = "Hotkey Setup";
			this.folderBrowserDialog_0.RootFolder = global::System.Environment.SpecialFolder.MyComputer;
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(1, 364);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 23;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			this.label2.AutoSize = true;
			this.label2.Location = new global::System.Drawing.Point(11, 63);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(106, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Data Save Directory:";
			this.DataDirectoryTextBox.Location = new global::System.Drawing.Point(14, 80);
			this.DataDirectoryTextBox.Name = "DataDirectoryTextBox";
			this.DataDirectoryTextBox.ReadOnly = true;
			this.DataDirectoryTextBox.Size = new global::System.Drawing.Size(175, 20);
			this.DataDirectoryTextBox.TabIndex = 0;
			this.DataDirectoryTextBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.DataDirectoryTextBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.ViewDataDirectoryBtn.Location = new global::System.Drawing.Point(192, 78);
			this.ViewDataDirectoryBtn.Name = "ViewDataDirectoryBtn";
			this.ViewDataDirectoryBtn.Size = new global::System.Drawing.Size(63, 23);
			this.ViewDataDirectoryBtn.TabIndex = 3;
			this.ViewDataDirectoryBtn.Text = "View Files";
			this.ViewDataDirectoryBtn.UseVisualStyleBackColor = true;
			this.ViewDataDirectoryBtn.Click += new global::System.EventHandler(this.ViewDataDirectoryBtn_Click);
			this.ViewDataDirectoryBtn.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.ViewDataDirectoryBtn.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.ConcurrentDownloadsTextBox.IfZeroDisplayEmpty = false;
			this.ConcurrentDownloadsTextBox.Location = new global::System.Drawing.Point(14, 37);
			this.ConcurrentDownloadsTextBox.MaximumValue = 3;
			this.ConcurrentDownloadsTextBox.MinimumValue = 1;
			this.ConcurrentDownloadsTextBox.Name = "ConcurrentDownloadsTextBox";
			this.ConcurrentDownloadsTextBox.Size = new global::System.Drawing.Size(77, 20);
			this.ConcurrentDownloadsTextBox.TabIndex = 1;
			this.ConcurrentDownloadsTextBox.Text = "3";
			this.ConcurrentDownloadsTextBox.Value = 3;
			this.ConcurrentDownloadsTextBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.ConcurrentDownloadsTextBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.LocalPortBox.IfZeroDisplayEmpty = false;
			this.LocalPortBox.Location = new global::System.Drawing.Point(14, 37);
			this.LocalPortBox.MaximumValue = 65535;
			this.LocalPortBox.MinimumValue = 256;
			this.LocalPortBox.Name = "LocalPortBox";
			this.LocalPortBox.Size = new global::System.Drawing.Size(77, 20);
			this.LocalPortBox.TabIndex = 1;
			this.LocalPortBox.Text = "3000";
			this.LocalPortBox.Value = 3000;
			this.LocalPortBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.LocalPortBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.KeyToPressBox.Enabled = false;
			this.KeyToPressBox.Key = global::System.Windows.Forms.Keys.None;
			this.KeyToPressBox.Location = new global::System.Drawing.Point(102, 102);
			this.KeyToPressBox.Modifiers = global::System.Windows.Forms.Keys.None;
			this.KeyToPressBox.MultipleKeys = false;
			this.KeyToPressBox.Name = "KeyToPressBox";
			this.KeyToPressBox.Size = new global::System.Drawing.Size(120, 20);
			this.KeyToPressBox.TabIndex = 2;
			this.KeyToPressBox.Text = "None";
			this.KeyToPressBox.EnabledChanged += new global::System.EventHandler(this.KeyToPressBox_EnabledChanged);
			this.KeyToPressBox.TextChanged += new global::System.EventHandler(this.KeyToPressBox_TextChanged);
			this.KeyToPressBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.KeyToPressBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.KeyPressRepeatRateBox.Enabled = false;
			this.KeyPressRepeatRateBox.IfZeroDisplayEmpty = false;
			this.KeyPressRepeatRateBox.Location = new global::System.Drawing.Point(178, 126);
			this.KeyPressRepeatRateBox.MaximumValue = 99999999;
			this.KeyPressRepeatRateBox.MaxLength = 8;
			this.KeyPressRepeatRateBox.MinimumValue = 0;
			this.KeyPressRepeatRateBox.Name = "KeyPressRepeatRateBox";
			this.KeyPressRepeatRateBox.Size = new global::System.Drawing.Size(59, 20);
			this.KeyPressRepeatRateBox.TabIndex = 4;
			this.KeyPressRepeatRateBox.Value = 0;
			this.KeyPressRepeatRateBox.TextChanged += new global::System.EventHandler(this.KeyPressRepeatRateBox_TextChanged);
			this.KeyPressRepeatRateBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.KeyPressRepeatRateBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.KeyReleaseDelayBox.Enabled = false;
			this.KeyReleaseDelayBox.IfZeroDisplayEmpty = false;
			this.KeyReleaseDelayBox.Location = new global::System.Drawing.Point(158, 149);
			this.KeyReleaseDelayBox.MaximumValue = 99999999;
			this.KeyReleaseDelayBox.MaxLength = 8;
			this.KeyReleaseDelayBox.MinimumValue = 0;
			this.KeyReleaseDelayBox.Name = "KeyReleaseDelayBox";
			this.KeyReleaseDelayBox.Size = new global::System.Drawing.Size(59, 20);
			this.KeyReleaseDelayBox.TabIndex = 6;
			this.KeyReleaseDelayBox.Value = 0;
			this.KeyReleaseDelayBox.TextChanged += new global::System.EventHandler(this.KeyReleaseDelayBox_TextChanged);
			this.KeyReleaseDelayBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.KeyReleaseDelayBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.MoveMouseRateBox.Enabled = false;
			this.MoveMouseRateBox.IfZeroDisplayEmpty = false;
			this.MoveMouseRateBox.Location = new global::System.Drawing.Point(156, 172);
			this.MoveMouseRateBox.MaximumValue = 99999999;
			this.MoveMouseRateBox.MaxLength = 8;
			this.MoveMouseRateBox.MinimumValue = 0;
			this.MoveMouseRateBox.Name = "MoveMouseRateBox";
			this.MoveMouseRateBox.Size = new global::System.Drawing.Size(59, 20);
			this.MoveMouseRateBox.TabIndex = 8;
			this.MoveMouseRateBox.Value = 0;
			this.MoveMouseRateBox.TextChanged += new global::System.EventHandler(this.MoveMouseRateBox_TextChanged);
			this.MoveMouseRateBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.MoveMouseRateBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.HotkeyListBox.FormattingEnabled = true;
			this.HotkeyListBox.Location = new global::System.Drawing.Point(9, 46);
			this.HotkeyListBox.Name = "HotkeyListBox";
			this.HotkeyListBox.Size = new global::System.Drawing.Size(177, 212);
			this.HotkeyListBox.TabIndex = 3;
			this.HotkeyListBox.SelectedIndexChanged += new global::System.EventHandler(this.HotkeyListBox_SelectedIndexChanged);
			this.HotkeyListBox.DoubleClick += new global::System.EventHandler(this.HotkeyListBox_DoubleClick);
			this.HotkeyListBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.HotkeyListBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.HotkeyBox.Key = global::System.Windows.Forms.Keys.None;
			this.HotkeyBox.Location = new global::System.Drawing.Point(9, 20);
			this.HotkeyBox.Modifiers = global::System.Windows.Forms.Keys.None;
			this.HotkeyBox.MultipleKeys = true;
			this.HotkeyBox.Name = "HotkeyBox";
			this.HotkeyBox.Size = new global::System.Drawing.Size(120, 20);
			this.HotkeyBox.TabIndex = 0;
			this.HotkeyBox.Text = "None";
			this.HotkeyBox.TextChanged += new global::System.EventHandler(this.HotkeyBox_TextChanged);
			this.HotkeyBox.MouseEnter += new global::System.EventHandler(this.HotkeyBox_MouseEnter);
			this.HotkeyBox.MouseLeave += new global::System.EventHandler(this.HotkeyBox_MouseLeave);
			this.class343_0.ContractDistance = 2;
			this.class343_0.ContractedDelay = 2000;
			this.class343_0.ContractRate = 10;
			this.class343_0.ControlToSlide = this.OptionsLogo;
			this.class343_0.Enabled = false;
			this.class343_0.EndPosition = 305;
			this.class343_0.ExpandDistance = 6;
			this.class343_0.ExpandedDelay = 20000;
			this.class343_0.ExpandRate = 10;
			this.class343_0.RunOnce = true;
			this.class343_0.SlideDirection = global::ns19.Enum100.const_3;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(524, 401);
			base.Controls.Add(this.HowToOpenHelpLabel);
			base.Controls.Add(this.OptionsContainer);
			base.Controls.Add(this.OKButton);
			base.Controls.Add(this.OptionsStatus);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "Options";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer : Options";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.Options_FormClosed);
			base.Load += new global::System.EventHandler(this.Options_Load);
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.Options_HelpRequested);
			this.HotkeyOptions.ResumeLayout(false);
			this.HotkeyOptions.PerformLayout();
			this.HotkeyActionsPanel.ResumeLayout(false);
			this.HotkeyActionsPanel.PerformLayout();
			this.OptionsStatus.ResumeLayout(false);
			this.OptionsStatus.PerformLayout();
			this.OptionsContainer.ResumeLayout(false);
			this.ApplicationSettingsTab.ResumeLayout(false);
			this.ApplicationSettingsTab.PerformLayout();
			this.DownloadingSettings.ResumeLayout(false);
			this.DownloadingSettings.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.OptionsLogo).EndInit();
			this.ScreenshotSettingsGroup.ResumeLayout(false);
			this.ScreenshotSettingsGroup.PerformLayout();
			this.ContentSettingsGroup.ResumeLayout(false);
			this.ContentSettingsGroup.PerformLayout();
			this.AutomaticUpdatingGroup.ResumeLayout(false);
			this.AutomaticUpdatingGroup.PerformLayout();
			this.HotkeySetupTab.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04001432 RID: 5170
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04001433 RID: 5171
		private global::ns18.Class257 HotkeyBox;

		// Token: 0x04001434 RID: 5172
		private global::System.Windows.Forms.GroupBox HotkeyOptions;

		// Token: 0x04001435 RID: 5173
		private global::ns21.Class181 KeyPressRepeatRateBox;

		// Token: 0x04001436 RID: 5174
		private global::System.Windows.Forms.Button CancelHotkeyButton;

		// Token: 0x04001437 RID: 5175
		private global::System.Windows.Forms.Button AcceptHotkeyButton;

		// Token: 0x04001438 RID: 5176
		private global::ns31.Class293 HotkeyListBox;

		// Token: 0x04001439 RID: 5177
		private global::System.Windows.Forms.Label KeyToPressLabel;

		// Token: 0x0400143A RID: 5178
		private global::System.Windows.Forms.CheckBox ReleaseKeyCheckBox;

		// Token: 0x0400143B RID: 5179
		private global::System.Windows.Forms.CheckBox RepeatKeyPressCheckBox;

		// Token: 0x0400143C RID: 5180
		private global::System.Windows.Forms.CheckBox MoveMouseCheckBox;

		// Token: 0x0400143D RID: 5181
		private global::System.Windows.Forms.RadioButton PerformEventRadioButton;

		// Token: 0x0400143E RID: 5182
		private global::System.Windows.Forms.RadioButton TabToonTownWindowsRadioButton;

		// Token: 0x0400143F RID: 5183
		private global::System.Windows.Forms.CheckBox StopOtherHotkeysCheckBox;

		// Token: 0x04001440 RID: 5184
		private global::ns21.Class181 MoveMouseRateBox;

		// Token: 0x04001441 RID: 5185
		private global::ns21.Class181 KeyReleaseDelayBox;

		// Token: 0x04001442 RID: 5186
		private global::ns18.Class257 KeyToPressBox;

		// Token: 0x04001443 RID: 5187
		private global::System.Windows.Forms.Label lblProperties;

		// Token: 0x04001444 RID: 5188
		private global::System.Windows.Forms.TextBox HotkeyDescription;

		// Token: 0x04001445 RID: 5189
		private global::System.Windows.Forms.Button ResetHotkeys;

		// Token: 0x04001446 RID: 5190
		private global::System.Windows.Forms.Button RemoveHotkey;

		// Token: 0x04001447 RID: 5191
		private global::System.Windows.Forms.StatusStrip OptionsStatus;

		// Token: 0x04001448 RID: 5192
		private global::System.Windows.Forms.ToolStripStatusLabel StatusLabel;

		// Token: 0x04001449 RID: 5193
		private global::System.Windows.Forms.Label ReleaseKeyDelayLabel;

		// Token: 0x0400144A RID: 5194
		private global::System.Windows.Forms.Label RepeatKeyPressRateLabel;

		// Token: 0x0400144B RID: 5195
		private global::System.Windows.Forms.Label MoveMouseRateLabel;

		// Token: 0x0400144C RID: 5196
		private global::System.Windows.Forms.Panel HotkeyActionsPanel;

		// Token: 0x0400144D RID: 5197
		private global::System.Windows.Forms.Button OKButton;

		// Token: 0x0400144E RID: 5198
		private global::System.Windows.Forms.TabControl OptionsContainer;

		// Token: 0x0400144F RID: 5199
		private global::System.Windows.Forms.TabPage ApplicationSettingsTab;

		// Token: 0x04001450 RID: 5200
		private global::System.Windows.Forms.TabPage HotkeySetupTab;

		// Token: 0x04001451 RID: 5201
		private global::System.Windows.Forms.GroupBox AutomaticUpdatingGroup;

		// Token: 0x04001452 RID: 5202
		private global::System.Windows.Forms.RadioButton DoNothingCheckBox;

		// Token: 0x04001453 RID: 5203
		private global::System.Windows.Forms.RadioButton NotifyAvailableCheckBox;

		// Token: 0x04001454 RID: 5204
		private global::System.Windows.Forms.RadioButton NotifyWhenDownloadedCheckBox;

		// Token: 0x04001455 RID: 5205
		private global::System.Windows.Forms.RadioButton AutomaticallyInstallCheckBox;

		// Token: 0x04001456 RID: 5206
		private global::System.Windows.Forms.Label LocalPortLabel;

		// Token: 0x04001457 RID: 5207
		private global::ns21.Class181 LocalPortBox;

		// Token: 0x04001458 RID: 5208
		private global::System.Windows.Forms.GroupBox ScreenshotSettingsGroup;

		// Token: 0x04001459 RID: 5209
		private global::System.Windows.Forms.GroupBox ContentSettingsGroup;

		// Token: 0x0400145A RID: 5210
		private global::System.Windows.Forms.Button ViewScreenshotDirectory;

		// Token: 0x0400145B RID: 5211
		private global::System.Windows.Forms.Button BrowseForScreenshotDirectory;

		// Token: 0x0400145C RID: 5212
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400145D RID: 5213
		private global::System.Windows.Forms.TextBox ScreenshotDirectoryBox;

		// Token: 0x0400145E RID: 5214
		private global::System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_0;

		// Token: 0x0400145F RID: 5215
		private global::System.Windows.Forms.PictureBox OptionsLogo;

		// Token: 0x04001460 RID: 5216
		private global::ns22.Class343 class343_0;

		// Token: 0x04001461 RID: 5217
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;

		// Token: 0x04001462 RID: 5218
		private global::System.Windows.Forms.GroupBox DownloadingSettings;

		// Token: 0x04001463 RID: 5219
		private global::System.Windows.Forms.Label ConcurrentDownloadsLabel;

		// Token: 0x04001464 RID: 5220
		private global::ns21.Class181 ConcurrentDownloadsTextBox;

		// Token: 0x04001465 RID: 5221
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04001466 RID: 5222
		private global::System.Windows.Forms.Button ViewDataDirectoryBtn;

		// Token: 0x04001467 RID: 5223
		private global::System.Windows.Forms.TextBox DataDirectoryTextBox;
	}
}
