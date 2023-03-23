using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class ProjectOpenedDocument
    {
        public string ProjectId { get; set; }
        public DateTime DateOfOpening { get; set; }
    }
}