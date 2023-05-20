using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ProcessoService : ServiceBase<Processo>, IProcessoService
    {
        private readonly IProcessoRepository _Repository;

        public ProcessoService(IProcessoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
