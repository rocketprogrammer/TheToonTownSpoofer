using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Schema;
using ns17;
using ns23;
using ns31;

namespace ns24
{
	// Token: 0x0200031D RID: 797
	internal sealed class Class305
	{
		// Token: 0x06001ED1 RID: 7889 RVA: 0x0000C00B File Offset: 0x0000A20B
		public Class305()
		{
			this.sortedList_0 = Class305.smethod_0(Class291.string_18);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x000653C4 File Offset: 0x000635C4
		private static SortedList<DateTime, KeyValuePair<Version, string[]>> smethod_0(string filePath)
		{
			XmlDocument xmlDocument = Class305.smethod_1(filePath);
			XmlElement xmlElement = xmlDocument[Class305.string_2];
			if (xmlDocument != null && xmlElement != null && xmlElement.ChildNodes.Count != 0)
			{
				SortedList<DateTime, KeyValuePair<Version, string[]>> sortedList = null;
				SortedList<DateTime, KeyValuePair<Version, string[]>> result;
				try
				{
					sortedList = new SortedList<DateTime, KeyValuePair<Version, string[]>>(new Class214<DateTime>());
					for (int i = 0; i < xmlElement.ChildNodes.Count; i++)
					{
						XmlNode xmlNode = xmlElement.ChildNodes[i];
						if (xmlNode.ChildNodes.Count > 0)
						{
							string value = xmlNode.Attributes[Class305.string_3].Value;
							string value2 = xmlNode.Attributes[Class305.string_0].Value;
							DateTime key;
							Version key2;
							if (DateTime.TryParse(value, out key) && Version.TryParse(value2, out key2) && !sortedList.ContainsKey(key))
							{
								string[] array = new string[xmlNode.ChildNodes.Count];
								for (int j = 0; j < xmlNode.ChildNodes.Count; j++)
								{
									XmlNode xmlNode2 = xmlNode.ChildNodes[j];
									if (xmlNode2.Name == Class305.string_4 && xmlNode2.HasChildNodes)
									{
										array[j] = xmlNode2.FirstChild.Value;
									}
								}
								IEnumerable<string> source = array;
								if (Class305.func_0 == null)
								{
									Class305.func_0 = new Func<string, bool>(Class305.smethod_2);
								}
								array = source.Where(Class305.func_0).ToArray<string>();
								if (array.Length > 0)
								{
									sortedList.Add(key, new KeyValuePair<Version, string[]>(key2, array));
								}
							}
						}
					}
					result = sortedList;
				}
				catch (Exception ex)
				{
					if (sortedList != null)
					{
						sortedList.Clear();
					}
					sortedList = null;
					ex.smethod_0();
					result = null;
				}
				finally
				{
				}
				return result;
			}
			return null;
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x000655B8 File Offset: 0x000637B8
		private static XmlDocument smethod_1(string filePath)
		{
			if (string.IsNullOrEmpty(filePath))
			{
				throw new ArgumentNullException("filePath");
			}
			if (!File.Exists(filePath))
			{
				throw new FileNotFoundException(string.Format(Class217.cultureInfo_0, Class305.string_1, new object[]
				{
					filePath
				}));
			}
			XmlDocument result;
			try
			{
				using (Stream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
				{
					XmlReaderSettings xmlReaderSettings = new XmlReaderSettings();
					xmlReaderSettings.DtdProcessing = DtdProcessing.Parse;
					xmlReaderSettings.ValidationType = ValidationType.DTD;
					XmlReaderSettings xmlReaderSettings2 = xmlReaderSettings;
					if (Class305.validationEventHandler_0 == null)
					{
						Class305.validationEventHandler_0 = new ValidationEventHandler(Class305.smethod_3);
					}
					xmlReaderSettings2.ValidationEventHandler += Class305.validationEventHandler_0;
					using (XmlReader xmlReader = XmlReader.Create(stream, xmlReaderSettings))
					{
						XmlDocument xmlDocument = new XmlDocument();
						xmlDocument.Load(xmlReader);
						result = xmlDocument;
					}
				}
			}
			catch (Exception ex)
			{
				ex.smethod_0();
				result = null;
			}
			return result;
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0000C023 File Offset: 0x0000A223
		[CompilerGenerated]
		private static bool smethod_2(string t)
		{
			return !string.IsNullOrEmpty(t);
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0000C02E File Offset: 0x0000A22E
		[CompilerGenerated]
		private static void smethod_3(object sender, ValidationEventArgs e)
		{
			e.Exception.smethod_0();
		}

		// Token: 0x04000BE1 RID: 3041
		private static readonly string string_0 = "version";

		// Token: 0x04000BE2 RID: 3042
		private static readonly string string_1 = "The XML file '{0}' does not exist.";

		// Token: 0x04000BE3 RID: 3043
		private static readonly string string_2 = "updates";

		// Token: 0x04000BE4 RID: 3044
		private static readonly string string_3 = "date";

		// Token: 0x04000BE5 RID: 3045
		private static readonly string string_4 = "content";

		// Token: 0x04000BE6 RID: 3046
		public readonly SortedList<DateTime, KeyValuePair<Version, string[]>> sortedList_0;

		// Token: 0x04000BE7 RID: 3047
		[CompilerGenerated]
		private static Func<string, bool> func_0;

		// Token: 0x04000BE8 RID: 3048
		[CompilerGenerated]
		private static ValidationEventHandler validationEventHandler_0;
	}
}
