using Newtonsoft.Json;

namespace WeatherAPI.Models
{
    public class IP
    {
        [JsonProperty("status")]
        public string Status { get; set; } = string.Empty;

        [JsonProperty("country")]
        public string Country { get; set; } = string.Empty;

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; } = string.Empty;

        [JsonProperty("region")]
        public string Region { get; set; } = string.Empty;

        [JsonProperty("regionName")]
        public string RegionName { get; set; } = string.Empty;

        [JsonProperty("city")]
        public string City { get; set; } = string.Empty;

        [JsonProperty("zip")]
        public string Zip { get; set; } = string.Empty;

        [JsonProperty("lat")]
        public string Lat { get; set; } = string.Empty;

        [JsonProperty("lon")]
        public string Lon { get; set; } = string.Empty;

        [JsonProperty("timezone")]
        public string Timezone { get; set; } = string.Empty;

        [JsonProperty("isp")]
        public string Isp { get; set; } = string.Empty;

        [JsonProperty("org")]
        public string Org { get; set; } = string.Empty;

        [JsonProperty("as")]
        public string As { get; set; } = string.Empty;

        [JsonProperty("query")]
        public string Query { get; set; } = string.Empty;
    }
}
