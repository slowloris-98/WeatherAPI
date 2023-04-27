using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace WeatherAPI.Models
{
    public class City
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public string CityId { get; set; } = string.Empty;

        [BsonElement("cityname")]
        public string CityName { get; set; } = string.Empty;
    }
}
