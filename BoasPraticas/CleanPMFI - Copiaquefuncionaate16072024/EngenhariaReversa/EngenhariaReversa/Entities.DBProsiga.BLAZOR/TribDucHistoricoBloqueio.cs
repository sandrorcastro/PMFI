using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribDucHistoricoBloqueio
    {
        public long IdHistorico { get; set; }
        public long? ConId { get; set; }
        public string? TpSituacao { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsUsuario { get; set; }
    }
}
