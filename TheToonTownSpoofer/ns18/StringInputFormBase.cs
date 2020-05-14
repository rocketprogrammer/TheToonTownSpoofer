using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns15;
using ns27;

namespace ns18
{
	// Token: 0x020002A8 RID: 680
	internal partial class StringInputFormBase : InputFormBase
	{
		// Token: 0x06001BCB RID: 7115 RVA: 0x000570CC File Offset: 0x000552CC
		private void InitializeComponent_1()
		{
			this.InputTextBox = new TextBox();
			base.SuspendLayout();
			this.InputTextBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.InputTextBox.Location = new Point(15, 37);
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new Size(337, 20);
			this.InputTextBox.TabIndex = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(523, 68);
			base.Controls.Add(this.InputTextBox);
			base.Name = "StringInputFormBase";
			this.Text = "Input";
			base.Controls.SetChildIndex(this.InputTextBox, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x14000180 RID: 384
		// (add) Token: 0x06001BCC RID: 7116 RVA: 0x000571B4 File Offset: 0x000553B4
		// (remove) Token: 0x06001BCD RID: 7117 RVA: 0x000571EC File Offset: 0x000553EC
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public event EventHandler<EventArgs43<string>> InputValidating
		{
			add
			{
				EventHandler<EventArgs43<string>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs43<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs43<string>> value2 = (EventHandler<EventArgs43<string>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs43<string>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs43<string>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs43<string>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs43<string>> value2 = (EventHandler<EventArgs43<string>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs43<string>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x0000A42A File Offset: 0x0000862A
		public StringInputFormBase()
		{
			this.InitializeComponent_1();
			base.LabelMessage = StringInputFormBase.string_0;
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001BCF RID: 7119 RVA: 0x0000A443 File Offset: 0x00008643
		// (set) Token: 0x06001BD0 RID: 7120 RVA: 0x0000A450 File Offset: 0x00008650
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public int MaxLength
		{
			get
			{
				return this.InputTextBox.MaxLength;
			}
			set
			{
				this.InputTextBox.MaxLength = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001BD1 RID: 7121 RVA: 0x0000A45E File Offset: 0x0000865E
		// (set) Token: 0x06001BD2 RID: 7122 RVA: 0x0000A471 File Offset: 0x00008671
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool PasswordTextBox
		{
			get
			{
				return this.InputTextBox.PasswordChar != '\0';
			}
			set
			{
				if (value)
				{
					this.InputTextBox.PasswordChar = '*';
					return;
				}
				this.InputTextBox.PasswordChar = '\0';
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001BD3 RID: 7123 RVA: 0x0000A490 File Offset: 0x00008690
		// (set) Token: 0x06001BD4 RID: 7124 RVA: 0x0000A49D File Offset: 0x0000869D
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public string Value
		{
			get
			{
				return this.InputTextBox.Text;
			}
			set
			{
				this.InputTextBox.Text = value;
			}
		}

		// Token: 0x06001BD5 RID: 7125 RVA: 0x00057224 File Offset: 0x00055424
		protected override bool vmethod_0()
		{
			if (this.eventHandler_0 != null)
			{
				EventArgs43<string> eventArgs = new EventArgs43<string>(this.InputTextBox.Text);
				this.eventHandler_0(this, eventArgs);
				return eventArgs.IsValid;
			}
			return base.vmethod_0();
		}

		// Token: 0x0400097B RID: 2427
		private TextBox InputTextBox;

		// Token: 0x0400097C RID: 2428
		private static readonly string string_0 = "Please enter a reference name:";

		// Token: 0x0400097D RID: 2429
		private EventHandler<EventArgs43<string>> eventHandler_0;
	}
}
