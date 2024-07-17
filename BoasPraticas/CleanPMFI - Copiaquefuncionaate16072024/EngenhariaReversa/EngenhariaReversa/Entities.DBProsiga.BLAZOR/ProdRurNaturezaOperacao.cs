using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class ProdRurNaturezaOperacao
    {
        public ProdRurNaturezaOperacao()
        {
            ProdRurNotaFiscals = new HashSet<ProdRurNotaFiscal>();
        }

        public int IdnatOperacao { get; set; }
        public string? Nome { get; set; }

        public virtual ICollection<ProdRurNotaFiscal> ProdRurNotaFiscals { get; set; }
    }
}
