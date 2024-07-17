using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribParede
    {
        public TribParede()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int ParedeId { get; set; }
        public string? ParedeNome { get; set; }
        public decimal? ParedeFator { get; set; }
        public int? ParedePontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
