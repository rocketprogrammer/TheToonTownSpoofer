using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using ns14;
using ns15;
using ns18;
using ns20;
using ns21;
using ns22;
using ns23;
using ns26;
using ns29;
using ns31;

namespace ns24
{
	// Token: 0x0200031E RID: 798
	internal sealed class Class96 : Class86
	{
		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06001ED7 RID: 7895 RVA: 0x0000C06F File Offset: 0x0000A26F
		protected override int? Version
		{
			get
			{
				return new int?(2);
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06001ED8 RID: 7896 RVA: 0x0000C077 File Offset: 0x0000A277
		protected override int MaximumVersion
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06001ED9 RID: 7897 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x06001EDA RID: 7898 RVA: 0x0000C07A File Offset: 0x0000A27A
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					80,
					80,
					83
				};
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x06001EDB RID: 7899 RVA: 0x0000C08D File Offset: 0x0000A28D
		// (set) Token: 0x06001EDC RID: 7900 RVA: 0x0000C095 File Offset: 0x0000A295
		public Class96.Class306 Properties { get; set; }

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x06001EDD RID: 7901 RVA: 0x0000C09E File Offset: 0x0000A29E
		// (set) Token: 0x06001EDE RID: 7902 RVA: 0x0000C0A6 File Offset: 0x0000A2A6
		public List<Uri> DownloadUrls { get; private set; }

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06001EDF RID: 7903 RVA: 0x0000C0AF File Offset: 0x0000A2AF
		// (set) Token: 0x06001EE0 RID: 7904 RVA: 0x0000C0B7 File Offset: 0x0000A2B7
		public Dictionary<string, Class186> FILES { get; private set; }

		// Token: 0x06001EE1 RID: 7905 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		public void method_4(Class96 data)
		{
			this.Properties = data.Properties.imethod_0();
			this.DownloadUrls = new List<Uri>(data.DownloadUrls);
			this.FILES = new Dictionary<string, Class186>(data.FILES);
		}

		// Token: 0x06001EE2 RID: 7906 RVA: 0x0000C0F5 File Offset: 0x0000A2F5
		public Class96()
		{
			this.DownloadUrls = new List<Uri>();
			this.FILES = new Dictionary<string, Class186>(StringComparer.OrdinalIgnoreCase);
			this.Properties = new Class96.Class306();
		}

		// Token: 0x06001EE3 RID: 7907 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class96(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x06001EE4 RID: 7908 RVA: 0x000656B0 File Offset: 0x000638B0
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.DownloadUrls = new List<Uri>();
			this.FILES = new Dictionary<string, Class186>(StringComparer.OrdinalIgnoreCase);
			this.Properties = new Class96.Class306();
			lock (((ICollection)this.FILES).SyncRoot)
			{
				this.FILES.Clear();
				int num = (int)reader.ReadInt16();
				short num2 = 0;
				while ((int)num2 < num)
				{
					Class186 @class = new Class186();
					string key = reader.ReadString();
					@class.Version = reader.ReadString();
					@class.ExpectedSize = reader.ReadInt64();
					@class.ExpectedHash = reader.BaseStream.smethod_22();
					if (version > 1)
					{
						@class.ForceRecheck = reader.ReadBoolean();
					}
					else
					{
						@class.ForceRecheck = false;
					}
					this.FILES.Add(key, @class);
					num2 += 1;
				}
			}
		}

		// Token: 0x06001EE5 RID: 7909 RVA: 0x00065794 File Offset: 0x00063994
		protected override void vmethod_0(BinaryWriter writer)
		{
			lock (((ICollection)this.FILES).SyncRoot)
			{
				writer.Write((short)this.FILES.Count);
				foreach (KeyValuePair<string, Class186> keyValuePair in this.FILES)
				{
					writer.Write(keyValuePair.Key);
					writer.Write(keyValuePair.Value.Version);
					writer.Write(keyValuePair.Value.ExpectedSize);
					writer.BaseStream.smethod_23(keyValuePair.Value.ExpectedHash);
					writer.Write(keyValuePair.Value.ForceRecheck);
				}
			}
		}

