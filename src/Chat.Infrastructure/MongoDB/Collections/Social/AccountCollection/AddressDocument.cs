using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class AddressDocument
    {
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Adjunct { get; set; }
        public string District { get; set; }
        public string CityId { get; set; }
        public string City { get; set; }
        public string StateId { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }
    }
}