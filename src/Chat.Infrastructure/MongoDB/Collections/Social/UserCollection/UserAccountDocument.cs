using Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection.Profile;
using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.UserCollection
{
    [BsonIgnoreExtraElements]
    public partial class UserAccountDocument
    {
        public bool Active { get; set; }
        public string AccountId { get; set; }
        public string RuleSetId { get; set; }
        public ProfileDocument? Profile { get; set; }
    }
}