		// Token: 0x06001EE6 RID: 7910 RVA: 0x0006587C File Offset: 0x00063A7C
		public void method_5(string name, Class282 patch, Struct43? hashOverride = null, long? sizeOverride = null)
		{
			lock (((ICollection)this.FILES).SyncRoot)
			{
				Class186 @class = patch.method_0();
				if (hashOverride != null)
				{
					@class.ExpectedHash = hashOverride.Value;
				}
				if (sizeOverride != null)
				{
					@class.ExpectedSize = sizeOverride.Value;
				}
				if (this.FILES.ContainsKey(name))
				{
					this.FILES[name] = @class;
				}
				else
				{
					this.FILES.Add(name, @class);
				}
			}
		}

		// Token: 0x06001EE7 RID: 7911 RVA: 0x00065918 File Offset: 0x00063B18
		public void method_6(string name, Class186 file, Struct43? hashOverride = null, long? sizeOverride = null)
		{
			Class186 @class = file.method_0();
			if (hashOverride != null)
			{
				@class.ExpectedHash = hashOverride.Value;
			}
			if (sizeOverride != null)
			{
				@class.ExpectedSize = sizeOverride.Value;
			}
			this.method_7(name, @class);
		}

		// Token: 0x06001EE8 RID: 7912 RVA: 0x00065960 File Offset: 0x00063B60
		private void method_7(string name, Class186 file)
		{
			lock (((ICollection)this.FILES).SyncRoot)
			{
				if (this.FILES.ContainsKey(name))
				{
					this.FILES[name] = file;
				}
				else
				{
					this.FILES.Add(name, file);
				}
			}
		}

		// Token: 0x06001EE9 RID: 7913 RVA: 0x000659CC File Offset: 0x00063BCC
		public void method_8(Class96 data, HashSet<string> filesUpdated, string installPath)
		{
			lock (((ICollection)this.FILES).SyncRoot)
			{
				lock (filesUpdated)
				{
					if (data == null)
					{
						using (HashSet<string>.Enumerator enumerator = filesUpdated.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								string str = enumerator.Current;
								string text = str + ".mf";
								string text2 = Path.Combine(installPath, text);
								Class186 @class = new Class186(Class234.smethod_11(text2), Class513.smethod_0(text2), null);
								if (this.FILES.ContainsKey(text))
								{
									@class.Version = this.FILES[text].Version;
									this.FILES[text] = @class;
								}
								else
								{
									this.FILES.Add(text, @class);
								}
							}
							goto IL_20D;
						}
					}
					lock (((ICollection)data.FILES).SyncRoot)
					{
						foreach (string str2 in filesUpdated)
						{
							string text3 = str2 + ".mf";
							string text4 = Path.Combine(installPath, text3);
							Class186 value = new Class186(Class234.smethod_11(text4), Class513.smethod_0(text4), data.FILES[text3].Version);
							if (this.FILES.ContainsKey(text3))
							{
								this.FILES[text3] = value;
							}
							else
							{
								this.FILES.Add(text3, value);
							}
						}
						foreach (KeyValuePair<string, Class186> keyValuePair in data.FILES)
						{
							if (!this.FILES.ContainsKey(keyValuePair.Key))
							{
								this.FILES.Add(keyValuePair.Key, keyValuePair.Value.method_0());
							}
							else
							{
								this.FILES[keyValuePair.Key].Version = keyValuePair.Value.Version;
							}
						}
					}
					IL_20D:;
				}
			}
		}

