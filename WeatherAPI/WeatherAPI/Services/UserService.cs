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
            try
            {
                return _users.Find(user => true).ToList();
            }
            catch
            {
                throw;
            }
        }

        public Users Create(Users user) 
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
