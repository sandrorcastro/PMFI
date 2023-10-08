using Application.Interfaces.Base;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Interfaces.Specifications;
using Microsoft.AspNetCore.Routing.Template;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMegaData_NFSE_AppService : IAppServiceBase<MegaData_NFSE>
    {
       // Task<TResult?> ProjectToFirstOrDefaultAsync<TResult>(ISpecification<T> specification, CancellationToken cancellationToken);
       //Task Exportar(DateTime DataInicial, DateTime DataFinal);
    }
}
