using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using XamarinApp.Helper;

namespace XamarinApp.Service
{
	public class SysAccessTokenService
	{
		private string url;
		private HttpClient client;

		public async Task<int> WriteAccessToken()
		{
			int count = 0;

			url = AppSettingsHelper.defaultAPIURLHost;
			client = new HttpClient();
			client.DefaultRequestHeaders.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			var uri = url + "/token";
			string body = @"username=admin&password=easyfis&grant_type=password";

			using (var response = await client.PostAsync(uri, new StringContent(body, Encoding.UTF8, "application/x-www-form-urlencoded")))
			{
				if (response.IsSuccessStatusCode)
				{
					var result = JObject.Parse(await response.Content.ReadAsStringAsync());
					string token = (string)result["access_token"];

					await SecureStorage.SetAsync("access_token", token);
					count++;
				}
			}

			return count;
		}

		public async Task<string> ReadAccessToken()
		{
			var access_token = await SecureStorage.GetAsync("access_token");
			string token = access_token.ToString();

			return token;
		}
	}
}
