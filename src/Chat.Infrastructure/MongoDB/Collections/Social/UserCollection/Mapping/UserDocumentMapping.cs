using Design.IS7.Domain.Entities.Social.Users;
using Design.IS7.Infrastructure.Mappers;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.UserCollection
{
    public partial class UserDocument
    {
        public static implicit operator User(UserDocument document)
        {
            if (document == null)
                return MappingHelper.GetDefaultValue<User>();
            else
                return User.CreateExisting(
                    document.Id,
                    document.CanAccessIS7,
                    document.LoginId,
                    document.Accounts.Select(x => (UserAccount)x).ToList(),
                    GetUserMoobleData(document),
                    GetUserFacebook(document),
                    GetUserGoogle(document),
                    GetUserPromob(document),
                    document.Date,
                    GetUserLeroy(document),
                    document.ExternalId,
                    document.Partnership,
                    document.DenyPasswordChange,
                    document.AccessToken
                );
        }

        public static implicit operator UserDocument(User entity)
        {
            if (entity == null)
                return MappingHelper.GetDefaultValue<UserDocument>();

            var result = new UserDocument
            {
                Id = entity.Id.ToString(),
                CanAccessIS7 = entity.CanAccessIS7,
                Accounts = entity.Accounts.Select(x => (UserAccountDocument)x).ToList(),
                Date = entity.Date,
                PasswordChangeDate = entity.Mooble?.PasswordChangeDate,
                Partnership = entity.Partnership,
                ExternalId = entity.ExternalId,
                AccessToken = entity.AccessToken,
            };

            if (entity.LoginId != null)
            {
                result.LoginId = entity.LoginId.ToString();
            }

            if (entity.Mooble != null)
            {
                result.Email = entity.Mooble.Email;
                result.Password = entity.Mooble.Password;
                result.ResetPasswordToken = entity.Mooble.ResetPasswordToken;
                result.ActiveToken = entity.Mooble.ActiveToken;
                result.Active = entity.Mooble.Active;
                result.IsMoobleAdmin = entity.Mooble.IsMoobleAdmin;
                result.IdentificationHash = entity.Mooble.IdentificationHash;
                result.DenyPasswordChange = entity.DenyPasswordChange;
            }

            if (entity.Facebook != null)
            {
                result.FacebookId = entity.Facebook.FacebookId;
            }

            if (entity.Google != null)
            {
                result.GoogleId = entity.Google.GoogleId;
            }

            if (entity.Promob != null)
            {
                result.PromobId = entity.Promob.PromobId;
            }

            if (entity.Leroy != null)
            {
                result.LdapSection =
                    entity.Leroy.LdapSection.Select(x => (int)x).ToList();
            }

            return result;
        }

        private static UserMooble GetUserMoobleData(UserDocument document)
        {
            if (string.IsNullOrWhiteSpace(document.Email))
                return MappingHelper.GetDefaultValue<UserMooble>();
            else
                return new UserMooble
                {
                    Email = document.Email,
                    Password = document.Password,
                    ResetPasswordToken = document.ResetPasswordToken,
                    ActiveToken = document.ActiveToken,
                    DenyPasswordChange = document.DenyPasswordChange,
                    Active = document.Active,
                    IsMoobleAdmin = document.IsMoobleAdmin,
                    PasswordChangeDate = document.PasswordChangeDate,
                    IdentificationHash = document.IdentificationHash
                };
        }

        private static UserFacebook GetUserFacebook(UserDocument document)
        {
            if (string.IsNullOrWhiteSpace(document.FacebookId))
                return MappingHelper.GetDefaultValue<UserFacebook>();
            else
                return new UserFacebook
                {
                    FacebookId = document.FacebookId
                };
        }

        private static UserGoogle GetUserGoogle(UserDocument document)
        {
            if (string.IsNullOrWhiteSpace(document.GoogleId))
                return MappingHelper.GetDefaultValue<UserGoogle>();
            else
                return new UserGoogle
                {
                    GoogleId = document.GoogleId
                };
        }

        private static UserPromob GetUserPromob(UserDocument document)
        {
            if (string.IsNullOrWhiteSpace(document.PromobId))
                return MappingHelper.GetDefaultValue<UserPromob>();
            else
                return new UserPromob
                {
                    PromobId = document.PromobId
                };
        }

        private static UserLeroy GetUserLeroy(UserDocument document)
        {
            if (document.LdapSection == null || !document.LdapSection.Any())
                return MappingHelper.GetDefaultValue<UserLeroy>();
            else
                return new UserLeroy
                {
                    LdapSection = document.LdapSection.Select(x => (LdapSection)x).ToList()
                };
        }
    }
}