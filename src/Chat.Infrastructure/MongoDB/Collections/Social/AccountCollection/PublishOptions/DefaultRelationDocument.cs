using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection.PublishOptions
{
    [BsonIgnoreExtraElements]
    public class DefaultRelationDocument
    {
        public string TagId { get; set; }
        public string MeaningId { get; set; }
    }
}