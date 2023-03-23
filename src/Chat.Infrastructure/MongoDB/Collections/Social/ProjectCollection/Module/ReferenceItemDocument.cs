using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection.Module
{
    [BsonIgnoreExtraElements]
    public class ReferenceItemDocument
    {
        public string SpecificationId { get; set; }
        public string Reference { get; set; }
        public string Ean { get; set; }
    }
}