using Design.IS7.Infrastructure.MongoDB.Collections;
using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.Common
{
    [BsonIgnoreExtraElements]
    public class LocalizationDocument : MongoDocument
    {
        public string ExpressionName { get; set; }
        public string ExpressionDescription { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Synonymous { get; set; }
        public List<AliaseDocument> Aliases { get; set; }
    }
}