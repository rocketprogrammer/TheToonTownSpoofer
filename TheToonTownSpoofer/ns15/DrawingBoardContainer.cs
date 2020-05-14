using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns16;
using ns18;
using ns24;
using ns28;

namespace ns15
{
	// Token: 0x02000217 RID: 535
	internal sealed class DrawingBoardContainer : UserControl
	{
		// Token: 0x06001768 RID: 5992 RVA: 0x000071E4 File Offset: 0x000053E4
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x0003D410 File Offset: 0x0003B610
		private void InitializeComponent()
		{
			this.BoardVScroll = new VScrollBar();
			this.BoardLayout = new TableLayoutPanel();
			this.BoardHScroll = new HScrollBar();
			this.BoardRenderer = new Control7();
			this.BoardLayout.SuspendLayout();
			base.SuspendLayout();
			this.BoardVScroll.Dock = DockStyle.Right;
			this.BoardVScroll.Enabled = false;
			this.BoardVScroll.LargeChange = 1;
			this.BoardVScroll.Location = new Point(183, 0);
			this.BoardVScroll.Maximum = 0;
			this.BoardVScroll.Name = "BoardVScroll";
			this.BoardVScroll.Size = new Size(17, 183);
			this.BoardVScroll.TabIndex = 1;
			this.BoardVScroll.ValueChanged += this.BoardHScroll_ValueChanged;
			this.BoardLayout.AutoSize = true;
			this.BoardLayout.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.BoardLayout.ColumnCount = 2;
			this.BoardLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f));
			this.BoardLayout.ColumnStyles.Add(new ColumnStyle());
			this.BoardLayout.Controls.Add(this.BoardVScroll, 1, 0);
			this.BoardLayout.Controls.Add(this.BoardHScroll, 0, 1);
			this.BoardLayout.Controls.Add(this.BoardRenderer, 0, 0);
			this.BoardLayout.Dock = DockStyle.Fill;
			this.BoardLayout.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
			this.BoardLayout.Location = new Point(0, 0);
			this.BoardLayout.Name = "BoardLayout";
			this.BoardLayout.RowCount = 2;
			this.BoardLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100f));
			this.BoardLayout.RowStyles.Add(new RowStyle());
			this.BoardLayout.Size = new Size(200, 200);
			this.BoardLayout.TabIndex = 3;
			this.BoardHScroll.Dock = DockStyle.Bottom;
			this.BoardHScroll.Enabled = false;
			this.BoardHScroll.LargeChange = 1;
			this.BoardHScroll.Location = new Point(0, 183);
			this.BoardHScroll.Maximum = 0;
			this.BoardHScroll.Name = "BoardHScroll";
			this.BoardHScroll.Size = new Size(183, 17);
			this.BoardHScroll.TabIndex = 2;
			this.BoardHScroll.ValueChanged += this.BoardHScroll_ValueChanged;
			this.BoardRenderer.Dock = DockStyle.Fill;
			this.BoardRenderer.DrawingTool = Enum125.const_0;
			this.BoardRenderer.DrawingToolSize = Enum61.const_2;
			this.BoardRenderer.Location = new Point(3, 3);
			this.BoardRenderer.Name = "BoardRenderer";
			this.BoardRenderer.Origin = new Point(0, 0);
			this.BoardRenderer.PanButton = MouseButtons.Right;
			this.BoardRenderer.Size = new Size(177, 177);
			this.BoardRenderer.TabIndex = 3;
			this.BoardRenderer.ZoomFactor = 1f;
			this.BoardRenderer.ScrollPosChanged += this.method_4;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.BoardLayout);
			base.Name = "DrawingBoardContainer";
			base.Size = new Size(200, 200);
			this.BoardLayout.ResumeLayout(false);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00007203 File Offset: 0x00005403
		public DrawingBoardContainer()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000724 RID: 1828
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x00007211 File Offset: 0x00005411
		// (set) Token: 0x0600176C RID: 5996 RVA: 0x0000721E File Offset: 0x0000541E
		[DefaultValue(typeof(Bitmap), null)]
		public Bitmap Image
		{
			get
			{
				return this.BoardRenderer.Image;
			}
			set
			{
				this.BoardRenderer.Image = value;
			}
		}

		// Token: 0x17000725 RID: 1829
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x0000722C File Offset: 0x0000542C
		public Bitmap Overlay
		{
			get
			{
				return this.BoardRenderer.Overlay;
			}
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x00007239 File Offset: 0x00005439
		public Class95<T> method_0<T>() where T : Interface17
		{
			return this.BoardRenderer.method_1<T>();
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x00007246 File Offset: 0x00005446
		public void method_1<T>(Class95<T> value) where T : Interface17
		{
			this.BoardRenderer.method_2<T>(value);
		}

		// Token: 0x17000726 RID: 1830
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00007254 File Offset: 0x00005454
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00007261 File Offset: 0x00005461
		public Enum61 DrawingToolSize
		{
			get
			{
				return this.BoardRenderer.DrawingToolSize;
			}
			set
			{
				this.BoardRenderer.DrawingToolSize = value;
			}
		}

		// Token: 0x17000727 RID: 1831
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x0000726F File Offset: 0x0000546F
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x0000727C File Offset: 0x0000547C
		public Enum125 DrawingTool
		{
			get
			{
				return this.BoardRenderer.DrawingTool;
			}
			set
			{
				this.BoardRenderer.DrawingTool = value;
			}
		}

		// Token: 0x06001774 RID: 6004 RVA: 0x0000728A File Offset: 0x0000548A
		public void method_2()
		{
			this.BoardRenderer.method_11();
		}

		// Token: 0x06001775 RID: 6005 RVA: 0x00007297 File Offset: 0x00005497
		public void method_3()
		{
			this.BoardRenderer.method_12();
		}

		// Token: 0x06001776 RID: 6006 RVA: 0x0003D7D4 File Offset: 0x0003B9D4
		private void method_4(object sender, EventArgs e)
		{
			if (this.BoardRenderer.Image == null)
			{
				this.BoardHScroll.Enabled = false;
				this.BoardHScroll.Value = 0;
				this.BoardVScroll.Enabled = false;
				this.BoardVScroll.Value = 0;
				return;
			}
			int width = this.BoardRenderer.Image.Width;
			int height = this.BoardRenderer.Image.Height;
			int x = this.BoardRenderer.Origin.X;
			int y = this.BoardRenderer.Origin.Y;
			int num = (int)Math.Ceiling((double)((float)this.BoardRenderer.Width / this.BoardRenderer.ZoomFactor));
			int num2 = (int)Math.Ceiling((double)((float)this.BoardRenderer.Height / this.BoardRenderer.ZoomFactor));
			this.BoardHScroll.Maximum = width;
			this.BoardVScroll.Maximum = height;
			if (num >= width)
			{
				this.BoardHScroll.Enabled = false;
				this.BoardHScroll.Value = 0;
			}
			else
			{
				this.BoardHScroll.LargeChange = num;
				this.BoardHScroll.Enabled = true;
				this.BoardHScroll.Value = x;
			}
			if (num2 >= height)
			{
				this.BoardVScroll.Enabled = false;
				this.BoardVScroll.Value = 0;
				return;
			}
			this.BoardVScroll.Enabled = true;
			this.BoardVScroll.LargeChange = num2;
			this.BoardVScroll.Value = y;
		}

		// Token: 0x06001777 RID: 6007 RVA: 0x000072A4 File Offset: 0x000054A4
		private void BoardHScroll_ValueChanged(object sender, EventArgs e)
		{
			this.BoardRenderer.Origin = new Point(this.BoardHScroll.Value, this.BoardVScroll.Value);
		}

		// Token: 0x040005A3 RID: 1443
		private IContainer icontainer_0;

		// Token: 0x040005A4 RID: 1444
		private VScrollBar BoardVScroll;

		// Token: 0x040005A5 RID: 1445
		private TableLayoutPanel BoardLayout;

		// Token: 0x040005A6 RID: 1446
		private HScrollBar BoardHScroll;

		// Token: 0x040005A7 RID: 1447
		private Control7 BoardRenderer;
	}
}
