using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection
{
    [BsonIgnoreExtraElements]
    public class ThumbNamesDocument
    {
        public string Large { get; set; }
        public string LargeWithWatermark { get; set; }
        public string MediumRetina { get; set; }
        public string Medium { get; set; }
        public string Small { get; set; }
    }
}