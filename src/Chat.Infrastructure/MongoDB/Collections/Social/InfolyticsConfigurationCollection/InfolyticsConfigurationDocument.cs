using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.InfolyticsConfigurationCollection
{
    /// <summary>
    /// Thius class represents the InfolyticsConfiguration collection document model.
    /// </summary>
    [BsonIgnoreExtraElements]
    public partial class InfolyticsConfigurationDocument : MongoDocument
    {
        /// <summary>
        /// Product Id provided by Infolytics.
        /// </summary>
        public string ProductId { get; set; }
        /// <summary>
        /// Product Name provided by Infolytics.
        /// </summary>
        public string ProductName { get; set; }
        /// <summary>
        /// Product Domain provided by Infolytics.
        /// </summary>
        public string ProductDomain { get; set; }
        /// <summary>
        /// The tag id to send on the request data. 
        /// </summary>
        public string TagId { get; set; }
        /// <summary>
        /// The enviroment type: Staging or Production.
        /// </summary>
        public string Environment { get; set; }
        /// <summary>
        /// Azure Function Metadata version.
        /// </summary>
        public string AzureFunctionMetadataVersion { get; set; }
        /// <summary>
        /// Azure Function data version.
        /// </summary>
        public string AzureFunctionDataVersion { get; set; }
    }
}