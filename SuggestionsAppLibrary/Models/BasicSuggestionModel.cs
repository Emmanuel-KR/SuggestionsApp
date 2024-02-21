namespace SuggestionsAppLibrary.Models
{
    public class BasicSuggestionModel
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Suggestion { get; set; }

        public BasicSuggestionModel() //implicit constractor
        {
            
        }

        public BasicSuggestionModel(SuggestionModel suggestion) //Explicit Contractor
        {
            Id = suggestion.Id;
            Suggestion = suggestion.Suggestion;
        }
    }
}
