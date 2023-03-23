using AutoMapper;
using Design.IS7.Domain.Entities.Social.Users;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.Users;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.UserCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.Users
{
    public class UsersRepository :
        SocialRepository<User, UserDocument>, IUsersRepository
    {
        public UsersRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection)
            : base(mapper, socialRepositoryConnection, "User") { }
    }
}