using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribProgressaoBonificacao
    {
        public int ProgresBonifId { get; set; }
        public int? ProgresBonifDe { get; set; }
        public int? ProgresBonifAte { get; set; }
        public decimal? ProgresBonifPerc { get; set; }
        public short? ProgresBonifVigenciaDe { get; set; }
        public short? ProgresBonifVigenciaAte { get; set; }
    }
}
