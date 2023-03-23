
using AutoMapper;
using Design.IS7.Domain.Entities.Social.HelpOverlays;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.HelpOverlays;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.HelpOverlayCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.HelpOverlays
{
    public class HelpOverlaysRepository :
        SocialRepository<HelpOverlay, HelpOverlayDocument>, IHelpOverlaysRepository
    {
        public HelpOverlaysRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection)
                : base(mapper, socialRepositoryConnection, "HelpOverlay") { }
    }
}
