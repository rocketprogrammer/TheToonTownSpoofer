using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns16;
using ns17;
using ns23;
using ns25;
using ns27;
using ns28;

namespace ns22
{
	// Token: 0x02000356 RID: 854
	internal sealed class EstatePlantDetailsSelector : UserControl
	{
		// Token: 0x06002192 RID: 8594 RVA: 0x00070BA4 File Offset: 0x0006EDA4
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.gardeningWaterCountSelector_0 != null)
				{
					this.gardeningWaterCountSelector_0.Dispose();
				}
				if (this.class359_0 != null)
				{
					this.class359_0.Dispose();
				}
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00070BF4 File Offset: 0x0006EDF4
		private void InitializeComponent()
		{
			this.PlantEstateCheckBox = new CheckBox();
			this.PickAction = new CheckBox();
			this.PlantAction = new CheckBox();
			this.WaterAction = new CheckBox();
			this.label1 = new Label();
			this.label2 = new Label();
			this.FlowersTarget = new CheckBox();
			this.TreesTarget = new CheckBox();
			this.CustomizeActions = new CheckBox();
			this.CustomizeEstate = new LinkLabel();
			this.WaterLink = new LinkLabel();
			this.EstateRendererInstance = new Control10();
			base.SuspendLayout();
			this.PlantEstateCheckBox.AutoSize = true;
			this.PlantEstateCheckBox.Font = new Font("Calibri", 15.75f);
			this.PlantEstateCheckBox.Location = new Point(65, 0);
			this.PlantEstateCheckBox.Name = "PlantEstateCheckBox";
			this.PlantEstateCheckBox.Size = new Size(126, 30);
			this.PlantEstateCheckBox.TabIndex = 0;
			this.PlantEstateCheckBox.TabStop = false;
			this.PlantEstateCheckBox.Text = "Blue House";
			this.PlantEstateCheckBox.UseVisualStyleBackColor = true;
			this.PlantEstateCheckBox.CheckedChanged += this.PlantEstateCheckBox_CheckedChanged;
			this.PickAction.AutoSize = true;
			this.PickAction.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.PickAction.Location = new Point(122, 48);
			this.PickAction.Name = "PickAction";
			this.PickAction.Size = new Size(42, 16);
			this.PickAction.TabIndex = 3;
			this.PickAction.TabStop = false;
			this.PickAction.Text = "Pick";
			this.PickAction.UseVisualStyleBackColor = true;
			this.PickAction.CheckedChanged += this.PickAction_CheckedChanged;
			this.PlantAction.AutoSize = true;
			this.PlantAction.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.PlantAction.Location = new Point(186, 48);
			this.PlantAction.Name = "PlantAction";
			this.PlantAction.Size = new Size(45, 16);
			this.PlantAction.TabIndex = 4;
			this.PlantAction.TabStop = false;
			this.PlantAction.Text = "Plant";
			this.PlantAction.UseVisualStyleBackColor = true;
			this.PlantAction.CheckedChanged += this.PlantAction_CheckedChanged;
			this.WaterAction.AutoSize = true;
			this.WaterAction.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.WaterAction.Location = new Point(253, 48);
			this.WaterAction.Name = "WaterAction";
			this.WaterAction.Size = new Size(15, 14);
			this.WaterAction.TabIndex = 5;
			this.WaterAction.TabStop = false;
			this.WaterAction.UseVisualStyleBackColor = true;
			this.WaterAction.CheckedChanged += this.WaterAction_CheckedChanged;
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label1.Location = new Point(68, 49);
			this.label1.Name = "label1";
			this.label1.Size = new Size(48, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "Actions:";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.Location = new Point(75, 33);
			this.label2.Name = "label2";
			this.label2.Size = new Size(41, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "Target:";
			this.FlowersTarget.AutoSize = true;
			this.FlowersTarget.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.FlowersTarget.Location = new Point(122, 32);
			this.FlowersTarget.Name = "FlowersTarget";
			this.FlowersTarget.Size = new Size(58, 16);
			this.FlowersTarget.TabIndex = 1;
			this.FlowersTarget.TabStop = false;
			this.FlowersTarget.Text = "Flowers";
			this.FlowersTarget.UseVisualStyleBackColor = true;
			this.FlowersTarget.CheckedChanged += this.FlowersTarget_CheckedChanged;
			this.TreesTarget.AutoSize = true;
			this.TreesTarget.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.TreesTarget.Location = new Point(186, 32);
			this.TreesTarget.Name = "TreesTarget";
			this.TreesTarget.Size = new Size(47, 16);
			this.TreesTarget.TabIndex = 2;
			this.TreesTarget.TabStop = false;
			this.TreesTarget.Text = "Trees";
			this.TreesTarget.UseVisualStyleBackColor = true;
			this.TreesTarget.CheckedChanged += this.TreesTarget_CheckedChanged;
			this.CustomizeActions.AutoSize = true;
			this.CustomizeActions.Font = new Font("Microsoft Sans Serif", 6.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.CustomizeActions.Location = new Point(299, 4);
			this.CustomizeActions.Name = "CustomizeActions";
			this.CustomizeActions.Size = new Size(15, 14);
			this.CustomizeActions.TabIndex = 7;
			this.CustomizeActions.TabStop = false;
			this.CustomizeActions.UseVisualStyleBackColor = true;
			this.CustomizeActions.CheckedChanged += this.CustomizeActions_CheckedChanged;
			this.CustomizeEstate.AutoSize = true;
			this.CustomizeEstate.Font = new Font("Microsoft Sans Serif", 6.75f);
			this.CustomizeEstate.Location = new Point(258, 4);
			this.CustomizeEstate.Name = "CustomizeEstate";
			this.CustomizeEstate.Size = new Size(38, 12);
			this.CustomizeEstate.TabIndex = 6;
			this.CustomizeEstate.TabStop = true;
			this.CustomizeEstate.Text = "Custom";
			this.CustomizeEstate.LinkClicked += this.CustomizeEstate_LinkClicked;
			this.WaterLink.AutoSize = true;
			this.WaterLink.Font = new Font("Microsoft Sans Serif", 6.75f);
			this.WaterLink.Location = new Point(269, 48);
			this.WaterLink.Margin = new Padding(0);
			this.WaterLink.Name = "WaterLink";
			this.WaterLink.Size = new Size(30, 12);
			this.WaterLink.TabIndex = 8;
			this.WaterLink.TabStop = true;
			this.WaterLink.Text = "Water";
			this.WaterLink.LinkClicked += this.WaterLink_LinkClicked;
			this.EstateRendererInstance.EstateHome = Enum13.const_3;
			this.EstateRendererInstance.Location = new Point(3, 3);
			this.EstateRendererInstance.Name = "EstateRendererInstance";
			this.EstateRendererInstance.Size = new Size(56, 64);
			this.EstateRendererInstance.TabIndex = 0;
			this.EstateRendererInstance.Text = "estateRenderer1";
			this.EstateRendererInstance.Click += this.EstatePlantDetailsSelector_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.Controls.Add(this.CustomizeActions);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.WaterAction);
			base.Controls.Add(this.PlantAction);
			base.Controls.Add(this.TreesTarget);
			base.Controls.Add(this.FlowersTarget);
			base.Controls.Add(this.PickAction);
			base.Controls.Add(this.PlantEstateCheckBox);
			base.Controls.Add(this.EstateRendererInstance);
			base.Controls.Add(this.WaterLink);
			base.Controls.Add(this.CustomizeEstate);
			base.Name = "EstatePlantDetailsSelector";
			base.Size = new Size(317, 70);
			base.Click += this.EstatePlantDetailsSelector_Click;
			base.MouseEnter += this.EstatePlantDetailsSelector_MouseEnter;
			base.MouseLeave += this.EstatePlantDetailsSelector_MouseLeave;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x14000199 RID: 409
		// (add) Token: 0x06002194 RID: 8596 RVA: 0x00071538 File Offset: 0x0006F738
		// (remove) Token: 0x06002195 RID: 8597 RVA: 0x00071570 File Offset: 0x0006F770
		public event EventHandler OnModified
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_0;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06002196 RID: 8598 RVA: 0x0000DE88 File Offset: 0x0000C088
		// (set) Token: 0x06002197 RID: 8599 RVA: 0x000715A8 File Offset: 0x0006F7A8
		[Browsable(false)]
		public Class94 FloraEstatePlantingDetails
		{
			get
			{
				return this.class94_0;
			}
			set
			{
				if (this.class94_0 != value)
				{
					this.class94_0 = value;
					this.EstateRendererInstance.EstateHome = this.class94_0.HouseColor;
					switch (this.class94_0.HouseColor)
					{
					case Enum13.const_0:
						this.PlantEstateCheckBox.Text = "Red House";
						break;
					case Enum13.const_1:
						this.PlantEstateCheckBox.Text = "Green House";
						break;
					case Enum13.const_2:
						this.PlantEstateCheckBox.Text = "Purple House";
						break;
					case Enum13.const_3:
						this.PlantEstateCheckBox.Text = "Blue House";
						break;
					case Enum13.const_4:
						this.PlantEstateCheckBox.Text = "Pink House";
						break;
					case Enum13.const_5:
						this.PlantEstateCheckBox.Text = "Yellow House";
						break;
					}
					this.method_2();
				}
			}
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x0007167C File Offset: 0x0006F87C
		public EstatePlantDetailsSelector()
		{
			this.InitializeComponent();
			this.gardeningWaterCountSelector_0 = new GardeningWaterCountSelector();
			this.gardeningWaterCountSelector_0.Size = new Size(94, 25);
			this.gardeningWaterCountSelector_0.ClosePopup += this.method_0;
			this.gardeningWaterCountSelector_0.ValueChanged += this.method_7;
			this.class359_0 = new Class359(this.gardeningWaterCountSelector_0);
			this.FloraEstatePlantingDetails = new Class94(Enum13.const_3);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x0000DE90 File Offset: 0x0000C090
		private void method_0(object sender, EventArgs e)
		{
			this.class359_0.Close();
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x0000DE9D File Offset: 0x0000C09D
		private void WaterLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.class359_0.method_1(this.WaterLink);
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		private void method_1()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00071700 File Offset: 0x0006F900
		private void method_2()
		{
			this.PlantAction.Checked = this.class94_0.Plant;
			this.PickAction.Checked = this.class94_0.Pick;
			this.WaterAction.Checked = this.class94_0.Water;
			this.FlowersTarget.Checked = this.class94_0.GardenFlowers;
			this.TreesTarget.Checked = this.class94_0.GardenTrees;
			this.CustomizeActions.Checked = this.class94_0.Customized;
			this.gardeningWaterCountSelector_0.WaterCount = (int)this.class94_0.WaterCount;
			this.method_3();
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x000717B0 File Offset: 0x0006F9B0
		private void method_3()
		{
			if (this.PlantEstateCheckBox.Checked != this.class94_0.Enabled)
			{
				this.PlantEstateCheckBox.Checked = this.class94_0.Enabled;
			}
			this.CustomizeEstate.Enabled = this.class94_0.Enabled;
			this.CustomizeActions.Enabled = this.class94_0.Enabled;
			bool enabled = this.class94_0.Enabled && !this.class94_0.Customized;
			this.FlowersTarget.Enabled = enabled;
			this.TreesTarget.Enabled = enabled;
			this.method_4();
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00071854 File Offset: 0x0006FA54
		private void method_4()
		{
			bool flag;
			bool enabled = (flag = (this.class94_0.Enabled && !this.class94_0.Customized)) && this.class94_0.GardenFlowers;
			bool enabled2 = flag && (this.class94_0.GardenFlowers || this.class94_0.GardenTrees);
			this.PlantAction.Enabled = enabled;
			this.PickAction.Enabled = enabled;
			this.WaterAction.Enabled = enabled2;
			this.WaterLink.Enabled = (flag && this.WaterAction.Checked);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x000718F4 File Offset: 0x0006FAF4
		protected override void InitLayout()
		{
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				control.MouseEnter += this.EstatePlantDetailsSelector_MouseEnter;
				control.MouseLeave += this.EstatePlantDetailsSelector_MouseLeave;
			}
			base.InitLayout();
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00071974 File Offset: 0x0006FB74
		private void EstatePlantDetailsSelector_MouseEnter(object sender, EventArgs e)
		{
			if (this.BackColor != SystemColors.Highlight)
			{
				this.method_6(SystemColors.Highlight);
				this.Cursor = Cursors.Hand;
				foreach (object obj in base.Parent.Controls)
				{
					Control control = (Control)obj;
					EstatePlantDetailsSelector estatePlantDetailsSelector = control as EstatePlantDetailsSelector;
					if (estatePlantDetailsSelector != null && estatePlantDetailsSelector != this)
					{
						estatePlantDetailsSelector.method_5();
					}
				}
			}
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x0000DECB File Offset: 0x0000C0CB
		private void EstatePlantDetailsSelector_MouseLeave(object sender, EventArgs e)
		{
			this.method_5();
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00071A08 File Offset: 0x0006FC08
		private void method_5()
		{
			if (this.BackColor != SystemColors.Control && !base.ClientRectangle.Contains(base.PointToClient(Cursor.Position)))
			{
				this.method_6(SystemColors.Control);
				this.Cursor = Cursors.Default;
			}
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00071A58 File Offset: 0x0006FC58
		private void method_6(Color c)
		{
			foreach (object obj in base.Controls)
			{
				Control control = (Control)obj;
				control.BackColor = c;
				control.Update();
			}
			this.BackColor = c;
			base.Update();
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x0000DED3 File Offset: 0x0000C0D3
		private void PlantEstateCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (this.class94_0.Enabled != this.PlantEstateCheckBox.Checked)
			{
				this.class94_0.Enabled = this.PlantEstateCheckBox.Checked;
				this.method_3();
				this.method_1();
			}
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x0000DF0F File Offset: 0x0000C10F
		private void EstatePlantDetailsSelector_Click(object sender, EventArgs e)
		{
			this.PlantEstateCheckBox.Checked = !this.PlantEstateCheckBox.Checked;
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x0000DF2A File Offset: 0x0000C12A
		private void CustomizeActions_CheckedChanged(object sender, EventArgs e)
		{
			if (this.class94_0.Customized != this.CustomizeActions.Checked)
			{
				this.class94_0.Customized = this.CustomizeActions.Checked;
				this.method_3();
				this.method_1();
			}
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x0000DF66 File Offset: 0x0000C166
		private void method_7(object sender, EventArgs e)
		{
			if ((int)this.class94_0.WaterCount != this.gardeningWaterCountSelector_0.WaterCount)
			{
				this.class94_0.WaterCount = (ushort)this.gardeningWaterCountSelector_0.WaterCount;
				this.method_1();
			}
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x00071AC8 File Offset: 0x0006FCC8
		private void CustomizeEstate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (!this.CustomizeActions.Checked)
			{
				this.CustomizeActions.Checked = true;
			}
			using (Class499 @class = new Class499(base.ParentForm))
			{
				using (CustomizeEstatePlanting customizeEstatePlanting = new CustomizeEstatePlanting(this.class94_0))
				{
					@class.method_0(customizeEstatePlanting);
					if (customizeEstatePlanting.ShowDialog() == DialogResult.OK)
					{
						this.method_1();
					}
				}
			}
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x0000DF9D File Offset: 0x0000C19D
		private void FlowersTarget_CheckedChanged(object sender, EventArgs e)
		{
			if (this.class94_0.GardenFlowers != this.FlowersTarget.Checked)
			{
				this.class94_0.GardenFlowers = this.FlowersTarget.Checked;
				this.method_4();
				this.method_1();
			}
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0000DFD9 File Offset: 0x0000C1D9
		private void TreesTarget_CheckedChanged(object sender, EventArgs e)
		{
			if (this.class94_0.GardenTrees != this.TreesTarget.Checked)
			{
				this.class94_0.GardenTrees = this.TreesTarget.Checked;
				this.method_4();
				this.method_1();
			}
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0000E015 File Offset: 0x0000C215
		private void PickAction_CheckedChanged(object sender, EventArgs e)
		{
			if (this.class94_0.Pick != this.PickAction.Checked)
			{
				this.class94_0.Pick = this.PickAction.Checked;
				this.method_1();
			}
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x0000E04B File Offset: 0x0000C24B
		private void PlantAction_CheckedChanged(object sender, EventArgs e)
		{
			if (this.class94_0.Plant != this.PlantAction.Checked)
			{
				this.class94_0.Plant = this.PlantAction.Checked;
				this.method_1();
			}
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x0000E081 File Offset: 0x0000C281
		private void WaterAction_CheckedChanged(object sender, EventArgs e)
		{
			this.method_4();
			if (this.class94_0.Water != this.WaterAction.Checked)
			{
				this.class94_0.Water = this.WaterAction.Checked;
				this.method_1();
			}
		}

		// Token: 0x04000DC3 RID: 3523
		private IContainer icontainer_0;

		// Token: 0x04000DC4 RID: 3524
		private Control10 EstateRendererInstance;

		// Token: 0x04000DC5 RID: 3525
		private CheckBox PlantEstateCheckBox;

		// Token: 0x04000DC6 RID: 3526
		private CheckBox PickAction;

		// Token: 0x04000DC7 RID: 3527
		private CheckBox PlantAction;

		// Token: 0x04000DC8 RID: 3528
		private CheckBox WaterAction;

		// Token: 0x04000DC9 RID: 3529
		private Label label1;

		// Token: 0x04000DCA RID: 3530
		private Label label2;

		// Token: 0x04000DCB RID: 3531
		private CheckBox FlowersTarget;

		// Token: 0x04000DCC RID: 3532
		private CheckBox TreesTarget;

		// Token: 0x04000DCD RID: 3533
		private CheckBox CustomizeActions;

		// Token: 0x04000DCE RID: 3534
		private LinkLabel CustomizeEstate;

		// Token: 0x04000DCF RID: 3535
		private LinkLabel WaterLink;

		// Token: 0x04000DD0 RID: 3536
		private Class94 class94_0;

		// Token: 0x04000DD1 RID: 3537
		private EventHandler eventHandler_0;

		// Token: 0x04000DD2 RID: 3538
		private Class359 class359_0;

		// Token: 0x04000DD3 RID: 3539
		private GardeningWaterCountSelector gardeningWaterCountSelector_0;
	}
}
