namespace ns25
{
	// Token: 0x02000334 RID: 820
	internal sealed partial class JoeFishNewSpeciesCaught : global::System.Windows.Forms.Form
	{
		// Token: 0x06001FE5 RID: 8165 RVA: 0x0000CD9D File Offset: 0x0000AF9D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x000697AC File Offset: 0x000679AC
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns25.JoeFishNewSpeciesCaught));
			this.ScreenshotPic = new global::System.Windows.Forms.PictureBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.DisableNoticeLabel = new global::System.Windows.Forms.Label();
			this.NewSpeciesDetectedMessage = new global::System.Windows.Forms.Label();
			this.StopFlashingBtn = new global::System.Windows.Forms.Button();
			this.CloseBtn = new global::System.Windows.Forms.Button();
			this.CongratulationsLabel = new global::System.Windows.Forms.Label();
			this.NewSpeciesTitle = new global::System.Windows.Forms.Label();
			this.SaveScreenshotBtn = new global::System.Windows.Forms.Button();
			this.saveFileDialog_0 = new global::System.Windows.Forms.SaveFileDialog();
			this.NewSpeciesFlasher = new global::ns15.FlashingBorder();
			((global::System.ComponentModel.ISupportInitialize)this.ScreenshotPic).BeginInit();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.ScreenshotPic.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.ScreenshotPic.Location = new global::System.Drawing.Point(9, 7);
			this.ScreenshotPic.Name = "ScreenshotPic";
			this.ScreenshotPic.Size = new global::System.Drawing.Size(140, 140);
			this.ScreenshotPic.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ScreenshotPic.TabIndex = 0;
			this.ScreenshotPic.TabStop = false;
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel1.Controls.Add(this.DisableNoticeLabel);
			this.panel1.Controls.Add(this.NewSpeciesDetectedMessage);
			this.panel1.Controls.Add(this.StopFlashingBtn);
			this.panel1.Controls.Add(this.CloseBtn);
			this.panel1.Controls.Add(this.CongratulationsLabel);
			this.panel1.Controls.Add(this.NewSpeciesTitle);
			this.panel1.Controls.Add(this.SaveScreenshotBtn);
			this.panel1.Controls.Add(this.ScreenshotPic);
			this.panel1.Location = new global::System.Drawing.Point(4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(386, 182);
			this.panel1.TabIndex = 2;
			this.DisableNoticeLabel.AutoSize = true;
			this.DisableNoticeLabel.BackColor = global::System.Drawing.SystemColors.Control;
			this.DisableNoticeLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.DisableNoticeLabel.Location = new global::System.Drawing.Point(165, 134);
			this.DisableNoticeLabel.Name = "DisableNoticeLabel";
			this.DisableNoticeLabel.Size = new global::System.Drawing.Size(205, 13);
			this.DisableNoticeLabel.TabIndex = 15;
			this.DisableNoticeLabel.Text = "This can be disabled on the main window.";
			this.NewSpeciesDetectedMessage.BackColor = global::System.Drawing.Color.Transparent;
			this.NewSpeciesDetectedMessage.Font = new global::System.Drawing.Font("Georgia", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.NewSpeciesDetectedMessage.ForeColor = global::System.Drawing.Color.Black;
			this.NewSpeciesDetectedMessage.Location = new global::System.Drawing.Point(165, 71);
			this.NewSpeciesDetectedMessage.Name = "NewSpeciesDetectedMessage";
			this.NewSpeciesDetectedMessage.Size = new global::System.Drawing.Size(206, 47);
			this.NewSpeciesDetectedMessage.TabIndex = 12;
			this.NewSpeciesDetectedMessage.Text = "Joe Fish has been stopped due to a new fish species being detected. A screenshot has been saved for you.";
			this.StopFlashingBtn.Location = new global::System.Drawing.Point(208, 153);
			this.StopFlashingBtn.Name = "StopFlashingBtn";
			this.StopFlashingBtn.Size = new global::System.Drawing.Size(89, 23);
			this.StopFlashingBtn.TabIndex = 1;
			this.StopFlashingBtn.Text = "Stop Flashing";
			this.StopFlashingBtn.UseVisualStyleBackColor = true;
			this.StopFlashingBtn.Click += new global::System.EventHandler(this.StopFlashingBtn_Click);
			this.CloseBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CloseBtn.Location = new global::System.Drawing.Point(303, 153);
			this.CloseBtn.Name = "CloseBtn";
			this.CloseBtn.Size = new global::System.Drawing.Size(75, 23);
			this.CloseBtn.TabIndex = 2;
			this.CloseBtn.Text = "Close";
			this.CloseBtn.UseVisualStyleBackColor = true;
			this.CloseBtn.Click += new global::System.EventHandler(this.CloseBtn_Click);
			this.CongratulationsLabel.AutoSize = true;
			this.CongratulationsLabel.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.CongratulationsLabel.Location = new global::System.Drawing.Point(191, 19);
			this.CongratulationsLabel.Name = "CongratulationsLabel";
			this.CongratulationsLabel.Size = new global::System.Drawing.Size(154, 26);
			this.CongratulationsLabel.TabIndex = 10;
			this.CongratulationsLabel.Text = "Congratulations!";
			this.NewSpeciesTitle.AutoSize = true;
			this.NewSpeciesTitle.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.NewSpeciesTitle.Location = new global::System.Drawing.Point(164, 45);
			this.NewSpeciesTitle.Name = "NewSpeciesTitle";
			this.NewSpeciesTitle.Size = new global::System.Drawing.Size(208, 26);
			this.NewSpeciesTitle.TabIndex = 10;
			this.NewSpeciesTitle.Text = "New Species Detected!";
			this.SaveScreenshotBtn.Location = new global::System.Drawing.Point(9, 153);
			this.SaveScreenshotBtn.Name = "SaveScreenshotBtn";
			this.SaveScreenshotBtn.Size = new global::System.Drawing.Size(140, 23);
			this.SaveScreenshotBtn.TabIndex = 0;
			this.SaveScreenshotBtn.Text = "Save Screenshot";
			this.SaveScreenshotBtn.UseVisualStyleBackColor = true;
			this.SaveScreenshotBtn.Click += new global::System.EventHandler(this.SaveScreenshotBtn_Click);
			this.saveFileDialog_0.Filter = "JPG Images|*.jpg|PNG Images|*.png";
			this.NewSpeciesFlasher.BorderSize = 4;
			this.NewSpeciesFlasher.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.NewSpeciesFlasher.EnableFlashing = true;
			this.NewSpeciesFlasher.ForeColor = global::System.Drawing.Color.Red;
			this.NewSpeciesFlasher.Location = new global::System.Drawing.Point(0, 0);
			this.NewSpeciesFlasher.Name = "NewSpeciesFlasher";
			this.NewSpeciesFlasher.Size = new global::System.Drawing.Size(394, 190);
			this.NewSpeciesFlasher.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.CloseBtn;
			base.ClientSize = new global::System.Drawing.Size(394, 190);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.NewSpeciesFlasher);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "JoeFishNewSpeciesCaught";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Joe Fish : New Species Detected";
			base.TopMost = true;
			((global::System.ComponentModel.ISupportInitialize)this.ScreenshotPic).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000C5F RID: 3167
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000C60 RID: 3168
		private global::System.Windows.Forms.PictureBox ScreenshotPic;

		// Token: 0x04000C61 RID: 3169
		private global::ns15.FlashingBorder NewSpeciesFlasher;

		// Token: 0x04000C62 RID: 3170
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000C63 RID: 3171
		private global::System.Windows.Forms.Button SaveScreenshotBtn;

		// Token: 0x04000C64 RID: 3172
		private global::System.Windows.Forms.Label NewSpeciesTitle;

		// Token: 0x04000C65 RID: 3173
		private global::System.Windows.Forms.Button StopFlashingBtn;

		// Token: 0x04000C66 RID: 3174
		private global::System.Windows.Forms.Button CloseBtn;

		// Token: 0x04000C67 RID: 3175
		private global::System.Windows.Forms.Label NewSpeciesDetectedMessage;

		// Token: 0x04000C68 RID: 3176
		private global::System.Windows.Forms.Label CongratulationsLabel;

		// Token: 0x04000C69 RID: 3177
		private global::System.Windows.Forms.Label DisableNoticeLabel;

		// Token: 0x04000C6A RID: 3178
		private global::System.Windows.Forms.SaveFileDialog saveFileDialog_0;
	}
}
