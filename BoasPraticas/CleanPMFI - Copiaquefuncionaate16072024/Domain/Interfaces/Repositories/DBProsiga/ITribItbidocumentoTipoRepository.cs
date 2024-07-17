using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Repositories.DBProsiga
{
    public interface ITribItbidocumentoTipoRepository : IRepositoryBase<TribItbidocumentoTipo>
    {
        public IQueryable<TribItbidocumentoTipo> GetQueryableDocumentosExigidos(string praquem);
        public Task<List<TribItbidocumentoTipo>> GetDocumentosExigidos(string praquem);
    }
}
