namespace ns31
{
	// Token: 0x020002CC RID: 716
	internal partial class FileSelectBase : global::System.Windows.Forms.Form
	{
		// Token: 0x06001C82 RID: 7298 RVA: 0x0000ABDA File Offset: 0x00008DDA
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0005BD80 File Offset: 0x00059F80
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns31.FileSelectBase));
			this.btnDelete = new global::System.Windows.Forms.Button();
			this.btnBrowse = new global::System.Windows.Forms.Button();
			this.btnOpen = new global::System.Windows.Forms.Button();
			this.btnCancel = new global::System.Windows.Forms.Button();
			this.lbFiles = new global::System.Windows.Forms.ListBox();
			this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			this.btnLocate = new global::System.Windows.Forms.Button();
			base.SuspendLayout();
			this.btnDelete.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnDelete.Location = new global::System.Drawing.Point(93, 190);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new global::System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 5;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new global::System.EventHandler(this.btnDelete_Click);
			this.btnBrowse.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnBrowse.Location = new global::System.Drawing.Point(207, 190);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new global::System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 3;
			this.btnBrowse.Text = "Browse";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new global::System.EventHandler(this.btnBrowse_Click);
			this.btnOpen.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnOpen.Enabled = false;
			this.btnOpen.Location = new global::System.Drawing.Point(288, 190);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new global::System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 1;
			this.btnOpen.Text = "&Open";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new global::System.EventHandler(this.btnOpen_Click);
			this.btnCancel.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.btnCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new global::System.Drawing.Point(369, 190);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new global::System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new global::System.EventHandler(this.btnCancel_Click);
			this.lbFiles.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.lbFiles.FormattingEnabled = true;
			this.lbFiles.Location = new global::System.Drawing.Point(12, 9);
			this.lbFiles.Name = "lbFiles";
			this.lbFiles.Size = new global::System.Drawing.Size(432, 173);
			this.lbFiles.TabIndex = 0;
			this.lbFiles.SelectedIndexChanged += new global::System.EventHandler(this.lbFiles_SelectedIndexChanged);
			this.lbFiles.DoubleClick += new global::System.EventHandler(this.lbFiles_DoubleClick);
			this.btnLocate.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.btnLocate.Location = new global::System.Drawing.Point(12, 190);
			this.btnLocate.Name = "btnLocate";
			this.btnLocate.Size = new global::System.Drawing.Size(75, 23);
			this.btnLocate.TabIndex = 4;
			this.btnLocate.Text = "Locate";
			this.btnLocate.UseVisualStyleBackColor = true;
			this.btnLocate.Click += new global::System.EventHandler(this.btnLocate_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(456, 223);
			base.Controls.Add(this.btnLocate);
			base.Controls.Add(this.btnDelete);
			base.Controls.Add(this.btnBrowse);
			base.Controls.Add(this.btnOpen);
			base.Controls.Add(this.btnCancel);
			base.Controls.Add(this.lbFiles);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			this.MinimumSize = new global::System.Drawing.Size(429, 158);
			base.Name = "FileSelectBase";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			base.ResumeLayout(false);
		}

		// Token: 0x04000A50 RID: 2640
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000A51 RID: 2641
		private global::System.Windows.Forms.Button btnDelete;

		// Token: 0x04000A52 RID: 2642
		private global::System.Windows.Forms.Button btnBrowse;

		// Token: 0x04000A53 RID: 2643
		private global::System.Windows.Forms.Button btnOpen;

		// Token: 0x04000A54 RID: 2644
		private global::System.Windows.Forms.Button btnCancel;

		// Token: 0x04000A55 RID: 2645
		private global::System.Windows.Forms.ListBox lbFiles;

		// Token: 0x04000A56 RID: 2646
		private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

		// Token: 0x04000A57 RID: 2647
		private global::System.Windows.Forms.Button btnLocate;
	}
}
