using AutoMapper;
using Design.IS7.Domain.Entities.Social.Projects;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.Projects;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.Projects
{
    public class ProjectsRepository :
        SocialRepository<Project, ProjectDocument>, IProjectsRepository
    {
        public ProjectsRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection)
                : base(mapper, socialRepositoryConnection, "Project") { }
    }
}