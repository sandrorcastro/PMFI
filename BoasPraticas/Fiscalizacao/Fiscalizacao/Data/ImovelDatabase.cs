using Fiscalizacao.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiscalizacao.Data
{
    public class ImovelDatabase
    {
        SQLiteAsyncConnection Database;

        public ImovelDatabase()
        {
        }

        async Task Init()
        {
            if (Database is not null)
                return;

            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
            var result = await Database.CreateTableAsync<Imovel>();
        }

        public async Task<List<Imovel>> GetImoveisAsync()
        {
            await Init();
            return await Database.Table<Imovel>().Take(10).ToListAsync();
        }
        /*
        public async Task<List<Imovel>> GetImoveisNotDoneAsync()
        {
            await Init();
            return await Database.Table<Imovel>().Where(t => t.Done).ToListAsync();

            // SQL queries are also possible
            //return await Database.QueryAsync<Imovel>("SELECT * FROM [Imovel] WHERE [Done] = 0");
        }*/

        public async Task<Imovel> GetImovelAsync(long inscricao)
        {
            await Init();
            return await Database.Table<Imovel>().Where(i => i.InscricaoImobiliaria == inscricao).FirstOrDefaultAsync();
        }

        public async Task<int> SaveImovelAsync(Imovel imovel)
        {
            await Init();
            if (imovel.InscricaoImobiliaria != 0)
                return await Database.UpdateAsync(imovel);
            else
                return await Database.InsertAsync(imovel);
        }

        public async Task<int> DeleteImovelAsync(Imovel imovel)
        {
            await Init();
            return await Database.DeleteAsync(imovel);
        }














    }
}
