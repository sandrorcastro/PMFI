using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribPedologium
    {
        public TribPedologium()
        {
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int PedoId { get; set; }
        public string? PedoNome { get; set; }
        public decimal? PedoFator { get; set; }
        public int PedoPontos { get; set; }

        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
