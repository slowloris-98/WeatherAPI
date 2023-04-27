using Newtonsoft.Json;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class IPService : IIPService
    {
        private IConfiguration _config;

        public IPService(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task<string> GetCityAsync(string clientIP)
        {
            try
            {
                IP ipAPIObj = new IP();
                var ipAPIClient = new HttpClient();
                var ipAPIURl = _config["IPAPISettings:URL"] + clientIP;
                var ipAPIRequest = new HttpRequestMessage(HttpMethod.Get, ipAPIURl);
                var ipAPIResponse = await ipAPIClient.SendAsync(ipAPIRequest);

                if (ipAPIResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    ipAPIObj = JsonConvert.DeserializeObject<IP>(ipAPIResponse.Content.ReadAsStringAsync().Result);
                }
                return ipAPIObj.City;
            }
            catch
            {
                throw;
            }
        }
    }
}
