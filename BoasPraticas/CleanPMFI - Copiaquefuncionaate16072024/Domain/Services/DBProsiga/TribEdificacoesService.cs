using Domain.Entities.DBProsiga;
using Domain.Interfaces.Base;
using Domain.Interfaces.Repositories.DBProsiga;
using Domain.Interfaces.Services.DBProsiga;
using Domain.Services.Base;

namespace Domain.Services.DBProsiga
{
    public class TribEdificacoesService : ServiceBase<TribEdificaco>, ITribEdificacoesService
    {
        private readonly ITribEdificacoesRepository _Repository;
        public TribEdificacoesService(ITribEdificacoesRepository repository) : base(repository)
        {
            _Repository = repository;
        }

        public Task<TribEdificaco> GetByInscricaoImobiliaria(string? inscricao)
        {
            return _Repository.GetByInscricaoImobiliaria(inscricao);
        }
    }
}
