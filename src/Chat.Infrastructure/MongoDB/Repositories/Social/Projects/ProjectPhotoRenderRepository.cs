using AutoMapper;
using Design.IS7.Domain.Entities.Social.Projects.Renders;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.Projects;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectPhotoRenderCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.Projects
{
    public class ProjectPhotoRenderRepository :
        SocialRepository<ProjectPhotoRender, ProjectPhotoRenderDocument>,
        IProjectPhotoRenderRepository
    {
        public ProjectPhotoRenderRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection)
                : base(mapper, socialRepositoryConnection, "ProjectPhotoRender") { }
    }
}