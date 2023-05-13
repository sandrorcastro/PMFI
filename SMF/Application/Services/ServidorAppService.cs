using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces.Services;

namespace Application.Services
{
    public class ServidorAppService : AppServiceBase<Servidor>, IServidorAppService
    {
        private readonly IServidorService service;

        public ServidorAppService(IServidorService _service)
            : base(_service)
        {
            service = _service;
        }

       
    }
}
