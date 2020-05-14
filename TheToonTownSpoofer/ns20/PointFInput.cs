using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns23;
using ns27;

namespace ns20
{
	// Token: 0x02000450 RID: 1104
	internal sealed partial class PointFInput : Form
	{
		// Token: 0x06002974 RID: 10612 RVA: 0x00013174 File Offset: 0x00011374
		public PointFInput()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06002975 RID: 10613 RVA: 0x00013182 File Offset: 0x00011382
		// (set) Token: 0x06002976 RID: 10614 RVA: 0x0001319F File Offset: 0x0001139F
		public PointF SelectedPoint
		{
			get
			{
				return new PointF(this.XTxt.Value, this.YTxt.Value);
			}
			set
			{
				this.XTxt.Value = value.X;
				this.YTxt.Value = value.Y;
			}
		}

		// Token: 0x140001D7 RID: 471
		// (add) Token: 0x06002977 RID: 10615 RVA: 0x0009EB30 File Offset: 0x0009CD30
		// (remove) Token: 0x06002978 RID: 10616 RVA: 0x0009EB68 File Offset: 0x0009CD68
		public event EventHandler<EventArgs43<PointF>> ValueValidating
		{
			add
			{
				EventHandler<EventArgs43<PointF>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs43<PointF>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs43<PointF>> value2 = (EventHandler<EventArgs43<PointF>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs43<PointF>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs43<PointF>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs43<PointF>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs43<PointF>> value2 = (EventHandler<EventArgs43<PointF>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs43<PointF>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06002979 RID: 10617 RVA: 0x0009EBA0 File Offset: 0x0009CDA0
		private void PointFInput_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (base.DialogResult == DialogResult.OK && this.eventHandler_0 != null)
			{
				EventArgs43<PointF> eventArgs = new EventArgs43<PointF>(this.SelectedPoint);
				this.eventHandler_0(this, eventArgs);
				if (!eventArgs.IsValid)
				{
					e.Cancel = true;
				}
			}
		}

		// Token: 0x0600297A RID: 10618 RVA: 0x0000A641 File Offset: 0x00008841
		private void OKBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
		}

		// Token: 0x0600297B RID: 10619 RVA: 0x00006181 File Offset: 0x00004381
		private void CancelBtn_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x04001586 RID: 5510
		private EventHandler<EventArgs43<PointF>> eventHandler_0;
	}
}
