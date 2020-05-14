using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using ns14;
using ns20;
using ns22;
using ns23;
using ns25;
using ns26;
using ns31;

namespace ns16
{
	// Token: 0x020003E5 RID: 997
	internal sealed class Class102 : Class86
	{
		// Token: 0x0600261D RID: 9757 RVA: 0x00086B58 File Offset: 0x00084D58
		public static Class102 smethod_0(Guid id)
		{
			foreach (Class102 @class in Class110.Instance.ConnectSettings.ContentPacks)
			{
				if (@class.ID == id)
				{
					return @class;
				}
			}
			return null;
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x0600261E RID: 9758 RVA: 0x00005B5E File Offset: 0x00003D5E
		protected override int? Version
		{
			get
			{
				return new int?(1);
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x0600261F RID: 9759 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MaximumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06002620 RID: 9760 RVA: 0x00005B66 File Offset: 0x00003D66
		protected override int MinimumVersion
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06002621 RID: 9761 RVA: 0x00010E5F File Offset: 0x0000F05F
		protected override byte[] Header
		{
			get
			{
				return new byte[]
				{
					67,
					80,
					83
				};
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06002622 RID: 9762 RVA: 0x00010E72 File Offset: 0x0000F072
		// (set) Token: 0x06002623 RID: 9763 RVA: 0x00010E7A File Offset: 0x0000F07A
		public Guid ID { get; set; }

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06002624 RID: 9764 RVA: 0x00010E83 File Offset: 0x0000F083
		// (set) Token: 0x06002625 RID: 9765 RVA: 0x00010E8B File Offset: 0x0000F08B
		public string FileName { get; set; }

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002626 RID: 9766 RVA: 0x00010E94 File Offset: 0x0000F094
		// (set) Token: 0x06002627 RID: 9767 RVA: 0x00010E9C File Offset: 0x0000F09C
		public Enum76 InstallState { get; set; }

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06002628 RID: 9768 RVA: 0x00010EA5 File Offset: 0x0000F0A5
		// (set) Token: 0x06002629 RID: 9769 RVA: 0x00010EAD File Offset: 0x0000F0AD
		public Uri UpdateUri { get; set; }

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600262A RID: 9770 RVA: 0x00010EB6 File Offset: 0x0000F0B6
		// (set) Token: 0x0600262B RID: 9771 RVA: 0x00010EBE File Offset: 0x0000F0BE
		public string Name { get; set; }

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x0600262C RID: 9772 RVA: 0x00010EC7 File Offset: 0x0000F0C7
		// (set) Token: 0x0600262D RID: 9773 RVA: 0x00010ECF File Offset: 0x0000F0CF
		public Struct43 DataHash { get; set; }

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x0600262E RID: 9774 RVA: 0x00010ED8 File Offset: 0x0000F0D8
		// (set) Token: 0x0600262F RID: 9775 RVA: 0x00010EE0 File Offset: 0x0000F0E0
		public bool AutoUpdate { get; set; }

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002630 RID: 9776 RVA: 0x00010EE9 File Offset: 0x0000F0E9
		// (set) Token: 0x06002631 RID: 9777 RVA: 0x00010EF1 File Offset: 0x0000F0F1
		public Enum82 VersionType { get; set; }

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002632 RID: 9778 RVA: 0x00010EFA File Offset: 0x0000F0FA
		// (set) Token: 0x06002633 RID: 9779 RVA: 0x00010F02 File Offset: 0x0000F102
		public bool LoaderPack { get; set; }

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002634 RID: 9780 RVA: 0x00010F0B File Offset: 0x0000F10B
		// (set) Token: 0x06002635 RID: 9781 RVA: 0x00010F13 File Offset: 0x0000F113
		public DateTime DateInstalled { get; set; }

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06002636 RID: 9782 RVA: 0x00010F1C File Offset: 0x0000F11C
		// (set) Token: 0x06002637 RID: 9783 RVA: 0x00010F24 File Offset: 0x0000F124
		public Version ContentPackVersion { get; set; }

		// Token: 0x06002638 RID: 9784 RVA: 0x00086BC4 File Offset: 0x00084DC4
		public Class102(Class132 cp, Struct43 contentPackHash, string fileName)
		{
			this.dictionary_0 = new Dictionary<string, Class102.Class403>(StringComparer.OrdinalIgnoreCase);
			this.ID = cp.ID;
			this.FileName = fileName;
			this.Name = cp.Name;
			this.DateInstalled = DateTime.Now;
			this.InstallState = Enum76.const_0;
			this.UpdateUri = cp.UpdateUri;
			this.DataHash = contentPackHash;
			this.AutoUpdate = (cp.UpdateUri != null);
			this.VersionType = cp.Type;
			this.LoaderPack = cp.LoaderPack;
			this.ContentPackVersion = cp.Version;
			foreach (KeyValuePair<string, Struct43> keyValuePair in cp.ItemIndex)
			{
				if (!this.dictionary_0.ContainsKey(keyValuePair.Key) && Class136.smethod_8(keyValuePair.Key))
				{
					if (this.method_4(keyValuePair.Key))
					{
						this.dictionary_0.Add(keyValuePair.Key, new Class102.Class403(keyValuePair.Value, Enum76.const_0));
					}
					else
					{
						this.dictionary_0.Add(keyValuePair.Key, new Class102.Class403(keyValuePair.Value, Enum76.const_3));
					}
				}
			}
		}

		// Token: 0x06002639 RID: 9785 RVA: 0x00005D8B File Offset: 0x00003F8B
		public Class102(BinaryReader reader) : base(reader)
		{
		}

		// Token: 0x0600263A RID: 9786 RVA: 0x00086D18 File Offset: 0x00084F18
		protected override void vmethod_2(BinaryReader reader, int version)
		{
			this.dictionary_0 = new Dictionary<string, Class102.Class403>(StringComparer.OrdinalIgnoreCase);
			this.ID = reader.smethod_29();
			this.FileName = Path.Combine(Class291.ContentPackDataDirectory, reader.ReadString());
			this.Name = reader.ReadString();
			this.DateInstalled = reader.smethod_30();
			this.InstallState = (Enum76)reader.ReadInt16();
			this.UpdateUri = reader.smethod_32();
			this.DataHash = reader.smethod_24();
			this.AutoUpdate = reader.ReadBoolean();
			this.VersionType = (Enum82)reader.ReadInt16();
			this.LoaderPack = reader.ReadBoolean();
			this.ContentPackVersion = reader.smethod_27();
			int num = reader.ReadInt32();
			for (int i = 0; i < num; i++)
			{
				this.dictionary_0.Add(reader.ReadString(), new Class102.Class403(reader.smethod_24(), (Enum76)reader.ReadInt16()));
			}
		}

		// Token: 0x0600263B RID: 9787 RVA: 0x00086DF8 File Offset: 0x00084FF8
		protected override void vmethod_0(BinaryWriter writer)
		{
			writer.smethod_28(this.ID);
			writer.Write(Path.GetFileName(this.FileName));
			writer.Write(this.Name);
			writer.smethod_31(this.DateInstalled);
			writer.Write((short)this.InstallState);
			writer.smethod_33(this.UpdateUri);
			writer.smethod_25(this.DataHash);
			writer.Write(this.AutoUpdate);
			writer.Write((short)this.VersionType);
			writer.Write(this.LoaderPack);
			writer.smethod_26(this.ContentPackVersion);
			writer.Write(this.dictionary_0.Count);
			foreach (KeyValuePair<string, Class102.Class403> keyValuePair in this.dictionary_0)
			{
				writer.Write(keyValuePair.Key);
				writer.smethod_25(keyValuePair.Value.struct43_0);
				writer.Write((short)keyValuePair.Value.enum76_0);
			}
		}

		// Token: 0x0600263C RID: 9788 RVA: 0x00086F14 File Offset: 0x00085114
		private bool method_4(string item)
		{
			lock (((ICollection)Class110.Instance.ConnectSettings.ContentPacks).SyncRoot)
			{
				using (List<Class102>.Enumerator enumerator = Class110.Instance.ConnectSettings.ContentPacks.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						Class102 @class = enumerator.Current;
						if (@class != this)
						{
							lock (((ICollection)@class.dictionary_0).SyncRoot)
							{
								if (@class.dictionary_0.ContainsKey(item))
								{
									switch (@class.dictionary_0[item].enum76_0)
									{
									case Enum76.const_1:
									case Enum76.const_3:
										return true;
									default:
										goto IL_AE;
									}
								}
							}
						}
					}
					IL_AE:;
				}
			}
			return false;
		}

		// Token: 0x0600263D RID: 9789 RVA: 0x00087018 File Offset: 0x00085218
		public void method_5()
		{
			this.DateInstalled = DateTime.Now;
			HashSet<string> hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			lock (((ICollection)this.dictionary_0).SyncRoot)
			{
				using (Class132 @class = new Class132(this.FileName, false, false))
				{
					foreach (KeyValuePair<string, Struct43> keyValuePair in @class.ItemIndex)
					{
						if (this.dictionary_0.ContainsKey(keyValuePair.Key))
						{
							if (Struct43.smethod_6(keyValuePair.Value, this.dictionary_0[keyValuePair.Key].struct43_0))
							{
								if (this.dictionary_0[keyValuePair.Key].enum76_0 == Enum76.const_1)
								{
									this.dictionary_0[keyValuePair.Key].enum76_0 = Enum76.const_3;
								}
								this.dictionary_0[keyValuePair.Key].struct43_0 = keyValuePair.Value;
							}
						}
						else if (Class136.smethod_8(keyValuePair.Key))
						{
							if (this.method_4(keyValuePair.Key))
							{
								this.dictionary_0.Add(keyValuePair.Key, new Class102.Class403(keyValuePair.Value, Enum76.const_0));
							}
							else
							{
								this.dictionary_0.Add(keyValuePair.Key, new Class102.Class403(keyValuePair.Value, Enum76.const_3));
								this.InstallState = Enum76.const_3;
							}
						}
					}
					foreach (KeyValuePair<string, Class102.Class403> keyValuePair2 in this.dictionary_0)
					{
						if (!@class.ItemIndex.ContainsKey(keyValuePair2.Key))
						{
							Enum76 @enum = keyValuePair2.Value.enum76_0;
							if (@enum == Enum76.const_1)
							{
								keyValuePair2.Value.enum76_0 = Enum76.const_4;
							}
							else
							{
								hashSet.Add(keyValuePair2.Key);
							}
						}
					}
					this.Name = @class.Name;
					this.UpdateUri = @class.UpdateUri;
					this.VersionType = @class.Type;
					this.ContentPackVersion = @class.Version;
					this.LoaderPack = @class.LoaderPack;
					if (this.VersionType == Enum82.const_0)
					{
						this.DataHash = @class.DataHash;
					}
				}
				if (this.VersionType != Enum82.const_0)
				{
					using (Stream stream = File.Open(this.FileName, FileMode.Open, FileAccess.Read, FileShare.None))
					{
						this.DataHash = stream.smethod_2();
					}
				}
				this.dictionary_0.smethod_8(hashSet);
			}
		}

		// Token: 0x0600263E RID: 9790 RVA: 0x00087324 File Offset: 0x00085524
		public static void smethod_1(HashSet<string> modifiedFiles)
		{
			if (Class110.Instance.ConnectSettings.SpoofedToonTownEnabled)
			{
				lock (((ICollection)Class110.Instance.ConnectSettings.ContentPacks).SyncRoot)
				{
					foreach (Class102 @class in Class110.Instance.ConnectSettings.ContentPacks)
					{
						lock (((ICollection)@class.dictionary_0).SyncRoot)
						{
							foreach (KeyValuePair<string, Class102.Class403> keyValuePair in @class.dictionary_0)
							{
								string item;
								if (keyValuePair.Value.enum76_0 != Enum76.const_0 && Class136.smethod_5(keyValuePair.Key, out item))
								{
									switch (keyValuePair.Value.enum76_0)
									{
									case Enum76.const_1:
										if (modifiedFiles.Contains(item))
										{
											@class.dictionary_0[keyValuePair.Key].enum76_0 = Enum76.const_3;
										}
										break;
									case Enum76.const_2:
										if (modifiedFiles.Contains(item))
										{
											@class.dictionary_0[keyValuePair.Key].enum76_0 = Enum76.const_0;
										}
										break;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600263F RID: 9791 RVA: 0x000874F8 File Offset: 0x000856F8
		public static void smethod_2(string installDirectory, out HashSet<string> changedMultiFiles)
		{
			changedMultiFiles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
			if (Class110.Instance.ConnectSettings.SpoofedToonTownEnabled)
			{
				Class102.Class404 @class = new Class102.Class404();
				Dictionary<Class102, Dictionary<string, HashSet<string>>> dictionary = new Dictionary<Class102, Dictionary<string, HashSet<string>>>();
				Dictionary<string, Dictionary<Class102, HashSet<string>>> dictionary2 = new Dictionary<string, Dictionary<Class102, HashSet<string>>>(StringComparer.OrdinalIgnoreCase);
				@class.dictionary_0 = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
				lock (((ICollection)Class110.Instance.ConnectSettings.ContentPacks).SyncRoot)
				{
					foreach (Class102 class2 in Class110.Instance.ConnectSettings.ContentPacks)
					{
						if (!class2.LoaderPack)
						{
							Dictionary<string, HashSet<string>> dictionary3;
							Dictionary<string, HashSet<string>> dictionary4;
							class2.method_7(out dictionary3, out dictionary4);
							if (dictionary3.Count > 0)
							{
								dictionary.Add(class2, dictionary3);
							}
							foreach (KeyValuePair<string, HashSet<string>> keyValuePair in dictionary3)
							{
								if (!@class.dictionary_0.ContainsKey(keyValuePair.Key))
								{
									@class.dictionary_0.Add(keyValuePair.Key, new HashSet<string>(StringComparer.OrdinalIgnoreCase));
								}
								foreach (string item in keyValuePair.Value)
								{
									if (!@class.dictionary_0[keyValuePair.Key].Contains(item))
									{
										@class.dictionary_0[keyValuePair.Key].Add(item);
									}
								}
							}
							foreach (KeyValuePair<string, HashSet<string>> keyValuePair2 in dictionary4)
							{
								Dictionary<Class102, HashSet<string>> dictionary5;
								if (dictionary2.ContainsKey(keyValuePair2.Key))
								{
									dictionary5 = dictionary2[keyValuePair2.Key];
								}
								else
								{
									dictionary2.Add(keyValuePair2.Key, dictionary5 = new Dictionary<Class102, HashSet<string>>());
								}
								HashSet<string> hashSet;
								if (dictionary5.ContainsKey(class2))
								{
									hashSet = dictionary5[class2];
								}
								else
								{
									dictionary5.Add(class2, hashSet = new HashSet<string>(StringComparer.OrdinalIgnoreCase));
								}
								foreach (string item2 in keyValuePair2.Value)
								{
									if (!hashSet.Contains(item2))
									{
										hashSet.Add(item2);
									}
								}
							}
						}
					}
				}
				dictionary2.smethod_7(new Action<KeyValuePair<string, Dictionary<Class102, HashSet<string>>>>(@class.method_0));
				IEnumerable<KeyValuePair<string, Dictionary<Class102, HashSet<string>>>> source = dictionary2;
				if (Class102.func_0 == null)
				{
					Class102.func_0 = new Func<KeyValuePair<string, Dictionary<Class102, HashSet<string>>>, bool>(Class102.smethod_3);
				}
				KeyValuePair<string, Dictionary<Class102, HashSet<string>>>[] array = source.Where(Class102.func_0).ToArray<KeyValuePair<string, Dictionary<Class102, HashSet<string>>>>();
				foreach (KeyValuePair<string, Dictionary<Class102, HashSet<string>>> keyValuePair3 in array)
				{
					dictionary2.Remove(keyValuePair3.Key);
				}
				Dictionary<Class102, Class132> dictionary6 = new Dictionary<Class102, Class132>();
				try
				{
					foreach (string text in @class.dictionary_0.Keys.Union(dictionary2.Keys, StringComparer.OrdinalIgnoreCase))
					{
						string path = Path.Combine(installDirectory, text + ".mf");
						if (File.Exists(path))
						{
							using (Stream stream = File.Open(path, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
							{
								using (Class136 class3 = new Class136(stream))
								{
									if (!changedMultiFiles.Contains(text))
									{
										changedMultiFiles.Add(text);
									}
									class3.method_12();
									if (dictionary2.ContainsKey(text))
									{
										string path2 = Path.Combine(installDirectory, text + ".mf.orig");
										if (File.Exists(path2))
										{
											using (Stream stream2 = File.Open(path2, FileMode.Open, FileAccess.Read, FileShare.None))
											{
												using (Class136 class4 = new Class136(stream2))
												{
													HashSet<string> hashSet2 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
													foreach (KeyValuePair<Class102, HashSet<string>> keyValuePair4 in dictionary2[text])
													{
														foreach (string item3 in keyValuePair4.Value)
														{
															if (!hashSet2.Contains(item3))
															{
																hashSet2.Add(item3);
															}
														}
													}
													class4.method_14(hashSet2);
													foreach (KeyValuePair<Class102, HashSet<string>> keyValuePair5 in dictionary2[text])
													{
														foreach (string name in keyValuePair5.Value)
														{
															if (class4.method_6(name) && class3.method_6(name))
															{
																class4[name].method_0(class3[name]);
															}
														}
														Enum76 installState = keyValuePair5.Key.InstallState;
														if (installState == Enum76.const_2)
														{
															using (HashSet<string>.Enumerator enumerator11 = keyValuePair5.Value.GetEnumerator())
															{
																while (enumerator11.MoveNext())
																{
																	string key = enumerator11.Current;
																	switch (keyValuePair5.Key.dictionary_0[key].enum76_0)
																	{
																	case Enum76.const_2:
																		keyValuePair5.Key.dictionary_0[key].enum76_0 = Enum76.const_0;
																		continue;
																	case Enum76.const_4:
																		continue;
																	}
																	keyValuePair5.Key.dictionary_0[key].enum76_0 = Enum76.const_3;
																}
																continue;
															}
														}
														foreach (string key2 in keyValuePair5.Value)
														{
															Enum76 @enum = keyValuePair5.Key.dictionary_0[key2].enum76_0;
															if (@enum != Enum76.const_4)
															{
																keyValuePair5.Key.dictionary_0[key2].enum76_0 = Enum76.const_0;
															}
														}
													}
												}
											}
										}
									}
									foreach (KeyValuePair<Class102, Dictionary<string, HashSet<string>>> keyValuePair6 in dictionary)
									{
										if (keyValuePair6.Value.ContainsKey(text))
										{
											Class102 key3 = keyValuePair6.Key;
											if (!dictionary6.ContainsKey(keyValuePair6.Key))
											{
												dictionary6.Add(keyValuePair6.Key, new Class132(keyValuePair6.Key.FileName, false, true));
											}
											Class136 data = dictionary6[keyValuePair6.Key].Data;
											foreach (string text2 in keyValuePair6.Value[text])
											{
												if (data.method_6(text2) && class3.method_6(text2))
												{
													Class338 class5 = data[text2];
													class5.method_0(class3[text2]);
													class5.Data = null;
													key3.dictionary_0[text2].enum76_0 = Enum76.const_1;
												}
												else
												{
													key3.dictionary_0[text2].enum76_0 = Enum76.const_0;
												}
											}
										}
									}
									class3.method_18();
								}
								continue;
							}
						}
						if (dictionary2.ContainsKey(text))
						{
							foreach (KeyValuePair<Class102, HashSet<string>> keyValuePair7 in dictionary2[text])
							{
								Enum76 installState = keyValuePair7.Key.InstallState;
								if (installState == Enum76.const_2)
								{
									using (HashSet<string>.Enumerator enumerator3 = keyValuePair7.Value.GetEnumerator())
									{
										while (enumerator3.MoveNext())
										{
											string key4 = enumerator3.Current;
											switch (keyValuePair7.Key.dictionary_0[key4].enum76_0)
											{
											case Enum76.const_2:
												keyValuePair7.Key.dictionary_0[key4].enum76_0 = Enum76.const_0;
												continue;
											case Enum76.const_4:
												continue;
											}
											keyValuePair7.Key.dictionary_0[key4].enum76_0 = Enum76.const_3;
										}
										continue;
									}
								}
								foreach (string key5 in keyValuePair7.Value)
								{
									installState = keyValuePair7.Key.dictionary_0[key5].enum76_0;
									if (installState != Enum76.const_4)
									{
										keyValuePair7.Key.dictionary_0[key5].enum76_0 = Enum76.const_0;
									}
								}
							}
						}
					}
				}
				finally
				{
					foreach (KeyValuePair<Class102, Class132> keyValuePair8 in dictionary6)
					{
						keyValuePair8.Value.Dispose();
					}
				}
				foreach (Class102 class6 in Class110.Instance.ConnectSettings.ContentPacks)
				{
					class6.method_6();
				}
			}
		}

		// Token: 0x06002640 RID: 9792 RVA: 0x000880DC File Offset: 0x000862DC
		private void method_6()
		{
			bool flag = false;
			try
			{
				Class102.Class406 @class = new Class102.Class406();
				@class.class102_0 = this;
				object syncRoot;
				Monitor.Enter(syncRoot = ((ICollection)this.dictionary_0).SyncRoot, ref flag);
				@class.hashSet_0 = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
				this.dictionary_0.Keys.smethod_7(new Action<string>(@class.method_0));
				this.dictionary_0.smethod_8(@class.hashSet_0);
			}
			finally
			{
				if (flag)
				{
					object syncRoot;
					Monitor.Exit(syncRoot);
				}
			}
			switch (this.InstallState)
			{
			case Enum76.const_2:
			{
				bool flag2 = false;
				foreach (KeyValuePair<string, Class102.Class403> keyValuePair in this.dictionary_0)
				{
					if (keyValuePair.Value.enum76_0 == Enum76.const_2)
					{
						flag2 = true;
						break;
					}
				}
				if (flag2)
				{
					this.InstallState = Enum76.const_2;
					return;
				}
				this.InstallState = Enum76.const_0;
				break;
			}
			case Enum76.const_3:
				if (!this.LoaderPack)
				{
					bool flag3 = false;
					foreach (KeyValuePair<string, Class102.Class403> keyValuePair2 in this.dictionary_0)
					{
						if (keyValuePair2.Value.enum76_0 == Enum76.const_3)
						{
							flag3 = true;
							break;
						}
					}
					if (flag3)
					{
						this.InstallState = Enum76.const_3;
						return;
					}
					this.InstallState = Enum76.const_1;
					return;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06002641 RID: 9793 RVA: 0x0008825C File Offset: 0x0008645C
		private void method_7(out Dictionary<string, HashSet<string>> installingFiles, out Dictionary<string, HashSet<string>> uninstallingFiles)
		{
			installingFiles = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
			uninstallingFiles = new Dictionary<string, HashSet<string>>(StringComparer.OrdinalIgnoreCase);
			if (this.InstallState != Enum76.const_0)
			{
				lock (((ICollection)this.dictionary_0).SyncRoot)
				{
					foreach (KeyValuePair<string, Class102.Class403> keyValuePair in this.dictionary_0)
					{
						string key;
						if (keyValuePair.Value.enum76_0 != Enum76.const_0 && Class136.smethod_5(keyValuePair.Key, out key))
						{
							Enum76 installState = this.InstallState;
							if (installState == Enum76.const_2)
							{
								switch (keyValuePair.Value.enum76_0)
								{
								case Enum76.const_1:
								case Enum76.const_2:
								case Enum76.const_4:
									if (!uninstallingFiles.ContainsKey(key))
									{
										uninstallingFiles.Add(key, new HashSet<string>(StringComparer.OrdinalIgnoreCase));
									}
									uninstallingFiles[key].Add(keyValuePair.Key);
									break;
								}
							}
							else
							{
								switch (keyValuePair.Value.enum76_0)
								{
								case Enum76.const_2:
								case Enum76.const_4:
									if (!uninstallingFiles.ContainsKey(key))
									{
										uninstallingFiles.Add(key, new HashSet<string>(StringComparer.OrdinalIgnoreCase));
									}
									uninstallingFiles[key].Add(keyValuePair.Key);
									break;
								case Enum76.const_3:
									if (!installingFiles.ContainsKey(key))
									{
										installingFiles.Add(key, new HashSet<string>(StringComparer.OrdinalIgnoreCase));
									}
									installingFiles[key].Add(keyValuePair.Key);
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06002642 RID: 9794 RVA: 0x00010F2D File Offset: 0x0000F12D
		[CompilerGenerated]
		private static bool smethod_3(KeyValuePair<string, Dictionary<Class102, HashSet<string>>> item)
		{
			return item.Value.Count == 0;
		}

		// Token: 0x040012A5 RID: 4773
		public Dictionary<string, Class102.Class403> dictionary_0;

		// Token: 0x040012A6 RID: 4774
		[CompilerGenerated]
		private Guid guid_0;

		// Token: 0x040012A7 RID: 4775
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040012A8 RID: 4776
		[CompilerGenerated]
		private Enum76 enum76_0;

		// Token: 0x040012A9 RID: 4777
		[CompilerGenerated]
		private Uri uri_0;

		// Token: 0x040012AA RID: 4778
		[CompilerGenerated]
		private string string_1;

		// Token: 0x040012AB RID: 4779
		[CompilerGenerated]
		private Struct43 struct43_0;

		// Token: 0x040012AC RID: 4780
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040012AD RID: 4781
		[CompilerGenerated]
		private Enum82 enum82_0;

		// Token: 0x040012AE RID: 4782
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040012AF RID: 4783
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x040012B0 RID: 4784
		[CompilerGenerated]
		private Version version_0;

		// Token: 0x040012B1 RID: 4785
		[CompilerGenerated]
		private static Func<KeyValuePair<string, Dictionary<Class102, HashSet<string>>>, bool> func_0;

		// Token: 0x020003E6 RID: 998
		internal sealed class Class403
		{
			// Token: 0x06002643 RID: 9795 RVA: 0x00010F3E File Offset: 0x0000F13E
			public Class403(Struct43 hash, Enum76 state)
			{
				this.struct43_0 = hash;
				this.enum76_0 = state;
			}

			// Token: 0x040012B2 RID: 4786
			public Struct43 struct43_0;

			// Token: 0x040012B3 RID: 4787
			public Enum76 enum76_0;
		}

		// Token: 0x020003E7 RID: 999
		[CompilerGenerated]
		private sealed class Class404
		{
			// Token: 0x06002645 RID: 9797 RVA: 0x00088438 File Offset: 0x00086638
			public void method_0(KeyValuePair<string, Dictionary<Class102, HashSet<string>>> removeItem)
			{
				Action<KeyValuePair<Class102, HashSet<string>>> action = null;
				Class102.Class404.Class405 @class = new Class102.Class404.Class405();
				@class.class404_0 = this;
				@class.keyValuePair_0 = removeItem;
				if (this.dictionary_0.ContainsKey(@class.keyValuePair_0.Key))
				{
					IEnumerable<KeyValuePair<Class102, HashSet<string>>> value = @class.keyValuePair_0.Value;
					if (action == null)
					{
						action = new Action<KeyValuePair<Class102, HashSet<string>>>(@class.method_0);
					}
					value.smethod_7(action);
					IEnumerable<KeyValuePair<Class102, HashSet<string>>> value2 = @class.keyValuePair_0.Value;
					if (Class102.Class404.func_0 == null)
					{
						Class102.Class404.func_0 = new Func<KeyValuePair<Class102, HashSet<string>>, bool>(Class102.Class404.smethod_0);
					}
					KeyValuePair<Class102, HashSet<string>>[] array = value2.Where(Class102.Class404.func_0).ToArray<KeyValuePair<Class102, HashSet<string>>>();
					foreach (KeyValuePair<Class102, HashSet<string>> keyValuePair in array)
					{
						@class.keyValuePair_0.Value.Remove(keyValuePair.Key);
					}
				}
			}

			// Token: 0x06002646 RID: 9798 RVA: 0x00010F54 File Offset: 0x0000F154
			private static bool smethod_0(KeyValuePair<Class102, HashSet<string>> item)
			{
				return item.Value.Count == 0;
			}

			// Token: 0x040012B4 RID: 4788
			public Dictionary<string, HashSet<string>> dictionary_0;

			// Token: 0x040012B5 RID: 4789
			private static Func<KeyValuePair<Class102, HashSet<string>>, bool> func_0;

			// Token: 0x020003E8 RID: 1000
			private sealed class Class405
			{
				// Token: 0x06002648 RID: 9800 RVA: 0x00088508 File Offset: 0x00086708
				public void method_0(KeyValuePair<Class102, HashSet<string>> removeFile)
				{
					IEnumerable<string> enumerable = removeFile.Value.Where(new Func<string, bool>(this.method_1));
					foreach (string key in enumerable)
					{
						Enum76 enum76_ = removeFile.Key.dictionary_0[key].enum76_0;
						if (enum76_ != Enum76.const_4)
						{
							removeFile.Key.dictionary_0[key].enum76_0 = Enum76.const_0;
						}
					}
					removeFile.Value.RemoveWhere(new Predicate<string>(this.method_2));
				}

				// Token: 0x06002649 RID: 9801 RVA: 0x00010F65 File Offset: 0x0000F165
				public bool method_1(string item)
				{
					return this.class404_0.dictionary_0[this.keyValuePair_0.Key].Contains(item);
				}

				// Token: 0x0600264A RID: 9802 RVA: 0x00010F65 File Offset: 0x0000F165
				public bool method_2(string item)
				{
					return this.class404_0.dictionary_0[this.keyValuePair_0.Key].Contains(item);
				}

				// Token: 0x040012B6 RID: 4790
				public Class102.Class404 class404_0;

				// Token: 0x040012B7 RID: 4791
				public KeyValuePair<string, Dictionary<Class102, HashSet<string>>> keyValuePair_0;
			}
		}

		// Token: 0x020003E9 RID: 1001
		[CompilerGenerated]
		private sealed class Class406
		{
			// Token: 0x0600264C RID: 9804 RVA: 0x000885B0 File Offset: 0x000867B0
			public void method_0(string item)
			{
				Enum76 enum76_ = this.class102_0.dictionary_0[item].enum76_0;
				if (enum76_ != Enum76.const_4)
				{
					return;
				}
				this.hashSet_0.Add(item);
			}

			// Token: 0x040012B8 RID: 4792
			public HashSet<string> hashSet_0;

			// Token: 0x040012B9 RID: 4793
			public Class102 class102_0;
		}
	}
}
