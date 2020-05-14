using System;
using System.Security.Permissions;
using Microsoft.Win32.SafeHandles;
using ns31;

namespace ns27
{
	// Token: 0x0200049A RID: 1178
	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	internal sealed class Class494 : SafeHandleZeroOrMinusOneIsInvalid
	{
		// Token: 0x06002BEC RID: 11244 RVA: 0x000146E8 File Offset: 0x000128E8
		private Class494() : base(true)
		{
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x000146F1 File Offset: 0x000128F1
		public Class494(IntPtr preexistingHandle, bool ownsHandle) : base(ownsHandle)
		{
			base.SetHandle(preexistingHandle);
		}

		// Token: 0x06002BEE RID: 11246 RVA: 0x00014701 File Offset: 0x00012901
		protected override bool ReleaseHandle()
		{
			return Class265.CloseHandle(this.handle);
		}
	}
}
