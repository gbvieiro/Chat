using AutoMapper;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.ReferenceLongDescriptions;
using Design.IS7.Domain.Social.Entities.ReferenceLongDescriptions;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ReferenceLongDescriptionsCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.ReferenceLongDescriptions
{
    public class ReferenceLongDescriptionsRepository :
        SocialRepository<ReferenceLongDescription, ReferenceLongDescriptionDocument>,
        IReferenceLongDescriptionsRepository
    {
        public ReferenceLongDescriptionsRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection
        ) : base(mapper, socialRepositoryConnection, "ReferenceLongDescriptions") { }
    }
}