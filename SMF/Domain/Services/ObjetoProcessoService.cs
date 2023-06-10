using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ObjetoProcessoService : ServiceBase<ObjetoProcesso>, IObjetoProcessoService
    {
        private readonly IObjetoProcessoRepository _Repository;

        public ObjetoProcessoService(IObjetoProcessoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
