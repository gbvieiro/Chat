using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.HelpOverlayCollection
{
    /// <summary>
    /// The exact match of HelpOverlayTip document on the database.
    /// It is used inside the HelpOverlayFlow document.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class HelpOverlayTipDocument : MongoDocument
    {
        /// <summary>
        /// Contains all translations for the text fields.
        /// </summary>
        public List<HelpOverlayTipLocalizationDocument> Localizations { get; set; }
        /// <summary>
        /// An optional image link.
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// Defines whether the HelpOverlayTip is visible or not.
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// The ordination that each one of the tips will follow.
        /// </summary>
        public int Order { get; set; }
        /// <summary>
        /// Is the React Component that the tip will be related to.
        /// </summary>
        public string RelatedComponent { get; set; }
    }
}