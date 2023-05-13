using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;

namespace Domain.Services
{
    public class ServidorService : ServiceBase<Servidor>, IServidorService
    {
        private readonly IServidorRepository _Repository;

        public ServidorService(IServidorRepository Repository)
            : base(Repository)
        {
            _Repository = Repository;
        }

       

       
    }
}
