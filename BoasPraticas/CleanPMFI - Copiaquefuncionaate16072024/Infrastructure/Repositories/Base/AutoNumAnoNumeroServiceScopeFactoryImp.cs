using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Base
{
    public class AutoNumAnoNumeroServiceScopeFactoryImp : IServiceScopeFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public AutoNumAnoNumeroServiceScopeFactoryImp(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public IServiceScope CreateScope()
        {
            //return new ServiceScope(_serviceProvider);
            throw new NotImplementedException();
        }
    }
}
