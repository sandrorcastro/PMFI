using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.NFSEDB
{
    public partial class ViewDividasGeradasVencimentoErrado
    {
        public string? Cmc { get; set; }
        public string? Contribuinte { get; set; }
        public int CodDecl { get; set; }
        public byte ComptMes { get; set; }
        public short CompAno { get; set; }
        public DateTime DtLancamento { get; set; }
        public DateTime? DtVencNfse { get; set; }
        public DateTime? DtVencTribuno { get; set; }
        public string TpRecolhimento { get; set; } = null!;
        public int? CodDivida { get; set; }
        public decimal VlDivida { get; set; }
        public decimal VlPago { get; set; }
        public DateTime? DtBaixa { get; set; }
    }
}
