using Microsoft.EntityFrameworkCore;
using FiscalMobile.Models;
using FiscalMobile.Utilidades;

namespace FiscalMobile.Context
{
    public class VistoriaDBContext :DbContext
    {
        public DbSet<Vistoria> Vistorias { get; set; }
      //  public DbSet<ImovelCheck> ImoveisCheck { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            string conexaoDB = $"Filename={ConexaoDB.GetRotaConexao("VistoriaInLoco.db")}";
            optionsBuilder.UseSqlite(conexaoDB);
        }
    }
}
