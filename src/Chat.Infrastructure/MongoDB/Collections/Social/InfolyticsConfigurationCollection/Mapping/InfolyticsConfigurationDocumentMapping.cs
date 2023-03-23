using Design.IS7.Domain.Entities.Base;
using Design.IS7.Domain.Entities.Social.InfolyticsConfigurations;
using Design.IS7.Infrastructure.Mappers;

namespace Design.IS7.Infrastructure.MongoDB.Collections.Social.InfolyticsConfigurationCollection
{
    /// <summary>
    /// This class extends some implicit operators, 
    /// to help convertions between
    /// InfolyticsConfigurationDocument and InfolyticsConfigurationDocument.
    /// </summary>
    public partial class InfolyticsConfigurationDocument
    {
        /// <summary>
        /// Convert a InfolyticsConfigurationDocument to InfolyticsConfiguration.
        /// </summary>
        /// <param name="document">A InfolyticsConfigurationDocument instance.</param>
        public static implicit operator InfolyticsConfiguration(
            InfolyticsConfigurationDocument document
        )
        {
            if (document == null)
                return MappingHelper.GetDefaultValue<InfolyticsConfiguration>();

            var product = InfolyticsConfigurationProduct.CreateNew(
                document.ProductId,
                document.ProductName,
                document.ProductDomain
            );

            var azureFunction = InfolyticsConfigurationAzureFunction.CreateNew(
                document.AzureFunctionMetadataVersion,
                document.AzureFunctionDataVersion
            );

            return InfolyticsConfiguration.CreateExisting(
                document.Id,
                document.TagId,
                document.Environment.GetAsEnvironmentType(),
                product,
                azureFunction
            );
        }
        /// <summary>
        /// Convert a InfolyticsConfiguration to InfolyticsConfigurationDocument.
        /// </summary>
        /// <param name="model">A InfolyticsConfigurationDocument instance.</param>
        public static implicit operator InfolyticsConfigurationDocument(
            InfolyticsConfiguration model
        )
        {
            if (model == null)
            {
                return MappingHelper.GetDefaultValue<InfolyticsConfigurationDocument>();
            }

            return new InfolyticsConfigurationDocument()
            {
                Id = model.Id,
                ProductId =
                    model.Product != null ?
                        model.Product.Id : string.Empty,
                ProductName =
                    model.Product != null ?
                        model.Product.Name : string.Empty,
                ProductDomain =
                    model.Product != null ?
                        model.Product.Domain : string.Empty,
                TagId = model.Id,
                AzureFunctionMetadataVersion =
                    model.AzureFunction != null ?
                        model.AzureFunction.MetadataVersion : string.Empty,
                AzureFunctionDataVersion =
                    model.AzureFunction != null ?
                        model.AzureFunction.DataVersion : string.Empty,
                Environment = model.Environment.GetAsString()
            };
        }
    }
}