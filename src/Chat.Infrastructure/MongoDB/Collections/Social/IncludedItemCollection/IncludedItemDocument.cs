using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.IncludeItemCollection
{
    /// <summary>
    /// The included items document represation class.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class IncludedItemDocument : MongoDocument
    {
        /// <summary>The associated brand</summary>
        public string Brand { get; set; }
        /// <summary>The owner's SKU code</summary>
        public string Sku { get; set; }
        /// <summary>The linked included priced SKU</summary>
        public string SkuIncluded { get; set; }
        /// <summary>The number of included items</summary>
        public uint IncludedQty { get; set; }
    }
}