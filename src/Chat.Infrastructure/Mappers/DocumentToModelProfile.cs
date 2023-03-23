using Design.IS7.Domain.Entities.Social.Accounts;
using Design.IS7.Domain.Entities.Social.Accounts.Profiles;
using Design.IS7.Domain.Entities.Social.Accounts.PublishOptions;
using Design.IS7.Domain.Entities.Social.Content;
using Design.IS7.Domain.Entities.Social.HelpOverlays;
using Design.IS7.Domain.Entities.Social.Projects;
using Design.IS7.Domain.Entities.Social.Projects.Modules;
using Design.IS7.Domain.Entities.Social.Projects.Renders;
using Design.IS7.Domain.Entities.Social.Users;
using Design.IS7.Domain.Social.Entities.Examples;
using Design.IS7.Domain.Social.Entities.ReferenceLongDescriptions;
using Design.IS7.Domain.ValueObjects.Projects;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection.Profile;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.AccountCollection.PublishOptions;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.EnvironmentMapCollection;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ExampleCollection;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.HelpOverlayCollection;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.IncludeItemCollection;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectCollection.Module;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ProjectPhotoRenderCollection;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.ReferenceLongDescriptionsCollection;
using Design.IS7.Infrastructure.MongoDB.Collections.Social.UserCollection;

namespace Design.IS7.Infrastructure.Mappers
{
    public class DocumentToModelProfile : AutoMapper.Profile
    {
        public DocumentToModelProfile()
        {
            CreateMap<AccessTokenDocument, AccessToken>().ConstructUsing(x => x);
            CreateMap<AccountDocument, Account>();
            CreateMap<AddressDocument, Address>();
            CreateMap<BrandsSellerDocument, BrandsSeller>();
            CreateMap<BudgetProfileItemDocument, BudgetProfileItem>();
            CreateMap<CatalogPublishOptionsDocument, CatalogPublishOptionsDocument>();
            CreateMap<DefaultRelationDocument, DefaultRelation>();
            CreateMap<DesignItemFeaturesDocument, DesignItemFeatures>();
            CreateMap<EnvironmentMapDocument, EnvironmentMap>();
            CreateMap<ExampleDocument, Example>();
            CreateMap<HelpOverlayDocument, HelpOverlay>();
            CreateMap<HelpOverlayFlowDocument, HelpOverlayFlow>();
            CreateMap<HelpOverlayTipDocument, HelpOverlayTip>();
            CreateMap<HelpOverlayTipLocalizationDocument, HelpOverlayTipLocalization>();
            CreateMap<IncludedItemDocument, IncludedItem>();
            CreateMap<MCMStoreInfoDocument, MCMStoreInfo>();
            CreateMap<PartnershipAccessValidityDocument, PartnershipAccessValidity>();
            CreateMap<ProfileDocument, Profile>();
            CreateMap<ProjectDocument, Project>();
            CreateMap<ProjectModuleDocument, ProjectModule>();
            CreateMap<ProjectOpenedDocument, ProjectOpened>();
            CreateMap<ProjectPhotoRenderDocument, ProjectPhotoRender>();
            CreateMap<ReferenceItemDocument, ReferenceItem>();
            CreateMap<RepresentativeInfoDocument, RepresentativeInfo>();
            CreateMap<SubscriptionDocument, Subscription>();
            CreateMap<ThumbNamesDocument, ThumbNames>();
            CreateMap<UserAccountDocument, UserAccount>().ConstructUsing(x => x);
            CreateMap<UserDocument, User>().ConstructUsing(x => x);
            CreateMap<VectorThreeDocument, VectorThree>();
            CreateMap<WatermarkDocument, Watermark>();
            CreateMap<ReferenceLongDescriptionDocument, ReferenceLongDescription>().ConstructUsing(x =>
                ReferenceLongDescription.CreateExisting(
                    x.Id,
                    x.Reference,
                    x.Description,
                    x.Brand,
                    x.ModifiedDate
                )
            );
        }
    }
}