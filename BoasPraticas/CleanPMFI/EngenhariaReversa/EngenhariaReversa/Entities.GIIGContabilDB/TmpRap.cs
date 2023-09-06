using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class TmpRap
    {
        public int Idempenho { get; set; }
        public short? Nrempenho { get; set; }
        public short? Nrano { get; set; }
        public string? Cdnatdespesa { get; set; }
        public string? ContaInscricao { get; set; }
        public decimal? InscritoProcessado { get; set; }
        public decimal? SaldoContaLiquidado { get; set; }
        public decimal VlInscrito2013 { get; set; }
        public decimal VlInscrito2014 { get; set; }
    }
}
