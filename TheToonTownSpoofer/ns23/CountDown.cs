using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns17;

namespace ns23
{
	// Token: 0x0200038E RID: 910
	internal sealed partial class CountDown : Form0
	{
		// Token: 0x140001B3 RID: 435
		// (add) Token: 0x0600238A RID: 9098 RVA: 0x000780A8 File Offset: 0x000762A8
		// (remove) Token: 0x0600238B RID: 9099 RVA: 0x000780E0 File Offset: 0x000762E0
		public event EventHandler CountDownCompleted
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

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600238C RID: 9100 RVA: 0x0000F341 File Offset: 0x0000D541
		// (set) Token: 0x0600238D RID: 9101 RVA: 0x0000F349 File Offset: 0x0000D549
		public int SecondsRemaining { get; set; }

		// Token: 0x0600238E RID: 9102 RVA: 0x0000F352 File Offset: 0x0000D552
		private void method_1()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600238F RID: 9103 RVA: 0x0000F36D File Offset: 0x0000D56D
		public CountDown()
		{
			this.InitializeComponent();
			this.SecondsRemaining = 3;
			base.CustomPainting = true;
			this.UseOpacity = true;
		}

		// Token: 0x06002390 RID: 9104 RVA: 0x0000F390 File Offset: 0x0000D590
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.SecondsRemaining--;
			if (this.SecondsRemaining == 0)
			{
				this.timer_0.Stop();
				this.method_1();
				base.DialogResult = DialogResult.OK;
				return;
			}
			base.method_0();
		}

		// Token: 0x06002391 RID: 9105 RVA: 0x00078118 File Offset: 0x00076318
		protected override void vmethod_0(Graphics gr)
		{
			gr.SmoothingMode = SmoothingMode.AntiAlias;
			gr.TextRenderingHint = TextRenderingHint.AntiAlias;
			float emSize = gr.DpiY * this.Font.SizeInPoints / 72f;
			SizeF sizeF = gr.MeasureString(this.SecondsRemaining.ToString(Class217.cultureInfo_0), this.Font);
			PointF pointF = new PointF((float)base.Width / 2f, (float)base.Height / 2f);
			using (GraphicsPath graphicsPath = new GraphicsPath())
			{
				graphicsPath.AddString(this.SecondsRemaining.ToString(Class217.cultureInfo_0), this.Font.FontFamily, 0, emSize, new PointF(pointF.X - sizeF.Width / 2f, pointF.Y - sizeF.Height / 2f), StringFormat.GenericDefault);
				gr.FillPath(Brushes.White, graphicsPath);
				using (Pen pen = new Pen(Color.Black, 2f))
				{
					gr.DrawPath(pen, graphicsPath);
				}
			}
		}

		// Token: 0x06002392 RID: 9106 RVA: 0x0000F3C7 File Offset: 0x0000D5C7
		private void CountDown_KeyPress(object sender, KeyPressEventArgs e)
		{
			this.timer_0.Stop();
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x06002393 RID: 9107 RVA: 0x0000F3DB File Offset: 0x0000D5DB
		private void CountDown_Shown(object sender, EventArgs e)
		{
			this.timer_0.Start();
		}

		// Token: 0x04001059 RID: 4185
		private EventHandler eventHandler_0;

		// Token: 0x0400105A RID: 4186
		[CompilerGenerated]
		private int int_0;
	}
}
