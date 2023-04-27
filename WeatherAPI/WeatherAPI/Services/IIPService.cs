namespace WeatherAPI.Services
{
    public interface IIPService
    {
        Task<string> GetCityAsync(string clientIP);
    }
}
