using System;
using ns17;
using ns23;

namespace ns22
{
	// Token: 0x02000371 RID: 881
	internal class Class338
	{
		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x0600226F RID: 8815 RVA: 0x0000E802 File Offset: 0x0000CA02
		public bool Populated
		{
			get
			{
				return this.bool_0;
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06002270 RID: 8816 RVA: 0x00074F2C File Offset: 0x0007312C
		// (set) Token: 0x06002271 RID: 8817 RVA: 0x00074F58 File Offset: 0x00073158
		public DateTime TimeStamp
		{
			get
			{
				return Class136.dateTime_0.AddSeconds(this.uint_1).ToLocalTime();
			}
			set
			{
				this.uint_1 = (uint)value.ToUniversalTime().Subtract(Class136.dateTime_0).TotalSeconds;
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06002272 RID: 8818 RVA: 0x0000E80A File Offset: 0x0000CA0A
		public bool Compressed
		{
			get
			{
				return ((int)this.ushort_0 & Class338.int_0) == Class338.int_0;
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x06002273 RID: 8819 RVA: 0x0000E81F File Offset: 0x0000CA1F
		// (set) Token: 0x06002274 RID: 8820 RVA: 0x00074F88 File Offset: 0x00073188
		public byte[] Data
		{
			get
			{
				if (!this.bool_0)
				{
					throw new InvalidOperationException("The MultiFileData has not been populated.");
				}
				if (this.Compressed)
				{
					return Class219.smethod_4(this.byte_0);
				}
				return this.byte_0;
			}
			set
			{
				if (value == null)
				{
					if (!this.bool_1)
					{
						this.uint_0 = 0U;
						this.uint_2 = 0U;
					}
					this.byte_0 = null;
					this.bool_0 = false;
					return;
				}
				if (this.Compressed)
				{
					this.byte_0 = Class219.smethod_3(value);
				}
				else
				{
					this.byte_0 = value;
				}
				this.uint_0 = (uint)value.Length;
				this.uint_2 = (uint)this.byte_0.Length;
				this.bool_0 = true;
			}
		}

		// Token: 0x06002275 RID: 8821 RVA: 0x0000E84E File Offset: 0x0000CA4E
		public void method_0(Class338 data)
		{
			data.byte_0 = this.byte_0;
			data.uint_2 = this.uint_2;
			data.uint_0 = this.uint_0;
			data.bool_0 = (data.byte_0 != null);
			data.bool_1 = false;
		}

		// Token: 0x06002276 RID: 8822 RVA: 0x000033EB File Offset: 0x000015EB
		protected Class338()
		{
		}

		// Token: 0x04000FCF RID: 4047
		private static readonly int int_0 = 8;

		// Token: 0x04000FD0 RID: 4048
		protected uint uint_0;

		// Token: 0x04000FD1 RID: 4049
		protected bool bool_0;

		// Token: 0x04000FD2 RID: 4050
		protected uint uint_1;

		// Token: 0x04000FD3 RID: 4051
		protected ushort ushort_0;

		// Token: 0x04000FD4 RID: 4052
		protected byte[] byte_0;

		// Token: 0x04000FD5 RID: 4053
		protected uint uint_2;

		// Token: 0x04000FD6 RID: 4054
		protected bool bool_1;
	}
}
