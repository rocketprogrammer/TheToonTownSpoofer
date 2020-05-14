using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using ns10;
using ns12;
using ns13;
using ns18;
using ns23;
using ns28;
using ns3;

namespace ns25
{
	// Token: 0x0200034B RID: 843
	internal sealed class LimitedMediaPlayer : UserControl
	{
		// Token: 0x060020B7 RID: 8375 RVA: 0x0000D4B5 File Offset: 0x0000B6B5
		protected override void Dispose(bool disposing)
		{
			this.method_4();
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060020B8 RID: 8376 RVA: 0x0006E94C File Offset: 0x0006CB4C
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LimitedMediaPlayer));
			this.btnMute = new Button();
			this.btnUnMute = new Button();
			this.btnStop = new Button();
			this.btnPlay = new Button();
			this.btnPause = new Button();
			this.timer_0 = new Timer(this.icontainer_0);
			this.lblTime = new Label();
			this.wmpMain = new Class24();
			this.sldVolume = new Control11();
			((ISupportInitialize)this.wmpMain).BeginInit();
			base.SuspendLayout();
			this.btnMute.Anchor = AnchorStyles.None;
			this.btnMute.Image = (Image)componentResourceManager.GetObject("btnMute.Image");
			this.btnMute.Location = new Point(60, 2);
			this.btnMute.Name = "btnMute";
			this.btnMute.Size = new Size(28, 28);
			this.btnMute.TabIndex = 10;
			this.btnMute.TabStop = false;
			this.btnMute.UseVisualStyleBackColor = true;
			this.btnMute.Click += this.btnMute_Click;
			this.btnUnMute.Anchor = AnchorStyles.None;
			this.btnUnMute.Image = (Image)componentResourceManager.GetObject("btnUnMute.Image");
			this.btnUnMute.Location = new Point(60, 2);
			this.btnUnMute.Name = "btnUnMute";
			this.btnUnMute.Size = new Size(28, 28);
			this.btnUnMute.TabIndex = 10;
			this.btnUnMute.TabStop = false;
			this.btnUnMute.UseVisualStyleBackColor = true;
			this.btnUnMute.Click += this.btnUnMute_Click;
			this.btnStop.Anchor = AnchorStyles.None;
			this.btnStop.Image = (Image)componentResourceManager.GetObject("btnStop.Image");
			this.btnStop.Location = new Point(32, 2);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new Size(28, 28);
			this.btnStop.TabIndex = 11;
			this.btnStop.TabStop = false;
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += this.btnStop_Click;
			this.btnPlay.Anchor = AnchorStyles.None;
			this.btnPlay.Image = (Image)componentResourceManager.GetObject("btnPlay.Image");
			this.btnPlay.Location = new Point(4, 2);
			this.btnPlay.Name = "btnPlay";
			this.btnPlay.Size = new Size(28, 28);
			this.btnPlay.TabIndex = 11;
			this.btnPlay.TabStop = false;
			this.btnPlay.UseVisualStyleBackColor = true;
			this.btnPlay.Click += this.btnPlay_Click;
			this.btnPause.Anchor = AnchorStyles.None;
			this.btnPause.Image = (Image)componentResourceManager.GetObject("btnPause.Image");
			this.btnPause.Location = new Point(4, 2);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new Size(28, 28);
			this.btnPause.TabIndex = 12;
			this.btnPause.TabStop = false;
			this.btnPause.UseVisualStyleBackColor = true;
			this.btnPause.Click += this.btnPause_Click;
			this.timer_0.Interval = 750;
			this.timer_0.Tick += this.timer_0_Tick;
			this.lblTime.Anchor = AnchorStyles.None;
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new Point(146, 10);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new Size(60, 13);
			this.lblTime.TabIndex = 13;
			this.lblTime.Text = "0:00 / 0:00";
			this.wmpMain.Enabled = true;
			this.wmpMain.Location = new Point(0, 100);
			this.wmpMain.Name = "wmpMain";
			this.wmpMain.OcxState = (AxHost.State)componentResourceManager.GetObject("wmpMain.OcxState");
			this.wmpMain.Size = new Size(224, 50);
			this.wmpMain.TabIndex = 2;
			this.wmpMain.Visible = false;
			this.wmpMain.method_0(new Delegate152(this.method_9));
			this.sldVolume.Anchor = AnchorStyles.None;
			this.sldVolume.Location = new Point(89, 5);
			this.sldVolume.MaxValue = 100f;
			this.sldVolume.Name = "sldVolume";
			this.sldVolume.Size = new Size(51, 22);
			this.sldVolume.TabIndex = 9;
			this.sldVolume.TabStop = false;
			this.sldVolume.Text = "slider1";
			this.sldVolume.TrackerColor = Color.FromArgb(24, 130, 198);
			this.sldVolume.TrackLineColor = Color.FromArgb(90, 93, 90);
			this.sldVolume.Value = 50f;
			this.sldVolume.ValueChanged += this.method_8;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.White;
			base.BorderStyle = BorderStyle.FixedSingle;
			base.Controls.Add(this.wmpMain);
			base.Controls.Add(this.lblTime);
			base.Controls.Add(this.btnPlay);
			base.Controls.Add(this.btnStop);
			base.Controls.Add(this.btnUnMute);
			base.Controls.Add(this.btnMute);
			base.Controls.Add(this.sldVolume);
			base.Controls.Add(this.btnPause);
			base.Name = "LimitedMediaPlayer";
			base.Size = new Size(224, 34);
			((ISupportInitialize)this.wmpMain).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x060020B9 RID: 8377 RVA: 0x0006EFD8 File Offset: 0x0006D1D8
		public LimitedMediaPlayer()
		{
			this.InitializeComponent();
			this.wmpMain.vmethod_3().autoStart = false;
			this.sldVolume.Value = (float)this.wmpMain.vmethod_3().volume;
			this.method_5();
			this.method_6();
		}

