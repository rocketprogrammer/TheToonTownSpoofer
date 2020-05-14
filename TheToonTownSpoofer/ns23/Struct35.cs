using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns17;

namespace ns23
{
	// Token: 0x02000395 RID: 917
	internal struct Struct35 : IEquatable<Struct35>, IEquatable<string>
	{
		// Token: 0x060023B6 RID: 9142 RVA: 0x00078B28 File Offset: 0x00076D28
		public unsafe Struct35(string str)
		{
			if (str == null)
			{
				throw new ArgumentNullException("str");
			}
			if (str.Length > Struct35.int_0)
			{
				throw new ArgumentException(Struct35.string_0);
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				for (int i = 0; i < str.Length; i++)
				{
					ptr[i] = str[i];
				}
				ptr[str.Length] = '\0';
			}
			this.byte_0 = (byte)str.Length;
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x00078BA8 File Offset: 0x00076DA8
		public unsafe Struct35(Struct35 str, int startIndex, int length)
		{
			if (startIndex >= (int)str.byte_0)
			{
				throw new ArgumentException("The start index is too large.");
			}
			if (length > (int)str.byte_0 - startIndex)
			{
				throw new ArgumentException("The length is too large.");
			}
			if (length > Struct35.int_0)
			{
				throw new ArgumentException(Struct35.string_0);
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				Class216.smethod_2(ptr, &str.struct36_0.char_0 + startIndex, length);
				ptr[length] = '\0';
			}
			this.byte_0 = (byte)length;
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x00078C30 File Offset: 0x00076E30
		public unsafe Struct35(char* str, int length)
		{
			if (length > Struct35.int_0)
			{
				throw new ArgumentException(Struct35.string_0);
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				Class216.smethod_2(ptr, str, length);
				ptr[length] = '\0';
			}
			this.byte_0 = (byte)length;
		}

		// Token: 0x1700093E RID: 2366
		public unsafe char this[int index]
		{
			get
			{
				fixed (char* ptr = &this.struct36_0.char_0)
				{
					return ptr[index];
				}
			}
			set
			{
				fixed (char* ptr = &this.struct36_0.char_0)
				{
					ptr[index] = value;
				}
			}
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x00078CCC File Offset: 0x00076ECC
		public unsafe void method_0(char c)
		{
			if ((int)(this.byte_0 + 1) > Struct35.int_0)
			{
				throw new InvalidOperationException(Struct35.string_1);
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				ref short ptr2 = ref *(short*)ptr;
				byte b;
				this.byte_0 = (b = this.byte_0) + 1;
				*(ref ptr2 + (IntPtr)b * 2) = (short)c;
				ptr[this.byte_0] = '\0';
			}
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x00078D2C File Offset: 0x00076F2C
		public unsafe void method_1(Struct35 str)
		{
			if ((int)(this.byte_0 + str.byte_0) > Struct35.int_0)
			{
				throw new InvalidOperationException(Struct35.string_1);
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				Class216.smethod_3(ptr + this.byte_0, &str.struct36_0.char_0, (int)str.byte_0);
				this.byte_0 += str.byte_0;
				ptr[this.byte_0] = '\0';
			}
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x00078DB4 File Offset: 0x00076FB4
		public unsafe void method_2(string str)
		{
			if ((int)this.byte_0 + str.Length > Struct35.int_0)
			{
				throw new InvalidOperationException(Struct35.string_1);
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				for (int i = 0; i < str.Length; i++)
				{
					ref short ptr2 = ref *(short*)ptr;
					byte b;
					this.byte_0 = (b = this.byte_0) + 1;
					*(ref ptr2 + (IntPtr)b * 2) = (short)str[i];
				}
				ptr[this.byte_0] = '\0';
			}
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00078E30 File Offset: 0x00077030
		public unsafe int method_3(Struct35 str)
		{
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				int num = Class216.smethod_1(ptr, &str.struct36_0.char_0, (int)((this.byte_0 < str.byte_0) ? this.byte_0 : str.byte_0));
				int result;
				if (num == 0)
				{
					result = (int)(this.byte_0 - str.byte_0);
				}
				else
				{
					result = num;
				}
				return result;
			}
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x00078E98 File Offset: 0x00077098
		public unsafe bool method_4(Struct35 str)
		{
			if (str.byte_0 > this.byte_0)
			{
				return false;
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				return Class216.smethod_1(ptr + (this.byte_0 - str.byte_0), &str.struct36_0.char_0, (int)str.byte_0) == 0;
			}
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0000F5B7 File Offset: 0x0000D7B7
		public override bool Equals(object other)
		{
			if (other is Struct35)
			{
				return this.Equals((Struct35)other);
			}
			return other is string && this.Equals((string)other);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x00078EF8 File Offset: 0x000770F8
		public unsafe bool Equals(Struct35 other)
		{
			if (this.byte_0 != other.byte_0)
			{
				return false;
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				for (int i = 0; i < (int)other.byte_0; i++)
				{
					if (ptr[i] != (&other.struct36_0.char_0)[i])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00078F60 File Offset: 0x00077160
		public unsafe bool Equals(string other)
		{
			if ((int)this.byte_0 != other.Length)
			{
				return false;
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				for (int i = 0; i < other.Length; i++)
				{
					if (ptr[i] != other[i])
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00078FB8 File Offset: 0x000771B8
		public unsafe int method_5(char c)
		{
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				char* ptr2 = Class216.smethod_0(ptr, c, (int)this.byte_0);
				int result;
				if (ptr2 != null)
				{
					result = (int)((long)(ptr2 - ptr));
				}
				else
				{
					result = -1;
				}
				return result;
			}
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0000F5E4 File Offset: 0x0000D7E4
		public override int GetHashCode()
		{
			return 352654597 * this.ToString().GetHashCode();
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x00078FF8 File Offset: 0x000771F8
		public unsafe bool method_6(Struct35 str)
		{
			if (str.byte_0 > this.byte_0)
			{
				return false;
			}
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				return Class216.smethod_1(ptr, &str.struct36_0.char_0, (int)str.byte_0) == 0;
			}
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0000F5FD File Offset: 0x0000D7FD
		public Struct35 method_7(int startIndex)
		{
			return this.method_8(startIndex, (int)this.byte_0 - startIndex);
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0000F60E File Offset: 0x0000D80E
		public Struct35 method_8(int startIndex, int length)
		{
			return new Struct35(this, startIndex, length);
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00079044 File Offset: 0x00077244
		public unsafe override string ToString()
		{
			fixed (char* ptr = &this.struct36_0.char_0)
			{
				return new string(ptr, 0, (int)this.byte_0);
			}
		}

		// Token: 0x04001077 RID: 4215
		private static readonly string string_0 = "The string must be less than 256 characters in length.";

		// Token: 0x04001078 RID: 4216
		private static readonly string string_1 = "There is not enough storage space.";

		// Token: 0x04001079 RID: 4217
		public static readonly int int_0 = 255;

		// Token: 0x0400107A RID: 4218
		[FixedBuffer(typeof(char), 256)]
		public Struct35.Struct36 struct36_0;

		// Token: 0x0400107B RID: 4219
		public byte byte_0;

		// Token: 0x02000396 RID: 918
		[CompilerGenerated]
		[UnsafeValueType]
		[StructLayout(LayoutKind.Sequential, Size = 512)]
		internal struct Struct36
		{
			// Token: 0x0400107C RID: 4220
			public char char_0;
		}
	}
}
