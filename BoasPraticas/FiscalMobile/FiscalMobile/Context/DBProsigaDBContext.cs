using Microsoft.EntityFrameworkCore;
using FiscalMobile.Models;
using FiscalMobile.Utilidades;

namespace FiscalMobile.Context
{
    public class DBProsigaDBContext : DbContext
    {
        
        //public DbSet<TribEdificacoes> ImoveisCheck { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            string conexaoDB = $"Filename={ConexaoDB.GetRotaConexao("ImovelCheckInLoco.db")}";
            optionsBuilder.UseSqlite(conexaoDB);
        }
    }
}
