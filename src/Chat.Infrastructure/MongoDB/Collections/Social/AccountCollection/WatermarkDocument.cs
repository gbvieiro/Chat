using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class WatermarkDocument
    {
        public string Image { get; set; }
        public double Opacity { get; set; }
    }
}