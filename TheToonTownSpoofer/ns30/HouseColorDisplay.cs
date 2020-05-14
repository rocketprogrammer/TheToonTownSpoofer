using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns14;
using ns17;
using ns20;

namespace ns30
{
	// Token: 0x020001E0 RID: 480
	internal sealed class HouseColorDisplay : UserControl
	{
		// Token: 0x060015F7 RID: 5623 RVA: 0x00006233 File Offset: 0x00004433
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x00034504 File Offset: 0x00032704
		private void InitializeComponent()
		{
			this.SelectTitleLabel = new Label();
			this.ResultingSelectedHouseLabel = new Label();
			this.HideBtn = new Button();
			this.PurpleHouse = new Control1();
			this.GreenHouse = new Control1();
			this.YellowHouse = new Control1();
			this.PinkHouse = new Control1();
			this.BlueHouse = new Control1();
			this.RedHouse = new Control1();
			this.BackgroundBlue = new Control1();
			base.SuspendLayout();
			this.SelectTitleLabel.Location = new Point(8, 3);
			this.SelectTitleLabel.Name = "SelectTitleLabel";
			this.SelectTitleLabel.Size = new Size(184, 33);
			this.SelectTitleLabel.TabIndex = 1;
			this.SelectTitleLabel.Text = "Select your toon's slot on the \r\nPick A Toon To Play selector.";
			this.SelectTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
			this.ResultingSelectedHouseLabel.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.ResultingSelectedHouseLabel.Location = new Point(-1, 135);
			this.ResultingSelectedHouseLabel.Name = "ResultingSelectedHouseLabel";
			this.ResultingSelectedHouseLabel.Size = new Size(202, 19);
			this.ResultingSelectedHouseLabel.TabIndex = 2;
			this.ResultingSelectedHouseLabel.TextAlign = ContentAlignment.TopCenter;
			this.HideBtn.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.HideBtn.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.HideBtn.Location = new Point(179, 3);
			this.HideBtn.Name = "HideBtn";
			this.HideBtn.Size = new Size(18, 19);
			this.HideBtn.TabIndex = 4;
			this.HideBtn.Text = "X";
			this.HideBtn.UseVisualStyleBackColor = true;
			this.HideBtn.Click += this.HideBtn_Click;
			this.PurpleHouse.BackColor = Color.Purple;
			this.PurpleHouse.Cursor = Cursors.Hand;
			this.PurpleHouse.Location = new Point(125, 40);
			this.PurpleHouse.Name = "PurpleHouse";
			this.PurpleHouse.Size = new Size(40, 40);
			this.PurpleHouse.TabIndex = 0;
			this.PurpleHouse.Click += this.BackgroundBlue_Click;
			this.GreenHouse.BackColor = Color.Green;
			this.GreenHouse.Cursor = Cursors.Hand;
			this.GreenHouse.Location = new Point(80, 40);
			this.GreenHouse.Name = "GreenHouse";
			this.GreenHouse.Size = new Size(40, 40);
			this.GreenHouse.TabIndex = 0;
			this.GreenHouse.Click += this.BackgroundBlue_Click;
			this.YellowHouse.BackColor = Color.Yellow;
			this.YellowHouse.Cursor = Cursors.Hand;
			this.YellowHouse.Location = new Point(125, 86);
			this.YellowHouse.Name = "YellowHouse";
			this.YellowHouse.Size = new Size(40, 40);
			this.YellowHouse.TabIndex = 0;
			this.YellowHouse.Click += this.BackgroundBlue_Click;
			this.PinkHouse.BackColor = Color.Pink;
			this.PinkHouse.Cursor = Cursors.Hand;
			this.PinkHouse.Location = new Point(80, 86);
			this.PinkHouse.Name = "PinkHouse";
			this.PinkHouse.Size = new Size(40, 40);
			this.PinkHouse.TabIndex = 0;
			this.PinkHouse.Click += this.BackgroundBlue_Click;
			this.BlueHouse.BackColor = Color.Blue;
			this.BlueHouse.Cursor = Cursors.Hand;
			this.BlueHouse.Location = new Point(35, 86);
			this.BlueHouse.Name = "BlueHouse";
			this.BlueHouse.Size = new Size(40, 40);
			this.BlueHouse.TabIndex = 0;
			this.BlueHouse.Click += this.BackgroundBlue_Click;
			this.RedHouse.BackColor = Color.Red;
			this.RedHouse.Cursor = Cursors.Hand;
			this.RedHouse.Location = new Point(35, 40);
			this.RedHouse.Name = "RedHouse";
			this.RedHouse.Size = new Size(40, 40);
			this.RedHouse.TabIndex = 0;
			this.RedHouse.Click += this.BackgroundBlue_Click;
			this.BackgroundBlue.BackColor = Color.DodgerBlue;
			this.BackgroundBlue.Cursor = Cursors.Hand;
			this.BackgroundBlue.Location = new Point(30, 36);
			this.BackgroundBlue.Name = "BackgroundBlue";
			this.BackgroundBlue.Size = new Size(140, 95);
			this.BackgroundBlue.TabIndex = 0;
			this.BackgroundBlue.Click += this.BackgroundBlue_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = SystemColors.Control;
			base.BorderStyle = BorderStyle.FixedSingle;
			base.Controls.Add(this.HideBtn);
			base.Controls.Add(this.ResultingSelectedHouseLabel);
			base.Controls.Add(this.PurpleHouse);
			base.Controls.Add(this.GreenHouse);
			base.Controls.Add(this.YellowHouse);
			base.Controls.Add(this.PinkHouse);
			base.Controls.Add(this.BlueHouse);
			base.Controls.Add(this.RedHouse);
			base.Controls.Add(this.BackgroundBlue);
			base.Controls.Add(this.SelectTitleLabel);
			base.Name = "HouseColorDisplay";
			base.Size = new Size(200, 154);
			base.ResumeLayout(false);
		}

