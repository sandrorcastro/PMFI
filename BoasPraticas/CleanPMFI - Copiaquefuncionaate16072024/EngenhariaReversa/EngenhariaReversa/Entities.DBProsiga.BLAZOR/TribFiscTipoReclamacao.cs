using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribFiscTipoReclamacao
    {
        public int TipoRecId { get; set; }
        public string? TipoRecNome { get; set; }
        public int? TipoFiscalId { get; set; }

        public virtual TribFiscTipoFiscal? TipoFiscal { get; set; }
    }
}
