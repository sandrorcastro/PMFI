using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories.DBProsiga
{
    public interface IAutoNumAnoNumeroRepository : IRepositoryBase<AutoNumAnoNumero>
    {
        public Task<AutoNumAnoNumero> GetMaxAutoNumAnoNumero(short AutoAno, string AutoTipo);
    }
}
