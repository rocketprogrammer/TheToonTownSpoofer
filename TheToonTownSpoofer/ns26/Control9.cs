using System;
using System.Collections;
using System.Windows.Forms.Design;

namespace ns26
{
	// Token: 0x02000466 RID: 1126
	internal sealed class Control9 : ControlDesigner
	{
		// Token: 0x060029D2 RID: 10706 RVA: 0x000A0684 File Offset: 0x0009E884
		protected override void PostFilterProperties(IDictionary Properties)
		{
			Properties.Remove("AllowDrop");
			Properties.Remove("BackgroundImageLayout");
			Properties.Remove("BackgroundImage");
			Properties.Remove("ContextMenu");
			Properties.Remove("FlatStyle");
			Properties.Remove("Image");
			Properties.Remove("ImageAlign");
			Properties.Remove("ImageIndex");
			Properties.Remove("ImageList");
			Properties.Remove("TextAlign");
		}
	}
}
