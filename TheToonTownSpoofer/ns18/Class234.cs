using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns30;

namespace ns18
{
	// Token: 0x020002A4 RID: 676
	internal static class Class234
	{
		// Token: 0x06001BA6 RID: 7078 RVA: 0x00056C78 File Offset: 0x00054E78
		public static KeyValuePair<string, DirectoryInfo>[] smethod_0(DirectoryInfo directory)
		{
			List<KeyValuePair<string, DirectoryInfo>> list = new List<KeyValuePair<string, DirectoryInfo>>();
			list.Add(new KeyValuePair<string, DirectoryInfo>(directory.Name, directory));
			for (DirectoryInfo parent = directory.Parent; parent != null; parent = parent.Parent)
			{
				list.Add(new KeyValuePair<string, DirectoryInfo>(parent.Name, parent));
			}
			list.Reverse();
			return list.ToArray();
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00056CD0 File Offset: 0x00054ED0
		public static string[] smethod_1(string directory, string searchPattern, string extension)
		{
			Class234.Class235 @class = new Class234.Class235();
			@class.string_0 = extension;
			return Directory.GetFiles(directory, searchPattern).Where(new Func<string, bool>(@class.method_0)).ToArray<string>();
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x0000A2E2 File Offset: 0x000084E2
		public static bool smethod_2(string directory)
		{
			return Directory.GetFiles(directory).Length > 0 || Directory.GetDirectories(directory).Length > 0;
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x0000A2FC File Offset: 0x000084FC
		public static bool smethod_3(string directory)
		{
			return Directory.GetFiles(directory).Length > 0;
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00056D08 File Offset: 0x00054F08
		public static bool smethod_4(string file)
		{
			bool result;
			try
			{
				using (File.Open(file, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
				{
				}
				return false;
			}
			catch (IOException e)
			{
				uint hrforException = (uint)Marshal.GetHRForException(e);
				if (hrforException != 2147942432U)
				{
					return false;
				}
				result = true;
			}
			return result;
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00056D64 File Offset: 0x00054F64
		public static bool smethod_5(string filePath)
		{
			if (!File.Exists(filePath))
			{
				throw new FileNotFoundException("Cannot determine locked state of file; File not found.", filePath);
			}
			bool result;
			try
			{
				using (File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
				{
					result = true;
				}
			}
			catch (IOException)
			{
				result = false;
			}
			return result;
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00056DC0 File Offset: 0x00054FC0
		public static void smethod_6(string filename, byte[] bytes)
		{
			using (Stream stream = File.Open(filename, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				bytes.smethod_0(stream);
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00056DFC File Offset: 0x00054FFC
		public static byte[] smethod_7(string filename)
		{
			byte[] result;
			using (Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
			{
				byte[] array = new byte[stream.Length];
				stream.smethod_6(array);
				result = array;
			}
			return result;
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00056E48 File Offset: 0x00055048
		public static string smethod_8(string filePath)
		{
			string result;
			using (Stream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.None))
			{
				using (StreamReader streamReader = new StreamReader(stream))
				{
					result = streamReader.ReadToEnd();
				}
			}
			return result;
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x00056EA0 File Offset: 0x000550A0
		public static void smethod_9(byte[] data, string filePath)
		{
			using (Stream stream = File.Open(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				data.smethod_0(stream);
			}
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00056EDC File Offset: 0x000550DC
		public static void smethod_10(Stream source_stream, string filePath)
		{
			using (Stream stream = File.Open(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				source_stream.CopyTo(stream);
			}
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00056F18 File Offset: 0x00055118
		public static long smethod_11(string filePath)
		{
			FileInfo fileInfo = new FileInfo(filePath);
			if (fileInfo.Exists)
			{
				return fileInfo.Length;
			}
			return 0L;
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00056F44 File Offset: 0x00055144
		public static DateTime smethod_12(string filePath)
		{
			FileInfo fileInfo = new FileInfo(filePath);
			return fileInfo.CreationTimeUtc;
		}

		// Token: 0x06001BB3 RID: 7091 RVA: 0x00056F60 File Offset: 0x00055160
		public static void smethod_13(string filePath, out long fileSize, out DateTime createdDate)
		{
			FileInfo fileInfo = new FileInfo(filePath);
			fileSize = fileInfo.Length;
			createdDate = fileInfo.CreationTimeUtc;
		}

		// Token: 0x06001BB4 RID: 7092 RVA: 0x0000A309 File Offset: 0x00008509
		public static void smethod_14(string source_file, string destination_file, bool overwrite)
		{
			if (overwrite && File.Exists(destination_file))
			{
				File.Delete(destination_file);
			}
			File.Move(source_file, destination_file);
		}

		// Token: 0x020002A5 RID: 677
		[CompilerGenerated]
		private sealed class Class235
		{
			// Token: 0x06001BB6 RID: 7094 RVA: 0x0000A323 File Offset: 0x00008523
			public bool method_0(string file)
			{
				return string.Equals(Path.GetExtension(file), this.string_0, StringComparison.OrdinalIgnoreCase);
			}

			// Token: 0x04000976 RID: 2422
			public string string_0;
		}
	}
}
