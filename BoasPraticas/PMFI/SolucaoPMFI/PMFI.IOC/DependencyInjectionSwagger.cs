

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using PMFI.Application.Interfaces;
using PMFI.Application.Interfaces.Base;
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
    public static class DependencyInjectionSwagger
    {
     
        
        public static IServiceCollection AddInfrastructureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey,
                    BearerFormat = "JWT",
                    In = ParameterLocation.Header,
                    Description = "Uma descrição qualquer no addinfrastructureswagger"
                });
                
                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {   
                    {   
                          new OpenApiSecurityScheme()
                          {
                              Reference = new OpenApiReference()
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id="Bearer"

                              }
                          },
                          new string[]
                          {

                          }
                    }
                });

            });


           
            return services;
        }
    }
}
