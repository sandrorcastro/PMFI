using Fiscalizacao.Context;
using Fiscalizacao.Data;
using Fiscalizacao.Model;
using Microsoft.EntityFrameworkCore;

namespace Fiscalizacao.Model
{
    public class ImovelService
    {
       
        private readonly ImoveisDBContext _dbContext;
        private readonly ImovelDatabase _imovelDatabase;
        public ImovelService(ImoveisDBContext dbContext, ImovelDatabase imovelDatabase)
        {
            _dbContext = dbContext;
            _imovelDatabase = imovelDatabase;
        }

        public Task<List<Imovel>> GetImovelAsync()
        {
            return _dbContext.Imoveis.Take(10).ToListAsync();
            //return _imovelDatabase.GetImoveisAsync();
        }
    }
}