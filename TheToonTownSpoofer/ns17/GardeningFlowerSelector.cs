using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns20;
using ns21;
using ns23;
using ns24;
using ns25;

namespace ns17
{
	// Token: 0x02000293 RID: 659
	internal sealed class GardeningFlowerSelector : UserControl
	{
		// Token: 0x06001B31 RID: 6961 RVA: 0x000536E0 File Offset: 0x000518E0
		protected override void Dispose(bool disposing)
		{
			if (this.gardeningActionsSelector_0 != null)
			{
				this.gardeningActionsSelector_0.Dispose();
			}
			if (this.class359_0 != null)
			{
				this.class359_0.Dispose();
			}
			if (this.gardeningBeanSelector_0 != null)
			{
				this.gardeningBeanSelector_0.Dispose();
			}
			if (this.class359_1 != null)
			{
				this.class359_1.Dispose();
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00053758 File Offset: 0x00051958
		private void InitializeComponent()
		{
			this.FlowerEnabledCheckBox = new CheckBox();
			this.OpenSetupLink = new LinkLabel();
			this.contextMenu_0 = new ContextMenu();
			this.menuItem_0 = new MenuItem();
			this.menuItem_1 = new MenuItem();
			this.FlowerNumberLabel = new Label();
			base.SuspendLayout();
			this.FlowerEnabledCheckBox.AutoSize = true;
			this.FlowerEnabledCheckBox.Location = new Point(17, 3);
			this.FlowerEnabledCheckBox.Name = "FlowerEnabledCheckBox";
			this.FlowerEnabledCheckBox.Size = new Size(15, 14);
			this.FlowerEnabledCheckBox.TabIndex = 0;
			this.FlowerEnabledCheckBox.UseVisualStyleBackColor = true;
			this.FlowerEnabledCheckBox.CheckedChanged += this.FlowerEnabledCheckBox_CheckedChanged;
			this.OpenSetupLink.AutoSize = true;
			this.OpenSetupLink.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.OpenSetupLink.Location = new Point(4, 16);
			this.OpenSetupLink.Name = "OpenSetupLink";
			this.OpenSetupLink.Size = new Size(29, 12);
			this.OpenSetupLink.TabIndex = 1;
			this.OpenSetupLink.TabStop = true;
			this.OpenSetupLink.Text = "Setup";
			this.OpenSetupLink.LinkClicked += this.OpenSetupLink_LinkClicked;
			this.contextMenu_0.MenuItems.AddRange(new MenuItem[]
			{
				this.menuItem_0,
				this.menuItem_1
			});
			this.menuItem_0.Index = 0;
			this.menuItem_0.Text = "Actions";
			this.menuItem_0.Click += this.menuItem_0_Click;
			this.menuItem_1.Index = 1;
			this.menuItem_1.Text = "Combo";
			this.menuItem_1.Click += this.menuItem_1_Click;
			this.FlowerNumberLabel.Location = new Point(-1, 3);
			this.FlowerNumberLabel.Name = "FlowerNumberLabel";
			this.FlowerNumberLabel.Size = new Size(20, 13);
			this.FlowerNumberLabel.TabIndex = 2;
			this.FlowerNumberLabel.Text = "10";
			this.FlowerNumberLabel.TextAlign = ContentAlignment.MiddleRight;
			this.FlowerNumberLabel.Click += this.FlowerNumberLabel_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.OpenSetupLink);
			base.Controls.Add(this.FlowerEnabledCheckBox);
			base.Controls.Add(this.FlowerNumberLabel);
			base.Name = "GardeningFlowerSelector";
			base.Size = new Size(36, 30);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x170007B8 RID: 1976
		// (get) Token: 0x06001B33 RID: 6963 RVA: 0x00009DB0 File Offset: 0x00007FB0
		// (set) Token: 0x06001B34 RID: 6964 RVA: 0x00009DB8 File Offset: 0x00007FB8
		public int FlowerNumber
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
				this.FlowerNumberLabel.Text = this.int_0.ToString();
			}
		}

