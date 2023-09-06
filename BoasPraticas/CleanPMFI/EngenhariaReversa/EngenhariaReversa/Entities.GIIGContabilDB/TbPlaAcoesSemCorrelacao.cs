using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPlaAcoesSemCorrelacao
    {
        public int IdSemCorrelacao { get; set; }
        public int IdAcao { get; set; }
        public int? NrSequencia { get; set; }
        public string? TpControle { get; set; }
        public short? NrAno { get; set; }
        public string? DsNotaExplicativa { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }

        public virtual TbPlaAco IdAcaoNavigation { get; set; } = null!;
    }
}
