using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribDividasBloqueio
    {
        public int IdBloqueio { get; set; }
        public DateTime? DtBloqueio { get; set; }
        /// <summary>
        /// Código de identificação da dívida.
        /// </summary>
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }
        public string? DsMotivo { get; set; }
        public DateTime? DtVelhoVencimento { get; set; }
        public DateTime? DtNovoVencimento { get; set; }
        public DateTime? DtBloqueioCorrecao { get; set; }
        public DateTime? DtBloqueioJuros { get; set; }
        public DateTime? DtBloqueioMulta { get; set; }
        public DateTime? DtBloqueioMda { get; set; }
        public DateTime? DtBaseCorrecao { get; set; }
        public DateTime? DtInclusao { get; set; }
        public string? DsLogin { get; set; }
        public bool? FlCancelado { get; set; }
        public string? DsMotivoCancelamento { get; set; }
        public string? TpOperacao { get; set; }
    }
}
