using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ns16
{
	// Token: 0x020003DB RID: 987
	internal static class Class399
	{
		// Token: 0x060025D8 RID: 9688 RVA: 0x00085E7C File Offset: 0x0008407C
		public static void smethod_0(this ListView lv, ListViewItem lvi, bool up)
		{
			int num = lv.Items.IndexOf(lvi);
			if (num == -1)
			{
				throw new ArgumentException("The item does not exist.", "lvi");
			}
			if (up)
			{
				num--;
				if (num < 0)
				{
					throw new ArgumentException("Index must be greater or equal to 0.");
				}
			}
			else
			{
				num++;
				if (num >= lv.Items.Count)
				{
					throw new ArgumentException("Index must be less then item count.");
				}
			}
			lv.Items.Remove(lvi);
			lv.Items.Insert(num, lvi);
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x00010A5C File Offset: 0x0000EC5C
		public static int smethod_1(this ListView lv)
		{
			if (lv.SelectedItems.Count == 0)
			{
				return -1;
			}
			return lv.SelectedIndices[0];
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00010A79 File Offset: 0x0000EC79
		public static void smethod_2(this Timer timer)
		{
			if (timer.Enabled)
			{
				timer.Stop();
				timer.Start();
			}
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00085EF8 File Offset: 0x000840F8
		public static void smethod_3(this Control control, int minSize)
		{
			control.SuspendLayout();
			if (control.Width >= minSize && control.Height >= minSize)
			{
				if (control.Width < control.Height)
				{
					control.Size = new Size(control.Width, control.Width);
				}
				else
				{
					control.Size = new Size(control.Height, control.Height);
				}
			}
			else
			{
				control.Size = new Size(minSize, minSize);
			}
			control.ResumeLayout();
		}

		// Token: 0x060025DC RID: 9692 RVA: 0x00010A8F File Offset: 0x0000EC8F
		public static void smethod_4(this Control sender, MethodInvoker del)
		{
			if (sender != null && sender.InvokeRequired)
			{
				sender.BeginInvoke(del);
				return;
			}
			del();
		}

		// Token: 0x060025DD RID: 9693 RVA: 0x00085F70 File Offset: 0x00084170
		public static T smethod_5<T>(this Control sender, Func<T> del)
		{
			MethodInvoker methodInvoker = null;
			Class399.Class400<T> @class = new Class399.Class400<T>();
			@class.func_0 = del;
			@class.gparam_0 = default(T);
			if (sender != null && sender.InvokeRequired)
			{
				if (methodInvoker == null)
				{
					methodInvoker = new MethodInvoker(@class.method_0);
				}
				sender.Invoke(methodInvoker);
			}
			else
			{
				@class.gparam_0 = @class.func_0();
			}
			return @class.gparam_0;
		}

		// Token: 0x060025DE RID: 9694 RVA: 0x00010AAB File Offset: 0x0000ECAB
		public static void smethod_6(this Control sender, MethodInvoker del)
		{
			if (sender != null && sender.InvokeRequired)
			{
				sender.Invoke(del);
				return;
			}
			del();
		}

		// Token: 0x020003DC RID: 988
		[CompilerGenerated]
		private sealed class Class400<T>
		{
			// Token: 0x060025E0 RID: 9696 RVA: 0x00010AC7 File Offset: 0x0000ECC7
			public void method_0()
			{
				this.gparam_0 = this.func_0();
			}

			// Token: 0x04001282 RID: 4738
			public T gparam_0;

			// Token: 0x04001283 RID: 4739
			public Func<T> func_0;
		}
	}
}
