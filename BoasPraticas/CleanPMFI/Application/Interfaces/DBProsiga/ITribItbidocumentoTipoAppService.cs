using Application.Interfaces.Base;
using Domain.Entities.DBProsiga;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.DBProsiga
{
    public interface ITribItbidocumentoTipoAppService : IAppServiceBase<TribItbidocumentoTipo>
    {
        public IQueryable<TribItbidocumentoTipo> GetQueryableDocumentosExigidos(string praquem);

        public Task<List<TribItbidocumentoTipo>> GetDocumentosExigidos(string praquem);
        
    }
}
