using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns14;
using ns16;
using ns19;
using ns20;
using ns21;
using ns23;
using ns24;
using ns27;
using ns31;

namespace ns17
{
	// Token: 0x02000264 RID: 612
	internal sealed partial class CustomizeEstatePlanting : Form
	{
		// Token: 0x06001A1E RID: 6686 RVA: 0x0004BF20 File Offset: 0x0004A120
		public CustomizeEstatePlanting(Class94 estate)
		{
			this.InitializeComponent();
			this.dictionary_0 = new Dictionary<GardeningFlowerSelector, Class93>();
			this.dictionary_1 = new Dictionary<GardenTreeSelector, Class109>();
			this.dictionary_2 = new Dictionary<PictureBox, GardeningFlowerSelector>();
			this.class94_0 = estate;
			this.HouseEstate.EstateHome = this.class94_0.HouseColor;
			this.dictionary_0.Add(this.FlowerBox0, this.class94_0.Flowers[Enum99.flag_5]);
			this.dictionary_0.Add(this.FlowerBox1, this.class94_0.Flowers[Enum99.flag_6]);
			this.dictionary_0.Add(this.FlowerBox2, this.class94_0.Flowers[Enum99.flag_7]);
			this.dictionary_0.Add(this.FlowerBox3, this.class94_0.Flowers[Enum99.flag_8]);
			this.dictionary_0.Add(this.FlowerBox4, this.class94_0.Flowers[Enum99.flag_9]);
			this.dictionary_0.Add(this.FlowerBox5, this.class94_0.Flowers[Enum99.flag_10]);
			this.dictionary_0.Add(this.FlowerBox6, this.class94_0.Flowers[Enum99.flag_11]);
			this.dictionary_0.Add(this.FlowerBox7, this.class94_0.Flowers[Enum99.flag_12]);
			this.dictionary_0.Add(this.FlowerBox8, this.class94_0.Flowers[Enum99.flag_13]);
			this.dictionary_0.Add(this.FlowerBox9, this.class94_0.Flowers[Enum99.flag_14]);
			this.dictionary_1.Add(this.TreeBox0, this.class94_0.Trees[Enum99.flag_15]);
			this.dictionary_1.Add(this.TreeBox1, this.class94_0.Trees[Enum99.flag_16]);
			this.dictionary_1.Add(this.TreeBox2, this.class94_0.Trees[Enum99.flag_17]);
			this.dictionary_1.Add(this.TreeBox3, this.class94_0.Trees[Enum99.flag_18]);
			this.dictionary_1.Add(this.TreeBox4, this.class94_0.Trees[Enum99.flag_19]);
			this.dictionary_1.Add(this.TreeBox5, this.class94_0.Trees[Enum99.flag_20]);
			this.dictionary_1.Add(this.TreeBox6, this.class94_0.Trees[Enum99.flag_21]);
			this.dictionary_1.Add(this.TreeBox7, this.class94_0.Trees[Enum99.flag_22]);
			this.dictionary_2.Add(this.FlowerIcon0, this.FlowerBox0);
			this.dictionary_2.Add(this.FlowerIcon1, this.FlowerBox1);
			this.dictionary_2.Add(this.FlowerIcon2, this.FlowerBox2);
			this.dictionary_2.Add(this.FlowerIcon3, this.FlowerBox3);
			this.dictionary_2.Add(this.FlowerIcon4, this.FlowerBox4);
			this.dictionary_2.Add(this.FlowerIcon5, this.FlowerBox5);
			this.dictionary_2.Add(this.FlowerIcon6, this.FlowerBox6);
			this.dictionary_2.Add(this.FlowerIcon7, this.FlowerBox7);
			this.dictionary_2.Add(this.FlowerIcon8, this.FlowerBox8);
			this.dictionary_2.Add(this.FlowerIcon9, this.FlowerBox9);
			foreach (KeyValuePair<GardenTreeSelector, Class109> keyValuePair in this.dictionary_1)
			{
				CustomizeEstatePlanting.smethod_1(keyValuePair.Key, keyValuePair.Value);
			}
			foreach (KeyValuePair<GardeningFlowerSelector, Class93> keyValuePair2 in this.dictionary_0)
			{
				CustomizeEstatePlanting.smethod_2(keyValuePair2.Key, keyValuePair2.Value);
			}
			this.method_0();
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0004C3A8 File Offset: 0x0004A5A8
		private void method_0()
		{
			switch (this.class94_0.HouseColor)
			{
			case Enum13.const_0:
				this.TreeBox0.Location = new Point(46, 238);
				this.TreeBox1.Location = new Point(12, 102);
				this.TreeBox2.Location = new Point(89, 135);
				this.TreeBox3.Location = new Point(226, 87);
				this.TreeBox4.Location = new Point(364, 157);
				this.TreeBox5.Location = new Point(432, 223);
				this.TreeBox6.Location = new Point(384, 297);
				this.TreeBox7.Location = new Point(323, 359);
				return;
			case Enum13.const_1:
				this.TreeBox0.Location = new Point(12, 381);
				this.TreeBox1.Location = new Point(47, 341);
				this.TreeBox2.Location = new Point(116, 303);
				this.TreeBox3.Location = new Point(12, 261);
				this.TreeBox4.Location = new Point(227, 88);
				this.TreeBox5.Location = new Point(255, 50);
				this.TreeBox6.Location = new Point(413, 67);
				this.TreeBox7.Location = new Point(389, 260);
				return;
			case Enum13.const_2:
				this.TreeBox0.Location = new Point(36, 361);
				this.TreeBox1.Location = new Point(94, 317);
				this.TreeBox2.Location = new Point(94, 107);
				this.TreeBox3.Location = new Point(36, 64);
				this.TreeBox4.Location = new Point(262, 77);
				this.TreeBox5.Location = new Point(338, 345);
				this.TreeBox6.Location = new Point(367, 304);
				this.TreeBox7.Location = new Point(435, 304);
				return;
			case Enum13.const_3:
				this.TreeBox0.Location = new Point(46, 261);
				this.TreeBox1.Location = new Point(12, 109);
				this.TreeBox2.Location = new Point(227, 64);
				this.TreeBox3.Location = new Point(297, 24);
				this.TreeBox4.Location = new Point(389, 191);
				this.TreeBox5.Location = new Point(419, 244);
				this.TreeBox6.Location = new Point(389, 297);
				this.TreeBox7.Location = new Point(351, 381);
				return;
			case Enum13.const_4:
				this.TreeBox0.Location = new Point(48, 297);
				this.TreeBox1.Location = new Point(12, 109);
				this.TreeBox2.Location = new Point(119, 61);
				this.TreeBox3.Location = new Point(255, 12);
				this.TreeBox4.Location = new Point(300, 88);
				this.TreeBox5.Location = new Point(341, 50);
				this.TreeBox6.Location = new Point(386, 12);
				this.TreeBox7.Location = new Point(435, 50);
				return;
			case Enum13.const_5:
				this.TreeBox0.Location = new Point(222, 382);
				this.TreeBox1.Location = new Point(33, 225);
				this.TreeBox2.Location = new Point(191, 88);
				this.TreeBox3.Location = new Point(259, 75);
				this.TreeBox4.Location = new Point(419, 124);
				this.TreeBox5.Location = new Point(432, 176);
				this.TreeBox6.Location = new Point(432, 327);
				this.TreeBox7.Location = new Point(351, 368);
				return;
			default:
				return;
			}
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x00009480 File Offset: 0x00007680
		private static void smethod_0(Class109 settings, GardenTreeSelector control)
		{
			settings.GardeningActions = control.GardeningActions;
			settings.WaterCount = control.WaterCount;
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0000949A File Offset: 0x0000769A
		private static void smethod_1(GardenTreeSelector control, Class109 settings)
		{
			control.GardeningActions = settings.GardeningActions;
			control.WaterCount = settings.WaterCount;
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x000094B4 File Offset: 0x000076B4
		private static void smethod_2(GardeningFlowerSelector control, Class93 settings)
		{
			control.FloraActions = settings.GardeningActions;
			control.BeanCombination = settings.BeanCombination;
			control.WaterCount = settings.WaterCount;
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x000094DA File Offset: 0x000076DA
		private static void smethod_3(Class93 settings, GardeningFlowerSelector control)
		{
			settings.GardeningActions = control.FloraActions;
			settings.BeanCombination = control.BeanCombination;
			settings.WaterCount = control.WaterCount;
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0004C858 File Offset: 0x0004AA58
		private void OKBtn_Click(object sender, EventArgs e)
		{
			foreach (KeyValuePair<GardenTreeSelector, Class109> keyValuePair in this.dictionary_1)
			{
				CustomizeEstatePlanting.smethod_0(keyValuePair.Value, keyValuePair.Key);
			}
			foreach (KeyValuePair<GardeningFlowerSelector, Class93> keyValuePair2 in this.dictionary_0)
			{
				CustomizeEstatePlanting.smethod_3(keyValuePair2.Value, keyValuePair2.Key);
			}
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0000587F File Offset: 0x00003A7F
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0004C914 File Offset: 0x0004AB14
		private void FlowerIcon6_Click(object sender, EventArgs e)
		{
			GardeningFlowerSelector gardeningFlowerSelector = this.dictionary_2[sender as PictureBox];
			gardeningFlowerSelector.FlowerEnabled = !gardeningFlowerSelector.FlowerEnabled;
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0004C944 File Offset: 0x0004AB44
		private void FlowerBox_Click(object sender, EventArgs e)
		{
			bool flag = false;
			foreach (GardeningFlowerSelector gardeningFlowerSelector in this.dictionary_0.Keys)
			{
				if (gardeningFlowerSelector.FlowerEnabled)
				{
					flag = true;
					break;
				}
			}
			foreach (GardeningFlowerSelector gardeningFlowerSelector2 in this.dictionary_0.Keys)
			{
				gardeningFlowerSelector2.FlowerEnabled = !flag;
			}
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0004C9F0 File Offset: 0x0004ABF0
		private void TreeBox_Click(object sender, EventArgs e)
		{
			bool flag = false;
			foreach (GardenTreeSelector gardenTreeSelector in this.dictionary_1.Keys)
			{
				if (gardenTreeSelector.TreeEnabled)
				{
					flag = true;
					break;
				}
			}
			foreach (GardenTreeSelector gardenTreeSelector2 in this.dictionary_1.Keys)
			{
				gardenTreeSelector2.TreeEnabled = !flag;
			}
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x00009500 File Offset: 0x00007700
		private void CustomizeEstatePlanting_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_19);
			e.Handled = true;
		}

		// Token: 0x040007BD RID: 1981
		private Class94 class94_0;

		// Token: 0x040007BE RID: 1982
		private Dictionary<GardeningFlowerSelector, Class93> dictionary_0;

		// Token: 0x040007BF RID: 1983
		private Dictionary<GardenTreeSelector, Class109> dictionary_1;

		// Token: 0x040007C0 RID: 1984
		private Dictionary<PictureBox, GardeningFlowerSelector> dictionary_2;
	}
}
