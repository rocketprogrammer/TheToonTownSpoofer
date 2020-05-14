namespace ns18
{
	// Token: 0x020002B0 RID: 688
	internal sealed partial class PNGSplit : global::System.Windows.Forms.Form
	{
		// Token: 0x06001C09 RID: 7177 RVA: 0x00057FB0 File Offset: 0x000561B0
		protected override void Dispose(bool disposing)
		{
			if (this.stream_2 != null)
			{
				this.stream_2.Dispose();
				this.stream_2 = null;
			}
			if (this.stream_1 != null)
			{
				this.stream_1.Dispose();
				this.stream_1 = null;
			}
			if (this.bitmap_1 != null)
			{
				this.bitmap_1.Dispose();
				this.bitmap_1 = null;
			}
			if (this.bitmap_2 != null)
			{
				this.bitmap_2.Dispose();
				this.bitmap_2 = null;
			}
			if (this.bitmap_0 != null)
			{
				this.bitmap_0.Dispose();
				this.bitmap_0 = null;
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x0005805C File Offset: 0x0005625C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns18.PNGSplit));
			this.picImage = new global::System.Windows.Forms.PictureBox();
			this.picRGB = new global::System.Windows.Forms.PictureBox();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.btnSave = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.picSource = new global::System.Windows.Forms.PictureBox();
			this.lblOriginal = new global::System.Windows.Forms.Label();
			this.lblNew = new global::System.Windows.Forms.Label();
			this.lblOpacity = new global::System.Windows.Forms.Label();
			this.cSelector = new global::ns19.ColorSelector();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.picImage).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.picRGB).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.picSource).BeginInit();
			base.SuspendLayout();
			this.picImage.Location = new global::System.Drawing.Point(178, 33);
			this.picImage.Name = "picImage";
			this.picImage.Size = new global::System.Drawing.Size(160, 160);
			this.picImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picImage.TabIndex = 0;
			this.picImage.TabStop = false;
			this.picRGB.Location = new global::System.Drawing.Point(344, 33);
			this.picRGB.Name = "picRGB";
			this.picRGB.Size = new global::System.Drawing.Size(160, 160);
			this.picRGB.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picRGB.TabIndex = 0;
			this.picRGB.TabStop = false;
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(429, 199);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.btnSave.Location = new global::System.Drawing.Point(348, 199);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new global::System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new global::System.EventHandler(this.btnSave_Click);
			this.label1.AutoSize = true;
			this.label1.Location = new global::System.Drawing.Point(214, 204);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(94, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Background color:";
			this.picSource.Location = new global::System.Drawing.Point(12, 33);
			this.picSource.Name = "picSource";
			this.picSource.Size = new global::System.Drawing.Size(160, 160);
			this.picSource.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picSource.TabIndex = 0;
			this.picSource.TabStop = false;
			this.lblOriginal.AutoSize = true;
			this.lblOriginal.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblOriginal.Location = new global::System.Drawing.Point(7, 4);
			this.lblOriginal.Name = "lblOriginal";
			this.lblOriginal.Size = new global::System.Drawing.Size(79, 26);
			this.lblOriginal.TabIndex = 10;
			this.lblOriginal.Text = "Original";
			this.lblNew.AutoSize = true;
			this.lblNew.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblNew.Location = new global::System.Drawing.Point(173, 4);
			this.lblNew.Name = "lblNew";
			this.lblNew.Size = new global::System.Drawing.Size(51, 26);
			this.lblNew.TabIndex = 10;
			this.lblNew.Text = "New";
			this.lblOpacity.AutoSize = true;
			this.lblOpacity.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.lblOpacity.Location = new global::System.Drawing.Point(339, 4);
			this.lblOpacity.Name = "lblOpacity";
			this.lblOpacity.Size = new global::System.Drawing.Size(78, 26);
			this.lblOpacity.TabIndex = 10;
			this.lblOpacity.Text = "Opacity";
			this.cSelector.Location = new global::System.Drawing.Point(314, 198);
			this.cSelector.Name = "cSelector";
			this.cSelector.SelectedColor = global::System.Drawing.Color.Black;
			this.cSelector.Size = new global::System.Drawing.Size(24, 24);
			this.cSelector.TabIndex = 0;
			this.cSelector.ColorChanged += new global::System.EventHandler<global::ns21.EventArgs17>(this.method_0);
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(1, 215);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 22;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			base.AcceptButton = this.btnSave;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btnCancel;
			base.ClientSize = new global::System.Drawing.Size(515, 230);
			base.Controls.Add(this.HowToOpenHelpLabel);
			base.Controls.Add(this.lblOpacity);
			base.Controls.Add(this.lblNew);
			base.Controls.Add(this.lblOriginal);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.cSelector);
			base.Controls.Add(this.btnSave);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.picRGB);
			base.Controls.Add(this.picSource);
			base.Controls.Add(this.picImage);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "PNGSplit";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MakePackage : PNG Split";
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.PNGSplit_HelpRequested);
			((global::System.ComponentModel.ISupportInitialize)this.picImage).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.picRGB).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.picSource).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040009A1 RID: 2465
		private global::System.IO.Stream stream_1;

		// Token: 0x040009A2 RID: 2466
		private global::System.IO.Stream stream_2;

		// Token: 0x040009A3 RID: 2467
		private global::System.Drawing.Bitmap bitmap_0;

		// Token: 0x040009A4 RID: 2468
		private global::System.Drawing.Bitmap bitmap_1;

		// Token: 0x040009A5 RID: 2469
		private global::System.Drawing.Bitmap bitmap_2;

		// Token: 0x040009A6 RID: 2470
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040009A7 RID: 2471
		private global::System.Windows.Forms.PictureBox picImage;

		// Token: 0x040009A8 RID: 2472
		private global::System.Windows.Forms.PictureBox picRGB;

		// Token: 0x040009A9 RID: 2473
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x040009AA RID: 2474
		private global::System.Windows.Forms.Button btnSave;

		// Token: 0x040009AB RID: 2475
		private global::ns19.ColorSelector cSelector;

		// Token: 0x040009AC RID: 2476
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040009AD RID: 2477
		private global::System.Windows.Forms.PictureBox picSource;

		// Token: 0x040009AE RID: 2478
		private global::System.Windows.Forms.Label lblOriginal;

		// Token: 0x040009AF RID: 2479
		private global::System.Windows.Forms.Label lblNew;

		// Token: 0x040009B0 RID: 2480
		private global::System.Windows.Forms.Label lblOpacity;

		// Token: 0x040009B1 RID: 2481
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;
	}
}
