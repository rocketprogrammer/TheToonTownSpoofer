using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns17;
using ns23;
using ns29;

namespace ns26
{
	// Token: 0x02000473 RID: 1139
	internal sealed class RichTextBoxExtended : UserControl
	{
		// Token: 0x06002A1C RID: 10780 RVA: 0x0001377A File Offset: 0x0001197A
		protected override void Dispose(bool disposing)
		{
			if (this.richTextBox_0 != null)
			{
				this.richTextBox_0.Dispose();
				this.richTextBox_0 = null;
			}
			if (disposing && this.icontainer_0 != null)
			{
				this.icontainer_0.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002A1D RID: 10781 RVA: 0x000A1E44 File Offset: 0x000A0044
		private void InitializeComponent()
		{
			this.icontainer_0 = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(RichTextBoxExtended));
			this.tbbSeparator5 = new ToolBarButton();
			this.tbMain = new ToolBar();
			this.tbbSave = new ToolBarButton();
			this.tbbOpen = new ToolBarButton();
			this.tbbSeparator3 = new ToolBarButton();
			this.tbbFont = new ToolBarButton();
			this.contextMenu_0 = new ContextMenu();
			this.menuItem_0 = new MenuItem();
			this.menuItem_1 = new MenuItem();
			this.menuItem_2 = new MenuItem();
			this.menuItem_3 = new MenuItem();
			this.menuItem_4 = new MenuItem();
			this.menuItem_5 = new MenuItem();
			this.menuItem_6 = new MenuItem();
			this.tbbFontSize = new ToolBarButton();
			this.contextMenu_1 = new ContextMenu();
			this.menuItem_7 = new MenuItem();
			this.menuItem_8 = new MenuItem();
			this.menuItem_9 = new MenuItem();
			this.menuItem_10 = new MenuItem();
			this.menuItem_11 = new MenuItem();
			this.menuItem_12 = new MenuItem();
			this.menuItem_13 = new MenuItem();
			this.menuItem_14 = new MenuItem();
			this.menuItem_15 = new MenuItem();
			this.menuItem_16 = new MenuItem();
			this.menuItem_17 = new MenuItem();
			this.menuItem_18 = new MenuItem();
			this.menuItem_19 = new MenuItem();
			this.menuItem_20 = new MenuItem();
			this.menuItem_21 = new MenuItem();
			this.menuItem_22 = new MenuItem();
			this.tbbColor = new ToolBarButton();
			this.contextMenu_2 = new ContextMenu();
			this.menuItem_23 = new MenuItem();
			this.menuItem_24 = new MenuItem();
			this.menuItem_25 = new MenuItem();
			this.menuItem_26 = new MenuItem();
			this.menuItem_27 = new MenuItem();
			this.menuItem_28 = new MenuItem();
			this.menuItem_29 = new MenuItem();
			this.menuItem_30 = new MenuItem();
			this.menuItem_31 = new MenuItem();
			this.tbbBold = new ToolBarButton();
			this.tbbItalic = new ToolBarButton();
			this.tbbUnderline = new ToolBarButton();
			this.tbbStrikeout = new ToolBarButton();
			this.tbbSeparator1 = new ToolBarButton();
			this.tbbLeft = new ToolBarButton();
			this.tbbCenter = new ToolBarButton();
			this.tbbRight = new ToolBarButton();
			this.tbbSeparator2 = new ToolBarButton();
			this.tbbUndo = new ToolBarButton();
			this.tbbRedo = new ToolBarButton();
			this.tbbSeparator4 = new ToolBarButton();
			this.tbbCut = new ToolBarButton();
			this.tbbCopy = new ToolBarButton();
			this.tbbPaste = new ToolBarButton();
			this.imageList_0 = new ImageList(this.icontainer_0);
			this.rtfBox = new RichTextBox();
			this.colorDialog_0 = new ColorDialog();
			this.openFileDialog_0 = new OpenFileDialog();
			this.saveFileDialog_0 = new SaveFileDialog();
			this.toolTip_0 = new ToolTip(this.icontainer_0);
			base.SuspendLayout();
			this.tbbSeparator5.Name = "tbbSeparator5";
			this.tbbSeparator5.Style = ToolBarButtonStyle.Separator;
			this.tbMain.Appearance = ToolBarAppearance.Flat;
			this.tbMain.Buttons.AddRange(new ToolBarButton[]
			{
				this.tbbSave,
				this.tbbOpen,
				this.tbbSeparator3,
				this.tbbFont,
				this.tbbFontSize,
				this.tbbColor,
				this.tbbSeparator5,
				this.tbbBold,
				this.tbbItalic,
				this.tbbUnderline,
				this.tbbStrikeout,
				this.tbbSeparator1,
				this.tbbLeft,
				this.tbbCenter,
				this.tbbRight,
				this.tbbSeparator2,
				this.tbbUndo,
				this.tbbRedo,
				this.tbbSeparator4,
				this.tbbCut,
				this.tbbCopy,
				this.tbbPaste
			});
			this.tbMain.ButtonSize = new Size(16, 16);
			this.tbMain.Divider = false;
			this.tbMain.DropDownArrows = true;
			this.tbMain.ImageList = this.imageList_0;
			this.tbMain.Location = new Point(0, 0);
			this.tbMain.Name = "tbMain";
			this.tbMain.ShowToolTips = true;
			this.tbMain.Size = new Size(504, 26);
			this.tbMain.TabIndex = 2;
			this.tbMain.ButtonClick += this.tbMain_ButtonClick;
			this.tbbSave.ImageIndex = 11;
			this.tbbSave.Name = "tbbSave";
			this.tbbSave.Tag = "save";
			this.tbbSave.ToolTipText = "Saves the Rich Text document.";
			this.tbbOpen.ImageIndex = 10;
			this.tbbOpen.Name = "tbbOpen";
			this.tbbOpen.Tag = "open";
			this.tbbOpen.ToolTipText = "Loads a Rich Text document.";
			this.tbbSeparator3.Name = "tbbSeparator3";
			this.tbbSeparator3.Style = ToolBarButtonStyle.Separator;
			this.tbbFont.DropDownMenu = this.contextMenu_0;
			this.tbbFont.ImageIndex = 14;
			this.tbbFont.Name = "tbbFont";
			this.tbbFont.Style = ToolBarButtonStyle.DropDownButton;
			this.tbbFont.Tag = "font";
			this.tbbFont.ToolTipText = "Select a font.";
			this.contextMenu_0.MenuItems.AddRange(new MenuItem[]
			{
				this.menuItem_0,
				this.menuItem_1,
				this.menuItem_2,
				this.menuItem_3,
				this.menuItem_4,
				this.menuItem_5,
				this.menuItem_6
			});
			this.menuItem_0.Index = 0;
			this.menuItem_0.Text = "Arial";
			this.menuItem_0.Click += this.menuItem_6_Click;
			this.menuItem_1.Index = 1;
			this.menuItem_1.Text = "Courier New";
			this.menuItem_1.Click += this.menuItem_6_Click;
			this.menuItem_2.Index = 2;
			this.menuItem_2.Text = "Garamond";
			this.menuItem_2.Click += this.menuItem_6_Click;
			this.menuItem_3.Index = 3;
			this.menuItem_3.Text = "Microsoft Sans Serif";
			this.menuItem_3.Click += this.menuItem_6_Click;
			this.menuItem_4.Index = 4;
			this.menuItem_4.Text = "Tahoma";
			this.menuItem_4.Click += this.menuItem_6_Click;
			this.menuItem_5.Index = 5;
			this.menuItem_5.Text = "Times New Roman";
			this.menuItem_5.Click += this.menuItem_6_Click;
			this.menuItem_6.Index = 6;
			this.menuItem_6.Text = "Verdana";
			this.menuItem_6.Click += this.menuItem_6_Click;
			this.tbbFontSize.DropDownMenu = this.contextMenu_1;
			this.tbbFontSize.ImageIndex = 15;
			this.tbbFontSize.Name = "tbbFontSize";
			this.tbbFontSize.Style = ToolBarButtonStyle.DropDownButton;
			this.tbbFontSize.Tag = "font size";
			this.tbbFontSize.ToolTipText = "Select a font size.";
			this.contextMenu_1.MenuItems.AddRange(new MenuItem[]
			{
				this.menuItem_7,
				this.menuItem_8,
				this.menuItem_9,
				this.menuItem_10,
				this.menuItem_11,
				this.menuItem_12,
				this.menuItem_13,
				this.menuItem_14,
				this.menuItem_15,
				this.menuItem_16,
				this.menuItem_17,
				this.menuItem_18,
				this.menuItem_19,
				this.menuItem_20,
				this.menuItem_21,
				this.menuItem_22
			});
			this.menuItem_7.Index = 0;
			this.menuItem_7.Text = "8";
			this.menuItem_7.Click += this.menuItem_22_Click;
			this.menuItem_8.Index = 1;
			this.menuItem_8.Text = "9";
			this.menuItem_8.Click += this.menuItem_22_Click;
			this.menuItem_9.Index = 2;
			this.menuItem_9.Text = "10";
			this.menuItem_9.Click += this.menuItem_22_Click;
			this.menuItem_10.Index = 3;
			this.menuItem_10.Text = "11";
			this.menuItem_10.Click += this.menuItem_22_Click;
			this.menuItem_11.Index = 4;
			this.menuItem_11.Text = "12";
			this.menuItem_11.Click += this.menuItem_22_Click;
			this.menuItem_12.Index = 5;
			this.menuItem_12.Text = "14";
			this.menuItem_12.Click += this.menuItem_22_Click;
			this.menuItem_13.Index = 6;
			this.menuItem_13.Text = "16";
			this.menuItem_13.Click += this.menuItem_22_Click;
			this.menuItem_14.Index = 7;
			this.menuItem_14.Text = "18";
			this.menuItem_14.Click += this.menuItem_22_Click;
			this.menuItem_15.Index = 8;
			this.menuItem_15.Text = "20";
			this.menuItem_15.Click += this.menuItem_22_Click;
			this.menuItem_16.Index = 9;
			this.menuItem_16.Text = "22";
			this.menuItem_16.Click += this.menuItem_22_Click;
			this.menuItem_17.Index = 10;
			this.menuItem_17.Text = "24";
			this.menuItem_17.Click += this.menuItem_22_Click;
			this.menuItem_18.Index = 11;
			this.menuItem_18.Text = "26";
			this.menuItem_18.Click += this.menuItem_22_Click;
			this.menuItem_19.Index = 12;
			this.menuItem_19.Text = "28";
			this.menuItem_19.Click += this.menuItem_22_Click;
			this.menuItem_20.Index = 13;
			this.menuItem_20.Text = "36";
			this.menuItem_20.Click += this.menuItem_22_Click;
			this.menuItem_21.Index = 14;
			this.menuItem_21.Text = "48";
			this.menuItem_21.Click += this.menuItem_22_Click;
			this.menuItem_22.Index = 15;
			this.menuItem_22.Text = "72";
			this.menuItem_22.Click += this.menuItem_22_Click;
			this.tbbColor.DropDownMenu = this.contextMenu_2;
			this.tbbColor.ImageIndex = 7;
			this.tbbColor.Name = "tbbColor";
			this.tbbColor.Style = ToolBarButtonStyle.DropDownButton;
			this.tbbColor.Tag = "color";
			this.tbbColor.ToolTipText = "Select a font color.";
			this.contextMenu_2.MenuItems.AddRange(new MenuItem[]
			{
				this.menuItem_23,
				this.menuItem_24,
				this.menuItem_25,
				this.menuItem_26,
				this.menuItem_27,
				this.menuItem_28,
				this.menuItem_29,
				this.menuItem_30,
				this.menuItem_31
			});
			this.menuItem_23.Index = 0;
			this.menuItem_23.Text = "Black";
			this.menuItem_23.Click += this.menuItem_23_Click;
			this.menuItem_24.Index = 1;
			this.menuItem_24.Text = "Custom";
			this.menuItem_24.Click += this.menuItem_24_Click;
			this.menuItem_25.Index = 2;
			this.menuItem_25.Text = "-";
			this.menuItem_26.Index = 3;
			this.menuItem_26.Text = "Blue";
			this.menuItem_26.Click += this.menuItem_26_Click;
			this.menuItem_27.Index = 4;
			this.menuItem_27.Text = "Fuchsia";
			this.menuItem_27.Click += this.menuItem_27_Click;
			this.menuItem_28.Index = 5;
			this.menuItem_28.Text = "Green";
			this.menuItem_28.Click += this.menuItem_28_Click;
			this.menuItem_29.Index = 6;
			this.menuItem_29.Text = "Lavender";
			this.menuItem_29.Click += this.menuItem_29_Click;
			this.menuItem_30.Index = 7;
			this.menuItem_30.Text = "Red";
			this.menuItem_30.Click += this.menuItem_30_Click;
			this.menuItem_31.Index = 8;
			this.menuItem_31.Text = "Yellow";
			this.menuItem_31.Click += this.menuItem_31_Click;
			this.tbbBold.ImageIndex = 0;
			this.tbbBold.Name = "tbbBold";
			this.tbbBold.Style = ToolBarButtonStyle.ToggleButton;
			this.tbbBold.Tag = "bold";
			this.tbbBold.ToolTipText = "Bold";
			this.tbbItalic.ImageIndex = 1;
			this.tbbItalic.Name = "tbbItalic";
			this.tbbItalic.Style = ToolBarButtonStyle.ToggleButton;
			this.tbbItalic.Tag = "italic";
			this.tbbItalic.ToolTipText = "Italic";
			this.tbbUnderline.ImageIndex = 2;
			this.tbbUnderline.Name = "tbbUnderline";
			this.tbbUnderline.Style = ToolBarButtonStyle.ToggleButton;
			this.tbbUnderline.Tag = "underline";
			this.tbbUnderline.ToolTipText = "Underline";
			this.tbbStrikeout.ImageIndex = 3;
			this.tbbStrikeout.Name = "tbbStrikeout";
			this.tbbStrikeout.Style = ToolBarButtonStyle.ToggleButton;
			this.tbbStrikeout.Tag = "strikeout";
			this.tbbStrikeout.ToolTipText = "Strikeout";
			this.tbbSeparator1.Name = "tbbSeparator1";
			this.tbbSeparator1.Style = ToolBarButtonStyle.Separator;
			this.tbbLeft.ImageIndex = 4;
			this.tbbLeft.Name = "tbbLeft";
			this.tbbLeft.Style = ToolBarButtonStyle.ToggleButton;
			this.tbbLeft.Tag = "left";
			this.tbbLeft.ToolTipText = "Align Left";
			this.tbbCenter.ImageIndex = 5;
			this.tbbCenter.Name = "tbbCenter";
			this.tbbCenter.Style = ToolBarButtonStyle.ToggleButton;
			this.tbbCenter.Tag = "center";
			this.tbbCenter.ToolTipText = "Align Center";
			this.tbbRight.ImageIndex = 6;
			this.tbbRight.Name = "tbbRight";
			this.tbbRight.Style = ToolBarButtonStyle.ToggleButton;
			this.tbbRight.Tag = "right";
			this.tbbRight.ToolTipText = "Align Right";
			this.tbbSeparator2.Name = "tbbSeparator2";
			this.tbbSeparator2.Style = ToolBarButtonStyle.Separator;
			this.tbbUndo.ImageIndex = 12;
			this.tbbUndo.Name = "tbbUndo";
			this.tbbUndo.Tag = "undo";
			this.tbbUndo.ToolTipText = "Undo";
			this.tbbRedo.ImageIndex = 13;
			this.tbbRedo.Name = "tbbRedo";
			this.tbbRedo.Tag = "redo";
			this.tbbRedo.ToolTipText = "Redo";
			this.tbbSeparator4.Name = "tbbSeparator4";
			this.tbbSeparator4.Style = ToolBarButtonStyle.Separator;
			this.tbbCut.ImageIndex = 17;
			this.tbbCut.Name = "tbbCut";
			this.tbbCut.Tag = "cut";
			this.tbbCut.ToolTipText = "Cut";
			this.tbbCopy.ImageIndex = 18;
			this.tbbCopy.Name = "tbbCopy";
			this.tbbCopy.Tag = "copy";
			this.tbbCopy.ToolTipText = "Copy";
			this.tbbPaste.ImageIndex = 19;
			this.tbbPaste.Name = "tbbPaste";
			this.tbbPaste.Tag = "paste";
			this.tbbPaste.ToolTipText = "Paste";
			this.imageList_0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("ilToolBarIcons.ImageStream");
			this.imageList_0.TransparentColor = Color.Transparent;
			this.imageList_0.Images.SetKeyName(0, "");
			this.imageList_0.Images.SetKeyName(1, "");
			this.imageList_0.Images.SetKeyName(2, "");
			this.imageList_0.Images.SetKeyName(3, "");
			this.imageList_0.Images.SetKeyName(4, "");
			this.imageList_0.Images.SetKeyName(5, "");
			this.imageList_0.Images.SetKeyName(6, "");
			this.imageList_0.Images.SetKeyName(7, "");
			this.imageList_0.Images.SetKeyName(8, "");
			this.imageList_0.Images.SetKeyName(9, "");
			this.imageList_0.Images.SetKeyName(10, "");
			this.imageList_0.Images.SetKeyName(11, "");
			this.imageList_0.Images.SetKeyName(12, "");
			this.imageList_0.Images.SetKeyName(13, "");
			this.imageList_0.Images.SetKeyName(14, "");
			this.imageList_0.Images.SetKeyName(15, "");
			this.imageList_0.Images.SetKeyName(16, "");
			this.imageList_0.Images.SetKeyName(17, "");
			this.imageList_0.Images.SetKeyName(18, "");
			this.imageList_0.Images.SetKeyName(19, "");
			this.imageList_0.Images.SetKeyName(20, "");
			this.rtfBox.AutoWordSelection = true;
			this.rtfBox.Dock = DockStyle.Fill;
			this.rtfBox.Location = new Point(0, 26);
			this.rtfBox.Name = "rtfBox";
			this.rtfBox.Size = new Size(504, 198);
			this.rtfBox.TabIndex = 3;
			this.rtfBox.Text = "";
			this.rtfBox.LinkClicked += this.rtfBox_LinkClicked;
			this.rtfBox.SelectionChanged += this.rtfBox_SelectionChanged;
			this.rtfBox.TextChanged += this.rtfBox_TextChanged;
			this.openFileDialog_0.DefaultExt = "rtf";
			this.openFileDialog_0.Filter = "Rich Text Files|*.rtf|Plain Text File|*.txt";
			this.openFileDialog_0.Title = "Open File";
			this.saveFileDialog_0.DefaultExt = "rtf";
			this.saveFileDialog_0.Filter = "Rich Text File|*.rtf|Plain Text File|*.txt";
			this.saveFileDialog_0.Title = "Save As";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.rtfBox);
			base.Controls.Add(this.tbMain);
			base.Name = "RichTextBoxExtended";
			base.Size = new Size(504, 224);
			base.Leave += this.RichTextBoxExtended_Leave;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x06002A1E RID: 10782 RVA: 0x000137B3 File Offset: 0x000119B3
		public RichTextBoxExtended()
		{
			this.InitializeComponent();
			this.method_0();
		}

		// Token: 0x140001D8 RID: 472
		// (add) Token: 0x06002A1F RID: 10783 RVA: 0x000A337C File Offset: 0x000A157C
		// (remove) Token: 0x06002A20 RID: 10784 RVA: 0x000A33B4 File Offset: 0x000A15B4
		[Category("Behavior")]
		[Description("Occurs when the selection is changed")]
		public event EventHandler SelectionChanged
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

		// Token: 0x140001D9 RID: 473
		// (add) Token: 0x06002A21 RID: 10785 RVA: 0x000A33EC File Offset: 0x000A15EC
		// (remove) Token: 0x06002A22 RID: 10786 RVA: 0x000A3424 File Offset: 0x000A1624
		[Category("Property Changed")]
		public event EventHandler RTFChanged
		{
			add
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler eventHandler = this.eventHandler_1;
				EventHandler eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler>(ref this.eventHandler_1, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06002A23 RID: 10787 RVA: 0x000A345C File Offset: 0x000A165C
		private void tbMain_ButtonClick(object sender, ToolBarButtonClickEventArgs e)
		{
			bool pushed = e.Button.Pushed;
			string key;
			if ((key = e.Button.Tag.ToString().ToLower()) != null)
			{
				if (Class529.dictionary_2 == null)
				{
					Class529.dictionary_2 = new Dictionary<string, int>(15)
					{
						{
							"bold",
							0
						},
						{
							"italic",
							1
						},
						{
							"underline",
							2
						},
						{
							"strikeout",
							3
						},
						{
							"left",
							4
						},
						{
							"center",
							5
						},
						{
							"right",
							6
						},
						{
							"color",
							7
						},
						{
							"undo",
							8
						},
						{
							"redo",
							9
						},
						{
							"open",
							10
						},
						{
							"save",
							11
						},
						{
							"cut",
							12
						},
						{
							"copy",
							13
						},
						{
							"paste",
							14
						}
					};
				}
				int num;
				if (Class529.dictionary_2.TryGetValue(key, out num))
				{
					switch (num)
					{
					case 0:
						this.method_3(FontStyle.Bold, pushed);
						return;
					case 1:
						this.method_3(FontStyle.Italic, pushed);
						return;
					case 2:
						this.method_3(FontStyle.Underline, pushed);
						return;
					case 3:
						this.method_3(FontStyle.Strikeout, pushed);
						return;
					case 4:
						this.rtfBox.SelectionAlignment = HorizontalAlignment.Left;
						this.tbbCenter.Pushed = false;
						this.tbbRight.Pushed = false;
						return;
					case 5:
						this.tbbLeft.Pushed = false;
						this.rtfBox.SelectionAlignment = HorizontalAlignment.Center;
						this.tbbRight.Pushed = false;
						return;
					case 6:
						this.tbbLeft.Pushed = false;
						this.tbbCenter.Pushed = false;
						this.rtfBox.SelectionAlignment = HorizontalAlignment.Right;
						return;
					case 7:
						this.rtfBox.SelectionColor = Color.Black;
						return;
					case 8:
						this.rtfBox.Undo();
						return;
					case 9:
						this.rtfBox.Redo();
						return;
					case 10:
						try
						{
							if (this.openFileDialog_0.ShowDialog() == DialogResult.OK && this.openFileDialog_0.FileName.Length > 0)
							{
								if (Path.GetExtension(this.openFileDialog_0.FileName).ToLower().Equals(".rtf"))
								{
									this.rtfBox.LoadFile(this.openFileDialog_0.FileName, RichTextBoxStreamType.RichText);
								}
								else
								{
									this.rtfBox.LoadFile(this.openFileDialog_0.FileName, RichTextBoxStreamType.PlainText);
								}
							}
							return;
						}
						catch (ArgumentException ex)
						{
							ex.smethod_1(new object[]
							{
								this.openFileDialog_0.FileName
							});
							DialogBox.smethod_4("There was an error loading the file: " + this.openFileDialog_0.FileName, "Error Loading");
							return;
						}
						catch (IOException ex2)
						{
							ex2.smethod_1(new object[]
							{
								this.openFileDialog_0.FileName
							});
							DialogBox.smethod_7(ex2, this.openFileDialog_0.FileName);
							return;
						}
						break;
					case 11:
						break;
					case 12:
						goto IL_3AC;
					case 13:
						if (this.rtfBox.SelectedText.Length <= 0)
						{
							return;
						}
						this.rtfBox.Copy();
						return;
					case 14:
						try
						{
							this.rtfBox.Paste();
						}
						catch (Exception ex3)
						{
							ex3.smethod_0();
							DialogBox.smethod_4("The contents of the ClipBoard could not be pasted.", "Error Pasting");
						}
						return;
					default:
						return;
					}
					try
					{
						if (this.saveFileDialog_0.ShowDialog() == DialogResult.OK && this.saveFileDialog_0.FileName.Length > 0)
						{
							if (Path.GetExtension(this.saveFileDialog_0.FileName).ToLower().Equals(".rtf"))
							{
								this.rtfBox.SaveFile(this.saveFileDialog_0.FileName);
							}
							else
							{
								this.rtfBox.SaveFile(this.saveFileDialog_0.FileName, RichTextBoxStreamType.PlainText);
							}
						}
						return;
					}
					catch (IOException ex4)
					{
						ex4.smethod_1(new object[]
						{
							this.openFileDialog_0.FileName
						});
						DialogBox.smethod_7(ex4, this.openFileDialog_0.FileName);
						return;
					}
					IL_3AC:
					if (this.rtfBox.SelectedText.Length <= 0)
					{
						return;
					}
					this.rtfBox.Cut();
					return;
				}
			}
		}

		// Token: 0x06002A24 RID: 10788 RVA: 0x000A38B0 File Offset: 0x000A1AB0
		public void method_0()
		{
			Font font = this.method_6();
			FontStyle style = font.Style;
			this.tbbBold.Pushed = font.Bold;
			this.tbbItalic.Pushed = font.Italic;
			this.tbbUnderline.Pushed = font.Underline;
			this.tbbStrikeout.Pushed = font.Strikeout;
			this.tbbLeft.Pushed = (this.rtfBox.SelectionAlignment == HorizontalAlignment.Left);
			this.tbbCenter.Pushed = (this.rtfBox.SelectionAlignment == HorizontalAlignment.Center);
			this.tbbRight.Pushed = (this.rtfBox.SelectionAlignment == HorizontalAlignment.Right);
			bool flag = false;
			foreach (object obj in this.contextMenu_2.MenuItems)
			{
				MenuItem menuItem = (MenuItem)obj;
				menuItem.Checked = (this.rtfBox.SelectionColor == Color.FromName(menuItem.Text));
				if (menuItem.Checked)
				{
					flag = true;
				}
			}
			this.colorDialog_0.Color = this.rtfBox.SelectionColor;
			this.menuItem_24.Checked = !flag;
			foreach (object obj2 in this.contextMenu_0.MenuItems)
			{
				MenuItem menuItem2 = (MenuItem)obj2;
				menuItem2.Checked = (font.FontFamily.Name == menuItem2.Text);
			}
			foreach (object obj3 in this.contextMenu_1.MenuItems)
			{
				MenuItem menuItem3 = (MenuItem)obj3;
				menuItem3.Checked = ((float)((int)font.SizeInPoints) == float.Parse(menuItem3.Text));
			}
		}

		// Token: 0x06002A25 RID: 10789 RVA: 0x000A3AD4 File Offset: 0x000A1CD4
		private void method_1()
		{
			if (!this.tbbSave.Visible && !this.tbbOpen.Visible)
			{
				this.tbbSeparator3.Visible = false;
			}
			else
			{
				this.tbbSeparator3.Visible = true;
			}
			if (!this.tbbFont.Visible && !this.tbbFontSize.Visible && !this.tbbColor.Visible)
			{
				this.tbbSeparator5.Visible = false;
			}
			else
			{
				this.tbbSeparator5.Visible = true;
			}
			if (!this.tbbBold.Visible && !this.tbbItalic.Visible && !this.tbbUnderline.Visible && !this.tbbStrikeout.Visible)
			{
				this.tbbSeparator1.Visible = false;
			}
			else
			{
				this.tbbSeparator1.Visible = true;
			}
			if (!this.tbbLeft.Visible && !this.tbbCenter.Visible && !this.tbbRight.Visible)
			{
				this.tbbSeparator2.Visible = false;
			}
			else
			{
				this.tbbSeparator2.Visible = true;
			}
			if (!this.tbbUndo.Visible && !this.tbbRedo.Visible)
			{
				this.tbbSeparator4.Visible = false;
				return;
			}
			this.tbbSeparator4.Visible = true;
		}

		// Token: 0x06002A26 RID: 10790 RVA: 0x000137D2 File Offset: 0x000119D2
		private void rtfBox_SelectionChanged(object sender, EventArgs e)
		{
			this.method_0();
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, e);
			}
		}

		// Token: 0x06002A27 RID: 10791 RVA: 0x000137EF File Offset: 0x000119EF
		private void menuItem_6_Click(object sender, EventArgs e)
		{
			this.method_2(((MenuItem)sender).Text);
		}

		// Token: 0x06002A28 RID: 10792 RVA: 0x00013802 File Offset: 0x00011A02
		private void menuItem_22_Click(object sender, EventArgs e)
		{
			this.method_4(float.Parse(((MenuItem)sender).Text));
		}

		// Token: 0x06002A29 RID: 10793 RVA: 0x0001381A File Offset: 0x00011A1A
		private void rtfBox_LinkClicked(object sender, LinkClickedEventArgs e)
		{
			Class512.smethod_2(e.LinkText);
		}

		// Token: 0x06002A2A RID: 10794 RVA: 0x00013827 File Offset: 0x00011A27
		private void RichTextBoxExtended_Leave(object sender, EventArgs e)
		{
			if (this.rtfBox.Modified && this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002A2B RID: 10795 RVA: 0x0001384F File Offset: 0x00011A4F
		private void rtfBox_TextChanged(object sender, EventArgs e)
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x06002A2C RID: 10796 RVA: 0x0001386A File Offset: 0x00011A6A
		private void menuItem_23_Click(object sender, EventArgs e)
		{
			this.method_5(Color.Black);
		}

		// Token: 0x06002A2D RID: 10797 RVA: 0x00013877 File Offset: 0x00011A77
		private void menuItem_26_Click(object sender, EventArgs e)
		{
			this.method_5(Color.Blue);
		}

		// Token: 0x06002A2E RID: 10798 RVA: 0x00013884 File Offset: 0x00011A84
		private void menuItem_30_Click(object sender, EventArgs e)
		{
			this.method_5(Color.Red);
		}

		// Token: 0x06002A2F RID: 10799 RVA: 0x00013891 File Offset: 0x00011A91
		private void menuItem_28_Click(object sender, EventArgs e)
		{
			this.method_5(Color.Green);
		}

		// Token: 0x06002A30 RID: 10800 RVA: 0x0001389E File Offset: 0x00011A9E
		private void menuItem_27_Click(object sender, EventArgs e)
		{
			this.method_5(Color.Fuchsia);
		}

		// Token: 0x06002A31 RID: 10801 RVA: 0x000138AB File Offset: 0x00011AAB
		private void menuItem_29_Click(object sender, EventArgs e)
		{
			this.method_5(Color.Lavender);
		}

		// Token: 0x06002A32 RID: 10802 RVA: 0x000138B8 File Offset: 0x00011AB8
		private void menuItem_31_Click(object sender, EventArgs e)
		{
			this.method_5(Color.Yellow);
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x000138C5 File Offset: 0x00011AC5
		private void menuItem_24_Click(object sender, EventArgs e)
		{
			if (this.colorDialog_0.ShowDialog() == DialogResult.OK)
			{
				this.method_5(this.colorDialog_0.Color);
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06002A34 RID: 10804 RVA: 0x000138E6 File Offset: 0x00011AE6
		// (set) Token: 0x06002A35 RID: 10805 RVA: 0x000138F3 File Offset: 0x00011AF3
		[Category("Appearance")]
		[Description("Controls whether the editing toolbar should be displayed")]
		[DefaultValue(true)]
		public bool ToolbarVisible
		{
			get
			{
				return this.tbMain.Visible;
			}
			set
			{
				this.tbMain.Visible = value;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06002A36 RID: 10806 RVA: 0x00013901 File Offset: 0x00011B01
		// (set) Token: 0x06002A37 RID: 10807 RVA: 0x0001390E File Offset: 0x00011B0E
		[Category("Appearance")]
		[Description("The background color of the editor portion of this control")]
		[DefaultValue(typeof(Color), "Window")]
		public Color EditorBackColor
		{
			get
			{
				return this.rtfBox.BackColor;
			}
			set
			{
				this.rtfBox.BackColor = value;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06002A38 RID: 10808 RVA: 0x0001391C File Offset: 0x00011B1C
		// (set) Token: 0x06002A39 RID: 10809 RVA: 0x00013929 File Offset: 0x00011B29
		[DefaultValue(BorderStyle.Fixed3D)]
		[Category("Appearance")]
		[Description("Indicates whether or not the edit control should have a border")]
		public new BorderStyle BorderStyle
		{
			get
			{
				return this.rtfBox.BorderStyle;
			}
			set
			{
				this.rtfBox.BorderStyle = value;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06002A3A RID: 10810 RVA: 0x00013937 File Offset: 0x00011B37
		// (set) Token: 0x06002A3B RID: 10811 RVA: 0x00013944 File Offset: 0x00011B44
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("Controls whether the text in the edit control can be changed or not")]
		public bool ReadOnly
		{
			get
			{
				return this.rtfBox.ReadOnly;
			}
			set
			{
				this.rtfBox.ReadOnly = value;
				if (value)
				{
					this.ToolbarVisible = false;
				}
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06002A3C RID: 10812 RVA: 0x000A3C18 File Offset: 0x000A1E18
		// (set) Token: 0x06002A3D RID: 10813 RVA: 0x000A3C50 File Offset: 0x000A1E50
		[Bindable(true)]
		[Category("Data")]
		[SettingsBindable(true)]
		[Editor(typeof(Class517), typeof(UITypeEditor))]
		[Description("Contents in Rtf format")]
		public string Rtf
		{
			get
			{
				string text = this.rtfBox.Rtf;
				if (text.EndsWith("\0"))
				{
					text = text.Substring(0, text.Length - 1);
				}
				return text;
			}
			set
			{
				if (value != this.rtfBox.Rtf)
				{
					this.rtfBox.Rtf = value;
					if (this.eventHandler_1 != null)
					{
						this.eventHandler_1(this, EventArgs.Empty);
					}
				}
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06002A3E RID: 10814 RVA: 0x0001395C File Offset: 0x00011B5C
		// (set) Token: 0x06002A3F RID: 10815 RVA: 0x00013969 File Offset: 0x00011B69
		[Description("Show the save button or not")]
		[Category("Appearance")]
		[DefaultValue(true)]
		public bool ShowSave
		{
			get
			{
				return this.tbbSave.Visible;
			}
			set
			{
				this.tbbSave.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002A40 RID: 10816 RVA: 0x0001397D File Offset: 0x00011B7D
		// (set) Token: 0x06002A41 RID: 10817 RVA: 0x0001398A File Offset: 0x00011B8A
		[Category("Appearance")]
		[Description("Show the open button or not")]
		[DefaultValue(true)]
		public bool ShowOpen
		{
			get
			{
				return this.tbbOpen.Visible;
			}
			set
			{
				this.tbbOpen.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002A42 RID: 10818 RVA: 0x0001399E File Offset: 0x00011B9E
		// (set) Token: 0x06002A43 RID: 10819 RVA: 0x000139AB File Offset: 0x00011BAB
		[DefaultValue(true)]
		[Category("Appearance")]
		[Description("Show the color button or not")]
		public bool ShowColors
		{
			get
			{
				return this.tbbColor.Visible;
			}
			set
			{
				this.tbbColor.Visible = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06002A44 RID: 10820 RVA: 0x000139B9 File Offset: 0x00011BB9
		// (set) Token: 0x06002A45 RID: 10821 RVA: 0x000139C6 File Offset: 0x00011BC6
		[DefaultValue(true)]
		[Category("Appearance")]
		[Description("Show the undo button or not")]
		public bool ShowUndo
		{
			get
			{
				return this.tbbUndo.Visible;
			}
			set
			{
				this.tbbUndo.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06002A46 RID: 10822 RVA: 0x000139DA File Offset: 0x00011BDA
		// (set) Token: 0x06002A47 RID: 10823 RVA: 0x000139E7 File Offset: 0x00011BE7
		[Category("Appearance")]
		[DefaultValue(true)]
		[Description("Show the redo button or not")]
		public bool ShowRedo
		{
			get
			{
				return this.tbbRedo.Visible;
			}
			set
			{
				this.tbbRedo.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06002A48 RID: 10824 RVA: 0x000139FB File Offset: 0x00011BFB
		// (set) Token: 0x06002A49 RID: 10825 RVA: 0x00013A08 File Offset: 0x00011C08
		[DefaultValue(true)]
		[Description("Show the bold button or not")]
		[Category("Appearance")]
		public bool ShowBold
		{
			get
			{
				return this.tbbBold.Visible;
			}
			set
			{
				this.tbbBold.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06002A4A RID: 10826 RVA: 0x00013A1C File Offset: 0x00011C1C
		// (set) Token: 0x06002A4B RID: 10827 RVA: 0x00013A29 File Offset: 0x00011C29
		[Description("Show the italic button or not")]
		[DefaultValue(true)]
		[Category("Appearance")]
		public bool ShowItalic
		{
			get
			{
				return this.tbbItalic.Visible;
			}
			set
			{
				this.tbbItalic.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06002A4C RID: 10828 RVA: 0x00013A3D File Offset: 0x00011C3D
		// (set) Token: 0x06002A4D RID: 10829 RVA: 0x00013A4A File Offset: 0x00011C4A
		[DefaultValue(true)]
		[Description("Show the underline button or not")]
		[Category("Appearance")]
		public bool ShowUnderline
		{
			get
			{
				return this.tbbUnderline.Visible;
			}
			set
			{
				this.tbbUnderline.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06002A4E RID: 10830 RVA: 0x00013A5E File Offset: 0x00011C5E
		// (set) Token: 0x06002A4F RID: 10831 RVA: 0x00013A6B File Offset: 0x00011C6B
		[DefaultValue(true)]
		[Description("Show the strikeout button or not")]
		[Category("Appearance")]
		public bool ShowStrikeout
		{
			get
			{
				return this.tbbStrikeout.Visible;
			}
			set
			{
				this.tbbStrikeout.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06002A50 RID: 10832 RVA: 0x00013A7F File Offset: 0x00011C7F
		// (set) Token: 0x06002A51 RID: 10833 RVA: 0x00013A8C File Offset: 0x00011C8C
		[Category("Appearance")]
		[Description("Show the left justify button or not")]
		[DefaultValue(true)]
		public bool ShowLeftJustify
		{
			get
			{
				return this.tbbLeft.Visible;
			}
			set
			{
				this.tbbLeft.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06002A52 RID: 10834 RVA: 0x00013AA0 File Offset: 0x00011CA0
		// (set) Token: 0x06002A53 RID: 10835 RVA: 0x00013AAD File Offset: 0x00011CAD
		[Description("Show the right justify button or not")]
		[Category("Appearance")]
		[DefaultValue(true)]
		public bool ShowRightJustify
		{
			get
			{
				return this.tbbRight.Visible;
			}
			set
			{
				this.tbbRight.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06002A54 RID: 10836 RVA: 0x00013AC1 File Offset: 0x00011CC1
		// (set) Token: 0x06002A55 RID: 10837 RVA: 0x00013ACE File Offset: 0x00011CCE
		[DefaultValue(true)]
		[Category("Appearance")]
		[Description("Show the center justify button or not")]
		public bool ShowCenterJustify
		{
			get
			{
				return this.tbbCenter.Visible;
			}
			set
			{
				this.tbbCenter.Visible = value;
				this.method_1();
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06002A56 RID: 10838 RVA: 0x00013AE2 File Offset: 0x00011CE2
		// (set) Token: 0x06002A57 RID: 10839 RVA: 0x00013AEF File Offset: 0x00011CEF
		[Category("Appearance")]
		[Description("Show the font button or not")]
		[DefaultValue(true)]
		public bool ShowFont
		{
			get
			{
				return this.tbbFont.Visible;
			}
			set
			{
				this.tbbFont.Visible = value;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06002A58 RID: 10840 RVA: 0x00013AFD File Offset: 0x00011CFD
		// (set) Token: 0x06002A59 RID: 10841 RVA: 0x00013B0A File Offset: 0x00011D0A
		[DefaultValue(true)]
		[Description("Show the font size button or not")]
		[Category("Appearance")]
		public bool ShowFontSize
		{
			get
			{
				return this.tbbFontSize.Visible;
			}
			set
			{
				this.tbbFontSize.Visible = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06002A5A RID: 10842 RVA: 0x00013B18 File Offset: 0x00011D18
		// (set) Token: 0x06002A5B RID: 10843 RVA: 0x00013B25 File Offset: 0x00011D25
		[DefaultValue(true)]
		[Description("Show the cut button or not")]
		[Category("Appearance")]
		public bool ShowCut
		{
			get
			{
				return this.tbbCut.Visible;
			}
			set
			{
				this.tbbCut.Visible = value;
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06002A5C RID: 10844 RVA: 0x00013B33 File Offset: 0x00011D33
		// (set) Token: 0x06002A5D RID: 10845 RVA: 0x00013B40 File Offset: 0x00011D40
		[Description("Show the copy button or not")]
		[Category("Appearance")]
		[DefaultValue(true)]
		public bool ShowCopy
		{
			get
			{
				return this.tbbCopy.Visible;
			}
			set
			{
				this.tbbCopy.Visible = value;
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06002A5E RID: 10846 RVA: 0x00013B4E File Offset: 0x00011D4E
		// (set) Token: 0x06002A5F RID: 10847 RVA: 0x00013B5B File Offset: 0x00011D5B
		[Category("Appearance")]
		[DefaultValue(true)]
		[Description("Show the paste button or not")]
		public bool ShowPaste
		{
			get
			{
				return this.tbbPaste.Visible;
			}
			set
			{
				this.tbbPaste.Visible = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06002A60 RID: 10848 RVA: 0x00013B69 File Offset: 0x00011D69
		// (set) Token: 0x06002A61 RID: 10849 RVA: 0x00013B76 File Offset: 0x00011D76
		[Category("Behavior")]
		[DefaultValue(true)]
		[Description("Detect URLs with-in the RichTextBox")]
		public bool DetectURLs
		{
			get
			{
				return this.rtfBox.DetectUrls;
			}
			set
			{
				this.rtfBox.DetectUrls = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06002A62 RID: 10850 RVA: 0x00013B84 File Offset: 0x00011D84
		// (set) Token: 0x06002A63 RID: 10851 RVA: 0x00013B91 File Offset: 0x00011D91
		[DefaultValue(false)]
		[Category("Behavior")]
		[Description("Determines if the TAB key moves to the next control or enters a TAB character in the RichTextBox")]
		public bool AcceptsTab
		{
			get
			{
				return this.rtfBox.AcceptsTab;
			}
			set
			{
				this.rtfBox.AcceptsTab = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06002A64 RID: 10852 RVA: 0x00013B9F File Offset: 0x00011D9F
		// (set) Token: 0x06002A65 RID: 10853 RVA: 0x00013BAC File Offset: 0x00011DAC
		[DefaultValue(true)]
		[Category("Behavior")]
		[Description("Determines if auto word selection is enabled")]
		public bool AutoWordSelection
		{
			get
			{
				return this.rtfBox.AutoWordSelection;
			}
			set
			{
				this.rtfBox.AutoWordSelection = value;
			}
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000A3C98 File Offset: 0x000A1E98
		public void method_2(string fontFamily)
		{
			int selectionStart = this.rtfBox.SelectionStart;
			int selectionLength = this.rtfBox.SelectionLength;
			int num = 0;
			if (selectionLength <= 1 && this.rtfBox.SelectionFont != null)
			{
				this.rtfBox.SelectionFont = new Font(fontFamily, this.rtfBox.SelectionFont.Size, this.rtfBox.SelectionFont.Style);
				return;
			}
			this.richTextBox_0.Rtf = this.rtfBox.SelectedRtf;
			for (int i = 0; i < selectionLength; i++)
			{
				this.richTextBox_0.Select(num + i, 1);
				this.richTextBox_0.SelectionFont = new Font(fontFamily, this.richTextBox_0.SelectionFont.Size, this.richTextBox_0.SelectionFont.Style);
			}
			this.richTextBox_0.Select(num, selectionLength);
			this.rtfBox.SelectedRtf = this.richTextBox_0.SelectedRtf;
			this.rtfBox.Select(selectionStart, selectionLength);
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x000A3D94 File Offset: 0x000A1F94
		public void method_3(FontStyle style, bool add)
		{
			if (style != FontStyle.Bold && style != FontStyle.Italic && style != FontStyle.Strikeout && style != FontStyle.Underline)
			{
				throw new InvalidProgramException("Invalid style parameter to ChangeFontStyle");
			}
			int selectionStart = this.rtfBox.SelectionStart;
			int selectionLength = this.rtfBox.SelectionLength;
			int num = 0;
			if (selectionLength > 1 || this.rtfBox.SelectionFont == null)
			{
				this.richTextBox_0.Rtf = this.rtfBox.SelectedRtf;
				for (int i = 0; i < selectionLength; i++)
				{
					this.richTextBox_0.Select(num + i, 1);
					if (add)
					{
						this.richTextBox_0.SelectionFont = new Font(this.richTextBox_0.SelectionFont, this.richTextBox_0.SelectionFont.Style | style);
					}
					else
					{
						this.richTextBox_0.SelectionFont = new Font(this.richTextBox_0.SelectionFont, this.richTextBox_0.SelectionFont.Style & ~style);
					}
				}
				this.richTextBox_0.Select(num, selectionLength);
				this.rtfBox.SelectedRtf = this.richTextBox_0.SelectedRtf;
				this.rtfBox.Select(selectionStart, selectionLength);
				return;
			}
			if (add)
			{
				this.rtfBox.SelectionFont = new Font(this.rtfBox.SelectionFont, this.rtfBox.SelectionFont.Style | style);
				return;
			}
			this.rtfBox.SelectionFont = new Font(this.rtfBox.SelectionFont, this.rtfBox.SelectionFont.Style & ~style);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000A3F08 File Offset: 0x000A2108
		public void method_4(float fontSize)
		{
			if ((double)fontSize <= 0.0)
			{
				throw new InvalidProgramException("Invalid font size parameter to ChangeFontSize");
			}
			int selectionStart = this.rtfBox.SelectionStart;
			int selectionLength = this.rtfBox.SelectionLength;
			int num = 0;
			if (selectionLength <= 1 && this.rtfBox.SelectionFont != null)
			{
				this.rtfBox.SelectionFont = new Font(this.rtfBox.SelectionFont.FontFamily, fontSize, this.rtfBox.SelectionFont.Style);
				return;
			}
			this.richTextBox_0.Rtf = this.rtfBox.SelectedRtf;
			for (int i = 0; i < selectionLength; i++)
			{
				this.richTextBox_0.Select(num + i, 1);
				this.richTextBox_0.SelectionFont = new Font(this.richTextBox_0.SelectionFont.FontFamily, fontSize, this.richTextBox_0.SelectionFont.Style);
			}
			this.richTextBox_0.Select(num, selectionLength);
			this.rtfBox.SelectedRtf = this.richTextBox_0.SelectedRtf;
			this.rtfBox.Select(selectionStart, selectionLength);
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000A401C File Offset: 0x000A221C
		public void method_5(Color newColor)
		{
			int selectionStart = this.rtfBox.SelectionStart;
			int selectionLength = this.rtfBox.SelectionLength;
			int num = 0;
			if (selectionLength <= 1 && this.rtfBox.SelectionFont != null)
			{
				this.rtfBox.SelectionColor = newColor;
				return;
			}
			this.richTextBox_0.Rtf = this.rtfBox.SelectedRtf;
			for (int i = 0; i < selectionLength; i++)
			{
				this.richTextBox_0.Select(num + i, 1);
				this.richTextBox_0.SelectionColor = newColor;
			}
			this.richTextBox_0.Select(num, selectionLength);
			this.rtfBox.SelectedRtf = this.richTextBox_0.SelectedRtf;
			this.rtfBox.Select(selectionStart, selectionLength);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000A40D0 File Offset: 0x000A22D0
		public Font method_6()
		{
			int selectionLength = this.rtfBox.SelectionLength;
			int num = 0;
			if (selectionLength > 1)
			{
				this.richTextBox_0.Rtf = this.rtfBox.SelectedRtf;
				this.richTextBox_0.Select(num, 1);
				string text = this.richTextBox_0.SelectionFont.Name;
				float num2 = this.richTextBox_0.SelectionFont.Size;
				FontStyle fontStyle = (FontStyle.Bold | FontStyle.Italic | FontStyle.Underline | FontStyle.Strikeout) & this.richTextBox_0.SelectionFont.Style;
				for (int i = 1; i < selectionLength; i++)
				{
					this.richTextBox_0.Select(num + i, 1);
					fontStyle &= this.richTextBox_0.SelectionFont.Style;
					if (text != this.richTextBox_0.SelectionFont.FontFamily.Name)
					{
						text = "";
					}
					if (num2 != this.richTextBox_0.SelectionFont.Size)
					{
						num2 = 0f;
					}
				}
				if (text == "")
				{
					text = this.richTextBox_0.Font.FontFamily.Name;
				}
				if ((double)num2 == 0.0)
				{
					num2 = this.richTextBox_0.Font.Size;
				}
				return new Font(text, num2, fontStyle);
			}
			if (this.rtfBox.SelectionFont != null)
			{
				return this.rtfBox.SelectionFont;
			}
			return this.rtfBox.Font;
		}

		// Token: 0x04001625 RID: 5669
		private IContainer icontainer_0;

		// Token: 0x04001626 RID: 5670
		private ToolBarButton tbbSeparator5;

		// Token: 0x04001627 RID: 5671
		private ToolBar tbMain;

		// Token: 0x04001628 RID: 5672
		private ToolBarButton tbbSave;

		// Token: 0x04001629 RID: 5673
		private ToolBarButton tbbOpen;

		// Token: 0x0400162A RID: 5674
		private ToolBarButton tbbSeparator3;

		// Token: 0x0400162B RID: 5675
		private ToolBarButton tbbFont;

		// Token: 0x0400162C RID: 5676
		private ContextMenu contextMenu_0;

		// Token: 0x0400162D RID: 5677
		private MenuItem menuItem_0;

		// Token: 0x0400162E RID: 5678
		private MenuItem menuItem_1;

		// Token: 0x0400162F RID: 5679
		private MenuItem menuItem_2;

		// Token: 0x04001630 RID: 5680
		private MenuItem menuItem_3;

		// Token: 0x04001631 RID: 5681
		private MenuItem menuItem_4;

		// Token: 0x04001632 RID: 5682
		private MenuItem menuItem_5;

		// Token: 0x04001633 RID: 5683
		private MenuItem menuItem_6;

		// Token: 0x04001634 RID: 5684
		private ToolBarButton tbbFontSize;

		// Token: 0x04001635 RID: 5685
		private ContextMenu contextMenu_1;

		// Token: 0x04001636 RID: 5686
		private MenuItem menuItem_7;

		// Token: 0x04001637 RID: 5687
		private MenuItem menuItem_8;

		// Token: 0x04001638 RID: 5688
		private MenuItem menuItem_9;

		// Token: 0x04001639 RID: 5689
		private MenuItem menuItem_10;

		// Token: 0x0400163A RID: 5690
		private MenuItem menuItem_11;

		// Token: 0x0400163B RID: 5691
		private MenuItem menuItem_12;

		// Token: 0x0400163C RID: 5692
		private MenuItem menuItem_13;

		// Token: 0x0400163D RID: 5693
		private MenuItem menuItem_14;

		// Token: 0x0400163E RID: 5694
		private MenuItem menuItem_15;

		// Token: 0x0400163F RID: 5695
		private MenuItem menuItem_16;

		// Token: 0x04001640 RID: 5696
		private MenuItem menuItem_17;

		// Token: 0x04001641 RID: 5697
		private MenuItem menuItem_18;

		// Token: 0x04001642 RID: 5698
		private MenuItem menuItem_19;

		// Token: 0x04001643 RID: 5699
		private MenuItem menuItem_20;

		// Token: 0x04001644 RID: 5700
		private MenuItem menuItem_21;

		// Token: 0x04001645 RID: 5701
		private MenuItem menuItem_22;

		// Token: 0x04001646 RID: 5702
		private ToolBarButton tbbColor;

		// Token: 0x04001647 RID: 5703
		private ContextMenu contextMenu_2;

		// Token: 0x04001648 RID: 5704
		private MenuItem menuItem_23;

		// Token: 0x04001649 RID: 5705
		private MenuItem menuItem_24;

		// Token: 0x0400164A RID: 5706
		private MenuItem menuItem_25;

		// Token: 0x0400164B RID: 5707
		private MenuItem menuItem_26;

		// Token: 0x0400164C RID: 5708
		private MenuItem menuItem_27;

		// Token: 0x0400164D RID: 5709
		private MenuItem menuItem_28;

		// Token: 0x0400164E RID: 5710
		private MenuItem menuItem_29;

		// Token: 0x0400164F RID: 5711
		private MenuItem menuItem_30;

		// Token: 0x04001650 RID: 5712
		private MenuItem menuItem_31;

		// Token: 0x04001651 RID: 5713
		private ToolBarButton tbbBold;

		// Token: 0x04001652 RID: 5714
		private ToolBarButton tbbItalic;

		// Token: 0x04001653 RID: 5715
		private ToolBarButton tbbUnderline;

		// Token: 0x04001654 RID: 5716
		private ToolBarButton tbbStrikeout;

		// Token: 0x04001655 RID: 5717
		private ToolBarButton tbbSeparator1;

		// Token: 0x04001656 RID: 5718
		private ToolBarButton tbbLeft;

		// Token: 0x04001657 RID: 5719
		private ToolBarButton tbbCenter;

		// Token: 0x04001658 RID: 5720
		private ToolBarButton tbbRight;

		// Token: 0x04001659 RID: 5721
		private ToolBarButton tbbSeparator2;

		// Token: 0x0400165A RID: 5722
		private ToolBarButton tbbUndo;

		// Token: 0x0400165B RID: 5723
		private ToolBarButton tbbRedo;

		// Token: 0x0400165C RID: 5724
		private ToolBarButton tbbSeparator4;

		// Token: 0x0400165D RID: 5725
		private ToolBarButton tbbCut;

		// Token: 0x0400165E RID: 5726
		private ToolBarButton tbbCopy;

		// Token: 0x0400165F RID: 5727
		private ToolBarButton tbbPaste;

		// Token: 0x04001660 RID: 5728
		private ImageList imageList_0;

		// Token: 0x04001661 RID: 5729
		private RichTextBox rtfBox;

		// Token: 0x04001662 RID: 5730
		private ColorDialog colorDialog_0;

		// Token: 0x04001663 RID: 5731
		private OpenFileDialog openFileDialog_0;

		// Token: 0x04001664 RID: 5732
		private SaveFileDialog saveFileDialog_0;

		// Token: 0x04001665 RID: 5733
		private ToolTip toolTip_0;

		// Token: 0x04001666 RID: 5734
		private RichTextBox richTextBox_0 = new RichTextBox();

		// Token: 0x04001667 RID: 5735
		private EventHandler eventHandler_0;

		// Token: 0x04001668 RID: 5736
		private EventHandler eventHandler_1;
	}
}
