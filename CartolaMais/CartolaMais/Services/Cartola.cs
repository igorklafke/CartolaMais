using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CartolaMais.Services
{
	public class Cartola
	{
		public Cartola()
		{
		}

		public async Task<string> Autenticar(string email, string senha)
		{
			using (var httpClient = new HttpClient() { MaxResponseContentBufferSize = int.MaxValue })
			{
                string json = "{\"payload\":{\"email\":\"" + email + "\",\"password\":\"" + senha + "\",\"serviceId\":438}}";

				var request = new HttpRequestMessage()
				{
					RequestUri = new Uri("https://login.globo.com/api/authentication"),
					Method = HttpMethod.Post,
					Content = new StringContent(json,
									Encoding.UTF8,
									"application/json")
				};

				var response = await httpClient.SendAsync(request);
				response.EnsureSuccessStatusCode();
				return await response.Content.ReadAsStringAsync();
			}
		}
	}
}

