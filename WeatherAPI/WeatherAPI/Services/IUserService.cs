using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public interface IUserService
    {
        List<Users> GetUser();
        Users Create(Users user);
    }
}
