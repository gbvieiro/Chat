using AutoMapper;
using Design.IS7.Domain.RepositoryInterfaces.Examples;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.Social.Entities.Examples;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ExampleCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.Examples
{
    public class ExamplesRepository :
        SocialRepository<Example, ExampleDocument>, IExamplesRepository
    {
        public ExamplesRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection)
                : base(mapper, socialRepositoryConnection, "Examples") { }
    }
}