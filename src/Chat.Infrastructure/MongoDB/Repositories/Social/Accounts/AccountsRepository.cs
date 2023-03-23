using AutoMapper;
using Design.IS7.Domain.Entities.Social.Accounts;
using Design.IS7.Domain.RepositoryInterfaces.Social;
using Design.IS7.Domain.RepositoryInterfaces.Social.Accounts;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection;

namespace Design.IS7.Infrastructure.MongoDB.Repositories.Social.Accounts
{
    public class AccountsRepository :
        SocialRepository<Account, AccountDocument>, IAccountsRepository
    {
        public AccountsRepository(
            IMapper mapper,
            ISocialRepositoryConnection socialRepositoryConnection)
                : base(mapper, socialRepositoryConnection, "Account") { }
    }
}