using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns24;
using ns25;
using ns31;

namespace ns29
{
	// Token: 0x020004CF RID: 1231
	internal sealed class Class520 : Component
	{
		// Token: 0x06002E01 RID: 11777 RVA: 0x000162A4 File Offset: 0x000144A4
		public Class520()
		{
			this.dictionary_0 = new Dictionary<Type, Form>();
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x000162B7 File Offset: 0x000144B7
		public Class520(IContainer container) : this()
		{
			if (container == null)
			{
				throw new ArgumentNullException("container");
			}
			container.Add(this);
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x000B0718 File Offset: 0x000AE918
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				Form[] array = this.dictionary_0.Values.ToArray<Form>();
				foreach (Form form in array)
				{
					form.Close();
				}
			}
			base.Dispose(disposing);
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x000B075C File Offset: 0x000AE95C
		public bool method_0<T>() where T : Form
		{
			Type typeFromHandle = typeof(T);
			return this.dictionary_0.ContainsKey(typeFromHandle);
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x000B0780 File Offset: 0x000AE980
		public T method_1<T>() where T : Form
		{
			Type typeFromHandle = typeof(T);
			if (!this.dictionary_0.ContainsKey(typeFromHandle))
			{
				throw new KeyNotFoundException(string.Format("The type of form: '{0}' is not in the collection.", typeFromHandle));
			}
			return (T)((object)this.dictionary_0[typeFromHandle]);
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x000B07C8 File Offset: 0x000AE9C8
		public T method_2<T>(params object[] args) where T : Form
		{
			bool flag;
			return this.method_3<T>(out flag, args);
		}

		// Token: 0x06002E07 RID: 11783 RVA: 0x000B07E0 File Offset: 0x000AE9E0
		public T method_3<T>(out bool created, params object[] args) where T : Form
		{
			if (this.method_0<T>())
			{
				T t = this.method_1<T>();
				if (t.Visible)
				{
					if (t.WindowState == FormWindowState.Minimized)
					{
						Struct28 @struct = default(Struct28);
						@struct.uint_0 = (uint)Marshal.SizeOf(typeof(Struct28));
						Class265.GetWindowPlacement(new HandleRef(t, t.Handle), ref @struct);
						if (@struct.enum62_0.HasFlag(Enum62.flag_1))
						{
							t.WindowState = FormWindowState.Maximized;
						}
						else
						{
							t.WindowState = FormWindowState.Normal;
						}
					}
					t.BringToFront();
					t.Activate();
				}
				created = false;
				return t;
			}
			Class520.Class521<T> @class = new Class520.Class521<T>();
			@class.class520_0 = this;
			@class.type_0 = typeof(T);
			@class.gparam_0 = (T)((object)Activator.CreateInstance(@class.type_0, args));
			@class.gparam_0.FormClosed += @class.method_0;
			this.dictionary_0.Add(@class.type_0, @class.gparam_0);
			@class.gparam_0.Show();
			created = true;
			return @class.gparam_0;
		}

		// Token: 0x04001826 RID: 6182
		private Dictionary<Type, Form> dictionary_0;

		// Token: 0x020004D0 RID: 1232
		[CompilerGenerated]
		private sealed class Class521<T> where T : Form
		{
			// Token: 0x06002E09 RID: 11785 RVA: 0x000162D4 File Offset: 0x000144D4
			public void method_0(object sender, FormClosedEventArgs e)
			{
				this.gparam_0.Dispose();
				this.class520_0.dictionary_0.Remove(this.type_0);
			}

			// Token: 0x04001827 RID: 6183
			public Type type_0;

			// Token: 0x04001828 RID: 6184
			public T gparam_0;

			// Token: 0x04001829 RID: 6185
			public Class520 class520_0;
		}
	}
}
