using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections
{
    [BsonIgnoreExtraElements]
    public abstract class MongoDocument
    {
        public MongoDocument()
        {
            Id = string.Empty;
        }

        [BsonId]
        public string Id { get; set; }

        public virtual string GenerateId()
        {
            Id = GetNewId();
            return Id;
        }

        protected static string GetNewId() => Guid.NewGuid().ToString();
    }
}