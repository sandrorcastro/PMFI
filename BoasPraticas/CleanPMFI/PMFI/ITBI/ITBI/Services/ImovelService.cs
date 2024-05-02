using ITBI.Context;
using ITBI.Entities.DBProsiga;
using Microsoft.EntityFrameworkCore;

namespace ITBI.Services
{
    public class ImovelService : IImovelService
    {
        private IDbContextFactory<DbprosigaContext> dbContextFactory;

        public ImovelService(IDbContextFactory<DbprosigaContext> _dbContextFactory)
        {
            this.dbContextFactory = _dbContextFactory;
        }

        public async Task<TribEdificaco> GetImovel(string? inscricaoimobiliaria)
        {
            var contexto = dbContextFactory.CreateDbContext();

            var imovel = await contexto.TribEdificacoes.Include(t => t.Terreno)
                                                           .Include(l => l.Lograd)
                                                           .Include(l => l.IdloteamentoNavigation)
                                                           .Include(c => c.TribEdificacoesContribs).ThenInclude(x => x.Con).AsQueryable()
                                                           .FirstOrDefaultAsync(c => c.InscricaoImobiliaria == inscricaoimobiliaria.PadLeft(14,'0'));
            /*  if (imovel == null)
              {
                  throw new EntityNotFoundException($"Imovel com inscrição {inscricaoimobiliaria} não encontrado.");
              }*/

            //return imovel; // ?? new TribEdificaco();
            return imovel ?? null;

            // throw new NotImplementedException();
        }

        public async Task<IQueryable<TribEdificaco>> GetImovelQueryable(string? inscricaoimobiliaria)
        {
            //var inscricaoimobiliaria = "";
            var contexto = dbContextFactory.CreateDbContext();

            var imovel = contexto.TribEdificacoes.Where(c => c.InscricaoImobiliaria ==  inscricaoimobiliaria.PadLeft(14,'0'))
                                                           .Include(t => t.Terreno)
                                                           .Include(l => l.Lograd)
                                                           .Include(l => l.IdloteamentoNavigation)
                                                           .Include(c => c.TribEdificacoesContribs).ThenInclude(x => x.Con).AsQueryable()
                                                           .AsQueryable<TribEdificaco>();
                                        //                  .AsQueryable(); // wFirstOrDefaultAsync(c => c.ConCnpjcpf == cpfcnpj) ;
            //if (imovel == null)
            //{
              //  throw new EntityNotFoundException($"Imovel com CPF/CNPJ {inscricaoimobiliaria} não encontrado.");
            //}

            return imovel; // ?? new Imovel();

            //throw new NotImplementedException();
        }

        public async Task<List<TribEdificaco>> GetImoveis()
        {
            var contexto = dbContextFactory.CreateDbContext();
            return await contexto.TribEdificacoes.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<IQueryable<TribEdificaco>> GetImoveisQueryable()
        {
            var contexto = dbContextFactory.CreateDbContext();
            return contexto.TribEdificacoes.AsQueryable();    //.AsQueryable<Imovel>();
            //throw new NotImplementedException();
        }

      
    }
}

