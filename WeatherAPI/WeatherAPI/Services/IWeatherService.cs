namespace WeatherAPI.Services
{
    public interface IWeatherService
    {
        Task<string> GetTemperatureAsync(string city);
    }
}
