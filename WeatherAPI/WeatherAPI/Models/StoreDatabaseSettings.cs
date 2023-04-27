namespace WeatherAPI.Models
{
    public class StoreDatabaseSettings : IStoreDatabaseSettings
    {
        public string UserCollectionName { get; set; } = string.Empty;
        public string CityCollectionName { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;
        public string ConnectionString { get; set; } = string.Empty;
    }
}
