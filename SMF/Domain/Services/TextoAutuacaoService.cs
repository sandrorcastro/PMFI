using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class TextoAutuacaoService : ServiceBase<TextoAutuacao>, ITextoAutuacaoService
    {
        private readonly ITextoAutuacaoRepository _Repository;

        public TextoAutuacaoService(ITextoAutuacaoRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
