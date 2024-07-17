using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.GIIGContabilDB
{
    public partial class XtbSaldoExercicioAnteriorRealizavel
    {
        public int IdSaldo { get; set; }
        public int? IdPessoa { get; set; }
        public short? NrOperacao { get; set; }
        public short? NrAnoOperacao { get; set; }
        public string? CdFonte { get; set; }
        public string? CdContaContabil { get; set; }
        public short? NrAno { get; set; }
        public decimal? VlLancamento { get; set; }
        public string? TpLancamento { get; set; }
    }
}
