namespace ns18
{
	// Token: 0x020002B1 RID: 689
	internal sealed partial class ContentPacks : global::System.Windows.Forms.Form
	{
		// Token: 0x06001C0B RID: 7179 RVA: 0x0000A662 File Offset: 0x00008862
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				if (this.class135_0 != null)
				{
					this.class135_0.Dispose();
				}
				if (this.icontainer_0 != null)
				{
					this.icontainer_0.Dispose();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06001C0C RID: 7180 RVA: 0x000587B0 File Offset: 0x000569B0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::ns18.ContentPacks));
			this.OpenNewButton = new global::System.Windows.Forms.Button();
			this.CloseButton = new global::System.Windows.Forms.Button();
			this.CreateYourOwnButton = new global::System.Windows.Forms.Button();
			this.AddNightLifeButton = new global::System.Windows.Forms.Button();
			this.openFileDialog_0 = new global::System.Windows.Forms.OpenFileDialog();
			this.grpContentPacks = new global::ns24.Class310();
			this.HowToOpenHelpLabel = new global::System.Windows.Forms.Label();
			this.AnimatedPointer = new global::ns19.AnimatedLeftArrow();
			this.ContentPacksLogo = new global::System.Windows.Forms.PictureBox();
			this.ContentPackIconImage = new global::System.Windows.Forms.PictureBox();
			this.SortByLabel = new global::System.Windows.Forms.Label();
			this.ContentPackStatusLabel = new global::System.Windows.Forms.Label();
			this.ContentPackTitle = new global::System.Windows.Forms.Label();
			this.RemoveContentPackButton = new global::System.Windows.Forms.Button();
			this.ViewingNumberLabel = new global::System.Windows.Forms.Label();
			this.MovePreviousButton = new global::ns16.Control8();
			this.BrowseLabel = new global::System.Windows.Forms.Label();
			this.MoveNextButton = new global::ns16.Control8();
			this.SortByComboBox = new global::System.Windows.Forms.ComboBox();
			this.DateInstalledDescriptionLabel = new global::System.Windows.Forms.Label();
			this.InstallCheckBox = new global::System.Windows.Forms.CheckBox();
			this.StatusDescriptionLabel = new global::System.Windows.Forms.Label();
			this.AutoUpdateCheckBox = new global::System.Windows.Forms.CheckBox();
			this.VersionDescriptionLabel = new global::System.Windows.Forms.Label();
			this.EnableContentPacksLink = new global::System.Windows.Forms.LinkLabel();
			this.CustomizeLink = new global::System.Windows.Forms.LinkLabel();
			this.AuthorDescriptionLabel = new global::System.Windows.Forms.Label();
			this.DateInstalledLabel = new global::System.Windows.Forms.Label();
			this.StatusLabel = new global::System.Windows.Forms.Label();
			this.VersionLabel = new global::System.Windows.Forms.Label();
			this.AuthorLabel = new global::System.Windows.Forms.Label();
			this.NameLabel = new global::System.Windows.Forms.Label();
			this.NameDescriptionLabel = new global::System.Windows.Forms.Label();
			this.DescriptionBox = new global::ns21.Class185();
			this.grpContentPacks.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ContentPacksLogo).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ContentPackIconImage).BeginInit();
			base.SuspendLayout();
			this.OpenNewButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.OpenNewButton.Location = new global::System.Drawing.Point(472, 386);
			this.OpenNewButton.Name = "OpenNewButton";
			this.OpenNewButton.Size = new global::System.Drawing.Size(83, 23);
			this.OpenNewButton.TabIndex = 15;
			this.OpenNewButton.Text = "Open New";
			this.OpenNewButton.UseVisualStyleBackColor = true;
			this.OpenNewButton.Click += new global::System.EventHandler(this.OpenNewButton_Click);
			this.CloseButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.CloseButton.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.CloseButton.Location = new global::System.Drawing.Point(561, 386);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new global::System.Drawing.Size(83, 23);
			this.CloseButton.TabIndex = 15;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new global::System.EventHandler(this.CloseButton_Click);
			this.CreateYourOwnButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.CreateYourOwnButton.Location = new global::System.Drawing.Point(117, 386);
			this.CreateYourOwnButton.Name = "CreateYourOwnButton";
			this.CreateYourOwnButton.Size = new global::System.Drawing.Size(108, 23);
			this.CreateYourOwnButton.TabIndex = 21;
			this.CreateYourOwnButton.Text = "Create Your Own";
			this.CreateYourOwnButton.UseVisualStyleBackColor = true;
			this.CreateYourOwnButton.Click += new global::System.EventHandler(this.CreateYourOwnButton_Click);
			this.AddNightLifeButton.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.AddNightLifeButton.Location = new global::System.Drawing.Point(3, 386);
			this.AddNightLifeButton.Name = "AddNightLifeButton";
			this.AddNightLifeButton.Size = new global::System.Drawing.Size(108, 23);
			this.AddNightLifeButton.TabIndex = 21;
			this.AddNightLifeButton.Text = "Add NightLife";
			this.AddNightLifeButton.UseVisualStyleBackColor = true;
			this.AddNightLifeButton.Click += new global::System.EventHandler(this.AddNightLifeButton_Click);
			this.openFileDialog_0.Filter = "Content Packs|*.ttp";
			this.openFileDialog_0.Title = "Select a Content Pack to Install";
			this.grpContentPacks.CenterColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.grpContentPacks.Controls.Add(this.HowToOpenHelpLabel);
			this.grpContentPacks.Controls.Add(this.AnimatedPointer);
			this.grpContentPacks.Controls.Add(this.ContentPacksLogo);
			this.grpContentPacks.Controls.Add(this.ContentPackIconImage);
			this.grpContentPacks.Controls.Add(this.SortByLabel);
			this.grpContentPacks.Controls.Add(this.ContentPackStatusLabel);
			this.grpContentPacks.Controls.Add(this.ContentPackTitle);
			this.grpContentPacks.Controls.Add(this.RemoveContentPackButton);
			this.grpContentPacks.Controls.Add(this.ViewingNumberLabel);
			this.grpContentPacks.Controls.Add(this.MovePreviousButton);
			this.grpContentPacks.Controls.Add(this.BrowseLabel);
			this.grpContentPacks.Controls.Add(this.MoveNextButton);
			this.grpContentPacks.Controls.Add(this.SortByComboBox);
			this.grpContentPacks.Controls.Add(this.DateInstalledDescriptionLabel);
			this.grpContentPacks.Controls.Add(this.InstallCheckBox);
			this.grpContentPacks.Controls.Add(this.StatusDescriptionLabel);
			this.grpContentPacks.Controls.Add(this.AutoUpdateCheckBox);
			this.grpContentPacks.Controls.Add(this.VersionDescriptionLabel);
			this.grpContentPacks.Controls.Add(this.EnableContentPacksLink);
			this.grpContentPacks.Controls.Add(this.CustomizeLink);
			this.grpContentPacks.Controls.Add(this.AuthorDescriptionLabel);
			this.grpContentPacks.Controls.Add(this.DateInstalledLabel);
			this.grpContentPacks.Controls.Add(this.StatusLabel);
			this.grpContentPacks.Controls.Add(this.VersionLabel);
			this.grpContentPacks.Controls.Add(this.AuthorLabel);
			this.grpContentPacks.Controls.Add(this.NameLabel);
			this.grpContentPacks.Controls.Add(this.NameDescriptionLabel);
			this.grpContentPacks.Controls.Add(this.DescriptionBox);
			this.grpContentPacks.HeaderHeight = 30;
			this.grpContentPacks.ImageBounds = new global::System.Drawing.Rectangle(0, 0, 0, 0);
			this.grpContentPacks.ImageLocation = new global::System.Drawing.Point(0, 0);
			this.grpContentPacks.Location = new global::System.Drawing.Point(3, 3);
			this.grpContentPacks.Name = "grpContentPacks";
			this.grpContentPacks.Size = new global::System.Drawing.Size(641, 377);
			this.grpContentPacks.TabIndex = 20;
			this.HowToOpenHelpLabel.AutoSize = true;
			this.HowToOpenHelpLabel.BackColor = global::System.Drawing.Color.FromArgb(224, 224, 224);
			this.HowToOpenHelpLabel.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 6.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.HowToOpenHelpLabel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.HowToOpenHelpLabel.Location = new global::System.Drawing.Point(4, 361);
			this.HowToOpenHelpLabel.Name = "HowToOpenHelpLabel";
			this.HowToOpenHelpLabel.Size = new global::System.Drawing.Size(105, 12);
			this.HowToOpenHelpLabel.TabIndex = 23;
			this.HowToOpenHelpLabel.Text = "Press F1 to display help.";
			this.AnimatedPointer.BackColor = global::System.Drawing.Color.Transparent;
			this.AnimatedPointer.Location = new global::System.Drawing.Point(248, 7);
			this.AnimatedPointer.Name = "AnimatedPointer";
			this.AnimatedPointer.Size = new global::System.Drawing.Size(149, 20);
			this.AnimatedPointer.TabIndex = 22;
			this.ContentPacksLogo.BackColor = global::System.Drawing.Color.Transparent;
			this.ContentPacksLogo.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("ContentPacksLogo.Image");
			this.ContentPacksLogo.Location = new global::System.Drawing.Point(522, 40);
			this.ContentPacksLogo.Name = "ContentPacksLogo";
			this.ContentPacksLogo.Size = new global::System.Drawing.Size(97, 98);
			this.ContentPacksLogo.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.ContentPacksLogo.TabIndex = 21;
			this.ContentPacksLogo.TabStop = false;
			this.ContentPackIconImage.BackColor = global::System.Drawing.Color.Transparent;
			this.ContentPackIconImage.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.ContentPackIconImage.Location = new global::System.Drawing.Point(22, 51);
			this.ContentPackIconImage.Name = "ContentPackIconImage";
			this.ContentPackIconImage.Size = new global::System.Drawing.Size(208, 208);
			this.ContentPackIconImage.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ContentPackIconImage.TabIndex = 11;
			this.ContentPackIconImage.TabStop = false;
			this.SortByLabel.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.SortByLabel.AutoSize = true;
			this.SortByLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.SortByLabel.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.SortByLabel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.SortByLabel.Location = new global::System.Drawing.Point(473, 10);
			this.SortByLabel.Name = "SortByLabel";
			this.SortByLabel.Size = new global::System.Drawing.Size(57, 19);
			this.SortByLabel.TabIndex = 10;
			this.SortByLabel.Text = "Sort by:";
			this.ContentPackStatusLabel.AutoSize = true;
			this.ContentPackStatusLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.ContentPackStatusLabel.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.ContentPackStatusLabel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.ContentPackStatusLabel.Location = new global::System.Drawing.Point(123, 8);
			this.ContentPackStatusLabel.Name = "ContentPackStatusLabel";
			this.ContentPackStatusLabel.Size = new global::System.Drawing.Size(66, 19);
			this.ContentPackStatusLabel.TabIndex = 10;
			this.ContentPackStatusLabel.Text = "Disabled";
			this.ContentPackTitle.AutoSize = true;
			this.ContentPackTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.ContentPackTitle.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.ContentPackTitle.ForeColor = global::System.Drawing.Color.Gray;
			this.ContentPackTitle.Location = new global::System.Drawing.Point(10, 8);
			this.ContentPackTitle.Name = "ContentPackTitle";
			this.ContentPackTitle.Size = new global::System.Drawing.Size(110, 19);
			this.ContentPackTitle.TabIndex = 10;
			this.ContentPackTitle.Text = "Content Packs:";
			this.RemoveContentPackButton.Enabled = false;
			this.RemoveContentPackButton.Location = new global::System.Drawing.Point(536, 159);
			this.RemoveContentPackButton.Name = "RemoveContentPackButton";
			this.RemoveContentPackButton.Size = new global::System.Drawing.Size(83, 23);
			this.RemoveContentPackButton.TabIndex = 15;
			this.RemoveContentPackButton.Text = "Remove";
			this.RemoveContentPackButton.UseVisualStyleBackColor = true;
			this.RemoveContentPackButton.Click += new global::System.EventHandler(this.RemoveContentPackButton_Click);
			this.ViewingNumberLabel.AutoSize = true;
			this.ViewingNumberLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.ViewingNumberLabel.Font = new global::System.Drawing.Font("Calibri", 9f);
			this.ViewingNumberLabel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.ViewingNumberLabel.Location = new global::System.Drawing.Point(92, 338);
			this.ViewingNumberLabel.Name = "ViewingNumberLabel";
			this.ViewingNumberLabel.Size = new global::System.Drawing.Size(69, 14);
			this.ViewingNumberLabel.TabIndex = 10;
			this.ViewingNumberLabel.Text = "viewing 0/0";
			this.MovePreviousButton.BackColor = global::System.Drawing.Color.Transparent;
			this.MovePreviousButton.Enabled = false;
			this.MovePreviousButton.HoverEndColor = global::System.Drawing.Color.DodgerBlue;
			this.MovePreviousButton.HoverStartColor = global::System.Drawing.Color.WhiteSmoke;
			this.MovePreviousButton.Location = new global::System.Drawing.Point(34, 286);
			this.MovePreviousButton.Name = "MovePreviousButton";
			this.MovePreviousButton.NormalEndColor = global::System.Drawing.Color.DarkGray;
			this.MovePreviousButton.NormalStartColor = global::System.Drawing.Color.WhiteSmoke;
			this.MovePreviousButton.Rotation = 270;
			this.MovePreviousButton.Size = new global::System.Drawing.Size(55, 55);
			this.MovePreviousButton.TabIndex = 14;
			this.MovePreviousButton.Text = "arrowButton1";
			this.MovePreviousButton.Click += new global::System.EventHandler(this.MovePreviousButton_Click);
			this.BrowseLabel.AutoSize = true;
			this.BrowseLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.BrowseLabel.Font = new global::System.Drawing.Font("Calibri", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			this.BrowseLabel.ForeColor = global::System.Drawing.Color.DarkGray;
			this.BrowseLabel.Location = new global::System.Drawing.Point(98, 304);
			this.BrowseLabel.Name = "BrowseLabel";
			this.BrowseLabel.Size = new global::System.Drawing.Size(56, 19);
			this.BrowseLabel.TabIndex = 10;
			this.BrowseLabel.Text = "browse";
			this.MoveNextButton.BackColor = global::System.Drawing.Color.Transparent;
			this.MoveNextButton.Enabled = false;
			this.MoveNextButton.HoverEndColor = global::System.Drawing.Color.DodgerBlue;
			this.MoveNextButton.HoverStartColor = global::System.Drawing.Color.WhiteSmoke;
			this.MoveNextButton.Location = new global::System.Drawing.Point(163, 286);
			this.MoveNextButton.Name = "MoveNextButton";
			this.MoveNextButton.NormalEndColor = global::System.Drawing.Color.DarkGray;
			this.MoveNextButton.NormalStartColor = global::System.Drawing.Color.WhiteSmoke;
			this.MoveNextButton.Rotation = 90;
			this.MoveNextButton.Size = new global::System.Drawing.Size(55, 55);
			this.MoveNextButton.TabIndex = 14;
			this.MoveNextButton.Text = "arrowButton1";
			this.MoveNextButton.Click += new global::System.EventHandler(this.MoveNextButton_Click);
			this.SortByComboBox.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right);
			this.SortByComboBox.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SortByComboBox.FormattingEnabled = true;
			this.SortByComboBox.Items.AddRange(new object[]
			{
				"Name",
				"Date Installed"
			});
			this.SortByComboBox.Location = new global::System.Drawing.Point(536, 8);
			this.SortByComboBox.Name = "SortByComboBox";
			this.SortByComboBox.Size = new global::System.Drawing.Size(95, 21);
			this.SortByComboBox.TabIndex = 19;
			this.SortByComboBox.SelectedIndexChanged += new global::System.EventHandler(this.SortByComboBox_SelectedIndexChanged);
			this.DateInstalledDescriptionLabel.AutoSize = true;
			this.DateInstalledDescriptionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.DateInstalledDescriptionLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.DateInstalledDescriptionLabel.Location = new global::System.Drawing.Point(265, 139);
			this.DateInstalledDescriptionLabel.Name = "DateInstalledDescriptionLabel";
			this.DateInstalledDescriptionLabel.Size = new global::System.Drawing.Size(75, 13);
			this.DateInstalledDescriptionLabel.TabIndex = 13;
			this.DateInstalledDescriptionLabel.Text = "Date Installed:";
			this.InstallCheckBox.AutoSize = true;
			this.InstallCheckBox.BackColor = global::System.Drawing.Color.Transparent;
			this.InstallCheckBox.Enabled = false;
			this.InstallCheckBox.ForeColor = global::System.Drawing.Color.DimGray;
			this.InstallCheckBox.Location = new global::System.Drawing.Point(267, 166);
			this.InstallCheckBox.Name = "InstallCheckBox";
			this.InstallCheckBox.Size = new global::System.Drawing.Size(119, 17);
			this.InstallCheckBox.TabIndex = 18;
			this.InstallCheckBox.Text = "[No Content Packs]";
			this.InstallCheckBox.UseVisualStyleBackColor = false;
			this.InstallCheckBox.CheckedChanged += new global::System.EventHandler(this.InstallCheckBox_CheckedChanged);
			this.StatusDescriptionLabel.AutoSize = true;
			this.StatusDescriptionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.StatusDescriptionLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.StatusDescriptionLabel.Location = new global::System.Drawing.Point(264, 117);
			this.StatusDescriptionLabel.Name = "StatusDescriptionLabel";
			this.StatusDescriptionLabel.Size = new global::System.Drawing.Size(40, 13);
			this.StatusDescriptionLabel.TabIndex = 13;
			this.StatusDescriptionLabel.Text = "Status:";
			this.AutoUpdateCheckBox.AutoSize = true;
			this.AutoUpdateCheckBox.BackColor = global::System.Drawing.Color.Transparent;
			this.AutoUpdateCheckBox.Enabled = false;
			this.AutoUpdateCheckBox.ForeColor = global::System.Drawing.Color.DimGray;
			this.AutoUpdateCheckBox.Location = new global::System.Drawing.Point(444, 165);
			this.AutoUpdateCheckBox.Name = "AutoUpdateCheckBox";
			this.AutoUpdateCheckBox.Size = new global::System.Drawing.Size(86, 17);
			this.AutoUpdateCheckBox.TabIndex = 18;
			this.AutoUpdateCheckBox.Text = "Auto Update";
			this.AutoUpdateCheckBox.UseVisualStyleBackColor = false;
			this.AutoUpdateCheckBox.CheckedChanged += new global::System.EventHandler(this.AutoUpdateCheckBox_CheckedChanged);
			this.VersionDescriptionLabel.AutoSize = true;
			this.VersionDescriptionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.VersionDescriptionLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.VersionDescriptionLabel.Location = new global::System.Drawing.Point(264, 95);
			this.VersionDescriptionLabel.Name = "VersionDescriptionLabel";
			this.VersionDescriptionLabel.Size = new global::System.Drawing.Size(45, 13);
			this.VersionDescriptionLabel.TabIndex = 13;
			this.VersionDescriptionLabel.Text = "Version:";
			this.EnableContentPacksLink.ActiveLinkColor = global::System.Drawing.Color.FromArgb(51, 153, 255);
			this.EnableContentPacksLink.AutoSize = true;
			this.EnableContentPacksLink.BackColor = global::System.Drawing.Color.Transparent;
			this.EnableContentPacksLink.Font = new global::System.Drawing.Font("Calibri", 12f);
			this.EnableContentPacksLink.LinkColor = global::System.Drawing.Color.FromArgb(51, 153, 255);
			this.EnableContentPacksLink.Location = new global::System.Drawing.Point(194, 8);
			this.EnableContentPacksLink.Name = "EnableContentPacksLink";
			this.EnableContentPacksLink.Size = new global::System.Drawing.Size(53, 19);
			this.EnableContentPacksLink.TabIndex = 17;
			this.EnableContentPacksLink.TabStop = true;
			this.EnableContentPacksLink.Text = "Enable";
			this.EnableContentPacksLink.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.EnableContentPacksLink_LinkClicked);
			this.CustomizeLink.ActiveLinkColor = global::System.Drawing.Color.FromArgb(51, 153, 255);
			this.CustomizeLink.AutoSize = true;
			this.CustomizeLink.BackColor = global::System.Drawing.Color.Transparent;
			this.CustomizeLink.LinkColor = global::System.Drawing.Color.FromArgb(51, 153, 255);
			this.CustomizeLink.Location = new global::System.Drawing.Point(55, 262);
			this.CustomizeLink.Name = "CustomizeLink";
			this.CustomizeLink.Size = new global::System.Drawing.Size(142, 13);
			this.CustomizeLink.TabIndex = 17;
			this.CustomizeLink.TabStop = true;
			this.CustomizeLink.Text = "Customize this Content Pack";
			this.CustomizeLink.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CustomizeLink_LinkClicked);
			this.AuthorDescriptionLabel.AutoSize = true;
			this.AuthorDescriptionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.AuthorDescriptionLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.AuthorDescriptionLabel.Location = new global::System.Drawing.Point(264, 73);
			this.AuthorDescriptionLabel.Name = "AuthorDescriptionLabel";
			this.AuthorDescriptionLabel.Size = new global::System.Drawing.Size(41, 13);
			this.AuthorDescriptionLabel.TabIndex = 13;
			this.AuthorDescriptionLabel.Text = "Author:";
			this.DateInstalledLabel.AutoEllipsis = true;
			this.DateInstalledLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.DateInstalledLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.DateInstalledLabel.Location = new global::System.Drawing.Point(345, 139);
			this.DateInstalledLabel.Name = "DateInstalledLabel";
			this.DateInstalledLabel.Size = new global::System.Drawing.Size(164, 13);
			this.DateInstalledLabel.TabIndex = 13;
			this.StatusLabel.AutoEllipsis = true;
			this.StatusLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.StatusLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.StatusLabel.Location = new global::System.Drawing.Point(345, 117);
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new global::System.Drawing.Size(164, 13);
			this.StatusLabel.TabIndex = 13;
			this.VersionLabel.AutoEllipsis = true;
			this.VersionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.VersionLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.VersionLabel.Location = new global::System.Drawing.Point(345, 95);
			this.VersionLabel.Name = "VersionLabel";
			this.VersionLabel.Size = new global::System.Drawing.Size(164, 13);
			this.VersionLabel.TabIndex = 13;
			this.AuthorLabel.AutoEllipsis = true;
			this.AuthorLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.AuthorLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.AuthorLabel.Location = new global::System.Drawing.Point(345, 73);
			this.AuthorLabel.Name = "AuthorLabel";
			this.AuthorLabel.Size = new global::System.Drawing.Size(164, 13);
			this.AuthorLabel.TabIndex = 13;
			this.NameLabel.AutoEllipsis = true;
			this.NameLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.NameLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.NameLabel.Location = new global::System.Drawing.Point(345, 51);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new global::System.Drawing.Size(164, 13);
			this.NameLabel.TabIndex = 13;
			this.NameDescriptionLabel.AutoSize = true;
			this.NameDescriptionLabel.BackColor = global::System.Drawing.Color.Transparent;
			this.NameDescriptionLabel.ForeColor = global::System.Drawing.Color.DimGray;
			this.NameDescriptionLabel.Location = new global::System.Drawing.Point(264, 51);
			this.NameDescriptionLabel.Name = "NameDescriptionLabel";
			this.NameDescriptionLabel.Size = new global::System.Drawing.Size(38, 13);
			this.NameDescriptionLabel.TabIndex = 13;
			this.NameDescriptionLabel.Text = "Name:";
			this.DescriptionBox.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.DescriptionBox.DetectUrls = false;
			this.DescriptionBox.Location = new global::System.Drawing.Point(267, 186);
			this.DescriptionBox.Name = "DescriptionBox";
			this.DescriptionBox.ReadOnly = true;
			this.DescriptionBox.Size = new global::System.Drawing.Size(352, 168);
			this.DescriptionBox.TabIndex = 16;
			this.DescriptionBox.Text = "";
			base.AcceptButton = this.CloseButton;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(218, 228, 246);
			base.CancelButton = this.CloseButton;
			base.ClientSize = new global::System.Drawing.Size(646, 413);
			base.Controls.Add(this.AddNightLifeButton);
			base.Controls.Add(this.CreateYourOwnButton);
			base.Controls.Add(this.CloseButton);
			base.Controls.Add(this.OpenNewButton);
			base.Controls.Add(this.grpContentPacks);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "ContentPacks";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "The ToonTown Spoofer : Content Packs";
			base.Shown += new global::System.EventHandler(this.ContentPacks_Shown);
			base.HelpRequested += new global::System.Windows.Forms.HelpEventHandler(this.ContentPacks_HelpRequested);
			this.grpContentPacks.ResumeLayout(false);
			this.grpContentPacks.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.ContentPacksLogo).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ContentPackIconImage).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040009B2 RID: 2482
		private global::System.ComponentModel.IContainer icontainer_0;

		// Token: 0x040009B3 RID: 2483
		private global::System.Windows.Forms.Label ContentPackTitle;

		// Token: 0x040009B4 RID: 2484
		private global::System.Windows.Forms.PictureBox ContentPackIconImage;

		// Token: 0x040009B5 RID: 2485
		private global::System.Windows.Forms.Label NameDescriptionLabel;

		// Token: 0x040009B6 RID: 2486
		private global::System.Windows.Forms.Label AuthorDescriptionLabel;

		// Token: 0x040009B7 RID: 2487
		private global::System.Windows.Forms.Label VersionDescriptionLabel;

		// Token: 0x040009B8 RID: 2488
		private global::System.Windows.Forms.Label StatusDescriptionLabel;

		// Token: 0x040009B9 RID: 2489
		private global::ns16.Control8 MovePreviousButton;

		// Token: 0x040009BA RID: 2490
		private global::ns16.Control8 MoveNextButton;

		// Token: 0x040009BB RID: 2491
		private global::System.Windows.Forms.Label BrowseLabel;

		// Token: 0x040009BC RID: 2492
		private global::System.Windows.Forms.Button RemoveContentPackButton;

		// Token: 0x040009BD RID: 2493
		private global::System.Windows.Forms.Button OpenNewButton;

		// Token: 0x040009BE RID: 2494
		private global::System.Windows.Forms.Button CloseButton;

		// Token: 0x040009BF RID: 2495
		private global::ns21.Class185 DescriptionBox;

		// Token: 0x040009C0 RID: 2496
		private global::System.Windows.Forms.LinkLabel CustomizeLink;

		// Token: 0x040009C1 RID: 2497
		private global::System.Windows.Forms.CheckBox AutoUpdateCheckBox;

		// Token: 0x040009C2 RID: 2498
		private global::System.Windows.Forms.CheckBox InstallCheckBox;

		// Token: 0x040009C3 RID: 2499
		private global::System.Windows.Forms.Label DateInstalledDescriptionLabel;

		// Token: 0x040009C4 RID: 2500
		private global::System.Windows.Forms.ComboBox SortByComboBox;

		// Token: 0x040009C5 RID: 2501
		private global::System.Windows.Forms.Label ViewingNumberLabel;

		// Token: 0x040009C6 RID: 2502
		private global::ns24.Class310 grpContentPacks;

		// Token: 0x040009C7 RID: 2503
		private global::System.Windows.Forms.Label ContentPackStatusLabel;

		// Token: 0x040009C8 RID: 2504
		private global::System.Windows.Forms.LinkLabel EnableContentPacksLink;

		// Token: 0x040009C9 RID: 2505
		private global::System.Windows.Forms.Button CreateYourOwnButton;

		// Token: 0x040009CA RID: 2506
		private global::System.Windows.Forms.Button AddNightLifeButton;

		// Token: 0x040009CB RID: 2507
		private global::System.Windows.Forms.Label SortByLabel;

		// Token: 0x040009CC RID: 2508
		private global::System.Windows.Forms.PictureBox ContentPacksLogo;

		// Token: 0x040009CD RID: 2509
		private global::System.Windows.Forms.OpenFileDialog openFileDialog_0;

		// Token: 0x040009CE RID: 2510
		private global::System.Windows.Forms.Label DateInstalledLabel;

		// Token: 0x040009CF RID: 2511
		private global::System.Windows.Forms.Label StatusLabel;

		// Token: 0x040009D0 RID: 2512
		private global::System.Windows.Forms.Label VersionLabel;

		// Token: 0x040009D1 RID: 2513
		private global::System.Windows.Forms.Label AuthorLabel;

		// Token: 0x040009D2 RID: 2514
		private global::System.Windows.Forms.Label NameLabel;

		// Token: 0x040009D3 RID: 2515
		private global::ns19.AnimatedLeftArrow AnimatedPointer;

		// Token: 0x040009D4 RID: 2516
		private global::System.Windows.Forms.Label HowToOpenHelpLabel;

		// Token: 0x040009D5 RID: 2517
		private global::ns23.Class135 class135_0;
	}
}
