using Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection.Module;
using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection
{
    [BsonIgnoreExtraElements]
    public class ProjectDocument : MongoDocument
    {
        public float Version { get; set; }
        public string Url { get; set; }
        public string Ip { get; set; }
        public string Region { get; set; }
        public int Area { get; set; }
        public List<string> TagsIds { get; set; }
        public string OriginalProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AccountId { get; set; }
        public string UserId { get; set; }
        public List<string> ModifiedByUser { get; set; }
        public string ContentName { get; set; }
        public ThumbNamesDocument ThumbNames { get; set; }
        public DateTime Date { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted { get; set; }
        public List<ProjectModuleDocument> Modules { get; set; }
        public string Partnership { get; set; }
        public int Likes { get; set; }
        public int Views { get; set; }
        public bool Private { get; set; }
        public bool OnlyBudget { get; set; }
        public bool IsBudgetProject { get; set; }
        public Dictionary<string, int> Brands { get; set; }
        public string[] BrandList { get; set; }
        public bool Draft { get; set; }
        public string DraftFrom { get; set; }
        public string ContributorId { get; set; }
        public HashSet<string> CollectionTagsIds { get; set; }
        public int ThumbStatus { get; set; }
        public bool CanEditByOtherAccount { get; set; }
        public bool CreateByReferral { get; set; }
        public bool AutoDesign { get; set; }
        public Dictionary<string, int> RoomTypes { get; set; }
        public List<string> ElevationImagesUrl { get; set; }
        public string FloorPlanImageUrl { get; set; }
    }
}