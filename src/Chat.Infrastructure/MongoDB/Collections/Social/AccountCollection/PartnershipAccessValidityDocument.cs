using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class PartnershipAccessValidityDocument
    {
        public string Partnership { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public int Status { get; set; }
        public int Profile { get; set; }
    }
}