		// Token: 0x06001EEA RID: 7914 RVA: 0x00065C98 File Offset: 0x00063E98
		public Dictionary<string, Class307> method_9(Class96 data, string installFolder, bool usingVirtualServer, bool canMoveOrInstallFiles, HashSet<string> changedFiles, out bool success)
		{
			Dictionary<string, Class307> dictionary = new Dictionary<string, Class307>();
			success = true;
			lock (((ICollection)this.FILES).SyncRoot)
			{
				lock (((ICollection)data.FILES).SyncRoot)
				{
					foreach (KeyValuePair<string, Class186> keyValuePair in data.FILES)
					{
						Class96.Class308 @class;
						bool flag3;
						if (usingVirtualServer && Class136.smethod_6(keyValuePair.Key))
						{
							@class = new Class96.Class308(keyValuePair.Key, keyValuePair.Key + ".orig", Path.Combine(installFolder, keyValuePair.Key + ".orig"), keyValuePair.Key, Path.Combine(installFolder, keyValuePair.Key), true);
							flag3 = true;
						}
						else
						{
							@class = new Class96.Class308(keyValuePair.Key, keyValuePair.Key, Path.Combine(installFolder, keyValuePair.Key), keyValuePair.Key + ".orig", Path.Combine(installFolder, keyValuePair.Key + ".orig"), false);
							flag3 = false;
						}
						bool flag4;
						Struct43 @struct;
						Enum23 @enum;
						if (flag4 = this.FILES.ContainsKey(keyValuePair.Key))
						{
							@enum = keyValuePair.Value.method_5(this.FILES[keyValuePair.Key], @class.FilePath, out @struct);
						}
						else
						{
							@enum = keyValuePair.Value.method_3(@class.FilePath, out @struct);
						}
						if (@enum != Enum23.const_2)
						{
							if (!canMoveOrInstallFiles)
							{
								success = false;
								break;
							}
							if (@enum == Enum23.const_1 && keyValuePair.Value.method_2(@struct))
							{
								@class.FileDetails = keyValuePair.Value.method_1(@struct);
								dictionary.Add(keyValuePair.Key, @class);
							}
							else if (flag3)
							{
								Struct43 struct2;
								long expectedSize;
								switch (keyValuePair.Value.method_4(@class.AltFilePath, out struct2, out expectedSize))
								{
								case Enum23.const_0:
									@class.FileDetails = keyValuePair.Value.method_0();
									dictionary.Add(keyValuePair.Key, @class);
									break;
								case Enum23.const_1:
									if (keyValuePair.Value.method_2(struct2))
									{
										Class234.smethod_14(@class.AltFilePath, @class.FilePath, true);
										@class.FileDetails = keyValuePair.Value.method_1(struct2);
										this.method_7(keyValuePair.Key, new Class186(expectedSize, struct2, string.Empty));
										dictionary.Add(keyValuePair.Key, @class);
										Class110.Instance.CreatedFileArchive.method_4(@class.FilePath);
										Class110.Instance.CreatedFileArchive.method_5(@class.AltFilePath);
									}
									else
									{
										@class.FileDetails = keyValuePair.Value.method_0();
										dictionary.Add(keyValuePair.Key, @class);
									}
									break;
								case Enum23.const_2:
									File.Copy(@class.AltFilePath, @class.FilePath, true);
									this.method_6(keyValuePair.Key, keyValuePair.Value, null, null);
									Class110.Instance.CreatedFileArchive.method_4(@class.FilePath);
									break;
								}
							}
							else
							{
								@class.FileDetails = keyValuePair.Value.method_0();
								dictionary.Add(keyValuePair.Key, @class);
							}
							string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(keyValuePair.Key);
							if (!changedFiles.Contains(fileNameWithoutExtension))
							{
								changedFiles.Add(fileNameWithoutExtension);
							}
						}
						else if (!flag4)
						{
							this.method_6(keyValuePair.Key, keyValuePair.Value, null, null);
						}
						if (flag3 && !File.Exists(@class.AltFilePath) && File.Exists(@class.FilePath))
						{
							File.Copy(@class.FilePath, @class.AltFilePath, true);
							string fileNameWithoutExtension2 = Path.GetFileNameWithoutExtension(keyValuePair.Key);
							if (!changedFiles.Contains(fileNameWithoutExtension2))
							{
								changedFiles.Add(fileNameWithoutExtension2);
							}
							Class110.Instance.CreatedFileArchive.method_4(@class.AltFilePath);
						}
					}
				}
			}
			return dictionary;
		}

