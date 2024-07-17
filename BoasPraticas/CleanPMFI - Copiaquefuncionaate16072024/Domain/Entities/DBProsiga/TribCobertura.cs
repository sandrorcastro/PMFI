using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribCobertura
    {
        public TribCobertura()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int CobertId { get; set; }
        public string? CobertNome { get; set; }
        public decimal? CobertFator { get; set; }
        public int? CobertPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
