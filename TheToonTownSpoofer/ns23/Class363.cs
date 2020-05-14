using System;
using System.Security.AccessControl;
using System.Security.Principal;

namespace ns23
{
	// Token: 0x02000394 RID: 916
	internal static class Class363
	{
		// Token: 0x060023B4 RID: 9140 RVA: 0x0000F5A1 File Offset: 0x0000D7A1
		private static FileSystemAccessRule smethod_0(WellKnownSidType sid)
		{
			return new FileSystemAccessRule(new SecurityIdentifier(sid, null), FileSystemRights.FullControl, InheritanceFlags.ContainerInherit | InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060023B5 RID: 9141 RVA: 0x00078AE0 File Offset: 0x00076CE0
		public static DirectorySecurity GetDirectorySecurity
		{
			get
			{
				DirectorySecurity directorySecurity = new DirectorySecurity();
				directorySecurity.AddAccessRule(Class363.smethod_0(WellKnownSidType.CreatorOwnerSid));
				directorySecurity.AddAccessRule(Class363.smethod_0(WellKnownSidType.LocalSystemSid));
				directorySecurity.AddAccessRule(Class363.smethod_0(WellKnownSidType.BuiltinUsersSid));
				directorySecurity.AddAccessRule(Class363.smethod_0(WellKnownSidType.BuiltinAdministratorsSid));
				return directorySecurity;
			}
		}
	}
}
