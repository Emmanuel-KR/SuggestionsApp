
namespace SuggestionsAppLibrary.Models
{
    public class UserModel
    {
        [BsonId] //represents that this is an Identifier
        [BsonRepresentation(BsonType.ObjectId)] //To represent Object Id in MongoDB
        public string Id { get; set; } //mongo Id
        public string ObjectIdentifier { get; set; }//azure Id
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string EmailAddress { get; set; }
        public List<BasicSuggestionModel> AuthoredSuggestions { get; set; }
        public List<BasicSuggestionModel> VotedOnSuggestions { get; set; }
    }
}
