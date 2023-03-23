using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class MCMStoreInfoDocument
    {
        public int NextOrderNumber { get; set; }
    }
}