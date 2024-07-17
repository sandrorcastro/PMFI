using Application.Interfaces.Base;
using Domain.Entities;
using Domain.Entities.MegaData;
using Domain.Entities.NFSEDB;
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
    public interface IMegaData_Export_AppService : IAppServiceBase<NfseTblNfse>
    {
       
    }
}
