using Design.IS7.Domain.Entities.Social.Users;
using Design.IS7.Infrastructure.Mappers;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection.Profile;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.UserCollection
{
    public partial class UserAccountDocument
    {
        public static implicit operator UserAccount(UserAccountDocument document)
        {
            if (document == null)
                return MappingHelper.GetDefaultValue<UserAccount>();

            return new UserAccount
            {
                Active = document.Active,
                AccountId = document.AccountId,
                RuleSetId = document.RuleSetId,
                //Profile = (Profile)document.Profile
            };
        }

        public static implicit operator UserAccountDocument(UserAccount model)
        {
            if (model == null)
                return MappingHelper.GetDefaultValue<UserAccount>();

            return new UserAccountDocument
            {
                Active = model.Active,
                AccountId = model.AccountId,
                RuleSetId = model.RuleSetId,
                //Profile = (ProfileDocument)model.Profile
            };
        }
    }
}
