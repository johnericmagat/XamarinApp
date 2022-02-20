using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using XamarinApp.Service;

namespace XamarinApp.Helper
{
	public static class AppSettingsHelper
	{
		public const string defaultAPIURLHost = "https://hris-api.hiro-test.net";

		public static async Task<HttpClient> Authorizer(HttpClient client)
		{
			SysAccessTokenService accessTokenService = new SysAccessTokenService();
			string token = await accessTokenService.ReadAccessToken();

			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

			return client;
		}
	}
}
