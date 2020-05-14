using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using ns25;
using ns31;

namespace ns29
{
	// Token: 0x020004C9 RID: 1225
	[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
	internal sealed class Class517 : UITypeEditor
	{
		// Token: 0x06002DDF RID: 11743 RVA: 0x0000C077 File Offset: 0x0000A277
		public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.Modal;
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000B00BC File Offset: 0x000AE2BC
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (provider != null && provider.GetService(typeof(IWindowsFormsEditorService)) is IWindowsFormsEditorService)
			{
				IntPtr focus = Class265.GetFocus();
				try
				{
					using (RTFEditor rtfeditor = new RTFEditor())
					{
						if (value is string)
						{
							rtfeditor.Value = (value as string);
						}
						if (rtfeditor.ShowDialog() == DialogResult.OK)
						{
							return rtfeditor.Value;
						}
					}
					return value;
				}
				finally
				{
					if (focus != IntPtr.Zero)
					{
						Class265.SetFocus(new HandleRef(null, focus));
					}
				}
				object result;
				return result;
			}
			return value;
		}
	}
}
