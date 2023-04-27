﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WeatherAPI.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
    }
}
