using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribAgrupamento
    {
        public TribAgrupamento()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int AgrupaId { get; set; }
        public string? AgrupaNome { get; set; }
        public decimal? AgrupaFator { get; set; }
        public int? AgrupaPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
