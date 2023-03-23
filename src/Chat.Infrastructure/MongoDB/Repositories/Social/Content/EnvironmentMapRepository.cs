using AutoMapper;
using Design.IS7.Domain.Entities.Social.Content;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.Content;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.EnvironmentMapCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.Content
{
    /// <summary>
    /// The repository to interface with <see cref="EnvironmentMap"/> entries from the collection.
    /// </summary>
    public class EnvironmentMapRepository :
        SocialRepository<EnvironmentMap, EnvironmentMapDocument>,
        IEnvironmentMapRepository
    {
        public EnvironmentMapRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection)
                : base(mapper, socialRepositoryConnection, "EnvironmentMap") { }
    }
}
