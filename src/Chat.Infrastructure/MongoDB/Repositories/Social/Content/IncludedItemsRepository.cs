using AutoMapper;
using Design.IS7.Domain.Entities.Social.Content;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.Content;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.IncludeItemCollection;


namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.Content
{
    /// <summary>
    /// The included items repository class
    /// </summary>
    public class IncludedItemsRepository :
        SocialRepository<IncludedItem, IncludedItemDocument>, IIncludedItemsRepository
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mapper">The Mapper instance to use.</param>
        /// <param name="socialRepositoryConnection">The connection instance.</param>
        public IncludedItemsRepository(IMapper mapper, ISocialRepositoryConnection socialRepositoryConnection) 
            : base(mapper, socialRepositoryConnection, "IncludedItems") { 
        }
    }
}
