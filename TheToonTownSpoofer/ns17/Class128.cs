using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns28;
using ns30;
using ns31;

namespace ns17
{
	// Token: 0x02000275 RID: 629
	internal sealed class Class128 : Class123
	{
		// Token: 0x170007AE RID: 1966
		// (get) Token: 0x06001A71 RID: 6769 RVA: 0x0000966C File Offset: 0x0000786C
		// (set) Token: 0x06001A72 RID: 6770 RVA: 0x00009674 File Offset: 0x00007874
		public IntPtr Memory { get; private set; }

		// Token: 0x170007AF RID: 1967
		// (get) Token: 0x06001A73 RID: 6771 RVA: 0x0000967D File Offset: 0x0000787D
		// (set) Token: 0x06001A74 RID: 6772 RVA: 0x00009685 File Offset: 0x00007885
		public int Size { get; private set; }

		// Token: 0x06001A75 RID: 6773 RVA: 0x0004E418 File Offset: 0x0004C618
		private static int smethod_0(Type structType)
		{
			int result;
			lock (Class128.dictionary_0)
			{
				int num;
				if (Class128.dictionary_0.ContainsKey(structType))
				{
					num = Class128.dictionary_0[structType];
				}
				else
				{
					Class128.dictionary_0.Add(structType, num = Marshal.SizeOf(structType));
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06001A76 RID: 6774 RVA: 0x0000968E File Offset: 0x0000788E
		public static IntPtr smethod_1(Class128 memory)
		{
			return memory.Memory;
		}

		// Token: 0x06001A77 RID: 6775 RVA: 0x0004E484 File Offset: 0x0004C684
		public unsafe static void* smethod_2(Class128 memory)
		{
			return memory.Memory.ToPointer();
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x00009696 File Offset: 0x00007896
		public Class128(IntPtr memory) : this(memory, 0)
		{
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x000096A0 File Offset: 0x000078A0
		public Class128(IntPtr memory, int offset) : this(memory, offset, 0)
		{
		}

		// Token: 0x06001A7A RID: 6778 RVA: 0x000096AB File Offset: 0x000078AB
		public Class128(IntPtr memory, int offset, int size)
		{
			this.Memory = memory.smethod_11(offset);
			this.Size = size;
		}

		// Token: 0x06001A7B RID: 6779 RVA: 0x000096C7 File Offset: 0x000078C7
		protected override void vmethod_0()
		{
			this.Memory = IntPtr.Zero;
			this.Size = 0;
			base.vmethod_0();
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x000096E1 File Offset: 0x000078E1
		public void method_4<T>()
		{
			this.method_5<T>(0);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x000096EA File Offset: 0x000078EA
		public void method_5<T>(int index)
		{
			this.method_6<T>(0, index);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x0004E4A0 File Offset: 0x0004C6A0
		public void method_6<T>(int offset, int index)
		{
			if (index == 0)
			{
				Marshal.DestroyStructure(this.Memory.smethod_11(offset), typeof(T));
				return;
			}
			Marshal.DestroyStructure(this.Memory.smethod_11(offset + Class128.smethod_0(typeof(T)) * index), typeof(T));
		}

		// Token: 0x06001A7F RID: 6783 RVA: 0x000096F4 File Offset: 0x000078F4
		public static T smethod_3<T>(IntPtr ptr)
		{
			return (T)((object)Marshal.PtrToStructure(ptr, typeof(T)));
		}

		// Token: 0x06001A80 RID: 6784 RVA: 0x0000970B File Offset: 0x0000790B
		public string method_7(int offset)
		{
			return Marshal.PtrToStringAnsi(this.Memory.smethod_11(offset));
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x0000971E File Offset: 0x0000791E
		public string method_8(int offset, int length)
		{
			return Marshal.PtrToStringAnsi(this.Memory.smethod_11(offset), length);
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x00009732 File Offset: 0x00007932
		public byte[] method_9(int length)
		{
			return this.method_10(0, length);
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x0004E4FC File Offset: 0x0004C6FC
		public byte[] method_10(int offset, int length)
		{
			byte[] array = new byte[length];
			this.method_12(offset, array, 0, length);
			return array;
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x0000973C File Offset: 0x0000793C
		public void method_11(byte[] buffer, int startIndex, int length)
		{
			this.method_12(0, buffer, startIndex, length);
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x00009748 File Offset: 0x00007948
		public void method_12(int offset, byte[] buffer, int startIndex, int length)
		{
			Marshal.Copy(this.Memory.smethod_11(offset), buffer, startIndex, length);
		}

		// Token: 0x06001A86 RID: 6790 RVA: 0x0000975F File Offset: 0x0000795F
		public int method_13(int offset)
		{
			return this.method_14(offset, 0);
		}

		// Token: 0x06001A87 RID: 6791 RVA: 0x00009769 File Offset: 0x00007969
		public unsafe int method_14(int offset, int index)
		{
			return *(int*)((byte*)((byte*)((void*)this.Memory) + offset) + (IntPtr)index * 4);
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0004E51C File Offset: 0x0004C71C
		public int[] method_15(int offset, int count)
		{
			int[] array = new int[count];
			Marshal.Copy(this.Memory.smethod_11(offset), array, 0, count);
			return array;
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0000977E File Offset: 0x0000797E
		public IntPtr method_16(int offset)
		{
			return this.method_17(offset, 0);
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x00009788 File Offset: 0x00007988
		public unsafe IntPtr method_17(int offset, int index)
		{
			return *(IntPtr*)((byte*)((byte*)((void*)this.Memory) + offset) + (IntPtr)index * (IntPtr)sizeof(IntPtr));
		}

		// Token: 0x06001A8B RID: 6795 RVA: 0x000097A6 File Offset: 0x000079A6
		public void method_18(IntPtr buffer, int destOffset, int srcOffset, int length)
		{
			Class265.RtlMoveMemory(buffer.smethod_11(destOffset), this.Memory.smethod_11(srcOffset), length.smethod_18());
		}

		// Token: 0x06001A8C RID: 6796 RVA: 0x000097C7 File Offset: 0x000079C7
		public uint method_19(int offset)
		{
			return this.method_20(offset, 0);
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x000097D1 File Offset: 0x000079D1
		public unsafe uint method_20(int offset, int index)
		{
			return *(uint*)((byte*)((byte*)((void*)this.Memory) + offset) + (IntPtr)index * 4);
		}

		// Token: 0x06001A8E RID: 6798 RVA: 0x000097E6 File Offset: 0x000079E6
		public T method_21<T>() where T : struct
		{
			return this.method_22<T>(0);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x000097EF File Offset: 0x000079EF
		public T method_22<T>(int index) where T : struct
		{
			return this.method_23<T>(0, index);
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0004E548 File Offset: 0x0004C748
		public T method_23<T>(int offset, int index) where T : struct
		{
			if (index == 0)
			{
				return (T)((object)Marshal.PtrToStructure(this.Memory.smethod_11(offset), typeof(T)));
			}
			return (T)((object)Marshal.PtrToStructure(this.Memory.smethod_11(offset + Class128.smethod_0(typeof(T)) * index), typeof(T)));
		}

		// Token: 0x06001A91 RID: 6801 RVA: 0x000097F9 File Offset: 0x000079F9
		public string method_24(int offset)
		{
			return Marshal.PtrToStringUni(this.Memory.smethod_11(offset));
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0000980C File Offset: 0x00007A0C
		public string method_25(int offset, int length)
		{
			return Marshal.PtrToStringUni(this.Memory.smethod_11(offset), length);
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x00009820 File Offset: 0x00007A20
		public void method_26(int offset, int length, byte value)
		{
			Class265.RtlFillMemory(this.Memory.smethod_11(offset), length.smethod_18(), value);
		}

		// Token: 0x06001A94 RID: 6804 RVA: 0x0000983A File Offset: 0x00007A3A
		public unsafe void method_27(int offset, byte b)
		{
			((byte*)((void*)this.Memory))[offset] = b;
		}

		// Token: 0x06001A95 RID: 6805 RVA: 0x0000984B File Offset: 0x00007A4B
		public void method_28(int offset, byte[] b)
		{
			Marshal.Copy(b, 0, this.Memory.smethod_11(offset), b.Length);
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x00009863 File Offset: 0x00007A63
		public unsafe void method_29(int offset, short i)
		{
			*(short*)((byte*)((void*)this.Memory) + offset) = i;
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x00009874 File Offset: 0x00007A74
		public unsafe void method_30(int offset, int i)
		{
			*(int*)((byte*)((void*)this.Memory) + offset) = i;
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x00009885 File Offset: 0x00007A85
		public unsafe void method_31(int offset, IntPtr i)
		{
			*(IntPtr*)((byte*)((void*)this.Memory) + offset) = i;
		}

		// Token: 0x06001A99 RID: 6809 RVA: 0x0000989A File Offset: 0x00007A9A
		public void method_32(int offset, IntPtr buffer, int length)
		{
			Class265.RtlMoveMemory(this.Memory.smethod_11(offset), buffer, length.smethod_18());
		}

		// Token: 0x06001A9A RID: 6810 RVA: 0x000098B4 File Offset: 0x00007AB4
		public void method_33<T>(T s) where T : struct
		{
			this.method_34<T>(0, s);
		}

		// Token: 0x06001A9B RID: 6811 RVA: 0x000098BE File Offset: 0x00007ABE
		public void method_34<T>(int index, T s) where T : struct
		{
			this.method_35<T>(0, index, s);
		}

		// Token: 0x06001A9C RID: 6812 RVA: 0x0004E5AC File Offset: 0x0004C7AC
		public void method_35<T>(int offset, int index, T s) where T : struct
		{
			if (index == 0)
			{
				Marshal.StructureToPtr(s, this.Memory.smethod_11(offset), false);
				return;
			}
			Marshal.StructureToPtr(s, this.Memory.smethod_11(offset + Class128.smethod_0(typeof(T)) * index), false);
		}

		// Token: 0x06001A9D RID: 6813 RVA: 0x0004E600 File Offset: 0x0004C800
		public unsafe void method_36(int offset, string s)
		{
			fixed (char* value = s)
			{
				this.method_32(offset, (IntPtr)((void*)value), s.Length * 2);
			}
		}

		// Token: 0x06001A9E RID: 6814 RVA: 0x000098C9 File Offset: 0x00007AC9
		public void method_37(int offset, int length)
		{
			Class265.RtlZeroMemory(this.Memory.smethod_11(offset), length.smethod_18());
		}

		// Token: 0x040007FA RID: 2042
		private static Dictionary<Type, int> dictionary_0 = new Dictionary<Type, int>();

		// Token: 0x040007FB RID: 2043
		[CompilerGenerated]
		private IntPtr intptr_0;

		// Token: 0x040007FC RID: 2044
		[CompilerGenerated]
		private int int_0;
	}
}
