using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns16;
using ns17;
using ns19;
using ns20;
using ns22;
using ns23;
using ns28;

namespace ns30
{
	// Token: 0x020001DE RID: 478
	internal sealed partial class RegionSelector : Form
	{
		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060015CF RID: 5583 RVA: 0x00006054 File Offset: 0x00004254
		// (set) Token: 0x060015D0 RID: 5584 RVA: 0x0000605C File Offset: 0x0000425C
		public Size MinimumSelectionSize { get; set; }

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00006065 File Offset: 0x00004265
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00006072 File Offset: 0x00004272
		public string LockedMessage
		{
			get
			{
				return this.RegionSelectorControl.LockedMessage;
			}
			set
			{
				this.RegionSelectorControl.LockedMessage = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00006080 File Offset: 0x00004280
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x0000608D File Offset: 0x0000428D
		public string MovableMessage
		{
			get
			{
				return this.RegionSelectorControl.MovableMessage;
			}
			set
			{
				this.RegionSelectorControl.MovableMessage = value;
			}
		}

		// Token: 0x170006DD RID: 1757
		// (get) Token: 0x060015D5 RID: 5589 RVA: 0x0000609B File Offset: 0x0000429B
		// (set) Token: 0x060015D6 RID: 5590 RVA: 0x000060A8 File Offset: 0x000042A8
		public string MovableResizeMessage
		{
			get
			{
				return this.RegionSelectorControl.MovableResizeMessage;
			}
			set
			{
				this.RegionSelectorControl.MovableResizeMessage = value;
			}
		}

		// Token: 0x170006DE RID: 1758
		// (get) Token: 0x060015D7 RID: 5591 RVA: 0x000060B6 File Offset: 0x000042B6
		// (set) Token: 0x060015D8 RID: 5592 RVA: 0x000060BE File Offset: 0x000042BE
		public bool FullScreenCapture { get; set; }

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x060015D9 RID: 5593 RVA: 0x000060C7 File Offset: 0x000042C7
		// (set) Token: 0x060015DA RID: 5594 RVA: 0x000060CF File Offset: 0x000042CF
		public bool FullSize { get; set; }

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x060015DB RID: 5595 RVA: 0x000060D8 File Offset: 0x000042D8
		// (set) Token: 0x060015DC RID: 5596 RVA: 0x000060E0 File Offset: 0x000042E0
		public bool FullSelect { get; set; }

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x060015DD RID: 5597 RVA: 0x000060E9 File Offset: 0x000042E9
		// (set) Token: 0x060015DE RID: 5598 RVA: 0x000060F1 File Offset: 0x000042F1
		public Enum124 RegionSelectorType { get; set; }

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x060015DF RID: 5599 RVA: 0x000060FA File Offset: 0x000042FA
		// (set) Token: 0x060015E0 RID: 5600 RVA: 0x00006102 File Offset: 0x00004302
		public Rectangle SelectedRegion { get; set; }

		// Token: 0x170006E3 RID: 1763
		// (get) Token: 0x060015E1 RID: 5601 RVA: 0x0000610B File Offset: 0x0000430B
		// (set) Token: 0x060015E2 RID: 5602 RVA: 0x00006113 File Offset: 0x00004313
		public Rectangle SelectionBounds { get; set; }

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060015E3 RID: 5603 RVA: 0x000323D4 File Offset: 0x000305D4
		public Class125 SelectedBitmap
		{
			get
			{
				if (this.RegionSelectorControl.SelectedRegion.Size != Size.Empty)
				{
					Bitmap screenCapture = this.RegionSelectorControl.ScreenCapture;
					if (screenCapture != null)
					{
						Class125 @class = null;
						try
						{
							using (Class125 class2 = new Class125(screenCapture))
							{
								class2.method_6(this.RegionSelectorControl.SelectedRegion, out @class);
							}
						}
						catch (Exception ex)
						{
							if (@class != null)
							{
								@class.Dispose();
							}
							@class = null;
							DialogBox.smethod_4(RegionSelector.string_0, RegionSelector.string_1);
							ex.smethod_0();
						}
						return @class;
					}
					DialogBox.smethod_4(RegionSelector.string_2, RegionSelector.string_1);
				}
				return null;
			}
		}

		// Token: 0x060015E4 RID: 5604 RVA: 0x0000611C File Offset: 0x0000431C
		public RegionSelector()
		{
			this.bool_0 = false;
			this.class141_0 = new Class141();
			this.InitializeComponent();
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x0000613C File Offset: 0x0000433C
		public RegionSelector(IntPtr hWnd) : this()
		{
			this.bool_0 = (hWnd != IntPtr.Zero);
			this.class141_0.MainWindowHandle = hWnd;
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x00006161 File Offset: 0x00004361
		private void method_0()
		{
			DialogBox.smethod_4("Screen capture has failed, check if the process is still running and try again.", "Capture Failure");
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x00032490 File Offset: 0x00030690
		private void RegionSelector_Load(object sender, EventArgs e)
		{
			this.RegionSelectorControl.BackgroundOverlayColor = Color.FromArgb(180, Color.Black);
			this.RegionSelectorControl.BorderColor = Color.FromArgb(255, Color.Red);
			this.RegionSelectorControl.WindowRegionOverlayColor = Color.FromArgb(90, 255, 128, 64);
			this.RegionSelectorControl.CloseMessageTextColor = Color.FromArgb(200, Color.Red);
			this.RegionSelectorControl.CloseMessageBorderTextColor = Color.FromArgb(200, Color.Black);
			this.RegionSelectorControl.SelectorType = this.RegionSelectorType;
			this.RegionSelectorControl.FullScreen = this.FullScreenCapture;
			if (this.bool_0 && !this.class141_0.ProcessOpen)
			{
				this.method_0();
				return;
			}
			IntPtr mainWindowHandle = this.class141_0.MainWindowHandle;
			if (this.FullScreenCapture)
			{
				try
				{
					this.RegionSelectorControl.ScreenCapture = (this.bitmap_0 = Class364.smethod_0());
				}
				catch (Exception ex)
				{
					ex.smethod_0();
					this.method_0();
					return;
				}
				if (!this.bool_0)
				{
					if (this.FullSize)
					{
						this.RegionSelectorControl.SelectionBounds = new Rectangle(Point.Empty, SystemInformation.VirtualScreen.Size);
					}
					else
					{
						this.RegionSelectorControl.SelectionBounds = this.SelectionBounds;
					}
					if (this.FullSelect)
					{
						this.RegionSelectorControl.SelectedRegion = new Rectangle(Point.Empty, this.RegionSelectorControl.SelectionBounds.Size).smethod_1(this.RegionSelectorControl.SelectionBounds);
					}
					else
					{
						this.RegionSelectorControl.SelectedRegion = this.SelectedRegion.smethod_1(this.RegionSelectorControl.SelectionBounds);
					}
				}
				else
				{
					try
					{
						this.rectangle_0 = Class410.smethod_16(mainWindowHandle);
					}
					catch (Exception ex2)
					{
						ex2.smethod_0();
						this.method_0();
						return;
					}
					if (SystemInformation.VirtualScreen.X < 0)
					{
						this.rectangle_0.X = this.rectangle_0.X - SystemInformation.VirtualScreen.X;
					}
					if (SystemInformation.VirtualScreen.Y < 0)
					{
						this.rectangle_0.Y = this.rectangle_0.Y - SystemInformation.VirtualScreen.Y;
					}
					if (this.FullSize)
					{
						this.RegionSelectorControl.SelectionBounds = this.rectangle_0;
					}
					else
					{
						this.RegionSelectorControl.SelectionBounds = new Rectangle(this.SelectionBounds.Location.smethod_10(this.rectangle_0.Location), this.SelectionBounds.Size);
					}
					if (this.FullSelect)
					{
						this.RegionSelectorControl.SelectedRegion = this.RegionSelectorControl.SelectionBounds;
					}
					else
					{
						this.RegionSelectorControl.SelectedRegion = new Rectangle(this.SelectedRegion.Location.smethod_10(this.rectangle_0.Location), this.SelectedRegion.Size).smethod_1(this.RegionSelectorControl.SelectionBounds);
					}
				}
				base.FormBorderStyle = FormBorderStyle.None;
				base.Location = SystemInformation.VirtualScreen.Location;
				base.Size = SystemInformation.VirtualScreen.Size;
			}
			else if (!this.bool_0)
			{
				if (this.FullSize)
				{
					try
					{
						this.RegionSelectorControl.ScreenCapture = (this.bitmap_0 = Class364.smethod_0());
					}
					catch (Exception ex3)
					{
						ex3.smethod_0();
						this.method_0();
						return;
					}
					this.RegionSelectorControl.SelectionBounds = this.SelectionBounds;
					base.Size = SystemInformation.VirtualScreen.Size;
				}
				else
				{
					try
					{
						this.RegionSelectorControl.ScreenCapture = (this.bitmap_0 = Class364.smethod_1(this.SelectionBounds.smethod_8()));
					}
					catch (Exception ex4)
					{
						ex4.smethod_0();
						this.method_0();
						return;
					}
					this.RegionSelectorControl.SelectionBounds = new Rectangle(Point.Empty, this.SelectionBounds.Size);
					base.Size = this.SelectionBounds.Size;
				}
				if (this.FullSelect)
				{
					this.RegionSelectorControl.SelectedRegion = new Rectangle(Point.Empty, this.RegionSelectorControl.SelectionBounds.Size);
				}
				else
				{
					this.RegionSelectorControl.SelectedRegion = new Rectangle(this.SelectedRegion.Location.smethod_11(this.SelectionBounds.Location), this.SelectedRegion.Size).smethod_1(this.RegionSelectorControl.SelectionBounds);
				}
				base.FormBorderStyle = FormBorderStyle.Fixed3D;
				base.CenterToScreen();
			}
			else
			{
				if (this.FullSize)
				{
					try
					{
						this.RegionSelectorControl.ScreenCapture = (this.bitmap_0 = Class364.smethod_2(mainWindowHandle));
						this.RegionSelectorControl.SelectionBounds = new Rectangle(Point.Empty, Class410.smethod_18(mainWindowHandle));
					}
					catch (Exception ex5)
					{
						ex5.smethod_0();
						this.method_0();
						return;
					}
					base.Size = this.RegionSelectorControl.SelectionBounds.Size;
					base.FormBorderStyle = FormBorderStyle.Fixed3D;
					try
					{
						base.Location = Class410.smethod_14(mainWindowHandle).Location;
						goto IL_60F;
					}
					catch (Exception ex6)
					{
						ex6.smethod_0();
						this.method_0();
						return;
					}
				}
				try
				{
					this.RegionSelectorControl.ScreenCapture = (this.bitmap_0 = Class364.smethod_3(mainWindowHandle, this.SelectionBounds));
				}
				catch (Exception ex7)
				{
					ex7.smethod_0();
					this.method_0();
					return;
				}
				this.RegionSelectorControl.SelectionBounds = new Rectangle(Point.Empty, this.SelectionBounds.Size);
				base.Size = this.SelectionBounds.Size;
				base.FormBorderStyle = FormBorderStyle.Fixed3D;
				try
				{
					base.Location = Class410.smethod_14(mainWindowHandle).Location.smethod_10(this.SelectionBounds.Location);
				}
				catch (Exception ex8)
				{
					ex8.smethod_0();
					this.method_0();
					return;
				}
				IL_60F:
				if (this.FullSelect)
				{
					this.RegionSelectorControl.SelectedRegion = new Rectangle(Point.Empty, this.RegionSelectorControl.SelectionBounds.Size);
				}
				else
				{
					this.RegionSelectorControl.SelectedRegion = new Rectangle(this.SelectedRegion.Location.smethod_11(this.SelectionBounds.Location), this.SelectedRegion.Size);
				}
			}
			base.TopMost = true;
			base.BringToFront();
			base.Activate();
			switch (this.RegionSelectorType)
			{
			case Enum124.const_0:
				this.toolTip_0.SetToolTip(this.RegionSelectorControl, this.MovableResizeMessage);
				break;
			case Enum124.const_1:
				this.toolTip_0.SetToolTip(this.RegionSelectorControl, this.MovableMessage);
				break;
			case Enum124.const_2:
				this.toolTip_0.SetToolTip(this.RegionSelectorControl, this.LockedMessage);
				break;
			}
			this.RegionSelectorControl.Focus();
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x00006179 File Offset: 0x00004379
		private void cmnuAccept_Click(object sender, EventArgs e)
		{
			this.method_2();
		}

		// Token: 0x060015E9 RID: 5609 RVA: 0x00006181 File Offset: 0x00004381
		private void cmnuCancel_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x0000618A File Offset: 0x0000438A
		private void RegionSelectorControl_KeyDown(object sender, KeyEventArgs e)
		{
			this.method_1(e);
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00032C0C File Offset: 0x00030E0C
		private void method_1(KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode == Keys.Escape)
			{
				base.DialogResult = DialogResult.Cancel;
				base.Close();
				return;
			}
			this.method_2();
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00032C3C File Offset: 0x00030E3C
		private void method_2()
		{
			if (this.RegionSelectorControl.SelectedRegion.Width >= this.MinimumSelectionSize.Width && this.RegionSelectorControl.SelectedRegion.Height >= this.MinimumSelectionSize.Width)
			{
				if (this.FullScreenCapture)
				{
					if (!this.bool_0)
					{
						this.SelectedRegion = this.RegionSelectorControl.SelectedRegion;
					}
					else
					{
						this.SelectedRegion = new Rectangle(this.RegionSelectorControl.SelectedRegion.Location.smethod_11(this.rectangle_0.Location), this.RegionSelectorControl.SelectedRegion.Size);
					}
				}
				else if (!this.bool_0)
				{
					this.SelectedRegion = new Rectangle(this.RegionSelectorControl.SelectedRegion.Location.smethod_10(this.SelectionBounds.Location), this.RegionSelectorControl.SelectedRegion.Size);
				}
				else
				{
					this.SelectedRegion = new Rectangle(this.RegionSelectorControl.SelectedRegion.Location.smethod_10(this.SelectionBounds.Location), this.RegionSelectorControl.SelectedRegion.Size);
				}
				base.DialogResult = DialogResult.OK;
				return;
			}
			DialogBox.smethod_3(string.Format(Class217.cultureInfo_0, RegionSelector.string_4, new object[]
			{
				this.MinimumSelectionSize,
				this.RegionSelectorControl.SelectedRegion.Size
			}), RegionSelector.string_3);
		}

		// Token: 0x04000321 RID: 801
		private static readonly string string_0 = "There was an error creating an sub-image object from the selected region.";

		// Token: 0x04000322 RID: 802
		private static readonly string string_1 = "Check the Log for More Information";

		// Token: 0x04000323 RID: 803
		private static readonly string string_2 = "There was an error capturing the selected region.";

		// Token: 0x04000324 RID: 804
		private static readonly string string_3 = "Invalid Size";

		// Token: 0x04000325 RID: 805
		private static readonly string string_4 = "Please make a selection with a size of at least '{0}'. Currently: '{1}'.";

		// Token: 0x04000327 RID: 807
		private Rectangle rectangle_0;

		// Token: 0x04000328 RID: 808
		private bool bool_0;

		// Token: 0x04000330 RID: 816
		[CompilerGenerated]
		private Size size_0;

		// Token: 0x04000331 RID: 817
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000332 RID: 818
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000333 RID: 819
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x04000334 RID: 820
		[CompilerGenerated]
		private Enum124 enum124_0;

		// Token: 0x04000335 RID: 821
		[CompilerGenerated]
		private Rectangle rectangle_1;

		// Token: 0x04000336 RID: 822
		[CompilerGenerated]
		private Rectangle rectangle_2;
	}
}
