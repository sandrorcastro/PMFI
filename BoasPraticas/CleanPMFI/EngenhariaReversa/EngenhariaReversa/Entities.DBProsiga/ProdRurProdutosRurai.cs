using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ProdRurProdutosRurai
    {
        public ProdRurProdutosRurai()
        {
            ProdRurNotaFiscalItens = new HashSet<ProdRurNotaFiscalIten>();
            ProdRurProducaos = new HashSet<ProdRurProducao>();
        }

        public int IdprodRural { get; set; }
        public string? Nome { get; set; }
        public int? IdativRural { get; set; }

        public virtual ProdRurAtividadeRural? IdativRuralNavigation { get; set; }
        public virtual ICollection<ProdRurNotaFiscalIten> ProdRurNotaFiscalItens { get; set; }
        public virtual ICollection<ProdRurProducao> ProdRurProducaos { get; set; }
    }
}
