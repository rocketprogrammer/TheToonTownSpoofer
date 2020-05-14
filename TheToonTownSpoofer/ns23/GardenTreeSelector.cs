using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns21;
using ns25;

namespace ns23
{
	// Token: 0x02000390 RID: 912
	internal sealed class GardenTreeSelector : UserControl
	{
		// Token: 0x0600239E RID: 9118 RVA: 0x0000F43F File Offset: 0x0000D63F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600239F RID: 9119 RVA: 0x0007870C File Offset: 0x0007690C
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GardenTreeSelector));
			this.TreePictureBox = new PictureBox();
			this.WaterTreeCheckBox = new CheckBox();
			this.TreeNumberLabel = new Label();
			this.OpenSetupLink = new LinkLabel();
			((ISupportInitialize)this.TreePictureBox).BeginInit();
			base.SuspendLayout();
			this.TreePictureBox.Image = (Image)componentResourceManager.GetObject("TreePictureBox.Image");
			this.TreePictureBox.Location = new Point(0, 0);
			this.TreePictureBox.Name = "TreePictureBox";
			this.TreePictureBox.Size = new Size(32, 32);
			this.TreePictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
			this.TreePictureBox.TabIndex = 0;
			this.TreePictureBox.TabStop = false;
			this.TreePictureBox.Click += this.TreeNumberLabel_Click;
			this.WaterTreeCheckBox.AutoSize = true;
			this.WaterTreeCheckBox.Location = new Point(44, 4);
			this.WaterTreeCheckBox.Name = "WaterTreeCheckBox";
			this.WaterTreeCheckBox.Size = new Size(15, 14);
			this.WaterTreeCheckBox.TabIndex = 1;
			this.WaterTreeCheckBox.UseVisualStyleBackColor = true;
			this.WaterTreeCheckBox.CheckedChanged += this.WaterTreeCheckBox_CheckedChanged;
			this.TreeNumberLabel.AutoSize = true;
			this.TreeNumberLabel.Location = new Point(33, 4);
			this.TreeNumberLabel.Name = "TreeNumberLabel";
			this.TreeNumberLabel.Size = new Size(13, 13);
			this.TreeNumberLabel.TabIndex = 3;
			this.TreeNumberLabel.Text = "8";
			this.TreeNumberLabel.TextAlign = ContentAlignment.MiddleRight;
			this.TreeNumberLabel.Click += this.TreeNumberLabel_Click;
			this.OpenSetupLink.AutoSize = true;
			this.OpenSetupLink.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.OpenSetupLink.Location = new Point(33, 17);
			this.OpenSetupLink.Name = "OpenSetupLink";
			this.OpenSetupLink.Size = new Size(29, 12);
			this.OpenSetupLink.TabIndex = 4;
			this.OpenSetupLink.TabStop = true;
			this.OpenSetupLink.Text = "Setup";
			this.OpenSetupLink.Click += this.OpenSetupLink_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.WaterTreeCheckBox);
			base.Controls.Add(this.TreePictureBox);
			base.Controls.Add(this.TreeNumberLabel);
			base.Controls.Add(this.OpenSetupLink);
			base.Name = "GardenTreeSelector";
			base.Size = new Size(62, 32);
			((ISupportInitialize)this.TreePictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060023A0 RID: 9120 RVA: 0x0000F45E File Offset: 0x0000D65E
		// (set) Token: 0x060023A1 RID: 9121 RVA: 0x0000F46B File Offset: 0x0000D66B
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int WaterCount
		{
			get
			{
				return this.gardeningWaterCountSelector_0.WaterCount;
			}
			set
			{
				this.gardeningWaterCountSelector_0.WaterCount = value;
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060023A2 RID: 9122 RVA: 0x0000F479 File Offset: 0x0000D679
		// (set) Token: 0x060023A3 RID: 9123 RVA: 0x0000F481 File Offset: 0x0000D681
		public int TreeNumber
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				this.TreeNumberLabel.Text = this.int_0.ToString();
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060023A4 RID: 9124 RVA: 0x0000F4A0 File Offset: 0x0000D6A0
		// (set) Token: 0x060023A5 RID: 9125 RVA: 0x00078A1C File Offset: 0x00076C1C
		[Browsable(false)]
		public bool TreeEnabled
		{
			get
			{
				return this.enum36_0.HasFlag(Enum36.flag_1);
			}
			set
			{
				if (this.TreeEnabled != value)
				{
					if (value)
					{
						this.enum36_0 |= Enum36.flag_1;
					}
					else
					{
						this.enum36_0 &= ~Enum36.flag_1;
					}
					if (this.WaterTreeCheckBox.Checked != this.TreeEnabled)
					{
						this.WaterTreeCheckBox.Checked = this.TreeEnabled;
					}
				}
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060023A6 RID: 9126 RVA: 0x0000F4B8 File Offset: 0x0000D6B8
		// (set) Token: 0x060023A7 RID: 9127 RVA: 0x0000F4C0 File Offset: 0x0000D6C0
		[Browsable(false)]
		public Enum36 GardeningActions
		{
			get
			{
				return this.enum36_0;
			}
			set
			{
				if (this.enum36_0 != value)
				{
					this.enum36_0 = value;
					if (this.WaterTreeCheckBox.Checked != this.TreeEnabled)
					{
						this.WaterTreeCheckBox.Checked = this.TreeEnabled;
					}
				}
			}
		}

		// Token: 0x060023A8 RID: 9128 RVA: 0x00078A80 File Offset: 0x00076C80
		public GardenTreeSelector()
		{
			this.InitializeComponent();
			this.gardeningWaterCountSelector_0 = new GardeningWaterCountSelector();
			this.gardeningWaterCountSelector_0.Size = new Size(94, 25);
			this.gardeningWaterCountSelector_0.ClosePopup += this.method_0;
			this.class359_0 = new Class359(this.gardeningWaterCountSelector_0);
		}

		// Token: 0x060023A9 RID: 9129 RVA: 0x0000F4F6 File Offset: 0x0000D6F6
		private void method_0(object sender, EventArgs e)
		{
			this.class359_0.Close();
		}

		// Token: 0x060023AA RID: 9130 RVA: 0x0000F503 File Offset: 0x0000D703
		private void OpenSetupLink_Click(object sender, EventArgs e)
		{
			this.class359_0.method_1(this);
		}

		// Token: 0x060023AB RID: 9131 RVA: 0x0000F511 File Offset: 0x0000D711
		private void TreeNumberLabel_Click(object sender, EventArgs e)
		{
			this.WaterTreeCheckBox.Checked = !this.WaterTreeCheckBox.Checked;
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x0000F52C File Offset: 0x0000D72C
		private void WaterTreeCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.TreeEnabled = this.WaterTreeCheckBox.Checked;
		}

		// Token: 0x04001066 RID: 4198
		private IContainer icontainer_0;

		// Token: 0x04001067 RID: 4199
		private PictureBox TreePictureBox;

		// Token: 0x04001068 RID: 4200
		private CheckBox WaterTreeCheckBox;

		// Token: 0x04001069 RID: 4201
		private Label TreeNumberLabel;

		// Token: 0x0400106A RID: 4202
		private LinkLabel OpenSetupLink;

		// Token: 0x0400106B RID: 4203
		private int int_0;

		// Token: 0x0400106C RID: 4204
		private Enum36 enum36_0;

		// Token: 0x0400106D RID: 4205
		private Class359 class359_0;

		// Token: 0x0400106E RID: 4206
		private GardeningWaterCountSelector gardeningWaterCountSelector_0;
	}
}
