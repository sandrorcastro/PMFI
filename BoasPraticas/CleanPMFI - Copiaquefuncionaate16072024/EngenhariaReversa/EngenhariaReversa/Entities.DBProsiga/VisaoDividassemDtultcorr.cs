using System;
using System.Collections.Generic;

namespace EngenhariaReversa.Entities.DBProsiga
{
    public partial class VisaoDividassemDtultcorr
    {
        public long? EmprCmc { get; set; }
        public int? EmprDivAno { get; set; }
        public int? EmprDivMes { get; set; }
        public DateTime? EmprDivVencimento { get; set; }
        public DateTime? EmprDivDataUltCorrecao { get; set; }
        public decimal? EmprDivVlrUltCorrecao { get; set; }
        public int? TipoTribId { get; set; }
    }
}
