using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ProdRurAtividadeRural
    {
        public ProdRurAtividadeRural()
        {
            ProdRurProdutosRurais = new HashSet<ProdRurProdutosRurai>();
        }

        public int IdativRural { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<ProdRurProdutosRurai> ProdRurProdutosRurais { get; set; }
    }
}
