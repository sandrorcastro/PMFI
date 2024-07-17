using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribFatorK
    {
        public TribFatorK()
        {
            TribQuadraLograds = new HashSet<TribQuadraLograd>();
        }

        public long FatorKid { get; set; }
        public string? FatorKnome { get; set; }
        public decimal? FatorKvalor { get; set; }

        public virtual ICollection<TribQuadraLograd> TribQuadraLograds { get; set; }
    }
}
