using Application.Interfaces.Base;
using Domain.Entities.DBProsiga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.DBProsiga
{
    public interface ISisParametrosAppService : IAppServiceBase<SisParametro>
    {
        //public Task<long> GeraNossoNumero(int ConvenioId);
        //public Task<ConvenioBanco> GeraNossoNumero(TribObjeto TribObjeto);
    }
}
