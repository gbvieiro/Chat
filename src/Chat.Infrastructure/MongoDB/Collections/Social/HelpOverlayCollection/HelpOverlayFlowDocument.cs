using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.HelpOverlayCollection
{
    /// <summary>
    /// The exact match of HelpOverlayFlow document on the database. It is used inside the HelpOverlay document.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class HelpOverlayFlowDocument : MongoDocument
    {
        /// <summary>
        /// Is the UI event that will trigger the flow.
        /// </summary>
        public string TriggerEvent { get; set; }

        /// <summary>
        /// Defines whether the HelpOverlayFlow is visible or not.
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// All the tips that are going to be shown in the flow.
        /// </summary>
        public List<HelpOverlayTipDocument> Tips { get; set; }
    }
}
