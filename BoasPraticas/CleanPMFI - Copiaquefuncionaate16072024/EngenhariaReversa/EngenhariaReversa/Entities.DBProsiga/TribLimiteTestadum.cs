using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribLimiteTestadum
    {
        public TribLimiteTestadum()
        {
            TribTerrenos = new HashSet<TribTerreno>();
        }

        public int LimTid { get; set; }
        public string? LimTnome { get; set; }
        public decimal? LimTfator { get; set; }
        public int LimTpontos { get; set; }

        public virtual ICollection<TribTerreno> TribTerrenos { get; set; }
    }
}
