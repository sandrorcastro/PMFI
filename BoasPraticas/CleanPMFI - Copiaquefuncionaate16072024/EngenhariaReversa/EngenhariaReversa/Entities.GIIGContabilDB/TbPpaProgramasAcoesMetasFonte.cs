using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TbPpaProgramasAcoesMetasFonte
    {
        public int IdAcao { get; set; }
        public short NrAno { get; set; }
        public string CdFonte { get; set; } = null!;
        public decimal? VlEstimado { get; set; }
    }
}
