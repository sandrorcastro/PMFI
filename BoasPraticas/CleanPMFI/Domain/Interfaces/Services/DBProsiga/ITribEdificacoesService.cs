using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.DBProsiga
{
    public interface ITribEdificacoesService : IServiceBase<TribEdificaco>
    {
        public Task<TribEdificaco> GetByInscricaoImobiliaria(string? inscricao);
    }
}
