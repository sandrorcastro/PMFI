using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribCalcadum
    {
        public TribCalcadum()
        {
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int CalcaId { get; set; }
        public string? CalcaNome { get; set; }
        public decimal? CalcaFator { get; set; }
        public int CalcaPontos { get; set; }

        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
