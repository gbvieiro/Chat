using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.HelpOverlayCollection
{
    /// <summary>
    /// The exact match of HelpOverlay document on the database.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class HelpOverlayDocument : MongoDocument
    {
        /// <summary>
        /// The partnership to whom the HelpOverlay is related to.
        /// </summary>
        public string Partnership { get; set; }

        /// <summary>
        /// Defines whether the HelpOverlay is visible or not.
        /// </summary>
        public bool Active{ get; set; }

        /// <summary>
        /// Defines when and what tips are going to be displayed.
        /// </summary>
        public List<HelpOverlayFlowDocument> Flows { get; set; }
    }
}
