using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns18;
using ns21;

namespace ns19
{
	// Token: 0x0200041B RID: 1051
	internal sealed class ColorSelector : UserControl
	{
		// Token: 0x060027D0 RID: 10192 RVA: 0x00011FE3 File Offset: 0x000101E3
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00093A80 File Offset: 0x00091C80
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			this.colorDialog_0 = new ColorDialog();
			this.cSelector = new Control3();
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			base.SuspendLayout();
			this.colorDialog_0.FullOpen = true;
			this.cSelector.BackColor = Color.White;
			this.cSelector.DrawBorder = true;
			this.cSelector.Location = new Point(2, 2);
			this.cSelector.Name = "cSelector";
			this.cSelector.SelectedColor = Color.Empty;
			this.cSelector.Size = new Size(20, 20);
			this.cSelector.TabIndex = 1;
			this.cSelector.Text = "Click here to select a color.";
			this.cSelector.Click += this.cSelector_Click;
			this.toolTip_0.IsBalloon = true;
			this.toolTip_0.ToolTipIcon = ToolTipIcon.Info;
			this.toolTip_0.ToolTipTitle = "Color";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.cSelector);
			base.Name = "ColorSelector";
			base.Size = new Size(24, 24);
			base.ResumeLayout(false);
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x060027D2 RID: 10194 RVA: 0x00012002 File Offset: 0x00010202
		// (set) Token: 0x060027D3 RID: 10195 RVA: 0x0001200F File Offset: 0x0001020F
		public Color SelectedColor
		{
			get
			{
				return this.cSelector.SelectedColor;
			}
			set
			{
				this.cSelector.SelectedColor = value;
			}
		}

		// Token: 0x140001CD RID: 461
		// (add) Token: 0x060027D4 RID: 10196 RVA: 0x00093BDC File Offset: 0x00091DDC
		// (remove) Token: 0x060027D5 RID: 10197 RVA: 0x00093C14 File Offset: 0x00091E14
		public event EventHandler<EventArgs17> ColorChanged
		{
			add
			{
				EventHandler<EventArgs17> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs17> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs17> value2 = (EventHandler<EventArgs17>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs17>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs17> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs17> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs17> value2 = (EventHandler<EventArgs17>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs17>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060027D6 RID: 10198 RVA: 0x0001201D File Offset: 0x0001021D
		private void method_0()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, new EventArgs17(this.SelectedColor));
			}
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x0001203E File Offset: 0x0001023E
		public ColorSelector()
		{
			this.InitializeComponent();
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x0001204C File Offset: 0x0001024C
		private void cSelector_Click(object sender, EventArgs e)
		{
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.cSelector.SelectedColor = this.colorDialog_0.Color;
				this.cSelector.Invalidate();
				this.method_0();
			}
		}

		// Token: 0x040013FC RID: 5116
		private IContainer icontainer_0;

		// Token: 0x040013FD RID: 5117
		private ColorDialog colorDialog_0;

		// Token: 0x040013FE RID: 5118
		private Control3 cSelector;

		// Token: 0x040013FF RID: 5119
		private ToolTip toolTip_0;

		// Token: 0x04001400 RID: 5120
		private EventHandler<EventArgs17> eventHandler_0;
	}
}
