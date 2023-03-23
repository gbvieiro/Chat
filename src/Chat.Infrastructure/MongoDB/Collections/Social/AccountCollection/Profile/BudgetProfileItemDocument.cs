using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection.Profile
{
    [BsonIgnoreExtraElements]
    public class BudgetProfileItemDocument
    {
        public int? Option { get; set; }
        public string Text { get; set; }
    }
}