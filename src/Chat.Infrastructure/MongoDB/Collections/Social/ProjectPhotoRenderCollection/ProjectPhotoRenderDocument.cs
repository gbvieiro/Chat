using MongoDB.Bson.Serialization.Attributes;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectPhotoRenderCollection
{
    [BsonIgnoreExtraElements]
    public class ProjectPhotoRenderDocument : MongoDocument
    {
        public string AccountId { get; set; }
        public string ProjectId { get; set; }
        public string ImageURL { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public int QueuePosition { get; set; }
        public float ProcessProgress { get; set; }
        public float SecondsRemains { get; set; }
        public bool IsPreview { get; set; }
        public bool Deleted { get; set; }
        public string Partnership { get; set; }
        public double SecondsPerPixel { get; set; }
        public int Credits { get; set; }
        public string RatioId { get; set; }
        public string PreviewId { get; set; }
        public string ImageThumb { get; set; }
        public string ProjectUrl { get; set; }
        public int RenderType { get; set; }

        public ProjectPhotoRenderDocument(
            string id,
            string accountId,
            string projectId,
            string imageURL,
            string message,
            DateTime date,
            string status,
            int queuePosition,
            float processProgress,
            float secondsRemains,
            bool isPreview,
            bool deleted,
            string partnership,
            double secondsPerPixel,
            int credits,
            string ratioId,
            string previewId,
            string imageThumb,
            string projectUrl,
            int renderType
        )
        {
            Id = id;
            AccountId = accountId;
            ProjectId = projectId;
            ImageURL = imageURL;
            Message = message;
            Date = date;
            Status = status;
            QueuePosition = queuePosition;
            ProcessProgress = processProgress;
            SecondsRemains = secondsRemains;
            IsPreview = isPreview;
            Deleted = deleted;
            Partnership = partnership;
            SecondsPerPixel = secondsPerPixel;
            Credits = credits;
            RatioId = ratioId;
            PreviewId = previewId;
            ImageThumb = imageThumb;
            ProjectUrl = projectUrl;
            RenderType = renderType;
        }
    }
}