
namespace SuggestionsAppLibrary.Models
{
    public class StatusModel
    {
        [BsonId] //represents that this is an Identifier
        [BsonRepresentation(BsonType.ObjectId)] //To represent Object Id in MongoDB
        public string Id { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
    }
}
