using System;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ns29
{
	// Token: 0x020004CE RID: 1230
	internal struct Struct57
	{
		// Token: 0x06002DF5 RID: 11765 RVA: 0x0001626F File Offset: 0x0001446F
		public Struct57(Rectangle clientRectangle)
		{
			this = default(Struct57);
			this.ClientRectangle = clientRectangle;
		}

		// Token: 0x17000B51 RID: 2897
		// (get) Token: 0x06002DF6 RID: 11766 RVA: 0x0001627F File Offset: 0x0001447F
		// (set) Token: 0x06002DF7 RID: 11767 RVA: 0x00016287 File Offset: 0x00014487
		public Rectangle ClientRectangle { get; private set; }

		// Token: 0x17000B52 RID: 2898
		// (get) Token: 0x06002DF8 RID: 11768 RVA: 0x000B054C File Offset: 0x000AE74C
		public Rectangle Bottom
		{
			get
			{
				Rectangle clientRectangle = this.ClientRectangle;
				clientRectangle.Y = clientRectangle.Bottom - Struct57.int_0 + 1;
				clientRectangle.Height = Struct57.int_0;
				return clientRectangle;
			}
		}

		// Token: 0x17000B53 RID: 2899
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x000B0584 File Offset: 0x000AE784
		public Rectangle BottomRight
		{
			get
			{
				Rectangle clientRectangle = this.ClientRectangle;
				clientRectangle.Y = clientRectangle.Bottom - Struct57.int_1 + 1;
				clientRectangle.Height = Struct57.int_1;
				clientRectangle.X = clientRectangle.Width - Struct57.int_1 + 1;
				clientRectangle.Width = Struct57.int_1;
				return clientRectangle;
			}
		}

		// Token: 0x17000B54 RID: 2900
		// (get) Token: 0x06002DFA RID: 11770 RVA: 0x000B05E0 File Offset: 0x000AE7E0
		public Rectangle Top
		{
			get
			{
				Rectangle clientRectangle = this.ClientRectangle;
				clientRectangle.Height = Struct57.int_0;
				return clientRectangle;
			}
		}

		// Token: 0x17000B55 RID: 2901
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x000B0604 File Offset: 0x000AE804
		public Rectangle TopRight
		{
			get
			{
				Rectangle clientRectangle = this.ClientRectangle;
				clientRectangle.Height = Struct57.int_1;
				clientRectangle.X = clientRectangle.Width - Struct57.int_1 + 1;
				clientRectangle.Width = Struct57.int_1;
				return clientRectangle;
			}
		}

		// Token: 0x17000B56 RID: 2902
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x000B0648 File Offset: 0x000AE848
		public Rectangle Left
		{
			get
			{
				Rectangle clientRectangle = this.ClientRectangle;
				clientRectangle.Width = Struct57.int_0;
				return clientRectangle;
			}
		}

		// Token: 0x17000B57 RID: 2903
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x000B066C File Offset: 0x000AE86C
		public Rectangle BottomLeft
		{
			get
			{
				Rectangle clientRectangle = this.ClientRectangle;
				clientRectangle.Width = Struct57.int_1;
				clientRectangle.Y = clientRectangle.Height - Struct57.int_1 + 1;
				clientRectangle.Height = Struct57.int_1;
				return clientRectangle;
			}
		}

		// Token: 0x17000B58 RID: 2904
		// (get) Token: 0x06002DFE RID: 11774 RVA: 0x000B06B0 File Offset: 0x000AE8B0
		public Rectangle Right
		{
			get
			{
				Rectangle clientRectangle = this.ClientRectangle;
				clientRectangle.X = clientRectangle.Right - Struct57.int_0 + 1;
				clientRectangle.Width = Struct57.int_0;
				return clientRectangle;
			}
		}

		// Token: 0x17000B59 RID: 2905
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x000B06E8 File Offset: 0x000AE8E8
		public Rectangle TopLeft
		{
			get
			{
				Rectangle clientRectangle = this.ClientRectangle;
				clientRectangle.Width = Struct57.int_1;
				clientRectangle.Height = Struct57.int_1;
				return clientRectangle;
			}
		}

		// Token: 0x04001823 RID: 6179
		private static readonly int int_0 = 6;

		// Token: 0x04001824 RID: 6180
		private static readonly int int_1 = Struct57.int_0 << 1;

		// Token: 0x04001825 RID: 6181
		[CompilerGenerated]
		private Rectangle rectangle_0;
	}
}
