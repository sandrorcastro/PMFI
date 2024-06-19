using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribItbidocumentoTipoService : ServiceBase<TribItbidocumentoTipo>, ITribItbidocumentoTipoService
    {
        private readonly ITribItbidocumentoTipoRepository _Repository;

        public TribItbidocumentoTipoService(ITribItbidocumentoTipoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }
      /*  public TribItbidocumentoTipoService(IRepositoryBase<TribItbidocumentoTipo> _repository) : base(_repository)
        {
        }*/
    }
}
