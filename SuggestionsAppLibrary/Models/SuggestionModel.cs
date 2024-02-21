
namespace SuggestionsAppLibrary.Models
{
    public class SuggestionModel
    {
        [BsonId] //represents that this is an Identifier Unique
        [BsonRepresentation(BsonType.ObjectId)] //To represent Object Id in MongoDB
        public string Id { get; set; }
        public string Suggestion { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public CategoryModel Category { get; set; }
        public BasicUserModel Author { get; set; }
        public HashSet<string> UserVote { get; set; } = new();
        public StatusModel SuggestionStatus { get; set; }
        public string OwnersNotes { get; set; }
        public bool ApprovedForRelease { get; set; } = false;
        public bool Archived { get; set; } = false;
        public bool Rejected { get; set; } = false;


    }
}
