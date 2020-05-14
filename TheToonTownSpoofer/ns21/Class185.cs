using System;
using System.Security.Permissions;
using System.Windows.Forms;

namespace ns21
{
	// Token: 0x02000241 RID: 577
	internal sealed class Class185 : RichTextBox
	{
		// Token: 0x060018B0 RID: 6320 RVA: 0x00008170 File Offset: 0x00006370
		public Class185()
		{
			base.BorderStyle = BorderStyle.None;
		}

		// Token: 0x17000754 RID: 1876
		// (get) Token: 0x060018B1 RID: 6321 RVA: 0x00043270 File Offset: 0x00041470
		protected override CreateParams CreateParams
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				CreateParams createParams = base.CreateParams;
				if (base.BorderStyle == BorderStyle.None && base.ReadOnly)
				{
					createParams.ExStyle |= 131072;
				}
				return createParams;
			}
		}
	}
}
