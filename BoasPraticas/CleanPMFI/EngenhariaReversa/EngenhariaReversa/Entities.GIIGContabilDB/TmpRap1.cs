using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmpRap1
    {
        public int IdEmpenho { get; set; }
        public short? NrEmpenho { get; set; }
        public short? NrAno { get; set; }
        public decimal? VlSaldoProcessado { get; set; }
        public decimal? VlSaldoNaoProcessado { get; set; }
        public decimal? VlProcessadoEmLiquidacao { get; set; }
    }
}
