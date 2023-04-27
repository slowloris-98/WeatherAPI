using System.Diagnostics.Contracts;
using Newtonsoft.Json;

namespace WeatherAPI.Models
{
    public class Condition
    {
    }

    public class Current
    {
        [JsonProperty(PropertyName = "temp_c")]
        public string Temperature { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "condition")]
        public Condition Condition { get; set; } = new Condition();

        [JsonProperty(PropertyName = "uv")]
        public string Uv { get; set; } = string.Empty;

    }

    public class Location
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "region")]
        public string Region { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "lat")]
        public string Lat { get; set; } = string.Empty;

        [JsonProperty(PropertyName = "lon")]
        public string Lon { get; set; } = string.Empty;
        
        [JsonProperty(PropertyName = "tz_id")]
        public string TzId { get; set; } = string.Empty;
        
        [JsonProperty(PropertyName = "localtime_epoch")]
        public string LocalTimeEpoch { get; set; } = string.Empty;
        
        [JsonProperty(PropertyName = "localtime")]
        public string LocalTime { get; set; } = string.Empty;

    }

    public class Weather
    {
        [JsonProperty("location")]
        public Location Location { get; set; } = new Location();

        [JsonProperty("current")]
        public Current Current { get; set; } = new Current();
    }
}
