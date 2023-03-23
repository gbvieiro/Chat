using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection.Module
{
    [BsonIgnoreExtraElements]
    public class DesignItemFeaturesDocument
    {
        public string Category { get; set; }
        public string Feature { get; set; }
        public string Option { get; set; }
    }
}