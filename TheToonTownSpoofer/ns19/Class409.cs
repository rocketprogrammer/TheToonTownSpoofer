using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ns17;
using ns22;
using ns23;
using ns25;

namespace ns19
{
	// Token: 0x020003F7 RID: 1015
	internal sealed class Class409
	{
		// Token: 0x060026CF RID: 9935 RVA: 0x0008B740 File Offset: 0x00089940
		private static Class409 smethod_0()
		{
			Class409 @class = new Class409();
			try
			{
				@class.method_0(Environment.CommandLine);
			}
			catch (ArgumentNullException ex)
			{
				ex.smethod_1(new object[]
				{
					string.Format(Class217.cultureInfo_0, Class409.string_4, new object[]
					{
						Environment.CommandLine
					})
				});
			}
			catch (ArgumentException ex2)
			{
				ex2.smethod_1(new object[]
				{
					string.Format(Class217.cultureInfo_0, Class409.string_4, new object[]
					{
						Environment.CommandLine
					})
				});
			}
			return @class;
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060026D0 RID: 9936 RVA: 0x000114A4 File Offset: 0x0000F6A4
		public static Class409 Current
		{
			get
			{
				return Class409.lazy_0.Value;
			}
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000114B0 File Offset: 0x0000F6B0
		public Class409()
		{
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0008B7EC File Offset: 0x000899EC
		public Class409(string args)
		{
			this.method_0(args);
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x000114EF File Offset: 0x0000F6EF
		public ReadOnlyCollection<string> Values
		{
			get
			{
				return this.list_0.AsReadOnly();
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x060026D4 RID: 9940 RVA: 0x000114FC File Offset: 0x0000F6FC
		public ReadOnlyCollection<string> Switches
		{
			get
			{
				return this.list_1.AsReadOnly();
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x00011509 File Offset: 0x0000F709
		public ReadOnlyCollection<string> Flags
		{
			get
			{
				return this.list_2.AsReadOnly();
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060026D6 RID: 9942 RVA: 0x00011516 File Offset: 0x0000F716
		public ReadOnlyCollection<Struct27> FlagPairs
		{
			get
			{
				return this.list_4.AsReadOnly();
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x00011523 File Offset: 0x0000F723
		public ReadOnlyCollection<Struct27> SwitchPairs
		{
			get
			{
				return this.list_3.AsReadOnly();
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x060026D8 RID: 9944 RVA: 0x00011530 File Offset: 0x0000F730
		// (set) Token: 0x060026D9 RID: 9945 RVA: 0x00011538 File Offset: 0x0000F738
		public string OriginalString { get; private set; }

		// Token: 0x060026DA RID: 9946 RVA: 0x0008B840 File Offset: 0x00089A40
		public void method_0(string args)
		{
			this.OriginalString = args;
			this.list_0.Clear();
			this.list_1.Clear();
			this.list_2.Clear();
			this.list_4.Clear();
			this.list_3.Clear();
			if (string.IsNullOrEmpty(args))
			{
				return;
			}
			Regex regex = new Regex(Class409.string_3);
			try
			{
				if (regex.IsMatch(args))
				{
					foreach (object obj in regex.Matches(args))
					{
						Match match = (Match)obj;
						string value;
						if ((value = match.Groups[Class409.string_0].Value) != null)
						{
							if (!(value == "-"))
							{
								if (!(value == "/"))
								{
									if (value == "")
									{
										string value2 = match.Groups[Class409.string_2].Value;
										if (!Class336.smethod_0(value2, Application.ExecutablePath))
										{
											this.list_0.Add(value2);
										}
									}
								}
								else if (match.Groups[Class409.string_1].Value == string.Empty)
								{
									this.list_1.Add(match.Groups[Class409.string_2].Value);
								}
								else
								{
									this.list_3.Add(new Struct27(match.Groups[Class409.string_1].Value, match.Groups[Class409.string_2].Value));
								}
							}
							else if (match.Groups[Class409.string_1].Value == string.Empty)
							{
								this.list_2.Add(match.Groups[Class409.string_2].Value);
							}
							else
							{
								this.list_4.Add(new Struct27(match.Groups[Class409.string_1].Value, match.Groups[Class409.string_2].Value));
							}
						}
					}
				}
			}
			finally
			{
			}
		}

		// Token: 0x0400130E RID: 4878
		private static readonly string string_0 = "Prefix";

		// Token: 0x0400130F RID: 4879
		private static readonly string string_1 = "Key";

		// Token: 0x04001310 RID: 4880
		private static readonly string string_2 = "Value";

		// Token: 0x04001311 RID: 4881
		private static readonly string string_3 = string.Concat(new string[]
		{
			"(?<",
			Class409.string_0,
			">[-/]{1}){0,1}(?([\\w\\d]+[:=]{1})(?<",
			Class409.string_1,
			">[\\w\\d]+)[:=]{1}(?(\"{1})\"{1}(?<",
			Class409.string_2,
			">[^\"]+)\"{1}|(?<",
			Class409.string_2,
			">[^\"\\s]+))|(?(\"{1})\"{1}(?<",
			Class409.string_2,
			">[^\"]+)\"{1}|(?<",
			Class409.string_2,
			">[^\"\\s]+)))"
		});

		// Token: 0x04001312 RID: 4882
		private static readonly string string_4 = "Command line '{0}'";

		// Token: 0x04001313 RID: 4883
		private static Lazy<Class409> lazy_0 = new Lazy<Class409>(new Func<Class409>(Class409.smethod_0));

		// Token: 0x04001314 RID: 4884
		private List<string> list_0 = new List<string>();

		// Token: 0x04001315 RID: 4885
		private List<string> list_1 = new List<string>();

		// Token: 0x04001316 RID: 4886
		private List<string> list_2 = new List<string>();

		// Token: 0x04001317 RID: 4887
		private List<Struct27> list_3 = new List<Struct27>();

		// Token: 0x04001318 RID: 4888
		private List<Struct27> list_4 = new List<Struct27>();

		// Token: 0x04001319 RID: 4889
		[CompilerGenerated]
		private string string_5;
	}
}
