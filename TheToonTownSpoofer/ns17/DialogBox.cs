using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ns14;
using ns16;
using ns18;
using ns19;
using ns23;
using ns24;
using ns27;
using ns29;
using ns31;
using TSN.Drawing;
using TSN.IO;

namespace ns17
{
	// Token: 0x0200027D RID: 637
	internal sealed partial class DialogBox : Form0
	{
		// Token: 0x06001AAD RID: 6829 RVA: 0x0004E7CC File Offset: 0x0004C9CC
		public static void smethod_2(string text, string caption, Enum121 position)
		{
			Enum90 dialogType = Enum90.const_0;
			bool enabledCloseButton = true;
			Enum39[] buttons = new Enum39[1];
			DialogBox.smethod_13(text, caption, dialogType, enabledCloseButton, position, buttons);
		}

		// Token: 0x06001AAE RID: 6830 RVA: 0x0004E7EC File Offset: 0x0004C9EC
		public static void smethod_3(string text, string caption)
		{
			Enum90 dialogType = Enum90.const_0;
			Enum39[] buttons = new Enum39[1];
			DialogBox.smethod_11(text, caption, dialogType, buttons);
		}

		// Token: 0x06001AAF RID: 6831 RVA: 0x0004E80C File Offset: 0x0004CA0C
		public static void smethod_4(string text, string caption)
		{
			Enum90 dialogType = Enum90.const_3;
			Enum39[] buttons = new Enum39[1];
			DialogBox.smethod_11(text, caption, dialogType, buttons);
		}

		// Token: 0x06001AB0 RID: 6832 RVA: 0x00009984 File Offset: 0x00007B84
		public static DialogResult smethod_5(string text, string caption, params Enum39[] buttons)
		{
			return DialogBox.smethod_11(text, caption, Enum90.const_3, buttons);
		}

		// Token: 0x06001AB1 RID: 6833 RVA: 0x0000998F File Offset: 0x00007B8F
		public static DialogResult smethod_6(string text, string caption, params Enum39[] buttons)
		{
			return DialogBox.smethod_12(text, caption, Enum90.const_1, true, buttons);
		}

