using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribIncidencium
    {
        public TribIncidencium()
        {
            TribEdificacos = new HashSet<TribEdificaco>();
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int InciId { get; set; }
        public string? InciNome { get; set; }
        public decimal? InciFator { get; set; }
        public int InciPontos { get; set; }

        public virtual ICollection<TribEdificaco> TribEdificacos { get; set; }
        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
