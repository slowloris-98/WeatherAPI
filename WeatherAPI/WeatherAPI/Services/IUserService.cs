using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public interface IUserService
    {
        List<User> GetUser();
        User Create(User user);
    }
}
