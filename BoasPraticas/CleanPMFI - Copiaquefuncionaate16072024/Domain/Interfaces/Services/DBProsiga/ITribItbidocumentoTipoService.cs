using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.DBProsiga
{
    public interface ITribItbidocumentoTipoService : IServiceBase<TribItbidocumentoTipo>
    {
        public IQueryable<TribItbidocumentoTipo> GetQueryableDocumentosExigidos(string praquem);
        public Task<List<TribItbidocumentoTipo>> GetDocumentosExigidos(string praquem);
    }
}
