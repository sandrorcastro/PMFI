using Application.Interfaces.Base;
using Domain.Entities.DBProsiga;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.DBProsiga
{
    public interface IAutoNumEntidadesAppService : IAppServiceBase<AutoNumEntidade>
    {
       // public Task<AutoNumEntidade> GetMaxAutoNumEntidade(string AutoNumEntidade);
        public Task<long> GetMaxAutoNumEntidade(string AutoNumEntidade);
    }
}
