using System;
using System.Runtime.InteropServices;

namespace ns0
{
	// Token: 0x02000019 RID: 25
	internal sealed class Class9
	{
		// Token: 0x06000027 RID: 39
		[DllImport("fusion", CharSet = CharSet.Auto)]
		internal static extern int CreateAssemblyCache(out Class9.Interface4 ppAsmCache, uint dwReserved);

		// Token: 0x06000028 RID: 40 RVA: 0x000177B4 File Offset: 0x000159B4
		public static bool smethod_0(string string_0)
		{
			Class9.Interface4 @interface = null;
			int num = Class9.CreateAssemblyCache(out @interface, 0U);
			if (num != 0)
			{
				return false;
			}
			num = @interface.imethod_4(0U, string_0, IntPtr.Zero);
			return num == 0;
		}

		// Token: 0x0200001A RID: 26
		public struct Struct13
		{
			// Token: 0x04000047 RID: 71
			public int int_0;

			// Token: 0x04000048 RID: 72
			public int int_1;
		}

		// Token: 0x0200001B RID: 27
		public struct Struct14
		{
			// Token: 0x04000049 RID: 73
			public Class9.Struct13 struct13_0;

			// Token: 0x0400004A RID: 74
			public long long_0;

			// Token: 0x0400004B RID: 75
			public Guid guid_0;

			// Token: 0x0400004C RID: 76
			public Class9.Struct13 struct13_1;

			// Token: 0x0400004D RID: 77
			public int int_0;

			// Token: 0x0400004E RID: 78
			public int int_1;

			// Token: 0x0400004F RID: 79
			public int int_2;

			// Token: 0x04000050 RID: 80
			public Class9.Struct13 struct13_2;

			// Token: 0x04000051 RID: 81
			public string string_0;

			// Token: 0x04000052 RID: 82
			public int int_3;

			// Token: 0x04000053 RID: 83
			public int int_4;
		}

		// Token: 0x0200001C RID: 28
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[Guid("0000000c-0000-0000-C000-000000000046")]
		[ComImport]
		public interface Interface0
		{
			// Token: 0x0600002A RID: 42
			void imethod_0(IntPtr pv, uint cb, out uint pcbRead);

			// Token: 0x0600002B RID: 43
			void imethod_1(IntPtr pv, uint cb, out uint pcbWritten);

			// Token: 0x0600002C RID: 44
			void imethod_2(long dlibMove, uint dwOrigin, out ulong plibNewPosition);

			// Token: 0x0600002D RID: 45
			void imethod_3(ulong libNewSize);

			// Token: 0x0600002E RID: 46
			void imethod_4(Class9.Interface0 pstm, ulong cb, out ulong pcbRead, out ulong pcbWritten);

			// Token: 0x0600002F RID: 47
			void imethod_5(uint grfCommitFlags);

			// Token: 0x06000030 RID: 48
			void imethod_6();

			// Token: 0x06000031 RID: 49
			void imethod_7(ulong libOffset, ulong cb, uint dwLockType);

			// Token: 0x06000032 RID: 50
			void imethod_8(ulong libOffset, ulong cb, uint dwLockType);

			// Token: 0x06000033 RID: 51
			void imethod_9(out Class9.Struct14 pstatstg, uint grfStatFlag);

			// Token: 0x06000034 RID: 52
			void imethod_10(out Class9.Interface0 ppstm);
		}

		// Token: 0x0200001D RID: 29
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[Guid("7c23ff90-33af-11d3-95da-00a024a85b51")]
		[ComImport]
		internal interface Interface1
		{
			// Token: 0x06000035 RID: 53
			void imethod_0(Class9.Interface2 pName);

			// Token: 0x06000036 RID: 54
			void imethod_1(out Class9.Interface2 ppName);

			// Token: 0x06000037 RID: 55
			void imethod_2([MarshalAs(UnmanagedType.LPWStr)] string szName, int pvValue, uint cbValue, uint dwFlags);

			// Token: 0x06000038 RID: 56
			void imethod_3([MarshalAs(UnmanagedType.LPWStr)] string szName, out int pvValue, ref uint pcbValue, uint dwFlags);

			// Token: 0x06000039 RID: 57
			void imethod_4(out int wzDynamicDir, ref uint pdwSize);
		}

		// Token: 0x0200001E RID: 30
		[Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		internal interface Interface2
		{
			// Token: 0x0600003A RID: 58
			[PreserveSig]
			int imethod_0(uint PropertyId, IntPtr pvProperty, uint cbProperty);

			// Token: 0x0600003B RID: 59
			[PreserveSig]
			int imethod_1(uint PropertyId, IntPtr pvProperty, ref uint pcbProperty);

			// Token: 0x0600003C RID: 60
			[PreserveSig]
			int imethod_2();

			// Token: 0x0600003D RID: 61
			[PreserveSig]
			int imethod_3(IntPtr szDisplayName, ref uint pccDisplayName, uint dwDisplayFlags);

			// Token: 0x0600003E RID: 62
			[PreserveSig]
			int imethod_4(object refIID, object pAsmBindSink, Class9.Interface1 pApplicationContext, [MarshalAs(UnmanagedType.LPWStr)] string szCodeBase, long llFlags, int pvReserved, uint cbReserved, out int ppv);

			// Token: 0x0600003F RID: 63
			[PreserveSig]
			int imethod_5(out uint lpcwBuffer, out int pwzName);

			// Token: 0x06000040 RID: 64
			[PreserveSig]
			int imethod_6(out uint pdwVersionHi, out uint pdwVersionLow);

			// Token: 0x06000041 RID: 65
			[PreserveSig]
			int imethod_7(Class9.Interface2 pName, uint dwCmpFlags);

			// Token: 0x06000042 RID: 66
			[PreserveSig]
			int imethod_8(out Class9.Interface2 pName);
		}

		// Token: 0x0200001F RID: 31
		[Guid("9e3aaeb4-d1cd-11d2-bab9-00c04f8eceae")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		internal interface Interface3
		{
			// Token: 0x06000043 RID: 67
			void imethod_0([MarshalAs(UnmanagedType.LPWStr)] string pszName, uint dwFormat, uint dwFlags, uint dwMaxSize, out Class9.Interface0 ppStream);

			// Token: 0x06000044 RID: 68
			void imethod_1(Class9.Interface2 pName);

			// Token: 0x06000045 RID: 69
			void imethod_2(uint dwFlags);

			// Token: 0x06000046 RID: 70
			void imethod_3(uint dwFlags);
		}

		// Token: 0x02000020 RID: 32
		[Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
		[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
		[ComImport]
		internal interface Interface4
		{
			// Token: 0x06000047 RID: 71
			[PreserveSig]
			int imethod_0(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pvReserved, out uint pulDisposition);

			// Token: 0x06000048 RID: 72
			[PreserveSig]
			int imethod_1(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName, IntPtr pAsmInfo);

			// Token: 0x06000049 RID: 73
			[PreserveSig]
			int imethod_2(uint dwFlags, IntPtr pvReserved, out Class9.Interface3 ppAsmItem, [MarshalAs(UnmanagedType.LPWStr)] string pszAssemblyName);

			// Token: 0x0600004A RID: 74
			[PreserveSig]
			int imethod_3(out object ppAsmScavenger);

			// Token: 0x0600004B RID: 75
			[PreserveSig]
			int imethod_4(uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string pszManifestFilePath, IntPtr pvReserved);
		}
	}
}
