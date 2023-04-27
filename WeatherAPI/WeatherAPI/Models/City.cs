using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using FluentValidation;
using System;

namespace WeatherAPI.Models
{
    public class City
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("id")]
        public ObjectId CityId { get; set; }

        [BsonElement("cityname")]
        public string CityName { get; set; } = string.Empty;
    }

    public class CityValidator : AbstractValidator<City>
    {
        public CityValidator()
        {
            RuleFor(x => x.CityId).NotEmpty();
            RuleFor(x => x.CityName).Empty();
        }
    }
}
