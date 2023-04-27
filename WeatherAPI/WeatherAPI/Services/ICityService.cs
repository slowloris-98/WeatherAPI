using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public interface ICityService
    {
        string GetCity(string cityId);
    }
}
