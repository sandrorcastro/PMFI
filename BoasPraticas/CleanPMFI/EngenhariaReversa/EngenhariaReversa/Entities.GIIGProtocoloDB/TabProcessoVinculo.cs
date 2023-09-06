using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGProtocoloDB
{
    public partial class TabProcessoVinculo
    {
        public long? IdProcPrincipal { get; set; }
        public long? IdProcVinculado { get; set; }
        public string? DsLogin { get; set; }
        public DateTime? DtVinculo { get; set; }
        public string? DsStatus { get; set; }
    }
}
