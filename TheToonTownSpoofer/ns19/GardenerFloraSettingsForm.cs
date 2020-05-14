using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns20;
using ns21;
using ns23;
using ns24;
using ns26;
using ns27;
using ns31;

namespace ns19
{
	// Token: 0x020003F3 RID: 1011
	internal sealed partial class GardenerFloraSettingsForm : Form
	{
		// Token: 0x060026B5 RID: 9909 RVA: 0x00089988 File Offset: 0x00087B88
		public GardenerFloraSettingsForm()
		{
			this.InitializeComponent();
			base.Icon = Class480.GenericSettings_Icon;
			Class105 gardenerFloraSettings = Class110.Instance.GardenerFloraSettings;
			this.ButtonClickDelayTextBox.Value = gardenerFloraSettings.ButtonClickDelay;
			this.AfterMoveBeforeClickDelayTextBox.Value = gardenerFloraSettings.AfterMoveBeforeClickDelay;
			this.MaxColorRangeTextBox.Value = gardenerFloraSettings.MaxColorRange;
			this.TargetRangeTextBox.Value = gardenerFloraSettings.TargetRange;
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000899FC File Offset: 0x00087BFC
		private void SaveBtn_Click(object sender, EventArgs e)
		{
			Class105 gardenerFloraSettings = Class110.Instance.GardenerFloraSettings;
			gardenerFloraSettings.ButtonClickDelay = this.ButtonClickDelayTextBox.Value;
			gardenerFloraSettings.AfterMoveBeforeClickDelay = this.AfterMoveBeforeClickDelayTextBox.Value;
			gardenerFloraSettings.MaxColorRange = this.MaxColorRangeTextBox.Value;
			gardenerFloraSettings.TargetRange = this.TargetRangeTextBox.Value;
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00006181 File Offset: 0x00004381
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x00089A60 File Offset: 0x00087C60
		private void ResetBtn_Click(object sender, EventArgs e)
		{
			this.ButtonClickDelayTextBox.Value = Class104.int_0;
			this.AfterMoveBeforeClickDelayTextBox.Value = Class104.int_1;
			this.MaxColorRangeTextBox.Value = Class105.int_5;
			this.TargetRangeTextBox.Value = Class104.float_0;
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x0001142B File Offset: 0x0000F62B
		private void GardenerFloraSettingsForm_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_24);
			e.Handled = true;
		}
	}
}
