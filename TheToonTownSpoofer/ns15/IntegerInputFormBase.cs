using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns21;
using ns27;

namespace ns15
{
	// Token: 0x02000205 RID: 517
	internal partial class IntegerInputFormBase : InputFormBase
	{
		// Token: 0x14000173 RID: 371
		// (add) Token: 0x060016CB RID: 5835 RVA: 0x00037650 File Offset: 0x00035850
		// (remove) Token: 0x060016CC RID: 5836 RVA: 0x00037688 File Offset: 0x00035888
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public event EventHandler<EventArgs43<int>> InputValidating
		{
			add
			{
				EventHandler<EventArgs43<int>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs43<int>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs43<int>> value2 = (EventHandler<EventArgs43<int>>)Delegate.Combine(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs43<int>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
			remove
			{
				EventHandler<EventArgs43<int>> eventHandler = this.eventHandler_0;
				EventHandler<EventArgs43<int>> eventHandler2;
				do
				{
					eventHandler2 = eventHandler;
					EventHandler<EventArgs43<int>> value2 = (EventHandler<EventArgs43<int>>)Delegate.Remove(eventHandler2, value);
					eventHandler = Interlocked.CompareExchange<EventHandler<EventArgs43<int>>>(ref this.eventHandler_0, value2, eventHandler2);
				}
				while (eventHandler != eventHandler2);
			}
		}

		// Token: 0x060016CD RID: 5837 RVA: 0x00006B46 File Offset: 0x00004D46
		public IntegerInputFormBase()
		{
			this.InitializeComponent_1();
			base.LabelMessage = IntegerInputFormBase.string_0;
		}

		// Token: 0x1700070A RID: 1802
		// (get) Token: 0x060016CE RID: 5838 RVA: 0x00006B5F File Offset: 0x00004D5F
		// (set) Token: 0x060016CF RID: 5839 RVA: 0x00006B6C File Offset: 0x00004D6C
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		public int MaximumValue
		{
			get
			{
				return this.InputTextBox.MaximumValue;
			}
			set
			{
				this.InputTextBox.MaximumValue = value;
			}
		}

		// Token: 0x1700070B RID: 1803
		// (get) Token: 0x060016D0 RID: 5840 RVA: 0x00006B7A File Offset: 0x00004D7A
		// (set) Token: 0x060016D1 RID: 5841 RVA: 0x00006B87 File Offset: 0x00004D87
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int MinimumValue
		{
			get
			{
				return this.InputTextBox.MinimumValue;
			}
			set
			{
				this.InputTextBox.MinimumValue = value;
			}
		}

		// Token: 0x1700070C RID: 1804
		// (get) Token: 0x060016D2 RID: 5842 RVA: 0x00006B95 File Offset: 0x00004D95
		// (set) Token: 0x060016D3 RID: 5843 RVA: 0x00006BA2 File Offset: 0x00004DA2
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public int Value
		{
			get
			{
				return this.InputTextBox.Value;
			}
			set
			{
				this.InputTextBox.Value = value;
			}
		}

		// Token: 0x1700070D RID: 1805
		// (get) Token: 0x060016D4 RID: 5844 RVA: 0x00006BB0 File Offset: 0x00004DB0
		// (set) Token: 0x060016D5 RID: 5845 RVA: 0x00006BBD File Offset: 0x00004DBD
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
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

		// Token: 0x060016D6 RID: 5846 RVA: 0x000376C0 File Offset: 0x000358C0
		protected override bool vmethod_0()
		{
			if (this.eventHandler_0 != null)
			{
				EventArgs43<int> eventArgs = new EventArgs43<int>(this.InputTextBox.Value);
				this.eventHandler_0(this, eventArgs);
				return eventArgs.IsValid;
			}
			return base.vmethod_0();
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00037700 File Offset: 0x00035900
		private void InitializeComponent_1()
		{
			this.InputTextBox = new Class181();
			base.SuspendLayout();
			this.InputTextBox.Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right);
			this.InputTextBox.IfZeroDisplayEmpty = false;
			this.InputTextBox.Location = new Point(15, 37);
			this.InputTextBox.MaximumValue = int.MaxValue;
			this.InputTextBox.MinimumValue = int.MinValue;
			this.InputTextBox.Name = "InputTextBox";
			this.InputTextBox.Size = new Size(337, 20);
			this.InputTextBox.TabIndex = 0;
			this.InputTextBox.Value = 0;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(523, 68);
			base.Controls.Add(this.InputTextBox);
			base.Name = "IntegerInputFormBase";
			this.Text = "Input";
			base.Controls.SetChildIndex(this.InputTextBox, 0);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040004F1 RID: 1265
		private static readonly string string_0 = "Please enter a value:";

		// Token: 0x040004F2 RID: 1266
		private EventHandler<EventArgs43<int>> eventHandler_0;

		// Token: 0x040004F4 RID: 1268
		private Class181 InputTextBox;
	}
}
