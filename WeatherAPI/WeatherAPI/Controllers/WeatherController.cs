using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson.IO;
using System.Net;
using System.Net.Sockets;
using WeatherAPI.Models;
using WeatherAPI.Services;

namespace WeatherAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private IConfiguration _config;
        private IIPService ipService;
        private IWeatherService weatherService;

        public WeatherController(IConfiguration configuration, IIPService ipService, IWeatherService weatherService)
        {
            _config = configuration;
            this.ipService = ipService;
            this.weatherService = weatherService;
        }


        [Authorize]
        [HttpGet]
        public IActionResult Weather()
        {
            string clientIP = Response.HttpContext.Connection.RemoteIpAddress.ToString();

            if (clientIP == "::1")
            {
                clientIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList[1].ToString();
            }

            string city = ipService.GetCityAsync(clientIP).Result;
            string temp = weatherService.GetTemperatureAsync(city).Result;

            IActionResult response = Ok(new { temperature = temp });

            return response;
        }
    }
}
