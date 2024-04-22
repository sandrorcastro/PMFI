using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribVegetacao
    {
        public TribVegetacao()
        {
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int VegeId { get; set; }
        public string? VegeNome { get; set; }
        public decimal? VegeFator { get; set; }
        public int VegePontos { get; set; }

        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
