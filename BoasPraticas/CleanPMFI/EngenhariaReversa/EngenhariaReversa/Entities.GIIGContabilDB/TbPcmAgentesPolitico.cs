using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPcmAgentesPolitico
    {
        public int IdAgente { get; set; }
        public string? CdCargao { get; set; }
        public string? CdpfAgente { get; set; }
        public string? NmAgente { get; set; }
        public string DsNotaExplicativa { get; set; } = null!;

        public virtual TbPcmRemuneracaoAgentesPolitico? TbPcmRemuneracaoAgentesPolitico { get; set; }
    }
}
