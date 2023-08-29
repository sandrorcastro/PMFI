using Microsoft.Extensions.DependencyInjection;
using MVC.Mappings;

namespace MVC.MappingConfig
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
