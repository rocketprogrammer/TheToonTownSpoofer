using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ns14;
using ns17;
using ns18;
using ns19;
using ns21;
using ns22;
using ns23;
using ns26;
using ns27;
using ns28;
using ns29;
using ns31;

namespace ns20
{
	// Token: 0x02000425 RID: 1061
	internal sealed partial class Options : Form
	{
		// Token: 0x06002834 RID: 10292 RVA: 0x00094E58 File Offset: 0x00093058
		public Options()
		{
			this.InitializeComponent();
			base.Icon = Class480.GenericSettings_Icon;
			this.CancelHotkeyButton.Image = Class480.Cancel_16x16;
			this.AcceptHotkeyButton.Image = Class480.Checkmark_16x16;
			this.class112_0 = Class110.Instance.ApplicationSettings;
			this.class99_0 = Class110.Instance.ConnectSettings;
			this.DataDirectoryTextBox.Text = Class291.CommonApplicationDataDirectory;
			this.method_0();
			this.method_2(false);
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x00094EDC File Offset: 0x000930DC
		private void Options_Load(object sender, EventArgs e)
		{
			if (this.class112_0.HotkeysEnabled)
			{
				Class330.class205_0.method_1();
			}
			this.method_1();
			switch (this.class112_0.UpdateType)
			{
			case Enum78.const_0:
				this.AutomaticallyInstallCheckBox.Checked = true;
				break;
			case Enum78.const_1:
				this.NotifyWhenDownloadedCheckBox.Checked = true;
				break;
			case Enum78.const_2:
				this.NotifyAvailableCheckBox.Checked = true;
				break;
			case Enum78.const_3:
				this.DoNothingCheckBox.Checked = true;
				break;
			}
			this.LocalPortBox.Value = this.class99_0.PatchServerPort;
			this.ScreenshotDirectoryBox.Text = this.class112_0.ScreenshotSaveDirectory;
			this.ConcurrentDownloadsTextBox.Value = this.class99_0.MaximumSimultaneousDownloads;
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x00012374 File Offset: 0x00010574
		private void Options_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (this.class112_0.HotkeysEnabled)
			{
				Class330.class205_0.method_0();
			}
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00094FA4 File Offset: 0x000931A4
		private void HotkeyBox_MouseEnter(object sender, EventArgs e)
		{
			if (object.ReferenceEquals(this.HotkeyBox, sender))
			{
				this.StatusLabel.Text = "Press a combination of CTRL, SHIFT, ALT and/or a key to use to activate an action.";
				return;
			}
			if (object.ReferenceEquals(this.AcceptHotkeyButton, sender))
			{
				this.StatusLabel.Text = "Accepts the specified hotkey combination.";
				return;
			}
			if (object.ReferenceEquals(this.CancelHotkeyButton, sender))
			{
				this.StatusLabel.Text = "Cancels changes to the selected hotkey.";
				return;
			}
			if (object.ReferenceEquals(this.HotkeyListBox, sender))
			{
				this.StatusLabel.Text = "Select a hotkey to setup actions or double click to change the hotkey.";
				return;
			}
			if (object.ReferenceEquals(this.RemoveHotkey, sender))
			{
				this.StatusLabel.Text = "Removes the selected hotkey.";
				return;
			}
			if (object.ReferenceEquals(this.ResetHotkeys, sender))
			{
				this.StatusLabel.Text = "Removes all hotkeys and replaces them with initial defaults.";
				return;
			}
			if (object.ReferenceEquals(this.HotkeyDescription, sender))
			{
				this.StatusLabel.Text = "Describes the selected hotkey actions.";
				return;
			}
			if (object.ReferenceEquals(this.TabToonTownWindowsRadioButton, sender))
			{
				this.StatusLabel.Text = "Restores and activates the next ToonTown window that is open.";
				return;
			}
			if (object.ReferenceEquals(this.PerformEventRadioButton, sender))
			{
				this.StatusLabel.Text = "Performs an key and/or mouse event.";
				return;
			}
			if (object.ReferenceEquals(this.KeyToPressBox, sender))
			{
				this.StatusLabel.Text = "Enter a single key to be pressed.";
				return;
			}
			if (object.ReferenceEquals(this.RepeatKeyPressCheckBox, sender))
			{
				this.StatusLabel.Text = "Determines if the key will be repeatedly pressed.";
				return;
			}
			if (object.ReferenceEquals(this.RepeatKeyPressRateLabel, sender) || object.ReferenceEquals(this.KeyPressRepeatRateBox, sender))
			{
				this.StatusLabel.Text = "Determines the delay to wait before pressing the key again. (1000 = 1 second)";
				return;
			}
			if (object.ReferenceEquals(this.ReleaseKeyCheckBox, sender))
			{
				this.StatusLabel.Text = "Determines if the key should be released.";
				return;
			}
			if (object.ReferenceEquals(this.ReleaseKeyDelayLabel, sender) || object.ReferenceEquals(this.KeyReleaseDelayBox, sender))
			{
				this.StatusLabel.Text = "Determines the delay to wait before releasing the key. (1000 = 1 second)";
				return;
			}
			if (object.ReferenceEquals(this.MoveMouseCheckBox, sender))
			{
				this.StatusLabel.Text = "Determines if the mouse should be slightly moved.";
				return;
			}
			if (object.ReferenceEquals(this.MoveMouseRateLabel, sender) || object.ReferenceEquals(this.MoveMouseRateBox, sender))
			{
				this.StatusLabel.Text = "Determines the rate at which to slightly move the mouse. (1000 = 1 second)";
				return;
			}
			if (object.ReferenceEquals(this.StopOtherHotkeysCheckBox, sender))
			{
				this.StatusLabel.Text = "Determines if all other active actions will be suspended for the current window.";
				return;
			}
			if (object.ReferenceEquals(this.AutomaticallyInstallCheckBox, sender))
			{
				this.StatusLabel.Text = "The ToonTown Spoofer will check for updates, download and install automatically.";
				return;
			}
			if (object.ReferenceEquals(this.NotifyWhenDownloadedCheckBox, sender))
			{
				this.StatusLabel.Text = "The ToonTown Spoofer will check and download updates automatically, then prompt to install.";
				return;
			}
			if (object.ReferenceEquals(this.NotifyAvailableCheckBox, sender))
			{
				this.StatusLabel.Text = "The ToonTown Spoofer will check for updates and notify if there is a new version available.";
				return;
			}
			if (object.ReferenceEquals(this.DoNothingCheckBox, sender))
			{
				this.StatusLabel.Text = "The ToonTown Spoofer will only check for updates manually.";
				return;
			}
			if (object.ReferenceEquals(this.LocalPortBox, sender))
			{
				this.StatusLabel.Text = "The ToonTown Spoofer requires a port to listen on to allow content packs to install.";
				return;
			}
			if (object.ReferenceEquals(this.ScreenshotDirectoryBox, sender))
			{
				this.StatusLabel.Text = "The directory in which screenshots will be saved from ToonTown.";
				return;
			}
			if (object.ReferenceEquals(this.ViewScreenshotDirectory, sender))
			{
				this.StatusLabel.Text = "Open the screenshot directory in Explorer to view the files. (You can also use My Gallery)";
				return;
			}
			if (object.ReferenceEquals(this.ViewDataDirectoryBtn, sender))
			{
				this.StatusLabel.Text = "Open The ToonTown Spoofer's data directory in Explorer to view the files.";
				return;
			}
			if (object.ReferenceEquals(this.DataDirectoryTextBox, sender))
			{
				this.StatusLabel.Text = "The data directory where data files are saved.";
				return;
			}
			if (object.ReferenceEquals(this.BrowseForScreenshotDirectory, sender))
			{
				this.StatusLabel.Text = "Browse and select a new directory to save screenshots inside.";
				return;
			}
			if (object.ReferenceEquals(this.OKButton, sender))
			{
				this.StatusLabel.Text = "Closes the options window.";
				return;
			}
			if (object.ReferenceEquals(this.OptionsLogo, sender))
			{
				this.StatusLabel.Text = "Please change an option!";
				return;
			}
			if (object.ReferenceEquals(this.ConcurrentDownloadsTextBox, sender))
			{
				this.StatusLabel.Text = "The number of simultaneous downloads. If you have network trouble, set this to a lower value.";
			}
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x0001238D File Offset: 0x0001058D
		private void HotkeyBox_MouseLeave(object sender, EventArgs e)
		{
			this.method_0();
			this.int_0 = 0;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0001239C File Offset: 0x0001059C
		private void method_0()
		{
			this.StatusLabel.Text = "Place your mouse over an object for help.";
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00095390 File Offset: 0x00093590
		private void method_1()
		{
			this.HotkeyListBox.Items.Clear();
			foreach (Struct21 @struct in this.class112_0.Hotkeys.Keys)
			{
				this.HotkeyListBox.Items.Add(@struct);
			}
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000123AE File Offset: 0x000105AE
		private void method_2(bool enable)
		{
			this.KeyToPressLabel.Enabled = enable;
			this.KeyToPressBox.Enabled = enable;
			this.MoveMouseCheckBox.Enabled = enable;
			this.StopOtherHotkeysCheckBox.Enabled = enable;
			this.KeyToPressBox.Enabled = enable;
		}

		// Token: 0x0600283C RID: 10300 RVA: 0x00095410 File Offset: 0x00093610
		private void HotkeyListBox_DoubleClick(object sender, EventArgs e)
		{
			if (this.HotkeyListBox.SelectedItem != null)
			{
				Struct21 hotkey = (Struct21)this.HotkeyListBox.SelectedItem;
				this.bool_0 = true;
				this.HotkeyBox.Hotkey = hotkey;
				this.HotkeyListBox.Enabled = false;
				this.CancelHotkeyButton.Enabled = true;
				this.RemoveHotkey.Enabled = false;
				this.ResetHotkeys.Enabled = false;
			}
		}

		// Token: 0x0600283D RID: 10301 RVA: 0x000123EC File Offset: 0x000105EC
		private void HotkeyBox_TextChanged(object sender, EventArgs e)
		{
			this.AcceptHotkeyButton.Enabled = (this.HotkeyBox.Key != Keys.None || this.HotkeyBox.Modifiers != Keys.None);
		}

		// Token: 0x0600283E RID: 10302 RVA: 0x00095480 File Offset: 0x00093680
		private void AcceptHotkeyButton_Click(object sender, EventArgs e)
		{
			Struct21 hotkey = this.HotkeyBox.Hotkey;
			if (this.method_3(hotkey))
			{
				if (this.bool_0)
				{
					Struct21 key = (Struct21)this.HotkeyListBox.SelectedItem;
					Class87 @class = this.class112_0.Hotkeys[key];
					this.class112_0.Hotkeys.Remove(key);
					@class.Hotkey = hotkey;
					this.class112_0.Hotkeys.Add(hotkey, @class);
					this.HotkeyListBox.Enabled = true;
					this.HotkeyListBox.Items[this.HotkeyListBox.SelectedIndex] = hotkey;
					this.HotkeyListBox.imethod_0(this.HotkeyListBox.SelectedIndex);
					this.HotkeyBox.Hotkey = default(Struct21);
					this.CancelHotkeyButton.Enabled = false;
					this.RemoveHotkey.Enabled = true;
					this.ResetHotkeys.Enabled = true;
					this.bool_0 = false;
					return;
				}
				if (this.HotkeyListBox.Items.Contains(hotkey))
				{
					DialogBox.smethod_3("The specified hotkey already exists. Please select an alternative hotkey combination.", "Hotkey Already Exists");
					return;
				}
				Class87 class2 = new Class87();
				class2.Hotkey = hotkey;
				this.class112_0.Hotkeys.Add(hotkey, class2);
				this.HotkeyListBox.Items.Add(hotkey);
				this.HotkeyListBox.SelectedItem = hotkey;
				this.HotkeyBox.Hotkey = default(Struct21);
			}
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x00095608 File Offset: 0x00093808
		private bool method_3(Struct21 hotkey)
		{
			if (hotkey.Key != Keys.Escape)
			{
				if (hotkey.Key == Keys.Oemplus)
				{
					if (hotkey.Modifier == Keys.Control)
					{
						goto IL_7B;
					}
					if (hotkey.Modifier == (Keys.Shift | Keys.Control))
					{
						goto IL_7B;
					}
				}
				if (!Class265.RegisterHotKey(base.Handle, 49151, hotkey.NativeModifier, hotkey.Key))
				{
					DialogBox.smethod_4("It appears the specified hotkey is already in use by another application or Windows. Please select an alternative hotkey combination.", "Hotkey in Use");
					return false;
				}
				Class265.UnregisterHotKey(base.Handle, 49151);
				return true;
			}
			IL_7B:
			DialogBox.smethod_3("This hotkey combination cannot be used due to The ToonTown Spoofer using it for other purposes.", "Hotkey In Use");
			return false;
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x000956A0 File Offset: 0x000938A0
		private void CancelHotkeyButton_Click(object sender, EventArgs e)
		{
			this.HotkeyBox.Hotkey = default(Struct21);
			this.HotkeyListBox.Enabled = true;
			this.CancelHotkeyButton.Enabled = false;
			this.RemoveHotkey.Enabled = true;
			this.ResetHotkeys.Enabled = true;
			this.bool_0 = false;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x000956F8 File Offset: 0x000938F8
		private void HotkeyListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			bool flag = this.HotkeyListBox.SelectedItem != null;
			this.TabToonTownWindowsRadioButton.Enabled = flag;
			this.PerformEventRadioButton.Enabled = flag;
			this.HotkeyDescription.Enabled = flag;
			this.RemoveHotkey.Enabled = (flag && !this.bool_0);
			if (flag)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				this.PerformEventRadioButton.Checked = (@class.HotkeyType == Enum40.const_0);
				this.TabToonTownWindowsRadioButton.Checked = (@class.HotkeyType == Enum40.const_1);
				if (@class.KeyToPress.HasFlag(Keys.Control))
				{
					this.KeyToPressBox.Hotkey = new Struct21(Keys.None, Keys.Control);
				}
				else if (@class.KeyToPress.HasFlag(Keys.Alt))
				{
					this.KeyToPressBox.Hotkey = new Struct21(Keys.None, Keys.Alt);
				}
				else if (@class.KeyToPress.HasFlag(Keys.Shift))
				{
					this.KeyToPressBox.Hotkey = new Struct21(Keys.None, Keys.Shift);
				}
				else
				{
					this.KeyToPressBox.Hotkey = new Struct21(@class.KeyToPress, Keys.None);
				}
				this.MoveMouseRateBox.Value = @class.MoveMouseRate;
				this.KeyPressRepeatRateBox.Value = @class.KeyPressRepeatRate;
				this.KeyReleaseDelayBox.Value = @class.KeyReleaseDelay;
				this.MoveMouseCheckBox.Checked = @class.MoveMouse;
				this.ReleaseKeyCheckBox.Checked = @class.ReleaseKey;
				this.RepeatKeyPressCheckBox.Checked = @class.RepeatKeyPress;
				this.StopOtherHotkeysCheckBox.Checked = @class.StopOtherHotkeys;
				this.HotkeyDescription.Text = @class.Description;
				this.method_2(@class.HotkeyType == Enum40.const_0);
				return;
			}
			this.method_2(false);
			this.PerformEventRadioButton.Checked = false;
			this.TabToonTownWindowsRadioButton.Checked = false;
			this.KeyToPressBox.Hotkey = default(Struct21);
			this.MoveMouseRateBox.Value = 0;
			this.KeyPressRepeatRateBox.Value = 0;
			this.KeyReleaseDelayBox.Value = 0;
			this.MoveMouseCheckBox.Checked = false;
			this.ReleaseKeyCheckBox.Checked = false;
			this.RepeatKeyPressCheckBox.Checked = false;
			this.StopOtherHotkeysCheckBox.Checked = false;
			this.HotkeyDescription.Text = string.Empty;
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x00095988 File Offset: 0x00093B88
		private void TabToonTownWindowsRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.HotkeyListBox.SelectedItem != null && this.TabToonTownWindowsRadioButton.Checked)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.HotkeyType = Enum40.const_1;
				this.method_2(false);
			}
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x000959E0 File Offset: 0x00093BE0
		private void PerformEventRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			if (this.HotkeyListBox.SelectedItem != null && this.PerformEventRadioButton.Checked)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.HotkeyType = Enum40.const_0;
				this.method_2(true);
			}
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x00095A38 File Offset: 0x00093C38
		private void RepeatKeyPressCheckBox_EnabledChanged(object sender, EventArgs e)
		{
			if (this.RepeatKeyPressCheckBox.Enabled && this.RepeatKeyPressCheckBox.Checked)
			{
				Control repeatKeyPressRateLabel = this.RepeatKeyPressRateLabel;
				this.KeyPressRepeatRateBox.Enabled = true;
				repeatKeyPressRateLabel.Enabled = true;
				return;
			}
			Control repeatKeyPressRateLabel2 = this.RepeatKeyPressRateLabel;
			this.KeyPressRepeatRateBox.Enabled = false;
			repeatKeyPressRateLabel2.Enabled = false;
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x00095A90 File Offset: 0x00093C90
		private void ReleaseKeyCheckBox_EnabledChanged(object sender, EventArgs e)
		{
			if (this.ReleaseKeyCheckBox.Enabled && this.ReleaseKeyCheckBox.Checked)
			{
				Control releaseKeyDelayLabel = this.ReleaseKeyDelayLabel;
				this.KeyReleaseDelayBox.Enabled = true;
				releaseKeyDelayLabel.Enabled = true;
				return;
			}
			Control releaseKeyDelayLabel2 = this.ReleaseKeyDelayLabel;
			this.KeyReleaseDelayBox.Enabled = false;
			releaseKeyDelayLabel2.Enabled = false;
		}

		// Token: 0x06002846 RID: 10310 RVA: 0x00095AE8 File Offset: 0x00093CE8
		private void ReleaseKeyCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.KeyReleaseDelayBox.Enabled = (this.ReleaseKeyDelayLabel.Enabled = (this.ReleaseKeyCheckBox.Checked && this.ReleaseKeyCheckBox.Enabled));
			if (this.ReleaseKeyCheckBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.ReleaseKey = this.ReleaseKeyCheckBox.Checked;
			}
		}

		// Token: 0x06002847 RID: 10311 RVA: 0x00095B68 File Offset: 0x00093D68
		private void MoveMouseCheckBox_EnabledChanged(object sender, EventArgs e)
		{
			if (this.MoveMouseCheckBox.Enabled && this.MoveMouseCheckBox.Checked)
			{
				Control moveMouseRateLabel = this.MoveMouseRateLabel;
				this.MoveMouseRateBox.Enabled = true;
				moveMouseRateLabel.Enabled = true;
				return;
			}
			Control moveMouseRateLabel2 = this.MoveMouseRateLabel;
			this.MoveMouseRateBox.Enabled = false;
			moveMouseRateLabel2.Enabled = false;
		}

		// Token: 0x06002848 RID: 10312 RVA: 0x00095BC0 File Offset: 0x00093DC0
		private void RepeatKeyPressCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.KeyPressRepeatRateBox.Enabled = (this.RepeatKeyPressRateLabel.Enabled = (this.RepeatKeyPressCheckBox.Checked && this.RepeatKeyPressCheckBox.Enabled));
			if (this.RepeatKeyPressCheckBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.RepeatKeyPress = this.RepeatKeyPressCheckBox.Checked;
			}
		}

		// Token: 0x06002849 RID: 10313 RVA: 0x00095C40 File Offset: 0x00093E40
		private void MoveMouseCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.MoveMouseRateBox.Enabled = (this.MoveMouseRateLabel.Enabled = (this.MoveMouseCheckBox.Checked && this.MoveMouseCheckBox.Enabled));
			if (this.MoveMouseCheckBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.MoveMouse = this.MoveMouseCheckBox.Checked;
			}
		}

		// Token: 0x0600284A RID: 10314 RVA: 0x00095CC0 File Offset: 0x00093EC0
		private void KeyPressRepeatRateBox_TextChanged(object sender, EventArgs e)
		{
			if (this.KeyPressRepeatRateBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.KeyPressRepeatRate = this.KeyPressRepeatRateBox.Value;
			}
		}

		// Token: 0x0600284B RID: 10315 RVA: 0x00095D0C File Offset: 0x00093F0C
		private void KeyReleaseDelayBox_TextChanged(object sender, EventArgs e)
		{
			if (this.KeyReleaseDelayBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.KeyReleaseDelay = this.KeyReleaseDelayBox.Value;
			}
		}

		// Token: 0x0600284C RID: 10316 RVA: 0x00095D58 File Offset: 0x00093F58
		private void MoveMouseRateBox_TextChanged(object sender, EventArgs e)
		{
			if (this.MoveMouseRateBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.MoveMouseRate = this.MoveMouseRateBox.Value;
			}
		}

		// Token: 0x0600284D RID: 10317 RVA: 0x00095DA4 File Offset: 0x00093FA4
		private void KeyToPressBox_TextChanged(object sender, EventArgs e)
		{
			if (this.KeyToPressBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				if (this.KeyToPressBox.Modifiers == Keys.None)
				{
					@class.KeyToPress = this.KeyToPressBox.Key;
				}
				else if (this.KeyToPressBox.Modifiers.HasFlag(Keys.Control))
				{
					@class.KeyToPress = Keys.Control;
				}
				else if (this.KeyToPressBox.Modifiers.HasFlag(Keys.Alt))
				{
					@class.KeyToPress = Keys.Alt;
				}
				else if (this.KeyToPressBox.Modifiers.HasFlag(Keys.Shift))
				{
					@class.KeyToPress = Keys.Shift;
				}
				else
				{
					@class.KeyToPress = this.KeyToPressBox.Key;
				}
			}
			this.method_4();
		}

		// Token: 0x0600284E RID: 10318 RVA: 0x0001241A File Offset: 0x0001061A
		private void KeyToPressBox_EnabledChanged(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x00095EA8 File Offset: 0x000940A8
		private void method_4()
		{
			if (this.KeyToPressBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				this.ReleaseKeyCheckBox.Enabled = (this.RepeatKeyPressCheckBox.Enabled = (@class.KeyToPress != Keys.None && @class.HotkeyType == Enum40.const_0));
				return;
			}
			Control releaseKeyCheckBox = this.ReleaseKeyCheckBox;
			this.RepeatKeyPressCheckBox.Enabled = false;
			releaseKeyCheckBox.Enabled = false;
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x00095F2C File Offset: 0x0009412C
		private void StopOtherHotkeysCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.StopOtherHotkeysCheckBox.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.StopOtherHotkeys = this.StopOtherHotkeysCheckBox.Checked;
			}
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x00095F78 File Offset: 0x00094178
		private void HotkeyDescription_TextChanged(object sender, EventArgs e)
		{
			if (this.HotkeyDescription.Enabled)
			{
				Class87 @class = this.class112_0.Hotkeys[(Struct21)this.HotkeyListBox.SelectedItem];
				@class.Description = this.HotkeyDescription.Text;
			}
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x00012422 File Offset: 0x00010622
		private void RemoveHotkey_Click(object sender, EventArgs e)
		{
			this.class112_0.Hotkeys.Remove((Struct21)this.HotkeyListBox.SelectedItem);
			this.HotkeyListBox.Items.RemoveAt(this.HotkeyListBox.SelectedIndex);
		}

		// Token: 0x06002853 RID: 10323 RVA: 0x00012460 File Offset: 0x00010660
		private void ResetHotkeys_Click(object sender, EventArgs e)
		{
			this.HotkeyListBox.SelectedIndex = -1;
			this.class112_0.method_4();
			this.method_1();
		}

		// Token: 0x06002854 RID: 10324 RVA: 0x0001247F File Offset: 0x0001067F
		private void AutomaticallyInstallCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.AutomaticallyInstallCheckBox.Checked)
			{
				this.class112_0.UpdateType = Enum78.const_0;
			}
		}

		// Token: 0x06002855 RID: 10325 RVA: 0x0001249A File Offset: 0x0001069A
		private void NotifyWhenDownloadedCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NotifyWhenDownloadedCheckBox.Checked)
			{
				this.class112_0.UpdateType = Enum78.const_1;
			}
		}

		// Token: 0x06002856 RID: 10326 RVA: 0x000124B5 File Offset: 0x000106B5
		private void NotifyAvailableCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.NotifyAvailableCheckBox.Checked)
			{
				this.class112_0.UpdateType = Enum78.const_2;
			}
		}

