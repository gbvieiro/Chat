using Design.IS7.Infrastructure.MongoDB.Collections;
using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.UserCollection
{
    [BsonIgnoreExtraElements]
    public partial class UserDocument : MongoDocument
    {
        public bool CanAccessIS7 { get; set; }
        public string LoginId { get; set; }
        public List<UserAccountDocument> Accounts { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PasswordChangeDate { get; set; }
        public bool DenyPasswordChange { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ActiveToken { get; set; }
        public bool Active { get; set; }
        public string ResetPasswordToken { get; set; }
        public bool IsMoobleAdmin { get; set; }
        public string IdentificationHash { get; set; }
        public string FacebookId { get; set; }
        public string GoogleId { get; set; }
        public string PromobId { get; set; }
        public string ECommerceId { get; set; }
        public List<string> ECommerceIds { get; set; }
        public List<int> LdapSection { get; set; }
        public string ExternalId { get; set; }
        public string Partnership { get; set; }
        public AccessTokenDocument AccessToken { get; set; }
    }
}