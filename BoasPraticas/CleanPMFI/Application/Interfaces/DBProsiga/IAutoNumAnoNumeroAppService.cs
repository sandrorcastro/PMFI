using Application.Interfaces.Base;
using Domain.Entities.DBProsiga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.DBProsiga
{
    public interface IAutoNumAnoNumeroAppService : IAppServiceBase<AutoNumAnoNumero>
    {
        public Task<AutoNumAnoNumero> GetMaxAutoNumAnoNumero(short AutoAno,string AutoTipo);

    }
}
