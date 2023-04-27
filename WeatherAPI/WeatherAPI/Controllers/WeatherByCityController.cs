using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using WeatherAPI.Models;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherByCityController : ControllerBase
    {
        private IConfiguration _config;
        private ICityService cityService;
        private IWeatherService weatherService;

        public WeatherByCityController(IConfiguration configuration, ICityService cityService, IWeatherService weatherService)
        {
            _config = configuration;
            this.cityService = cityService;
            this.weatherService = weatherService;
        }


        [Authorize]
        [HttpPost]
        public IActionResult WeatherByCity(City city)
        {
            IActionResult response = null;
            string cityName = cityService.GetCity(city.CityId);
            if(string.IsNullOrWhiteSpace(cityName))
            {
                response = NotFound(new {error = "City not found"});
            }
            else
            {
                string temp = weatherService.GetTemperatureAsync(cityName).Result;
                response = Ok(new { temperature = temp });
            }

            return response;
        }
    }
}
