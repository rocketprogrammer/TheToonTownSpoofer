namespace ns17
{
	// Token: 0x02000280 RID: 640
	internal sealed partial class Connect : global::System.Windows.Forms.Form
	{
		// Token: 0x06001ACE RID: 6862 RVA: 0x00009A41 File Offset: 0x00007C41
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001ACF RID: 6863 RVA: 0x0004F938 File Offset: 0x0004DB38
		private void InitializeComponent()
		{
			this.icontainer_0 = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns17.Connect));
			this.FavoriteAccountsMenu = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
			this.ConnectButton = new global::System.Windows.Forms.Button();
			this.CloseButton = new global::System.Windows.Forms.Button();
			this.smoothGroup1 = new global::ns24.Class310();
			this.ShowFavoritesButton = new global::ns22.Control6();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.WelcomeBannerLabel = new global::System.Windows.Forms.Label();
			this.ToonTownUsernameLabel = new global::System.Windows.Forms.Label();
			this.NewsTabControl = new global::System.Windows.Forms.TabControl();
			this.TTNewsTab = new global::System.Windows.Forms.TabPage();
			this.ToonTownNewsBrowser = new global::System.Windows.Forms.WebBrowser();
			this.TTSNewsTab = new global::System.Windows.Forms.TabPage();
			this.TheToonTownSpooferNewsBrowser = new global::System.Windows.Forms.WebBrowser();
			this.AccountManagerButton = new global::ns22.Control6();
			this.TestServerRadioButton = new global::System.Windows.Forms.RadioButton();
			this.txtUsername = new global::System.Windows.Forms.TextBox();
			this.txtPassword = new global::System.Windows.Forms.TextBox();
			this.OpenServerRadioButton = new global::System.Windows.Forms.RadioButton();
			this.ToonTownPasswordLabel = new global::System.Windows.Forms.Label();
			this.ToonTownServerLabel = new global::System.Windows.Forms.Label();
			this.DuckBlinker = new global::ns14.Blinker();
			this.class343_0 = new global::ns22.Class343(this.icontainer_0);
			this.smoothGroup1.SuspendLayout();
			this.NewsTabControl.SuspendLayout();
			this.TTNewsTab.SuspendLayout();
			this.TTSNewsTab.SuspendLayout();
			base.SuspendLayout();
			this.FavoriteAccountsMenu.Name = "FavoriteAccountsMenu";
			this.FavoriteAccountsMenu.ShowItemToolTips = false;
			this.FavoriteAccountsMenu.Size = new global::System.Drawing.Size(61, 4);
			this.ConnectButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.ConnectButton.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.ConnectButton.Location = new global::System.Drawing.Point(301, 99);
			this.ConnectButton.Name = "ConnectButton";
			this.ConnectButton.Size = new global::System.Drawing.Size(75, 23);
			this.ConnectButton.TabIndex = 2;
			this.ConnectButton.Text = "&Connect";
			this.ConnectButton.UseVisualStyleBackColor = true;
			this.ConnectButton.Click += new global::System.EventHandler(this.ConnectButton_Click);
			this.CloseButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.CloseButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Location = new global::System.Drawing.Point(382, 99);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new global::System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 5;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new global::System.EventHandler(this.CloseButton_Click);
			this.smoothGroup1.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.smoothGroup1.Controls.Add(this.ShowFavoritesButton);
			this.smoothGroup1.Controls.Add(this.HowToOpenHelpLabel);
			this.smoothGroup1.Controls.Add(this.WelcomeBannerLabel);
			this.smoothGroup1.Controls.Add(this.ToonTownUsernameLabel);
			this.smoothGroup1.Controls.Add(this.NewsTabControl);
			this.smoothGroup1.Controls.Add(this.CloseButton);
			this.smoothGroup1.Controls.Add(this.AccountManagerButton);
			this.smoothGroup1.Controls.Add(this.TestServerRadioButton);
			this.smoothGroup1.Controls.Add(this.txtUsername);
			this.smoothGroup1.Controls.Add(this.txtPassword);
			this.smoothGroup1.Controls.Add(this.OpenServerRadioButton);
			this.smoothGroup1.Controls.Add(this.ToonTownPasswordLabel);
			this.smoothGroup1.Controls.Add(this.ConnectButton);
			this.smoothGroup1.Controls.Add(this.ToonTownServerLabel);
			this.smoothGroup1.Controls.Add(this.DuckBlinker);
			this.smoothGroup1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.smoothGroup1.HeaderHeight = 30;
			this.smoothGroup1.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.smoothGroup1.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.smoothGroup1.Location = new global::System.Drawing.Point(3, 3);
			this.smoothGroup1.Name = "smoothGroup1";
			this.smoothGroup1.Size = new global::System.Drawing.Size(511, 342);
			this.smoothGroup1.TabIndex = 8;
			this.ShowFavoritesButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.ShowFavoritesButton.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.ShowFavoritesButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ShowFavoritesButton.ImageEnter = (global::System.Drawing.Image)componentResourceManager.GetObject("ShowFavoritesButton.ImageEnter");
			this.ShowFavoritesButton.ImageNormal = (global::System.Drawing.Image)componentResourceManager.GetObject("ShowFavoritesButton.ImageNormal");
			this.ShowFavoritesButton.Location = new global::System.Drawing.Point(475, 73);
			this.ShowFavoritesButton.Name = "ShowFavoritesButton";
			this.ShowFavoritesButton.Size = new global::System.Drawing.Size(22, 20);
			this.ShowFavoritesButton.TabIndex = 25;
			this.ShowFavoritesButton.TabStop = false;
			this.ShowFavoritesButton.Click += new global::System.EventHandler(this.ShowFavoritesButton_Click);
			this.HowToOpenHelpLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(390, 132);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 24;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			this.WelcomeBannerLabel.AutoSize = true;
			this.WelcomeBannerLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.WelcomeBannerLabel.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold);
			this.WelcomeBannerLabel.ForeColor = global::System.Drawing.Color.FromArgb(95, 95, 95);
			this.WelcomeBannerLabel.Location = new global::System.Drawing.Point(10, 8);
			this.WelcomeBannerLabel.Name = "WelcomeBannerLabel";
			this.WelcomeBannerLabel.Size = new global::System.Drawing.Size(253, 19);
			this.WelcomeBannerLabel.TabIndex = 2;
			this.WelcomeBannerLabel.Text = "Welcome to The ToonTown Spoofer";
			this.ToonTownUsernameLabel.AutoSize = true;
			this.ToonTownUsernameLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.ToonTownUsernameLabel.Font = new global::System.Drawing.Font("Georgia", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ToonTownUsernameLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.ToonTownUsernameLabel.Location = new global::System.Drawing.Point(27, 44);
			this.ToonTownUsernameLabel.Name = "ToonTownUsernameLabel";
			this.ToonTownUsernameLabel.Size = new global::System.Drawing.Size(144, 16);
			this.ToonTownUsernameLabel.TabIndex = 2;
			this.ToonTownUsernameLabel.Text = "ToonTown Username:";
			this.NewsTabControl.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.NewsTabControl.Controls.Add(this.TTNewsTab);
			this.NewsTabControl.Controls.Add(this.TTSNewsTab);
			this.NewsTabControl.Location = new global::System.Drawing.Point(10, 128);
			this.NewsTabControl.Name = "NewsTabControl";
			this.NewsTabControl.SelectedIndex = 0;
			this.NewsTabControl.Size = new global::System.Drawing.Size(490, 206);
			this.NewsTabControl.TabIndex = 6;
			this.NewsTabControl.SelectedIndexChanged += new global::System.EventHandler(this.NewsTabControl_SelectedIndexChanged);
			this.TTNewsTab.Controls.Add(this.ToonTownNewsBrowser);
			this.TTNewsTab.Location = new global::System.Drawing.Point(4, 22);
			this.TTNewsTab.Name = "TTNewsTab";
			this.TTNewsTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.TTNewsTab.Size = new global::System.Drawing.Size(482, 180);
			this.TTNewsTab.TabIndex = 0;
			this.TTNewsTab.Text = "ToonTown News";
			this.TTNewsTab.UseVisualStyleBackColor = true;
			this.ToonTownNewsBrowser.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.ToonTownNewsBrowser.Location = new global::System.Drawing.Point(3, 3);
			this.ToonTownNewsBrowser.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.ToonTownNewsBrowser.Name = "ToonTownNewsBrowser";
			this.ToonTownNewsBrowser.Size = new global::System.Drawing.Size(476, 174);
			this.ToonTownNewsBrowser.TabIndex = 0;
			this.TTSNewsTab.Controls.Add(this.TheToonTownSpooferNewsBrowser);
			this.TTSNewsTab.Location = new global::System.Drawing.Point(4, 22);
			this.TTSNewsTab.Name = "TTSNewsTab";
			this.TTSNewsTab.Padding = new global::System.Windows.Forms.Padding(3);
			this.TTSNewsTab.Size = new global::System.Drawing.Size(482, 180);
			this.TTSNewsTab.TabIndex = 1;
			this.TTSNewsTab.Text = "The ToonTown Spoofer News";
			this.TTSNewsTab.UseVisualStyleBackColor = true;
			this.TheToonTownSpooferNewsBrowser.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.TheToonTownSpooferNewsBrowser.Location = new global::System.Drawing.Point(3, 3);
			this.TheToonTownSpooferNewsBrowser.MinimumSize = new global::System.Drawing.Size(20, 20);
			this.TheToonTownSpooferNewsBrowser.Name = "TheToonTownSpooferNewsBrowser";
			this.TheToonTownSpooferNewsBrowser.Size = new global::System.Drawing.Size(476, 174);
			this.TheToonTownSpooferNewsBrowser.TabIndex = 0;
			this.TheToonTownSpooferNewsBrowser.DocumentCompleted += new global::System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.TheToonTownSpooferNewsBrowser_DocumentCompleted);
			this.AccountManagerButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.AccountManagerButton.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.AccountManagerButton.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.AccountManagerButton.ImageEnter = (global::System.Drawing.Image)componentResourceManager.GetObject("AccountManagerButton.ImageEnter");
			this.AccountManagerButton.ImageNormal = (global::System.Drawing.Image)componentResourceManager.GetObject("AccountManagerButton.ImageNormal");
			this.AccountManagerButton.Location = new global::System.Drawing.Point(461, 44);
			this.AccountManagerButton.Name = "AccountManagerButton";
			this.AccountManagerButton.Size = new global::System.Drawing.Size(20, 43);
			this.AccountManagerButton.TabIndex = 5;
			this.AccountManagerButton.TabStop = false;
			this.AccountManagerButton.Click += new global::System.EventHandler(this.AccountManagerButton_Click);
			this.TestServerRadioButton.AutoSize = true;
			this.TestServerRadioButton.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.TestServerRadioButton.Font = new global::System.Drawing.Font("Georgia", 8.25f);
			this.TestServerRadioButton.ForeColor = global::System.Drawing.Color.DimGray;
			this.TestServerRadioButton.Location = new global::System.Drawing.Point(188, 102);
			this.TestServerRadioButton.Name = "TestServerRadioButton";
			this.TestServerRadioButton.Size = new global::System.Drawing.Size(49, 18);
			this.TestServerRadioButton.TabIndex = 4;
			this.TestServerRadioButton.Text = "Test";
			this.TestServerRadioButton.UseVisualStyleBackColor = false;
			this.txtUsername.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtUsername.Font = new global::System.Drawing.Font("Georgia", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.txtUsername.Location = new global::System.Drawing.Point(177, 41);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new global::System.Drawing.Size(280, 22);
			this.txtUsername.TabIndex = 0;
			this.txtPassword.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.txtPassword.Font = new global::System.Drawing.Font("Georgia", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.txtPassword.Location = new global::System.Drawing.Point(177, 69);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new global::System.Drawing.Size(280, 22);
			this.txtPassword.TabIndex = 1;
			this.OpenServerRadioButton.AutoSize = true;
			this.OpenServerRadioButton.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.OpenServerRadioButton.Checked = true;
			this.OpenServerRadioButton.Font = new global::System.Drawing.Font("Georgia", 8.25f);
			this.OpenServerRadioButton.ForeColor = global::System.Drawing.Color.DimGray;
			this.OpenServerRadioButton.Location = new global::System.Drawing.Point(129, 102);
			this.OpenServerRadioButton.Name = "OpenServerRadioButton";
			this.OpenServerRadioButton.Size = new global::System.Drawing.Size(55, 18);
			this.OpenServerRadioButton.TabIndex = 3;
			this.OpenServerRadioButton.TabStop = true;
			this.OpenServerRadioButton.Text = "Open";
			this.OpenServerRadioButton.UseVisualStyleBackColor = false;
			this.ToonTownPasswordLabel.AutoSize = true;
			this.ToonTownPasswordLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.ToonTownPasswordLabel.Font = new global::System.Drawing.Font("Georgia", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ToonTownPasswordLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.ToonTownPasswordLabel.Location = new global::System.Drawing.Point(100, 71);
			this.ToonTownPasswordLabel.Name = "ToonTownPasswordLabel";
			this.ToonTownPasswordLabel.Size = new global::System.Drawing.Size(71, 16);
			this.ToonTownPasswordLabel.TabIndex = 2;
			this.ToonTownPasswordLabel.Text = "Password:";
			this.ToonTownServerLabel.AutoSize = true;
			this.ToonTownServerLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.ToonTownServerLabel.Font = new global::System.Drawing.Font("Georgia", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.ToonTownServerLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.ToonTownServerLabel.Location = new global::System.Drawing.Point(73, 104);
			this.ToonTownServerLabel.Name = "ToonTownServerLabel";
			this.ToonTownServerLabel.Size = new global::System.Drawing.Size(50, 14);
			this.ToonTownServerLabel.TabIndex = 2;
			this.ToonTownServerLabel.Text = "Server:";
			this.DuckBlinker.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.DuckBlinker.BlinkSpeed = 200;
			this.DuckBlinker.Location = new global::System.Drawing.Point(19, 76);
			this.DuckBlinker.MaximumBlinkDelay = 5000;
			this.DuckBlinker.MinimumBlinkDelay = 1000;
			this.DuckBlinker.Name = "DuckBlinker";
			this.DuckBlinker.OffImage = (global::System.Drawing.Image)componentResourceManager.GetObject("DuckBlinker.OffImage");
			this.DuckBlinker.OnImage = (global::System.Drawing.Image)componentResourceManager.GetObject("DuckBlinker.OnImage");
			this.DuckBlinker.Size = new global::System.Drawing.Size(41, 60);
			this.DuckBlinker.TabIndex = 0;
			this.DuckBlinker.TabStop = false;
			this.DuckBlinker.Click += new global::System.EventHandler(this.DuckBlinker_Click);
			this.class343_0.ContractDistance = 2;
			this.class343_0.ContractedDelay = 500;
			this.class343_0.ContractRate = 10;
			this.class343_0.ControlToSlide = this.DuckBlinker;
			this.class343_0.Enabled = false;
			this.class343_0.EndPosition = 150;
			this.class343_0.ExpandDistance = 6;
			this.class343_0.ExpandedDelay = 5000;
			this.class343_0.ExpandRate = 30;
			this.class343_0.RunOnce = true;
			this.class343_0.SlideDirection = global::ns19.Enum100.const_3;
			base.AcceptButton = this.ConnectButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			base.CancelButton = this.CloseButton;
			base.ClientSize = new global::System.Drawing.Size(517, 348);
			base.Controls.Add(this.smoothGroup1);
			this.DoubleBuffered = true;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Connect";
			base.Padding = new global::System.Windows.Forms.Padding(3);
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer : Connect";
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.Connect_HelpRequested);
			this.smoothGroup1.ResumeLayout(false);
			this.smoothGroup1.PerformLayout();
			this.NewsTabControl.ResumeLayout(false);
			this.TTNewsTab.ResumeLayout(false);
			this.TTSNewsTab.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000836 RID: 2102
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x04000837 RID: 2103
		private global::ns22.Control6 AccountManagerButton;

		// Token: 0x04000838 RID: 2104
		private global::System.Windows.Forms.TextBox txtUsername;

		// Token: 0x04000839 RID: 2105
		private global::System.Windows.Forms.TextBox txtPassword;

		// Token: 0x0400083A RID: 2106
		private global::System.Windows.Forms.Label ToonTownUsernameLabel;

		// Token: 0x0400083B RID: 2107
		private global::System.Windows.Forms.Label ToonTownPasswordLabel;

		// Token: 0x0400083C RID: 2108
		private global::System.Windows.Forms.Label WelcomeBannerLabel;

		// Token: 0x0400083D RID: 2109
		private global::System.Windows.Forms.Button ConnectButton;

		// Token: 0x0400083E RID: 2110
		private global::System.Windows.Forms.RadioButton OpenServerRadioButton;

		// Token: 0x0400083F RID: 2111
		private global::System.Windows.Forms.RadioButton TestServerRadioButton;

		// Token: 0x04000840 RID: 2112
		private global::System.Windows.Forms.Label ToonTownServerLabel;

		// Token: 0x04000841 RID: 2113
		private global::System.Windows.Forms.TabControl NewsTabControl;

		// Token: 0x04000842 RID: 2114
		private global::System.Windows.Forms.TabPage TTNewsTab;

		// Token: 0x04000843 RID: 2115
		private global::System.Windows.Forms.TabPage TTSNewsTab;

		// Token: 0x04000844 RID: 2116
		private global::System.Windows.Forms.Button CloseButton;

		// Token: 0x04000845 RID: 2117
		private global::ns24.Class310 smoothGroup1;

		// Token: 0x04000846 RID: 2118
		private global::ns14.Blinker DuckBlinker;

		// Token: 0x04000847 RID: 2119
		private global::ns22.Class343 class343_0;

		// Token: 0x04000848 RID: 2120
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;

		// Token: 0x04000849 RID: 2121
		private global::System.Windows.Forms.WebBrowser ToonTownNewsBrowser;

		// Token: 0x0400084A RID: 2122
		private global::System.Windows.Forms.WebBrowser TheToonTownSpooferNewsBrowser;

		// Token: 0x0400084B RID: 2123
		private global::ns22.Control6 ShowFavoritesButton;

		// Token: 0x0400084C RID: 2124
		private global::System.Windows.Forms.ContextMenuStrip FavoriteAccountsMenu;
	}
}
