using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class CustomButtonInfoDocument
    {
        public string ButtonId { get; set; }
        public string ButtonText { get; set; }
        public string ButtonImage { get; set; }
    }
}
