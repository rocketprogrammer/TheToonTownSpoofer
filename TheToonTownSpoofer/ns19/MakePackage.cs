using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;
using ns14;
using ns15;
using ns16;
using ns17;
using ns18;
using ns20;
using ns21;
using ns22;
using ns23;
using ns24;
using ns25;
using ns26;
using ns27;
using ns28;
using ns29;
using ns30;
using ns31;
using TheToonTownSpoofer.IO.Archive;
using TSN.Controls;

namespace ns19
{
	// Token: 0x02000404 RID: 1028
	internal sealed partial class MakePackage : SaveForm
	{
		// Token: 0x06002719 RID: 10009 RVA: 0x0008C70C File Offset: 0x0008A90C
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private void InitializeComponent_1()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MakePackage));
			this.gdContentPackProperties = new PropertyGrid();
			this.mnuMain = new MenuStrip();
			this.mniFile = new ToolStripMenuItem();
			this.mniNew = new ToolStripMenuItem();
			this.mniOpen = new ToolStripMenuItem();
			this.mniSep1 = new ToolStripSeparator();
			this.mniSave = new ToolStripMenuItem();
			this.mniSaveAs = new ToolStripMenuItem();
			this.mniSep2 = new ToolStripSeparator();
			this.mniClose = new ToolStripMenuItem();
			this.mniEdit = new ToolStripMenuItem();
			this.mniSelectPanda3dpViewPath = new ToolStripMenuItem();
			this.mniCreate = new ToolStripMenuItem();
			this.mniPatch = new ToolStripMenuItem();
			this.HelpMenuItem = new ToolStripMenuItem();
			this.GuideMenuItem = new ToolStripMenuItem();
			this.tsMain = new ToolStrip();
			this.btnAddFile = new ToolStripButton();
			this.ddbRemoveFile = new ToolStripDropDownButton();
			this.mniRemoveFile = new ToolStripMenuItem();
			this.mniRemoveAllFiles = new ToolStripMenuItem();
			this.btnAddFolder = new ToolStripButton();
			this.ddbExtract = new ToolStripDropDownButton();
			this.mniExtractUserContent = new ToolStripMenuItem();
			this.mniExtractToonTownContent = new ToolStripMenuItem();
			this.ddbIndex = new ToolStripDropDownButton();
			this.mniOpenIndex = new ToolStripMenuItem();
			this.mniSaveIndex = new ToolStripMenuItem();
			this.tsSep1 = new ToolStripSeparator();
			this.lblFileSearch = new ToolStripLabel();
			this.txtFileSearch = new ToolStripTextBox();
			this.btnClearFileSearch = new ToolStripButton();
			this.tsSep2 = new ToolStripSeparator();
			this.btnPNG2JPGRGB = new ToolStripButton();
			this.btnJPGRGB = new ToolStripButton();
			this.tsSep3 = new ToolStripSeparator();
			this.mniModels = new ToolStripDropDownButton();
			this.mniBuildModelIndex = new ToolStripMenuItem();
			this.mniWithUserContent = new ToolStripMenuItem();
			this.mniWithToonTownContent = new ToolStripMenuItem();
			this.lblModelSearch = new ToolStripLabel();
			this.txtModelSearch = new ToolStripTextBox();
			this.btnClearModelSearch = new ToolStripButton();
			this.picUserContent = new PictureBox();
			this.picToonTownContent = new PictureBox();
			this.lblUserContent = new Label();
			this.lblToonTownContent = new Label();
			this.lblFiles = new Label();
			this.lblProperties = new Label();
			this.lblModels = new Label();
			this.ssHelp = new StatusStrip();
			this.barLoading = new ToolStripProgressBar();
			this.lblMouseOverHelp = new ToolStripStatusLabel();
			this.lblSelectedFile = new ToolStripStatusLabel();
			this.lblSelectedModel = new ToolStripStatusLabel();
			this.lbModels = new ListView();
			this.columnHeader_0 = new ColumnHeader();
			this.lbFiles = new ListView();
			this.columnHeader_1 = new ColumnHeader();
			this.openFileDialog_1 = new OpenFileDialog();
			this.panToonTownContent = new Panel();
			this.picToonTownContentAudioFile = new PictureBox();
			this.panUserContent = new Panel();
			this.picUserContentAudioFile = new PictureBox();
			this.folderBrowserDialog_0 = new FolderBrowserDialog();
			this.cboFilterUserContent = new CheckBox();
			this.saveFileDialog_1 = new SaveFileDialog();
			this.wmpToonTown = new LimitedMediaPlayer();
			this.wmpUserPlayer = new LimitedMediaPlayer();
			this.mnuMain.SuspendLayout();
			this.tsMain.SuspendLayout();
			((ISupportInitialize)this.picUserContent).BeginInit();
			((ISupportInitialize)this.picToonTownContent).BeginInit();
			this.ssHelp.SuspendLayout();
			this.panToonTownContent.SuspendLayout();
			((ISupportInitialize)this.picToonTownContentAudioFile).BeginInit();
			this.panUserContent.SuspendLayout();
			((ISupportInitialize)this.picUserContentAudioFile).BeginInit();
			base.SuspendLayout();
			this.gdContentPackProperties.Location = new Point(5, 98);
			this.gdContentPackProperties.Name = "gdContentPackProperties";
			this.gdContentPackProperties.PropertySort = PropertySort.Alphabetical;
			this.gdContentPackProperties.Size = new Size(180, 264);
			this.gdContentPackProperties.TabIndex = 0;
			this.gdContentPackProperties.ToolbarVisible = false;
			this.mnuMain.Items.AddRange(new ToolStripItem[]
			{
				this.mniFile,
				this.mniEdit,
				this.mniCreate,
				this.HelpMenuItem
			});
			this.mnuMain.Location = new Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new Size(1134, 24);
			this.mnuMain.TabIndex = 1;
			this.mnuMain.Text = "menuStrip1";
			this.mniFile.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mniNew,
				this.mniOpen,
				this.mniSep1,
				this.mniSave,
				this.mniSaveAs,
				this.mniSep2,
				this.mniClose
			});
			this.mniFile.Name = "mniFile";
			this.mniFile.Size = new Size(37, 20);
			this.mniFile.Text = "&File";
			this.mniNew.Name = "mniNew";
			this.mniNew.ShortcutKeys = (Keys)131150;
			this.mniNew.Size = new Size(186, 22);
			this.mniNew.Text = "&New";
			this.mniNew.Click += this.mniNew_Click;
			this.mniOpen.Name = "mniOpen";
			this.mniOpen.ShortcutKeys = (Keys)131151;
			this.mniOpen.Size = new Size(186, 22);
			this.mniOpen.Text = "&Open";
			this.mniOpen.Click += this.mniOpen_Click;
			this.mniSep1.Name = "mniSep1";
			this.mniSep1.Size = new Size(183, 6);
			this.mniSave.Name = "mniSave";
			this.mniSave.ShortcutKeys = (Keys)131155;
			this.mniSave.Size = new Size(186, 22);
			this.mniSave.Text = "&Save";
			this.mniSave.Click += this.mniSave_Click;
			this.mniSaveAs.Name = "mniSaveAs";
			this.mniSaveAs.ShortcutKeys = (Keys)196691;
			this.mniSaveAs.Size = new Size(186, 22);
			this.mniSaveAs.Text = "Save &As";
			this.mniSaveAs.Click += this.mniSaveAs_Click;
			this.mniSep2.Name = "mniSep2";
			this.mniSep2.Size = new Size(183, 6);
			this.mniClose.Name = "mniClose";
			this.mniClose.ShortcutKeys = (Keys)131159;
			this.mniClose.Size = new Size(186, 22);
			this.mniClose.Text = "&Close";
			this.mniClose.Click += this.mniClose_Click;
			this.mniEdit.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mniSelectPanda3dpViewPath
			});
			this.mniEdit.Name = "mniEdit";
			this.mniEdit.Size = new Size(39, 20);
			this.mniEdit.Text = "&Edit";
			this.mniSelectPanda3dpViewPath.Name = "mniSelectPanda3dpViewPath";
			this.mniSelectPanda3dpViewPath.Size = new Size(182, 22);
			this.mniSelectPanda3dpViewPath.Text = "&Panda3d pView Path";
			this.mniSelectPanda3dpViewPath.Click += this.mniSelectPanda3dpViewPath_Click;
			this.mniCreate.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mniPatch
			});
			this.mniCreate.Name = "mniCreate";
			this.mniCreate.Size = new Size(53, 20);
			this.mniCreate.Text = "&Create";
			this.mniPatch.Name = "mniPatch";
			this.mniPatch.Size = new Size(152, 22);
			this.mniPatch.Text = "&Patch";
			this.mniPatch.Click += this.mniPatch_Click;
			this.HelpMenuItem.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.GuideMenuItem
			});
			this.HelpMenuItem.Name = "HelpMenuItem";
			this.HelpMenuItem.Size = new Size(44, 20);
			this.HelpMenuItem.Text = "&Help";
			this.GuideMenuItem.Name = "GuideMenuItem";
			this.GuideMenuItem.ShortcutKeys = Keys.F1;
			this.GuideMenuItem.Size = new Size(152, 22);
			this.GuideMenuItem.Text = "&Guide";
			this.GuideMenuItem.Click += this.GuideMenuItem_Click;
			this.tsMain.Items.AddRange(new ToolStripItem[]
			{
				this.btnAddFile,
				this.ddbRemoveFile,
				this.btnAddFolder,
				this.ddbExtract,
				this.ddbIndex,
				this.tsSep1,
				this.lblFileSearch,
				this.txtFileSearch,
				this.btnClearFileSearch,
				this.tsSep2,
				this.btnPNG2JPGRGB,
				this.btnJPGRGB,
				this.tsSep3,
				this.mniModels,
				this.lblModelSearch,
				this.txtModelSearch,
				this.btnClearModelSearch
			});
			this.tsMain.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.tsMain.Location = new Point(0, 24);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new Size(1134, 38);
			this.tsMain.TabIndex = 5;
			this.tsMain.Text = "toolStrip1";
			this.btnAddFile.Image = (Image)componentResourceManager.GetObject("btnAddFile.Image");
			this.btnAddFile.ImageTransparentColor = Color.Magenta;
			this.btnAddFile.Name = "btnAddFile";
			this.btnAddFile.Size = new Size(54, 35);
			this.btnAddFile.Text = "Add File";
			this.btnAddFile.TextImageRelation = TextImageRelation.ImageAboveText;
			this.btnAddFile.ToolTipText = "Replace the selected file.";
			this.btnAddFile.Click += this.btnAddFile_Click;
			this.ddbRemoveFile.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mniRemoveFile,
				this.mniRemoveAllFiles
			});
			this.ddbRemoveFile.Image = (Image)componentResourceManager.GetObject("ddbRemoveFile.Image");
			this.ddbRemoveFile.ImageTransparentColor = Color.Magenta;
			this.ddbRemoveFile.Name = "ddbRemoveFile";
			this.ddbRemoveFile.Size = new Size(84, 35);
			this.ddbRemoveFile.Text = "Remove File";
			this.ddbRemoveFile.TextImageRelation = TextImageRelation.ImageAboveText;
			this.ddbRemoveFile.ToolTipText = "Remove the selected file.";
			this.ddbRemoveFile.DropDownOpening += this.ddbRemoveFile_DropDownOpening;
			this.mniRemoveFile.Name = "mniRemoveFile";
			this.mniRemoveFile.Size = new Size(160, 22);
			this.mniRemoveFile.Text = "Remove File";
			this.mniRemoveFile.Click += this.mniRemoveFile_Click;
			this.mniRemoveAllFiles.Name = "mniRemoveAllFiles";
			this.mniRemoveAllFiles.Size = new Size(160, 22);
			this.mniRemoveAllFiles.Text = "Remove All Files";
			this.mniRemoveAllFiles.Click += this.mniRemoveAllFiles_Click;
			this.btnAddFolder.Image = (Image)componentResourceManager.GetObject("btnAddFolder.Image");
			this.btnAddFolder.ImageTransparentColor = Color.Magenta;
			this.btnAddFolder.Name = "btnAddFolder";
			this.btnAddFolder.Size = new Size(69, 35);
			this.btnAddFolder.Text = "Add Folder";
			this.btnAddFolder.TextImageRelation = TextImageRelation.ImageAboveText;
			this.btnAddFolder.ToolTipText = "Add a folder or a folder structure.";
			this.btnAddFolder.Click += this.btnAddFolder_Click;
			this.ddbExtract.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mniExtractUserContent,
				this.mniExtractToonTownContent
			});
			this.ddbExtract.Image = (Image)componentResourceManager.GetObject("ddbExtract.Image");
			this.ddbExtract.ImageTransparentColor = Color.Magenta;
			this.ddbExtract.Name = "ddbExtract";
			this.ddbExtract.Size = new Size(55, 35);
			this.ddbExtract.Text = "Extract";
			this.ddbExtract.TextImageRelation = TextImageRelation.ImageAboveText;
			this.ddbExtract.DropDownOpening += this.ddbExtract_DropDownOpening;
			this.mniExtractUserContent.Name = "mniExtractUserContent";
			this.mniExtractUserContent.Size = new Size(153, 22);
			this.mniExtractUserContent.Text = "User File";
			this.mniExtractUserContent.Click += this.mniExtractUserContent_Click;
			this.mniExtractToonTownContent.Name = "mniExtractToonTownContent";
			this.mniExtractToonTownContent.Size = new Size(153, 22);
			this.mniExtractToonTownContent.Text = "ToonTown File";
			this.mniExtractToonTownContent.Click += this.mniExtractToonTownContent_Click;
			this.ddbIndex.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mniOpenIndex,
				this.mniSaveIndex
			});
			this.ddbIndex.Image = (Image)componentResourceManager.GetObject("ddbIndex.Image");
			this.ddbIndex.ImageTransparentColor = Color.Magenta;
			this.ddbIndex.Name = "ddbIndex";
			this.ddbIndex.Size = new Size(48, 35);
			this.ddbIndex.Text = "Index";
			this.ddbIndex.TextImageRelation = TextImageRelation.ImageAboveText;
			this.mniOpenIndex.Name = "mniOpenIndex";
			this.mniOpenIndex.Size = new Size(134, 22);
			this.mniOpenIndex.Text = "Open Index";
			this.mniOpenIndex.Click += this.mniOpenIndex_Click;
			this.mniSaveIndex.Name = "mniSaveIndex";
			this.mniSaveIndex.Size = new Size(134, 22);
			this.mniSaveIndex.Text = "Save Index";
			this.mniSaveIndex.Click += this.mniSaveIndex_Click;
			this.tsSep1.Name = "tsSep1";
			this.tsSep1.Size = new Size(6, 38);
			this.lblFileSearch.Name = "lblFileSearch";
			this.lblFileSearch.Size = new Size(66, 35);
			this.lblFileSearch.Text = "File Search:";
			this.txtFileSearch.Name = "txtFileSearch";
			this.txtFileSearch.Size = new Size(100, 38);
			this.txtFileSearch.TextChanged += this.txtFileSearch_TextChanged;
			this.btnClearFileSearch.Image = (Image)componentResourceManager.GetObject("btnClearFileSearch.Image");
			this.btnClearFileSearch.ImageTransparentColor = Color.Magenta;
			this.btnClearFileSearch.Name = "btnClearFileSearch";
			this.btnClearFileSearch.Size = new Size(38, 35);
			this.btnClearFileSearch.Text = "Clear";
			this.btnClearFileSearch.TextImageRelation = TextImageRelation.ImageAboveText;
			this.btnClearFileSearch.ToolTipText = "Clear the search box.";
			this.btnClearFileSearch.Click += this.btnClearFileSearch_Click;
			this.tsSep2.Name = "tsSep2";
			this.tsSep2.Size = new Size(6, 38);
			this.btnPNG2JPGRGB.Image = (Image)componentResourceManager.GetObject("btnPNG2JPGRGB.Image");
			this.btnPNG2JPGRGB.ImageTransparentColor = Color.Magenta;
			this.btnPNG2JPGRGB.Name = "btnPNG2JPGRGB";
			this.btnPNG2JPGRGB.Size = new Size(61, 35);
			this.btnPNG2JPGRGB.Text = "PNG Split";
			this.btnPNG2JPGRGB.TextImageRelation = TextImageRelation.ImageAboveText;
			this.btnPNG2JPGRGB.ToolTipText = "Converts and splits an PNG file to an JPG and RGB file.";
			this.btnPNG2JPGRGB.Click += this.btnPNG2JPGRGB_Click;
			this.btnJPGRGB.Image = (Image)componentResourceManager.GetObject("btnJPGRGB.Image");
			this.btnJPGRGB.ImageTransparentColor = Color.Magenta;
			this.btnJPGRGB.Name = "btnJPGRGB";
			this.btnJPGRGB.Size = new Size(74, 35);
			this.btnJPGRGB.Text = "JPG <> RGB";
			this.btnJPGRGB.TextImageRelation = TextImageRelation.ImageAboveText;
			this.btnJPGRGB.ToolTipText = "Converts an JPG to an RGB or an RGB to an JPG.";
			this.btnJPGRGB.Click += this.btnJPGRGB_Click;
			this.tsSep3.Name = "tsSep3";
			this.tsSep3.Size = new Size(6, 38);
			this.mniModels.DropDownItems.AddRange(new ToolStripItem[]
			{
				this.mniBuildModelIndex,
				this.mniWithUserContent,
				this.mniWithToonTownContent
			});
			this.mniModels.Image = (Image)componentResourceManager.GetObject("mniModels.Image");
			this.mniModels.ImageTransparentColor = Color.Magenta;
			this.mniModels.Name = "mniModels";
			this.mniModels.Size = new Size(59, 35);
			this.mniModels.Text = "Models";
			this.mniModels.TextImageRelation = TextImageRelation.ImageAboveText;
			this.mniBuildModelIndex.Name = "mniBuildModelIndex";
			this.mniBuildModelIndex.Size = new Size(236, 22);
			this.mniBuildModelIndex.Text = "Build Model Index";
			this.mniBuildModelIndex.Click += this.mniBuildModelIndex_Click;
			this.mniWithUserContent.Enabled = false;
			this.mniWithUserContent.Name = "mniWithUserContent";
			this.mniWithUserContent.Size = new Size(236, 22);
			this.mniWithUserContent.Text = "Open with User Content";
			this.mniWithUserContent.Click += this.mniWithUserContent_Click;
			this.mniWithToonTownContent.Enabled = false;
			this.mniWithToonTownContent.Name = "mniWithToonTownContent";
			this.mniWithToonTownContent.Size = new Size(236, 22);
			this.mniWithToonTownContent.Text = "Open with ToonTown Content";
			this.mniWithToonTownContent.Click += this.mniWithToonTownContent_Click;
			this.lblModelSearch.Name = "lblModelSearch";
			this.lblModelSearch.Size = new Size(82, 35);
			this.lblModelSearch.Text = "Model Search:";
			this.txtModelSearch.Enabled = false;
			this.txtModelSearch.Name = "txtModelSearch";
			this.txtModelSearch.Size = new Size(100, 38);
			this.txtModelSearch.TextChanged += this.txtModelSearch_TextChanged;
			this.btnClearModelSearch.Enabled = false;
			this.btnClearModelSearch.Image = (Image)componentResourceManager.GetObject("btnClearModelSearch.Image");
			this.btnClearModelSearch.ImageTransparentColor = Color.Magenta;
			this.btnClearModelSearch.Name = "btnClearModelSearch";
			this.btnClearModelSearch.Size = new Size(38, 35);
			this.btnClearModelSearch.Text = "Clear";
			this.btnClearModelSearch.TextImageRelation = TextImageRelation.ImageAboveText;
			this.btnClearModelSearch.Click += this.btnClearModelSearch_Click;
			this.picUserContent.Location = new Point(0, 0);
			this.picUserContent.MaximumSize = new Size(224, 224);
			this.picUserContent.Name = "picUserContent";
			this.picUserContent.Size = new Size(224, 224);
			this.picUserContent.SizeMode = PictureBoxSizeMode.StretchImage;
			this.picUserContent.TabIndex = 6;
			this.picUserContent.TabStop = false;
			this.picToonTownContent.Location = new Point(0, 0);
			this.picToonTownContent.MaximumSize = new Size(224, 224);
			this.picToonTownContent.Name = "picToonTownContent";
			this.picToonTownContent.Size = new Size(224, 224);
			this.picToonTownContent.SizeMode = PictureBoxSizeMode.StretchImage;
			this.picToonTownContent.TabIndex = 6;
			this.picToonTownContent.TabStop = false;
			this.lblUserContent.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblUserContent.AutoSize = true;
			this.lblUserContent.Font = new Font("Calibri", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.lblUserContent.Location = new Point(427, 69);
			this.lblUserContent.Name = "lblUserContent";
			this.lblUserContent.Size = new Size(123, 26);
			this.lblUserContent.TabIndex = 9;
			this.lblUserContent.Text = "User Content";
			this.lblToonTownContent.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblToonTownContent.AutoSize = true;
			this.lblToonTownContent.Font = new Font("Calibri", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.lblToonTownContent.Location = new Point(657, 69);
			this.lblToonTownContent.Name = "lblToonTownContent";
			this.lblToonTownContent.Size = new Size(171, 26);
			this.lblToonTownContent.TabIndex = 9;
			this.lblToonTownContent.Text = "ToonTown Content";
			this.lblFiles.AutoSize = true;
			this.lblFiles.Font = new Font("Calibri", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.lblFiles.Location = new Point(186, 69);
			this.lblFiles.Name = "lblFiles";
			this.lblFiles.Size = new Size(50, 26);
			this.lblFiles.TabIndex = 9;
			this.lblFiles.Text = "Files";
			this.lblProperties.AutoSize = true;
			this.lblProperties.Font = new Font("Calibri", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.lblProperties.Location = new Point(0, 69);
			this.lblProperties.Name = "lblProperties";
			this.lblProperties.Size = new Size(99, 26);
			this.lblProperties.TabIndex = 9;
			this.lblProperties.Text = "Properties";
			this.lblModels.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lblModels.AutoSize = true;
			this.lblModels.Font = new Font("Calibri", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 204);
			this.lblModels.Location = new Point(887, 69);
			this.lblModels.Name = "lblModels";
			this.lblModels.Size = new Size(75, 26);
			this.lblModels.TabIndex = 9;
			this.lblModels.Text = "Models";
			this.ssHelp.Items.AddRange(new ToolStripItem[]
			{
				this.barLoading,
				this.lblMouseOverHelp,
				this.lblSelectedFile,
				this.lblSelectedModel
			});
			this.ssHelp.Location = new Point(0, 370);
			this.ssHelp.Name = "ssHelp";
			this.ssHelp.Size = new Size(1134, 22);
			this.ssHelp.SizingGrip = false;
			this.ssHelp.TabIndex = 11;
			this.barLoading.Name = "barLoading";
			this.barLoading.Size = new Size(100, 16);
			this.barLoading.Style = ProgressBarStyle.Marquee;
			this.barLoading.Visible = false;
			this.lblMouseOverHelp.Name = "lblMouseOverHelp";
			this.lblMouseOverHelp.Size = new Size(0, 17);
			this.lblSelectedFile.Name = "lblSelectedFile";
			this.lblSelectedFile.Size = new Size(0, 17);
			this.lblSelectedModel.Name = "lblSelectedModel";
			this.lblSelectedModel.Size = new Size(0, 17);
			this.lbModels.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.lbModels.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_0
			});
			this.lbModels.FullRowSelect = true;
			this.lbModels.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.lbModels.HideSelection = false;
			this.lbModels.Location = new Point(892, 98);
			this.lbModels.MultiSelect = false;
			this.lbModels.Name = "lbModels";
			this.lbModels.Size = new Size(235, 264);
			this.lbModels.TabIndex = 13;
			this.lbModels.UseCompatibleStateImageBehavior = false;
			this.lbModels.View = View.Details;
			this.lbModels.SelectedIndexChanged += this.lbModels_SelectedIndexChanged;
			this.lbModels.DoubleClick += this.lbModels_DoubleClick;
			this.columnHeader_0.Text = "";
			this.columnHeader_0.Width = 210;
			this.lbFiles.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
			this.lbFiles.Columns.AddRange(new ColumnHeader[]
			{
				this.columnHeader_1
			});
			this.lbFiles.FullRowSelect = true;
			this.lbFiles.HeaderStyle = ColumnHeaderStyle.Nonclickable;
			this.lbFiles.HideSelection = false;
			this.lbFiles.Location = new Point(191, 98);
			this.lbFiles.MultiSelect = false;
			this.lbFiles.Name = "lbFiles";
			this.lbFiles.Size = new Size(235, 264);
			this.lbFiles.TabIndex = 13;
			this.lbFiles.UseCompatibleStateImageBehavior = false;
			this.lbFiles.View = View.Details;
			this.lbFiles.SelectedIndexChanged += this.lbFiles_SelectedIndexChanged;
			this.lbFiles.DoubleClick += this.lbFiles_DoubleClick;
			this.columnHeader_1.Text = "";
			this.columnHeader_1.Width = 210;
			this.panToonTownContent.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.panToonTownContent.BorderStyle = BorderStyle.FixedSingle;
			this.panToonTownContent.Controls.Add(this.picToonTownContentAudioFile);
			this.panToonTownContent.Controls.Add(this.picToonTownContent);
			this.panToonTownContent.Location = new Point(662, 98);
			this.panToonTownContent.Name = "panToonTownContent";
			this.panToonTownContent.Size = new Size(224, 224);
			this.panToonTownContent.TabIndex = 14;
			this.picToonTownContentAudioFile.Image = (Image)componentResourceManager.GetObject("picToonTownContentAudioFile.Image");
			this.picToonTownContentAudioFile.Location = new Point(87, 87);
			this.picToonTownContentAudioFile.Name = "picToonTownContentAudioFile";
			this.picToonTownContentAudioFile.Size = new Size(48, 48);
			this.picToonTownContentAudioFile.SizeMode = PictureBoxSizeMode.AutoSize;
			this.picToonTownContentAudioFile.TabIndex = 7;
			this.picToonTownContentAudioFile.TabStop = false;
			this.picToonTownContentAudioFile.Visible = false;
			this.panUserContent.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.panUserContent.BorderStyle = BorderStyle.FixedSingle;
			this.panUserContent.Controls.Add(this.picUserContentAudioFile);
			this.panUserContent.Controls.Add(this.picUserContent);
			this.panUserContent.Location = new Point(432, 98);
			this.panUserContent.Name = "panUserContent";
			this.panUserContent.Size = new Size(224, 224);
			this.panUserContent.TabIndex = 15;
			this.picUserContentAudioFile.Image = (Image)componentResourceManager.GetObject("picUserContentAudioFile.Image");
			this.picUserContentAudioFile.Location = new Point(87, 87);
			this.picUserContentAudioFile.Name = "picUserContentAudioFile";
			this.picUserContentAudioFile.Size = new Size(48, 48);
			this.picUserContentAudioFile.SizeMode = PictureBoxSizeMode.AutoSize;
			this.picUserContentAudioFile.TabIndex = 7;
			this.picUserContentAudioFile.TabStop = false;
			this.picUserContentAudioFile.Visible = false;
			this.cboFilterUserContent.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.cboFilterUserContent.AutoSize = true;
			this.cboFilterUserContent.CheckAlign = ContentAlignment.MiddleRight;
			this.cboFilterUserContent.Font = new Font("Segoe UI", 8f);
			this.cboFilterUserContent.Location = new Point(303, 78);
			this.cboFilterUserContent.Name = "cboFilterUserContent";
			this.cboFilterUserContent.Size = new Size(123, 17);
			this.cboFilterUserContent.TabIndex = 16;
			this.cboFilterUserContent.Text = "Filter User Content";
			this.cboFilterUserContent.UseVisualStyleBackColor = true;
			this.cboFilterUserContent.CheckedChanged += this.cboFilterUserContent_CheckedChanged;
			this.wmpToonTown.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.wmpToonTown.BackColor = Color.White;
			this.wmpToonTown.BorderStyle = BorderStyle.FixedSingle;
			this.wmpToonTown.Location = new Point(662, 328);
			this.wmpToonTown.Name = "wmpToonTown";
			this.wmpToonTown.Size = new Size(224, 34);
			this.wmpToonTown.TabIndex = 7;
			this.wmpUserPlayer.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
			this.wmpUserPlayer.BackColor = Color.White;
			this.wmpUserPlayer.BorderStyle = BorderStyle.FixedSingle;
			this.wmpUserPlayer.Location = new Point(432, 328);
			this.wmpUserPlayer.Name = "wmpUserPlayer";
			this.wmpUserPlayer.Size = new Size(224, 34);
			this.wmpUserPlayer.TabIndex = 7;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(1134, 392);
			base.Controls.Add(this.cboFilterUserContent);
			base.Controls.Add(this.panUserContent);
			base.Controls.Add(this.panToonTownContent);
			base.Controls.Add(this.lbFiles);
			base.Controls.Add(this.lbModels);
			base.Controls.Add(this.ssHelp);
			base.Controls.Add(this.lblModels);
			base.Controls.Add(this.lblToonTownContent);
			base.Controls.Add(this.lblProperties);
			base.Controls.Add(this.lblFiles);
			base.Controls.Add(this.lblUserContent);
			base.Controls.Add(this.wmpToonTown);
			base.Controls.Add(this.wmpUserPlayer);
			base.Controls.Add(this.gdContentPackProperties);
			base.Controls.Add(this.tsMain);
			base.Controls.Add(this.mnuMain);
			base.MainMenuStrip = this.mnuMain;
			this.MaximumSize = new Size(2200, 430);
			this.MinimumSize = new Size(1150, 430);
			base.Name = "MakePackage";
			this.Text = "The ToonTown Spoofer : MakePackage";
			base.FormClosing += this.MakePackage_FormClosing;
			base.Load += this.MakePackage_Load;
			base.HelpRequested += this.MakePackage_HelpRequested;
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			((ISupportInitialize)this.picUserContent).EndInit();
			((ISupportInitialize)this.picToonTownContent).EndInit();
			this.ssHelp.ResumeLayout(false);
			this.ssHelp.PerformLayout();
			this.panToonTownContent.ResumeLayout(false);
			this.panToonTownContent.PerformLayout();
			((ISupportInitialize)this.picToonTownContentAudioFile).EndInit();
			this.panUserContent.ResumeLayout(false);
			this.panUserContent.PerformLayout();
			((ISupportInitialize)this.picUserContentAudioFile).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0600271A RID: 10010 RVA: 0x0008E8EC File Offset: 0x0008CAEC
		public MakePackage()
		{
			this.InitializeComponent_1();
			base.Icon = Class480.Content_Icon;
			this.class374_0 = new Class374();
			this.class374_0.Started += this.method_14;
			this.class374_0.Stopped += this.method_15;
			base.method_5();
		}

		// Token: 0x0600271B RID: 10011 RVA: 0x0008E9A0 File Offset: 0x0008CBA0
		protected override void vmethod_7(Class524 fileName, bool modified)
		{
			if (Class524.smethod_0(fileName, null))
			{
				if (modified)
				{
					this.Text = "The ToonTown Spoofer : MakePackage : New File*";
					return;
				}
				this.Text = "The ToonTown Spoofer : MakePackage : New File";
				return;
			}
			else
			{
				if (modified)
				{
					this.Text = string.Format("The ToonTown Spoofer : MakePackage : {0}*", Path.GetFileName(fileName.string_1));
					return;
				}
				this.Text = "The ToonTown Spoofer : MakePackage : " + Path.GetFileName(fileName.string_1);
				return;
			}
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x0008EA0C File Offset: 0x0008CC0C
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		private void method_10(Class132 cp)
		{
			this.class132_0 = cp;
			this.class504_0 = new Class504(this.class132_0);
			this.class504_0.ModifiedStateChanged += this.method_56;
			this.gdContentPackProperties.SelectedObject = this.class504_0;
			this.gdContentPackProperties.Refresh();
			this.method_11();
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00011872 File Offset: 0x0000FA72
		private void method_11()
		{
			this.method_12(this.class506_0.Keys);
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x0008EA6C File Offset: 0x0008CC6C
		private void method_12(IEnumerable<ListViewItemState<string>> files)
		{
			foreach (ListViewItemState<string> item in files)
			{
				this.method_13(item);
			}
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x0008EAB4 File Offset: 0x0008CCB4
		private void method_13(ListViewItemState<string> item)
		{
			bool flag = this.dictionary_1.ContainsKey(item.State);
			bool flag2 = this.class132_0.Data.MultiFileData.ContainsKey(item.State);
			if (flag)
			{
				if (flag2)
				{
					item.ForeColor = Color.Red;
					return;
				}
				item.ForeColor = Color.LightPink;
				return;
			}
			else
			{
				if (flag2)
				{
					item.ForeColor = Color.Black;
					return;
				}
				item.ForeColor = Color.Gray;
				return;
			}
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x00011885 File Offset: 0x0000FA85
		private void method_14(object sender, EventArgs e)
		{
			this.smethod_4(new MethodInvoker(this.method_57));
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00011899 File Offset: 0x0000FA99
		private void method_15(object sender, EventArgs e)
		{
			this.smethod_4(new MethodInvoker(this.method_58));
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x000118AD File Offset: 0x0000FAAD
		private void btnClearFileSearch_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.txtFileSearch.Text = string.Empty;
			this.method_16(false);
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x000118D1 File Offset: 0x0000FAD1
		private void txtFileSearch_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.method_16(false);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x000118E5 File Offset: 0x0000FAE5
		private void btnClearModelSearch_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.txtModelSearch.Text = string.Empty;
			this.method_16(false);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x000118D1 File Offset: 0x0000FAD1
		private void txtModelSearch_TextChanged(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.method_16(false);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x000118D1 File Offset: 0x0000FAD1
		private void cboFilterUserContent_CheckedChanged(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.method_16(false);
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x0008EB28 File Offset: 0x0008CD28
		private void method_16(bool insert)
		{
			if (insert)
			{
				this.class374_0.method_5(new Action<object>(this.method_17), new KeyValuePair<string, string>(this.txtFileSearch.Text, this.txtModelSearch.Text));
				return;
			}
			this.class374_0.method_3(new Action<object>(this.method_17), new KeyValuePair<string, string>(this.txtFileSearch.Text, this.txtModelSearch.Text));
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x0008EBA8 File Offset: 0x0008CDA8
		private void method_17(object state)
		{
			KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)state;
			string text = keyValuePair.Key;
			string text2 = keyValuePair.Value;
			if (string.IsNullOrEmpty(text) && string.IsNullOrEmpty(text2))
			{
				this.class374_0.method_5(new Action<object>(this.method_20), this.class506_0.Keys.ToArray<ListViewItemState<string>>());
				this.class374_0.method_5(new Action<object>(this.method_21), this.class506_1.Keys.ToArray<ListViewItemState<string>>());
				return;
			}
			if (!string.IsNullOrEmpty(text))
			{
				if (!text.StartsWith("*"))
				{
					text = "*" + text;
				}
				if (!text.EndsWith("*"))
				{
					text += "*";
				}
			}
			if (!string.IsNullOrEmpty(text2))
			{
				if (!text2.StartsWith("*"))
				{
					text2 = "*" + text2;
				}
				if (!text2.EndsWith("*"))
				{
					text2 += "*";
				}
			}
			this.class374_0.method_5(new Action<object>(this.method_18), new KeyValuePair<string, string>(text, text2));
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x0008ECC4 File Offset: 0x0008CEC4
		private void method_18(object state)
		{
			KeyValuePair<string, string> keyValuePair = (KeyValuePair<string, string>)state;
			List<ListViewItemState<string>> list = null;
			ListViewItemState<string>[] array = null;
			List<ListViewItemState<string>> list2 = new List<ListViewItemState<string>>();
			ListViewItemState<string>[] array2;
			if (string.IsNullOrEmpty(keyValuePair.Value))
			{
				if (this.class506_1.Count > 0)
				{
					list = new List<ListViewItemState<string>>();
				}
				foreach (KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>> keyValuePair2 in this.class506_0)
				{
					if (keyValuePair2.Key.State.smethod_20(keyValuePair.Key))
					{
						list2.Add(keyValuePair2.Key);
						if (list != null)
						{
							foreach (ListViewItemState<string> item in keyValuePair2.Value)
							{
								if (!list.Contains(item))
								{
									list.Add(item);
								}
							}
						}
					}
				}
				array2 = list2.ToArray();
				if (list != null)
				{
					array = list.ToArray();
					Array.Sort<ListViewItemState<string>>(array, Class236.Default);
				}
			}
			else if (string.IsNullOrEmpty(keyValuePair.Key))
			{
				list = new List<ListViewItemState<string>>();
				foreach (KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>> keyValuePair3 in this.class506_1)
				{
					if (keyValuePair3.Key.State.smethod_20(keyValuePair.Value))
					{
						list.Add(keyValuePair3.Key);
						foreach (ListViewItemState<string> item2 in keyValuePair3.Value)
						{
							if (!list2.Contains(item2))
							{
								list2.Add(item2);
							}
						}
					}
				}
				array2 = list2.ToArray();
				array = list.ToArray();
				Array.Sort<ListViewItemState<string>>(array2, Class236.Default);
			}
			else
			{
				list = new List<ListViewItemState<string>>();
				foreach (KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>> keyValuePair4 in this.class506_1)
				{
					if (keyValuePair4.Key.State.smethod_20(keyValuePair.Value))
					{
						list.Add(keyValuePair4.Key);
						foreach (ListViewItemState<string> listViewItemState in keyValuePair4.Value)
						{
							if (listViewItemState.State.smethod_20(keyValuePair.Key) && !list2.Contains(listViewItemState))
							{
								list2.Add(listViewItemState);
							}
						}
					}
				}
				array2 = list2.ToArray();
				array = list.ToArray();
				Array.Sort<ListViewItemState<string>>(array2, Class236.Default);
			}
			if (array == null)
			{
				this.class374_0.method_5(new Action<object>(this.method_21), this.class506_1.Keys.ToArray<ListViewItemState<string>>());
			}
			else
			{
				this.class374_0.method_5(new Action<object>(this.method_21), array);
			}
			this.class374_0.method_5(new Action<object>(this.method_20), array2);
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00011909 File Offset: 0x0000FB09
		private void MakePackage_Load(object sender, EventArgs e)
		{
			this.class374_0.method_2(new Action<object>(this.method_19));
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x0008F028 File Offset: 0x0008D228
		private void method_19(object state)
		{
			string[] array = Class234.smethod_1(Class291.ToonTownOpenDataDirectory, "phase*_*.mf", ".mf");
			Class99 connectSettings = Class110.Instance.ConnectSettings;
			foreach (string text in array)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				if (Class136.smethod_7(fileNameWithoutExtension))
				{
					Stream stream = null;
					Class136 @class = null;
					string text2 = text;
					if (connectSettings.SpoofedToonTownEnabled)
					{
						string text3 = text + ".orig";
						if (File.Exists(text3))
						{
							text2 = text3;
						}
					}
					try
					{
						stream = File.Open(text2, FileMode.Open, FileAccess.Read, FileShare.None);
						@class = new Class136(stream);
						@class.method_10();
						this.dictionary_0.Add(fileNameWithoutExtension, @class);
					}
					catch (Exception ex)
					{
						ex.smethod_1(new object[]
						{
							"error loading ToonTown MultiFile: " + text2
						});
						if (stream != null)
						{
							stream.Dispose();
						}
						if (@class != null)
						{
							@class.Dispose();
						}
					}
				}
			}
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			foreach (Class136 class2 in this.dictionary_0.Values)
			{
				foreach (string text4 in class2.MultiFileData.Keys)
				{
					if (!hashSet.Contains(text4) && Class136.smethod_8(text4))
					{
						hashSet.Add(text4);
					}
				}
			}
			string[] array3 = hashSet.ToArray<string>();
			Array.Sort<string>(array3, Class408.Default);
			foreach (string text5 in array3)
			{
				ListViewItemState<string> listViewItemState = new ListViewItemState<string>(text5);
				this.dictionary_2.Add(text5, listViewItemState);
				this.class506_0.Add(listViewItemState, new HashSet<ListViewItemState<string>>());
			}
			foreach (ListViewItemState<string> listViewItemState2 in this.class506_0.Keys)
			{
				listViewItemState2.ForeColor = Color.Gray;
			}
			this.class374_0.method_5(new Action<object>(this.method_20), this.class506_0.Keys.ToArray<ListViewItemState<string>>());
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x0008F2A8 File Offset: 0x0008D4A8
		private void method_20(object state)
		{
			MakePackage.Class415 @class = new MakePackage.Class415();
			@class.makePackage_0 = this;
			@class.listViewItemState_0 = (state as ListViewItemState<string>[]);
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x0008F2E0 File Offset: 0x0008D4E0
		private void method_21(object state)
		{
			MakePackage.Class416 @class = new MakePackage.Class416();
			@class.makePackage_0 = this;
			@class.listViewItemState_0 = (state as ListViewItemState<string>[]);
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00011922 File Offset: 0x0000FB22
		private void mniBuildModelIndex_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.mniBuildModelIndex.Enabled = false;
			this.class374_0.method_2(new Action<object>(this.method_22));
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x0008F318 File Offset: 0x0008D518
		private void method_22(object state)
		{
			Dictionary<string, KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>> dictionary = new Dictionary<string, KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>>(StringComparer.OrdinalIgnoreCase);
			foreach (Class136 @class in this.dictionary_0.Values)
			{
				foreach (KeyValuePair<string, Class338> keyValuePair in ((IEnumerable<KeyValuePair<string, Class338>>)@class.MultiFileData))
				{
					if (Path.GetExtension(keyValuePair.Key).ToLower() == ".bam")
					{
						@class.method_15(keyValuePair.Value);
						HashSet<string> hashSet = Class187.smethod_0(keyValuePair.Value.Data);
						keyValuePair.Value.Data = null;
						if (hashSet != null)
						{
							ListViewItemState<string> listViewItemState = new ListViewItemState<string>(keyValuePair.Key);
							HashSet<ListViewItemState<string>> hashSet2 = new HashSet<ListViewItemState<string>>();
							foreach (string key in hashSet)
							{
								if (this.dictionary_2.ContainsKey(key))
								{
									ListViewItemState<string> listViewItemState2 = this.dictionary_2[key];
									this.class506_0[listViewItemState2].Add(listViewItemState);
									hashSet2.Add(listViewItemState2);
								}
							}
							dictionary.Add(keyValuePair.Key, new KeyValuePair<ListViewItemState<string>, HashSet<ListViewItemState<string>>>(listViewItemState, hashSet2));
						}
					}
				}
			}
			string[] array = dictionary.Keys.ToArray<string>();
			Array.Sort<string>(array, Class408.Default);
			foreach (string key2 in array)
			{
				this.class506_1.Add(dictionary[key2]);
			}
			this.smethod_6(new MethodInvoker(this.method_59));
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00011952 File Offset: 0x0000FB52
		private void mniClose_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			base.Close();
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0008F530 File Offset: 0x0008D730
		private void MakePackage_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!e.Cancel)
			{
				base.PromptToSaveOnClose = false;
				if (this.bool_5)
				{
					e.Cancel = !this.bool_4;
					return;
				}
				this.bool_5 = true;
				e.Cancel = true;
				this.class374_0.method_2(new Action<object>(this.method_23));
			}
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x00011965 File Offset: 0x0000FB65
		private void method_23(object state)
		{
			this.smethod_6(new MethodInvoker(this.method_60));
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x00011979 File Offset: 0x0000FB79
		private void lbFiles_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.method_25(false);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x0001198D File Offset: 0x0000FB8D
		private void lbModels_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.method_24();
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x0008F590 File Offset: 0x0008D790
		private void method_24()
		{
			if (this.lbModels.SelectedItems.Count == 0)
			{
				this.lblSelectedModel.Text = string.Empty;
				this.mniWithToonTownContent.Enabled = false;
				this.mniWithUserContent.Enabled = false;
				return;
			}
			this.lblSelectedModel.Text = "(" + (this.lbModels.SelectedItems[0] as ListViewItemState<string>).State + ")";
			this.mniWithToonTownContent.Enabled = true;
			this.mniWithUserContent.Enabled = true;
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x0008F628 File Offset: 0x0008D828
		private void method_25(bool insert)
		{
			if (insert)
			{
				if (this.lbFiles.SelectedItems.Count == 0)
				{
					this.class374_0.method_4(new Action<object>(this.method_27));
					return;
				}
				this.class374_0.method_5(new Action<object>(this.method_27), (this.lbFiles.SelectedItems[0] as ListViewItemState<string>).State);
				return;
			}
			else
			{
				if (this.lbFiles.SelectedItems.Count == 0)
				{
					this.class374_0.method_2(new Action<object>(this.method_27));
					return;
				}
				this.class374_0.method_3(new Action<object>(this.method_27), (this.lbFiles.SelectedItems[0] as ListViewItemState<string>).State);
				return;
			}
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x0008F6F4 File Offset: 0x0008D8F4
		private void method_26(object state)
		{
			MakePackage.Class417 @class = new MakePackage.Class417();
			@class.makePackage_0 = this;
			@class.string_0 = (state as string);
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x0008F72C File Offset: 0x0008D92C
		private void method_27(object state)
		{
			string text = state as string;
			this.class374_0.method_5(new Action<object>(this.method_26), state);
			if (string.IsNullOrEmpty(text))
			{
				this.class374_0.method_4(new Action<object>(this.method_30));
				this.class374_0.method_4(new Action<object>(this.method_28));
				return;
			}
			byte[] array = this.method_33(text);
			if (array == null)
			{
				return;
			}
			byte[] array2 = null;
			if (this.class132_0.Data.MultiFileData.ContainsKey(text))
			{
				Class338 @class = this.class132_0.Data.MultiFileData[text];
				array2 = @class.Data;
			}
			switch (Class136.smethod_4(text))
			{
			case Enum68.const_0:
				break;
			case Enum68.const_1:
				if (array2 == null)
				{
					this.class374_0.method_5(new Action<object>(this.method_28), Class429.smethod_0(null, array));
				}
				else
				{
					this.class374_0.method_5(new Action<object>(this.method_28), Class429.smethod_0(array2, array));
				}
				this.class374_0.method_4(new Action<object>(this.method_30));
				return;
			case Enum68.const_2:
				using (MemoryStream memoryStream = new MemoryStream(array))
				{
					if (array2 == null)
					{
						this.class374_0.method_5(new Action<object>(this.method_28), new Class429(null, Class486.smethod_2(memoryStream)));
					}
					else
					{
						using (MemoryStream memoryStream2 = new MemoryStream(array2))
						{
							this.class374_0.method_5(new Action<object>(this.method_28), new Class429(Class486.smethod_2(memoryStream2), Class486.smethod_2(memoryStream)));
						}
					}
				}
				this.class374_0.method_4(new Action<object>(this.method_30));
				return;
			case Enum68.const_3:
			case Enum68.const_4:
			case Enum68.const_5:
				this.class374_0.method_5(new Action<object>(this.method_30), new Class355(text, array2, array));
				this.class374_0.method_4(new Action<object>(this.method_28));
				break;
			default:
				return;
			}
		}

		// Token: 0x06002739 RID: 10041 RVA: 0x0008F940 File Offset: 0x0008DB40
		private void method_28(object state)
		{
			MakePackage.Class418 @class = new MakePackage.Class418();
			@class.makePackage_0 = this;
			@class.class429_0 = (state as Class429);
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600273A RID: 10042 RVA: 0x0008F978 File Offset: 0x0008DB78
		private void method_29(Class429 gr)
		{
			if (gr != null && gr.UserGraphicData != null)
			{
				this.picUserContent.Image = gr.UserGraphicData;
				this.picUserContent.Size = this.picUserContent.Image.Size.smethod_2(224, 244);
			}
			else
			{
				this.picUserContent.Image = null;
			}
			if (gr != null && gr.ToonTownGraphicData != null)
			{
				this.picToonTownContent.Image = gr.ToonTownGraphicData;
				this.picToonTownContent.Size = this.picToonTownContent.Image.Size.smethod_2(224, 244);
			}
			else
			{
				this.picToonTownContent.Image = null;
			}
			if (this.class429_0 != null)
			{
				this.class429_0.Dispose();
			}
			this.class429_0 = gr;
		}

		// Token: 0x0600273B RID: 10043 RVA: 0x0008FA48 File Offset: 0x0008DC48
		private void method_30(object state)
		{
			MakePackage.Class419 @class = new MakePackage.Class419();
			@class.makePackage_0 = this;
			@class.class355_0 = (state as Class355);
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x0600273C RID: 10044 RVA: 0x0008FA80 File Offset: 0x0008DC80
		private void method_31(Class355 audioData)
		{
			if (audioData == null)
			{
				this.wmpUserPlayer.method_2();
				this.wmpToonTown.method_2();
				this.picUserContentAudioFile.Visible = false;
				this.picToonTownContentAudioFile.Visible = false;
				return;
			}
			if (audioData.UserAudioData == null)
			{
				this.wmpUserPlayer.method_2();
			}
			else
			{
				this.wmpUserPlayer.method_0(audioData.AudioFile, audioData.UserAudioData);
			}
			if (audioData.ToonTownAudioData == null)
			{
				this.wmpToonTown.method_2();
			}
			else
			{
				this.wmpToonTown.method_0(audioData.AudioFile, audioData.ToonTownAudioData);
			}
			this.picUserContentAudioFile.Visible = true;
			this.picToonTownContentAudioFile.Visible = true;
		}

		// Token: 0x0600273D RID: 10045 RVA: 0x0008FB30 File Offset: 0x0008DD30
		private Class338 method_32(string file)
		{
			string key;
			if (!Class136.smethod_5(file, out key))
			{
				return null;
			}
			if (!this.dictionary_0.ContainsKey(key))
			{
				return null;
			}
			Class136 @class = this.dictionary_0[key];
			if (!@class.MultiFileData.ContainsKey(file))
			{
				return null;
			}
			Class338 class2 = @class.MultiFileData[file];
			@class.method_15(class2);
			return class2;
		}

		// Token: 0x0600273E RID: 10046 RVA: 0x0008FB8C File Offset: 0x0008DD8C
		private byte[] method_33(string file)
		{
			Class338 @class = this.method_32(file);
			if (@class == null)
			{
				return null;
			}
			byte[] data = @class.Data;
			@class.Data = null;
			return data;
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x0008FBB8 File Offset: 0x0008DDB8
		private void lbFiles_DoubleClick(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			if (this.lbFiles.SelectedItems.Count > 0)
			{
				this.txtFileSearch.Text = (this.lbFiles.SelectedItems[0] as ListViewItemState<string>).State;
			}
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x0008FC0C File Offset: 0x0008DE0C
		private void lbModels_DoubleClick(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			if (this.lbModels.SelectedItems.Count > 0)
			{
				this.txtModelSearch.Text = (this.lbModels.SelectedItems[0] as ListViewItemState<string>).State;
			}
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000119A0 File Offset: 0x0000FBA0
		private void btnPNG2JPGRGB_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_34));
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000119C4 File Offset: 0x0000FBC4
		private void method_34(object state)
		{
			this.smethod_6(new MethodInvoker(this.method_61));
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000119D8 File Offset: 0x0000FBD8
		private void btnJPGRGB_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_35));
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000119FC File Offset: 0x0000FBFC
		private void method_35(object state)
		{
			this.smethod_6(new MethodInvoker(this.method_62));
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0008FC60 File Offset: 0x0008DE60
		private void btnAddFile_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			if (this.lbFiles.SelectedItems.Count == 1)
			{
				this.class374_0.method_3(new Action<object>(this.method_36), this.lbFiles.SelectedItems[0]);
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0008FCB4 File Offset: 0x0008DEB4
		private void method_36(object state)
		{
			MakePackage.Class420 @class = new MakePackage.Class420();
			@class.makePackage_0 = this;
			@class.listViewItemState_0 = (state as ListViewItemState<string>);
			this.smethod_6(new MethodInvoker(@class.method_0));
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00011A10 File Offset: 0x0000FC10
		private void btnAddFolder_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_37));
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x0008FCEC File Offset: 0x0008DEEC
		private void method_37(object state)
		{
			MakePackage.Class421 @class = new MakePackage.Class421();
			@class.makePackage_0 = this;
			@class.string_0 = null;
			if (this.smethod_5(new Func<bool>(@class.method_0)))
			{
				MakePackage.Class422 class2 = new MakePackage.Class422();
				class2.class421_0 = @class;
				DirectoryInfo directoryInfo = new DirectoryInfo(@class.string_0);
				class2.hashSet_0 = new HashSet<ListViewItemState<string>>();
				if (Class136.smethod_7(directoryInfo.Name))
				{
					this.method_38(@class.string_0, directoryInfo.Name, class2.hashSet_0);
				}
				else
				{
					string[] directories = Directory.GetDirectories(@class.string_0);
					foreach (string text in directories)
					{
						directoryInfo = new DirectoryInfo(text);
						if (Class136.smethod_7(directoryInfo.Name))
						{
							this.method_38(text, directoryInfo.Name, class2.hashSet_0);
						}
					}
				}
				this.smethod_6(new MethodInvoker(class2.method_0));
			}
		}

		// Token: 0x06002749 RID: 10057 RVA: 0x0008FDD8 File Offset: 0x0008DFD8
		private void method_38(string parentFolder, string multiFileName, HashSet<ListViewItemState<string>> changedFiles)
		{
			string path = Path.Combine(parentFolder, "audio");
			string text = Path.Combine(path, "bgm");
			string text2 = Path.Combine(path, "dial");
			string text3 = Path.Combine(path, "sfx");
			string text4 = Path.Combine(parentFolder, "maps");
			if (Directory.Exists(text))
			{
				this.method_39(text, Path.Combine(Path.Combine(multiFileName, "audio"), "bgm"), changedFiles);
			}
			if (Directory.Exists(text2))
			{
				this.method_39(text2, Path.Combine(Path.Combine(multiFileName, "audio"), "dial"), changedFiles);
			}
			if (Directory.Exists(text3))
			{
				this.method_39(text3, Path.Combine(Path.Combine(multiFileName, "audio"), "sfx"), changedFiles);
			}
			if (Directory.Exists(text4))
			{
				this.method_39(text4, Path.Combine(multiFileName, "maps"), changedFiles);
			}
		}

		// Token: 0x0600274A RID: 10058 RVA: 0x0008FEB0 File Offset: 0x0008E0B0
		private void method_39(string folder, string relativeFolder, HashSet<ListViewItemState<string>> changedFiles)
		{
			string[] files = Directory.GetFiles(folder);
			foreach (string text in files)
			{
				string text2 = Path.Combine(relativeFolder, Path.GetFileName(text)).Replace("\\", "/");
				if (this.dictionary_2.ContainsKey(text2))
				{
					try
					{
						byte[] data = Class234.smethod_7(text);
						Class338 @class;
						if (this.class132_0.Data.method_6(text2))
						{
							@class = this.class132_0.Data[text2];
						}
						else
						{
							@class = this.class132_0.Data.method_4(text2);
						}
						@class.Data = data;
						this.class504_0.Modified = true;
						changedFiles.Add(this.dictionary_2[text2]);
					}
					catch (Exception ex)
					{
						ex.smethod_1(new object[]
						{
							string.Format("Error loading file: '{0}'.", text)
						});
					}
				}
			}
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x00011A34 File Offset: 0x0000FC34
		private void ddbExtract_DropDownOpening(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.mniExtractToonTownContent.Enabled = false;
			this.mniExtractUserContent.Enabled = false;
			this.class374_0.method_2(new Action<object>(this.method_40));
		}

		// Token: 0x0600274C RID: 10060 RVA: 0x00011A70 File Offset: 0x0000FC70
		private void method_40(object state)
		{
			this.smethod_6(new MethodInvoker(this.method_63));
		}

		// Token: 0x0600274D RID: 10061 RVA: 0x0008FFB4 File Offset: 0x0008E1B4
		private void mniExtractUserContent_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			if (this.lbFiles.SelectedItems.Count > 0)
			{
				this.class374_0.method_3(new Action<object>(this.method_41), this.lbFiles.SelectedItems[0]);
			}
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00090008 File Offset: 0x0008E208
		private void method_41(object state)
		{
			ListViewItemState<string> listViewItemState = state as ListViewItemState<string>;
			if (this.class132_0.Data.method_6(listViewItemState.State))
			{
				Class338 @class = this.class132_0.Data[listViewItemState.State];
				this.method_43(listViewItemState.State, @class.Data);
			}
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00090060 File Offset: 0x0008E260
		private void mniExtractToonTownContent_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			if (this.lbFiles.SelectedItems.Count > 0)
			{
				this.class374_0.method_3(new Action<object>(this.method_42), this.lbFiles.SelectedItems[0]);
			}
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x000900B4 File Offset: 0x0008E2B4
		private void method_42(object state)
		{
			ListViewItemState<string> listViewItemState = state as ListViewItemState<string>;
			byte[] array = this.method_33(listViewItemState.State);
			if (array == null)
			{
				return;
			}
			this.method_43(listViewItemState.State, array);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x000900E8 File Offset: 0x0008E2E8
		private void method_43(string file, byte[] data)
		{
			MakePackage.Class423 @class = new MakePackage.Class423();
			@class.string_1 = file;
			@class.makePackage_0 = this;
			if (data == null)
			{
				return;
			}
			@class.enum68_0 = Class136.smethod_4(@class.string_1);
			if (@class.enum68_0 == Enum68.const_0)
			{
				return;
			}
			@class.string_0 = null;
			if (this.smethod_5(new Func<bool>(@class.method_0)))
			{
				switch (@class.enum68_0)
				{
				case Enum68.const_1:
				case Enum68.const_3:
				case Enum68.const_4:
				case Enum68.const_5:
					Class234.smethod_6(@class.string_0, data);
					break;
				case Enum68.const_2:
				{
					string a;
					if ((a = Path.GetExtension(@class.string_0).ToLower()) != null)
					{
						if (!(a == ".jpg"))
						{
							if (!(a == ".png"))
							{
								goto IL_150;
							}
							using (MemoryStream memoryStream = new MemoryStream(data))
							{
								using (Bitmap bitmap = Class486.smethod_2(memoryStream))
								{
									using (Stream stream = File.Open(@class.string_0, FileMode.Create, FileAccess.Write, FileShare.None))
									{
										Class157.smethod_5(bitmap, stream, 100);
									}
								}
								break;
							}
						}
						using (MemoryStream memoryStream2 = new MemoryStream(data))
						{
							using (Bitmap bitmap2 = Class486.smethod_2(memoryStream2))
							{
								using (Stream stream2 = File.Open(@class.string_0, FileMode.Create, FileAccess.Write, FileShare.None))
								{
									Class157.smethod_6(bitmap2, stream2, 100);
								}
							}
							break;
						}
					}
					IL_150:
					Class234.smethod_6(@class.string_0, data);
					return;
				}
				default:
					return;
				}
			}
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00011A84 File Offset: 0x0000FC84
		private void mniRemoveAllFiles_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_44));
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x000902AC File Offset: 0x0008E4AC
		private void method_44(object state)
		{
			MethodInvoker methodInvoker = null;
			if (MakePackage.func_0 == null)
			{
				MakePackage.func_0 = new Func<bool>(MakePackage.smethod_0);
			}
			if (this.smethod_5(MakePackage.func_0))
			{
				MethodInvoker methodInvoker2 = null;
				MakePackage.Class424 @class = new MakePackage.Class424();
				@class.makePackage_0 = this;
				string[] array = this.class132_0.Data.MultiFileData.Keys.ToArray<string>();
				@class.hashSet_0 = new HashSet<ListViewItemState<string>>();
				foreach (string text in array)
				{
					Class338 class2 = this.class132_0.Data[text];
					this.class132_0.Data.method_5(text);
					class2.Data = null;
					@class.hashSet_0.Add(this.dictionary_2[text]);
				}
				if (@class.hashSet_0.Count > 0)
				{
					this.class504_0.Modified = true;
					if (methodInvoker2 == null)
					{
						methodInvoker2 = new MethodInvoker(@class.method_0);
					}
					this.smethod_6(methodInvoker2);
				}
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(this.method_64);
				}
				this.smethod_6(methodInvoker);
			}
			this.method_16(true);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000903D0 File Offset: 0x0008E5D0
		private void mniRemoveFile_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			if (this.lbFiles.SelectedItems.Count == 1)
			{
				this.class374_0.method_3(new Action<object>(this.method_45), this.lbFiles.SelectedItems[0]);
			}
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x00090424 File Offset: 0x0008E624
		private void method_45(object state)
		{
			MakePackage.Class425 @class = new MakePackage.Class425();
			@class.object_0 = state;
			@class.makePackage_0 = this;
			this.smethod_6(new MethodInvoker(@class.method_0));
			this.method_16(true);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00011AA8 File Offset: 0x0000FCA8
		private void ddbRemoveFile_DropDownOpening(object sender, EventArgs e)
		{
			ToolStripItem toolStripItem = this.mniRemoveAllFiles;
			this.mniRemoveFile.Enabled = false;
			toolStripItem.Enabled = false;
			this.class374_0.method_2(new Action<object>(this.method_46));
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00011AD9 File Offset: 0x0000FCD9
		private void method_46(object state)
		{
			this.smethod_6(new MethodInvoker(this.method_65));
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00090460 File Offset: 0x0008E660
		private void mniWithUserContent_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			if (this.lbModels.SelectedItems.Count > 0)
			{
				this.class374_0.method_3(new Action<object>(this.method_47), this.lbModels.SelectedItems[0]);
			}
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x000904B4 File Offset: 0x0008E6B4
		private void method_47(object state)
		{
			ListViewItemState<string> listViewItemState = state as ListViewItemState<string>;
			if (this.smethod_5(new Func<bool>(this.method_66)))
			{
				Class338 @class = this.method_32(listViewItemState.State);
				if (@class != null)
				{
					string text = Path.Combine(Class291.ToonTownContent_TempFolder, Path.GetFileName(listViewItemState.State));
					HashSet<string> hashSet = new HashSet<string>();
					HashSet<string> hashSet2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
					hashSet.Add(text);
					@class.smethod_0(text);
					foreach (ListViewItemState<string> listViewItemState2 in this.class506_1[listViewItemState])
					{
						string text2 = Path.Combine(Class291.ToonTownContent_TempFolder, listViewItemState2.State);
						string directoryName = Path.GetDirectoryName(text2);
						if (!hashSet2.Contains(directoryName))
						{
							hashSet2.Add(directoryName);
						}
						hashSet.Add(text2);
						if (this.class132_0.Data.method_6(listViewItemState2.State))
						{
							@class = this.class132_0.Data[listViewItemState2.State];
						}
						else
						{
							@class = this.method_32(listViewItemState2.State);
						}
						@class.smethod_0(text2);
					}
					Class516.smethod_0(new Class515(text, hashSet, hashSet2));
				}
			}
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x00090608 File Offset: 0x0008E808
		private void mniWithToonTownContent_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			if (this.lbModels.SelectedItems.Count > 0)
			{
				this.class374_0.method_3(new Action<object>(this.method_48), this.lbModels.SelectedItems[0]);
			}
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x0009065C File Offset: 0x0008E85C
		private void method_48(object state)
		{
			ListViewItemState<string> listViewItemState = state as ListViewItemState<string>;
			if (this.smethod_5(new Func<bool>(this.method_67)))
			{
				Class338 @class = this.method_32(listViewItemState.State);
				if (@class != null)
				{
					string text = Path.Combine(Class291.ToonTownContent_TempFolder, Path.GetFileName(listViewItemState.State));
					HashSet<string> hashSet = new HashSet<string>();
					HashSet<string> hashSet2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
					hashSet.Add(text);
					@class.smethod_0(text);
					foreach (ListViewItemState<string> listViewItemState2 in this.class506_1[listViewItemState])
					{
						string text2 = Path.Combine(Class291.ToonTownContent_TempFolder, listViewItemState2.State);
						string directoryName = Path.GetDirectoryName(text2);
						if (!hashSet2.Contains(directoryName))
						{
							hashSet2.Add(directoryName);
						}
						hashSet.Add(text2);
						@class = this.method_32(listViewItemState2.State);
						@class.smethod_0(text2);
					}
					Class516.smethod_0(new Class515(text, hashSet, hashSet2));
				}
			}
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00011AED File Offset: 0x0000FCED
		private void mniSelectPanda3dpViewPath_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.method_50();
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00011B01 File Offset: 0x0000FD01
		private bool method_49()
		{
			return (!string.IsNullOrEmpty(Class110.Instance.MakePackageSettings.Panda3dPath) && File.Exists(Class110.Instance.MakePackageSettings.Panda3dPath)) || this.method_50();
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00090778 File Offset: 0x0008E978
		private bool method_50()
		{
			this.openFileDialog_1.Title = "Select the Panda pView application to open models.";
			this.openFileDialog_1.Filter = "pView|pview.exe";
			this.openFileDialog_1.FilterIndex = 1;
			if (string.IsNullOrEmpty(Class110.Instance.MakePackageSettings.Panda3dPath))
			{
				this.openFileDialog_1.FileName = "pview.exe";
			}
			else
			{
				this.openFileDialog_1.InitialDirectory = Path.GetDirectoryName(Class110.Instance.MakePackageSettings.Panda3dPath);
				this.openFileDialog_1.FileName = Path.GetFileName(Class110.Instance.MakePackageSettings.Panda3dPath);
			}
			if (this.openFileDialog_1.ShowDialog() == DialogResult.OK)
			{
				Class110.Instance.MakePackageSettings.Panda3dPath = this.openFileDialog_1.FileName;
				Class110.smethod_1();
				return true;
			}
			return false;
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00011B37 File Offset: 0x0000FD37
		private void mniNew_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_68));
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00011B5B File Offset: 0x0000FD5B
		protected override void vmethod_0()
		{
			this.method_10(new Class132());
			if (base.IsHandleCreated)
			{
				this.method_16(false);
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00011B77 File Offset: 0x0000FD77
		private void mniOpen_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_70));
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00090848 File Offset: 0x0008EA48
		protected override bool vmethod_5(Class524 fileName)
		{
			EventHandler<EventArgs43<string>> eventHandler = null;
			MakePackage.Class426 @class = new MakePackage.Class426();
			@class.class132_0 = null;
			try
			{
				@class.class132_0 = new Class132(fileName.string_1, true, true);
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, fileName.string_1);
				return false;
			}
			if (Struct43.smethod_6(@class.class132_0.PasswordHash, Struct43.struct43_0))
			{
				bool result;
				using (StringInputForm stringInputForm = new StringInputForm())
				{
					stringInputForm.Text = "Enter Password";
					stringInputForm.LabelMessage = "Please enter your password:";
					stringInputForm.PasswordTextBox = true;
					StringInputFormBase stringInputFormBase = stringInputForm;
					if (eventHandler == null)
					{
						eventHandler = new EventHandler<EventArgs43<string>>(@class.method_0);
					}
					stringInputFormBase.InputValidating += eventHandler;
					if (stringInputForm.ShowDialog() == DialogResult.OK)
					{
						@class.class132_0.Password = stringInputForm.Value;
						goto IL_D9;
					}
					@class.class132_0.Dispose();
					@class.class132_0 = null;
					result = false;
				}
				return result;
			}
			IL_D9:
			Dictionary<ListViewItemState<string>, Class338> dictionary = new Dictionary<ListViewItemState<string>, Class338>(Class414.class414_0);
			foreach (string text in @class.class132_0.Data.MultiFileData.Keys)
			{
				if (!this.dictionary_2.ContainsKey(text))
				{
					dictionary.Add(new ListViewItemState<string>(text), @class.class132_0.Data[text]);
				}
			}
			if (dictionary.Count > 0)
			{
				using (frmUnusedContentPackFiles frmUnusedContentPackFiles = new frmUnusedContentPackFiles(dictionary))
				{
					frmUnusedContentPackFiles.ShowDialog();
				}
				dictionary.Clear();
			}
			this.method_10(@class.class132_0);
			this.method_16(false);
			return true;
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00011B9B File Offset: 0x0000FD9B
		private void mniSave_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_72));
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x00090A1C File Offset: 0x0008EC1C
		protected override bool vmethod_2(Class524 fileName)
		{
			bool result;
			try
			{
				this.class132_0.method_8(fileName.string_1, null);
				goto IL_2F;
			}
			catch (Exception ex)
			{
				DialogBox.smethod_7(ex, fileName.string_1);
				result = false;
			}
			return result;
			IL_2F:
			this.class504_0.Modified = false;
			this.gdContentPackProperties.Refresh();
			return true;
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x00011BBF File Offset: 0x0000FDBF
		private void mniSaveAs_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_74));
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x00011BE3 File Offset: 0x0000FDE3
		private void mniOpenIndex_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_51));
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00090A80 File Offset: 0x0008EC80
		private void method_51(object state)
		{
			MethodInvoker methodInvoker = null;
			if (this.smethod_5(new Func<bool>(this.method_76)))
			{
				this.method_53();
				foreach (KeyValuePair<string, Struct43> keyValuePair in this.class514_1.dictionary_0)
				{
					if (this.class514_0.dictionary_0.ContainsKey(keyValuePair.Key))
					{
						if (Struct43.smethod_6(this.class514_0.dictionary_0[keyValuePair.Key], keyValuePair.Value))
						{
							this.dictionary_1.Add(keyValuePair.Key, MakePackage.Enum98.const_2);
						}
					}
					else
					{
						this.dictionary_1.Add(keyValuePair.Key, MakePackage.Enum98.const_1);
					}
				}
				foreach (KeyValuePair<string, Struct43> keyValuePair2 in this.class514_0.dictionary_0)
				{
					if (!this.class514_1.dictionary_0.ContainsKey(keyValuePair2.Key))
					{
						this.dictionary_1.Add(keyValuePair2.Key, MakePackage.Enum98.const_0);
					}
				}
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(this.method_77);
				}
				this.smethod_6(methodInvoker);
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00011C07 File Offset: 0x0000FE07
		private void mniSaveIndex_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_52));
			this.class374_0.method_2(new Action<object>(this.method_54));
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x00011C42 File Offset: 0x0000FE42
		private void method_52(object state)
		{
			this.method_53();
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x00090BDC File Offset: 0x0008EDDC
		private void method_53()
		{
			if (this.class514_0 == null)
			{
				this.class514_0 = new Class514();
				foreach (Class136 @class in this.dictionary_0.Values)
				{
					foreach (KeyValuePair<string, Class338> keyValuePair in ((IEnumerable<KeyValuePair<string, Class338>>)@class.MultiFileData))
					{
						if (Path.GetExtension(keyValuePair.Key).ToLower() == ".bam" || Class136.smethod_8(keyValuePair.Key))
						{
							@class.method_15(keyValuePair.Value);
							Struct43 value = keyValuePair.Value.Data.smethod_0();
							if (!this.class514_0.dictionary_0.ContainsKey(keyValuePair.Key))
							{
								this.class514_0.dictionary_0.Add(keyValuePair.Key, value);
							}
							keyValuePair.Value.Data = null;
						}
					}
				}
				return;
			}
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00011C4A File Offset: 0x0000FE4A
		private void method_54(object state)
		{
			this.smethod_6(new MethodInvoker(this.method_78));
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00011C5E File Offset: 0x0000FE5E
		private void mniPatch_Click(object sender, EventArgs e)
		{
			if (this.bool_5)
			{
				return;
			}
			this.class374_0.method_2(new Action<object>(this.method_55));
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00090D14 File Offset: 0x0008EF14
		private void method_55(object state)
		{
			MakePackage.Class427 @class = new MakePackage.Class427();
			@class.makePackage_0 = this;
			@class.string_0 = null;
			@class.string_1 = null;
			@class.string_2 = null;
			if (this.smethod_5(new Func<bool>(@class.method_0)))
			{
				try
				{
					Class292.smethod_13(@class.string_0, @class.string_1, @class.string_2);
					if (MakePackage.methodInvoker_0 == null)
					{
						MakePackage.methodInvoker_0 = new MethodInvoker(MakePackage.smethod_1);
					}
					this.smethod_6(MakePackage.methodInvoker_0);
				}
				catch (LoaderPackNotSupported)
				{
					if (MakePackage.methodInvoker_1 == null)
					{
						MakePackage.methodInvoker_1 = new MethodInvoker(MakePackage.smethod_2);
					}
					this.smethod_6(MakePackage.methodInvoker_1);
				}
				catch (Exception exception_)
				{
					MakePackage.Class428 class2 = new MakePackage.Class428();
					class2.class427_0 = @class;
					class2.exception_0 = exception_;
					class2.exception_0.smethod_1(new object[]
					{
						string.Format("Patch creation failed: original file: '{0}' new file: '{1}' patch file: '{2}'.", @class.string_0, @class.string_1, @class.string_2)
					});
					this.smethod_6(new MethodInvoker(class2.method_0));
				}
			}
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00011C82 File Offset: 0x0000FE82
		private void GuideMenuItem_Click(object sender, EventArgs e)
		{
			Class462.smethod_0(Enum51.const_13);
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00011C8B File Offset: 0x0000FE8B
		private void MakePackage_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_13);
			e.Handled = true;
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00011C9B File Offset: 0x0000FE9B
		[CompilerGenerated]
		private void method_56(object sender, EventArgs32 e)
		{
			base.FileModified = e.Modified;
		}

		// Token: 0x06002771 RID: 10097 RVA: 0x00011CA9 File Offset: 0x0000FEA9
		[CompilerGenerated]
		private void method_57()
		{
			this.barLoading.Visible = true;
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00011CB7 File Offset: 0x0000FEB7
		[CompilerGenerated]
		private void method_58()
		{
			this.barLoading.Visible = false;
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x00011CC5 File Offset: 0x0000FEC5
		[CompilerGenerated]
		private void method_59()
		{
			this.class374_0.method_5(new Action<object>(this.method_17), new KeyValuePair<string, string>(this.txtFileSearch.Text, this.txtModelSearch.Text));
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x00090E38 File Offset: 0x0008F038
		[CompilerGenerated]
		private void method_60()
		{
			foreach (KeyValuePair<string, Class136> keyValuePair in this.dictionary_0)
			{
				keyValuePair.Value.Dispose();
			}
			this.class374_0.Started -= this.method_14;
			this.class374_0.Stopped -= this.method_15;
			this.bool_4 = true;
			base.Close();
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00090ED0 File Offset: 0x0008F0D0
		[CompilerGenerated]
		private void method_61()
		{
			this.openFileDialog_1.FileName = string.Empty;
			this.openFileDialog_1.Filter = "PNG Image|*.png";
			this.openFileDialog_1.Title = "Select a PNG image to split into a JPG + RGB.";
			this.openFileDialog_1.FilterIndex = 1;
			if (this.openFileDialog_1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (Stream stream = File.Open(this.openFileDialog_1.FileName, FileMode.Open, FileAccess.Read, FileShare.None))
					{
						using (PNGSplit pngsplit = new PNGSplit(stream))
						{
							if (pngsplit.ShowDialog() == DialogResult.OK)
							{
								string text = Path.Combine(Path.GetDirectoryName(this.openFileDialog_1.FileName), Path.GetFileNameWithoutExtension(this.openFileDialog_1.FileName) + ".jpg");
								string text2 = Path.Combine(Path.GetDirectoryName(this.openFileDialog_1.FileName), Path.GetFileNameWithoutExtension(this.openFileDialog_1.FileName) + "_a.rgb");
								try
								{
									using (Stream stream2 = File.Open(text, FileMode.Create, FileAccess.Write, FileShare.None))
									{
										try
										{
											using (Stream stream3 = File.Open(text2, FileMode.Create, FileAccess.Write, FileShare.None))
											{
												pngsplit.JPGStream.CopyTo(stream2);
												pngsplit.RGBStream.CopyTo(stream3);
											}
										}
										catch (Exception ex)
										{
											ex.smethod_1(new object[]
											{
												text2
											});
											DialogBox.smethod_7(ex, text2);
										}
									}
								}
								catch (Exception ex2)
								{
									ex2.smethod_1(new object[]
									{
										text
									});
									DialogBox.smethod_7(ex2, text);
								}
							}
						}
					}
				}
				catch (Exception ex3)
				{
					ex3.smethod_1(new object[]
					{
						this.openFileDialog_1.FileName
					});
					DialogBox.smethod_7(ex3, this.openFileDialog_1.FileName);
				}
			}
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x00091144 File Offset: 0x0008F344
		[CompilerGenerated]
		private void method_62()
		{
			this.openFileDialog_1.FileName = string.Empty;
			this.openFileDialog_1.Filter = "JPG Images|*.jpg|RGB Images|*.rgb";
			this.openFileDialog_1.Title = "Select a JPG to convert to a RGB or a RGB to convert to a JPG.";
			this.openFileDialog_1.FilterIndex = 1;
			if (this.openFileDialog_1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					string a;
					if ((a = Path.GetExtension(this.openFileDialog_1.FileName).ToLower()) != null)
					{
						if (!(a == ".rgb"))
						{
							if (!(a == ".jpg"))
							{
								goto IL_151;
							}
							using (Stream stream = File.Open(this.openFileDialog_1.FileName, FileMode.Open, FileAccess.Read, FileShare.None))
							{
								using (Stream stream2 = File.Open(Path.ChangeExtension(this.openFileDialog_1.FileName, ".rgb"), FileMode.Create, FileAccess.Write, FileShare.None))
								{
									Class486.smethod_0(stream, stream2, null, null, true, Enum14.const_3);
								}
								goto IL_151;
							}
						}
						using (Stream stream3 = File.Open(this.openFileDialog_1.FileName, FileMode.Open, FileAccess.Read, FileShare.None))
						{
							using (Bitmap bitmap = Class486.smethod_2(stream3))
							{
								using (Stream stream4 = File.Open(Path.ChangeExtension(this.openFileDialog_1.FileName, ".jpg"), FileMode.Create, FileAccess.Write, FileShare.None))
								{
									Class157.smethod_6(bitmap, stream4, 100);
								}
							}
						}
					}
					IL_151:;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						this.openFileDialog_1.FileName
					});
					DialogBox.smethod_7(ex, this.openFileDialog_1.FileName);
				}
			}
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x00091370 File Offset: 0x0008F570
		[CompilerGenerated]
		private void method_63()
		{
			if (this.lbFiles.SelectedItems.Count == 0)
			{
				this.mniExtractToonTownContent.Enabled = false;
				this.mniExtractUserContent.Enabled = false;
				return;
			}
			this.mniExtractToonTownContent.Enabled = true;
			this.mniExtractUserContent.Enabled = this.class132_0.Data.method_6((this.lbFiles.SelectedItems[0] as ListViewItemState<string>).State);
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x000913EC File Offset: 0x0008F5EC
		[CompilerGenerated]
		private static bool smethod_0()
		{
			return DialogBox.smethod_6("Are you sure you want to remove all the items in your Content Pack?", "Remove All Items", new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			}) == DialogResult.Yes;
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00011CFE File Offset: 0x0000FEFE
		[CompilerGenerated]
		private void method_64()
		{
			this.method_25(true);
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x0009141C File Offset: 0x0008F61C
		[CompilerGenerated]
		private void method_65()
		{
			if (this.lbFiles.SelectedItems.Count > 0)
			{
				ListViewItemState<string> listViewItemState = this.lbFiles.SelectedItems[0] as ListViewItemState<string>;
				this.mniRemoveFile.Enabled = this.class132_0.Data.method_6(listViewItemState.State);
			}
			else
			{
				this.mniRemoveFile.Enabled = false;
			}
			this.mniRemoveAllFiles.Enabled = (this.class132_0.Data.MultiFileData.Count > 0);
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x00011D07 File Offset: 0x0000FF07
		[CompilerGenerated]
		private bool method_66()
		{
			return this.method_49();
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x00011D07 File Offset: 0x0000FF07
		[CompilerGenerated]
		private bool method_67()
		{
			return this.method_49();
		}

		// Token: 0x0600277D RID: 10109 RVA: 0x00011D0F File Offset: 0x0000FF0F
		[CompilerGenerated]
		private void method_68(object _)
		{
			this.smethod_6(new MethodInvoker(this.method_69));
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x000050AC File Offset: 0x000032AC
		[CompilerGenerated]
		private void method_69()
		{
			base.method_5();
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x00011D23 File Offset: 0x0000FF23
		[CompilerGenerated]
		private void method_70(object _)
		{
			this.smethod_6(new MethodInvoker(this.method_71));
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x00011D37 File Offset: 0x0000FF37
		[CompilerGenerated]
		private void method_71()
		{
			this.openFileDialog_0.Title = "Select a Content Pack to open.";
			this.openFileDialog_0.Filter = "Content Packs|*.ttp";
			this.openFileDialog_0.FilterIndex = 1;
			base.method_8();
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x00011D6B File Offset: 0x0000FF6B
		[CompilerGenerated]
		private void method_72(object _)
		{
			this.smethod_6(new MethodInvoker(this.method_73));
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x00011D7F File Offset: 0x0000FF7F
		[CompilerGenerated]
		private void method_73()
		{
			this.saveFileDialog_0.Filter = "Content Packs|*.ttp";
			this.saveFileDialog_0.FilterIndex = 1;
			this.saveFileDialog_0.Title = "Enter a file name to save your Content Pack.";
			base.method_6(base.FileName);
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00011DBA File Offset: 0x0000FFBA
		[CompilerGenerated]
		private void method_74(object _)
		{
			this.smethod_6(new MethodInvoker(this.method_75));
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x00011DCE File Offset: 0x0000FFCE
		[CompilerGenerated]
		private void method_75()
		{
			this.saveFileDialog_0.Filter = "Content Packs|*.ttp";
			this.saveFileDialog_0.FilterIndex = 1;
			this.saveFileDialog_0.Title = "Enter a file name to save your Content Pack.";
			base.method_7();
		}

		// Token: 0x06002785 RID: 10117 RVA: 0x000914A8 File Offset: 0x0008F6A8
		[CompilerGenerated]
		private bool method_76()
		{
			this.openFileDialog_1.Title = "Choose a MultiFile Data Index to load.";
			this.openFileDialog_1.FileName = string.Empty;
			this.openFileDialog_1.Filter = "MultiFile Data Index|*.mfdi";
			this.openFileDialog_1.FilterIndex = 1;
			if (this.openFileDialog_1.ShowDialog() == DialogResult.OK)
			{
				bool result;
				try
				{
					using (Stream stream = File.Open(this.openFileDialog_1.FileName, FileMode.Open, FileAccess.Read, FileShare.None))
					{
						using (BinaryReader binaryReader = new BinaryReader(stream))
						{
							this.class514_1 = Class514.smethod_0(binaryReader);
						}
					}
					result = true;
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						this.openFileDialog_1.FileName
					});
					DialogBox.smethod_7(ex, this.openFileDialog_1.FileName);
					result = false;
				}
				return result;
			}
			return false;
		}

		// Token: 0x06002786 RID: 10118 RVA: 0x00011E03 File Offset: 0x00010003
		[CompilerGenerated]
		private void method_77()
		{
			this.method_11();
		}

		// Token: 0x06002787 RID: 10119 RVA: 0x000915A4 File Offset: 0x0008F7A4
		[CompilerGenerated]
		private void method_78()
		{
			this.saveFileDialog_1.Title = "Choose a file to save the current MultiFile Data Index.";
			this.saveFileDialog_1.FileName = string.Empty;
			this.saveFileDialog_1.Filter = "MultiFile Data Index|*.mfdi";
			this.saveFileDialog_1.FilterIndex = 1;
			if (this.saveFileDialog_1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (Stream stream = File.Open(this.saveFileDialog_1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
					{
						using (BinaryWriter binaryWriter = new BinaryWriter(stream))
						{
							this.class514_0.method_0(binaryWriter);
						}
					}
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						this.saveFileDialog_1.FileName
					});
					DialogBox.smethod_7(ex, this.saveFileDialog_1.FileName);
				}
			}
		}

		// Token: 0x06002788 RID: 10120 RVA: 0x00011E0B File Offset: 0x0001000B
		[CompilerGenerated]
		private static void smethod_1()
		{
			DialogBox.smethod_3("Patch created successfully.", "Complete");
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00011E1C File Offset: 0x0001001C
		[CompilerGenerated]
		private static void smethod_2()
		{
			DialogBox.smethod_4("Cannot create a patch file using a loader pack.", "Loader Pack Not Supported");
		}

		// Token: 0x04001341 RID: 4929
		private PropertyGrid gdContentPackProperties;

		// Token: 0x04001342 RID: 4930
		private MenuStrip mnuMain;

		// Token: 0x04001343 RID: 4931
		private ToolStripMenuItem mniFile;

		// Token: 0x04001344 RID: 4932
		private ToolStripMenuItem mniNew;

		// Token: 0x04001345 RID: 4933
		private ToolStripMenuItem mniOpen;

		// Token: 0x04001346 RID: 4934
		private ToolStripMenuItem mniSave;

		// Token: 0x04001347 RID: 4935
		private ToolStripMenuItem mniClose;

		// Token: 0x04001348 RID: 4936
		private ToolStrip tsMain;

		// Token: 0x04001349 RID: 4937
		private ToolStripButton btnAddFile;

		// Token: 0x0400134A RID: 4938
		private ToolStripButton btnAddFolder;

		// Token: 0x0400134B RID: 4939
		private ToolStripSeparator tsSep1;

		// Token: 0x0400134C RID: 4940
		private ToolStripLabel lblFileSearch;

		// Token: 0x0400134D RID: 4941
		private ToolStripTextBox txtFileSearch;

		// Token: 0x0400134E RID: 4942
		private ToolStripSeparator tsSep2;

		// Token: 0x0400134F RID: 4943
		private ToolStripButton btnClearFileSearch;

		// Token: 0x04001350 RID: 4944
		private PictureBox picUserContent;

		// Token: 0x04001351 RID: 4945
		private ToolStripButton btnPNG2JPGRGB;

		// Token: 0x04001352 RID: 4946
		private ToolStripButton btnJPGRGB;

		// Token: 0x04001353 RID: 4947
		private LimitedMediaPlayer wmpUserPlayer;

		// Token: 0x04001354 RID: 4948
		private PictureBox picToonTownContent;

		// Token: 0x04001355 RID: 4949
		private LimitedMediaPlayer wmpToonTown;

		// Token: 0x04001356 RID: 4950
		private Label lblUserContent;

		// Token: 0x04001357 RID: 4951
		private Label lblToonTownContent;

		// Token: 0x04001358 RID: 4952
		private Label lblFiles;

		// Token: 0x04001359 RID: 4953
		private Label lblProperties;

		// Token: 0x0400135A RID: 4954
		private Label lblModels;

		// Token: 0x0400135B RID: 4955
		private StatusStrip ssHelp;

		// Token: 0x0400135C RID: 4956
		private ToolStripStatusLabel lblMouseOverHelp;

		// Token: 0x0400135D RID: 4957
		private ToolStripProgressBar barLoading;

		// Token: 0x0400135E RID: 4958
		private ToolStripSeparator tsSep3;

		// Token: 0x0400135F RID: 4959
		private ToolStripLabel lblModelSearch;

		// Token: 0x04001360 RID: 4960
		private ToolStripTextBox txtModelSearch;

		// Token: 0x04001361 RID: 4961
		private ToolStripButton btnClearModelSearch;

		// Token: 0x04001362 RID: 4962
		private ToolStripDropDownButton ddbIndex;

		// Token: 0x04001363 RID: 4963
		private ToolStripMenuItem mniSaveIndex;

		// Token: 0x04001364 RID: 4964
		private ToolStripMenuItem mniOpenIndex;

		// Token: 0x04001365 RID: 4965
		private ToolStripStatusLabel lblSelectedFile;

		// Token: 0x04001366 RID: 4966
		private ToolStripStatusLabel lblSelectedModel;

		// Token: 0x04001367 RID: 4967
		private ListView lbModels;

		// Token: 0x04001368 RID: 4968
		private ListView lbFiles;

		// Token: 0x04001369 RID: 4969
		private ColumnHeader columnHeader_0;

		// Token: 0x0400136A RID: 4970
		private ColumnHeader columnHeader_1;

		// Token: 0x0400136B RID: 4971
		private OpenFileDialog openFileDialog_1;

		// Token: 0x0400136C RID: 4972
		private Panel panToonTownContent;

		// Token: 0x0400136D RID: 4973
		private Panel panUserContent;

		// Token: 0x0400136E RID: 4974
		private FolderBrowserDialog folderBrowserDialog_0;

		// Token: 0x0400136F RID: 4975
		private CheckBox cboFilterUserContent;

		// Token: 0x04001370 RID: 4976
		private ToolStripDropDownButton ddbExtract;

		// Token: 0x04001371 RID: 4977
		private ToolStripMenuItem mniExtractUserContent;

		// Token: 0x04001372 RID: 4978
		private ToolStripMenuItem mniExtractToonTownContent;

		// Token: 0x04001373 RID: 4979
		private PictureBox picToonTownContentAudioFile;

		// Token: 0x04001374 RID: 4980
		private PictureBox picUserContentAudioFile;

		// Token: 0x04001375 RID: 4981
		private SaveFileDialog saveFileDialog_1;

		// Token: 0x04001376 RID: 4982
		private ToolStripDropDownButton ddbRemoveFile;

		// Token: 0x04001377 RID: 4983
		private ToolStripMenuItem mniRemoveAllFiles;

		// Token: 0x04001378 RID: 4984
		private ToolStripMenuItem mniRemoveFile;

		// Token: 0x04001379 RID: 4985
		private ToolStripDropDownButton mniModels;

		// Token: 0x0400137A RID: 4986
		private ToolStripMenuItem mniWithUserContent;

		// Token: 0x0400137B RID: 4987
		private ToolStripMenuItem mniWithToonTownContent;

		// Token: 0x0400137C RID: 4988
		private ToolStripMenuItem mniEdit;

		// Token: 0x0400137D RID: 4989
		private ToolStripMenuItem mniSelectPanda3dpViewPath;

		// Token: 0x0400137E RID: 4990
		private ToolStripSeparator mniSep1;

		// Token: 0x0400137F RID: 4991
		private ToolStripMenuItem mniSaveAs;

		// Token: 0x04001380 RID: 4992
		private ToolStripSeparator mniSep2;

		// Token: 0x04001381 RID: 4993
		private ToolStripMenuItem mniBuildModelIndex;

		// Token: 0x04001382 RID: 4994
		private ToolStripMenuItem mniCreate;

		// Token: 0x04001383 RID: 4995
		private ToolStripMenuItem mniPatch;

		// Token: 0x04001384 RID: 4996
		private ToolStripMenuItem HelpMenuItem;

		// Token: 0x04001385 RID: 4997
		private ToolStripMenuItem GuideMenuItem;

		// Token: 0x04001386 RID: 4998
		private Class504 class504_0;

		// Token: 0x04001387 RID: 4999
		private Dictionary<string, Class136> dictionary_0 = new Dictionary<string, Class136>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x04001388 RID: 5000
		private Class374 class374_0;

		// Token: 0x04001389 RID: 5001
		private Class506<ListViewItemState<string>, HashSet<ListViewItemState<string>>> class506_0 = new Class506<ListViewItemState<string>, HashSet<ListViewItemState<string>>>(Class414.class414_0);

		// Token: 0x0400138A RID: 5002
		private Class506<ListViewItemState<string>, HashSet<ListViewItemState<string>>> class506_1 = new Class506<ListViewItemState<string>, HashSet<ListViewItemState<string>>>(Class414.class414_0);

		// Token: 0x0400138B RID: 5003
		private Dictionary<string, MakePackage.Enum98> dictionary_1 = new Dictionary<string, MakePackage.Enum98>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400138C RID: 5004
		private Dictionary<string, ListViewItemState<string>> dictionary_2 = new Dictionary<string, ListViewItemState<string>>(StringComparer.OrdinalIgnoreCase);

		// Token: 0x0400138D RID: 5005
		private Class429 class429_0;

		// Token: 0x0400138E RID: 5006
		private Class132 class132_0;

		// Token: 0x0400138F RID: 5007
		private Class514 class514_0;

		// Token: 0x04001390 RID: 5008
		private Class514 class514_1;

		// Token: 0x04001391 RID: 5009
		private volatile bool bool_4;

		// Token: 0x04001392 RID: 5010
		private volatile bool bool_5;

		// Token: 0x04001393 RID: 5011
		[CompilerGenerated]
		private static Func<bool> func_0;

		// Token: 0x04001394 RID: 5012
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_0;

		// Token: 0x04001395 RID: 5013
		[CompilerGenerated]
		private static MethodInvoker methodInvoker_1;

		// Token: 0x02000405 RID: 1029
		private enum Enum98
		{
			// Token: 0x04001397 RID: 5015
			const_0,
			// Token: 0x04001398 RID: 5016
			const_1,
			// Token: 0x04001399 RID: 5017
			const_2
		}

		// Token: 0x02000406 RID: 1030
		[CompilerGenerated]
		private sealed class Class415
		{
			// Token: 0x0600278B RID: 10123 RVA: 0x00091694 File Offset: 0x0008F894
			public void method_0()
			{
				this.makePackage_0.lbFiles.BeginUpdate();
				this.makePackage_0.lbFiles.Items.Clear();
				if (this.makePackage_0.cboFilterUserContent.Checked)
				{
					this.makePackage_0.lbFiles.Items.AddRange(this.listViewItemState_0.Where(new Func<ListViewItemState<string>, bool>(this.method_1)).ToArray<ListViewItemState<string>>());
				}
				else
				{
					this.makePackage_0.lbFiles.Items.AddRange(this.listViewItemState_0);
				}
				this.makePackage_0.lbFiles.EndUpdate();
				this.makePackage_0.method_25(true);
			}

			// Token: 0x0600278C RID: 10124 RVA: 0x00011E2D File Offset: 0x0001002D
			private bool method_1(ListViewItemState<string> item)
			{
				return this.makePackage_0.class132_0.Data.method_6(item.State);
			}

			// Token: 0x0400139A RID: 5018
			public ListViewItemState<string>[] listViewItemState_0;

			// Token: 0x0400139B RID: 5019
			public MakePackage makePackage_0;
		}

		// Token: 0x02000407 RID: 1031
		[CompilerGenerated]
		private sealed class Class416
		{
			// Token: 0x0600278E RID: 10126 RVA: 0x00091744 File Offset: 0x0008F944
			public void method_0()
			{
				this.makePackage_0.lbModels.BeginUpdate();
				this.makePackage_0.lbModels.Items.Clear();
				this.makePackage_0.lbModels.Items.AddRange(this.listViewItemState_0);
				this.makePackage_0.lbModels.EndUpdate();
				this.makePackage_0.txtModelSearch.Enabled = !this.makePackage_0.mniBuildModelIndex.Enabled;
				this.makePackage_0.btnClearModelSearch.Enabled = !this.makePackage_0.mniBuildModelIndex.Enabled;
				this.makePackage_0.method_24();
			}

			// Token: 0x0400139C RID: 5020
			public ListViewItemState<string>[] listViewItemState_0;

			// Token: 0x0400139D RID: 5021
			public MakePackage makePackage_0;
		}

		// Token: 0x02000408 RID: 1032
		[CompilerGenerated]
		private sealed class Class417
		{
			// Token: 0x06002790 RID: 10128 RVA: 0x000917F4 File Offset: 0x0008F9F4
			public void method_0()
			{
				if (string.IsNullOrEmpty(this.string_0))
				{
					this.makePackage_0.lblSelectedFile.Text = string.Empty;
					return;
				}
				this.makePackage_0.lblSelectedFile.Text = string.Format("({0})", this.string_0);
			}

			// Token: 0x0400139E RID: 5022
			public string string_0;

			// Token: 0x0400139F RID: 5023
			public MakePackage makePackage_0;
		}

		// Token: 0x02000409 RID: 1033
		[CompilerGenerated]
		private sealed class Class418
		{
			// Token: 0x06002792 RID: 10130 RVA: 0x00011E4A File Offset: 0x0001004A
			public void method_0()
			{
				this.makePackage_0.method_29(this.class429_0);
			}

			// Token: 0x040013A0 RID: 5024
			public Class429 class429_0;

			// Token: 0x040013A1 RID: 5025
			public MakePackage makePackage_0;
		}

		// Token: 0x0200040A RID: 1034
		[CompilerGenerated]
		private sealed class Class419
		{
			// Token: 0x06002794 RID: 10132 RVA: 0x00011E5D File Offset: 0x0001005D
			public void method_0()
			{
				this.makePackage_0.method_31(this.class355_0);
			}

			// Token: 0x040013A2 RID: 5026
			public Class355 class355_0;

			// Token: 0x040013A3 RID: 5027
			public MakePackage makePackage_0;
		}

		// Token: 0x0200040B RID: 1035
		[CompilerGenerated]
		private sealed class Class420
		{
			// Token: 0x06002796 RID: 10134 RVA: 0x00091844 File Offset: 0x0008FA44
			public void method_0()
			{
				byte[] array = null;
				try
				{
					Enum68 @enum = Class136.smethod_4(this.listViewItemState_0.State);
					if (@enum == Enum68.const_0)
					{
						return;
					}
					this.makePackage_0.openFileDialog_1.FileName = Path.GetFileName(this.listViewItemState_0.State);
					this.makePackage_0.openFileDialog_1.Filter = @enum.smethod_0(true);
					this.makePackage_0.openFileDialog_1.Title = "Select a file to add to your Content Pack.";
					this.makePackage_0.openFileDialog_1.FilterIndex = 1;
					if (this.makePackage_0.openFileDialog_1.ShowDialog() == DialogResult.OK)
					{
						switch (@enum)
						{
						case Enum68.const_1:
						case Enum68.const_3:
						case Enum68.const_4:
						case Enum68.const_5:
							break;
						case Enum68.const_2:
						{
							array = Class234.smethod_7(this.makePackage_0.openFileDialog_1.FileName);
							byte[] buffer = this.makePackage_0.method_33(this.listViewItemState_0.State);
							Enum14 enum2;
							using (MemoryStream memoryStream = new MemoryStream(buffer))
							{
								enum2 = Class486.smethod_1(memoryStream);
							}
							bool convert_to_grayscale = enum2 == Enum14.const_2 || enum2 == Enum14.const_3;
							string a;
							if ((a = Path.GetExtension(this.makePackage_0.openFileDialog_1.FileName).ToLower()) == null)
							{
								goto IL_1F6;
							}
							if (!(a == ".jpg"))
							{
								if (!(a == ".png"))
								{
									goto IL_1F6;
								}
								using (MemoryStream memoryStream2 = new MemoryStream(array))
								{
									using (MemoryStream memoryStream3 = new MemoryStream())
									{
										Class486.smethod_0(memoryStream2, memoryStream3, null, null, convert_to_grayscale, enum2);
										array = memoryStream3.ToArray();
									}
									goto IL_1F6;
								}
							}
							using (MemoryStream memoryStream4 = new MemoryStream(array))
							{
								using (MemoryStream memoryStream5 = new MemoryStream())
								{
									Class486.smethod_0(memoryStream4, memoryStream5, null, null, convert_to_grayscale, enum2);
									array = memoryStream5.ToArray();
								}
								goto IL_1F6;
							}
							break;
						}
						default:
							goto IL_1F6;
						}
						array = Class234.smethod_7(this.makePackage_0.openFileDialog_1.FileName);
					}
					IL_1F6:;
				}
				catch (Exception ex)
				{
					array = null;
					DialogBox.smethod_7(ex, this.makePackage_0.openFileDialog_1.FileName);
					ex.smethod_1(new object[]
					{
						this.makePackage_0.openFileDialog_1.FileName
					});
				}
				if (array != null)
				{
					Class338 @class;
					if (this.makePackage_0.class132_0.Data.method_6(this.listViewItemState_0.State))
					{
						@class = this.makePackage_0.class132_0.Data[this.listViewItemState_0.State];
					}
					else
					{
						@class = this.makePackage_0.class132_0.Data.method_4(this.listViewItemState_0.State);
					}
					@class.Data = array;
					this.makePackage_0.class504_0.Modified = true;
				}
				this.makePackage_0.method_13(this.listViewItemState_0);
				this.makePackage_0.method_25(true);
			}

			// Token: 0x040013A4 RID: 5028
			public ListViewItemState<string> listViewItemState_0;

			// Token: 0x040013A5 RID: 5029
			public MakePackage makePackage_0;
		}

		// Token: 0x0200040C RID: 1036
		[CompilerGenerated]
		private sealed class Class421
		{
			// Token: 0x06002798 RID: 10136 RVA: 0x00011E70 File Offset: 0x00010070
			public bool method_0()
			{
				if (this.makePackage_0.folderBrowserDialog_0.ShowDialog() == DialogResult.OK)
				{
					this.string_0 = this.makePackage_0.folderBrowserDialog_0.SelectedPath;
					return true;
				}
				return false;
			}

			// Token: 0x040013A6 RID: 5030
			public string string_0;

			// Token: 0x040013A7 RID: 5031
			public MakePackage makePackage_0;
		}

		// Token: 0x0200040D RID: 1037
		[CompilerGenerated]
		private sealed class Class422
		{
			// Token: 0x0600279A RID: 10138 RVA: 0x00011E9E File Offset: 0x0001009E
			public void method_0()
			{
				this.class421_0.makePackage_0.method_12(this.hashSet_0);
			}

			// Token: 0x040013A8 RID: 5032
			public MakePackage.Class421 class421_0;

			// Token: 0x040013A9 RID: 5033
			public HashSet<ListViewItemState<string>> hashSet_0;
		}

		// Token: 0x0200040E RID: 1038
		[CompilerGenerated]
		private sealed class Class423
		{
			// Token: 0x0600279C RID: 10140 RVA: 0x00091BC4 File Offset: 0x0008FDC4
			public bool method_0()
			{
				this.makePackage_0.saveFileDialog_1.FileName = Path.GetFileName(this.string_1);
				this.makePackage_0.saveFileDialog_1.Filter = this.enum68_0.smethod_0(true);
				this.makePackage_0.saveFileDialog_1.Title = "Save the exported file.";
				this.makePackage_0.saveFileDialog_1.FilterIndex = 1;
				if (this.makePackage_0.saveFileDialog_1.ShowDialog() == DialogResult.OK)
				{
					this.string_0 = this.makePackage_0.saveFileDialog_1.FileName;
					return true;
				}
				return false;
			}

			// Token: 0x040013AA RID: 5034
			public Enum68 enum68_0;

			// Token: 0x040013AB RID: 5035
			public string string_0;

			// Token: 0x040013AC RID: 5036
			public MakePackage makePackage_0;

			// Token: 0x040013AD RID: 5037
			public string string_1;
		}

		// Token: 0x0200040F RID: 1039
		[CompilerGenerated]
		private sealed class Class424
		{
			// Token: 0x0600279E RID: 10142 RVA: 0x00011EB6 File Offset: 0x000100B6
			public void method_0()
			{
				this.makePackage_0.method_12(this.hashSet_0);
			}

			// Token: 0x040013AE RID: 5038
			public HashSet<ListViewItemState<string>> hashSet_0;

			// Token: 0x040013AF RID: 5039
			public MakePackage makePackage_0;
		}

		// Token: 0x02000410 RID: 1040
		[CompilerGenerated]
		private sealed class Class425
		{
			// Token: 0x060027A0 RID: 10144 RVA: 0x00091C5C File Offset: 0x0008FE5C
			public void method_0()
			{
				ListViewItemState<string> listViewItemState = this.object_0 as ListViewItemState<string>;
				if (this.makePackage_0.class132_0.Data.method_6(listViewItemState.State))
				{
					Class338 @class = this.makePackage_0.class132_0.Data[listViewItemState.State];
					@class.Data = null;
					this.makePackage_0.class132_0.Data.method_5(listViewItemState.State);
					this.makePackage_0.class504_0.Modified = true;
				}
				this.makePackage_0.method_13(listViewItemState);
				this.makePackage_0.method_25(true);
			}

			// Token: 0x040013B0 RID: 5040
			public MakePackage makePackage_0;

			// Token: 0x040013B1 RID: 5041
			public object object_0;
		}

		// Token: 0x02000411 RID: 1041
		[CompilerGenerated]
		private sealed class Class426
		{
			// Token: 0x060027A2 RID: 10146 RVA: 0x00091CFC File Offset: 0x0008FEFC
			public void method_0(object sender, EventArgs43<string> e)
			{
				if (string.IsNullOrEmpty(e.gparam_0))
				{
					e.IsValid = false;
				}
				else
				{
					switch (this.class132_0.Type)
					{
					case Enum82.const_0:
						e.IsValid = Struct43.smethod_5(Encoding.ASCII.GetBytes(e.gparam_0).smethod_0(), this.class132_0.PasswordHash);
						goto IL_8A;
					}
					e.IsValid = Struct43.smethod_5(Encoding.Unicode.GetBytes(e.gparam_0).smethod_0(), this.class132_0.PasswordHash);
				}
				IL_8A:
				if (!e.IsValid)
				{
					DialogBox.smethod_3("Your password is not valid.", "Invalid Password");
				}
			}

			// Token: 0x040013B2 RID: 5042
			public Class132 class132_0;
		}

		// Token: 0x02000412 RID: 1042
		[CompilerGenerated]
		private sealed class Class427
		{
			// Token: 0x060027A4 RID: 10148 RVA: 0x00091DAC File Offset: 0x0008FFAC
			public bool method_0()
			{
				this.makePackage_0.openFileDialog_1.Filter = "Content Packs|*.ttp";
				this.makePackage_0.openFileDialog_1.FileName = string.Empty;
				this.makePackage_0.openFileDialog_1.Title = "Select the original file name.";
				this.makePackage_0.openFileDialog_1.FilterIndex = 1;
				if (this.makePackage_0.openFileDialog_1.ShowDialog() == DialogResult.OK)
				{
					this.string_0 = this.makePackage_0.openFileDialog_1.FileName;
					this.makePackage_0.openFileDialog_1.FileName = string.Empty;
					this.makePackage_0.openFileDialog_1.Title = "Select the new file.";
					if (this.makePackage_0.openFileDialog_1.ShowDialog() == DialogResult.OK)
					{
						this.string_1 = this.makePackage_0.openFileDialog_1.FileName;
						if (Class336.smethod_0(this.string_0, this.string_1))
						{
							DialogBox.smethod_3("You cannot pick the same file.", "Same Original / New File Selected.");
						}
						else
						{
							this.makePackage_0.saveFileDialog_1.Filter = "Patch File|*.pch";
							this.makePackage_0.saveFileDialog_1.FilterIndex = 1;
							this.makePackage_0.saveFileDialog_1.FileName = string.Empty;
							this.makePackage_0.saveFileDialog_1.Title = "Save the resulting patch file.";
							if (this.makePackage_0.saveFileDialog_1.ShowDialog() == DialogResult.OK)
							{
								this.string_2 = this.makePackage_0.saveFileDialog_1.FileName;
								if (!Class336.smethod_0(this.string_1, this.string_2) && !Class336.smethod_0(this.string_0, this.string_2))
								{
									return true;
								}
								DialogBox.smethod_3("You cannot pick the same file.", "Same Patch, Original / New File Selected.");
							}
						}
					}
				}
				return false;
			}

			// Token: 0x040013B3 RID: 5043
			public string string_0;

			// Token: 0x040013B4 RID: 5044
			public string string_1;

			// Token: 0x040013B5 RID: 5045
			public string string_2;

			// Token: 0x040013B6 RID: 5046
			public MakePackage makePackage_0;
		}

		// Token: 0x02000413 RID: 1043
		[CompilerGenerated]
		private sealed class Class428
		{
			// Token: 0x060027A6 RID: 10150 RVA: 0x00011EC9 File Offset: 0x000100C9
			public void method_0()
			{
				DialogBox.smethod_4(string.Format("There has been an error creating the patch: '{0}'.", this.exception_0.Message), "Error Creating Patch");
			}

			// Token: 0x040013B7 RID: 5047
			public MakePackage.Class427 class427_0;

			// Token: 0x040013B8 RID: 5048
			public Exception exception_0;
		}
	}
}
