using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribUtilizacao
    {
        public TribUtilizacao()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
        }

        public int UtilizId { get; set; }
        public string? UtilizNome { get; set; }
        public decimal? UtilizFator { get; set; }
        public int? UtilizPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
    }
}
