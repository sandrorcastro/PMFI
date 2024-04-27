using ITBI.Context;
using ITBI.Entities.DBProsiga;
using Microsoft.EntityFrameworkCore;

namespace ITBI.Services
{
    public class ContribuinteService : IContribuinteService
    {
        private IDbContextFactory<DbprosigaContext> dbContextFactory;

        public ContribuinteService(IDbContextFactory<DbprosigaContext> _dbContextFactory)
        {
            this.dbContextFactory = _dbContextFactory;
        }

        public async Task<Contribuinte> AddContribuinte(Contribuinte contribuinte)
        {
            var contexto = dbContextFactory.CreateDbContext();

            if (contribuinte is null)
                throw new ArgumentNullException(nameof(contribuinte));

            contexto.Add(contribuinte);
            await contexto.SaveChangesAsync();
            return contribuinte;
            //throw new NotImplementedException();
        }

        public async Task<Contribuinte> GetContribuinte(string? cpfcnpj)
        {
            var contexto = dbContextFactory.CreateDbContext();

            //var contribuinte = await contexto.Contribuintes.FirstOrDefaultAsync(c => c.ConCnpjcpf == cpfcnpj);
            var contribuinte = await contexto.Contribuintes.Where(c => c.ConCnpjcpf == cpfcnpj).Include(i=>i.ConBairro).Include(i=>i.ConCidade).ThenInclude(i=>i.Pais).FirstOrDefaultAsync();
            /*   if (contribuinte == null)
               {
                   throw new EntityNotFoundException($"Contribuinte com CPF/CNPJ {cpfcnpj} não encontrado.");
               }*/

            return contribuinte ?? null; // new Contribuinte();

           // throw new NotImplementedException();
        }

        public async  Task<IQueryable<Contribuinte>> GetContribuinteQueryable(string? cpfcnpj)
        {
            var contexto = dbContextFactory.CreateDbContext();

            var contribuinte = contexto.Contribuintes.Where(c => c.ConCnpjcpf == cpfcnpj).AsQueryable(); // wFirstOrDefaultAsync(c => c.ConCnpjcpf == cpfcnpj) ;
            if (contribuinte == null)
            {
                throw new EntityNotFoundException($"Contribuinte com CPF/CNPJ {cpfcnpj} não encontrado.");
            }

            return contribuinte; // ?? new Contribuinte();

            //throw new NotImplementedException();
        }

        public async Task<List<Contribuinte>> GetContribuintes()
        {
            var contexto = dbContextFactory.CreateDbContext();
            return await contexto.Contribuintes.ToListAsync();
            //throw new NotImplementedException();
        }

        public async Task<IQueryable<Contribuinte>> GetContribuintesQueryable()
        {
            var contexto = dbContextFactory.CreateDbContext();
            return  contexto.Contribuintes.AsQueryable();    //.AsQueryable<Contribuinte>();
            //throw new NotImplementedException();
        }

        public async Task<Contribuinte> UpdateContribuinte(Contribuinte contribuinte)
        {
            var contexto = dbContextFactory.CreateDbContext();
            if (contribuinte is null)
                throw new ArgumentNullException(nameof(contribuinte));

            //_context.Update(aluno);
            //await _context.SaveChangesAsync();
            //return aluno;

            contexto.Entry(contribuinte).State = EntityState.Modified;
            await contexto.SaveChangesAsync();

            return contribuinte;
           // throw new NotImplementedException();
        }
    }
}