		// Token: 0x06001EEB RID: 7915 RVA: 0x00066108 File Offset: 0x00064308
		public string method_10(string PANDA_DOWNLOAD_URL)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append(string.Format("PATCHER_VERSION_STRING_SERVER={0}\r\n", this.Properties.PATCHER_VERSION_STRING_SERVER));
			stringBuilder.Append(string.Format("PATCHER_VERSION_STRING_SERVER_OSX={0}\r\n", this.Properties.PATCHER_VERSION_STRING_SERVER_OSX));
			stringBuilder.Append(string.Format("GAME_VERSION_TEXT={0}\r\n", this.Properties.GAME_VERSION_TEXT));
			stringBuilder.Append(string.Format("DOWNLOAD_PATCHER_CURRENT_VERSION={0}\r\n", this.Properties.DOWNLOAD_PATCHER_CURRENT_VERSION));
			stringBuilder.Append(string.Format("DOWNLOAD_PATCHER_CURRENT_VERSION_OSX={0}\r\n", this.Properties.DOWNLOAD_PATCHER_CURRENT_VERSION_OSX));
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(string.Format("ACCOUNT_SERVER={0}\r\n", this.Properties.ACCOUNT_SERVER));
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(string.Format("GAME_SERVER={0}\r\n", this.Properties.GAME_SERVER));
			stringBuilder.Append(string.Format("PANDA_DOWNLOAD_URL={0}\r\n", PANDA_DOWNLOAD_URL));
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(string.Format("PATCHER_BASE_URL_HEAVY_LIFTING={0}\r\n", this.Properties.PATCHER_BASE_URL_HEAVY_LIFTING));
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(string.Format("WEB_PAGE_LOGIN_RPC={0}\r\n", this.Properties.WEB_PAGE_LOGIN_RPC));
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.Append(string.Format("REQUIRED_INSTALL_FILES={0}\r\n", this.Properties.REQUIRED_INSTALL_FILES));
			stringBuilder.Append(string.Format("REQUIRED_INSTALL_FILES_OSX={0}\r\n", this.Properties.REQUIRED_INSTALL_FILES_OSX));
			stringBuilder.Append(Environment.NewLine);
			if (!string.IsNullOrEmpty(this.Properties.REMOVE_OLD_FILE_LIST))
			{
				stringBuilder.Append(string.Format("REMOVE_OLD_FILE_LIST={0}\r\n", this.Properties.REMOVE_OLD_FILE_LIST));
				stringBuilder.Append(Environment.NewLine);
			}
			lock (((ICollection)this.FILES).SyncRoot)
			{
				foreach (KeyValuePair<string, Class186> keyValuePair in this.FILES)
				{
					stringBuilder.Append(string.Format("FILE_{0}.current=v{1}\r\n", keyValuePair.Key, keyValuePair.Value.Version));
				}
				stringBuilder.Append(Environment.NewLine);
				foreach (KeyValuePair<string, Class186> keyValuePair2 in this.FILES)
				{
					stringBuilder.Append(string.Format("#{0}\r\n", keyValuePair2.Key));
					stringBuilder.Append(string.Format("FILE_{0}.v{1}={2} {3}\r\n", new object[]
					{
						keyValuePair2.Key,
						keyValuePair2.Value.Version,
						keyValuePair2.Value.ExpectedSize,
						keyValuePair2.Value.ExpectedHash
					}));
				}
				stringBuilder.Append(Environment.NewLine);
				stringBuilder.Append(Environment.NewLine);
			}
			stringBuilder.Append("#EndOfStream\r\n");
			return stringBuilder.ToString();
		}

		// Token: 0x06001EEC RID: 7916 RVA: 0x000664A8 File Offset: 0x000646A8
		public void method_11(string data)
		{
			Regex regex = new Regex("^(FILE_){1}(?<fileName>.+){1}(\\.v){1}(?<fileVersion>\\d+\\.{1}\\d+){1}$");
			Regex regex2 = new Regex("^(PFILE_){1}(?<fileName>.+){1}(\\.v){1}(?<fileVersion>\\d+\\.{1}\\d+){1}(\\.pch){1}$");
			string[] array = data.Split(new char[]
			{
				'\r',
				'\n'
			}, StringSplitOptions.RemoveEmptyEntries);
			lock (((ICollection)this.FILES).SyncRoot)
			{
				this.FILES.Clear();
				foreach (string text in array)
				{
					string[] array3 = text.Split(new char[]
					{
						'='
					});
					if (array3.Length == 2)
					{
						string key;
						if ((key = array3[0]) != null)
						{
							if (Class529.dictionary_1 == null)
							{
								Class529.dictionary_1 = new Dictionary<string, int>(13)
								{
									{
										"PATCHER_VERSION_STRING_SERVER",
										0
									},
									{
										"PATCHER_VERSION_STRING_SERVER_OSX",
										1
									},
									{
										"GAME_VERSION_TEXT",
										2
									},
									{
										"DOWNLOAD_PATCHER_CURRENT_VERSION",
										3
									},
									{
										"DOWNLOAD_PATCHER_CURRENT_VERSION_OSX",
										4
									},
									{
										"ACCOUNT_SERVER",
										5
									},
									{
										"GAME_SERVER",
										6
									},
									{
										"PANDA_DOWNLOAD_URL",
										7
									},
									{
										"PATCHER_BASE_URL_HEAVY_LIFTING",
										8
									},
									{
										"WEB_PAGE_LOGIN_RPC",
										9
									},
									{
										"REQUIRED_INSTALL_FILES",
										10
									},
									{
										"REQUIRED_INSTALL_FILES_OSX",
										11
									},
									{
										"REMOVE_OLD_FILE_LIST",
										12
									}
								};
							}
							int num;
							if (Class529.dictionary_1.TryGetValue(key, out num))
							{
								switch (num)
								{
								case 0:
									this.Properties.PATCHER_VERSION_STRING_SERVER = array3[1];
									goto IL_5EA;
								case 1:
									this.Properties.PATCHER_VERSION_STRING_SERVER_OSX = array3[1];
									goto IL_5EA;
								case 2:
									this.Properties.GAME_VERSION_TEXT = array3[1];
									goto IL_5EA;
								case 3:
									this.Properties.DOWNLOAD_PATCHER_CURRENT_VERSION = array3[1];
									goto IL_5EA;
								case 4:
									this.Properties.DOWNLOAD_PATCHER_CURRENT_VERSION_OSX = array3[1];
									goto IL_5EA;
								case 5:
									this.Properties.ACCOUNT_SERVER = array3[1];
									goto IL_5EA;
								case 6:
									this.Properties.GAME_SERVER = array3[1];
									goto IL_5EA;
								case 7:
									this.Properties.PANDA_DOWNLOAD_URL = array3[1];
									try
									{
										lock (((ICollection)this.DownloadUrls).SyncRoot)
										{
											this.DownloadUrls.Insert(this.DownloadUrls.Count, new Uri(Class96.smethod_0(this.Properties.PANDA_DOWNLOAD_URL)));
										}
										goto IL_5EA;
									}
									catch (Exception ex)
									{
										ex.smethod_1(new object[]
										{
											array3[1]
										});
										goto IL_5EA;
									}
									break;
								case 8:
									break;
								case 9:
									this.Properties.WEB_PAGE_LOGIN_RPC = array3[1];
									goto IL_5EA;
								case 10:
									this.Properties.REQUIRED_INSTALL_FILES = array3[1];
									goto IL_5EA;
								case 11:
									this.Properties.REQUIRED_INSTALL_FILES_OSX = array3[1];
									goto IL_5EA;
								case 12:
									this.Properties.REMOVE_OLD_FILE_LIST = array3[1];
									goto IL_5EA;
								default:
									goto IL_3B8;
								}
								this.Properties.PATCHER_BASE_URL_HEAVY_LIFTING = array3[1];
								string[] array4 = this.Properties.PATCHER_BASE_URL_HEAVY_LIFTING.Split(new char[]
								{
									';'
								}, StringSplitOptions.RemoveEmptyEntries);
								for (int j = array4.Length - 1; j >= 0; j--)
								{
									try
									{
										lock (((ICollection)this.DownloadUrls).SyncRoot)
										{
											this.DownloadUrls.Insert(0, new Uri(Class96.smethod_0(array4[0])));
										}
									}
									catch (Exception ex2)
									{
										ex2.smethod_1(new object[]
										{
											array4[j]
										});
									}
								}
								goto IL_5EA;
							}
						}
						IL_3B8:
						if (array3[0].StartsWith("FILE"))
						{
							Match match = regex.Match(array3[0]);
							long expectedSize;
							Struct43 expectedHash;
							if (match.Success && !match.Groups["fileName"].Value.Contains("OSX") && Class96.smethod_2(array3[1].Trim(), out expectedSize, out expectedHash))
							{
								if (!this.FILES.ContainsKey(match.Groups["fileName"].Value))
								{
									this.FILES.Add(match.Groups["fileName"].Value, new Class186());
								}
								Class186 @class = this.FILES[match.Groups["fileName"].Value];
								@class.Version = match.Groups["fileVersion"].Value;
								@class.ExpectedHash = expectedHash;
								@class.ExpectedSize = expectedSize;
							}
						}
						else if (array3[0].StartsWith("PFILE"))
						{
							Match match = regex2.Match(array3[0]);
							uint expectedFileSize;
							Struct43 expectedHash2;
							uint resultingFileSize;
							Struct43 resultingHash;
							if (match.Success && !match.Groups["fileName"].Value.Contains("OSX") && Class96.smethod_1(array3[1].Trim(), out expectedFileSize, out expectedHash2, out resultingFileSize, out resultingHash))
							{
								Class282 class2 = new Class282();
								class2.ExpectedFileSize = expectedFileSize;
								class2.ExpectedHash = expectedHash2;
								class2.ResultingFileSize = resultingFileSize;
								class2.ResultingHash = resultingHash;
								class2.Version = match.Groups["fileVersion"].Value;
								string value = match.Groups["fileName"].Value;
								if (!this.FILES.ContainsKey(value))
								{
									this.FILES.Add(value, new Class186());
								}
								lock (((ICollection)this.FILES[value].Patches).SyncRoot)
								{
									this.FILES[value].Patches.Add(class2);
								}
							}
						}
					}
					IL_5EA:;
				}
			}
		}

		// Token: 0x06001EED RID: 7917 RVA: 0x0000C123 File Offset: 0x0000A323
		private static string smethod_0(string downloadUrl)
		{
			if (!downloadUrl.EndsWith("/"))
			{
				downloadUrl += '/';
			}
			return downloadUrl;
		}

		// Token: 0x06001EEE RID: 7918 RVA: 0x00066B4C File Offset: 0x00064D4C
		private static bool smethod_1(string data, out uint expectedFileSize, out Struct43 expectedHash, out uint resultingFileSize, out Struct43 resultingHash)
		{
			expectedFileSize = 0U;
			expectedHash = default(Struct43);
			resultingFileSize = 0U;
			resultingHash = default(Struct43);
			int num = 0;
			string text;
			if (!data.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			if (!uint.TryParse(text, out expectedFileSize))
			{
				return false;
			}
			if (!data.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			if (!text.smethod_13())
			{
				return false;
			}
			expectedHash = new Struct43(text);
			if (!data.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			if (!uint.TryParse(text, out resultingFileSize))
			{
				return false;
			}
			if (!data.smethod_7(ref num, out text))
			{
				return false;
			}
			if (!text.smethod_13())
			{
				return false;
			}
			resultingHash = new Struct43(text);
			return true;
		}

		// Token: 0x06001EEF RID: 7919 RVA: 0x00066BF4 File Offset: 0x00064DF4
		private static bool smethod_2(string data, out long expectedSize, out Struct43 expectedHash)
		{
			expectedSize = 0L;
			expectedHash = default(Struct43);
			int num = 0;
			string text;
			if (!data.smethod_8(' ', ref num, out text))
			{
				return false;
			}
			long num2;
			if (!long.TryParse(text, out num2))
			{
				return false;
			}
			if (!data.smethod_7(ref num, out text))
			{
				return false;
			}
			if (!text.smethod_13())
			{
				return false;
			}
			expectedHash = new Struct43(text);
			expectedSize = num2;
			return true;
		}

		// Token: 0x04000BE9 RID: 3049
		[CompilerGenerated]
		private Class96.Class306 class306_0;

		// Token: 0x04000BEA RID: 3050
		[CompilerGenerated]
		private List<Uri> list_0;

		// Token: 0x04000BEB RID: 3051
		[CompilerGenerated]
		private Dictionary<string, Class186> dictionary_0;

		// Token: 0x0200031F RID: 799
		internal sealed class Class306 : Interface15<Class96.Class306>
		{
			// Token: 0x1700082D RID: 2093
			// (get) Token: 0x06001EF0 RID: 7920 RVA: 0x0000C142 File Offset: 0x0000A342
			// (set) Token: 0x06001EF1 RID: 7921 RVA: 0x0000C14A File Offset: 0x0000A34A
			public string PATCHER_VERSION_STRING_SERVER { get; set; }

			// Token: 0x1700082E RID: 2094
			// (get) Token: 0x06001EF2 RID: 7922 RVA: 0x0000C153 File Offset: 0x0000A353
			// (set) Token: 0x06001EF3 RID: 7923 RVA: 0x0000C15B File Offset: 0x0000A35B
			public string PATCHER_VERSION_STRING_SERVER_OSX { get; set; }

			// Token: 0x1700082F RID: 2095
			// (get) Token: 0x06001EF4 RID: 7924 RVA: 0x0000C164 File Offset: 0x0000A364
			// (set) Token: 0x06001EF5 RID: 7925 RVA: 0x0000C16C File Offset: 0x0000A36C
			public string GAME_VERSION_TEXT { get; set; }

			// Token: 0x17000830 RID: 2096
			// (get) Token: 0x06001EF6 RID: 7926 RVA: 0x0000C175 File Offset: 0x0000A375
			// (set) Token: 0x06001EF7 RID: 7927 RVA: 0x0000C17D File Offset: 0x0000A37D
			public string DOWNLOAD_PATCHER_CURRENT_VERSION { get; set; }

			// Token: 0x17000831 RID: 2097
			// (get) Token: 0x06001EF8 RID: 7928 RVA: 0x0000C186 File Offset: 0x0000A386
			// (set) Token: 0x06001EF9 RID: 7929 RVA: 0x0000C18E File Offset: 0x0000A38E
			public string DOWNLOAD_PATCHER_CURRENT_VERSION_OSX { get; set; }

			// Token: 0x17000832 RID: 2098
			// (get) Token: 0x06001EFA RID: 7930 RVA: 0x0000C197 File Offset: 0x0000A397
			// (set) Token: 0x06001EFB RID: 7931 RVA: 0x0000C19F File Offset: 0x0000A39F
			public string ACCOUNT_SERVER { get; set; }

			// Token: 0x17000833 RID: 2099
			// (get) Token: 0x06001EFC RID: 7932 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
			// (set) Token: 0x06001EFD RID: 7933 RVA: 0x0000C1B0 File Offset: 0x0000A3B0
			public string GAME_SERVER { get; set; }

			// Token: 0x17000834 RID: 2100
			// (get) Token: 0x06001EFE RID: 7934 RVA: 0x0000C1B9 File Offset: 0x0000A3B9
			// (set) Token: 0x06001EFF RID: 7935 RVA: 0x0000C1C1 File Offset: 0x0000A3C1
			public string PANDA_DOWNLOAD_URL { get; set; }

			// Token: 0x17000835 RID: 2101
			// (get) Token: 0x06001F00 RID: 7936 RVA: 0x0000C1CA File Offset: 0x0000A3CA
			// (set) Token: 0x06001F01 RID: 7937 RVA: 0x0000C1D2 File Offset: 0x0000A3D2
			public string PATCHER_BASE_URL_HEAVY_LIFTING { get; set; }

			// Token: 0x17000836 RID: 2102
			// (get) Token: 0x06001F02 RID: 7938 RVA: 0x0000C1DB File Offset: 0x0000A3DB
			// (set) Token: 0x06001F03 RID: 7939 RVA: 0x0000C1E3 File Offset: 0x0000A3E3
			public string WEB_PAGE_LOGIN_RPC { get; set; }

			// Token: 0x17000837 RID: 2103
			// (get) Token: 0x06001F04 RID: 7940 RVA: 0x0000C1EC File Offset: 0x0000A3EC
			// (set) Token: 0x06001F05 RID: 7941 RVA: 0x0000C1F4 File Offset: 0x0000A3F4
			public string REQUIRED_INSTALL_FILES { get; set; }

			// Token: 0x17000838 RID: 2104
			// (get) Token: 0x06001F06 RID: 7942 RVA: 0x0000C1FD File Offset: 0x0000A3FD
			// (set) Token: 0x06001F07 RID: 7943 RVA: 0x0000C205 File Offset: 0x0000A405
			public string REQUIRED_INSTALL_FILES_OSX { get; set; }

			// Token: 0x17000839 RID: 2105
			// (get) Token: 0x06001F08 RID: 7944 RVA: 0x0000C20E File Offset: 0x0000A40E
			// (set) Token: 0x06001F09 RID: 7945 RVA: 0x0000C216 File Offset: 0x0000A416
			public string REMOVE_OLD_FILE_LIST { get; set; }

			// Token: 0x06001F0A RID: 7946 RVA: 0x00066C5C File Offset: 0x00064E5C
			public Class96.Class306 imethod_0()
			{
				return new Class96.Class306
				{
					ACCOUNT_SERVER = this.ACCOUNT_SERVER,
					DOWNLOAD_PATCHER_CURRENT_VERSION = this.DOWNLOAD_PATCHER_CURRENT_VERSION,
					DOWNLOAD_PATCHER_CURRENT_VERSION_OSX = this.DOWNLOAD_PATCHER_CURRENT_VERSION_OSX,
					GAME_SERVER = this.GAME_SERVER,
					GAME_VERSION_TEXT = this.GAME_VERSION_TEXT,
					PANDA_DOWNLOAD_URL = this.PANDA_DOWNLOAD_URL,
					PATCHER_BASE_URL_HEAVY_LIFTING = this.PATCHER_BASE_URL_HEAVY_LIFTING,
					PATCHER_VERSION_STRING_SERVER = this.PATCHER_VERSION_STRING_SERVER,
					PATCHER_VERSION_STRING_SERVER_OSX = this.PATCHER_VERSION_STRING_SERVER_OSX,
					REMOVE_OLD_FILE_LIST = this.REMOVE_OLD_FILE_LIST,
					REQUIRED_INSTALL_FILES = this.REQUIRED_INSTALL_FILES,
					REQUIRED_INSTALL_FILES_OSX = this.REQUIRED_INSTALL_FILES_OSX,
					WEB_PAGE_LOGIN_RPC = this.WEB_PAGE_LOGIN_RPC
				};
			}

			// Token: 0x04000BEC RID: 3052
			[CompilerGenerated]
			private string string_0;

			// Token: 0x04000BED RID: 3053
			[CompilerGenerated]
			private string string_1;

			// Token: 0x04000BEE RID: 3054
			[CompilerGenerated]
			private string string_2;

			// Token: 0x04000BEF RID: 3055
			[CompilerGenerated]
			private string string_3;

			// Token: 0x04000BF0 RID: 3056
			[CompilerGenerated]
			private string string_4;

			// Token: 0x04000BF1 RID: 3057
			[CompilerGenerated]
			private string string_5;

			// Token: 0x04000BF2 RID: 3058
			[CompilerGenerated]
			private string string_6;

			// Token: 0x04000BF3 RID: 3059
			[CompilerGenerated]
			private string string_7;

			// Token: 0x04000BF4 RID: 3060
			[CompilerGenerated]
			private string string_8;

			// Token: 0x04000BF5 RID: 3061
			[CompilerGenerated]
			private string string_9;

			// Token: 0x04000BF6 RID: 3062
			[CompilerGenerated]
			private string string_10;

			// Token: 0x04000BF7 RID: 3063
			[CompilerGenerated]
			private string string_11;

			// Token: 0x04000BF8 RID: 3064
			[CompilerGenerated]
			private string string_12;
		}

		// Token: 0x02000320 RID: 800
		private sealed class Class308 : Class307
		{
			// Token: 0x1700083A RID: 2106
			// (get) Token: 0x06001F0C RID: 7948 RVA: 0x0000C21F File Offset: 0x0000A41F
			// (set) Token: 0x06001F0D RID: 7949 RVA: 0x0000C227 File Offset: 0x0000A427
			public new Class186 FileDetails
			{
				get
				{
					return base.FileDetails;
				}
				set
				{
					base.FileDetails = value;
				}
			}

			// Token: 0x06001F0E RID: 7950 RVA: 0x0000C230 File Offset: 0x0000A430
			public Class308(string phaseName, string fileName, string filePath, string altFileName, string altFilePath, bool virtualized) : base(phaseName, fileName, filePath, altFileName, altFilePath, virtualized)
			{
			}
		}
	}
}
