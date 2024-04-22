using System;
using System.Collections.Generic;

namespace RP.SMF.Blazor.DBProsiga
{
    public partial class TribTapMapaOld
    {
        public long TapMapaId { get; set; }
        public short? TapParcela { get; set; }
        public int? TipoTribId { get; set; }
        public decimal? TapVlOriginal { get; set; }
        public decimal? TapVlPrincipal { get; set; }
        public decimal? TapVlJuros { get; set; }
        public decimal? TapVlMulta { get; set; }
        public decimal? TapVlMultaDa { get; set; }
        public decimal? TapVlCorrecao { get; set; }
        public decimal? TapVlDesconto { get; set; }
        public decimal? TapVlJurosParc { get; set; }
        public decimal? TapVlAcrescimo { get; set; }
        public string? TapParcelaPaga { get; set; }
        public long? ImoIddivida { get; set; }
        public long? ConIddivida { get; set; }
        public long? EmpIddivida { get; set; }
        public long? TapId { get; set; }
        public DateTime? DataBaixa { get; set; }
        public string? TapSituacao { get; set; }
        public decimal? TapValorPagamentoParcial { get; set; }
        public string? TapPagamentoParcial { get; set; }
        public decimal? JurosTap { get; set; }
        public decimal? MultaTap { get; set; }
        public decimal? CorrecaoTap { get; set; }
        public decimal? MultaDaTap { get; set; }
        public decimal? DescontoTap { get; set; }
    }
}