		// Token: 0x06001AB2 RID: 6834 RVA: 0x0004E82C File Offset: 0x0004CA2C
		public static void smethod_7(Exception ex, string path)
		{
			if (path == null)
			{
				path = string.Empty;
			}
			Type type = ex.GetType();
			if (type == typeof(InvalidFileType))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_19, new object[]
				{
					path
				}), DialogBox.string_20);
				return;
			}
			if (type == typeof(ArgumentNullException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_15, new object[]
				{
					ex.Message
				}), DialogBox.string_16);
				return;
			}
			if (type == typeof(ArgumentException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_13, new object[]
				{
					ex.Message
				}), DialogBox.string_14);
				return;
			}
			if (type == typeof(WebException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, "There has been a exception while downloading: '{0}'. '{1}'", new object[]
				{
					path,
					ex.Message
				}), "Error downloading");
				return;
			}
			if (type == typeof(PathTooLongException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_3, new object[]
				{
					path
				}), DialogBox.string_4);
				return;
			}
			if (type == typeof(DirectoryNotFoundException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_5, new object[]
				{
					Path.GetDirectoryName(path)
				}), DialogBox.string_6);
				return;
			}
			if (type == typeof(IOException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_7, new object[]
				{
					ex.Message
				}), DialogBox.string_8);
				return;
			}
			if (type == typeof(NotSupportedException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_9, new object[]
				{
					ex.Message
				}), DialogBox.string_10);
				return;
			}
			if (type == typeof(UnauthorizedAccessException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_11, new object[]
				{
					ex.Message
				}), DialogBox.string_12);
				return;
			}
			if (type == typeof(FileNotFoundException))
			{
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_1, new object[]
				{
					path
				}), DialogBox.string_2);
				return;
			}
			if (type == typeof(InvalidPixelFormatException))
			{
				InvalidPixelFormatException ex2 = ex as InvalidPixelFormatException;
				DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_0, new object[]
				{
					Path.GetFileName(path),
					ex2.PixelFormat.smethod_0()
				}), "Invalid Pixel Format");
				return;
			}
			DialogBox.smethod_4(string.Format(Class217.cultureInfo_0, DialogBox.string_17, new object[]
			{
				ex.Message
			}), DialogBox.string_18);
		}

		// Token: 0x06001AB3 RID: 6835 RVA: 0x0004EB40 File Offset: 0x0004CD40
		public static DialogResult smethod_8(string title)
		{
			return DialogBox.smethod_6(string.Format(Class217.cultureInfo_0, DialogBox.string_21, new object[]
			{
				title
			}), DialogBox.string_22, new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			});
		}

		// Token: 0x06001AB4 RID: 6836 RVA: 0x0004EB84 File Offset: 0x0004CD84
		public static DialogResult smethod_9(string message, string title, Enum90 dialogType)
		{
			bool enabledCloseButton = true;
			Enum121 position = Enum121.const_0;
			Enum39[] buttons = new Enum39[1];
			return DialogBox.smethod_13(message, title, dialogType, enabledCloseButton, position, buttons);
		}

		// Token: 0x06001AB5 RID: 6837 RVA: 0x0004EBA4 File Offset: 0x0004CDA4
		public static DialogResult smethod_10(string message, string title, Enum90 dialogType, bool enabledCloseButton)
		{
			Enum121 position = Enum121.const_0;
			Enum39[] buttons = new Enum39[1];
			return DialogBox.smethod_13(message, title, dialogType, enabledCloseButton, position, buttons);
		}

		// Token: 0x06001AB6 RID: 6838 RVA: 0x0000999B File Offset: 0x00007B9B
		public static DialogResult smethod_11(string message, string title, Enum90 dialogType, params Enum39[] buttons)
		{
			return DialogBox.smethod_13(message, title, dialogType, true, Enum121.const_0, buttons);
		}

		// Token: 0x06001AB7 RID: 6839 RVA: 0x000099A8 File Offset: 0x00007BA8
		public static DialogResult smethod_12(string message, string title, Enum90 dialogType, bool enabledCloseButton, params Enum39[] buttons)
		{
			return DialogBox.smethod_13(message, title, dialogType, enabledCloseButton, Enum121.const_0, buttons);
		}

		// Token: 0x06001AB8 RID: 6840 RVA: 0x0004EBC4 File Offset: 0x0004CDC4
		public static DialogResult smethod_13(string message, string title, Enum90 dialogType, bool enabledCloseButton, Enum121 position, params Enum39[] buttons)
		{
			DialogResult result;
			using (DialogBox dialogBox = new DialogBox(message, title, dialogType, null, enabledCloseButton, position, buttons))
			{
				result = dialogBox.ShowDialog();
			}
			return result;
		}

		// Token: 0x06001AB9 RID: 6841 RVA: 0x0004EC04 File Offset: 0x0004CE04
		public DialogBox(string message, string title, Enum90 dialogType, Font font, bool enabledCloseButton, Enum121 position, params Enum39[] buttons)
		{
			EventHandler eventHandler = null;
			EventHandler eventHandler2 = null;
			EventHandler eventHandler3 = null;
			EventHandler eventHandler4 = null;
			EventHandler eventHandler5 = null;
			EventHandler eventHandler6 = null;
			EventHandler eventHandler7 = null;
			EventHandler eventHandler8 = null;
			DialogBox.Class218 @class = new DialogBox.Class218();
			@class.enum90_0 = dialogType;
			base..ctor(enabledCloseButton);
			@class.dialogBox_0 = this;
			if (message == null)
			{
				throw new ArgumentNullException("message");
			}
			if (title == null)
			{
				throw new ArgumentNullException("title");
			}
			if (buttons == null)
			{
				throw new ArgumentNullException("buttons");
			}
			if (buttons.Length == 0)
			{
				throw new ArgumentException("Must have at least one dialog box button.");
			}
			@class.enum90_0.smethod_0();
			position.smethod_0();
			foreach (Enum39 @enum in buttons)
			{
				@enum.smethod_0();
			}
			this.InitializeComponent();
			this.Text = title;
			this.Message.Text = message;
			if (font != null)
			{
				this.Message.Font = font;
			}
			Rectangle workingArea = Screen.GetWorkingArea(Cursor.Position);
			this.IconImage.StaticImage = true;
			this.IconImage.AnimationInterval = 25;
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(DialogBox));
			switch (@class.enum90_0)
			{
			case Enum90.const_0:
				this.IconImage.BaseImage = (Image)componentResourceManager.GetObject("InformationBubbleBitmap");
				base.Icon = (Icon)componentResourceManager.GetObject("InformationBubbleIcon");
				break;
			case Enum90.const_1:
				this.IconImage.BaseImage = (Image)componentResourceManager.GetObject("QuestionBubbleBitmap");
				base.Icon = (Icon)componentResourceManager.GetObject("QuestionBubbleIcon");
				break;
			case Enum90.const_2:
				this.IconImage.BaseImage = (Image)componentResourceManager.GetObject("WarningBubbleBitmap");
				base.Icon = (Icon)componentResourceManager.GetObject("WarningBubbleIcon");
				break;
			case Enum90.const_3:
				this.IconImage.BaseImage = (Image)componentResourceManager.GetObject("ErrorBubbleBitmap");
				base.Icon = (Icon)componentResourceManager.GetObject("ErrorBubbleIcon");
				break;
			}
			this.IconImage.method_0();
			Button button = null;
			this.LayoutPanel.SuspendLayout();
			Button button2 = null;
			Button button3 = null;
			for (int j = 0; j < buttons.Length; j++)
			{
				Enum39 enum2 = buttons[j];
				try
				{
					button = new Button();
					button.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
					button.Location = new Point(0, 0);
					button.Margin = new Padding(0, 0, (j < buttons.Length - 1) ? 3 : 0, 0);
					button.UseVisualStyleBackColor = true;
					button.Size = new Size(75, 23);
					button.TabIndex = j;
					switch (enum2)
					{
					case Enum39.const_0:
					{
						if (button2 == null)
						{
							button2 = button;
						}
						button.Text = "OK";
						Control control = button;
						if (eventHandler == null)
						{
							eventHandler = new EventHandler(this.method_1);
						}
						control.Click += eventHandler;
						break;
					}
					case Enum39.const_1:
					{
						if (button3 == null)
						{
							button3 = button;
						}
						button.Text = "Cancel";
						Control control2 = button;
						if (eventHandler3 == null)
						{
							eventHandler3 = new EventHandler(this.method_3);
						}
						control2.Click += eventHandler3;
						break;
					}
					case Enum39.const_2:
					{
						if (button3 == null)
						{
							button3 = button;
						}
						button.Text = "Abort";
						Control control3 = button;
						if (eventHandler2 == null)
						{
							eventHandler2 = new EventHandler(this.method_2);
						}
						control3.Click += eventHandler2;
						break;
					}
					case Enum39.const_3:
					{
						button.Text = "Retry";
						Control control4 = button;
						if (eventHandler6 == null)
						{
							eventHandler6 = new EventHandler(this.method_6);
						}
						control4.Click += eventHandler6;
						break;
					}
					case Enum39.const_4:
					{
						button.Text = "Ignore";
						Control control5 = button;
						if (eventHandler4 == null)
						{
							eventHandler4 = new EventHandler(this.method_4);
						}
						control5.Click += eventHandler4;
						break;
					}
					case Enum39.const_5:
					{
						if (button2 == null)
						{
							button2 = button;
						}
						button.Text = "Yes";
						Control control6 = button;
						if (eventHandler7 == null)
						{
							eventHandler7 = new EventHandler(this.method_7);
						}
						control6.Click += eventHandler7;
						break;
					}
					case Enum39.const_6:
					{
						button.Text = "No";
						Control control7 = button;
						if (eventHandler5 == null)
						{
							eventHandler5 = new EventHandler(this.method_5);
						}
						control7.Click += eventHandler5;
						break;
					}
					}
					this.LayoutPanel.Controls.Add(button);
				}
				catch
				{
					if (button != null)
					{
						button.Dispose();
					}
					throw;
				}
			}
			this.LayoutPanel.ResumeLayout(true);
			if (button2 != null)
			{
				base.AcceptButton = button2;
			}
			if (button3 != null)
			{
				base.CancelButton = button3;
			}
			int num = SystemInformation.FixedFrameBorderSize.Width * 2;
			int num2 = SystemInformation.FixedFrameBorderSize.Height * 2;
			int val = 24 + this.LayoutPanel.Height + 6 + this.IconImage.Height + num2 + SystemInformation.CaptionHeight;
			int val2 = 24 + this.LayoutPanel.Width + 6 + this.IconImage.Width + num;
			int width = (int)((double)(workingArea.Width - num - this.IconImage.Width - 6 - 24) * 0.6);
			int num3 = (int)((double)(workingArea.Height - num2 - SystemInformation.CaptionHeight - this.LayoutPanel.Height - 6 - 24) * 0.9);
			Size preferredSize = this.Message.GetPreferredSize(new Size(width, num3));
			base.Size = new Size(Math.Max(val2, num + 24 + this.IconImage.Width + 6 + preferredSize.Width), Math.Max(val, Math.Min(num2 + SystemInformation.CaptionHeight + 6 + 24 + this.LayoutPanel.Height + preferredSize.Height, num3)));
			this.LayoutPanel.Location = new Point(this.MainPanel.Width / 2 - this.LayoutPanel.Width / 2, this.LayoutPanel.Location.Y);
			if (eventHandler8 == null)
			{
				eventHandler8 = new EventHandler(@class.method_0);
			}
			base.Load += eventHandler8;
			switch (position)
			{
			case Enum121.const_0:
				base.StartPosition = FormStartPosition.CenterScreen;
				return;
			case Enum121.const_1:
				base.StartPosition = FormStartPosition.Manual;
				base.Location = new Point(workingArea.Width / 2 - base.Width / 2 + workingArea.X, workingArea.Height - base.Height + workingArea.Y - (int)((double)workingArea.Height * 0.05));
				return;
			case Enum121.const_2:
				base.StartPosition = FormStartPosition.CenterParent;
				return;
			default:
				return;
			}
		}

		// Token: 0x06001ABC RID: 6844 RVA: 0x00005870 File Offset: 0x00003A70
		[CompilerGenerated]
		private void method_1(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			base.Close();
		}

		// Token: 0x06001ABD RID: 6845 RVA: 0x000099D5 File Offset: 0x00007BD5
		[CompilerGenerated]
		private void method_2(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Abort;
			base.Close();
		}

		// Token: 0x06001ABE RID: 6846 RVA: 0x0000587F File Offset: 0x00003A7F
		[CompilerGenerated]
		private void method_3(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			base.Close();
		}

		// Token: 0x06001ABF RID: 6847 RVA: 0x000099E4 File Offset: 0x00007BE4
		[CompilerGenerated]
		private void method_4(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Ignore;
			base.Close();
		}

		// Token: 0x06001AC0 RID: 6848 RVA: 0x000099F3 File Offset: 0x00007BF3
		[CompilerGenerated]
		private void method_5(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.No;
			base.Close();
		}

		// Token: 0x06001AC1 RID: 6849 RVA: 0x00009A02 File Offset: 0x00007C02
		[CompilerGenerated]
		private void method_6(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Retry;
			base.Close();
		}

		// Token: 0x06001AC2 RID: 6850 RVA: 0x00009A11 File Offset: 0x00007C11
		[CompilerGenerated]
		private void method_7(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Yes;
			base.Close();
		}

		// Token: 0x04000818 RID: 2072
		private static readonly string string_0 = "The image '{0}' has an invalid pixel format of {1}.";

		// Token: 0x04000819 RID: 2073
		private static readonly string string_1 = "The file could not be found: '{0}'.";

		// Token: 0x0400081A RID: 2074
		private static readonly string string_2 = "File Not Found";

		// Token: 0x0400081B RID: 2075
		private static readonly string string_3 = "The path '{0}' is too long.";

		// Token: 0x0400081C RID: 2076
		private static readonly string string_4 = "Path too Long";

		// Token: 0x0400081D RID: 2077
		private static readonly string string_5 = "The directory '{0}' could not be found.";

		// Token: 0x0400081E RID: 2078
		private static readonly string string_6 = "Directory Not Found";

		// Token: 0x0400081F RID: 2079
		private static readonly string string_7 = "There was an IO error '{0}'.";

		// Token: 0x04000820 RID: 2080
		private static readonly string string_8 = "IO Error";

		// Token: 0x04000821 RID: 2081
		private static readonly string string_9 = "There has been an not supported exception '{0}'.";

		// Token: 0x04000822 RID: 2082
		private static readonly string string_10 = "Not Supported Error";

		// Token: 0x04000823 RID: 2083
		private static readonly string string_11 = "Access was denied by the operating system '{0}'.";

		// Token: 0x04000824 RID: 2084
		private static readonly string string_12 = "Access Denied";

		// Token: 0x04000825 RID: 2085
		private static readonly string string_13 = "There has been an argument exception '{0}'.";

		// Token: 0x04000826 RID: 2086
		private static readonly string string_14 = "Argument Error";

		// Token: 0x04000827 RID: 2087
		private static readonly string string_15 = "There has been an null argument exception '{0}'.";

		// Token: 0x04000828 RID: 2088
		private static readonly string string_16 = "Null Argument Error";

		// Token: 0x04000829 RID: 2089
		private static readonly string string_17 = "There has been an exception '{0}'.";

		// Token: 0x0400082A RID: 2090
		private static readonly string string_18 = "Error";

		// Token: 0x0400082B RID: 2091
		private static readonly string string_19 = "The file '{0}' appears to be an invalid type.";

		// Token: 0x0400082C RID: 2092
		private static readonly string string_20 = "Invalid File Type";

		// Token: 0x0400082D RID: 2093
		private static readonly string string_21 = "Are you sure you would like to delete '{0}'?";

		// Token: 0x0400082E RID: 2094
		private static readonly string string_22 = "Confirm Delete";

		// Token: 0x0200027E RID: 638
		[CompilerGenerated]
		private sealed class Class218
		{
			// Token: 0x06001AC5 RID: 6853 RVA: 0x0004F668 File Offset: 0x0004D868
			public void method_0(object sender, EventArgs e)
			{
				try
				{
					switch (this.enum90_0)
					{
					case Enum90.const_0:
						Class265.MessageBeep(Enum95.const_7);
						break;
					case Enum90.const_1:
						Class265.MessageBeep(Enum95.const_4);
						break;
					case Enum90.const_2:
						Class265.MessageBeep(Enum95.const_5);
						break;
					case Enum90.const_3:
						Class265.MessageBeep(Enum95.const_1);
						break;
					}
				}
				catch (Exception ex)
				{
					ex.smethod_0();
				}
			}

			// Token: 0x04000834 RID: 2100
			public DialogBox dialogBox_0;

			// Token: 0x04000835 RID: 2101
			public Enum90 enum90_0;
		}
	}
}
