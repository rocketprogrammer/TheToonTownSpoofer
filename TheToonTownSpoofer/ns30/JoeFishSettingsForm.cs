using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns19;
using ns20;
using ns21;
using ns23;
using ns24;
using ns26;
using ns27;
using ns31;

namespace ns30
{
	// Token: 0x020001DF RID: 479
	internal sealed partial class JoeFishSettingsForm : Form
	{
		// Token: 0x060015F2 RID: 5618 RVA: 0x00034340 File Offset: 0x00032540
		public JoeFishSettingsForm()
		{
			this.InitializeComponent();
			base.Icon = Class480.GenericSettings_Icon;
			Class106 joeFishSettings = Class110.Instance.JoeFishSettings;
			this.CastDragDelayTextBox.Value = joeFishSettings.CastDragDelay;
			this.AfterCastDelayTextBox.Value = joeFishSettings.AfterCastDelay;
			this.ButtonClickDelayTextBox.Value = joeFishSettings.ButtonClickDelay;
			this.AfterMoveBeforeClickDelayTextBox.Value = joeFishSettings.AfterMoveBeforeClickDelay;
			this.MaxColorRangeTextBox.Value = joeFishSettings.MaxColorRange;
			this.TargetRangeTextBox.Value = joeFishSettings.TargetRange;
			this.RequireStableFishTargetCheckBox.Checked = joeFishSettings.RequireStableTarget;
		}

		// Token: 0x060015F3 RID: 5619 RVA: 0x000343E8 File Offset: 0x000325E8
		private void SaveBtn_Click(object sender, EventArgs e)
		{
			Class106 joeFishSettings = Class110.Instance.JoeFishSettings;
			joeFishSettings.CastDragDelay = this.CastDragDelayTextBox.Value;
			joeFishSettings.AfterCastDelay = this.AfterCastDelayTextBox.Value;
			joeFishSettings.ButtonClickDelay = this.ButtonClickDelayTextBox.Value;
			joeFishSettings.AfterMoveBeforeClickDelay = this.AfterMoveBeforeClickDelayTextBox.Value;
			joeFishSettings.MaxColorRange = this.MaxColorRangeTextBox.Value;
			joeFishSettings.TargetRange = this.TargetRangeTextBox.Value;
			joeFishSettings.RequireStableTarget = this.RequireStableFishTargetCheckBox.Checked;
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x060015F4 RID: 5620 RVA: 0x0000587F File Offset: 0x00003A7F
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x060015F5 RID: 5621 RVA: 0x00034484 File Offset: 0x00032684
		private void ResetBtn_Click(object sender, EventArgs e)
		{
			this.CastDragDelayTextBox.Value = Class106.int_6;
			this.AfterCastDelayTextBox.Value = Class106.int_7;
			this.ButtonClickDelayTextBox.Value = Class104.int_0;
			this.AfterMoveBeforeClickDelayTextBox.Value = Class104.int_1;
			this.MaxColorRangeTextBox.Value = Class106.int_5;
			this.TargetRangeTextBox.Value = Class104.float_0;
			this.RequireStableFishTargetCheckBox.Checked = Class106.bool_1;
		}

		// Token: 0x060015F6 RID: 5622 RVA: 0x00006223 File Offset: 0x00004423
		private void JoeFishSettingsForm_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_23);
			e.Handled = true;
		}
	}
}
