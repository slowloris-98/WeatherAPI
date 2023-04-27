using Newtonsoft.Json;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class WeatherService : IWeatherService
    {
        private IConfiguration _config;

        public WeatherService(IConfiguration configuration)
        {
            _config = configuration;
        }
        public async Task<string> GetTemperatureAsync(string city)
        {
            try
            {
                Weather weatherObj = new Weather();
                var weatherClient = new HttpClient();
                var weatherKey = _config["WeatherAPISettings:Key"];
                var weatherURl = _config["WeatherAPISettings:URL"] + weatherKey + "&q=" + city + "&aqi=no";
                var weatherRequest = new HttpRequestMessage(HttpMethod.Get, weatherURl);
                var weatherResponse = await weatherClient.SendAsync(weatherRequest);

                if (weatherResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    weatherObj = JsonConvert.DeserializeObject<Weather>(weatherResponse.Content.ReadAsStringAsync().Result);
                }
                return weatherObj.Current.Temperature;
            }
            catch
            {
                throw;
            }
        }
    }
}
