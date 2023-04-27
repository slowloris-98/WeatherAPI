namespace WeatherAPI.Models
{
    public interface IStoreDatabaseSettings
    {
        string UserCollectionName { get; set; }
        string CityCollectionName { get; set; }
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
