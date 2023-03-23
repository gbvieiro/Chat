using AutoMapper;
using Design.IS7.Domain.Entities.Social.InfolyticsConfigurations;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.InfolyticsConfigurations;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.InfolyticsConfigurationCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.InfolyticsConfigurationCollections
{
    /// <summary>
    /// This class provides a repository for the entity InfolyticsConfiguration.
    /// </summary>
    public class InfolyticsConfigurationsRepository :
        SocialRepository<InfolyticsConfiguration, InfolyticsConfigurationDocument>,
        IInfolyticsConfigurationsRepository
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="mapper">The mapper service.</param>
        /// <param name="socialRepositoryConnection">
        /// The social repository parameters for creating a connection.
        /// </param>
        public InfolyticsConfigurationsRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection)
                : base(mapper, socialRepositoryConnection, "InfolyticsConfigurations") { }
    }
}