		// Token: 0x170007B9 RID: 1977
		// (get) Token: 0x06001B35 RID: 6965 RVA: 0x00009DD7 File Offset: 0x00007FD7
		// (set) Token: 0x06001B36 RID: 6966 RVA: 0x00053A3C File Offset: 0x00051C3C
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Enum36 FloraActions
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
					if (this.FlowerEnabledCheckBox.Checked != this.FlowerEnabled)
					{
						this.FlowerEnabledCheckBox.Checked = this.FlowerEnabled;
					}
					this.gardeningActionsSelector_0.FloraActions = value;
				}
			}
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001B37 RID: 6967 RVA: 0x00009DDF File Offset: 0x00007FDF
		// (set) Token: 0x06001B38 RID: 6968 RVA: 0x00053A8C File Offset: 0x00051C8C
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public bool FlowerEnabled
		{
			get
			{
				return this.enum36_0.HasFlag(Enum36.flag_1);
			}
			set
			{
				if (this.FlowerEnabled != value)
				{
					if (value)
					{
						this.enum36_0 |= Enum36.flag_1;
					}
					else
					{
						this.enum36_0 &= ~Enum36.flag_1;
					}
					if (this.FlowerEnabledCheckBox.Checked != value)
					{
						this.FlowerEnabledCheckBox.Checked = value;
					}
				}
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001B39 RID: 6969 RVA: 0x00009DF7 File Offset: 0x00007FF7
		// (set) Token: 0x06001B3A RID: 6970 RVA: 0x00009E04 File Offset: 0x00008004
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Class322 BeanCombination
		{
			get
			{
				return this.gardeningBeanSelector_0.BeanCombination;
			}
			set
			{
				this.gardeningBeanSelector_0.BeanCombination = value;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001B3B RID: 6971 RVA: 0x00009E12 File Offset: 0x00008012
		// (set) Token: 0x06001B3C RID: 6972 RVA: 0x00009E1F File Offset: 0x0000801F
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int WaterCount
		{
			get
			{
				return this.gardeningActionsSelector_0.WaterCount;
			}
			set
			{
				this.gardeningActionsSelector_0.WaterCount = value;
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x00053AE4 File Offset: 0x00051CE4
		public GardeningFlowerSelector()
		{
			this.InitializeComponent();
			this.gardeningActionsSelector_0 = new GardeningActionsSelector();
			this.gardeningActionsSelector_0.Size = new Size(87, 66);
			this.gardeningActionsSelector_0.GardenerActionsChanged += this.method_2;
			this.gardeningActionsSelector_0.ClosePopup += this.method_0;
			this.class359_0 = new Class359(this.gardeningActionsSelector_0);
			this.gardeningBeanSelector_0 = new GardeningBeanSelector();
			this.gardeningBeanSelector_0.Size = new Size(210, 210);
			this.gardeningBeanSelector_0.ClosePopup += this.method_1;
			this.class359_1 = new Class359(this.gardeningBeanSelector_0);
			this.FloraActions = (Enum36.flag_1 | Enum36.flag_2 | Enum36.flag_3 | Enum36.flag_4);
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00009E2D File Offset: 0x0000802D
		private void method_0(object sender, EventArgs e)
		{
			this.class359_0.Close();
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00009E3A File Offset: 0x0000803A
		private void method_1(object sender, EventArgs e)
		{
			this.class359_1.Close();
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00009E47 File Offset: 0x00008047
		private void method_2(object sender, EventArgs27 e)
		{
			if (this.FlowerEnabled)
			{
				this.FloraActions = (e.FloraActions | Enum36.flag_1);
				return;
			}
			this.FloraActions = e.FloraActions;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00009E6D File Offset: 0x0000806D
		private void FlowerEnabledCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.FlowerEnabled = this.FlowerEnabledCheckBox.Checked;
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00009E80 File Offset: 0x00008080
		private void OpenSetupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.contextMenu_0.Show(this.OpenSetupLink, new Point(0, this.OpenSetupLink.Height));
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00009EA4 File Offset: 0x000080A4
		private void FlowerNumberLabel_Click(object sender, EventArgs e)
		{
			this.FlowerEnabledCheckBox.Checked = !this.FlowerEnabledCheckBox.Checked;
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x00009EBF File Offset: 0x000080BF
		private void menuItem_0_Click(object sender, EventArgs e)
		{
			this.class359_0.method_1(this);
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00009ECD File Offset: 0x000080CD
		private void menuItem_1_Click(object sender, EventArgs e)
		{
			this.class359_1.method_1(this);
		}

		// Token: 0x040008D2 RID: 2258
		private IContainer icontainer_0;

		// Token: 0x040008D3 RID: 2259
		private CheckBox FlowerEnabledCheckBox;

		// Token: 0x040008D4 RID: 2260
		private LinkLabel OpenSetupLink;

		// Token: 0x040008D5 RID: 2261
		private ContextMenu contextMenu_0;

		// Token: 0x040008D6 RID: 2262
		private MenuItem menuItem_0;

		// Token: 0x040008D7 RID: 2263
		private MenuItem menuItem_1;

		// Token: 0x040008D8 RID: 2264
		private Label FlowerNumberLabel;

		// Token: 0x040008D9 RID: 2265
		private GardeningActionsSelector gardeningActionsSelector_0;

		// Token: 0x040008DA RID: 2266
		private Class359 class359_0;

		// Token: 0x040008DB RID: 2267
		private GardeningBeanSelector gardeningBeanSelector_0;

		// Token: 0x040008DC RID: 2268
		private Class359 class359_1;

		// Token: 0x040008DD RID: 2269
		private Enum36 enum36_0;

		// Token: 0x040008DE RID: 2270
		private int int_0;
	}
}
