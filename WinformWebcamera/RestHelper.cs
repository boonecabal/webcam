using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Webcam
{
	public static class RestHelper
	{
		private static readonly string baseUrl = "https://ogden.rent/wp-json/wp/v2/customers";

		public static async Task<string> GetAll()
		{
			using (HttpClient client = new HttpClient())
			{
				using (HttpResponseMessage res = await client.GetAsync(baseUrl))
				{
					using (HttpContent content = res.Content)
					{
						string data = await content.ReadAsStringAsync();
						if (data != null)
						{
							return data;
						}
					}
				}
			}
			return string.Empty;
		}

		public static string BeautifyJson(string jsonStr)
		{
			JToken parseJson = JToken.Parse(jsonStr);
			return parseJson.ToString(Formatting.Indented);
		}
	}
}