		// Token: 0x06002857 RID: 10327 RVA: 0x000124D0 File Offset: 0x000106D0
		private void DoNothingCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.DoNothingCheckBox.Checked)
			{
				this.class112_0.UpdateType = Enum78.const_3;
			}
		}

		// Token: 0x06002858 RID: 10328 RVA: 0x000050D4 File Offset: 0x000032D4
		private void OKButton_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06002859 RID: 10329 RVA: 0x00095FC4 File Offset: 0x000941C4
		private void Options_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.LocalPortBox.Value != this.class99_0.PatchServerPort)
			{
				if (Class509.CanChangeVirtualServerPort)
				{
					this.class99_0.PatchServerPort = this.LocalPortBox.Value;
				}
				else
				{
					this.LocalPortBox.Value = this.class99_0.PatchServerPort;
				}
			}
			this.class99_0.MaximumSimultaneousDownloads = this.ConcurrentDownloadsTextBox.Value;
		}

		// Token: 0x0600285A RID: 10330 RVA: 0x000124EB File Offset: 0x000106EB
		private void ViewDataDirectoryBtn_Click(object sender, EventArgs e)
		{
			Class512.smethod_0(Class291.CommonApplicationDataDirectory);
		}

		// Token: 0x0600285B RID: 10331 RVA: 0x00096034 File Offset: 0x00094234
		private void BrowseForScreenshotDirectory_Click(object sender, EventArgs e)
		{
			if (Class509.CanChangeScreenshotDirectory)
			{
				this.folderBrowserDialog_0.SelectedPath = this.class112_0.ScreenshotSaveDirectory;
				if (this.folderBrowserDialog_0.ShowDialog() == DialogResult.OK)
				{
					string screenshotSaveDirectory = this.class112_0.ScreenshotSaveDirectory;
					string selectedPath = this.folderBrowserDialog_0.SelectedPath;
					if (!string.IsNullOrEmpty(screenshotSaveDirectory) && Directory.Exists(screenshotSaveDirectory))
					{
						string[] array = Class234.smethod_1(screenshotSaveDirectory, "*.jpg", ".jpg");
						if (array.Length > 0)
						{
							DialogResult dialogResult = DialogBox.smethod_6("Would you like to move your existing screenshots to the new directory?", "Migrate Screenshots", new Enum39[]
							{
								Enum39.const_5,
								Enum39.const_6,
								Enum39.const_1
							});
							DialogResult dialogResult2 = dialogResult;
							if (dialogResult2 == DialogResult.Cancel)
							{
								return;
							}
							switch (dialogResult2)
							{
							case DialogResult.Yes:
								Class356.smethod_0(array, selectedPath);
								break;
							}
						}
					}
					this.class112_0.ScreenshotSaveDirectory = selectedPath;
					this.ScreenshotDirectoryBox.Text = selectedPath;
				}
			}
		}

		// Token: 0x0600285C RID: 10332 RVA: 0x000124F7 File Offset: 0x000106F7
		private void ViewScreenshotDirectory_Click(object sender, EventArgs e)
		{
			Class512.smethod_0(this.class112_0.ScreenshotSaveDirectory);
		}

		// Token: 0x0600285D RID: 10333 RVA: 0x00096118 File Offset: 0x00094318
		private void OptionsLogo_Click(object sender, EventArgs e)
		{
			switch (this.int_0)
			{
			case 0:
				this.StatusLabel.Text = "You clicked on me!";
				break;
			case 1:
				this.StatusLabel.Text = "I'm not an option!";
				break;
			case 2:
				this.StatusLabel.Text = "I'm ignoring you!";
				break;
			case 3:
				this.StatusLabel.Text = "*** Whistles ***";
				break;
			case 6:
				this.StatusLabel.Text = "ARGGHHHHHH!";
				this.class343_0.Enabled = true;
				break;
			}
			this.int_0++;
		}

		// Token: 0x0600285E RID: 10334 RVA: 0x00012509 File Offset: 0x00010709
		private void Options_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_9);
			e.Handled = true;
		}

		// Token: 0x0400142E RID: 5166
		private Class112 class112_0;

		// Token: 0x0400142F RID: 5167
		private bool bool_0;

		// Token: 0x04001430 RID: 5168
		private Class99 class99_0;

		// Token: 0x04001431 RID: 5169
		private int int_0;
	}
}
