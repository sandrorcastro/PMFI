using System;
using System.Collections.Generic;

namespace Domain.Entities.DBProsiga
{
    public partial class TribFiscTipoNotaFiscal
    {
        public short TipoNfid { get; set; }
        public string? TipoNfdescricao { get; set; }
        public string? TipoNfresumido { get; set; }
    }
}
