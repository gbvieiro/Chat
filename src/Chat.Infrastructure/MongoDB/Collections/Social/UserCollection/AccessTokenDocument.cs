using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.UserCollection
{
    [BsonIgnoreExtraElements]
    public partial class AccessTokenDocument
    {
        public string Value { get; set; }
        public DateTime Expiration { get; set; }
    }
}