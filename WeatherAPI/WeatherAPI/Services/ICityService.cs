using MongoDB.Bson;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public interface ICityService
    {
        string GetCity(ObjectId cityId);
    }
}
