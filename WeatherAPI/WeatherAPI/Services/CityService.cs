using MongoDB.Bson;
using MongoDB.Driver;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class CityService : ICityService
    {
        private IMongoCollection<City> _cities;
        public CityService(IStoreDatabaseSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _cities = database.GetCollection<City>(settings.CityCollectionName);
        }

        public string GetCity(ObjectId cityId)
        {
            try
            {
                var cityName = _cities.Find(city => city.CityId == cityId).FirstOrDefault().CityName;
                if(!string.IsNullOrWhiteSpace(cityName))
                {
                    return cityName;
                }
                else
                {
                    return string.Empty;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
