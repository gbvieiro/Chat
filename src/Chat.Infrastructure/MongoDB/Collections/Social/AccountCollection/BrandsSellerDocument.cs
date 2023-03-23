using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class BrandsSellerDocument
    {
        public string AccountId { get; set; }
        public List<string> Brands { get; set; }
        public string RepresentativeId { get; set; }
    }
}