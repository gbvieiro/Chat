using Microsoft.Extensions.DependencyInjection;

namespace Chat.Application.Mappers
{
    /// <summary>
    /// This class provides a method for configure models mappers.
    /// </summary>
    public static class AppMapper
    {
        /// <summary>
        /// This method configures maps for entities and DTOs.
        /// </summary>
        /// <param name="services">
        /// Current service collection.
        /// </param>
        public static void Configure(this IServiceCollection services)
        {
            services.AddAutoMapper(
                typeof(EntityToDtoProfile),
                typeof(DtoToEntityProfile));
        }
    }
}