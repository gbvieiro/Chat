using Chat.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Chat.API.IOC
{
    /// <summary>
    /// This extension provides the IOC services creation.
    /// </summary>
    public static class IServiceCollectionExtensions
    {
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