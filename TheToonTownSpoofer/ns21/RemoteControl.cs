using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ns20;
using ns24;
using ns25;
using ns26;
using ns28;
using ns31;

namespace ns21
{
	// Token: 0x0200024C RID: 588
	internal sealed partial class RemoteControl : RemoteControlForm
	{
		// Token: 0x0600198F RID: 6543 RVA: 0x00045FD8 File Offset: 0x000441D8
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RemoteControl));
			base.SuspendLayout();
			base.AllowFormDrag = true;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Background = (Image)componentResourceManager.GetObject("$this.Background");
			base.BottomGreen_Image = (Image)componentResourceManager.GetObject("$this.BottomGreen_Image");
			base.BottomGreenBounds = new Rectangle(211, 76, 21, 20);
			base.ClientSize = new Size(320, 240);
			base.Close_Image = (Image)componentResourceManager.GetObject("$this.Close_Image");
			base.CloseBounds = new Rectangle(231, 150, 53, 58);
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			base.LeftBlue_Image = (Image)componentResourceManager.GetObject("$this.LeftBlue_Image");
			base.LeftBlueBounds = new Rectangle(193, 58, 22, 19);
			base.LeftController_BottomImage = (Image)componentResourceManager.GetObject("$this.LeftController_BottomImage");
			base.LeftController_BottomLeftImage = (Image)componentResourceManager.GetObject("$this.LeftController_BottomLeftImage");
			base.LeftController_BottomRightImage = (Image)componentResourceManager.GetObject("$this.LeftController_BottomRightImage");
			base.LeftController_LeftImage = (Image)componentResourceManager.GetObject("$this.LeftController_LeftImage");
			base.LeftController_RightImage = (Image)componentResourceManager.GetObject("$this.LeftController_RightImage");
			base.LeftController_TopImage = (Image)componentResourceManager.GetObject("$this.LeftController_TopImage");
			base.LeftController_TopLeftImage = (Image)componentResourceManager.GetObject("$this.LeftController_TopLeftImage");
			base.LeftController_TopRightImage = (Image)componentResourceManager.GetObject("$this.LeftController_TopRightImage");
			base.LeftControllerBounds = new Rectangle(64, 42, 67, 60);
			base.MaximizeBox = false;
			base.Name = "RemoteControl";
			base.RightController_BottomImage = (Image)componentResourceManager.GetObject("$this.RightController_BottomImage");
			base.RightController_BottomLeftImage = (Image)componentResourceManager.GetObject("$this.RightController_BottomLeftImage");
			base.RightController_BottomRightImage = (Image)componentResourceManager.GetObject("$this.RightController_BottomRightImage");
			base.RightController_LeftImage = (Image)componentResourceManager.GetObject("$this.RightController_LeftImage");
			base.RightController_RightImage = (Image)componentResourceManager.GetObject("$this.RightController_RightImage");
			base.RightController_TopImage = (Image)componentResourceManager.GetObject("$this.RightController_TopImage");
			base.RightController_TopLeftImage = (Image)componentResourceManager.GetObject("$this.RightController_TopLeftImage");
			base.RightController_TopRightImage = (Image)componentResourceManager.GetObject("$this.RightController_TopRightImage");
			base.RightControllerBounds = new Rectangle(133, 81, 137, 73);
			base.RightRed_Image = (Image)componentResourceManager.GetObject("$this.RightRed_Image");
			base.RightRedBounds = new Rectangle(228, 64, 15, 15);
			base.Setup_Image = (Image)componentResourceManager.GetObject("$this.Setup_Image");
			base.SetupBounds = new Rectangle(39, 152, 53, 58);
			base.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Multi-Toon Remote Controller";
			base.TopYellow_Image = (Image)componentResourceManager.GetObject("$this.TopYellow_Image");
			base.TopYellowBounds = new Rectangle(212, 47, 15, 15);
			base.SetupClicked += this.method_22;
			base.CloseClicked += this.method_21;
			base.HelpRequested += this.RemoteControl_HelpRequested;
			base.ResumeLayout(false);
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00008DEB File Offset: 0x00006FEB
		public RemoteControl()
		{
			this.InitializeComponent_1();
			this.class97_0 = Class110.Instance.RemoteControllerSettings;
			this.method_23();
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x000050D4 File Offset: 0x000032D4
		private void method_21(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00046360 File Offset: 0x00044560
		private void method_22(object sender, EventArgs e)
		{
			using (Class499 @class = new Class499(this))
			{
				using (RemoteControlSetup remoteControlSetup = new RemoteControlSetup())
				{
					@class.method_0(remoteControlSetup);
					remoteControlSetup.FirstSelectedWindow = base.FirstToonTownWindow;
					remoteControlSetup.SecondSelectedWindow = base.SecondToonTownWindow;
					remoteControlSetup.ShowDialog();
					base.FirstToonTownWindow = remoteControlSetup.FirstSelectedWindow;
					base.SecondToonTownWindow = remoteControlSetup.SecondSelectedWindow;
					this.method_23();
				}
			}
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x000463F4 File Offset: 0x000445F4
		private void method_23()
		{
			this.UseOpacity = this.class97_0.UseOpacity;
			base.AnimateController = this.class97_0.AnimateController;
			base.TopMost = this.class97_0.TopMost;
			base.KeyboardLayout = this.class97_0.KeyboardLayout;
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00008E0F File Offset: 0x0000700F
		private void RemoteControl_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_11);
			e.Handled = true;
		}

		// Token: 0x04000711 RID: 1809
		private Class97 class97_0;
	}
}
