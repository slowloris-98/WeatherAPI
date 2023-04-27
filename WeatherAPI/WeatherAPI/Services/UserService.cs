using MongoDB.Driver;
using WeatherAPI.Models;

namespace WeatherAPI.Services
{
    public class UserService : IUserService
    {
        private IMongoCollection<User> _users;
        public UserService(IStoreDatabaseSettings settings, IMongoClient mongoClient) 
        {
            var database = mongoClient.GetDatabase(settings.DatabaseName);
            _users = database.GetCollection<User>(settings.UserCollectionName);
        }

        public List<User> GetUser() 
        {
            try
            {
                return _users.Find(user => true).ToList();
            }
            catch
            {
                throw;
            }
        }

        public User Create(User user) 
        {
            try
            {
                _users.InsertOne(user);
                return user;
            }
            catch
            {
                throw;
            }
        }
    }
}
