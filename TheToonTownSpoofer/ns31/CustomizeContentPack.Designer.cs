namespace ns31
{
	// Token: 0x020002CF RID: 719
	internal sealed partial class CustomizeContentPack : global::System.Windows.Forms.Form
	{
		// Token: 0x06001CB6 RID: 7350 RVA: 0x0000AE6A File Offset: 0x0000906A
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.class132_0 != null)
				{
					this.class132_0.Dispose();
				}
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x0005CB34 File Offset: 0x0005AD34
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns31.CustomizeContentPack));
			this.ContentPackFilesTitle = new global::System.Windows.Forms.Label();
			this.PreviewTitle = new global::System.Windows.Forms.Label();
			this.FilesList = new global::System.Windows.Forms.ListView();
			this.panUserContent = new global::System.Windows.Forms.Panel();
			this.picUserContentAudioFile = new global::System.Windows.Forms.PictureBox();
			this.picUserContent = new global::System.Windows.Forms.PictureBox();
			this.CheckAvailableButton = new global::System.Windows.Forms.Button();
			this.CheckAllButton = new global::System.Windows.Forms.Button();
			this.UncheckAllButton = new global::System.Windows.Forms.Button();
			this.OKButton = new global::System.Windows.Forms.Button();
			this.CancelBtn = new global::System.Windows.Forms.Button();
			this.wmpUserPlayer = new global::ns25.LimitedMediaPlayer();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.panUserContent.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picUserContentAudioFile).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.picUserContent).BeginInit();
			base.SuspendLayout();
			this.ContentPackFilesTitle.AutoSize = true;
			this.ContentPackFilesTitle.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.ContentPackFilesTitle.Location = new global::System.Drawing.Point(7, 9);
			this.ContentPackFilesTitle.Name = "ContentPackFilesTitle";
			this.ContentPackFilesTitle.Size = new global::System.Drawing.Size(168, 26);
			this.ContentPackFilesTitle.TabIndex = 11;
			this.ContentPackFilesTitle.Text = "Content Pack Files";
			this.PreviewTitle.AutoSize = true;
			this.PreviewTitle.Font = new global::System.Drawing.Font("Calibri", 15.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.PreviewTitle.Location = new global::System.Drawing.Point(319, 10);
			this.PreviewTitle.Name = "PreviewTitle";
			this.PreviewTitle.Size = new global::System.Drawing.Size(79, 26);
			this.PreviewTitle.TabIndex = 11;
			this.PreviewTitle.Text = "Preview";
			this.FilesList.CheckBoxes = true;
			this.FilesList.FullRowSelect = true;
			this.FilesList.Location = new global::System.Drawing.Point(12, 38);
			this.FilesList.Name = "FilesList";
			this.FilesList.Size = new global::System.Drawing.Size(306, 264);
			this.FilesList.TabIndex = 0;
			this.FilesList.UseCompatibleStateImageBehavior = false;
			this.FilesList.View = global::System.Windows.Forms.View.List;
			this.FilesList.SelectedIndexChanged += new global::System.EventHandler(this.FilesList_SelectedIndexChanged);
			this.panUserContent.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.panUserContent.Controls.Add(this.picUserContentAudioFile);
			this.panUserContent.Controls.Add(this.picUserContent);
			this.panUserContent.Location = new global::System.Drawing.Point(324, 38);
			this.panUserContent.Name = "panUserContent";
			this.panUserContent.Size = new global::System.Drawing.Size(224, 224);
			this.panUserContent.TabIndex = 16;
			this.picUserContentAudioFile.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("picUserContentAudioFile.Image");
			this.picUserContentAudioFile.Location = new global::System.Drawing.Point(87, 87);
			this.picUserContentAudioFile.Name = "picUserContentAudioFile";
			this.picUserContentAudioFile.Size = new global::System.Drawing.Size(48, 48);
			this.picUserContentAudioFile.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picUserContentAudioFile.TabIndex = 7;
			this.picUserContentAudioFile.TabStop = false;
			this.picUserContentAudioFile.Visible = false;
			this.picUserContent.Location = new global::System.Drawing.Point(0, 0);
			this.picUserContent.MaximumSize = new global::System.Drawing.Size(224, 224);
			this.picUserContent.Name = "picUserContent";
			this.picUserContent.Size = new global::System.Drawing.Size(224, 224);
			this.picUserContent.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picUserContent.TabIndex = 6;
			this.picUserContent.TabStop = false;
			this.CheckAvailableButton.Location = new global::System.Drawing.Point(12, 308);
			this.CheckAvailableButton.Name = "CheckAvailableButton";
			this.CheckAvailableButton.Size = new global::System.Drawing.Size(98, 23);
			this.CheckAvailableButton.TabIndex = 2;
			this.CheckAvailableButton.Text = "Check Available";
			this.CheckAvailableButton.UseVisualStyleBackColor = true;
			this.CheckAvailableButton.Click += new global::System.EventHandler(this.CheckAvailableButton_Click);
			this.CheckAllButton.Location = new global::System.Drawing.Point(116, 308);
			this.CheckAllButton.Name = "CheckAllButton";
			this.CheckAllButton.Size = new global::System.Drawing.Size(98, 23);
			this.CheckAllButton.TabIndex = 3;
			this.CheckAllButton.Text = "Check All";
			this.CheckAllButton.UseVisualStyleBackColor = true;
			this.CheckAllButton.Click += new global::System.EventHandler(this.CheckAllButton_Click);
			this.UncheckAllButton.Location = new global::System.Drawing.Point(220, 308);
			this.UncheckAllButton.Name = "UncheckAllButton";
			this.UncheckAllButton.Size = new global::System.Drawing.Size(98, 23);
			this.UncheckAllButton.TabIndex = 4;
			this.UncheckAllButton.Text = "Uncheck All";
			this.UncheckAllButton.UseVisualStyleBackColor = true;
			this.UncheckAllButton.Click += new global::System.EventHandler(this.UncheckAllButton_Click);
			this.OKButton.Location = new global::System.Drawing.Point(472, 308);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new global::System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 5;
			this.OKButton.Text = "&OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new global::System.EventHandler(this.OKButton_Click);
			this.CancelBtn.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CancelBtn.Location = new global::System.Drawing.Point(391, 308);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new global::System.Drawing.Size(75, 23);
			this.CancelBtn.TabIndex = 6;
			this.CancelBtn.Text = "&Cancel";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new global::System.EventHandler(this.CancelBtn_Click);
			this.wmpUserPlayer.BackColor = global::System.Drawing.Color.White;
			this.wmpUserPlayer.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.wmpUserPlayer.Location = new global::System.Drawing.Point(324, 268);
			this.wmpUserPlayer.Name = "wmpUserPlayer";
			this.wmpUserPlayer.Size = new global::System.Drawing.Size(224, 34);
			this.wmpUserPlayer.TabIndex = 1;
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(459, 2);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 20;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			base.AcceptButton = this.OKButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.CancelBtn;
			base.ClientSize = new global::System.Drawing.Size(563, 342);
			base.Controls.Add(this.HowToOpenHelpLabel);
			base.Controls.Add(this.CancelBtn);
			base.Controls.Add(this.OKButton);
			base.Controls.Add(this.UncheckAllButton);
			base.Controls.Add(this.CheckAllButton);
			base.Controls.Add(this.CheckAvailableButton);
			base.Controls.Add(this.panUserContent);
			base.Controls.Add(this.FilesList);
			base.Controls.Add(this.PreviewTitle);
			base.Controls.Add(this.ContentPackFilesTitle);
			base.Controls.Add(this.wmpUserPlayer);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "CustomizeContentPack";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Customize Content Pack";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.CustomizeContentPack_FormClosing);
			base.Shown += new global::System.EventHandler(this.CustomizeContentPack_Shown);
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.CustomizeContentPack_HelpRequested);
			this.panUserContent.ResumeLayout(false);
			this.panUserContent.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.picUserContentAudioFile).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.picUserContent).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000A69 RID: 2665
		private global::ns25.Class132 class132_0;

		// Token: 0x04000A6C RID: 2668
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000A6D RID: 2669
		private global::ns25.LimitedMediaPlayer wmpUserPlayer;

		// Token: 0x04000A6E RID: 2670
		private global::System.Windows.Forms.Label ContentPackFilesTitle;

		// Token: 0x04000A6F RID: 2671
		private global::System.Windows.Forms.Label PreviewTitle;

		// Token: 0x04000A70 RID: 2672
		private global::System.Windows.Forms.ListView FilesList;

		// Token: 0x04000A71 RID: 2673
		private global::System.Windows.Forms.Panel panUserContent;

		// Token: 0x04000A72 RID: 2674
		private global::System.Windows.Forms.PictureBox picUserContentAudioFile;

		// Token: 0x04000A73 RID: 2675
		private global::System.Windows.Forms.PictureBox picUserContent;

		// Token: 0x04000A74 RID: 2676
		private global::System.Windows.Forms.Button CheckAvailableButton;

		// Token: 0x04000A75 RID: 2677
		private global::System.Windows.Forms.Button CheckAllButton;

		// Token: 0x04000A76 RID: 2678
		private global::System.Windows.Forms.Button UncheckAllButton;

		// Token: 0x04000A77 RID: 2679
		private global::System.Windows.Forms.Button OKButton;

		// Token: 0x04000A78 RID: 2680
		private global::System.Windows.Forms.Button CancelBtn;

		// Token: 0x04000A79 RID: 2681
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;
	}
}
