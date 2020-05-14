using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns20;
using ns23;
using ns25;
using ns26;
using ns29;
using ns31;
using TSN.Controls;

namespace ns14
{
	// Token: 0x020001CF RID: 463
	internal sealed partial class BeanCombinations : Form
	{
		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0002B574 File Offset: 0x00029774
		// (set) Token: 0x06001508 RID: 5384 RVA: 0x0002B5DC File Offset: 0x000297DC
		public List<Class322> CheckedBeanCombinations
		{
			get
			{
				IEnumerable<ListViewItemState<Class322>> source = this.BeanCombinationsListView.Items.OfType<ListViewItemState<Class322>>();
				if (BeanCombinations.func_0 == null)
				{
					BeanCombinations.func_0 = new Func<ListViewItemState<Class322>, bool>(BeanCombinations.smethod_0);
				}
				IEnumerable<ListViewItemState<Class322>> source2 = source.Where(BeanCombinations.func_0);
				if (BeanCombinations.func_1 == null)
				{
					BeanCombinations.func_1 = new Func<ListViewItemState<Class322>, Class322>(BeanCombinations.smethod_1);
				}
				return source2.Select(BeanCombinations.func_1).ToList<Class322>();
			}
			set
			{
				BeanCombinations.Class83 @class = new BeanCombinations.Class83();
				@class.list_0 = value;
				this.BeanCombinationsListView.Items.OfType<ListViewItemState<Class322>>().smethod_7(new Action<ListViewItemState<Class322>>(@class.method_0));
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x00005829 File Offset: 0x00003A29
		// (set) Token: 0x0600150A RID: 5386 RVA: 0x0002B618 File Offset: 0x00029818
		public Enum115 PlantMethod
		{
			get
			{
				if (this.PlantSequentialCheckBox.Checked)
				{
					return Enum115.const_2;
				}
				if (this.PlantRandomCheckBox.Checked)
				{
					return Enum115.const_1;
				}
				return Enum115.const_0;
			}
			set
			{
				value.smethod_0();
				switch (value)
				{
				case Enum115.const_0:
					this.PlantSequentialCheckBox.Checked = false;
					this.PlantRandomCheckBox.Checked = false;
					this.AutoPlantCheckBox.Checked = true;
					return;
				case Enum115.const_1:
					this.PlantSequentialCheckBox.Checked = false;
					this.PlantRandomCheckBox.Checked = true;
					this.AutoPlantCheckBox.Checked = false;
					return;
				case Enum115.const_2:
					this.PlantRandomCheckBox.Checked = false;
					this.PlantSequentialCheckBox.Checked = true;
					this.AutoPlantCheckBox.Checked = false;
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0000584A File Offset: 0x00003A4A
		public BeanCombinations()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x00005858 File Offset: 0x00003A58
		private void AutoSelectComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.BeanCombinationsListView.method_1(this.AutoSelectComboBox.SelectedIndex);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0002B6B4 File Offset: 0x000298B4
		private void AutoPlantCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.AutoSelectComboBox.Enabled = (this.BeanCombinationsListView.Enabled = !this.AutoPlantCheckBox.Checked);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x00005870 File Offset: 0x00003A70
		private void btnOK_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0000587F File Offset: 0x00003A7F
		private void btnCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0000588E File Offset: 0x00003A8E
		private void BeanCombinations_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_20);
			e.Handled = true;
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0000589E File Offset: 0x00003A9E
		[CompilerGenerated]
		private static bool smethod_0(ListViewItemState<Class322> item)
		{
			return item.Checked;
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x000058A6 File Offset: 0x00003AA6
		[CompilerGenerated]
		private static Class322 smethod_1(ListViewItemState<Class322> item)
		{
			return item.State;
		}

		// Token: 0x040002A2 RID: 674
		[CompilerGenerated]
		private static Func<ListViewItemState<Class322>, bool> func_0;

		// Token: 0x040002A3 RID: 675
		[CompilerGenerated]
		private static Func<ListViewItemState<Class322>, Class322> func_1;

		// Token: 0x020001D0 RID: 464
		[CompilerGenerated]
		private sealed class Class83
		{
			// Token: 0x06001514 RID: 5396 RVA: 0x000058AE File Offset: 0x00003AAE
			public void method_0(ListViewItemState<Class322> item)
			{
				item.Checked = this.list_0.Contains(item.State);
			}

			// Token: 0x040002A4 RID: 676
			public List<Class322> list_0;
		}
	}
}
