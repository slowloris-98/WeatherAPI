namespace WeatherAPI.Models
{
    public interface IUserStoreDatabaseSettings
    {
        string UserCollectionName { get; set; }
        string DatabaseName { get; set; }
        string ConnectionString { get; set; }
    }
}
