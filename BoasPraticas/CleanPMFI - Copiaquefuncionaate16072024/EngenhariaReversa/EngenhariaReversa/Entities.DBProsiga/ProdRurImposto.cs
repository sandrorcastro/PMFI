using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class ProdRurImposto
    {
        public ProdRurImposto()
        {
            ProdRurNotaFiscalItens = new HashSet<ProdRurNotaFiscalIten>();
        }

        public int Idimposto { get; set; }
        public string? Nome { get; set; }
        public decimal? AliquotaPadrao { get; set; }

        public virtual ICollection<ProdRurNotaFiscalIten> ProdRurNotaFiscalItens { get; set; }
    }
}
