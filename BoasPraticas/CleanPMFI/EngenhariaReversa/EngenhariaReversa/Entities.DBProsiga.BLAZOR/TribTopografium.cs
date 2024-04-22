using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribTopografium
    {
        public TribTopografium()
        {
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int TopoId { get; set; }
        public string? TopoNome { get; set; }
        public decimal? TopoFator { get; set; }
        public int TopoPontos { get; set; }

        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
