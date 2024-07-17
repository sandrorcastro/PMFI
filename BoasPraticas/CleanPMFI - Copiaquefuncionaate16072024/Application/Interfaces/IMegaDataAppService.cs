using Application.Interfaces.Base;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
using Domain.Filters;
using Domain.Interfaces.Specifications;
using Domain.Pagination;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IMegaDataAppService : IAppServiceBase<MegaData_NFSE>
    {
        public string ValidarPeriodo(MegaData_NFSE entity);
        public bool ExportarPeriodo(IWebHostEnvironment environment ,NFSEDBContext _NFSEDBContext, MegaData_NFSE entity);
        //public bool ExportarPeriodo(IWebHostEnvironment environment, NFSEDBContext _NFSEDBContext, MegaData_Contribuinte entity);
        public bool EnviarPeriodo(MegaData_NFSE entity);

    }
}
