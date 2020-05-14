using System;
using System.Diagnostics;
using System.Drawing;

namespace ns18
{
	// Token: 0x0200029F RID: 671
	internal struct Struct24
	{
		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001B9A RID: 7066 RVA: 0x0000A200 File Offset: 0x00008400
		// (set) Token: 0x06001B9B RID: 7067 RVA: 0x0000A208 File Offset: 0x00008408
		public int X
		{
			get
			{
				return this.int_0;
			}
			set
			{
				this.int_0 = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001B9C RID: 7068 RVA: 0x0000A211 File Offset: 0x00008411
		// (set) Token: 0x06001B9D RID: 7069 RVA: 0x0000A219 File Offset: 0x00008419
		public int Y
		{
			get
			{
				return this.int_1;
			}
			set
			{
				this.int_1 = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001B9E RID: 7070 RVA: 0x0000A222 File Offset: 0x00008422
		// (set) Token: 0x06001B9F RID: 7071 RVA: 0x0000A231 File Offset: 0x00008431
		public int Width
		{
			get
			{
				return this.int_2 - this.int_0;
			}
			set
			{
				this.int_2 = this.int_0 + value;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06001BA0 RID: 7072 RVA: 0x0000A241 File Offset: 0x00008441
		// (set) Token: 0x06001BA1 RID: 7073 RVA: 0x0000A250 File Offset: 0x00008450
		public int Height
		{
			get
			{
				return this.int_3 - this.int_1;
			}
			set
			{
				this.int_3 = this.int_1 + value;
			}
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x0000A260 File Offset: 0x00008460
		public Struct24(Rectangle rec)
		{
			this.int_0 = rec.Left;
			this.int_1 = rec.Top;
			this.int_2 = rec.Right;
			this.int_3 = rec.Bottom;
		}

		// Token: 0x06001BA3 RID: 7075 RVA: 0x0000A296 File Offset: 0x00008496
		[DebuggerStepThrough]
		public Struct24(int left, int top, int right, int bottom)
		{
			this.int_0 = left;
			this.int_1 = top;
			this.int_2 = right;
			this.int_3 = bottom;
		}

		// Token: 0x06001BA4 RID: 7076 RVA: 0x0000A2B5 File Offset: 0x000084B5
		public Rectangle method_0()
		{
			return new Rectangle(this.int_0, this.int_1, this.int_2 - this.int_0, this.int_3 - this.int_1);
		}

		// Token: 0x06001BA5 RID: 7077 RVA: 0x00056C20 File Offset: 0x00054E20
		public override string ToString()
		{
			return string.Format("{{X={0},Y={1},Width={2},Height={3}}}", new object[]
			{
				this.X,
				this.Y,
				this.Width,
				this.Height
			});
		}

		// Token: 0x04000959 RID: 2393
		public int int_0;

		// Token: 0x0400095A RID: 2394
		public int int_1;

		// Token: 0x0400095B RID: 2395
		public int int_2;

		// Token: 0x0400095C RID: 2396
		public int int_3;
	}
}
