using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using ns17;

namespace ns28
{
	// Token: 0x020004A2 RID: 1186
	internal sealed class Class500
	{
		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06002C2D RID: 11309 RVA: 0x00014B56 File Offset: 0x00012D56
		public static Class500 Current
		{
			get
			{
				return Class500.lazy_0.Value;
			}
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x00014B62 File Offset: 0x00012D62
		public Class500(Type type)
		{
			if (type == null)
			{
				throw new ArgumentNullException("type");
			}
			this.assembly_0 = Assembly.GetAssembly(type);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x00014B8A File Offset: 0x00012D8A
		public Class500(Assembly assembly)
		{
			if (assembly == null)
			{
				throw new ArgumentNullException("assembly");
			}
			this.assembly_0 = assembly;
		}

		// Token: 0x06002C30 RID: 11312 RVA: 0x00014BAD File Offset: 0x00012DAD
		public Class500() : this(Assembly.GetExecutingAssembly())
		{
		}

		// Token: 0x06002C31 RID: 11313 RVA: 0x000AB174 File Offset: 0x000A9374
		private T method_0<T>() where T : Attribute
		{
			object[] customAttributes = this.assembly_0.GetCustomAttributes(typeof(T), false);
			if (customAttributes == null || customAttributes.Length <= 0)
			{
				throw new InvalidOperationException(string.Format(Class217.cultureInfo_0, Class500.string_0, new object[]
				{
					typeof(T).FullName
				}));
			}
			return (T)((object)customAttributes[0]);
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x00014BBA File Offset: 0x00012DBA
		public static bool IsRunningOnMono
		{
			get
			{
				if (Class500.nullable_0 == null)
				{
					Class500.nullable_0 = new bool?(Type.GetType("Mono.Runtime") != null);
				}
				return Class500.nullable_0.Value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06002C33 RID: 11315 RVA: 0x00014BEC File Offset: 0x00012DEC
		public string Title
		{
			get
			{
				return this.method_0<AssemblyTitleAttribute>().Title;
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x00014BF9 File Offset: 0x00012DF9
		public string Description
		{
			get
			{
				return this.method_0<AssemblyDescriptionAttribute>().Description;
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06002C35 RID: 11317 RVA: 0x00014C06 File Offset: 0x00012E06
		public string CompanyName
		{
			get
			{
				return this.method_0<AssemblyCompanyAttribute>().Company;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x00014C13 File Offset: 0x00012E13
		public string ProductName
		{
			get
			{
				return this.method_0<AssemblyProductAttribute>().Product;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06002C37 RID: 11319 RVA: 0x00014C20 File Offset: 0x00012E20
		public string Copyright
		{
			get
			{
				return this.method_0<AssemblyCopyrightAttribute>().Copyright;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x00014C2D File Offset: 0x00012E2D
		public string Trademark
		{
			get
			{
				return this.method_0<AssemblyTrademarkAttribute>().Trademark;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06002C39 RID: 11321 RVA: 0x00014C3A File Offset: 0x00012E3A
		public Version AssemblyVersion
		{
			get
			{
				return this.assembly_0.GetName().Version;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x00014C4C File Offset: 0x00012E4C
		public Version FileVersion
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return new Version(this.method_0<AssemblyFileVersionAttribute>().Version);
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06002C3B RID: 11323 RVA: 0x00014C5E File Offset: 0x00012E5E
		public string Guid
		{
			get
			{
				return this.method_0<GuidAttribute>().Value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x000AB1D8 File Offset: 0x000A93D8
		public string OriginalFilename
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(this.assembly_0.Location);
				return versionInfo.OriginalFilename;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000AB1FC File Offset: 0x000A93FC
		public string FileName
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(this.assembly_0.Location);
				return versionInfo.FileName;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06002C3E RID: 11326 RVA: 0x00014C6B File Offset: 0x00012E6B
		public string InformationalVersion
		{
			[SecurityPermission(SecurityAction.Demand, Flags = SecurityPermissionFlag.UnmanagedCode)]
			get
			{
				return this.method_0<AssemblyInformationalVersionAttribute>().InformationalVersion;
			}
		}

		// Token: 0x06002C3F RID: 11327 RVA: 0x00014C78 File Offset: 0x00012E78
		// Note: this type is marked as 'beforefieldinit'.
		static Class500()
		{
			if (Class500.func_0 == null)
			{
				Class500.func_0 = new Func<Class500>(Class500.smethod_0);
			}
			Class500.lazy_0 = new Lazy<Class500>(Class500.func_0);
			Class500.string_0 = "The custom attribute '{0}' could not be retrieved.";
		}

		// Token: 0x06002C40 RID: 11328 RVA: 0x00014CAB File Offset: 0x00012EAB
		[CompilerGenerated]
		private static Class500 smethod_0()
		{
			return new Class500();
		}

		// Token: 0x0400173A RID: 5946
		private static readonly Lazy<Class500> lazy_0;

		// Token: 0x0400173B RID: 5947
		private static readonly string string_0;

		// Token: 0x0400173C RID: 5948
		private Assembly assembly_0;

		// Token: 0x0400173D RID: 5949
		private static bool? nullable_0;

		// Token: 0x0400173E RID: 5950
		[CompilerGenerated]
		private static Func<Class500> func_0;
	}
}
