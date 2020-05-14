using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;
using ns31;

namespace ns29
{
	// Token: 0x020004D2 RID: 1234
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	internal sealed class Class522 : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06002E0A RID: 11786 RVA: 0x000146E8 File Offset: 0x000128E8
		private Class522() : base(true)
		{
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x000146F1 File Offset: 0x000128F1
		public Class522(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(preexistingHandle);
		}

		// Token: 0x06002E0C RID: 11788 RVA: 0x00014701 File Offset: 0x00012901
		protected override bool ReleaseHandle()
		{
			return Class265.CloseHandle(this.handle);
		}
	}
}
