
namespace SuggestionsAppLibrary.Models
{
    public class CategoryModel
    {
        [BsonId] //represents that this is an Identifier
        [BsonRepresentation(BsonType.ObjectId)] //To represent Object Id in MongoDB
        public string Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
