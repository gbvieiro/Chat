using Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection.Profile;
using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class AccountDocument : MongoDocument
    {
        public int AccountType { get; set; }
        public string Partnership { get; set; }
        public bool PartnershipOwner { get; set; }
        public Dictionary<string, string> ECommerceIds { get; set; }
        public string Nickname { get; set; }
        public string Region { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Url { get; set; }
        public bool Deactive { get; set; }
        public List<string> HideInStoreSearch { get; set; }
        public string EmailsCC { get; set; }
        public string Picture { get; set; }
        public List<string> FrontBudget { get; set; }
        public List<string> BackBudget { get; set; }
        public WatermarkDocument Watermark { get; set; }
        public WatermarkDocument Stampmark { get; set; }
        public AddressDocument Address { get; set; }
        public List<string> BrandsOwner { get; set; }
        public List<string> BudgetBrands { get; set; }
        public List<BrandsSellerDocument> BrandsSeller { get; set; }
        public List<string> BrandsNotForStores { get; set; }
        public List<string> ChainAccounts { get; set; }
        public List<RepresentativeInfoDocument> RepresentativeInfo { get; set; }
        public DateTime Date { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Main { get; set; }
        public string IdentificationCode { get; set; }
        public string IdentificationType { get; set; }
        public string LegalName { get; set; }
        public string TradeName { get; set; }
        public string Celular { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public double? Longitude { get; set; }
        public double? Latitude { get; set; }
        public SubscriptionDocument Subscription { get; set; }
        public string MarkupPassword { get; set; }
        public string ResetPasswordMarkupToken { get; set; }
        public string Logotype { get; set; }
        public ProfileDocument Profile { get; set; }
        public MCMStoreInfoDocument MCMStoreInfo { get; set; }
        public string BudgetImage { get; set; }
        public string BudgetDescription { get; set; }
        public string AccountRecievesBudget { get; set; }
        public List<PartnershipAccessValidityDocument> PartnershipAccessValidity { get; set; }
        public int? PromobPortalUserId { get; set; }
        public int? PromobPortalAccountId { get; set; }
        public string StateInscription { get; set; }
        public string BonusPlan { get; set; }
        public List<string> DisableStoreSearch { get; set; }
        public string Logo { get; set; }
        public bool AllowMarketingEmails { get; set; }
        public List<ProjectOpenedDocument> ProjectOpened { get; set; }
    }
}