using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ImovelService : ServiceBase<Imovel>, IImovelService
    {
        private readonly IImovelRepository _Repository;

        public ImovelService(IImovelRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
