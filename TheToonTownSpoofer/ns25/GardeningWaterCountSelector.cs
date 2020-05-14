using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns21;

namespace ns25
{
	// Token: 0x02000335 RID: 821
	internal sealed class GardeningWaterCountSelector : UserControl
	{
		// Token: 0x06001FED RID: 8173 RVA: 0x0000CE06 File Offset: 0x0000B006
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00069FD8 File Offset: 0x000681D8
		private void InitializeComponent()
		{
			this.WaterCountTextBox = new Class181();
			this.TimesLabel = new Label();
			this.WaterLabel = new Label();
			this.HideBtn = new Button();
			base.SuspendLayout();
			this.WaterCountTextBox.IfZeroDisplayEmpty = false;
			this.WaterCountTextBox.Location = new Point(54, 2);
			this.WaterCountTextBox.MaximumValue = 5;
			this.WaterCountTextBox.MaxLength = 1;
			this.WaterCountTextBox.MinimumValue = 0;
			this.WaterCountTextBox.Name = "WaterCountTextBox";
			this.WaterCountTextBox.Size = new Size(12, 20);
			this.WaterCountTextBox.TabIndex = 7;
			this.WaterCountTextBox.Value = 0;
			this.WaterCountTextBox.TextChanged += this.WaterCountTextBox_TextChanged;
			this.TimesLabel.AutoSize = true;
			this.TimesLabel.Location = new Point(43, 5);
			this.TimesLabel.Name = "TimesLabel";
			this.TimesLabel.Size = new Size(12, 13);
			this.TimesLabel.TabIndex = 8;
			this.TimesLabel.Text = "x";
			this.WaterLabel.AutoSize = true;
			this.WaterLabel.Location = new Point(5, 5);
			this.WaterLabel.Name = "WaterLabel";
			this.WaterLabel.Size = new Size(36, 13);
			this.WaterLabel.TabIndex = 9;
			this.WaterLabel.Text = "Water";
			this.HideBtn.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.HideBtn.Location = new Point(73, 3);
			this.HideBtn.Name = "HideBtn";
			this.HideBtn.Size = new Size(18, 19);
			this.HideBtn.TabIndex = 10;
			this.HideBtn.Text = "X";
			this.HideBtn.UseVisualStyleBackColor = true;
			this.HideBtn.Click += this.HideBtn_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.BorderStyle = BorderStyle.FixedSingle;
			base.Controls.Add(this.HideBtn);
			base.Controls.Add(this.WaterLabel);
			base.Controls.Add(this.WaterCountTextBox);
			base.Controls.Add(this.TimesLabel);
			base.Name = "GardeningWaterCountSelector";
			base.Size = new Size(94, 25);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x14000196 RID: 406
		// (add) Token: 0x06001FEF RID: 8175 RVA: 0x0006A290 File Offset: 0x00068490
		// (remove) Token: 0x06001FF0 RID: 8176 RVA: 0x0006A2C8 File Offset: 0x000684C8
		public event EventHandler ClosePopup
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

		// Token: 0x14000197 RID: 407
		// (add) Token: 0x06001FF1 RID: 8177 RVA: 0x0006A300 File Offset: 0x00068500
		// (remove) Token: 0x06001FF2 RID: 8178 RVA: 0x0006A338 File Offset: 0x00068538
		public event EventHandler ValueChanged
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

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06001FF3 RID: 8179 RVA: 0x0000CE25 File Offset: 0x0000B025
		// (set) Token: 0x06001FF4 RID: 8180 RVA: 0x0000CE32 File Offset: 0x0000B032
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

		// Token: 0x06001FF5 RID: 8181 RVA: 0x0000CE40 File Offset: 0x0000B040
		public GardeningWaterCountSelector()
		{
			this.InitializeComponent();
		}

		// Token: 0x06001FF6 RID: 8182 RVA: 0x0000CE4E File Offset: 0x0000B04E
		private void HideBtn_Click(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, e);
			}
		}

		// Token: 0x06001FF7 RID: 8183 RVA: 0x0000CE65 File Offset: 0x0000B065
		private void WaterCountTextBox_TextChanged(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, e);
			}
		}

		// Token: 0x04000C6C RID: 3180
		private IContainer icontainer_0;

		// Token: 0x04000C6D RID: 3181
		private Class181 WaterCountTextBox;

		// Token: 0x04000C6E RID: 3182
		private Label TimesLabel;

		// Token: 0x04000C6F RID: 3183
		private Label WaterLabel;

		// Token: 0x04000C70 RID: 3184
		private Button HideBtn;

		// Token: 0x04000C71 RID: 3185
		private EventHandler eventHandler_0;

		// Token: 0x04000C72 RID: 3186
		private EventHandler eventHandler_1;
	}
}
