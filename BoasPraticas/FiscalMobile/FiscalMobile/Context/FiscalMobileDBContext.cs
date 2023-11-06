using Microsoft.EntityFrameworkCore;
using FiscalMobile.Models;
using FiscalMobile.Utilidades;

namespace FiscalMobile.Context
{
    public class FiscalMobileDBContext :DbContext
    {
        public DbSet<Vistoria> Vistoria { get; set; }
        public DbSet<ImovelCheck> ImovelCheck { get; set; }
        public DbSet<PerfilApp> PerfilApp { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            string conexaoDB = $"Filename={ConexaoDB.GetRotaConexao("FiscalMobileDB.db")}";
            optionsBuilder.UseSqlite(conexaoDB);
        }
    }
}
