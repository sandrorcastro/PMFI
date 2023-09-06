using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbFinContasContabeisCorrelacao
    {
        public short IdEmpresa { get; set; }
        public short NrAno { get; set; }
        public string CdContaContabil { get; set; } = null!;
        public string? CdContaContabilAnoSeguinte { get; set; }
    }
}
