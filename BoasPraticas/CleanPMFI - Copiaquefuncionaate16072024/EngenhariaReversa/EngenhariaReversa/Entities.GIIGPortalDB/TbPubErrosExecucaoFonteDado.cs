using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGPortalDB
{
    public partial class TbPubErrosExecucaoFonteDado
    {
        public int IdErro { get; set; }
        public int IdFonteDados { get; set; }
        public DateTime? DtExecucao { get; set; }
        public string? DsErro { get; set; }
    }
}
