using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection.Module
{
    [BsonIgnoreExtraElements]
    public class ProjectModuleDocument : MongoDocument
    {
        public string Brand { get; set; }
        public string SpecificationId { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public VectorThreeDocument? Dimension { get; set; }
        public List<ReferenceItemDocument> References { get; set; }
        public string[] CollectionTagsIds { get; set; }
        public List<DesignItemFeaturesDocument> DesignItemFeatures { get; set; }
    }
}