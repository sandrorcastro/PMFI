using Application.Interfaces.Base;
using Domain.Entities.DBProsiga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.DBProsiga
{
    public interface ITribBoletoAppService : IAppServiceBase<TribBoleto>
    {
        //public Task<long> GeraNossoNumero(int ConvenioId);
        //public Task<ConvenioBanco> GeraNossoNumero(TribBoleto TribBoleto);
    }
}
