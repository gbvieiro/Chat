using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ExampleCollection
{
    [BsonIgnoreExtraElements]
    public class ExampleDocument : MongoDocument
    {
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public int Number { get; set; }
    }
}