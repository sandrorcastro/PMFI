using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribAcabamentoExterno
    {
        public TribAcabamentoExterno()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int AcabExtId { get; set; }
        public string? AcabExtNome { get; set; }
        public decimal? AcabExtFator { get; set; }
        public int? AcabExtPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
