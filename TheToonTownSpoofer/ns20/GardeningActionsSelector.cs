using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns21;
using ns25;

namespace ns20
{
	// Token: 0x02000424 RID: 1060
	internal sealed class GardeningActionsSelector : UserControl
	{
		// Token: 0x0600281E RID: 10270 RVA: 0x0001225F File Offset: 0x0001045F
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x000947CC File Offset: 0x000929CC
		private void InitializeComponent()
		{
			this.PickCheckBox = new CheckBox();
			this.PlantCheckBox = new CheckBox();
			this.WaterCheckBox = new CheckBox();
			this.HideBtn = new Button();
			this.TimesLabel = new Label();
			this.WaterCountTextBox = new Class181();
			base.SuspendLayout();
			this.PickCheckBox.AutoSize = true;
			this.PickCheckBox.Location = new Point(5, 5);
			this.PickCheckBox.Name = "PickCheckBox";
			this.PickCheckBox.Size = new Size(47, 17);
			this.PickCheckBox.TabIndex = 0;
			this.PickCheckBox.Text = "Pick";
			this.PickCheckBox.UseVisualStyleBackColor = true;
			this.PickCheckBox.CheckedChanged += this.PickCheckBox_CheckedChanged;
			this.PlantCheckBox.AutoSize = true;
			this.PlantCheckBox.Location = new Point(5, 24);
			this.PlantCheckBox.Name = "PlantCheckBox";
			this.PlantCheckBox.Size = new Size(50, 17);
			this.PlantCheckBox.TabIndex = 0;
			this.PlantCheckBox.Text = "Plant";
			this.PlantCheckBox.UseVisualStyleBackColor = true;
			this.PlantCheckBox.CheckedChanged += this.PlantCheckBox_CheckedChanged;
			this.WaterCheckBox.AutoSize = true;
			this.WaterCheckBox.Location = new Point(5, 43);
			this.WaterCheckBox.Name = "WaterCheckBox";
			this.WaterCheckBox.Size = new Size(55, 17);
			this.WaterCheckBox.TabIndex = 0;
			this.WaterCheckBox.Text = "Water";
			this.WaterCheckBox.UseVisualStyleBackColor = true;
			this.WaterCheckBox.CheckedChanged += this.WaterCheckBox_CheckedChanged;
			this.HideBtn.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.HideBtn.Location = new Point(64, 3);
			this.HideBtn.Name = "HideBtn";
			this.HideBtn.Size = new Size(18, 19);
			this.HideBtn.TabIndex = 3;
			this.HideBtn.Text = "X";
			this.HideBtn.UseVisualStyleBackColor = true;
			this.HideBtn.Click += this.HideBtn_Click;
			this.TimesLabel.AutoSize = true;
			this.TimesLabel.Location = new Point(59, 44);
			this.TimesLabel.Name = "TimesLabel";
			this.TimesLabel.Size = new Size(12, 13);
			this.TimesLabel.TabIndex = 5;
			this.TimesLabel.Text = "x";
			this.WaterCountTextBox.Location = new Point(70, 41);
			this.WaterCountTextBox.MaximumValue = 5;
			this.WaterCountTextBox.MaxLength = 1;
			this.WaterCountTextBox.MinimumValue = 0;
			this.WaterCountTextBox.Name = "WaterCountTextBox";
			this.WaterCountTextBox.Size = new Size(12, 20);
			this.WaterCountTextBox.TabIndex = 4;
			this.WaterCountTextBox.Value = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.BorderStyle = BorderStyle.FixedSingle;
			base.Controls.Add(this.WaterCountTextBox);
			base.Controls.Add(this.TimesLabel);
			base.Controls.Add(this.HideBtn);
			base.Controls.Add(this.WaterCheckBox);
			base.Controls.Add(this.PlantCheckBox);
			base.Controls.Add(this.PickCheckBox);
			base.Name = "GardeningActionsSelector";
			base.Size = new Size(85, 62);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06002820 RID: 10272 RVA: 0x0001227E File Offset: 0x0001047E
		// (set) Token: 0x06002821 RID: 10273 RVA: 0x00094BC8 File Offset: 0x00092DC8
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
					if (this.PickCheckBox.Checked != this.Pick)
					{
						this.PickCheckBox.Checked = this.Pick;
					}
					if (this.PlantCheckBox.Checked != this.Plant)
					{
						this.PlantCheckBox.Checked = this.Plant;
					}
					if (this.WaterCheckBox.Checked != this.Water)
					{
						this.WaterCheckBox.Checked = this.Water;
					}
					this.method_0();
				}
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06002822 RID: 10274 RVA: 0x00012286 File Offset: 0x00010486
		// (set) Token: 0x06002823 RID: 10275 RVA: 0x00094C58 File Offset: 0x00092E58
		public bool Pick
		{
			get
			{
				return this.enum36_0.HasFlag(Enum36.flag_2);
			}
			set
			{
				if (this.Pick != value)
				{
					if (value)
					{
						this.enum36_0 |= Enum36.flag_2;
					}
					else
					{
						this.enum36_0 &= ~Enum36.flag_2;
					}
					if (this.PickCheckBox.Checked != value)
					{
						this.PickCheckBox.Checked = value;
					}
					this.method_0();
				}
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06002824 RID: 10276 RVA: 0x0001229E File Offset: 0x0001049E
		// (set) Token: 0x06002825 RID: 10277 RVA: 0x00094CB8 File Offset: 0x00092EB8
		public bool Plant
		{
			get
			{
				return this.enum36_0.HasFlag(Enum36.flag_3);
			}
			set
			{
				if (this.Plant != value)
				{
					if (value)
					{
						this.enum36_0 |= Enum36.flag_3;
					}
					else
					{
						this.enum36_0 &= ~Enum36.flag_3;
					}
					if (this.PlantCheckBox.Checked != value)
					{
						this.PlantCheckBox.Checked = value;
					}
					this.method_0();
				}
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06002826 RID: 10278 RVA: 0x000122B6 File Offset: 0x000104B6
		// (set) Token: 0x06002827 RID: 10279 RVA: 0x00094D18 File Offset: 0x00092F18
		public bool Water
		{
			get
			{
				return this.enum36_0.HasFlag(Enum36.flag_4);
			}
			set
			{
				if (this.Water != value)
				{
					if (value)
					{
						this.enum36_0 |= Enum36.flag_4;
					}
					else
					{
						this.enum36_0 &= ~Enum36.flag_4;
					}
					if (this.WaterCheckBox.Checked != value)
					{
						this.WaterCheckBox.Checked = value;
					}
					this.method_0();
				}
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06002828 RID: 10280 RVA: 0x000122CE File Offset: 0x000104CE
		// (set) Token: 0x06002829 RID: 10281 RVA: 0x000122DB File Offset: 0x000104DB
		public int WaterCount
		{
			get
			{
				return this.WaterCountTextBox.Value;
			}
			set
			{
				this.WaterCountTextBox.Value = value;
			}
		}

		// Token: 0x140001CF RID: 463
		// (add) Token: 0x0600282A RID: 10282 RVA: 0x00094D78 File Offset: 0x00092F78
		// (remove) Token: 0x0600282B RID: 10283 RVA: 0x00094DB0 File Offset: 0x00092FB0
		public event EventHandler<EventArgs27> GardenerActionsChanged
		{
			add
			{
				EventHandler<EventArgs27> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs27> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs27> value2 = (EventHandler<EventArgs27>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs27>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs27> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs27> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs27> value2 = (EventHandler<EventArgs27>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs27>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x140001D0 RID: 464
		// (add) Token: 0x0600282C RID: 10284 RVA: 0x00094DE8 File Offset: 0x00092FE8
		// (remove) Token: 0x0600282D RID: 10285 RVA: 0x00094E20 File Offset: 0x00093020
		public event EventHandler ClosePopup
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x0600282E RID: 10286 RVA: 0x000122E9 File Offset: 0x000104E9
		public GardeningActionsSelector()
		{
			this.InitializeComponent();
			this.FloraActions = (Enum36.flag_2 | Enum36.flag_3 | Enum36.flag_4);
		}

		// Token: 0x0600282F RID: 10287 RVA: 0x000122FF File Offset: 0x000104FF
		private void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs27(this.enum36_0));
			}
		}

		// Token: 0x06002830 RID: 10288 RVA: 0x00012320 File Offset: 0x00010520
		private void PickCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.Pick = this.PickCheckBox.Checked;
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00012333 File Offset: 0x00010533
		private void PlantCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.Plant = this.PlantCheckBox.Checked;
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00012346 File Offset: 0x00010546
		private void WaterCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.Water = this.WaterCheckBox.Checked;
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00012359 File Offset: 0x00010559
		private void HideBtn_Click(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x04001424 RID: 5156
		private IContainer icontainer_0;

		// Token: 0x04001425 RID: 5157
		private CheckBox PickCheckBox;

		// Token: 0x04001426 RID: 5158
		private CheckBox PlantCheckBox;

		// Token: 0x04001427 RID: 5159
		private CheckBox WaterCheckBox;

		// Token: 0x04001428 RID: 5160
		private Button HideBtn;

		// Token: 0x04001429 RID: 5161
		private Class181 WaterCountTextBox;

		// Token: 0x0400142A RID: 5162
		private Label TimesLabel;

		// Token: 0x0400142B RID: 5163
		private Enum36 enum36_0;

		// Token: 0x0400142C RID: 5164
		private EventHandler<EventArgs27> eventHandler_0;

		// Token: 0x0400142D RID: 5165
		private EventHandler eventHandler_1;
	}
}
