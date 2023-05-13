using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class EstadoService : ServiceBase<Estado>, IEstadoService
    {
        private readonly IEstadoRepository _Repository;

        public EstadoService(IEstadoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

        public Estado BuscarPorDescricao(string estado)
        {
            return _Repository.BuscarPorDescricao(estado);
        }
        public Estado BuscarPorSigla(string sigla)
        {
            return _Repository.BuscarPorSigla(sigla);
        }


    }
}
