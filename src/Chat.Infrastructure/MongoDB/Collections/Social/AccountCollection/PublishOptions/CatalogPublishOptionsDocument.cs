using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection.PublishOptions
{
    [BsonIgnoreExtraElements]
    public class CatalogPublishOptionsDocument
    {
        public List<DefaultRelationDocument> DefaultRelations { get; set; }
    }
}
