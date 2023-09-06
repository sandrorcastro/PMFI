using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribForro
    {
        public TribForro()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int ForroId { get; set; }
        public string? ForroNome { get; set; }
        public decimal? ForroFator { get; set; }
        public int? ForroPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
