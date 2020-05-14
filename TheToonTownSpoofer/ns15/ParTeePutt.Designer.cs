namespace ns15
{
	// Token: 0x0200022B RID: 555
	internal sealed partial class ParTeePutt : global::System.Windows.Forms.Form
	{
		// Token: 0x060017FA RID: 6138 RVA: 0x00007A25 File Offset: 0x00005C25
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060017FB RID: 6139 RVA: 0x0004083C File Offset: 0x0003EA3C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns15.ParTeePutt));
			this.DrawGuideLineButton = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.ParTeePuttGuideLineTitle = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.DrawGuideLineButton.Location = new global::System.Drawing.Point(17, 75);
			this.DrawGuideLineButton.Name = "DrawGuideLineButton";
			this.DrawGuideLineButton.Size = new global::System.Drawing.Size(214, 33);
			this.DrawGuideLineButton.TabIndex = 0;
			this.DrawGuideLineButton.Text = "Create Guide Line";
			this.DrawGuideLineButton.UseVisualStyleBackColor = true;
			this.DrawGuideLineButton.Click += new global::System.EventHandler(this.DrawGuideLineButton_Click);
			this.label1.Location = new global::System.Drawing.Point(10, 39);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(228, 36);
			this.label1.TabIndex = 1;
			this.label1.Text = "The ParTee Putt Guide Line draws a straight line to assist with aiming while golfing.";
			this.ParTeePuttGuideLineTitle.AutoSize = true;
			this.ParTeePuttGuideLineTitle.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.ParTeePuttGuideLineTitle.Location = new global::System.Drawing.Point(7, 9);
			this.ParTeePuttGuideLineTitle.Name = "ParTeePuttGuideLineTitle";
			this.ParTeePuttGuideLineTitle.Size = new global::System.Drawing.Size(203, 26);
			this.ParTeePuttGuideLineTitle.TabIndex = 10;
			this.ParTeePuttGuideLineTitle.Text = "ParTee Putt Guide Line";
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.Location = new global::System.Drawing.Point(10, 115);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(231, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "To remove the guide line, close the window. ToonTown will not exit. ";
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(248, 14);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(52, 120);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 11;
			this.pictureBox1.TabStop = false;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.Location = new global::System.Drawing.Point(10, 144);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(290, 30);
			this.label3.TabIndex = 1;
			this.label3.Text = "Warning: Do not change ToonTown's display properties while ParTee Putt Guide Line is active or you risk detaching the guide line.";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(305, 176);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.DrawGuideLineButton);
			base.Controls.Add(this.ParTeePuttGuideLineTitle);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "ParTeePutt";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ParTee Putt";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.ParTeePutt_FormClosing);
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.ParTeePutt_HelpRequested);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040005F9 RID: 1529
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040005FA RID: 1530
		private global::System.Windows.Forms.Button DrawGuideLineButton;

		// Token: 0x040005FB RID: 1531
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040005FC RID: 1532
		private global::System.Windows.Forms.Label ParTeePuttGuideLineTitle;

		// Token: 0x040005FD RID: 1533
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040005FE RID: 1534
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040005FF RID: 1535
		private global::System.Windows.Forms.Label label3;
	}
}
