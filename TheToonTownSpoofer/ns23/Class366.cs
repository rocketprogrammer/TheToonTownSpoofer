using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ns17;
using ns18;
using ns20;
using ns31;

namespace ns23
{
	// Token: 0x0200039C RID: 924
	internal sealed class Class366 : IDisposable
	{
		// Token: 0x060023D2 RID: 9170 RVA: 0x00079390 File Offset: 0x00077590
		public Class366(string fileName)
		{
			IntPtr intPtr = Class265.LoadImage(Marshal.GetHINSTANCE(base.GetType().Module), fileName, Enum46.const_2, 0, 0, Enum103.const_3);
			if (intPtr == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error(), string.Format(Class217.cultureInfo_0, Class366.string_0, new object[]
				{
					fileName
				}));
			}
			this.method_0(intPtr);
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0000F689 File Offset: 0x0000D889
		public Class366(IntPtr handle)
		{
			if (handle == IntPtr.Zero)
			{
				throw new ArgumentException(Class366.string_1);
			}
			this.method_0(handle);
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x00079404 File Offset: 0x00077604
		public Class366(int iEmbeddedWin32ResourceID, string sResourceTypeName)
		{
			IntPtr hinstance = Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]);
			IntPtr intPtr = Class265.FindResource(hinstance, "#" + iEmbeddedWin32ResourceID.ToString(Class217.cultureInfo_0), sResourceTypeName);
			if (intPtr == IntPtr.Zero)
			{
				throw new Win32Exception();
			}
			uint num = Class265.SizeofResource(hinstance, intPtr);
			if (num == 0U)
			{
				throw new Win32Exception();
			}
			IntPtr intPtr2 = Class265.LoadResource(hinstance, intPtr);
			if (intPtr2 == IntPtr.Zero)
			{
				throw new Win32Exception();
			}
			IntPtr intPtr3 = Class265.LockResource(intPtr2);
			if (intPtr3 == IntPtr.Zero)
			{
				throw new Win32Exception();
			}
			this.intptr_0 = Class265.CreateIconFromResource(intPtr3, num, false, 196608U);
			if (this.intptr_0 == IntPtr.Zero)
			{
				throw new Win32Exception();
			}
			this.method_0(this.intptr_0);
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060023D5 RID: 9173 RVA: 0x0000F6BB File Offset: 0x0000D8BB
		internal IntPtr Handle
		{
			get
			{
				return this.intptr_0;
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060023D6 RID: 9174 RVA: 0x0000F6C3 File Offset: 0x0000D8C3
		public Cursor Cursor
		{
			get
			{
				return this.cursor_0;
			}
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0000F6CB File Offset: 0x0000D8CB
		private void method_0(IntPtr cursor)
		{
			this.intptr_0 = cursor;
			if (this.intptr_0 != IntPtr.Zero)
			{
				this.cursor_0 = new Cursor(this.intptr_0);
			}
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x000794E8 File Offset: 0x000776E8
		~Class366()
		{
			this.method_1(false);
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x0000F6F7 File Offset: 0x0000D8F7
		public void Dispose()
		{
			this.method_1(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x00079518 File Offset: 0x00077718
		private void method_1(bool disposing)
		{
			if (this.intptr_0 != IntPtr.Zero)
			{
				Class265.DestroyCursor(this.intptr_0);
				this.intptr_0 = IntPtr.Zero;
			}
			if (disposing && this.cursor_0 != null)
			{
				this.cursor_0.Dispose();
				this.cursor_0 = null;
			}
		}

		// Token: 0x040010A7 RID: 4263
		private static readonly string string_0 = "Failure to load animated cursor '{0}'.";

		// Token: 0x040010A8 RID: 4264
		private static readonly string string_1 = "The handle is invalid.";

		// Token: 0x040010A9 RID: 4265
		private Cursor cursor_0;

		// Token: 0x040010AA RID: 4266
		private IntPtr intptr_0 = IntPtr.Zero;
	}
}
