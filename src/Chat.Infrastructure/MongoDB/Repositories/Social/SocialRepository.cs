using AutoMapper;
using Design.IS7.Domain.Entities;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Infrastructure.MongoDB.Collections;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social
{
    public abstract class SocialRepository<EntityType, DocumentType> :
        MongoRepository<EntityType, DocumentType>
            where EntityType : Entity
            where DocumentType: MongoDocument
    {
        public SocialRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection,
            string collectionName)
                : base(mapper, socialRepositoryConnection, collectionName) { }
    }
}