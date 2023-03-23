using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.EnvironmentMapCollection
{
    [BsonIgnoreExtraElements]
    public class EnvironmentMapDocument : MongoDocument
    {
        public short Intensity { get; set; }
        public short TimesUsed { get; set; }
        public string Name { get; set; }
        public string Thumb { get; set; }
        public string Type { get; set; }

        public EnvironmentMapDocument(
            string id,
            short intensity,
            short timesUsed,
            string name,
            string thumb,
            string type
        )
        {
            Id = id;
            Intensity = intensity;
            Name = name;
            Thumb = thumb;
            TimesUsed = timesUsed;
            Type = type;
        }
    }
}
