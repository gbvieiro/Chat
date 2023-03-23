using Microsoft.Extensions.DependencyInjection;

namespace Design.IS7.Infrastructure.Mappers
{
    public static class EntityMapper
    {
        public static void Configure(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(
                typeof(DocumentToModelProfile),
                typeof(ModelToDocumentProfile));
        }
    }
}