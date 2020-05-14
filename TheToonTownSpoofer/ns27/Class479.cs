using System;
using System.ComponentModel;
using System.Drawing;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ns27
{
	// Token: 0x0200047C RID: 1148
	internal sealed class Class479 : Button
	{
		// Token: 0x06002AC8 RID: 10952 RVA: 0x00013F42 File Offset: 0x00012142
		public Class479()
		{
			this.AutoSize = true;
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x00013F51 File Offset: 0x00012151
		// (set) Token: 0x06002ACA RID: 10954 RVA: 0x00013F59 File Offset: 0x00012159
		[Browsable(false)]
		public override ContextMenuStrip ContextMenuStrip
		{
			get
			{
				return this.SplitMenuStrip;
			}
			set
			{
				this.SplitMenuStrip = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06002ACB RID: 10955 RVA: 0x00013F62 File Offset: 0x00012162
		// (set) Token: 0x06002ACC RID: 10956 RVA: 0x000A5B98 File Offset: 0x000A3D98
		[DefaultValue(null)]
		public ContextMenu SplitMenu
		{
			get
			{
				return this.contextMenu_0;
			}
			set
			{
				if (this.contextMenu_0 != null)
				{
					this.contextMenu_0.Popup -= this.method_9;
				}
				if (value != null)
				{
					this.ShowSplit = true;
					value.Popup += this.method_9;
				}
				else
				{
					this.ShowSplit = false;
				}
				this.contextMenu_0 = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06002ACD RID: 10957 RVA: 0x00013F6A File Offset: 0x0001216A
		// (set) Token: 0x06002ACE RID: 10958 RVA: 0x000A5BF0 File Offset: 0x000A3DF0
		[DefaultValue(null)]
		public ContextMenuStrip SplitMenuStrip
		{
			get
			{
				return this.contextMenuStrip_0;
			}
			set
			{
				if (this.contextMenuStrip_0 != null)
				{
					this.contextMenuStrip_0.Closing -= this.method_8;
					this.contextMenuStrip_0.Opening -= this.method_7;
				}
				if (value != null)
				{
					this.ShowSplit = true;
					value.Closing += this.method_8;
					value.Opening += this.method_7;
				}
				else
				{
					this.ShowSplit = false;
				}
				this.contextMenuStrip_0 = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002ACF RID: 10959 RVA: 0x00013F72 File Offset: 0x00012172
		// (set) Token: 0x06002AD0 RID: 10960 RVA: 0x00013F7A File Offset: 0x0001217A
		[DefaultValue(false)]
		public bool ShowSplit
		{
			get
			{
				return this.bool_1;
			}
			set
			{
				if (value != this.bool_1)
				{
					this.bool_1 = value;
					base.Invalidate();
					if (base.Parent != null)
					{
						base.Parent.PerformLayout();
					}
				}
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002AD1 RID: 10961 RVA: 0x00013FA5 File Offset: 0x000121A5
		// (set) Token: 0x06002AD2 RID: 10962 RVA: 0x00013FAD File Offset: 0x000121AD
		[DefaultValue(PushButtonState.Normal)]
		private PushButtonState State
		{
			get
			{
				return this.pushButtonState_0;
			}
			set
			{
				if (!this.pushButtonState_0.Equals(value))
				{
					this.pushButtonState_0 = value;
					base.Invalidate();
				}
			}
		}

		// Token: 0x06002AD3 RID: 10963 RVA: 0x00013FD4 File Offset: 0x000121D4
		protected override bool IsInputKey(Keys keyData)
		{
			return (keyData.Equals(Keys.Down) && this.bool_1) || base.IsInputKey(keyData);
		}

		// Token: 0x06002AD4 RID: 10964 RVA: 0x000A5C74 File Offset: 0x000A3E74
		protected override void OnGotFocus(EventArgs e)
		{
			if (!this.bool_1)
			{
				base.OnGotFocus(e);
				return;
			}
			if (!this.State.Equals(PushButtonState.Pressed) && !this.State.Equals(PushButtonState.Disabled))
			{
				this.State = PushButtonState.Default;
			}
		}

		// Token: 0x06002AD5 RID: 10965 RVA: 0x000A5CC8 File Offset: 0x000A3EC8
		protected override void OnKeyDown(KeyEventArgs kevent)
		{
			if (this.bool_1)
			{
				if (kevent.KeyCode.Equals(Keys.Down) && !this.bool_2)
				{
					this.method_6();
				}
				else if (kevent.KeyCode.Equals(Keys.Space) && kevent.Modifiers == Keys.None)
				{
					this.State = PushButtonState.Pressed;
				}
			}
			base.OnKeyDown(kevent);
		}

		// Token: 0x06002AD6 RID: 10966 RVA: 0x000A5D38 File Offset: 0x000A3F38
		protected override void OnKeyUp(KeyEventArgs kevent)
		{
			if (kevent.KeyCode.Equals(Keys.Space))
			{
				if (Control.MouseButtons == MouseButtons.None)
				{
					this.State = PushButtonState.Normal;
				}
			}
			else if (kevent.KeyCode.Equals(Keys.Apps) && Control.MouseButtons == MouseButtons.None && !this.bool_2)
			{
				this.method_6();
			}
			base.OnKeyUp(kevent);
		}

		// Token: 0x06002AD7 RID: 10967 RVA: 0x00013FFB File Offset: 0x000121FB
		protected override void OnEnabledChanged(EventArgs e)
		{
			this.State = (base.Enabled ? PushButtonState.Normal : PushButtonState.Disabled);
			base.OnEnabledChanged(e);
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x000A5DA4 File Offset: 0x000A3FA4
		protected override void OnLostFocus(EventArgs e)
		{
			if (!this.bool_1)
			{
				base.OnLostFocus(e);
				return;
			}
			if (!this.State.Equals(PushButtonState.Pressed) && !this.State.Equals(PushButtonState.Disabled))
			{
				this.State = PushButtonState.Normal;
			}
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x000A5DF8 File Offset: 0x000A3FF8
		protected override void OnMouseEnter(EventArgs e)
		{
			if (!this.bool_1)
			{
				base.OnMouseEnter(e);
				return;
			}
			this.bool_3 = true;
			if (!this.State.Equals(PushButtonState.Pressed) && !this.State.Equals(PushButtonState.Disabled))
			{
				this.State = PushButtonState.Hot;
			}
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x000A5E54 File Offset: 0x000A4054
		protected override void OnMouseLeave(EventArgs e)
		{
			if (!this.bool_1)
			{
				base.OnMouseLeave(e);
				return;
			}
			this.bool_3 = false;
			if (!this.State.Equals(PushButtonState.Pressed) && !this.State.Equals(PushButtonState.Disabled))
			{
				this.State = (this.Focused ? PushButtonState.Default : PushButtonState.Normal);
			}
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000A5EBC File Offset: 0x000A40BC
		protected override void OnMouseDown(MouseEventArgs e)
		{
			if (!this.bool_1)
			{
				base.OnMouseDown(e);
				return;
			}
			if (this.contextMenu_0 != null && e.Button == MouseButtons.Left && !this.bool_3)
			{
				this.bool_0 = true;
			}
			if (this.rectangle_0.Contains(e.Location) && !this.bool_2 && e.Button == MouseButtons.Left)
			{
				this.method_6();
				return;
			}
			this.State = PushButtonState.Pressed;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x000A5F34 File Offset: 0x000A4134
		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			if (!this.bool_1)
			{
				base.OnMouseUp(mevent);
				return;
			}
			if (mevent.Button == MouseButtons.Right && base.ClientRectangle.Contains(mevent.Location) && !this.bool_2)
			{
				this.method_6();
				return;
			}
			if ((this.contextMenuStrip_0 == null && this.contextMenu_0 == null) || !this.bool_2)
			{
				this.method_10();
				if (base.ClientRectangle.Contains(mevent.Location) && !this.rectangle_0.Contains(mevent.Location))
				{
					this.OnClick(EventArgs.Empty);
				}
			}
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x000A5FD8 File Offset: 0x000A41D8
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			if (!this.bool_1)
			{
				return;
			}
			Graphics graphics = pevent.Graphics;
			Rectangle clientRectangle = base.ClientRectangle;
			if (this.State != PushButtonState.Pressed && base.IsDefault && !Application.RenderWithVisualStyles)
			{
				Rectangle bounds = clientRectangle;
				bounds.Inflate(-1, -1);
				ButtonRenderer.DrawButton(graphics, bounds, this.State);
				graphics.DrawRectangle(SystemPens.WindowFrame, 0, 0, clientRectangle.Width - 1, clientRectangle.Height - 1);
			}
			else
			{
				ButtonRenderer.DrawButton(graphics, clientRectangle, this.State);
			}
			this.rectangle_0 = new Rectangle(clientRectangle.Right - Class479.int_0, 0, Class479.int_0, clientRectangle.Height);
			int num = Class479.int_1;
			Rectangle rectangle = new Rectangle(num - 1, num - 1, clientRectangle.Width - this.rectangle_0.Width - num, clientRectangle.Height - num * 2 + 2);
			if (this.RightToLeft == RightToLeft.Yes)
			{
				this.rectangle_0.X = clientRectangle.Left + 1;
				rectangle.X = this.rectangle_0.Right;
				graphics.DrawLine(SystemPens.ButtonShadow, clientRectangle.Left + Class479.int_0, Class479.int_1, clientRectangle.Left + Class479.int_0, clientRectangle.Bottom - Class479.int_1);
				graphics.DrawLine(SystemPens.ButtonFace, clientRectangle.Left + Class479.int_0 + 1, Class479.int_1, clientRectangle.Left + Class479.int_0 + 1, clientRectangle.Bottom - Class479.int_1);
			}
			else
			{
				graphics.DrawLine(SystemPens.ButtonShadow, clientRectangle.Right - Class479.int_0, Class479.int_1, clientRectangle.Right - Class479.int_0, clientRectangle.Bottom - Class479.int_1);
				graphics.DrawLine(SystemPens.ButtonFace, clientRectangle.Right - Class479.int_0 - 1, Class479.int_1, clientRectangle.Right - Class479.int_0 - 1, clientRectangle.Bottom - Class479.int_1);
			}
			this.method_1(graphics, this.rectangle_0);
			this.method_0(graphics, new Rectangle(0, 0, base.ClientRectangle.Width - Class479.int_0, base.ClientRectangle.Height));
			if (this.State != PushButtonState.Pressed && this.Focused && this.ShowFocusCues)
			{
				ControlPaint.DrawFocusRectangle(graphics, rectangle);
			}
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x000A6234 File Offset: 0x000A4434
		private void method_0(Graphics g, Rectangle bounds)
		{
			Rectangle rectangle;
			Rectangle rectangle2;
			this.method_3(ref bounds, out rectangle, out rectangle2);
			if (base.Image != null)
			{
				if (base.Enabled)
				{
					g.DrawImage(base.Image, rectangle2.X, rectangle2.Y, base.Image.Width, base.Image.Height);
				}
				else
				{
					ControlPaint.DrawImageDisabled(g, base.Image, rectangle2.X, rectangle2.Y, this.BackColor);
				}
			}
			if (!base.UseMnemonic)
			{
				this.textFormatFlags_0 |= TextFormatFlags.NoPrefix;
			}
			else if (!this.ShowKeyboardCues)
			{
				this.textFormatFlags_0 |= TextFormatFlags.HidePrefix;
			}
			if (!string.IsNullOrEmpty(this.Text))
			{
				if (base.Enabled)
				{
					TextRenderer.DrawText(g, this.Text, this.Font, rectangle, this.ForeColor, this.textFormatFlags_0);
					return;
				}
				ControlPaint.DrawStringDisabled(g, this.Text, this.Font, this.BackColor, rectangle, this.textFormatFlags_0);
			}
		}

		// Token: 0x06002ADF RID: 10975 RVA: 0x000A633C File Offset: 0x000A453C
		private void method_1(Graphics g, Rectangle dropDownRect)
		{
			Point point = new Point(Convert.ToInt32(dropDownRect.Left + dropDownRect.Width / 2), Convert.ToInt32(dropDownRect.Top + dropDownRect.Height / 2));
			point.X += dropDownRect.Width % 2;
			Point[] points = new Point[]
			{
				new Point(point.X - 2, point.Y - 1),
				new Point(point.X + 3, point.Y - 1),
				new Point(point.X, point.Y + 2)
			};
			if (base.Enabled)
			{
				g.FillPolygon(SystemBrushes.ControlText, points);
				return;
			}
			g.FillPolygon(SystemBrushes.ButtonShadow, points);
		}

		// Token: 0x06002AE0 RID: 10976 RVA: 0x000A6424 File Offset: 0x000A4624
		public override Size GetPreferredSize(Size proposedSize)
		{
			Size preferredSize = base.GetPreferredSize(proposedSize);
			if (this.bool_1)
			{
				if (this.AutoSize)
				{
					return this.method_2();
				}
				if (!string.IsNullOrEmpty(this.Text) && TextRenderer.MeasureText(this.Text, this.Font).Width + Class479.int_0 > preferredSize.Width)
				{
					return preferredSize + new Size(Class479.int_0 + Class479.int_1 * 2, 0);
				}
			}
			return preferredSize;
		}

		// Token: 0x06002AE1 RID: 10977 RVA: 0x000A64A0 File Offset: 0x000A46A0
		private Size method_2()
		{
			Size empty = Size.Empty;
			Size size = TextRenderer.MeasureText(this.Text, this.Font);
			Size size2 = (base.Image == null) ? Size.Empty : base.Image.Size;
			if (this.Text.Length != 0)
			{
				size.Height += 4;
				size.Width += 4;
			}
			switch (base.TextImageRelation)
			{
			case TextImageRelation.Overlay:
				empty.Height = Math.Max((this.Text.Length == 0) ? 0 : size.Height, size2.Height);
				empty.Width = Math.Max(size.Width, size2.Width);
				break;
			case TextImageRelation.ImageAboveText:
			case TextImageRelation.TextAboveImage:
				empty.Height = size.Height + size2.Height;
				empty.Width = Math.Max(size.Width, size2.Width);
				break;
			case TextImageRelation.ImageBeforeText:
			case TextImageRelation.TextBeforeImage:
				empty.Height = Math.Max(size.Height, size2.Height);
				empty.Width = size.Width + size2.Width;
				break;
			}
			empty.Height += base.Padding.Vertical + 6;
			empty.Width += base.Padding.Horizontal + 6;
			if (this.bool_1)
			{
				empty.Width += Class479.int_0;
			}
			return empty;
		}

		// Token: 0x06002AE2 RID: 10978 RVA: 0x000A6644 File Offset: 0x000A4844
		private void method_3(ref Rectangle content_rect, out Rectangle textRectangle, out Rectangle imageRectangle)
		{
			Size textSize = TextRenderer.MeasureText(this.Text, this.Font, content_rect.Size, this.textFormatFlags_0);
			Size imageSize = (base.Image == null) ? Size.Empty : base.Image.Size;
			textRectangle = Rectangle.Empty;
			imageRectangle = Rectangle.Empty;
			switch (base.TextImageRelation)
			{
			case TextImageRelation.Overlay:
				textRectangle = Class479.smethod_0(ref content_rect, ref textSize, this.TextAlign);
				if (this.pushButtonState_0 == PushButtonState.Pressed && !Application.RenderWithVisualStyles)
				{
					textRectangle.Offset(1, 1);
				}
				if (base.Image != null)
				{
					imageRectangle = Class479.smethod_0(ref content_rect, ref imageSize, base.ImageAlign);
					return;
				}
				break;
			case TextImageRelation.ImageAboveText:
				content_rect.Inflate(-4, -4);
				this.method_5(content_rect, false, textSize, imageSize, out textRectangle, out imageRectangle);
				return;
			case TextImageRelation.TextAboveImage:
				content_rect.Inflate(-4, -4);
				this.method_5(content_rect, true, textSize, imageSize, out textRectangle, out imageRectangle);
				return;
			case (TextImageRelation)3:
			case (TextImageRelation)5:
			case (TextImageRelation)6:
			case (TextImageRelation)7:
				break;
			case TextImageRelation.ImageBeforeText:
				content_rect.Inflate(-4, -4);
				this.method_4(content_rect, false, textSize, imageSize, out textRectangle, out imageRectangle);
				return;
			case TextImageRelation.TextBeforeImage:
				content_rect.Inflate(-4, -4);
				this.method_4(content_rect, true, textSize, imageSize, out textRectangle, out imageRectangle);
				break;
			default:
				return;
			}
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x000A6790 File Offset: 0x000A4990
		private static Rectangle smethod_0(ref Rectangle container, ref Size sizeOfObject, System.Drawing.ContentAlignment alignment)
		{
			int x;
			int y;
			if (alignment <= System.Drawing.ContentAlignment.MiddleCenter)
			{
				switch (alignment)
				{
				case System.Drawing.ContentAlignment.TopLeft:
					x = 4;
					y = 4;
					goto IL_149;
				case System.Drawing.ContentAlignment.TopCenter:
					x = (container.Width - sizeOfObject.Width) / 2;
					y = 4;
					goto IL_149;
				case (System.Drawing.ContentAlignment)3:
					break;
				case System.Drawing.ContentAlignment.TopRight:
					x = container.Width - sizeOfObject.Width - 4;
					y = 4;
					goto IL_149;
				default:
					if (alignment == System.Drawing.ContentAlignment.MiddleLeft)
					{
						x = 4;
						y = (container.Height - sizeOfObject.Height) / 2;
						goto IL_149;
					}
					if (alignment == System.Drawing.ContentAlignment.MiddleCenter)
					{
						x = (container.Width - sizeOfObject.Width) / 2;
						y = (container.Height - sizeOfObject.Height) / 2;
						goto IL_149;
					}
					break;
				}
			}
			else if (alignment <= System.Drawing.ContentAlignment.BottomLeft)
			{
				if (alignment == System.Drawing.ContentAlignment.MiddleRight)
				{
					x = container.Width - sizeOfObject.Width - 4;
					y = (container.Height - sizeOfObject.Height) / 2;
					goto IL_149;
				}
				if (alignment == System.Drawing.ContentAlignment.BottomLeft)
				{
					x = 4;
					y = container.Height - sizeOfObject.Height - 4;
					goto IL_149;
				}
			}
			else
			{
				if (alignment == System.Drawing.ContentAlignment.BottomCenter)
				{
					x = (container.Width - sizeOfObject.Width) / 2;
					y = container.Height - sizeOfObject.Height - 4;
					goto IL_149;
				}
				if (alignment == System.Drawing.ContentAlignment.BottomRight)
				{
					x = container.Width - sizeOfObject.Width - 4;
					y = container.Height - sizeOfObject.Height - 4;
					goto IL_149;
				}
			}
			x = 4;
			y = 4;
			IL_149:
			return new Rectangle(x, y, sizeOfObject.Width, sizeOfObject.Height);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x000A68FC File Offset: 0x000A4AFC
		private void method_4(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, out Rectangle textRect, out Rectangle imageRect)
		{
			int num = 0;
			int num2 = textSize.Width + 0 + imageSize.Width;
			if (!textFirst)
			{
				num += 2;
			}
			if (num2 > totalArea.Width)
			{
				textSize.Width = totalArea.Width - num - imageSize.Width;
				num2 = totalArea.Width;
			}
			int num3 = totalArea.Width - num2;
			int num4 = 0;
			HorizontalAlignment horizontalAlignment = Class479.smethod_1(this.TextAlign);
			HorizontalAlignment horizontalAlignment2 = Class479.smethod_1(base.ImageAlign);
			if (horizontalAlignment2 == HorizontalAlignment.Left)
			{
				num4 = 0;
			}
			else if (horizontalAlignment2 == HorizontalAlignment.Right && horizontalAlignment == HorizontalAlignment.Right)
			{
				num4 = num3;
			}
			else if (horizontalAlignment2 == HorizontalAlignment.Center && (horizontalAlignment == HorizontalAlignment.Left || horizontalAlignment == HorizontalAlignment.Center))
			{
				num4 += num3 / 3;
			}
			else
			{
				num4 += 2 * (num3 / 3);
			}
			Rectangle rectangle;
			Rectangle rectangle2;
			if (textFirst)
			{
				rectangle = new Rectangle(totalArea.Left + num4, Class479.smethod_3(totalArea, textSize, this.TextAlign).Top, textSize.Width, textSize.Height);
				rectangle2 = new Rectangle(rectangle.Right + num, Class479.smethod_3(totalArea, imageSize, base.ImageAlign).Top, imageSize.Width, imageSize.Height);
			}
			else
			{
				rectangle2 = new Rectangle(totalArea.Left + num4, Class479.smethod_3(totalArea, imageSize, base.ImageAlign).Top, imageSize.Width, imageSize.Height);
				rectangle = new Rectangle(rectangle2.Right + num, Class479.smethod_3(totalArea, textSize, this.TextAlign).Top, textSize.Width, textSize.Height);
			}
			textRect = rectangle;
			imageRect = rectangle2;
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x000A6A94 File Offset: 0x000A4C94
		private void method_5(Rectangle totalArea, bool textFirst, Size textSize, Size imageSize, out Rectangle textRect, out Rectangle imageRect)
		{
			int num = 0;
			int num2 = textSize.Height + 0 + imageSize.Height;
			if (textFirst)
			{
				num += 2;
			}
			if (textSize.Width > totalArea.Width)
			{
				textSize.Width = totalArea.Width;
			}
			if (num2 > totalArea.Height && textFirst)
			{
				imageSize = Size.Empty;
				num2 = totalArea.Height;
			}
			int num3 = totalArea.Height - num2;
			int num4 = 0;
			VerticalAlignment verticalAlignment = Class479.smethod_2(this.TextAlign);
			VerticalAlignment verticalAlignment2 = Class479.smethod_2(base.ImageAlign);
			if (verticalAlignment2 == VerticalAlignment.Top)
			{
				num4 = 0;
			}
			else if (verticalAlignment2 == VerticalAlignment.Bottom && verticalAlignment == VerticalAlignment.Bottom)
			{
				num4 = num3;
			}
			else if (verticalAlignment2 == VerticalAlignment.Center && (verticalAlignment == VerticalAlignment.Top || verticalAlignment == VerticalAlignment.Center))
			{
				num4 += num3 / 3;
			}
			else
			{
				num4 += 2 * (num3 / 3);
			}
			Rectangle rectangle;
			Rectangle rectangle2;
			if (textFirst)
			{
				rectangle = new Rectangle(Class479.smethod_3(totalArea, textSize, this.TextAlign).Left, totalArea.Top + num4, textSize.Width, textSize.Height);
				rectangle2 = new Rectangle(Class479.smethod_3(totalArea, imageSize, base.ImageAlign).Left, rectangle.Bottom + num, imageSize.Width, imageSize.Height);
			}
			else
			{
				rectangle2 = new Rectangle(Class479.smethod_3(totalArea, imageSize, base.ImageAlign).Left, totalArea.Top + num4, imageSize.Width, imageSize.Height);
				rectangle = new Rectangle(Class479.smethod_3(totalArea, textSize, this.TextAlign).Left, rectangle2.Bottom + num, textSize.Width, textSize.Height);
				if (rectangle.Bottom > totalArea.Bottom)
				{
					rectangle.Y = totalArea.Top;
				}
			}
			textRect = rectangle;
			imageRect = rectangle2;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000A6C5C File Offset: 0x000A4E5C
		private static HorizontalAlignment smethod_1(System.Drawing.ContentAlignment align)
		{
			if (align <= System.Drawing.ContentAlignment.MiddleCenter)
			{
				switch (align)
				{
				case System.Drawing.ContentAlignment.TopLeft:
					break;
				case System.Drawing.ContentAlignment.TopCenter:
					return HorizontalAlignment.Center;
				case (System.Drawing.ContentAlignment)3:
					return HorizontalAlignment.Left;
				case System.Drawing.ContentAlignment.TopRight:
					return HorizontalAlignment.Right;
				default:
					if (align != System.Drawing.ContentAlignment.MiddleLeft)
					{
						if (align != System.Drawing.ContentAlignment.MiddleCenter)
						{
							return HorizontalAlignment.Left;
						}
						return HorizontalAlignment.Center;
					}
					break;
				}
			}
			else if (align <= System.Drawing.ContentAlignment.BottomLeft)
			{
				if (align == System.Drawing.ContentAlignment.MiddleRight)
				{
					return HorizontalAlignment.Right;
				}
				if (align != System.Drawing.ContentAlignment.BottomLeft)
				{
					return HorizontalAlignment.Left;
				}
			}
			else
			{
				if (align == System.Drawing.ContentAlignment.BottomCenter)
				{
					return HorizontalAlignment.Center;
				}
				if (align != System.Drawing.ContentAlignment.BottomRight)
				{
					return HorizontalAlignment.Left;
				}
				return HorizontalAlignment.Right;
			}
			return HorizontalAlignment.Left;
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000A6CC4 File Offset: 0x000A4EC4
		private static VerticalAlignment smethod_2(System.Drawing.ContentAlignment align)
		{
			if (align > System.Drawing.ContentAlignment.MiddleCenter)
			{
				if (align <= System.Drawing.ContentAlignment.BottomLeft)
				{
					if (align == System.Drawing.ContentAlignment.MiddleRight)
					{
						return VerticalAlignment.Center;
					}
					if (align != System.Drawing.ContentAlignment.BottomLeft)
					{
						return VerticalAlignment.Top;
					}
				}
				else if (align != System.Drawing.ContentAlignment.BottomCenter && align != System.Drawing.ContentAlignment.BottomRight)
				{
					return VerticalAlignment.Top;
				}
				return VerticalAlignment.Bottom;
			}
			switch (align)
			{
			case System.Drawing.ContentAlignment.TopLeft:
			case System.Drawing.ContentAlignment.TopCenter:
			case System.Drawing.ContentAlignment.TopRight:
				return VerticalAlignment.Top;
			case (System.Drawing.ContentAlignment)3:
				return VerticalAlignment.Top;
			default:
				if (align != System.Drawing.ContentAlignment.MiddleLeft && align != System.Drawing.ContentAlignment.MiddleCenter)
				{
					return VerticalAlignment.Top;
				}
				break;
			}
			return VerticalAlignment.Center;
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000A6D2C File Offset: 0x000A4F2C
		public static Rectangle smethod_3(Rectangle outer, Size inner, System.Drawing.ContentAlignment align)
		{
			int x = 0;
			int y = 0;
			if (align != System.Drawing.ContentAlignment.BottomLeft && align != System.Drawing.ContentAlignment.MiddleLeft)
			{
				if (align != System.Drawing.ContentAlignment.TopLeft)
				{
					if (align != System.Drawing.ContentAlignment.BottomCenter && align != System.Drawing.ContentAlignment.MiddleCenter)
					{
						if (align != System.Drawing.ContentAlignment.TopCenter)
						{
							if (align == System.Drawing.ContentAlignment.BottomRight || align == System.Drawing.ContentAlignment.MiddleRight || align == System.Drawing.ContentAlignment.TopRight)
							{
								x = outer.Right - inner.Width;
								goto IL_7D;
							}
							goto IL_7D;
						}
					}
					x = Math.Max(outer.X + (outer.Width - inner.Width) / 2, outer.Left);
					goto IL_7D;
				}
			}
			x = outer.X;
			IL_7D:
			if (align != System.Drawing.ContentAlignment.TopCenter && align != System.Drawing.ContentAlignment.TopLeft)
			{
				if (align != System.Drawing.ContentAlignment.TopRight)
				{
					if (align != System.Drawing.ContentAlignment.MiddleCenter && align != System.Drawing.ContentAlignment.MiddleLeft)
					{
						if (align != System.Drawing.ContentAlignment.MiddleRight)
						{
							if (align == System.Drawing.ContentAlignment.BottomCenter || align == System.Drawing.ContentAlignment.BottomRight || align == System.Drawing.ContentAlignment.BottomLeft)
							{
								y = outer.Bottom - inner.Height;
								goto IL_EA;
							}
							goto IL_EA;
						}
					}
					y = outer.Y + (outer.Height - inner.Height) / 2;
					goto IL_EA;
				}
			}
			y = outer.Y;
			IL_EA:
			return new Rectangle(x, y, Math.Min(inner.Width, outer.Width), Math.Min(inner.Height, outer.Height));
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000A6E50 File Offset: 0x000A5050
		private void method_6()
		{
			if (this.bool_0)
			{
				this.bool_0 = false;
				return;
			}
			this.State = PushButtonState.Pressed;
			if (this.contextMenu_0 != null)
			{
				this.contextMenu_0.Show(this, new Point(0, base.Height));
				return;
			}
			if (this.contextMenuStrip_0 != null)
			{
				this.contextMenuStrip_0.Show(this, new Point(0, base.Height), ToolStripDropDownDirection.BelowRight);
			}
		}

		// Token: 0x06002AEA RID: 10986 RVA: 0x00014016 File Offset: 0x00012216
		private void method_7(object sender, CancelEventArgs e)
		{
			this.bool_2 = true;
		}

		// Token: 0x06002AEB RID: 10987 RVA: 0x000A6EB8 File Offset: 0x000A50B8
		private void method_8(object sender, ToolStripDropDownClosingEventArgs e)
		{
			this.bool_2 = false;
			this.method_10();
			if (e.CloseReason == ToolStripDropDownCloseReason.AppClicked)
			{
				this.bool_0 = (this.rectangle_0.Contains(base.PointToClient(Cursor.Position)) && Control.MouseButtons == MouseButtons.Left);
			}
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00014016 File Offset: 0x00012216
		private void method_9(object sender, EventArgs e)
		{
			this.bool_2 = true;
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x0001401F File Offset: 0x0001221F
		[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 530)
			{
				this.bool_2 = false;
				this.method_10();
			}
			base.WndProc(ref m);
		}

		// Token: 0x06002AEE RID: 10990 RVA: 0x000A6F08 File Offset: 0x000A5108
		private void method_10()
		{
			if (base.Bounds.Contains(base.Parent.PointToClient(Cursor.Position)))
			{
				this.State = PushButtonState.Hot;
				return;
			}
			if (this.Focused)
			{
				this.State = PushButtonState.Default;
				return;
			}
			if (!base.Enabled)
			{
				this.State = PushButtonState.Disabled;
				return;
			}
			this.State = PushButtonState.Normal;
		}

		// Token: 0x0400169D RID: 5789
		private static readonly int int_0 = 14;

		// Token: 0x0400169E RID: 5790
		private static readonly int int_1 = SystemInformation.Border3DSize.Width * 2;

		// Token: 0x0400169F RID: 5791
		private PushButtonState pushButtonState_0;

		// Token: 0x040016A0 RID: 5792
		private bool bool_0;

		// Token: 0x040016A1 RID: 5793
		private Rectangle rectangle_0;

		// Token: 0x040016A2 RID: 5794
		private bool bool_1;

		// Token: 0x040016A3 RID: 5795
		private bool bool_2;

		// Token: 0x040016A4 RID: 5796
		private ContextMenuStrip contextMenuStrip_0;

		// Token: 0x040016A5 RID: 5797
		private ContextMenu contextMenu_0;

		// Token: 0x040016A6 RID: 5798
		private TextFormatFlags textFormatFlags_0;

		// Token: 0x040016A7 RID: 5799
		private bool bool_3;
	}
}
