using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.HelpOverlayCollection
{
    /// <summary>
    /// The exact match of HelpOverlayTipLocalization document on the database.
    /// </summary>
    [BsonIgnoreExtraElements]
    public class HelpOverlayTipLocalizationDocument : MongoDocument
    {
        /// <summary>
        /// The language that the texts were translated for.
        /// </summary>
        public string Language { get; set; }
        /// <summary>
        /// The tip title translated for the informed culture.
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// The tip Content translated for the informed culture.
        /// </summary>
        public string Content { get; set; }
    }
}