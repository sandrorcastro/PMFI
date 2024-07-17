using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribLocalizacaoQuadra
    {
        public TribLocalizacaoQuadra()
        {
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int LocQid { get; set; }
        public string? LocQnome { get; set; }
        public decimal? LocQfator { get; set; }
        public int LocQpontos { get; set; }

        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
