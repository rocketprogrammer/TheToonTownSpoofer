using System;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using ns23;

namespace ns21
{
	// Token: 0x02000239 RID: 569
	internal static class Class178
	{
		// Token: 0x0600185A RID: 6234 RVA: 0x00042060 File Offset: 0x00040260
		static Class178()
		{
			ServicePointManager.DefaultConnectionLimit = int.MaxValue;
			ServicePointManager.MaxServicePointIdleTime = -1;
			if (Class178.remoteCertificateValidationCallback_0 == null)
			{
				Class178.remoteCertificateValidationCallback_0 = new RemoteCertificateValidationCallback(Class178.smethod_5);
			}
			ServicePointManager.ServerCertificateValidationCallback = Class178.remoteCertificateValidationCallback_0;
		}

		// Token: 0x0600185B RID: 6235 RVA: 0x000420CC File Offset: 0x000402CC
		public static DateTime smethod_0(this WebRequest request)
		{
			DateTime result;
			using (HttpWebResponse httpWebResponse = request.GetResponse() as HttpWebResponse)
			{
				result = httpWebResponse.LastModified.ToUniversalTime();
			}
			return result;
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00042114 File Offset: 0x00040314
		public static HttpWebRequest smethod_1(this Uri requestUri)
		{
			HttpWebRequest httpWebRequest = WebRequest.Create(requestUri) as HttpWebRequest;
			int connectionLimit = httpWebRequest.ServicePoint.ConnectionLimit;
			httpWebRequest.Credentials = Class178.icredentials_0;
			httpWebRequest.PreAuthenticate = Class178.bool_0;
			httpWebRequest.KeepAlive = true;
			if (!string.IsNullOrEmpty(Class178.string_0))
			{
				httpWebRequest.UserAgent = Class178.string_0;
			}
			httpWebRequest.ReadWriteTimeout = 40000;
			httpWebRequest.Timeout = Class178.int_0;
			httpWebRequest.Proxy = Class178.iwebProxy_0;
			return httpWebRequest;
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00042190 File Offset: 0x00040390
		public static void smethod_2(this Uri requestUri, Action<Uri, long> desti)
		{
			ThreadPool.QueueUserWorkItem(new WaitCallback(Class178.smethod_3), new object[]
			{
				requestUri,
				desti
			});
		}

		// Token: 0x0600185E RID: 6238 RVA: 0x000421C0 File Offset: 0x000403C0
		private static void smethod_3(object data)
		{
			object[] array = data as object[];
			Uri uri = array[0] as Uri;
			Action<Uri, long> action = array[1] as Action<Uri, long>;
			try
			{
				action(uri, uri.smethod_4());
			}
			catch (Exception ex)
			{
				ex.smethod_1(new object[]
				{
					uri.OriginalString
				});
				action(uri, -1L);
			}
		}

		// Token: 0x0600185F RID: 6239 RVA: 0x00042234 File Offset: 0x00040434
		public static long smethod_4(this Uri requestUri)
		{
			HttpWebRequest httpWebRequest = null;
			long result;
			try
			{
				httpWebRequest = requestUri.smethod_1();
				using (HttpWebResponse httpWebResponse = httpWebRequest.GetResponse() as HttpWebResponse)
				{
					try
					{
						result = httpWebResponse.ContentLength;
					}
					catch (NotSupportedException)
					{
						result = 0L;
					}
					finally
					{
						httpWebRequest.Abort();
						httpWebResponse.Close();
					}
				}
			}
			finally
			{
				if (httpWebRequest != null)
				{
					httpWebRequest.Abort();
				}
			}
			return result;
		}

		// Token: 0x06001860 RID: 6240 RVA: 0x00005B66 File Offset: 0x00003D66
		[CompilerGenerated]
		private static bool smethod_5(object obj, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			return true;
		}

		// Token: 0x04000673 RID: 1651
		private static readonly string string_0 = "ToontownLauncher";

		// Token: 0x04000674 RID: 1652
		private static IWebProxy iwebProxy_0 = WebRequest.DefaultWebProxy;

		// Token: 0x04000675 RID: 1653
		private static ICredentials icredentials_0 = null;

		// Token: 0x04000676 RID: 1654
		private static bool bool_0 = false;

		// Token: 0x04000677 RID: 1655
		private static int int_0 = 10000;

		// Token: 0x04000678 RID: 1656
		[CompilerGenerated]
		private static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;
	}
}
