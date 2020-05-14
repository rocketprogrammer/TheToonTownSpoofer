using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns28
{
	// Token: 0x020004A1 RID: 1185
	internal sealed class Class499 : IDisposable
	{
		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x00014A56 File Offset: 0x00012C56
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x00014A5E File Offset: 0x00012C5E
		public Form Owner { get; private set; }

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x00014A67 File Offset: 0x00012C67
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x00014A6F File Offset: 0x00012C6F
		public Form ShowingForm { get; private set; }

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x00014A78 File Offset: 0x00012C78
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00014A80 File Offset: 0x00012C80
		public Form ClosingForm { get; private set; }

		// Token: 0x06002C21 RID: 11297 RVA: 0x00014A89 File Offset: 0x00012C89
		public Class499(Form frm, bool showWhenDisposed) : this(frm)
		{
			this.bool_0 = showWhenDisposed;
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x00014A99 File Offset: 0x00012C99
		public Class499(Form frm)
		{
			if (frm == null)
			{
				throw new NullReferenceException("frm");
			}
			if (frm.IsDisposed)
			{
				throw new ObjectDisposedException("frm");
			}
			this.Owner = frm;
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000AAFC8 File Offset: 0x000A91C8
		public void method_0(Form frm)
		{
			this.method_3(frm, true, null);
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x00014AC9 File Offset: 0x00012CC9
		public void method_1(Form frm, DialogResult nonShowResult)
		{
			this.method_3(frm, true, new DialogResult?(nonShowResult));
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000AAFE8 File Offset: 0x000A91E8
		public void method_2(Form frm, bool autoDisplay)
		{
			this.method_3(frm, autoDisplay, null);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000AB008 File Offset: 0x000A9208
		public void method_3(Form frm, bool autoDisplay, DialogResult? nonShowResult)
		{
			if (frm == null)
			{
				throw new ArgumentNullException("frm");
			}
			if (this.ShowingForm != null)
			{
				throw new ArgumentException("Cannot set a new form without first unsubscribing the existing one.");
			}
			this.ShowingForm = frm;
			this.ShowingForm.Shown += this.method_7;
			if (autoDisplay)
			{
				this.method_5(this.ShowingForm, nonShowResult);
			}
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x00014AD9 File Offset: 0x00012CD9
		public void method_4()
		{
			if (this.ShowingForm != null)
			{
				this.ShowingForm.Shown -= this.method_7;
				if (this.ClosingForm == this.ShowingForm)
				{
					this.method_6();
				}
				this.ShowingForm = null;
			}
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000AB064 File Offset: 0x000A9264
		public void method_5(Form frm, DialogResult? nonShowResult)
		{
			if (frm == null)
			{
				throw new ArgumentNullException("frm");
			}
			if (this.ClosingForm != null)
			{
				throw new ArgumentException("Cannot set a new form for closing without first unsubscribing the existing one.");
			}
			this.nullable_0 = nonShowResult;
			this.ClosingForm = frm;
			this.ClosingForm.FormClosing += this.method_8;
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x00014B15 File Offset: 0x00012D15
		public void method_6()
		{
			if (this.ClosingForm != null)
			{
				this.nullable_0 = null;
				this.ClosingForm.FormClosing -= this.method_8;
				this.ClosingForm = null;
			}
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x00014B49 File Offset: 0x00012D49
		private void method_7(object sender, EventArgs e)
		{
			this.Owner.Hide();
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000AB0B8 File Offset: 0x000A92B8
		private void method_8(object sender, FormClosingEventArgs e)
		{
			if (!e.Cancel && (this.nullable_0 == null || ((Form)sender).DialogResult != this.nullable_0))
			{
				this.Owner.Show();
				this.Owner.Refresh();
			}
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000AB11C File Offset: 0x000A931C
		public void Dispose()
		{
			if (!this.Owner.IsDisposed)
			{
				if (this.bool_0)
				{
					this.Owner.Show();
				}
				this.Owner.BringToFront();
				this.Owner.Activate();
			}
			this.method_4();
			this.method_6();
			this.Owner = null;
		}

		// Token: 0x04001735 RID: 5941
		private DialogResult? nullable_0;

		// Token: 0x04001736 RID: 5942
		private bool bool_0;

		// Token: 0x04001737 RID: 5943
		[CompilerGenerated]
		private Form form_0;

		// Token: 0x04001738 RID: 5944
		[CompilerGenerated]
		private Form form_1;

		// Token: 0x04001739 RID: 5945
		[CompilerGenerated]
		private Form form_2;
	}
}
