using MongoDB.Driver;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class UserService : IUserService
    {
        private IMongoCollection<Users> _users;
        public UserService(IUserStoreDatabaseSettings settings, IMongoClient mongoClient) 
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<Users>(settings.UserCollectionName);
        }

        public List<Users> GetUser() 
        {
            return _users.Find(user => true).ToList();
        }

        public Users Create(Users user) 
        {
            _users.InsertOne(user);
            return user;
        }
    }
}
