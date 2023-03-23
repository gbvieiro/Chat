using Design.IS7.Domain.Entities.Social.Users;
using Design.IS7.Infrastructure.Mappers;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.UserCollection
{
    public partial class AccessTokenDocument
    {
        public static implicit operator AccessToken(AccessTokenDocument document)
        {
            if (document == null)
                return MappingHelper.GetDefaultValue<AccessToken>();

            return new AccessToken
            {
                Expiration = document.Expiration,
                Value = document.Value
            };
        }

        public static implicit operator AccessTokenDocument(AccessToken model)
        {
            if (model == null)
                return MappingHelper.GetDefaultValue<AccessTokenDocument>();

            return new AccessTokenDocument
            {
                Expiration = model.Expiration,
                Value = model.Value
            };
        }
    }
}