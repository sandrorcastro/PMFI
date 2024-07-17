using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribTiposBaseCalculoTributo
    {
        public int TipoTribId { get; set; }
        public int Tcid { get; set; }
        public decimal? Tctde { get; set; }
        public decimal? Tctate { get; set; }
        public decimal? TctqtdeUf { get; set; }

        public virtual TribTiposBaseCalculo Tc { get; set; } = null!;
    }
}
