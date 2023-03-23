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
    public class ModelToDocumentProfile : AutoMapper.Profile
    {
        public ModelToDocumentProfile()
        {
            CreateMap<AccessToken, AccessTokenDocument>().ConstructUsing(x => x);
            CreateMap<Account, AccountDocument>();
            CreateMap<Address, AddressDocument>();
            CreateMap<BrandsSeller, BrandsSellerDocument>();
            CreateMap<BudgetProfileItem, BudgetProfileItemDocument>();
            CreateMap<CatalogPublishOptions, CatalogPublishOptionsDocument>();
            CreateMap<DefaultRelation, DefaultRelationDocument>();
            CreateMap<DesignItemFeatures, DesignItemFeaturesDocument>();
            CreateMap<EnvironmentMap, EnvironmentMapDocument>();
            CreateMap<Example, ExampleDocument>();
            CreateMap<HelpOverlay, HelpOverlayDocument>();
            CreateMap<HelpOverlayFlow, HelpOverlayFlowDocument>();
            CreateMap<HelpOverlayTip, HelpOverlayTipDocument>();
            CreateMap<HelpOverlayTipLocalization, HelpOverlayTipLocalizationDocument>();
            CreateMap<IncludedItem, IncludedItemDocument>();
            CreateMap<MCMStoreInfo, MCMStoreInfoDocument>();
            CreateMap<PartnershipAccessValidity, PartnershipAccessValidityDocument>();
            CreateMap<Profile, ProfileDocument>();
            CreateMap<Project, ProjectDocument>();
            CreateMap<ProjectModule, ProjectModuleDocument>();
            CreateMap<ProjectOpened, ProjectOpenedDocument>();
            CreateMap<ProjectPhotoRender, ProjectPhotoRenderDocument>();
            CreateMap<ReferenceItem, ReferenceItemDocument>();
            CreateMap<RepresentativeInfo, RepresentativeInfoDocument>();
            CreateMap<Subscription, SubscriptionDocument>();
            CreateMap<ThumbNames, ThumbNamesDocument>();
            CreateMap<User, UserDocument>().ConstructUsing(x => x);
            CreateMap<UserAccount, UserAccountDocument>().ConstructUsing(x => x);
            CreateMap<VectorThree, VectorThreeDocument>();
            CreateMap<Watermark, WatermarkDocument>();
            CreateMap<ReferenceLongDescription, ReferenceLongDescriptionDocument>();
        }
    }
}