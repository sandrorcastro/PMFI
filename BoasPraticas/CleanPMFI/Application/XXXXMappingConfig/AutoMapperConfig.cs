using Application.Mappings;
using Microsoft.Extensions.DependencyInjection;


namespace Aplication.MappingConfig
{
    public static class AutoMapperConfig
    {
        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile),typeof(ViewModelToDomainMappingProfile));
        }
    }
}
