using Fiscalizacao.Context;
using Fiscalizacao.Model;
using Microsoft.EntityFrameworkCore;

namespace Fiscalizacao.Model
{
    public class ImovelService
    {
       
        private readonly ImoveisDBContext _dbContext;

        public ImovelService(ImoveisDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Imovel>> GetImovelAsync()
        {
            return _dbContext.Imoveis.Take(10).ToListAsync();
        }
    }
}