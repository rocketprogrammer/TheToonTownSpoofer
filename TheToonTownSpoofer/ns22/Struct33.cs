using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using ns18;
using ns29;

namespace ns22
{
	// Token: 0x0200036A RID: 874
	[StructLayout(LayoutKind.Explicit)]
	internal struct Struct33 : Interface17
	{
		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x06002233 RID: 8755 RVA: 0x0000E504 File Offset: 0x0000C704
		// (set) Token: 0x06002234 RID: 8756 RVA: 0x0000E50C File Offset: 0x0000C70C
		public byte B
		{
			[DebuggerStepThrough]
			get
			{
				return this.byte_0;
			}
			[DebuggerStepThrough]
			set
			{
				this.byte_0 = value;
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06002235 RID: 8757 RVA: 0x0000E515 File Offset: 0x0000C715
		// (set) Token: 0x06002236 RID: 8758 RVA: 0x0000E51D File Offset: 0x0000C71D
		public byte G
		{
			[DebuggerStepThrough]
			get
			{
				return this.byte_1;
			}
			[DebuggerStepThrough]
			set
			{
				this.byte_1 = value;
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06002237 RID: 8759 RVA: 0x0000E526 File Offset: 0x0000C726
		// (set) Token: 0x06002238 RID: 8760 RVA: 0x0000E52E File Offset: 0x0000C72E
		public byte R
		{
			[DebuggerStepThrough]
			get
			{
				return this.byte_2;
			}
			[DebuggerStepThrough]
			set
			{
				this.byte_2 = value;
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06002239 RID: 8761 RVA: 0x0000E537 File Offset: 0x0000C737
		// (set) Token: 0x0600223A RID: 8762 RVA: 0x0000E53F File Offset: 0x0000C73F
		public byte A
		{
			[DebuggerStepThrough]
			get
			{
				return this.byte_3;
			}
			[DebuggerStepThrough]
			set
			{
				this.byte_3 = value;
			}
		}

		// Token: 0x0600223B RID: 8763 RVA: 0x0000E548 File Offset: 0x0000C748
		public Struct33(byte r, byte g, byte b)
		{
			this = default(Struct33);
			this.R = r;
			this.G = g;
			this.B = b;
			this.A = byte.MaxValue;
		}

		// Token: 0x0600223C RID: 8764 RVA: 0x0000E571 File Offset: 0x0000C771
		public Struct33(byte r, byte g, byte b, byte a)
		{
			this = default(Struct33);
			this.R = r;
			this.G = g;
			this.B = b;
			this.A = a;
		}

		// Token: 0x0600223D RID: 8765 RVA: 0x0000E597 File Offset: 0x0000C797
		public static Color smethod_0(Struct33 c)
		{
			return Color.FromArgb((int)c.A, (int)c.R, (int)c.G, (int)c.B);
		}

		// Token: 0x0600223E RID: 8766 RVA: 0x0000E5BA File Offset: 0x0000C7BA
		public static Struct33 smethod_1(Color c)
		{
			return new Struct33(c.R, c.G, c.B, c.A);
		}

		// Token: 0x0600223F RID: 8767 RVA: 0x0000E5DD File Offset: 0x0000C7DD
		public static Struct33 smethod_2(Struct54 c)
		{
			return new Struct33(c.R, c.G, c.B, byte.MaxValue);
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0000E5FE File Offset: 0x0000C7FE
		public override int GetHashCode()
		{
			return this.int_0;
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0000E606 File Offset: 0x0000C806
		public override bool Equals(object obj)
		{
			if (obj is Struct33)
			{
				return this.int_0 == ((Struct33)obj).int_0;
			}
			return base.Equals(obj);
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0000E635 File Offset: 0x0000C835
		public static bool smethod_3(Struct33 left, Struct33 right)
		{
			return left.int_0 == right.int_0;
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0000E647 File Offset: 0x0000C847
		public static bool smethod_4(Struct33 left, Struct33 right)
		{
			return !Struct33.smethod_3(left, right);
		}

		// Token: 0x04000FA3 RID: 4003
		public static readonly Struct33 struct33_0 = new Struct33(0, 0, 0, 0);

		// Token: 0x04000FA4 RID: 4004
		[FieldOffset(0)]
		private byte byte_0;

		// Token: 0x04000FA5 RID: 4005
		[FieldOffset(1)]
		private byte byte_1;

		// Token: 0x04000FA6 RID: 4006
		[FieldOffset(2)]
		private byte byte_2;

		// Token: 0x04000FA7 RID: 4007
		[FieldOffset(3)]
		private byte byte_3;

		// Token: 0x04000FA8 RID: 4008
		[FieldOffset(0)]
		private int int_0;
	}
}
