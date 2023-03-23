using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class RepresentativeInfoDocument
    {
        public string RequestId { get; set; }
        public string ManufacturerId { get; set; }
        public string BrandId { get; set; }
        public string StateId { get; set; }
        public string CityId { get; set; }
        public List<string> StoreIds { get; set; }
    }
}