		// Token: 0x060020BA RID: 8378 RVA: 0x0006F02C File Offset: 0x0006D22C
		public void method_0(string fileName, byte[] data)
		{
			this.method_2();
			this.string_0 = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString() + Path.GetExtension(fileName));
			this.method_3(data);
		}

		// Token: 0x060020BB RID: 8379 RVA: 0x0006F074 File Offset: 0x0006D274
		public void method_1()
		{
			this.wmpMain.vmethod_0(string.Empty);
			this.btnPause.Visible = false;
			this.btnPlay.Visible = true;
			this.btnPlay.Enabled = false;
			this.btnStop.Enabled = false;
		}

		// Token: 0x060020BC RID: 8380 RVA: 0x0000D4DA File Offset: 0x0000B6DA
		public void method_2()
		{
			this.method_1();
			this.method_4();
		}

		// Token: 0x060020BD RID: 8381 RVA: 0x0006F0C4 File Offset: 0x0006D2C4
		private void method_3(byte[] data)
		{
			if (!this.bool_0)
			{
				bool flag = false;
				try
				{
					Class234.smethod_9(data, this.string_0);
					flag = true;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						string.Format("Error saving file: {0}", this.string_0)
					});
				}
				if (flag)
				{
					this.bool_0 = true;
					this.wmpMain.vmethod_0(this.string_0);
					return;
				}
				this.wmpMain.vmethod_0("");
			}
		}

		// Token: 0x060020BE RID: 8382 RVA: 0x0006F14C File Offset: 0x0006D34C
		private void method_4()
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				try
				{
					File.Delete(this.string_0);
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						string.Format("failure to delete: '{0}'", this.string_0)
					});
				}
			}
		}

		// Token: 0x060020BF RID: 8383 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		private void method_5()
		{
			this.btnUnMute.Visible = this.wmpMain.vmethod_3().mute;
			this.btnMute.Visible = !this.wmpMain.vmethod_3().mute;
		}

		// Token: 0x060020C0 RID: 8384 RVA: 0x0006F1AC File Offset: 0x0006D3AC
		private void method_6()
		{
			switch (this.wmpMain.vmethod_1())
			{
			case Enum10.const_1:
			case Enum10.const_8:
				this.btnStop.Enabled = false;
				this.btnPlay.Visible = true;
				this.btnPlay.Enabled = true;
				this.btnPause.Visible = false;
				this.timer_0.Enabled = false;
				goto IL_162;
			case Enum10.const_2:
				this.btnStop.Enabled = true;
				this.btnPlay.Visible = true;
				this.btnPause.Visible = false;
				this.timer_0.Enabled = false;
				goto IL_162;
			case Enum10.const_3:
				this.btnStop.Enabled = true;
				this.btnPlay.Visible = false;
				this.btnPause.Visible = true;
				this.timer_0.Enabled = true;
				goto IL_162;
			case Enum10.const_6:
			case Enum10.const_7:
			case Enum10.const_9:
			case Enum10.const_10:
				this.btnStop.Enabled = false;
				this.btnPlay.Visible = true;
				this.btnPlay.Enabled = true;
				this.btnPause.Visible = false;
				this.timer_0.Enabled = false;
				goto IL_162;
			}
			this.btnStop.Enabled = false;
			this.btnPlay.Enabled = false;
			this.btnPlay.Visible = true;
			this.btnPause.Visible = false;
			this.timer_0.Enabled = false;
			IL_162:
			this.method_7();
		}

		// Token: 0x060020C1 RID: 8385 RVA: 0x0006F324 File Offset: 0x0006D524
		private void method_7()
		{
			try
			{
				if (this.wmpMain.vmethod_2().currentItem == null)
				{
					this.lblTime.Text = "00:00 / 00:00";
				}
				else
				{
					this.lblTime.Text = TimeSpan.FromSeconds(this.wmpMain.vmethod_2().currentPosition).ToString("mm\\:ss") + " / " + TimeSpan.FromSeconds(this.wmpMain.vmethod_2().currentItem.duration).ToString("mm\\:ss");
				}
			}
			catch (InvalidComObjectException)
			{
			}
		}

		// Token: 0x060020C2 RID: 8386 RVA: 0x0000D523 File Offset: 0x0000B723
		private void method_8(object sender, EventArgs e)
		{
			this.wmpMain.vmethod_3().volume = (int)this.sldVolume.Value;
		}

		// Token: 0x060020C3 RID: 8387 RVA: 0x0000D541 File Offset: 0x0000B741
		private void btnMute_Click(object sender, EventArgs e)
		{
			this.wmpMain.vmethod_3().mute = true;
			this.method_5();
		}

		// Token: 0x060020C4 RID: 8388 RVA: 0x0000D55A File Offset: 0x0000B75A
		private void btnUnMute_Click(object sender, EventArgs e)
		{
			this.wmpMain.vmethod_3().mute = false;
			this.method_5();
		}

		// Token: 0x060020C5 RID: 8389 RVA: 0x0000D573 File Offset: 0x0000B773
		private void btnPause_Click(object sender, EventArgs e)
		{
			this.wmpMain.vmethod_2().imethod_27();
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x0000D585 File Offset: 0x0000B785
		private void btnStop_Click(object sender, EventArgs e)
		{
			this.wmpMain.vmethod_2().imethod_26();
		}

		// Token: 0x060020C7 RID: 8391 RVA: 0x0000D597 File Offset: 0x0000B797
		private void btnPlay_Click(object sender, EventArgs e)
		{
			this.wmpMain.vmethod_2().imethod_25();
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x0000D5A9 File Offset: 0x0000B7A9
		private void method_9(object sender, Class57 e)
		{
			this.method_6();
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x0000D5B1 File Offset: 0x0000B7B1
		private void timer_0_Tick(object sender, EventArgs e)
		{
			this.method_7();
		}

		// Token: 0x04000D72 RID: 3442
		private IContainer icontainer_0;

		// Token: 0x04000D73 RID: 3443
		private Class24 wmpMain;

		// Token: 0x04000D74 RID: 3444
		private Control11 sldVolume;

		// Token: 0x04000D75 RID: 3445
		private Button btnMute;

		// Token: 0x04000D76 RID: 3446
		private Button btnUnMute;

		// Token: 0x04000D77 RID: 3447
		private Button btnStop;

		// Token: 0x04000D78 RID: 3448
		private Button btnPlay;

		// Token: 0x04000D79 RID: 3449
		private Button btnPause;

		// Token: 0x04000D7A RID: 3450
		private Timer timer_0;

		// Token: 0x04000D7B RID: 3451
		private Label lblTime;

		// Token: 0x04000D7C RID: 3452
		private string string_0;

		// Token: 0x04000D7D RID: 3453
		private bool bool_0;
	}
}
