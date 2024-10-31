using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribPatrimonio
    {
        public TribPatrimonio()
        {
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int PatrId { get; set; }
        public string? PatrNome { get; set; }
        public decimal? PatrFator { get; set; }
        public int PatrPontos { get; set; }

        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
