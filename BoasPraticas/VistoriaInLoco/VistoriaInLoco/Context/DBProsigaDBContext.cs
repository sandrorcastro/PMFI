using Microsoft.EntityFrameworkCore;
using VistoriaInLoco.Models;
using VistoriaInLoco.Utilidades;

namespace VistoriaInLoco.Context
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
