using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using ns20;
using ns21;
using ns24;
using ns25;
using ns28;

namespace ns16
{
	// Token: 0x020003E4 RID: 996
	internal sealed class Class402
	{
		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x0600260F RID: 9743 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		public ReadOnlyCollection<KeyValuePair<Struct43, Class319>> Patches
		{
			get
			{
				if (this.list_0 == null)
				{
					return null;
				}
				if (this.readOnlyCollection_0 == null)
				{
					this.readOnlyCollection_0 = this.list_0.AsReadOnly();
				}
				return this.readOnlyCollection_0;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06002610 RID: 9744 RVA: 0x00010DF3 File Offset: 0x0000EFF3
		// (set) Token: 0x06002611 RID: 9745 RVA: 0x00010DFB File Offset: 0x0000EFFB
		public Uri DownloadUri { get; private set; }

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x00010E04 File Offset: 0x0000F004
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x00010E0C File Offset: 0x0000F00C
		public Struct43 Hash { get; private set; }

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x00010E15 File Offset: 0x0000F015
		// (set) Token: 0x06002615 RID: 9749 RVA: 0x00010E1D File Offset: 0x0000F01D
		public Version MinimumVersion { get; private set; }

		// Token: 0x06002616 RID: 9750 RVA: 0x00010E26 File Offset: 0x0000F026
		private Class402(Struct43 hash, Uri downloadUri, Version mininumVersion, List<KeyValuePair<Struct43, Class319>> patches)
		{
			if (downloadUri == null)
			{
				throw new ArgumentNullException("downloadUri");
			}
			this.Hash = hash;
			this.DownloadUri = downloadUri;
			this.MinimumVersion = mininumVersion;
			this.list_0 = patches;
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00086590 File Offset: 0x00084790
		public static bool smethod_0(string data, bool loaderPack, out Class402 parser)
		{
			parser = null;
			string[] array = data.Split(new char[]
			{
				'\n',
				'\r'
			}, StringSplitOptions.RemoveEmptyEntries);
			Version mininumVersion = null;
			Uri uri = null;
			Struct43 hash = Struct43.struct43_0;
			foreach (string text in array)
			{
				if (!text.StartsWith("#"))
				{
					string[] array2 = text.Split(new char[]
					{
						'='
					});
					if (array2.Length == 2)
					{
						if (string.IsNullOrEmpty(array2[1]))
						{
							return false;
						}
						string a;
						if ((a = array2[0]) != null)
						{
							if (!(a == "minimumversion"))
							{
								if (!(a == "hash"))
								{
									if (a == "downloadurl")
									{
										Uri uri2;
										if (!Uri.TryCreate(array2[1], UriKind.Absolute, out uri2))
										{
											return false;
										}
										if (!uri2.smethod_0())
										{
											return false;
										}
										uri = uri2;
									}
								}
								else
								{
									if (!array2[1].smethod_13())
									{
										return false;
									}
									hash = new Struct43(array2[1]);
								}
							}
							else
							{
								Regex regex = new Regex("^(?<major>(\\d+))\\.(?<minor>(\\d+))\\.(?<build>(\\d+))$");
								if (regex.IsMatch(array2[1]))
								{
									Match match = regex.Match(array2[1]);
									int major = int.Parse(match.Groups["major"].Value);
									int minor = int.Parse(match.Groups["minor"].Value);
									int build = int.Parse(match.Groups["build"].Value);
									mininumVersion = new Version(major, minor, build, 0);
								}
							}
						}
					}
				}
			}
			if (uri == null)
			{
				return false;
			}
			parser = new Class402(hash, uri, mininumVersion, null);
			return true;
		}

		// Token: 0x06002618 RID: 9752 RVA: 0x00086750 File Offset: 0x00084950
		public static bool smethod_1(string data, bool loaderPack, out Class402 parser)
		{
			parser = null;
			string[] array = data.Split(new char[]
			{
				'\n',
				'\r'
			}, StringSplitOptions.RemoveEmptyEntries);
			List<KeyValuePair<Struct43, Class319>> patches = null;
			Uri uri = null;
			Struct43 hash = Struct43.struct43_0;
			Version version = null;
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i];
				if (!text.StartsWith("#"))
				{
					string[] array2 = text.Split(new char[]
					{
						'='
					});
					if (array2.Length == 2)
					{
						string text2;
						if (!Class402.smethod_4(array, array2[1], ref i, out text2))
						{
							return false;
						}
						string a;
						if ((a = array2[0]) != null)
						{
							if (!(a == "minimum_version"))
							{
								if (!(a == "download"))
								{
									if (!(a == "hash"))
									{
										if (a == "patches" && !Class402.smethod_2(text2, out patches))
										{
											return false;
										}
									}
									else
									{
										if (!text2.smethod_13())
										{
											return false;
										}
										hash = new Struct43(text2);
									}
								}
								else
								{
									if (string.IsNullOrEmpty(text2))
									{
										return false;
									}
									Uri uri2;
									if (!Uri.TryCreate(text2, UriKind.Absolute, out uri2))
									{
										return false;
									}
									if (!uri2.smethod_0())
									{
										return false;
									}
									uri = uri2;
								}
							}
							else
							{
								if (string.IsNullOrEmpty(text2))
								{
									return false;
								}
								if (!Version.TryParse(text2, out version))
								{
									return false;
								}
							}
						}
					}
				}
			}
			if (uri == null)
			{
				return false;
			}
			if (version == null)
			{
				version = Class500.Current.FileVersion;
			}
			parser = new Class402(hash, uri, version, patches);
			return true;
		}

		// Token: 0x06002619 RID: 9753 RVA: 0x000868D0 File Offset: 0x00084AD0
		private static bool smethod_2(string patch_data, out List<KeyValuePair<Struct43, Class319>> patches)
		{
			patches = null;
			List<KeyValuePair<Struct43, Class319>> list = new List<KeyValuePair<Struct43, Class319>>();
			string[] array = patch_data.Split(new char[]
			{
				'\n',
				'\r'
			}, StringSplitOptions.RemoveEmptyEntries);
			foreach (string line in array)
			{
				Struct43? @struct;
				Class319 value;
				if (!Class402.smethod_3(line, out @struct, out value))
				{
					return false;
				}
				list.Add(new KeyValuePair<Struct43, Class319>(@struct.Value, value));
			}
			patches = list;
			return true;
		}

		// Token: 0x0600261A RID: 9754 RVA: 0x0008694C File Offset: 0x00084B4C
		private static bool smethod_3(string line, out Struct43? expectedHash, out Class319 data)
		{
			expectedHash = null;
			data = null;
			int num = 0;
			line = line.Trim();
			string text;
			if (!line.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			if (!text.smethod_13())
			{
				return false;
			}
			expectedHash = new Struct43?(new Struct43(text));
			if (!line.smethod_7(ref num, out text))
			{
				return false;
			}
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			string[] array = text.Split(new char[]
			{
				' '
			});
			if (array.Length != 3)
			{
				return false;
			}
			Uri uri;
			if (!Uri.TryCreate(array[0], UriKind.Absolute, out uri))
			{
				return false;
			}
			if (!uri.smethod_0())
			{
				return false;
			}
			Version minimumVersion;
			if (!Version.TryParse(array[1], out minimumVersion))
			{
				return false;
			}
			Version expectedContentPackVersion;
			if (!Version.TryParse(array[2], out expectedContentPackVersion))
			{
				return false;
			}
			data = new Class319(uri, minimumVersion, expectedContentPackVersion);
			return true;
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00086A14 File Offset: 0x00084C14
		private static bool smethod_4(string[] lines, string line_value, ref int index, out string value)
		{
			value = null;
			if (!line_value.StartsWith("{"))
			{
				value = line_value;
				return true;
			}
			if (!line_value.EndsWith("}"))
			{
				StringBuilder stringBuilder = new StringBuilder();
				stringBuilder.Append(line_value.Substring(1));
				int num = -1;
				int i = index + 1;
				while (i < lines.Length)
				{
					if (!lines[i].EndsWith("}"))
					{
						i++;
					}
					else
					{
						num = i;
						IL_78:
						if (num == -1)
						{
							return false;
						}
						for (index++; index <= num; index++)
						{
							if (index == num)
							{
								stringBuilder.Append(lines[index].Substring(0, lines[index].IndexOf('}')));
							}
							else
							{
								stringBuilder.Append(Environment.NewLine);
								stringBuilder.Append(lines[index]);
							}
						}
						value = stringBuilder.ToString();
						return true;
					}
				}
				goto IL_78;
			}
			if (line_value.Length > 2)
			{
				value = line_value.Substring(1, line_value.Length - 2);
				return true;
			}
			return false;
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x00086AFC File Offset: 0x00084CFC
		public bool method_0(Struct43 currentHash, Version currentVersion, out int startIndex)
		{
			for (int i = 0; i < this.list_0.Count; i++)
			{
				KeyValuePair<Struct43, Class319> keyValuePair = this.list_0[i];
				if (Struct43.smethod_5(keyValuePair.Key, currentHash) && keyValuePair.Value.ExpectedContentPackVersion == currentVersion)
				{
					startIndex = i;
					return true;
				}
			}
			startIndex = -1;
			return false;
		}

		// Token: 0x040012A0 RID: 4768
		private List<KeyValuePair<Struct43, Class319>> list_0;

		// Token: 0x040012A1 RID: 4769
		private ReadOnlyCollection<KeyValuePair<Struct43, Class319>> readOnlyCollection_0;

		// Token: 0x040012A2 RID: 4770
		[CompilerGenerated]
		private Uri uri_0;

		// Token: 0x040012A3 RID: 4771
		[CompilerGenerated]
		private Struct43 struct43_0;

		// Token: 0x040012A4 RID: 4772
		[CompilerGenerated]
		private Version version_0;
	}
}
