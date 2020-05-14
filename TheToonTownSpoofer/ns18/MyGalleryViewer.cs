using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns16;
using ns17;
using ns20;
using ns22;
using ns23;
using ns26;
using ns27;
using ns31;

namespace ns18
{
	// Token: 0x02000299 RID: 665
	internal sealed partial class MyGalleryViewer : Form1
	{
		// Token: 0x1400017E RID: 382
		// (add) Token: 0x06001B6F RID: 7023 RVA: 0x0005579C File Offset: 0x0005399C
		// (remove) Token: 0x06001B70 RID: 7024 RVA: 0x000557D4 File Offset: 0x000539D4
		public event EventHandler ShowNextImage
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

		// Token: 0x1400017F RID: 383
		// (add) Token: 0x06001B71 RID: 7025 RVA: 0x0005580C File Offset: 0x00053A0C
		// (remove) Token: 0x06001B72 RID: 7026 RVA: 0x00055844 File Offset: 0x00053A44
		public event EventHandler ShowPreviousImage
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

		// Token: 0x06001B73 RID: 7027 RVA: 0x0005587C File Offset: 0x00053A7C
		public MyGalleryViewer()
		{
			this.InitializeComponent();
			this.class111_0 = Class110.Instance.MyGallerySettings;
			int num = base.Width - base.ClientSize.Width;
			int num2 = base.Height - base.ClientSize.Height;
			Rectangle workingArea = Screen.GetWorkingArea(Cursor.Position);
			int y = (int)((double)workingArea.Height * 0.02) + workingArea.Y;
			int num3 = workingArea.Height - (int)((double)workingArea.Height * 0.06) - 246;
			Size size = new Size((int)((float)workingArea.Width * 0.875f) - num, num3 - num2);
			float num4 = (float)size.Width / (float)size.Height;
			float num5 = 1.3333334f;
			if (num4 > num5)
			{
				base.Height = size.Height + num2;
				base.Width = (int)((float)size.Height * num5) + num;
			}
			else
			{
				base.Width = size.Width + num;
				base.Height = (int)((float)size.Width / num5) + num2;
			}
			base.Location = new Point(workingArea.Width / 2 - base.Width / 2 + workingArea.X, y);
			this.method_5();
			this.enum41_0 = MyGalleryViewer.Enum41.const_4;
			this.method_9(MyGalleryViewer.Enum41.const_0);
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000559DC File Offset: 0x00053BDC
		public void method_1(string imagePath)
		{
			this.string_0 = imagePath;
			ToolStripItem deleteImageButton = this.DeleteImageButton;
			this.CopyImageButton.Enabled = false;
			deleteImageButton.Enabled = false;
			if (string.IsNullOrEmpty(imagePath))
			{
				this.Text = "Screenshot Viewer";
			}
			else
			{
				this.Text = string.Format("Screenshot Viewer : {0}", Path.GetFileName(imagePath));
			}
			this.RendererControl.method_3(imagePath);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x0000A038 File Offset: 0x00008238
		private void method_2(object sender, EventArgs e)
		{
			ToolStripItem deleteImageButton = this.DeleteImageButton;
			this.CopyImageButton.Enabled = true;
			deleteImageButton.Enabled = true;
		}

		// Token: 0x06001B76 RID: 7030 RVA: 0x00055A40 File Offset: 0x00053C40
		private void CopyImageButton_Click(object sender, EventArgs e)
		{
			bool enabled;
			if (enabled = this.timer_1.Enabled)
			{
				this.timer_1.Stop();
			}
			this.saveFileDialog_0.FileName = Path.GetFileName(this.string_0);
			if (this.saveFileDialog_0.ShowDialog() == DialogResult.OK)
			{
				if (Class336.smethod_0(this.string_0, this.saveFileDialog_0.FileName))
				{
					DialogBox.smethod_3("Cannot overwrite the existing screenshot.", "Cannot Overwrite");
				}
				else
				{
					try
					{
						File.Copy(this.string_0, this.saveFileDialog_0.FileName);
					}
					catch (Exception ex)
					{
						ex.smethod_1(new object[]
						{
							string.Format("Src: '{0}' Dest: '{1}'", this.string_0, this.saveFileDialog_0.FileName)
						});
						DialogBox.smethod_7(ex, this.saveFileDialog_0.FileName);
					}
				}
			}
			if (enabled)
			{
				this.timer_1.Start();
			}
		}

		// Token: 0x06001B77 RID: 7031 RVA: 0x00055B30 File Offset: 0x00053D30
		private void DeleteImageButton_Click(object sender, EventArgs e)
		{
			bool enabled;
			if (enabled = this.timer_1.Enabled)
			{
				this.timer_1.Stop();
			}
			if (DialogBox.smethod_6("Are you sure you want to delete this screenshot?", "Delete Screenshot", new Enum39[]
			{
				Enum39.const_5,
				Enum39.const_6
			}) == DialogResult.Yes)
			{
				string text = this.string_0;
				this.method_1(null);
				try
				{
					File.Delete(text);
				}
				catch (Exception ex)
				{
					ex.smethod_1(new object[]
					{
						text
					});
					DialogBox.smethod_7(ex, text);
				}
			}
			if (enabled)
			{
				this.timer_1.Start();
			}
		}

		// Token: 0x06001B78 RID: 7032 RVA: 0x00055BCC File Offset: 0x00053DCC
		private void MyGalleryViewer_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			switch (e.KeyCode)
			{
			case Keys.Left:
			case Keys.Right:
				e.IsInputKey = true;
				break;
			case Keys.Up:
				break;
			default:
				return;
			}
		}

		// Token: 0x06001B79 RID: 7033 RVA: 0x00055C00 File Offset: 0x00053E00
		private void MyGalleryViewer_KeyDown(object sender, KeyEventArgs e)
		{
			Keys keyCode = e.KeyCode;
			if (keyCode != Keys.Escape)
			{
				switch (keyCode)
				{
				case Keys.Left:
					this.method_3();
					return;
				case Keys.Up:
					break;
				case Keys.Right:
					this.method_4();
					return;
				default:
					if (keyCode != Keys.F12)
					{
						return;
					}
					base.method_0(!base.FullScreen);
					this.FullScreenButton.Checked = base.FullScreen;
					break;
				}
				return;
			}
			base.Close();
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x0000A052 File Offset: 0x00008252
		private void PreviousImageButton_Click(object sender, EventArgs e)
		{
			this.timer_1.smethod_2();
			this.method_3();
		}

		// Token: 0x06001B7B RID: 7035 RVA: 0x0000A065 File Offset: 0x00008265
		private void NextImageButton_Click(object sender, EventArgs e)
		{
			this.timer_1.smethod_2();
			this.method_4();
		}

		// Token: 0x06001B7C RID: 7036 RVA: 0x0000A078 File Offset: 0x00008278
		private void method_3()
		{
			if (this.eventHandler_1 != null)
			{
				this.eventHandler_1(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001B7D RID: 7037 RVA: 0x0000A093 File Offset: 0x00008293
		private void method_4()
		{
			if (this.eventHandler_0 != null)
			{
				this.eventHandler_0(this, EventArgs.Empty);
			}
		}

		// Token: 0x06001B7E RID: 7038 RVA: 0x0000A0AE File Offset: 0x000082AE
		private void StretchMenuItem_Click(object sender, EventArgs e)
		{
			this.class111_0.ScreenshotScaling = Enum24.const_0;
			this.method_5();
			this.RendererControl.method_4();
		}

		// Token: 0x06001B7F RID: 7039 RVA: 0x0000A0CD File Offset: 0x000082CD
		private void MaintainAspectRatioMenuItem_Click(object sender, EventArgs e)
		{
			this.class111_0.ScreenshotScaling = Enum24.const_1;
			this.method_5();
			this.RendererControl.method_4();
		}

		// Token: 0x06001B80 RID: 7040 RVA: 0x0000A0EC File Offset: 0x000082EC
		private void MaintainAspectRatioAndStretchMenuItem_Click(object sender, EventArgs e)
		{
			this.class111_0.ScreenshotScaling = Enum24.const_2;
			this.method_5();
			this.RendererControl.method_4();
		}

		// Token: 0x06001B81 RID: 7041 RVA: 0x00055C6C File Offset: 0x00053E6C
		private void method_5()
		{
			this.MaintainAspectRatioMenuItem.Checked = false;
			this.StretchMenuItem.Checked = false;
			this.MaintainAspectRatioAndStretchMenuItem.Checked = false;
			switch (this.class111_0.ScreenshotScaling)
			{
			case Enum24.const_0:
				this.StretchMenuItem.Checked = true;
				return;
			case Enum24.const_1:
				this.MaintainAspectRatioMenuItem.Checked = true;
				return;
			case Enum24.const_2:
				this.MaintainAspectRatioAndStretchMenuItem.Checked = true;
				return;
			default:
				return;
			}
		}

		// Token: 0x06001B82 RID: 7042 RVA: 0x0000A10B File Offset: 0x0000830B
		private void method_6()
		{
			if (this.bool_1)
			{
				Cursor.Show();
				this.bool_1 = false;
			}
		}

		// Token: 0x06001B83 RID: 7043 RVA: 0x0000A121 File Offset: 0x00008321
		private void method_7()
		{
			if (!this.bool_1)
			{
				Cursor.Hide();
				this.bool_1 = true;
			}
		}

		// Token: 0x06001B84 RID: 7044 RVA: 0x0000A137 File Offset: 0x00008337
		private void RendererControl_MouseEnter(object sender, EventArgs e)
		{
			this.method_9(MyGalleryViewer.Enum41.const_3);
		}

		// Token: 0x06001B85 RID: 7045 RVA: 0x00055CE4 File Offset: 0x00053EE4
		private void RendererControl_MouseLeave(object sender, EventArgs e)
		{
			bool flag = this.ImageToolStrip.ClientRectangle.Contains(this.ImageToolStrip.PointToClient(Control.MousePosition));
			bool flag2 = this.RendererControl.ClientRectangle.Contains(this.RendererControl.PointToClient(Control.MousePosition));
			if (!flag && !flag2)
			{
				this.method_9(MyGalleryViewer.Enum41.const_0);
				this.method_6();
			}
		}

		// Token: 0x06001B86 RID: 7046 RVA: 0x00055D4C File Offset: 0x00053F4C
		private void RendererControl_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.nullable_0 != null && this.nullable_0 != Control.MousePosition)
			{
				this.nullable_0 = null;
			}
			this.method_8();
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00055DA0 File Offset: 0x00053FA0
		private void method_8()
		{
			if (this.nullable_0 == null)
			{
				this.nullable_0 = new Point?(Control.MousePosition);
				switch (this.enum41_0)
				{
				case MyGalleryViewer.Enum41.const_0:
				case MyGalleryViewer.Enum41.const_4:
					if (this.RendererControl.ClientRectangle.Contains(this.RendererControl.PointToClient(Control.MousePosition)))
					{
						this.method_9(MyGalleryViewer.Enum41.const_0);
						return;
					}
					break;
				case MyGalleryViewer.Enum41.const_1:
				case MyGalleryViewer.Enum41.const_2:
					this.method_9(MyGalleryViewer.Enum41.const_3);
					break;
				case MyGalleryViewer.Enum41.const_3:
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x00055E24 File Offset: 0x00054024
		private void timer_0_Tick(object sender, EventArgs e)
		{
			switch (this.enum41_0)
			{
			case MyGalleryViewer.Enum41.const_0:
				this.method_9(MyGalleryViewer.Enum41.const_1);
				return;
			case MyGalleryViewer.Enum41.const_1:
				if (this.ImageToolStrip.Bottom > 0)
				{
					this.ImageToolStrip.Location = new Point(0, this.ImageToolStrip.Location.Y - 1);
					this.RendererControl.method_0();
					this.RendererControl.Location = new Point(0, this.RendererControl.Location.Y - 1);
					this.RendererControl.Height++;
					this.RendererControl.method_1();
					return;
				}
				this.method_9(MyGalleryViewer.Enum41.const_2);
				return;
			case MyGalleryViewer.Enum41.const_3:
				if (this.ImageToolStrip.Bottom < this.ImageToolStrip.Height)
				{
					this.ImageToolStrip.Location = new Point(0, this.ImageToolStrip.Location.Y + 1);
					this.RendererControl.method_0();
					this.RendererControl.Location = new Point(0, this.RendererControl.Location.Y + 1);
					this.RendererControl.Height--;
					this.RendererControl.method_1();
					return;
				}
				this.method_9(MyGalleryViewer.Enum41.const_4);
				return;
			}
			this.timer_0.Enabled = false;
		}

		// Token: 0x06001B89 RID: 7049 RVA: 0x00055F8C File Offset: 0x0005418C
		private void method_9(MyGalleryViewer.Enum41 newState)
		{
			switch (newState)
			{
			case MyGalleryViewer.Enum41.const_0:
				switch (this.enum41_0)
				{
				case MyGalleryViewer.Enum41.const_0:
					this.timer_0.Stop();
					this.timer_0.Start();
					break;
				case MyGalleryViewer.Enum41.const_1:
				case MyGalleryViewer.Enum41.const_2:
					break;
				case MyGalleryViewer.Enum41.const_3:
					this.enum41_0 = MyGalleryViewer.Enum41.const_1;
					this.timer_0.Interval = MyGalleryViewer.int_0;
					this.timer_0.Enabled = true;
					return;
				case MyGalleryViewer.Enum41.const_4:
					this.enum41_0 = newState;
					this.timer_0.Interval = MyGalleryViewer.int_1;
					this.timer_0.Enabled = true;
					return;
				default:
					return;
				}
				break;
			case MyGalleryViewer.Enum41.const_1:
				switch (this.enum41_0)
				{
				case MyGalleryViewer.Enum41.const_0:
				case MyGalleryViewer.Enum41.const_3:
				case MyGalleryViewer.Enum41.const_4:
					this.enum41_0 = newState;
					this.timer_0.Interval = MyGalleryViewer.int_0;
					this.timer_0.Enabled = true;
					return;
				case MyGalleryViewer.Enum41.const_1:
				case MyGalleryViewer.Enum41.const_2:
					break;
				default:
					return;
				}
				break;
			case MyGalleryViewer.Enum41.const_2:
			{
				MyGalleryViewer.Enum41 @enum = this.enum41_0;
				if (@enum != MyGalleryViewer.Enum41.const_1)
				{
					return;
				}
				this.enum41_0 = newState;
				this.timer_0.Enabled = false;
				if (this.RendererControl.ClientRectangle.Contains(this.RendererControl.PointToClient(Control.MousePosition)))
				{
					this.method_7();
					return;
				}
				break;
			}
			case MyGalleryViewer.Enum41.const_3:
				switch (this.enum41_0)
				{
				case MyGalleryViewer.Enum41.const_0:
					this.enum41_0 = MyGalleryViewer.Enum41.const_4;
					this.timer_0.Enabled = false;
					return;
				case MyGalleryViewer.Enum41.const_1:
				case MyGalleryViewer.Enum41.const_2:
					this.method_6();
					this.enum41_0 = newState;
					this.timer_0.Interval = MyGalleryViewer.int_0;
					this.timer_0.Enabled = true;
					return;
				default:
					return;
				}
				break;
			case MyGalleryViewer.Enum41.const_4:
			{
				MyGalleryViewer.Enum41 enum2 = this.enum41_0;
				if (enum2 != MyGalleryViewer.Enum41.const_3)
				{
					return;
				}
				this.enum41_0 = newState;
				this.timer_0.Enabled = false;
				this.nullable_0 = null;
				this.method_8();
				return;
			}
			default:
				return;
			}
		}

		// Token: 0x06001B8A RID: 7050 RVA: 0x0000A140 File Offset: 0x00008340
		private void MyGalleryViewer_Deactivate(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x0000A140 File Offset: 0x00008340
		private void MyGalleryViewer_Resize(object sender, EventArgs e)
		{
			this.method_6();
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0000A148 File Offset: 0x00008348
		private void FullScreenButton_Click(object sender, EventArgs e)
		{
			base.method_0(!base.FullScreen);
			this.FullScreenButton.Checked = base.FullScreen;
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x0000A148 File Offset: 0x00008348
		private void RendererControl_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			base.method_0(!base.FullScreen);
			this.FullScreenButton.Checked = base.FullScreen;
		}

		// Token: 0x06001B8E RID: 7054 RVA: 0x0000A16A File Offset: 0x0000836A
		private void PlayButton_Click(object sender, EventArgs e)
		{
			this.method_10(true);
		}

		// Token: 0x06001B8F RID: 7055 RVA: 0x0000A173 File Offset: 0x00008373
		private void StopButton_Click(object sender, EventArgs e)
		{
			this.method_10(false);
		}

		// Token: 0x06001B90 RID: 7056 RVA: 0x0000A17C File Offset: 0x0000837C
		private void method_10(bool enable)
		{
			this.StopButton.Enabled = enable;
			this.PlayButton.Enabled = !enable;
			this.timer_1.Enabled = enable;
		}

		// Token: 0x06001B91 RID: 7057 RVA: 0x0000A1A5 File Offset: 0x000083A5
		private void timer_1_Tick(object sender, EventArgs e)
		{
			this.method_4();
		}

		// Token: 0x06001B92 RID: 7058 RVA: 0x0000953A File Offset: 0x0000773A
		private void MyGalleryViewer_HelpRequested(object sender, HelpEventArgs e)
		{
			Class462.smethod_0(Enum51.const_8);
			e.Handled = true;
		}

		// Token: 0x0400091F RID: 2335
		private static readonly int int_0 = 10;

		// Token: 0x04000920 RID: 2336
		private static readonly int int_1 = 5000;

		// Token: 0x04000921 RID: 2337
		private EventHandler eventHandler_0;

		// Token: 0x04000922 RID: 2338
		private EventHandler eventHandler_1;

		// Token: 0x04000923 RID: 2339
		private Class111 class111_0;

		// Token: 0x04000924 RID: 2340
		private string string_0;

		// Token: 0x04000925 RID: 2341
		private MyGalleryViewer.Enum41 enum41_0;

		// Token: 0x04000926 RID: 2342
		private Point? nullable_0;

		// Token: 0x04000927 RID: 2343
		private bool bool_1;

		// Token: 0x0200029A RID: 666
		private enum Enum41
		{
			// Token: 0x0400093E RID: 2366
			const_0,
			// Token: 0x0400093F RID: 2367
			const_1,
			// Token: 0x04000940 RID: 2368
			const_2,
			// Token: 0x04000941 RID: 2369
			const_3,
			// Token: 0x04000942 RID: 2370
			const_4
		}
	}
}
