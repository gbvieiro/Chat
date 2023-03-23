using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection.Module
{
    [BsonIgnoreExtraElements]
    public class VectorThreeDocument
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }
    }
}