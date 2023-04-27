using FluentValidation;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WeatherAPI.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;
    }

    //public class UserValidator : AbstractValidator<User>
    //{
    //    public UserValidator()
    //    {
    //        RuleFor(x => x.Id).Empty().WithMessage("Id field should be empty");
    //        RuleFor(x => x.Name).NotEmpty().WithMessage("Name field cannot be empty");
    //    }
    //}
}
