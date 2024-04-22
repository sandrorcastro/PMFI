using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class SaudeTipoExame
    {
        public int TipoExameId { get; set; }
        public string? TipoExameNome { get; set; }
        public int? TipoExameValidDias { get; set; }
        public string? TipoExameProced { get; set; }
    }
}