		// Token: 0x1400016B RID: 363
		// (add) Token: 0x060015F9 RID: 5625 RVA: 0x00034B4C File Offset: 0x00032D4C
		// (remove) Token: 0x060015FA RID: 5626 RVA: 0x00034B84 File Offset: 0x00032D84
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

		// Token: 0x060015FB RID: 5627 RVA: 0x00034BBC File Offset: 0x00032DBC
		public HouseColorDisplay()
		{
			this.InitializeComponent();
			this.dictionary_0 = new Dictionary<object, Enum13>();
			this.dictionary_0.Add(this.RedHouse, Enum13.const_0);
			this.dictionary_0.Add(this.GreenHouse, Enum13.const_1);
			this.dictionary_0.Add(this.PurpleHouse, Enum13.const_2);
			this.dictionary_0.Add(this.BlueHouse, Enum13.const_3);
			this.dictionary_0.Add(this.PinkHouse, Enum13.const_4);
			this.dictionary_0.Add(this.YellowHouse, Enum13.const_5);
		}

		// Token: 0x060015FC RID: 5628 RVA: 0x00006252 File Offset: 0x00004452
		private void BackgroundBlue_Click(object sender, EventArgs e)
		{
			if (this.dictionary_0.ContainsKey(sender))
			{
				this.ResultingSelectedHouseLabel.Text = string.Format("Your house is the {0}!", this.dictionary_0[sender].smethod_1());
			}
		}

		// Token: 0x060015FD RID: 5629 RVA: 0x00006288 File Offset: 0x00004488
		private void HideBtn_Click(object sender, EventArgs e)
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x04000351 RID: 849
		private IContainer icontainer_0;

		// Token: 0x04000352 RID: 850
		private Control1 RedHouse;

		// Token: 0x04000353 RID: 851
		private Control1 GreenHouse;

		// Token: 0x04000354 RID: 852
		private Control1 PurpleHouse;

		// Token: 0x04000355 RID: 853
		private Control1 BlueHouse;

		// Token: 0x04000356 RID: 854
		private Control1 PinkHouse;

		// Token: 0x04000357 RID: 855
		private Control1 YellowHouse;

		// Token: 0x04000358 RID: 856
		private Label SelectTitleLabel;

		// Token: 0x04000359 RID: 857
		private Label ResultingSelectedHouseLabel;

		// Token: 0x0400035A RID: 858
		private Button HideBtn;

		// Token: 0x0400035B RID: 859
		private Control1 BackgroundBlue;

		// Token: 0x0400035C RID: 860
		private EventHandler eventHandler_0;

		// Token: 0x0400035D RID: 861
		private Dictionary<object, Enum13> dictionary_0;
	}
}
