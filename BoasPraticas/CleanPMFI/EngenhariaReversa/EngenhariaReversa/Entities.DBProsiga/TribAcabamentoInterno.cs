using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAcabamentoInterno
    {
        public TribAcabamentoInterno()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int AcabIntId { get; set; }
        public string? AcabIntNome { get; set; }
        public decimal? AcabIntFator { get; set; }
        public int? AcabIntPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
