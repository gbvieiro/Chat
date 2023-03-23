using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ReferenceLongDescriptionsCollection
{
    /// <summary>
    /// Represents the document model for the ReferenceLongDescriptions Collection.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class ReferenceLongDescriptionDocument : MongoDocument
    {
        /// <summary>
        /// The reference id that is used to find the long description
        /// </summary>
        public string Reference { get; set; }
        /// <summary>
        /// The long description test.
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// The brand name that is used to find the long description.
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// The last time that the register was modified.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}