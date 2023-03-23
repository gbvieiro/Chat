using Chat.Application.Services;
using Chat.Domain.Specifications;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.API.IOC
{
    /// <summary>
    /// This extension provides the IOC services creation.
    /// </summary>
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Creates domain services.
        /// </summary>
        /// <param name="services">
        /// Current Service Collection.
        /// </param>
        /// <returns>
        /// urrent Service Collection with all services added.
        /// </returns>
        public static IServiceCollection AddDomainServices(
            this IServiceCollection services
        )
        {
            services.AddScoped<IMessageValidator, MessageValidator>();

            return services;
        }

        /// <summary>
        /// Creates application services.
        /// </summary>
        /// <param name="services">
        /// Current Service Collection.
        /// </param>
        /// <returns>
        /// urrent Service Collection with all services added.
        /// </returns>
        public static IServiceCollection AddAppServices(
            this IServiceCollection services
        )
        {
            services.AddScoped<IChatAppService, ChatAppService>();

            return services;
        }
    }
}