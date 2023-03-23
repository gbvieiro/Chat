using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection
{
    [BsonIgnoreExtraElements]
    public class SubscriptionDocument
    {
        public int Type { get; set; }
        public string PagarMeSubscriptionId { get; set; }
        public int Status { get; set; }
        public DateTime NextCharging { get; set; }
        public string CurrentCreditCardBrand { get; set; }
        public string CurrentCreditCardLastFourDigits { get; set; }
        public double Amount { get; set; }
        public DateTime CreationDate { get; set; }
        public int PaymentMethod { get; set; }
        public string BoletoUrl { get; set; }
        public int LastPortalOrderId { get; set; }
        public int PaymentTerm { get; set; }
        public string PortalContractCode { get; set; }
        public int QuantityBrands { get; set; }
        public string UserPlanId { get; set; }
        public bool EarnTrial { get; set; }
        public string AccountPromotionId { get; set; }
    }
}