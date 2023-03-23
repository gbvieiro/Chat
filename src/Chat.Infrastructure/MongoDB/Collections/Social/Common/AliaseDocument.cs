using Design.IS7.Infrastructure.MongoDB.Collections;
using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.Common
{
    [BsonIgnoreExtraElements]
    public class AliaseDocument : MongoDocument
    {
        public string Name { get; set; }
    }
}