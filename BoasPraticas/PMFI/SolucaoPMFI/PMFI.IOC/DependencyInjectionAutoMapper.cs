

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PMFI.Application.Interfaces;
using PMFI.Application.Interfaces.Base;
using PMFI.Application.Mappings;
using PMFI.Application.Services;
using PMFI.Application.Services.Base;
using PMFI.Domain.Interfaces.Base;
using PMFI.Domain.Interfaces.Repositories;
using PMFI.Domain.Interfaces.Services;
using PMFI.Domain.Services;
using PMFI.Domain.Services.Base;
using PMFI.Infra.Context;
using PMFI.Infra.Repositories;
using PMFI.Infra.Repositories.Base;
using PMIFI.Domain.Interfaces.Base;
using System.Data.Common;

namespace PMFI.IOC
{
    public static class DependencyInjectionAutoMapper
    {
        public static void AddAutoMapperConfig(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(typeof(DomainToViewModelMappingProfile),
                typeof(ViewModelToDomainMappingProfile));
        }
    }
}
