using System;
using System.Drawing;
using ns17;

namespace ns29
{
	// Token: 0x020004C5 RID: 1221
	internal struct Struct56
	{
		// Token: 0x17000B47 RID: 2887
		// (get) Token: 0x06002DC5 RID: 11717 RVA: 0x0001600A File Offset: 0x0001420A
		public PointF Location
		{
			get
			{
				return new PointF(this.float_0, this.float_1);
			}
		}

		// Token: 0x17000B48 RID: 2888
		// (get) Token: 0x06002DC6 RID: 11718 RVA: 0x0001601D File Offset: 0x0001421D
		public bool IsDock
		{
			get
			{
				return this.float_0 == 0f && this.float_1 == 0f;
			}
		}

		// Token: 0x06002DC7 RID: 11719 RVA: 0x0001603B File Offset: 0x0001423B
		public Struct56(float x, float y, float z, float h)
		{
			this.float_0 = x;
			this.float_1 = y;
			this.float_2 = z;
			this.float_3 = h;
		}

		// Token: 0x06002DC8 RID: 11720 RVA: 0x000AFAF4 File Offset: 0x000ADCF4
		public static bool smethod_0(Struct56 a, Struct56 b)
		{
			return a.float_3 == b.float_3 && a.float_0 == b.float_0 && a.float_1 == b.float_1 && a.float_2 == b.float_2;
		}

		// Token: 0x06002DC9 RID: 11721 RVA: 0x0001605A File Offset: 0x0001425A
		public static bool smethod_1(Struct56 a, Struct56 b)
		{
			return !Struct56.smethod_0(a, b);
		}

		// Token: 0x06002DCA RID: 11722 RVA: 0x000AFB44 File Offset: 0x000ADD44
		public override bool Equals(object obj)
		{
			if (!(obj is Struct56))
			{
				return false;
			}
			Struct56 b = (Struct56)obj;
			return Struct56.smethod_0(this, b);
		}

		// Token: 0x06002DCB RID: 11723 RVA: 0x000AFB70 File Offset: 0x000ADD70
		public override int GetHashCode()
		{
			return Class227.smethod_2(14, 15, new object[]
			{
				this.float_3,
				this.float_0,
				this.float_1,
				this.float_2
			});
		}

		// Token: 0x06002DCC RID: 11724 RVA: 0x000AFBC8 File Offset: 0x000ADDC8
		public float method_0(PointF targetPosition)
		{
			double num = Math.Atan2((double)(targetPosition.Y - this.float_1), (double)(targetPosition.X - this.float_0));
			if (num > 0.0)
			{
				num = num * 180.0 / 3.141592653589793 - 90.0;
			}
			else
			{
				num = num * 180.0 / 3.141592653589793 + 270.0;
			}
			num %= 360.0;
			if (num < 0.0)
			{
				num += 360.0;
			}
			return (float)num;
		}

		// Token: 0x0400180B RID: 6155
		public static readonly Struct56 struct56_0 = new Struct56(0f, 0f, 0f, 0f);

		// Token: 0x0400180C RID: 6156
		public readonly float float_0;

		// Token: 0x0400180D RID: 6157
		public readonly float float_1;

		// Token: 0x0400180E RID: 6158
		public readonly float float_2;

		// Token: 0x0400180F RID: 6159
		public readonly float float_3;
	}
}
