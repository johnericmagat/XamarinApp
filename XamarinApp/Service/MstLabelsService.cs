using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using XamarinApp.Helper;
using XamarinApp.Model;

namespace XamarinApp.Service
{
	public class MstLabelsService
	{
		private string url;
		private HttpClient client;

		public MstLabelsService()
		{
			url = AppSettingsHelper.defaultAPIURLHost;
			client = new HttpClient();
		}

		public async Task<List<MstLabelsModel>> FilterLabels()
		{
			List<MstLabelsModel> list = new List<MstLabelsModel>();

			client = await AppSettingsHelper.Authorizer(client);
			Uri uri = new Uri(url + "/mst/api/labels/list");

			HttpResponseMessage response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				list = JsonConvert.DeserializeObject<List<MstLabelsModel>>(content);
			}

			return list;
		}

		public async Task<MstLabelsModel> ViewLabel(int id)
		{
			MstLabelsModel label = new MstLabelsModel();

			client = await AppSettingsHelper.Authorizer(client);
			Uri uri = new Uri(url + "/mst/api/labels/detial/" + id.ToString());

			HttpResponseMessage response = await client.GetAsync(uri);
			if (response.IsSuccessStatusCode)
			{
				string content = await response.Content.ReadAsStringAsync();
				label = JsonConvert.DeserializeObject<MstLabelsModel>(content);
			}

			return label;
		}

		public async void UpdateLabel(int id, MstLabelsModel label)
		{
			client = await AppSettingsHelper.Authorizer(client);
			Uri uri = new Uri(url + "/mst/api/labels/update/" + id.ToString());

			string json = JsonConvert.SerializeObject(label);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

			HttpResponseMessage response = await client.PutAsync(uri, content);
			if (response.IsSuccessStatusCode)
			{
			}
		}

		public async void InsertLabel(MstLabelsModel label)
		{
			client = await AppSettingsHelper.Authorizer(client);
			Uri uri = new Uri(url + "/mst/api/labels/create");

			string json = JsonConvert.SerializeObject(label);
			StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

			HttpResponseMessage response = await client.PostAsync(uri, content);
			if (response.IsSuccessStatusCode)
			{
			}
		}

		public async void DeleteLabel(int id)
		{
			client = await AppSettingsHelper.Authorizer(client);
			Uri uri = new Uri(url + "/mst/api/labels/delete/" + id.ToString());

			HttpResponseMessage response = await client.DeleteAsync(uri);
			if (response.IsSuccessStatusCode)
			{
			}
		}
	}
}
