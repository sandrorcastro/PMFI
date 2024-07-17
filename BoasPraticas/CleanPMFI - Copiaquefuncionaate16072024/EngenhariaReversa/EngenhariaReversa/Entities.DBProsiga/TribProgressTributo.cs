using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class TribProgressTributo
    {
        public int PrgTribId { get; set; }
        public string? PrgTribDescricao { get; set; }
        public int? TipoTribId { get; set; }
        public decimal? PrgTribDe { get; set; }
        public decimal? PrgTribAte { get; set; }
        public decimal? PrgTribPercentual { get; set; }
    }
}
